using NUnit.Framework;
using TextBasedGame;

namespace PrimaryService.Test
{
    [TestFixture]
    public class Testing
    {
        private Path _path;
        private Player _player;
        private Place _place;
        private Item _item;
        [SetUp]
        public void Setup()
        {
            _item = new Item("Sword", "", "", true);
            string PlaceDesc = "big house";
            _place = new Place("House", null, null, null, null, PlaceDesc, $"You enter A {PlaceDesc}");
            _player = new Player("So3ad", "Female", "Black Hair", _place);
        }

        [Test]
        public void TestCreatPlayer()
        {
            Assert.That(_player.getName(), Is.EqualTo("So3ad"));
            Assert.That(_player.getSex(), Is.EqualTo("Female"));
            Assert.That(_player.getMycurrentPlaceName, Is.EqualTo(_place.getPlaceName()));

        }

        [Test]
        public void TestInventory()
        {
            StringAssert.Contains("Pocket Knife", _player.printInventory());
            _player.addToInventory(_item);
            StringAssert.Contains("Sword", _player.printInventory());
            //check if player drops item correctly and if it appears in current Place
            _player.dropItemFromInventory(_item);
            StringAssert.DoesNotContain("Sword", _player.printInventory());
            Assert.IsTrue(_player.getMycurrentPlace().checkItemIsHere(_item));
            //check if player picks up item correctly and if it disappears from current Place
            _player.addToInventory(_item);
            Assert.IsFalse(_player.getMycurrentPlace().checkItemIsHere(_item));
        }

        [Test]
        public void TestPath()
        {
            Place _place2 = new Place("House", null, null, null, null, "", "");
            _path = new Path();
            _path.AddAtLast(_place);
            Assert.AreEqual(_place, _path.getLastPlace());
            _path.AddAtLast(_place2);
            Assert.AreEqual(_place2, _path.getLastPlace());
            _path.RemoveLast();
            Assert.AreEqual(_place, _path.getLastPlace());
            _path.RemoveLast();
            Assert.AreEqual(_place, _path.getLastPlace());
            int i = 0;
            for (i = 0; i < 100; i++)
            {
                _path.AddAtLast(_place);
            }
            Assert.AreEqual(_path.getCount(), i + 1);
            _path = null;
        }

        [Test]
        public void TestContainerItem()
        {
            ContianerItem letter = new ContianerItem("Letter", "Old and wrinkled", "Yeeehawww", true);
            Box box = new Box("Big box", "Heavy and old");
            Item malet = new Item("Malet", "silver", "Heavy af", false);
            Assert.IsFalse(malet==null);
            Assert.IsFalse(letter==null);
            box.addContents(malet);
            box.addContents(letter);
            box.pickItem(letter);
            box.pickItem(malet);

            Assert.IsTrue(box.contains(malet));
            Assert.IsFalse(box.contains(letter));
            Assert.AreEqual("Yeeehawww", letter.Contents);
        }

    }
}