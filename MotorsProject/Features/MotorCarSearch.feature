Feature: MotorCarSearch
	In order to know more details about the car of my choice 
	As a Customer 
	I want to the ability to search for a car of my choice

Scenario: Search for Audi Cars
	Given I am navigate to Motors homepage
	When I enter my postcode
	And I select Audi as the car make
	And I select Q7 as the car model
	And I click on the  search button
	Then the result of Audi Q7 cars are displayed

Scenario: Search for Any Car
	Given I am navigate to Motors homepage
	When I enter my postcode as "OL9 8LE"
	And I select "Audi" as the car make
	And I select "Q7" as the car model
	And I click on the  search button
	Then the result of "AUDI Q7" cars are displayed

Scenario Outline: Search for Any Car in test Table
	Given I am navigate to Motors homepage
	When I enter my postcode as "<Postcode>"
	And I select "<Make>" as the car make
	And I select "<Model>" as the car model
	And I click on the  search button
	Then the result of "<Result>" cars are displayed

Scenarios: 
| Postcode | Make  | Model | Result  |
| ol9 8le  | Audi  | Q7    | AUDI Q7 |
| ol9 8le  | Mazda | 6     | MAZDA 6 |
| M40 2EB  | Audi  | Q7    | AUDI Q7 |
| M40 2EB  | Mazda | 6     | MAZDA 6 |


