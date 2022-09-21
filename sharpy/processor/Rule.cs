namespace sharpy.processor
{
    public interface Rule<ResultValue, StateValue>
        
        
    {
        ResultAndState<ResultValue, StateValue> Apply(State<ResultValue, StateValue> state);
    }
}
