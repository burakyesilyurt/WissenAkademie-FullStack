// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SOLIDSample.SingleResponsibilty;
using static SOLIDSample.SingleResponsibilty.CustomExceptions;

Araba araba = new Araba("Mavi");
BildirimServisi.ArabanınDurumu(araba);

DepoServisi depoServisi = new DepoServisi();
depoServisi.ArabayaBenzinAl(araba);
BildirimServisi.ArabanınDurumu(araba);

MotorServisi motorServisi = new MotorServisi(depoServisi);
motorServisi.MotorCalistir(araba);
BildirimServisi.ArabanınDurumu(araba);

motorServisi.MotorDurdur(araba);
BildirimServisi.ArabanınDurumu(araba);

try
{
    motorServisi.MotorDurdur(araba);
}
catch (MotorZatenCalismiyorException ex)
{
    Console.WriteLine(ex.Message);
}

