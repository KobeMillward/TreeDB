namespace TreeDBNS {
    interface INode {
        IComparable getKey();
        Object? getData();
        INode? getLChild();
        INode? getRChild();
    }
}
