namespace sharpy.processor
{
    public class Error : Exception
    {
        public string? RuleName { get; init; }

        protected Error(string? message = null, string? ruleName = null) : base(message)
            => RuleName = ruleName;

        public virtual Error WithRuleName(string ruleName) => new Error(Message, ruleName);
    }
}
