# Delegates

# Shopping Cart Application

This is a simple shopping cart application that demonstrates the use of delegates, interfaces, and polymorphism in C#. It includes classes for modeling products, users, and shopping carts, along with a program to showcase their interactions.

## Classes

### ProductModel

Represents a product in the shopping cart with properties:
- `ProductName`: The name of the product
- `Price`: The price of the product

### ShoppingCartModel

Represents a shopping cart with the following properties:
- `Products`: A list of products in the shopping cart

Methods:
- `GetFinalPrice`: Calculates the final discounted price using delegates:
  - `finalPrice`: Delegate to calculate overall discount based on user type
  - `caculateTotalPrice`: Delegate to calculate the total price of products
  - `printDiscountAmount`: Delegate to display the discount amount

### NormalUser

Represents a normal user with properties:
- `Name`: User's name
- `ShoppingCart`: User's shopping cart

Method:
- `Dlg_GetDiscountePrice`: Calculates discount based on the number of products in the cart. Applies a 30% discount if the number of products is more than 5.

### GoldenUser

Represents a golden user with properties:
- `Name`: User's name
- `ShoppingCart`: User's shopping cart

Method:
- `Dlg_GetDiscountePrice`: Applies a fixed 30% discount on the total purchase amount.

### Program

Main class responsible for:
- Filling shopping carts with products
- Calculating total prices
- Printing discount information
- Creating instances of normal and golden users, populating their carts, and calculating final discounted prices using delegates.

## Dependencies

- NormalUser and GoldenUser depend on IUser interface for properties `Name` and `ShoppingCart`.
- ShoppingCartModel depends on ProductModel, NormalUser, and GoldenUser for calculations.

This application showcases the use of delegates to execute code that varies based on different conditions. It also uses interfaces and polymorphism to model different types of users for flexibility and extensibility.

Feel free to explore the code and run the program!

/////////////////////////////////////////////////////

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
