using Bogus;
using System.Collections.Generic;

namespace NaughtyStrings.Bogus
{
    public class Naughty : DataSet
    {
        /// <summary>
        /// All naughty strings.
        /// </summary>
        public static IEnumerable<string> Strings(int num = 1)
        {
            return TheNaughtyStrings.All.PickRandom(num);
        }

        /// <summary>
        ///  Strings which may be used elsewhere in code
        /// </summary>
        public static IEnumerable<string> ReservedStrings(int num = 1)
        {
            return TheNaughtyStrings.ReservedStrings.PickRandom(num);
        }

        /// <summary>
        ///  Strings which can be interpreted as numeric
        /// </summary>
        public static IEnumerable<string> NumericStrings(int num = 1)
        {
            return TheNaughtyStrings.NumericStrings.PickRandom(num);
        }

        /// <summary>
        ///  ASCII punctuation.  All of these characters may need to be escaped in some contexts.  Divided into three groups based on (US-layout) keyboard position.
        /// </summary>
        public static IEnumerable<string> SpecialCharacters(int num = 1)
        {
            return TheNaughtyStrings.SpecialCharacters.PickRandom(num);
        }

        /// <summary>
        ///  Strings which contain common unicode symbols (e.g. smart quotes)
        /// </summary>
        public static IEnumerable<string> UnicodeSymbols(int num = 1)
        {
            return TheNaughtyStrings.UnicodeSymbols.PickRandom(num);
        }

        /// <summary>
        ///  Strings which contain unicode subscripts/superscripts; can cause rendering issues
        /// </summary>
        public static IEnumerable<string> UnicodeSubscriptSuperscriptAccents(int num = 1)
        {
            return TheNaughtyStrings.UnicodeSubscriptSuperscriptAccents.PickRandom(num);
        }

        /// <summary>
        ///  Strings which contain misplaced quotation marks; can cause encoding errors
        /// </summary>
        public static IEnumerable<string> QuotationMarks(int num = 1)
        {
            return TheNaughtyStrings.QuotationMarks.PickRandom(num);
        }

        /// <summary>
        ///  Strings which contain two-byte characters: can cause rendering issues or character-length issues
        /// </summary>
        public static IEnumerable<string> TwoByteCharacters(int num = 1)
        {
            return TheNaughtyStrings.TwoByteCharacters.PickRandom(num);
        }

        /// <summary>
        ///  Characters which increase in length (2 to 3 bytes) when lowercased Credit: https://twitter.com/jifa/status/625776454479970304
        /// </summary>
        public static IEnumerable<string> Changinglengthwhenlowercased(int num = 1)
        {
            return TheNaughtyStrings.Changinglengthwhenlowercased.PickRandom(num);
        }

        /// <summary>
        ///  Strings which consists of Japanese-style emoticons which are popular on the web
        /// </summary>
        public static IEnumerable<string> JapaneseEmoticons(int num = 1)
        {
            return TheNaughtyStrings.JapaneseEmoticons.PickRandom(num);
        }

        /// <summary>
        ///  Strings which contain Emoji; should be the same behavior as two-byte characters, but not always
        /// </summary>
        public static IEnumerable<string> Emoji(int num = 1)
        {
            return TheNaughtyStrings.Emoji.PickRandom(num);
        }

        /// <summary>
        ///  Strings which contain unicode numbers; if the code is localized, it should see the input as numeric
        /// </summary>
        public static IEnumerable<string> UnicodeNumbers(int num = 1)
        {
            return TheNaughtyStrings.UnicodeNumbers.PickRandom(num);
        }

        /// <summary>
        ///  Strings which contain text that should be rendered RTL if possible (e.g. Arabic, Hebrew)
        /// </summary>
        public static IEnumerable<string> RightToLeftStrings(int num = 1)
        {
            return TheNaughtyStrings.RightToLeftStrings.PickRandom(num);
        }

        /// <summary>
        ///  Strings which contain unicode with unusual properties (e.g. Right-to-left override) (c.f. http://www.unicode.org/charts/PDF/U2000.pdf)
        /// </summary>
        public static IEnumerable<string> TrickUnicode(int num = 1)
        {
            return TheNaughtyStrings.TrickUnicode.PickRandom(num);
        }

