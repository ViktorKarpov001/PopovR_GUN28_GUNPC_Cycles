class Arrays
{
    static void Main(string[] args)
    {

        //Задача A: создать 4 массива внутри метода Main:

        //Задание 1:

        int[] a = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };
        for (var i = 0; i < a.Length; i++)
        {
            Console.WriteLine("" + i + ": " + a[i]);
        }
        Console.WriteLine();

        //Задание 2:

        string[] Months = ["January","February","March","April","May","June",
            "July","August","September","October","November","December"];
        for (var i = 0; i < Months.Length; i++)
        {
            Console.WriteLine("" + i + ": " + Months[i]);
        }
        //Задание 3:

        int[,] b = new int[3, 3] {
        {2, 3, 4 }, {4, 9, 16 }, {8, 27, 64 } };

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("" + i + "," + j + ": " + b[i, j]);
            }
        }
        Console.WriteLine();

        //Задание 4:

        //1. Ломаный массив Double:
        int k = 0;
        int l = 0;
        double[][] myArr = new double[4][];
        {
            myArr[0] = new double[3] { 1.00563, 2.3957, 3.1152 };
            myArr[1] = new double[2] { 4.7281, 2.3174 };
            myArr[2] = new double[1] { 5.0390 };
            myArr[3] = new double[4] { 2.3478, 0.2567, 4.2731, 3.2465 };
        }


        for (; k < 3; k++)
        {
            Console.Write("{0}\t", myArr[0][k]);
        }

        Console.WriteLine();
        for (k = 0; k < 2; k++)
        {
            Console.Write("{0}\t", myArr[1][k]);
        }

        Console.WriteLine();
        for (k = 0; k < 1; k++)
        {
            Console.Write("{0}\t", myArr[2][k]);
        }

        Console.WriteLine();
        for (k = 0; k < 4; k++)
        {
            Console.Write("{0}\t", myArr[3][k]);
        }
        Console.WriteLine();
        Console.WriteLine();

        double[] myArr1 = new double[3];
        myArr1[0] = 5.6546;
        myArr1[1] = Math.PI;
        myArr1[2] = Math.E;
        Console.WriteLine(myArr1[0] * myArr1[1]);
        Console.WriteLine(myArr1[0] * myArr1[2]);
        Console.WriteLine();

        double[] log10 = new double[4];
        log10[0] = 1;
        log10[1] = 10;
        log10[2] = 100;
        log10[3] = 1000;

        Console.WriteLine(Math.Log10(log10[0]));
        Console.WriteLine(Math.Log10(log10[1]));
        Console.WriteLine(Math.Log10(log10[2]));
        Console.WriteLine(Math.Log10(log10[3]));
        Console.WriteLine();

        //Задача Б:

        //Задание 5:

        int[] array = { 1, 2, 3, 4, 5 };
        int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
        Array.Copy(array, array2, 3);
        Console.WriteLine((array2[0], array2[1], array2[2], array2[3], array2[4], array2[5], array2[6])); // Топорно...
        Console.WriteLine();

        //Задание 6:

        Array.Resize(ref array, 10);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
