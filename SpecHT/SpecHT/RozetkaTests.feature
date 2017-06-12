Feature: RozetkaTests

Scenario Outline: Search For Items
    Given I am on Rozetka main page
	And I have entered the <searchText>
	When I press searchButton
	Then The results found contain <resultText> 
Examples: 
| searchText | resultText |
| Hyundai    | Hyundai    |
| LG         | LG         |
| Lenovo     | Lenovo     |
| Jabra      | Jabra      |

Scenario: Log In To Personal Office
    Given I am on Rozetka main page
    And I have entered credentials
| UserName                     | Password    |
| leno4ka.konovalova@gmail.com | 123456789Ok |
    When I press enterButton
    Then I see my personal page with personal data displayed

Scenario: Filter Items
    Given I am on Smartphone page
	When I filter by brand - Apple
	Then I see search results which are of Apple brand

Scenario: Arrange Price Descending
    Given Go to the Smartphone page
	And Filter by brand - ZTE
	When Price descending sort is executed
    Then All the goods displayed are properly sorted
