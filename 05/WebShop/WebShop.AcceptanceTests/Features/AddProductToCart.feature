Feature: Adding a product to the cart
	

Scenario: Add a product
	Given I'm browsing the shop
	When I press "Add to Cart"
	Then the cart should have an item
