using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Калион Екатерина Максимовна. 8 пр.  Создать интерфейс - человек. Создать классы – студент и студент-отец семейства. " +
                "Классы должны включать конструкторы, функцию для формирования строки" +
                "информации о студенте.Сравнение производить по фамилии.");
        }

       
       

        Student student = new Student();//создаем обьект типа студент
        StudentFather student1 = new StudentFather();//создаем обьект типа сдудент1 
        IHuman x1;
        //Выход из программы
        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
       
        //Радиокнопка студент
        private void Student_Checked(object sender, RoutedEventArgs e)
        {
            Surname.Text = "Иванов";
            Age.Text = "19";
            Haracter.Text = "Ленивый";
            student.SetParams(Surname.Text, Convert.ToInt32(Age.Text), Haracter.Text);// используем метод
        }

        //радиокнопка студент отец-семейства
        private void Student1_Checked(object sender, RoutedEventArgs e)
        {
            Surname1.Text = "Петров";
            Age1.Text = "28";
            Family.Text = "4";
            student1.SetParams(Surname1.Text, Convert.ToInt32(Age1.Text), Convert.ToInt32(Family.Text));// испоьзуем метод
        }

        
        private void Haracter1_Click(object sender, RoutedEventArgs e)
        {
                haracter1.Text = student.Show(); //используем метод
        }

        private void Haracter2_Click(object sender, RoutedEventArgs e)
        {
                haracter2.Text = student1.Show(); //используем метод
        }


        //кнопка сравнить
        private void Сравнить_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Age.Text, out int age) && int.TryParse(Age1.Text, out int age1) && age > 0 && age1 > 0)
            {
                Student m1 = new Student();
                m1.Age = Convert.ToInt32(Age.Text);
                StudentFather m2 = new StudentFather();
                m2.Age = Convert.ToInt32(Age1.Text);
                if (m1.CompareTo(m2) == 0) Srav.Text="Возраст равен";
                else if (m1.CompareTo(m2) == -1) Srav.Text = "Второй старше";
                else Srav.Text = "Первый старше";
            }
            else MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Очистить_Click(object sender, RoutedEventArgs e)
        {
            Surname.Clear();
            Surname1.Clear();
            Age.Clear();
            Age1.Clear();
            Haracter.Clear();
            Family.Clear();
            haracter1.Clear();
            haracter2.Clear();
            Srav.Clear();
            Surname2.Clear();
            Age2.Clear();
            Haracter2.Clear();
            haracter3.Clear();
        }

        private void Haracter3_Click(object sender, RoutedEventArgs e)
        {
                haracter3.Text = x1.Show(); //используем метод
        }

        //кнопка клонировать
        private void Клонировать_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Age.Text, out int age)  && age > 0 && Surname.Text != string.Empty && Haracter.Text != string.Empty)
            {
                x1 = (Student)student.Clone();
                Surname2.Text = x1.Surname;
                Age2.Text = Convert.ToString(x1.Age);
                Haracter2.Text = ((Student)x1).Harakter;
            }
            else MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Клонировать1_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Age.Text, out int age) && age > 0 && Surname1.Text != string.Empty && int.TryParse(Family.Text, out int family) && family > 0)
            {
                 x1 = (StudentFather)student1.Clone();
                Surname2.Text = x1.Surname;
                Age2.Text = Convert.ToString(x1.Age);
                Haracter2.Text = Convert.ToString(((StudentFather)x1).Family);
            }
            else MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

}
