using System;
using System.Collections;
using System.Web;

namespace testSelenium.Classes
{
	/// <summary>
	/// Classe qui extrait des infos depuis un string.
	/// </summary>
    public class StringParser
    {
        /// <summary>
        /// Contructeur.
        /// </summary>
        public StringParser()
        {
        }

        /// <summary>
        /// Constructeur par initialisation.
        /// </summary>
        /// <param name="strContent">The parser's content.</param>
        public StringParser
          (string strContent)
        {
            Content = strContent;
        }

        /////////////
        // Propriétés

        /// <summary>getter et setter du contenu.</summary>
        public string Content
        {
            get
            {
                return m_strContent;
            }
            set
            {
                m_strContent = value;
                m_strContentLC = m_strContent.ToLower();
                resetPosition();
            }
        }

        /// <summary>getter de la pos courante.</summary>
        public int Position
        {
            get
            {
                return m_nIndex;
            }
        }

        /////////////////
        // Méthodes statiques

        /// <summary>
        /// Renvoi la liste des fonctions présentes.
        /// Fonction par terible à revoir avec un parser
        /// </summary>
        public static string getParams(string strString, string nomAction)
        {
            // on retires les commentaires et les includes
            StringParser parser = new StringParser(strString);

            string strFunc = "";
            parser.resetPosition();
            parser.skipToEndOfNoCase("The" + nomAction + "Test(");
            if (parser.extractTo(")", ref strFunc))
            {
                strFunc = strFunc.Trim();
            }

            return strFunc;
        }

        /////////////
        // Operations

        /// <summary>
        /// Checks if the parser is case-sensitively positioned at the start
        /// of a string.
        /// </summary>
        /// <param name="strString">The string.</param>
        /// <returns>
        /// true if the parser is positioned at the start of the string, false
        /// otherwise.
        /// </returns>
        public bool at
          (string strString)
        {
            if (m_strContent.IndexOf(strString, Position) == Position)
                return (true);
            return (false);
        }

        /// <summary>
        /// Checks if the parser is case-insensitively positioned at the start
        /// of a string.
        /// </summary>
        /// <param name="strString">The string.</param>
        /// <returns>
        /// true if the parser is positioned at the start of the string, false
        /// otherwise.
        /// </returns>
        public bool atNoCase
          (string strString)
        {
            strString = strString.ToLower();
            if (m_strContentLC.IndexOf(strString, Position) == Position)
                return (true);
            return (false);
        }

        /// <summary>
        /// Extracts the text from the parser's current position to the case-
        /// sensitive start of a string and advances the parser just after the
        /// string.
        /// </summary>
        /// <param name="strString">The string.</param>
        /// <param name="strExtract">The extracted text.</param>
        /// <returns>true if the parser was advanced, false otherwise.</returns>
        public bool extractTo
          (string strString,
           ref string strExtract)
        {
            int nPos = m_strContent.IndexOf(strString, Position);
            if (nPos != -1)
            {
                strExtract = m_strContent.Substring(m_nIndex, nPos - m_nIndex);
                m_nIndex = nPos + strString.Length;
                return (true);
            }
            return (false);
        }

        /// <summary>
        /// Extracts the text from the parser's current position to the case-
        /// insensitive start of a string and advances the parser just after the
        /// string.
        /// </summary>
        /// <param name="strString">The string.</param>
        /// <param name="strExtract">The extracted text.</param>
        /// <returns>true if the parser was advanced, false otherwise.</returns>
        public bool extractToNoCase
          (string strString,
           ref string strExtract)
        {
            strString = strString.ToLower();
            int nPos = m_strContentLC.IndexOf(strString, Position);
            if (nPos != -1)
            {
                strExtract = m_strContent.Substring(m_nIndex, nPos - m_nIndex);
                m_nIndex = nPos + strString.Length;
                return (true);
            }
            return (false);
        }

        /// <summary>
        /// Extracts the text from the parser's current position to the case-
        /// sensitive start of a string and position's the parser at the start
        /// of the string.
        /// </summary>
        /// <param name="strString">The string.</param>
        /// <param name="strExtract">The extracted text.</param>
        /// <returns>true if the parser was advanced, false otherwise.</returns>
        public bool extractUntil
          (string strString,
           ref string strExtract)
        {
            int nPos = m_strContent.IndexOf(strString, Position);
            if (nPos != -1)
            {
                strExtract = m_strContent.Substring(m_nIndex, nPos - m_nIndex);
                m_nIndex = nPos;
                return (true);
            }
            return (false);
        }

        /// <summary>
        /// Extracts the text from the parser's current position to the case-
        /// insensitive start of a string and position's the parser at the start
        /// of the string.
        /// </summary>
        /// <param name="strString">The string.</param>
        /// <param name="strExtract">The extracted text.</param>
        /// <returns>true if the parser was advanced, false otherwise.</returns>
        public bool extractUntilNoCase
          (string strString,
           ref string strExtract)
        {
            strString = strString.ToLower();
            int nPos = m_strContentLC.IndexOf(strString, Position);
            if (nPos != -1)
            {
                strExtract = m_strContent.Substring(m_nIndex, nPos - m_nIndex);
                m_nIndex = nPos;
                return (true);
            }
            return (false);
        }

