using System; //allows us to use the system library for our project. This gives us access to useful functions such as WriteLine, which is used to display text in the console output.

public class BMI // This is the public class.
{
    public static void Main() // this is the main method.
    {
        double weight; // this is the weight integar.
        double height; // this is the height integar
        double bmi; // this is the BMI integar.

        Console.WriteLine(" Welcome to Hishaam's BMI calculator application! " );// this is the opening title of the BMI program.
        Console.WriteLine(" ------------------------------------------------ " );// This will be used to seperate the text in the console output.

        Console.WriteLine(" Please enter your height in meters: "); // The user is asked to input their height in inches.
		height = Convert.ToDouble((Console.ReadLine())); // int32 is used to store the data in 32 bit.

		Console.WriteLine(" -------------------------------------------------- ");

		Console.WriteLine(" Please enter your weight in kgs: "); // Asks user for their weight in kilograms
		weight = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine(" -------------------------------------------------- ");

		bmi = (weight/(height*height)); // this is the formula which will be used to calculate the user's BMI.

		Console.WriteLine("Your BMI is: " + bmi);

		











    }
}


