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

        Label lblUser;
        Label lblPass;


        TextBox txtUser;
        TextBox txtPass;

        Button btnDentista;
        Button btnProcedimento;
        Button btnSala;
        Button btnPaciente;
        Button btnEspecialidade;
        Button btnAgendamento;
        Button btnFechar;

        public Form1()
        {
            this.lblUser = new Label();
            this.lblUser.Text = "Olá João";
            this.lblUser.Location = new Point(130, 50);

            /*this.lblPass = new Label();
            this.lblPass.Text = "Senha";
            this.lblPass.Location = new Point(120, 80);

            this.txtUser = new TextBox();
            this.txtUser.Location = new Point(60,60);
            this.txtUser.Size = new Size(800,800);

            this.txtPass = new TextBox();
            this.txtPass.Location = new Point(10,110);
            this.txtPass.Size = new Size(280,30);
            this.txtPass.PasswordChar = '*';*/

            this.btnDentista = new Button();
            this.btnDentista.Text = "Dentista";
            this.btnDentista.Location = new Point(50,110);
            this.btnDentista.Size = new Size(100,30);
            this.btnDentista.Click += new EventHandler(this.handleConfirmClick);
            
            this.btnProcedimento = new Button();
            this.btnProcedimento.Text = "Procedimento";
            this.btnProcedimento.Location = new Point(50,150);
            this.btnProcedimento.Size = new Size(100,30);
            this.btnProcedimento.Click += new EventHandler(this.handleCancelClick);

            this.btnSala = new Button();
            this.btnSala.Text = "Sala";
            this.btnSala.Location = new Point(50,190);
            this.btnSala.Size = new Size(100,30);
            this.btnSala.Click += new EventHandler(this.handleConfirmClick);
            
            this.btnPaciente = new Button();
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.Location = new Point(160,110);
            this.btnPaciente.Size = new Size(100,30);
            this.btnPaciente.Click += new EventHandler(this.handleCancelClick);

            this.btnEspecialidade = new Button();
            this.btnEspecialidade.Text = "Especialidade";
            this.btnEspecialidade.Location = new Point(160,150);
            this.btnEspecialidade.Size = new Size(100,30);
            this.btnEspecialidade.Click += new EventHandler(this.handleConfirmClick);
            
            this.btnAgendamento = new Button();
            this.btnAgendamento.Text = "Agendamento";
            this.btnAgendamento.Location = new Point(160,190);
            this.btnAgendamento.Size = new Size(100,30);
            this.btnAgendamento.Click += new EventHandler(this.handleCancelClick);

            this.btnFechar = new Button();
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Location = new Point(100,250);
            this.btnFechar.Size = new Size(100,30);
            this.btnFechar.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnDentista);
            this.Controls.Add(this.btnProcedimento);
            this.Controls.Add(this.btnSala);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnEspecialidade);
            this.Controls.Add(this.btnAgendamento);
            this.Controls.Add(this.btnFechar);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 350);
            this.Text = "Dentista";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void handleConfirmClick(object sender, EventArgs e) {
            DialogResult result;

            result = MessageBox.Show(
                $"Usuário: {this.txtUser.Text}" +
                $"\nSenha: {this.txtPass.Text}",
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