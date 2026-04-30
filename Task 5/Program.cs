using System;

class Student
{
    private static int nextId = 1;
    private double _gpa;

    public string Name { get; set; }
    public int StudentId { get; }
    public string Faculty { get; set; }

    public double GPA
    {
        get { return _gpa; }
        set
        {
            if (value < 0.0 || value > 4.0)
            {
                throw new ArgumentException("GPA must be between 0.0 and 4.0.");
            }

            _gpa = value;
        }
    }

    public Student(string name, double gpa, string faculty)
    {
        Name = name;
        StudentId = nextId;
        nextId++;
        GPA = gpa;
        Faculty = faculty;
    }

    public void PrintInfo()
    {
        Console.WriteLine("ID: " + StudentId + ", Name: " + Name + ", GPA: " + GPA + ", Faculty: " + Faculty);
    }
}

class Registry
{
    private Student[] students = new Student[100];
    private int count = 0;

    public void Add(Student student)
    {
        if (count >= 100)
        {
            Console.WriteLine("Registry is full.");
            return;
        }

        students[count] = student;
        count++;
        Console.WriteLine("Student added.");
    }

    public Student FindById(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (students[i].StudentId == id)
            {
                return students[i];
            }
        }

        return null;
    }

    public void FindByName(string name)
    {
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (students[i].Name.ToLower() == name.ToLower())
            {
                students[i].PrintInfo();
                found = true;
            }
        }

        if (found == false)
        {
            Console.WriteLine("Student not found.");
        }
    }

    public void GetTopStudents(int n)
    {
        if (count == 0)
        {
            Console.WriteLine("Registry is empty.");
            return;
        }

        if (n > count)
        {
            n = count;
        }

        Student[] temp = new Student[count];

        for (int i = 0; i < count; i++)
        {
            temp[i] = students[i];
        }

        for (int i = 0; i < temp.Length - 1; i++)
        {
            for (int j = i + 1; j < temp.Length; j++)
            {
                if (temp[i].GPA < temp[j].GPA)
                {
                    Student x = temp[i];
                    temp[i] = temp[j];
                    temp[j] = x;
                }
            }
        }

        Console.WriteLine("Top students:");
        for (int i = 0; i < n; i++)
        {
            temp[i].PrintInfo();
        }
    }

    public void PrintAll()
    {
        if (count == 0)
        {
            Console.WriteLine("Registry is empty.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            students[i].PrintInfo();
        }
    }
}

class Program
{
    static void Main()
    {
        Registry registry = new Registry();
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("1 - Add student");
            Console.WriteLine("2 - Find by ID");
            Console.WriteLine("3 - Find by name");
            Console.WriteLine("4 - Top students");
            Console.WriteLine("5 - Print all");
            Console.WriteLine("6 - Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                try
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("GPA: ");
                    double gpa = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Faculty: ");
                    string faculty = Console.ReadLine();

                    Student s = new Student(name, gpa, faculty);
                    registry.Add(s);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Enter a number for GPA.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (choice == "2")
            {
                try
                {
                    Console.Write("Enter ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Student found = registry.FindById(id);

                    if (found != null)
                    {
                        found.PrintInfo();
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Enter a number for ID.");
                }
            }
            else if (choice == "3")
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                registry.FindByName(name);
            }
            else if (choice == "4")
            {
                try
                {
                    Console.Write("Enter N: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n <= 0)
                    {
                        Console.WriteLine("Enter a positive number.");
                    }
                    else
                    {
                        registry.GetTopStudents(n);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Enter a number.");
                }
            }
            else if (choice == "5")
            {
                registry.PrintAll();
            }
            else if (choice == "6")
            {
                running = false;
                Console.WriteLine("Program ended.");
            }
            else
            {
                Console.WriteLine("Wrong choice.");
            }
        }
    }
}