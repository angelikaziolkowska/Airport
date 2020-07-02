using AirportClassLibrary.Classes;
using AirportClassLibrary.Classes.People.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class OutgoingFlight : Flight
    {            
        public int CheckInDeskRef { get; set; }

        //todo : add 'boarding pass' to passenger person


        public int Gate { get; set; }

        public void BoardAFlight(int PersonalReferenceNum)
        {
            BoardingPass boardingPass = GetBoardingPass(PersonalReferenceNum);
            CheckInLuggage(boardingPass);
            GetIntoAirport(boardingPass);
            //.....
            // check in desk with luggage check in w/ weight get 'boarding pass' or via app
            // swipe boarding pass to enter
            // hand luggage security detection cue 
            // shopping and food with gates and 'gate num screen'
            // boarding
            // flight - shop/food
        }

        private BoardingPass GetBoardingPass(int PersonalReferenceNum)
        {
            var boardingPass = new BoardingPass();
            // via app or check in desk
            return boardingPass;
        }

        private void CheckInLuggage(BoardingPass boardingPass)
        {

        }


        private void GetIntoAirport(BoardingPass boardingPass)
        {

        }
    }
}
