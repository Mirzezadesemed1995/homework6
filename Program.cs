using System;

class Program
{
    static bool IsArrayContains(int[] arr1, int[] arr2)
    {
        if (arr1.Length < arr2.Length)
        {
            return false;
        }

        for (int i = 0; i <= arr1.Length - arr2.Length; i++)
        {
            if (arr1[i] == arr2[0])
            {
                bool isMatch = true;
                for (int j = 1; j < arr2.Length; j++)
                {
                    if (arr1[i + j] != arr2[j])
                    {
                        isMatch = false;
                        break;
                    }
                }
                if (isMatch)
                {
                    return true;
                }
            }
        }

        return false;
    }

    static void Main()
    {
        int[] arr1 = { 2, 3, 4, 7 };
        int[] arr2 = { 3, 4 };

        bool result = IsArrayContains(arr1, arr2);

        Console.WriteLine(result); 
    }
}

