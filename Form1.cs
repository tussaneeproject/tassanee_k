using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testpromiwtus
{
    public partial class Form1 : Form
    {
        String[] item = { "เชียงราย", "เชียงใหม่", "น่าน", "พะเยา", "แพร่", "แม่ฮ่องสอน", "ลำปาง", "ลำพูน", "อุตรดิตษ์" }; //กำหนดตัวแปรitemให้แสดงจังหวัดเป็นข้อความ
        String select1; //กำหนดตัวแปรข้อความ
        String select2;//กำหนดตัวแปรข้อความ
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if ((select1.Equals("เชียงราย") && select2.Equals("อุตรดิตษ์")) || (select1.Equals("อุตรดิตษ์") && select2.Equals("เชียงราย")))//ถ้าเงื่อนไขไปกลับของเชียงรายกับอุตรดิตษ์ตรงกันให้โชว์ระยะทาง
                    textBox1.Text = "308 k.m."; //ให้ไปโชว์ระยะทางกิโลเมตที่textbox1
                if (select1.Equals("เชียงราย") && select2.Equals("ลำพูน") || select2.Equals("ลำพูน") && select1.Equals("เชียงราย"))//ถ้าเงื่อนไขไปกลับของเชียงรายกับลำพูนตรงกันให้โชว์ระยะทาง
                textBox1.Text = "295 k.m.";//ให้ไปโชว์ระยะทางกิโลเมตที่textbox1
            if (select1.Equals("เชียงราย") && select2.Equals("ลำปาง") || select2.Equals("ลำปาง") && select1.Equals("เชียงราย"))//ถ้าเงื่อนไขไปกลับของเชียงรายกับลำปางหรือลำปางเชียงรายตรงกันให้โชว์ระยะทาง
                textBox1.Text = "225 k.m.";//ให้ไปโชว์ระยะทางกิโลเมตที่textbox1
            if (select1.Equals("เชียงราย") && select2.Equals("แม่ฮ่องสอน") || select2.Equals("แม่ฮ่องสอน") &&select1.Equals("เชียงราย"))//ถ้าเงื่อนไขไปกลับของเชียงรายกับแม่ฮ่องสอนตรงกันให้โชว์ระยะทาง
                textBox1.Text = "634 k.m.";//ให้ไปโชว์ระยะทางกิโลเมตที่textbox1
            if (select1.Equals("เชียงราย") && select2.Equals("แพร่") ||select2.Equals("เเพร่") && select1.Equals("เชียงราย"))//ถ้าเงื่อนไขไปกลับของเชียงรายกับแพร่ตรงกันให้โชว์ระยะทาง
                textBox1.Text = "235 k.m.";//ให้ไปโชว์ระยะทางกิโลเมตที่textbox1
            if (select1.Equals("เชียงราย") && select2.Equals("พะเยา") || select2.Equals("พะเยา") && select1.Equals("เชียงราย"))//ถ้าเงื่อนไขไปกลับของเชียงรายกับพะเยาตรงกันให้โชว์ระยะทาง
                textBox1.Text = "94 k.m.";//ให้ไปโชว์ระยะทางกิโลเมตที่textbox1
            if (select1.Equals("เชียงราย") && select2.Equals("เชียงใหม่") || select2.Equals("เชียงใหม่") && select1.Equals("เชียงราย"))//ถ้าเงื่อนไขไปกลับของเชียงรายกับเชียงใหม่ตรงกันให้โชว์ระยะทาง
                textBox1.Text = "182 k.m.";//ให้ไปโชว์ระยะทางกิโลเมตที่textbox1
            if (select1.Equals("เชียงราย") && select2.Equals("น่าน") || select2.Equals("น่าน") && select1.Equals("เชียงราย"))//ถ้าเงื่อนไขไปกลับของเชียงรายกับน่านตรงกันให้โชว์ระยะทาง
                textBox1.Text = "270 k.m.";//ให้ไปโชว์ระยะทางกิโลเมตที่textbox1
                                           /////////////////////////////////////////////
            if (select1.Equals("เชียงใหม่") && select2.Equals("อุตรดิตษ์") || select2.Equals("อุตรดิตษ์") && select1.Equals("เชียงใหม่"))
                    textBox1.Text = "231 k.m.";
                if (select1.Equals("เชียงใหม่") && select2.Equals("ลำพูน") || select2.Equals("ลำพูน") && select1.Equals("เชียงใหม่"))
                    textBox1.Text = "21 k.m.";
                if (select1.Equals("เชียงใหม่") && select2.Equals("ลำปาง") || select2.Equals("ลำปาง") && select1.Equals("เชียงใหม่"))
                    textBox1.Text = "92 k.m.";
                if (select1.Equals("เชียงใหม่") && select2.Equals("แม่ฮ่องสอน") || select2.Equals("แม่ฮ่องสอน") && select1.Equals("เชียงใหม่"))
                    textBox1.Text = "349 k.m.";
                if (select1.Equals("เชียงใหม่") && select2.Equals("แพร่") || select2.Equals("เเพร่") && select1.Equals("เชียงใหม่"))
                    textBox1.Text = "201 k.m.";
                if (select1.Equals("เชียงใหม่") && select2.Equals("พะเยา") || select2.Equals("พะเยา") && select1.Equals("เชียงใหม่"))
                    textBox1.Text = "222 k.m.";
                if (select1.Equals("เชียงใหม่") && select2.Equals("เชียงราย") || select2.Equals("เชียงราย") &&select1.Equals("เชียงใหม่"))
                    textBox1.Text = "182 k.m.";
                if (select1.Equals("เชียงใหม่") && select2.Equals("น่าน") || select2.Equals("น่าน") && select1.Equals("เชียงใหม่"))
                    textBox1.Text = "318 k.m.";
                ///////////////////////////////////////////
                if (select1.Equals("น่าน") && select2.Equals("อุตรดิตษ์") || select2.Equals("อุตรดิตษ์") && select1.Equals("น่าน"))
                    textBox1.Text = "191 k.m.";
                if (select1.Equals("น่าน") && select2.Equals("ลำพูน") || select2.Equals("ลำพูน") && select1.Equals("น่าน"))
                    textBox1.Text = "297 k.m.";
                if (select1.Equals("น่าน") && select2.Equals("ลำปาง") || select2.Equals("ลำปาง") && select1.Equals("น่าน"))
                    textBox1.Text = "227 k.m.";
                if (select1.Equals("น่าน") && select2.Equals("แม่ฮ่องสอน") || select2.Equals("แม่ฮ่องสอน") && select1.Equals("น่าน"))
                    textBox1.Text = "639 k.m.";
                if (select1.Equals("น่าน") && select2.Equals("แพร่") || select2.Equals("เเพร่") && select1.Equals("น่าน"))
                    textBox1.Text = "118 k.m.";
                if (select1.Equals("น่าน") && select2.Equals("พะเยา") || select2.Equals("พะเยา") && select1.Equals("น่าน"))
                    textBox1.Text = "179 k.m.";
                if (select1.Equals("น่าน") && select2.Equals("เชียงใหม่") || select2.Equals("เชียงใหม่") && select1.Equals("น่าน"))
                    textBox1.Text = "318 k.m.";
                if (select1.Equals("น่าน") && select2.Equals("เชียงราย") || select2.Equals("เชียงราย") && select1.Equals("น่าน"))
                    textBox1.Text = "270 k.m.";
            ///////////////////////////////////////////
                if (select1.Equals("พะเยา") && select2.Equals("อุตรดิตษ์") || select2.Equals("อุตรดิตษ์") && select1.Equals("พะเยา"))
                    textBox1.Text = "214 k.m.";
                if (select1.Equals("พะเยา") && select2.Equals("ลำพูน") || select2.Equals("ลำพูน") && select1.Equals("พะเยา"))
                    textBox1.Text = "201 k.m.";
                if (select1.Equals("พะเยา") && select2.Equals("ลำปาง") || select2.Equals("ลำปาง") && select1.Equals("พะเยา"))
                    textBox1.Text = "131 k.m.";
                if (select1.Equals("พะเยา") && select2.Equals("แม่ฮ่องสอน") || select2.Equals("แม่ฮ่องสอน") && select1.Equals("พะเยา"))
                    textBox1.Text = "543 k.m.";
                if (select1.Equals("พะเยา") && select2.Equals("แพร่") || select2.Equals("เเพร่") && select1.Equals("พะเยา"))
                    textBox1.Text = "141 k.m.";
                if (select1.Equals("พะเยา") && select2.Equals("เชียงใหม่") || select2.Equals("เชียงใหม่") && select1.Equals("พะเยา"))
                    textBox1.Text = "222 k.m.";
                if (select1.Equals("พะเยา") && select2.Equals("เชียงราย") || select2.Equals("เชียงราย") && select1.Equals("พะเยา"))
                    textBox1.Text = "94 k.m.";
                if (select1.Equals("พะเยา") && select2.Equals("น่าน") || select2.Equals("น่าน") && select1.Equals("พะเยา"))
                    textBox1.Text = "179 k.m.";
                ///////////////////////////////////////////
                if (select1.Equals("แพร่") && select2.Equals("อุตรดิตษ์") || select2.Equals("อุตรดิตษ์") && select1.Equals("แพร่"))
                    textBox1.Text = "74 k.m.";
                if (select1.Equals("แพร่") && select2.Equals("ลำพูน") || select2.Equals("ลำพูน") && select1.Equals("แพร่"))
                    textBox1.Text = "180 k.m.";
                if (select1.Equals("แพร่") && select1.Equals("ลำปาง") || select2.Equals("ลำปาง") && select1.Equals("แพร่"))
                    textBox1.Text = "109 k.m.";
                if (select1.Equals("แพร่") && select2.Equals("แม่ฮ่องสอน") || select2.Equals("แม่ฮ่องสอน") && select1.Equals("แพร่"))
                    textBox1.Text = "521 k.m.";
                if (select1.Equals("แพร่") && select2.Equals("พะเยา") || select2.Equals("พะเยา") && select1.Equals("แพร่"))
                    textBox1.Text = "141 k.m.";
                if (select1.Equals("แพร่") && select2.Equals("เชียงใหม่") || select2.Equals("เชียงใหม่") && select1.Equals("แพร่"))
                    textBox1.Text = "201 k.m.";
                if (select1.Equals("แพร่") && select2.Equals("เชียงราย") || select2.Equals("เชียงราย") && select1.Equals("แพร่"))
                    textBox1.Text = "235 k.m.";
                if (select1.Equals("แพร่") && select2.Equals("น่าน") || select2.Equals("น่าน") && select1.Equals("แพร่"))
                    textBox1.Text = "118 k.m.";
                ///////////////////////////////////////////
                if (select1.Equals("แม่ฮ่องสอน") && select2.Equals("อุตรดิตษ์") || select2.Equals("อุตรดิตษ์") && select1.Equals("แม่ฮ่องสอน"))
                    textBox1.Text = "552 k.m.";
                if (select1.Equals("แม่ฮ่องสอน") && select2.Equals("ลำพูน") || select2.Equals("ลำพูน") && select1.Equals("แม่ฮ่องสอน"))
                    textBox1.Text = "342 k.m.";
                if (select1.Equals("แม่ฮ่องสอน") && select2.Equals("ลำปาง") || select2.Equals("ลำปาง") && select1.Equals("แม่ฮ่องสอน"))
                    textBox1.Text = "412 k.m.";
                if (select1.Equals("แม่ฮ่องสอน") && select2.Equals("แพร่") || select2.Equals("เเพร่") && select1.Equals("แม่ฮ่องสอน"))
                    textBox1.Text = "521 k.m.";
                if (select1.Equals("แม่ฮ่องสอน") && select2.Equals("พะเยา") || select2.Equals("พะเยา") && select1.Equals("แม่ฮ่องสอน"))
                    textBox1.Text = "543 k.m.";
                if (select1.Equals("แม่ฮ่องสอน") && select2.Equals("เชียงใหม่") || select2.Equals("เชียงใหม่") && select1.Equals("แม่ฮ่องสอน"))
                    textBox1.Text = "349 k.m.";
                if (select1.Equals("แม่ฮ่องสอน") && select2.Equals("เชียงราย") || select2.Equals("เชียงราย") && select1.Equals("แม่ฮ่องสอน"))
                    textBox1.Text = "634 k.m.";
                if (select1.Equals("แม่ฮ่องสอน") && select2.Equals("น่าน") || select2.Equals("น่าน") && select1.Equals("แม่ฮ่องสอน"))
                    textBox1.Text = "639 k.m.";
                ///////////////////////////////////////////
                if (select1.Equals("ลำปาง") && select2.Equals("อุตรดิตษ์") || select2.Equals("อุตรดิตษ์") && select1.Equals("ลำปาง"))
                    textBox1.Text = "140 k.m.";
                if (select1.Equals("ลำปาง") && select2.Equals("ลำพูน") || select2.Equals("ลำพูน") && select1.Equals("ลำปาง"))
                    textBox1.Text = "71 k.m.";
                if (select1.Equals("ลำปาง") && select2.Equals("แม่ฮ่องสอน") || select2.Equals("แม่ฮ่องสอน") && select1.Equals("ลำปาง"))
                    textBox1.Text = "412 k.m.";
                if (select1.Equals("ลำปาง") && select2.Equals("แพร่") || select2.Equals("เเพร่") && select1.Equals("ลำปาง"))
                    textBox1.Text = "109 k.m.";
                if (select1.Equals("ลำปาง") && select2.Equals("พะเยา") || select2.Equals("พะเยา") && select1.Equals("ลำปาง"))
                    textBox1.Text = "131 k.m.";
                if (select1.Equals("ลำปาง") && select2.Equals("เชียงใหม่") || select2.Equals("เชียงใหม่") && select1.Equals("ลำปาง"))
                    textBox1.Text = "92 k.m.";
                if (select1.Equals("ลำปาง") && select2.Equals("เชียงราย") || select2.Equals("เชียงราย") && select1.Equals("ลำปาง"))
                    textBox1.Text = "225 k.m.";
                if (select1.Equals("ลำปาง") && select2.Equals("น่าน") || select2.Equals("น่าน") && select1.Equals("ลำปาง"))
                    textBox1.Text = "227 k.m.";
                ///////////////////////////////////////////
                if (select1.Equals("ลำพูน") && select2.Equals("อุตรดิตษ์") || select2.Equals("อุตรดิตษ์") && select1.Equals("ลำพูน"))
                    textBox1.Text = "210 k.m.";
                if (select1.Equals("ลำพูน") && select2.Equals("ลำปาง") || select2.Equals("ลำปาง") && select1.Equals("ลำพูน"))
                    textBox1.Text = "71 k.m.";
                if (select1.Equals("ลำพูน") && select2.Equals("แม่ฮ่องสอน") || select2.Equals("แม่ฮ่องสอน") && select1.Equals("ลำพูน"))
                    textBox1.Text = "342 k.m.";
                if (select1.Equals("ลำพูน") && select2.Equals("แพร่") || select2.Equals("เเพร่") && select1.Equals("ลำพูน"))
                    textBox1.Text = "180 k.m.";
                if (select1.Equals("ลำพูน") && select2.Equals("พะเยา") || select2.Equals("พะเยา") && select1.Equals("ลำพูน"))
                    textBox1.Text = "201 k.m.";
                if (select1.Equals("ลำพูน") && select2.Equals("เชียงใหม่") || select2.Equals("เชียงใหม่") && select1.Equals("ลำพูน"))
                    textBox1.Text = "21 k.m.";
                if (select1.Equals("ลำพูน") && select2.Equals("เชียงราย") || select2.Equals("เชียงราย") && select1.Equals("ลำพูน"))
                    textBox1.Text = "295 k.m.";
                if (select1.Equals("ลำพูน") && select2.Equals("น่าน") || select2.Equals("น่าน") && select1.Equals("ลำพูน"))
                    textBox1.Text = "297 k.m.";
                ///////////////////////////////////////////
                if (select1.Equals("อุตรดิตษ์") && select2.Equals("ลำพูน") || select2.Equals("ลำพูน") && select1.Equals("อุตรดิตษ์"))
                    textBox1.Text = "210 k.m.";
                if (select1.Equals("อุตรดิตษ์") && select2.Equals("ลำปาง") || select2.Equals("ลำปาง") && select1.Equals("อุตรดิตษ์"))
                    textBox1.Text = "140 k.m.";
                if (select1.Equals("อุตรดิตษ์") && select2.Equals("แม่ฮ่องสอน") || select2.Equals("แม่ฮ่องสอน") && select1.Equals("อุตรดิตษ์"))
                    textBox1.Text = "552 k.m.";
                if (select1.Equals("อุตรดิตษ์") && select2.Equals("แพร่") || select2.Equals("เเพร่") && select1.Equals("อุตรดิตษ์"))
                    textBox1.Text = "74 k.m.";
                if (select1.Equals("อุตรดิตษ์") && select2.Equals("พะเยา") ||select2.Equals("พะเยา") && select1.Equals("อุตรดิตษ์"))
                    textBox1.Text = "214 k.m.";
                if (select1.Equals("อุตรดิตษ์") && select2.Equals("เชียงใหม่") || select2.Equals("เชียงใหม่") && select1.Equals("อุตรดิตษ์"))
                    textBox1.Text = "231 k.m.";
                if (select1.Equals("อุตรดิตษ์") && select2.Equals("เชียงราย") || select2.Equals("เชียงราย") && select1.Equals("อุตรดิตษ์"))
                    textBox1.Text = "308 k.m.";
                if (select1.Equals("อุตรดิตษ์") && select2.Equals("น่าน") || select2.Equals("น่าน") && select1.Equals("อุตรดิตษ์"))
                    textBox1.Text = "191 k.m.";
            
              
    }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่?", "!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)//ถ้าเงื่อนไขตรงกันให้โชว์ข้อความคุณต้องการออกจากโปรแกรมหรือไม่?แล้วให้กด ok
            {
                Application.Exit(); //คำสั่งออกจากโปรแกรม
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((String)comboBox1.SelectedItem == "ลำปาง")//คำสั่ง if else ถ้าตรงกับcomboBox1ให่มาแสดงค่าที่comboBox
            {
                select1 = (String)comboBox1.SelectedItem;
                int index = comboBox1.SelectedIndex;
                pictureBox1.Image = Properties.Resources._6ลำปาง; //โชว์รูปภาพ
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }else if((String)comboBox1.SelectedItem == "เชียงใหม่")
            {
                select1 = (String)comboBox1.SelectedItem;
                int index = comboBox1.SelectedIndex;
                pictureBox1.Image = Properties.Resources._1ใหม่;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                
            }else if ((String)comboBox1.SelectedItem == "เชียงราย")
            {
                select1 = (String)comboBox1.SelectedItem;
                int index = comboBox1.SelectedIndex;
                pictureBox1.Image = Properties.Resources._2_ราย;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((String)comboBox1.SelectedItem == "พะเยา")
            {
                select1 = (String)comboBox1.SelectedItem;
                int index = comboBox1.SelectedIndex;
                pictureBox1.Image = Properties.Resources._15218511_1120249741428122_1195389791_n;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }else if ((String)comboBox1.SelectedItem == "น่าน")
            {
                select1 = (String)comboBox1.SelectedItem;
                int index = comboBox1.SelectedIndex;
                pictureBox1.Image = Properties.Resources._15218249_1120188554767574_1354999448_n;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }else if ((String)comboBox1.SelectedItem == "แพร่")
            {
                select1 = (String)comboBox1.SelectedItem;
                int index = comboBox1.SelectedIndex;
                pictureBox1.Image = Properties.Resources._15211734_1120188551434241_1372982552_n;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }else if ((String)comboBox1.SelectedItem == "แม่ฮ่องสอน")
            {
                select1 = (String)comboBox1.SelectedItem;
                int index = comboBox1.SelectedIndex;
                pictureBox1.Image = Properties.Resources._15211752_1120188444767585_1992457284_n;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((String)comboBox1.SelectedItem == "ลำพูน")
            {
                select1 = (String)comboBox1.SelectedItem;
                int index = comboBox1.SelectedIndex;
                pictureBox1.Image = Properties.Resources._15207889_1120188428100920_1493047306_n;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((String)comboBox1.SelectedItem == "อุตรดิตษ์")
            {
                select1 = (String)comboBox1.SelectedItem;
                int index = comboBox1.SelectedIndex;
                pictureBox1.Image = Properties.Resources._15175581_1120188491434247_1902793988_n;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(item);
            comboBox2.Items.Remove(comboBox1.SelectedItem);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
   
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((String)comboBox2.SelectedItem == "ลำปาง")
            {
                select2 = (String)comboBox2.SelectedItem;
                int index = comboBox2.SelectedIndex;
                pictureBox2.Image = Properties.Resources._6ลำปาง;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((String)comboBox2.SelectedItem == "เชียงใหม่")
            {
                select2 = (String)comboBox2.SelectedItem;
                int index = comboBox2.SelectedIndex;
                pictureBox2.Image = Properties.Resources._1ใหม่;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else if ((String)comboBox2.SelectedItem == "เชียงราย")
            {
                select2 = (String)comboBox2.SelectedItem;
                int index = comboBox2.SelectedIndex;
                pictureBox2.Image = Properties.Resources._2_ราย;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((String)comboBox2.SelectedItem == "พะเยา")
            {
                select2 = (String)comboBox2.SelectedItem;
                int index = comboBox2.SelectedIndex;
                pictureBox2.Image = Properties.Resources._15218511_1120249741428122_1195389791_n;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((String)comboBox2.SelectedItem == "น่าน")
            {
                select2 = (String)comboBox2.SelectedItem;
                int index = comboBox2.SelectedIndex;
                pictureBox2.Image = Properties.Resources._15218249_1120188554767574_1354999448_n;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((String)comboBox2.SelectedItem == "แพร่")
            {
                select2 = (String)comboBox2.SelectedItem;
                int index = comboBox2.SelectedIndex;
                pictureBox2.Image = Properties.Resources._15211734_1120188551434241_1372982552_n;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((String)comboBox2.SelectedItem == "แม่ฮ่องสอน")
            {
                select2 = (String)comboBox2.SelectedItem;
                int index = comboBox2.SelectedIndex;
                pictureBox2.Image = Properties.Resources._15211752_1120188444767585_1992457284_n;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((String)comboBox2.SelectedItem == "ลำพูน")
            {
                select2 = (String)comboBox2.SelectedItem;
                int index = comboBox2.SelectedIndex;
                pictureBox2.Image = Properties.Resources._15207889_1120188428100920_1493047306_n;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if ((String)comboBox2.SelectedItem == "อุตรดิตษ์")
            {
                select2 = (String)comboBox2.SelectedItem;
                int index = comboBox2.SelectedIndex;
                pictureBox2.Image = Properties.Resources._15175581_1120188491434247_1902793988_n;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            comboBox1.Items.Clear(); //เคลียร์ข้อมูลในcomboBox1
            comboBox1.Items.AddRange(item);//เคลียร์itemในcomboBox1
            comboBox1.Items.Remove(comboBox2.SelectedItem);//เคลียร์ข้อมูลในcomboBox2
        }
    }
}
