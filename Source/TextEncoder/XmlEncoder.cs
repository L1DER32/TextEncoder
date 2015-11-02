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
        private static string sentence = string.Empty;

        static XmlTextWriter xmlWriter;
        public static void EncodeTextFile(string saveFileName, HeaderInformation info,
            List<string[]> paragraphsWithSentences, bool tagPunctuation)
        {
            //creating xml file
            xmlWriter = new XmlTextWriter(saveFileName, Encoding.UTF8);
            xmlWriter.WriteStartDocument();// <?xml version="1.0" encoding="UTF-8"?> line

            //getting the name out of the full path
            saveFileName = saveFileName.Replace(".xml", string.Empty);
            saveFileName = Regex.Match(saveFileName, "\\w+$").Value;

            // <!DOCTYPE TEI.2 SYSTEM "NAME"> line
            xmlWriter.WriteDocType("TEI.2", null, saveFileName, null);

            // <TEI.2 id="NAME"> line
            xmlWriter.WriteStartElement("TEI.2");
            xmlWriter.WriteAttributeString("id", saveFileName);

            //process header
            EncodeHeader(info);

            //process text
            EncodeText(paragraphsWithSentences, tagPunctuation);

            xmlWriter.WriteEndElement();//closing <TEI.2>
            xmlWriter.Close();
        }

        private static void EncodeHeader(HeaderInformation info)
        {
            xmlWriter.WriteStartElement("teiHeader");//<teiHeader> 
            xmlWriter.WriteStartElement("fileDesc");//<fileDesc>

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

        private static void EncodeText(List<string[]> paragraphsWithSentences, bool tagPunctuation)
        {
            xmlWriter.WriteStartElement("text"); //<text>
            xmlWriter.WriteStartElement("group"); //<group>
            xmlWriter.WriteStartElement("body"); //<body>

            foreach (string[] paragraph in paragraphsWithSentences)
            {
                xmlWriter.WriteStartElement("p");//tag paragraph

                EncodeSentences(paragraph, tagPunctuation);

                xmlWriter.WriteEndElement();//close paragraph tag
            }

            xmlWriter.WriteEndElement();//closing <body>
            xmlWriter.WriteEndElement();//closing <group>
            xmlWriter.WriteEndElement();//closing <text>
        }

        private static void EncodeSentences(string[] sentences, bool tagPunctuation)
        {
            for (int k = 0; k < sentences.Length; k++)
            {
                xmlWriter.WriteStartElement("s");//<s>

                if (tagPunctuation)
                {
                    sentence = sentences[k];

                    //tagging puntuation
                    #region
                    while (sentence.Length > 0)
                    {
                        if (sentence[0] == '.')
                        {
                            //if triple dot
                            if (sentence.Length >= 3 && sentence[1] == '.' && sentence[2] == '.')
                            {
                                xmlWriter.WriteString(tempPartOfSentence);
                                xmlWriter.WriteElementString("per", sentence.Remove(3));
                                ////clearing symbol
                                sentence = sentence.Remove(0, 3);
                                ////reset
                                tempPartOfSentence = string.Empty;
                            }
                            else
                                TagPunctuation("Fstop");
                        }
                        else if (sentence[0] == ',')
                            TagPunctuation("com");

                        else if (sentence[0] == '(')
                            TagPunctuation("lpm");

                        else if (sentence[0] == ')')
                            TagPunctuation("rpm");

                        else if (sentence[0] == '[')
                            TagPunctuation("lsqr");

                        else if (sentence[0] == ']')
                            TagPunctuation("rsqr");

                        else if (sentence[0] == '-')
                            TagPunctuation("hyph");

                        else if (sentence[0] == '!')
                            TagPunctuation("excl");

                        else if (sentence[0] == '?')
                            TagPunctuation("quest");

                        else if (sentence[0] == ':')
                            TagPunctuation("col");

                        else if (sentence[0] == ':')
                            TagPunctuation("sc");

                        else //non punctuation symbols
                        {
                            tempPartOfSentence += sentence[0].ToString();
                            sentence = sentence.Remove(0, 1);
                        }
                    }
                    #endregion
                }
                else xmlWriter.WriteString(sentences[k]);
                xmlWriter.WriteEndElement();//closing <s>
            }
        }

        private static void TagPunctuation(string tag)
        {
            //writing part of sentence to file
            xmlWriter.WriteString(tempPartOfSentence);

            //tagging the punctuation
            xmlWriter.WriteElementString(tag, sentence[0].ToString());

            //clearing symbol
            sentence = sentence.Remove(0, 1);

            //reset
            tempPartOfSentence = string.Empty;
        }
    }
}
