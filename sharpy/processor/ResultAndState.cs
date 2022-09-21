namespace sharpy.processor
{
    public class ResultAndState<ResultValue, StateValue>
    {
        public Result<ResultValue> Result { get; init; }

        public State<ResultValue, StateValue> State { get; init; }

        public ResultAndState(Result<ResultValue> result, State<ResultValue, StateValue> state)
        {
            Result = result;
            State = state;
        }

        public ResultAndState<ResultValue, StateValue> WithRuleName(string rule_name)
            => new ResultAndState<ResultValue, StateValue>(Result.WithRuleName(rule_name), State);

        public ResultAndState<ResultValue, StateValue> AsChildResult()
            => new ResultAndState<ResultValue, StateValue>(
                new Result<ResultValue>(
                    default(ResultValue),
                    new List<Result<ResultValue>> { Result }),
                State
            );
    }
}
