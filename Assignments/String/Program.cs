using System;
String str1= "The James Bond series focuses on a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is Forever and a Day by Anthony Horowitz, published in May 2018. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny. The character—also known by the code number 007 (pronounced double-O-seven)—has also been adapted for television, radio, comic strip, video games and film. The films are one of the longest continually running film series and have grossed over US$7.04 billion in total, making it the fifth-highest-grossing film series to date, which started in 1962 with Dr. No, starring Sean Connery as Bond. As of 2021, there have been twenty-five films in the Eon Productions series. The most recent Bond film, No Time to Die (2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series. There have also been two independent productions of Bond films: Casino Royale(a 1967 spoof starring David Niven) and Never Say Never Again (a 1983 remake of an earlier Eon-produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion,[1] making James Bond one of the highest-grossing media franchises of all time.";
int len=str1.Length;
int a;
int count = 1;

//number of words
for (a = 0; a < len; a++)
{
    if (str1[a] == ' ' || str1[a] == '\n' )
    {
        count++;
    }
}
Console.WriteLine($"Total number of words are:{count}");

//number of statements
count = 0;
for (a = 0; a < len-1; a++)
{
    if (str1[a] == '.' && str1[a+1]==' ')
    {
        count++;
    }
}
Console.WriteLine($"Total number of statement are:{count}");

//special character
count = 0;
String sp = "!#$%&/()=?»«@£§€{}.-;'<>_,";
for (a = 0; a < len; a++)
{
    if (sp.Contains(str1[a]))
    {
        count++;
    }
}
Console.WriteLine($"Total number of special characters are:{count}");
//number of blanks
count = 0;
for (a = 0; a < len; a++)
{
    if (str1[a] == ' ')
    {
        count++;
    }
}
Console.WriteLine($"Total number of blanks are:{count}");
String num = "1234567890";
for (a = 0; a < len; a++)
{
    if (num.Contains(str1[a]))
    {
        Console.WriteLine($"Digit at index number:{a}");
    }
}
// First Letter Upper
Console.WriteLine("Capitlized first word result: ");
char[] arr=str1.ToCharArray();
for (a=1; a < arr.Length; a++)
{
    if (arr[a-1]==' ' && char.IsLower(arr[a]))
    {
            arr[a] = char.ToUpper(arr[a]);
    }
}
foreach (char c in arr)
{
    Console.Write(c);
}