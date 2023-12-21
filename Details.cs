using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Details
    {
        private string[] firstName;
        private string[] middleName;
        private string[] lastName;
        private string[] Age;

        public Details()
        {
            firstName = new string[] {};
            middleName = new string[] { };
            lastName = new string[] { };
            Age = new string[] { };
        }

        public string[] GetFirstName()
        {
            return (string[])firstName.Clone();
        }

        public string[] GetMiddleName()
        {
            return (string[])middleName.Clone();
        }

        public string[] GetLastName()
        {
            return (string[])lastName.Clone();
        }

        public string[] GetAge()
        {
            return (string[])Age.Clone();
        }

        public void AddDataFirstName(string fn)
        {
            Array.Resize(ref firstName, firstName.Length + 1);
            firstName[firstName.Length - 1] = fn;
        }

        public void AddDataMiddleName(string mn)
        {
            Array.Resize(ref middleName, middleName.Length + 1);
            middleName[middleName.Length - 1] = mn;
        }

        public void AddDataLastName(string ln)
        {
            Array.Resize(ref lastName, lastName.Length + 1);
            lastName[lastName.Length - 1] = ln;
        }

        public void AddAge(string age)
        {
            Array.Resize(ref Age, Age.Length + 1);
            Age[Age.Length - 1] = age;
        }
    }
}
