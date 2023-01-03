namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            CreateContact CreateContact = new CreateContact();

            Console.WriteLine("Enter the first name :");
            CreateContact.First_Name = Console.ReadLine();

            Console.WriteLine("Enter the last name :");
            CreateContact.Last_Name = Console.ReadLine();

            Console.WriteLine("Enter the Address :");
            CreateContact.Address = Console.ReadLine();

            Console.WriteLine("Enter the city name :");
            CreateContact.City = Console.ReadLine();

            Console.WriteLine("Enter the state name :");
            CreateContact.State = Console.ReadLine();

            Console.WriteLine("Enter the zip number :");
            CreateContact.Zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the phone number :");
            CreateContact.Phone_Number = (int)Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter the E mail id :");
            CreateContact.E_mail_Id = Console.ReadLine();

            Console.WriteLine(CreateContact.First_Name);
            Console.WriteLine(CreateContact.Last_Name);
            Console.WriteLine(CreateContact.Address);
            Console.WriteLine(CreateContact.City);
            Console.WriteLine(CreateContact.State);
            Console.WriteLine(CreateContact.Zip);
            Console.WriteLine(CreateContact.Phone_Number);
            Console.WriteLine(CreateContact.E_mail_Id);

        }
    }
}
