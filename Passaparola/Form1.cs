using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "İleri";
            soruno++;
            textBox1.Text = "";
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Türkiye'nin başkenti?";
                BtnA.BackColor = Color.Yellow;
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Marmara bölgesindeki yeşilliğiyle ünlü şehir?";
                BtnB.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                BtnC.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzu ile ünlü ilimiz?";
                BtnD.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                BtnE.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                BtnF.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                BtnG.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Yeryüzünün kağıda çizilmiş hali?";
                BtnH.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülü ile ünlü şehrimiz?";
                BtnI.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi?";
                Btnİ.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                BtnJ.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                BtnK.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "her yıl düzenlenen çicek festivali?";
                BtnL.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı?";
                BtnM.BackColor = Color.Yellow;

            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli müzik aleti?";
                BtnN.BackColor = Color.Yellow;

            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                BtnO.BackColor = Color.Yellow;

            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Fransanın başkenti";
                BtnP.BackColor = Color.Yellow;

            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Çayı ile ünlü şehrimiz?";
                BtnR.BackColor = Color.Yellow;

            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                BtnS.BackColor = Color.Yellow;

            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Of isimli ilçesi olan şehir?";
                BtnT.BackColor = Color.Yellow;

            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Hatırlamak kelimesinin zıt anlamlısı?";
                BtnU.BackColor = Color.Yellow;

            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Türkiyenin en büyük gölü?";
                BtnV.BackColor = Color.Yellow;

            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Bugünden sonraki gün?";
                BtnY.BackColor = Color.Yellow;

            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Egenin incisi?";
                BtnZ.BackColor = Color.Yellow;

            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    //cevap1
                    case 1:
                        if (textBox1.Text == "ankara")
                        {
                            BtnA.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnA.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;


                    //cevap2
                    case 2:
                        if (textBox1.Text == "Bursa")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;

                    //cevap3
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;

                    //cevap4
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    //cevap5
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;

                    //cevap6
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;

                    //cevap7
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;


                    //cevap8
                    case 8:
                        if (textBox1.Text == "harita")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;


                    //cevap9
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;


                    //cevap10
                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;


                    //cevap11
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;


                    //cevap12
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;


                    //cevap13
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                            break;

                    //cevap14
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;

                    //cevap15
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;


                    //cevap16
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;


                    //cevap17
                    case 17:
                        if (textBox1.Text == "paris")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;


                    //cevap18
                    case 18:
                        if (textBox1.Text == "rize")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;


                    //cevap19
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;



                    //cevap20
                    case 20:
                        if (textBox1.Text == "trabzon")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;


                    //cevap21
                    case 21:
                        if (textBox1.Text == "unutmak")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;


                    //cevap22
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;


                    //cevap23
                    case 23:
                        if (textBox1.Text == "yarın")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;


                    //cevap24
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;



                }
            }

        }

    }
}
