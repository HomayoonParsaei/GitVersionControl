namespace GitVersionControl
{
    partial class FormMain
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
            buttonFtoC = new Button();
            buttonCtoF = new Button();
            buttonClear = new Button();
            textBoxTempC = new TextBox();
            textBoxTempF = new TextBox();
            labelTempInC = new Label();
            labelTempInF = new Label();
            labelTitle = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonFtoC
            // 
            buttonFtoC.Location = new Point(127, 76);
            buttonFtoC.Name = "buttonFtoC";
            buttonFtoC.Size = new Size(89, 23);
            buttonFtoC.TabIndex = 0;
            buttonFtoC.Text = "<- C to F";
            buttonFtoC.UseVisualStyleBackColor = true;
            buttonFtoC.Click += buttonFtoC_Click;
            // 
            // buttonCtoF
            // 
            buttonCtoF.Location = new Point(127, 50);
            buttonCtoF.Name = "buttonCtoF";
            buttonCtoF.Size = new Size(89, 23);
            buttonCtoF.TabIndex = 1;
            buttonCtoF.Text = "C to F ->";
            buttonCtoF.UseVisualStyleBackColor = true;
            buttonCtoF.Click += buttonCtoF_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(127, 137);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(89, 23);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // textBoxTempC
            // 
            textBoxTempC.Location = new Point(21, 50);
            textBoxTempC.Name = "textBoxTempC";
            textBoxTempC.Size = new Size(100, 23);
            textBoxTempC.TabIndex = 3;
            // 
            // textBoxTempF
            // 
            textBoxTempF.Location = new Point(231, 51);
            textBoxTempF.Name = "textBoxTempF";
            textBoxTempF.Size = new Size(100, 23);
            textBoxTempF.TabIndex = 4;
            // 
            // labelTempInC
            // 
            labelTempInC.AutoSize = true;
            labelTempInC.Location = new Point(27, 32);
            labelTempInC.Name = "labelTempInC";
            labelTempInC.Size = new Size(89, 15);
            labelTempInC.TabIndex = 5;
            labelTempInC.Text = "Temperature °C";
            // 
            // labelTempInF
            // 
            labelTempInF.AutoSize = true;
            labelTempInF.Location = new Point(238, 33);
            labelTempInF.Name = "labelTempInF";
            labelTempInF.Size = new Size(87, 15);
            labelTempInF.TabIndex = 6;
            labelTempInF.Text = "Temperature °F";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(128, 15);
            labelTitle.TabIndex = 7;
            labelTitle.Text = "Temperature Converter";
            // 
            // button1
            // 
            button1.Location = new Point(127, 105);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 8;
            button1.Text = "C to K - >";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 172);
            Controls.Add(button1);
            Controls.Add(labelTitle);
            Controls.Add(labelTempInF);
            Controls.Add(labelTempInC);
            Controls.Add(textBoxTempF);
            Controls.Add(textBoxTempC);
            Controls.Add(buttonClear);
            Controls.Add(buttonCtoF);
            Controls.Add(buttonFtoC);
            Name = "FormMain";
            Text = "Temperature Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFtoC;
        private Button buttonCtoF;
        private Button buttonClear;
        private TextBox textBoxTempC;
        private TextBox textBoxTempF;
        private Label labelTempInC;
        private Label labelTempInF;
        private Label labelTitle;
        private Button button1;
    }
}
