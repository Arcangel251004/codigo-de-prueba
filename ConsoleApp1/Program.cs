// See https://aka.ms/new-console-template for more information
/*Al cerrar un expendio de naranjas, 15 clientes que aún no han pagado,
  recibirán un 15% de descuento si compran más de 10 kilos. 
  Determinar cuánto pagará cada cliente y cuanto percibirá la tienda por
 esas compras.*/
const int N = 5;
int kilos, valorkilos;
double totalpagar, cuentatotal;
for (int i = 0; i <= N; i++)
{
    Console.WriteLine("Cuantos kilos comprara:  ");
    kilos = int.Parse(Console.ReadLine());
    valorkilos = 84;
    if (kilos > 10)
    {
        cuentatotal = kilos * valorkilos;
        totalpagar = cuentatotal - cuentatotal * 0.15;
    }
    else
        totalpagar = kilos * valorkilos;
    Console.WriteLine("el cliente pagara: " + totalpagar);

}
Console.ReadKey();
