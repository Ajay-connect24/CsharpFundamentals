using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_PropsUse
{
    internal class Student
    {
        private int _id;
        private string Name;
        private int _passmark=35;

        public int Passmark 
        {
            get
            {
                return _passmark;
            }
            
        }
        public int Id
            { 
            get { return _id; }
            set
            {

                if (value < 0)
                {
                    throw new Exception("Invalid Id");

                    
                }
                _id = value;

            }




        }
    }


}
