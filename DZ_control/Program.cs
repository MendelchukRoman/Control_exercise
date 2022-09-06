string[] Massiv;
            Console.WriteLine("Первоначальный массив");
            string first_massiv = Console.ReadLine();
            Massiv = first_massiv.Split(' ');
            var result = new string[Massiv .Length];
            var realSize = 0;
            foreach (var value in Massiv )
            {
                if (value.Length <= 3)
                {
                    result[realSize] = value;
                    realSize++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));