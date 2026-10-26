using System;

class Program
{
    static string InverterString(string text)
    {
        if(text == "") return "Não pode colocar string vazia!";

        int lastIndex = text.Length - 1;

        string Inverter(string text, int index, int lastIndex)
        {
            if(lastIndex < 0) return "";

            return text[lastIndex] + Inverter(text,index,lastIndex-1);
        }

        return Inverter(text,0,lastIndex);
    }
    static void Main()
    {
        Console.WriteLine(InverterString("pneumoultramicroscopicosilicovulcanoconiotico"));
    }
}