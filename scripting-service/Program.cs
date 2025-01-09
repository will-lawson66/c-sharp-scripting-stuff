
using Microsoft.Extensions.Configuration;
using Microsoft.Scripting.Utils;
using scripting_engine;

var configuration = new ConfigurationBuilder()
    .AddInMemoryCollection(new Dictionary<string, string?>()
    {
        ["ScriptFilePath"] = @"..\..\..\..\script_console_basic.txt"
    })
    .Build();

Assert.NotNull(configuration);
Console.WriteLine("Starting scripting service.");

var script = ScriptHelpers.LoadScript(configuration["ScriptFilePath"]);

var engine = new ScriptEngine(new ScriptInterpreter());

Console.WriteLine("Executing script.");
await engine.RunScript(script);
Console.WriteLine("Script execution complete.");