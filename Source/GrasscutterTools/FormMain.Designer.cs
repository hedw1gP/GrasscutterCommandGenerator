﻿
namespace GrasscutterTools
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TxtCommand = new System.Windows.Forms.TextBox();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.ChkAutoCopy = new System.Windows.Forms.CheckBox();
            this.GrpCommand = new System.Windows.Forms.GroupBox();
            this.BtnInvokeOpenCommand = new System.Windows.Forms.Button();
            this.TCMain = new System.Windows.Forms.TabControl();
            this.TPHome = new System.Windows.Forms.TabPage();
            this.BtnOpenTextMap = new System.Windows.Forms.Button();
            this.BtnOpenGachaBannerEditor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrpSettings = new System.Windows.Forms.GroupBox();
            this.CmbLanguage = new System.Windows.Forms.ComboBox();
            this.LblLanguage = new System.Windows.Forms.Label();
            this.NUDUid = new System.Windows.Forms.NumericUpDown();
            this.ChkIncludeUID = new System.Windows.Forms.CheckBox();
            this.LblDefaultUid = new System.Windows.Forms.Label();
            this.LblAbout = new System.Windows.Forms.Label();
            this.TPCustom = new System.Windows.Forms.TabPage();
            this.BtnExportCustomCommands = new System.Windows.Forms.Button();
            this.BtnLoadCustomCommands = new System.Windows.Forms.Button();
            this.LblCustomName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FLPCustomCommands = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnRemoveCustomCommand = new System.Windows.Forms.Button();
            this.BtnSaveCustomCommand = new System.Windows.Forms.Button();
            this.TxtCustomName = new System.Windows.Forms.TextBox();
            this.TPArtifact = new System.Windows.Forms.TabPage();
            this.LblArtifactName = new System.Windows.Forms.Label();
            this.NUDArtifactStars = new System.Windows.Forms.NumericUpDown();
            this.LblArtifactStars = new System.Windows.Forms.Label();
            this.LblArtifactPart = new System.Windows.Forms.Label();
            this.CmbArtifactPart = new System.Windows.Forms.ComboBox();
            this.CmbArtifactSet = new System.Windows.Forms.ComboBox();
            this.LblArtifactSet = new System.Windows.Forms.Label();
            this.LblArtifactLevelTip = new System.Windows.Forms.Label();
            this.LblAddSubAttr = new System.Windows.Forms.Label();
            this.NUDSubAttributionTimes = new System.Windows.Forms.NumericUpDown();
            this.CmbSubAttributionValue = new System.Windows.Forms.ComboBox();
            this.CmbSubAttribution = new System.Windows.Forms.ComboBox();
            this.LblClearSubAttrCheckedList = new System.Windows.Forms.Label();
            this.ListSubAttributionChecked = new System.Windows.Forms.ListBox();
            this.NUDArtifactLevel = new System.Windows.Forms.NumericUpDown();
            this.LblArtifactLevel = new System.Windows.Forms.Label();
            this.LblSubAttribution = new System.Windows.Forms.Label();
            this.CmbMainAttribution = new System.Windows.Forms.ComboBox();
            this.LblMainAttribution = new System.Windows.Forms.Label();
            this.TPWeapon = new System.Windows.Forms.TabPage();
            this.TxtWeaponFilter = new System.Windows.Forms.TextBox();
            this.LblWeaponDescription = new System.Windows.Forms.Label();
            this.LblWeaponRefinement = new System.Windows.Forms.Label();
            this.LblWeaponAmount = new System.Windows.Forms.Label();
            this.LblWeaponLevel = new System.Windows.Forms.Label();
            this.NUDWeaponRefinement = new System.Windows.Forms.NumericUpDown();
            this.NUDWeaponAmout = new System.Windows.Forms.NumericUpDown();
            this.NUDWeaponLevel = new System.Windows.Forms.NumericUpDown();
            this.ListWeapons = new System.Windows.Forms.ListBox();
            this.TPItem = new System.Windows.Forms.TabPage();
            this.BtnSaveGiveItemLog = new System.Windows.Forms.Button();
            this.BtnRemoveGiveItemLog = new System.Windows.Forms.Button();
            this.GrpGiveItemRecord = new System.Windows.Forms.GroupBox();
            this.ListGiveItemLogs = new System.Windows.Forms.ListBox();
            this.ChkDrop = new System.Windows.Forms.CheckBox();
            this.TxtGameItemFilter = new System.Windows.Forms.TextBox();
            this.ListGameItems = new System.Windows.Forms.ListBox();
            this.LblGameItemAmount = new System.Windows.Forms.Label();
            this.LblGameItemLevel = new System.Windows.Forms.Label();
            this.NUDGameItemAmout = new System.Windows.Forms.NumericUpDown();
            this.NUDGameItemLevel = new System.Windows.Forms.NumericUpDown();
            this.LblGiveCommandDescription = new System.Windows.Forms.Label();
            this.TPAvatar = new System.Windows.Forms.TabPage();
            this.LblAvatarGenWarning = new System.Windows.Forms.Label();
            this.ImgAvatar = new System.Windows.Forms.PictureBox();
            this.LblAvatar = new System.Windows.Forms.Label();
            this.LblLevel = new System.Windows.Forms.Label();
            this.NUDAvatarLevel = new System.Windows.Forms.NumericUpDown();
            this.CmbAvatar = new System.Windows.Forms.ComboBox();
            this.TPSpawn = new System.Windows.Forms.TabPage();
            this.BtnSaveSpawnLog = new System.Windows.Forms.Button();
            this.BtnRemoveSpawnLog = new System.Windows.Forms.Button();
            this.GrpSpawnRecord = new System.Windows.Forms.GroupBox();
            this.ListSpawnLogs = new System.Windows.Forms.ListBox();
            this.GrpEntityType = new System.Windows.Forms.GroupBox();
            this.RbEntityOrnament = new System.Windows.Forms.RadioButton();
            this.RbEntityAnimal = new System.Windows.Forms.RadioButton();
            this.RbEntityNPC = new System.Windows.Forms.RadioButton();
            this.RbEntityMonster = new System.Windows.Forms.RadioButton();
            this.LblSpawnDescription = new System.Windows.Forms.Label();
            this.LblEntityAmount = new System.Windows.Forms.Label();
            this.LblEntityLevel = new System.Windows.Forms.Label();
            this.NUDEntityAmout = new System.Windows.Forms.NumericUpDown();
            this.NUDEntityLevel = new System.Windows.Forms.NumericUpDown();
            this.TxtEntityFilter = new System.Windows.Forms.TextBox();
            this.ListEntity = new System.Windows.Forms.ListBox();
            this.TPScene = new System.Windows.Forms.TabPage();
            this.CmbClimateType = new System.Windows.Forms.ComboBox();
            this.LblClimateType = new System.Windows.Forms.Label();
            this.LblSceneDescription = new System.Windows.Forms.Label();
            this.ListScenes = new System.Windows.Forms.ListBox();
            this.TPStats = new System.Windows.Forms.TabPage();
            this.GrpSetStats = new System.Windows.Forms.GroupBox();
            this.LblStatTip = new System.Windows.Forms.Label();
            this.LblStatPercent = new System.Windows.Forms.Label();
            this.NUDStat = new System.Windows.Forms.NumericUpDown();
            this.CmbStat = new System.Windows.Forms.ComboBox();
            this.GrpTalentLevel = new System.Windows.Forms.GroupBox();
            this.LnkTalentE = new System.Windows.Forms.LinkLabel();
            this.LnkTalentQ = new System.Windows.Forms.LinkLabel();
            this.LnkTalentNormalATK = new System.Windows.Forms.LinkLabel();
            this.NUDTalentLevel = new System.Windows.Forms.NumericUpDown();
            this.LblStatsDescription = new System.Windows.Forms.Label();
            this.TPManage = new System.Windows.Forms.TabPage();
            this.GrpAccount = new System.Windows.Forms.GroupBox();
            this.ChkAccountSetUid = new System.Windows.Forms.CheckBox();
            this.NUDAccountUid = new System.Windows.Forms.NumericUpDown();
            this.BtnDeleteAccount = new System.Windows.Forms.Button();
            this.BtnCreateAccount = new System.Windows.Forms.Button();
            this.LblAccountUserName = new System.Windows.Forms.Label();
            this.TxtAccountUserName = new System.Windows.Forms.TextBox();
            this.GrpPermission = new System.Windows.Forms.GroupBox();
            this.CmbPerm = new System.Windows.Forms.ComboBox();
            this.NUDPermUID = new System.Windows.Forms.NumericUpDown();
            this.BtmPermRemove = new System.Windows.Forms.Button();
            this.BtnPermAdd = new System.Windows.Forms.Button();
            this.LblPerm = new System.Windows.Forms.Label();
            this.LblPermUID = new System.Windows.Forms.Label();
            this.TPAbout = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LnkGithub = new System.Windows.Forms.LinkLabel();
            this.LblSupportDescription = new System.Windows.Forms.Label();
            this.TPRemoteCall = new System.Windows.Forms.TabPage();
            this.GrpServerStatus = new System.Windows.Forms.GroupBox();
            this.LnkOpenCommandLabel = new System.Windows.Forms.LinkLabel();
            this.LblOpenCommandSupport = new System.Windows.Forms.Label();
            this.LblServerVersion = new System.Windows.Forms.Label();
            this.LblPlayerCount = new System.Windows.Forms.Label();
            this.LblServerVersionLabel = new System.Windows.Forms.Label();
            this.LblPlayerCountLabel = new System.Windows.Forms.Label();
            this.GrpRemoteCommand = new System.Windows.Forms.GroupBox();
            this.LnkRCHelp = new System.Windows.Forms.LinkLabel();
            this.BtnConnectOpenCommand = new System.Windows.Forms.Button();
            this.BtnSendVerificationCode = new System.Windows.Forms.Button();
            this.LblRemotePlayerId = new System.Windows.Forms.Label();
            this.NUDVerificationCode = new System.Windows.Forms.NumericUpDown();
            this.LblVerificationCode = new System.Windows.Forms.Label();
            this.NUDRemotePlayerId = new System.Windows.Forms.NumericUpDown();
            this.TxtHost = new System.Windows.Forms.TextBox();
            this.BtnQueryServerStatus = new System.Windows.Forms.Button();
            this.LblHost = new System.Windows.Forms.Label();
            this.TTip = new System.Windows.Forms.ToolTip(this.components);
            this.GrpCommand.SuspendLayout();
            this.TCMain.SuspendLayout();
            this.TPHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDUid)).BeginInit();
            this.TPCustom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TPArtifact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDArtifactStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSubAttributionTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDArtifactLevel)).BeginInit();
            this.TPWeapon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDWeaponRefinement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDWeaponAmout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDWeaponLevel)).BeginInit();
            this.TPItem.SuspendLayout();
            this.GrpGiveItemRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDGameItemAmout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDGameItemLevel)).BeginInit();
            this.TPAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAvatarLevel)).BeginInit();
            this.TPSpawn.SuspendLayout();
            this.GrpSpawnRecord.SuspendLayout();
            this.GrpEntityType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEntityAmout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEntityLevel)).BeginInit();
            this.TPScene.SuspendLayout();
            this.TPStats.SuspendLayout();
            this.GrpSetStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDStat)).BeginInit();
            this.GrpTalentLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTalentLevel)).BeginInit();
            this.TPManage.SuspendLayout();
            this.GrpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAccountUid)).BeginInit();
            this.GrpPermission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPermUID)).BeginInit();
            this.TPAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TPRemoteCall.SuspendLayout();
            this.GrpServerStatus.SuspendLayout();
            this.GrpRemoteCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDVerificationCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRemotePlayerId)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCommand
            // 
            resources.ApplyResources(this.TxtCommand, "TxtCommand");
            this.TxtCommand.Name = "TxtCommand";
            this.TTip.SetToolTip(this.TxtCommand, resources.GetString("TxtCommand.ToolTip"));
            // 
            // BtnCopy
            // 
            resources.ApplyResources(this.BtnCopy, "BtnCopy");
            this.BtnCopy.Name = "BtnCopy";
            this.TTip.SetToolTip(this.BtnCopy, resources.GetString("BtnCopy.ToolTip"));
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // ChkAutoCopy
            // 
            resources.ApplyResources(this.ChkAutoCopy, "ChkAutoCopy");
            this.ChkAutoCopy.Name = "ChkAutoCopy";
            this.TTip.SetToolTip(this.ChkAutoCopy, resources.GetString("ChkAutoCopy.ToolTip"));
            this.ChkAutoCopy.UseVisualStyleBackColor = true;
            // 
            // GrpCommand
            // 
            resources.ApplyResources(this.GrpCommand, "GrpCommand");
            this.GrpCommand.Controls.Add(this.BtnInvokeOpenCommand);
            this.GrpCommand.Controls.Add(this.BtnCopy);
            this.GrpCommand.Controls.Add(this.ChkAutoCopy);
            this.GrpCommand.Controls.Add(this.TxtCommand);
            this.GrpCommand.Name = "GrpCommand";
            this.GrpCommand.TabStop = false;
            this.TTip.SetToolTip(this.GrpCommand, resources.GetString("GrpCommand.ToolTip"));
            // 
            // BtnInvokeOpenCommand
            // 
            resources.ApplyResources(this.BtnInvokeOpenCommand, "BtnInvokeOpenCommand");
            this.BtnInvokeOpenCommand.Name = "BtnInvokeOpenCommand";
            this.TTip.SetToolTip(this.BtnInvokeOpenCommand, resources.GetString("BtnInvokeOpenCommand.ToolTip"));
            this.BtnInvokeOpenCommand.UseVisualStyleBackColor = true;
            this.BtnInvokeOpenCommand.Click += new System.EventHandler(this.BtnInvokeOpenCommand_Click);
            // 
            // TCMain
            // 
            resources.ApplyResources(this.TCMain, "TCMain");
            this.TCMain.Controls.Add(this.TPHome);
            this.TCMain.Controls.Add(this.TPCustom);
            this.TCMain.Controls.Add(this.TPArtifact);
            this.TCMain.Controls.Add(this.TPWeapon);
            this.TCMain.Controls.Add(this.TPItem);
            this.TCMain.Controls.Add(this.TPAvatar);
            this.TCMain.Controls.Add(this.TPSpawn);
            this.TCMain.Controls.Add(this.TPScene);
            this.TCMain.Controls.Add(this.TPStats);
            this.TCMain.Controls.Add(this.TPManage);
            this.TCMain.Controls.Add(this.TPAbout);
            this.TCMain.Controls.Add(this.TPRemoteCall);
            this.TCMain.Name = "TCMain";
            this.TCMain.SelectedIndex = 0;
            this.TTip.SetToolTip(this.TCMain, resources.GetString("TCMain.ToolTip"));
            // 
            // TPHome
            // 
            resources.ApplyResources(this.TPHome, "TPHome");
            this.TPHome.Controls.Add(this.BtnOpenTextMap);
            this.TPHome.Controls.Add(this.BtnOpenGachaBannerEditor);
            this.TPHome.Controls.Add(this.pictureBox1);
            this.TPHome.Controls.Add(this.GrpSettings);
            this.TPHome.Controls.Add(this.LblAbout);
            this.TPHome.Name = "TPHome";
            this.TTip.SetToolTip(this.TPHome, resources.GetString("TPHome.ToolTip"));
            this.TPHome.UseVisualStyleBackColor = true;
            // 
            // BtnOpenTextMap
            // 
            resources.ApplyResources(this.BtnOpenTextMap, "BtnOpenTextMap");
            this.BtnOpenTextMap.Name = "BtnOpenTextMap";
            this.TTip.SetToolTip(this.BtnOpenTextMap, resources.GetString("BtnOpenTextMap.ToolTip"));
            this.BtnOpenTextMap.UseVisualStyleBackColor = true;
            this.BtnOpenTextMap.Click += new System.EventHandler(this.BtnOpenTextMap_Click);
            // 
            // BtnOpenGachaBannerEditor
            // 
            resources.ApplyResources(this.BtnOpenGachaBannerEditor, "BtnOpenGachaBannerEditor");
            this.BtnOpenGachaBannerEditor.Name = "BtnOpenGachaBannerEditor";
            this.TTip.SetToolTip(this.BtnOpenGachaBannerEditor, resources.GetString("BtnOpenGachaBannerEditor.ToolTip"));
            this.BtnOpenGachaBannerEditor.UseVisualStyleBackColor = true;
            this.BtnOpenGachaBannerEditor.Click += new System.EventHandler(this.BtnOpenGachaBannerEditor_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::GrasscutterTools.Properties.Resources.ImgIconGrasscutter;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.TTip.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // GrpSettings
            // 
            resources.ApplyResources(this.GrpSettings, "GrpSettings");
            this.GrpSettings.Controls.Add(this.CmbLanguage);
            this.GrpSettings.Controls.Add(this.LblLanguage);
            this.GrpSettings.Controls.Add(this.NUDUid);
            this.GrpSettings.Controls.Add(this.ChkIncludeUID);
            this.GrpSettings.Controls.Add(this.LblDefaultUid);
            this.GrpSettings.Name = "GrpSettings";
            this.GrpSettings.TabStop = false;
            this.TTip.SetToolTip(this.GrpSettings, resources.GetString("GrpSettings.ToolTip"));
            // 
            // CmbLanguage
            // 
            resources.ApplyResources(this.CmbLanguage, "CmbLanguage");
            this.CmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLanguage.FormattingEnabled = true;
            this.CmbLanguage.Name = "CmbLanguage";
            this.TTip.SetToolTip(this.CmbLanguage, resources.GetString("CmbLanguage.ToolTip"));
            this.CmbLanguage.SelectedIndexChanged += new System.EventHandler(this.CmbLanguage_SelectedIndexChanged);
            // 
            // LblLanguage
            // 
            resources.ApplyResources(this.LblLanguage, "LblLanguage");
            this.LblLanguage.Name = "LblLanguage";
            this.TTip.SetToolTip(this.LblLanguage, resources.GetString("LblLanguage.ToolTip"));
            // 
            // NUDUid
            // 
            resources.ApplyResources(this.NUDUid, "NUDUid");
            this.NUDUid.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDUid.Name = "NUDUid";
            this.TTip.SetToolTip(this.NUDUid, resources.GetString("NUDUid.ToolTip"));
            this.NUDUid.Value = new decimal(new int[] {
            10001,
            0,
            0,
            0});
            // 
            // ChkIncludeUID
            // 
            resources.ApplyResources(this.ChkIncludeUID, "ChkIncludeUID");
            this.ChkIncludeUID.Name = "ChkIncludeUID";
            this.TTip.SetToolTip(this.ChkIncludeUID, resources.GetString("ChkIncludeUID.ToolTip"));
            this.ChkIncludeUID.UseVisualStyleBackColor = true;
            // 
            // LblDefaultUid
            // 
            resources.ApplyResources(this.LblDefaultUid, "LblDefaultUid");
            this.LblDefaultUid.Name = "LblDefaultUid";
            this.TTip.SetToolTip(this.LblDefaultUid, resources.GetString("LblDefaultUid.ToolTip"));
            // 
            // LblAbout
            // 
            resources.ApplyResources(this.LblAbout, "LblAbout");
            this.LblAbout.Name = "LblAbout";
            this.TTip.SetToolTip(this.LblAbout, resources.GetString("LblAbout.ToolTip"));
            // 
            // TPCustom
            // 
            resources.ApplyResources(this.TPCustom, "TPCustom");
            this.TPCustom.Controls.Add(this.BtnExportCustomCommands);
            this.TPCustom.Controls.Add(this.BtnLoadCustomCommands);
            this.TPCustom.Controls.Add(this.LblCustomName);
            this.TPCustom.Controls.Add(this.groupBox1);
            this.TPCustom.Controls.Add(this.BtnRemoveCustomCommand);
            this.TPCustom.Controls.Add(this.BtnSaveCustomCommand);
            this.TPCustom.Controls.Add(this.TxtCustomName);
            this.TPCustom.Name = "TPCustom";
            this.TTip.SetToolTip(this.TPCustom, resources.GetString("TPCustom.ToolTip"));
            this.TPCustom.UseVisualStyleBackColor = true;
            // 
            // BtnExportCustomCommands
            // 
            resources.ApplyResources(this.BtnExportCustomCommands, "BtnExportCustomCommands");
            this.BtnExportCustomCommands.Name = "BtnExportCustomCommands";
            this.TTip.SetToolTip(this.BtnExportCustomCommands, resources.GetString("BtnExportCustomCommands.ToolTip"));
            this.BtnExportCustomCommands.UseVisualStyleBackColor = true;
            this.BtnExportCustomCommands.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnLoadCustomCommands
            // 
            resources.ApplyResources(this.BtnLoadCustomCommands, "BtnLoadCustomCommands");
            this.BtnLoadCustomCommands.Name = "BtnLoadCustomCommands";
            this.TTip.SetToolTip(this.BtnLoadCustomCommands, resources.GetString("BtnLoadCustomCommands.ToolTip"));
            this.BtnLoadCustomCommands.UseVisualStyleBackColor = true;
            this.BtnLoadCustomCommands.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // LblCustomName
            // 
            resources.ApplyResources(this.LblCustomName, "LblCustomName");
            this.LblCustomName.Name = "LblCustomName";
            this.TTip.SetToolTip(this.LblCustomName, resources.GetString("LblCustomName.ToolTip"));
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.FLPCustomCommands);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.TTip.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // FLPCustomCommands
            // 
            resources.ApplyResources(this.FLPCustomCommands, "FLPCustomCommands");
            this.FLPCustomCommands.Name = "FLPCustomCommands";
            this.TTip.SetToolTip(this.FLPCustomCommands, resources.GetString("FLPCustomCommands.ToolTip"));
            // 
            // BtnRemoveCustomCommand
            // 
            resources.ApplyResources(this.BtnRemoveCustomCommand, "BtnRemoveCustomCommand");
            this.BtnRemoveCustomCommand.Name = "BtnRemoveCustomCommand";
            this.TTip.SetToolTip(this.BtnRemoveCustomCommand, resources.GetString("BtnRemoveCustomCommand.ToolTip"));
            this.BtnRemoveCustomCommand.UseVisualStyleBackColor = true;
            this.BtnRemoveCustomCommand.Click += new System.EventHandler(this.BtnRemoveCustomCommand_Click);
            // 
            // BtnSaveCustomCommand
            // 
            resources.ApplyResources(this.BtnSaveCustomCommand, "BtnSaveCustomCommand");
            this.BtnSaveCustomCommand.Name = "BtnSaveCustomCommand";
            this.TTip.SetToolTip(this.BtnSaveCustomCommand, resources.GetString("BtnSaveCustomCommand.ToolTip"));
            this.BtnSaveCustomCommand.UseVisualStyleBackColor = true;
            this.BtnSaveCustomCommand.Click += new System.EventHandler(this.BtnSaveCustomCommand_Click);
            // 
            // TxtCustomName
            // 
            resources.ApplyResources(this.TxtCustomName, "TxtCustomName");
            this.TxtCustomName.Name = "TxtCustomName";
            this.TTip.SetToolTip(this.TxtCustomName, resources.GetString("TxtCustomName.ToolTip"));
            // 
            // TPArtifact
            // 
            resources.ApplyResources(this.TPArtifact, "TPArtifact");
            this.TPArtifact.Controls.Add(this.LblArtifactName);
            this.TPArtifact.Controls.Add(this.NUDArtifactStars);
            this.TPArtifact.Controls.Add(this.LblArtifactStars);
            this.TPArtifact.Controls.Add(this.LblArtifactPart);
            this.TPArtifact.Controls.Add(this.CmbArtifactPart);
            this.TPArtifact.Controls.Add(this.CmbArtifactSet);
            this.TPArtifact.Controls.Add(this.LblArtifactSet);
            this.TPArtifact.Controls.Add(this.LblArtifactLevelTip);
            this.TPArtifact.Controls.Add(this.LblAddSubAttr);
            this.TPArtifact.Controls.Add(this.NUDSubAttributionTimes);
            this.TPArtifact.Controls.Add(this.CmbSubAttributionValue);
            this.TPArtifact.Controls.Add(this.CmbSubAttribution);
            this.TPArtifact.Controls.Add(this.LblClearSubAttrCheckedList);
            this.TPArtifact.Controls.Add(this.ListSubAttributionChecked);
            this.TPArtifact.Controls.Add(this.NUDArtifactLevel);
            this.TPArtifact.Controls.Add(this.LblArtifactLevel);
            this.TPArtifact.Controls.Add(this.LblSubAttribution);
            this.TPArtifact.Controls.Add(this.CmbMainAttribution);
            this.TPArtifact.Controls.Add(this.LblMainAttribution);
            this.TPArtifact.Name = "TPArtifact";
            this.TTip.SetToolTip(this.TPArtifact, resources.GetString("TPArtifact.ToolTip"));
            this.TPArtifact.UseVisualStyleBackColor = true;
            // 
            // LblArtifactName
            // 
            resources.ApplyResources(this.LblArtifactName, "LblArtifactName");
            this.LblArtifactName.Name = "LblArtifactName";
            this.TTip.SetToolTip(this.LblArtifactName, resources.GetString("LblArtifactName.ToolTip"));
            // 
            // NUDArtifactStars
            // 
            resources.ApplyResources(this.NUDArtifactStars, "NUDArtifactStars");
            this.NUDArtifactStars.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUDArtifactStars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDArtifactStars.Name = "NUDArtifactStars";
            this.TTip.SetToolTip(this.NUDArtifactStars, resources.GetString("NUDArtifactStars.ToolTip"));
            this.NUDArtifactStars.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUDArtifactStars.ValueChanged += new System.EventHandler(this.ArtifactInputChanged);
            // 
            // LblArtifactStars
            // 
            resources.ApplyResources(this.LblArtifactStars, "LblArtifactStars");
            this.LblArtifactStars.Name = "LblArtifactStars";
            this.TTip.SetToolTip(this.LblArtifactStars, resources.GetString("LblArtifactStars.ToolTip"));
            // 
            // LblArtifactPart
            // 
            resources.ApplyResources(this.LblArtifactPart, "LblArtifactPart");
            this.LblArtifactPart.Name = "LblArtifactPart";
            this.TTip.SetToolTip(this.LblArtifactPart, resources.GetString("LblArtifactPart.ToolTip"));
            // 
            // CmbArtifactPart
            // 
            resources.ApplyResources(this.CmbArtifactPart, "CmbArtifactPart");
            this.CmbArtifactPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbArtifactPart.DropDownWidth = 125;
            this.CmbArtifactPart.FormattingEnabled = true;
            this.CmbArtifactPart.Name = "CmbArtifactPart";
            this.TTip.SetToolTip(this.CmbArtifactPart, resources.GetString("CmbArtifactPart.ToolTip"));
            this.CmbArtifactPart.SelectedIndexChanged += new System.EventHandler(this.CmbArtifactPart_SelectedIndexChanged);
            // 
            // CmbArtifactSet
            // 
            resources.ApplyResources(this.CmbArtifactSet, "CmbArtifactSet");
            this.CmbArtifactSet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbArtifactSet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbArtifactSet.FormattingEnabled = true;
            this.CmbArtifactSet.Name = "CmbArtifactSet";
            this.TTip.SetToolTip(this.CmbArtifactSet, resources.GetString("CmbArtifactSet.ToolTip"));
            this.CmbArtifactSet.SelectedIndexChanged += new System.EventHandler(this.CmbArtifactSet_SelectedIndexChanged);
            // 
            // LblArtifactSet
            // 
            resources.ApplyResources(this.LblArtifactSet, "LblArtifactSet");
            this.LblArtifactSet.Name = "LblArtifactSet";
            this.TTip.SetToolTip(this.LblArtifactSet, resources.GetString("LblArtifactSet.ToolTip"));
            // 
            // LblArtifactLevelTip
            // 
            resources.ApplyResources(this.LblArtifactLevelTip, "LblArtifactLevelTip");
            this.LblArtifactLevelTip.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblArtifactLevelTip.Name = "LblArtifactLevelTip";
            this.TTip.SetToolTip(this.LblArtifactLevelTip, resources.GetString("LblArtifactLevelTip.ToolTip"));
            // 
            // LblAddSubAttr
            // 
            resources.ApplyResources(this.LblAddSubAttr, "LblAddSubAttr");
            this.LblAddSubAttr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblAddSubAttr.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblAddSubAttr.Name = "LblAddSubAttr";
            this.TTip.SetToolTip(this.LblAddSubAttr, resources.GetString("LblAddSubAttr.ToolTip"));
            this.LblAddSubAttr.Click += new System.EventHandler(this.LblAddSubAttr_Click);
            // 
            // NUDSubAttributionTimes
            // 
            resources.ApplyResources(this.NUDSubAttributionTimes, "NUDSubAttributionTimes");
            this.NUDSubAttributionTimes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDSubAttributionTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDSubAttributionTimes.Name = "NUDSubAttributionTimes";
            this.TTip.SetToolTip(this.NUDSubAttributionTimes, resources.GetString("NUDSubAttributionTimes.ToolTip"));
            this.NUDSubAttributionTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CmbSubAttributionValue
            // 
            resources.ApplyResources(this.CmbSubAttributionValue, "CmbSubAttributionValue");
            this.CmbSubAttributionValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSubAttributionValue.FormattingEnabled = true;
            this.CmbSubAttributionValue.Name = "CmbSubAttributionValue";
            this.TTip.SetToolTip(this.CmbSubAttributionValue, resources.GetString("CmbSubAttributionValue.ToolTip"));
            // 
            // CmbSubAttribution
            // 
            resources.ApplyResources(this.CmbSubAttribution, "CmbSubAttribution");
            this.CmbSubAttribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSubAttribution.FormattingEnabled = true;
            this.CmbSubAttribution.Name = "CmbSubAttribution";
            this.TTip.SetToolTip(this.CmbSubAttribution, resources.GetString("CmbSubAttribution.ToolTip"));
            this.CmbSubAttribution.SelectedIndexChanged += new System.EventHandler(this.CmbSubAttribution_SelectedIndexChanged);
            // 
            // LblClearSubAttrCheckedList
            // 
            resources.ApplyResources(this.LblClearSubAttrCheckedList, "LblClearSubAttrCheckedList");
            this.LblClearSubAttrCheckedList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblClearSubAttrCheckedList.Name = "LblClearSubAttrCheckedList";
            this.TTip.SetToolTip(this.LblClearSubAttrCheckedList, resources.GetString("LblClearSubAttrCheckedList.ToolTip"));
            this.LblClearSubAttrCheckedList.Click += new System.EventHandler(this.LblClearSubAttrCheckedList_Click);
            // 
            // ListSubAttributionChecked
            // 
            resources.ApplyResources(this.ListSubAttributionChecked, "ListSubAttributionChecked");
            this.ListSubAttributionChecked.FormattingEnabled = true;
            this.ListSubAttributionChecked.Name = "ListSubAttributionChecked";
            this.TTip.SetToolTip(this.ListSubAttributionChecked, resources.GetString("ListSubAttributionChecked.ToolTip"));
            this.ListSubAttributionChecked.SelectedIndexChanged += new System.EventHandler(this.ListSubAttributionChecked_SelectedIndexChanged);
            // 
            // NUDArtifactLevel
            // 
            resources.ApplyResources(this.NUDArtifactLevel, "NUDArtifactLevel");
            this.NUDArtifactLevel.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.NUDArtifactLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDArtifactLevel.Name = "NUDArtifactLevel";
            this.TTip.SetToolTip(this.NUDArtifactLevel, resources.GetString("NUDArtifactLevel.ToolTip"));
            this.NUDArtifactLevel.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.NUDArtifactLevel.ValueChanged += new System.EventHandler(this.ArtifactInputChanged);
            // 
            // LblArtifactLevel
            // 
            resources.ApplyResources(this.LblArtifactLevel, "LblArtifactLevel");
            this.LblArtifactLevel.Name = "LblArtifactLevel";
            this.TTip.SetToolTip(this.LblArtifactLevel, resources.GetString("LblArtifactLevel.ToolTip"));
            // 
            // LblSubAttribution
            // 
            resources.ApplyResources(this.LblSubAttribution, "LblSubAttribution");
            this.LblSubAttribution.Name = "LblSubAttribution";
            this.TTip.SetToolTip(this.LblSubAttribution, resources.GetString("LblSubAttribution.ToolTip"));
            // 
            // CmbMainAttribution
            // 
            resources.ApplyResources(this.CmbMainAttribution, "CmbMainAttribution");
            this.CmbMainAttribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMainAttribution.FormattingEnabled = true;
            this.CmbMainAttribution.Name = "CmbMainAttribution";
            this.TTip.SetToolTip(this.CmbMainAttribution, resources.GetString("CmbMainAttribution.ToolTip"));
            this.CmbMainAttribution.SelectedIndexChanged += new System.EventHandler(this.ArtifactInputChanged);
            // 
            // LblMainAttribution
            // 
            resources.ApplyResources(this.LblMainAttribution, "LblMainAttribution");
            this.LblMainAttribution.Name = "LblMainAttribution";
            this.TTip.SetToolTip(this.LblMainAttribution, resources.GetString("LblMainAttribution.ToolTip"));
            // 
            // TPWeapon
            // 
            resources.ApplyResources(this.TPWeapon, "TPWeapon");
            this.TPWeapon.Controls.Add(this.TxtWeaponFilter);
            this.TPWeapon.Controls.Add(this.LblWeaponDescription);
            this.TPWeapon.Controls.Add(this.LblWeaponRefinement);
            this.TPWeapon.Controls.Add(this.LblWeaponAmount);
            this.TPWeapon.Controls.Add(this.LblWeaponLevel);
            this.TPWeapon.Controls.Add(this.NUDWeaponRefinement);
            this.TPWeapon.Controls.Add(this.NUDWeaponAmout);
            this.TPWeapon.Controls.Add(this.NUDWeaponLevel);
            this.TPWeapon.Controls.Add(this.ListWeapons);
            this.TPWeapon.Name = "TPWeapon";
            this.TTip.SetToolTip(this.TPWeapon, resources.GetString("TPWeapon.ToolTip"));
            this.TPWeapon.UseVisualStyleBackColor = true;
            // 
            // TxtWeaponFilter
            // 
            resources.ApplyResources(this.TxtWeaponFilter, "TxtWeaponFilter");
            this.TxtWeaponFilter.Name = "TxtWeaponFilter";
            this.TTip.SetToolTip(this.TxtWeaponFilter, resources.GetString("TxtWeaponFilter.ToolTip"));
            this.TxtWeaponFilter.TextChanged += new System.EventHandler(this.TxtWeaponFilter_TextChanged);
            // 
            // LblWeaponDescription
            // 
            resources.ApplyResources(this.LblWeaponDescription, "LblWeaponDescription");
            this.LblWeaponDescription.Name = "LblWeaponDescription";
            this.TTip.SetToolTip(this.LblWeaponDescription, resources.GetString("LblWeaponDescription.ToolTip"));
            // 
            // LblWeaponRefinement
            // 
            resources.ApplyResources(this.LblWeaponRefinement, "LblWeaponRefinement");
            this.LblWeaponRefinement.Name = "LblWeaponRefinement";
            this.TTip.SetToolTip(this.LblWeaponRefinement, resources.GetString("LblWeaponRefinement.ToolTip"));
            // 
            // LblWeaponAmount
            // 
            resources.ApplyResources(this.LblWeaponAmount, "LblWeaponAmount");
            this.LblWeaponAmount.Name = "LblWeaponAmount";
            this.TTip.SetToolTip(this.LblWeaponAmount, resources.GetString("LblWeaponAmount.ToolTip"));
            // 
            // LblWeaponLevel
            // 
            resources.ApplyResources(this.LblWeaponLevel, "LblWeaponLevel");
            this.LblWeaponLevel.Name = "LblWeaponLevel";
            this.TTip.SetToolTip(this.LblWeaponLevel, resources.GetString("LblWeaponLevel.ToolTip"));
            // 
            // NUDWeaponRefinement
            // 
            resources.ApplyResources(this.NUDWeaponRefinement, "NUDWeaponRefinement");
            this.NUDWeaponRefinement.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUDWeaponRefinement.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDWeaponRefinement.Name = "NUDWeaponRefinement";
            this.TTip.SetToolTip(this.NUDWeaponRefinement, resources.GetString("NUDWeaponRefinement.ToolTip"));
            this.NUDWeaponRefinement.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDWeaponRefinement.ValueChanged += new System.EventHandler(this.WeaponValueChanged);
            // 
            // NUDWeaponAmout
            // 
            resources.ApplyResources(this.NUDWeaponAmout, "NUDWeaponAmout");
            this.NUDWeaponAmout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDWeaponAmout.Name = "NUDWeaponAmout";
            this.TTip.SetToolTip(this.NUDWeaponAmout, resources.GetString("NUDWeaponAmout.ToolTip"));
            this.NUDWeaponAmout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDWeaponAmout.ValueChanged += new System.EventHandler(this.WeaponValueChanged);
            // 
            // NUDWeaponLevel
            // 
            resources.ApplyResources(this.NUDWeaponLevel, "NUDWeaponLevel");
            this.NUDWeaponLevel.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.NUDWeaponLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDWeaponLevel.Name = "NUDWeaponLevel";
            this.TTip.SetToolTip(this.NUDWeaponLevel, resources.GetString("NUDWeaponLevel.ToolTip"));
            this.NUDWeaponLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDWeaponLevel.ValueChanged += new System.EventHandler(this.WeaponValueChanged);
            // 
            // ListWeapons
            // 
            resources.ApplyResources(this.ListWeapons, "ListWeapons");
            this.ListWeapons.FormattingEnabled = true;
            this.ListWeapons.Name = "ListWeapons";
            this.TTip.SetToolTip(this.ListWeapons, resources.GetString("ListWeapons.ToolTip"));
            this.ListWeapons.SelectedIndexChanged += new System.EventHandler(this.WeaponValueChanged);
            // 
            // TPItem
            // 
            resources.ApplyResources(this.TPItem, "TPItem");
            this.TPItem.Controls.Add(this.BtnSaveGiveItemLog);
            this.TPItem.Controls.Add(this.BtnRemoveGiveItemLog);
            this.TPItem.Controls.Add(this.GrpGiveItemRecord);
            this.TPItem.Controls.Add(this.ChkDrop);
            this.TPItem.Controls.Add(this.TxtGameItemFilter);
            this.TPItem.Controls.Add(this.ListGameItems);
            this.TPItem.Controls.Add(this.LblGameItemAmount);
            this.TPItem.Controls.Add(this.LblGameItemLevel);
            this.TPItem.Controls.Add(this.NUDGameItemAmout);
            this.TPItem.Controls.Add(this.NUDGameItemLevel);
            this.TPItem.Controls.Add(this.LblGiveCommandDescription);
            this.TPItem.Name = "TPItem";
            this.TTip.SetToolTip(this.TPItem, resources.GetString("TPItem.ToolTip"));
            this.TPItem.UseVisualStyleBackColor = true;
            // 
            // BtnSaveGiveItemLog
            // 
            resources.ApplyResources(this.BtnSaveGiveItemLog, "BtnSaveGiveItemLog");
            this.BtnSaveGiveItemLog.Name = "BtnSaveGiveItemLog";
            this.TTip.SetToolTip(this.BtnSaveGiveItemLog, resources.GetString("BtnSaveGiveItemLog.ToolTip"));
            this.BtnSaveGiveItemLog.UseVisualStyleBackColor = true;
            this.BtnSaveGiveItemLog.Click += new System.EventHandler(this.BtnSaveGiveItemLog_Click);
            // 
            // BtnRemoveGiveItemLog
            // 
            resources.ApplyResources(this.BtnRemoveGiveItemLog, "BtnRemoveGiveItemLog");
            this.BtnRemoveGiveItemLog.Name = "BtnRemoveGiveItemLog";
            this.TTip.SetToolTip(this.BtnRemoveGiveItemLog, resources.GetString("BtnRemoveGiveItemLog.ToolTip"));
            this.BtnRemoveGiveItemLog.UseVisualStyleBackColor = true;
            this.BtnRemoveGiveItemLog.Click += new System.EventHandler(this.BtnRemoveGiveItemLog_Click);
            // 
            // GrpGiveItemRecord
            // 
            resources.ApplyResources(this.GrpGiveItemRecord, "GrpGiveItemRecord");
            this.GrpGiveItemRecord.Controls.Add(this.ListGiveItemLogs);
            this.GrpGiveItemRecord.Name = "GrpGiveItemRecord";
            this.GrpGiveItemRecord.TabStop = false;
            this.TTip.SetToolTip(this.GrpGiveItemRecord, resources.GetString("GrpGiveItemRecord.ToolTip"));
            // 
            // ListGiveItemLogs
            // 
            resources.ApplyResources(this.ListGiveItemLogs, "ListGiveItemLogs");
            this.ListGiveItemLogs.FormattingEnabled = true;
            this.ListGiveItemLogs.Name = "ListGiveItemLogs";
            this.TTip.SetToolTip(this.ListGiveItemLogs, resources.GetString("ListGiveItemLogs.ToolTip"));
            this.ListGiveItemLogs.SelectedIndexChanged += new System.EventHandler(this.ListGiveItemLogs_SelectedIndexChanged);
            // 
            // ChkDrop
            // 
            resources.ApplyResources(this.ChkDrop, "ChkDrop");
            this.ChkDrop.Name = "ChkDrop";
            this.TTip.SetToolTip(this.ChkDrop, resources.GetString("ChkDrop.ToolTip"));
            this.ChkDrop.UseVisualStyleBackColor = true;
            this.ChkDrop.CheckedChanged += new System.EventHandler(this.GiveItemsInputChanged);
            // 
            // TxtGameItemFilter
            // 
            resources.ApplyResources(this.TxtGameItemFilter, "TxtGameItemFilter");
            this.TxtGameItemFilter.Name = "TxtGameItemFilter";
            this.TTip.SetToolTip(this.TxtGameItemFilter, resources.GetString("TxtGameItemFilter.ToolTip"));
            this.TxtGameItemFilter.TextChanged += new System.EventHandler(this.TxtGameItemFilter_TextChanged);
            // 
            // ListGameItems
            // 
            resources.ApplyResources(this.ListGameItems, "ListGameItems");
            this.ListGameItems.FormattingEnabled = true;
            this.ListGameItems.Name = "ListGameItems";
            this.TTip.SetToolTip(this.ListGameItems, resources.GetString("ListGameItems.ToolTip"));
            this.ListGameItems.SelectedIndexChanged += new System.EventHandler(this.GiveItemsInputChanged);
            // 
            // LblGameItemAmount
            // 
            resources.ApplyResources(this.LblGameItemAmount, "LblGameItemAmount");
            this.LblGameItemAmount.Name = "LblGameItemAmount";
            this.TTip.SetToolTip(this.LblGameItemAmount, resources.GetString("LblGameItemAmount.ToolTip"));
            // 
            // LblGameItemLevel
            // 
            resources.ApplyResources(this.LblGameItemLevel, "LblGameItemLevel");
            this.LblGameItemLevel.Name = "LblGameItemLevel";
            this.TTip.SetToolTip(this.LblGameItemLevel, resources.GetString("LblGameItemLevel.ToolTip"));
            // 
            // NUDGameItemAmout
            // 
            resources.ApplyResources(this.NUDGameItemAmout, "NUDGameItemAmout");
            this.NUDGameItemAmout.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUDGameItemAmout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDGameItemAmout.Name = "NUDGameItemAmout";
            this.TTip.SetToolTip(this.NUDGameItemAmout, resources.GetString("NUDGameItemAmout.ToolTip"));
            this.NUDGameItemAmout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDGameItemAmout.ValueChanged += new System.EventHandler(this.GiveItemsInputChanged);
            // 
            // NUDGameItemLevel
            // 
            resources.ApplyResources(this.NUDGameItemLevel, "NUDGameItemLevel");
            this.NUDGameItemLevel.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.NUDGameItemLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDGameItemLevel.Name = "NUDGameItemLevel";
            this.TTip.SetToolTip(this.NUDGameItemLevel, resources.GetString("NUDGameItemLevel.ToolTip"));
            this.NUDGameItemLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDGameItemLevel.ValueChanged += new System.EventHandler(this.GiveItemsInputChanged);
            // 
            // LblGiveCommandDescription
            // 
            resources.ApplyResources(this.LblGiveCommandDescription, "LblGiveCommandDescription");
            this.LblGiveCommandDescription.Name = "LblGiveCommandDescription";
            this.TTip.SetToolTip(this.LblGiveCommandDescription, resources.GetString("LblGiveCommandDescription.ToolTip"));
            // 
            // TPAvatar
            // 
            resources.ApplyResources(this.TPAvatar, "TPAvatar");
            this.TPAvatar.Controls.Add(this.LblAvatarGenWarning);
            this.TPAvatar.Controls.Add(this.ImgAvatar);
            this.TPAvatar.Controls.Add(this.LblAvatar);
            this.TPAvatar.Controls.Add(this.LblLevel);
            this.TPAvatar.Controls.Add(this.NUDAvatarLevel);
            this.TPAvatar.Controls.Add(this.CmbAvatar);
            this.TPAvatar.Name = "TPAvatar";
            this.TTip.SetToolTip(this.TPAvatar, resources.GetString("TPAvatar.ToolTip"));
            this.TPAvatar.UseVisualStyleBackColor = true;
            // 
            // LblAvatarGenWarning
            // 
            resources.ApplyResources(this.LblAvatarGenWarning, "LblAvatarGenWarning");
            this.LblAvatarGenWarning.ForeColor = System.Drawing.Color.Red;
            this.LblAvatarGenWarning.Name = "LblAvatarGenWarning";
            this.TTip.SetToolTip(this.LblAvatarGenWarning, resources.GetString("LblAvatarGenWarning.ToolTip"));
            // 
            // ImgAvatar
            // 
            resources.ApplyResources(this.ImgAvatar, "ImgAvatar");
            this.ImgAvatar.Image = global::GrasscutterTools.Properties.Resources.ImgHome;
            this.ImgAvatar.Name = "ImgAvatar";
            this.ImgAvatar.TabStop = false;
            this.TTip.SetToolTip(this.ImgAvatar, resources.GetString("ImgAvatar.ToolTip"));
            // 
            // LblAvatar
            // 
            resources.ApplyResources(this.LblAvatar, "LblAvatar");
            this.LblAvatar.Name = "LblAvatar";
            this.TTip.SetToolTip(this.LblAvatar, resources.GetString("LblAvatar.ToolTip"));
            // 
            // LblLevel
            // 
            resources.ApplyResources(this.LblLevel, "LblLevel");
            this.LblLevel.Name = "LblLevel";
            this.TTip.SetToolTip(this.LblLevel, resources.GetString("LblLevel.ToolTip"));
            // 
            // NUDAvatarLevel
            // 
            resources.ApplyResources(this.NUDAvatarLevel, "NUDAvatarLevel");
            this.NUDAvatarLevel.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.NUDAvatarLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDAvatarLevel.Name = "NUDAvatarLevel";
            this.TTip.SetToolTip(this.NUDAvatarLevel, resources.GetString("NUDAvatarLevel.ToolTip"));
            this.NUDAvatarLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDAvatarLevel.ValueChanged += new System.EventHandler(this.NUDAvatarLevel_ValueChanged);
            // 
            // CmbAvatar
            // 
            resources.ApplyResources(this.CmbAvatar, "CmbAvatar");
            this.CmbAvatar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAvatar.FormattingEnabled = true;
            this.CmbAvatar.Name = "CmbAvatar";
            this.TTip.SetToolTip(this.CmbAvatar, resources.GetString("CmbAvatar.ToolTip"));
            this.CmbAvatar.SelectedIndexChanged += new System.EventHandler(this.CmbAvatar_SelectedIndexChanged);
            // 
            // TPSpawn
            // 
            resources.ApplyResources(this.TPSpawn, "TPSpawn");
            this.TPSpawn.Controls.Add(this.BtnSaveSpawnLog);
            this.TPSpawn.Controls.Add(this.BtnRemoveSpawnLog);
            this.TPSpawn.Controls.Add(this.GrpSpawnRecord);
            this.TPSpawn.Controls.Add(this.GrpEntityType);
            this.TPSpawn.Controls.Add(this.LblSpawnDescription);
            this.TPSpawn.Controls.Add(this.LblEntityAmount);
            this.TPSpawn.Controls.Add(this.LblEntityLevel);
            this.TPSpawn.Controls.Add(this.NUDEntityAmout);
            this.TPSpawn.Controls.Add(this.NUDEntityLevel);
            this.TPSpawn.Controls.Add(this.TxtEntityFilter);
            this.TPSpawn.Controls.Add(this.ListEntity);
            this.TPSpawn.Name = "TPSpawn";
            this.TTip.SetToolTip(this.TPSpawn, resources.GetString("TPSpawn.ToolTip"));
            this.TPSpawn.UseVisualStyleBackColor = true;
            // 
            // BtnSaveSpawnLog
            // 
            resources.ApplyResources(this.BtnSaveSpawnLog, "BtnSaveSpawnLog");
            this.BtnSaveSpawnLog.Name = "BtnSaveSpawnLog";
            this.TTip.SetToolTip(this.BtnSaveSpawnLog, resources.GetString("BtnSaveSpawnLog.ToolTip"));
            this.BtnSaveSpawnLog.UseVisualStyleBackColor = true;
            this.BtnSaveSpawnLog.Click += new System.EventHandler(this.BtnSaveSpawnLog_Click);
            // 
            // BtnRemoveSpawnLog
            // 
            resources.ApplyResources(this.BtnRemoveSpawnLog, "BtnRemoveSpawnLog");
            this.BtnRemoveSpawnLog.Name = "BtnRemoveSpawnLog";
            this.TTip.SetToolTip(this.BtnRemoveSpawnLog, resources.GetString("BtnRemoveSpawnLog.ToolTip"));
            this.BtnRemoveSpawnLog.UseVisualStyleBackColor = true;
            this.BtnRemoveSpawnLog.Click += new System.EventHandler(this.BtnRemoveSpawnLog_Click);
            // 
            // GrpSpawnRecord
            // 
            resources.ApplyResources(this.GrpSpawnRecord, "GrpSpawnRecord");
            this.GrpSpawnRecord.Controls.Add(this.ListSpawnLogs);
            this.GrpSpawnRecord.Name = "GrpSpawnRecord";
            this.GrpSpawnRecord.TabStop = false;
            this.TTip.SetToolTip(this.GrpSpawnRecord, resources.GetString("GrpSpawnRecord.ToolTip"));
            // 
            // ListSpawnLogs
            // 
            resources.ApplyResources(this.ListSpawnLogs, "ListSpawnLogs");
            this.ListSpawnLogs.FormattingEnabled = true;
            this.ListSpawnLogs.Name = "ListSpawnLogs";
            this.TTip.SetToolTip(this.ListSpawnLogs, resources.GetString("ListSpawnLogs.ToolTip"));
            this.ListSpawnLogs.SelectedIndexChanged += new System.EventHandler(this.ListSpawnLogs_SelectedIndexChanged);
            // 
            // GrpEntityType
            // 
            resources.ApplyResources(this.GrpEntityType, "GrpEntityType");
            this.GrpEntityType.Controls.Add(this.RbEntityOrnament);
            this.GrpEntityType.Controls.Add(this.RbEntityAnimal);
            this.GrpEntityType.Controls.Add(this.RbEntityNPC);
            this.GrpEntityType.Controls.Add(this.RbEntityMonster);
            this.GrpEntityType.Name = "GrpEntityType";
            this.GrpEntityType.TabStop = false;
            this.TTip.SetToolTip(this.GrpEntityType, resources.GetString("GrpEntityType.ToolTip"));
            // 
            // RbEntityOrnament
            // 
            resources.ApplyResources(this.RbEntityOrnament, "RbEntityOrnament");
            this.RbEntityOrnament.Name = "RbEntityOrnament";
            this.RbEntityOrnament.TabStop = true;
            this.TTip.SetToolTip(this.RbEntityOrnament, resources.GetString("RbEntityOrnament.ToolTip"));
            this.RbEntityOrnament.UseVisualStyleBackColor = true;
            this.RbEntityOrnament.CheckedChanged += new System.EventHandler(this.RbEntity_CheckedChanged);
            // 
            // RbEntityAnimal
            // 
            resources.ApplyResources(this.RbEntityAnimal, "RbEntityAnimal");
            this.RbEntityAnimal.Name = "RbEntityAnimal";
            this.TTip.SetToolTip(this.RbEntityAnimal, resources.GetString("RbEntityAnimal.ToolTip"));
            this.RbEntityAnimal.UseVisualStyleBackColor = true;
            this.RbEntityAnimal.CheckedChanged += new System.EventHandler(this.RbEntity_CheckedChanged);
            // 
            // RbEntityNPC
            // 
            resources.ApplyResources(this.RbEntityNPC, "RbEntityNPC");
            this.RbEntityNPC.Name = "RbEntityNPC";
            this.TTip.SetToolTip(this.RbEntityNPC, resources.GetString("RbEntityNPC.ToolTip"));
            this.RbEntityNPC.UseVisualStyleBackColor = true;
            this.RbEntityNPC.CheckedChanged += new System.EventHandler(this.RbEntity_CheckedChanged);
            // 
            // RbEntityMonster
            // 
            resources.ApplyResources(this.RbEntityMonster, "RbEntityMonster");
            this.RbEntityMonster.Name = "RbEntityMonster";
            this.TTip.SetToolTip(this.RbEntityMonster, resources.GetString("RbEntityMonster.ToolTip"));
            this.RbEntityMonster.UseVisualStyleBackColor = true;
            this.RbEntityMonster.CheckedChanged += new System.EventHandler(this.RbEntity_CheckedChanged);
            // 
            // LblSpawnDescription
            // 
            resources.ApplyResources(this.LblSpawnDescription, "LblSpawnDescription");
            this.LblSpawnDescription.Name = "LblSpawnDescription";
            this.TTip.SetToolTip(this.LblSpawnDescription, resources.GetString("LblSpawnDescription.ToolTip"));
            // 
            // LblEntityAmount
            // 
            resources.ApplyResources(this.LblEntityAmount, "LblEntityAmount");
            this.LblEntityAmount.Name = "LblEntityAmount";
            this.TTip.SetToolTip(this.LblEntityAmount, resources.GetString("LblEntityAmount.ToolTip"));
            // 
            // LblEntityLevel
            // 
            resources.ApplyResources(this.LblEntityLevel, "LblEntityLevel");
            this.LblEntityLevel.Name = "LblEntityLevel";
            this.TTip.SetToolTip(this.LblEntityLevel, resources.GetString("LblEntityLevel.ToolTip"));
            // 
            // NUDEntityAmout
            // 
            resources.ApplyResources(this.NUDEntityAmout, "NUDEntityAmout");
            this.NUDEntityAmout.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDEntityAmout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDEntityAmout.Name = "NUDEntityAmout";
            this.TTip.SetToolTip(this.NUDEntityAmout, resources.GetString("NUDEntityAmout.ToolTip"));
            this.NUDEntityAmout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDEntityAmout.ValueChanged += new System.EventHandler(this.SpawnEntityInputChanged);
            // 
            // NUDEntityLevel
            // 
            resources.ApplyResources(this.NUDEntityLevel, "NUDEntityLevel");
            this.NUDEntityLevel.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUDEntityLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDEntityLevel.Name = "NUDEntityLevel";
            this.TTip.SetToolTip(this.NUDEntityLevel, resources.GetString("NUDEntityLevel.ToolTip"));
            this.NUDEntityLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDEntityLevel.ValueChanged += new System.EventHandler(this.SpawnEntityInputChanged);
            // 
            // TxtEntityFilter
            // 
            resources.ApplyResources(this.TxtEntityFilter, "TxtEntityFilter");
            this.TxtEntityFilter.Name = "TxtEntityFilter";
            this.TTip.SetToolTip(this.TxtEntityFilter, resources.GetString("TxtEntityFilter.ToolTip"));
            this.TxtEntityFilter.TextChanged += new System.EventHandler(this.TxtEntityFilter_TextChanged);
            // 
            // ListEntity
            // 
            resources.ApplyResources(this.ListEntity, "ListEntity");
            this.ListEntity.FormattingEnabled = true;
            this.ListEntity.Name = "ListEntity";
            this.TTip.SetToolTip(this.ListEntity, resources.GetString("ListEntity.ToolTip"));
            this.ListEntity.SelectedIndexChanged += new System.EventHandler(this.SpawnEntityInputChanged);
            // 
            // TPScene
            // 
            resources.ApplyResources(this.TPScene, "TPScene");
            this.TPScene.Controls.Add(this.CmbClimateType);
            this.TPScene.Controls.Add(this.LblClimateType);
            this.TPScene.Controls.Add(this.LblSceneDescription);
            this.TPScene.Controls.Add(this.ListScenes);
            this.TPScene.Name = "TPScene";
            this.TTip.SetToolTip(this.TPScene, resources.GetString("TPScene.ToolTip"));
            this.TPScene.UseVisualStyleBackColor = true;
            // 
            // CmbClimateType
            // 
            resources.ApplyResources(this.CmbClimateType, "CmbClimateType");
            this.CmbClimateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbClimateType.FormattingEnabled = true;
            this.CmbClimateType.Name = "CmbClimateType";
            this.TTip.SetToolTip(this.CmbClimateType, resources.GetString("CmbClimateType.ToolTip"));
            this.CmbClimateType.SelectedIndexChanged += new System.EventHandler(this.CmbClimateType_SelectedIndexChanged);
            // 
            // LblClimateType
            // 
            resources.ApplyResources(this.LblClimateType, "LblClimateType");
            this.LblClimateType.Name = "LblClimateType";
            this.TTip.SetToolTip(this.LblClimateType, resources.GetString("LblClimateType.ToolTip"));
            // 
            // LblSceneDescription
            // 
            resources.ApplyResources(this.LblSceneDescription, "LblSceneDescription");
            this.LblSceneDescription.Name = "LblSceneDescription";
            this.TTip.SetToolTip(this.LblSceneDescription, resources.GetString("LblSceneDescription.ToolTip"));
            // 
            // ListScenes
            // 
            resources.ApplyResources(this.ListScenes, "ListScenes");
            this.ListScenes.FormattingEnabled = true;
            this.ListScenes.Name = "ListScenes";
            this.TTip.SetToolTip(this.ListScenes, resources.GetString("ListScenes.ToolTip"));
            this.ListScenes.SelectedIndexChanged += new System.EventHandler(this.ListScenes_SelectedIndexChanged);
            // 
            // TPStats
            // 
            resources.ApplyResources(this.TPStats, "TPStats");
            this.TPStats.Controls.Add(this.GrpSetStats);
            this.TPStats.Controls.Add(this.GrpTalentLevel);
            this.TPStats.Controls.Add(this.LblStatsDescription);
            this.TPStats.Name = "TPStats";
            this.TTip.SetToolTip(this.TPStats, resources.GetString("TPStats.ToolTip"));
            this.TPStats.UseVisualStyleBackColor = true;
            // 
            // GrpSetStats
            // 
            resources.ApplyResources(this.GrpSetStats, "GrpSetStats");
            this.GrpSetStats.Controls.Add(this.LblStatTip);
            this.GrpSetStats.Controls.Add(this.LblStatPercent);
            this.GrpSetStats.Controls.Add(this.NUDStat);
            this.GrpSetStats.Controls.Add(this.CmbStat);
            this.GrpSetStats.Name = "GrpSetStats";
            this.GrpSetStats.TabStop = false;
            this.TTip.SetToolTip(this.GrpSetStats, resources.GetString("GrpSetStats.ToolTip"));
            // 
            // LblStatTip
            // 
            resources.ApplyResources(this.LblStatTip, "LblStatTip");
            this.LblStatTip.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblStatTip.Name = "LblStatTip";
            this.TTip.SetToolTip(this.LblStatTip, resources.GetString("LblStatTip.ToolTip"));
            // 
            // LblStatPercent
            // 
            resources.ApplyResources(this.LblStatPercent, "LblStatPercent");
            this.LblStatPercent.Name = "LblStatPercent";
            this.TTip.SetToolTip(this.LblStatPercent, resources.GetString("LblStatPercent.ToolTip"));
            // 
            // NUDStat
            // 
            resources.ApplyResources(this.NUDStat, "NUDStat");
            this.NUDStat.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NUDStat.Name = "NUDStat";
            this.TTip.SetToolTip(this.NUDStat, resources.GetString("NUDStat.ToolTip"));
            this.NUDStat.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUDStat.ValueChanged += new System.EventHandler(this.SetStatsInputChanged);
            // 
            // CmbStat
            // 
            resources.ApplyResources(this.CmbStat, "CmbStat");
            this.CmbStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStat.FormattingEnabled = true;
            this.CmbStat.Name = "CmbStat";
            this.TTip.SetToolTip(this.CmbStat, resources.GetString("CmbStat.ToolTip"));
            this.CmbStat.SelectedIndexChanged += new System.EventHandler(this.SetStatsInputChanged);
            // 
            // GrpTalentLevel
            // 
            resources.ApplyResources(this.GrpTalentLevel, "GrpTalentLevel");
            this.GrpTalentLevel.Controls.Add(this.LnkTalentE);
            this.GrpTalentLevel.Controls.Add(this.LnkTalentQ);
            this.GrpTalentLevel.Controls.Add(this.LnkTalentNormalATK);
            this.GrpTalentLevel.Controls.Add(this.NUDTalentLevel);
            this.GrpTalentLevel.Name = "GrpTalentLevel";
            this.GrpTalentLevel.TabStop = false;
            this.TTip.SetToolTip(this.GrpTalentLevel, resources.GetString("GrpTalentLevel.ToolTip"));
            // 
            // LnkTalentE
            // 
            resources.ApplyResources(this.LnkTalentE, "LnkTalentE");
            this.LnkTalentE.Name = "LnkTalentE";
            this.LnkTalentE.TabStop = true;
            this.LnkTalentE.Tag = "e";
            this.TTip.SetToolTip(this.LnkTalentE, resources.GetString("LnkTalentE.ToolTip"));
            this.LnkTalentE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSetTalentClicked);
            // 
            // LnkTalentQ
            // 
            resources.ApplyResources(this.LnkTalentQ, "LnkTalentQ");
            this.LnkTalentQ.Name = "LnkTalentQ";
            this.LnkTalentQ.TabStop = true;
            this.LnkTalentQ.Tag = "q";
            this.TTip.SetToolTip(this.LnkTalentQ, resources.GetString("LnkTalentQ.ToolTip"));
            this.LnkTalentQ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSetTalentClicked);
            // 
            // LnkTalentNormalATK
            // 
            resources.ApplyResources(this.LnkTalentNormalATK, "LnkTalentNormalATK");
            this.LnkTalentNormalATK.Name = "LnkTalentNormalATK";
            this.LnkTalentNormalATK.TabStop = true;
            this.LnkTalentNormalATK.Tag = "n";
            this.TTip.SetToolTip(this.LnkTalentNormalATK, resources.GetString("LnkTalentNormalATK.ToolTip"));
            this.LnkTalentNormalATK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSetTalentClicked);
            // 
            // NUDTalentLevel
            // 
            resources.ApplyResources(this.NUDTalentLevel, "NUDTalentLevel");
            this.NUDTalentLevel.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NUDTalentLevel.Name = "NUDTalentLevel";
            this.TTip.SetToolTip(this.NUDTalentLevel, resources.GetString("NUDTalentLevel.ToolTip"));
            this.NUDTalentLevel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // LblStatsDescription
            // 
            resources.ApplyResources(this.LblStatsDescription, "LblStatsDescription");
            this.LblStatsDescription.Name = "LblStatsDescription";
            this.TTip.SetToolTip(this.LblStatsDescription, resources.GetString("LblStatsDescription.ToolTip"));
            // 
            // TPManage
            // 
            resources.ApplyResources(this.TPManage, "TPManage");
            this.TPManage.Controls.Add(this.GrpAccount);
            this.TPManage.Controls.Add(this.GrpPermission);
            this.TPManage.Name = "TPManage";
            this.TTip.SetToolTip(this.TPManage, resources.GetString("TPManage.ToolTip"));
            this.TPManage.UseVisualStyleBackColor = true;
            // 
            // GrpAccount
            // 
            resources.ApplyResources(this.GrpAccount, "GrpAccount");
            this.GrpAccount.Controls.Add(this.ChkAccountSetUid);
            this.GrpAccount.Controls.Add(this.NUDAccountUid);
            this.GrpAccount.Controls.Add(this.BtnDeleteAccount);
            this.GrpAccount.Controls.Add(this.BtnCreateAccount);
            this.GrpAccount.Controls.Add(this.LblAccountUserName);
            this.GrpAccount.Controls.Add(this.TxtAccountUserName);
            this.GrpAccount.Name = "GrpAccount";
            this.GrpAccount.TabStop = false;
            this.TTip.SetToolTip(this.GrpAccount, resources.GetString("GrpAccount.ToolTip"));
            // 
            // ChkAccountSetUid
            // 
            resources.ApplyResources(this.ChkAccountSetUid, "ChkAccountSetUid");
            this.ChkAccountSetUid.Name = "ChkAccountSetUid";
            this.TTip.SetToolTip(this.ChkAccountSetUid, resources.GetString("ChkAccountSetUid.ToolTip"));
            this.ChkAccountSetUid.UseVisualStyleBackColor = true;
            // 
            // NUDAccountUid
            // 
            resources.ApplyResources(this.NUDAccountUid, "NUDAccountUid");
            this.NUDAccountUid.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDAccountUid.Name = "NUDAccountUid";
            this.TTip.SetToolTip(this.NUDAccountUid, resources.GetString("NUDAccountUid.ToolTip"));
            this.NUDAccountUid.Value = new decimal(new int[] {
            10001,
            0,
            0,
            0});
            // 
            // BtnDeleteAccount
            // 
            resources.ApplyResources(this.BtnDeleteAccount, "BtnDeleteAccount");
            this.BtnDeleteAccount.Name = "BtnDeleteAccount";
            this.BtnDeleteAccount.Tag = "delete";
            this.TTip.SetToolTip(this.BtnDeleteAccount, resources.GetString("BtnDeleteAccount.ToolTip"));
            this.BtnDeleteAccount.UseVisualStyleBackColor = true;
            this.BtnDeleteAccount.Click += new System.EventHandler(this.AccountButtonClicked);
            // 
            // BtnCreateAccount
            // 
            resources.ApplyResources(this.BtnCreateAccount, "BtnCreateAccount");
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Tag = "create";
            this.TTip.SetToolTip(this.BtnCreateAccount, resources.GetString("BtnCreateAccount.ToolTip"));
            this.BtnCreateAccount.UseVisualStyleBackColor = true;
            this.BtnCreateAccount.Click += new System.EventHandler(this.AccountButtonClicked);
            // 
            // LblAccountUserName
            // 
            resources.ApplyResources(this.LblAccountUserName, "LblAccountUserName");
            this.LblAccountUserName.Name = "LblAccountUserName";
            this.TTip.SetToolTip(this.LblAccountUserName, resources.GetString("LblAccountUserName.ToolTip"));
            // 
            // TxtAccountUserName
            // 
            resources.ApplyResources(this.TxtAccountUserName, "TxtAccountUserName");
            this.TxtAccountUserName.Name = "TxtAccountUserName";
            this.TTip.SetToolTip(this.TxtAccountUserName, resources.GetString("TxtAccountUserName.ToolTip"));
            // 
            // GrpPermission
            // 
            resources.ApplyResources(this.GrpPermission, "GrpPermission");
            this.GrpPermission.Controls.Add(this.CmbPerm);
            this.GrpPermission.Controls.Add(this.NUDPermUID);
            this.GrpPermission.Controls.Add(this.BtmPermRemove);
            this.GrpPermission.Controls.Add(this.BtnPermAdd);
            this.GrpPermission.Controls.Add(this.LblPerm);
            this.GrpPermission.Controls.Add(this.LblPermUID);
            this.GrpPermission.Name = "GrpPermission";
            this.GrpPermission.TabStop = false;
            this.TTip.SetToolTip(this.GrpPermission, resources.GetString("GrpPermission.ToolTip"));
            // 
            // CmbPerm
            // 
            resources.ApplyResources(this.CmbPerm, "CmbPerm");
            this.CmbPerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbPerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbPerm.FormattingEnabled = true;
            this.CmbPerm.Name = "CmbPerm";
            this.TTip.SetToolTip(this.CmbPerm, resources.GetString("CmbPerm.ToolTip"));
            // 
            // NUDPermUID
            // 
            resources.ApplyResources(this.NUDPermUID, "NUDPermUID");
            this.NUDPermUID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDPermUID.Name = "NUDPermUID";
            this.TTip.SetToolTip(this.NUDPermUID, resources.GetString("NUDPermUID.ToolTip"));
            this.NUDPermUID.Value = new decimal(new int[] {
            10001,
            0,
            0,
            0});
            // 
            // BtmPermRemove
            // 
            resources.ApplyResources(this.BtmPermRemove, "BtmPermRemove");
            this.BtmPermRemove.Name = "BtmPermRemove";
            this.BtmPermRemove.Tag = "remove";
            this.TTip.SetToolTip(this.BtmPermRemove, resources.GetString("BtmPermRemove.ToolTip"));
            this.BtmPermRemove.UseVisualStyleBackColor = true;
            this.BtmPermRemove.Click += new System.EventHandler(this.BtnPermClick);
            // 
            // BtnPermAdd
            // 
            resources.ApplyResources(this.BtnPermAdd, "BtnPermAdd");
            this.BtnPermAdd.Name = "BtnPermAdd";
            this.BtnPermAdd.Tag = "add";
            this.TTip.SetToolTip(this.BtnPermAdd, resources.GetString("BtnPermAdd.ToolTip"));
            this.BtnPermAdd.UseVisualStyleBackColor = true;
            this.BtnPermAdd.Click += new System.EventHandler(this.BtnPermClick);
            // 
            // LblPerm
            // 
            resources.ApplyResources(this.LblPerm, "LblPerm");
            this.LblPerm.Name = "LblPerm";
            this.TTip.SetToolTip(this.LblPerm, resources.GetString("LblPerm.ToolTip"));
            // 
            // LblPermUID
            // 
            resources.ApplyResources(this.LblPermUID, "LblPermUID");
            this.LblPermUID.Name = "LblPermUID";
            this.TTip.SetToolTip(this.LblPermUID, resources.GetString("LblPermUID.ToolTip"));
            // 
            // TPAbout
            // 
            resources.ApplyResources(this.TPAbout, "TPAbout");
            this.TPAbout.Controls.Add(this.pictureBox2);
            this.TPAbout.Controls.Add(this.LnkGithub);
            this.TPAbout.Controls.Add(this.LblSupportDescription);
            this.TPAbout.Name = "TPAbout";
            this.TTip.SetToolTip(this.TPAbout, resources.GetString("TPAbout.ToolTip"));
            this.TPAbout.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::GrasscutterTools.Properties.Resources.ImgSupport;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.TTip.SetToolTip(this.pictureBox2, resources.GetString("pictureBox2.ToolTip"));
            // 
            // LnkGithub
            // 
            resources.ApplyResources(this.LnkGithub, "LnkGithub");
            this.LnkGithub.Name = "LnkGithub";
            this.LnkGithub.TabStop = true;
            this.TTip.SetToolTip(this.LnkGithub, resources.GetString("LnkGithub.ToolTip"));
            this.LnkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkGithub_LinkClicked);
            // 
            // LblSupportDescription
            // 
            resources.ApplyResources(this.LblSupportDescription, "LblSupportDescription");
            this.LblSupportDescription.Name = "LblSupportDescription";
            this.TTip.SetToolTip(this.LblSupportDescription, resources.GetString("LblSupportDescription.ToolTip"));
            // 
            // TPRemoteCall
            // 
            resources.ApplyResources(this.TPRemoteCall, "TPRemoteCall");
            this.TPRemoteCall.Controls.Add(this.GrpServerStatus);
            this.TPRemoteCall.Controls.Add(this.GrpRemoteCommand);
            this.TPRemoteCall.Controls.Add(this.TxtHost);
            this.TPRemoteCall.Controls.Add(this.BtnQueryServerStatus);
            this.TPRemoteCall.Controls.Add(this.LblHost);
            this.TPRemoteCall.Name = "TPRemoteCall";
            this.TTip.SetToolTip(this.TPRemoteCall, resources.GetString("TPRemoteCall.ToolTip"));
            this.TPRemoteCall.UseVisualStyleBackColor = true;
            // 
            // GrpServerStatus
            // 
            resources.ApplyResources(this.GrpServerStatus, "GrpServerStatus");
            this.GrpServerStatus.Controls.Add(this.LnkOpenCommandLabel);
            this.GrpServerStatus.Controls.Add(this.LblOpenCommandSupport);
            this.GrpServerStatus.Controls.Add(this.LblServerVersion);
            this.GrpServerStatus.Controls.Add(this.LblPlayerCount);
            this.GrpServerStatus.Controls.Add(this.LblServerVersionLabel);
            this.GrpServerStatus.Controls.Add(this.LblPlayerCountLabel);
            this.GrpServerStatus.Name = "GrpServerStatus";
            this.GrpServerStatus.TabStop = false;
            this.TTip.SetToolTip(this.GrpServerStatus, resources.GetString("GrpServerStatus.ToolTip"));
            // 
            // LnkOpenCommandLabel
            // 
            resources.ApplyResources(this.LnkOpenCommandLabel, "LnkOpenCommandLabel");
            this.LnkOpenCommandLabel.Name = "LnkOpenCommandLabel";
            this.LnkOpenCommandLabel.TabStop = true;
            this.TTip.SetToolTip(this.LnkOpenCommandLabel, resources.GetString("LnkOpenCommandLabel.ToolTip"));
            this.LnkOpenCommandLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkOpenCommandLabel_LinkClicked);
            // 
            // LblOpenCommandSupport
            // 
            resources.ApplyResources(this.LblOpenCommandSupport, "LblOpenCommandSupport");
            this.LblOpenCommandSupport.Name = "LblOpenCommandSupport";
            this.TTip.SetToolTip(this.LblOpenCommandSupport, resources.GetString("LblOpenCommandSupport.ToolTip"));
            // 
            // LblServerVersion
            // 
            resources.ApplyResources(this.LblServerVersion, "LblServerVersion");
            this.LblServerVersion.Name = "LblServerVersion";
            this.TTip.SetToolTip(this.LblServerVersion, resources.GetString("LblServerVersion.ToolTip"));
            // 
            // LblPlayerCount
            // 
            resources.ApplyResources(this.LblPlayerCount, "LblPlayerCount");
            this.LblPlayerCount.Name = "LblPlayerCount";
            this.TTip.SetToolTip(this.LblPlayerCount, resources.GetString("LblPlayerCount.ToolTip"));
            // 
            // LblServerVersionLabel
            // 
            resources.ApplyResources(this.LblServerVersionLabel, "LblServerVersionLabel");
            this.LblServerVersionLabel.Name = "LblServerVersionLabel";
            this.TTip.SetToolTip(this.LblServerVersionLabel, resources.GetString("LblServerVersionLabel.ToolTip"));
            // 
            // LblPlayerCountLabel
            // 
            resources.ApplyResources(this.LblPlayerCountLabel, "LblPlayerCountLabel");
            this.LblPlayerCountLabel.Name = "LblPlayerCountLabel";
            this.TTip.SetToolTip(this.LblPlayerCountLabel, resources.GetString("LblPlayerCountLabel.ToolTip"));
            // 
            // GrpRemoteCommand
            // 
            resources.ApplyResources(this.GrpRemoteCommand, "GrpRemoteCommand");
            this.GrpRemoteCommand.Controls.Add(this.LnkRCHelp);
            this.GrpRemoteCommand.Controls.Add(this.BtnConnectOpenCommand);
            this.GrpRemoteCommand.Controls.Add(this.BtnSendVerificationCode);
            this.GrpRemoteCommand.Controls.Add(this.LblRemotePlayerId);
            this.GrpRemoteCommand.Controls.Add(this.NUDVerificationCode);
            this.GrpRemoteCommand.Controls.Add(this.LblVerificationCode);
            this.GrpRemoteCommand.Controls.Add(this.NUDRemotePlayerId);
            this.GrpRemoteCommand.Name = "GrpRemoteCommand";
            this.GrpRemoteCommand.TabStop = false;
            this.TTip.SetToolTip(this.GrpRemoteCommand, resources.GetString("GrpRemoteCommand.ToolTip"));
            // 
            // LnkRCHelp
            // 
            resources.ApplyResources(this.LnkRCHelp, "LnkRCHelp");
            this.LnkRCHelp.Name = "LnkRCHelp";
            this.LnkRCHelp.TabStop = true;
            this.TTip.SetToolTip(this.LnkRCHelp, resources.GetString("LnkRCHelp.ToolTip"));
            this.LnkRCHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkRCHelp_LinkClicked);
            // 
            // BtnConnectOpenCommand
            // 
            resources.ApplyResources(this.BtnConnectOpenCommand, "BtnConnectOpenCommand");
            this.BtnConnectOpenCommand.Name = "BtnConnectOpenCommand";
            this.TTip.SetToolTip(this.BtnConnectOpenCommand, resources.GetString("BtnConnectOpenCommand.ToolTip"));
            this.BtnConnectOpenCommand.UseVisualStyleBackColor = true;
            this.BtnConnectOpenCommand.Click += new System.EventHandler(this.BtnConnectOpenCommand_Click);
            // 
            // BtnSendVerificationCode
            // 
            resources.ApplyResources(this.BtnSendVerificationCode, "BtnSendVerificationCode");
            this.BtnSendVerificationCode.Name = "BtnSendVerificationCode";
            this.TTip.SetToolTip(this.BtnSendVerificationCode, resources.GetString("BtnSendVerificationCode.ToolTip"));
            this.BtnSendVerificationCode.UseVisualStyleBackColor = true;
            this.BtnSendVerificationCode.Click += new System.EventHandler(this.BtnSendVerificationCode_Click);
            // 
            // LblRemotePlayerId
            // 
            resources.ApplyResources(this.LblRemotePlayerId, "LblRemotePlayerId");
            this.LblRemotePlayerId.Name = "LblRemotePlayerId";
            this.TTip.SetToolTip(this.LblRemotePlayerId, resources.GetString("LblRemotePlayerId.ToolTip"));
            // 
            // NUDVerificationCode
            // 
            resources.ApplyResources(this.NUDVerificationCode, "NUDVerificationCode");
            this.NUDVerificationCode.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUDVerificationCode.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDVerificationCode.Name = "NUDVerificationCode";
            this.TTip.SetToolTip(this.NUDVerificationCode, resources.GetString("NUDVerificationCode.ToolTip"));
            this.NUDVerificationCode.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // LblVerificationCode
            // 
            resources.ApplyResources(this.LblVerificationCode, "LblVerificationCode");
            this.LblVerificationCode.Name = "LblVerificationCode";
            this.TTip.SetToolTip(this.LblVerificationCode, resources.GetString("LblVerificationCode.ToolTip"));
            // 
            // NUDRemotePlayerId
            // 
            resources.ApplyResources(this.NUDRemotePlayerId, "NUDRemotePlayerId");
            this.NUDRemotePlayerId.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDRemotePlayerId.Name = "NUDRemotePlayerId";
            this.TTip.SetToolTip(this.NUDRemotePlayerId, resources.GetString("NUDRemotePlayerId.ToolTip"));
            this.NUDRemotePlayerId.Value = new decimal(new int[] {
            10001,
            0,
            0,
            0});
            // 
            // TxtHost
            // 
            resources.ApplyResources(this.TxtHost, "TxtHost");
            this.TxtHost.Name = "TxtHost";
            this.TTip.SetToolTip(this.TxtHost, resources.GetString("TxtHost.ToolTip"));
            // 
            // BtnQueryServerStatus
            // 
            resources.ApplyResources(this.BtnQueryServerStatus, "BtnQueryServerStatus");
            this.BtnQueryServerStatus.Name = "BtnQueryServerStatus";
            this.TTip.SetToolTip(this.BtnQueryServerStatus, resources.GetString("BtnQueryServerStatus.ToolTip"));
            this.BtnQueryServerStatus.UseVisualStyleBackColor = true;
            this.BtnQueryServerStatus.Click += new System.EventHandler(this.BtnQueryServerStatus_Click);
            // 
            // LblHost
            // 
            resources.ApplyResources(this.LblHost, "LblHost");
            this.LblHost.Name = "LblHost";
            this.TTip.SetToolTip(this.LblHost, resources.GetString("LblHost.ToolTip"));
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.TCMain);
            this.Controls.Add(this.GrpCommand);
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.TTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.GrpCommand.ResumeLayout(false);
            this.GrpCommand.PerformLayout();
            this.TCMain.ResumeLayout(false);
            this.TPHome.ResumeLayout(false);
            this.TPHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GrpSettings.ResumeLayout(false);
            this.GrpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDUid)).EndInit();
            this.TPCustom.ResumeLayout(false);
            this.TPCustom.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.TPArtifact.ResumeLayout(false);
            this.TPArtifact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDArtifactStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSubAttributionTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDArtifactLevel)).EndInit();
            this.TPWeapon.ResumeLayout(false);
            this.TPWeapon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDWeaponRefinement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDWeaponAmout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDWeaponLevel)).EndInit();
            this.TPItem.ResumeLayout(false);
            this.TPItem.PerformLayout();
            this.GrpGiveItemRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUDGameItemAmout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDGameItemLevel)).EndInit();
            this.TPAvatar.ResumeLayout(false);
            this.TPAvatar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAvatarLevel)).EndInit();
            this.TPSpawn.ResumeLayout(false);
            this.TPSpawn.PerformLayout();
            this.GrpSpawnRecord.ResumeLayout(false);
            this.GrpEntityType.ResumeLayout(false);
            this.GrpEntityType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEntityAmout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEntityLevel)).EndInit();
            this.TPScene.ResumeLayout(false);
            this.TPScene.PerformLayout();
            this.TPStats.ResumeLayout(false);
            this.TPStats.PerformLayout();
            this.GrpSetStats.ResumeLayout(false);
            this.GrpSetStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDStat)).EndInit();
            this.GrpTalentLevel.ResumeLayout(false);
            this.GrpTalentLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTalentLevel)).EndInit();
            this.TPManage.ResumeLayout(false);
            this.GrpAccount.ResumeLayout(false);
            this.GrpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAccountUid)).EndInit();
            this.GrpPermission.ResumeLayout(false);
            this.GrpPermission.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPermUID)).EndInit();
            this.TPAbout.ResumeLayout(false);
            this.TPAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TPRemoteCall.ResumeLayout(false);
            this.TPRemoteCall.PerformLayout();
            this.GrpServerStatus.ResumeLayout(false);
            this.GrpServerStatus.PerformLayout();
            this.GrpRemoteCommand.ResumeLayout(false);
            this.GrpRemoteCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDVerificationCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRemotePlayerId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCommand;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.CheckBox ChkAutoCopy;
        private System.Windows.Forms.GroupBox GrpCommand;
        private System.Windows.Forms.TabControl TCMain;
        private System.Windows.Forms.TabPage TPHome;
        private System.Windows.Forms.TabPage TPCustom;
        private System.Windows.Forms.TabPage TPArtifact;
        private System.Windows.Forms.TabPage TPWeapon;
        private System.Windows.Forms.TabPage TPItem;
        private System.Windows.Forms.TabPage TPAvatar;
        private System.Windows.Forms.TabPage TPSpawn;
        private System.Windows.Forms.TabPage TPScene;
        private System.Windows.Forms.FlowLayoutPanel FLPCustomCommands;
        private System.Windows.Forms.Button BtnRemoveCustomCommand;
        private System.Windows.Forms.Button BtnSaveCustomCommand;
        private System.Windows.Forms.TextBox TxtCustomName;
        private System.Windows.Forms.Label LblCustomName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblSceneDescription;
        private System.Windows.Forms.ListBox ListScenes;
        private System.Windows.Forms.Label LblDefaultUid;
        private System.Windows.Forms.Label LblAbout;
        private System.Windows.Forms.NumericUpDown NUDUid;
        private System.Windows.Forms.Label LblAvatar;
        private System.Windows.Forms.Label LblLevel;
        private System.Windows.Forms.NumericUpDown NUDAvatarLevel;
        private System.Windows.Forms.ComboBox CmbAvatar;
        private System.Windows.Forms.PictureBox ImgAvatar;
        private System.Windows.Forms.Label LblWeaponDescription;
        private System.Windows.Forms.Label LblWeaponRefinement;
        private System.Windows.Forms.Label LblWeaponAmount;
        private System.Windows.Forms.Label LblWeaponLevel;
        private System.Windows.Forms.NumericUpDown NUDWeaponRefinement;
        private System.Windows.Forms.NumericUpDown NUDWeaponAmout;
        private System.Windows.Forms.NumericUpDown NUDWeaponLevel;
        private System.Windows.Forms.ListBox ListWeapons;
        private System.Windows.Forms.TextBox TxtWeaponFilter;
        private System.Windows.Forms.CheckBox ChkIncludeUID;
        private System.Windows.Forms.Label LblGiveCommandDescription;
        private System.Windows.Forms.GroupBox GrpSettings;
        private System.Windows.Forms.Label LblSpawnDescription;
        private System.Windows.Forms.Label LblEntityAmount;
        private System.Windows.Forms.Label LblEntityLevel;
        private System.Windows.Forms.NumericUpDown NUDEntityAmout;
        private System.Windows.Forms.NumericUpDown NUDEntityLevel;
        private System.Windows.Forms.TextBox TxtEntityFilter;
        private System.Windows.Forms.ListBox ListEntity;
        private System.Windows.Forms.RadioButton RbEntityNPC;
        private System.Windows.Forms.RadioButton RbEntityMonster;
        private System.Windows.Forms.RadioButton RbEntityAnimal;
        private System.Windows.Forms.GroupBox GrpEntityType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnExportCustomCommands;
        private System.Windows.Forms.Button BtnLoadCustomCommands;
        private System.Windows.Forms.TextBox TxtGameItemFilter;
        private System.Windows.Forms.ListBox ListGameItems;
        private System.Windows.Forms.Label LblGameItemAmount;
        private System.Windows.Forms.Label LblGameItemLevel;
        private System.Windows.Forms.NumericUpDown NUDGameItemAmout;
        private System.Windows.Forms.NumericUpDown NUDGameItemLevel;
        private System.Windows.Forms.CheckBox ChkDrop;
        private System.Windows.Forms.ComboBox CmbMainAttribution;
        private System.Windows.Forms.Label LblMainAttribution;
        private System.Windows.Forms.Label LblSubAttribution;
        private System.Windows.Forms.NumericUpDown NUDArtifactLevel;
        private System.Windows.Forms.Label LblArtifactLevel;
        private System.Windows.Forms.ListBox ListSubAttributionChecked;
        private System.Windows.Forms.TabPage TPStats;
        private System.Windows.Forms.Label LblClearSubAttrCheckedList;
        private System.Windows.Forms.TabPage TPManage;
        private System.Windows.Forms.GroupBox GrpTalentLevel;
        private System.Windows.Forms.LinkLabel LnkTalentE;
        private System.Windows.Forms.LinkLabel LnkTalentQ;
        private System.Windows.Forms.LinkLabel LnkTalentNormalATK;
        private System.Windows.Forms.NumericUpDown NUDTalentLevel;
        private System.Windows.Forms.Label LblStatsDescription;
        private System.Windows.Forms.GroupBox GrpPermission;
        private System.Windows.Forms.Button BtmPermRemove;
        private System.Windows.Forms.Button BtnPermAdd;
        private System.Windows.Forms.Label LblPerm;
        private System.Windows.Forms.Label LblPermUID;
        private System.Windows.Forms.GroupBox GrpAccount;
        private System.Windows.Forms.Label LblAvatarGenWarning;
        private System.Windows.Forms.NumericUpDown NUDSubAttributionTimes;
        private System.Windows.Forms.ComboBox CmbSubAttributionValue;
        private System.Windows.Forms.ComboBox CmbSubAttribution;
        private System.Windows.Forms.Label LblAddSubAttr;
        private System.Windows.Forms.Label LblArtifactLevelTip;
        private System.Windows.Forms.GroupBox GrpSpawnRecord;
        private System.Windows.Forms.Button BtnRemoveSpawnLog;
        private System.Windows.Forms.ListBox ListSpawnLogs;
        private System.Windows.Forms.GroupBox GrpGiveItemRecord;
        private System.Windows.Forms.Button BtnSaveSpawnLog;
        private System.Windows.Forms.Button BtnSaveGiveItemLog;
        private System.Windows.Forms.Button BtnRemoveGiveItemLog;
        private System.Windows.Forms.ListBox ListGiveItemLogs;
        private System.Windows.Forms.ComboBox CmbArtifactPart;
        private System.Windows.Forms.ComboBox CmbArtifactSet;
        private System.Windows.Forms.Label LblArtifactSet;
        private System.Windows.Forms.NumericUpDown NUDArtifactStars;
        private System.Windows.Forms.Label LblArtifactStars;
        private System.Windows.Forms.Label LblArtifactPart;
        private System.Windows.Forms.Label LblArtifactName;
        private System.Windows.Forms.GroupBox GrpSetStats;
        private System.Windows.Forms.Label LblStatTip;
        private System.Windows.Forms.Label LblStatPercent;
        private System.Windows.Forms.NumericUpDown NUDStat;
        private System.Windows.Forms.ComboBox CmbStat;
        private System.Windows.Forms.TabPage TPAbout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel LnkGithub;
        private System.Windows.Forms.Label LblSupportDescription;
        private System.Windows.Forms.CheckBox ChkAccountSetUid;
        private System.Windows.Forms.NumericUpDown NUDAccountUid;
        private System.Windows.Forms.Button BtnDeleteAccount;
        private System.Windows.Forms.Button BtnCreateAccount;
        private System.Windows.Forms.Label LblAccountUserName;
        private System.Windows.Forms.TextBox TxtAccountUserName;
        private System.Windows.Forms.NumericUpDown NUDPermUID;
        private System.Windows.Forms.ComboBox CmbPerm;
        private System.Windows.Forms.ComboBox CmbClimateType;
        private System.Windows.Forms.Label LblClimateType;
        private System.Windows.Forms.Button BtnOpenGachaBannerEditor;
        private System.Windows.Forms.ComboBox CmbLanguage;
        private System.Windows.Forms.Label LblLanguage;
        private System.Windows.Forms.RadioButton RbEntityOrnament;
        private System.Windows.Forms.TabPage TPRemoteCall;
        private System.Windows.Forms.GroupBox GrpRemoteCommand;
        private System.Windows.Forms.TextBox TxtHost;
        private System.Windows.Forms.Label LblHost;
        private System.Windows.Forms.Button BtnQueryServerStatus;
        private System.Windows.Forms.Button BtnOpenTextMap;
        private System.Windows.Forms.Label LblRemotePlayerId;
        private System.Windows.Forms.NumericUpDown NUDRemotePlayerId;
        private System.Windows.Forms.Label LblPlayerCount;
        private System.Windows.Forms.Label LblPlayerCountLabel;
        private System.Windows.Forms.Label LblServerVersion;
        private System.Windows.Forms.Label LblServerVersionLabel;
        private System.Windows.Forms.GroupBox GrpServerStatus;
        private System.Windows.Forms.LinkLabel LnkOpenCommandLabel;
        private System.Windows.Forms.Label LblOpenCommandSupport;
        private System.Windows.Forms.Button BtnConnectOpenCommand;
        private System.Windows.Forms.Button BtnSendVerificationCode;
        private System.Windows.Forms.NumericUpDown NUDVerificationCode;
        private System.Windows.Forms.Label LblVerificationCode;
        private System.Windows.Forms.Button BtnInvokeOpenCommand;
        private System.Windows.Forms.LinkLabel LnkRCHelp;
        private System.Windows.Forms.ToolTip TTip;
    }
}

