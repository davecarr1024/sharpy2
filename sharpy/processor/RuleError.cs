namespace sharpy.processor
{
    public class RuleError<ResultValue, StateValue>
        : Error
        
        
    {
        public Rule<ResultValue, StateValue> Rule { get; init; }

        public State<ResultValue, StateValue> State { get; init; }

        protected RuleError(Rule<ResultValue, StateValue> rule, State<ResultValue, StateValue> state, string? message, string? ruleName)
        : base(message, ruleName)
        {
            Rule = rule;
            State = state;
        }

        public RuleError(Rule<ResultValue, StateValue> rule, State<ResultValue, StateValue> state, string? message = null)
            : this(rule, state, message, null) { }

        public override Error WithRuleName(string ruleName)
            => new RuleError<ResultValue, StateValue>(Rule, State, Message, ruleName);
    }
}
