using System;
using System.Numerics;




//Recursividad:
//1) Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100. 



//Daclarar variables
Console.WriteLine("Números pares del 1 al 100:");
ImprimirPares(2);
Console.ReadLine();

static void ImprimirPares(int n)
{
    //Resolver el algoritmo
    if (n <= 100)
    {
        //Mostrar el resultado
        Console.Write(n + " ");
        ImprimirPares(n + 2);
    }
}




//2) Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n. 


//Declarar variables
Console.Write("Ingrese un número n: ");
int n = int.Parse(Console.ReadLine());

int suma = 0;
//Resolver el algoritmo
for (int i = 1; i <= n; i++)
{
    suma += i;
}
//Mostrar el resultado
Console.WriteLine($"La suma de los números del 1 al {n} es: {suma}");
Console.ReadLine();



//3) Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n. 


//Declarar variables
Console.Write("Ingrese un número n: ");
int nR = int.Parse(Console.ReadLine());

ImprimirPiramide(n);

Console.ReadLine();

//Resolver el algoritmo
static void ImprimirPiramide(int nR, int fila = 1)
{
    if (fila > nR)
        return;

    for (int i = 1; i <= fila; i++)
    {
        Console.Write(i + " ");
    }
    //Mostrar el resultado
    Console.WriteLine();

    ImprimirPiramide(nR, fila + 1);
}




////4) Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n. 

//Declarar variables
Console.Write("Ingrese un número n: ");
int nI = int.Parse(Console.ReadLine());

ImprimirPiramideInvertida(n);

Console.ReadLine();

//Resolver el algoritmo
static void ImprimirPiramideInvertida(int nI, int row = 1)
{
    if (row > nI)
        return;

    ImprimirPiramideInvertida(nI, row + 1);

    for (int i = 1; i <= row; i++)
    {
        //Mostrar el resultado
        Console.Write(i + " ");
    }
    Console.WriteLine();
}





//5) Ejercicio 2: Escribe una función recursiva que imprima la tabla de multiplicar del n. 

//Declarar variables
Console.Write("Ingrese un número para la tabla de multiplicar: ");
int nM = int.Parse(Console.ReadLine());

ImprimirTablaMultiplicar(n, 1);

Console.ReadLine();

//Resolver el algoritmo
static void ImprimirTablaMultiplicar(int nM, int multiplicador)
{
    if (multiplicador > 10)
        return;

    //Mostrar el resultado
    Console.WriteLine($"{nM} x {multiplicador} = {nM * multiplicador}");

    ImprimirTablaMultiplicar(nM, multiplicador + 1);
}





//Arreglos y Matrices: 
//6) Crea una matriz de números reales. 

//Declarar variables
double[,] matriz = {
            { 1.2, 2.5, 3.8, 4.1 },
            { 5.3, 6.7, 7.9, 8.2 },
            { 9.4, 10.1, 11.6, 12.8 }
        };

//Mostrar el resultado
Console.WriteLine("Matriz de números reales:");
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

Console.ReadLine();



//7) Crea una matriz de números complejos. 



//Declarar datos
Complex[,] matrizC = {
            { new Complex(1.2, 3.4), new Complex(5.6, 7.8) },
            { new Complex(9.1, 2.3), new Complex(4.5, 6.7) }
        };

//Mostrar el resultado
Console.WriteLine("Matriz de números complejos:");
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

Console.ReadLine();


//8) Crea una matriz de matrices. 

//Declarar datos
int[][] matrizM = new int[3][];

matrizM[0] = new int[] { 1, 2, 3 };
matrizM[1] = new int[] { 4, 5 };
matrizM[2] = new int[] { 6, 7, 8, 9 };

//Mostrar el resultado
Console.WriteLine("Matriz de matrices de enteros:");
for (int i = 0; i < matrizM.Length; i++)
{
    for (int j = 0; j < matrizM[i].Length; j++)
    {
        Console.Write(matrizM[i][j] + " ");
    }
    Console.WriteLine();
}

Console.ReadLine();



//9) Accede al elemento central de una matriz. 


//Declarar datos
int[,] matrizCE = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

//Resolver el algoritmo
int filas = matrizCE.GetLength(0);
int columnas = matrizCE.GetLength(1);

int filaCentral = filas / 2;
int columnaCentral = columnas / 2;

int elementoCentral = matrizCE[filaCentral, columnaCentral];

//Mostrar el resultado
Console.WriteLine("El elemento central de la matriz es: " + elementoCentral);

Console.ReadLine();



