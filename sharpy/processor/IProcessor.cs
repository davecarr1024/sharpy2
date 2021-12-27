namespace sharpy.processor
{
    public interface IProcessor<ResultValueT, StateValueT>
        where ResultValueT : ResultValue
        where StateValueT : StateValue
    {
        ResultAndState<ResultValueT, StateValueT> Apply(string rule_name, State<ResultValueT, StateValueT> state);
    }
}
