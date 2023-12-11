using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace AeroFlotApp {
    public class FlightSchedule {
        private List<Flight> flights;
        private string filePath;
        private readonly FileHandler fileHandler;

        public int Count { get { return flights.Count; } }

        public FlightSchedule(string filePath) {
            flights = new List<Flight>();
            this.filePath = filePath;
            fileHandler = new FileHandler(filePath);
        }

        public void AddFlight(Flight flight) {
            flights.Add(flight);
        }

        public void SetFlights(List<Flight> flights) {
            this.flights = flights;
        }

        public List<Flight> GetFlights() {
            return flights;
        }

        public Flight FindClosestFlight(string destination) {
            Flight closestFlight = null;
            TimeSpan closestFlightTime = TimeSpan.MaxValue;

            foreach (var flight in flights) {
                string flightDestination = flight.Route.ToLower().Split('-')[1].Trim();
                if ((flightDestination.Contains(destination.ToLower()) || flight.IntermediatePoints.ToLower().Contains(destination.ToLower())) && flight.AvailableSeats > 0) {
                    TimeSpan timeToFirstFlight = TimeSpan.Parse(flight.DepartureTime) - DateTime.Now.TimeOfDay;

                    DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DayOfWeek), DateTime.Now.DayOfWeek.ToString());
                    DaysOfWeek[] daysOfFlight = flight.DaysOfFlight;

                    DaysOfWeek closestDayOfFlight = DaysOfWeek.Пн;

                    foreach (var day in daysOfFlight) {
                        if (day >= currentDay) {
                            closestDayOfFlight = day;
                            break;
                        }
                    }

                    TimeSpan timeToClosestFlight = timeToFirstFlight + TimeSpan.FromDays((int)closestDayOfFlight - (int)currentDay);

                    if (timeToClosestFlight < closestFlightTime) {
                        closestFlightTime = timeToClosestFlight;
                        closestFlight = flight;
                    }                   
                }
            }

            return closestFlight;
        }   


        public void BookTickets(string flightNumber, int tickets) {
            Flight flight = flights.Find(f => f.FlightNumber == flightNumber);

            if (flight != null) {
                if (flight.AvailableSeats >= tickets) {
                    flight.AvailableSeats -= tickets;
                    this.SaveToFile();
                    return;
                }
            }

            throw new Exception("Недостатньо вільних місць");
        }

        public int IndexOf(Flight flight) {
            return flights.IndexOf(flight);
        }

        public void SaveToFile() {
            string json = JsonConvert.SerializeObject(flights);
            fileHandler.WriteToFile(json);
        }

        public void LoadFromFile() {
            if (fileHandler.FileExists()) {
                string json = fileHandler.ReadFromFile();
                flights = JsonConvert.DeserializeObject<List<Flight>>(json);
            }
        }
        public Flight this[int index] {
            get { return flights[index]; }
            set { flights[index] = value; }
        }

        public MainForm MainForm {
            get => default;
            set { }
        }

        public FileHandler FileHandler {
            get => default;
            set { }
        }
    }
}
