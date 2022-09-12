using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

Console.Write("Skriv in en sträng: ");
string userInput = Console.ReadLine();

// Används för att ge platshållar-arrayerna rätt index.
int inputIndex = 0;
foreach (char c in userInput)
{
    inputIndex++;
}

// Platshållar-arrayer
char[] digits = new char[inputIndex];
char[] others = new char[inputIndex];
char[] sequence = new char[inputIndex];

for (int i = 0; i < userInput.Length; i++) //for sparar userInput[i]
{
    if (char.IsDigit(userInput[i]))
    {
        digits[i] = userInput[i];
    }
    else
    {
        others[i] = userInput[i];
    }
}

string[] userSequence = userInput.Split(others);
string strings = "";

for (int i = 0; i < userSequence.Length; i++)
{
    if (userSequence[0] == userSequence.Max())
    {
        Console.WriteLine("hej");
    }
}

foreach (var item in userSequence)
{
    Console.WriteLine(item);
    strings += item;
}

Console.WriteLine(strings);

//foreach (var item in strings)
//{
//    Console.WriteLine(item);
//}

//string seqOne = string.Join("", userSequence);
//Console.WriteLine(seqOne);
//for (int i = 0; i < userSequence.Length; i++)
//{
//    Console.WriteLine(userSequence[i]);
//    if (userSequence[i] == userSequence.Length-1)
//    {

//    }
//}

//string seqOne = "";
//for (int i = 0; i < userSequence.Length; i++) //for sparar userInput[j]
//{
//    for (int j = 0; j < userSequence.Length; j++)
//    {
//        if (userSequence[i] == userSequence[j] && j != i) //OM j inte är i
//        {
//            seqOne += userSequence[i];
//        }
//    }
//}

//Console.WriteLine($"Sekvens ett: {seqOne}");

//Console.WriteLine("Digits");
//for (int i = 0; i < userInput.Length; i++)
//{
//    Console.WriteLine($"Index: {i}, tal: {digits[i]}");
//}
//Console.WriteLine(userInput);

//Console.WriteLine("\nOthers");
//for (int i = 0; i < userInput.Length; i++)
//{
//    Console.WriteLine($"Index: {i}, tal: {others[i]}");
//}
//Console.WriteLine(userInput);

//Console.WriteLine("\nSequence");
//for (int i = 0; i < userInput.Length; i++)
//{
//    Console.WriteLine($"Index: {i}, tal: {sequence[i]}");
//}
//Console.WriteLine(userInput);


//string userAndSeq = "";

//for (int i = 0; i < userInput.Length; i++)
//{
//    userAndSeq += digits[i].ToString();
//    userAndSeq += others[i].ToString();
//}

//userAndSeq.Split(digits);

//Console.WriteLine(userAndSeq);