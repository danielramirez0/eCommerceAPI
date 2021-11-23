# Electronics Ecommerce API

Uses ASP.NET Core to handle requests from React based front end.

## Endpoints

root/api

- /authentication
  - POST: user registration
- /authentication/login
    - POST: jwt token retrieval and user registration
- /addresses
  - POST: add address
- /addresses?type=shipping(or billing)
  - GET: get shipping or billing for user (protected)
- /products
  - GET: list all products
- /products?category=value
  - GET: products by speific category
- /products?name=value
  - GET: products by speific name
- /products/id
  - GET: product by ID
- /products/id/reviews
  - GET: reviews for specific product
  - POST: submit review for spefic product
- /shoppingcart
  - GET: shopping cart products for user
  - POST: add product to shopping cart for user
- /orders
  - POST: add order to database (protected:user)
- /orders/all
  - GET: get all orders (protected:admin)
- /orders/products/id
  - GET: orders for specific products
- /orders/users/id
  - GET: get all order for user id
- /orders/detail/id
  - GET: detail for specific order

## Technologies

MSSQL Server, ASP.NET Core Web API, Entity Framework

## Models and ERD

[text](https://link)

