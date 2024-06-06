namespace WinForms_Tic_Tac_Toe
{
    partial class GameForm
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
            ButtonGrid = new TableLayoutPanel();
            Button_9 = new Button();
            Button_8 = new Button();
            Button_7 = new Button();
            Button_6 = new Button();
            Button_5 = new Button();
            Button_4 = new Button();
            Button_3 = new Button();
            Button_2 = new Button();
            Button_1 = new Button();
            ButtonGrid.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonGrid
            // 
            ButtonGrid.ColumnCount = 3;
            ButtonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ButtonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ButtonGrid.Controls.Add(Button_9, 2, 2);
            ButtonGrid.Controls.Add(Button_8, 1, 2);
            ButtonGrid.Controls.Add(Button_7, 0, 2);
            ButtonGrid.Controls.Add(Button_6, 2, 1);
            ButtonGrid.Controls.Add(Button_5, 1, 1);
            ButtonGrid.Controls.Add(Button_4, 0, 1);
            ButtonGrid.Controls.Add(Button_3, 2, 0);
            ButtonGrid.Controls.Add(Button_2, 1, 0);
            ButtonGrid.Controls.Add(Button_1, 0, 0);
            ButtonGrid.Dock = DockStyle.Fill;
            ButtonGrid.Location = new Point(0, 0);
            ButtonGrid.Name = "ButtonGrid";
            ButtonGrid.RowCount = 3;
            ButtonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            ButtonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            ButtonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            ButtonGrid.Size = new Size(490, 415);
            ButtonGrid.TabIndex = 0;
            // 
            // Button_9
            // 
            Button_9.BackColor = SystemColors.ButtonHighlight;
            Button_9.BackgroundImageLayout = ImageLayout.Zoom;
            Button_9.FlatStyle = FlatStyle.Flat;
            Button_9.Location = new Point(329, 279);
            Button_9.Name = "Button_9";
            Button_9.Size = new Size(158, 133);
            Button_9.TabIndex = 8;
            Button_9.TabStop = false;
            Button_9.UseVisualStyleBackColor = false;
            Button_9.Click += Button_9_Click;
            // 
            // Button_8
            // 
            Button_8.BackColor = SystemColors.ButtonHighlight;
            Button_8.BackgroundImageLayout = ImageLayout.Zoom;
            Button_8.FlatStyle = FlatStyle.Flat;
            Button_8.Location = new Point(166, 279);
            Button_8.Name = "Button_8";
            Button_8.Size = new Size(157, 133);
            Button_8.TabIndex = 7;
            Button_8.UseVisualStyleBackColor = false;
            Button_8.Click += Button_8_Click;
            // 
            // Button_7
            // 
            Button_7.BackColor = SystemColors.ButtonHighlight;
            Button_7.BackgroundImageLayout = ImageLayout.Zoom;
            Button_7.FlatStyle = FlatStyle.Flat;
            Button_7.Location = new Point(3, 279);
            Button_7.Name = "Button_7";
            Button_7.Size = new Size(157, 133);
            Button_7.TabIndex = 6;
            Button_7.UseVisualStyleBackColor = false;
            Button_7.Click += Button_7_Click;
            // 
            // Button_6
            // 
            Button_6.BackColor = SystemColors.ButtonHighlight;
            Button_6.BackgroundImageLayout = ImageLayout.Zoom;
            Button_6.FlatStyle = FlatStyle.Flat;
            Button_6.Location = new Point(329, 141);
            Button_6.Name = "Button_6";
            Button_6.Size = new Size(158, 132);
            Button_6.TabIndex = 5;
            Button_6.UseVisualStyleBackColor = false;
            Button_6.Click += Button_6_Click;
            // 
            // Button_5
            // 
            Button_5.BackColor = SystemColors.ButtonHighlight;
            Button_5.BackgroundImageLayout = ImageLayout.Zoom;
            Button_5.FlatStyle = FlatStyle.Flat;
            Button_5.Location = new Point(166, 141);
            Button_5.Name = "Button_5";
            Button_5.Size = new Size(157, 132);
            Button_5.TabIndex = 4;
            Button_5.UseVisualStyleBackColor = false;
            Button_5.Click += Button_5_Click;
            // 
            // Button_4
            // 
            Button_4.BackColor = SystemColors.ButtonHighlight;
            Button_4.BackgroundImageLayout = ImageLayout.Zoom;
            Button_4.FlatStyle = FlatStyle.Flat;
            Button_4.Location = new Point(3, 141);
            Button_4.Name = "Button_4";
            Button_4.Size = new Size(157, 132);
            Button_4.TabIndex = 3;
            Button_4.UseVisualStyleBackColor = false;
            Button_4.Click += Button_4_Click;
            // 
            // Button_3
            // 
            Button_3.BackColor = SystemColors.ButtonHighlight;
            Button_3.BackgroundImageLayout = ImageLayout.Zoom;
            Button_3.FlatStyle = FlatStyle.Flat;
            Button_3.Location = new Point(329, 3);
            Button_3.Name = "Button_3";
            Button_3.Size = new Size(158, 132);
            Button_3.TabIndex = 2;
            Button_3.UseVisualStyleBackColor = false;
            Button_3.Click += Button_3_Click_1;
            // 
            // Button_2
            // 
            Button_2.BackColor = SystemColors.ButtonHighlight;
            Button_2.BackgroundImageLayout = ImageLayout.Zoom;
            Button_2.FlatStyle = FlatStyle.Flat;
            Button_2.Location = new Point(166, 3);
            Button_2.Name = "Button_2";
            Button_2.Size = new Size(157, 132);
            Button_2.TabIndex = 1;
            Button_2.UseVisualStyleBackColor = false;
            Button_2.Click += Button_2_Click_1;
            // 
            // Button_1
            // 
            Button_1.BackColor = SystemColors.ButtonHighlight;
            Button_1.BackgroundImageLayout = ImageLayout.Zoom;
            Button_1.FlatStyle = FlatStyle.Flat;
            Button_1.ForeColor = SystemColors.ControlText;
            Button_1.Location = new Point(3, 3);
            Button_1.Name = "Button_1";
            Button_1.Size = new Size(157, 132);
            Button_1.TabIndex = 0;
            Button_1.UseVisualStyleBackColor = false;
            Button_1.Click += Button_1_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 415);
            Controls.Add(ButtonGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic-Tac-Toe";
            ButtonGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ButtonGrid;
        private Button Button_1;
        private Button Button_9;
        private Button Button_8;
        private Button Button_7;
        private Button Button_6;
        private Button Button_5;
        private Button Button_4;
        private Button Button_3;
        private Button Button_2;
    }
}