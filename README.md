# Delegates

# Shopping System Documentation

This repository contains a simple shopping system implementation with a focus on utilizing delegates, interfaces, and polymorphism. It showcases different user types, product management, and discount calculation.

## Classes Overview

### `ProductModel`

Represents a product in the shopping cart with two properties:
- `ProductName`: The name of the product
- `Price`: The price of the product

### `ShoppingCartModel`

Represents the shopping cart with the following property:
- `Products`: A list of products in the cart

Methods:
- `GetFinalPrice(delegate finalPrice, delegate caculateTotalPrice, delegate printDiscountAmount)`: Calculates the final discounted price using the provided delegates.

### `NormalUser`

Represents a regular user with properties:
- `Name`: User's name
- `ShoppingCart`: User's shopping cart

Methods:
- `Dlg_GetDiscountePrice()`: Calculates the discount based on the number of products in the cart. Applies a 30% discount if the number of products is more than 5.

### `GoldenUser`

Represents a golden user with properties:
- `Name`: User's name
- `ShoppingCart`: User's shopping cart

Methods:
- `Dlg_GetDiscountePrice()`: Applies a fixed 30% discount on the total purchase amount.

### `Program`

The main class responsible for program execution. It includes the following methods:
- `fillShoppingCart()`: Fills the shopping carts with various products.
- `Dlg_calculateTotal()`: Calculates the total price of products.
- `Dlg_printDiscountAmount()`: Displays the discount amount.
- `Main()`: Creates instances of NormalUser and GoldenUser, fills their shopping carts, calculates final prices using the `GetFinalPrice` method from `ShoppingCartModel`, and displays the results.

## Dependencies

- `NormalUser` and `GoldenUser` depend on the `IUser` interface, implementing properties `Name` and `ShoppingCart`.
- `ShoppingCartModel` depends on `ProductModel`, `NormalUser`, and `GoldenUser` classes for product and user information.

This project demonstrates the use of delegates to execute code paths based on different conditions, and it employs interfaces and polymorphism to model different user types for flexibility and extensibility.
