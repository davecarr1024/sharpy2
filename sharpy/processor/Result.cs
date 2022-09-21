namespace sharpy.processor
{
    public class Result<ResultValue> 
    {
        public ResultValue? Value { get; init; }

        public IReadOnlyCollection<Result<ResultValue>> Children { get; init; }

        public string? RuleName { get; init; }

        public Result(ResultValue? value, IReadOnlyCollection<Result<ResultValue>> children, string? ruleName = null)
        {
            Value = value;
            Children = children;
            RuleName = ruleName;
        }

        public Result(ResultValue? value, string? ruleName = null) : this(value, new List<Result<ResultValue>>(), ruleName) {}

        public Result<ResultValue> WithRuleName(string rule_name)
            => new Result<ResultValue>(Value, Children, rule_name);
    }
}
