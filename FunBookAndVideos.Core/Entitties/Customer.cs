using System;
using System.Collections.Generic;
using System.Text;

namespace FunBookAndVideos.Core.Entitties
{
    public class Customer
    {
        public long CustomerId { get; set; }
        public List<Membership> Memberships { get; set; }
        public int LoyaltyPoints { get; private set; }

        public void AddMembership(Membership membership)
        {
            if (Memberships.Contains(membership)) return;

            Memberships.Add(membership);
        }

        public void AddLoyaltyPoints(int points)
        {
            LoyaltyPoints = points;
        }

    }

    public class PurchaseOrder
    {
        public long PurchaseOrderId { get; set; }
        public long CustomerId { get; set; }
        public decimal TotalPrice { get; set; }
        public List<IProduct> ProductLines { get; set; }
        public PurchaseOrderType PurchaseOrderType { get; set; }
        public List<Membership> Memberships { get; set; }

    }

    public interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
    }

    public class Book : IProduct
    {
        public Book()
        {

        }
        public Book(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Video : IProduct
    {
        public Video()
        {

        }

        public Video(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public enum Membership
    {
        Book,
        Video
    }

    public enum PurchaseOrderType
    {
        Membership,
        Product
    }
}
