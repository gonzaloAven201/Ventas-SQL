using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

       
//Frontend /diseño UX 
        //Botones de windows
        

        
       

 
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFrom(new Venta());
        }





        //Mover pantalla 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void Barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //FIn Mover


        //Sub menu
        private void btnProductos_Click(object sender, EventArgs e)
        {
            Subproductos.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Subproductos.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Subproductos.Visible = false;
            AbrirFrom(new Crud());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Subproductos.Visible = false;
        }

       //fin sub menu




        //Abrir formulario
        private void AbrirFrom(object fromhija) {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form fh = fromhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }



        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFrom(new inicio());
        }


        //botones de windows
        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void btnmaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }
       

        //Fin UX
    }
}
