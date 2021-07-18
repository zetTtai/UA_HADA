﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
namespace usuWeb
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (MenuItem item in Menu1.Items)
            {
                if (item.NavigateUrl.Equals(Request.AppRelativeCurrentExecutionFilePath, StringComparison.InvariantCultureIgnoreCase))
                {
                    item.Selected = true;
                }
            }
        }
    }
}