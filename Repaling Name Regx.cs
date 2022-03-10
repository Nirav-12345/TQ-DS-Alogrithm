using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Nirav Raj, We have your fullname as Nirav Raj in our system.your contact number i 91 7585853052.Please, let us know in case of any clarification Thank you BridgeLabz 01 / 01 / 2016.");


        string text = "name";

        Console.WriteLine(text);
        
        string temp = text.Replace("[/", "[");
        temp = Console.ReadLine();

        Console.WriteLine(temp);

        Console.WriteLine("Replacing Full Name");

        string text2 = "full name";
        string temp2 = text2.Replace("[/", "[");
        temp2 = Console.ReadLine();
        Console.WriteLine("full Name updated");
        Console.WriteLine(temp2);

        Console.WriteLine("Replaing Mobile number");

        string mob_num = "91 + xxxxxxxxx";

        string mob_num1 = mob_num.Replace("[/", "[");

        mob_num1 = Console.ReadLine();
        Console.WriteLine("Mobile number updated");

        Console.WriteLine("91" + mob_num1);

        Console.WriteLine("Replacing date");

        string Date = "XX/XX/XXXX";
        string date1 = Date.Replace("[/", "[");
        date1 = Console.ReadLine();
        Console.WriteLine("Date updated");
        Console.WriteLine(date1);



    }
}