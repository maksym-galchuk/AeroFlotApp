namespace AeroFlotApp;

public partial class MainForm : Form {
    private FlightSchedule flights;

    public MainForm() {
        InitializeComponent();
        InitializeFlights();
        DisplayFlights();
        dataGridViewFlights.ClearSelection();
        this.AutoSize = true;
    }

    private void InitializeFlights() {
        flights = new FlightSchedule("flights.json");
        flights.LoadFromFile();

        if (flights.GetFlights().Count == 0) {
            FlightsGenerator flightsGenerator = new FlightsGenerator();
            flights.SetFlights(flightsGenerator.GenerateFlights(10));
            flights.SaveToFile();
        }
    }

    private void DisplayFlights() {
        dataGridViewFlights.Rows.Clear();

        foreach (var flight in flights.GetFlights()) {
            dataGridViewFlights.Rows.Add(
                flight.FlightNumber,
                flight.Route,
                flight.IntermediatePoints,
                flight.DepartureTime,
                flight.DaysOfFlightString,
                flight.AvailableSeats
            );
        }
    }

    private void buttonFindClosestFlight_Click(object sender, EventArgs e) {
        string destination = textBoxDestination.Text;

        Flight closestFlight = flights.FindClosestFlight(destination);

        if (closestFlight != null) {
            MessageBox.Show($"Найближчий рейс: {closestFlight.FlightNumber}, {closestFlight.Route}, {closestFlight.DepartureTime}");

            int rowIndex = flights.IndexOf(closestFlight);

            if (rowIndex >= 0) {
                dataGridViewFlights.ClearSelection();
                dataGridViewFlights.Rows[rowIndex].Selected = true;
                dataGridViewFlights.CurrentCell = dataGridViewFlights.Rows[rowIndex].Cells[0];
            }
        } else {
            MessageBox.Show("Немає вільних місць для вказаного пункту призначення.");
        }
    }



    private void buttonBookTickets_Click(object sender, EventArgs e) {
        int ticketsToBook;
        if (!int.TryParse(textBoxTickets.Text, out ticketsToBook) || ticketsToBook <= 0) {
            MessageBox.Show("Введіть коректну кількість квитків.");
            return;
        }

        int selectedRowIndex = dataGridViewFlights.CurrentCell.RowIndex;


        if (selectedRowIndex < 0 || selectedRowIndex >= flights.Count) {
            MessageBox.Show("Виберіть рейс зі списку.");
            return;
        }


        Flight selectedFlight = flights[selectedRowIndex];

        try {
            flights.BookTickets(selectedFlight.FlightNumber, ticketsToBook);
        } catch (Exception ex) {
            MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }


        DisplayFlights();

        MessageBox.Show($"Квитки на рейс {selectedFlight.FlightNumber} оформлено успішно.");

        textBoxTickets.Text = string.Empty;

        dataGridViewFlights.ClearSelection();
        dataGridViewFlights.Rows[selectedRowIndex].Selected = true;
        dataGridViewFlights.CurrentCell = dataGridViewFlights.Rows[selectedRowIndex].Cells[0];

    }
}




