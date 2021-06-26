using System.Collections;
using RefactorThis.Models;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace RefactorThis.Business
{

    public static class BusinessHandler
    {
        public static Products loadProducts(string where)
        {
            var Items = new List<Product>();
            var conn = Helpers.NewConnection();
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = $"select id from Products {where}";

            var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                var id = Guid.Parse(rdr.GetString(0));
                Items.Add(loadProduct(id));
            }
            return new Products(Items);
        }

        public static Product loadProduct(Guid id)
        {
            // var IsNew = true;
            var conn = Helpers.NewConnection();
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = $"select * from Products where id = '{id}' collate nocase";

            var rdr = cmd.ExecuteReader();
            if (!rdr.Read())
                return null;

            // IsNew = false;
            var Id = Guid.Parse(rdr["Id"].ToString());
            var Name = rdr["Name"].ToString();
            var Description = (DBNull.Value == rdr["Description"]) ? null : rdr["Description"].ToString();
            var Price = decimal.Parse(rdr["Price"].ToString());
            var DeliveryPrice = decimal.Parse(rdr["DeliveryPrice"].ToString());
            return new Product(Id, Name, Description, Price, DeliveryPrice);
        }


        public static void addNewProduct(Product product)
        {
            // todo: add a new product
        }

        public static void editProduct(Guid id, Product product)
        {
            // todo: edit a new product
        }

        public static void deleteProduct(Guid id)
        {
            // todo: delete a new product
        }
        public static void getProductOptions(Guid ProductId)
        {
            // todo: return all options of a product
        }


        public static void getOption(Guid id)
        {
            // todo: return an option
        }
        public static void createOptionForProduct(Guid productId, ProductOption option)
        {
            // todo: create option for a certain product
        }

        public static void updateOptionForProduct(Guid productId, Guid optionId)
        {
            // todo: update option for a certain product
        }

        public static void deleteOptionForProduct(Guid productId, Guid optionId)
        {
            // todo: update option for a certain product
        }

    }


}