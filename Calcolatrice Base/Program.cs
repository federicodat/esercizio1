using System.Linq.Expressions;

namespace Calcolatrice_Base
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        bool insAbi = true;

            double Cifra1 = 0;
            double Cifra2 = 0;
            double Risultato = 0;

            double i = 0;




            #region menu 
            List<string> Elenco = new List<string>();

            while (insAbi)
            {
                Console.Write("Dimmi cosa vuoi fare: \n - " +
                    "A addizione \n - " +
                    "D divisione \n - " +
                    "M moltiplicazione \n - " +
                    "S sottrazione \n - " +
                    "Q per uscire   : ");

                string? inputUtente = Console.ReadLine();

                if (inputUtente != null) inputUtente = inputUtente.ToUpper();

                try
                {
                    switch (inputUtente)
                {
                    case "A":
                        {
                            Console.WriteLine("Addizione : dammi cifra 1: ");
                             
                             double varcifra1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Addizione : dammi cifra 2: "); ;
                        double varcifra2 = Convert.ToDouble(Console.ReadLine());
                            
                         double somma = varcifra1 + varcifra2;

                           Console.WriteLine($"Risultato operazione:{somma}  ");
                            break;

                        }

                    case "M":
                        {
                            Console.WriteLine("Moltiplicazione : dammi cifra 1: ");
                            double varcifra1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Moltiplicazione : dammi cifra 2: "); ;
                            double varcifra2 = Convert.ToDouble(Console.ReadLine());

                            double moltipli = varcifra1 * varcifra2;

                            Console.WriteLine($"Risultato operazione:{moltipli}  ");
                            break;

                        }
                    case "S":
                        {
                            Console.WriteLine("Sottrazione : dammi cifra 1: ");
                            double varcifra1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Sottrazione : dammi cifra 2: "); ;
                            double varcifra2 = Convert.ToDouble(Console.ReadLine());

                            double sottra = varcifra1 - varcifra2;

                            Console.WriteLine($"Risultato operazione:{sottra}  ");
                            break;

                        }
                    case "D":
                        {
                            Console.WriteLine("Divisione : dammi cifra 1: ");
                            double varcifra1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Divisione : dammi cifra 2: "); ;
                            double varcifra2 = Convert.ToDouble(Console.ReadLine());
                         
                            if (varcifra2 == 0)
                                Console.WriteLine("cifra 2  non può essere 0");
                             else
                            {
                                double dividi = varcifra1 / varcifra2;

                            Console.WriteLine($"Risultato operazione:{dividi}  ");
                            }
                            break;

                        }
                    case "Q":
                        insAbi = !insAbi;
                        break;

                    default:
                        Console.WriteLine("comando errato");
                        break;
                            #endregion menu 
                    
            }
                }




                catch (FormatException)
                {

                    Console.WriteLine("cifra  deve essere numerica");
                }
            }
            //Console.WriteLine("Hello, World!");
        }
    }
}
