using JustForWatchPaymentCsv.Define;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustForWatchPaymentCsv.Forms
{
    public partial class CsvColumnBindSelector : UserControl
    {
        //object
        public enum ErrorStatus
        {
            DUPLICATE,
            REQUIRED,
            NONE
        }
        //Properties
        private string _systemItem;
        public string SystemItem
        {
            get { return _systemItem; }
            set {
                this.systemName_label.Text = value;
                _systemItem = value;
            }
        }

        public event EventHandler TargetItemChanged;

        private string[] _targetColumns;
        public string[] TargetColumns
        {
            get { return _targetColumns; }
            set { 
                this.csvItems_comboBox.Items.Clear();
                List<string> list = new List<string>();
                list.Add("") ;
                if (value != null) list.AddRange(value);
                this.csvItems_comboBox.Items.AddRange(list.ToArray());
                _targetColumns = value;
            }
        }

        public string  TargetColumnName
        {
            get { return this.csvItems_comboBox.Text; }
        }
        public string[] TargetCsvItem { get; private set; }

        private bool _editable;
        public bool Editable
        {
            get { return _editable; }
            set {
                this.csvItems_comboBox.Enabled = value;
                _editable = value;
            }
        }


        private bool _required;
        public bool Required
        {
            get { return _required; }
            set {
                this.systemName_label.Text = (value ? "*" : "") + SystemItem ;
                _required = value;
            }
        }



        //Constractors
        public CsvColumnBindSelector()
        {
            InitializeComponent();
        }
        public CsvColumnBindSelector(string systemItem, string[] targetCsvColumns,bool is_required):this()
        {
            SystemItem = systemItem;
            TargetColumns = targetCsvColumns;
            Required = is_required;
        }

        //controls
        public void SetEditableMode(bool editable,string init_display_name = "",int init_selected_index = -1)
        {
            Editable = editable;
            this.csvItems_comboBox.Text = init_display_name;
            this.csvItems_comboBox.SelectedIndex = init_selected_index;
        }
        private void csvItems_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TargetItemChanged(this,new EventArgs());
        }
        public void SetErrorStatus(ErrorStatus error)
        {
            switch (error)
            {
                case ErrorStatus.DUPLICATE:
                    this.errorMessage_label.Text = SystemMessages.ErrorMessages.Duplicated;
                    this.errorMessage_label.Visible = true;
                    break;
                case ErrorStatus.REQUIRED:
                    this.errorMessage_label.Text = SystemMessages.ErrorMessages.IsRequired;
                    this.errorMessage_label.Visible = true;
                    break;
                case ErrorStatus.NONE:
                    this.errorMessage_label.Visible = false;
                    break;
            }
        }
    }
}
