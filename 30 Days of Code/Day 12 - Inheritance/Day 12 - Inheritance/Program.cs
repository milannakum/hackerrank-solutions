using System;
using System.Linq;

namespace Day_12___Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
                scores[i] = Convert.ToInt32(inputs[i]);

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }

    class Student : Person
    {
        private int[] scores;

        public Student(string firstName, string lastName, int identification, int[] scores) : base(firstName, lastName, identification)
        {
            this.scores = scores;
        }

        public char Calculate()
        {
            int avg = scores.Sum() / scores.Length;
            if (avg >= 90)
                return 'O';
            else if (avg < 90 && avg >= 80)
                return 'E';
            else if (avg < 80 && avg >= 70)
                return 'A';
            else if (avg < 70 && avg >= 55)
                return 'P';
            else if (avg < 55 && avg >= 40)
                return 'D';
            else
                return 'T';
        }
    }

    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }
}