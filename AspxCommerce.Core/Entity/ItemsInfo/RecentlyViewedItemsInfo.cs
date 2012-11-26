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
using System.Runtime.Serialization;

namespace AspxCommerce.Core
{
    [DataContract]
    [Serializable]
    public class RecentlyViewedItemsInfo
    {
        #region "Private Members"
        int _itemID;
        string _itemName;
        string _sku;
        #endregion
        #region "Constructors"
        public RecentlyViewedItemsInfo()
        {
        }
        public RecentlyViewedItemsInfo(int itemID, string itemName, string sku)
        {
            this.ItemID = itemID;
            this.ItemName = itemName;
            this.SKU = sku;
        }
        #endregion
        #region "Public Members"
        [DataMember]
        public int ItemID
        {
            get { return _itemID; }
            set { _itemID = value; }
        }
        [DataMember]
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        [DataMember]
        public string SKU
        {
            get { return _sku; }
            set { _sku = value; }
        }
        #endregion
    }
}
