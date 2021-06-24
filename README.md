### Brief

Write a robot simulator.

A robot factory's test facility needs a program to verify robot movements.

The robots have three possible movements:

- turn right
- turn left
- advance

Robots are placed on a hypothetical infinite grid, facing a particular
direction (north, east, south, or west) at a set of {x,y} coordinates,
e.g., {3,8}, with coordinates increasing to the north and east.

The robot then receives a number of instructions, at which point the
testing facility verifies the robot's new position, and in which
direction it is pointing.

- The letter-string "RAALAL" means:
  - Turn right
  - Advance twice
  - Turn left
  - Advance once
  - Turn left yet again
- Say a robot starts at {7, 3} facing north. Then running this stream
  of instructions should leave it at {9, 4} facing west.

### Running the tests

To run the tests, run the command `dotnet test` from within the challenge directory.

Initially, only the first test will be enabled. This is to encourage you to solve the challenge one step at a time.
Once you get the first test passing, remove the `Skip` property from the next test and work on getting that test passing.
Once none of the tests are skipped and they are all passing, you can submit your solution.

### Evaluation Criteria

- C# best practices
- Show us your work through your commit history
- Completeness: did you complete the features? Are all the tests running?
- Correctness: does the functionality act in sensible, thought-out ways?
- Maintainability: is it written in a clean, maintainable way?


### CodeSubmit

Please organize, design, and document your code as if it were going into production - then push your changes 
to the master branch. After you have pushed your code, you may submit the assignment on the assignment page.

All the best and happy coding,

The Biosero Team