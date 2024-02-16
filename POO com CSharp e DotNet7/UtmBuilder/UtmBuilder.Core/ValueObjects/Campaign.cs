namespace UtmBuilder.Core.ValueObjects
{
    public class Campaign(string source,
                          string medium,
                          string name,
                          string? id = null,
                          string? term = null,
                          string? content = null) : ValueObject
    {
        public string Source { get; } = source;
        public string Medium { get; } = medium;
        public string Name { get; } = name;
        public string? Id { get; } = id;
        public string? Term { get; } = term;
        public string? Content { get; } = content;

    }
}
