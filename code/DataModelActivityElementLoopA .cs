public sealed class DataModelActivityElementLoopA : DataModelActivityElement
{
    public DataModelActivityElementLoopA()
        : base("LoopA", true)
    {
    }
    public string? OnLoopSuccessor { get; set; }
    public string? OnFinishedSuccessor { get; set; }
    public int MaxIterationCount { get; set; } = 5;
    public DataModelFlowReference ComparisonFlow { get; set; } = null!;
    public DataModelOperatorType Operator { get; set; } = DataModelOperatorType.Equal;
    public Dictionary<string, DataModelActivityArgument> InputPorts { get; set; } = new();
}

