﻿using System;
using System.Collections.Generic;

namespace Lab9.Models.DataAccess
{
    public partial class EmployeeRole
    {
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }

        public virtual EmployeeMetaData Employee { get; set; }
        public virtual Role Role { get; set; }
    }
}
