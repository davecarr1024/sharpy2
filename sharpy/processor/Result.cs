namespace sharpy.processor
{
    public class Result<ResultValueT> where ResultValueT : ResultValue
    {
        public ResultValueT? ResultValue { get; init; }

        public IReadOnlyCollection<Result<ResultValueT>> Children { get; init; }

        public string? RuleName { get; init; }

        public Result(ResultValueT? resultValue, IReadOnlyCollection<Result<ResultValueT>> children, string? ruleName = null)
        {
            ResultValue = resultValue;
            Children = children;
            RuleName = ruleName;
        }

        public Result<ResultValueT> WithRuleName(string rule_name)
            => new Result<ResultValueT>(ResultValue, Children, rule_name);
    }
}
