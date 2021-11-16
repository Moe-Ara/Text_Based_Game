using System;

namespace TextBasedGame
{
    public class Start
    {
        protected String _EventDescript;
        protected String _placeName;
        protected Place _placeToEast;
        protected String _PlaceDescript;

        public Start(){
            _EventDescript = "You see a big house to your North-East, it looks renovated and unlike the other houses, it looks like it was built not long ago.\n"
            + "You look at your car and you feel sorry for that poor piece of garbage standing in the middle of a narrow road, emitting heat and some smoke from its front end.\n"
            + "There is a passage to the east that leads to the house.";
            _placeName = "Drive Way";
            _PlaceDescript = $"It is really hard to see anything in this unsetteling darkness, However, {EventDescript}";
        }

        public String EventDescript
        {
            get { return _EventDescript; }
            set
            {
                _EventDescript = value;
            }
        }
        public String PlaceName
        {
            get { return _placeName; }
            set
            {
                _placeName = value;
            }
        }
        public Place PlaceToEast
        {
            get { return _placeToEast; }
            set
            {
                _placeToEast = value;
            }
        }
        public String PlaceDesc
        {
            get { return _PlaceDescript; }
            set
            {
                _PlaceDescript = value;
            }
        }


    }
}