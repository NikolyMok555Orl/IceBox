namespace IceBox
{
    partial class IceBoxForm
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxIceBox = new System.Windows.Forms.PictureBox();
            this.btnOpenDoor = new System.Windows.Forms.Button();
            this.btnCloseDoor = new System.Windows.Forms.Button();
            this.btnUpMode = new System.Windows.Forms.Button();
            this.btnDownMode = new System.Windows.Forms.Button();
            this.labelSostIceBox = new System.Windows.Forms.Label();
            this.labelModeIceBox = new System.Windows.Forms.Label();
            this.labLampIceBox = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxFreezer = new System.Windows.Forms.PictureBox();
            this.labLampFreezer = new System.Windows.Forms.Label();
            this.labelModeFreezer = new System.Windows.Forms.Label();
            this.labelSostFreezer = new System.Windows.Forms.Label();
            this.btnFreezerDown = new System.Windows.Forms.Button();
            this.btnFreezerModeUp = new System.Windows.Forms.Button();
            this.btnFreezerClose = new System.Windows.Forms.Button();
            this.btnFreezerOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFreezer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIceBox
            // 
            this.pictureBoxIceBox.Location = new System.Drawing.Point(12, 211);
            this.pictureBoxIceBox.Name = "pictureBoxIceBox";
            this.pictureBoxIceBox.Size = new System.Drawing.Size(316, 251);
            this.pictureBoxIceBox.TabIndex = 0;
            this.pictureBoxIceBox.TabStop = false;
            // 
            // btnOpenDoor
            // 
            this.btnOpenDoor.Location = new System.Drawing.Point(516, 55);
            this.btnOpenDoor.Name = "btnOpenDoor";
            this.btnOpenDoor.Size = new System.Drawing.Size(154, 46);
            this.btnOpenDoor.TabIndex = 1;
            this.btnOpenDoor.Text = "Открыть";
            this.btnOpenDoor.UseVisualStyleBackColor = true;
            this.btnOpenDoor.Click += new System.EventHandler(this.btnOpenDoor_Click);
            // 
            // btnCloseDoor
            // 
            this.btnCloseDoor.Location = new System.Drawing.Point(516, 107);
            this.btnCloseDoor.Name = "btnCloseDoor";
            this.btnCloseDoor.Size = new System.Drawing.Size(154, 46);
            this.btnCloseDoor.TabIndex = 2;
            this.btnCloseDoor.Text = "Закрыть";
            this.btnCloseDoor.UseVisualStyleBackColor = true;
            this.btnCloseDoor.Click += new System.EventHandler(this.btnCloseDoor_Click);
            // 
            // btnUpMode
            // 
            this.btnUpMode.Location = new System.Drawing.Point(516, 159);
            this.btnUpMode.Name = "btnUpMode";
            this.btnUpMode.Size = new System.Drawing.Size(154, 46);
            this.btnUpMode.TabIndex = 3;
            this.btnUpMode.Text = "Увеличить режим";
            this.btnUpMode.UseVisualStyleBackColor = true;
            this.btnUpMode.Click += new System.EventHandler(this.btnUpMode_Click);
            // 
            // btnDownMode
            // 
            this.btnDownMode.Location = new System.Drawing.Point(516, 211);
            this.btnDownMode.Name = "btnDownMode";
            this.btnDownMode.Size = new System.Drawing.Size(154, 46);
            this.btnDownMode.TabIndex = 4;
            this.btnDownMode.Text = "Уменьшить режим";
            this.btnDownMode.UseVisualStyleBackColor = true;
            this.btnDownMode.Click += new System.EventHandler(this.btnDownMode_Click);
            // 
            // labelSostIceBox
            // 
            this.labelSostIceBox.AutoSize = true;
            this.labelSostIceBox.Location = new System.Drawing.Point(517, 13);
            this.labelSostIceBox.Name = "labelSostIceBox";
            this.labelSostIceBox.Size = new System.Drawing.Size(123, 13);
            this.labelSostIceBox.TabIndex = 5;
            this.labelSostIceBox.Text = "Холодольник работает";
            // 
            // labelModeIceBox
            // 
            this.labelModeIceBox.AutoSize = true;
            this.labelModeIceBox.Location = new System.Drawing.Point(517, 26);
            this.labelModeIceBox.Name = "labelModeIceBox";
            this.labelModeIceBox.Size = new System.Drawing.Size(42, 13);
            this.labelModeIceBox.TabIndex = 6;
            this.labelModeIceBox.Text = "Режим";
            // 
            // labLampIceBox
            // 
            this.labLampIceBox.AutoSize = true;
            this.labLampIceBox.Location = new System.Drawing.Point(517, 39);
            this.labLampIceBox.Name = "labLampIceBox";
            this.labLampIceBox.Size = new System.Drawing.Size(41, 13);
            this.labLampIceBox.TabIndex = 7;
            this.labLampIceBox.Text = "Лампа";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxFreezer
            // 
            this.pictureBoxFreezer.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxFreezer.Name = "pictureBoxFreezer";
            this.pictureBoxFreezer.Size = new System.Drawing.Size(316, 193);
            this.pictureBoxFreezer.TabIndex = 8;
            this.pictureBoxFreezer.TabStop = false;
            // 
            // labLampFreezer
            // 
            this.labLampFreezer.AutoSize = true;
            this.labLampFreezer.Location = new System.Drawing.Point(350, 39);
            this.labLampFreezer.Name = "labLampFreezer";
            this.labLampFreezer.Size = new System.Drawing.Size(41, 13);
            this.labLampFreezer.TabIndex = 15;
            this.labLampFreezer.Text = "Лампа";
            // 
            // labelModeFreezer
            // 
            this.labelModeFreezer.AutoSize = true;
            this.labelModeFreezer.Location = new System.Drawing.Point(350, 26);
            this.labelModeFreezer.Name = "labelModeFreezer";
            this.labelModeFreezer.Size = new System.Drawing.Size(42, 13);
            this.labelModeFreezer.TabIndex = 14;
            this.labelModeFreezer.Text = "Режим";
            // 
            // labelSostFreezer
            // 
            this.labelSostFreezer.AutoSize = true;
            this.labelSostFreezer.Location = new System.Drawing.Point(350, 13);
            this.labelSostFreezer.Name = "labelSostFreezer";
            this.labelSostFreezer.Size = new System.Drawing.Size(125, 13);
            this.labelSostFreezer.TabIndex = 13;
            this.labelSostFreezer.Text = "Морозильник работает";
            // 
            // btnFreezerDown
            // 
            this.btnFreezerDown.Location = new System.Drawing.Point(349, 211);
            this.btnFreezerDown.Name = "btnFreezerDown";
            this.btnFreezerDown.Size = new System.Drawing.Size(154, 46);
            this.btnFreezerDown.TabIndex = 12;
            this.btnFreezerDown.Text = "Уменьшить режим";
            this.btnFreezerDown.UseVisualStyleBackColor = true;
            this.btnFreezerDown.Click += new System.EventHandler(this.btnFreezerDown_Click);
            // 
            // btnFreezerModeUp
            // 
            this.btnFreezerModeUp.Location = new System.Drawing.Point(349, 159);
            this.btnFreezerModeUp.Name = "btnFreezerModeUp";
            this.btnFreezerModeUp.Size = new System.Drawing.Size(154, 46);
            this.btnFreezerModeUp.TabIndex = 11;
            this.btnFreezerModeUp.Text = "Увеличить режим";
            this.btnFreezerModeUp.UseVisualStyleBackColor = true;
            this.btnFreezerModeUp.Click += new System.EventHandler(this.btnFreezerModeUp_Click);
            // 
            // btnFreezerClose
            // 
            this.btnFreezerClose.Location = new System.Drawing.Point(349, 107);
            this.btnFreezerClose.Name = "btnFreezerClose";
            this.btnFreezerClose.Size = new System.Drawing.Size(154, 46);
            this.btnFreezerClose.TabIndex = 10;
            this.btnFreezerClose.Text = "Закрыть";
            this.btnFreezerClose.UseVisualStyleBackColor = true;
            this.btnFreezerClose.Click += new System.EventHandler(this.btnFreezerClose_Click);
            // 
            // btnFreezerOpen
            // 
            this.btnFreezerOpen.Location = new System.Drawing.Point(349, 55);
            this.btnFreezerOpen.Name = "btnFreezerOpen";
            this.btnFreezerOpen.Size = new System.Drawing.Size(154, 46);
            this.btnFreezerOpen.TabIndex = 9;
            this.btnFreezerOpen.Text = "Открыть";
            this.btnFreezerOpen.UseVisualStyleBackColor = true;
            this.btnFreezerOpen.Click += new System.EventHandler(this.btnFreezerOpen_Click);
            // 
            // IceBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 474);
            this.Controls.Add(this.labLampFreezer);
            this.Controls.Add(this.labelModeFreezer);
            this.Controls.Add(this.labelSostFreezer);
            this.Controls.Add(this.btnFreezerDown);
            this.Controls.Add(this.btnFreezerModeUp);
            this.Controls.Add(this.btnFreezerClose);
            this.Controls.Add(this.btnFreezerOpen);
            this.Controls.Add(this.pictureBoxFreezer);
            this.Controls.Add(this.labLampIceBox);
            this.Controls.Add(this.labelModeIceBox);
            this.Controls.Add(this.labelSostIceBox);
            this.Controls.Add(this.btnDownMode);
            this.Controls.Add(this.btnUpMode);
            this.Controls.Add(this.btnCloseDoor);
            this.Controls.Add(this.btnOpenDoor);
            this.Controls.Add(this.pictureBoxIceBox);
            this.Name = "IceBoxForm";
            this.Text = "IceBoxForm";
            this.Load += new System.EventHandler(this.IceBoxForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFreezer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIceBox;
        private System.Windows.Forms.Button btnOpenDoor;
        private System.Windows.Forms.Button btnCloseDoor;
        private System.Windows.Forms.Button btnUpMode;
        private System.Windows.Forms.Button btnDownMode;
        private System.Windows.Forms.Label labelSostIceBox;
        private System.Windows.Forms.Label labelModeIceBox;
        private System.Windows.Forms.Label labLampIceBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxFreezer;
        private System.Windows.Forms.Label labLampFreezer;
        private System.Windows.Forms.Label labelModeFreezer;
        private System.Windows.Forms.Label labelSostFreezer;
        private System.Windows.Forms.Button btnFreezerDown;
        private System.Windows.Forms.Button btnFreezerModeUp;
        private System.Windows.Forms.Button btnFreezerClose;
        private System.Windows.Forms.Button btnFreezerOpen;
    }
}