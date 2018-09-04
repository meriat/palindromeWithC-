using System;
using System.Collections.Generic;

public class Palindrome
{

public static void Main()
{

Console.WriteLine("Please enter a word to see if it is a Palindrome.");
string word = Console.ReadLine();
string reverse = "";
int Length;
Length = word.Length -1;

while (Length >= 0)
{
  reverse = reverse + word[Length];
  Length--;
}
if(reverse == word)
{
  Console.WriteLine("It is a Palindrome");
}
else
{
  Console.WriteLine("Not a palindrome");
}


}
}
