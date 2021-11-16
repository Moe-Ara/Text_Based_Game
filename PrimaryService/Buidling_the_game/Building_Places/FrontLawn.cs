using System;

namespace TextBasedGame
{
    public class FrontLawn
    {
        protected String _EventDescript;
        protected String _placeName;
        protected Place _placeToEast;
        protected String _PlaceDescript;

        public FrontLawn(){
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