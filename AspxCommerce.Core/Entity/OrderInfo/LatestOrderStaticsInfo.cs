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
    public class LatestOrderStaticsInfo
    {
        public LatestOrderStaticsInfo()
        {
        }
        [DataMember(Name = "_orderID", Order = 0)]
        private int _orderID;

        [DataMember(Name = "_firstName", Order = 1)]
        private string _firstName;

        [DataMember(Name = "_itemTypeName", Order = 2)]
        private string _itemTypeName;

        [DataMember(Name = "_grandTotal", Order = 3)]
        private decimal _grandTotal;

        [DataMember(Name = "_addedOn", Order = 4)]
        private string _addedOn;

        public int OrderID
        {
            get
            {
                return this._orderID;
            }
            set
            {
                if ((this._orderID != value))
                {
                    this._orderID = value;
                }
            }
        }

        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                if ((this._firstName != value))
                {
                    this._firstName = value;
                }
            }
        }

        public string ItemTypeName
        {
            get
            {
                return this._itemTypeName;
            }
            set
            {
                if ((this._itemTypeName != value))
                {
                    this._itemTypeName = value;
                }
            }
        }


        public decimal GrandTotal
        {
            get
            {
                return this._grandTotal;
            }
            set
            {
                if ((this._grandTotal != value))
                {
                    this._grandTotal = value;
                }
            }
        }

        public string AddedOn
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
    }
}
