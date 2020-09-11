# Worksheet Two

## Exercise Answers

### 3. 

PollSensors() current responsibilities:
- Instantiating a new list of sensors
- Instantiating sensors and adding them to the list
- Checking whether each of the sensors in the list are triggered or not by calling their IsTriggered property
- Outputing information about each sensor

### 5.

PollSensors() responsibilities after the changes in q4:
- Iterating through a collection of sensors that the object holds to check their trigger state.
- Outputing information about each sensor

### 6.

The SOLID principle that is violated is the Liskov Substitution Principle, because we expect all ISensor types to implement the method GetBatteryPercentage(); however, this method doesn't make sense for motion and heat sensors, so we wouldn't be able to provide a meaningful implementation.


### 10.

The SOLID principle we are maintaining/not breaking is the Open-Closed Principle, as we are extending the ControlUnit class with a new functionality (restricting time based on type of sensor) without changing already working code.
