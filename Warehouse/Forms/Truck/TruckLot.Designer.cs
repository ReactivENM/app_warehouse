namespace Warehouse.Forms.Truck
{
    partial class TruckLot
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
            this.lotsWithoutTruck = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lotsInTruck = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.btnRemoveFromTruck = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnMoveToTruck = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lotPackagesTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lotsWithoutTruck
            // 
            this.lotsWithoutTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lotsWithoutTruck.Location = new System.Drawing.Point(12, 72);
            this.lotsWithoutTruck.Name = "lotsWithoutTruck";
            this.lotsWithoutTruck.OverrideFocus.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.lotsWithoutTruck.OverrideFocus.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.lotsWithoutTruck.Size = new System.Drawing.Size(385, 497);
            this.lotsWithoutTruck.StateCheckedPressed.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.lotsWithoutTruck.StateCheckedPressed.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.lotsWithoutTruck.StateCheckedTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.lotsWithoutTruck.StateCheckedTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.lotsWithoutTruck.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotsWithoutTruck.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotsWithoutTruck.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lotsWithoutTruck.StateCommon.Border.Rounding = 6;
            this.lotsWithoutTruck.StateCommon.Border.Width = 2;
            this.lotsWithoutTruck.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotsWithoutTruck.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotsWithoutTruck.StateCommon.Item.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.lotsWithoutTruck.StateCommon.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.lotsWithoutTruck.StateCommon.Item.Border.Color2 = System.Drawing.Color.Transparent;
            this.lotsWithoutTruck.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lotsWithoutTruck.StateCommon.Item.Border.Rounding = 4;
            this.lotsWithoutTruck.StateCommon.Item.Content.Padding = new System.Windows.Forms.Padding(5);
            this.lotsWithoutTruck.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.lotsWithoutTruck.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotsWithoutTruck.StateDisabled.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.lotsWithoutTruck.StateDisabled.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.lotsWithoutTruck.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotsWithoutTruck.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotsWithoutTruck.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lotsWithoutTruck.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotsWithoutTruck.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotsWithoutTruck.StateNormal.Item.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.lotsWithoutTruck.StateNormal.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.lotsWithoutTruck.StateNormal.Item.Border.Color2 = System.Drawing.Color.Transparent;
            this.lotsWithoutTruck.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lotsWithoutTruck.StateNormal.Item.Border.Rounding = 4;
            this.lotsWithoutTruck.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.lotsWithoutTruck.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotsWithoutTruck.StatePressed.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.lotsWithoutTruck.StatePressed.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.lotsWithoutTruck.StatePressed.Item.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.lotsWithoutTruck.StatePressed.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.lotsWithoutTruck.StatePressed.Item.Border.Color2 = System.Drawing.Color.Transparent;
            this.lotsWithoutTruck.StatePressed.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lotsWithoutTruck.StatePressed.Item.Content.Padding = new System.Windows.Forms.Padding(4);
            this.lotsWithoutTruck.StatePressed.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.lotsWithoutTruck.StatePressed.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotsWithoutTruck.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.lotsWithoutTruck.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(84)))));
            this.lotsWithoutTruck.TabIndex = 0;
            // 
            // lotsInTruck
            // 
            this.lotsInTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lotsInTruck.Location = new System.Drawing.Point(528, 72);
            this.lotsInTruck.Name = "lotsInTruck";
            this.lotsInTruck.Size = new System.Drawing.Size(385, 497);
            this.lotsInTruck.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotsInTruck.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotsInTruck.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lotsInTruck.StateCommon.Border.Rounding = 6;
            this.lotsInTruck.StateCommon.Border.Width = 2;
            this.lotsInTruck.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotsInTruck.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotsInTruck.StateCommon.Item.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.lotsInTruck.StateCommon.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.lotsInTruck.StateCommon.Item.Border.Color2 = System.Drawing.Color.Transparent;
            this.lotsInTruck.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lotsInTruck.StateCommon.Item.Border.Width = 2;
            this.lotsInTruck.StateCommon.Item.Content.Padding = new System.Windows.Forms.Padding(5);
            this.lotsInTruck.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.lotsInTruck.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotsInTruck.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotsInTruck.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotsInTruck.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lotsInTruck.StateNormal.Border.Width = 2;
            this.lotsInTruck.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.lotsInTruck.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotsInTruck.TabIndex = 1;
            // 
            // btnRemoveFromTruck
            // 
            this.btnRemoveFromTruck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveFromTruck.Enabled = false;
            this.btnRemoveFromTruck.Location = new System.Drawing.Point(411, 328);
            this.btnRemoveFromTruck.Name = "btnRemoveFromTruck";
            this.btnRemoveFromTruck.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromTruck.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromTruck.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromTruck.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromTruck.Size = new System.Drawing.Size(102, 43);
            this.btnRemoveFromTruck.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromTruck.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromTruck.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRemoveFromTruck.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnRemoveFromTruck.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold);
            this.btnRemoveFromTruck.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnRemoveFromTruck.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnRemoveFromTruck.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRemoveFromTruck.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromTruck.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromTruck.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromTruck.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnRemoveFromTruck.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnRemoveFromTruck.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnRemoveFromTruck.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemoveFromTruck.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRemoveFromTruck.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromTruck.StateNormal.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.btnRemoveFromTruck.StateNormal.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnRemoveFromTruck.StateNormal.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnRemoveFromTruck.StateNormal.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnRemoveFromTruck.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnRemoveFromTruck.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromTruck.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromTruck.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromTruck.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnRemoveFromTruck.TabIndex = 11;
            this.btnRemoveFromTruck.Values.Text = "<";
            this.btnRemoveFromTruck.Click += new System.EventHandler(this.btnRemoveFromLot_Click);
            // 
            // btnMoveToTruck
            // 
            this.btnMoveToTruck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMoveToTruck.Enabled = false;
            this.btnMoveToTruck.Location = new System.Drawing.Point(411, 265);
            this.btnMoveToTruck.Name = "btnMoveToTruck";
            this.btnMoveToTruck.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToTruck.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToTruck.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnMoveToTruck.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnMoveToTruck.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoveToTruck.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMoveToTruck.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnMoveToTruck.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveToTruck.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToTruck.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToTruck.Size = new System.Drawing.Size(102, 43);
            this.btnMoveToTruck.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToTruck.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToTruck.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMoveToTruck.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnMoveToTruck.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold);
            this.btnMoveToTruck.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnMoveToTruck.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnMoveToTruck.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMoveToTruck.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnMoveToTruck.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveToTruck.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToTruck.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToTruck.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMoveToTruck.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnMoveToTruck.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnMoveToTruck.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoveToTruck.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMoveToTruck.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnMoveToTruck.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveToTruck.StateNormal.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.btnMoveToTruck.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToTruck.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToTruck.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToTruck.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnMoveToTruck.TabIndex = 10;
            this.btnMoveToTruck.Values.Text = ">";
            this.btnMoveToTruck.Click += new System.EventHandler(this.btnMoteToLot_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lotes sin asignar";
            // 
            // lotPackagesTitle
            // 
            this.lotPackagesTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lotPackagesTitle.AutoSize = true;
            this.lotPackagesTitle.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotPackagesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.lotPackagesTitle.Location = new System.Drawing.Point(521, 18);
            this.lotPackagesTitle.Name = "lotPackagesTitle";
            this.lotPackagesTitle.Size = new System.Drawing.Size(238, 42);
            this.lotPackagesTitle.TabIndex = 8;
            this.lotPackagesTitle.Text = "Lotes del camión";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lotPackagesTitle);
            this.panel1.Controls.Add(this.lotsWithoutTruck);
            this.panel1.Controls.Add(this.lotsInTruck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 581);
            this.panel1.TabIndex = 12;
            // 
            // TruckLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 581);
            this.Controls.Add(this.btnRemoveFromTruck);
            this.Controls.Add(this.btnMoveToTruck);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(941, 620);
            this.Name = "TruckLot";
            this.Text = "Lotes en camión";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonListBox lotsWithoutTruck;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lotsInTruck;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRemoveFromTruck;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMoveToTruck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lotPackagesTitle;
        private System.Windows.Forms.Panel panel1;
    }
}