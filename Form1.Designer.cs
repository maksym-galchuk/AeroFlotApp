namespace AeroFlotApp;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dataGridViewFlights = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
        buttonFindClosestFlight = new Button();
        buttonBookTickets = new Button();
        textBoxDestination = new TextBox();
        textBoxTickets = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dataGridViewFlights).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewFlights
        // 
        dataGridViewFlights.AllowUserToAddRows = false;
        dataGridViewFlights.AllowUserToDeleteRows = false;
        dataGridViewFlights.AllowUserToResizeColumns = false;
        dataGridViewFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridViewFlights.BackgroundColor = SystemColors.Control;
        dataGridViewFlights.BorderStyle = BorderStyle.None;
        dataGridViewFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewFlights.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
        dataGridViewFlights.GridColor = SystemColors.Menu;
        dataGridViewFlights.Location = new Point(16, 18);
        dataGridViewFlights.Margin = new Padding(4, 5, 4, 5);
        dataGridViewFlights.MultiSelect = false;
        dataGridViewFlights.Name = "dataGridViewFlights";
        dataGridViewFlights.ReadOnly = true;
        dataGridViewFlights.RowHeadersVisible = false;
        dataGridViewFlights.RowHeadersWidth = 51;
        dataGridViewFlights.ScrollBars = ScrollBars.Vertical;
        dataGridViewFlights.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewFlights.Size = new Size(1067, 366);
        dataGridViewFlights.TabIndex = 0;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.HeaderText = "Номер";
        dataGridViewTextBoxColumn1.MinimumWidth = 6;
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Width = 86;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.HeaderText = "Маршрут";
        dataGridViewTextBoxColumn2.MinimumWidth = 6;
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.ReadOnly = true;
        dataGridViewTextBoxColumn2.Width = 102;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.HeaderText = "Проміжні Пункти";
        dataGridViewTextBoxColumn3.MinimumWidth = 6;
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.ReadOnly = true;
        dataGridViewTextBoxColumn3.Width = 146;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.HeaderText = "Час Відправлення";
        dataGridViewTextBoxColumn4.MinimumWidth = 6;
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.ReadOnly = true;
        dataGridViewTextBoxColumn4.Width = 150;
        // 
        // dataGridViewTextBoxColumn5
        // 
        dataGridViewTextBoxColumn5.HeaderText = "Дні Польоту";
        dataGridViewTextBoxColumn5.MinimumWidth = 6;
        dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        dataGridViewTextBoxColumn5.ReadOnly = true;
        dataGridViewTextBoxColumn5.Width = 113;
        // 
        // dataGridViewTextBoxColumn6
        // 
        dataGridViewTextBoxColumn6.HeaderText = "Вільні Місця";
        dataGridViewTextBoxColumn6.MinimumWidth = 6;
        dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
        dataGridViewTextBoxColumn6.ReadOnly = true;
        dataGridViewTextBoxColumn6.Width = 115;
        // 
        // buttonFindClosestFlight
        // 
        buttonFindClosestFlight.Location = new Point(13, 468);
        buttonFindClosestFlight.Margin = new Padding(4, 5, 4, 5);
        buttonFindClosestFlight.Name = "buttonFindClosestFlight";
        buttonFindClosestFlight.Size = new Size(213, 46);
        buttonFindClosestFlight.TabIndex = 1;
        buttonFindClosestFlight.Text = "Знайти найближчий рейс";
        buttonFindClosestFlight.UseVisualStyleBackColor = true;
        buttonFindClosestFlight.Click += buttonFindClosestFlight_Click;
        // 
        // buttonBookTickets
        // 
        buttonBookTickets.Location = new Point(234, 468);
        buttonBookTickets.Margin = new Padding(4, 5, 4, 5);
        buttonBookTickets.Name = "buttonBookTickets";
        buttonBookTickets.Size = new Size(200, 46);
        buttonBookTickets.TabIndex = 2;
        buttonBookTickets.Text = "Оформити квитки";
        buttonBookTickets.UseVisualStyleBackColor = true;
        buttonBookTickets.Click += buttonBookTickets_Click;
        // 
        // textBoxDestination
        // 
        textBoxDestination.Location = new Point(13, 431);
        textBoxDestination.Margin = new Padding(4, 5, 4, 5);
        textBoxDestination.Name = "textBoxDestination";
        textBoxDestination.Size = new Size(213, 27);
        textBoxDestination.TabIndex = 3;
        textBoxDestination.Text = "Місце призначення";
        // 
        // textBoxTickets
        // 
        textBoxTickets.Location = new Point(291, 431);
        textBoxTickets.Margin = new Padding(4, 5, 4, 5);
        textBoxTickets.Name = "textBoxTickets";
        textBoxTickets.Size = new Size(79, 27);
        textBoxTickets.TabIndex = 4;
        textBoxTickets.Text = "1";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1096, 595);
        Controls.Add(textBoxTickets);
        Controls.Add(textBoxDestination);
        Controls.Add(buttonBookTickets);
        Controls.Add(buttonFindClosestFlight);
        Controls.Add(dataGridViewFlights);
        Margin = new Padding(4, 5, 4, 5);
        Name = "MainForm";
        Text = "Каса аерофлоту";
        ((System.ComponentModel.ISupportInitialize)dataGridViewFlights).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridViewFlights;
    private Button buttonFindClosestFlight;
    private Button buttonBookTickets;
    private TextBox textBoxDestination;
    private TextBox textBoxTickets;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
}
