

using System;

 

namespace BMI

{

    class Program

    {



        public static string getName()//input users name

        {

            Console.Write("Enter name: ");

            return Console.ReadLine();

        }

        public static string getGender()

        {

            Console.WriteLine("Please enter your gender (M/F):");

            return Console.ReadLine();

        }

        public static void getWeightAndHeight(ref double weight, ref double height)

        {

            Console.Write("Enter your weight in pounds: ");   //Asks user for their weight in pounds

            weight = Convert.ToDouble(Console.ReadLine());



            Console.Write("Enter your height in inches: ");   //Asks user for their height in inches

            height = Convert.ToDouble(Console.ReadLine());

        }



        public static double calculateBMI(double weight, double height)

        {

            return (weight * 703) / (height * height);       //Actual BMI calculation

        }



        public static void display(string name, double weight, double height, double BMI)

        {

            Console.WriteLine("BMI of {0} with weight {1:F2} and height {2:F2} is {3:F2}", name, weight, height, BMI);

        }



        static void Main(string[] args)

        {

            string name, gender;

            double weight = 0, height = 0, BMI;

            name = getName();

            gender = getGender();



            getWeightAndHeight(ref weight, ref height);

            BMI = calculateBMI(weight, height);

            display(name, weight, height, BMI);



            if (BMI < 18.5)

            {

                Console.WriteLine("You're underweight.Eat more frequently and Choose nutrient-rich foods.");// Tell user results and give advises.

            }



            else if (BMI >= 18.5 && BMI <= 25) // Tell user results and give advises.

            {

                Console.WriteLine("You're Healthy.Good Job!");

                System.Console.Write('\u003A');       // Make Happy Face use Unicode :)

                System.Console.WriteLine('\u0029');

            }

            else if (BMI > 25) // Tell user results and give advises.

            {

                Console.WriteLine("You're overweight.Eat a healthy diet and Increase your activity level");

            }



        }

    }

}



