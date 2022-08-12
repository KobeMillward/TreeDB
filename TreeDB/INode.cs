namespace TreeDBNS {
    public interface INode {
        public IComparable getKey();
        public Object? getData();
        public bool setData();
        public INode? getLChild();
        public bool setLChild();
        public INode? getRChild();
        public bool setRChild(INode node);
    }
}
