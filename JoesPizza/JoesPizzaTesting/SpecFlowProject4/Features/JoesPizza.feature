Feature: JoesPizza

A short summary of the feature

@tag1
Scenario: Purchasing a pizza from menu and checking cart page and then redirecting to my payment confirmation page.
	Given I have opened the Website url
	When I will click on Buy Now of a specific pizza
	Then I will be redirected to the cart page
	Then i will change the quantity and type 3
	Then i will upadte the order 
	When I will click on Pay Now
	Then Payment confirmation page is opened

