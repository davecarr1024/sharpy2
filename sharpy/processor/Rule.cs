namespace sharpy.processor
{
    public interface Rule<ResultValueT, StateValueT>
        where ResultValueT : ResultValue
        where StateValueT : StateValue
    {
        ResultAndState<ResultValueT, StateValueT> Apply(State<ResultValueT, StateValueT> state);
    }
}
