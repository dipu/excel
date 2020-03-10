﻿namespace Dipu.Excel
{
    public interface ICell
    {
        IWorksheet Worksheet { get; }

        IRow Row { get; }

        IColumn Column { get; }
                
        object Value { get; set; }

        Range Options { get; set; }

        bool IsRequired { get; set; }

        string Comment { get; set; }

        Style Style { get; set; }

        string NumberFormat { get; set; }

        IValueConverter ValueConverter { get; set; }

        void Clear();
    }
}
