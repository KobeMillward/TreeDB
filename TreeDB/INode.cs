namespace TreeDBNS {
    public interface INode {
        IComparable getKey();
        Object? getData();
        INode? getLChild();
        INode? getRChild();
    }
}
