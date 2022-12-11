namespace AdventOfCode.Dias {
    internal class Calendario {
        Dictionary<string, Action> Dias;

        public Calendario(Dictionary<string, Action> dia) {
            Dias = dia;
        }

        public void SelecionarEExecutar() {
            int i = 1;

            foreach (var dia in Dias) {
                Console.WriteLine("{0}) {1}", i, dia.Key);
                i++;
            }

            Console.Write("Digite o dia (Ou deixe vazio para o último) ");

            int.TryParse(Console.ReadLine(), out int num);
            bool numValido = num > 0 && num <= Dias.Count;
            num = numValido ? num - 1 : Dias.Count - 1;

            string numeroDoDia = Dias.ElementAt(num).Key;

            Console.Write("\nExecutando exercício ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(numeroDoDia);
            Console.ResetColor();

            Console.WriteLine(String.Concat(
                Enumerable.Repeat("=", numeroDoDia.Length + 21)) + "\n");

            Action executar = Dias.ElementAt(num).Value;
            try {
                executar();
            } catch (Exception e) {
                Console.WriteLine("Ocorreu um erro: {0}", e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}

