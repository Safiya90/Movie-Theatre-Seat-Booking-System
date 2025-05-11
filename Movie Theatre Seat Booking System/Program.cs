namespace Movie_Theatre_Seat_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] seats = new char[5, 5];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    seats[i, j] = 'A';

            while (true)
            {
                Console.WriteLine("Menu:\r\n1-View Seats\r\n2-Book Seat (Enter row and column)\r\n3-Cancel Booking\r\n4-Show Available Seat Count\r\n\r\n5-Exit");
                Console.Write("Please choose from 1 to 5: ");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        Console.WriteLine("\nSeat Layout (A = Available, X = Booked):");
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                                Console.Write(seats[i, j] + " ");
                            Console.WriteLine();
                        }
                        break;
                    case "2":
                        Console.Write("Enter row (0-4): ");
                        int bookRow = int.Parse(Console.ReadLine());
                        Console.Write("Enter column (0-4): ");
                        int bookCol = int.Parse(Console.ReadLine());

                            if (seats[bookRow, bookCol] == 'A')
                            {
                                seats[bookRow, bookCol] = 'X';
                                Console.WriteLine("Seat successfully booked!");
                            }
                            else
                            {
                                Console.WriteLine("Seat already booked.");
                            }
                        break;
                        case "3":
                        Console.Write("Enter row (0-4): ");
                        int cancelRow = int.Parse(Console.ReadLine());
                        Console.Write("Enter column (0-4): ");
                        int cancelCol = int.Parse(Console.ReadLine());
                            if (seats[cancelRow, cancelCol] == 'X')
                            {
                                seats[cancelRow, cancelCol] = 'A';
                                Console.WriteLine("Booking canceled.");
                            }
                            else
                            {
                                Console.WriteLine("This seat was not booked.");
                            }
                        break;
                    case "4":
                        int vailable = 0;
                        for (int i = 0; i < 5; i++)
                            for (int j = 0; j < 5; j++)
                                if (seats[i, j] == 'A') vailable++;
                        Console.WriteLine($"Available Seats: {vailable}");
                        break;

                    case "5":
                        Console.WriteLine("Thank you!");
                        return;

                }
            }
        }
    }
}
