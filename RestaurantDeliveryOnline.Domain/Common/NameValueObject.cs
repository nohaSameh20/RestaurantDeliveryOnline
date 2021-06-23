using System;
using System.Collections.Generic;
using System.Text;
using static CharityProject.Domain.Common.Enum;

namespace CharityProject.Domain.Common
{
    public class DisplayNameValueObject : IValueObject
    {
        public string Name { set; get; }
    }
}
