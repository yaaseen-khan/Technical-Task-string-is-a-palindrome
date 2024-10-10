
Console.Write("Enter a string:");
string input = Console.ReadLine();

input = input.ToLower();

int left = 0;
int right = input.Length - 1;
bool isPalendrome = true;
while(left < right)
{
    if(input[left] != input[right])
    {
        isPalendrome = false;
        break;
    }
    left++;
    right--;
}
if (isPalendrome)
{
    Console.WriteLine("the string is a palindrome");
}
else
{
    Console.WriteLine("the string is not a palendrome");
}

Console.ReadLine();
