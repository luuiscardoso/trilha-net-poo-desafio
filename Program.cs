using DesafioPOO.Models;

class Program{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia("82675813", "Modelo 1", "1234F12", 12);

        Iphone iphone = new Iphone("81375814", "Modelo 1", "1234F12", 12);

        nokia.Ligar();
        nokia.InstalarAplicativo("Facebook");

        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");
    }
}
