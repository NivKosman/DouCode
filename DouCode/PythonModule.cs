using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using IronPython.Hosting;

namespace DouCode
{
    class PythonModule
    {
        static public String PythonMachine(List<String> i_Code)
        {
            StringBuilder stringBuilder = new StringBuilder("class DouCode:\n    def douCodeMain():\n");
            String pySpacing = "    ";            
            foreach (string line in i_Code)
            {
                stringBuilder.Append(pySpacing + pySpacing + line + "\n");
            }
            String pyCode = stringBuilder.ToString();
            var engine = Python.CreateEngine();
            var source = engine.CreateScriptSourceFromString(pyCode);
            var scope = engine.CreateScope();
            source.Execute(scope);
            var douCodeMain = scope.GetVariable("DouCode");
            var douCodeInstance = engine.Operations.CreateInstance(douCodeMain);
            String result = douCodeInstance.douCodeMain();
            return result;
        }

    }
}
