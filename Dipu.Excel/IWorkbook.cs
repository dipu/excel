﻿using System.Collections.Generic;

namespace Dipu.Excel
{
    public interface IWorkbook
    {
        bool IsActive { get; }

        IWorksheet[] Worksheets { get; }

        void Close(bool? saveChanges = null, string fileName = null);

        IWorksheet AddWorksheet(int? index = null, IWorksheet before = null, IWorksheet after = null);

        IWorksheet Copy(IWorksheet source, IWorksheet beforeWorksheet);

        Range[] GetNamedRanges();
    }
}
