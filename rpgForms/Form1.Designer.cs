
namespace rpgForms
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
            this.Move_Btn = new System.Windows.Forms.Button();
            this.AttackType = new System.Windows.Forms.ComboBox();
            this.ItemPickUp = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.Inteligence = new System.Windows.Forms.Label();
            this.attack = new System.Windows.Forms.Label();
            this.narraratorSpeech = new System.Windows.Forms.RichTextBox();
            this.scene = new System.Windows.Forms.Label();
            this.questBox = new System.Windows.Forms.CheckedListBox();
            this.magic = new System.Windows.Forms.Label();
            this.health = new System.Windows.Forms.Label();
            this.healthAmt = new System.Windows.Forms.TextBox();
            this.levelAmt = new System.Windows.Forms.TextBox();
            this.speedAmt = new System.Windows.Forms.TextBox();
            this.inteligenceAmt = new System.Windows.Forms.TextBox();
            this.attackAmt = new System.Windows.Forms.TextBox();
            this.magicAmt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Move_Btn
            // 
            this.Move_Btn.Location = new System.Drawing.Point(64, 504);
            this.Move_Btn.Name = "Move_Btn";
            this.Move_Btn.Size = new System.Drawing.Size(242, 53);
            this.Move_Btn.TabIndex = 0;
            this.Move_Btn.Text = "Click To Move";
            this.Move_Btn.UseVisualStyleBackColor = true;
            this.Move_Btn.Click += new System.EventHandler(this.Move_Click);
            // 
            // AttackType
            // 
            this.AttackType.FormattingEnabled = true;
            this.AttackType.Items.AddRange(new object[] {
            "Physical",
            "Magic"});
            this.AttackType.Location = new System.Drawing.Point(1016, 521);
            this.AttackType.Name = "AttackType";
            this.AttackType.Size = new System.Drawing.Size(161, 21);
            this.AttackType.TabIndex = 2;
            this.AttackType.Text = "Pick Attack";
            this.AttackType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ItemPickUp
            // 
            this.ItemPickUp.AutoSize = true;
            this.ItemPickUp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ItemPickUp.Location = new System.Drawing.Point(454, 32);
            this.ItemPickUp.Name = "ItemPickUp";
            this.ItemPickUp.Size = new System.Drawing.Size(70, 13);
            this.ItemPickUp.TabIndex = 3;
            this.ItemPickUp.Text = "\"New Items\" ";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.level.Location = new System.Drawing.Point(1138, 8);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(33, 13);
            this.level.TabIndex = 4;
            this.level.Text = "Level";
            this.level.Click += new System.EventHandler(this.level_Click);
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.speed.Location = new System.Drawing.Point(1139, 32);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(38, 13);
            this.speed.TabIndex = 4;
            this.speed.Text = "Speed";
            this.speed.Click += new System.EventHandler(this.level_Click);
            // 
            // Inteligence
            // 
            this.Inteligence.AutoSize = true;
            this.Inteligence.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Inteligence.Location = new System.Drawing.Point(1137, 59);
            this.Inteligence.Name = "Inteligence";
            this.Inteligence.Size = new System.Drawing.Size(39, 13);
            this.Inteligence.TabIndex = 4;
            this.Inteligence.Text = "Smarts";
            this.Inteligence.Click += new System.EventHandler(this.level_Click);
            // 
            // attack
            // 
            this.attack.AutoSize = true;
            this.attack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.attack.Location = new System.Drawing.Point(1138, 85);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(38, 13);
            this.attack.TabIndex = 4;
            this.attack.Text = "Attack";
            this.attack.Click += new System.EventHandler(this.level_Click);
            // 
            // narraratorSpeech
            // 
            this.narraratorSpeech.Location = new System.Drawing.Point(235, 109);
            this.narraratorSpeech.Name = "narraratorSpeech";
            this.narraratorSpeech.Size = new System.Drawing.Size(873, 349);
            this.narraratorSpeech.TabIndex = 6;
            this.narraratorSpeech.Text = "Narrarator Speech";
            // 
            // scene
            // 
            this.scene.AutoSize = true;
            this.scene.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.scene.Location = new System.Drawing.Point(686, 33);
            this.scene.Name = "scene";
            this.scene.Size = new System.Drawing.Size(97, 13);
            this.scene.TabIndex = 7;
            this.scene.Text = "You are in \"scene\"";
            // 
            // questBox
            // 
            this.questBox.FormattingEnabled = true;
            this.questBox.Items.AddRange(new object[] {
            "Quest 1",
            "Quest 2 ",
            "Quest 3",
            "Quest 4",
            "Quest 5"});
            this.questBox.Location = new System.Drawing.Point(12, 12);
            this.questBox.Name = "questBox";
            this.questBox.Size = new System.Drawing.Size(109, 109);
            this.questBox.TabIndex = 8;
            // 
            // magic
            // 
            this.magic.AutoSize = true;
            this.magic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.magic.Location = new System.Drawing.Point(1138, 112);
            this.magic.Name = "magic";
            this.magic.Size = new System.Drawing.Size(36, 13);
            this.magic.TabIndex = 4;
            this.magic.Text = "Magic";
            this.magic.Click += new System.EventHandler(this.level_Click);
            // 
            // health
            // 
            this.health.BackColor = System.Drawing.Color.Green;
            this.health.Location = new System.Drawing.Point(541, 56);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(82, 49);
            this.health.TabIndex = 9;
            this.health.Text = "Health";
            this.health.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthAmt
            // 
            this.healthAmt.Location = new System.Drawing.Point(629, 71);
            this.healthAmt.Name = "healthAmt";
            this.healthAmt.Size = new System.Drawing.Size(37, 20);
            this.healthAmt.TabIndex = 10;
            this.healthAmt.TextChanged += new System.EventHandler(this.healthAmt_TextChanged);
            // 
            // levelAmt
            // 
            this.levelAmt.Location = new System.Drawing.Point(1187, 5);
            this.levelAmt.Name = "levelAmt";
            this.levelAmt.Size = new System.Drawing.Size(37, 20);
            this.levelAmt.TabIndex = 11;
            // 
            // speedAmt
            // 
            this.speedAmt.Location = new System.Drawing.Point(1187, 30);
            this.speedAmt.Name = "speedAmt";
            this.speedAmt.Size = new System.Drawing.Size(37, 20);
            this.speedAmt.TabIndex = 11;
            // 
            // inteligenceAmt
            // 
            this.inteligenceAmt.Location = new System.Drawing.Point(1187, 56);
            this.inteligenceAmt.Name = "inteligenceAmt";
            this.inteligenceAmt.Size = new System.Drawing.Size(37, 20);
            this.inteligenceAmt.TabIndex = 11;
            // 
            // attackAmt
            // 
            this.attackAmt.Location = new System.Drawing.Point(1187, 82);
            this.attackAmt.Name = "attackAmt";
            this.attackAmt.Size = new System.Drawing.Size(37, 20);
            this.attackAmt.TabIndex = 11;
            // 
            // magicAmt
            // 
            this.magicAmt.Location = new System.Drawing.Point(1187, 108);
            this.magicAmt.Name = "magicAmt";
            this.magicAmt.Size = new System.Drawing.Size(37, 20);
            this.magicAmt.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1313, 604);
            this.Controls.Add(this.magicAmt);
            this.Controls.Add(this.attackAmt);
            this.Controls.Add(this.inteligenceAmt);
            this.Controls.Add(this.speedAmt);
            this.Controls.Add(this.levelAmt);
            this.Controls.Add(this.healthAmt);
            this.Controls.Add(this.health);
            this.Controls.Add(this.questBox);
            this.Controls.Add(this.scene);
            this.Controls.Add(this.narraratorSpeech);
            this.Controls.Add(this.magic);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.Inteligence);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.level);
            this.Controls.Add(this.ItemPickUp);
            this.Controls.Add(this.AttackType);
            this.Controls.Add(this.Move_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Move_Btn;
        private System.Windows.Forms.ComboBox AttackType;
        private System.Windows.Forms.Label ItemPickUp;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label Inteligence;
        private System.Windows.Forms.Label attack;
        private System.Windows.Forms.RichTextBox narraratorSpeech;
        private System.Windows.Forms.Label scene;
        private System.Windows.Forms.CheckedListBox questBox;
        private System.Windows.Forms.Label magic;
        private System.Windows.Forms.Label health;
        private System.Windows.Forms.TextBox healthAmt;
        private System.Windows.Forms.TextBox levelAmt;
        private System.Windows.Forms.TextBox speedAmt;
        private System.Windows.Forms.TextBox inteligenceAmt;
        private System.Windows.Forms.TextBox attackAmt;
        private System.Windows.Forms.TextBox magicAmt;
    }
}

