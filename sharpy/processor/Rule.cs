namespace sharpy.processor
{
    public interface Rule<ResultValueT, StateValueT>
        
        
    {
        ResultAndState<ResultValueT, StateValueT> Apply(State<ResultValueT, StateValueT> state);
    }
}
