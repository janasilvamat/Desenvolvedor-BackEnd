//Declaração de variáveis
double ladoA_x, ladoB_x, ladoC_x;
double ladoA_y, ladoB_y, ladoC_y;
double perimetro_X, perimetro_Y;
double area_X, area_Y;

//Entrada de dados
Console.WriteLine("Entre com as medidas do triangulo X");
Console.Write("Lado A = ");
ladoA_x = double.Parse(Console.ReadLine());
Console.Write("Lado B = ");
ladoB_x = double.Parse(Console.ReadLine());
Console.Write("Lado C = ");
ladoC_x = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com as medidas do triangulo Y");
Console.Write("Lado A = ");
ladoA_y = double.Parse(Console.ReadLine());
Console.Write("Lado B = ");
ladoB_y = double.Parse(Console.ReadLine());
Console.Write("Lado C = ");
ladoC_y = double.Parse(Console.ReadLine());

//Perimetro dos triangulos
perimetro_X = (ladoA_x + ladoB_x + ladoC_x) / 2;
perimetro_Y = (ladoA_y + ladoB_y + ladoC_y) / 2;

//Area dos triangulos
area_X = Math.Sqrt(perimetro_X * (perimetro_X - ladoA_x) * (perimetro_X - ladoB_x) * (perimetro_X - ladoC_x));
area_Y = Math.Sqrt(perimetro_Y * (perimetro_Y - ladoA_y) * (perimetro_Y - ladoB_y) * (perimetro_Y - ladoC_y));

//Saida de dados
Console.WriteLine($"Area do triangulo X = {area_X}");
Console.WriteLine($"Area do triangulo Y = {area_Y}");
Console.WriteLine(area_X > area_Y ? "O triangulo X tem maior area" : "O triangulo Y tem maior area");