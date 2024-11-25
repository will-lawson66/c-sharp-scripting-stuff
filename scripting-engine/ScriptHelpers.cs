using IronPython.Modules;

namespace scripting_engine
{
    public static class ScriptHelpers
    {
        public static string LoadScript(string? path)
        {
            try
            {
                if (string.IsNullOrEmpty(path))
                    return string.Empty;
                // Open the text file using a stream reader.
                using StreamReader reader = new(path);

                // Read the stream as a string.
                string text = reader.ReadToEnd();

                // Write the text to the console.
                return text;
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return string.Empty;
        }
    }
}
