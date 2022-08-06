namespace TreeDBNS {
    public class TreeDB {
        private string name;
        private Tree[] trees;
        private Tree active;

        public TreeDB(string name) {
            this.name = name;
        }

        public string getName() {
            return this.name;
        }

        public bool addTree(string name) {
            if (trees == null) {
                trees = new Tree[1];
                trees[0] = new Tree(name);
                active = trees[0];
                return true;
            }
            foreach (var tree in trees) {
                if (name.Equals(tree.getName())) return false;  
            }
            Tree[] t = new Tree[trees.Length+1];
            this.trees.CopyTo(t, 0);
            t[t.Length-1] = new Tree(name);
            this.trees = t;
            return true;
        }

        public bool addNode(IComparable key) {
            return active.addNode(key, active.getRoot());
        }

        public bool addNode(IComparable key, Object data) {
            return active.addNode(key, data, active.getRoot());
        }
    }
}