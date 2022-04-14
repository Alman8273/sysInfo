using System;
class sysInfo
{
    static void Main(String [] args)
    {
        string machInfo = Environment.MachineName;        //machine info
        string domainInfo = Environment.UserDomainName;       //current domain
        string userName = Environment.UserName;            //User

        Console.WriteLine("Machine Name {0}", machInfo);
        Console.WriteLine("Domain Name {0}", domainInfo);
        Console.WriteLine("User Name {0}", userName);

    }
}