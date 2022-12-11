using AdventOfCode.Dias;

namespace AdventOfCode {
    internal class Program {
        static void Main(string[] args) {
            var calendario = new Calendario(new Dictionary<string, Action>() {
                {"Dia 1", Dia1.Executar},
                {"Dia 2", Dia2.Executar},
            });

            calendario.SelecionarEExecutar();
        }
    }
}