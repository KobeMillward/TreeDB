namespace TreeDBNS {
    public interface ITree {
        INode getRoot();
        bool addNode(IComparable key, INode root);
    }
}
