namespace Prayer;


public class Prayer : AuditableRecord
{
    public string Title { get; set; } = "";

    public string? Subtitle { get; set; }

    public string Body { get; set; } = "";

    public List<ScriptureReference> ScriptureReferences {get;set;} = new();

    public Author? Author {get;set;}

    public List<Tag> Tags = new();

    public Uri? ImageUrl {get;set;}

    public override string ToString()
    {
        string result = $"{Title}\n";

        if(Subtitle != null)
        {
            result += $"{Subtitle}\n";
        }

        if(Author != null)
        {
            result += $"by {Author}\n";
        }


        if(ScriptureReferences.Count > 0)
        {
            result += string.Join(", ", ScriptureReferences);
            result += "\n";
        }



        return result;
    }
}