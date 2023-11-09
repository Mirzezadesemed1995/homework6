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











        User[] users = new User[]
      {
            new Student
            {
                Username = "student1",
                Password = "pass1",
                FirstName = "John",
                LastName = "Doe",
                Grade = 95
            },
            new User
            {
                Username = "user1",
                Password = "pass2"
            }
      };

        Console.Write("Istifadecinin adini daxil edin: ");
        string inputUsername = Console.ReadLine();
        Console.Write("Parolu daxil edin: ");
        string inputPassword = Console.ReadLine();

        User foundUser = null;
        foreach (User user in users)
        {
            if (user.Username == inputUsername && user.Password == inputPassword)
            {
                foundUser = user;
                break;
            }
        }

        if (foundUser is Student student)
        {
            Console.WriteLine($"Salam, {student.FirstName} {student.LastName}! Sizin qiymetiniz: {student.Grade}");
        }
        else if (foundUser != null)
        {
            Console.WriteLine("Siz adi istifadeci kimi daxil oldunuz.");
        }
        else
        {
            Console.WriteLine("Bu adla istifadeci adi ve parol tapilmadi.");

        }
    }


    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    class Student : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
    }
}

