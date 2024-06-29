namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public int[] nums = new int[10000];
        public Random rnd = new Random();
        private int max = 0;
        private int min = 0;
        private double mean = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            max = Logic.maxNum(nums);
            listBox2.Items.Add("Max num: " + max);

            min = Logic.minNum(nums);
            listBox2.Items.Add("Min num: " + min);

            mean = Logic.meanNum(nums);
            listBox2.Items.Add("Mean num: " + mean);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CountingResults countingResults = new CountingResults();

            countingResults.maxNumber = max;
            countingResults.minNumber = min;
            countingResults.meanNumber = mean;

            Logic.writeFile(countingResults);

            MessageBox.Show("File has been written");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Logic.generateNums(nums, rnd, listBox1);
        }
    }
}
