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
- /addresses?type={shipping/billing}
  - GET: get shipping or billing for user (protected)
- /products
  - GET: list all products
  - POST: add a product {send product}
- /product/category/{category}
  - GET: products by speific category
- /product/name/{name}
  - GET: products by speific name
- /products/{id}
  - GET: product by ID
  - DELETE: delete a product 
- /products/reviews/{id}
  - GET: reviews for specific product
  - POST: submit review for spefic product
- /shoppingcart
  - GET: shopping cart products for user
  - POST: add product to shopping cart for user
  - PUT: update item in shopping cart
  - DELETE: remove item from shopping cart
- /order
  - POST: add order to database (protected:user)
- /order/all
  - GET: get all orders (protected:admin)
- /order/product/{id}
  - GET: orders for specific products
- /order/user
  - GET: get all order for user
- /order/detail/{id}
  - GET: detail for specific order

## Technologies

MSSQL Server, ASP.NET Core Web API, Entity Framework

## Models and ERD

[text](https://link)

