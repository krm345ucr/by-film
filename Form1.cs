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
                label2.Text = "1)MUC�ZE";
                label3.Text = "2)7. KO�U�TAK� MUC�ZE";
                label4.Text = "3)KEFERNAHUM";
                label5.Text = "4)NA�M";
                label6.Text = "5)GAR�P B�LB�L NE�ET ERTA�";
                label7.Text = "6)BERGEN";
                label8.Text = "7)AYLA";
                label9.Text = "8)G�NE�� G�RD�M";

            }
            else if(radioButton2.Checked)
            {
                label2.Text = "1)KARLAR �LKES�";
                label3.Text = "2)BUZDEVR�";
                label4.Text = "3)EJDERHANI NASIL E��T�RS�N";
                label5.Text = "4)�ILGIN HIRSIZLAR";
                label6.Text = "5)ALV�N VE S�NCAPLAR";
                label7.Text = "6)LUKA";
                label8.Text = "7)��ZMEL� KED�";
                label9.Text = "8)MADAGASKAR";

            }
            else if (radioButton3.Checked)
            {
                label2.Text = "1)Y�Z�KLER�N EFEND�S�";
                label3.Text = "2)BATMAN";
                label4.Text = "3)KABADAYI";
                label5.Text = "4)HOBB�T";
                label6.Text = "5)LUCY";
                label7.Text = "6)KARAY�P KORSANLARI";
                label8.Text = "7)MATR�S";
                label9.Text = "8)THE �LLUS�ON�ST";


            }
            else if (radioButton4.Checked)
            {
                label2.Text = "1)LUCY";
                label3.Text = "2)PREST�J";
                label4.Text = "3)MARSLI";
                label5.Text = "4)UZAY YOLCULARI";
                label6.Text = "5)UYUMSUZ";
                label7.Text = "6)A�LIK OYUNLARI";
                label8.Text = "7)�ND�ANA JOHNES";
                label9.Text = "8)VENOM";

            }
            else if (radioButton5.Checked)
            {
                label2.Text = "1)A�LE ARASINDA";
                label3.Text = "2)�AKALLARLA DANS";
                label4.Text = "3)KOLPA��NO";
                label5.Text = "4)E�K� ELMALAR";
                label6.Text = "5)AYKUT EN��TE";
                label7.Text = "6)H�K�MET KADIN";
                label8.Text = "7)ORGAN�ZE ��LER";
                label9.Text = "8)MASKEL� BE�LER";

            }
            else
            {
                label10.Text = "L�TFEN T�R SE��N�Z";
            }
        }
    }
}
