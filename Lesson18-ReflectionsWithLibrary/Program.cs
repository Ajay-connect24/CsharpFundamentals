using System.Reflection;

namespace Lesson18_ReflectionsWithLibrary
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load("CustomerLibrary");
            Type T = assembly.GetType("CustomerLibrary.CustomerDemo");
            //Type T = Type.GetType("Lesson18_Reflections_Demo.CustomerDemo");
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
            ConstructorInfo[] constructorInfos = T.GetConstructors();

            foreach (ConstructorInfo constructorInfo in constructorInfos)
            {
                Console.WriteLine(constructorInfo.Name);
                Console.WriteLine(constructorInfo.ToString());
            }
        }

        //void SetAssembly(string assemblyName , string className)
        //{
        //    Assembly assembly = Assembly.Load(assemblyName);
        //    Type T = assembly.GetType("CustomerLibrary.CustomerDemo");

        //    Activator.CreateInstance(T);

        //}
    }
}
