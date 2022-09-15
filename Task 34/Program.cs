Console.WriteLine("Введите количество элементов в массиве:");

            Random rnd = new Random();
            int a = 0;

            bool numberCheck = int.TryParse(Console.ReadLine(),out int a_size);
            if (numberCheck)
            {
                int[] a_array = new int[a_size];
                for (int i = 0; i < a_size; i++)
                {
                    a_array[i] = rnd.Next(100, 999);
                    if (a_array[i] % 2 == 0) a++;
                }
                Console.WriteLine("[" + String.Join(", ", a_array) + "] -> " + a);

            }
            else Console.WriteLine("не число");