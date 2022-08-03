using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Exception_task
{
    public class Furniture
    {
        public string OrderId;
        public int OrderDate;
        public string FurnitureType;
        public int Qty;
        public float TotalAmt;
        public string PaymentMode;
        public Furniture()
        {

        }
        public void GetData()
        {
            Console.WriteLine("Enter your order Id");
            this.OrderId = Console.ReadLine();
            Console.WriteLine("Enter your order date");
            this.OrderDate = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your order furniture type either chair or cot");
            this.FurnitureType = Console.ReadLine();
            Console.WriteLine("Enter Quantity");
            this.Qty = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter total amount");
            this.TotalAmt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter payment mode ");
            this.PaymentMode = Console.ReadLine();
        }
        public void ShowData()
        {
            Console.WriteLine("Order Id is : {0}", OrderId);
            Console.WriteLine("Order Date is : {0}", OrderDate);
            Console.WriteLine("Furniture Type is : {0}", FurnitureType);
            Console.WriteLine("Qty is : {0}", Qty);
            Console.WriteLine("Total amt is : {0}", TotalAmt);
            Console.WriteLine("Payment mode is : {0}", PaymentMode);
        }
    }
    class Chair : Furniture
    {
        public string ChairType;
        public string Purpose;
        public string Color;
        public void GetDataChair()
        {
            Console.WriteLine("Choose a chair type either Wood/Steel/Plastic");
            this.ChairType=Console.ReadLine();
           
            Console.WriteLine("Choose purpose of chair either home/office");
            this.Purpose = Console.ReadLine();
            if (ChairType == "Wood" || ChairType=="wood" )
            {
                Console.WriteLine("Enter chair color either Teak Wood/Rose Wood");
                this.Color = Console.ReadLine();
            }
            if (ChairType == "Steel" || ChairType=="steel")
            {
                Console.WriteLine("Enter chair color either Gray Steel/Green Steel/Brown Steel");
                this.Color = Console.ReadLine();
            }
            if (ChairType == "Plastic" || ChairType=="plastic")
            {
                Console.WriteLine("Enter chair color either Green/Red/Blue/White");
                this.Color = Console.ReadLine();
            }
          
        }
        public void ShowDataChair()
        {
            Console.WriteLine("Chair Type  is : {0}", ChairType);
            Console.WriteLine("Purpose is : {0}", Purpose);
            Console.WriteLine("Color is : {0}", Color);
            
        }

    }
    class Cot : Furniture
    {
        string CotType;
        string Color;
        string Capacity;
        public void GetDataCot()
        {
            Console.WriteLine("Choose a cot type either Wood/Steel");
            this.CotType = Console.ReadLine();

            try
            {
                if (CotType == "Wood" || CotType == "wood")
                {
                    Console.WriteLine("Enter chair color either Teak Wood/Rose Wood");
                    this.Color = Console.ReadLine();
                }
                if (CotType == "Steel" || CotType == "steel")
                {
                    Console.WriteLine("Enter chair color either Gray Steel/Green Steel/Brown Steel");
                    this.Color = Console.ReadLine();
                }
                else
                {
                    throw new InvalidType();
                }
              
            }
            catch (InvalidType e)
            {
                e.InvalidChairType();
               
            };
            Console.WriteLine("Enter cot capacity either single or double");
            this.Capacity = Console.ReadLine();

        }

        public void ShowDataCot()
        {
            Console.WriteLine("Cot Type  is : {0}", CotType);
            Console.WriteLine("Color is : {0}", Color);
            Console.WriteLine("Capacity is : {0}", Capacity);

        }

    }

    class InvalidType : Exception
    {
        public void InvalidChairType()
        {
           Console.WriteLine("Invalid Chair Type");
        }
        public void InvalidCotType()
        {
            Console.WriteLine("Invalid Cot Type");
        }
    }

}


