
namespace TicTacToe2
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "АЛЬТЕРНАТИВНЫЕ КРЕСТИКИ НОЛИКИ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // play
            // 
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.play.Location = new System.Drawing.Point(278, 138);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(255, 57);
            this.play.TabIndex = 1;
            this.play.Text = "ИГРАТЬ";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // settings
            // 
            this.settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.settings.Location = new System.Drawing.Point(278, 201);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(255, 57);
            this.settings.TabIndex = 2;
            this.settings.Text = "НАСТРОЙКИ";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(278, 355);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(255, 57);
            this.exit.TabIndex = 3;
            this.exit.Text = "ВЫХОД";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.info.Location = new System.Drawing.Point(278, 264);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(255, 57);
            this.info.TabIndex = 4;
            this.info.Text = "ПРАВИЛА";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.info);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.play);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Крестики-Нолики^2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button info;
    }
}