namespace LINQ_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List of nums for excercise
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            //For nums:
            Console.WriteLine("\nLINQ Practice With Nums:");

            //1)
            int minimum = nums.Min();
            Console.WriteLine("\n1)" + minimum);

            //2)
            int maximum = nums.Max();
            Console.WriteLine("\n2)" + maximum);

            //3)
            int maxLess = nums.Where(n => n < 10000).Max();
            Console.WriteLine("\n3)" + maxLess);

            //4)
            List<int> list = nums.Where(n => n > 10 && n < 100).ToList();
            Console.WriteLine("\n4)");
            PrintList(list);

            //5)
            List<int> list2 = nums.Where(n => n >= 100000 && n <= 999999).ToList();
            Console.Write("\n5)");
            PrintList(list2);
            Console.WriteLine();

            //6)
            int evenNums = nums.Count(n => n % 2 == 0);
            Console.WriteLine("\n6)" + evenNums);    

            //7)
            List<int> list3 = nums.OrderByDescending(num => num).ToList();
            Console.Write("\n7)");
            PrintList(list3);
            Console.WriteLine();
            
            List <Student> students = new List <Student> ();
                students.Add(new Student("Jimmy", 13));
                students.Add(new Student("Hannah Banana", 21));
                students.Add(new Student("Justin", 30));
                students.Add(new Student("Sarah", 53));
                students.Add(new Student("Hannibal", 15));
                students.Add(new Student("Phillip", 16));
                students.Add(new Student("Maria", 63));
                students.Add(new Student("Abe", 33));
                students.Add(new Student("Curtis", 10));

            //For students:
            Console.WriteLine("\n\nClass-Based Student Questions:");

            //1
            List <Student> over21 = students.Where(n => n.Age >= 21).ToList();
            Console.Write("\n1) Students over 21:");
            PrintStudents(over21);
            Console.WriteLine();

            //2
            int oldest = students.Max(n => n.Age);
            Student oldestStudent = students.First(n => n.Age == oldest);
            Console.WriteLine("\n2) The oldest student is: " + oldestStudent.Name);

            //3
            int youngest = students.Min(n => n.Age);
            Student youngestStudent = students.First(n => n.Age == youngest);
            Console.WriteLine("\n3) The youngest student is: " + youngestStudent.Name);

            //4
            List <Student> under25 = students.Where(n => n.Age < 25).ToList();
            int oldest25 = under25.Max(n => n.Age);
            Student oldestName = students.First(n => n.Age == oldest25);
            Console.WriteLine("\n4) The oldest student under 25 is: " + oldestName.Name);

            //5
            List <Student> evenAges = over21.Where(n => n.Age % 2 == 0).ToList();
            Console.Write("\n5) Students over 21 with even ages:");
            PrintStudents(evenAges);
            Console.WriteLine();

            //6
            List<Student> teenagers = students.Where(n => n.Age >= 13 && n.Age <= 19).ToList();
            Console.Write("\n6) Teenage students:");
            PrintStudents(teenagers);
            Console.WriteLine();

            //7
            string[] vowels = { "A", "E", "I", "O", "U" };
            
            List<Student> vowelNames = students.Where(n => vowels.Contains(n.Name.Substring(0, 1)) == true).ToList();
            Console.Write("\n7) Students whose name starts with a vowel: ");
            PrintStudents(vowelNames);
            Console.WriteLine();

            //8
            List <Student> orderedList = students.OrderBy(n => n.Age).ToList();
            Console.Write("\n8) Students youngest to oldest: ");
            PrintStudents(orderedList);
            Console.WriteLine();

        }

        //Method to check the output of enumberable items
        public static void PrintList(List <int> list) 
        { 
            foreach (int num in list) 
            { 
                Console.Write(num + " ");
            }
        }

        public static void PrintStudents(List<Student> students) 
        {
            for (int i = 0; i < students.Count; i++)
            {
                Student p = students[i];
                Console.Write($" {p.Name} ");
            }
            
        }
    }
}