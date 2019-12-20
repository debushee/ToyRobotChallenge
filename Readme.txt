Toy Robot
The toy robot moves on a table top grid of 5 x 5 units, there are no obstructions. You can commands to the robot allowing it to roam around the table top.

Getting Started
Copy the WpfNetCoreRobot folder from Github and save somewhere on your development machine.  Open the WpfNetCoreRobot.sln solution in Visual Studio 2019 and build and run the solution. 

Prerequisites
The application is .NET Core WPF VS 2019 solution and requires no prerequisites to run apart from a Windows PC.

Installing
Follow the steps in Getting Started.  Run the solution.
You will be presented with the main ShellWindow screen.  The first grid at the top displays the realtime position of the toy robot.  You can click on the Move, Left or Right buttons to move the robot accordingly.
The second grid allows the user to enter commands to the toy robot and then when ready to run them all.  There is no limit to the number of commands it can process.
Commands
The robot should be able to process the following commands.

PLACE X,Y,FACING
Puts the toy robot on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST.
The origin (0,0) can be considered to be the SOUTH WEST most corner.
The first valid command to the robot is a PLACE command, after that, any sequence of commands may be issued, in any order, including another PLACE command.
The application should discard all commands in the sequence until a valid PLACE command has been executed.
MOVE
Moves the toy robot one unit forward in the direction it is currently facing.

LEFT
Will rotate the robot 90° anticlockwise without changing the position of the robot.

RIGHT
Rotate the robot 90° clockwise without changing the position of the robot.

REPORT
Outputs the X,Y and F of the robot. This can be in any form, but standard output is sufficient.

Running the tests
Explain how to run the automated tests for this system

Break down into end to end tests
Explain what these tests test and why

Give an example
And coding style tests
Explain what these tests test and why

Give an example
Deployment
Add additional notes about how to deploy this on a live system

Built With
.NET Core WPF solution - built with VS 2019

Versioning
1.0.0.0

Authors
Niall Brown

License
N/A

Acknowledgments
N/A