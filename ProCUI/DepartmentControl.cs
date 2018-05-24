using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProCTools;
using ProCModel;

namespace ProCUI
{
    public partial class DepartmentControl : UserControl
    {
        public DepartmentControl()
        {
            InitializeComponent();

            cbxManager.DataSource = ProCDBTool.GetUsers();
            cbxManager.DisplayMember = "name";
            cbxManager.ValueMember = "userid";
        }
        private ProCCommands _Commands;
        /// <summary>
        /// Gets or sets the commands associated with the control.
        /// </summary>
        public ProCCommands Commands
        {
            get { return _Commands; }
            set
            {
                if (value != _Commands)
                {
                    ProCCommands oldValue = _Commands;
                    _Commands = value;
                    OnCommandsChanged(oldValue, value);
                }
            }
        }
        /// <summary>
        /// Called when Commands property has changed.
        /// </summary>
        /// <param name="oldValue">Old property value</param>
        /// <param name="newValue">New property value</param>
        protected virtual void OnCommandsChanged(ProCCommands oldValue, ProCCommands newValue)
        {
            if (newValue != null)
            {
                saveButton.Command = newValue.DepartmentCommands.Save;
                cancelButton.Command = newValue.DepartmentCommands.Cancel;
            }
            else
            {
                saveButton.Command = null;
                cancelButton.Command = null;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveButton.CommandParameter = new TDepartment { deptname = tbxDepartmentName.Text.Trim(), description = tbxDescribe.Text.Trim(),manager = cbxManager.SelectedValue.ToString() };
        }
    }
}
