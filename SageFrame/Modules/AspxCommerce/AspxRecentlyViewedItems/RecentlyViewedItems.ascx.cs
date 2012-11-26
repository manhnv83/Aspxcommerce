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
using AspxCommerce.Core;

public partial class Modules_AspxRecentlyViewedItems_RecentlyViewedItems : BaseAdministrationUserControl
{
    public string SessionCode = string.Empty;
    public int StoreID, PortalID;
    public string UserName, CultureName;
    public int CountViewedItems;
    public string EnableRecentlyViewed;
    protected void Page_Init(object sender, EventArgs e)
    {
        
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                IncludeCss("RecentlyViewedItems", "/Templates/" + TemplateName + "/css/MessageBox/style.css");
                IncludeJs("RecentlyViewedItems", "/js/MessageBox/jquery.easing.1.3.js", "/js/MessageBox/alertbox.js",
                    "/Modules/AspxCommerce/AspxRecentlyViewedItems/js/RecentlyViewedItems.js");
                StoreID = GetStoreID;
                PortalID = GetPortalID;
                UserName = GetUsername;
                CultureName = GetCurrentCultureName;
                if (HttpContext.Current.Session.SessionID != null)
                {
                    SessionCode = HttpContext.Current.Session.SessionID.ToString();
                }

                StoreSettingConfig ssc = new StoreSettingConfig();
                CountViewedItems = int.Parse(ssc.GetStoreSettingsByKey(StoreSetting.NoOfRecentlyViewedItemsDispay, StoreID, PortalID, CultureName));
                EnableRecentlyViewed = ssc.GetStoreSettingsByKey(StoreSetting.EnableRecentlyViewedItems, StoreID, PortalID, CultureName);
            }
        }
        catch (Exception ex)
        {
            ProcessException(ex);
        }
    }
}
