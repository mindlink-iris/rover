Feature: Initialise
  Scenario: Initalise at a location and direction
  Given the user is prompted "Please enter initial coordinates and direction for rover"
  When the user enters 5, 6, E 
  Then the rover is initialised at location is (5, 6) 
  And the rover is facing at E
  And the system confirms "Rover is at (5, 6), facing East"
  And the user is prompted "Please enter instructions"
  