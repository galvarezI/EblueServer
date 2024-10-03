﻿using System;
using System.Collections.Generic;

namespace EblueWorkPlan.Models;

public partial class ProjectNote
{
    public int ProjectNotesId { get; set; }

    public string Comment { get; set; }

    public DateTime? LastUpdate { get; set; }

    public int? ProjectId { get; set; }

    public int? RosterId { get; set; }

    public string Username { get; set; }

    public string DepartmentDirectorComments { get; set; }

    public string DeanComments { get; set; }

    public string Roles { get; set; }

    public string UserRole { get; set; }

    public virtual Project Project { get; set; }

    public virtual User ProjectNavigation { get; set; }

    public virtual Roster Roster { get; set; }
}
