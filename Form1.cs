namespace by_film
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Text = "1)MUCÝZE";
                label3.Text = "2)7. KOÐUÞTAKÝ MUCÝZE";
                label4.Text = "3)KEFERNAHUM";
                label5.Text = "4)NAÝM";
                label6.Text = "5)GARÝP BÜLBÜL NEÞET ERTAÞ";
                label7.Text = "6)BERGEN";
                label8.Text = "7)AYLA";
                label9.Text = "8)GÜNEÞÝ GÖRDÜM";

            }
            else if(radioButton2.Checked)
            {
                label2.Text = "1)KARLAR ÜLKESÝ";
                label3.Text = "2)BUZDEVRÝ";
                label4.Text = "3)EJDERHANI NASIL EÐÝTÝRSÝN";
                label5.Text = "4)ÇILGIN HIRSIZLAR";
                label6.Text = "5)ALVÝN VE SÝNCAPLAR";
                label7.Text = "6)LUKA";
                label8.Text = "7)ÇÝZMELÝ KEDÝ";
                label9.Text = "8)MADAGASKAR";

            }
            else if (radioButton3.Checked)
            {
                label2.Text = "1)YÜZÜKLERÝN EFENDÝSÝ";
                label3.Text = "2)BATMAN";
                label4.Text = "3)KABADAYI";
                label5.Text = "4)HOBBÝT";
                label6.Text = "5)LUCY";
                label7.Text = "6)KARAYÝP KORSANLARI";
                label8.Text = "7)MATRÝS";
                label9.Text = "8)THE ÝLLUSÝONÝST";


            }
            else if (radioButton4.Checked)
            {
                label2.Text = "1)LUCY";
                label3.Text = "2)PRESTÝJ";
                label4.Text = "3)MARSLI";
                label5.Text = "4)UZAY YOLCULARI";
                label6.Text = "5)UYUMSUZ";
                label7.Text = "6)AÇLIK OYUNLARI";
                label8.Text = "7)ÝNDÝANA JOHNES";
                label9.Text = "8)VENOM";

            }
            else if (radioButton5.Checked)
            {
                label2.Text = "1)AÝLE ARASINDA";
                label3.Text = "2)ÇAKALLARLA DANS";
                label4.Text = "3)KOLPAÇÝNO";
                label5.Text = "4)EÞKÝ ELMALAR";
                label6.Text = "5)AYKUT ENÝÞTE";
                label7.Text = "6)HÜKÜMET KADIN";
                label8.Text = "7)ORGANÝZE ÝÞLER";
                label9.Text = "8)MASKELÝ BEÞLER";

            }
            else
            {
                label10.Text = "LÜTFEN TÜR SEÇÝNÝZ";
            }
        }
    }
}
