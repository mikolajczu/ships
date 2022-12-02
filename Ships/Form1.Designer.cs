
namespace Ships
{
    partial class Ships
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ships));
            this.background = new System.Windows.Forms.PictureBox();
            this.tytuł = new System.Windows.Forms.Label();
            this.pvp = new System.Windows.Forms.Button();
            this.pvc = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fleet = new System.Windows.Forms.PictureBox();
            this.putRandomlyButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.ship6 = new System.Windows.Forms.PictureBox();
            this.ship42 = new System.Windows.Forms.PictureBox();
            this.ship41 = new System.Windows.Forms.PictureBox();
            this.ship31 = new System.Windows.Forms.PictureBox();
            this.ship32 = new System.Windows.Forms.PictureBox();
            this.ship21 = new System.Windows.Forms.PictureBox();
            this.ship22 = new System.Windows.Forms.PictureBox();
            this.hits = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hits)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.White;
            this.background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.background.Image = global::Ships.Properties.Resources.shipss;
            this.background.Location = new System.Drawing.Point(-1, -1);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1200, 710);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.background_MouseMove);
            // 
            // tytuł
            // 
            this.tytuł.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tytuł.AutoSize = true;
            this.tytuł.BackColor = System.Drawing.SystemColors.Control;
            this.tytuł.Font = new System.Drawing.Font("Stencil", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tytuł.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tytuł.Location = new System.Drawing.Point(334, 45);
            this.tytuł.Name = "tytuł";
            this.tytuł.Size = new System.Drawing.Size(515, 178);
            this.tytuł.TabIndex = 1;
            this.tytuł.Text = "SHIPS";
            this.tytuł.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pvp
            // 
            this.pvp.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvp.Location = new System.Drawing.Point(500, 262);
            this.pvp.Name = "pvp";
            this.pvp.Size = new System.Drawing.Size(200, 100);
            this.pvp.TabIndex = 2;
            this.pvp.Text = "Player vs Player";
            this.pvp.UseVisualStyleBackColor = true;
            this.pvp.Click += new System.EventHandler(this.pvp_Click);
            // 
            // pvc
            // 
            this.pvc.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvc.Location = new System.Drawing.Point(500, 387);
            this.pvc.Name = "pvc";
            this.pvc.Size = new System.Drawing.Size(200, 100);
            this.pvc.TabIndex = 3;
            this.pvc.Text = "Player vs Computer";
            this.pvc.UseVisualStyleBackColor = true;
            this.pvc.Click += new System.EventHandler(this.pvc_Click);
            // 
            // quit
            // 
            this.quit.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.Location = new System.Drawing.Point(500, 514);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(200, 100);
            this.quit.TabIndex = 4;
            this.quit.Text = "Quit game";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(970, 591);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(200, 100);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(814, 95);
            this.label1.TabIndex = 6;
            this.label1.Text = "put your fleet up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // fleet
            // 
            this.fleet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fleet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fleet.Location = new System.Drawing.Point(325, 115);
            this.fleet.Name = "fleet";
            this.fleet.Size = new System.Drawing.Size(535, 493);
            this.fleet.TabIndex = 7;
            this.fleet.TabStop = false;
            this.fleet.Paint += new System.Windows.Forms.PaintEventHandler(this.fleet_Paint);
            this.fleet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fleet_MouseMove);
            // 
            // putRandomlyButton
            // 
            this.putRandomlyButton.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.putRandomlyButton.Location = new System.Drawing.Point(63, 115);
            this.putRandomlyButton.Name = "putRandomlyButton";
            this.putRandomlyButton.Size = new System.Drawing.Size(200, 100);
            this.putRandomlyButton.TabIndex = 8;
            this.putRandomlyButton.Text = "Random";
            this.putRandomlyButton.UseVisualStyleBackColor = true;
            this.putRandomlyButton.Click += new System.EventHandler(this.putRandomlyButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(63, 245);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(200, 100);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(12, 591);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 100);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ship6
            // 
            this.ship6.BackColor = System.Drawing.Color.Green;
            this.ship6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ship6.Location = new System.Drawing.Point(885, 115);
            this.ship6.Name = "ship6";
            this.ship6.Size = new System.Drawing.Size(53, 296);
            this.ship6.TabIndex = 11;
            this.ship6.TabStop = false;
            this.ship6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ship6_MouseClick);
            this.ship6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship6_MouseMove);
            // 
            // ship42
            // 
            this.ship42.BackColor = System.Drawing.Color.Green;
            this.ship42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ship42.Location = new System.Drawing.Point(1030, 115);
            this.ship42.Name = "ship42";
            this.ship42.Size = new System.Drawing.Size(53, 196);
            this.ship42.TabIndex = 14;
            this.ship42.TabStop = false;
            this.ship42.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ship42_MouseClick);
            this.ship42.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship42_MouseMove);
            // 
            // ship41
            // 
            this.ship41.BackColor = System.Drawing.Color.Green;
            this.ship41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ship41.Location = new System.Drawing.Point(957, 115);
            this.ship41.Name = "ship41";
            this.ship41.Size = new System.Drawing.Size(53, 196);
            this.ship41.TabIndex = 15;
            this.ship41.TabStop = false;
            this.ship41.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ship41_MouseClick);
            this.ship41.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship41_MouseMove);
            // 
            // ship31
            // 
            this.ship31.BackColor = System.Drawing.Color.Green;
            this.ship31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ship31.Location = new System.Drawing.Point(1103, 115);
            this.ship31.Name = "ship31";
            this.ship31.Size = new System.Drawing.Size(53, 146);
            this.ship31.TabIndex = 16;
            this.ship31.TabStop = false;
            this.ship31.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ship31_MouseClick);
            this.ship31.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship31_MouseMove);
            // 
            // ship32
            // 
            this.ship32.BackColor = System.Drawing.Color.Green;
            this.ship32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ship32.Location = new System.Drawing.Point(957, 341);
            this.ship32.Name = "ship32";
            this.ship32.Size = new System.Drawing.Size(53, 146);
            this.ship32.TabIndex = 17;
            this.ship32.TabStop = false;
            this.ship32.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ship32_MouseClick);
            this.ship32.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship32_MouseMove);
            // 
            // ship21
            // 
            this.ship21.BackColor = System.Drawing.Color.Green;
            this.ship21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ship21.Location = new System.Drawing.Point(1030, 341);
            this.ship21.Name = "ship21";
            this.ship21.Size = new System.Drawing.Size(53, 96);
            this.ship21.TabIndex = 18;
            this.ship21.TabStop = false;
            this.ship21.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ship21_MouseClick);
            this.ship21.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship21_MouseMove);
            // 
            // ship22
            // 
            this.ship22.BackColor = System.Drawing.Color.Green;
            this.ship22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ship22.Location = new System.Drawing.Point(1103, 341);
            this.ship22.Name = "ship22";
            this.ship22.Size = new System.Drawing.Size(53, 96);
            this.ship22.TabIndex = 19;
            this.ship22.TabStop = false;
            this.ship22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ship22_MouseClick);
            this.ship22.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ship22_MouseMove);
            // 
            // hits
            // 
            this.hits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hits.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hits.Location = new System.Drawing.Point(621, 83);
            this.hits.Name = "hits";
            this.hits.Size = new System.Drawing.Size(535, 493);
            this.hits.TabIndex = 20;
            this.hits.TabStop = false;
            this.hits.Paint += new System.Windows.Forms.PaintEventHandler(this.hits_Paint);
            this.hits.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hits_MouseClick);
            // 
            // Ships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.hits);
            this.Controls.Add(this.ship22);
            this.Controls.Add(this.ship21);
            this.Controls.Add(this.ship32);
            this.Controls.Add(this.ship31);
            this.Controls.Add(this.ship41);
            this.Controls.Add(this.ship42);
            this.Controls.Add(this.ship6);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.putRandomlyButton);
            this.Controls.Add(this.fleet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.pvc);
            this.Controls.Add(this.pvp);
            this.Controls.Add(this.tytuł);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ships";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ships";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Label tytuł;
        private System.Windows.Forms.Button pvp;
        private System.Windows.Forms.Button pvc;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox fleet;
        private System.Windows.Forms.Button putRandomlyButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox ship6;
        private System.Windows.Forms.PictureBox ship42;
        private System.Windows.Forms.PictureBox ship41;
        private System.Windows.Forms.PictureBox ship31;
        private System.Windows.Forms.PictureBox ship32;
        private System.Windows.Forms.PictureBox ship21;
        private System.Windows.Forms.PictureBox ship22;
        private System.Windows.Forms.PictureBox hits;
    }
}

