using System;
using System.IO;
using System.Windows.Forms;

namespace applicants_information
{
    public partial class Form1 : Form
    {
        // Counter to keep track of participants
        private int participantsCounter = 1;

        // Form constructor
        public Form1()
        {
            InitializeComponent();

            // Load the participant counter value from a file
            participantsCounter = LoadCounterValue();
        }

        // Event handler for the "Add Participants" button click
        private void AddParticipantsButton_Click(object sender, EventArgs e)
        {
            // Check if any of the required fields is empty
            if (string.IsNullOrWhiteSpace(NameTB.Text) ||
                string.IsNullOrWhiteSpace(StudentNumberTB.Text) ||
                string.IsNullOrWhiteSpace(GenderCB.Text) ||
                string.IsNullOrWhiteSpace(MajorTB.Text) ||
                string.IsNullOrWhiteSpace(LevelCB.Text) ||
                string.IsNullOrWhiteSpace(WhatsAppNumberTB.Text))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            // Validate that StudentNumberTB contains only numeric values
            if (!IsNumeric(StudentNumberTB.Text))
            {
                MessageBox.Show("Student Number must contain only numeric values.");
                return;
            }

            // Validate that WhatsAppNumberTB contains only numeric values
            if (!IsNumeric(WhatsAppNumberTB.Text))
            {
                MessageBox.Show("WhatsApp Number must contain only numeric values.");
                return;
            }

            // Generate a participant ID and display it
            SequentialNumberLabel.Text = GenerateParticipantsId();

            // Write participant information to a file
            string desktopPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "applicants information");
            Directory.CreateDirectory(desktopPath); // Create directory if it doesn't exist
            string filePath = Path.Combine(desktopPath, "Participants.txt");

            using (StreamWriter sw = new StreamWriter(filePath, true))

            {
                sw.WriteLine(SequentialNumberLabel.Text);
                sw.WriteLine(NameLabel.Text + " : " + NameTB.Text);
                sw.WriteLine(StudentNumberLabel.Text + " : " + StudentNumberTB.Text);
                sw.WriteLine(GenderLabel.Text + " : " + GenderCB.Text);
                sw.WriteLine(MajorLabel.Text + " : " + MajorTB.Text);
                sw.WriteLine(LevelLabel.Text + " : " + LevelCB.Text);
                sw.WriteLine(WhatsAppNumberLabel.Text + " : " + WhatsAppNumberCB.Text + WhatsAppNumberTB.Text);
                sw.WriteLine("-----------------------------------------------------------------------");
            }

            // Increment the participant counter
            participantsCounter++;



            // Save the updated counter value to a file
            SaveCounterValue(participantsCounter);
        }

        // Generate a participant ID based on the counter value
        private string GenerateParticipantsId()
        {
            return $"#{participantsCounter}";
        }

        // Event handler for the "Clear" button click
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear the input fields
            NameTB.Text = string.Empty;
            StudentNumberTB.Text = string.Empty;
            GenderCB.Text = string.Empty;
            MajorTB.Text = string.Empty;
            LevelCB.Text = string.Empty;
            WhatsAppNumberTB.Text = string.Empty;
        }

        // Event handler for the key press in the StudentNumberTB field
        private void StudentNumberTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input and the backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        // Check if a given string is numeric
        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        // Save the participant counter value to a file
        private void SaveCounterValue(int counterValue)
        {
            File.WriteAllText("CounterValue.txt", counterValue.ToString());
        }

        // Load the participant counter value from a file
        private int LoadCounterValue()
        {
            if (File.Exists("CounterValue.txt"))
            {
                string counterValueString = File.ReadAllText("CounterValue.txt");
                if (int.TryParse(counterValueString, out int counterValue))
                {
                    return counterValue;
                }
            }

            // If the file doesn't exist or an error occurs, return a default value
            return 1;
        }
    }
}
