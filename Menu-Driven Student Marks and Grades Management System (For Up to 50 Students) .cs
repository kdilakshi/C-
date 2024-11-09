using System;

class StudentMarksManagement
{
    static void Main()
    {
        int[] marks = new int[50];
        char[] grades = new char[50];
        int count = 25;  // Number of students 
        int option;//choices

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Marks");
            Console.WriteLine("2. Calculate Average Mark");
            Console.WriteLine("3. Assign Grades");
            Console.WriteLine("4. Display Marks and Grades");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: // Add Marks
                    Console.WriteLine("Enter marks for 25 students:");
                    for (int i = 0; i < count; i++)
                    {
                        int mark;
                        do
                        {
                            Console.WriteLine("Marks range 0-100");
                            Console.Write("Enter mark for student {0} : ", i + 1);
                            mark = int.Parse(Console.ReadLine());
                            if (mark >= 0 && mark <= 100)
                            {
                                marks[i] = mark;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid mark. Please enter a mark between 0 and 100.");
                            }
                        } while (true);
                    }
                    break;

                case 2: // Calculate Average Mark
                    int sum = 0;
                    for (int i = 0; i < count; i++)
                    {
                        sum += marks[i];
                    }
                    double average = sum / (double)count;
                    Console.WriteLine("Average mark: " + average);
                    break;

                case 3: // Assign Grades
                    for (int i = 0; i < count; i++)
                    {
                        if (marks[i] >= 85)
                            grades[i] = 'A';
                        else if (marks[i] >= 70)
                            grades[i] = 'B';
                        else if (marks[i] >= 50)
                            grades[i] = 'C';
                        else if (marks[i] >= 40)
                            grades[i] = 'D';
                        else
                            grades[i] = 'F';
                    }
                    Console.WriteLine("Grades assigned.");
                    break;

                case 4: // Display Marks and Grades
                    Console.WriteLine("Marks and Grades:");
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("Student {0}: Mark = {1}, Grade = {2}", i + 1, marks[i], grades[i]);
                    }
                    break;

                case 5: // Exit
                    Console.WriteLine("Exiting the program.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose between 1 and 5.");
                    break;
            }

        } while (option != 5);
    }
}
