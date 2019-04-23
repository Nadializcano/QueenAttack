namespace LeetSpeak
{
    public class LeetSpeakTranslator
    {
        public string Translate(string phrase)
        {
            string output = "";

            for (int i = 0; i < phrase.Length; i++)
            {
                if(phrase[i] == 'E' || phrase[i] == 'e')
                {
                    output += "3";
                }
                else if (phrase[i] == 'O' || phrase[i] == 'o')
                {
                    output += "0";
                }

                else if (phrase[i] == 'I')
                {
                    output += "1";
                }
                else if (phrase[i] == 'T' || phrase[i] == 't')
                {
                    output += "7";
                }
                else if (phrase[i] == 'S' && i != 0 || phrase[i] == 's' && i != 0)
                {
                    output += "z";
                }

                else
                {
                    output += phrase[i];
                }
            }
            return output;
        }
    }

}