//10) Suma dos matrices de diferentes tamaños. 

//Declarando datos

int[,] matrizA = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

int[,] matrizB = {
            { 7, 8 },
            { 9, 10 },
            { 11, 12 }
        };

//Resolver el algoritmo
if (matrizA.GetLength(0) != matrizB.GetLength(0) || matrizA.GetLength(1) != matrizB.GetLength(1))
{
    Console.WriteLine("No se pueden sumar las matrices debido a diferencias en las dimensiones.");
    return;
}

Console.WriteLine("La suma de las matrices es:");
for (int i = 0; i < matrizA.GetLength(0); i++)
{
    for (int j = 0; j < matrizA.GetLength(1); j++)
    {
        //Mostrar el resultado
        Console.Write((matrizA[i, j] + matrizB[i, j]) + " ");
    }
    Console.WriteLine();
}

Console.ReadLine();



//11) Multiplica una matriz por un número. 

//Declarar los datos
int[,] matrizMU = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

int numero = 2;

//Resolver el algoritmo
Console.WriteLine("Matriz resultante:");
for (int i = 0; i < matrizMU.GetLength(0); i++)
{
    for (int j = 0; j < matrizMU.GetLength(1); j++)
    {
        //Mostrar el resultado
        Console.Write((matrizMU[i, j] * numero) + " ");
    }
    Console.WriteLine();
}

Console.ReadLine();


//12) Calcula la media de los elementos de una matriz. 

//Declarar los datos
int[,] matrizME = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

//Resolver el algoritmo
static double CalcularMediaMatriz(int[,] matrizME)
{
    int suma = 0;
    int totalElementos = matrizME.GetLength(0) * matrizME.GetLength(1);


    foreach (int elemento in matrizME)
    {
        suma += elemento;
    }

    double media = (double)suma / totalElementos;
    return media;
}

//Mostrar el resultado
double media = CalcularMediaMatriz(matrizME);
Console.WriteLine("La media de los elementos de la matriz es: " + media);

Console.ReadLine();


//Ejercicio Matrices: 

//Ejercicio 1: 
//Crea una matriz de números aleatorios de tamaño 100x100. 

//Declarar datos
int[,] matrizAL = new int[100, 100];
Random random = new Random();

//Resolver el algoritmo
for (int i = 0; i < 100; i++)
{
    for (int j = 0; j < 100; j++)
    {
        matrizAL[i, j] = random.Next(1, 101);
    }
}

// Imprimir el resultado
Console.WriteLine("Matriz de números aleatorios de tamaño 100x100:");
for (int i = 0; i < 100; i++)
{
    for (int j = 0; j < 100; j++)
    {
        Console.Write(matrizAL[i, j] + " ");
    }
    Console.WriteLine();
}

Console.ReadLine();


//Ejercicio 2: 
//Calcula la media, la mediana y la desviación estándar de los elementos de una matriz. 

// Declarar los datos
int[,] matrizDE = {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 }
        };

// Resolver el algoritmo
double mediaM = matrizDE.Cast<int>().Average();


int[] elementosOrdenados = matrizDE.Cast<int>().OrderBy(x => x).ToArray();
double mediana = elementosOrdenados[elementosOrdenados.Length / 2];
if (elementosOrdenados.Length % 2 == 0)
{
    mediana = (mediana + elementosOrdenados[elementosOrdenados.Length / 2 - 1]) / 2.0;
}

double desviacionEstandar = Math.Sqrt(matrizDE.Cast<int>().Select(x => Math.Pow(x - media, 2)).Average());

//Imprimir los resultados
Console.WriteLine("Media: " + mediaM);
Console.WriteLine("Mediana: " + mediana);
Console.WriteLine("Desviación estándar: " + desviacionEstandar);

Console.ReadLine();



//Ejercicio 3: 
//Escribe una función que encuentre el elemento máximo de una matriz. 

// Declarar los datos
int[,] matrizMAX = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

// Resolver el algoritmo
int maximo = EncontrarMaximo(matrizMAX);

static int EncontrarMaximo(int[,] matrizMAX)
{
    int maximo = int.MinValue;

    foreach (int elemento in matrizMAX)
    {
        if (elemento > maximo)
        {
            maximo = elemento;
        }
    }

    return maximo;
}

// Mostrar el resulatdo
Console.WriteLine("El elemento máximo de la matriz es: " + maximo);

Console.ReadLine();



