




//float [] vector = new float[] { 5, 4 };


//double[] ScaleVector(double[] vector, double k)
//{
//    double[] novy = new double[vector.Length];
//    for (int i = 0; i < vector.Length; i++)
//    {
//       novy[i] = vector[i] * k;
//    }  
//    return novy;
//}
//double myscalar = 2;
//double[] myvector = new double[2];
//myvector[0] = 2;
//myvector[1] = 2;
//double[] a = ScaleVector(myvector, myscalar);

//for (int i = 0;i < a.Length;i++)
//{
//    Console.WriteLine(a[i]);
//}






string replace(string text)
{
   Console.WriteLine("napiš co chceš nahradit");
    string nahrazovac = Console.ReadLine();
    Console.WriteLine("napiš cim chceš nahradit");
    string switchovac = Console.ReadLine();

    char[] ccc = text.ToCharArray();
    for (int i = 0; i < ccc.Length; i++)
    {
        if (ccc[i] == nahrazovac[0]) 
        {
            ccc[i]= switchovac[0];
        }
    }
    string novytext = new string(ccc);
    return novytext;
}

string text = "ahojda";
string hiddentext = replace(text);

Console.WriteLine(text);
Console.WriteLine(hiddentext);


