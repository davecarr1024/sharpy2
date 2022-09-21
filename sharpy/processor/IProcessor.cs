namespace sharpy.processor
{
    public interface IProcessor<ResultValue, StateValue>
    {
        ResultAndState<ResultValue, StateValue>
        Apply(
            string rule_name, State<ResultValue, StateValue> state
        );
    }
}
