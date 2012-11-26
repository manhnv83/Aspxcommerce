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
    public class ItemBasicDetailsInfo
    {
        #region Constructor
        public ItemBasicDetailsInfo()
        {
        }
        #endregion

        #region Private Fields
        [DataMember]
        private int _rowTotal;
        [DataMember]
        private int _itemID;

        [DataMember]
        private System.Nullable<System.DateTime> _dateFrom;

        [DataMember]
        private System.Nullable<System.DateTime> _dateTo;

        [DataMember]
        private string  _isFeatured;

        [DataMember]
        private string _sku;

        [DataMember]
        private string _name;

        [DataMember]
        private string _description;

        [DataMember]
        private string _shortDescription;

        [DataMember]
        private int _quantity;

        [DataMember]
        private string _price;

        [DataMember]
        private string _weight;

        [DataMember]
        private string _listPrice;

        [DataMember]
        private System.Nullable<bool> _hidePrice;

        [DataMember]
        private System.Nullable<bool> _hideInRSSFeed;

        [DataMember]
        private System.Nullable<bool> _hideToAnonymous;

        [DataMember]
        private System.Nullable<bool> _isOutOfStock;
        
        [DataMember]
        private System.Nullable<System.DateTime> _addedOn;

        [DataMember]
        private string _imagePath;

        [DataMember]
        private string _alternateText;

        [DataMember]
        private int _taxRuleID;

        [DataMember]
        private string _taxRateValue;

        [DataMember]
        private string _sampleLink;

        [DataMember]
        private string _sampleFile;

        [DataMember]
        private string _discountPrice;
        #endregion

        #region Public Fields     

        public int RowTotal
        {
            get
            {
                return this._rowTotal;
            }
            set
            {
                if ((this._rowTotal != value))
                {
                    this._rowTotal = value;
                }
            }
        }

        public int ItemID
        {
            get
            {
                return this._itemID;
            }
            set
            {
                if ((this._itemID != value))
                {
                    this._itemID = value;
                }
            }
        }

        public System.Nullable<System.DateTime> DateFrom
        {
            get
            {
                return this._dateFrom;
            }
            set
            {
                if ((this._dateFrom != value))
                {
                    this._dateFrom = value;
                }
            }
        }

        public System.Nullable<System.DateTime> DateTo
        {
            get
            {
                return this._dateTo;
            }
            set
            {
                if ((this._dateTo != value))
                {
                    this._dateTo = value;
                }
            }
        }

        public string IsFeatured
        {
            get
            {
                return this._isFeatured;
            }
            set
            {
                if ((this._isFeatured != value))
                {
                    this._isFeatured = value;
                }
            }
        }

        public string SKU
        {
            get
            {
                return this._sku;
            }
            set
            {
                if ((this._sku != value))
                {
                    this._sku = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this._name = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                if ((this._description != value))
                {
                    this._description = value;
                }
            }
        }

        public string ShortDescription
        {
            get
            {
                return this._shortDescription;
            }
            set
            {
                if ((this._shortDescription != value))
                {
                    this._shortDescription = value;
                }
            }
        }

        public int Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                if ((this._quantity != value))
                {
                    this._quantity = value;
                }
            }
        }

        public string Price
        {
            get
            {
                return this._price;
            }
            set
            {
                if ((this._price != value))
                {
                    this._price = value;
                }
            }
        }

        public string Weight
        {
            get
            {
                return this._weight;
            }
            set
            {
                if ((this._weight != value))
                {
                    this._weight = value;
                }
            }
        }

        public string ListPrice
        {
            get
            {
                return this._listPrice;
            }
            set
            {
                if ((this._listPrice != value))
                {
                    this._listPrice = value;
                }
            }
        }

        public System.Nullable<bool> HidePrice
        {
            get
            {
                return this._hidePrice;
            }
            set
            {
                if ((this._hidePrice != value))
                {
                    this._hidePrice = value;
                }
            }
        }

        public System.Nullable<bool> HideInRSSFeed
        {
            get
            {
                return this._hideInRSSFeed;
            }
            set
            {
                if ((this._hideInRSSFeed != value))
                {
                    this._hideInRSSFeed = value;
                }
            }
        }

        public System.Nullable<bool> HideToAnonymous
        {
            get
            {
                return this._hideToAnonymous;
            }
            set
            {
                if ((this._hideToAnonymous != value))
                {
                    this._hideToAnonymous = value;
                }
            }
        }

        public System.Nullable<bool> IsOutOfStock
        {
            get
            {
                return this._isOutOfStock;
            }
            set
            {
                if ((this._isOutOfStock != value))
                {
                    this._isOutOfStock = value;
                }
            }
        }

        public System.Nullable<System.DateTime> AddedOn
        {
            get
            {
                return this._addedOn;
            }
            set
            {
                if ((this._addedOn != value))
                {
                    this._addedOn = value;
                }
            }
        }

        public string ImagePath
        {
            get
            {
                return this._imagePath;
            }
            set
            {
                if ((this._imagePath != value))
                {
                    this._imagePath = value;
                }
            }
        }

        public string AlternateText
        {
            get
            {
                return this._alternateText;
            }
            set
            {
                if ((this._alternateText != value))
                {
                    this._alternateText = value;
                }
            }
        }

        public int TaxRuleID
        {
            get
            {
                return this._taxRuleID;
            }
            set
            {
                if ((this._taxRuleID != value))
                {
                    this._taxRuleID = value;
                }
            }
        }

        public string TaxRateValue
        {
            get
            {
                return this._taxRateValue;
            }
            set
            {
                if ((this._taxRateValue != value))
                {
                    this._taxRateValue = value;
                }
            }
        }

        public string SampleLink
        {
            get
            {
                return this._sampleLink;
            }
            set
            {
                if ((this._sampleLink != value))
                {
                    this._sampleLink = value;
                }
            }
        }

        public string SampleFile
        {
            get
            {
                return this._sampleFile;
            }
            set
            {
                if ((this._sampleFile != value))
                {
                    this._sampleFile = value;
                }
            }
        }

         public string DiscountPrice
        {
            get
            {
                return this._discountPrice;
            }
            set
            {
                if ((this._discountPrice != value))
                {
                    this._discountPrice = value;
                }
            }
        }

        #endregion
    }
}
