using Newtonsoft.Json.Linq;

static string promptFor(string prompt)
{
	Console.WriteLine(prompt);
	string? input = Console.ReadLine();
	if (string.IsNullOrEmpty(input))
	{
		Console.WriteLine("Input cannot be empty. Please try again.");
		return promptFor(prompt);
	}
	return input;
}

Name name = new(promptFor("Enter your first name:"), promptFor("Enter your last name:"));

JObject json = new()
{
	["Name"] = JObject.FromObject(name)
};

Console.WriteLine(json.ToString());


record Name(string First, string Last);