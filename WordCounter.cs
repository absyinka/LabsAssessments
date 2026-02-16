using System.Text;

namespace LabsAssessments;

public class WordCounter
{
    public Dictionary<string, int> WordCountEngine(string text)
    {
        var counts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        var builder = new StringBuilder();

        foreach (char c in text) //edge cases SDLC
        {
            if (IsIgnoredPunctuation(c) || char.IsWhiteSpace(c))
            {
                if (builder.Length > 0)
                {
                    AddWord(counts, builder.ToString());
                }

                builder.Clear();
                continue;
            }

            builder.Append(char.ToLowerInvariant(c));
        }

        if (builder.Length > 0)
        {
            AddWord(counts, builder.ToString());
        }

        return counts;
    }

    void AddWord(Dictionary<string, int> dict, string word)
    {
        dict.TryGetValue(word, out int count);
        dict[word] = count + 1;
    }

    bool IsIgnoredPunctuation(char c)
    {
        return c == '.' || c == ',' || c == '!' || c == '?';
    }
}
