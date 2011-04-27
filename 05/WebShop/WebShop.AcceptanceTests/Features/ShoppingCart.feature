Feature: Adding products to the shopping cart
	In order to select products I want to buy
	As a customer browsing the site
	I want to add products to a shopping cart 
	And see which products I have added

Scenario: Add a product to the cart
	Given The product
	| Name    | Price | InStock |
	| "Dings" | 50.00 | True    |
	When I open the shop page
	And press "Add to cart"
	Then The shopping cart should contain the item
	| Name    |
	| "Dings" |
