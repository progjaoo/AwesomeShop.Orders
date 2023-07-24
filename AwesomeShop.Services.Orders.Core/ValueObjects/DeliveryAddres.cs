﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeShop.Services.Orders.Core.ValueObjects
{
    public class DeliveryAddres
    {
        public DeliveryAddres(string street, string number, string city, string state, string zipCode)
        {
            Street = street;
            Number = number;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }

        public override bool Equals(object? obj)
        {
            return obj is DeliveryAddres addres &&
                   Street == addres.Street &&
                   Number == addres.Number &&
                   City == addres.City &&
                   State == addres.State &&
                   ZipCode == addres.ZipCode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Street, Number, City, State, ZipCode);
        }
    }
}
