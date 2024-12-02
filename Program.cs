// See https://aka.ms/new-console-template for more information

/*
Du skal lage en app hvor man kan lage sin egen chatbot - og deretter velge å snakke med den 🙂
Brukeren skal få prompt på chættbått navn, og deretter mulighet til å skrive inn forskjellige 
tilbakemeldinger/ svar som chættbått’n skal trekke et tilfeldig svar fra og svare brukeren med når den startes opp.
    Bruk gjerne en meny for å gå inn i de forskjellige modusene: “mekke en chættbått” og “preke med en chættbått”
BONUS:
Mulighet til å lage flere chættbåtts, brukeren skal kunne se en liste av tilgjengelige chættbåtts og velge hvem 
hen vil snakke med - her må det brukes List fra neste ukes pensum. 
*/


using ParProgrammering2;

Console.WriteLine("Halla på deg! Hva vil du at chættbåtten din skal hete?");

string botName = Console.ReadLine();

Console.WriteLine("Nice! Skriv inn et svar chatbotten kan gi, eller skriv \"Ha en fin dag!\" for å avslutte og gå videre til neste steg.");
string botReply = Console.ReadLine();
List<string> allReplies = new List<string>();

while (botReply != "Ha en fin dag!")
{
    allReplies.Add(botReply);
    Console.WriteLine("Nice, hva mer? Avslutt med \"Ha en fin dag!\" når du er ferdig.");
    botReply = Console.ReadLine();
}
Console.WriteLine($"Chatbot mode activated. Jeg heter {botName}. Spør meg om hva som helst!");
while (true)
{
    
    Console.ReadLine();
    Console.WriteLine(botName + ": " + BotReplies.getRandomReply(allReplies));
}

