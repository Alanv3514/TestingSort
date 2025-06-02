using System;

namespace TestingSort.utils
{
    public static class GeneradorDatos
    {
        public static int[] Enteros32(int cantidad, int semilla)
        {
            int[] datos = new int[cantidad];
            Random rnd = new Random(semilla);
            for (int i = 0; i < cantidad; i++)
            {
                datos[i] = rnd.Next(int.MinValue, int.MaxValue);
            }
            return datos;
        }

        public static long[] Enteros64(int cantidad, int semilla)
        {
            long[] datos = new long[cantidad];
            Random rnd = new Random(semilla);
            for (int i = 0; i < cantidad; i++)
            {
                datos[i] = ((long)rnd.Next(int.MinValue, int.MaxValue) << 32) | (uint)rnd.Next(int.MinValue, int.MaxValue);
            }
            return datos;
        }

        public static float[] Reales32(int cantidad, int semilla)
        {
            float[] datos = new float[cantidad];
            Random rnd = new Random(semilla);
            for (int i = 0; i < cantidad; i++)
            {
                datos[i] = (float)(rnd.NextDouble() * 10000.0);
            }
            return datos;
        }

        public static decimal[] Reales128(int cantidad, int semilla)
        {
            decimal[] datos = new decimal[cantidad];
            Random rnd = new Random(semilla);
            for (int i = 0; i < cantidad; i++)
            {
                datos[i] = (decimal)(rnd.NextDouble() * 10000.0);
            }
            return datos;
        }

        public static string[] Strings(int cantidad, int largo, int semilla)
        {
            string[] datos = new string[cantidad];
            Random rnd = new Random(semilla);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            for (int i = 0; i < cantidad; i++)
            {
                char[] buffer = new char[largo];
                for (int j = 0; j < largo; j++)
                {
                    buffer[j] = chars[rnd.Next(chars.Length)];
                }
                datos[i] = new string(buffer);
            }
            return datos;
        }
    }
}
