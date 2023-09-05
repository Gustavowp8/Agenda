namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            btnSalvar = new Button();
            lstConstatos = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ExcuirContato = new ToolStripMenuItem();
            label4 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnNovo = new Button();
            btnExcluir = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 48);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 104);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 1;
            label2.Text = "Telefone";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 175);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 2;
            label3.Text = "E-mail";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(30, 72);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(181, 23);
            txtNome.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(30, 199);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(181, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(30, 137);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(181, 23);
            txtTelefone.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(30, 261);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(181, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lstConstatos
            // 
            lstConstatos.ContextMenuStrip = contextMenuStrip1;
            lstConstatos.Location = new Point(263, 101);
            lstConstatos.MultiSelect = false;
            lstConstatos.Name = "lstConstatos";
            lstConstatos.Size = new Size(496, 233);
            lstConstatos.TabIndex = 7;
            lstConstatos.UseCompatibleStateImageBehavior = false;
            lstConstatos.ItemSelectionChanged += lstConstatos_ItemSelectionChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ExcuirContato });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(156, 26);
            // 
            // ExcuirContato
            // 
            ExcuirContato.Name = "ExcuirContato";
            ExcuirContato.Size = new Size(155, 22);
            ExcuirContato.Text = "Excluir Contato";
            ExcuirContato.Click += ExcuirContato_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(263, 48);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 8;
            label4.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(263, 72);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(402, 23);
            txtBuscar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(684, 72);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(30, 311);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 11;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(136, 311);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Visible = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 364);
            Controls.Add(btnExcluir);
            Controls.Add(btnNovo);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(lstConstatos);
            Controls.Add(btnSalvar);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Button btnSalvar;
        private ListView lstConstatos;
        private Label label4;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnNovo;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ExcuirContato;
        private Button btnExcluir;
    }
}