using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.CodeDom.Compiler;
using System.Reflection;
using Microsoft.VisualBasic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WindowsFormsApplication1
{


    public partial class Form1 : Form
    {
        private double inputNum1;
        private double inputNum2;
        public string[] numArray = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public Form1()
        {
            InitializeComponent();
        }
       
        //button click
        private void numberInput(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string numberInputFromButten = clickedButton.Text;
            addToLable(numberInputFromButten);
        }  //button0~9

        private void operatorInput(object sender, EventArgs e)
        {
            
            if (countOutPut.Text.EndsWith("+") || countOutPut.Text.EndsWith("-") || countOutPut.Text.EndsWith("*") || countOutPut.Text.EndsWith("/") || countOutPut.Text.EndsWith("."))
            {
                //if== +-*/.
                countOutPut.Text = countOutPut.Text.Substring(0, countOutPut.Text.Length - 1);// 將最後一個符號刪除
            }
            else
            {
                cutAndCounting();
            }
            Button clickedButton = (Button)sender;
            string operatorInputFromButton = clickedButton.Text;
            addToLable(operatorInputFromButton);
        } //button +-*/

        private void addPoint(object sender, EventArgs e)
        {
            if(countOutPut.Text == "0")
            {
                addToLable("0.");
            }
            else  //尾碼為數字或point
            {   
                int sameAsAnyStringInArry = compareSameAsAnyStringInArry(numArray, findLastWordOfStr(countOutPut.Text));
                if (sameAsAnyStringInArry == 1)//如果尾碼是0~9
                {
                    string theLastNumStr = countOutPut.Text.Substring(findWhereLastOperator() + 1);//取得符號後的數字串
                    int ifPointExist = theLastNumStr.LastIndexOf("."); //-1表示最後數字串沒有小數點，則在下面if內可以再加入"."                                          
                    if (ifPointExist == -1)
                    {
                        addToLable(".");
                    }
                }
            }
        }  //button .

        private void countResultClick(object sender, EventArgs e)
        {
            string lastWordOfCountOutPut = findLastWordOfStr(countOutPut.Text);
            int sameAsAnyStringInArry = compareSameAsAnyStringInArry(numArray, lastWordOfCountOutPut);
            if (sameAsAnyStringInArry == 1)
            {
                cutAndCounting();
            }
        }  //button =

        private void clickAC(object sender, EventArgs e)
        {
            cleanAllParamaters();
        }  //button AC

        //called functions

        public void addToLable(string inputFromButton)
        {
            string getCountOutPut;

            if (countOutPut.Text != "0" )
            {
                getCountOutPut = countOutPut.Text + inputFromButton;
                countOutPut.Text = Convert.ToString(getCountOutPut);
            }
            else
            {
                switch (inputFromButton)
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                            break;
                    default:
                            countOutPut.Text = "";
                            break;
                }
                getCountOutPut = countOutPut.Text + inputFromButton;
                countOutPut.Text = Convert.ToString(getCountOutPut);
            }
        }  //將指定的數字或符號，輸入output.text      

        public int findWhereLastOperator()  //被呼叫，回傳end的最大值，尋找是否有符號混在label.text中，若無回傳theMaxOfEndOperator為-1
        {
            string testStr = countOutPut.Text;

            int plus_cutFromTestStr = Convert.ToInt32(testStr.LastIndexOf("+").ToString());
            int minux_cutFromTestStr = Convert.ToInt32(testStr.LastIndexOf("-").ToString());
            int mutiply_cutFromTestStr = Convert.ToInt32(testStr.LastIndexOf("*").ToString());
            int division_cutFromTestStr = Convert.ToInt32(testStr.LastIndexOf("/").ToString());
            //找到最後一個符號
            int[] operatorPlaces = { plus_cutFromTestStr, minux_cutFromTestStr, division_cutFromTestStr, mutiply_cutFromTestStr };
            int theMaxOfEndOperator = operatorPlaces.Max();
            return theMaxOfEndOperator;
            
           
        }

        public void cutAndCounting()
        {
            int cutByOperator = findWhereLastOperator();

            if (cutByOperator != -1) //擁有可以切割前後兩數字的運算符號
            {
                inputNum2 = Convert.ToDouble( countOutPut.Text.Substring(cutByOperator + 1));//取得符號後的數字串
               
                string operatorBetween = countOutPut.Text.Substring(cutByOperator, 1);
                inputNum1 = counting(operatorBetween);
                
                countOutPut.Text = Convert.ToString(inputNum1);
            }
            else
                inputNum1 = Convert.ToDouble(countOutPut.Text);

        }  //切割出inputNum2後，呼叫counting()計算

        public double counting(string operatorBetween)      //計算 
        {
            double theFirstNumToCount=inputNum1;
            double theSecondNumToCount = inputNum2;
            switch (operatorBetween)
            {
                case "+":
                    theFirstNumToCount = theFirstNumToCount + theSecondNumToCount;
                    break;
                case "-":
                    theFirstNumToCount = theFirstNumToCount - theSecondNumToCount;
                    break;
                case "*":
                    theFirstNumToCount = theFirstNumToCount * theSecondNumToCount;
                    break;
                case "/":
                    theFirstNumToCount = theFirstNumToCount / theSecondNumToCount;
                    break;
            }

            return theFirstNumToCount;
        }
        public int compareSameAsAnyStringInArry(string[] inputArray, string theWordtoCompare)
        {
            int isSameOrNot = -1;
            foreach (string eachWord in inputArray)
            {
                if (eachWord == theWordtoCompare)
                {
                    isSameOrNot = 1;
                    break;
                }
            }
            return isSameOrNot;
        }  //compare給定的string值，是否同於指定的陣列中任一值，回傳 1 表示有相同

        public string findLastWordOfStr(string StrBeFoundLastWord)
        {
            string theWord = StrBeFoundLastWord.Substring(StrBeFoundLastWord.Length - 1, 1);

            return theWord;
        }  //回傳指定字串中最後一個字

        public void cleanAllParamaters()
        {
            countOutPut.Text = "0";
            inputNum1 = 0;
            inputNum2 = 0;
        }  //清理

    }
  
}
