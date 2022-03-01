
/*
Asssigment 1: Palindrome
Linear Search
Sorting
Binary Search
*/

//// Palindrome
//Console.Write("Enter a string: ");
//string s = Console.ReadLine();

//Console.WriteLine(s + ": " + IsPalindrome(s));
//s = "nitin";
//Console.WriteLine(s + ": " + IsPalindrome(s));
//s = "avinash";
//Console.WriteLine(s + ":" + IsPalindrome(s));

//bool IsPalindrome(string s)
//{
//    int startIndex = 0;
//    int endIndex = s.Length - 1;
//    while (startIndex < endIndex)
//    {
//        if (s[startIndex++] != s[endIndex--])
//            return false;
//    }

//    return true;
//}

/* Linear Search */

//string[] fruits = new string[] 
//{ 
//    "Apples",
//    "PineApples",
//    "Mangoes",
//};

//Console.Write("Enter a fruit to search: ");
//string fruitToSearch = Console.ReadLine();


//if(IsFound(fruits, fruitToSearch))
//    Console.WriteLine("Found");
//else
//    Console.WriteLine("Not Found");


//bool IsFound(string[] fruits, string fruitToSearch)
//{
//    foreach (string fruit in fruits)
//    {
//        if (fruitToSearch == fruit)
//        {
//            return true;
//        }
//    }

//    return false;
//}

/* Sorting */
int[] arr = new int[] { 55, 22, 22, 78, 88, 22, 88, 44, 54, 86, 23 };

Console.Write("Original array: ");
Display(arr);

Sort(arr, true);
Console.Write("Sorted ascending array: ");
Display(arr);

Sort(arr, false);
Console.Write("Sorted descending array: ");
Display(arr);

void Sort(int[] arr, bool ascending)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (ascending)
            {
                if (arr[j] < arr[i])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            else
            {
                if (arr[j] > arr[i])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
}

void Display(int[] arr)
{
    foreach (var num in arr)
    {
        Console.Write(num + ",");
    }
    Console.WriteLine();
}