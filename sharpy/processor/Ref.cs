namespace sharpy.processor
{
    public class Ref<ResultValueT, StateValueT>
        : Rule<ResultValueT, StateValueT>
        where ResultValueT : ResultValue
        where StateValueT : StateValue
    {
        public string RuleName { get; init; }

        public Ref(string ruleName) => RuleName = ruleName;

        public ResultAndState<ResultValueT, StateValueT> Apply(State<ResultValueT, StateValueT> state)
        {
            try
            {
                return state.Processor.Apply(RuleName, state);
            }
            catch (Error error)
            {
                throw new NestedRuleError<ResultValueT, StateValueT>(this, state, error);
            }
        }
    }
}
