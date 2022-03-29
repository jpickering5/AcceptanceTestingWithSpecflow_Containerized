﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.7.0.0
//      SpecFlow Generator Version:3.7.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Product.Api.Tests.Acceptance.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ManageProductsInTheSystemFeature : object, Xunit.IClassFixture<ManageProductsInTheSystemFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ProductManagement.feature"
#line hidden
        
        public ManageProductsInTheSystemFeature(ManageProductsInTheSystemFeature.FixtureData fixtureData, Product_Api_Tests_Acceptance_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Manage products in the system", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Products get created successfully")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage products in the system")]
        [Xunit.TraitAttribute("Description", "Products get created successfully")]
        public virtual void ProductsGetCreatedSuccessfully()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Products get created successfully", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 3
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Description",
                            "Price",
                            "RRP",
                            "CurrencyIsoCode",
                            "Category"});
                table1.AddRow(new string[] {
                            "Hoodie",
                            "WEX Hoodie",
                            "20.99",
                            "20.99",
                            "USD",
                            "Clothing"});
                table1.AddRow(new string[] {
                            "T-Shirt",
                            "WEX t-shirt",
                            "18.99",
                            "18.99",
                            "USD",
                            "Clothing"});
                table1.AddRow(new string[] {
                            "Fleece",
                            "WEX fleece",
                            "19.99",
                            "19.99",
                            "USD",
                            "Clothing"});
#line 4
    testRunner.When("I create products with the following details", ((string)(null)), table1, "When ");
#line hidden
#line 9
    testRunner.Then("the products are created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Products get deleted successfully")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage products in the system")]
        [Xunit.TraitAttribute("Description", "Products get deleted successfully")]
        public virtual void ProductsGetDeletedSuccessfully()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Products get deleted successfully", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 11
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Description",
                            "Price",
                            "RRP",
                            "CurrencyIsoCode",
                            "Category"});
                table2.AddRow(new string[] {
                            "Hoodie",
                            "WEX Hoodie",
                            "20.99",
                            "20.99",
                            "USD",
                            "Clothing"});
                table2.AddRow(new string[] {
                            "T-Shirt",
                            "WEX t-shirt",
                            "18.99",
                            "18.99",
                            "USD",
                            "Clothing"});
                table2.AddRow(new string[] {
                            "Fleece",
                            "WEX fleece",
                            "19.99",
                            "19.99",
                            "USD",
                            "Clothing"});
#line 12
    testRunner.Given("the following products in the system", ((string)(null)), table2, "Given ");
#line hidden
#line 17
    testRunner.When("those products get deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
    testRunner.Then("the products are deleted successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ManageProductsInTheSystemFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ManageProductsInTheSystemFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
