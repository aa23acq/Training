using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Prototype
    {
    }

    public class User
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }


        public bool isOwner { get; set; }
        public User(string name, string address, string email)
        {
            Name = name;
            Address = address;
            Email = email;
        }

        public User DeepCopy()
        {
            return new User(Name, Address, Email);
        }

    }

    public class Purchase : ICloneable
    {
        public User User { get; set; }
        public Product Product { get; set; }
        public DateTime Date { get; set; }

        public Operation Operation { get; set; }
        public int Amount { get; set; }

        public object Clone()
        {
            return new Purchase
            {
                User = this.User.DeepCopy(),
                Product = this.Product.DeepCopy(),
                Date = this.Date,
                Operation = this.Operation,
                Amount = this.Amount
            };
        }

        public Purchase MakePurchase(User user, Product product,   Operation operation, int amount)
        {
           return new Purchase
           {
               User = user,
               Product = product,
               Date = DateTime.Now,
               Operation = operation,
               Amount = amount
           };
        }

        public Purchase CloneAndModify(User user = null, Product? product = null, Operation? operation =null, int? amount =null)
        {
            var clone = (Purchase)Clone();
            clone.User = user ?? clone.User;
            clone.Product = product ?? clone.Product;
            clone.Operation = operation ?? clone.Operation;
            clone.Amount = amount ?? clone.Amount;
            clone.Date = DateTime.Now;
            return clone;
        }

    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Product DeepCopy()
        {
            return new Product(Id, Name, Price);
        }

    }
    public enum Operation {
        BUY, SELL
    }
}
