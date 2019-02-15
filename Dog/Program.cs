using System;

namespace dog
{
    public enum Gender {Male,Female}
    public class Dog
    {
        public string name,owner;
        public int age;
        public Gender gender;
        public Dog(string n,string o,int a, Gender g)
        {
            name = n;
            owner = o; 
            age = a;
            gender = g;
        }
        public void Bark(int time)
        {
            int x = 0;
            while(x < time)
            {
                Console.WriteLine("woof", time);
                x++;
            }
        }
        public String GetTag()
        {
            switch (gender)
            {
                case Gender.Male:
                    if (age == 1)
                    {
                        return "If lost, call " + owner + ". His name is " + name + " and He is 1 year old.";
                        //return （"If lost, call {0}. His name is {1} and He is 1 year old.", owner, name);

                    }
                    else
                    {
                        return "If lost, call" + owner + ". His name is " + name + " and He is " + age + "years old.";
                        //Console.WriteLine("If lost, call {0}. His name is {1} and He is {2} years old.", owner, name, age);
                    }
                case Gender.Female:
                    if (age == 1)
                    {
                        return "If lost, call " + owner + ". Her name is " + name + " and She is 1 year old.";
                        //Console.WriteLine("If lost, call {0}. Her name is {1} and She is 1 year old.", owner, name);
                    }
                    else
                    {
                        return "If lost, call " + owner + ". Her name is " + name + " and She is " + age + " years old.";
                        //Console.WriteLine("If lost, call {0}. Her name is {1} and She is {2} years old.", owner, name, age);
                    }
                default:
                    return "";

            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.Bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.
        }
    }
}
