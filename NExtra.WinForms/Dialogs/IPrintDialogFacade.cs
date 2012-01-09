﻿using System.Windows.Forms;

namespace NExtra.WinForms.Dialogs
{
    /// <summary>
    /// This interface can be implemented by classes that
    /// should be able to be used as facade classes for a
    /// PrintDialog instance.
    /// </summary>
    public interface IPrintDialogFacade
    {
        /// <summary>
        /// The base PrintDialog instance.
        /// </summary>
        PrintDialog PrintDialog { get; }

        /// <summary>
        /// Show the PrintDialog.
        /// </summary>
        DialogResult ShowDialog();
    }
}