using _4_EjemploMVVM.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EjemploMVVM.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; set; }

        public PersonViewModel()
        {
            Person = new Person
            {
                Name = "Héctor",
                Age = 50,
                Married = "yes",
                BirthDate = DateTime.Now,
                Weight = 50,
                LunchTime = DateTime.Now.TimeOfDay,
            };
        }
    }
}
