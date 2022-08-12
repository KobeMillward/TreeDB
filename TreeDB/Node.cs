namespace TreeDBNS {
    public class Node : INode {
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

        public bool setData(Object data) {
            this.data = data;
            return true;
        }

        public INode? getLChild() {
            return this.LChild;
        }

        public bool setLChild(Node node) {
            this.LChild = node;
            return true;
        }

        public bool setLChild(IComparable key) {
            this.LChild = new Node(key);
            return true;
        }

        public bool setLChild(IComparable key, Object data) {
            this.LChild = new Node(key, data);
            return true;
        }

        public INode? getRChild() {
            return this.RChild;
        }

        public bool setRChild(INode node) {
            this.RChild = (Node)node;
            return true;
        }
    }
}
