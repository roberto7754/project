namespace proiect
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtNumeAngajat;
        private System.Windows.Forms.TextBox txtDepartamentAngajat;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Button btnTrimiteRaspunsuri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtNumeAngajat = new System.Windows.Forms.TextBox();
            this.txtDepartamentAngajat = new System.Windows.Forms.TextBox();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.btnTrimiteRaspunsuri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();

            // tabControl1
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 70);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 270);
            this.tabControl1.TabIndex = 7;

            // tabPage1
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(592, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Angajat";
            this.tabPage1.UseVisualStyleBackColor = true;

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(584, 236);
            this.dataGridView1.TabIndex = 0;

            // tabPage2
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rezultate";
            this.tabPage2.UseVisualStyleBackColor = true;

            // dataGridView2
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(580, 232);
            this.dataGridView2.TabIndex = 0;

            // txtNumeAngajat
            this.txtNumeAngajat.Location = new System.Drawing.Point(136, 12);
            this.txtNumeAngajat.Name = "txtNumeAngajat";
            this.txtNumeAngajat.Size = new System.Drawing.Size(160, 20);
            this.txtNumeAngajat.TabIndex = 1;

            // txtDepartamentAngajat
            this.txtDepartamentAngajat.Location = new System.Drawing.Point(136, 40);
            this.txtDepartamentAngajat.Name = "txtDepartamentAngajat";
            this.txtDepartamentAngajat.Size = new System.Drawing.Size(160, 20);
            this.txtDepartamentAngajat.TabIndex = 2;

            // btnStartTest
            this.btnStartTest.Location = new System.Drawing.Point(312, 8);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(120, 28);
            this.btnStartTest.TabIndex = 3;
            this.btnStartTest.Text = "Start Test";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);

            // btnTrimiteRaspunsuri
            this.btnTrimiteRaspunsuri.Location = new System.Drawing.Point(312, 40);
            this.btnTrimiteRaspunsuri.Name = "btnTrimiteRaspunsuri";
            this.btnTrimiteRaspunsuri.Size = new System.Drawing.Size(120, 28);
            this.btnTrimiteRaspunsuri.TabIndex = 4;
            this.btnTrimiteRaspunsuri.Text = "Trimite Raspunsuri";
            this.btnTrimiteRaspunsuri.UseVisualStyleBackColor = true;
            this.btnTrimiteRaspunsuri.Click += new System.EventHandler(this.btnTrimiteRaspunsuri_Click);

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nume:";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prenume:";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 388);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrimiteRaspunsuri);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.txtDepartamentAngajat);
            this.Controls.Add(this.txtNumeAngajat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
