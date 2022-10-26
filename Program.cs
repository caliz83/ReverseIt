bool letsPlay = true;

while(letsPlay == true)
{
int numb;
int remainder;
int revNumber = 0;
bool isNumber;

Console.WriteLine("Please enter a number to be reversed.");
isNumber = Int32.TryParse(Console.ReadLine() , out numb);



//while(numb > 0)
for(int i = numb; i > 0; i = i / 10){
    
    remainder = i % 10;
    revNumber = (revNumber * 10) + remainder;
    
}

Console.WriteLine("The number you chose is " + numb);
Console.WriteLine("The number in reverse is " + revNumber + ".");

bool question = true;
while(question == true)
{
Console.WriteLine("Do you want to play again? Y/N");
string playAgain = Console.ReadLine().ToUpper();

if(playAgain == "Y")
{
    letsPlay = true;
    question = false;
}
else if(playAgain == "N")
{
    letsPlay = false;
    question = false;
    Console.WriteLine("Goodbye.");
}
else
{
    Console.WriteLine("Please enter a valid option: Y or N");
    question = true;
}
}
}
