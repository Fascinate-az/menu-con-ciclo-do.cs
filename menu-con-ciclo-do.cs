int stato = 0;

do
{
    stato = 0;
    introduzione();

    int scelta = int.Parse(Console.ReadLine());
    if (scelta == 1)
    {
        stato = 1;
        Console.WriteLine("hai scelto di andare avanti\nPremere 1 per andare ancora avanti o 2 per tornare indietro");
        scelta = int.Parse(Console.ReadLine());
        if (scelta == 1)
        {
            Console.WriteLine("sei andato avanti\nPremere 2 per al menu iniziale");
            scelta = int.Parse(Console.ReadLine());
            if (scelta == 2)
            {
                stato = 0;
                Console.Clear();
            }
        }
        else if (scelta == 2)
        {
            stato = 0;
            Console.WriteLine("stai tornando indietro");
        }
    }
    
    else if (scelta == 2)
    {
        stato = 2;
        Environment.Exit(0);

    }




}
while (stato==0);








static void introduzione(){

    Console.WriteLine("Premere\n1.Per andare avanti\n2.Per uscire");
}
