
namespace TicTacToe2
{
    partial class SettingsForm
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
            this.win = new System.Windows.Forms.CheckBox();
            this.next = new System.Windows.Forms.CheckBox();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "НАСТРОЙКИ";
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Checked = true;
            this.win.CheckState = System.Windows.Forms.CheckState.Checked;
            this.win.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.win.Location = new System.Drawing.Point(39, 154);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(410, 33);
            this.win.TabIndex = 1;
            this.win.Text = "Подсвечивать выигранные поля";
            this.win.UseVisualStyleBackColor = true;
            this.win.CheckedChanged += new System.EventHandler(this.win_CheckedChanged);
            // 
            // next
            // 
            this.next.AutoSize = true;
            this.next.Checked = true;
            this.next.CheckState = System.Windows.Forms.CheckState.Checked;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.next.Location = new System.Drawing.Point(39, 207);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(398, 33);
            this.next.TabIndex = 2;
            this.next.Text = "Подсвечивать следующее поле";
            this.next.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.save.Location = new System.Drawing.Point(119, 297);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(211, 53);
            this.save.TabIndex = 3;
            this.save.Text = "ПРИМЕНИТЬ";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 385);
            this.Controls.Add(this.save);
            this.Controls.Add(this.next);
            this.Controls.Add(this.win);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox win;
        private System.Windows.Forms.CheckBox next;
        private System.Windows.Forms.Button save;
    }
}