using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    interface IHuman
    {
        string Surname { get; set; }//свойство фамилия
        int Age { get; set; }//свойство возраст
        string Show();//метод
    }
}
