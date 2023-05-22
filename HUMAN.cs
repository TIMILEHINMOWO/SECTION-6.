using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECTION_6
{
    internal class HUMAN
    {

        // Members
        public string lastName;
        public string firstName;
        public int age;
        public string eyeColour;

        public int width;
        public int length;
        public int area;
        // Property
        public int Area
        {
            get { return width * length; }
            set { area = value; }
        }


        //
        public HUMAN(string lastName, string firstName, int age, string eyeColour)
        {
            this.age = age;
            this.eyeColour = eyeColour;
            this.lastName = lastName;
            this.firstName = firstName;


        }
        // Public memeber method
        public void Introduce()
        {
            Console.WriteLine($"My name is {firstName} {lastName}, I am {age}years old and I have {eyeColour} coloured eyes");

        }
    }
}
