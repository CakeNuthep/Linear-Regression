namespace LinearRegression
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.textBox_bias = new System.Windows.Forms.TextBox();
            this.textBox_iter = new System.Windows.Forms.TextBox();
            this.textBox_learningRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_pathFile = new System.Windows.Forms.TextBox();
            this.button_run = new System.Windows.Forms.Button();
            this.button_browseFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(27, 83);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(747, 341);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.TabStop = false;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // textBox_weight
            // 
            this.textBox_weight.Location = new System.Drawing.Point(85, 45);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(100, 20);
            this.textBox_weight.TabIndex = 3;
            this.textBox_weight.Text = "0";
            // 
            // textBox_bias
            // 
            this.textBox_bias.Location = new System.Drawing.Point(234, 45);
            this.textBox_bias.Name = "textBox_bias";
            this.textBox_bias.Size = new System.Drawing.Size(100, 20);
            this.textBox_bias.TabIndex = 4;
            this.textBox_bias.Text = "0";
            // 
            // textBox_iter
            // 
            this.textBox_iter.Location = new System.Drawing.Point(399, 45);
            this.textBox_iter.Name = "textBox_iter";
            this.textBox_iter.Size = new System.Drawing.Size(100, 20);
            this.textBox_iter.TabIndex = 5;
            this.textBox_iter.Text = "1000";
            // 
            // textBox_learningRate
            // 
            this.textBox_learningRate.Location = new System.Drawing.Point(586, 45);
            this.textBox_learningRate.Name = "textBox_learningRate";
            this.textBox_learningRate.Size = new System.Drawing.Size(100, 20);
            this.textBox_learningRate.TabIndex = 6;
            this.textBox_learningRate.Text = "0.001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "weight: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "bias: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "iterator:  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "learning rate:  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "path file: ";
            // 
            // textBox_pathFile
            // 
            this.textBox_pathFile.Location = new System.Drawing.Point(85, 9);
            this.textBox_pathFile.Name = "textBox_pathFile";
            this.textBox_pathFile.Size = new System.Drawing.Size(601, 20);
            this.textBox_pathFile.TabIndex = 1;
            this.textBox_pathFile.Text = "D:\\LearningC#\\page\\Linear Regression\\App\\LinearRegression\\LinearRegression\\Data\\A" +
    "dvertising.csv";
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(699, 45);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(75, 23);
            this.button_run.TabIndex = 7;
            this.button_run.Text = "RUN";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // button_browseFile
            // 
            this.button_browseFile.Location = new System.Drawing.Point(699, 9);
            this.button_browseFile.Name = "button_browseFile";
            this.button_browseFile.Size = new System.Drawing.Size(75, 23);
            this.button_browseFile.TabIndex = 2;
            this.button_browseFile.Text = "Browse";
            this.button_browseFile.UseVisualStyleBackColor = true;
            this.button_browseFile.Click += new System.EventHandler(this.button_browseFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_browseFile);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_learningRate);
            this.Controls.Add(this.textBox_iter);
            this.Controls.Add(this.textBox_bias);
            this.Controls.Add(this.textBox_pathFile);
            this.Controls.Add(this.textBox_weight);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "Form1";
            this.Text = "Linear Regression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.TextBox textBox_bias;
        private System.Windows.Forms.TextBox textBox_iter;
        private System.Windows.Forms.TextBox textBox_learningRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_pathFile;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.Button button_browseFile;
    }
}

