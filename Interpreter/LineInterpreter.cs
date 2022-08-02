using System;
using StructuredTextEmu.TextReader;

namespace StructuredTextEmu.Interpreter
{
    public class LineInterpreter
    {
        public FunctionClass Interprete(string line)
        {
            for (int i = 0; i < ConstReservedKeywords.Keywords.Length; ++i)
            {
                if (line.Contains(ConstReservedKeywords.Keywords[i]))
                {
                    switch (ConstReservedKeywords.Keywords[i])
                    {
                        case ConstReservedKeywords.Set:
                            break;
                    }
                }
            }
        }
    }
}

