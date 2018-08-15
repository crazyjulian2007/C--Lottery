using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork5
{
    public partial class Form1 : Form
    {
        Random ranx = new Random(Guid.NewGuid().GetHashCode());
        Random rany = new Random(Guid.NewGuid().GetHashCode());
        List<int> lottoNum;
        List<int> tempLottoNum;
        List<int> tempNumArray;
        List<int> NumMessageList;
        List<int> compareNum;
        List<Button> myDButtonList;
        List<Button> chosedButton;
        Button myButton ;
        int choseNum = 12;
        string strNumMessage;
        bool ifShow = false;
        bool ifChose = false;
        System.Timers.Timer t = new System.Timers.Timer(2000); 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myDButtonList = new List<Button>();
            NumMessageList = new List<int>();
            chosedButton = new List<Button>(); 
            CreatButton(6, 4);
            lottoNum = new List<int>(Enumerable.Range(1, 24));
            tempLottoNum = new List<int>();
            tempNumArray = new List<int>();
            compareNum = new List<int>();

            timer1.Enabled = true;
            t.Elapsed += new System.Timers.ElapsedEventHandler(shine); 
            t.AutoReset = false;
            t.SynchronizingObject = this;
        }

        void shine(object sender, System.Timers.ElapsedEventArgs e )
        {
            try
            {
                if (NumMessageList.Count == choseNum)
                {
                    timer1.Stop();
                    lblFinalNumber.Text = "";
                    lblNumChosed.Text = "";
                    tempLottoNum = lottoNum.ToList();
                    Lotto(tempLottoNum);
                    CompareValue(tempLottoNum);
                }
                else
                {
                    //MessageBox.Show("Please select 12 Numbers");
                    Again();
                }
            }
            catch (Exception error)
            {
                //MessageBox.Show(error.ToString());
            }
        }

        void dButton_Click(object sender, EventArgs e)
        {
            try
            {
                myButton = (Button)sender;
                myButton.BackColor = Color.Red;

                if (ifChose == true)
                {
                    myButton.BackColor = Color.Pink;
                    ifChose = false;
                    for (int i = 0; i <= NumMessageList.Count; i++)
                    {
                        NumMessageList.Remove(Convert.ToInt32(myButton.Name));
                        chosedButton.Remove(myButton);
                    }
                }
                else
                {
                    ifChose = true;
                    myButton.BackColor = Color.Red;
                    NumMessageList.Add(Convert.ToInt32(myButton.Name));
                    chosedButton.Add(myButton);
                }
                
                if (NumMessageList.Count == choseNum)
                {
                    btStop();
                }
            }
            catch (Exception error)
            {
                //MessageBox.Show(error.ToString());
            }
        }

        void CreatButton(int intCount1, int intCount2)
        {
            int btName = 1;
            int btText = 1;
            for (int i = 0; i < intCount1; i++)
            {
                for (int j = 0; j < intCount2; j++)
                {
                    Button dButton = new Button();
                    dButton.BackColor = Color.Pink;
                    dButton.ForeColor = Color.Blue;
                    dButton.Text = btText++.ToString(); 
                    dButton.Name = btName++.ToString();
                    dButton.Font = new Font("微軟正黑體", 16);
                    dButton.Size = new Size(60, 40);
                    dButton.Location = new Point(20 + 62 * j, 120 + 42 * i);
                    dButton.Click += new EventHandler(dButton_Click);
                    //dButton.Click -= new EventHandler(dButton_Click);

                    Controls.Add(dButton);
                    myDButtonList.Add(dButton);
                }
            }
        }

        void btStop() 
        {
            try
            {
                for (int i = 0; i < lottoNum.Count; i++)
                {
                    myDButtonList[i].Enabled = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        void btReStart() 
        {

            try
            {
                for (int i = 0; i < lottoNum.Count; i++)
                {
                    myDButtonList[i].Enabled = true;
                    myDButtonList[i].BackColor = Color.Pink;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            lblFinalNumber.Text = "";
            
            if (NumMessageList.Count == choseNum)
            {
                timer1.Start();

                t.Enabled = true;
                t.Start();

                if (ifShow == true)
                {
                    ifShow = false;
                }
                else
                {
                    ifShow = true;
                }
            }
            else
            {
                MessageBox.Show("Please select 12 Numbers");
                Again();
            }
        }

        void Lotto(List<int> myLottoNum)
        {
            int maxNum = 24;
            int randomNum = 0;
            string strMessage = "";
            
            try
            {
                //LottoNum = LottoNum.OrderBy(num=>ranx.Next()).ToList<int>();
                //Console.WriteLine(LottoNum[i].ToString()); random number won't repeat
                for (int i = 0; i < choseNum; i++)
                {
                    randomNum = ranx.Next(maxNum-=1);
                    myLottoNum.RemoveAt(randomNum);
                }
                myLottoNum.Sort();
                foreach (int item in myLottoNum)
                {
                    strMessage += item+"\n";
                }
                lblFinalNumber.Text = strMessage;
                btStart.Enabled = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void btAgain_Click(object sender, EventArgs e)
        {
            Again();
        }

        void Again()
        {
            btReStart();

            lblFinalNumber.Text = "";

            btStart.Enabled = true;

            tempNumArray.Clear();

            lblNumChosed.Text = "";

            NumMessageList.Clear();

            strNumMessage = "";

            ifShow = false;

            compareNum.Clear();

            chosedButton.Clear();
        }

        void CompareValue(List<int> myLottoNum)
        {
            try
            {
                NumMessageList.Sort();
                foreach (int item in NumMessageList)
                {
                    strNumMessage += item.ToString() + "\n";
                }
                lblNumChosed.Text = strNumMessage;

                if (NumMessageList.Count == choseNum)
                {
                    for (int i = 0; i < choseNum; i++)
                    {
                        for (int j = 0; j < choseNum; j++)
                        {
                            if (NumMessageList[i] == myLottoNum[j])
                            {
                                compareNum.Add(NumMessageList[i]);
                            }
                        }
                    }
                    for (int i = 0; i < myDButtonList.Count; i++)
                    {
                        for (int j = 0; j < myLottoNum.Count; j++)
                        {
                            if (myDButtonList[i].Name.ToString() == myLottoNum[j].ToString())
                            {
                                myDButtonList[i].BackColor = Color.MediumSlateBlue;
                            }
                        }
                    }
                    for (int i = 0; i < 12; i++)
                    {
                        chosedButton[i].BackColor = Color.Tomato;
                        for (int j = 0; j < compareNum.Count; j++)
                        {
                            if (chosedButton[i].Name.ToString() == compareNum[j].ToString())
                            {
                                chosedButton[i].BackColor = Color.Cyan;
                            }
                            
                        }
                    }
                    if ((compareNum.Count == 12) || (compareNum.Count == 0))
                    {
                        MessageBox.Show( compareNum.Count + " Numbers are qualified, You Win the First Prize, You Get NT$15,000,000. ");
                    }
                    else if ((compareNum.Count == 11) || (compareNum.Count == 1))
                    {
                        MessageBox.Show(compareNum.Count + " Numbers are qualified, You Win the Second Prize, You Get NT$100,000. ");
                    }
                    else if ((compareNum.Count == 10) || (compareNum.Count == 2))
                    {
                        MessageBox.Show(compareNum.Count + " Numbers are qualified, You Win the third Prize, You Get NT$500. ");
                    }
                    else if ((compareNum.Count == 9) || (compareNum.Count == 3))
                    {
                        MessageBox.Show(compareNum.Count + " Numbers are qualified, You Win the Forth Prize, You Get NT$100. ");
                    }
                    else
                    {
                        MessageBox.Show(compareNum.Count + " Numbers are qualified, Sorry, You Get Nothing. ");
                    }
                    
                    Again();
                }
                else
                {
                    MessageBox.Show("Please select 12 Numbers");
                    Again();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void btRule_Click(object sender, EventArgs e)
        {
            lblFinalNumber.Text = "";
            lblFinalNumber.Text = "雙贏彩是一種樂透型遊戲，您必須從01~24的號碼中任選12個號碼進行投注。" +
                "開獎時，開獎單位將隨機開出12個號碼，這一組號碼就是該期雙贏彩的中獎號碼。\n" +
                "頭獎:對中當期12個獎號或對中當期0個獎號。\n" +
                "二獎:對中當期任11個獎號或對中任1個獎號。\n" +
                "三獎:對中當期任10個獎號或對中任2個獎號。\n" +
                "四獎:對中當期任9個獎號或對中任3個獎號。";
        }

        private void btMoney_Click(object sender, EventArgs e)
        {
            string strFirstPrize = "頭獎 : $15,000,000";
            string strSecondPrize = "二獎 : $100,000";
            string strThirdPrize = "三獎 : $500";
            string strForthPrize = "四獎 : $100";
            string strMessage = "";

            lblNumChosed.Text = "";
            strMessage = string.Format("{0},\n{1},\n{2},\n{3}.",
                strFirstPrize,strSecondPrize,strThirdPrize,strForthPrize);
            lblNumChosed.Text = strMessage;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int randomNumx = ranx.Next(24);
            int randomNumy = rany.Next(24);
            string strMessage = "";

            try
            {
                if (ifShow == true)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        chosedButton[ranx.Next(12)].BackColor = Color.PowderBlue;
                        chosedButton[rany.Next(12)].BackColor = Color.Purple;
                    }
                    for (int i = 0; i < 12; i++)
                    {
                        strMessage += ranx.Next(1,24).ToString() + "\n";
                        lblNumChosed.Text = strMessage;
                        lblFinalNumber.Text = strMessage;
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            
        }
    }
}
