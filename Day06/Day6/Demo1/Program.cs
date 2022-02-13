using Utility;
namespace Demo1;
class Program
{
    static void Main()
    {
        Complex c1 = new Complex(10, 20);
        Complex c2= new Complex(10, 20);
       //c1 = c2;
        if (c1 .Equals( c2))
        {
            Console.WriteLine("c1==c2");
        }
        else
            Console.WriteLine("c1!=c2");
    }
    static void Main4()
    {
        float z = 2.3f;
        int y = (int)z;
        Complex c1 = new Complex(10, 20);
        int x =(int) c1;
        Console.WriteLine(x);
        Complex c2 = new Complex(5, 6);
        Complex c4;
        c2 += c1;
        Console.WriteLine(c1);
        Console.WriteLine(c2);
        Complex c3=c1 + c2;
        ++c1;
        Console.WriteLine(c3);
        Console.WriteLine(c1);
    }
    public static void Main3()
    {


        NIC n1 = NIC.CreateNIC("192.168.1.2");
        Console.WriteLine(n1.GetHashCode());
        NIC n2=NIC.CreateNIC("255.255.255.255");
        Console.WriteLine(n2.GetHashCode());
        Console.WriteLine(n1.IP);
        Console.WriteLine(n2.IP);

    }
    public static void Main2()
    {
        Console.WriteLine(BankAccount.InterstRate);
        BankAccount.InterstRate = 50;
        BankAccount b1=new BankAccount() { Id=10,Name="Ahmed",Balnce=2000};
        BankAccount b2 = new BankAccount() { Id = 20, Name = "sara", Balnce = 2000 };
        BankAccount b3 = new BankAccount() { Id = 30, Name = "alyaa", Balnce = 2000 };
        
        b1.Print();
        b2.Print();
        b3.Print();
        
        Console.WriteLine(BankAccount.InterstRate);
    }
    public static  void myfun()
    {
        Complex c1 = new Complex(8,10);// {Real=1,Img=3 };
        Complex c2 = new Complex(c1);
        c1.Real = 20;
        Console.WriteLine(c1);
        Console.WriteLine(c2);
    }
   
}
