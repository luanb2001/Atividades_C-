using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace exemplo_winforms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblName;
        Label lblData;
        Label lblCpf;


        TextBox txtName;
        DateTimePicker dtpData;
        TextBox txtCpf;

        Button btnConfirm;
        Button btnFechar;

        public Form1()
        {
            this.lblName = new Label();
            this.lblName.Text = "Nome";
            this.lblName.Location = new Point(120, 20);

            this.lblData = new Label();
            this.lblData.Text = "Data de Nascimento";
            this.lblData.Location = new Point(100, 80);
            this.lblData.Size = new Size(300, 30);
            
            this.lblCpf = new Label();
            this.lblCpf.Text = "CPF";
            this.lblCpf.Location = new Point(120, 140);
            this.lblData.Size = new Size(300, 30);

            this.txtName = new TextBox();
            this.txtName.Location = new Point(10,50);
            this.txtName.Size = new Size(280,30);

            this.dtpData = new DateTimePicker();
            this.dtpData.Location = new Point(10,110);
            this.dtpData.Size = new Size(280,30);

            this.txtCpf = new TextBox();
            this.txtCpf.Location = new Point(10,170);
            this.txtCpf.Size = new Size(230,30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(50,220);
            this.btnConfirm.Size = new Size(80,30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);
            
            this.btnFechar = new Button();
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Location = new Point(140,220);
            this.btnFechar.Size = new Size(80,30);
            this.btnFechar.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Text = "Título";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void handleConfirmClick(object sender, EventArgs e) {
            DialogResult result;

            result = MessageBox.Show(
                $"Usuário: {this.txtName.Text}" +
                $"\nSenha: {this.dtpData.Text}",
                "Titulo da Mensagem",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                Form2 menu = new Form2();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                Console.WriteLine("Clicou não");
            }
        }
        
        private void handleCancelClick(object sender, EventArgs e) {
            this.Close();
        }

    }

    public class Form2 : Form
    {
        public Form2()
        {
            this.Text = "Menu Principal";
        }
    }

    

}