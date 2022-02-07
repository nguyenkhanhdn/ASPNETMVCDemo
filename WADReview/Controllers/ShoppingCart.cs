using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WADReview.Controllers
{
    public class ShoppingCart
    {
        // internal member variables
        private String user;
        private DataTable items;
        private Double total;

        // public properties
        public String UserID
        {
            get { return user; }
            set { user = value; }
        }
        public DataTable CartItems
        {
            get { return items; }
            set { items = value; }
        }
        public Double TotalValue
        {
            get { return total; }
            set { total = value; }
        }
        // default constructor
        public ShoppingCart()
        {
            // create an empty shopping cart
            user = String.Empty;
            // create an empty DataTable to hold the cart items
            items = new DataTable("Items");
            items.Columns.Add(new DataColumn("ProductID", Type.GetType("System.String")));
            items.Columns.Add(new DataColumn("Quantity", Type.GetType("System.Int32")));
            items.Columns.Add(new DataColumn("Price", Type.GetType("System.Double")));
            // set total value of the new cart to zero 
            total = 0;
        }
        public void UpdateCart()
        {
            //your Update cart
        }
        public void RemoveItem(string productID)
        {
            DataRow[] rows = items.Select("ProductID='" + productID + "'");
            if (rows.Length > 0)
            {
                items.Rows.Remove(rows[0]);
            }
        }
        // add an item to the cart
        public void AddItem(String proId, Int32 Qty, Double price)
        {
            if (!IsExistItem(proId))
            {
                // create new DataTable row and populate with values - Hàng mới
                DataRow row = items.NewRow();
                row["ProductID"] = proId;
                row["Quantity"] = Qty;
                row["Price"] = price;
                // add row to DataTable update total value
                items.Rows.Add(row);
                total += (Qty * price);
            }
            else
            {
                //tăng số lượng hàng trong giỏ hàng
                for (int i = 0; i < items.Rows.Count; i++)
                {
                    if (items.Rows[i]["ProductID"].Equals(proId))
                    {
                        items.Rows[i]["Quantity"] = int.Parse(items.Rows[i]["Quantity"].ToString()) + Qty;
                        total += (Qty * price);
                        break;//Thoat vong lap
                    }
                }
            }
        }
        public bool IsExistItem(string proID)
        {
            bool b = false;
            if (items.Rows.Count > 0)
            {
                for (int i = 0; i < items.Rows.Count; i++)
                {
                    if (items.Rows[i]["ProductID"].Equals(proID))
                    {
                        b = true;
                        break;//Thoat vong lap
                    }
                }
            }
            return b;
        }
        // empty the cart by clearing the DataTable
        public void Clear()
        {
            items.Rows.Clear();
            total = 0;
        }
    }
}