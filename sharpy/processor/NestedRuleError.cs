using System.Collections.ObjectModel;

namespace sharpy.processor
{
    public class NestedRuleError<ResultValue, StateValue>
        : RuleError<ResultValue, StateValue>
        
        
    {
        public IReadOnlyCollection<Error> Children { get; private set; }

        protected NestedRuleError(
            IReadOnlyCollection<Error> children,
            Rule<ResultValue, StateValue> rule,
            State<ResultValue, StateValue> state,
            string? message,
            string? ruleName) : base(rule, state, message, ruleName)
            => Children = children;

        public NestedRuleError(
            Rule<ResultValue, StateValue> rule,
            State<ResultValue, StateValue> state,
            IReadOnlyCollection<Error> children,
            string? message = null)
            : this(children, rule, state, message, null) { }

        public NestedRuleError(
            Rule<ResultValue, StateValue> rule,
            State<ResultValue, StateValue> state,
            Error child,
            string? message = null)
            : this(rule, state, new ReadOnlyCollection<Error>(new List<Error> { child }), message) { }

        public override Error WithRuleName(string ruleName)
            => new NestedRuleError<ResultValue, StateValue>(Children, Rule, State, Message, ruleName);
    }
}
