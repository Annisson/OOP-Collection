﻿namespace Encapsulation
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
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException($"\"{value}\" is not valid. First name must be between 2-10 letters");
                }
            }
        }

        public string LName { 
            get { return lName; } 
            set 
            {
                if (value.Length >= 3 && value.Length <= 15)
                {
                    lName = value;
                }
                else
                {
                    throw new ArgumentException($"\"{value}\" is not valid. First name must be between 3-15 letters");
                }
            }
        }

        public double Height { 
            get { return height; } 
            set 
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException($"\"{value}\" is not valid. Height must be greather than 0");
                }
            }
        }
        public double Weight { 
            get { return weight; }
            set 
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException($"\"{value}\" is not valid. Weight must be greather than 0");
                }
            }
        }
    }
}
