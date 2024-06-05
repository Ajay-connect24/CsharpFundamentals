using System.Security.Cryptography.X509Certificates;

namespace Lesson7_Props
{
    internal class Student
    {
        private int _id;
        private string Name;
        private int Passmark;


        public int GetId() { return _id; }
        public void SetId(int id)
        {
            if (id <= 0) { throw new Exception("Student id must be greater than zero"); }
            _id = id;

        }

        public int GetPassMark() { return Passmark; }



        






    }

   
}
