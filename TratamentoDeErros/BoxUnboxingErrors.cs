//__________________________________________________________________________
//Tratando erros com boxing e unboxing

try
{
    //Variável a é do tipo int, b do tipo float e recebe float. Essa divergência gera um erro.
    int a = 001;
    object objA = a;
    float b = (float)objA;

    throw new Exception("Lançado uma exception!");//Erro critico!

}
catch (InvalidCastException ex)//Tratando especificamente o erro de conversão!
{

    Console.WriteLine("Aconteceu um erro na aplicação da conversão de valores." + "\n\r"+ ex);
}
catch (Exception)//O catch tem como parâmentro a classe Exception
{
    Console.WriteLine(" Erro ao executar a aplicação não identificado! ");//Mensagem é exibida ao User em caso de erro.
}

//____________________________________________________________________________

Console.ReadKey();
    


