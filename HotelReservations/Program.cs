using System;

namespace HotelReservations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test 1: \n");

            Hotel hotel1 = new Hotel(1);
            hotel1.makeReservations(-2, 4);
            hotel1.makeReservations(200, 400);

            Console.WriteLine("\nTest 2: \n");

            Hotel hotel2 = new Hotel(3);
            hotel2.makeReservations(0, 5);
            hotel2.makeReservations(7, 13);
            hotel2.makeReservations(3, 9);
            hotel2.makeReservations(5, 7);
            hotel2.makeReservations(6, 6);
            hotel2.makeReservations(0, 4);

            Console.WriteLine("\nTest 3: \n");

            Hotel hotel3 = new Hotel(3);
            hotel3.makeReservations(1, 3);
            hotel3.makeReservations(2, 5);
            hotel3.makeReservations(1, 9);
            hotel3.makeReservations(0, 15);

            Console.WriteLine("\nTest 4: \n");

            Hotel hotel4 = new Hotel(3);
            hotel4.makeReservations(1, 3);
            hotel4.makeReservations(0, 15);
            hotel4.makeReservations(1, 9);
            hotel4.makeReservations(2, 5);
            hotel4.makeReservations(4, 9);

            Console.WriteLine("\nTest 5: \n");

            Hotel hotel5 = new Hotel(2);
            hotel5.makeReservations(1, 3);
            hotel5.makeReservations(0, 4);
            hotel5.makeReservations(2, 3);
            hotel5.makeReservations(5, 5);
            hotel5.makeReservations(4, 10);
            hotel5.makeReservations(10, 10);
            hotel5.makeReservations(6, 7);
            hotel5.makeReservations(8, 10);
            hotel5.makeReservations(8, 9);
        }
    }
}
