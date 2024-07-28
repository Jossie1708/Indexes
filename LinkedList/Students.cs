using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexes
{
    public class Students
    {
        
        private string studentID, degree, name, surname, email;

        //Alt enter for automatic constructor
        public Students(string email, string studentID, string degree, string name, string surname)
        {
            this.email = email;
            this.studentID = studentID;
            this.degree = degree;
            this.name = name;
            this.surname = surname;
        }

        public object this[int index]
        {
            get 
            {
                if (index == 0)
                {
                    return this.studentID;
                }
                else if (index == 1)
                {
                    return this.degree;
                }
                else if (index == 2)
                {
                    return this.name;
                }
                else if(index == 3)
                {
                    return this.surname;
                }
                else if(index == 4)
                {
                    return this.email;
                }
                else
                {
                    return null;
                }
            }
            set 
            {
                if (index == 0)
                {
                    this.studentID = (string)value;
                }
                else if (index == 1)
                {
                    this.degree = (string)value;
                }
                else if (index == 2)
                {
                    this.name = (string)value;
                }
                else if (index == 3)
                {
                    this.surname = (string)value;
                }
                else if (index == 4)
                {
                    this.email = (string)value;
                }
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("stNumber"))
                {
                    return this.studentID;
                }
                else if (attrName.ToLower().Equals("degree"))
                {
                    return this.degree;
                }
                else if (attrName.ToLower().Equals("name"))
                {
                    return this.name;
                }
                else if (attrName.ToLower().Equals("surname"))
                {
                    return this.surname;
                }
                else if (attrName.ToLower().Equals("email"))
                {
                    return this.email;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (attrName.ToLower().Equals("stNumber"))
                {
                    this.studentID = (string)value;
                }
                else if (attrName.ToLower().Equals("degree"))
                {
                    this.degree = (string)value;
                }
                else if (attrName.ToLower().Equals("name"))
                {
                    this.name = (string)value;
                }
                else if (attrName.ToLower().Equals("surname"))
                {
                    this.surname = (string)value;
                }
                else if (attrName.ToLower().Equals("email"))
                {
                    this.email = (string)value;
                }
            }
        }
    }
}
