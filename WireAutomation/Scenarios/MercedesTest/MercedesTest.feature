Feature: MercedesShop
	In order to check Shop page
	As a User I will make an order
	And in the end verify the Product name, price, Invoice address, Delivery address, Payment type and Amount


Scenario: Check Shopping workflow
	Given User opened Home page
	And User closes cookies pop-up
	And User clicks the Collection and Accessories link
	And User clicks the All Products button
	And User clicks See All Products button
	And User clicks the item number 1 item from products
	And User clicks the Add to basket button
	When User clicks the Go to shopping basket button
	Then Product name is correct
	And Product price is correct
	When User clicks the Continue to address and delivery button
	And User enters email address 'email@mb.com' to the Email address field
	And User clicks the Place order as guest button
	And User sets the salutation to Mr
	And User enters 'Konstantin' First name
	And User enters 'Volchkov' Last name
	And User enters '109' Street number
	And User enters 'Mercedes str' Street name
	And User enters 'Stuttgart' city
	And User enters 'SP2 0FL' postcode
	And User receives Shipping price
	And User clicks the Continue to payment type button
	And User sets Payment type to Credit Card
	And User sets the Credit Card type to MasterCard
	And User clicks the Continue to verification and order placement button
	Then Invoice address is correct
	And Delivery address is correct
	And Payment type is correct
	And Amount is correct