﻿/*
AspxCommerce® - http://www.aspxcommerce.com
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

public partial class Modules_AspxShoppingBagHeader_ShoppingBagHeader : BaseAdministrationUserControl
{
    public int StoreID, PortalID, CustomerID;
    public string UserName, CultureName;
    public string SessionCode = string.Empty;
    public string ShowMiniShopCart, AllowMultipleAddChkOut, MinOrderAmount,AllowAnonymousCheckOut,ShoppingCartURL;
    public bool IsUseFriendlyUrls = true;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SageFrameConfig pagebase = new SageFrameConfig();
            IsUseFriendlyUrls = pagebase.GetSettingBollByKey(SageFrameSettingKeys.UseFriendlyUrls);
            if (!IsPostBack)
            {
                IncludeCss("ShoppingBagHeader", "/Templates/" + TemplateName + "/css/PopUp/style.css", "/Templates/" + TemplateName + "/css/MessageBox/style.css");
                IncludeJs("ShoppingBagHeader", "/js/PopUp/custom.js", "/js/MessageBox/jquery.easing.1.3.js", "/js/MessageBox/alertbox.js", "/js/Session.js",
                    "Modules/AspxCommerce/AspxShoppingBagHeader/js/ShoppingBag.js");
                StoreID = GetStoreID;
                PortalID = GetPortalID;
                CustomerID = GetCustomerID;
                UserName = GetUsername;
                CultureName = GetCurrentCultureName;

                if (HttpContext.Current.Session.SessionID != null)
                {
                    SessionCode = HttpContext.Current.Session.SessionID.ToString();
                }

                StoreSettingConfig ssc = new StoreSettingConfig();
                ShowMiniShopCart = ssc.GetStoreSettingsByKey(StoreSetting.ShowMiniShoppingCart, StoreID, PortalID, CultureName);
                AllowMultipleAddChkOut = ssc.GetStoreSettingsByKey(StoreSetting.AllowMultipleShippingAddress, StoreID, PortalID, CultureName);
                MinOrderAmount = ssc.GetStoreSettingsByKey(StoreSetting.MinimumOrderAmount, StoreID, PortalID, CultureName);
                AllowAnonymousCheckOut = ssc.GetStoreSettingsByKey(StoreSetting.AllowAnonymousCheckOut, StoreID, PortalID, CultureName);
                ShoppingCartURL = ssc.GetStoreSettingsByKey(StoreSetting.ShoppingCartURL, StoreID, PortalID, CultureName);
            }
        }
        catch (Exception ex)
        {
            ProcessException(ex);
        }
    }

    protected void Page_Init(object sender, EventArgs e)
    {
       
    }
}
