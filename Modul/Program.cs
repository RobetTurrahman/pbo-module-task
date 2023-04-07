// See https://aka.ms/new-console-template for more information

using System;

class Processor{
  
  public string merk;
  public string tipe;


}

class intel : Processor
{
  public intel()
  {
  base.merk = "Intel";
  }
}
class Corei3 : intel{
  public Corei3()
  {
    base.tipe = "Core i3";

  }
}
class Corei5 : intel{
  public Corei5()
  {
    base.tipe = "Core i5";

  }
}

class Corei7 : intel{
  public Corei7()
  {
    base.tipe = "Core i7";

  }
}

class AMD : Processor
{
  public AMD()
  {
    base.merk = "AMD";
  }
}

class Ryzen : AMD {
  public Ryzen()
  {
    base.tipe = "RYZEN";

  }
}

class Athlon : AMD {
  public Athlon()
  {
    base.tipe = "ATHLON";

  }
}





class Vga{
  public string merk;
}

class Nvidia : Vga
{
  public Nvidia()
  {
  base.merk = "Nvidia";
  }
}

class amd : Vga
{
  public amd()
  {
  base.merk = "AMD";
  }
}




class Laptop{
  public string merk;
  public string tipe;
  public Vga vga;
  public Processor processor;
  public void LaptopDinyalakan()
  {
    Console.WriteLine($"Laptop {merk} {tipe} menyala");
  }
  public void LaptopDimatikan()
  {
    Console.WriteLine($"Laptop {merk} {tipe} mati");
  }
}

class Asus : Laptop
{
  public Asus()
  {
    base.merk = "ASUS";

  } 
}

class rog : Asus
{
  public rog()
  {
    base.tipe = "ROG";
  }
}

class vivobook : Asus
{
  public vivobook()
  {
    base.tipe = "Vivobook";
  }
  public void Ngoding()
  {
    Console.WriteLine($"Ctak ctak ctak, error lagi!!");
  }
}

class Acer : Laptop
{
  public Acer()
  {
    base.merk = "ACER";

  } 
}

class swift : Acer
{
  public swift()
  {
    base.tipe = "Swift";
  }
}

class predator : Acer
{
  public predator()
  {
    base.tipe = "Predator";
  }
  public void BermainGame()
  {
    Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
  }
}

class lenovo : Laptop
{
  public lenovo()
  {
    base.merk = "Lenovo";

  } 
}

class ideapad : lenovo
{
  public ideapad()
  {
    base.tipe = "IdeaPad";
  }
}

class legion : lenovo
{
  public legion()
  {
    base.tipe = "Predator";
  }

}
  
class Program
{
 static void Main(string[] args)
 {
  predator predator = new predator();
  predator.vga = new amd();
  predator.processor = new Ryzen();

  //No 1
  Laptop laptop2 = new ideapad();
  laptop2.vga = new amd();
  laptop2.processor = new Ryzen();
  laptop2.LaptopDinyalakan();
  laptop2.LaptopDimatikan();

  //No 2
  Laptop laptop1 = new vivobook();
  laptop1.vga = new Nvidia();
  laptop1.processor = new Corei5();
  // laptop1.Ngoding();
  
  //No 3
  Console.WriteLine($"laptop1 memiliki merk vga {laptop1.vga} dengan processor {laptop1.processor.merk} {laptop1.processor.tipe}");

  //No 4
  predator.BermainGame();
  Console.WriteLine();


  //No 5
  Acer acer = new Acer();
  acer.vga = new amd();
  acer.processor = new Corei7();
  // acer.BermainGame();
 }

}

