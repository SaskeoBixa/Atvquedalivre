Console.WriteLine("+-------- Calculadora queda livre --------+\n");
Console.Write("Digite a altura (em metros) da queda...: ");
double h = Convert.ToDouble(Console.ReadLine());

const double g = 9.80665; 
double t = Math.Sqrt((2 * h) / g);
double v = Math.Sqrt(2 * h * g);

Console.WriteLine($"O tempo de queda é: {t:n2} s");
Console.WriteLine($"A velocidade final é: {v:n4} m/s");