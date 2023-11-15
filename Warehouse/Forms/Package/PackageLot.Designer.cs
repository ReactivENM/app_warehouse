namespace Warehouse.Forms.Package
{
    partial class PackageLot
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
            this.packagesWithoutLot = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.packagesInLot = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.btnMoveToLot = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRemoveFromLot = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lotPackagesTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // packagesWithoutLot
            // 
            this.packagesWithoutLot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.packagesWithoutLot.Location = new System.Drawing.Point(12, 72);
            this.packagesWithoutLot.Name = "packagesWithoutLot";
            this.packagesWithoutLot.OverrideFocus.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.packagesWithoutLot.OverrideFocus.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.packagesWithoutLot.Size = new System.Drawing.Size(385, 497);
            this.packagesWithoutLot.StateCheckedPressed.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.packagesWithoutLot.StateCheckedPressed.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.packagesWithoutLot.StateCheckedTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.packagesWithoutLot.StateCheckedTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.packagesWithoutLot.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.packagesWithoutLot.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.packagesWithoutLot.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.packagesWithoutLot.StateCommon.Border.Rounding = 6;
            this.packagesWithoutLot.StateCommon.Border.Width = 2;
            this.packagesWithoutLot.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.packagesWithoutLot.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.packagesWithoutLot.StateCommon.Item.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.packagesWithoutLot.StateCommon.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.packagesWithoutLot.StateCommon.Item.Border.Color2 = System.Drawing.Color.Transparent;
            this.packagesWithoutLot.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.packagesWithoutLot.StateCommon.Item.Border.Rounding = 4;
            this.packagesWithoutLot.StateCommon.Item.Content.Padding = new System.Windows.Forms.Padding(5);
            this.packagesWithoutLot.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.packagesWithoutLot.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagesWithoutLot.StateDisabled.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.packagesWithoutLot.StateDisabled.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.packagesWithoutLot.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.packagesWithoutLot.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.packagesWithoutLot.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.packagesWithoutLot.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.packagesWithoutLot.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.packagesWithoutLot.StateNormal.Item.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.packagesWithoutLot.StateNormal.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.packagesWithoutLot.StateNormal.Item.Border.Color2 = System.Drawing.Color.Transparent;
            this.packagesWithoutLot.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.packagesWithoutLot.StateNormal.Item.Border.Rounding = 4;
            this.packagesWithoutLot.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.packagesWithoutLot.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagesWithoutLot.StatePressed.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.packagesWithoutLot.StatePressed.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.packagesWithoutLot.StatePressed.Item.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.packagesWithoutLot.StatePressed.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.packagesWithoutLot.StatePressed.Item.Border.Color2 = System.Drawing.Color.Transparent;
            this.packagesWithoutLot.StatePressed.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.packagesWithoutLot.StatePressed.Item.Content.Padding = new System.Windows.Forms.Padding(4);
            this.packagesWithoutLot.StatePressed.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.packagesWithoutLot.StatePressed.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagesWithoutLot.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.packagesWithoutLot.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.packagesWithoutLot.TabIndex = 0;
            // 
            // packagesInLot
            // 
            this.packagesInLot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.packagesInLot.Location = new System.Drawing.Point(528, 72);
            this.packagesInLot.Name = "packagesInLot";
            this.packagesInLot.Size = new System.Drawing.Size(385, 497);
            this.packagesInLot.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.packagesInLot.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.packagesInLot.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.packagesInLot.StateCommon.Border.Rounding = 6;
            this.packagesInLot.StateCommon.Border.Width = 2;
            this.packagesInLot.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.packagesInLot.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.packagesInLot.StateCommon.Item.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.packagesInLot.StateCommon.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.packagesInLot.StateCommon.Item.Border.Color2 = System.Drawing.Color.Transparent;
            this.packagesInLot.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.packagesInLot.StateCommon.Item.Border.Width = 2;
            this.packagesInLot.StateCommon.Item.Content.Padding = new System.Windows.Forms.Padding(5);
            this.packagesInLot.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.packagesInLot.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagesInLot.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.packagesInLot.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.packagesInLot.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.packagesInLot.StateNormal.Border.Width = 2;
            this.packagesInLot.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.packagesInLot.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagesInLot.TabIndex = 1;
            // 
            // btnMoveToLot
            // 
            this.btnMoveToLot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMoveToLot.Enabled = false;
            this.btnMoveToLot.Location = new System.Drawing.Point(411, 265);
            this.btnMoveToLot.Name = "btnMoveToLot";
            this.btnMoveToLot.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToLot.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToLot.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnMoveToLot.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnMoveToLot.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoveToLot.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMoveToLot.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveToLot.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToLot.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToLot.Size = new System.Drawing.Size(102, 43);
            this.btnMoveToLot.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnMoveToLot.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnMoveToLot.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoveToLot.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMoveToLot.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveToLot.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnMoveToLot.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnMoveToLot.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToLot.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToLot.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMoveToLot.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnMoveToLot.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnMoveToLot.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoveToLot.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMoveToLot.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveToLot.StateNormal.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.btnMoveToLot.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToLot.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToLot.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToLot.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToLot.TabIndex = 4;
            this.btnMoveToLot.Values.Text = ">";
            this.btnMoveToLot.Click += new System.EventHandler(this.btnMoteToLot_Click);
            // 
            // btnRemoveFromLot
            // 
            this.btnRemoveFromLot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveFromLot.Enabled = false;
            this.btnRemoveFromLot.Location = new System.Drawing.Point(411, 328);
            this.btnRemoveFromLot.Name = "btnRemoveFromLot";
            this.btnRemoveFromLot.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromLot.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromLot.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnRemoveFromLot.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnRemoveFromLot.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemoveFromLot.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRemoveFromLot.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromLot.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromLot.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromLot.Size = new System.Drawing.Size(102, 43);
            this.btnRemoveFromLot.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromLot.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromLot.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnRemoveFromLot.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnRemoveFromLot.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemoveFromLot.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRemoveFromLot.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromLot.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnRemoveFromLot.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnRemoveFromLot.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromLot.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromLot.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnRemoveFromLot.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnRemoveFromLot.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnRemoveFromLot.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemoveFromLot.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRemoveFromLot.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromLot.StateNormal.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.btnRemoveFromLot.StateNormal.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnRemoveFromLot.StateNormal.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnRemoveFromLot.StateNormal.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnRemoveFromLot.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnRemoveFromLot.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromLot.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromLot.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromLot.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromLot.TabIndex = 5;
            this.btnRemoveFromLot.Values.Text = "<";
            this.btnRemoveFromLot.Click += new System.EventHandler(this.btnRemoveFromLot_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Paquetes sin lote";
            // 
            // lotPackagesTitle
            // 
            this.lotPackagesTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lotPackagesTitle.AutoSize = true;
            this.lotPackagesTitle.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotPackagesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotPackagesTitle.Location = new System.Drawing.Point(521, 18);
            this.lotPackagesTitle.Name = "lotPackagesTitle";
            this.lotPackagesTitle.Size = new System.Drawing.Size(336, 42);
            this.lotPackagesTitle.TabIndex = 8;
            this.lotPackagesTitle.Text = "Paquetes dentro del lote";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lotPackagesTitle);
            this.panel1.Controls.Add(this.packagesWithoutLot);
            this.panel1.Controls.Add(this.packagesInLot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 581);
            this.panel1.TabIndex = 9;
            // 
            // PackageLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 581);
            this.Controls.Add(this.btnRemoveFromLot);
            this.Controls.Add(this.btnMoveToLot);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(941, 620);
            this.Name = "PackageLot";
            this.Text = "Paquetes en lote";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonListBox packagesWithoutLot;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox packagesInLot;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMoveToLot;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRemoveFromLot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lotPackagesTitle;
        private System.Windows.Forms.Panel panel1;
    }
}