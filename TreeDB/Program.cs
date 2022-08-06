namespace TreeDBNS {
    public class Program {
        public static void Main(string[] args) {
            TreeDB db = new TreeDB("DB");
            db.addTree("A tree");
            db.addNode(5, "some data");
            db.addNode(3, "more data");
        }
    }
}