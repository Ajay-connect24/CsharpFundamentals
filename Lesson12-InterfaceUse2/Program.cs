namespace Lesson12_InterfaceUse2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        
    }

    class Company

    //sealed class Company
    {
        //Company() { }

        public Company() { }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class UST : Company 
    {
    
    }
}

/*
 
1.sealed keyword...cannot be inherited but obj can be made
2.or we can use private constructor

 
 
 
 
 */