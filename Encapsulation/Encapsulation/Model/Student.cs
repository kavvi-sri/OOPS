using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Model
{
    class Student
    {
        private int id;
        private string name;
        private string email;
        private long mobilenumber;
        private string course;
        private int pincode;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string  Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public long Mobilenumber
        {
            get { return mobilenumber; }
            set { mobilenumber = value; }

        }
        public string Course
        {
            get { return course; }
            set { course = value; }
        }
        public int Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }

       



    }
}