        /// <summary>
        ///  Strings which contain "corrupted" text. The corruption will not appear in non-HTML text, however. (via http://www.eeemo.net)
        /// </summary>
        public static IEnumerable<string> ZalgoText(int num = 1)
        {
            return TheNaughtyStrings.ZalgoText.PickRandom(num);
        }

        /// <summary>
        ///  Strings which contain unicode with an "upsidedown" effect (via http://www.upsidedowntext.com)
        /// </summary>
        public static IEnumerable<string> UnicodeUpsidedown(int num = 1)
        {
            return TheNaughtyStrings.UnicodeUpsidedown.PickRandom(num);
        }

        /// <summary>
        ///  Strings which contain bold/italic/etc. versions of normal characters
        /// </summary>
        public static IEnumerable<string> Unicodefont(int num = 1)
        {
            return TheNaughtyStrings.Unicodefont.PickRandom(num);
        }

        /// <summary>
        ///  Strings which attempt to invoke a benign script injection; shows vulnerability to XSS
        /// </summary>
        public static IEnumerable<string> ScriptInjection(int num = 1)
        {
            return TheNaughtyStrings.ScriptInjection.PickRandom(num);
        }

        /// <summary>
        ///  Strings which can cause a SQL injection if inputs are not sanitized
        /// </summary>
        public static IEnumerable<string> SQLInjection(int num = 1)
        {
            return TheNaughtyStrings.SQLInjection.PickRandom(num);
        }

        /// <summary>
        ///  Strings which can cause user to run code on server as a privileged user (c.f. https://news.ycombinator.com/item?id=7665153)
        /// </summary>
        public static IEnumerable<string> ServerCodeInjection(int num = 1)
        {
            return TheNaughtyStrings.ServerCodeInjection.PickRandom(num);
        }

        /// <summary>
        ///  Strings which can call system commands within Ruby/Rails applications
        /// </summary>
        public static IEnumerable<string> CommandInjectionRuby(int num = 1)
        {
            return TheNaughtyStrings.CommandInjectionRuby.PickRandom(num);
        }

        /// <summary>
        ///  Strings which can be accidentally expanded into different strings if evaluated in the wrong context, e.g. used as a printf format string or via Perl or shell eval. Might expose sensitive data from the program doing the interpolation, or might just represent the wrong string.
        /// </summary>
        public static IEnumerable<string> UnwantedInterpolation(int num = 1)
        {
            return TheNaughtyStrings.UnwantedInterpolation.PickRandom(num);
        }

        /// <summary>
        ///  Strings which can cause user to pull in files that should not be a part of a web server
        /// </summary>
        public static IEnumerable<string> FileInclusion(int num = 1)
        {
            return TheNaughtyStrings.FileInclusion.PickRandom(num);
        }

        /// <summary>
        ///  Strings that test for known vulnerabilities
        /// </summary>
        public static IEnumerable<string> KnownCVEsandVulnerabilities(int num = 1)
        {
            return TheNaughtyStrings.KnownCVEsandVulnerabilities.PickRandom(num);
        }

        /// <summary>
        ///  Strings which are reserved characters in MSDOS/Windows
        /// </summary>
        public static IEnumerable<string> MSDOSWindowsSpecialFilenames(int num = 1)
        {
            return TheNaughtyStrings.MSDOSWindowsSpecialFilenames.PickRandom(num);
        }

        /// <summary>
        ///  Innocuous strings which may be blocked by profanity filters (https://en.wikipedia.org/wiki/Scunthorpe_problem)
        /// </summary>
        public static IEnumerable<string> ScunthorpeProblem(int num = 1)
        {
            return TheNaughtyStrings.ScunthorpeProblem.PickRandom(num);
        }

        /// <summary>
        ///  Strings which may cause human to reinterpret worldview
        /// </summary>
        public static IEnumerable<string> Humaninjection(int num = 1)
        {
            return TheNaughtyStrings.Humaninjection.PickRandom(num);
        }

        /// <summary>
        ///  Strings which punish the fools who use cat/type on this file
        /// </summary>
        public static IEnumerable<string> Terminalescapecodes(int num = 1)
        {
            return TheNaughtyStrings.Terminalescapecodes.PickRandom(num);
        }

        /// <summary>
        ///  Strings which crashed iMessage in various versions of iOS
        /// </summary>
        public static IEnumerable<string> iOSVulnerabilities(int num = 1)
        {
            return TheNaughtyStrings.iOSVulnerabilities.PickRandom(num);
        }

    }
}
