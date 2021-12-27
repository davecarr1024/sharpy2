namespace sharpy.processor
{
    public class RuleError<ResultValueT, StateValueT>
        : Error
        where ResultValueT : ResultValue
        where StateValueT : StateValue
    {
        public Rule<ResultValueT, StateValueT> Rule { get; init; }

        public State<ResultValueT, StateValueT> State { get; init; }

        protected RuleError(Rule<ResultValueT, StateValueT> rule, State<ResultValueT, StateValueT> state, string? message, string? ruleName)
        : base(message, ruleName)
        {
            Rule = rule;
            State = state;
        }

        public RuleError(Rule<ResultValueT, StateValueT> rule, State<ResultValueT, StateValueT> state, string? message = null)
            : this(rule, state, message, null) { }

        public override Error WithRuleName(string ruleName)
            => new RuleError<ResultValueT, StateValueT>(Rule, State, Message, ruleName);
    }
}
