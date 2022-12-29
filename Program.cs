// See https://aka.ms/new-console-template for more information

double denklem_kök1, denklem_kök2, delta,a,b,c;

Console.WriteLine("a değerini giriniz : ");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("b değerini giriniz : ");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("c değerini giriniz : ");
c = Convert.ToDouble(Console.ReadLine());


//delta hesaplaması 
delta = (b * b) - (4 * a * c);
Console.WriteLine("Delta değeri : " + delta);


//deltanın sonucu 0 ise kökler eşittir.
if (delta == 0)
{
    Console.WriteLine("Kökler birbirine eşit ");
    denklem_kök1 = (-1)*(b / (2 * a));
    Console.WriteLine("Denklemin kökleri : " + denklem_kök1);
}

//delte sıfırdan küçük ise reel kök yoktur.
else if (delta < 0)
{
    Console.WriteLine("Reel kök yok. ");
}

//delta sıfırdan büyük ise 2 kök vardır
else 
{
    denklem_kök1 = (((-1)*(b))+ (Math.Sqrt(delta)))/(2*a);
    denklem_kök2 = (((-1) * (b)) - (Math.Sqrt(delta))) / (2 * a);
    Console.WriteLine("Denklemin kökleri : " + denklem_kök1 + " ve " + denklem_kök2);
}
