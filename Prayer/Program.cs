namespace Prayer;

public class Program
{
    static void Main(string[] args)
    {
        Prayer p = new Prayer();
        p.Title = "Title";
        p.ScriptureReferences.Add(
            new ScriptureReference() {
                Book="Matthew",
                Chapter=1,
                StartVerse=1,
                EndVerse=3
                });
        p.ScriptureReferences.Add(
            new ScriptureReference() {
                Book="Mark",
                Chapter=2,
                StartVerse=2,
                EndVerse=4
                });
        p.ScriptureReferences.Add(
            new ScriptureReference() {
                Book="John",
                Chapter=8,
                StartVerse=2,
                EndVerse=2
                });

        System.Console.WriteLine(p);


    }

}

