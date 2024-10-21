namespace tic_tac_toe
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
            Label label3;
            tableLayoutPanel1 = new TableLayoutPanel();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            turn = new Label();
            label1 = new Label();
            label2 = new Label();
            wins1 = new Label();
            wins2 = new Label();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Copperplate Gothic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(127, 20);
            label3.Name = "label3";
            label3.Size = new Size(444, 44);
            label3.TabIndex = 6;
            label3.Text = "TIC TAC TOE GAME";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(b1, 0, 0);
            tableLayoutPanel1.Controls.Add(b2, 1, 0);
            tableLayoutPanel1.Controls.Add(b3, 2, 0);
            tableLayoutPanel1.Controls.Add(b4, 0, 1);
            tableLayoutPanel1.Controls.Add(b5, 1, 1);
            tableLayoutPanel1.Controls.Add(b6, 2, 1);
            tableLayoutPanel1.Controls.Add(b7, 0, 2);
            tableLayoutPanel1.Controls.Add(b8, 1, 2);
            tableLayoutPanel1.Controls.Add(b9, 2, 2);
            tableLayoutPanel1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            tableLayoutPanel1.Location = new Point(101, 146);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(501, 308);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // b1
            // 
            b1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            b1.Location = new Point(4, 4);
            b1.Margin = new Padding(4);
            b1.Name = "b1";
            b1.Size = new Size(159, 94);
            b1.TabIndex = 0;
            b1.UseVisualStyleBackColor = true;
            b1.Click += button2_Click;
            // 
            // b2
            // 
            b2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b2.Location = new Point(171, 4);
            b2.Margin = new Padding(4);
            b2.Name = "b2";
            b2.Size = new Size(159, 94);
            b2.TabIndex = 1;
            b2.UseVisualStyleBackColor = true;
            b2.Click += button2_Click;
            // 
            // b3
            // 
            b3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b3.Location = new Point(338, 4);
            b3.Margin = new Padding(4);
            b3.Name = "b3";
            b3.Size = new Size(159, 94);
            b3.TabIndex = 2;
            b3.UseVisualStyleBackColor = true;
            b3.Click += button2_Click;
            // 
            // b4
            // 
            b4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b4.Location = new Point(4, 106);
            b4.Margin = new Padding(4);
            b4.Name = "b4";
            b4.Size = new Size(159, 94);
            b4.TabIndex = 3;
            b4.UseVisualStyleBackColor = true;
            b4.Click += button2_Click;
            // 
            // b5
            // 
            b5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b5.Location = new Point(171, 106);
            b5.Margin = new Padding(4);
            b5.Name = "b5";
            b5.Size = new Size(159, 94);
            b5.TabIndex = 4;
            b5.UseVisualStyleBackColor = true;
            b5.Click += button2_Click;
            // 
            // b6
            // 
            b6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b6.Location = new Point(338, 106);
            b6.Margin = new Padding(4);
            b6.Name = "b6";
            b6.Size = new Size(159, 94);
            b6.TabIndex = 5;
            b6.UseVisualStyleBackColor = true;
            b6.Click += button2_Click;
            // 
            // b7
            // 
            b7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b7.Location = new Point(4, 208);
            b7.Margin = new Padding(4);
            b7.Name = "b7";
            b7.Size = new Size(159, 96);
            b7.TabIndex = 6;
            b7.UseVisualStyleBackColor = true;
            b7.Click += button2_Click;
            // 
            // b8
            // 
            b8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b8.Location = new Point(171, 208);
            b8.Margin = new Padding(4);
            b8.Name = "b8";
            b8.Size = new Size(159, 96);
            b8.TabIndex = 7;
            b8.UseVisualStyleBackColor = true;
            b8.Click += button2_Click;
            // 
            // b9
            // 
            b9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            b9.Location = new Point(338, 208);
            b9.Margin = new Padding(4);
            b9.Name = "b9";
            b9.Size = new Size(159, 96);
            b9.TabIndex = 8;
            b9.UseVisualStyleBackColor = true;
            b9.Click += button2_Click;
            // 
            // turn
            // 
            turn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            turn.AutoSize = true;
            turn.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            turn.Location = new Point(13, 101);
            turn.Margin = new Padding(4, 0, 4, 0);
            turn.Name = "turn";
            turn.Size = new Size(200, 26);
            turn.TabIndex = 1;
            turn.Text = "Turn Player 1(X)";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(623, 218);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 2;
            label1.Text = "Player 1(X) Wins:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(620, 289);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 25);
            label2.TabIndex = 3;
            label2.Text = "Player 2(O) Wins:";
            label2.Click += label2_Click;
            // 
            // wins1
            // 
            wins1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            wins1.AutoSize = true;
            wins1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wins1.Location = new Point(815, 218);
            wins1.Margin = new Padding(4, 0, 4, 0);
            wins1.Name = "wins1";
            wins1.Size = new Size(0, 28);
            wins1.TabIndex = 4;
            // 
            // wins2
            // 
            wins2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            wins2.AutoSize = true;
            wins2.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wins2.Location = new Point(816, 287);
            wins2.Margin = new Padding(4, 0, 4, 0);
            wins2.Name = "wins2";
            wins2.Size = new Size(0, 28);
            wins2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(878, 512);
            Controls.Add(label3);
            Controls.Add(wins2);
            Controls.Add(wins1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(turn);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
        private Label turn;
        private Label label1;
        private Label label2;
        private Label wins1;
        private Label wins2;
        private Label label3;
    }
}
