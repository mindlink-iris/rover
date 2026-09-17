Feature: Turn left

@Scenario: Turn left from North to West
Given the rover is facing North and is at coordinates (0,0)
And the user is being prompted "Please enter instructions"
When the user enters "L"
Then the rover is facing West at coordinates (0,0)
And the system confirms "Rover is at (0, 0), facing West"
And the user is prompted "Please enter instructions"
