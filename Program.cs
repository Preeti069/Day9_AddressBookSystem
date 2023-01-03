namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            CreateContacts Contact1 = new CreateContacts("Raj", "Desai", "3/5 jay", "mumbai", "maharastra", 400078, 7021734, "Desai.123@gmail.com");
            CreateContacts Contact2 = new CreateContacts("rutik", "Desai", "3/5 jay", "mumbai", "maharastra", 400078, 8898338, "Desai.432@gmail.com");

            Console.WriteLine(Contact1.First_Name);
            Console.WriteLine(Contact1.Last_Name);
            Console.WriteLine(Contact1.Address);
            Console.WriteLine(Contact1.City);
            Console.WriteLine(Contact1.State);
            Console.WriteLine(Contact1.Zip);
            Console.WriteLine(Contact1.Phone_Number);
            Console.WriteLine(Contact1.E_mail_Id);

            Console.WriteLine(Contact2.First_Name);
            Console.WriteLine(Contact2.Last_Name);
            Console.WriteLine(Contact2.Address);
            Console.WriteLine(Contact2.City);
            Console.WriteLine(Contact2.State);
            Console.WriteLine(Contact2.Zip);
            Console.WriteLine(Contact2.Phone_Number);
            Console.WriteLine(Contact2.E_mail_Id);

        }
    }
}
