using System;

namespace BoxingUnboxing;

class BoxUnboxing
{
    static void Main(string[] args)
    {
        int x = 100;//variável do tipo primitivo(int)
        object obj = x;//boxing i->0(int para object)
        int j = (int)obj;//j recebe o unboxing de o

        Console.WriteLine(" Unboxing realizado com sucesso!O valor de j é: " + j + " \n\r ");



    }
}

