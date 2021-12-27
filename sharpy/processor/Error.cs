namespace sharpy.processor
{
    public class Error : Exception
    {
        public string? RuleName { get; init; }

        public Error(string? message = null) : this(message, null) { }

        protected Error(string? message, string? ruleName) : base(message)
            => RuleName = ruleName;

        public virtual Error WithRuleName(string ruleName) => new Error(Message, ruleName);
    }
}
