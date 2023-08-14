
namespace GameCaro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_ChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctb_Avatar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoBtn_15x15 = new System.Windows.Forms.RadioButton();
            this.rdoBtn_10x10 = new System.Windows.Forms.RadioButton();
            this.rdoBtn_5x5 = new System.Windows.Forms.RadioButton();
            this.btn_Start = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_Avatar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ChessBoard
            // 
            this.pnl_ChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_ChessBoard.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnl_ChessBoard.Location = new System.Drawing.Point(14, 22);
            this.pnl_ChessBoard.Name = "pnl_ChessBoard";
            this.pnl_ChessBoard.Size = new System.Drawing.Size(450, 450);
            this.pnl_ChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pctb_Avatar);
            this.panel2.Location = new System.Drawing.Point(478, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 269);
            this.panel2.TabIndex = 1;
            // 
            // pctb_Avatar
            // 
            this.pctb_Avatar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pctb_Avatar.BackgroundImage = global::GameCaro.Properties.Resources.caro;
            this.pctb_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctb_Avatar.InitialImage = global::GameCaro.Properties.Resources.caro;
            this.pctb_Avatar.Location = new System.Drawing.Point(5, 3);
            this.pctb_Avatar.Name = "pctb_Avatar";
            this.pctb_Avatar.Size = new System.Drawing.Size(264, 264);
            this.pctb_Avatar.TabIndex = 0;
            this.pctb_Avatar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.rdoBtn_15x15);
            this.panel3.Controls.Add(this.rdoBtn_10x10);
            this.panel3.Controls.Add(this.rdoBtn_5x5);
            this.panel3.Controls.Add(this.btn_Start);
            this.panel3.Location = new System.Drawing.Point(478, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 133);
            this.panel3.TabIndex = 2;
            // 
            // rdoBtn_15x15
            // 
            this.rdoBtn_15x15.AutoSize = true;
            this.rdoBtn_15x15.Location = new System.Drawing.Point(33, 103);
            this.rdoBtn_15x15.Name = "rdoBtn_15x15";
            this.rdoBtn_15x15.Size = new System.Drawing.Size(54, 17);
            this.rdoBtn_15x15.TabIndex = 3;
            this.rdoBtn_15x15.TabStop = true;
            this.rdoBtn_15x15.Text = "15x15";
            this.rdoBtn_15x15.UseVisualStyleBackColor = true;
            // 
            // rdoBtn_10x10
            // 
            this.rdoBtn_10x10.AutoSize = true;
            this.rdoBtn_10x10.Location = new System.Drawing.Point(33, 80);
            this.rdoBtn_10x10.Name = "rdoBtn_10x10";
            this.rdoBtn_10x10.Size = new System.Drawing.Size(54, 17);
            this.rdoBtn_10x10.TabIndex = 2;
            this.rdoBtn_10x10.TabStop = true;
            this.rdoBtn_10x10.Text = "10x10";
            this.rdoBtn_10x10.UseVisualStyleBackColor = true;
            // 
            // rdoBtn_5x5
            // 
            this.rdoBtn_5x5.AutoSize = true;
            this.rdoBtn_5x5.Location = new System.Drawing.Point(33, 57);
            this.rdoBtn_5x5.Name = "rdoBtn_5x5";
            this.rdoBtn_5x5.Size = new System.Drawing.Size(42, 17);
            this.rdoBtn_5x5.TabIndex = 1;
            this.rdoBtn_5x5.TabStop = true;
            this.rdoBtn_5x5.Text = "5x5";
            this.rdoBtn_5x5.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Start.Font = new System.Drawing.Font("Times", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Start.Location = new System.Drawing.Point(5, 3);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(131, 48);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Bắt đầu";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_ChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctb_Avatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctb_Avatar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdoBtn_15x15;
        private System.Windows.Forms.RadioButton rdoBtn_10x10;
        private System.Windows.Forms.RadioButton rdoBtn_5x5;
        private System.Windows.Forms.Button btn_Start;
    }
}

