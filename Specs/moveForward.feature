Feature: Move Forward
  Scenario: Moving the rover forward from an initialized location and direction
  Given the user is being prompted "Please enter instructions"
  And the rover is at location (5, 6) facing North
  When the user enters "F"
  Then the rover is at location (5, 7) facing North
  And the system confirms with "Rover is at (5, 7) facing North"
  And the user is prompted "Please enter instructions"
  