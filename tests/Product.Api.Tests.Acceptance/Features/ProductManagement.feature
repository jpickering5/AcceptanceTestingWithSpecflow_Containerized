Feature: Manage products in the system

  Scenario: Products get created successfully
    When I create products with the following details
      | Name    | Description         | Price | RRP   | CurrencyIsoCode | Category |
      | Hoodie  | WEX Hoodie          | 20.99 | 20.99 | USD             | Clothing |
      | T-Shirt | WEX t-shirt         | 18.99 | 18.99 | USD             | Clothing |
      | Fleece  | WEX fleece          | 19.99 | 19.99 | USD             | Clothing |
    Then the products are created successfully

  Scenario: Products get deleted successfully
    Given the following products in the system
      | Name    | Description         | Price | RRP   | CurrencyIsoCode | Category |
      | Hoodie  | WEX Hoodie          | 20.99 | 20.99 | USD             | Clothing |
      | T-Shirt | WEX t-shirt         | 18.99 | 18.99 | USD             | Clothing |
      | Fleece  | WEX fleece          | 19.99 | 19.99 | USD             | Clothing |
    When those products get deleted
    Then the products are deleted successfully
