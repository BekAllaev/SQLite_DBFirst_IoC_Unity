//This code was generated by a tool.
//Changes to this file will be lost if the code is regenerated.
// See the blog post here for help on using the generated code: http://erikej.blogspot.dk/2014/10/database-first-with-sqlite-in-universal.html
using SQLite;
using System;

namespace SQLite_DBFirst_IoC_Unity
{
    public class SQLiteDb
    {
        string _path;
        public SQLiteDb(string path)
        {
            _path = path;
        }

        public void Create()
        {
            using (SQLiteConnection db = new SQLiteConnection(_path))
            {
                db.CreateTable<Categories>();
                db.CreateTable<Customers>();
                db.CreateTable<Employees>();
                db.CreateTable<EmployeesTerritories>();
                db.CreateTable<InternationalOrders>();
                db.CreateTable<OrderDetails>();
                db.CreateTable<Orders>();
                db.CreateTable<PagingTest>();
                db.CreateTable<PreviousEmployees>();
                db.CreateTable<Products>();
                db.CreateTable<Regions>();
                db.CreateTable<Suppliers>();
                db.CreateTable<Territories>();
            }
        }
    }
    public partial class Categories
    {
        [PrimaryKey, AutoIncrement]
        public Int64 CategoryID { get; set; }

        [Indexed(Name = "IX_Categories_CategoryName", Order = 0)]
        [MaxLength(15)]
        [NotNull]
        public String CategoryName { get; set; }

        public String Description { get; set; }

        public Byte[] Picture { get; set; }

    }

    public partial class Customers
    {
        [PrimaryKey]
        [MaxLength(5)]
        public String CustomerID { get; set; }

        [Indexed(Name = "IX_Customers_CompanyName", Order = 0)]
        [MaxLength(40)]
        [NotNull]
        public String CompanyName { get; set; }

        [MaxLength(30)]
        public String ContactName { get; set; }

        [MaxLength(30)]
        public String ContactTitle { get; set; }

        [MaxLength(60)]
        public String Address { get; set; }

        [Indexed(Name = "IX_Customers_City", Order = 0)]
        [MaxLength(15)]
        public String City { get; set; }

        [Indexed(Name = "IX_Customers_Region", Order = 0)]
        [MaxLength(15)]
        public String Region { get; set; }

        [Indexed(Name = "IX_Customers_PostalCode", Order = 0)]
        [MaxLength(10)]
        public String PostalCode { get; set; }

        [MaxLength(15)]
        public String Country { get; set; }

        [MaxLength(24)]
        public String Phone { get; set; }

        [MaxLength(24)]
        public String Fax { get; set; }

    }

    public partial class Employees
    {
        [PrimaryKey, AutoIncrement]
        public Int64 EmployeeID { get; set; }

        [Indexed(Name = "IX_Employees_LastName", Order = 0)]
        [MaxLength(20)]
        [NotNull]
        public String LastName { get; set; }

        [MaxLength(10)]
        [NotNull]
        public String FirstName { get; set; }

        [MaxLength(30)]
        public String Title { get; set; }

        [MaxLength(25)]
        public String TitleOfCourtesy { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        [MaxLength(60)]
        public String Address { get; set; }

        [MaxLength(15)]
        public String City { get; set; }

        [MaxLength(15)]
        public String Region { get; set; }

        [Indexed(Name = "IX_Employees_PostalCode", Order = 0)]
        [MaxLength(10)]
        public String PostalCode { get; set; }

        [MaxLength(15)]
        public String Country { get; set; }

        [MaxLength(24)]
        public String HomePhone { get; set; }

        [MaxLength(4)]
        public String Extension { get; set; }

        public Byte[] Photo { get; set; }

        public String Notes { get; set; }

        [MaxLength(255)]
        public String PhotoPath { get; set; }

    }

    public partial class EmployeesTerritories
    {
        [NotNull]
        public Int64 EmployeeID { get; set; }

        [NotNull]
        public Int64 TerritoryID { get; set; }

    }

    public partial class InternationalOrders
    {
        [PrimaryKey, AutoIncrement]
        public Int64 OrderID { get; set; }

        [MaxLength(100)]
        [NotNull]
        public String CustomsDescription { get; set; }

        [NotNull]
        public Decimal ExciseTax { get; set; }

    }

    public partial class OrderDetails
    {
        [Indexed(Name = "IX_OrderDetails_OrdersOrder_Details", Order = 0)]
        //[Indexed(Name = "IX_OrderDetails_OrderID", Order = 0)]
        [NotNull]
        public Int64 OrderID { get; set; }

        [Indexed(Name = "IX_OrderDetails_ProductsOrder_Details", Order = 0)]
        //[Indexed(Name = "IX_OrderDetails_ProductID", Order = 0)]
        [NotNull]
        public Int64 ProductID { get; set; }

        [NotNull]
        public Decimal UnitPrice { get; set; }

        [NotNull]
        public Int16 Quantity { get; set; }

        [NotNull]
        public Double Discount { get; set; }

    }

    public partial class Orders
    {
        [PrimaryKey, AutoIncrement]
        public Int64 OrderID { get; set; }

