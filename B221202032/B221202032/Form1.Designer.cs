
namespace B221202032
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
            txtRotationAngle = new TextBox();
            txtNumberOfEdge = new TextBox();
            txtLength = new TextBox();
            txtCenterY = new TextBox();
            txtCenterX = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            btnSetRandomValues = new Button();
            btnDraw = new Button();
            btnRotate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtRotationAngle
            // 
            txtRotationAngle.Location = new Point(177, 179);
            txtRotationAngle.Name = "txtRotationAngle";
            txtRotationAngle.Size = new Size(125, 27);
            txtRotationAngle.TabIndex = 0;
            // 
            // txtNumberOfEdge
            // 
            txtNumberOfEdge.Location = new Point(177, 140);
            txtNumberOfEdge.Name = "txtNumberOfEdge";
            txtNumberOfEdge.Size = new Size(125, 27);
            txtNumberOfEdge.TabIndex = 1;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(177, 99);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(125, 27);
            txtLength.TabIndex = 2;
            // 
            // txtCenterY
            // 
            txtCenterY.Location = new Point(331, 59);
            txtCenterY.Name = "txtCenterY";
            txtCenterY.Size = new Size(125, 27);
            txtCenterY.TabIndex = 3;
            // 
            // txtCenterX
            // 
            txtCenterX.Location = new Point(177, 59);
            txtCenterX.Name = "txtCenterX";
            txtCenterX.Size = new Size(125, 27);
            txtCenterX.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 62);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 5;
            label1.Text = "Center Points";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 106);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 6;
            label2.Text = "Length";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 143);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 7;
            label3.Text = "Number Of Edge";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 182);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 8;
            label4.Text = "Rotation Angle";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(42, 258);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(453, 204);
            listBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(795, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(536, 414);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // btnSetRandomValues
            // 
            btnSetRandomValues.Location = new Point(581, 267);
            btnSetRandomValues.Name = "btnSetRandomValues";
            btnSetRandomValues.Size = new Size(149, 29);
            btnSetRandomValues.TabIndex = 11;
            btnSetRandomValues.Text = "Set Random Values";
            btnSetRandomValues.UseVisualStyleBackColor = true;
            btnSetRandomValues.Click += btnSetRandomValues_Click;
            // 
            // btnDraw
            // 
            btnDraw.Location = new Point(581, 321);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(149, 29);
            btnDraw.TabIndex = 12;
            btnDraw.Text = "Draw";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // btnRotate
            // 
            btnRotate.Location = new Point(581, 382);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(149, 29);
            btnRotate.TabIndex = 13;
            btnRotate.Text = "Rotate";
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.Click += btnRotate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 655);
            Controls.Add(btnRotate);
            Controls.Add(btnDraw);
            Controls.Add(btnSetRandomValues);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCenterX);
            Controls.Add(txtCenterY);
            Controls.Add(txtLength);
            Controls.Add(txtNumberOfEdge);
            Controls.Add(txtRotationAngle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtRotationAngle;
        private TextBox txtNumberOfEdge;
        private TextBox txtLength;
        private TextBox txtCenterY;
        private TextBox txtCenterX;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Button btnSetRandomValues;
        private Button btnDraw;
        private Button btnRotate;
    }
}
