namespace AdventOfCode.Dias {

    class Dia1 {

        public static void Executar() {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\bruno\source\repos\AdventOfCode\AdventOfCode\Dias\inputdia1.txt");
            int[] TotalFood = new int[400];
            int food = 0;
            int elf = 0;
            foreach (string line in lines) {
                if (line != "") {
                    food += int.Parse(line);
                } else {
                    TotalFood[elf] = food;
                    elf++;
                    food = 0;
                }
            }
            Array.Sort(TotalFood);
            Array.Reverse(TotalFood);

            int TopThree = 0;
            int Count = 0;
            foreach (int elffood in TotalFood) {
                if (Count < 3) {
                    TopThree += elffood;
                    System.Console.WriteLine(Count + 1 + ": " + elffood);
                    Count++;
                } else {
                    break;
                }
            }

            System.Console.WriteLine("Eles tem " + TopThree + " calorias no total");
        }
    }
}
