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

public class OpSala : Form 
    {
        private System.ComponentModel.IContainer components = null;

        Label lblSala;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public OpSala()
        {
            this.lblSala = new Label();
            this.lblSala.Text = "Sala";
            this.lblSala.Location = new Point(220, 10);

            this.Controls.Add(this.lblSala);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("0");
            lista1.SubItems.Add("Arrancar dente");
            lista1.SubItems.Add("R$ 50,00");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Número", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Equipamentos", -2, HorizontalAlignment.Left);
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
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickSalaInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickSalaDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickSalaAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickSalaAtualizar(object sender, EventArgs e)
        {
            AtualizarSala menu = new AtualizarSala();
            menu.ShowDialog();
        }
        private void handleConfirmClickSalaDeletar(object sender, EventArgs e)
        {
            ExcluirSala menu = new ExcluirSala();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmClickSalaInserir(object sender, EventArgs e)
        {
            InserirSala menu = new InserirSala();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {

            this.Close();
        }
    }

    public class InserirSala : Form 
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNumero;
        Label lblEquipamentos;

        TextBox txtNumero;
        TextBox txtEquipamentos;

        Button btnConfirm;
        Button btnCancel;

        public InserirSala()
        {
            this.lblNumero = new Label();
            this.lblNumero.Text = "Número";
            this.lblNumero.Location = new Point(120, 20);

            this.lblEquipamentos = new Label();
            this.lblEquipamentos.Text = "Preço";
            this.lblEquipamentos.Location = new Point(130, 80);
            this.lblEquipamentos.Size = new Size(300, 30);

            this.txtNumero = new TextBox();
            this.txtNumero.Location = new Point(10, 50);
            this.txtNumero.Size = new Size(280, 30);

            this.txtEquipamentos = new TextBox();
            this.txtEquipamentos.Location = new Point(10, 110);
            this.txtEquipamentos.Size = new Size(280, 30);

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

            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEquipamentos);

            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEquipamentos);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Sala ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja inserir uma nova Sala?" +
                $"",
                "Inserir Sala",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Sala inserida com sucesso! " +
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

    public class ExcluirSala : Form
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public ExcluirSala()
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
            this.Text = "Deletar Sala";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja excluir essa Sala?" +
                $"",
                "Excluir Sala",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Sala excluida com sucesso! " +
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

    public class AtualizarSala : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNumero;
        Label lblEquipamentos;

        TextBox txtNumero;
        TextBox txtEquipamentos;

        Button btnConfirm;
        Button btnCancel;

        public AtualizarSala()
        {
            this.lblNumero = new Label();
            this.lblNumero.Text = "Número";
            this.lblNumero.Location = new Point(120, 20);

            this.lblEquipamentos = new Label();
            this.lblEquipamentos.Text = "Preço";
            this.lblEquipamentos.Location = new Point(130, 80);
            this.lblEquipamentos.Size = new Size(300, 30);

            this.txtNumero = new TextBox();
            this.txtNumero.Location = new Point(10, 50);
            this.txtNumero.Size = new Size(280, 30);

            this.txtEquipamentos = new TextBox();
            this.txtEquipamentos.Location = new Point(10, 110);
            this.txtEquipamentos.Size = new Size(280, 30);

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

            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEquipamentos);

            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEquipamentos);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Sala ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja atualizar uma Sala?" +
                $"",
                "Atualizar Sala",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Sala atualizada com sucesso! " +
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