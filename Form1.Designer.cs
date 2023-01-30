namespace DeathStrandingCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.roadrepair_add = new System.Windows.Forms.Button();
            this.roadrepair_clear = new System.Windows.Forms.Button();
            this.roadrepair_output = new System.Windows.Forms.TextBox();
            this.roadbuilder_metalinitial = new System.Windows.Forms.NumericUpDown();
            this.roadrepair_percentageleft = new System.Windows.Forms.NumericUpDown();
            this.roadbuilder_metaltotal = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roadbuilder_ceramictotal = new System.Windows.Forms.NumericUpDown();
            this.roadbuilder_ceramicinitial = new System.Windows.Forms.NumericUpDown();
            this.roadbuilder_output = new System.Windows.Forms.TextBox();
            this.adhoc_amount = new System.Windows.Forms.NumericUpDown();
            this.adhoc_type = new System.Windows.Forms.ComboBox();
            this.adhoc_output = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roadrepair_useceramic = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.roadbuilder_metalinitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadrepair_percentageleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadbuilder_metaltotal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roadbuilder_ceramictotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadbuilder_ceramicinitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adhoc_amount)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Percentage Left:";
            // 
            // roadrepair_add
            // 
            this.roadrepair_add.Location = new System.Drawing.Point(207, 3);
            this.roadrepair_add.Name = "roadrepair_add";
            this.roadrepair_add.Size = new System.Drawing.Size(75, 23);
            this.roadrepair_add.TabIndex = 2;
            this.roadrepair_add.Text = "Add";
            this.roadrepair_add.UseVisualStyleBackColor = true;
            this.roadrepair_add.Click += new System.EventHandler(this.roadrepair_addClick);
            // 
            // roadrepair_clear
            // 
            this.roadrepair_clear.Location = new System.Drawing.Point(288, 3);
            this.roadrepair_clear.Name = "roadrepair_clear";
            this.roadrepair_clear.Size = new System.Drawing.Size(75, 23);
            this.roadrepair_clear.TabIndex = 3;
            this.roadrepair_clear.Text = "Clear";
            this.roadrepair_clear.UseVisualStyleBackColor = true;
            this.roadrepair_clear.Click += new System.EventHandler(this.roadrepair_clear_Click);
            // 
            // roadrepair_output
            // 
            this.roadrepair_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roadrepair_output.Location = new System.Drawing.Point(3, 33);
            this.roadrepair_output.Multiline = true;
            this.roadrepair_output.Name = "roadrepair_output";
            this.roadrepair_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.roadrepair_output.Size = new System.Drawing.Size(571, 317);
            this.roadrepair_output.TabIndex = 4;
            this.roadrepair_output.TabStop = false;
            // 
            // roadbuilder_metalinitial
            // 
            this.roadbuilder_metalinitial.Location = new System.Drawing.Point(6, 37);
            this.roadbuilder_metalinitial.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.roadbuilder_metalinitial.Name = "roadbuilder_metalinitial";
            this.roadbuilder_metalinitial.Size = new System.Drawing.Size(77, 23);
            this.roadbuilder_metalinitial.TabIndex = 4;
            this.roadbuilder_metalinitial.ValueChanged += new System.EventHandler(this.roadbuilder_metalinitial_ValueChanged);
            // 
            // roadrepair_percentageleft
            // 
            this.roadrepair_percentageleft.Location = new System.Drawing.Point(101, 5);
            this.roadrepair_percentageleft.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.roadrepair_percentageleft.Name = "roadrepair_percentageleft";
            this.roadrepair_percentageleft.Size = new System.Drawing.Size(100, 23);
            this.roadrepair_percentageleft.TabIndex = 1;
            // 
            // roadbuilder_metaltotal
            // 
            this.roadbuilder_metaltotal.Location = new System.Drawing.Point(92, 37);
            this.roadbuilder_metaltotal.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.roadbuilder_metaltotal.Name = "roadbuilder_metaltotal";
            this.roadbuilder_metaltotal.Size = new System.Drawing.Size(77, 23);
            this.roadbuilder_metaltotal.TabIndex = 5;
            this.roadbuilder_metaltotal.ValueChanged += new System.EventHandler(this.roadbuilder_metaltotal_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.roadbuilder_metaltotal);
            this.groupBox1.Controls.Add(this.roadbuilder_metalinitial);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 70);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contributions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.roadbuilder_ceramictotal);
            this.groupBox2.Controls.Add(this.roadbuilder_ceramicinitial);
            this.groupBox2.Location = new System.Drawing.Point(184, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 70);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ceramic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contributions";
            // 
            // roadbuilder_ceramictotal
            // 
            this.roadbuilder_ceramictotal.Location = new System.Drawing.Point(92, 37);
            this.roadbuilder_ceramictotal.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.roadbuilder_ceramictotal.Name = "roadbuilder_ceramictotal";
            this.roadbuilder_ceramictotal.Size = new System.Drawing.Size(77, 23);
            this.roadbuilder_ceramictotal.TabIndex = 7;
            this.roadbuilder_ceramictotal.ValueChanged += new System.EventHandler(this.roadbuilder_ceramictotal_ValueChanged);
            // 
            // roadbuilder_ceramicinitial
            // 
            this.roadbuilder_ceramicinitial.Location = new System.Drawing.Point(6, 37);
            this.roadbuilder_ceramicinitial.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.roadbuilder_ceramicinitial.Name = "roadbuilder_ceramicinitial";
            this.roadbuilder_ceramicinitial.Size = new System.Drawing.Size(77, 23);
            this.roadbuilder_ceramicinitial.TabIndex = 6;
            this.roadbuilder_ceramicinitial.ValueChanged += new System.EventHandler(this.roadbuilder_ceramicinitial_ValueChanged);
            // 
            // roadbuilder_output
            // 
            this.roadbuilder_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roadbuilder_output.Location = new System.Drawing.Point(3, 82);
            this.roadbuilder_output.Multiline = true;
            this.roadbuilder_output.Name = "roadbuilder_output";
            this.roadbuilder_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.roadbuilder_output.Size = new System.Drawing.Size(571, 268);
            this.roadbuilder_output.TabIndex = 11;
            this.roadbuilder_output.TabStop = false;
            // 
            // adhoc_amount
            // 
            this.adhoc_amount.Location = new System.Drawing.Point(3, 6);
            this.adhoc_amount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.adhoc_amount.Name = "adhoc_amount";
            this.adhoc_amount.Size = new System.Drawing.Size(86, 23);
            this.adhoc_amount.TabIndex = 12;
            this.adhoc_amount.ValueChanged += new System.EventHandler(this.adhoc_amount_ValueChanged);
            // 
            // adhoc_type
            // 
            this.adhoc_type.FormattingEnabled = true;
            this.adhoc_type.Items.AddRange(new object[] {
            "Metal",
            "Ceramic",
            "Chemical",
            "SpecialAlloy"});
            this.adhoc_type.Location = new System.Drawing.Point(95, 6);
            this.adhoc_type.Name = "adhoc_type";
            this.adhoc_type.Size = new System.Drawing.Size(121, 23);
            this.adhoc_type.TabIndex = 13;
            this.adhoc_type.SelectedIndexChanged += new System.EventHandler(this.adhoc_type_SelectedIndexChanged);
            // 
            // adhoc_output
            // 
            this.adhoc_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adhoc_output.Location = new System.Drawing.Point(0, 38);
            this.adhoc_output.Multiline = true;
            this.adhoc_output.Name = "adhoc_output";
            this.adhoc_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.adhoc_output.Size = new System.Drawing.Size(577, 315);
            this.adhoc_output.TabIndex = 14;
            this.adhoc_output.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 381);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.roadrepair_output);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Road Repair";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.roadrepair_useceramic);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.roadrepair_percentageleft);
            this.panel2.Controls.Add(this.roadrepair_clear);
            this.panel2.Controls.Add(this.roadrepair_add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 30);
            this.panel2.TabIndex = 8;
            // 
            // roadrepair_useceramic
            // 
            this.roadrepair_useceramic.AutoSize = true;
            this.roadrepair_useceramic.Location = new System.Drawing.Point(369, 6);
            this.roadrepair_useceramic.Name = "roadrepair_useceramic";
            this.roadrepair_useceramic.Size = new System.Drawing.Size(92, 19);
            this.roadrepair_useceramic.TabIndex = 4;
            this.roadrepair_useceramic.Text = "Use Ceramic";
            this.roadrepair_useceramic.UseVisualStyleBackColor = true;
            this.roadrepair_useceramic.CheckedChanged += new System.EventHandler(this.roadrepair_useceramic_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.roadbuilder_output);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(577, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Road Building";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 79);
            this.panel3.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.adhoc_output);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(577, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ad Hoc";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adhoc_amount);
            this.panel1.Controls.Add(this.adhoc_type);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 38);
            this.panel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 381);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "Form1";
            this.Text = "Death Stranding Crap";
            ((System.ComponentModel.ISupportInitialize)(this.roadbuilder_metalinitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadrepair_percentageleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadbuilder_metaltotal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roadbuilder_ceramictotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadbuilder_ceramicinitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adhoc_amount)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button roadrepair_add;
        private Button roadrepair_clear;
        private TextBox roadrepair_output;
        private NumericUpDown roadbuilder_metalinitial;
        private NumericUpDown roadrepair_percentageleft;
        private NumericUpDown roadbuilder_metaltotal;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown roadbuilder_ceramictotal;
        private NumericUpDown roadbuilder_ceramicinitial;
        private TextBox roadbuilder_output;
        private NumericUpDown adhoc_amount;
        private TextBox adhoc_output;
        private ComboBox adhoc_type;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel2;
        private TabPage tabPage2;
        private Panel panel3;
        private TabPage tabPage3;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private CheckBox roadrepair_useceramic;
    }
}