        /// <summary>
        /// Extracts the text from the parser's current position to the end
        /// of its content and does not advance the parser's position.
        /// </summary>
        /// <param name="strExtract">The extracted text.</param>
        public void extractToEnd
          (ref string strExtract)
        {
            strExtract = "";
            if (Position < m_strContent.Length)
            {
                int nRemainLen = m_strContent.Length - Position;
                strExtract = m_strContent.Substring(Position, nRemainLen);
            }
        }

        /// <summary>
        /// Case-insensitively replaces every occurence of a string in the
        /// parser's content with another.
        /// </summary>
        /// <param name="strOccurrence">The occurrence.</param>
        /// <param name="strReplacement">The replacement string.</param>
        /// <returns>The number of occurences replaced.</returns>
        public int replaceEvery
          (string strOccurrence,
           string strReplacement)
        {
            // Initialize replacement process
            int nReplacements = 0;
            strOccurrence = strOccurrence.ToLower();

            // For every occurence...
            int nOccurrence = m_strContentLC.IndexOf(strOccurrence);
            while (nOccurrence != -1)
            {

                // Create replaced substring
                string strReplacedString = m_strContent.Substring(0, nOccurrence) + strReplacement;

                // Add remaining substring (if any)
                int nStartOfRemainingSubstring = nOccurrence + strOccurrence.Length;
                if (nStartOfRemainingSubstring < m_strContent.Length)
                {
                    string strSecondPart = m_strContent.Substring(nStartOfRemainingSubstring, m_strContent.Length - nStartOfRemainingSubstring);
                    strReplacedString += strSecondPart;
                }

                // Update the original string
                m_strContent = strReplacedString;
                m_strContentLC = m_strContent.ToLower();
                nReplacements++;

                // Find the next occurence
                nOccurrence = m_strContentLC.IndexOf(strOccurrence);
            }
            return (nReplacements);
        }

        /// <summary>
        /// Case sensitive version of replaceEvery()
        /// </summary>
        /// <param name="strOccurrence">The occurrence.</param>
        /// <param name="strReplacement">The replacement string.</param>
        /// <returns>The number of occurences replaced.</returns>
        public int replaceEveryExact
          (string strOccurrence,
           string strReplacement)
        {
            int nReplacements = 0;
            while (m_strContent.IndexOf(strOccurrence) != -1)
            {
                m_strContent = m_strContent.Replace(strOccurrence, strReplacement);
                nReplacements++;
            }
            m_strContentLC = m_strContent.ToLower();
            return (nReplacements);
        }

        /// <summary>
        /// Resets the parser's position to the start of the content.
        /// </summary>
        public void resetPosition()
        {
            m_nIndex = 0;
        }

        /// <summary>
        /// Advances the parser's position to the start of the next case-sensitive
        /// occurence of a string.
        /// </summary>
        /// <param name="strString">The string.</param>
        /// <returns>true if the parser's position was advanced, false otherwise.</returns>
        public bool skipToStartOf
          (string strString)
        {
            bool bStatus = seekTo(strString, false, false);
            return (bStatus);
        }

        /// <summary>
        /// Advances the parser's position to the start of the next case-insensitive
        /// occurence of a string.
        /// </summary>
        /// <param name="strText">The string.</param>
        /// <returns>true if the parser's position was advanced, false otherwise.</returns>
        public bool skipToStartOfNoCase
          (string strText)
        {
            bool bStatus = seekTo(strText, true, false);
            return (bStatus);
        }

        /// <summary>
        /// Advances the parser's position to the end of the next case-sensitive
        /// occurence of a string.
        /// </summary>
        /// <param name="strString">The string.</param>
        /// <returns>true if the parser's position was advanced, false otherwise.</returns>
        public bool skipToEndOf
          (string strString)
        {
            bool bStatus = seekTo(strString, false, true);
            return (bStatus);
        }

        /// <summary>
        /// Advances the parser's position to the end of the next case-insensitive
        /// occurence of a string.
        /// </summary>
        /// <param name="strText">The string.</param>
        /// <returns>true if the parser's position was advanced, false otherwise.</returns>
        public bool skipToEndOfNoCase
          (string strText)
        {
            bool bStatus = seekTo(strText, true, true);
            return (bStatus);
        }

        ///////////////////////////
        // Implementation (members)

        /// <summary>Content to be parsed.</summary>
        string m_strContent = "";

        /// <summary>Lower-cased version of content to be parsed.</summary>
        string m_strContentLC = "";

        /// <summary>Current position in content.</summary>
        int m_nIndex = 0;

        ///////////////////////////
        // Implementation (methods)

        /// <summary>
        /// Advances the parser's position to the next occurence of a string.
        /// </summary>
        /// <param name="strString">The string.</param>
        /// <param name="bNoCase">Flag: perform a case-insensitive search.</param>
        /// <param name="bPositionAfter">Flag: position parser just after string.</param>
        /// <returns></returns>
        bool seekTo
          (string strString,
           bool bNoCase,
           bool bPositionAfter)
        {
            if (Position < m_strContent.Length)
            {

                // Find the start of the string - return if not found
                int nNewIndex = 0;
                if (bNoCase)
                {
                    strString = strString.ToLower();
                    nNewIndex = m_strContentLC.IndexOf(strString, Position);
                }
                else
                {
                    nNewIndex = m_strContent.IndexOf(strString, Position);
                }
                if (nNewIndex == -1)
                    return (false);

                // Position the parser
                m_nIndex = nNewIndex;
                if (bPositionAfter)
                    m_nIndex += strString.Length;
                return (true);
            }
            return (false);
        }
    }
}
