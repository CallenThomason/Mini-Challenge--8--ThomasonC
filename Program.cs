/* 
Callen Thomason
Mini Challenge # 8 - Add 2 Numbers & Greater Than Or Less Than Validation
I took my mini challenge 2 and 4 and added validation using a series of do while and while loops.
Also took out the ToInt32 lines and replaced them with TryParse for a more robust program. 

Peer Review name: 
Review: 
include a png of flowchart
*/


string ans = ""; 
do{
Console.Clear(); 
Console.Write("Input a number: ");
string num1 = Console.ReadLine();
int newNum1; //converts the strings to int 
bool isNum = int.TryParse(num1, out newNum1); //returns true if int value was input

while(isNum == false) //runs if a string was input
{
    Console.Write("Invalid input. Please input a number: ");
     num1 = Console.ReadLine();
     isNum = int.TryParse(num1, out newNum1); 

}

Console.Write("Input another number: ");
string num2 = Console.ReadLine(); 

int newNum2;
bool isNum2 = int.TryParse(num2, out newNum2); 

while(isNum2 == false)
{
    Console.Write("Invalid input. Please input a number: ");
     num1 = Console.ReadLine();
     isNum2 = int.TryParse(num1, out newNum2); 

}

int sum = newNum1 + newNum2; //adds the two new integers
Console.WriteLine($"The sum of your two numbers is: {sum}"); //prints everything

Console.WriteLine("Do you want to play again? Y / N: "); 
 ans = Console.ReadLine().ToUpper(); 
while(ans != "Y" && ans != "N")
    {
        Console.Write("Invalid input. Please enter Y or N: "); 
        ans = Console.ReadLine().ToUpper(); 
        
    }
}while(ans != "N"); 


//---------------END OF ADD TWO NUMBERS------------//

string answer = "Y";

do{
Console.Write("Enter a number: "); 
string userInput = Console.ReadLine();
int realNum1;
bool isUsable = int.TryParse(userInput, out realNum1);

while(isUsable == false)
{
    Console.Write("Invalid input. Please input a number: ");
     userInput = Console.ReadLine();

     isUsable = int.TryParse(userInput, out realNum1);

}


Console.Write("Enter another number: "); 
string userInput2 = Console.ReadLine();
int realNum2;
bool isUsable2 = int.TryParse(userInput2, out realNum2);

while(isUsable2 == false)
{
    Console.Write("Invalid input. Please input a number: ");
     userInput2 = Console.ReadLine();

     isUsable2 = int.TryParse(userInput2, out realNum2);

}



if(realNum1 == realNum2) //checks if they are equal
{
   Console.WriteLine($"{realNum1} is equal to {realNum2}"); 
   
    Console.WriteLine($"{realNum2} is equal to {realNum1}"); 
}//end if
else if(realNum1 > realNum2) //checks if the first one is greater than the second
{
    Console.WriteLine($"{realNum1} is greater than  {realNum2}"); 

    Console.WriteLine($"{realNum2} is less than  {realNum1}"); 
} //end else if
else //runs if both are not true
{
    Console.WriteLine($"{realNum1} is less than  {realNum2}"); 

    Console.WriteLine($"{realNum2} is greater than  {realNum1}"); 
} //end else

Console.WriteLine("Do you want to play again? Y / N: "); 
 answer = Console.ReadLine().ToUpper(); 
while(answer != "Y" && answer != "N")
    {
        Console.Write("Invalid input. Please enter Y or N: "); 
        answer = Console.ReadLine().ToUpper(); 
        
    }

}while(answer != "N");