//Ejercicio 4: 
//Escribe una función que encuentre la submatriz de mayor suma de una matriz. 
class Program
{
    static void Main(string[] args)
    {
        // Declarar los datos
        int[,] matriz = {
            { 1, 2, -1, 4 },
            { -4, -2, 1, 3 },
            { 5, 0, 2, -7 },
            { -3, 6, 2, 2 }
        };

        // Encontrar la submatriz de mayor suma
        int[,] submatrizMaxima = EncontrarSubmatrizMaxima(matriz);

        // Imprimir la submatriz de mayor suma
        ImprimirMatriz(submatrizMaxima);

        Console.ReadLine();
    }

    static int[,] EncontrarSubmatrizMaxima(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        // Variables para mantener el seguimiento de la mejor submatriz encontrada hasta el momento
        int mejorSuma = int.MinValue;
        int[,] submatrizMaxima = new int[2, 2];

        // Iterar sobre todas las submatrices posibles
        for (int filaInicio = 0; filaInicio < filas; filaInicio++)
        {
            for (int filaFin = filaInicio; filaFin < filas; filaFin++)
            {
                for (int columnaInicio = 0; columnaInicio < columnas; columnaInicio++)
                {
                    for (int columnaFin = columnaInicio; columnaFin < columnas; columnaFin++)
                    {
                        // Calcular la suma de la submatriz actual
                        int sumaActual = 0;
                        for (int i = filaInicio; i <= filaFin; i++)
                        {
                            for (int j = columnaInicio; j <= columnaFin; j++)
                            {
                                sumaActual += matriz[i, j];
                            }
                        }

                        // Actualizar la mejor submatriz encontrada hasta el momento
                        if (sumaActual > mejorSuma)
                        {
                            mejorSuma = sumaActual;
                            submatrizMaxima[0, 0] = filaInicio;
                            submatrizMaxima[0, 1] = columnaInicio;
                            submatrizMaxima[1, 0] = filaFin;
                            submatrizMaxima[1, 1] = columnaFin;
                        }
                    }
                }
            }
        }

        // Crear y devolver la submatriz de mayor suma
        int filaInicioMaxima = submatrizMaxima[0, 0];
        int columnaInicioMaxima = submatrizMaxima[0, 1];
        int filaFinMaxima = submatrizMaxima[1, 0];
        int columnaFinMaxima = submatrizMaxima[1, 1];
        int[,] submatriz = new int[filaFinMaxima - filaInicioMaxima + 1, columnaFinMaxima - columnaInicioMaxima + 1];
        for (int i = filaInicioMaxima; i <= filaFinMaxima; i++)
        {
            for (int j = columnaInicioMaxima; j <= columnaFinMaxima; j++)
            {
                submatriz[i - filaInicioMaxima, j - columnaInicioMaxima] = matriz[i, j];
            }
        }
        return submatriz;
    }
    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}



//Ejercicio 5: 
//Escribe una función que encuentre la matriz de covarianza de dos matrices.

class Program
{
    static void Main(string[] args)
    {
        // Declarar los datos
        double[,] matrizX = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        double[,] matrizY = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };
        //Resolver el algoritmo
        // Calcular la matriz de covarianza entre las dos matrices
        double[,] matrizCovarianza = CalcularMatrizCovarianza(matrizX, matrizY);

        // Imprimir la matriz de covarianza
        ImprimirMatriz(matrizCovarianza);

        Console.ReadLine();
    }

    static double[,] CalcularMatrizCovarianza(double[,] matrizX, double[,] matrizY)
    {
        int columnas = matrizX.GetLength(1);

        // Calcular los vectores de medias de las matrices X e Y
        double[] mediaX = CalcularMedia(matrizX);
        double[] mediaY = CalcularMedia(matrizY);

        // Inicializar la matriz de covarianza
        double[,] matrizCovarianza = new double[columnas, columnas];

        // Calcular la matriz de covarianza
        for (int i = 0; i < columnas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                double covarianza = 0;
                for (int k = 0; k < matrizX.GetLength(0); k++)
                {
                    covarianza += (matrizX[k, i] - mediaX[i]) * (matrizY[k, j] - mediaY[j]);
                }
                matrizCovarianza[i, j] = covarianza / (matrizX.GetLength(0) - 1);
            }
        }

        return matrizCovarianza;
    }

    static double[] CalcularMedia(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        double[] medias = new double[columnas];

        for (int j = 0; j < columnas; j++)
        {
            double suma = 0;
            for (int i = 0; i < filas; i++)
            {
                suma += matriz[i, j];
            }
            medias[j] = suma / filas;
        }

        return medias;
    }

    static void ImprimirMatriz(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

