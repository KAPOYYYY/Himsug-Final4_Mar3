using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Himsug_Final4.Shared.DateConvert
{
    public class DateOnlyConverter : ValueConverter<DateOnly,DateTime>
    {
        public DateOnlyConverter() : base(
            dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue),
            dateTime => DateOnly.FromDateTime(dateTime))
        {

        }
    }
}
