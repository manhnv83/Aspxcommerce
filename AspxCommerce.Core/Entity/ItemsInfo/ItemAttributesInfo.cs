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
    public class ItemAttributesInfo
    {
        #region Constructor
        public ItemAttributesInfo()
        {
        }
        #endregion

        #region Private Members
        [DataMember(Name = "_rowTotal", Order = 0)]
        private System.Nullable<int> _rowTotal;

        [DataMember(Name = "_attributeID", Order = 1)]
        private int _attributeID;

        [DataMember(Name = "_attributeName", Order = 2)]
        private string _attributeName;

        //[DataMember(Name = "_inputType", Order = 9)]
        private string _inputType;

        //[DataMember(Name = "_defaultValue", Order = 10)]
        private string _defaultValue;

        //[DataMember(Name = "_validationTypeID", Order = 11)]
        private System.Nullable<int> _validationTypeID;

        //[DataMember(Name = "_length", Order = 12)]
        private System.Nullable<int> _length;

        //[DataMember(Name = "_isUnique", Order = 2)]
        private System.Nullable<bool> _isUnique;

        [DataMember(Name = "_isRequired", Order = 4)]
        private System.Nullable<bool> _isRequired;

        //[DataMember(Name = "_isEnableEditor", Order = 2)]
        private System.Nullable<bool> _isEnableEditor;

        [DataMember(Name = "_showInSearch", Order = 7)]
        private System.Nullable<bool> _showInSearch;

        //[DataMember(Name = "_showInGrid", Order = 2)]
        private System.Nullable<bool> _showInGrid;

        //[DataMember(Name = "_showInAdvanceSearch", Order = 2)]
        private System.Nullable<bool> _showInAdvanceSearch;

        [DataMember(Name = "_showInComparison", Order = 9)]
        private System.Nullable<bool> _showInComparison;

        //[DataMember(Name = "_isEnableSorting", Order = 2)]
        private System.Nullable<bool> _isEnableSorting;

        [DataMember(Name = "_isSystemUsed", Order = 6)]
        private System.Nullable<bool> _isSystemUsed;

        //[DataMember(Name = "_isUseInFilter", Order = 2)]
        private System.Nullable<bool> _isUseInFilter;

        //[DataMember(Name = "_isIncludeInPriceRule", Order = 2)]
        private System.Nullable<bool> _isIncludeInPriceRule;

        //[DataMember(Name = "_isIncludeInPromotions", Order = 2)]
        private System.Nullable<bool> _isIncludeInPromotions;

        //[DataMember(Name = "_isShownInRating", Order = 2)]
        private System.Nullable<bool> _isShownInRating;

        //[DataMember(Name = "_storeID", Order = 2)]
        private int _storeID;

        //[DataMember(Name = "_portalID", Order = 2)]
        private int _portalID;

        [DataMember(Name = "_isActive", Order = 5)]
        private System.Nullable<bool> _isActive;

        //[DataMember(Name = "_isDeleted", Order = 2)]
        private System.Nullable<bool> _isDeleted;

        //[DataMember(Name = "_isModified", Order = 2)]
        private System.Nullable<bool> _isModified;

        [DataMember(Name = "_addedOn", Order = 10)]
        private System.Nullable<System.DateTime> _addedOn;

        //[DataMember(Name = "_updatedOn", Order = 5)]
        private System.Nullable<System.DateTime> _updatedOn;

        //[DataMember(Name = "_deletedOn", Order = 2)]
        private System.Nullable<System.DateTime> _deletedOn;

        //[DataMember(Name = "_addedBy", Order = 2)]
        private string _addedBy;

        //[DataMember(Name = "_updatedBy", Order = 2)]
        private string _updatedBy;

        //[DataMember(Name = "_deletedBy", Order = 2)]
        private string _deletedBy;

        //[DataMember(Name = "_attributeAliasID", Order = 2)]
        private System.Nullable<int> _attributeAliasID;

        [DataMember(Name = "_aliasName", Order = 3)]
        private string _aliasName;

        //[DataMember(Name = "_aliasToolTip", Order = 2)]
        private string _aliasToolTip;

        //[DataMember(Name = "_aliasHelp", Order = 2)]
        private string _aliasHelp;

        //[DataMember(Name = "_cultureName", Order = 2)]
        private string _cultureName;

        //[DataMember(Name = "_rowNumber", Order = 2)]
        private int _rowNumber;

        [DataMember(Name = "_isUsedInConfigItem", Order = 8)]
        private System.Nullable<bool> _isUsedInConfigItem;
        #endregion

        #region Public Members
        public System.Nullable<int> RowTotal
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

        public int AttributeID
        {
            get
            {
                return this._attributeID;
            }
            set
            {
                if ((this._attributeID != value))
                {
                    this._attributeID = value;
                }
            }
        }

        public string AttributeName
        {
            get
            {
                return this._attributeName;
            }
            set
            {
                if ((this._attributeName != value))
                {
                    this._attributeName = value;
                }
            }
        }

        public string InputType
        {
            get
            {
                return this._inputType;
            }
            set
            {
                if ((this._inputType != value))
                {
                    this._inputType = value;
                }
            }
        }

        public string DefaultValue
        {
            get
            {
                return this._defaultValue;
            }
            set
            {
                if ((this._defaultValue != value))
                {
                    this._defaultValue = value;
                }
            }
        }

        public System.Nullable<int> ValidationTypeID
        {
            get
            {
                return this._validationTypeID;
            }
            set
            {
                if ((this._validationTypeID != value))
                {
                    this._validationTypeID = value;
                }
            }
        }

        public System.Nullable<int> Length
        {
            get
            {
                return this._length;
            }
            set
            {
                if ((this._length != value))
                {
                    this._length = value;
                }
            }
        }

        public System.Nullable<bool> IsUnique
        {
            get
            {
                return this._isUnique;
            }
            set
            {
                if ((this._isUnique != value))
                {
                    this._isUnique = value;
                }
            }
        }

        public System.Nullable<bool> IsRequired
        {
            get
            {
                return this._isRequired;
            }
            set
            {
                if ((this._isRequired != value))
                {
                    this._isRequired = value;
                }
            }
        }

        public System.Nullable<bool> IsEnableEditor
        {
            get
            {
                return this._isEnableEditor;
            }
            set
            {
                if ((this._isEnableEditor != value))
                {
                    this._isEnableEditor = value;
                }
            }
        }

        public System.Nullable<bool> ShowInSearch
        {
            get
            {
                return this._showInSearch;
            }
            set
            {
                if ((this._showInSearch != value))
                {
                    this._showInSearch = value;
                }
            }
        }

        public System.Nullable<bool> ShowInGrid
        {
            get
            {
                return this._showInGrid;
            }
            set
            {
                if ((this._showInGrid != value))
                {
                    this._showInGrid = value;
                }
            }
        }

        public System.Nullable<bool> ShowInAdvanceSearch
        {
            get
            {
                return this._showInAdvanceSearch;
            }
            set
            {
                if ((this._showInAdvanceSearch != value))
                {
                    this._showInAdvanceSearch = value;
                }
            }
        }

        public System.Nullable<bool> ShowInComparison
        {
            get
            {
                return this._showInComparison;
            }
            set
            {
                if ((this._showInComparison != value))
                {
                    this._showInComparison = value;
                }
            }
        }

        public System.Nullable<bool> IsEnableSorting
        {
            get
            {
                return this._isEnableSorting;
            }
            set
            {
                if ((this._isEnableSorting != value))
                {
                    this._isEnableSorting = value;
                }
            }
        }

        public System.Nullable<bool> IsSystemUsed
        {
            get
            {
                return this._isSystemUsed;
            }
            set
            {
                if ((this._isSystemUsed != value))
                {
                    this._isSystemUsed = value;
                }
            }
        }

        public System.Nullable<bool> IsUseInFilter
        {
            get
            {
                return this._isUseInFilter;
            }
            set
            {
                if ((this._isUseInFilter != value))
                {
                    this._isUseInFilter = value;
                }
            }
        }

        public System.Nullable<bool> IsIncludeInPriceRule
        {
            get
            {
                return this._isIncludeInPriceRule;
            }
            set
            {
                if ((this._isIncludeInPriceRule != value))
                {
                    this._isIncludeInPriceRule = value;
                }
            }
        }

        public System.Nullable<bool> IsIncludeInPromotions
        {
            get
            {
                return this._isIncludeInPromotions;
            }
            set
            {
                if ((this._isIncludeInPromotions != value))
                {
                    this._isIncludeInPromotions = value;
                }
            }
        }

        public System.Nullable<bool> IsShownInRating
        {
            get
            {
                return this._isShownInRating;
            }
            set
            {
                if ((this._isShownInRating != value))
                {
                    this._isShownInRating = value;
                }
            }
        }

        public int StoreID
        {
            get
            {
                return this._storeID;
            }
            set
            {
                if ((this._storeID != value))
                {
                    this._storeID = value;
                }
            }
        }

        public int PortalID
        {
            get
            {
                return this._portalID;
            }
            set
            {
                if ((this._portalID != value))
                {
                    this._portalID = value;
                }
            }
        }

        public System.Nullable<bool> IsActive
        {
            get
            {
                return this._isActive;
            }
            set
            {
                if ((this._isActive != value))
                {
                    this._isActive = value;
                }
            }
        }

        public System.Nullable<bool> IsDeleted
        {
            get
            {
                return this._isDeleted;
            }
            set
            {
                if ((this._isDeleted != value))
                {
                    this._isDeleted = value;
                }
            }
        }

        public System.Nullable<bool> IsModified
        {
            get
            {
                return this._isModified;
            }
            set
            {
                if ((this._isModified != value))
                {
                    this._isModified = value;
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

        public System.Nullable<System.DateTime> UpdatedOn
        {
            get
            {
                return this._updatedOn;
            }
            set
            {
                if ((this._updatedOn != value))
                {
                    this._updatedOn = value;
                }
            }
        }

        public System.Nullable<System.DateTime> DeletedOn
        {
            get
            {
                return this._deletedOn;
            }
            set
            {
                if ((this._deletedOn != value))
                {
                    this._deletedOn = value;
                }
            }
        }

        public string AddedBy
        {
            get
            {
                return this._addedBy;
            }
            set
            {
                if ((this._addedBy != value))
                {
                    this._addedBy = value;
                }
            }
        }

        public string UpdatedBy
        {
            get
            {
                return this._updatedBy;
            }
            set
            {
                if ((this._updatedBy != value))
                {
                    this._updatedBy = value;
                }
            }
        }

        public string DeletedBy
        {
            get
            {
                return this._deletedBy;
            }
            set
            {
                if ((this._deletedBy != value))
                {
                    this._deletedBy = value;
                }
            }
        }

        public System.Nullable<int> AttributeAliasID
        {
            get
            {
                return this._attributeAliasID;
            }
            set
            {
                if ((this._attributeAliasID != value))
                {
                    this._attributeAliasID = value;
                }
            }
        }

        public string AliasName
        {
            get
            {
                return this._aliasName;
            }
            set
            {
                if ((this._aliasName != value))
                {
                    this._aliasName = value;
                }
            }
        }

        public string AliasToolTip
        {
            get
            {
                return this._aliasToolTip;
            }
            set
            {
                if ((this._aliasToolTip != value))
                {
                    this._aliasToolTip = value;
                }
            }
        }

        public string AliasHelp
        {
            get
            {
                return this._aliasHelp;
            }
            set
            {
                if ((this._aliasHelp != value))
                {
                    this._aliasHelp = value;
                }
            }
        }

        public string CultureName
        {
            get
            {
                return this._cultureName;
            }
            set
            {
                if ((this._cultureName != value))
                {
                    this._cultureName = value;
                }
            }
        }

        public int RowNumber
        {
            get
            {
                return this._rowNumber;
            }
            set
            {
                if ((this._rowNumber != value))
                {
                    this._rowNumber = value;
                }
            }
        }

        public System.Nullable<bool> IsUsedInConfigItem
        {
            get
            {
                return this._isUsedInConfigItem;
            }
            set
            {
                if ((this._isUsedInConfigItem != value))
                {
                    this._isUsedInConfigItem = value;
                }
            }
        }        
        #endregion
    }
}
