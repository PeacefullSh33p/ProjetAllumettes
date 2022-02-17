using System;

namespace ProjetAllumettes
{
    class Program
    {
        static void Main(string[] args)
        {


            //Initiation du code//

            // Tableau des Allumettes//

            //11 => 6   le calcul qui permet de passer de l'un à l' autre est /2 + 1
            // 9 => 5   le calcul qui permet de passer de l'un à l' autre est /2 + 1
            // 7 => 4   le calcul qui permet de passer de l'un à l' autre est /2 + 1
            // 5 => 3   le calcul qui permet de passer de l'un à l' autre est /2 + 1
            //3 => 2    le calcul qui permet de passer de l'un à l' autre est /2 + 1



            int TB = TailleDeLaBase();



            int Nlignes = CréationLignes(TB);

            int StockA = GetAllumettes();

            int[] Board = CréationTableau(Nlignes, StockA);

            Display_Up(TB);

            CalculStockAllumettes(Board, StockA, TB, Nlignes);

            Display_Lignes(Board, TB, Nlignes);


            Display_Up(TB);

            Console.WriteLine(" ");

            int NA = ChoixNombreAllumettes(); 

            int CL = ChoixLignes(Board);

            ModifTableau(Board, CL, NA);

            Display_Up(TB);

            Display_Lignes(Board, TB, Nlignes);

            Display_Up(TB);
        }

        //----------------------------------------------------------------------------------------------------------------------------//
        static int Game(int TB)
        {
            int Jeu = 0;

            int lignes = TB / 2 + 1;
            string Af = "I";
            int NA = 0;

            int[] displayNBlignes = { 1, 2, 3, 4, 5 };
            int[] Tableau = { };

            



          
            return Jeu;
        }

        static int TailleDeLaBase()
        {
            //choix de la taille de la base//
            int TB = 0;
            try
            {
                Console.WriteLine("taille de votre base ? ( seulement des nombres impairs) : ");
                string TailleBase = Console.ReadLine();
                TB = int.Parse(TailleBase);
                return TB;
                if (TB % 2 == 0)
                {
                    Console.WriteLine("Veuillez renseigner seulement des nombres impairs");
                }
                else
                {
                    Console.Clear();
                    return TailleDeLaBase();
                }
            }

            catch
            {

            }
            return TB;
        }

        //----------------------------------------------------------------------------------------------------------------------------//
        static int ChoixNombreAllumettes()
        {
            Console.WriteLine(" ");
            int NA = 0;
            //choix du nombre d'allumettes//
            Console.WriteLine("C'est à votre tour, combien d'allumetts voulez-vous retirez ?  :");
            string NombreAllumettes = Console.ReadLine();
            NA = int.Parse(NombreAllumettes);
            return NA;
        }

        //----------------------------------------------------------------------------------------------------------------------------//


        static int ModifTableau(int[] Board, int CL, int NA)
        {
            Board[CL] = Board[CL] - NA;

            Console.WriteLine(Board[0] + " " + Board[1] + " " + Board[2]);
            return Board[CL] - 1;
          
        } 

















        static int CréationLignes(int TB)
        {
            int VBL = 1;
            int Nlignes = 1;
            while(TB != VBL)
            {
                VBL = VBL + 2;
                Nlignes = Nlignes + 1;
            }
            return Nlignes;
        }

        static int[] CréationTableau(int Nlignes, int StockA)
        {
            
            
            int[] Board = new int[Nlignes];
            int Sélection = 0;
            while(Nlignes > Sélection)
            {
                Board[Sélection] = StockA;
                Sélection = Sélection + 1;
                StockA = StockA + 2; // StockA = StockAllumettes = allumettes sur la 2nd lignes

            }


            
            return Board;
        
        }
            static int GetAllumettes()
            {
                int StockA = 1;
               

                return StockA;
            }

        // PARTIE LIGNES//
        //------------------------------------------------------------------------------------------------------------------------------//
        static int ChoixLignes(int[] Board) // méthode pour choisir sur quelle lignes retirer des allumettes
        {

            Console.WriteLine("C'est à votre tour,  sur quelle ligne voulez-vous retirer les allumettes ?");
            int CL = 0;

            string ChoixLignes = Console.ReadLine();

            
            CL = int.Parse(ChoixLignes);
            return CL ; // CL = ChoixLignes, 
           


        }

        static int[] CalculStockAllumettes(int[] Board, int StockA, int TB, int Nlignes) 
        {
            int StockATB = TB;
            for ( int i = 0 ; StockATB  != i; StockATB--) 
            {
                 StockATB = StockATB - 2;
            } 
            
            return Board;

        }
        //StockATB = stock Allumettes sur la 1ere lignes.
       

        //-------------------------------------------------------------------------------------------------------------------------------//








        static int Display_Lignes(int[] Board, int TB, int Nlignes)// Work in progress. Faire l'affichage  en fonction du Board.
        {
         
            int NBL = 1;
            int TBL = TB / 2 * -1;
            int Space = 1;
            
            Console.WriteLine(" ");
            while (NBL != TB + 2)// pour les autres lignes.
            {
                Console.Write(Space + "\t");
                Console.Write("|");
                for (int i = 0; i != TBL; i = i - 1)
                {
                    Console.Write(" ");

                }
                TBL++;
                for (int i = 0; i != NBL; i++)
                {

                    Console.Write("I");

                }
                for (int i = 1; i != TBL; i = i - 1)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.WriteLine(" ");
                Space++;
                NBL += 2;
















            }

            return NBL;

        }












        void IA_Play()
        {

        }



        void Player_Play()
        {

        }

        static int Display_Up(int TB)
        {

            int Space = 1;

            int NBdisplay = 0;

            Console.Write("\t");
            while (NBdisplay != TB + 2)
            {
                Console.Write("-");
                NBdisplay = NBdisplay + 1;
            }
            Space = 1;

           

            return Space;
















        }














    }
}
