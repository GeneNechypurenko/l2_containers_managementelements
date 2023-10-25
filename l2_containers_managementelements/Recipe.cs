using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2_containers_managementelements
{
    //Создать приложение рецепты.Рецепт содержит: название, описание, дата добавления.
    //    Реализовать возможность добавление и вывода всех рецептов из списка.
    internal class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime addDate { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Description}. {addDate.ToShortDateString()}";
        }
    }
}
