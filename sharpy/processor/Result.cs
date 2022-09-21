namespace sharpy.processor
{
    public class Result<ResultValue> 
    {
        public ResultValue? ResultValue { get; init; }

        public IReadOnlyCollection<Result<ResultValue>> Children { get; init; }

        public string? RuleName { get; init; }

        public Result(ResultValue? resultValue, IReadOnlyCollection<Result<ResultValue>> children, string? ruleName = null)
        {
            ResultValue = resultValue;
            Children = children;
            RuleName = ruleName;
        }

        public Result<ResultValue> WithRuleName(string rule_name)
            => new Result<ResultValue>(ResultValue, Children, rule_name);
    }
}
