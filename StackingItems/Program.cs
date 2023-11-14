using System.Runtime.Intrinsics.X86;

Stack<string> valigia = new Stack<string>();

valigia.Push("Spazzolino");
valigia.Push("Felpa");


do
{
    Console.WriteLine("\n");
    Console.WriteLine("Seleziona un Opzione:" +
        "\n\n1) Push " +
        "\n\n2) Pop" +
        "\n\n3) Peek" +
        "\n\n4) GetAll" +
        "\n\n5) Esci\n");

    string input = Console.ReadLine();
    Console.WriteLine(" \n");


    switch (input)
    {
        case "1": Push();
            break;
        case "2": Pop();
            break;
        case "3": Peek();
            break;
        case "4": GetAll();
            break;
        case "5": Environment.Exit(0);
            break;
        default: Console.WriteLine("Scelta non valida. Riprova.\n");
            break;

    }
    Console.WriteLine("Vuoi fare altre operazioni? (S/N): \n");

} while (Console.ReadLine().ToUpper() == "S");



void Push()
{
    Console.WriteLine("Cosa vuoi inserire nella Valigia:\n");
    string elementoPush = Console.ReadLine();
    Console.WriteLine("\n");
    valigia.Push(elementoPush);
    Console.WriteLine($"L'elemento {elementoPush} è stato inserito correttamente in valigia\n");
    GetAll();
    Console.WriteLine("\n");
}

void Pop()
{
    if ( valigia.Count > 0)
    {
       string elementoPop = valigia.Pop();
       Console.WriteLine($"L'elemento {elementoPop} è stato eliminato con successo\n");
       GetAll();
       Console.WriteLine("\n");
    }
    else
    {
        Console.WriteLine("La Valigia è vuota. Impossibile eliminare\n");

    }
}


void Peek()
{
    if( valigia.Count > 0 )
    {
        string elementoPeek = valigia.Peek();
        Console.WriteLine($"L'ultimo elemento che hai inserito in Valigia è: {elementoPeek}\n");
    }
    else
    {
        Console.WriteLine("La Valigia è vuota\n");
    }
}


void GetAll()
{
    if(valigia.Count > 0)
    {
        Stack<string> copiaStack = new Stack<string>(valigia);

        Console.WriteLine("Nella Valigia hai inserito:\n");

        foreach (string s in copiaStack) {
            Console.WriteLine(s + "\n");

        };
    }
    else
    {
        Console.WriteLine("La Valigia è vuota");
        
    }

}