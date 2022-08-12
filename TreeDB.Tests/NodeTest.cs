using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeDBNS;

namespace TreeDBNS.Tests {
    [TestClass]
    public class NodeTest {
        [TestMethod]
        public void TestInit1() {
            Node node = new Node(5);
            Assert.AreEqual(5, node.getKey());
            Assert.AreEqual(null, node.getData());
        }

        [TestMethod]
        public void TestInit2() {
            Node node = new Node("Node");
            Assert.AreEqual("Node", node.getKey());
            Assert.AreEqual(null, node.getData());
        }

        [TestMethod]
        public void TestInit3() {
            Node node = new Node(true);
            Assert.AreEqual(true, node.getKey());
            Assert.AreEqual(null, node.getData());
        }

        [TestMethod]
        public void TestInit4() {
            Node node = new Node(0b00000000);
            Assert.AreEqual(0b00000000, node.getKey());
            Assert.AreEqual(null, node.getData());
        }
    }
}