        [Indexed(Name = "IX_Orders_CustomersOrders", Order = 0)]
        //[Indexed(Name = "IX_Orders_CustomerID", Order = 0)]
        [MaxLength(5)]
        public String CustomerID { get; set; }

        [Indexed(Name = "IX_Orders_EmployeesOrders", Order = 0)]
        //[Indexed(Name = "IX_Orders_EmployeeID", Order = 0)]
        public Int64? EmployeeID { get; set; }

        [Indexed(Name = "IX_Orders_OrderDate", Order = 0)]
        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        [Indexed(Name = "IX_Orders_ShippedDate", Order = 0)]
        public DateTime? ShippedDate { get; set; }

        public Decimal? Freight { get; set; }

        [MaxLength(40)]
        public String ShipName { get; set; }

        [MaxLength(60)]
        public String ShipAddress { get; set; }

        [MaxLength(15)]
        public String ShipCity { get; set; }

        [MaxLength(15)]
        public String ShipRegion { get; set; }

        [Indexed(Name = "IX_Orders_ShipPostalCode", Order = 0)]
        [MaxLength(10)]
        public String ShipPostalCode { get; set; }

        [MaxLength(15)]
        public String ShipCountry { get; set; }

    }

    public partial class PagingTest
    {
        [PrimaryKey, AutoIncrement]
        public Int64 Id { get; set; }

        [NotNull]
        public Int64 Row { get; set; }

    }

    public partial class PreviousEmployees
    {
        [PrimaryKey, AutoIncrement]
        public Int64 EmployeeID { get; set; }

        [MaxLength(20)]
        [NotNull]
        public String LastName { get; set; }

        [MaxLength(10)]
        [NotNull]
        public String FirstName { get; set; }

        [MaxLength(30)]
        public String Title { get; set; }

        [MaxLength(25)]
        public String TitleOfCourtesy { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        [MaxLength(60)]
        public String Address { get; set; }

        [MaxLength(15)]
        public String City { get; set; }

        [MaxLength(15)]
        public String Region { get; set; }

        [MaxLength(10)]
        public String PostalCode { get; set; }

        [MaxLength(15)]
        public String Country { get; set; }

        [MaxLength(24)]
        public String HomePhone { get; set; }

        [MaxLength(4)]
        public String Extension { get; set; }

        public Byte[] Photo { get; set; }

        public String Notes { get; set; }

        [MaxLength(255)]
        public String PhotoPath { get; set; }

    }

    public partial class Products
    {
        [PrimaryKey, AutoIncrement]
        public Int64 ProductID { get; set; }

        [Indexed(Name = "IX_Products_ProductName", Order = 0)]
        [MaxLength(40)]
        [NotNull]
        public String ProductName { get; set; }

        [Indexed(Name = "IX_Products_SuppliersProducts", Order = 0)]
        //[Indexed(Name = "IX_Products_SupplierID", Order = 0)]
        public Int64? SupplierID { get; set; }

        [Indexed(Name = "IX_Products_CategoryID", Order = 0)]
        //[Indexed(Name = "IX_Products_CategoriesProducts", Order = 0)]
        public Int64? CategoryID { get; set; }

        [MaxLength(20)]
        public String QuantityPerUnit { get; set; }

        public Decimal? UnitPrice { get; set; }

        public Int16? UnitsInStock { get; set; }

        public Int16? UnitsOnOrder { get; set; }

        public Int16? ReorderLevel { get; set; }

        [NotNull]
        public Boolean Discontinued { get; set; }

        public DateTime? DiscontinuedDate { get; set; }

    }

    public partial class Regions
    {
        [PrimaryKey, AutoIncrement]
        public Int64 RegionID { get; set; }

        [MaxLength(50)]
        [NotNull]
        public String RegionDescription { get; set; }

    }

    public partial class Suppliers
    {
        [PrimaryKey, AutoIncrement]
        public Int64 SupplierID { get; set; }

        [Indexed(Name = "IX_Suppliers_CompanyName", Order = 0)]
        [MaxLength(40)]
        [NotNull]
        public String CompanyName { get; set; }

        [MaxLength(30)]
        public String ContactName { get; set; }

        [MaxLength(30)]
        public String ContactTitle { get; set; }

        [MaxLength(60)]
        public String Address { get; set; }

        [MaxLength(15)]
        public String City { get; set; }

        [MaxLength(15)]
        public String Region { get; set; }

        [Indexed(Name = "IX_Suppliers_PostalCode", Order = 0)]
        [MaxLength(10)]
        public String PostalCode { get; set; }

        [MaxLength(15)]
        public String Country { get; set; }

        [MaxLength(24)]
        public String Phone { get; set; }

        [MaxLength(24)]
        public String Fax { get; set; }

        public String HomePage { get; set; }

    }

    public partial class Territories
    {
        [PrimaryKey, AutoIncrement]
        public Int64 TerritoryID { get; set; }

        [MaxLength(50)]
        [NotNull]
        public String TerritoryDescription { get; set; }

        [NotNull]
        public Int64 RegionID { get; set; }

    }

}