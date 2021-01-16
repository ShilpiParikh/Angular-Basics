using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssarpAssignment
{
    public class arrangeList
    {
        public void GetUserData2()
        {
            Console.WriteLine("Arranging Elements in the List in Ascending Order");

            var elements = (from x in itemlist.GetItems()
                            select x.itemValue)
                            .Distinct()
                            .OrderBy(a => a);
            foreach (var item in elements)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }

    public class itemlist
    {
        public int itemID { get; set; }
        public int itemValue { get; set; }

        public static List<itemlist> GetItems()
        {
                List<itemlist> elements = new List<itemlist>();
                elements.Add(new itemlist() { itemID = 1, itemValue = 2 });
                elements.Add(new itemlist() { itemID = 2, itemValue = 8 });
                elements.Add(new itemlist() { itemID = 3, itemValue = 1 });
            return elements;
        }
    }
}