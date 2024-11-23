int stato = 0;

do
{
    stato = 0;
    introduzione();

    int scelta = int.Parse(Console.ReadLine());
    if (scelta == 1)
    {
        Console.WriteLine("hai scelto di andare avanti");
        stato1(ref stato, ref scelta);
        if (scelta == 1)
        {
            Console.WriteLine("sei andato avanti\nPremere 1 per al menu iniziale o 2 per andare indietro");
            scelta = int.Parse(Console.ReadLine());
            if (scelta == 1)
            {
                stato = 0;
                Console.Clear();
            }
            else if ( scelta == 2)
            {
                Console.WriteLine("sei tornato indietro di un menu");
                stato1(ref stato, ref scelta);
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

static void stato1(ref int stato,ref int scelta)
{
    stato = 1;
    Console.WriteLine("Premere 1 per andare ancora avanti o 2 per tornare indietro");
    scelta = int.Parse(Console.ReadLine());
    
}
