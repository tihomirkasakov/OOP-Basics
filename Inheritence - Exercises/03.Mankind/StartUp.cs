using System;

public class StartUp
{
    static void Main(string[] args)
    {
        var studentInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string studentFirstName = studentInput[0];
        string studentLastName = studentInput[1];
        string facultyNumber = studentInput[2];

        var workerInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string workerFirstName = workerInput[0];
        string workerLastName = workerInput[1];
        decimal salary = decimal.Parse(workerInput[2]);
        decimal workHours = decimal.Parse(workerInput[3]);

        try
        {
            Student student = new Student(studentFirstName, studentLastName, facultyNumber);
            Worker worker = new Worker(workerFirstName, workerLastName, salary, workHours);

            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
        catch (Exception aex)
        {
            Console.WriteLine(aex.Message);
        }
    }
}