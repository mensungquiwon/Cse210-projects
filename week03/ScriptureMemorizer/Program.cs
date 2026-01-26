using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        // Add scriptures to the list
        scriptures.Add(new Scripture(new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));

        scriptures.Add(new Scripture(new Reference("Psalm", 23, 1, 4),
            "The Lord is my shepherd, I lack nothing. He makes me lie down in green pastures, he leads me beside quiet waters, he refreshes my soul."));

        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."));

        scriptures.Add(new Scripture(new Reference("Philippians", 4, 13),
            "I can do all this through him who gives me strength."));

        scriptures.Add(new Scripture(new Reference("Romans", 12, 1, 2),
            "Therefore, I urge you, brothers and sisters, in view of God's mercy, to offer your bodies as a living sacrifice, holy and pleasing to God—this is your true and proper worship. Do not conform to the pattern of this world, but be transformed by the renewing of your mind. Then you will be able to test and approve what God's will is—his good, pleasing and perfect will."));

        scriptures.Add(new Scripture(new Reference("Matthew", 6, 33),
            "But seek first his kingdom and his righteousness, and all these things will be given to you as well."));

        scriptures.Add(new Scripture(new Reference("1 Peter", 5, 7),
            "Cast all your anxiety on him because he cares for you."));

        scriptures.Add(new Scripture(new Reference("Joshua", 1, 8),
            "Keep this Book of the Law always on your lips; meditate on it day and night, so that you may be careful to do everything written in it. Then you will be prosperous and successful."));

        // Select a random scripture
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (!scripture.isCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(1);

        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());







    }
}
