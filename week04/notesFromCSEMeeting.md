# Assignment 1
## What does the program do?
- The program will display list of videos -> Each video will have a title, author, name
- The program is about tracking video information.

## What are candidates for classes?
- The two classes : Video and Comment class

## What are the responsibilities of each class?

1. ### Video Class
- The video class is responsible for tracking the title, author and length(in seconds) of the video 
- Title -> Author -> length (In this order)

2. ### Comment Class
- The comment class tracks the name of the commenter and the comment.


# Assignment 2
## What does the program do?
- Get the packing label and the total billing (including shipping costs)
- The input -> customers name, product, price, quantity -> calculate the price and quantity.

## What are candidates for classes?
- Product, Customer, Address, and Order.

## What are the responsibilities of each class?
1. ### Order
-    Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.
-   The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
-    This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
-    A packing label should list the name and product id of each product in the order.
-    A shipping label should list the name and address of the customer
2. ### Product
-    Contains the name, product id, price, and quantity of each product.
-    The total cost of this product is computed by multiplying the price per unit and the quantity. (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)

3. ### Customer
-    The customer contains a name and an address.
-    The name is a string, but the Address is a class.
-    The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
4. ### Address
-    The address contains a string for the street address, the city, state/province, and country.
-    The address should have a method that can return whether it is in the USA or not.
-    The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)

`NB` <strong>Start with classes that don't use reference from classes, then work your way up.</strong>