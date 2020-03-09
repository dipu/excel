﻿namespace Dipu.Excel
{
    public interface IRow
    {
        IWorksheet Worksheet { get; }

        int Index { get; }

        bool Hidden { get; set; }
    }
}
