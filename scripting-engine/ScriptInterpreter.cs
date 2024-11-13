using IronPython.Hosting;

namespace scripting_engine
{
    public class ScriptInterpreter : IScriptInterpreter
    {
        public bool Interpret(string script)
        {
            var engine = Python.CreateEngine();
            var scope = engine?.CreateScope();
            var source = engine?.CreateScriptSourceFromString(script);
            var compiled = source?.Compile();
            try
            {
                _ = compiled?.Execute();
                return true;
            }
            catch (OperationCanceledException ocx)
            {
                return false;
            }
        }
    }
}
