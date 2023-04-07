using MyApplication;
using System;

class Program
{
    static void Main()
    {
        // create an instance with data type string 
        Student<string> studentName = new Student<string>("Avicii");

        // create an instance with data type int
        Student<int> studentId = new Student<int>(23);

        Employee<string> employeeName = new Employee<string>();

        employeeName.displayData("Jack");

        Employee<int> employeeId = new Employee<int>();

        employeeId.displayData(123);

        // create an instance with data type string 
        Movie<string> movieName = new Movie<string>();
        Console.WriteLine("Generics Method returns: " + movieName.displayData("Inception"));

        // create an instance with data type int  
        Movie<int> movieRating = new Movie<int>();
        Console.WriteLine("Generics Method returns: " + movieRating.displayData(9));

        // creating object of class GFG
        GMVP p = new GMVP();

        // calling Generics method
        p.Display<int>("Integer", 122);
        p.Display<char>("Character", 'H');
        p.Display<double>("Decimal", 255.67);

        Test<string> name = new Test<string>();
        name.value = "Android";

        Test<float> Version = new Test<float>();
        Version.value = 10.0F;

        Console.WriteLine("Operating system: " + name.value);
        Console.WriteLine("Version: " + Version.value);

        Gadget gadgetName = new Gadget();
        Console.WriteLine("Gadget Name: " + gadgetName.displayData("Laptop"));

        Gadget gadgeModel = new Gadget();
        Console.WriteLine("Gadget Model: " + gadgetName.displayData(258617));

        // creating object of Student class
        Student student1 = new Student();

        // accessing name field and printing it
        Console.WriteLine("Name: " + student1.name);

        // accessing print method from Student
        student1.print();
        Console.ReadLine();


    }
}

// Generics class
public class Student<T>
{
    // define a variable of type T 
    public T data;

    // define a constructor of the Student class 
    public Student(T data)
    {
        this.data = data;
        Console.WriteLine("Data passed: " + this.data);
    }
}

//Generic class and method
public class Employee<T>
{
    // define a generics method that displays the passed data  
    public void displayData(T data)
    {
        Console.WriteLine("The data passed is: " + data);
    }
}

//Generic method with return type
public class Movie<T>
{
    // define a generics method that returns T type value    
    public T displayData(T data)
    {
        return data;
    }
}

//Generic method with various parameter
public class GMVP
{

    // Generics method
    public void Display<TypeOfValue>(string msg, TypeOfValue value)
    {
        Console.WriteLine("{0}: {1}", msg, value);
    }
}
//Example
public class Test<T>
{

    // private data members
    private T data;

    // using properties
    public T value
    {
        // using accessors
        get
        {
            return this.data;
        }
        set
        {
            this.data = value;
        }
    }
}

// Generics Method inside Non-Generics Class
public class Gadget
{
    // define a generic method 
    public T displayData<T>(T data)
    {
        return data;
    }
}

namespace MyApplication
{
    class Student
    {
        public string name = "Sheeran"; //if we declare it private -- we are not able to access them from the Program class
        //protected string name = "Sheeran"; 
        //if it is protected need to inherit student class in Program class like "Class Program: Student" 
        public void print() //Same for method if we declare it private
        {
            Console.WriteLine("Hello from Student class");
        }
    }

}



