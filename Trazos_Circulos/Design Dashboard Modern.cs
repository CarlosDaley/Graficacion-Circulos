using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }


        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

       
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = PintarPicturebox.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.Green, 5);
            Rectangle myRectangle = new Rectangle(20, 20, 250, 200);
            graphicsObj.DrawEllipse(myPen, myRectangle);

        }
        

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = PintarPicturebox.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.Blue, 5);
            Rectangle myRectangle = new Rectangle(30, 30, 350, 300);
            graphicsObj.DrawEllipse(myPen, myRectangle);
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = PintarPicturebox.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.DarkRed, 5);
            Rectangle myRectangle = new Rectangle(40, 40, 450, 400);
            graphicsObj.DrawEllipse(myPen, myRectangle);
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = PintarPicturebox.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.DarkMagenta, 5);
            Rectangle myRectangle = new Rectangle(50, 50, 550, 500);
            graphicsObj.DrawEllipse(myPen, myRectangle);
        }

        private void bunifuFlatButton7_Click_1(object sender, EventArgs e)
        {
            foreach (var series in PintarPicturebox.Series)
            {
                series.Points.Clear();
            }
        }

        private void Minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
