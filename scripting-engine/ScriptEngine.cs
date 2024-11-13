namespace scripting_engine
{
    public class ScriptEngine(IScriptInterpreter interpreter) : IScriptEngine
    {
        private string ScriptSource { get; set; } = string.Empty;

        public Task<bool> RunScript(string script)
        {
            return Task.Run(() => interpreter.Interpret(script));
        }

        private Task<bool> RunScript()
        {
            return Task.Run(() => interpreter.Interpret(ScriptSource));
        }
    }
}
