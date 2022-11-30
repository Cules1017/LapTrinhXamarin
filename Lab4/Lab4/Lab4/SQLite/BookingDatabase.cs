using Lab4.Models;
using SQLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab4.SQLite
{
    public class BookingDatabase
    {
        private readonly SQLiteConnection db;
        public BookingDatabase()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            db = new SQLiteConnection(System.IO.Path.Combine(folder, "BookingDatabase.db3"));
            db.CreateTable<City>();
            db.CreateTable<Hotel>();
            City tinthan = new City();
            tinthan.CityId = 0;
            tinthan.CityName = "An Giang";
            tinthan.CityImageUrl = "ag.jpg";
            Hotel htmau = new Hotel();
            htmau.CityName = "An Giang";
            htmau.HotelName = "Khách sạn Bảy Núi";
            htmau.HotelId = 0;
            htmau.HotelImageUrl = "ht1.jpg";
            this.CreateCity(tinthan);
            this.CreateHotel(htmau);
        }

        //City
        public bool CreateCity(City city)
        {
            try
            {
                db.Insert(city);
                return true;
            }
            catch(SQLiteException e)
            {
                Debug.WriteLine(e);
                return false;
                throw;
            }
        }
        public List<City> ReadCities()
        {
            try
            {
                return db.Table<City>().ToList();   
            }
            catch(SQLiteException e)
            {
                Debug.WriteLine(e);
                return null;
                throw;
            }
        }
        public bool UpdateCity(City city)
        {
            try
            {
                db.Update(city);
                return true;
            }
            catch(SQLiteException e)
            {
                Debug.WriteLine(e);
                return false;
                throw;
            }
        }
        public bool DeleteCity(City city)
        {
            try
            {
                db.Delete(city);
                return true;
            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e);
                return false;
                throw;
            }
        }

        //Hotel
        public bool CreateHotel(Hotel hotel)
        {
            try
            {
                db.Insert(hotel);
                return true;
            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e);
                return false;
                throw;
            }
        }
        public List<Hotel> ReadHotels(City city)
        {
            try
            {
                List<Hotel> list = new List<Hotel>();
                foreach(Hotel h in db.Table<Hotel>().ToList())
                {
                    if(city.CityName == h.CityName)
                    {
                        list.Add(h);
                    }
                };
                return list;
            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e);
                return null;
                throw;
            }
        }
        public bool UpdateHotel(Hotel hotel)
        {
            try
            {
                db.Update(hotel);
                return true;
            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e);
                return false;
                throw;
            }
        }
        public bool DeleteHotel(Hotel hotel)
        {
            try
            {
                db.Delete(hotel);
                return true;
            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e);
                return false;
                throw;
            }
        }
    }
}
