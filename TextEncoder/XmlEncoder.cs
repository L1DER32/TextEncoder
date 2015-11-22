using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace TextEncoder
{

    public static class XmlEncoder
    {
        private static string tempPartOfSentence = string.Empty;
        private static string currSentence = string.Empty;
        private static bool quoteIsOpen = true;

        private static XmlTextWriter xmlWriter;
        public static void EncodeTextFile(string saveFileName, HeaderInformation info,
            List<string[]> paragraphsWithSentences, bool tagPunctuation)
        {
            //creating xml file
            xmlWriter = new XmlTextWriter(saveFileName, Encoding.UTF8);

            //starting the document (intro)
            WriteDocIntro(saveFileName);

            //process header
            EncodeHeader(info);

            //process text
            xmlWriter.WriteStartElement("text"); //<text>
            xmlWriter.WriteStartElement("group"); //<group>
            xmlWriter.WriteStartElement("body"); //<body>

            foreach (string[] paragraph in paragraphsWithSentences)
            {
                xmlWriter.WriteStartElement("p");//tag paragraph
                EncodeSentencesOrParagraphs(paragraph, tagPunctuation, true);
                xmlWriter.WriteEndElement();//close paragraph tag
            }

            xmlWriter.WriteEndElement();//closing <body>
            xmlWriter.WriteEndElement();//closing <group>
            xmlWriter.WriteEndElement();//closing <text>

            //ending the document (outro)
            xmlWriter.WriteEndElement();//closing <TEI.2>
            xmlWriter.Close();
        }


        //overload that takes string[]
        public static void EncodeTextFile(string saveFileName, HeaderInformation info,
           string[] paragraphs, bool tagPunctuation)
        {
            //creating xml file
            xmlWriter = new XmlTextWriter(saveFileName, Encoding.UTF8);

            //starting the document (intro)
            WriteDocIntro(saveFileName);

            //process header
            EncodeHeader(info);

            //process text
            xmlWriter.WriteStartElement("text"); //<text>
            xmlWriter.WriteStartElement("group"); //<group>
            xmlWriter.WriteStartElement("body"); //<body>

            EncodeSentencesOrParagraphs(paragraphs, tagPunctuation, false);

            xmlWriter.WriteEndElement();//closing <body>
            xmlWriter.WriteEndElement();//closing <group>
            xmlWriter.WriteEndElement();//closing <text>

            //ending the document (outro)
            xmlWriter.WriteEndElement();//closing <TEI.2>
            xmlWriter.Close();
        }


        private static void WriteDocIntro(string saveFileName)
        {
            xmlWriter.WriteStartDocument();// <?xml version="1.0" encoding="UTF-8"?> line

            //getting the name out of the full path
            saveFileName = saveFileName.Replace(".xml", string.Empty);
            saveFileName = Regex.Match(saveFileName, "\\w+$").Value;

            // <!DOCTYPE TEI.2 SYSTEM "NAME"> line
            xmlWriter.WriteDocType("TEI.2", null, saveFileName, null);

            // <TEI.2 id="NAME"> line
            xmlWriter.WriteStartElement("TEI.2");
            xmlWriter.WriteAttributeString("id", saveFileName);
        }

        private static void EncodeHeader(HeaderInformation info)
        {
            xmlWriter.WriteStartElement("teiHeader");//<teiHeader> 
            xmlWriter.WriteStartElement("fileDesc");//<fileDesc>

            xmlWriter.WriteComment("Description is managed by the operator");

            //titleStmt info
            #region
            if (info.Title != string.Empty || info.Author != string.Empty)
            {
                xmlWriter.WriteStartElement("titleStmt");//<titleStmt>

                if (info.Title != string.Empty)
                    xmlWriter.WriteElementString("title", info.Title);

                if (info.Author != string.Empty)
                    xmlWriter.WriteElementString("author", info.Author);

                xmlWriter.WriteEndElement();//closing <titleStmt>
            }
            #endregion

            //pubStmt info
            #region
            if (info.Publisher != string.Empty || info.PublisherPlace != string.Empty ||
                info.PublishDate != string.Empty || info.PublishAddress != string.Empty ||
                info.Distributor != string.Empty)
            {
                xmlWriter.WriteStartElement("pubStmt");//<pubStmt>

                if (info.Publisher != string.Empty)
                    xmlWriter.WriteElementString("publisher", info.Publisher);

                if (info.PublisherPlace != string.Empty)
                    xmlWriter.WriteElementString("pubPlace", info.PublisherPlace);

                if (info.PublishAddress != string.Empty)
                    xmlWriter.WriteElementString("address", info.PublishAddress);

                if (info.PublishDate != string.Empty)
                    xmlWriter.WriteElementString("date", info.PublishDate);

                if (info.Distributor != string.Empty)
                    xmlWriter.WriteElementString("distributor", info.Distributor);

                xmlWriter.WriteEndElement();//closing <pubStmt>
            }
            #endregion

            //sourceDesc info      
            #region
            if (info.BiblCitation != string.Empty || info.TitleSrc != string.Empty || info.AuthorSrc != string.Empty ||
                info.EditionSrc != string.Empty || info.Analytic != string.Empty || info.DateSrc != string.Empty)
            {
                xmlWriter.WriteStartElement("sourceDesc"); //<sourceDesc>

                if (info.BiblCitation != string.Empty)
                    xmlWriter.WriteElementString("Bibl", info.BiblCitation);

                if (info.TitleSrc != string.Empty)
                    xmlWriter.WriteElementString("title", info.TitleSrc);

                if (info.AuthorSrc != string.Empty)
                    xmlWriter.WriteElementString("author", info.AuthorSrc);

                if (info.EditionSrc != string.Empty)
                    xmlWriter.WriteElementString("edition", info.EditionSrc);

                if (info.Analytic != string.Empty)
                    xmlWriter.WriteElementString("analytic", info.Analytic);

                if (info.DateSrc != string.Empty)
                    xmlWriter.WriteElementString("date", info.DateSrc);

                xmlWriter.WriteEndElement();//closing <sourceDesc>
            }
            #endregion

            xmlWriter.WriteEndElement();//closing <fileDesc>         
            xmlWriter.WriteEndElement();//closing <teiHeader>
        }

        private static void EncodeSentencesOrParagraphs(string[] stringEntries, bool tagPunctuation, bool encodeSentences)
        {
            for (int k = 0; k < stringEntries.Length; k++)
            {
                if (encodeSentences) xmlWriter.WriteStartElement("s");//<s>
                else xmlWriter.WriteStartElement("p");//tag paragraph

                if (tagPunctuation)
                {
                    currSentence = stringEntries[k];

                    //tagging punctuation
                    #region
                    while (currSentence.Length > 0)
                    {
                        if (currSentence[0] == '.')
                        {
                            //if triple dot
                            if (currSentence.Length >= 3 && currSentence[1] == '.' && currSentence[2] == '.')
                            {
                                xmlWriter.WriteString(tempPartOfSentence);
                                xmlWriter.WriteElementString("per", currSentence.Remove(3));

                                //clearing symbol
                                currSentence = currSentence.Remove(0, 3);
                                //reset
                                tempPartOfSentence = string.Empty;
                            }
                            else EncodePunctuationSymbol("Fstop");
                        }

                        else if (currSentence[0] == '—' ||
                            currSentence[0] == '–') EncodePunctuationSymbol("dash");

                        else if (currSentence[0] == '-' && currSentence.Length >= 2
                            && currSentence[1] == ' ') EncodePunctuationSymbol("hyph");

                        else if (currSentence[0] == ',') EncodePunctuationSymbol("com");

                        else if (currSentence[0] == '(') EncodePunctuationSymbol("lpm");

                        else if (currSentence[0] == ')') EncodePunctuationSymbol("rpm");

                        else if (currSentence[0] == '[') EncodePunctuationSymbol("lsqr");

                        else if (currSentence[0] == ']') EncodePunctuationSymbol("rsqr");

                        else if (currSentence[0] == '!') EncodePunctuationSymbol("excl");

                        else if (currSentence[0] == '?') EncodePunctuationSymbol("quest");

                        else if (currSentence[0] == ':') EncodePunctuationSymbol("col");

                        else if (currSentence[0] == ';') EncodePunctuationSymbol("sc");

                        else if (currSentence[0] == '/') EncodePunctuationSymbol("slash");

                        else if (currSentence[0] == '"')
                        {
                            //cycling between open and closed double quotes
                            if (quoteIsOpen) EncodePunctuationSymbol("odblq");
                            else EncodePunctuationSymbol("cbdlq");

                            //changing state
                            quoteIsOpen = !quoteIsOpen;
                        }

                        else //non punctuation symbols
                        {
                            tempPartOfSentence += currSentence[0].ToString();
                            currSentence = currSentence.Remove(0, 1);
                        }
                    }
                    #endregion
                }
                else
                    xmlWriter.WriteString(
                        //no space added if it is the last sentence in the paragraph
                    (k == stringEntries.Length - 1) ? stringEntries[k] : stringEntries[k] + " ");

                if (encodeSentences) xmlWriter.WriteEndElement();//closing <s>
                else xmlWriter.WriteEndElement();//close paragraph tag
            }
        }

        private static void EncodePunctuationSymbol(string tag)
        {
            //writing part of sentence to file
            xmlWriter.WriteString(tempPartOfSentence);

            //tagging the punctuation
            xmlWriter.WriteElementString(tag, currSentence[0].ToString());

            //clearing symbol
            currSentence = currSentence.Remove(0, 1);

            //reset
            tempPartOfSentence = string.Empty;
        }
    }
}
