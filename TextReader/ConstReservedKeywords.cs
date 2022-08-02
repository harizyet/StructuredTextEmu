using System;
using System.Security.Cryptography.X509Certificates;

namespace StructuredTextEmu.TextReader
{
    public class ConstReservedKeywords
    {
        public const string Keyword_IF = "IF";
        public const string Keyword_ELSE = "ELSE";
        public const string Keyword_THEN = "THEN";
        public const string Keyword_END_IF = "END_IF";
        public const string Keyword_AND = "AND";
        public const string Keyword_OR = "OR";
        public const string Set = ":=";

        public const string Delimiter = ";";
        public const string Comment_Start = "(*";
        public const string Comment_End = "*)";

        public static string[] Keywords = new string[]
        {
            Keyword_AND,
            Keyword_OR,
            Keyword_END_IF,
            Keyword_IF,
            Keyword_ELSE,
            Keyword_THEN,
            Set
        };
    }
}

