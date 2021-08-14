
namespace rpgForms
{
    partial class CharacterCreation
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
            this.nameText = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.genderText = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.Label();
            this.ageUpDown = new System.Windows.Forms.NumericUpDown();
            this.age = new System.Windows.Forms.Label();
            this.heroType = new System.Windows.Forms.Label();
            this.createAHero = new System.Windows.Forms.Button();
            this.pickAHero = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(76, 98);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(194, 20);
            this.nameText.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.LightSalmon;
            this.name.Location = new System.Drawing.Point(37, 98);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 1;
            this.name.Text = "name";
            // 
            // genderText
            // 
            this.genderText.Location = new System.Drawing.Point(76, 146);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(194, 20);
            this.genderText.TabIndex = 0;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.Color.LightSalmon;
            this.gender.Location = new System.Drawing.Point(30, 146);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(40, 13);
            this.gender.TabIndex = 1;
            this.gender.Text = "gender";
            // 
            // ageUpDown
            // 
            this.ageUpDown.Location = new System.Drawing.Point(76, 192);
            this.ageUpDown.Name = "ageUpDown";
            this.ageUpDown.Size = new System.Drawing.Size(194, 20);
            this.ageUpDown.TabIndex = 2;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.BackColor = System.Drawing.Color.LightSalmon;
            this.age.Location = new System.Drawing.Point(37, 194);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(25, 13);
            this.age.TabIndex = 3;
            this.age.Text = "age";
            // 
            // heroType
            // 
            this.heroType.AutoSize = true;
            this.heroType.BackColor = System.Drawing.Color.LightSalmon;
            this.heroType.Location = new System.Drawing.Point(19, 243);
            this.heroType.Name = "heroType";
            this.heroType.Size = new System.Drawing.Size(51, 13);
            this.heroType.TabIndex = 5;
            this.heroType.Text = "hero type";
            // 
            // createAHero
            // 
            this.createAHero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createAHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAHero.Location = new System.Drawing.Point(341, 148);
            this.createAHero.Name = "createAHero";
            this.createAHero.Size = new System.Drawing.Size(124, 76);
            this.createAHero.TabIndex = 6;
            this.createAHero.Text = "Create A Hero";
            this.createAHero.UseVisualStyleBackColor = false;
            this.createAHero.Click += new System.EventHandler(this.createAHero_Click);
            // 
            // pickAHero
            // 
            this.pickAHero.FormattingEnabled = true;
            this.pickAHero.Items.AddRange(new object[] {
            "Kod",
            "King Piller",
            "Mega Wolf",
            "Dark Elf"});
            this.pickAHero.Location = new System.Drawing.Point(76, 240);
            this.pickAHero.Name = "pickAHero";
            this.pickAHero.Size = new System.Drawing.Size(194, 21);
            this.pickAHero.TabIndex = 7;
            this.pickAHero.Text = "Pick a hero";
            // 
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(652, 393);
            this.Controls.Add(this.pickAHero);
            this.Controls.Add(this.createAHero);
            this.Controls.Add(this.heroType);
            this.Controls.Add(this.age);
            this.Controls.Add(this.ageUpDown);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.name);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.nameText);
            this.Name = "CharacterCreation";
            this.Text = "CharacterCreation";
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox genderText;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.NumericUpDown ageUpDown;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label heroType;
        private System.Windows.Forms.Button createAHero;
        private System.Windows.Forms.ComboBox pickAHero;
    }
}