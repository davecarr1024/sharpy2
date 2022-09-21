namespace sharpy.processor
{
    public class State<ResultValue, StateValue>
        
        
    {
        public IProcessor<ResultValue, StateValue> Processor { get; init; }

        public StateValue Value { get; init; }

        public State(IProcessor<ResultValue, StateValue> processor, StateValue value)
        {
            Processor = processor;
            Value = value;
        }

        public State<ResultValue, StateValue> WithValue(StateValue value)
            => new State<ResultValue, StateValue>(Processor, value);
    }
}
