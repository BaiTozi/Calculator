namespace Calculator2
{
    public partial class Form1 : Form
    {
        private List<double> operands = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string inputText = txtEnterNumber.Text;
            List<double> numbers = ParseNumbers(inputText);

            if (numbers.Count == 0)
            {
                MessageBox.Show("Please enter valid numbers separated by commas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double average = CalculateAverage(numbers);
            double median = CalculateMedian(numbers);
            double mode = CalculateMode(numbers);

            txtAverage.Text = $"{average:F2}";
            txtMedian.Text = $"{median:F2}";
            txtMode.Text = $"{mode:F2}";
        }

        private List<double> ParseNumbers(string input)
        {
            return input.Split(',')
                        .Select(s => s.Trim())
                        .Where(s => !string.IsNullOrEmpty(s))
                        .Select(s =>
                        {
                            bool success = double.TryParse(s, out double result);
                            return new { success, result };
                        })
                        .Where(x => x.success)
                        .Select(x => x.result)
                        .ToList();
        }

        private double CalculateAverage(List<double> numbers)
        {
            return numbers.Count > 0 ? numbers.Average() : 0;
        }

        private double CalculateMedian(List<double> numbers)
        {
            if (numbers.Count == 0)
                return 0;

            numbers.Sort();
            int middle = numbers.Count / 2;

            if (numbers.Count % 2 == 0)
            {
                return (numbers[middle - 1] + numbers[middle]) / 2.0;
            }
            else
            {
                return numbers[middle];
            }
        }

        private double CalculateMode(List<double> numbers)
        {
            if (numbers.Count == 0)
                return 0;

            var groupedNumbers = numbers.GroupBy(n => n);
            var maxFrequency = groupedNumbers.Max(g => g.Count());

            return groupedNumbers.FirstOrDefault(g => g.Count() == maxFrequency)?.Key ?? 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEnterNumber.Clear();
            txtAverage.Text = string.Empty;
            txtMode.Text = string.Empty;
            txtMedian.Text = string.Empty;
        }
    }
}
