namespace sharpy.processor
{
    public interface IProcessor<ResultValueT, StateValueT>
    {
        ResultAndState<ResultValueT, StateValueT>
        Apply(
            string rule_name, State<ResultValueT, StateValueT> state
        );
    }
}
