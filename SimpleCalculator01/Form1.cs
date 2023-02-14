namespace SimpleCalculator01
{

    public partial class Form1 : Form
    {
        public static int num1;
        public static int num2;
        public Form1()
        {
            InitializeComponent();
            button1.Click+= new System.EventHandler(converter);
            button2.Click+= new System.EventHandler(converter);
        }



        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                label1.Text = (num1 + num2).ToString();
            }
            catch (Exception ex)
            {


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
       
                label1.Text = (num1 - num2).ToString();

            }catch (Exception ex) {
            
                Console.WriteLine(ex.ToString());
            }

        }

        private void converter(object sender , EventArgs e)
        {
            try
            {
                num1 = Convert.ToInt32((textBox1.Text).ToString());
                num2 = Convert.ToInt32((textBox2.Text).ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       
        }
    }
}