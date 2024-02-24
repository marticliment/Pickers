﻿using Pickers.Classes;
using Pickers.Enums;

namespace Pickers;

/// <summary>
/// Class responsible for folder pick dialog.
/// </summary>
public class FolderPicker
{
    /// <summary>
    /// Window handle where dialog should appear.
    /// </summary>
    private readonly IntPtr _windowHandle;

    public FolderPicker(IntPtr windowHandle)
    {
        _windowHandle = windowHandle;
    }

    /// <summary>
    /// Shows folder pick dialog.
    /// </summary>
    /// <returns>Path to selected folder or empty string.</returns>
    public string Show()
    {
        return Helper.Show(_windowHandle, FOS.FOS_PICKFOLDERS | FOS.FOS_FORCEFILESYSTEM);
    }
}
