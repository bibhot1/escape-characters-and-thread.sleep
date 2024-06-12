/* how to make a line break
string myString = "Hello bibhot \n Good morning";
Console.WriteLine(myString);*/
//building for and while loop
//for loop which counts to 10 and displays message on the console


/*for (int i = 0; i < 10; i++)
{
    Console.WriteLine("hello" + i);
}*/

// guess the number challenge

// declare the secret number

int secretNumber = 12;
int userGuess = 0;              

// now we need to compare the numbers on while loop

Console.WriteLine("guess the number");

while (secretNumber != userGuess)
{
    userGuess = int.Parse(Console.ReadLine());

    if (userGuess > secretNumber)
    {
        Console.WriteLine("too high try again");
    }else if (userGuess < secretNumber)
    {
        Console.WriteLine("Too low try again");
    }else { Console.WriteLine("GOOD JOB"); }

}

