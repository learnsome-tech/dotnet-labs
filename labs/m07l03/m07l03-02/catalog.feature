Feature: Product lookup

Scenario: Unknown product
  When I request product number 7
  Then the response status is 404
