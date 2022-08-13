namespace TreeDBNS {
    public class Node : INode {
        private IComparable key;
        private Object? data;
        private INode? LChild;
        private INode? RChild;

        public Node(IComparable key) {
            this.key = key;
        }

        public Node(IComparable key, Object? data) {
            this.key = key;
            this.data = data;
        }
        // KEY
        public IComparable getKey() {
            return this.key;
        }

        // DATA
        public Object? getData() {
            return this.data;
        }

        public bool setData(Object? data) {
            this.data = data;
            return true;
        }

        // Left Child
        public INode? getLChild() {
            return this.LChild;
        }

        public bool setLChild(INode node) {
            this.LChild = node;
            return true;
        }

        public bool setLChild(IComparable key) {
            this.LChild = new Node(key);
            return true;
        }

        public bool setLChild(IComparable key, Object? data) {
            this.LChild = new Node(key, data);
            return true;
        }

        // Right Child
        public INode? getRChild() {
            return this.RChild;
        }

        public bool setRChild(INode node) {
            this.RChild = node;
            return true;
        }

        public bool setRChild(IComparable key) {
            this.RChild = new Node(key);
            return true;
        }

        public bool setRChild(IComparable key, Object? data) {
            this.RChild = new Node(key, data);
            return true;
        }
    }
}
