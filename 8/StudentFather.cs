using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _8
{ 
    /// <summary>
    /// класс студента отца-семейства
    /// </summary>
    
    class StudentFather:IHuman, IComparable, ICloneable
    {
        int _age; //возраст
        int _family; //количество человек в семье


        //Свойства
        public string Surname { get; set; }//фамилия
        
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
        public int Family //количество человек в семье
        {
            get
            {
                return _family;
            }
            set
            {
                if (value >= 0)
                {
                    _family = value;
                }
                else MessageBox.Show("Неверные данные!", "Ошибка");
            }

        }

        //реализация интерфейса
        public int CompareTo(object student1)
        {
            IHuman student = (IHuman)student1;
                if (Age > student.Age) return 1;
                if (Age < student.Age) return -1;
                return 0;
        }

        //Метод 
        public string Show()
        {
            string info = "Человек:\n" +
                Surname + " - Фамилия\n" +
                Age + " - Возраст\n" +
                Family + " - Состав семьи\n";
            return info;

        }

        public StudentFather () { }

        //перегруженный метод
        public void SetParams(string surname)
        {
            Surname = surname;

        }
        public void SetParams(int age, int family)
        {
            Age = age;
            Family = family;
        }
        public void SetParams(string surname, int age, int family)
        {
            Surname = surname;
            Age = age;
            Family = family;
        }

        //повехностное клонирование
        public object  Clone()
        {
            return MemberwiseClone();
        }
    }

}

