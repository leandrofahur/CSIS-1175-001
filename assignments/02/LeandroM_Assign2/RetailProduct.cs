using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeandroM_Assign2
{
    class RetailProduct
    {
        // Read-write auto-property:
        public string ProductCode
        {
            get;
            set;
        }

        public string ProductName
        {
            get;
            set;
        }

        public int StartingQty
        {
            get;
            set;
        }

        public int MinQty
        {
            get;
            set;
        }

        public int SoldQty
        {
            get;
            set;
        }
            
        public int RestockedQty
        {
            get;
            set;
        }

        public double UnitPrice
        {
            get;
            set;
        }

        // Read-only properties:
        public int AvailableQty
        {
            get
            {
                return StartingQty - SoldQty + RestockedQty;
            }
        }

        
        public double Sales
        {
            get
            {
                return SoldQty * UnitPrice;
            }
        }

        // Constructor:
        public RetailProduct(string productCode, string productName, int startingQty, int minQty, int soldQty, int restockedQty, double unitPrice)
        {
            ProductCode = productCode;
            ProductName = productName;
            StartingQty = startingQty;
            MinQty = minQty;
            SoldQty = soldQty;
            RestockedQty = restockedQty;
            UnitPrice = unitPrice;
        }

        public override string ToString()
        {
            return string.Format("{0:10}\t{1:21}\t{2:12}\t{3:7}\t{4:8}\t{5:13}\t{6:C}",
                                 ProductCode,
                                 ProductName,
                                 StartingQty,
                                 MinQty,
                                 SoldQty,
                                 RestockedQty, 
                                 UnitPrice);
        }
    }
}
