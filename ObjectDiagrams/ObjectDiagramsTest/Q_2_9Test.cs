using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ObjectDiagramsTest
{
    [TestClass]
    public class Q_2_9Test
    {
        [TestMethod]
        public void Q_2_9()
        {
            var 自宅 = new 場所(); // 東山七条
            var 会社 = new 場所(); // 龍谷大学深草学舎
            var 京都駅 = new 場所();
            var 七条駅 = new 場所();
            var 稲荷駅 = new 場所();
            var くいな橋駅 = new 場所();
            var 深草駅 = new 場所();

            var 車 = new 手段();
            var バス = new 手段();
            var 徒歩 = new 手段();
            var JR = new 手段();
            var 地下鉄 = new 手段();
            var 私鉄 = new 手段();

            var 自宅_京都駅 = new 移動 { 始点 = 自宅, 終点 = 京都駅, 手段 = バス, 分 = 10 };

            var 経路_車 = new[]
            {
                new 移動 { 始点 = 自宅, 終点 = 会社, 手段 = 車, 分 = 30 },
            };
            var 経路_JR = new[]
            {
                自宅_京都駅,
                new 移動 { 始点 = 京都駅, 終点 = 稲荷駅, 手段 = JR, 分 = 15 },
                new 移動 { 始点 = 稲荷駅, 終点 = 会社, 手段 = 徒歩, 分 = 8 },
            };
            var 経路_地下鉄 = new[]
            {
                自宅_京都駅,
                new 移動 { 始点 = 京都駅, 終点 = くいな橋駅, 手段 = 地下鉄, 分 = 10 },
                new 移動 { 始点 = くいな橋駅, 終点 = 会社, 手段 = 徒歩, 分 = 12 },
            };
            var 経路_私鉄 = new[]
            {
                new 移動 { 始点 = 自宅, 終点 = 七条駅, 手段 = 徒歩, 分 = 15 },
                new 移動 { 始点 = 七条駅, 終点 = 深草駅, 手段 = 私鉄, 分 = 20 },
                new 移動 { 始点 = 深草駅, 終点 = 会社, 手段 = 徒歩, 分 = 3 },
            };
        }
    }

    public class 場所 { }
    public class 手段 { }
    public class 移動
    {
        public 場所 始点;
        public 場所 終点;
        public 手段 手段;
        public int 分;
    }
}
