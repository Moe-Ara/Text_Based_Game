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
            _item = new Item("Sword","","",true);
            string PlaceDesc = "big house";
            _place = new Place ("House","Yard","Shed", "Main Street", "", PlaceDesc,$"You enter A {PlaceDesc}");
            _player= new Player("So3ad", "Female","Black Hair",_place);
        }

        [Test]
        public void TestCreatPlayer()
        {
            Assert.That(_player.getName(), Is.EqualTo("So3ad"));
            Assert.That(_player.getSex(), Is.EqualTo("Female"));
            Assert.That(_player.getMycurrentPlaceName, Is.EqualTo(_place.getPlaceName()));

        }
        
        [Test]
        public void TestInventory(){
            StringAssert.Contains("Pocket Knife",_player.printInventory());
            _player.addToInventory(_item);
            StringAssert.Contains("Sword",_player.printInventory());
            //check if player drops item correctly and if it appears in current Place
            _player.dropItemFromInventory(_item);
            StringAssert.DoesNotContain("Sword", _player.printInventory());
            Assert.IsTrue(_player.getMycurrentPlace().checkItemIsHere(_item));
            //check if player picks up item correctly and if it disappears from current Place
            _player.addToInventory(_item);
            Assert.IsFalse(_player.getMycurrentPlace().checkItemIsHere(_item));
        }
        
        [Test]
        public void TestPath(){
            Place _place2 = new Place ("House","Yard","Shed", "Main Street", "","","");
            _path = new Path();
            _path.AddAtLast(_place);
            Assert.AreEqual(_place, _path.getLast());
            _path.AddAtLast(_place2);
            Assert.AreEqual(_place2, _path.getLast());
            _path.RemoveLast();
            Assert.AreEqual(_place, _path.getLast());
        }
        
    }
}