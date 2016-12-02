using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Home_Four
{
    
    public partial class Caculate : Form,MathMethodInterface
    {
        //添加一个堆栈
        Stack st = new Stack();
        bool previsnumber = false;
        bool nextisnumber = false;
        enum Hex { Hexadecimal, Decimal, Octal, Binary };//16,10,8,2进制
        enum Symbol{ADD,SUB,MUL,DIV,MOD,sin,cos,tan,ctan};//加，减，乘，除
        Symbol symbol;//运算符标识符
        Hex hex=Hex.Decimal;//进制标识符
        public Caculate()
        {
            InitializeComponent();
            this.text_show_caclute.Enabled = false;
        }
        /// <summary>
        /// 设置A-F按键的Enable属性
        /// </summary>
        /// <param name="flag">true|false</param>
        private void HideA_F(bool flag)
        {


            btn_16_A.Enabled = flag;
            btn_16_B.Enabled = flag;
            btn_16_C.Enabled = flag;
            btn_16_D.Enabled = flag;
            btn_16_E.Enabled = flag;
            btn_16_F.Enabled = flag;

        }
        /// <summary>
        /// 设置1-9按钮Enable属性
        /// </summary>
        /// <param name="flag">true|false</param>
        private void Hide1_9(bool flag)
        {
            btn_0.Enabled = flag;
            btn_1.Enabled = flag;
            btn_2.Enabled = flag;
            btn_3.Enabled = flag;
            btn_4.Enabled = flag;
            btn_5.Enabled = flag;
            btn_6.Enabled = flag;
            btn_7.Enabled = flag;
            btn_8.Enabled = flag;
            btn_9.Enabled = flag;
        }
        /// <summary>
        /// 控制选择各种进制的时候显示各种按钮的函数
        /// </summary>
        private void Show_btn()
        {
            //选择16进制
            if (radioButton1.Checked == true)
            {
                HideA_F(true);
                Hide1_9(true);

            }
            //选择10进制
            if (radioButton2.Checked == true)
            {
                //隐藏A—F
                HideA_F(false);
                Hide1_9(true);


            }
            //8进制
            if (radioButton3.Checked == true)
            {
                HideA_F(false);
                Hide1_9(true);
                btn_8.Enabled = false;
                btn_9.Enabled = false;

            }
            //2进制
            if (radioButton4.Checked == true)
            {
                HideA_F(false);
                Hide1_9(false);
                btn_0.Enabled = true;
                btn_1.Enabled = true;

            }
        }
        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public String ADD(double x,double y)
        {
            int result=Convert.ToInt32((x + y));
            try
            {
                switch (hex)
                {
                    case Hex.Hexadecimal: return Convert.ToString(result, 16); 
                    case Hex.Decimal: return (x + y).ToString();
                    case Hex.Octal: return Convert.ToString(result, 8);
                    case Hex.Binary: return Convert.ToString(result, 2);
                    default: return "出错";
                }
            }
            catch (Exception e)
            {
                return "出错";
            }
           
 
        }
        /// <summary>
        /// 减法
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public String SUB(double x,double y)
        {
            int result=Convert.ToInt32((x - y));
            try
            {
                switch (hex)
                {
                    case Hex.Hexadecimal: return Convert.ToString(result, 16);
                    case Hex.Decimal: return (x - y).ToString();
                    case Hex.Octal: return Convert.ToString(result, 8);
                    case Hex.Binary: return Convert.ToString(result, 2);
                    default: return "出错";
                }
            }
            catch (Exception e)
            {
                return "出错";
            }
        }
        /// <summary>
        /// 乘法
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public String MUL(double x, double y)
        {
            int result = Convert.ToInt32((x * y));
            try
            {
                switch (hex)
                {
                    case Hex.Hexadecimal: return Convert.ToString(result, 16);
                    case Hex.Decimal: return (x * y).ToString();
                    case Hex.Octal: return Convert.ToString(result, 8);
                    case Hex.Binary: return Convert.ToString(result, 2);
                    default: return "出错";
                }
            }
            catch (Exception e)
            {
                return "出错";
            }

        }
        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="x">被除数</param>
        /// <param name="y">除数</param>
        /// <returns></returns>
        public String DIV(double x, double y)
        {
            int result = Convert.ToInt32((x / y));
            try
            {
                switch (hex)
                {
                    case Hex.Hexadecimal: return Convert.ToString(result, 16);
                    case Hex.Decimal: return (x / y).ToString();
                    case Hex.Octal: return Convert.ToString(result, 8);
                    case Hex.Binary: return Convert.ToString(result, 2);
                    default: return "出错";
                }
            }
            catch (Exception e)
            {
                return "出错";
            }
        }
        /// <summary>
        /// 取绝对值
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public String ABS(double x)
        {
            return Math.Abs(x).ToString();
        }
        /// <summary>
        /// 求余
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public String MOD(double x,double y)
        {
            return (x % y).ToString();
        }
        /// <summary>
        /// 三角SIN函数
        /// </summary>
        /// <param name="x">度数</param>
        /// <returns></returns>
        public String SIN(double x)
        {
            return Math.Sin((x*Math.PI)/180).ToString();
        }
        /// <summary>
        /// 三角COS函数
        /// </summary>
        /// <param name="x">度数</param>
        /// <returns></returns>
        public String COS(double x)
        {
            return Math.Cos((x * Math.PI) / 180).ToString();
        }
        /// <summary>
        /// 三角TAN函数
        /// </summary>
        /// <param name="x">度数</param>
        /// <returns></returns>
        public String TAN(double x)
        {
            return Math.Tan((x * Math.PI) / 180).ToString();
        }
        /// <summary>
        /// COTTAN(1/TAN(x))
        /// </summary>
        /// <param name="x">度数</param>
        /// <returns></returns>
        public String CTAN(double x)
        {
            return (1 / Math.Tan((x * Math.PI) / 180)).ToString();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Show_btn();
            //16进制
            hex = Hex.Hexadecimal;
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Show_btn();
            //10进制
            hex = Hex.Decimal;
        }

 

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Show_btn();
            //二进制
            hex = Hex.Binary;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Show_btn();
            //8进制
            hex = Hex.Octal;
        }

        //绝对值转化
        private void btn_addsub_Click(object sender, EventArgs e)
        {
            double x;
            //如果在栈顶是+/-这个并且是text中的是数字
            if (double.TryParse(text_show_caclute.Text, out x) == true )
            {
                text_show_caclute.Text = (-x).ToString();
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            text_show_caclute.Text += 0;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            text_show_caclute.Text += 1;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            text_show_caclute.Text += 2;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            
            text_show_caclute.Text += 3;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            text_show_caclute.Text +=4;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            text_show_caclute.Text += 5;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            text_show_caclute.Text += 6;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            text_show_caclute.Text += 7;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            text_show_caclute.Text += 8;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
           
            text_show_caclute.Text += 9;
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            
            text_show_caclute.Text += '.';
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
           
            text_show_caclute.Text = "";

        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            text_show_caclute.Text = "";
            st.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (hex ==Hex.Decimal)
            {
                double x;
                if (double.TryParse(text_show_caclute.Text, out x) == true)
                {
                    previsnumber = true;
                    st.Push(x);
                    text_show_caclute.Text = "";
                }
                symbol = Symbol.ADD;
            }
            else
            {
                String x;
                x=text_show_caclute.Text;
                previsnumber = true;
                st.Push(x);
                text_show_caclute.Text = "";
                symbol = Symbol.ADD;
                
 
            }
            
        }
        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (hex == Hex.Decimal)
            {
                double x;
                if (double.TryParse(text_show_caclute.Text, out x) == true)
                {
                    previsnumber = true;
                    st.Push(x);
                    text_show_caclute.Text = "";

                }
                symbol = Symbol.SUB;

            }
            else
            {
                String x;
                x = text_show_caclute.Text;
                previsnumber = true;
                st.Push(x);
                text_show_caclute.Text = "";
                symbol = Symbol.SUB;


            }
        }
        private void btn_mul_Click(object sender, EventArgs e)
        {
            if (hex == Hex.Decimal)
            {
                double x;
                if (double.TryParse(text_show_caclute.Text, out x) == true)
                {
                    previsnumber = true;
                    st.Push(x);
                    text_show_caclute.Text = "";

                }
                symbol = Symbol.MUL;
            }
            else
            {
                String x;
                x = text_show_caclute.Text;
                previsnumber = true;
                st.Push(x);
                text_show_caclute.Text = "";
                symbol = Symbol.MUL;


            }
        }
        private void btn_div_Click(object sender, EventArgs e)
        {
            if (hex == Hex.Decimal)
            {
                double x;
                if (double.TryParse(text_show_caclute.Text, out x) == true)
                {
                    previsnumber = true;
                    st.Push(x);
                    text_show_caclute.Text = "";

                }
                symbol = Symbol.DIV;

            }
            else
            {
                String x;
                x = text_show_caclute.Text;
                previsnumber = true;
                st.Push(x);
                text_show_caclute.Text = "";
                symbol = Symbol.DIV;


            }
        }
        private void btn_mod_Click(object sender, EventArgs e)
        {

            if (hex == Hex.Decimal)
            {
                double x;
                if (double.TryParse(text_show_caclute.Text, out x) == true)
                {
                    
                    previsnumber = true;
                    st.Push(x);
                    text_show_caclute.Text = "";
                    symbol = Symbol.MOD;
                }
            }
            else
            {
                String x;
                x = text_show_caclute.Text;
                previsnumber = true;
                st.Push(x);
                text_show_caclute.Text = "";
                symbol = Symbol.MOD;


            }
            

        }

        private bool isnumber(double x)
        {
            //如果堆栈不为空才能出栈
            if (st.Count != 0)
            {
                if (double.TryParse(st.Peek().ToString(), out x) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

 
        }

        private void btn_eq_Click(object sender, EventArgs e)
        {
            try
            {
                if (hex == Hex.Decimal)//判断是否为10进制
                {
                    if (previsnumber && isnumber(Convert.ToDouble(text_show_caclute.Text)))
                    {

                        switch (symbol)
                        {
                            case Symbol.ADD: text_show_caclute.Text = ADD((double)st.Peek(), Convert.ToDouble(text_show_caclute.Text)); break;
                            case Symbol.SUB: text_show_caclute.Text = SUB((double)st.Peek(), Convert.ToDouble(text_show_caclute.Text)); break;
                            case Symbol.MUL: text_show_caclute.Text = MUL((double)st.Peek(), Convert.ToDouble(text_show_caclute.Text)); break;
                            case Symbol.DIV: text_show_caclute.Text = DIV((double)st.Peek(), Convert.ToDouble(text_show_caclute.Text)); break;
                            case Symbol.MOD: text_show_caclute.Text = MOD((double)st.Peek(), Convert.ToDouble(text_show_caclute.Text)); break;
                        }

                    }
                }
                else if (hex == Hex.Hexadecimal)//16进制
                {
                    switch (symbol)
                    {
                            //输入参数16进制
                        case Symbol.ADD: text_show_caclute.Text = ADD(Convert.ToInt32(st.Peek().ToString(),16),Convert.ToInt32(text_show_caclute.Text,16)); break;
                        case Symbol.SUB: text_show_caclute.Text = SUB(Convert.ToInt32(st.Peek().ToString(), 16), Convert.ToInt32(text_show_caclute.Text, 16)); break;
                        case Symbol.MUL: text_show_caclute.Text = MUL(Convert.ToInt32(st.Peek().ToString(), 16), Convert.ToInt32(text_show_caclute.Text, 16)); break;
                        case Symbol.DIV: text_show_caclute.Text = DIV(Convert.ToInt32(st.Peek().ToString(), 16), Convert.ToInt32(text_show_caclute.Text, 16)); break;
                        case Symbol.MOD: text_show_caclute.Text = MOD(Convert.ToInt32(st.Peek().ToString(), 16), Convert.ToInt32(text_show_caclute.Text, 16)); break;
                    }
 
                }
                else if (hex == Hex.Octal)//8进制
                {
                    switch (symbol)
                    {
                        //输入参数16进制
                        case Symbol.ADD: text_show_caclute.Text = ADD(Convert.ToInt32(st.Peek().ToString(), 8), Convert.ToInt32(text_show_caclute.Text, 8)); break;
                        case Symbol.SUB: text_show_caclute.Text = SUB(Convert.ToInt32(st.Peek().ToString(), 8), Convert.ToInt32(text_show_caclute.Text, 8)); break;
                        case Symbol.MUL: text_show_caclute.Text = MUL(Convert.ToInt32(st.Peek().ToString(), 8), Convert.ToInt32(text_show_caclute.Text, 8)); break;
                        case Symbol.DIV: text_show_caclute.Text = DIV(Convert.ToInt32(st.Peek().ToString(), 8), Convert.ToInt32(text_show_caclute.Text, 8)); break;
                        case Symbol.MOD: text_show_caclute.Text = MOD(Convert.ToInt32(st.Peek().ToString(), 8), Convert.ToInt32(text_show_caclute.Text, 8)); break;
                    }
 
                }
                else if (hex == Hex.Binary)//二进制
                {
                    switch (symbol)
                    {
                        //输入参数16进制
                        case Symbol.ADD: text_show_caclute.Text = ADD(Convert.ToInt32(st.Peek().ToString(), 2), Convert.ToInt32(text_show_caclute.Text, 2)); break;
                        case Symbol.SUB: text_show_caclute.Text = SUB(Convert.ToInt32(st.Peek().ToString(), 2), Convert.ToInt32(text_show_caclute.Text, 2)); break;
                        case Symbol.MUL: text_show_caclute.Text = MUL(Convert.ToInt32(st.Peek().ToString(), 2), Convert.ToInt32(text_show_caclute.Text, 2)); break;
                        case Symbol.DIV: text_show_caclute.Text = DIV(Convert.ToInt32(st.Peek().ToString(), 2), Convert.ToInt32(text_show_caclute.Text, 2)); break;
                        case Symbol.MOD: text_show_caclute.Text = MOD(Convert.ToInt32(st.Peek().ToString(), 2), Convert.ToInt32(text_show_caclute.Text, 2)); break;
                    }
 
                }

            }
            catch (Exception ex)
            {
 
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (st.Count != 0)
            {
                
                text_show_caclute.Text = st.Peek().ToString();
                st.Pop();
            }
            
        }

        private void btn_sin_Click(object sender, EventArgs e)
        {
            double x;
            if (double.TryParse(text_show_caclute.Text, out x) == true)
            {
                //st.Push(x);
                text_show_caclute.Text = SIN(x);

            }
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            double x;
            if (double.TryParse(text_show_caclute.Text, out x) == true)
            {
               // st.Push(x);
                text_show_caclute.Text = COS(x);

            }
        }

        private void btn_tan_Click(object sender, EventArgs e)
        {
            double x;
            if (double.TryParse(text_show_caclute.Text, out x) == true)
            {
               // st.Push(x);
                text_show_caclute.Text = TAN(x);

            }
        }

        private void btn_ctan_Click(object sender, EventArgs e)
        {
            double x;
            if (double.TryParse(text_show_caclute.Text, out x) == true)
            {
               // st.Push(x);
                text_show_caclute.Text = CTAN(x);

            }
        }

        private void btn_pi_Click(object sender, EventArgs e)
        {
            text_show_caclute.Text += Math.PI;
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            text_show_caclute.Text += Math.E;
        }

        private void Caculate_Load(object sender, EventArgs e)
        {

        }




    }
}
