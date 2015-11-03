using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TextEncoder
{
    public static class SimpleTextSplitter
    {
        public static List<string[]> SplitToParagraphsWithSentences(string rawText)
        {
            if (!string.IsNullOrWhiteSpace(rawText))
            {
                if (rawText.Contains(".") || rawText.Contains("!") || rawText.Contains("?"))
                {
                    //list of string arrays represents paragraphs with sentences
                    List<string[]> packedText = new List<string[]>();

                    //splitting to paragraphs
                    List<string> paragraphs = rawText.Split(new string[] { " \n", "\n ", "\n" },
                        StringSplitOptions.RemoveEmptyEntries).ToList<string>();

                    //splitting each paragraph to sentences
                    for (int i = 0; i < paragraphs.Count; i++)
                    {
                        packedText.Add(
                            SplitToSentencesAndNormalize(paragraphs[i]));
                    }
                    return packedText;
                }
                else throw new FormatException("There are no sentence endings in the text");
            }
            else throw new FormatException("There is no text.");
        }

        private static string[] SplitToSentencesAndNormalize(string text)
        {
            //actual splitting
            string[] snts = Regex.Split(text, "(?<=[.!?]\"*)\\s+(?=\"*[A-Z])");

            List<string> sentences = new List<string>(snts.ToList<string>());

            return sentences.ToArray();
        }
    }
}
