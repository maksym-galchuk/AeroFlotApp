using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroFlotApp {
    public class FlightsGenerator {
        public MainForm MainForm {
            get => default;
            set { }
        }

        public List<Flight> GenerateFlights(int numFlights) {
                List<Flight> flights = new List<Flight>();

                for (int i = 1; i <= numFlights; i++) {

                    DateTime date = DateTime.Now;
                    date = date.AddHours(new Random().Next(0, 24));
                    date = date.AddMinutes(-date.Minute);
                    date = date.AddMinutes(new Random().Next(0, 4) * 15);

                    flights.Add(
                        new Flight(
                            GenerateRandomFlightNumber(),
                            GenerateRandomRoute(),
                            GenerateRandomIntermediatePoints(),
                            date.ToString("HH:mm"),
                            GenerateRandomDaysOfFlight(),
                            new Random().Next(10, 25) * 10
                        )
                   );
                }

                return flights;
            }

            private string GenerateRandomFlightNumber() {
                Random random = new Random();
                char randomChar1 = (char)random.Next('A', 'Z' + 1);
                char randomChar2 = (char)random.Next('A', 'Z' + 1);

                int randomDigits = random.Next(100, 1000);

                string flightNumber = $"{randomChar1}{randomChar2}{randomDigits:D3}";

                return flightNumber;
            }

            private string GenerateRandomRoute() {
                List<string> cities = new List<string> { "Париж", "Лондон", "Нью-Йорк", "Дубай", "Токіо", "Сідней", "Берлін", "Пекін", "Стамбул" };
                Random random = new Random();
                string city1 = cities[random.Next(cities.Count)];
                cities.Remove(city1);
                string city2 = cities[random.Next(cities.Count)];

                return $"{city1} - {city2}";
            }

            private string GenerateRandomIntermediatePoints() {
                List<string> cities = new List<string> { "Мадрид", "Рим", "Каїр", "Афіни", "Сінгапур", "Торонто", "Мумбаї", "Лос Анджелес", "Ріо де Жанейро", "Сінгапур" };
                Random random = new Random();
                int numPoints = random.Next(1, 5); // Генерувати від 1 до 4 проміжних пунктів
                List<string> intermediatePoints = new List<string>();

                for (int i = 0; i < numPoints; i++) {
                    int index = random.Next(cities.Count);
                    intermediatePoints.Add(cities[index]);
                    cities.RemoveAt(index);
                }

                return string.Join(", ", intermediatePoints);
            }



            private DaysOfWeek[] GenerateRandomDaysOfFlight() {
                string[] daysOfWeek = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Нд" };
                Random random = new Random();
                int numDays = random.Next(1, 7); // Генерувати від 1 до 6 днів польоту
                List<DaysOfWeek> daysOfFlight = new List<DaysOfWeek>();

                for (int i = 0; i < numDays; i++) {
                    string day = daysOfWeek[random.Next(daysOfWeek.Length)];
                    DaysOfWeek dayOfWeek = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), day);
                    if (!daysOfFlight.Contains(dayOfWeek)) daysOfFlight.Add(dayOfWeek);
                    
                }
                daysOfFlight.Sort((day1, day2) => daysOfWeek.ToList().IndexOf(day1.ToString()).CompareTo(daysOfWeek.ToList().IndexOf(day2.ToString())));

                return daysOfFlight.ToArray();
            }
        }
    
}
