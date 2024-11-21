
using scripting_engine;

Console.WriteLine("Starting scripting service.");

var script = "import clr\r\nclr.AddReference(\"mscorlib\")\r\nimport System\r\nSystem.Console.WriteLine(\"Hello from IronPython!\")";

var engine = new ScriptEngine(new ScriptInterpreter());

Console.WriteLine("Executing script.");
await engine.RunScript(script);
Console.WriteLine("Script execution complete.");