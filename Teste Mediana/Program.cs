
// Calculo Mediana.
Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

TestaMediana(amostra);
void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo mediana está vazio ou nulo");
    }

    // Cópia do Array anterior
    double[] numerosOrdenados = (double[])array.Clone();
    // Ordena o Array 
    Array.Sort(numerosOrdenados);

    //Calculo para a mediana
    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    // Se for divisivel por 2 (par), é pego o numero do meio do array , se não, é pego o numero do meio - 1 e divide por 2
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra a mediana = {mediana}.");


}