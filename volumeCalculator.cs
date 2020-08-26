using System;
using System.Collections.Generic;

interface IVolumeCalculator			
{ 
    void ComputeVolume(); 
} 

interface IInputReader 				//Interface Segregation
{
    void ReadInput();
} 

interface IShape : IVolumeCalculator,IInputReader
{
	
}

public class Sphere : IShape
{ 
    double radius;
	
    public void ReadInput()
    {
	Console.WriteLine("Enter radius:");
	string input = Console.ReadLine();
	radius = double.Parse(input);	
    }
	
    public void ComputeVolume()
    { 
        double vol = (4 * Math.PI * radius * radius * radius)/3;
        Console.WriteLine("Volume of the sphere:"+vol);
    } 
} 

public class Pyramid : IShape 
{ 
    double radius,height;
	
    public void ReadInput()								
    {
	Console.WriteLine("Enter radius and height:");
	string input1 = Console.ReadLine();
	string input2 = Console.ReadLine();
	radius = double.Parse(input1);
	height = double.Parse(input2); 
    }
	
    public void ComputeVolume()							//ComputeVolume
    { 
        double vol = (radius * height)/3;
        Console.WriteLine("Volume of the Pyramid:"+vol);
    } 
} 

public class Cone : IShape 
{ 
    double radius,height;				
	
    public void ReadInput()
    {
	Console.WriteLine("Enter radius and height:");
	string input1 = Console.ReadLine();
	string input2 = Console.ReadLine();
	radius = double.Parse(input1);	
	height = double.Parse(input2);
    }
	
    public void ComputeVolume()
    { 
        double vol = (Math.PI * radius * radius * height)/3; 
        Console.WriteLine("Volume of the cone:"+vol);
    } 
} 

public class Cuboid : IShape 
{ 
    double length,breadth,height;
	
    public void ReadInput()
    {
	Console.WriteLine("Enter length, breadth and height:");
	string input1 = Console.ReadLine();
	string input2 = Console.ReadLine();
	string input3 = Console.ReadLine();
	length = double.Parse(input1);
	breadth = double.Parse(input2);
	height = double.Parse(input3);
    }
	
    public void ComputeVolume()
    { 
        double vol = length * breadth * height; 
        Console.WriteLine("Volume of the cuboid:"+vol);
    } 
} 

public class CreateDictionary 
{
    Dictionary<int, IShape> ShapeDictionary = new Dictionary<int, IShape>(); 	//Create ShapeDictionary
    public void ShapeLoader()
    {
        ShapeDictionary.Add(1, new Sphere()); 
        ShapeDictionary.Add(2, new Pyramid());
	ShapeDictionary.Add(3, new Cone());
	ShapeDictionary.Add(4, new Cuboid());
    }	
    public void Calculator(int choice)
    {
	ShapeDictionary[choice].ReadInput();
	ShapeDictionary[choice].ComputeVolume();	
    }
}
	
public class InputValidator 
{
    public string ValidateInput(string input)
    {
	string validInput;
	bool isValid = true;
		
     	while(true)  			
     	{
		if(char.IsDigit(input[0]) == false || float.Parse(input) > 4)
		{
			isValid = false;
			Console.WriteLine("Enter a valid choice");
			input = Console.ReadLine();
		}
		else
		{
			isValid = true;
			break;
		}
     	}
     	validInput = input;
		
     	if (isValid == true)
      		return validInput;
     	else 
     		return " ";
     }
}

public class VolumeCalculatorApplication
{
    public static void Main() 
    { 
	Console.WriteLine("Enter\n1.Sphere\n2.Pyramid\n3.Cone\n4.Cuboid");
	string input = Console.ReadLine();
		
	CreateDictionary creator = new CreateDictionary();
	creator.ShapeLoader();
	bool isValid = true;
	InputValidator i = new InputValidator();
	input = i.ValidateInput(input);
		
	isValid = true; 
	if(isValid == true)
	{
		int choice = int.Parse(input);
		creator.Calculator(choice);
	}
    }
}
