namespace scripting_engine
{
    public interface IScriptEngine
    {
        public Task<bool> RunScript(string script);
    }
}
