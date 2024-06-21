using System.Collections;

namespace Lesson22_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("hello");
            arrayList.Add(numbers);
            arrayList.Add(new Customer());

            foreach (var item in arrayList)
            {
                Console.WriteLine(item.ToString());
                
            }

            Console.WriteLine(arrayList[0]);

            //int number1 = arrayList[0]; //error coz it acts as an object
            int number2 = (int) arrayList[0];  //this is unboxing

            string hello = (string) arrayList[1];

            //non typesafe
            //so list was made . which suport generics


            List<int> nums =new List<int>();
            nums.Add(1);
            //nums.Add("hello"); //coz typesafe

            List<int> nums1 = new List<int>() {  1 ,2 ,3 ,4 };

            nums1.Insert(0, 10); //insert at index 0

            nums1.FindAll(number => number == 10);



            List<int> list = nums1.FindAll(number => number %2 == 0);

            IEnumerable evenList1 = nums1.FindAll(number => number % 2 == 0);

            IEnumerable<int> evenList2 = nums1.FindAll(number => number % 2 == 0);



            nums1.Find(x => x==10);  //returns first matching value

            nums1.IndexOf(2);

            nums.Contains(1);  //param is int

            nums.Exists(x => x==10);//param condition return list

            nums.RemoveAll(x => x==10);

            nums.ForEach(number => Console.WriteLine(number));








        }
    }
    class Customer 
    { }
}

//arraylist is a non generics collection of objects
//its not type safe
//can contain hetrogenous data
//all class that implements the IEnumerable can hace foreach loop
//to access it in other we need to implement IEnumerate here in Customer 
//tostring default is namespace+class