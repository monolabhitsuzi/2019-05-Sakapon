using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ObjectDiagramsTest
{
    [TestClass]
    public class Q_2_8Test
    {
        [TestMethod]
        public void Q_2_8()
        {
            var 先頭 = new くさび形車両();
            var 中間 = new 箱形車両();
            var 末尾 = new くさび形車両();
            var 新幹線 = new 車両[] { 先頭, 中間, 末尾 };
        }
    }

    public abstract class 車両 { }
    public class くさび形車両 : 車両 { }
    public class 箱形車両 : 車両 { }
}
