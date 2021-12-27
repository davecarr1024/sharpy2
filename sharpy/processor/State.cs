namespace sharpy.processor
{
    public class State<ResultValueT, StateValueT>
        where ResultValueT : ResultValue
        where StateValueT : StateValue
    {
        public IProcessor<ResultValueT, StateValueT> Processor { get; init; }

        public StateValueT Value { get; init; }

        public State(IProcessor<ResultValueT, StateValueT> processor, StateValueT value)
        {
            Processor = processor;
            Value = value;
        }

        public State<ResultValueT, StateValueT> WithValue(StateValueT value)
            => new State<ResultValueT, StateValueT>(Processor, value);
    }
}
