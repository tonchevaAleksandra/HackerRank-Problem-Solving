using System;

namespace Day_12._Inheritance
{
    public class Solution
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
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
    public abstract class Person
    {
        protected string firstName;
        protected string lastName;
        protected int Id;

        protected Person(string firstname, string lastName, int id)
        {
            this.firstName = firstname;
            this.lastName = lastName;
            this.Id = id;
        }
        public void printPerson()
        {
            Console.WriteLine($"Name: {this.lastName}, {this.firstName}");
            Console.WriteLine($"ID: {this.Id}");
        }
    }

    public class Student : Person
    {
        private int[] testScores;


        public Student(string firstName, string lastName, int id, int[] scores)
            : base(firstName, lastName, id)
        {
            this.testScores = scores;
        }


        public char Calculate()
        {

            var s = 0;

            for (int i = 0; i < this.testScores.Length; i++)
            {
                s += testScores[i];
            }

            s /= testScores.Length;

            if (s >= 90 && s <= 100)
                return 'O';
            else if (s < 90 && s >= 80)
                return 'E';
            else if (s < 80 && s >= 70)
                return 'A';
            else if (s < 70 && s >= 55)
                return 'P';
            else if (s < 55 && s >= 40)
                return 'D';
            else
                return 'T';

        }
    }

}
