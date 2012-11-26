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
using System.Web;
using SageFrame.Web;
using SageFrame.Framework;

public partial class Modules_AspxItemRatingManagement_ItemRatingManagement : BaseAdministrationUserControl
{
    public string UserIP;
    public string CountryName = string.Empty;
    public int StoreID, PortalID;
    public string UserName, CultureName;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                IncludeCss("ItemRatingManagement", "/Templates/" + TemplateName + "/css/GridView/tablesort.css", "/Templates/" + TemplateName + "/css/MessageBox/style.css", "/Templates/" + TemplateName + "/css/StarRating/jquery.rating.css");
                IncludeJs("ItemRatingManagement", "/js/FormValidation/jquery.validate.js", "/js/GridView/jquery.grid.js", "/js/GridView/SagePaging.js", "/js/GridView/jquery.global.js",
                            "/js/GridView/jquery.dateFormat.js", "/js/MessageBox/jquery.easing.1.3.js", "/js/MessageBox/alertbox.js", "/js/StarRating/jquery.rating.js",
                            "/js/StarRating/jquery.rating.js", "/js/StarRating/jquery.rating.pack.js",
                            "/Modules/AspxCommerce/AspxItemRatingManagement/js/ItemRatingManage.js");

                StoreID = GetStoreID;
                PortalID = GetPortalID;
                UserName = GetUsername;
                CultureName = GetCurrentCultureName;
            }
        }
        catch (Exception ex)
        {
            ProcessException(ex);
        }
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        try
        {
            UserIP = HttpContext.Current.Request.UserHostAddress;
            IPAddressToCountryResolver ipToCountry = new IPAddressToCountryResolver();
            ipToCountry.GetCountry(UserIP, out CountryName);
            InitializeJS();
        }
        catch (Exception ex)
        {
            ProcessException(ex);
        }
    }

    private void InitializeJS()
    {
        Page.ClientScript.RegisterClientScriptInclude("metadata", ResolveUrl("~/js/StarRating/jquery.MetaData.js"));
        Page.ClientScript.RegisterClientScriptInclude("JTablesorter", ResolveUrl("~/js/GridView/jquery.tablesorter.js"));    
    }
}
