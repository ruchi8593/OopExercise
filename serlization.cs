using System;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
[Serializable]
class Student
{
    int rollno;
    string name;
    public Student(int rollno, string name)
    {
        this.rollno = rollno;
        this.name = name;
    }
}
public class SerializeExample
{
    public static void Main(string[] args)
    {
        FileStream stream = new FileStream("e:\\sss.txt", FileMode.OpenOrCreate);
        BinaryFormatter formatter = new BinaryFormatter();

        Student s = new Student(101, "Nili");
        formatter.Serialize(stream, s);

        Student s = (Student)formatter.Deserialize(stream);
        Console.WriteLine("Rollno: " + s.rollno);
        Console.WriteLine("Name: " + s.name);


        stream.Close();
    }
}