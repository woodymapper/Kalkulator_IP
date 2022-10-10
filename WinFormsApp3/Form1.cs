namespace WinFormsApp3
{
    public partial class Form1 : Form
    {

        bool spr(int a)
        {


            return true;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void liczenia_Click(object sender, EventArgs e)
        {
            string ip1 = textBox1.Text;
            string ip2 = textBox2.Text;
            string ip3 = textBox3.Text;
            string ip4 = textBox4.Text;


            int chuj = int.Parse(ip1);
            int chuj2 = int.Parse(ip2);
            int chuj3 = int.Parse(ip3);
            int chuj4 = int.Parse(ip4);

            label3.Text = ip1;
            label4.Text = ip2;
            label5.Text = ip3;
            label6.Text = ip4;

            
            //spr
            if(chuj < 0 || chuj > 255) {
                label8.Text = "N I E";
            }
            else if (chuj2 < 0 || chuj2 > 255)
            {
                label8.Text = "N I E";
            }
           else if (chuj3 < 0 || chuj3 > 255)
            {
                label8.Text = "N I E";
            }
           else if (chuj4 < 0 || chuj4 > 255)
            {
                label8.Text = "N I E";
            }
            else { label8.Text = "T A K"; }



            if (chuj >= 1 && chuj <= 126)
            {
                klasa.Text = "A";
            }
            else if (chuj >= 128 && chuj <= 191)
            {
                klasa.Text = "B";
            }
            else if (chuj >= 192 && chuj <= 223)
            {
                klasa.Text = "C";
            }
            else if (chuj >= 224 && chuj <= 239)
            {
                klasa.Text = "D";
            }
            else if (chuj >= 240 && chuj <= 255)
            {
                klasa.Text = "E";
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        //chuja
        //https://pastebin.com/iZpFSSaK





    }
}