using System.Windows.Forms;

namespace ProCUI
{
    public partial class ClientControl : UserControl
    {
        public ClientControl()
        {
            InitializeComponent();
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
                saveButton.Command = newValue.ClientCommands.Save;
                cancelButton.Command = newValue.ClientCommands.Cancel;
            }
            else
            {
                saveButton.Command = null;
                cancelButton.Command = null;
            }
        }
    }
}
