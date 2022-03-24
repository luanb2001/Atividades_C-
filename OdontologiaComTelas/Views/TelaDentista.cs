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
            this.btnProcedimento.Click += new EventHandler(this.handleProcedimentoClick);

            this.btnEspecialidade = new Button();
            this.btnEspecialidade.Text = "Especialidade";
            this.btnEspecialidade.Location = new Point(160, 150);
            this.btnEspecialidade.Size = new Size(100, 30);
            this.btnEspecialidade.Click += new EventHandler(this.handleEspecialidadeClick);

            this.btnSala = new Button();
            this.btnSala.Text = "Sala";
            this.btnSala.Location = new Point(50, 190);
            this.btnSala.Size = new Size(100, 30);
            this.btnSala.Click += new EventHandler(this.handleSalaClick);

            this.btnAgendamento = new Button();
            this.btnAgendamento.Text = "Agendamento";
            this.btnAgendamento.Location = new Point(160, 190);
            this.btnAgendamento.Size = new Size(100, 30);
            this.btnAgendamento.Click += new EventHandler(this.handleAgendamentoClick);

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

        private void handleProcedimentoClick(object sender, EventArgs e)
        {
            OpProcedimento menu = new OpProcedimento();
            menu.ShowDialog();
        }

        private void handleEspecialidadeClick(object sender, EventArgs e)
        {
            OpEspecialidade menu = new OpEspecialidade();
            menu.ShowDialog();
        }

        private void handleSalaClick(object sender, EventArgs e)
        {
            OpSala menu = new OpSala();
            menu.ShowDialog();
        }

        private void handleAgendamentoClick(object sender, EventArgs e)
        {
            OpAgendamento menu = new OpAgendamento();
            menu.ShowDialog();
        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }