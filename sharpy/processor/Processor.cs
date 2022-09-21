namespace sharpy.processor
{
    public class Processor<ResultValueT, StateValueT>
        : IProcessor<ResultValueT, StateValueT>
        
        
    {
        public string RootRuleName { get; init; }

        public IReadOnlyDictionary<string, Rule<ResultValueT, StateValueT>> Rules { get; init; }

        public Processor(string rootRuleName, IReadOnlyDictionary<string, Rule<ResultValueT, StateValueT>> rules)
        {
            RootRuleName = rootRuleName;
            Rules = rules;
        }

        public ResultAndState<ResultValueT, StateValueT> Apply(string ruleName, State<ResultValueT, StateValueT> state)
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

        public ResultAndState<ResultValueT, StateValueT> Apply(State<ResultValueT, StateValueT> state)
            => Apply(RootRuleName, state);

        public ResultAndState<ResultValueT, StateValueT> Apply(StateValueT stateValue)
            => Apply(new State<ResultValueT, StateValueT>(this, stateValue));
    }
}
