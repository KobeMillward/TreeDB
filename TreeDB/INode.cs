namespace TreeDBNS {
    public interface INode {
        // KEY
        public IComparable getKey();
        
        // DATA
        public Object? getData();
        public bool setData(Object? data);
        
        // Left Child
        public INode? getLChild();
        public bool setLChild(INode node);
        public bool setLChild(IComparable key);
        public bool setLChild(IComparable key, Object? data);

        // Right Child
        public INode? getRChild();
        public bool setRChild(INode node);
        public bool setRChild(IComparable key);
        public bool setRChild(IComparable key, Object? data);
    }
}
