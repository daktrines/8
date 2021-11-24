using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _8
{
    /// <summary>
    /// класс студента
    /// </summary>
    

    class Student: IHuman, ICloneable, IComparable
    {
        int _age; //возраст
        
        //Свойства
        public string Surname { get; set; }//фамилия
        public string Harakter { get; set; }//характер

        public int Age //возраст
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
                else MessageBox.Show("Неверные данные!", "Ошибка");
            }
        }
       

        //Метод 
        public string Show()
        {
            string info = "Человек:\n" +
                Surname + " - Фамилия\n" +
                Age + " - Возраст\n" +
                Harakter + " - Характеристика\n";
            return info;

        }

        public Student() { }

        //перегруженный метод
        public void SetParams(string surname)
        {
            Surname = surname;

        }
        public void SetParams(int age, string harakter)
        {
            Age = age;
            Harakter = harakter;
        }
        public void SetParams(string surname, int age, string harakter)
        {
            Surname = surname;
            Age = age;
            Harakter = harakter;
        }
        
        //реализация интерфейса
        public int CompareTo(object student)
        {
            IHuman student1 = (IHuman)student;
            if (Age > student1.Age) return 1;
            if (Age < student1.Age) return -1;
            return 0;
        }

        
        //повехностное клонирование
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}


