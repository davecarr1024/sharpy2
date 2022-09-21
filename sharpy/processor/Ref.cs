namespace sharpy.processor
{
    public class Ref<ResultValue, StateValue>
        : Rule<ResultValue, StateValue>
        
        
    {
        public string RuleName { get; init; }

        public Ref(string ruleName) => RuleName = ruleName;

        public ResultAndState<ResultValue, StateValue> Apply(State<ResultValue, StateValue> state)
        {
            try
            {
                return state.Processor.Apply(RuleName, state).AsChildResult();
            }
            catch (Error error)
            {
                throw new NestedRuleError<ResultValue, StateValue>(this, state, error);
            }
        }
    }
}
