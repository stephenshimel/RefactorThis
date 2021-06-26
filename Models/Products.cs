using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RefactorThis.Models
{
    public class Products
    {
        public List<Product> _Items { get; private set; }

        public Products(List<Product> Items)
        {
            _Items = Items;
        }

    }

    public class Product
    {
        public Guid _Id { get; set; }

        public string _Name { get; set; }

        public string _Description { get; set; }

        public decimal _Price { get; set; }

        public decimal _DeliveryPrice { get; set; }

        // [JsonIgnore] public bool _IsNew { get; }

        public Product(Guid Id, string Name, string Description, decimal Price, decimal DeliveryPrice)
        {
            _Id = Id;
            _Name = Name;
            _Description = Description;
            _Price = Price;
            _DeliveryPrice = DeliveryPrice;
            // _IsNew = IsNew;
        }




        // public void Delete()
        // {
        //     foreach (var option in new ProductOptions(Id).Items)
        //         option.Delete();

        //     var conn = Helpers.NewConnection();
        //     conn.Open();
        //     var cmd = conn.CreateCommand();

        //     cmd.CommandText = $"delete from Products where id = '{Id}' collate nocase";
        //     cmd.ExecuteNonQuery();
        // }
    }

    public class ProductOptions
    {
        public IEnumerable<ProductOption> _Items { get; private set; }

        public ProductOptions(IEnumerable<ProductOption> Items)
        {
            _Items = Items;
        }

        // public ProductOptions(Guid productId)
        // {
        //     LoadProductOptions($"where productid = '{productId}' collate nocase");
        // }

        // private void LoadProductOptions(string where)
        // {
        //     Items = new List<ProductOption>();
        //     var conn = Helpers.NewConnection();
        //     conn.Open();
        //     var cmd = conn.CreateCommand();

        //     cmd.CommandText = $"select id from productoptions {where}";

        //     var rdr = cmd.ExecuteReader();
        //     while (rdr.Read())
        //     {
        //         var id = Guid.Parse(rdr.GetString(0));
        //         Items.Add(new ProductOption(id));
        //     }
        // }
    }

    public class ProductOption
    {
        public Guid _Id { get; set; }

        public Guid _ProductId { get; set; }

        public string _Name { get; set; }

        public string _Description { get; set; }

        // [JsonIgnore] public bool IsNew { get; }

        public ProductOption(Guid Id, Guid ProductId, string Name, string Description)
        {
            _Id = Id;
            _ProductId = ProductId;
            _Name = Name;
            _Description = Description;
        }

        // public ProductOption(Guid id)
        // {
        //     IsNew = true;
        //     var conn = Helpers.NewConnection();
        //     conn.Open();
        //     var cmd = conn.CreateCommand();

        //     cmd.CommandText = $"select * from productoptions where id = '{id}' collate nocase";

        //     var rdr = cmd.ExecuteReader();
        //     if (!rdr.Read())
        //         return;

        //     IsNew = false;
        //     Id = Guid.Parse(rdr["Id"].ToString());
        //     ProductId = Guid.Parse(rdr["ProductId"].ToString());
        //     Name = rdr["Name"].ToString();
        //     Description = (DBNull.Value == rdr["Description"]) ? null : rdr["Description"].ToString();
        // }

        // public void Save()
        // {
        //     var conn = Helpers.NewConnection();
        //     conn.Open();
        //     var cmd = conn.CreateCommand();

        //     cmd.CommandText = IsNew
        //         ? $"insert into productoptions (id, productid, name, description) values ('{Id}', '{ProductId}', '{Name}', '{Description}')"
        //         : $"update productoptions set name = '{Name}', description = '{Description}' where id = '{Id}' collate nocase";

        //     cmd.ExecuteNonQuery();
        // }

        // public void Delete()
        // {
        //     var conn = Helpers.NewConnection();
        //     conn.Open();
        //     var cmd = conn.CreateCommand();
        //     cmd.CommandText = $"delete from productoptions where id = '{Id}' collate nocase";
        //     cmd.ExecuteReader();
        // }
    }
}