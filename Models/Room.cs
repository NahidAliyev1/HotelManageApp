using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManageApp.Models;

public class Room
{
    public static int IdCounter = 1;
    public int Id { get; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int PersonCapacity { get; set; }
    public bool IsAvialable { get; set; }


    public Room(string name,decimal  price,int personcapacity)
    {
        if (name is null && price<=0 && personcapacity<=0)
        {
            throw new ArgumentException("Bütün məlumatlar düzgün daxil edilməlidir!");
        }
        Id = ++IdCounter;
        Name = name;
        Price = price;
        PersonCapacity = personcapacity;
        IsAvialable = true;
    }


    public override string ToString()
    {
        return ShowInfo();
    }
    public string ShowInfo()
    {
        return $"Ad: {Name}, Qiymet: {Price}, Insan tutumu: {PersonCapacity}";
    }
}
