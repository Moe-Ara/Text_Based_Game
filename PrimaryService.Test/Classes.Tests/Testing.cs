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
        [SetUp]
        public void Setup()
        {
            Inventory inventory= new Inventory();
           
            string PlaceDesc = "big house";
            _place = new Place("House", null, null, null, null, PlaceDesc, $"You enter A {PlaceDesc}");
            _player = new Player("So3ad", "Female", "Black Hair", _place,inventory);
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
            Item _item = new Item("Sword", "", "","", true);
            StringAssert.Contains("Pocket Knife", _player.printMyInventory());
            _player.MyInventory.addItem(_item);
            StringAssert.Contains("Sword", _player.printMyInventory());
            //check if player drops item correctly and if it appears in current Place
            _player.removeFromMyInventory(_item);
            StringAssert.DoesNotContain("Sword", _player.printMyInventory());
            Assert.IsTrue(_player.getMycurrentPlace().checkItemIsHere(_item));
            //check if player picks up item correctly and if it disappears from current Place
            _player.addtoMyInventory(_item);
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
            Box b = new Box("Big box", "Heavy and old");
            ContianerItem letter = new ContianerItem("Letter", "Old and wrinkled","", "Yeeehawww", true);
            Item malet = new Item("Malet", "silver", "Heavy af", "",false);
            Assert.IsFalse(malet == null);
            Assert.IsFalse(letter == null);
            b.addContents(malet);
            b.addContents(letter);
            b.pickItem(letter);
            b.pickItem(malet);

            Assert.IsTrue(b.contains(malet));
            Assert.IsFalse(b.contains(letter));
            Assert.AreEqual("Yeeehawww", letter.Contents);
        }


        // [Test]
        // public void TestAssets()
        // {
        //     Item item1= new Item("Malet", "silver", "Heavy af", false);
        //     Item item2= new Item("Malet2", "", "", false);
        //     Item item3= new Item("gallon of gas", "", "", false);

        //     Place _place = new Place("Drive way", null,null,null,null,"Description", "You See Descr");
        //     Asset car =new Car();
        //     car.addItems(item1);
        //     car.addItems(item3);
        //     car.addItems(item3);

        //     _place.addItemToPlace(car.);
        //     Player _player= new Player ("moe","female","meh",_place);
        //     _player.pickItemFromPlace(item1);


        [Test]
        public void TestCommands(){
            Commands commands = new Commands();
            string abrevs= commands.Inspect.printAbbreviation();
            StringAssert.Contains("examine",abrevs);
            StringAssert.Contains("examine", commands.Inspect.getHelp());

        }
        }
    }