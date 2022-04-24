Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumN(int N){
    
int a = Convert.ToString(N).Length;
int b = 0;
int result = 0;

for (int i = 0; i < a; i++)
{
  b = N - N % 10;
  result = result + (N - b);
  N = N / 10;
}
return result;
}

int sumN = SumN(N);
Console.WriteLine("Сумма цифр: " + sumN);
