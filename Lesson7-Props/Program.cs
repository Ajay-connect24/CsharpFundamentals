namespace Lesson7_Props
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetId(1); 
            //student.Name = "thomas";
            //student.Passmark = 0;

            //Console.WriteLine($"Id = {student.GetId()} , Name ={student.Name} , PassMark ={student.Passmark}");
        }

    }
}

/*

---Notes
1.remove unnessry using..right click..quick actions and refactoring
2.getters and setters => giving controls
3.we have properties instead of getter and setters.
4.prop + tab for get and set
5. if a class is static then all methods must be static.it cannot create an object
6.non static class can have static methods
7.even if class is non static and method is static we can use that method in another class




 */
