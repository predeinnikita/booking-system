﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystem.Models.Device
{
    public class DeviceModel
    {
        private readonly DataBase.Device dbDevice;
        public DeviceModel(DataBase.Device dbDevice)
        {
            Id = dbDevice.Id;
            Name = dbDevice.Name;
            Year = dbDevice.Year;
            Description = dbDevice.Description;
            this.dbDevice = dbDevice;
        }

        public DeviceModel(DataBase.Device dbDevice, List<BookingModel> bookings) : this(dbDevice)
        {
            //bookings = bookings.Where(b => b.End > DateTime.Now).ToList();
            bookings.Sort(new Comparison<BookingModel>((x, y) => (int)(x.Start - y.Start).TotalSeconds));
            Bookings = bookings;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public List<BookingModel> Bookings { get; set; }
        public bool IsBooked { 
            get 
            {
                if (dbDevice.Bookings != null)
                {
                    return dbDevice.Bookings.Any(b => DateTime.Now >= b.Start && DateTime.Now <= b.End);
                }
                return false;
            }
        }
    }
}
