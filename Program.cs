using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Db db = new Db();
            
           var returnDati= db.GetAllData();
           

            Console.WriteLine("Lettura dati terminata, di seguito i risultati..");
            var stampaDati = string.Empty;


            foreach (var item in returnDati)
            {
                stampaDati += $"ID: {item.Id} \n";
                stampaDati += $"Nome: {item.Nome}\n";
                stampaDati += $"Cognome: {item.Cognome}\n";
                stampaDati += $"Stipendio: {item.Stipendio}\n";
                stampaDati += $"ID Ruolo: {item.IdRuolo}\n";
                stampaDati += $"ID Azienda Amministrazione: {item.IdAziendaAmministrazione}\n";
                stampaDati += $"Azienda: {item.Azienda}\n";
               
                
                    Console.WriteLine(stampaDati);
                // Add an empty line for clarity between objects
                   Console.WriteLine();
                }

                // Wait for user input before closing the console window
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }

        }
           
        }
   
