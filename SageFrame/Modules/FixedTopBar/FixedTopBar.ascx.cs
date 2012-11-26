﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SageFrame.Web;

public partial class Modules_FixedTopBar_FixedTopBar : BaseAdministrationUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

       
        if (!IsPostBack)
            {
                IncludeCss("FixedTopBar","/Modules/FixedTopBar/css/fixed_top_bar.css");
                IncludeJs("FixedTopBar", "/Modules/FixedTopBar/js/fixed_top_bar.js");
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
