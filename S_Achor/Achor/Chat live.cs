using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Achor
{
    public partial class Achor : Form
    {
        private Label msg_lbl;
        private Label sender_lbl;
        private int Xloc;
        private int Yloc;
        private Boolean is_leftpos;
        private string msg;
        private string dest;
        private string contenu;
        private int cpt;

        public Achor()
        {
            InitializeComponent();
            Xloc = 30;
            Yloc = 30;
            is_leftpos = true;

        }

        private void btnsendprivate_Click(object sender, EventArgs e)
        {
            string contenu = richTextBox1.Text;            
            Message msg = new Message(dest, contenu);

            msg.MyContent = contenu;
            msg.MySender = dest;
            richTextBox1.Text = String.Empty;

            sender_lbl = this.createLabel("lbSender",msg.MySender,is_leftpos,Xloc,Yloc);
            int posi_sen=sender_lbl.Location.X+10;
            msg_lbl = this.createLabel("lbContent",msg.MyContent,is_leftpos,posi_sen,Yloc);

            

            panel1.Controls.Add(msg_lbl);
            panel1.Controls.Add(sender_lbl);
           
        }

        private Label createLabel(String lbName,String content,bool posi,int Xvar,int Yvar) {
            
            Label lbl = new Label();

            lbl.Location = new Point(Xvar, Yvar);
            lbl.AutoSize = true;
            lbl.MaximumSize = new Size(this.Height / 2, this.Width / 2);
            lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lbl.Text = content;


            if (posi)
            {
                posi = false;
                if (lbName == "lbContent")
                {
                    lbl.BackColor = Color.Azure;
                }
                else
                {
                    lbl.BackColor = Color.Aqua;
                }
            }
            else {
                posi = true;
                if (lbName == "lbContent")
                {
                    lbl.BackColor = Color.Blue;
                }
                else {
                    lbl.BackColor = Color.Brown;
                }
            }
             

            /*Yloc = Yloc + 30;

            if (Xloc==30)
            {
                Xloc = 375;
                lbl.Anchor = AnchorStyles.Left;
                //lbl.Location = new Point(30, 45);
            }
            else
            {
                Xloc = 30;
                lbl.Anchor = AnchorStyles.Right;
                //lbl.Location = new Point(375, 30);
                
            }
            */
            return lbl;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dest = "A :";
        }

        private void sender_B_Click(object sender, EventArgs e)
        {
            dest = "B :";
        }

        private void sender_C_Click(object sender, EventArgs e)
        {
            dest = "C :";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dest = "D :";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}