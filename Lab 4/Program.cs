namespace Lab_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {          
            string LabTitle = "Welcome to the Pig Latin Translator!";
            string InputRequest = "\nEnter a line to be translated:";
            string ContinueRequest = "\nTranslate another line? (y/n):";
            string stoploop = "";
            string PiglatinText = "";

            Console.WriteLine(LabTitle);

            while (stoploop == "")
            {
                Console.Write(InputRequest);
                string RequestInput = Console.ReadLine();

               
                string[] allwords = RequestInput.Split(" ");

                int index;
                for (index = 0; index <= allwords.Length; index++)
                {
                    if (allwords.Length > index)
                    {                        
                        if (RequestInput == "")
                        {
                            Console.Write("\nPlease enter a line to be translated.");
                        }
                        else
                        {
                            // Convert each word to a lowercase before translating
                            PiglatinText = PiglatinText + " " + TranslateWords(allwords[index]);
                        }
                    }
                    else
                    {
                        break;
                    }

                }               
                Console.WriteLine("\n" + PiglatinText.Trim());
                PiglatinText = "";

               
                Console.Write(ContinueRequest);
                string userInput = Console.ReadLine();
                if (userInput.ToLower() != "y")
                {
                    break;
                }
            }
        }
        public static string TranslateWords(string WordsToTranslate)
        {
            string vowels = "a,e,i,o,u"; //Treat “y” as a consonant

           
            WordsToTranslate = WordsToTranslate.ToLower();

            
            char[] letters = WordsToTranslate.ToCharArray();
            char FirstChar = letters[0];


            if (vowels.Contains(FirstChar))
            {
                WordsToTranslate = WordsToTranslate + "way";
            }
            else
            {                
                int i;
                int firstvowel = 0;

                string Consonants = "";
                if (WordsToTranslate.Length > 1)
                {
                    for (i = 0; i <= WordsToTranslate.Length; i++)
                    {
                        if (WordsToTranslate.Length > i)
                        {                           
                            if (vowels.Contains(letters[i]))
                            {                              
                                firstvowel = i;
                                break;
                            }
                            else
                            {                               
                                Consonants = Consonants + letters[i];
                            }
                        }
                        else
                        {
                            break;
                        }

                    }
                }
                WordsToTranslate = WordsToTranslate.Substring(firstvowel, WordsToTranslate.Length - Consonants.Length) + Consonants + "ay";
            }
            return (WordsToTranslate);
        }

    }
}
