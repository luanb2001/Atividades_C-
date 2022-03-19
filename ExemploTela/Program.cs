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
            Application.Run(new Login());
        }
    }

    public class Login : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Label lblPass;


        TextBox txtUser;
        TextBox txtPass;

        Button btnConfirm;
        Button btnCancel;

        public Login()
        {
            this.lblUser = new Label();
            this.lblUser.Text = "Usuário";
            this.lblUser.Location = new Point(120, 20);

            this.lblPass = new Label();
            this.lblPass.Text = "Senha";
            this.lblPass.Location = new Point(120, 80);

            this.txtUser = new TextBox();
            this.txtUser.Location = new Point(10, 50);
            this.txtUser.Size = new Size(280, 30);

            this.txtPass = new TextBox();
            this.txtPass.Location = new Point(10, 110);
            this.txtPass.Size = new Size(280, 30);
            this.txtPass.PasswordChar = '*';

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(100, 180);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void handleConfirmClick(object sender, EventArgs e)
        {

            if (this.txtUser.Text == "dentista" && this.txtPass.Text == "123")
            {
                TelaDentista form = new TelaDentista();
                form.Show();
            }
            else
            {
                //InserirPaciente form = new Form3();
                //form.Show();

            }
        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    public class TelaDentista : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDentista;

        Button btnDentista;
        Button btnProcedimento;
        Button btnSala;
        Button btnPaciente;
        Button btnEspecialidade;
        Button btnAgendamento;
        Button btnCancel;

        public TelaDentista()
        {
            this.lblDentista = new Label();
            this.lblDentista.Text = "Olá João";
            this.lblDentista.Location = new Point(130, 50);

            this.btnDentista = new Button();
            this.btnDentista.Text = "Dentista";
            this.btnDentista.Location = new Point(50, 110);
            this.btnDentista.Size = new Size(100, 30);
            this.btnDentista.Click += new EventHandler(this.handleDentistaClick);

            this.btnPaciente = new Button();
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.Location = new Point(160, 110);
            this.btnPaciente.Size = new Size(100, 30);
            this.btnPaciente.Click += new EventHandler(this.handlePacienteClick);

            this.btnProcedimento = new Button();
            this.btnProcedimento.Text = "Procedimento";
            this.btnProcedimento.Location = new Point(50, 150);
            this.btnProcedimento.Size = new Size(100, 30);

            this.btnEspecialidade = new Button();
            this.btnEspecialidade.Text = "Especialidade";
            this.btnEspecialidade.Location = new Point(160, 150);
            this.btnEspecialidade.Size = new Size(100, 30);

            this.btnSala = new Button();
            this.btnSala.Text = "Sala";
            this.btnSala.Location = new Point(50, 190);
            this.btnSala.Size = new Size(100, 30);

            this.btnAgendamento = new Button();
            this.btnAgendamento.Text = "Agendamento";
            this.btnAgendamento.Location = new Point(160, 190);
            this.btnAgendamento.Size = new Size(100, 30);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Fechar";
            this.btnCancel.Location = new Point(100, 250);
            this.btnCancel.Size = new Size(100, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDentista);
            this.Controls.Add(this.btnDentista);
            this.Controls.Add(this.btnProcedimento);
            this.Controls.Add(this.btnSala);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnEspecialidade);
            this.Controls.Add(this.btnAgendamento);
            this.Controls.Add(this.btnCancel);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 350);
            this.Text = "Dentista";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void handlePacienteClick(object sender, EventArgs e)
        {
            OpPaciente menu = new OpPaciente();
            menu.ShowDialog();
        }

        private void handleDentistaClick(object sender, EventArgs e)
        {
            OpDentista menu = new OpDentista();
            menu.ShowDialog();
        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    public class OpPaciente : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblPaciente;

        Button btnCancel;

        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public OpPaciente()
        {
            //this.Text = "Paciente";

            this.lblPaciente = new Label();
            this.lblPaciente.Text = "Paciente";
            this.lblPaciente.Location = new Point(220, 10);

            this.Controls.Add(this.lblPaciente);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("Lucas Rafael");
            lista1.SubItems.Add("Maria");
            lista1.SubItems.Add("Obturação");
            lista1.SubItems.Add("Clareamento");
            lista1.SubItems.Add("7");
            lista1.SubItems.Add("...");

            ListViewItem lista2 = new ListViewItem("Lucas Rafael");
            lista2.SubItems.Add("Maria");
            lista2.SubItems.Add("Obturação");
            lista2.SubItems.Add("Clareamento");
            lista2.SubItems.Add("7");
            lista2.SubItems.Add("...");

            ListViewItem lista3 = new ListViewItem("Lucas Rafael");
            lista3.SubItems.Add("Maria");
            lista3.SubItems.Add("Obturação");
            lista3.SubItems.Add("Clareamento");
            lista3.SubItems.Add("7");
            lista3.SubItems.Add("...");

            listView.Items.AddRange(new ListViewItem[] { lista1, lista2, lista3 });
            listView.Columns.Add("Dentista", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Paciente", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Procedimento", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Especialidade", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Sala", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Status", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickAtualizar);

            this.Controls.Add(listView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickAtualizar(object sender, EventArgs e)
        {
            Atualizar menu = new Atualizar();
            menu.ShowDialog();
        }
        private void handleConfirmClickDeletar(object sender, EventArgs e)
        {
            Excluir menu = new Excluir();
            menu.ShowDialog();
        }
        private void handleConfirmClickInserir(object sender, EventArgs e)
        {
            InserirPaciente menu = new InserirPaciente();
            menu.ShowDialog();
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja realmente confirmar o agendamento?" +
                $"",
                "STATUS!",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Console.WriteLine("Clicou não");
            }
        }
        private void handleCancelClick(object sender, EventArgs e)
        {

            this.Close();
        }

        public class InserirPaciente : Form
        {
            private System.ComponentModel.IContainer components = null;

            Label lblNome;
            Label lblCpf;
            Label lblFone;
            Label lblEmail;
            Label lblSenha;
            Label lblData;

            TextBox txtNome;
            TextBox txtCpf;
            TextBox txtFone;
            TextBox txtEmail;
            TextBox txtSenha;
            DateTimePicker dtpData;


            Button btnConfirm;
            Button btnCancel;

            public InserirPaciente()
            {
                this.lblNome = new Label();
                this.lblNome.Text = "Nome";
                this.lblNome.Location = new Point(132, 20);

                this.lblCpf = new Label();
                this.lblCpf.Text = "CPF";
                this.lblCpf.Location = new Point(135, 80);
                this.lblCpf.Size = new Size(300, 30);

                this.lblFone = new Label();
                this.lblFone.Text = "Fone";
                this.lblFone.Location = new Point(132, 140);
                this.lblFone.Size = new Size(300, 30);

                this.lblEmail = new Label();
                this.lblEmail.Text = "Email";
                this.lblEmail.Location = new Point(130, 200);
                this.lblEmail.Size = new Size(300, 30);

                this.lblSenha = new Label();
                this.lblSenha.Text = "Senha";
                this.lblSenha.Location = new Point(130, 260);
                this.lblSenha.Size = new Size(300, 30);

                this.lblData = new Label();
                this.lblData.Text = "Data de Nascimento";
                this.lblData.Location = new Point(95, 320);
                this.lblData.Size = new Size(300, 30);


                this.txtNome = new TextBox();
                this.txtNome.Location = new Point(10, 50);
                this.txtNome.Size = new Size(280, 30);

                this.txtCpf = new TextBox();
                this.txtCpf.Location = new Point(10, 110);
                this.txtCpf.Size = new Size(280, 30);

                this.txtFone = new TextBox();
                this.txtFone.Location = new Point(10, 170);
                this.txtFone.Size = new Size(280, 30);

                this.txtEmail = new TextBox();
                this.txtEmail.Location = new Point(10, 230);
                this.txtEmail.Size = new Size(280, 30);

                this.txtSenha = new TextBox();
                this.txtSenha.Location = new Point(10, 290);
                this.txtSenha.Size = new Size(280, 30);

                this.dtpData = new DateTimePicker();
                this.dtpData.Location = new Point(10, 350);
                this.dtpData.Size = new Size(280, 30);


                this.btnConfirm = new Button();
                this.btnConfirm.Text = "Confirmar";
                this.btnConfirm.Location = new Point(70, 430);
                this.btnConfirm.Size = new Size(80, 30);
                this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

                this.btnCancel = new Button();
                this.btnCancel.Text = "Fechar";
                this.btnCancel.Location = new Point(160, 430);
                this.btnCancel.Size = new Size(80, 30);
                this.btnCancel.Click += new EventHandler(this.handleCancelClick);


                this.Controls.Add(this.lblNome);
                this.Controls.Add(this.lblCpf);
                this.Controls.Add(this.lblFone);
                this.Controls.Add(this.lblEmail);
                this.Controls.Add(this.lblSenha);
                this.Controls.Add(this.lblData);

                this.Controls.Add(this.txtNome);
                this.Controls.Add(this.txtCpf);
                this.Controls.Add(this.txtFone);
                this.Controls.Add(this.txtEmail);
                this.Controls.Add(this.txtSenha);
                this.Controls.Add(this.dtpData);

                this.Controls.Add(this.btnCancel);
                this.Controls.Add(this.btnConfirm);

                this.components = new System.ComponentModel.Container();
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(300, 500);
                this.Text = "Título";
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            private void handleConfirmClick(object sender, EventArgs e)
            {

            }

            private void handleCancelClick(object sender, EventArgs e)
            {
                this.Close();
            }

        }
        public class Excluir : Form
        {
            Label lblId;
            TextBox TxtId;

            Button btnConfirm;
            Button btnCancel;

            public Excluir()
            {
                this.lblId = new Label();
                this.lblId.Text = "Digite o Id:";
                this.lblId.Location = new Point(110, 20);

                this.TxtId = new TextBox();
                this.TxtId.Location = new Point(10, 50);
                this.TxtId.Size = new Size(280, 30);

                this.btnConfirm = new Button();
                this.btnConfirm.Text = "Confirmar";
                this.btnConfirm.Location = new Point(50, 150);
                this.btnConfirm.Size = new Size(80, 30);
                this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

                this.btnCancel = new Button();
                this.btnCancel.Text = "Cancelar";
                this.btnCancel.Location = new Point(140, 150);
                this.btnCancel.Size = new Size(80, 30);
                this.btnCancel.Click += new EventHandler(this.handleCancelClick);

                this.Controls.Add(this.lblId);
                this.Controls.Add(this.TxtId);
                this.Controls.Add(this.btnConfirm);
                this.Controls.Add(this.btnCancel);

                //this.components = new System.ComponentModel.Container();
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(300, 300);
                this.Text = "Deletar Paciente ";
                this.StartPosition = FormStartPosition.CenterScreen;
            }

            private void handleConfirmClick(object sender, EventArgs e)
            {

            }

            private void handleCancelClick(object sender, EventArgs e)
            {
                this.Close();
            }
        }

        public class Atualizar : Form
        {
            Label lblNome;
            Label lblCpf;
            Label lblFone;
            Label lblEmail;
            Label lblSenha;
            Label lblData;

            TextBox txtNome;
            TextBox txtCpf;
            TextBox txtFone;
            TextBox txtEmail;
            TextBox txtSenha;
            DateTimePicker dtpData;


            Button btnConfirm;
            Button btnCancel;

            public Atualizar()
            {

                this.lblNome = new Label();
                this.lblNome.Text = "Nome";
                this.lblNome.Location = new Point(132, 20);

                this.lblCpf = new Label();
                this.lblCpf.Text = "CPF";
                this.lblCpf.Location = new Point(135, 80);
                this.lblCpf.Size = new Size(300, 30);

                this.lblFone = new Label();
                this.lblFone.Text = "Fone";
                this.lblFone.Location = new Point(132, 140);
                this.lblFone.Size = new Size(300, 30);

                this.lblEmail = new Label();
                this.lblEmail.Text = "Email";
                this.lblEmail.Location = new Point(130, 200);
                this.lblEmail.Size = new Size(300, 30);

                this.lblSenha = new Label();
                this.lblSenha.Text = "Senha";
                this.lblSenha.Location = new Point(130, 260);
                this.lblSenha.Size = new Size(300, 30);

                this.lblData = new Label();
                this.lblData.Text = "Data de Nascimento";
                this.lblData.Location = new Point(95, 320);
                this.lblData.Size = new Size(300, 30);


                this.txtNome = new TextBox();
                this.txtNome.Location = new Point(10, 50);
                this.txtNome.Size = new Size(280, 30);

                this.txtCpf = new TextBox();
                this.txtCpf.Location = new Point(10, 110);
                this.txtCpf.Size = new Size(280, 30);

                this.txtFone = new TextBox();
                this.txtFone.Location = new Point(10, 170);
                this.txtFone.Size = new Size(280, 30);

                this.txtEmail = new TextBox();
                this.txtEmail.Location = new Point(10, 230);
                this.txtEmail.Size = new Size(280, 30);

                this.txtSenha = new TextBox();
                this.txtSenha.Location = new Point(10, 290);
                this.txtSenha.Size = new Size(280, 30);

                this.dtpData = new DateTimePicker();
                this.dtpData.Location = new Point(10, 350);
                this.dtpData.Size = new Size(280, 30);


                this.btnConfirm = new Button();
                this.btnConfirm.Text = "Confirmar";
                this.btnConfirm.Location = new Point(70, 430);
                this.btnConfirm.Size = new Size(80, 30);
                this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

                this.btnCancel = new Button();
                this.btnCancel.Text = "Fechar";
                this.btnCancel.Location = new Point(160, 430);
                this.btnCancel.Size = new Size(80, 30);
                this.btnCancel.Click += new EventHandler(this.handleCancelClick);


                this.Controls.Add(this.lblNome);
                this.Controls.Add(this.lblCpf);
                this.Controls.Add(this.lblFone);
                this.Controls.Add(this.lblEmail);
                this.Controls.Add(this.lblSenha);
                this.Controls.Add(this.lblData);

                this.Controls.Add(this.txtNome);
                this.Controls.Add(this.txtCpf);
                this.Controls.Add(this.txtFone);
                this.Controls.Add(this.txtEmail);
                this.Controls.Add(this.txtSenha);
                this.Controls.Add(this.dtpData);

                this.Controls.Add(this.btnCancel);
                this.Controls.Add(this.btnConfirm);

                //this.components = new System.ComponentModel.Container();
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(300, 500);
                this.Text = "Atualizar";
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            private void handleConfirmClick(object sender, EventArgs e)
            {

            }

            private void handleCancelClick(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }

    public class OpDentista : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblPaciente;

        Button btnCancel;

        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public OpDentista()
        {
            //this.Text = "Paciente";

            this.lblPaciente = new Label();
            this.lblPaciente.Text = "Dentista";
            this.lblPaciente.Location = new Point(220, 10);

            this.Controls.Add(this.lblPaciente);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("Lucas Rafael");
            lista1.SubItems.Add("Maria");
            lista1.SubItems.Add("Obturação");
            lista1.SubItems.Add("Clareamento");
            lista1.SubItems.Add("7");
            lista1.SubItems.Add("...");

            ListViewItem lista2 = new ListViewItem("Lucas Rafael");
            lista2.SubItems.Add("Maria");
            lista2.SubItems.Add("Obturação");
            lista2.SubItems.Add("Clareamento");
            lista2.SubItems.Add("7");
            lista2.SubItems.Add("...");

            ListViewItem lista3 = new ListViewItem("Lucas Rafael");
            lista3.SubItems.Add("Maria");
            lista3.SubItems.Add("Obturação");
            lista3.SubItems.Add("Clareamento");
            lista3.SubItems.Add("7");
            lista3.SubItems.Add("...");

            listView.Items.AddRange(new ListViewItem[] { lista1, lista2, lista3 });
            listView.Columns.Add("Dentista", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Paciente", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Procedimento", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Especialidade", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Sala", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Status", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickAtualizar);

            this.Controls.Add(listView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickAtualizar(object sender, EventArgs e)
        {
            Atualizar menu = new Atualizar();
            menu.ShowDialog();
        }
        private void handleConfirmClickDeletar(object sender, EventArgs e)
        {
            Excluir menu = new Excluir();
            menu.ShowDialog();
        }
        private void handleConfirmClickInserir(object sender, EventArgs e)
        {
            InserirDentista menu = new InserirDentista();
            menu.ShowDialog();
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja realmente confirmar o agendamento?" +
                $"",
                "STATUS!",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Console.WriteLine("Clicou não");
            }
        }
        private void handleCancelClick(object sender, EventArgs e)
        {

            this.Close();
        }

        public class InserirDentista : Form
        {
            private System.ComponentModel.IContainer components = null;

            Label lblNome;
            Label lblCpf;
            Label lblFone;
            Label lblEmail;
            Label lblSenha;
            Label lblRegistro;
            Label lblSalario;
            Label lblEspecialidade;

            TextBox txtNome;
            TextBox txtCpf;
            TextBox txtFone;
            TextBox txtEmail;
            TextBox txtSenha;
            TextBox txtRegistro;
            TextBox txtSalario;
            TextBox txtEspecialidade;


            Button btnConfirm;
            Button btnCancel;

            public InserirDentista()
            {
                this.lblNome = new Label();
                this.lblNome.Text = "Nome";
                this.lblNome.Location = new Point(132, 20);

                this.lblCpf = new Label();
                this.lblCpf.Text = "CPF";
                this.lblCpf.Location = new Point(135, 80);
                this.lblCpf.Size = new Size(300, 30);

                this.lblFone = new Label();
                this.lblFone.Text = "Fone";
                this.lblFone.Location = new Point(132, 140);
                this.lblFone.Size = new Size(300, 30);

                this.lblEmail = new Label();
                this.lblEmail.Text = "Email";
                this.lblEmail.Location = new Point(130, 200);
                this.lblEmail.Size = new Size(300, 30);

                this.lblSenha = new Label();
                this.lblSenha.Text = "Senha";
                this.lblSenha.Location = new Point(130, 260);
                this.lblSenha.Size = new Size(300, 30);

                this.lblRegistro = new Label();
                this.lblRegistro.Text = "Registro";
                this.lblRegistro.Location = new Point(128, 320);
                this.lblRegistro.Size = new Size(300, 30);

                this.lblSalario = new Label();
                this.lblSalario.Text = "Salário";
                this.lblSalario.Location = new Point(128, 380);
                this.lblSalario.Size = new Size(300, 30);

                this.lblEspecialidade = new Label();
                this.lblEspecialidade.Text = "Especialidade";
                this.lblEspecialidade.Location = new Point(115, 440);
                this.lblEspecialidade.Size = new Size(300, 30);


                this.txtNome = new TextBox();
                this.txtNome.Location = new Point(10, 50);
                this.txtNome.Size = new Size(280, 30);

                this.txtCpf = new TextBox();
                this.txtCpf.Location = new Point(10, 110);
                this.txtCpf.Size = new Size(280, 30);

                this.txtFone = new TextBox();
                this.txtFone.Location = new Point(10, 170);
                this.txtFone.Size = new Size(280, 30);

                this.txtEmail = new TextBox();
                this.txtEmail.Location = new Point(10, 230);
                this.txtEmail.Size = new Size(280, 30);

                this.txtSenha = new TextBox();
                this.txtSenha.Location = new Point(10, 290);
                this.txtSenha.Size = new Size(280, 30);

                this.txtRegistro = new TextBox();
                this.txtRegistro.Location = new Point(10, 350);
                this.txtRegistro.Size = new Size(280, 30);

                this.txtSalario = new TextBox();
                this.txtSalario.Location = new Point(10, 410);
                this.txtSalario.Size = new Size(280, 30);

                this.txtEspecialidade = new TextBox();
                this.txtEspecialidade.Location = new Point(10, 470);
                this.txtEspecialidade.Size = new Size(280, 30);


                this.btnConfirm = new Button();
                this.btnConfirm.Text = "Confirmar";
                this.btnConfirm.Location = new Point(70, 520);
                this.btnConfirm.Size = new Size(80, 30);
                this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

                this.btnCancel = new Button();
                this.btnCancel.Text = "Fechar";
                this.btnCancel.Location = new Point(160, 520);
                this.btnCancel.Size = new Size(80, 30);
                this.btnCancel.Click += new EventHandler(this.handleCancelClick);


                this.Controls.Add(this.lblNome);
                this.Controls.Add(this.lblCpf);
                this.Controls.Add(this.lblFone);
                this.Controls.Add(this.lblEmail);
                this.Controls.Add(this.lblSenha);
                this.Controls.Add(this.lblRegistro);
                this.Controls.Add(this.lblSalario);
                this.Controls.Add(this.lblEspecialidade);

                this.Controls.Add(this.txtNome);
                this.Controls.Add(this.txtCpf);
                this.Controls.Add(this.txtFone);
                this.Controls.Add(this.txtEmail);
                this.Controls.Add(this.txtSenha);
                this.Controls.Add(this.txtRegistro);
                this.Controls.Add(this.txtSalario);
                this.Controls.Add(this.txtEspecialidade);

                this.Controls.Add(this.btnCancel);
                this.Controls.Add(this.btnConfirm);

                this.components = new System.ComponentModel.Container();
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(300, 600);
                this.Text = "Inserir Dentista";
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            private void handleConfirmClick(object sender, EventArgs e)
            {

            }

            private void handleCancelClick(object sender, EventArgs e)
            {
                this.Close();
            }

        }
        public class Excluir : Form
        {
            Label lblId;
            TextBox TxtId;

            Button btnConfirm;
            Button btnCancel;

            public Excluir()
            {
                this.lblId = new Label();
                this.lblId.Text = "Digite o Id:";
                this.lblId.Location = new Point(110, 20);

                this.TxtId = new TextBox();
                this.TxtId.Location = new Point(10, 50);
                this.TxtId.Size = new Size(280, 30);

                this.btnConfirm = new Button();
                this.btnConfirm.Text = "Confirmar";
                this.btnConfirm.Location = new Point(50, 150);
                this.btnConfirm.Size = new Size(80, 30);
                this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

                this.btnCancel = new Button();
                this.btnCancel.Text = "Cancelar";
                this.btnCancel.Location = new Point(140, 150);
                this.btnCancel.Size = new Size(80, 30);
                this.btnCancel.Click += new EventHandler(this.handleCancelClick);

                this.Controls.Add(this.lblId);
                this.Controls.Add(this.TxtId);
                this.Controls.Add(this.btnConfirm);
                this.Controls.Add(this.btnCancel);

                //this.components = new System.ComponentModel.Container();
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(300, 300);
                this.Text = "Deletar Dentista ";
                this.StartPosition = FormStartPosition.CenterScreen;
            }

            private void handleConfirmClick(object sender, EventArgs e)
            {

            }

            private void handleCancelClick(object sender, EventArgs e)
            {
                this.Close();
            }
        }

        public class Atualizar : Form
        {
            Label lblNome;
            Label lblCpf;
            Label lblFone;
            Label lblEmail;
            Label lblSenha;
            Label lblRegistro;
            Label lblSalario;
            Label lblEspecialidade;

            TextBox txtNome;
            TextBox txtCpf;
            TextBox txtFone;
            TextBox txtEmail;
            TextBox txtSenha;
            TextBox txtRegistro;
            TextBox txtSalario;
            TextBox txtEspecialidade;


            Button btnConfirm;
            Button btnCancel;

            public Atualizar()
            {
                this.lblNome = new Label();
                this.lblNome.Text = "Nome";
                this.lblNome.Location = new Point(132, 20);

                this.lblCpf = new Label();
                this.lblCpf.Text = "CPF";
                this.lblCpf.Location = new Point(135, 80);
                this.lblCpf.Size = new Size(300, 30);

                this.lblFone = new Label();
                this.lblFone.Text = "Fone";
                this.lblFone.Location = new Point(132, 140);
                this.lblFone.Size = new Size(300, 30);

                this.lblEmail = new Label();
                this.lblEmail.Text = "Email";
                this.lblEmail.Location = new Point(130, 200);
                this.lblEmail.Size = new Size(300, 30);

                this.lblSenha = new Label();
                this.lblSenha.Text = "Senha";
                this.lblSenha.Location = new Point(130, 260);
                this.lblSenha.Size = new Size(300, 30);

                this.lblRegistro = new Label();
                this.lblRegistro.Text = "Registro";
                this.lblRegistro.Location = new Point(128, 320);
                this.lblRegistro.Size = new Size(300, 30);

                this.lblSalario = new Label();
                this.lblSalario.Text = "Salário";
                this.lblSalario.Location = new Point(128, 380);
                this.lblSalario.Size = new Size(300, 30);

                this.lblEspecialidade = new Label();
                this.lblEspecialidade.Text = "Especialidade";
                this.lblEspecialidade.Location = new Point(115, 440);
                this.lblEspecialidade.Size = new Size(300, 30);


                this.txtNome = new TextBox();
                this.txtNome.Location = new Point(10, 50);
                this.txtNome.Size = new Size(280, 30);

                this.txtCpf = new TextBox();
                this.txtCpf.Location = new Point(10, 110);
                this.txtCpf.Size = new Size(280, 30);

                this.txtFone = new TextBox();
                this.txtFone.Location = new Point(10, 170);
                this.txtFone.Size = new Size(280, 30);

                this.txtEmail = new TextBox();
                this.txtEmail.Location = new Point(10, 230);
                this.txtEmail.Size = new Size(280, 30);

                this.txtSenha = new TextBox();
                this.txtSenha.Location = new Point(10, 290);
                this.txtSenha.Size = new Size(280, 30);

                this.txtRegistro = new TextBox();
                this.txtRegistro.Location = new Point(10, 350);
                this.txtRegistro.Size = new Size(280, 30);

                this.txtSalario = new TextBox();
                this.txtSalario.Location = new Point(10, 410);
                this.txtSalario.Size = new Size(280, 30);

                this.txtEspecialidade = new TextBox();
                this.txtEspecialidade.Location = new Point(10, 470);
                this.txtEspecialidade.Size = new Size(280, 30);


                this.btnConfirm = new Button();
                this.btnConfirm.Text = "Confirmar";
                this.btnConfirm.Location = new Point(70, 520);
                this.btnConfirm.Size = new Size(80, 30);
                this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

                this.btnCancel = new Button();
                this.btnCancel.Text = "Fechar";
                this.btnCancel.Location = new Point(160, 520);
                this.btnCancel.Size = new Size(80, 30);
                this.btnCancel.Click += new EventHandler(this.handleCancelClick);


                this.Controls.Add(this.lblNome);
                this.Controls.Add(this.lblCpf);
                this.Controls.Add(this.lblFone);
                this.Controls.Add(this.lblEmail);
                this.Controls.Add(this.lblSenha);
                this.Controls.Add(this.lblRegistro);
                this.Controls.Add(this.lblSalario);
                this.Controls.Add(this.lblEspecialidade);

                this.Controls.Add(this.txtNome);
                this.Controls.Add(this.txtCpf);
                this.Controls.Add(this.txtFone);
                this.Controls.Add(this.txtEmail);
                this.Controls.Add(this.txtSenha);
                this.Controls.Add(this.txtRegistro);
                this.Controls.Add(this.txtSalario);
                this.Controls.Add(this.txtEspecialidade);

                this.Controls.Add(this.btnCancel);
                this.Controls.Add(this.btnConfirm);

                //this.components = new System.ComponentModel.Container();
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(300, 600);
                this.Text = "Inserir Dentista";
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            private void handleConfirmClick(object sender, EventArgs e)
            {

            }

            private void handleCancelClick(object sender, EventArgs e)
            {
                this.Close();
            }
        }

    }
}


