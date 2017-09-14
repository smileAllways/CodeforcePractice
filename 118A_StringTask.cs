using System;

namespace CodeForce
{
    class _118A_StringTask
    {
        void StringTask()
        {
            // 92ms
            string input = Console.ReadLine();

            foreach (char c in input)
            {
                switch ((int)c)
                {
                    case 65:
                    case 69:
                    case 73:
                    case 79:
                    case 85:
                    case 89:
                    case 97:
                    case 101:
                    case 105:
                    case 111:
                    case 117:
                    case 121:
                        break;
                    default:
                        Console.Write('.');
                        if (c >= 65 && c <= 90)
                        {
                            Console.Write((char)(c + 32));
                        }
                        else
                        {
                            Console.Write(c);
                        }
                        break;
                }
            }

            // 124ms
            /*
            string input = Console.ReadLine().ToLower();

            foreach(char c in input)
            {
                switch ((int)c)
                {
                    case 65:
                    case 69:
                    case 73:
                    case 79:
                    case 85:
                    case 89:
                    case 97:
                    case 101:
                    case 105:
                    case 111:
                    case 117:
                    case 121:
                        break;
                    default:
                        Console.Write('.');
                        Console.Write(c);
                        break;
                }
            }*/
        }
    }
}