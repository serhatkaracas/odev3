namespace odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> Liste_AdSoyad = new List<string>();
        List<string> Liste_OgrenciNo = new List<string>();
        List<string> Liste_BolumAdi = new List<string>();
        int sayac = 0;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string deger = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
            //listBox1.Items.Add(deger);
            //comboBox1.Items.Add(deger);

            Liste_AdSoyad.Add(textBox1.Text);
            Liste_OgrenciNo.Add(textBox2.Text);
            Liste_BolumAdi.Add(textBox3.Text);
            sayac++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sayac; i++)
            {
                string deger = Liste_AdSoyad[i] + " " + Liste_OgrenciNo[i] + " " + Liste_BolumAdi[i];
                listBox1.Items.Add(deger);
                comboBox1.Items.Add(deger);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int sonuc = Liste_AdSoyad.Where a => a.Contains(textBox4.Text)).Count();
            MessageBox.Show(textBox4.Text +  + sonuc + " adet bulunmaktad�r");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}