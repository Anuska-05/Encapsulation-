// // without encapsulation
// //  class Student {public int Age; }
// // Student s= new Student();
// // s.Age= -50; //invalid but allowed 


// // with encapsulation
// Student s = new Student();
// s.SetAge(22);
// Console.WriteLine(s.GetAge()); //22 

// class Student
// {
//     private int age;
//     public void SetAge(int newAge)
//     {
//         if (newAge >= 0 && newAge <= 120) age = newAge;
//         else Console.WriteLine("Invalid age");
//     }
//     public int GetAge() 
//     {
//         return age;
//     }
// }



//properties get and set 
Person p = new Person();
p.Name = "sam";   //set accesor 
Console.WriteLine(p.Name); //get accesor
class Person
{
    private string name = "";
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
