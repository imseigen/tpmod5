<<<<<<< HEAD
﻿public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
=======
﻿public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
>>>>>>> generic-class
    }
}

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser<string>("Abizar"); 
=======
        DataGeneric<string> data = new DataGeneric<string>("103022330128"); 
        data.PrintData();
>>>>>>> generic-class
    }
}