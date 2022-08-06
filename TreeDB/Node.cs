namespace TreeDBNS {
    class Node : INode {
        private IComparable key;
        private Object? data;
        private Node? LChild;
        private Node? RChild;

        public Node(IComparable key) {
            this.key = key;
        }

        public Node(IComparable key, Object data) {
            this.key = key;
            this.data = data;
        }
        
        public IComparable getKey() {
            return this.key;
        }

        public Object? getData() {
            return this.data;
        }

        public INode? getLChild() {
            return this.LChild;
        }

        public INode? getRChild() {
            return this.RChild;
        }
    }
}
