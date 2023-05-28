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
using JustForWatchPaymentCsv.Define;

namespace JustForWatchPaymentCsv.Forms
{
    public partial class MappingCsvForm : Form
    {
        private MappingCsvForm()
        {
            InitializeComponent();
        }
        string[] _titles;
        public MappingCsvForm(string[] targetFileNames, string[] titles):this()
        {
            targetFile_label.Text = String.Join(",", targetFileNames) + "の紐づけ";
            _titles = titles;
            SetBindingItems();
        }
        public void SetBindingItems()
        {

            SystemItems.SystemItemObject[] items= SystemItems.Items;
            int index = 0;
            foreach(SystemItems.SystemItemObject item in items)
            {
                CsvColumnBindSelector bindselector = new CsvColumnBindSelector(item.Name,_titles,item.Require);
                bindselector.Tag = index;
                bindselector.TargetItemChanged += TartgetCsvItemChanged;

                flowLayoutPanel1.Controls.Add(bindselector);
                flowLayoutPanel1.SetFlowBreak(bindselector, true);
                index++;
            }

        }
        private void TartgetCsvItemChanged(object sender, EventArgs e)
        {
            CsvColumnBindSelector src_selector = sender as CsvColumnBindSelector;
            if (src_selector is null) return;
            List<CsvColumnBindSelector> selectors = new List<CsvColumnBindSelector>();
            foreach(Control control in flowLayoutPanel1.Controls) {
                CsvColumnBindSelector selector = control as CsvColumnBindSelector;
                if (selector == null) return;
                selectors.Add(selector);
            }

            List<string> selectedTargetNames = selectors.Select(item => item.TargetColumnName).ToList();
            int target_index = (int)src_selector.Tag;
            for (int i = 0; i < selectedTargetNames.Count; i++)
            {
                CsvColumnBindSelector bindSelector = selectors[i];

                if (target_index == i)
                {
                    if (bindSelector.Required && String.IsNullOrEmpty(bindSelector.TargetColumnName))
                    {
                        bindSelector.SetErrorStatus(CsvColumnBindSelector.ErrorStatus.REQUIRED);
                        continue;
                    }
                }
                else {
                    if (String.IsNullOrEmpty(bindSelector.TargetColumnName)) continue;
                }
                CsvColumnBindSelector[] duplicate_binder = selectors.Where(item => item.TargetColumnName == bindSelector.TargetColumnName).ToArray();
                if (duplicate_binder.Length == 1) {
                    bindSelector.SetErrorStatus(CsvColumnBindSelector.ErrorStatus.NONE);
                    continue;
                }
                foreach(CsvColumnBindSelector selector in duplicate_binder)
                {
                    selector.SetErrorStatus(CsvColumnBindSelector.ErrorStatus.DUPLICATE);
                }

            }

        }
    }
}
