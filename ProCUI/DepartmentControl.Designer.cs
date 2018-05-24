namespace ProCUI
{
    partial class DepartmentControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.saveButton = new DevComponents.DotNetBar.ButtonX();
            this.labelDepartmentTitle = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbxDescribe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tbxDepartmentName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxManager = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(301, 331);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(176, 58);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 32;
            this.cancelButton.Text = "取消";
            // 
            // saveButton
            // 
            this.saveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.saveButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.saveButton.Location = new System.Drawing.Point(113, 331);
            this.saveButton.Margin = new System.Windows.Forms.Padding(6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(176, 58);
            this.saveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "保存";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // labelDepartmentTitle
            // 
            // 
            // 
            // 
            this.labelDepartmentTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelDepartmentTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartmentTitle.Location = new System.Drawing.Point(171, 28);
            this.labelDepartmentTitle.Margin = new System.Windows.Forms.Padding(6);
            this.labelDepartmentTitle.Name = "labelDepartmentTitle";
            this.labelDepartmentTitle.Size = new System.Drawing.Size(212, 76);
            this.labelDepartmentTitle.TabIndex = 30;
            this.labelDepartmentTitle.Text = "新建部门";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(37, 229);
            this.labelX3.Margin = new System.Windows.Forms.Padding(6);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(150, 92);
            this.labelX3.TabIndex = 27;
            this.labelX3.Text = "管理人员:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(37, 178);
            this.labelX2.Margin = new System.Windows.Forms.Padding(6);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(150, 60);
            this.labelX2.TabIndex = 25;
            this.labelX2.Text = "职能描述:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tbxDescribe
            // 
            this.tbxDescribe.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbxDescribe.Border.Class = "TextBoxBorder";
            this.tbxDescribe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxDescribe.DisabledBackColor = System.Drawing.Color.White;
            this.tbxDescribe.ForeColor = System.Drawing.Color.Black;
            this.tbxDescribe.Location = new System.Drawing.Point(199, 190);
            this.tbxDescribe.Margin = new System.Windows.Forms.Padding(6);
            this.tbxDescribe.Name = "tbxDescribe";
            this.tbxDescribe.Size = new System.Drawing.Size(313, 35);
            this.tbxDescribe.TabIndex = 24;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(37, 116);
            this.labelX1.Margin = new System.Windows.Forms.Padding(6);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(150, 68);
            this.labelX1.TabIndex = 23;
            this.labelX1.Text = "部门名称:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tbxDepartmentName
            // 
            this.tbxDepartmentName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbxDepartmentName.Border.Class = "TextBoxBorder";
            this.tbxDepartmentName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxDepartmentName.DisabledBackColor = System.Drawing.Color.White;
            this.tbxDepartmentName.ForeColor = System.Drawing.Color.Black;
            this.tbxDepartmentName.Location = new System.Drawing.Point(199, 130);
            this.tbxDepartmentName.Margin = new System.Windows.Forms.Padding(6);
            this.tbxDepartmentName.Name = "tbxDepartmentName";
            this.tbxDepartmentName.Size = new System.Drawing.Size(313, 35);
            this.tbxDepartmentName.TabIndex = 22;
            // 
            // cbxManager
            // 
            this.cbxManager.DisplayMember = "Text";
            this.cbxManager.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxManager.ForeColor = System.Drawing.Color.Black;
            this.cbxManager.FormattingEnabled = true;
            this.cbxManager.ItemHeight = 30;
            this.cbxManager.Location = new System.Drawing.Point(199, 253);
            this.cbxManager.Margin = new System.Windows.Forms.Padding(6);
            this.cbxManager.Name = "cbxManager";
            this.cbxManager.Size = new System.Drawing.Size(313, 36);
            this.cbxManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbxManager.TabIndex = 33;
            // 
            // DepartmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxManager);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.labelDepartmentTitle);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tbxDescribe);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.tbxDepartmentName);
            this.Name = "DepartmentControl";
            this.Size = new System.Drawing.Size(600, 502);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX saveButton;
        private DevComponents.DotNetBar.LabelX labelDepartmentTitle;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxDescribe;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxDepartmentName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxManager;
    }
}
