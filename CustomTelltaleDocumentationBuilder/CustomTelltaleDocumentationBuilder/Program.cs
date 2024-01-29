using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static CustomTelltaleDocumentationBuilder.Program;
using System.Security.Cryptography;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace CustomTelltaleDocumentationBuilder
{
    public class Program
    {
        private static string documentationBaseDirectory = "G:/work/david-telltale-lua-script-documentation/TelltaleLuaScriptingDocumentation";
        private static string documentationReferenceTextFilePath = "G:/work/david-telltale-lua-script-documentation/TelltaleLuaScriptingDocumentation/LuaFunctions.txt";
        private static string luaFunctionsFolderDirectory => string.Format("{0}/LuaFunctions", documentationBaseDirectory);

        private static string UpperCaseFirstCharacter(string text)
        {
            string newText = text;

            if (string.IsNullOrEmpty(newText) || newText.Length <= 0)
                return newText;

            char[] charArray = newText.ToCharArray();

            charArray[0] = char.ToUpper(charArray[0]);

            return new string(charArray);
        }

        public struct LuaFunctionParameter
        {
            public string parameterType;
            public string parameterDescription;
            public int parameterIndex;
            public bool optional;

            public LuaFunctionParameter(string line)
            {
                string cleanedLine1 = line.Remove(0, "- (PARAMETER) ".Length);
                string cleanedLine2 = cleanedLine1.Replace("(OPTIONAL)", "");
                string[] seperatedLines = cleanedLine2.Split(new char[] { ',', });

                //parameterIndex = int.Parse(seperatedLines[0]);
                //parameterType = seperatedLines[1];
                //parameterDescription = seperatedLines.Length > 1 ? seperatedLines[2] : "";

                parameterIndex = 0;
                parameterType = seperatedLines[0].Replace(" ", "");
                parameterDescription = seperatedLines.Length > 1 ? seperatedLines[1] : "";

                optional = line.Contains("(OPTIONAL)");
            }
        }

        public struct LuaFunctionDocument
        {
            public string functionName;
            public LuaFunctionParameter[] parameters;
            public string returnType;

            public LuaFunctionDocument(string[] lines)
            {
                this.functionName = lines[0].Replace("[", "").Replace("]", "");
                this.returnType = "";

                List<LuaFunctionParameter> parameters = new List<LuaFunctionParameter>();

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains("(PARAMETER)"))
                    {
                        parameters.Add(new LuaFunctionParameter(lines[i]));
                    }
                    else if (lines[i].Contains("(RETURNS)"))
                    {
                        returnType = lines[i].Remove(0, "- (RETURNS) ".Length).Split(new char[] { ',', })[0];
                    }
                }

                this.parameters = parameters.ToArray();
            }

            public bool HasOptionalParameters()
            {
                for(int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i].optional)
                        return true;
                }

                return false;
            }

            public int OptionalParameterCount()
            {
                int optionalParameterCount = 0;

                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i].optional)
                        optionalParameterCount++;
                }

                return optionalParameterCount;
            }

            public string GetDocumentText()
            {
                //TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                string text = "";

                //||||||||||||||||||||||||| TITLE TEXT |||||||||||||||||||||||||
                //||||||||||||||||||||||||| TITLE TEXT |||||||||||||||||||||||||
                //||||||||||||||||||||||||| TITLE TEXT |||||||||||||||||||||||||

                text += string.Format("# {0}", functionName);
                text += "\n";

                //||||||||||||||||||||||||| FULL FUNCTION TEXT |||||||||||||||||||||||||
                //||||||||||||||||||||||||| FULL FUNCTION TEXT |||||||||||||||||||||||||
                //||||||||||||||||||||||||| FULL FUNCTION TEXT |||||||||||||||||||||||||

                text += "\n";
                text += "### " + functionName + "(";

                for(int i = 0; i < parameters.Length; i++)
                {
                    text += parameters[i].parameterType;

                    if (i != parameters.Length - 1)
                        text += ", ";
                }

                text += ")";
                text += "\n";

                //||||||||||||||||||||||||| PARAMETERS |||||||||||||||||||||||||
                //||||||||||||||||||||||||| PARAMETERS |||||||||||||||||||||||||
                //||||||||||||||||||||||||| PARAMETERS |||||||||||||||||||||||||

                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i].optional)
                    {
                        text += string.Format("- ***{0}:*** *(optional)* {1}", parameters[i].parameterType, parameters[i].parameterDescription);
                        text += "\n";
                    }
                    else
                    {
                        text += string.Format("- ***{0}:*** {1}", parameters[i].parameterType, parameters[i].parameterDescription);
                        text += "\n";
                    }
                }

                //||||||||||||||||||||||||| RETURN TYPE |||||||||||||||||||||||||
                //||||||||||||||||||||||||| RETURN TYPE |||||||||||||||||||||||||
                //||||||||||||||||||||||||| RETURN TYPE |||||||||||||||||||||||||

                text += string.Format("- ***Returns:*** {0}", returnType);
                text += "\n";
                text += "\n";

                //||||||||||||||||||||||||| USAGE TITLE |||||||||||||||||||||||||
                //||||||||||||||||||||||||| USAGE TITLE |||||||||||||||||||||||||
                //||||||||||||||||||||||||| USAGE TITLE |||||||||||||||||||||||||

                text += "### Usage";
                text += "\n";
                text += "\n";

                //||||||||||||||||||||||||| USAGE EXAMPLES WITH OPTIONAL PARAMETERS |||||||||||||||||||||||||
                //||||||||||||||||||||||||| USAGE EXAMPLES WITH OPTIONAL PARAMETERS |||||||||||||||||||||||||
                //||||||||||||||||||||||||| USAGE EXAMPLES WITH OPTIONAL PARAMETERS |||||||||||||||||||||||||
                if (HasOptionalParameters())
                {
                    for (int j = OptionalParameterCount() + 1; j > 0; j--)
                    {
                        //||||||||||||||||||||||||| MARKDOWN LUA HEADER |||||||||||||||||||||||||
                        //||||||||||||||||||||||||| MARKDOWN LUA HEADER |||||||||||||||||||||||||
                        //||||||||||||||||||||||||| MARKDOWN LUA HEADER |||||||||||||||||||||||||

                        text += "```Lua";
                        text += "\n";

                        //||||||||||||||||||||||||| LUA FUNCTION VOID TYPE |||||||||||||||||||||||||
                        //||||||||||||||||||||||||| LUA FUNCTION VOID TYPE |||||||||||||||||||||||||
                        //||||||||||||||||||||||||| LUA FUNCTION VOID TYPE |||||||||||||||||||||||||
                        if (returnType.Equals("Nothing") || returnType.Equals("nothing") || returnType.Equals("None") || returnType.Equals("none") || returnType.Equals(" ") || string.IsNullOrEmpty(returnType))
                        {
                            text += functionName + "(";

                            for (int i = 0; i < parameters.Length - (j - 1); i++)
                            {
                                text += string.Format("variable{0}", UpperCaseFirstCharacter(parameters[i].parameterType));

                                if (i != parameters.Length - 1 - (j - 1))
                                    text += ", ";
                            }

                            text += ")";
                            text += "\n";
                        }
                        //||||||||||||||||||||||||| LUA FUNCTION WITH RETURN VALUE |||||||||||||||||||||||||
                        //||||||||||||||||||||||||| LUA FUNCTION WITH RETURN VALUE |||||||||||||||||||||||||
                        //||||||||||||||||||||||||| LUA FUNCTION WITH RETURN VALUE |||||||||||||||||||||||||
                        else
                        {
                            text += "local result" + UpperCaseFirstCharacter(returnType) + " = " + functionName + "(";

                            for (int i = 0; i < parameters.Length - (j - 1); i++)
                            {
                                text += string.Format("variable{0}", UpperCaseFirstCharacter(parameters[i].parameterType));

                                if (i != parameters.Length - 1 - (j - 1))
                                    text += ", ";
                            }

                            text += ")";
                            text += "\n";
                        }

                        //||||||||||||||||||||||||| MARKDOWN LUA HEADER END |||||||||||||||||||||||||
                        //||||||||||||||||||||||||| MARKDOWN LUA HEADER END |||||||||||||||||||||||||
                        //||||||||||||||||||||||||| MARKDOWN LUA HEADER END |||||||||||||||||||||||||

                        text += "```";
                        text += "\n";
                        text += "\n";
                    }
                }
                //||||||||||||||||||||||||| REGULAR USAGE EXAMPLES |||||||||||||||||||||||||
                //||||||||||||||||||||||||| REGULAR USAGE EXAMPLES |||||||||||||||||||||||||
                //||||||||||||||||||||||||| REGULAR USAGE EXAMPLES |||||||||||||||||||||||||
                else
                {
                    //||||||||||||||||||||||||| MARKDOWN LUA HEADER |||||||||||||||||||||||||
                    //||||||||||||||||||||||||| MARKDOWN LUA HEADER |||||||||||||||||||||||||
                    //||||||||||||||||||||||||| MARKDOWN LUA HEADER |||||||||||||||||||||||||

                    text += "```Lua";
                    text += "\n";

                    //||||||||||||||||||||||||| LUA FUNCTION VOID TYPE |||||||||||||||||||||||||
                    //||||||||||||||||||||||||| LUA FUNCTION VOID TYPE |||||||||||||||||||||||||
                    //||||||||||||||||||||||||| LUA FUNCTION VOID TYPE |||||||||||||||||||||||||
                    if (returnType.Equals("Nothing") || returnType.Equals("nothing") || returnType.Equals("None") || returnType.Equals("none") || returnType.Equals(" ") || string.IsNullOrEmpty(returnType))
                    {
                        text += functionName + "(";

                        for (int i = 0; i < parameters.Length; i++)
                        {
                            text += string.Format("variable{0}", UpperCaseFirstCharacter(parameters[i].parameterType));

                            if (i != parameters.Length - 1)
                                text += ", ";
                        }

                        text += ")";
                        text += "\n";
                    }
                    //||||||||||||||||||||||||| LUA FUNCTION WITH RETURN VALUE |||||||||||||||||||||||||
                    //||||||||||||||||||||||||| LUA FUNCTION WITH RETURN VALUE |||||||||||||||||||||||||
                    //||||||||||||||||||||||||| LUA FUNCTION WITH RETURN VALUE |||||||||||||||||||||||||
                    else
                    {
                        text += "local result" + UpperCaseFirstCharacter(returnType) + " = " + functionName + "(";

                        for (int i = 0; i < parameters.Length; i++)
                        {
                            text += string.Format("variable{0}", UpperCaseFirstCharacter(parameters[i].parameterType));

                            if (i != parameters.Length - 1)
                                text += ", ";
                        }

                        text += ")";
                        text += "\n";
                    }

                    //||||||||||||||||||||||||| MARKDOWN LUA HEADER END |||||||||||||||||||||||||
                    //||||||||||||||||||||||||| MARKDOWN LUA HEADER END |||||||||||||||||||||||||
                    //||||||||||||||||||||||||| MARKDOWN LUA HEADER END |||||||||||||||||||||||||

                    text += "```";
                    text += "\n";
                }

                text += "\n";
                text += "\n";
                text += "[Back To Scripting Documentation](../README.md)";
                text += "\n";

                return text;
            }
        }

        private static void Purge()
        {
            if (Directory.Exists(luaFunctionsFolderDirectory))
                Directory.Delete(luaFunctionsFolderDirectory, true);
        }

        private static void Main(string[] args)
        {
            //clear prior generated data
            Purge();

            //check if our folders do exist
            if (File.Exists(documentationReferenceTextFilePath) == false || Directory.Exists(documentationBaseDirectory) == false)
                return;

            //create a directory to store the singluar 
            if (Directory.Exists(luaFunctionsFolderDirectory) == false)
                Directory.CreateDirectory(luaFunctionsFolderDirectory);  

            //read all lines in the reference text file
            string[] referenceTextFileLines = File.ReadAllLines(documentationReferenceTextFilePath);

            //prepare array for lua function
            List<LuaFunctionDocument> luaFunctionDocuments = new List<LuaFunctionDocument>();

            //iterate through all lines in the reference text file
            for (int i = 0; i < referenceTextFileLines.Length; i++)
            {
                string currentLine = referenceTextFileLines[i];

                //if the current line is empty, or it's first character has a space, or it's first character has a dash
                if (currentLine == "" || currentLine[0] == ' ' || currentLine[0] == '-')
                    continue; //skip to the next iteration in the loop

                //if the first character in the first line has a [
                if (currentLine[0] == '[')
                {
                    //initalize the lines for the current function
                    List<string> lines = new List<string>
                    {
                        currentLine //add the current line, which is the function name
                    };

                    /*
                    //search down the reference text lines (up to 32 lines)
                    for (int lineSearchIndex = 1; lineSearchIndex <= 32; lineSearchIndex++)
                    {
                        int indexSearch = i + lineSearchIndex;

                        //stop searching if the index goes beyond the amount of lines in the reference text file.
                        if (indexSearch > referenceTextFileLines.Length - 1)
                            break;

                        string referenceLineFromDocument = referenceTextFileLines[i + lineSearchIndex];

                        //if the new selected line doesn't exist then break
                        if (referenceLineFromDocument.Length <= 0)
                            break;

                        //if there is a dash then add it!
                        if (referenceLineFromDocument[0] == '-')
                            lines.Add(referenceLineFromDocument);

                        lineSearchIndex++;
                    }
                    */

                    int lineSearchIndex = 0;

                    while (true)
                    {
                        int indexSearch = (i + 1) + lineSearchIndex;

                        if (indexSearch > referenceTextFileLines.Length - 1)
                            break;

                        string referenceLineFromDocument = referenceTextFileLines[(i + 1) + lineSearchIndex];

                        if (referenceLineFromDocument.Length <= 0)
                            break;

                        if (referenceLineFromDocument[0] == '-')
                            lines.Add(referenceLineFromDocument);

                        if (referenceLineFromDocument[0] == '[')
                            break;

                        lineSearchIndex++;
                    }

                    LuaFunctionDocument extractedLuaFunction = new LuaFunctionDocument(lines.ToArray());
                    luaFunctionDocuments.Add(extractedLuaFunction);
                }
            }

            for (int i = 0; i < luaFunctionDocuments.Count; i++)
            {
                LuaFunctionDocument extractedLuaFunction = luaFunctionDocuments[i];

                string newFilePath = string.Format("{0}/{1}.md", luaFunctionsFolderDirectory, extractedLuaFunction.functionName);

                if (File.Exists(newFilePath) == false)
                    File.WriteAllText(newFilePath, extractedLuaFunction.GetDocumentText());

                Console.WriteLine(extractedLuaFunction.functionName);
            }

            string masterFilePath = documentationBaseDirectory + "/README.md";

            if(File.Exists(masterFilePath))
                File.Delete(masterFilePath);

            {
                string readmeContents = "";

                readmeContents += "# Telltale Lua Scripting Documentation";
                readmeContents += "\n";
                readmeContents += "\n";

                readmeContents += "# Lua Functions";
                readmeContents += "\n";
                readmeContents += "\n";

                for (int i = 0; i < luaFunctionDocuments.Count; i++)
                {
                    readmeContents += string.Format("[{0}](LuaFunctions/{0}.md)", luaFunctionDocuments[i].functionName);
                    readmeContents += "\n";
                }

                File.WriteAllText(masterFilePath, readmeContents);
            }

            Console.WriteLine("Found about {0} functions.", luaFunctionDocuments.Count);

            Console.ReadKey();
        }
    }
}
