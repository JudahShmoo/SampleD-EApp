using Newtonsoft.Json.Linq;
using Markdig;

MarkdownPipeline pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
string promptFor(string prompt)
{
	Console.WriteLine(prompt);
	string? input = Console.ReadLine();
	if (string.IsNullOrEmpty(input))
	{
		Console.WriteLine("Input cannot be empty. Please try again.");
		return promptFor(prompt);
	}
	return Markdown.ToHtml(input, pipeline);
}

JObject json = new()
{
	["Name"] = JObject.FromObject(new Name(promptFor("Enter your first name:"), promptFor("Enter your last name:"))),
	["Description"] = promptFor("Enter a description:")
};

Console.WriteLine(json.ToString());
Console.ReadKey();

record Name(string First, string Last);