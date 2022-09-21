namespace sharpy.processor
{
    public class ResultAndState<ResultValueT, StateValueT>
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

        public ResultAndState<ResultValueT, StateValueT> AsChildResult()
            => new ResultAndState<ResultValueT, StateValueT>(
                new Result<ResultValueT>(
                    default(ResultValueT),
                    new List<Result<ResultValueT>> { Result }),
                State
            );
    }
}
