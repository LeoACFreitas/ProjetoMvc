﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoMvc.ViewModels
{
    public class EmployeeListViewModel
    {

        public List<EmployeeViewModel> Employees {get; set;}
        public string UserName { get; set; }
        public FooterViewModel FooterData { get; set; }

    }
}