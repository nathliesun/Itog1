string[] a = new string[] { "good", "123", "ok", "3333" };

void PrintArray(string[] a) // вывод массива
{
    Console.Write("[");
    Console.Write(a[0]);
    for(int i=1;i<a.Length;i++)
    {
        Console.Write(", ");
        Console.Write(a[i]);
    }
    Console.WriteLine("]");
}


int count=0; //счетчик элементов массива с количеством символов <=3'
for(int i=0;i<a.Length;i++)
{
    if(a[i].Length<=3)
        count++;
}
if(count==0)           //если элемнтов с кол-вом символов <=3 нет, прерываем программу
{
    Console.Write("Нет подходящих элементов для массива ");
   return;
}


string[] b = new string[count];  // создаем новый массив с выясненным числом элементов
int j=0;
for(int i=0;i<a.Length;i++)
{
    if(a[i].Length<=3)
       { b[j]=a[i];           // если число символов <=3 то он элемент нового массива
        j++;}
}


PrintArray(a);
Console.Write("Число элементов массива с количеством символов <=3 : ");
Console.WriteLine(count);
PrintArray(b);
