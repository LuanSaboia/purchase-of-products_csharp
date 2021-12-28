using System;
using System.Text;
using System.Globalization;

namespace ExProHP.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }
        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufactured date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")");

            return sb.ToString();
        }
    }
}
