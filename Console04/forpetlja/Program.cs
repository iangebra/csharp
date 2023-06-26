// 1. zadatak
// Korisnik unosi dva cijela broja
// Program ispisuje 
// zbroj svih parnih brojeva
// između dva unesena broja

Console.Write("unesi 1. broj ");
int br1 = int.Parse(Console.ReadLine());
Console.Write("unesi 2. broj ");
int br2 = int.Parse(Console.ReadLine());

int manji = br1 < br2 ? br1 : br2;
int veci = br1 > br2 ? br1 : br2;
int zbroj = 0;
for (int i = manji; i <= veci; i++)
{
    zbroj = i % 2 == 0 ? zbroj + i : zbroj;
}
Console.WriteLine(zbroj);


// 2. zadatak
// Program ispisuje brojeve od 100 do 1
// u istom redu odvojeno zarezom

for (int i = 100; i > 0; i--)
{
    Console.Write(i + (i != 1 ? "," : ""));
}