// This is challenge work for the "C# Players Guide"
// Level 9 Watchtower
// The scenario used a 3x3 grid, but uses relation operators for grid numbers. 
// The user provides a number and the program provides the direction of the enemy forces
// Direction is determined based on the number's relationship to 0 for both x and y 
// The challenge says to only use "if statements" and relational operators.

Console.WriteLine("Please input a coordinate value for y: ");
float yCoordinate = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Please input a coordinate value for x:  ");
float xCoordinate = Convert.ToSingle(Console.ReadLine());

//Looping through each y then x coordinate
if (yCoordinate > 0)
{
    if (xCoordinate < 0) Console.WriteLine("The enemy is to the northwest!");

    else if (xCoordinate == 0) Console.WriteLine("The enemy is to the north!");
    
    else Console.WriteLine("The enemy is to the northeast!");
}

else if (yCoordinate == 0)
{
    if (xCoordinate < 0) Console.WriteLine("The enemy is to the west!");

    else if (xCoordinate == 0) Console.WriteLine("The enemy on top of us!");

    else Console.WriteLine("The enemy is to the east!");
}

else // The only choice left is yCoordinate < 0
{
    if (xCoordinate < 0) Console.WriteLine("The enemy is to the southwest!");

    else if (xCoordinate == 0) Console.WriteLine("The enemy is to the south!");

    else Console.WriteLine("The enemy is to the southeast!");
}

Console.WriteLine("Press any key to end");
Console.ReadKey();