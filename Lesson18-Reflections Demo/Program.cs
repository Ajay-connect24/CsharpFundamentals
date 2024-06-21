using System.Reflection;

namespace Lesson18_Reflections_Demo
{
    class CustomerDemo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        CustomerDemo() { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Type T = Type.GetType("Lesson18_Reflections_Demo.CustomerDemo");
            //var obj =Activator.CreateInstance(T);

            Console.WriteLine(T.FullName);
            Console.WriteLine(T.Name);
            Console.WriteLine(T.Namespace);

            PropertyInfo[] properties = T.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($" Property name => {property.Name} Datatype =>{property.PropertyType.Name}");


            }
            MethodInfo[] methodInfos = T.GetMethods();
            foreach (MethodInfo method in methodInfos)
            {
                Console.WriteLine($"Method Name => {method.Name} Return Type => {method.ReturnType.Name}");
            }
            


            Console.WriteLine("\n ctor");
            ConstructorInfo[] constructorInfos = T.GetConstructors();

            foreach (ConstructorInfo constructorInfo in constructorInfos)
            {
                Console.WriteLine(constructorInfo.Name);
                Console.WriteLine(constructorInfo.ToString());
            }
        }
    }
}
