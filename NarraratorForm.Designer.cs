
namespace rpgForms
{
    partial class NarraratorForm
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
            this.Weapons = new System.Windows.Forms.ListView();
            this.Scene = new System.Windows.Forms.ListView();
            this.Character = new System.Windows.Forms.ListView();
            this.sceneLabel = new System.Windows.Forms.Label();
            this.weaponsLabel = new System.Windows.Forms.Label();
            this.characterLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CreateWeapon = new System.Windows.Forms.TabPage();
            this.createaweaponButton = new System.Windows.Forms.Button();
            this.damagePickerLabel = new System.Windows.Forms.Label();
            this.damagePicker = new System.Windows.Forms.NumericUpDown();
            this.pickWeaponType = new System.Windows.Forms.ComboBox();
            this.CreateVillian = new System.Windows.Forms.TabPage();
            this.createVillianButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.MagicBox = new System.Windows.Forms.TextBox();
            this.LevelBox = new System.Windows.Forms.TextBox();
            this.MaxLifeBox = new System.Windows.Forms.TextBox();
            this.StrengthBox = new System.Windows.Forms.TextBox();
            this.InteligenceBox = new System.Windows.Forms.TextBox();
            this.DexterityBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.maxLife = new System.Windows.Forms.Label();
            this.magic = new System.Windows.Forms.Label();
            this.strength = new System.Windows.Forms.Label();
            this.inteligence = new System.Windows.Forms.Label();
            this.dexterity = new System.Windows.Forms.Label();
            this.CreateScene = new System.Windows.Forms.TabPage();
            this.CreateScene_btn = new System.Windows.Forms.Button();
            this.ChooseScene = new System.Windows.Forms.ComboBox();
            this.StoryConclusion = new System.Windows.Forms.RichTextBox();
            this.StoryIntro = new System.Windows.Forms.RichTextBox();
            this.SceneName = new System.Windows.Forms.TextBox();
            this.StoryTitle = new System.Windows.Forms.TextBox();
            this.QuestsBox = new System.Windows.Forms.GroupBox();
            this.addQuest = new System.Windows.Forms.Button();
            this.TargetBox = new System.Windows.Forms.NumericUpDown();
            this.VillianBox = new System.Windows.Forms.ComboBox();
            this.ChallengeBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.saveConfig = new System.Windows.Forms.Button();
            this.startGame = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.CreateWeapon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.damagePicker)).BeginInit();
            this.CreateVillian.SuspendLayout();
            this.CreateScene.SuspendLayout();
            this.QuestsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TargetBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Weapons
            // 
            this.Weapons.BackColor = System.Drawing.SystemColors.Info;
            this.Weapons.HideSelection = false;
            this.Weapons.Location = new System.Drawing.Point(12, 38);
            this.Weapons.Name = "Weapons";
            this.Weapons.Size = new System.Drawing.Size(214, 131);
            this.Weapons.TabIndex = 0;
            this.Weapons.UseCompatibleStateImageBehavior = false;
            // 
            // Scene
            // 
            this.Scene.BackColor = System.Drawing.SystemColors.Info;
            this.Scene.HideSelection = false;
            this.Scene.Location = new System.Drawing.Point(128, 190);
            this.Scene.Name = "Scene";
            this.Scene.Size = new System.Drawing.Size(214, 131);
            this.Scene.TabIndex = 0;
            this.Scene.UseCompatibleStateImageBehavior = false;
            // 
            // Character
            // 
            this.Character.BackColor = System.Drawing.SystemColors.Info;
            this.Character.HideSelection = false;
            this.Character.Location = new System.Drawing.Point(249, 38);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(214, 131);
            this.Character.TabIndex = 0;
            this.Character.UseCompatibleStateImageBehavior = false;
            // 
            // sceneLabel
            // 
            this.sceneLabel.AutoSize = true;
            this.sceneLabel.BackColor = System.Drawing.Color.LightSlateGray;
            this.sceneLabel.Location = new System.Drawing.Point(218, 174);
            this.sceneLabel.Name = "sceneLabel";
            this.sceneLabel.Size = new System.Drawing.Size(38, 13);
            this.sceneLabel.TabIndex = 1;
            this.sceneLabel.Text = "Scene";
            // 
            // weaponsLabel
            // 
            this.weaponsLabel.AutoSize = true;
            this.weaponsLabel.BackColor = System.Drawing.Color.LightSlateGray;
            this.weaponsLabel.Location = new System.Drawing.Point(98, 22);
            this.weaponsLabel.Name = "weaponsLabel";
            this.weaponsLabel.Size = new System.Drawing.Size(53, 13);
            this.weaponsLabel.TabIndex = 1;
            this.weaponsLabel.Text = "Weapons";
            // 
            // characterLabel
            // 
            this.characterLabel.AutoSize = true;
            this.characterLabel.BackColor = System.Drawing.Color.LightSlateGray;
            this.characterLabel.Location = new System.Drawing.Point(323, 22);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(53, 13);
            this.characterLabel.TabIndex = 1;
            this.characterLabel.Text = "Character";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CreateWeapon);
            this.tabControl1.Controls.Add(this.CreateVillian);
            this.tabControl1.Controls.Add(this.CreateScene);
            this.tabControl1.Location = new System.Drawing.Point(594, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 409);
            this.tabControl1.TabIndex = 2;
            // 
            // CreateWeapon
            // 
            this.CreateWeapon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateWeapon.Controls.Add(this.createaweaponButton);
            this.CreateWeapon.Controls.Add(this.damagePickerLabel);
            this.CreateWeapon.Controls.Add(this.damagePicker);
            this.CreateWeapon.Controls.Add(this.pickWeaponType);
            this.CreateWeapon.Location = new System.Drawing.Point(4, 22);
            this.CreateWeapon.Name = "CreateWeapon";
            this.CreateWeapon.Padding = new System.Windows.Forms.Padding(3);
            this.CreateWeapon.Size = new System.Drawing.Size(726, 383);
            this.CreateWeapon.TabIndex = 0;
            this.CreateWeapon.Text = "Create Weapon";
            // 
            // createaweaponButton
            // 
            this.createaweaponButton.Location = new System.Drawing.Point(150, 153);
            this.createaweaponButton.Name = "createaweaponButton";
            this.createaweaponButton.Size = new System.Drawing.Size(176, 77);
            this.createaweaponButton.TabIndex = 3;
            this.createaweaponButton.Text = "Click to Create";
            this.createaweaponButton.UseVisualStyleBackColor = true;
            this.createaweaponButton.Click += new System.EventHandler(this.createaweaponButton_Click);
            // 
            // damagePickerLabel
            // 
            this.damagePickerLabel.AutoSize = true;
            this.damagePickerLabel.Location = new System.Drawing.Point(213, 65);
            this.damagePickerLabel.Name = "damagePickerLabel";
            this.damagePickerLabel.Size = new System.Drawing.Size(86, 13);
            this.damagePickerLabel.TabIndex = 2;
            this.damagePickerLabel.Text = "Choose Damage";
            // 
            // damagePicker
            // 
            this.damagePicker.Location = new System.Drawing.Point(203, 89);
            this.damagePicker.Name = "damagePicker";
            this.damagePicker.Size = new System.Drawing.Size(210, 20);
            this.damagePicker.TabIndex = 1;
            // 
            // pickWeaponType
            // 
            this.pickWeaponType.FormattingEnabled = true;
            this.pickWeaponType.Items.AddRange(new object[] {
            "Sword",
            "Bow",
            "Stick",
            "Stone"});
            this.pickWeaponType.Location = new System.Drawing.Point(30, 88);
            this.pickWeaponType.Name = "pickWeaponType";
            this.pickWeaponType.Size = new System.Drawing.Size(135, 21);
            this.pickWeaponType.TabIndex = 0;
            this.pickWeaponType.Text = "Pick a Weapon";
            // 
            // CreateVillian
            // 
            this.CreateVillian.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateVillian.Controls.Add(this.createVillianButton);
            this.CreateVillian.Controls.Add(this.NameBox);
            this.CreateVillian.Controls.Add(this.MagicBox);
            this.CreateVillian.Controls.Add(this.LevelBox);
            this.CreateVillian.Controls.Add(this.MaxLifeBox);
            this.CreateVillian.Controls.Add(this.StrengthBox);
            this.CreateVillian.Controls.Add(this.InteligenceBox);
            this.CreateVillian.Controls.Add(this.DexterityBox);
            this.CreateVillian.Controls.Add(this.name);
            this.CreateVillian.Controls.Add(this.level);
            this.CreateVillian.Controls.Add(this.maxLife);
            this.CreateVillian.Controls.Add(this.magic);
            this.CreateVillian.Controls.Add(this.strength);
            this.CreateVillian.Controls.Add(this.inteligence);
            this.CreateVillian.Controls.Add(this.dexterity);
            this.CreateVillian.Location = new System.Drawing.Point(4, 22);
            this.CreateVillian.Name = "CreateVillian";
            this.CreateVillian.Padding = new System.Windows.Forms.Padding(3);
            this.CreateVillian.Size = new System.Drawing.Size(726, 383);
            this.CreateVillian.TabIndex = 1;
            this.CreateVillian.Text = "Create Villian";
            // 
            // createVillianButton
            // 
            this.createVillianButton.Location = new System.Drawing.Point(294, 131);
            this.createVillianButton.Name = "createVillianButton";
            this.createVillianButton.Size = new System.Drawing.Size(86, 77);
            this.createVillianButton.TabIndex = 9;
            this.createVillianButton.Text = "Create Villian";
            this.createVillianButton.UseVisualStyleBackColor = true;
            this.createVillianButton.Click += new System.EventHandler(this.createVillianButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(415, 130);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(149, 20);
            this.NameBox.TabIndex = 8;
            // 
            // MagicBox
            // 
            this.MagicBox.Location = new System.Drawing.Point(336, 73);
            this.MagicBox.Name = "MagicBox";
            this.MagicBox.Size = new System.Drawing.Size(149, 20);
            this.MagicBox.TabIndex = 7;
            // 
            // LevelBox
            // 
            this.LevelBox.Location = new System.Drawing.Point(263, 230);
            this.LevelBox.Name = "LevelBox";
            this.LevelBox.Size = new System.Drawing.Size(149, 20);
            this.LevelBox.TabIndex = 7;
            // 
            // MaxLifeBox
            // 
            this.MaxLifeBox.Location = new System.Drawing.Point(107, 130);
            this.MaxLifeBox.Name = "MaxLifeBox";
            this.MaxLifeBox.Size = new System.Drawing.Size(149, 20);
            this.MaxLifeBox.TabIndex = 7;
            // 
            // StrengthBox
            // 
            this.StrengthBox.Location = new System.Drawing.Point(181, 73);
            this.StrengthBox.Name = "StrengthBox";
            this.StrengthBox.Size = new System.Drawing.Size(149, 20);
            this.StrengthBox.TabIndex = 7;
            // 
            // InteligenceBox
            // 
            this.InteligenceBox.Location = new System.Drawing.Point(491, 73);
            this.InteligenceBox.Name = "InteligenceBox";
            this.InteligenceBox.Size = new System.Drawing.Size(149, 20);
            this.InteligenceBox.TabIndex = 7;
            // 
            // DexterityBox
            // 
            this.DexterityBox.Location = new System.Drawing.Point(26, 73);
            this.DexterityBox.Name = "DexterityBox";
            this.DexterityBox.Size = new System.Drawing.Size(149, 20);
            this.DexterityBox.TabIndex = 7;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(475, 114);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 5;
            this.name.Text = "name";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(321, 214);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(29, 13);
            this.level.TabIndex = 5;
            this.level.Text = "level";
            // 
            // maxLife
            // 
            this.maxLife.AutoSize = true;
            this.maxLife.Location = new System.Drawing.Point(155, 114);
            this.maxLife.Name = "maxLife";
            this.maxLife.Size = new System.Drawing.Size(42, 13);
            this.maxLife.TabIndex = 4;
            this.maxLife.Text = "max life";
            // 
            // magic
            // 
            this.magic.AutoSize = true;
            this.magic.Location = new System.Drawing.Point(377, 57);
            this.magic.Name = "magic";
            this.magic.Size = new System.Drawing.Size(35, 13);
            this.magic.TabIndex = 3;
            this.magic.Text = "magic";
            // 
            // strength
            // 
            this.strength.AutoSize = true;
            this.strength.Location = new System.Drawing.Point(211, 57);
            this.strength.Name = "strength";
            this.strength.Size = new System.Drawing.Size(45, 13);
            this.strength.TabIndex = 2;
            this.strength.Text = "strength";
            // 
            // inteligence
            // 
            this.inteligence.AutoSize = true;
            this.inteligence.Location = new System.Drawing.Point(521, 57);
            this.inteligence.Name = "inteligence";
            this.inteligence.Size = new System.Drawing.Size(58, 13);
            this.inteligence.TabIndex = 1;
            this.inteligence.Text = "inteligence";
            // 
            // dexterity
            // 
            this.dexterity.AutoSize = true;
            this.dexterity.Location = new System.Drawing.Point(56, 57);
            this.dexterity.Name = "dexterity";
            this.dexterity.Size = new System.Drawing.Size(46, 13);
            this.dexterity.TabIndex = 0;
            this.dexterity.Text = "dexterity";
            // 
            // CreateScene
            // 
            this.CreateScene.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateScene.Controls.Add(this.CreateScene_btn);
            this.CreateScene.Controls.Add(this.ChooseScene);
            this.CreateScene.Controls.Add(this.StoryConclusion);
            this.CreateScene.Controls.Add(this.StoryIntro);
            this.CreateScene.Controls.Add(this.SceneName);
            this.CreateScene.Controls.Add(this.StoryTitle);
            this.CreateScene.Controls.Add(this.QuestsBox);
            this.CreateScene.Location = new System.Drawing.Point(4, 22);
            this.CreateScene.Name = "CreateScene";
            this.CreateScene.Size = new System.Drawing.Size(726, 383);
            this.CreateScene.TabIndex = 2;
            this.CreateScene.Text = "Create Scene";
            // 
            // CreateScene_btn
            // 
            this.CreateScene_btn.Location = new System.Drawing.Point(69, 321);
            this.CreateScene_btn.Name = "CreateScene_btn";
            this.CreateScene_btn.Size = new System.Drawing.Size(77, 35);
            this.CreateScene_btn.TabIndex = 4;
            this.CreateScene_btn.Text = "Create Scene";
            this.CreateScene_btn.UseVisualStyleBackColor = true;
            this.CreateScene_btn.Click += new System.EventHandler(this.CreateScene_btn_Click);
            // 
            // ChooseScene
            // 
            this.ChooseScene.FormattingEnabled = true;
            this.ChooseScene.Location = new System.Drawing.Point(41, 281);
            this.ChooseScene.Name = "ChooseScene";
            this.ChooseScene.Size = new System.Drawing.Size(140, 21);
            this.ChooseScene.TabIndex = 3;
            this.ChooseScene.Text = "Pick a Scene";
            // 
            // StoryConclusion
            // 
            this.StoryConclusion.Location = new System.Drawing.Point(41, 248);
            this.StoryConclusion.Name = "StoryConclusion";
            this.StoryConclusion.Size = new System.Drawing.Size(141, 27);
            this.StoryConclusion.TabIndex = 2;
            this.StoryConclusion.Text = "Story Conclusion";
            // 
            // StoryIntro
            // 
            this.StoryIntro.Location = new System.Drawing.Point(41, 215);
            this.StoryIntro.Name = "StoryIntro";
            this.StoryIntro.Size = new System.Drawing.Size(141, 27);
            this.StoryIntro.TabIndex = 2;
            this.StoryIntro.Text = "Story Introduction";
            // 
            // SceneName
            // 
            this.SceneName.Location = new System.Drawing.Point(215, 231);
            this.SceneName.Name = "SceneName";
            this.SceneName.Size = new System.Drawing.Size(140, 20);
            this.SceneName.TabIndex = 1;
            this.SceneName.Text = "Scene Name";
            this.SceneName.TextChanged += new System.EventHandler(this.StoryTitle_TextChanged);
            // 
            // StoryTitle
            // 
            this.StoryTitle.Location = new System.Drawing.Point(41, 189);
            this.StoryTitle.Name = "StoryTitle";
            this.StoryTitle.Size = new System.Drawing.Size(140, 20);
            this.StoryTitle.TabIndex = 1;
            this.StoryTitle.Text = "Story Title";
            this.StoryTitle.TextChanged += new System.EventHandler(this.StoryTitle_TextChanged);
            // 
            // QuestsBox
            // 
            this.QuestsBox.Controls.Add(this.addQuest);
            this.QuestsBox.Controls.Add(this.TargetBox);
            this.QuestsBox.Controls.Add(this.VillianBox);
            this.QuestsBox.Controls.Add(this.ChallengeBox);
            this.QuestsBox.Controls.Add(this.TitleBox);
            this.QuestsBox.Location = new System.Drawing.Point(21, 35);
            this.QuestsBox.Name = "QuestsBox";
            this.QuestsBox.Size = new System.Drawing.Size(289, 130);
            this.QuestsBox.TabIndex = 0;
            this.QuestsBox.TabStop = false;
            this.QuestsBox.Text = "Quests";
            // 
            // addQuest
            // 
            this.addQuest.Location = new System.Drawing.Point(92, 56);
            this.addQuest.Name = "addQuest";
            this.addQuest.Size = new System.Drawing.Size(75, 36);
            this.addQuest.TabIndex = 3;
            this.addQuest.Text = "Add New Quest";
            this.addQuest.UseVisualStyleBackColor = true;
            this.addQuest.Click += new System.EventHandler(this.addQuest_Click);
            // 
            // TargetBox
            // 
            this.TargetBox.Location = new System.Drawing.Point(194, 21);
            this.TargetBox.Name = "TargetBox";
            this.TargetBox.Size = new System.Drawing.Size(78, 20);
            this.TargetBox.TabIndex = 2;
            // 
            // VillianBox
            // 
            this.VillianBox.FormattingEnabled = true;
            this.VillianBox.Location = new System.Drawing.Point(132, 20);
            this.VillianBox.Name = "VillianBox";
            this.VillianBox.Size = new System.Drawing.Size(56, 21);
            this.VillianBox.TabIndex = 1;
            this.VillianBox.Text = "Villian";
            // 
            // ChallengeBox
            // 
            this.ChallengeBox.Location = new System.Drawing.Point(73, 20);
            this.ChallengeBox.Name = "ChallengeBox";
            this.ChallengeBox.Size = new System.Drawing.Size(53, 20);
            this.ChallengeBox.TabIndex = 0;
            this.ChallengeBox.Text = "Challenge";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(14, 20);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(53, 20);
            this.TitleBox.TabIndex = 0;
            this.TitleBox.Text = "Title";
            // 
            // saveConfig
            // 
            this.saveConfig.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveConfig.Location = new System.Drawing.Point(51, 389);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(175, 129);
            this.saveConfig.TabIndex = 3;
            this.saveConfig.Text = "Save Configuration";
            this.saveConfig.UseVisualStyleBackColor = true;
            // 
            // startGame
            // 
            this.startGame.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(272, 389);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(174, 129);
            this.startGame.TabIndex = 3;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // NarraratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1350, 619);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.saveConfig);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.weaponsLabel);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.sceneLabel);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.Scene);
            this.Controls.Add(this.Weapons);
            this.MaximizeBox = false;
            this.Name = "NarraratorForm";
            this.Text = "NarraratorForm";
            this.tabControl1.ResumeLayout(false);
            this.CreateWeapon.ResumeLayout(false);
            this.CreateWeapon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.damagePicker)).EndInit();
            this.CreateVillian.ResumeLayout(false);
            this.CreateVillian.PerformLayout();
            this.CreateScene.ResumeLayout(false);
            this.CreateScene.PerformLayout();
            this.QuestsBox.ResumeLayout(false);
            this.QuestsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TargetBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Weapons;
        private System.Windows.Forms.ListView Scene;
        private System.Windows.Forms.ListView Character;
        private System.Windows.Forms.Label sceneLabel;
        private System.Windows.Forms.Label weaponsLabel;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CreateWeapon;
        private System.Windows.Forms.TabPage CreateVillian;
        private System.Windows.Forms.TabPage CreateScene;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label maxLife;
        private System.Windows.Forms.Label magic;
        private System.Windows.Forms.Label strength;
        private System.Windows.Forms.Label inteligence;
        private System.Windows.Forms.Label dexterity;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox MagicBox;
        private System.Windows.Forms.TextBox MaxLifeBox;
        private System.Windows.Forms.TextBox StrengthBox;
        private System.Windows.Forms.TextBox InteligenceBox;
        private System.Windows.Forms.TextBox DexterityBox;
        private System.Windows.Forms.Button createVillianButton;
        private System.Windows.Forms.Button createaweaponButton;
        private System.Windows.Forms.Label damagePickerLabel;
        private System.Windows.Forms.NumericUpDown damagePicker;
        private System.Windows.Forms.ComboBox pickWeaponType;
        private System.Windows.Forms.Button CreateScene_btn;
        private System.Windows.Forms.ComboBox ChooseScene;
        private System.Windows.Forms.RichTextBox StoryConclusion;
        private System.Windows.Forms.RichTextBox StoryIntro;
        private System.Windows.Forms.TextBox StoryTitle;
        private System.Windows.Forms.GroupBox QuestsBox;
        private System.Windows.Forms.Button addQuest;
        private System.Windows.Forms.NumericUpDown TargetBox;
        private System.Windows.Forms.ComboBox VillianBox;
        private System.Windows.Forms.TextBox ChallengeBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox SceneName;
        private System.Windows.Forms.TextBox LevelBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button saveConfig;
        private System.Windows.Forms.Button startGame;
    }
}