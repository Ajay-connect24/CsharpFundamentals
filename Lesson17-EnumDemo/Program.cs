namespace Lesson17_EnumDemo
{
    internal class Program
    {
        enum Gender
        {
            Male,
            Female,
            Unknown
        }

        enum Mobile
        {
            samsung,
            nokia

        }
        static void Main(string[] args)
        {
           //int[] genderValues= Enum.GetValues(typeof(Gender)); //error need typecast
            int[] genderValues = (int[])Enum.GetValues(typeof(Gender));

            //Enum is a class used
            //type of assign the type its imp

            foreach (int value in genderValues)
            {
                Console.WriteLine(value);
            }

            foreach (int value in  Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine(value);
            }


            //string[] genderNames = (string[])Enum.GetNames(typeof(Gender));
            string[] genderNames = Enum.GetNames(typeof(Gender)); //already string array no need to cast
            foreach (string value in genderNames)
            {
                Console.WriteLine(value);
            }


            Gender gender = (Gender) 2;
            int myGender = (int) Gender.Male;

            Gender newGender =(Gender)Mobile.samsung;

            

            //Enum.TryParse();



        }
    }
}

/*
 --Notes
1.used in dropdown
2.

 
 */
