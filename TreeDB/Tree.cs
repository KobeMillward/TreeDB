namespace TreeDBNS {
    class Tree : ITree {
        private string name;
        private INode? root;
        
        public Tree(string name) {
            this.name = name;
        }

        public INode? getRoot() {
            return this.root;
        }

        public string getName() {
            return this.name;
        }

        public bool addNode(IComparable key, INode root) {
            if (root == null) {
                root = new Node(key);
            }
            if (key.CompareTo(root.getKey()) < 0) {
                return addNode(key, root.getLChild());
            }
            if (key.CompareTo(root.getKey()) > 0) {
                return addNode(key, root.getRChild());
            }
            return false;
        }

        public bool addNode(IComparable key, Object data, INode root) {
            if (root == null) {
                root = new Node(key, data);
            }
            if (key.CompareTo(root.getKey()) < 0) {
                return addNode(key, root.getLChild());
            }
            if (key.CompareTo(root.getKey()) > 0) {
                return addNode(key, root.getRChild());
            }
            return false;
        }
    }
}
