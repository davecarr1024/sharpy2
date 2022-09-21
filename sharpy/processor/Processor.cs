namespace sharpy.processor
{
    public class Processor<ResultValue, StateValue>
        : IProcessor<ResultValue, StateValue>
        
        
    {
        public string RootRuleName { get; init; }

        public IReadOnlyDictionary<string, Rule<ResultValue, StateValue>> Rules { get; init; }

        public Processor(string rootRuleName, IReadOnlyDictionary<string, Rule<ResultValue, StateValue>> rules)
        {
            RootRuleName = rootRuleName;
            Rules = rules;
        }

        public ResultAndState<ResultValue, StateValue> Apply(string ruleName, State<ResultValue, StateValue> state)
        {
            try
            {
                return Rules[RootRuleName].Apply(state).WithRuleName(ruleName);
            }
            catch (Error error)
            {
                throw error.WithRuleName(ruleName);
            }
        }

        public ResultAndState<ResultValue, StateValue> Apply(State<ResultValue, StateValue> state)
            => Apply(RootRuleName, state);

        public ResultAndState<ResultValue, StateValue> Apply(StateValue stateValue)
            => Apply(new State<ResultValue, StateValue>(this, stateValue));
    }
}
