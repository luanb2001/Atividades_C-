using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;
using Models;

public class OpAgendamento : Form 
    {
        private System.ComponentModel.IContainer components = null;

        Label lblAgendamento;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public OpAgendamento()
        {
            this.lblAgendamento = new Label();
            this.lblAgendamento.Text = "Agendamento";
            this.lblAgendamento.Location = new Point(220, 10);

            this.Controls.Add(this.lblAgendamento);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("0");
            lista1.SubItems.Add("Arrancar dente");
            lista1.SubItems.Add("R$ 50,00");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("IdPaciente", -2, HorizontalAlignment.Left);
            listView.Columns.Add("IdDentista", -2, HorizontalAlignment.Left);
            listView.Columns.Add("IdSala", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data", -2, HorizontalAlignment.Left);
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
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickAgendamentoInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickAgendamentoDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickAgendamentoAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickAgendamentoAtualizar(object sender, EventArgs e)
        {
            AtualizarAgendamento menu = new AtualizarAgendamento();
            menu.ShowDialog();
        }
        private void handleConfirmClickAgendamentoDeletar(object sender, EventArgs e)
        {
            ExcluirAgendamento menu = new ExcluirAgendamento();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmClickAgendamentoInserir(object sender, EventArgs e)
        {
            InserirAgendamento menu = new InserirAgendamento();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {

            this.Close();
        }
    }

    public class InserirAgendamento : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblIdPaciente;
        Label lblIdDentista;
        Label lblIdSala;
        Label lblData;

        TextBox txtIdPaciente;
        TextBox txtIdDentista;
        TextBox txtIdSala;
        DateTimePicker dtpData;

        Button btnConfirm;
        Button btnCancel;

        public InserirAgendamento()
        {
            this.lblIdPaciente = new Label();
            this.lblIdPaciente.Text = "IdPaciente";
            this.lblIdPaciente.Location = new Point(120, 20);

            this.lblIdDentista = new Label();
            this.lblIdDentista.Text = "IdDentista";
            this.lblIdDentista.Location = new Point(120, 80);
            this.lblIdDentista.Size = new Size(300, 30);

            this.lblIdSala = new Label();
            this.lblIdSala.Text = "IdSala";
            this.lblIdSala.Location = new Point(125, 140);

            this.lblData = new Label();
            this.lblData.Text = "Data";
            this.lblData.Location = new Point(130, 200);
            this.lblData.Size = new Size(300, 30);


            this.txtIdPaciente = new TextBox();
            this.txtIdPaciente.Location = new Point(10, 50);
            this.txtIdPaciente.Size = new Size(280, 30);

            this.txtIdDentista = new TextBox();
            this.txtIdDentista.Location = new Point(10, 110);
            this.txtIdDentista.Size = new Size(280, 30);

            this.txtIdSala = new TextBox();
            this.txtIdSala.Location = new Point(10, 170);
            this.txtIdSala.Size = new Size(280, 30);

            this.dtpData = new DateTimePicker();
            this.dtpData.Location = new Point(10, 230);
            this.dtpData.Size = new Size(280, 30);
            this.dtpData.Format = DateTimePickerFormat.Short;

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(60, 280);
            this.btnConfirm.Size = new Size(90, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(150, 280);
            this.btnCancel.Size = new Size(90, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblIdPaciente);
            this.Controls.Add(this.lblIdDentista);
            this.Controls.Add(this.lblIdSala);
            this.Controls.Add(this.lblData);

            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.txtIdDentista);
            this.Controls.Add(this.txtIdSala);
            this.Controls.Add(this.dtpData);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Text = "Inserir Agendamento ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja inserir um novo agendamento?" +
                $"",
                "Inserir Agendamento",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Agendamento inserido com sucesso! " +
                    $"",
                    "",
                    MessageBoxButtons.OK
                );
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
    }

    public class ExcluirAgendamento : Form //Deletar Agendamento
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public ExcluirAgendamento()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
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
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Text = "Deletar Agendamento";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja excluir agendamento?" +
                $"",
                "Excluir Agendamento",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Agendamento excluido com sucesso! " +
                    $"",
                    "",
                    MessageBoxButtons.OK
                );
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
    }

    public class AtualizarAgendamento : Form //Atualizar Agendamento
    {
        private System.ComponentModel.IContainer components = null;

        Label lblIdPaciente;
        Label lblIdDentista;
        Label lblIdSala;
        Label lblData;

        TextBox txtIdPaciente;
        TextBox txtIdDentista;
        TextBox txtIdSala;
        DateTimePicker dtpData;

        Button btnConfirm;
        Button btnCancel;

        public AtualizarAgendamento()
        {
            this.lblIdPaciente = new Label();
            this.lblIdPaciente.Text = "IdPaciente";
            this.lblIdPaciente.Location = new Point(120, 20);

            this.lblIdDentista = new Label();
            this.lblIdDentista.Text = "IdDentista";
            this.lblIdDentista.Location = new Point(120, 80);
            this.lblIdDentista.Size = new Size(300, 30);

            this.lblIdSala = new Label();
            this.lblIdSala.Text = "IdSala";
            this.lblIdSala.Location = new Point(125, 140);

            this.lblData = new Label();
            this.lblData.Text = "Data";
            this.lblData.Location = new Point(130, 200);
            this.lblData.Size = new Size(300, 30);


            this.txtIdPaciente = new TextBox();
            this.txtIdPaciente.Location = new Point(10, 50);
            this.txtIdPaciente.Size = new Size(280, 30);

            this.txtIdDentista = new TextBox();
            this.txtIdDentista.Location = new Point(10, 110);
            this.txtIdDentista.Size = new Size(280, 30);

            this.txtIdSala = new TextBox();
            this.txtIdSala.Location = new Point(10, 170);
            this.txtIdSala.Size = new Size(280, 30);

            this.dtpData = new DateTimePicker();
            this.dtpData.Location = new Point(10, 230);
            this.dtpData.Size = new Size(280, 30);
            this.dtpData.Format = DateTimePickerFormat.Short;

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(65, 280);
            this.btnConfirm.Size = new Size(90, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(155, 280);
            this.btnCancel.Size = new Size(90, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblIdPaciente);
            this.Controls.Add(this.lblIdDentista);
            this.Controls.Add(this.lblIdSala);
            this.Controls.Add(this.lblData);

            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.txtIdDentista);
            this.Controls.Add(this.txtIdSala);
            this.Controls.Add(this.dtpData);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Text = "Atualizar Agendamento ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja alterar as informações deste agendamento?" +
                $"",
                "Atualizar Agendamento",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Agendamento alterado com sucesso! " +
                    $"",
                    "",
                    MessageBoxButtons.OK
                );
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
    }