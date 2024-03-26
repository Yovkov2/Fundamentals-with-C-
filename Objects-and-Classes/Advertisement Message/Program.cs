int count = int.Parse(Console.ReadLine());

string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

Random phrasesRandom = new Random();
Random eventsRandom = new Random();
Random authorsRandom = new Random();
Random citiesRandom = new Random();

for (int i = 0; i < count; i++)
{
    int pharsesIndex = phrasesRandom.Next(0, phrases.Length);
    int eventsIndex = eventsRandom.Next(0, events.Length);
    int authorsIndex = authorsRandom.Next(0, authors.Length);
    int citiesIndex = citiesRandom.Next(0, cities.Length);
    Console.WriteLine($"{phrases[pharsesIndex]} {events[eventsIndex]} {authors[authorsIndex]} {cities[citiesIndex]}");
}