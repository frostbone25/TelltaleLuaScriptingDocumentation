using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CustomTelltaleDocumentationBuilder
{
    public class Program
    {
        private static string documentationBaseDirectory = "G:/work/david-telltale-lua-script-documentation/TelltaleLuaScriptingDocumentation";
        private static string documentationReferenceTextFilePath = "G:/work/david-telltale-lua-script-documentation/TelltaleLuaScriptingDocumentation/LuaFunctions.txt";
        private static string luaFunctionsFolderDirectory => documentationBaseDirectory + "/LuaFunctions";

        public struct ExtractedLuaFunction
        {
            public int startingIndex;
            public string[] lines;
        }

        private static void Purge()
        {
            if (Directory.Exists(luaFunctionsFolderDirectory))
                Directory.Delete(luaFunctionsFolderDirectory, true);
        }

        private static void Main(string[] args)
        {
            Purge();

            if (File.Exists(documentationReferenceTextFilePath) == false)
                return;

            if (Directory.Exists(documentationBaseDirectory) == false)
                return;

            if (Directory.Exists(luaFunctionsFolderDirectory) == false)
                Directory.CreateDirectory(luaFunctionsFolderDirectory);  

            string[] referenceTextFileLines = File.ReadAllLines(documentationReferenceTextFilePath);
            int functionCount = 0;
            List<ExtractedLuaFunction> extractedLuaFunctions = new List<ExtractedLuaFunction>();

            for (int i = 0; i < referenceTextFileLines.Length; i++)
            {
                string currentLine = referenceTextFileLines[i];

                if (currentLine == "" || currentLine[0] == ' ' || currentLine[0] == '-')
                    continue;

                if (currentLine[0] == '[')
                {
                    ExtractedLuaFunction extractedLuaFunction = new ExtractedLuaFunction()
                    {
                        startingIndex = i,
                        lines = null
                    };

                    extractedLuaFunctions.Add(extractedLuaFunction);
                    functionCount++;
                }
            }

            for(int i = 0; i < extractedLuaFunctions.Count; i++)
            {
                ExtractedLuaFunction extractedLuaFunction = extractedLuaFunctions[i];
                List<string> lines = new List<string>();

                for(int j = 0; j < 64; j++)
                {
                    string referenceLineFromDocument = referenceTextFileLines[extractedLuaFunction.startingIndex + j];

                    if (referenceLineFromDocument.Length <= 0)
                        continue;

                    if (referenceLineFromDocument[0] == '-')
                    {
                        lines.Add(referenceLineFromDocument);
                    }
                    else
                    {
                        break;
                    }
                }

                extractedLuaFunction.lines = lines.ToArray();
                extractedLuaFunctions[i] = extractedLuaFunction;
            }

            for (int i = 0; i < extractedLuaFunctions.Count; i++)
            {
                ExtractedLuaFunction extractedLuaFunction = extractedLuaFunctions[i];

                string extractedFunctionName = extractedLuaFunction.lines[0];
                //string extractedFunctionName = extractedLuaFunction.lines[0].Replace("[", "").Replace("]", "");
                string newFilePath = luaFunctionsFolderDirectory + "/" + extractedFunctionName + ".md";

                //File.CreateText(newFilePath);
                Console.WriteLine(extractedFunctionName);
            }

            Console.WriteLine("Found about {0} functions.", functionCount);

            Console.ReadKey();
        }
    }
}
