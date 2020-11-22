﻿using System;

namespace DL.DataObjects
{
    public class CopyOfBook
    {
        private Guid _id;
        private Book _book;
        private DateTime _purchaseDate;
        private double _pricePerDay;

        public CopyOfBook(Guid id, Book book, DateTime purchaseDate, double pricePerDay)
        {
            _id = id;
            _book = book;
            _purchaseDate = purchaseDate;
            _pricePerDay = pricePerDay;
        }
        public Guid Id { get => _id; set => _id = value; }
        public Book Book { get => _book; set => _book = value; }
        public DateTime PurchaseDate { get => _purchaseDate; set => _purchaseDate = value; }
        public double PricePerDay { get => _pricePerDay; set => _pricePerDay = value; }

        public override bool Equals(object obj)
        {
            return obj is CopyOfBook book &&
                   _id.Equals(book._id);
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Book)}={Book}, {nameof(PurchaseDate)}={PurchaseDate.ToString()}, {nameof(PricePerDay)}={PricePerDay.ToString()}}}";
        }

    }
}