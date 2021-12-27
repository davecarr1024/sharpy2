using System.Collections.ObjectModel;

namespace sharpy.processor
{
    public class NestedRuleError<ResultValueT, StateValueT>
        : RuleError<ResultValueT, StateValueT>
        where ResultValueT : ResultValue
        where StateValueT : StateValue
    {
        public IReadOnlyCollection<Error> Children { get; private set; }

        protected NestedRuleError(
            IReadOnlyCollection<Error> children,
            Rule<ResultValueT, StateValueT> rule,
            State<ResultValueT, StateValueT> state,
            string? message,
            string? ruleName) : base(rule, state, message, ruleName)
            => Children = children;

        public NestedRuleError(
            Rule<ResultValueT, StateValueT> rule,
            State<ResultValueT, StateValueT> state,
            IReadOnlyCollection<Error> children,
            string? message = null)
            : this(children, rule, state, message, null) { }

        public NestedRuleError(
            Rule<ResultValueT, StateValueT> rule,
            State<ResultValueT, StateValueT> state,
            Error child,
            string? message = null)
            : this(rule, state, new ReadOnlyCollection<Error>(new List<Error> { child }), message) { }

        public override Error WithRuleName(string ruleName)
            => new NestedRuleError<ResultValueT, StateValueT>(Children, Rule, State, Message, ruleName);
    }
}
