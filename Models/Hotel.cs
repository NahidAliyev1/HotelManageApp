using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManageApp.Exceptions;

namespace HotelManageApp.Models;

public class Hotel
{
    public static int IdCounter = 1;
    public int Id { get; }
    public string Name { get; set; }
    private List<Room> rooms = new();
    public Hotel(string name)
    {
        if (name is null)
        {
            throw new ArgumentException("Adi duzgun daxil edin");
        }
        Id = ++IdCounter;
        Name = name;
    }

    public void AddRoom(Room room)
    {
        rooms.Add(room);
    }
    public List<Room> FindAllRoom(bool isAvailable, int minCapacity)
    {
        List<Room> matchedRooms = new List<Room>();

        foreach (Room room in rooms)
        {
            if (room.IsAvialable == isAvailable && room.PersonCapacity >= minCapacity)
            {
                matchedRooms.Add(room);
            }
        }

        return matchedRooms;
    }

    public void MakeReservation(int? roomId, int customerCount)
    {
        if (roomId == null)
        {
            throw new NullReferenceException("Room ID null ola bilməz.");
        }

        Room selectedRoom = null;

        foreach (Room room in rooms)
        {
            if (room.Id == roomId)
            {
                selectedRoom = room;
                break;
            }
        }

        if (selectedRoom == null)
        {
            throw new Exception("Göstərilən ID-li otaq tapılmadı.");
        }

        if (!selectedRoom.IsAvialable)
        {
            throw new NotAvailableException("Bu otaq artıq rezerv olunub.");
        }

        if (selectedRoom.PersonCapacity < customerCount)
        {
            throw new NotAvailableException("Otaq müştəri sayına uyğun deyil.");
        }

       
        selectedRoom.IsAvialable = false;
        Console.WriteLine("Rezervasiya uğurla tamamlandı.");
    }

}
