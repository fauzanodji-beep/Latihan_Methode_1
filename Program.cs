int c= 0;

void tambah (int a, int b)
{
    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");

}
void kurang (int a, int b)
{
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");

}
void kali (int a, int b)
{
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");

}
void bagi (int a, int b)
{
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");

}

tambah(8,3);
kurang(13,10);
kali(22,4);
bagi(50,5);
