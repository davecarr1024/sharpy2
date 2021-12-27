namespace sharpy.processor
{
    public class ResultAndState<ResultValueT, StateValueT>
        where ResultValueT : ResultValue
        where StateValueT : StateValue
    {
        public Result<ResultValueT> Result { get; init; }

        public State<ResultValueT, StateValueT> State { get; init; }

        public ResultAndState(Result<ResultValueT> result, State<ResultValueT, StateValueT> state)
        {
            Result = result;
            State = state;
        }

        public ResultAndState<ResultValueT, StateValueT> WithRuleName(string rule_name)
            => new ResultAndState<ResultValueT, StateValueT>(Result.WithRuleName(rule_name), State);
    }
}
