using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroFlotApp {
    public class Flight {
        
        public string FlightNumber { get; }
        public string Route { get; }
        public string IntermediatePoints { get; }
        public string DepartureTime { get; }
        public DaysOfWeek[] DaysOfFlight { get; }

        public string DaysOfFlightString {
            get {
                string daysOfFlightString = "";

                foreach (var day in DaysOfFlight) {
                    daysOfFlightString += $"{day}, ";
                }

                return daysOfFlightString.Substring(0, daysOfFlightString.Length - 2);
            }
        }
        public int AvailableSeats { get; set; }

        public FlightSchedule FlightSchedule {
            get => default;
            set { }
        }

        public Flight(string flightNumber, string route, string intermediatePoints, string departureTime, DaysOfWeek[] daysOfFlight, int availableSeats) {
            FlightNumber = flightNumber;
            Route = route;
            IntermediatePoints = intermediatePoints;
            DepartureTime = departureTime;
            AvailableSeats = availableSeats;
            DaysOfFlight = daysOfFlight;
        }
    }
}
