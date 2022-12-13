namespace AdventOfCode.Dias {
    internal class Dia2 {
        public static void ExecutarParteUm() {

            //Rock Paper and Cissors
            //A , X = Rock
            //B , Y = Paper
            //C , Z = Scissors

            //The objective here is to understand the Encrypted Strategy Guideline
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\bruno\source\repos\AdventOfCode\AdventOfCode\Dias\inputdia2.txt");
            int TotalScore = 0;
            foreach (string line in lines) {
                if (line[2].Equals('X')) {
                    TotalScore += 1;
                    if (line[0].Equals('A')) {
                        TotalScore += 3;
                    } else if (line[0].Equals('B')) {
                        continue;
                    } else {
                        TotalScore += 6;
                    }
                } else if (line[2].Equals('Y')) {
                    TotalScore += 2;
                    if (line[0].Equals('A')) {
                        TotalScore += 6;
                    } else if (line[0].Equals('B')) {
                        TotalScore += 3;
                    } else {
                        continue;
                    }

                } else {
                    TotalScore += 3;
                    if (line[0].Equals('A')) {
                        continue;
                    } else if (line[0].Equals('B')) {
                        TotalScore += 6;
                    } else {
                        TotalScore += 3;
                    }
                }

            }
            System.Console.WriteLine(TotalScore);
            ExecutarParteDois();

        }
        public static void ExecutarParteDois() {

            // Same thing, but this time 
            //A = Rock
            //B = Paper
            //C = Scissors
            // X = Lose
            // Y = Draw
            // Z = Win

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\bruno\source\repos\AdventOfCode\AdventOfCode\Dias\inputdia2.txt");
            int TotalScore = 0;
            foreach (string line in lines) {
                if (line[0].Equals('A')) {
                    if (line[2].Equals('X')) {
                        TotalScore += 3;
                    } else if (line[2].Equals('Y')) {
                        TotalScore += 4;
                    } else {
                        TotalScore += 8;
                    }
                } else if (line[0].Equals('B')) {
                    if (line[2].Equals('X')) {
                        TotalScore += 1;
                    } else if (line[2].Equals('Y')) {
                        TotalScore += 5;
                    } else {
                        TotalScore += 9;
                    }

                } else {
                    if (line[2].Equals('X')) {
                        TotalScore += 2;
                    } else if (line[2].Equals('Y')) {
                        TotalScore += 6;
                    } else {
                        TotalScore += 7;
                    }
                }

            }
            System.Console.WriteLine(TotalScore);

        }
    }

}



