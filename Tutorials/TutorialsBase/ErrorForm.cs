﻿using System;
using System.Windows.Forms;

namespace TutorialsBase
{
    /// <summary>
    /// Applicaton error dialog
    /// </summary>
    partial class ErrorForm : Form
    {
        #region Ctor

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        /// <param name="title">dialog title</param>
        /// <param name="message">error header message</param>
        /// <param name="exception">exception as any</param>
        public ErrorForm(string title, string message, Exception exception)
        {
            InitializeComponent();
            this.Text = title;
            if (null == message)
                message = "An error is occured.";
              
            labelErrorMessage.Text = message;
            DisplayException(exception);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Creates an instance of FormError and show
        /// </summary>
        /// <param name="parentDialog">modal owner</param>
        /// <param name="title">dialog title</param>
        /// <param name="message">error header message</param>
        /// <param name="exception">exception as any</param>
        public static void Show(Control parentDialog, string title, string message, Exception exception)
        {
            ErrorForm form = new ErrorForm(title, message, exception);
            form.ShowDialog(parentDialog);
        }

        private void DisplayException(Exception exception)
        {
            listViewTrace.Items.Clear();

            if (null == exception)
                return;

            int i = 1;
            while (exception != null)
            {
                ListViewItem viewItem = listViewTrace.Items.Add(i.ToString());
                viewItem.SubItems.Add(exception.Message);
                viewItem.SubItems.Add(exception.GetType().Name.ToString());
                if (null != exception.TargetSite)
                    viewItem.SubItems.Add(exception.TargetSite.ToString());
                else
                    viewItem.SubItems.Add("");
                exception = exception.InnerException;
                i++;
            }
        }

        #endregion

        #region Trigger

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
