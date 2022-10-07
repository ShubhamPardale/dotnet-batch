Feature: JoesPizza1

A short summary of the feature

@tag2
Scenario: Purcahsing two pizzas and deleting one and the confirming the order.
	Given I have opened the Website Url
	When I will click on Buy Now of a pizza
	Then I will be redirected to the cart
	Then i will go back to menu
	Then i will add another pizza
	Then i will cancel one pizza
	When the button Pay Now is clicked
	Then Order confirmation page is opened
