using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    class Program
    {
        static void Main(string[] args)

        {
            // create collection or list

            List<Myelement> my_list = new List<Myelement>();

            Myelement element1 = new Myelement();
            Myelement element2 = new Myelement();
            Myelement element3 = new Myelement();

            element1.info = "element1";
            element2.info = "element2";
            element3.info = "element3";

            my_list.Add(element2);
            my_list.Add(element3);

            //iterator
            //for (type_of_element var_name in list_name) {
            // var_name
            foreach (Myelement current_element in my_list)

                Console.WriteLine(current_element.info);
            {

                my_list.Clear();

                Console.ReadKey();

            }
        }
    }
}
    
