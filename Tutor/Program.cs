// Aditi Mahangade
// HW 3 Task 2 Tutor

Random rnd = new Random();
int num1 = rnd.Next(0, 51);
int num2 = rnd.Next(0, 51);
int answer = num1 + num2;
int userInputInt;

do
{
    string message = string.Format($"{num1}+{num2}=?");
    Console.Write(message);
    string userInputStr = Console.ReadLine();
    userInputInt = Convert.ToInt32(userInputStr);
    if (userInputInt == answer)
    {
        message = "Congratulations! You get the right answer!";
        Console.WriteLine(message);
        break;
    }
    else
    {
        message = "Sorry, please try again";
        Console.WriteLine(message);
    }
}
while (true);
// while(userInputInt!=answer);
