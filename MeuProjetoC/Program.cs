
Console.WriteLine("## Nullable Types##\n");

//Nullable<int> i = null; //todos valores int e nullos
//Nullable<double> d = null;// todos os valores double e nullos
//Nullable<bool> b = null;// valores true e false e nullos
//Console.WriteLine(i);
//Console.WriteLine(d);
//Console.WriteLine(b);

////MELHOR OPÇÃO DE USAR O NULLABLE
//Console.WriteLine();
//Console.WriteLine("Melhor opção de usar o NULLABLE!!");
//int? numero= null;
//double? preco= null;
//bool? VerdadeOuFalso= null;
//Console.WriteLine(numero);
//Console.WriteLine(preco);
//Console.WriteLine(VerdadeOuFalso);
//int mudarnumero = numero??45;
//Console.WriteLine(mudarnumero);

//int? a = null;

//int b = a??100;
//string? Palavra = null;
//string frase = Palavra ??"Utilizando Caalescência nulla";
//Console.WriteLine(frase);
//Console.WriteLine(b);

////////////////////////////////EXEMPLO DE ERRO/////////////////////////////////
//Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$EXEMPLO ERRO$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
//int? x = 4;
//int? y = 3;
//int? z = x * y;
//Console.WriteLine(z);

//////////////////////////////EXEMPLO NULLABLE TYPE: PROPRIEDADE DE LEITURA HASVALUE E VALUE////////////////////////////
Console.WriteLine("--------------------------EXEMPLO DE HASVALUE E VALUE------------------------------");
int? bb = null;
if (bb.HasValue)
{

    Console.WriteLine($"b= {bb.Value}");
}
else { Console.WriteLine("b não possui nenhum valor (null)"); }

Console.ReadKey();
