using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Product.Api.Tests.Acceptance.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Product.Api.Tests.Acceptance.StepDefinitions
{
    [Binding]
    public class ProductManagementSteps
    {
        private readonly HttpClient _httpClient;
        private readonly ScenarioContext _scenarioContext;

        public ProductManagementSteps(HttpClient httpClient, ScenarioContext scenarioContext)
        {
            _httpClient = httpClient;
            _scenarioContext = scenarioContext;
        }

        [When(@"I create products with the following details")]
        public async Task WhenICreateProductsWithTheFollowingDetails(Table table)
        {
            var createProductRequests = table.CreateSet<CreateProductRequest>();
            var createdProducts = new List<ProductResponse>();
            foreach (var createProductRequest in createProductRequests)
            {
                var response = await _httpClient.PostAsJsonAsync("products", createProductRequest);
                var responseProduct = await response.Content.ReadFromJsonAsync<ProductResponse>();
                createdProducts.Add(responseProduct);
            }
            _scenarioContext.Add("CreatedProducts", createdProducts);
        }

        [Then(@"the products are created successfully")]
        public async Task ThenTheProductsAreCreatedSuccessfully()
        {
            var createdProducts = _scenarioContext.Get<List<ProductResponse>>("CreatedProducts");
            foreach (var createdProduct in createdProducts)
            {
                var response = await _httpClient.GetFromJsonAsync<ProductResponse>($"products/{createdProduct.Id}");
                createdProduct.Should().BeEquivalentTo(response);
            }
        }

        [Given(@"the following products in the system")]
        public async Task GivenTheFollowingProductsInTheSystem(Table table)
        {
            var products = table.CreateSet<CreateProductRequest>();
            var createdProductsIds = new List<Guid>();
            foreach (var createProductRequest in products)
            {
                var response = await _httpClient.PostAsJsonAsync("products", createProductRequest);
                var responseProduct = await response.Content.ReadFromJsonAsync<ProductResponse>();
                Console.WriteLine(createdProductsIds);
                createdProductsIds.Add(responseProduct!.Id);
            }
            _scenarioContext.Add("CreatedProductIds", createdProductsIds);
        }

        [When(@"those products get deleted")]
        public async Task WhenThoseProductsGetDeleted()
        {
            var createdProductsIds = _scenarioContext.Get<List<Guid>>("CreatedProductIds");
            foreach (var createdProductsId in createdProductsIds)
            {
                await _httpClient.DeleteAsync($"products/{createdProductsId}");
            }
        }

        [Then(@"the products are deleted successfully")]
        public async Task ThenTheProductsAreDeletedSuccessfully()
        {
            var createdProductsIds = _scenarioContext.Get<List<Guid>>("CreatedProductIds");
            foreach (var createdProductsId in createdProductsIds)
            {
                var productResponse = await _httpClient.GetAsync($"products/{createdProductsId}");
                productResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
            }
        }
    }
}
