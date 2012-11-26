﻿/*
AspxCommerce® - http://www.AspxCommerce.com
Copyright (c) 20011-2012 by AspxCommerce
Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System;
using SageFrame.Web;
using AspxCommerce.Core;

public partial class Modules_AspxPopularTags_PopularTags : BaseAdministrationUserControl
{
    public int StoreID, PortalID,NoOfPopTags;
    public string UserName, CultureName;
    protected void page_init(object sender, EventArgs e)
    {
        try
        {
            InitializeJS();
        }
        catch (Exception ex)
        {
            ProcessException(ex);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                IncludeCss("PopularTags", "/Templates/" + TemplateName + "/css/MessageBox/style.css");
                IncludeJs("PopularTags", "/Modules/AspxCommerce/AspxPopularTags/js/PopularTag.js");
                StoreID = GetStoreID;
                PortalID = GetPortalID;
                UserName = GetUsername;
                CultureName = GetCurrentCultureName;

                StoreSettingConfig ssc = new StoreSettingConfig();
                NoOfPopTags = int.Parse(ssc.GetStoreSettingsByKey(StoreSetting.NoOfPopularTags, StoreID, PortalID, CultureName));
            }
        }
        catch (Exception ex)
        {
            ProcessException(ex);
        }
    }

    private void InitializeJS()
    {
       Page.ClientScript.RegisterClientScriptInclude("JTablesorter", ResolveUrl("~/js/GridView/jquery.tablesorter.js"));
    }
}
