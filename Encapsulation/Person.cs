namespace Encapsulation
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age {
            get { return age; } 
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException($"{value} is not valid. Age must be greater then 0");
                }
            }
        }
        public string FName { 
            get {  return fName; } 
            set { fName = value; } 
        }

        public string LName { 
            get { return lName; } 
            set { lName = value; }
        }
        public double Height { 
            get { return height; } 
            set { height = value; }
        }
        public double Weight { 
            get { return weight; }
            set { weight = value; }
        }


    }
}
