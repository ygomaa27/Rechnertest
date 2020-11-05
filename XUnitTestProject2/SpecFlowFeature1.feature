Feature:Rechner für Kreisfunktionen

@mytag
Scenario: Sinus
	Given the number is PI
	When the number use the Sinus function
	Then the result should be 0

Scenario: Cosinus
	Given the number is PI
	When the number use the Cosinus function
	Then the result should be -1

Scenario: Tangens
	Given the number is PI 
	When the number use the Tangenss function
	Then the result should be 0
