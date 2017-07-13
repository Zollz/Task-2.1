using System;
using SplashKitSDK;

public class Program


{
    public static void Main()
    {
    string name, inputText;
    int heightInCM;
    double weightInKG, heightInMeters, bmi;

    Console.Write("Enter Your Name: ");
    name = Console.ReadLine();
    Console.Write("Hey " + name);

    Console.Write("Enter Your Height in Centimetres: ");
    inputText = Console.ReadLine();
    heightInCM = Convert.ToInt32(inputText);
    heightInMeters = heightInCM / 100.0;
    Console.Write("Your Height In Metres Is: " + heightInMeters);

    Console.Write("Enter Your Weight in Kilograms: ");
    inputText = Console.ReadLine();
    weightInKG = Convert.ToDouble(inputText);
    bmi = weightInKG / (heightInMeters * heightInMeters);
    Console.Write("Your BMI Is: " + bmi);

    
    


    }
}
