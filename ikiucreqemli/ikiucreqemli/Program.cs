float num1 = 500;
float num2 = 500;
float sum = num1 + num2;

if ((sum / 10 >= 1) && (sum/ 10 < 10))
{
    Console.WriteLine("Ikiededlidir");
}
else if ((sum / 100 >= 1) && (sum / 100 < 10))
{
    Console.WriteLine("Ucededlidir");
}
else
{
    Console.WriteLine("nezere alinmayıb");
}