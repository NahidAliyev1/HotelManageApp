using System.Xml.Linq;
using HotelManageApp.Exceptions;
using HotelManageApp.Models;
namespace HotelManageApp;
public class Program
{
   public static List<Hotel> hotels = new List<Hotel>();
    string selectedHotel = null;
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("******Menu******");
            Console.WriteLine("1.Sisteme giris");
            Console.WriteLine("0.Cixis");
            Console.WriteLine("secim edin  ");
            string choose = Console.ReadLine();


            switch (choose)
            {
                case "0":
                    break;
                case "1":
                    LoginMenu();
                    break;
                default:
                    Console.WriteLine("Duzgun secim edin");
                    break;
            }
        }
        
       

    }
    static void LoginMenu()
    {
        while (true)
        {
            Console.WriteLine("1.Hotel yarat");
            Console.WriteLine("2.Butun Hotelleri gor");
            Console.WriteLine("3.Hotel sec");
            Console.WriteLine("0.Exit");
            Console.WriteLine("Secim edin");
            string choose = Console.ReadLine();

            switch (choose)
            {
                case "0":
                    break;
                case "1":
                    CreateHotel();
                    break;
                case "2":
                    ShowAllHotel();
                    break;
                case "3":
                    SelectedHotel();
                    break;
                default:
                    Console.WriteLine("duzgun secim edin");
                    break;
            }
        }
    }
    static void CreateHotel() 
    {
        Console.WriteLine("Hotelin adi_");
        string hotellname = Console.ReadLine();

        if (hotellname is null)
        {
            Console.WriteLine("Hotel adi bos ola bilmezzz");
        }

        Hotel hotel = new Hotel(hotellname);
        hotels.Add(hotel);
        
        
        Console.WriteLine("Hotel ugurla yaradildi.");
    }


    static void ShowAllHotel()
    {
        if (hotels.Count == 0)
        {
            Console.WriteLine("Hec bir hotel yoxdur.");
            return;
        }

        Console.WriteLine("--- Butun Hoteller ---");
        foreach (Hotel hotel in hotels)
        {
            Console.WriteLine($"ID: {hotel.Id} - Ad: {hotel.Name}");
        }
        HotelMenu();
    }

    static void HotelMenu() { 
    }

    }


