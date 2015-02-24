using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // Bellek'imiz
        private int[] M = new int[4096];

        // Register'larımız
        public static int MAR = 0;
        public static int PC = 0;
        public static int MBR = 0;
        public static int AC = 0;
        public static int IR = 0;
        public static int InREG = 0;
        public static int OutREG = 0;
         
        ListViewItem hex;                   // bellek listview'ı için 
        ListViewItem etiket1;               // etiket listView'ı için
        public static int org = 0;          // ORG komutundan sonra yazılan hex sayıyı dec olarak tutar ORG yoksa değeri 0'dır
        public static int adresSayici = 0;  // adresSayici etiket ve hexadecimal kod oluşturmak için PC yerine kulanıldı

        // bellek içeriklerini M dizisinin elemanlarıyla doldur.
        public void degerleriGuncelle(ListViewItem item, int[] dizi, int baslangic, int bitis)
        {
            for (int a = baslangic; a <= bitis; a++)
            {
                bellek_listView.Items[a].SubItems[1].Text = dizi[a].ToString("X4");
            }
        }

        

        // Tüm register değerlerini labellarına ata.
        public void registerlariGuncelle()
        {
            registerlariGuncelle12bit(marDeger_label, MAR);
            registerlariGuncelle12bit(pcDeger_label, PC);
            registerlariGuncelle16bit(acDeger_label, AC);
            registerlariGuncelle16bit(mbrDeger_label, MBR);
            registerlariGuncelle16bit(irDeger_label, IR);
            registerlariGuncelle16bit(outRegDeger_label, OutREG);
        }

        public void registerlariGuncelle12bit(Label lab, int content)
        {
            lab.Text = content.ToString("X3");
        }

        public void registerlariGuncelle16bit(Label lab, int content)
        {
            lab.Text = content.ToString("X4");
        }

        public void JnS(int X)
        {
            MBR = PC;
            MAR = X;
            M[MAR] = MBR;
            MBR = X;
            AC = 1;
            AC = AC + MBR;
            PC = AC;

        }
        public void Load(int X)
        {
            MAR = X;
            MBR = M[MAR];
            AC = MBR;
        }
        public void Store(int X)
        {
            MAR = X;
            MBR = AC;
            M[MAR] = MBR;
        }
        public void Add(int X)
        {
            MAR = X;
            MBR = M[MAR];
            AC = AC + MBR;
        }
        public void Subt(int X)
        {
            MAR = X;
            MBR = M[MAR];
            AC = AC - MBR;
        }
        public void Input()
        {        
            AC = InREG;
        }
        public void Output()
        {
            OutREG = AC;
        }

        public void Skipcond(string x)
        {
            if (x.Equals("000"))
            {
                if (AC < 0)
                    PC = PC + 1;
            }
            else if (x.Equals("400"))
            {
                if (AC == 0)
                    PC = PC + 1;
            }
            else if (x.Equals("800"))
            {
                if (AC > 0)
                    PC = PC + 1;
            }
        }
        public void Jump(int X)
        {
            // PC <- IR(0-11)
            string IR_hexString = IR.ToString("X4");
            PC = Convert.ToInt32(IR_hexString.Substring(1), 16);
        }
        public void Clear()
        {
            AC = 0;
        }
        public void AddI(int X)
        {
            MAR = X;
            MBR = M[MAR];
            MAR = MBR;
            MBR = M[MAR];
            AC = AC + MBR;
        }
        public void JumpI(int X)
        {
            MAR = X;
            MBR = M[MAR];
            PC = MBR;
        }
        public void StoreI(int X)
        {
            MAR = X;
            MBR = M[MAR];
            MAR = MBR;
            MBR = AC;
            M[MAR] = MBR;
        }
        public void LoadI(int X)
        {
            MAR = X;
            MBR = M[MAR];
            MAR = MBR;
            MBR = M[MAR];
            AC = MBR;
        }

        public Form1()
        {
            InitializeComponent();
            bellek_listView.Items.Clear();
            int hexadesimal;
            Random rnd = new Random();          // rastgele sayı üretmek için
          

            /* Belleği ilk başta oluştur */
            for (hexadesimal = 0x00; hexadesimal <= 0xfff; hexadesimal++)
            {
                hex = new ListViewItem(hexadesimal.ToString("X3"));
                hex.SubItems.Add(new ListViewItem.ListViewSubItem(hex, "0000"));
                bellek_listView.Items.Add(hex);
            }

            // Soru 1 için rastgele sayılar 210-22F adreslerşne yerleştirildi
            for (int a = 0x210; a <= 0x22F; a++)
            {
                bellek_listView.Items[a].SubItems[1].Text = rnd.Next(1, 5).ToString("X4");
                M[a] = Convert.ToInt32(bellek_listView.Items[a].SubItems[1].Text, 16);
            }

            // Soru 3 için rastgele sayılar atanıyor 350-0x36F
            int sayi;
            for (int a = 0x350; a <= 0x36F; a++)
            {
                sayi = rnd.Next(-5, 5);
                M[a] = sayi;

                if (sayi < 0)
                {
                    bellek_listView.Items[a].SubItems[1].Text = sayi.ToString("X4").Substring(4);
                }
                else
                {
                    bellek_listView.Items[a].SubItems[1].Text = sayi.ToString("X4");
                }
            }

            


            
        }

        // Temizle Butonu- herşeyi sıfırla
        private void button1_Click(object sender, EventArgs e)
        {
            MAR = 0;
            PC = 0;
            MBR = 0;
            AC = 0;
            IR = 0;
            InREG = 0;
            OutREG = 0;
            adresSayici = 0;

            for (int i = 0; i < M.Length; i++)
            {
                M[i] = 0;
            }

            degerleriGuncelle(hex, M, 0x000, 0xfff);
            registerlariGuncelle();
            org = 0;

            for (int i = etiket_listView.Items.Count - 1; i >= 0; i--)
            {
                etiket_listView.Items[i].Remove();
            }

            richTextBox1.Clear();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void editor_richTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        public void etiketleriOlustur()
        {
            string program = richTextBox1.Text;
            string[] buyruklar = program.Split('\n');

            for (int i = 0; i < buyruklar.Length; i++)
            {
                buyruklar[i] = buyruklar[i].Trim();
                buyruklar[i] = buyruklar[i].ToUpper();

                if (buyruklar[i].Contains("ORG"))
                {
                    string[] parcalanmis = buyruklar[i].Substring(buyruklar[i].IndexOf(" ") + 1).Split(' ');
                    adresSayici += Convert.ToInt32(parcalanmis[0], 16);
                    PC = adresSayici;
                    org = PC;
                }
                else
                {
                    if (buyruklar[i].Contains(","))
                    {
                        string[] parcalanmis = buyruklar[i].Split(',');
                        parcalanmis[0] = parcalanmis[0].Trim();
                        parcalanmis[1] = parcalanmis[1].Trim();

                        etiket1 = new ListViewItem(parcalanmis[0]);
                        etiket1.SubItems.Add(new ListViewItem.ListViewSubItem(etiket1, adresSayici.ToString("X3")));
                        etiket_listView.Items.Add(etiket1);

                        if (parcalanmis[1].Contains("DEC"))
                        {
                            parcalanmis[1] = parcalanmis[1].Substring(parcalanmis[1].IndexOf("DEC") + 4);
                            M[adresSayici] = int.Parse(parcalanmis[1]);
                            bellek_listView.Items[adresSayici].SubItems[1].Text = M[adresSayici].ToString("X4");
                        }
                        else if (parcalanmis[1].Contains("HEX"))
                        {
                            parcalanmis[1] = parcalanmis[1].Substring(parcalanmis[1].IndexOf("HEX") + 4);
                            M[adresSayici] = Convert.ToInt32(parcalanmis[1], 16);
                            bellek_listView.Items[adresSayici].SubItems[1].Text = M[adresSayici].ToString("X4");
                        }
                       
                        
                    }
                    adresSayici++;

                }

            }
            adresSayici = PC;
        }

        private void programiYukle_button_Click(object sender, EventArgs e)
        {
            etiketleriOlustur();

            string program = richTextBox1.Text;
            string[] buyruklar = program.Split('\n');

            for (int i = 0; i < buyruklar.Length; i++)
            {
                buyruklar[i] = buyruklar[i].ToUpper();

                if (buyruklar[i].Contains(",") && !buyruklar[i].Contains("DEC") && !buyruklar[i].Contains("HEX"))
                {
                    string[] parcalanmis = buyruklar[i].Split(',');
                    parcalanmis[1] = parcalanmis[1].Trim();
                    buyruklar[i] = parcalanmis[1];
                }

                if (buyruklar[i].Contains("JNS"))
                {
                    string icerik = "0";
                    string[] parcalanmis = buyruklar[i].Substring(buyruklar[i].IndexOf(" ") + 1).Split(' ');

                    for (int j = 0; j < etiket_listView.Items.Count; j++)
                    {
                        if (etiket_listView.Items[j].SubItems[0].Text.Equals(parcalanmis[0]))
                        {
                            icerik += etiket_listView.Items[j].SubItems[1].Text;
                            break;
                        }
                    }

                    bellek_listView.Items[adresSayici].SubItems[1].Text = icerik;
                    M[adresSayici] = Convert.ToInt32(icerik, 16);
                }

                else if (buyruklar[i].Contains("ADDI"))
                {
                    string icerik = "B";
                    string[] parcalanmis = buyruklar[i].Substring(buyruklar[i].IndexOf(" ") + 1).Split(' ');

                    for (int j = 0; j < etiket_listView.Items.Count; j++)
                    {
                        if (etiket_listView.Items[j].SubItems[0].Text.Equals(parcalanmis[0]))
                        {
                            icerik += etiket_listView.Items[j].SubItems[1].Text;
                            break;
                        }
                    }

                    bellek_listView.Items[adresSayici].SubItems[1].Text = icerik;
                    M[adresSayici] = Convert.ToInt32(icerik, 16);
                }
                else if (buyruklar[i].Contains("JUMPI"))
                {
                    string icerik = "C";
                    string[] parcalanmis = buyruklar[i].Substring(buyruklar[i].IndexOf(" ") + 1).Split(' ');

                    for (int j = 0; j < etiket_listView.Items.Count; j++)
                    {
                        if (etiket_listView.Items[j].SubItems[0].Text.Equals(parcalanmis[0]))
                        {
                            icerik += etiket_listView.Items[j].SubItems[1].Text;
                            break;
                        }
                    }

                    bellek_listView.Items[adresSayici].SubItems[1].Text = icerik;
                    M[adresSayici] = Convert.ToInt32(icerik, 16);
                }
                else if (buyruklar[i].Contains("STOREI"))
                {
                    string icerik = "D";
                    string[] parcalanmis = buyruklar[i].Substring(buyruklar[i].IndexOf(" ") + 1).Split(' ');

                    for (int j = 0; j < etiket_listView.Items.Count; j++)
                    {
                        if (etiket_listView.Items[j].SubItems[0].Text.Equals(parcalanmis[0]))
                        {
                            icerik += etiket_listView.Items[j].SubItems[1].Text;
                            break;
                        }
                    }

                    bellek_listView.Items[adresSayici].SubItems[1].Text = icerik;
                    M[adresSayici] = Convert.ToInt32(icerik, 16);

                }
                else if (buyruklar[i].Contains("LOADI"))
                {
                    string icerik = "E";
                    string[] parcalanmis = buyruklar[i].Substring(buyruklar[i].IndexOf(" ") + 1).Split(' ');

                    for (int j = 0; j < etiket_listView.Items.Count; j++)
                    {
                        if (etiket_listView.Items[j].SubItems[0].Text.Equals(parcalanmis[0]))
                        {
                            icerik += etiket_listView.Items[j].SubItems[1].Text;
                            break;
                        }
                    }

                    bellek_listView.Items[adresSayici].SubItems[1].Text = icerik;
                    M[adresSayici] = Convert.ToInt32(icerik, 16);
                }

                else if (buyruklar[i].Contains("LOAD"))
                {
                    string icerik = "1";
                    string[] parcalanmis = buyruklar[i].Substring(buyruklar[i].IndexOf(" ") + 1).Split(' ');

                    for (int j = 0; j < etiket_listView.Items.Count; j++)
                    {
                        if (etiket_listView.Items[j].SubItems[0].Text.Equals(parcalanmis[0]))
                        {
                            icerik += etiket_listView.Items[j].SubItems[1].Text;
                            break;
                        }
                    }

                    bellek_listView.Items[adresSayici].SubItems[1].Text = icerik;
                    M[adresSayici] = Convert.ToInt32(icerik, 16);

                }
                else if (buyruklar[i].Contains("STORE"))
                {
                    string icerik = "2";
                    string[] parcalanmis = buyruklar[i].Substring(buyruklar[i].IndexOf(" ") + 1).Split(' ');

                    for (int j = 0; j < etiket_listView.Items.Count; j++)
                    {
                        if (etiket_listView.Items[j].SubItems[0].Text.Equals(parcalanmis[0]))
                        {
                            icerik += etiket_listView.Items[j].SubItems[1].Text;
                            break;
                        }
                    }

                    bellek_listView.Items[adresSayici].SubItems[1].Text = icerik;
                    M[adresSayici] = Convert.ToInt32(icerik, 16);

                }
                else if (buyruklar[i].Contains("ADD"))
                {
                    string icerik = "3";
                    string[] parcalanmis = buyruklar[i].Substring(buyruklar[i].IndexOf(" ") + 1).Split(' ');

                    for (int j = 0; j < etiket_listView.Items.Count; j++)
                    {
                        if (etiket_listView.Items[j].SubItems[0].Text.Equals(parcalanmis[0]))
                        {
                            icerik += etiket_listView.Items[j].SubItems[1].Text;
                            break;
                        }
                    }

                    bellek_listView.Items[adresSayici].SubItems[1].Text = icerik;
                    M[adresSayici] = Convert.ToInt32(icerik, 16);
                }
                else if (buyruklar[i].Contains("SUBT"))
                {
                    string icerik = "4";
                    string[] parcalanmis = buyruklar[i].Substring(buyruklar[i].IndexOf(" ") + 1).Split(' ');

                    for (int j = 0; j < etiket_listView.Items.Count; j++)
                    {
                        if (etiket_listView.Items[j].SubItems[0].Text.Equals(parcalanmis[0]))
                        {
                            icerik += etiket_listView.Items[j].SubItems[1].Text;
                            break;
                        }
                    }

                    bellek_listView.Items[adresSayici].SubItems[1].Text = icerik;
                    M[adresSayici] = Convert.ToInt32(icerik, 16);
                }
                else if (buyruklar[i].Contains("INPUT"))
                {
                    bellek_listView.Items[adresSayici].SubItems[1].Text = "5000";
                    M[adresSayici] = Convert.ToInt32("5000", 16);

                    InREG = int.Parse(inRegDeger_textBox.Text);
                }
                else if (buyruklar[i].Contains("OUTPUT"))
                {

                    bellek_listView.Items[adresSayici].SubItems[1].Text = "6000";
                    M[adresSayici] = Convert.ToInt32("6000", 16);
                }
                else if (buyruklar[i].Contains("HALT"))
                {

                    bellek_listView.Items[adresSayici].SubItems[1].Text = "7000";
                    M[adresSayici] = Convert.ToInt32("7000", 16);
                }
                else if (buyruklar[i].Contains("SKIPCOND") || buyruklar[i].Contains("SKİPCOND"))
                {
                    string icerik = "8";
                    string[] parcalanmis = buyruklar[i].Substring(buyruklar[i].IndexOf(" ") + 1).Split(' ');
                    icerik += parcalanmis[0];
                    bellek_listView.Items[adresSayici].SubItems[1].Text = icerik;
                    M[adresSayici] = Convert.ToInt32(icerik, 16);
                }
                else if (buyruklar[i].Contains("JUMP"))
                {
                    string icerik = "9";
                    string[] parcalanmis = buyruklar[i].Substring(buyruklar[i].IndexOf(" ") + 1).Split(' ');

                    for (int j = 0; j < etiket_listView.Items.Count; j++)
                    {
                        if (etiket_listView.Items[j].SubItems[0].Text.Equals(parcalanmis[0]))
                        {
                            icerik += etiket_listView.Items[j].SubItems[1].Text;
                            break;
                        }
                    }

                    bellek_listView.Items[adresSayici].SubItems[1].Text = icerik;
                    M[adresSayici] = Convert.ToInt32(icerik, 16);
                }
                else if (buyruklar[i].Contains("CLEAR"))
                {
                    bellek_listView.Items[adresSayici].SubItems[1].Text = "A000";
                    M[adresSayici] = Convert.ToInt32("A000", 16);
                }

                else if (buyruklar[i].Contains("END"))
                {
                    break;
                }
                if (!buyruklar[i].Contains("ORG"))
                {
                    adresSayici++;
                }


            }

        }

        public string fetchAndDecode()
        {
            // Fetch
            MAR = PC;
            IR = M[MAR];
            PC = PC + 1;

            // Decode
            string IR_hexString = IR.ToString("X4");
            MAR = Convert.ToInt32(IR_hexString.Substring(1), 16);

            // Get Operand
            MBR = M[MAR];

            // opcode'u dönder hangi işlem olduğunu anlayabilmek için
            return IR_hexString.Substring(0, 1);
        }

        private void calistir_buton_Click(object sender, EventArgs e)
        {
            string islem;
            int i = 0;
            do
            {
                islem = fetchAndDecode();
                if (islem.Equals("0"))
                    JnS(MAR);
                else if (islem.Equals("1"))
                    Load(MAR);
                else if (islem.Equals("2"))
                    Store(MAR);
                else if (islem.Equals("3"))
                    Add(MAR);
                else if (islem.Equals("4"))
                    Subt(MAR);
                else if (islem.Equals("5"))
                    Input();
                else if (islem.Equals("6"))
                    Output();
                else if (islem.Equals("8"))
                    Skipcond(IR.ToString("X4").Substring(1));
                else if (islem.Equals("9"))
                    Jump(MAR);
                else if (islem.Equals("A"))
                    Clear();
                else if (islem.Equals("B"))
                    AddI(MAR);
                else if (islem.Equals("C"))
                    JumpI(MAR);
                else if (islem.Equals("D"))
                    StoreI(MAR);
                else if (islem.Equals("E"))
                    LoadI(MAR);

            }       // Halt olana kadar hex komutları oku.
            while (!IR.ToString("X4").Substring(0, 1).Equals("7"));

            degerleriGuncelle(hex, M, 0x000, 0xfff);
            registerlariGuncelle();
        }

    }
}