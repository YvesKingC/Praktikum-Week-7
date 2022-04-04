namespace Praktikum_Week_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnKonversi_Click(object sender, EventArgs e)
        {
            int[] input = new int[txtBoxKalimatInput.TextLength];
            string[] input2 = new string[txtBoxKalimatInput.TextLength];
            string kalimat = txtBoxKalimatInput.Text;
            string hasilUbah = "";
            char huruf = Convert.ToChar(txtBoxHuruf1.Text);
            char ubah = Convert.ToChar(txtBoxHuruf2.Text);
            int indexHuruf = char.ToUpper(huruf);
            int indexUbah = char.ToUpper(ubah);
            int tambahIndex = 0;
            if (indexHuruf < indexUbah)
            {
                tambahIndex = indexUbah - indexHuruf;
            }
            else
            {
                tambahIndex = indexUbah - indexHuruf;
            }
            for (int i = 0; i < kalimat.Length; i++)
            {
                int j = Convert.ToInt32(kalimat[i]);
                input[i] = j+(tambahIndex);
                if ((j + tambahIndex) >= 27)
                {
                    input[i] = j + (tambahIndex);
                }
                else
                {
                    input[i] = j + (tambahIndex - 26);
                }
                input2[i] += ((char)input[i]).ToString();
                hasilUbah += input2[i];
            }
            lblHasil.Text = hasilUbah.ToUpper();
        }
    }
}