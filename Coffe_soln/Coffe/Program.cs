using System;
class coffee
{
    static void Main()
    {
        int totalcost = 0;
        start:
        Console.WriteLine("Please select your coffee sizr from these: 1 - Small coffee, 2 - Medium coffee, 3 - Large coffee");
        int userinput=int.Parse(Console.ReadLine());
        switch(userinput){
            case 1:
                totalcost +=1;

                break;
            case 2:
                totalcost +=2;
                break;
            case 3:
                totalcost += 3;
                break;
                default:
                Console.WriteLine("Not valid user choice");
                goto start;

    }
        second:
        Console.WriteLine("Do you want some more coffee? if so please enter Yes or No");
        string userdecision=Console.ReadLine();
        switch (userdecision.ToUpper())
        {
            case "YES":
                goto start;
            case "NO":
                break;
            default :
                Console.WriteLine("Please choose valid options");
                goto second;
        }
        Console.WriteLine("Thanks for shopping with us toatal cost {0}",totalcost);
        Console.WriteLine("Thanks for shopping with us have nice day ahead");
        Console.WriteLine("Please visit once again");
        Console.WriteLine("Please visit once again");
        Console.WriteLine("Thank you visit again");
        Console.WriteLine("Thank you visit again");
    }
}