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

public class OpEspecialidade : Form 
    {
        private System.ComponentModel.IContainer components = null;

        Label lblEspecialidade;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public OpEspecialidade()
        {
            this.lblEspecialidade = new Label();
            this.lblEspecialidade.Text = "Especialidade";
            this.lblEspecialidade.Location = new Point(220, 10);

            this.Controls.Add(this.lblEspecialidade);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("0");
            lista1.SubItems.Add("Arrancar dente");
            lista1.SubItems.Add("R$ 50,00");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Tarefas", -2, HorizontalAlignment.Left);
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
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickEspecialidadeInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickEspecialidadeDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickEspecialidadeAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickEspecialidadeAtualizar(object sender, EventArgs e)
        {
            AtualizarEspecialidade menu = new AtualizarEspecialidade();
            menu.ShowDialog();
        }
        private void handleConfirmClickEspecialidadeDeletar(object sender, EventArgs e)
        {
            ExcluirEspecialidade menu = new ExcluirEspecialidade();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmClickEspecialidadeInserir(object sender, EventArgs e)
        {
            InserirEspecialidade menu = new InserirEspecialidade();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {

            this.Close();
        }
    }

    public class InserirEspecialidade : Form 
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        Label lblTarefas;

        TextBox txtDescricao;
        TextBox txtTarefas;

        Button btnConfirm;
        Button btnCancel;

        public InserirEspecialidade()
        {
            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(120, 20);

            this.lblTarefas = new Label();
            this.lblTarefas.Text = "Preço";
            this.lblTarefas.Location = new Point(130, 80);
            this.lblTarefas.Size = new Size(300, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtTarefas = new TextBox();
            this.txtTarefas.Location = new Point(10, 110);
            this.txtTarefas.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(100, 220);
            this.btnConfirm.Size = new Size(90, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100, 260);
            this.btnCancel.Size = new Size(90, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTarefas);

            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTarefas);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Especialidade ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja inserir uma nova especialidade?" +
                $"",
                "Inserir Especialidade",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Especialidade inserida com sucesso! " +
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

    public class ExcluirEspecialidade : Form 
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public ExcluirEspecialidade()
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
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Especialidade";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja excluir uma especialidade?" +
                $"",
                "Excluir Especialidade",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Escpecialidade exlcuida com sucesso! " +
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

    public class AtualizarEspecialidade : Form 
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        Label lblTarefas;

        TextBox txtDescricao;
        TextBox txtTarefas;

        Button btnConfirm;
        Button btnCancel;

        public AtualizarEspecialidade()
        {
            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(120, 20);

            this.lblTarefas = new Label();
            this.lblTarefas.Text = "Tarefas";
            this.lblTarefas.Location = new Point(130, 80);
            this.lblTarefas.Size = new Size(300, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtTarefas = new TextBox();
            this.txtTarefas.Location = new Point(10, 110);
            this.txtTarefas.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(100, 220);
            this.btnConfirm.Size = new Size(90, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100, 260);
            this.btnCancel.Size = new Size(90, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTarefas);

            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTarefas);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Especialidade ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja atualizar uma especialidade?" +
                $"",
                "Atualizar Especialidade",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Especialidade atualizada com sucesso! " +
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