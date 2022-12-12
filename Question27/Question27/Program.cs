using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question25
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item_mast> itemlist = new List<Item_mast>
            {
                new Item_mast{ItemId = 1, ItemDes = "Biscuit"},
                new Item_mast{ItemId = 2, ItemDes = "Choco"},
                new Item_mast{ItemId = 3, ItemDes = "Butter"},
                new Item_mast{ItemId = 4, ItemDes = "Brade"},
                new Item_mast{ItemId = 5, ItemDes = "Honey"}
            };

            List<Purchase> purchlist = new List<Purchase>
            {
                new Purchase{InvNo = 100, ItemId = 3, PurQty = 800},
                new Purchase{InvNo = 101, ItemId = 2, PurQty = 650},
                new Purchase{InvNo = 102, ItemId = 3, PurQty = 900},
                new Purchase{InvNo = 103, ItemId = 4, PurQty = 700},
                new Purchase{InvNo = 104, ItemId = 3, PurQty = 900},
                new Purchase{InvNo = 105, ItemId = 4, PurQty = 650},
                new Purchase{InvNo = 106, ItemId = 1, PurQty = 485}
            };
            Console.Write("Item_mast List : ");
            foreach (var item in itemlist)
            {
                Console.WriteLine("Item Id : {0}, Description : {1} ", item.ItemId, item.ItemDes);
            }

            Console.WriteLine("Purchase List");
            foreach (var item in purchlist)
            {
                Console.WriteLine("Invoice No. : {0}, Item Id : {1}, Quantity : {2}", item.InvNo, item.ItemId, item.PurQty);
            }

            Console.WriteLine("List after joining : ");

            //var innerjoin = from e in itemlist
            //                join d in purchlist on e.ItemId equals d.ItemId
            //                select new
            //                {
            //                    itid = e.ItemId,
            //                    itdes = e.ItemDes,
            //                    prqty = d.PurQty
            //                };
            //foreach (var data in innerjoin)
            //{
            //    Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
            //}

            //Left Outer Join
            //var leftOuterJoin = from item in itemlist
            //                    join purchase in purchlist
            //                    on item.ItemId equals purchase.ItemId
            //                    into a
            //                    from b in a.DefaultIfEmpty(new Purchase())
            //                    select new
            //                    {
            //                        itid = item.ItemId,
            //                        itdes = item.ItemDes,
            //                        prqty = b.PurQty
            //                    };


            //right outer join
            var rightOuterJoin = from p in purchlist
                                 join i in itemlist
                                 on p.ItemId equals i.ItemId
                                 into a
                                 from b in a.DefaultIfEmpty()
                                 select new
                                     {
                                         itid = b.ItemId,
                                         itdes = b.ItemDes,
                                         prqty = p.PurQty
                                     };

            Console.WriteLine("Item ID \t Item Name \t Purchanse Quantity");

            foreach (var data in rightOuterJoin)
            {
                Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
            }
            Console.ReadLine();
        }
    }
    public class Item_mast
    {
        public int ItemId { get; set; }
        public string ItemDes { get; set; }
    }
    public class Purchase
    {
        public int InvNo { get; set; }
        public int ItemId { get; set; }
        public int PurQty { get; set; }
    }
}
