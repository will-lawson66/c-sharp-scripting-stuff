using IronPython.Hosting;
using IronPython.Modules;
using Microsoft.Scripting;

namespace scripting_engine
{
    public class ScriptInterpreter : IScriptInterpreter
    {
        public bool Interpret(string script)
        {
            var engine = Python.CreateEngine();
            var scope = engine?.CreateScope();
            var source = engine?.CreateScriptSourceFromString(script, SourceCodeKind.Statements);
            var compiled = source?.Compile();
            try
            {
                if (scope is null)
                    return false;
                _ = compiled?.Execute(scope);
                return true;
            }
            catch (OperationCanceledException ocx)
            {
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught. " + e.Message);
                return false;
            }
        }
    }
}
