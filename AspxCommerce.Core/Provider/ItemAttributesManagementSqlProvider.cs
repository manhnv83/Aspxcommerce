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
using System.Collections.Generic;
using SageFrame.Web.Utilities;

namespace AspxCommerce.Core
{
    public class ItemAttributesManagementSqlProvider
    {
        public ItemAttributesManagementSqlProvider()
        {

        }
        /// <summary>
        /// To Bind grid
        /// </summary>
        /// <returns></returns>
        public List<AttributesBasicInfo> GetItemAttributes(int offset, int limit, string attributeName, System.Nullable<bool> isRequired, System.Nullable<bool> comparable, System.Nullable<bool> isSystem, int storeId, int portalId, string cultureName, string userName)
        //(int portalID, int userModuleID, string cultureName)
        {
            List<AttributesBasicInfo> ml;
            SQLHandler sqlH = new SQLHandler();
            List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
            parameterCollection.Add(new KeyValuePair<string, object>("@offset", offset));
            parameterCollection.Add(new KeyValuePair<string, object>("@limit", limit));
            parameterCollection.Add(new KeyValuePair<string, object>("@AttributeName", attributeName));
            parameterCollection.Add(new KeyValuePair<string, object>("@IsRequired", isRequired));
            parameterCollection.Add(new KeyValuePair<string, object>("@Comparable", comparable));
            parameterCollection.Add(new KeyValuePair<string, object>("@IsSystem", isSystem));
            parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeId));
            parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalId));
            parameterCollection.Add(new KeyValuePair<string, object>("@CultureName", cultureName));  
            //parameterCollection.Add(new KeyValuePair<string, object>("@UserName", userName));            
            ml = sqlH.ExecuteAsList<AttributesBasicInfo>("dbo.usp_Aspx_AttributesGetAll", parameterCollection);
            return ml;
        }

        /// <summary>
        /// To Bind Attribute Type dropdown
        /// </summary>
        /// <returns></returns>
        public List<AttributesInputTypeInfo> GetAttributesInputType()
        {
            List<AttributesInputTypeInfo> ml;
            SQLHandler sqlH = new SQLHandler();
            ml = sqlH.ExecuteAsList<AttributesInputTypeInfo>("dbo.usp_Aspx_AttributesInputTypeGetAll");
            return ml;
        }

        /// <summary>
        /// To Bind Attribute Item Type dropdown
        /// </summary>
        /// <returns></returns>
        public List<AttributesItemTypeInfo> GetAttributesItemType(int storeId, int portalId)
        {
            List<AttributesItemTypeInfo> ml;
            SQLHandler sqlH = new SQLHandler();
            List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
            parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeId));
            parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalId));
            ml = sqlH.ExecuteAsList<AttributesItemTypeInfo>("dbo.usp_Aspx_AttributesItemTypeGetAll", parameterCollection);
            return ml;
        }

        /// <summary>
        /// To Bind Attribute validation Type dropdown
        /// </summary>
        /// <returns></returns>
        public List<AttributesValidationTypeInfo> GetAttributesValidationType()
        {
            List<AttributesValidationTypeInfo> ml;
            SQLHandler sqlH = new SQLHandler();
            ml = sqlH.ExecuteAsList<AttributesValidationTypeInfo>("dbo.usp_Aspx_AttributesValidationTypeGetAll");
            return ml;
        }

        /// <summary>
        /// To Bind for Attribute ID
        /// </summary>
        /// <returns></returns>
        public List<AttributesGetByAttributeIdInfo> GetAttributesInfoByAttributeID(int attributeId, int storeId, int portalId, string userName)
        {
            List<AttributesGetByAttributeIdInfo> ml;
            SQLHandler sqlH = new SQLHandler();
            List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
            parameterCollection.Add(new KeyValuePair<string, object>("@AttributeID", attributeId));
            parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeId));
            parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalId));
            parameterCollection.Add(new KeyValuePair<string, object>("@UserName", userName));
            ml = sqlH.ExecuteAsList<AttributesGetByAttributeIdInfo>("dbo.usp_Aspx_AttributesGetByAttributeID", parameterCollection);
            return ml;
        }
        /// <summary>
        /// To Delete Multiple Attribute IDs
        /// </summary>
        /// <returns></returns>
        public void DeleteMultipleAttributes(string attributeIds, int storeId, int portalId, string userName)
        {
            try
            {
                List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeIDs", attributeIds));
                parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeId));
                parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalId));
                parameterCollection.Add(new KeyValuePair<string, object>("@DeletedBy", userName));
                SQLHandler sqlH = new SQLHandler();
                sqlH.ExecuteNonQuery("dbo.usp_Aspx_AttributesDeleteMultipleSelected", parameterCollection);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// To Delete by Attribute ID
        /// </summary>
        /// <returns></returns>
        public void DeleteAttribute(int attributeId, int storeId, int portalId, string userName)
        {
            try
            {
                List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeID", attributeId));
                parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeId));
                parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalId));
                parameterCollection.Add(new KeyValuePair<string, object>("@DeletedBy", userName));
                SQLHandler sqlH = new SQLHandler();
                sqlH.ExecuteNonQuery("dbo.usp_Aspx_DeleteAttributeByAttributeID", parameterCollection);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// To Activate/ Deactivate Attribute 
        /// </summary>
        /// <returns></returns>
        public void UpdateAttributeIsActive(int attributeId, int storeId, int portalId, string userName, bool isActive)
        {
            try
            {
                List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeID", attributeId));
                parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeId));
                parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalId));
                parameterCollection.Add(new KeyValuePair<string, object>("@UserName", userName));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsActive", isActive));
                SQLHandler sqlH = new SQLHandler();
                sqlH.ExecuteNonQuery("dbo.usp_Aspx_UpdateAttributeIsActiveByAttributeID", parameterCollection);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// To Save Attribute 
        /// </summary>
        /// <returns></returns>
        public void SaveAttribute(AttributesGetByAttributeIdInfo attributeToInsert)
        {
            try
            {
                List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeID", attributeToInsert.AttributeID));
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeName", attributeToInsert.AttributeName));
                parameterCollection.Add(new KeyValuePair<string, object>("@InputTypeID", attributeToInsert.InputTypeID));

                parameterCollection.Add(new KeyValuePair<string, object>("@DefaultValue", attributeToInsert.DefaultValue));
                parameterCollection.Add(new KeyValuePair<string, object>("@Length", attributeToInsert.Length));
                parameterCollection.Add(new KeyValuePair<string, object>("@AliasName", attributeToInsert.AliasName));
                parameterCollection.Add(new KeyValuePair<string, object>("@AliasToolTip", attributeToInsert.AliasToolTip));
                parameterCollection.Add(new KeyValuePair<string, object>("@AliasHelp", attributeToInsert.AliasHelp));
                parameterCollection.Add(new KeyValuePair<string, object>("@DisplayOrder", attributeToInsert.DisplayOrder));

                parameterCollection.Add(new KeyValuePair<string, object>("@IsUnique", attributeToInsert.IsUnique));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsRequired", attributeToInsert.IsRequired));
                parameterCollection.Add(new KeyValuePair<string, object>("@ShowInAdvanceSearch", attributeToInsert.ShowInAdvanceSearch));
                parameterCollection.Add(new KeyValuePair<string, object>("@ShowInComparison", attributeToInsert.ShowInComparison));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsIncludeInPriceRule", attributeToInsert.IsIncludeInPriceRule));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsIncludeInPromotions", attributeToInsert.IsIncludeInPromotions));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsEnableEditor", attributeToInsert.IsEnableEditor));
                parameterCollection.Add(new KeyValuePair<string, object>("@ShowInSearch", attributeToInsert.ShowInSearch));
                parameterCollection.Add(new KeyValuePair<string, object>("@ShowInGrid", attributeToInsert.ShowInGrid));

                parameterCollection.Add(new KeyValuePair<string, object>("@IsEnableSorting", attributeToInsert.IsEnableSorting));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsUseInFilter", attributeToInsert.IsUseInFilter));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsShownInRating", attributeToInsert.IsShownInRating));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsActive", attributeToInsert.IsActive));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsModified", attributeToInsert.IsModified));
                parameterCollection.Add(new KeyValuePair<string, object>("@ValidationTypeID", attributeToInsert.ValidationTypeID));

                parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", attributeToInsert.StoreID));
                parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", attributeToInsert.PortalID));
                parameterCollection.Add(new KeyValuePair<string, object>("@UserName", attributeToInsert.AddedBy));
                parameterCollection.Add(new KeyValuePair<string, object>("@CultureName", attributeToInsert.CultureName));

                parameterCollection.Add(new KeyValuePair<string, object>("@ItemTypes", attributeToInsert.ItemTypes));
                parameterCollection.Add(new KeyValuePair<string, object>("@UpdateFlag", attributeToInsert.Flag));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsUsedInConfigItem", attributeToInsert.IsUsedInConfigItem));
                parameterCollection.Add(new KeyValuePair<string, object>("@SaveOptions", attributeToInsert.SaveOptions));
                SQLHandler sqlH = new SQLHandler();
                sqlH.ExecuteNonQuery("dbo.usp_Aspx_AttributeAddUpdate", parameterCollection);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// To Bind Attribute Set Base On dropdown
        /// </summary>
        /// <returns></returns>
        public List<AttributeSetInfo> GetAttributeSet(int storeId, int portalId)
        {
            List<AttributeSetInfo> ml;
            SQLHandler sqlH = new SQLHandler();
            List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
            parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeId));
            parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalId));
            ml = sqlH.ExecuteAsList<AttributeSetInfo>("dbo.usp_Aspx_AttributeSetGetAll", parameterCollection);
            return ml;
        }

        /// <summary>
        /// To Save Attribute Set
        /// </summary>
        /// <returns></returns>
        public int SaveUpdateAttributeSet(AttributeSetInfo attributeSetInfoToInsert)
        {
            try
            {
                List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeSetID", attributeSetInfoToInsert.AttributeSetID));
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeSetBaseID", attributeSetInfoToInsert.AttributeSetBaseID));
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeSetName", attributeSetInfoToInsert.AttributeSetName));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsActive", attributeSetInfoToInsert.IsActive));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsModified", attributeSetInfoToInsert.IsModified));

                parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", attributeSetInfoToInsert.StoreID));
                parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", attributeSetInfoToInsert.PortalID));
                parameterCollection.Add(new KeyValuePair<string, object>("@UserName", attributeSetInfoToInsert.AddedBy));
                parameterCollection.Add(new KeyValuePair<string, object>("@UpdateFlag", attributeSetInfoToInsert.Flag));
                parameterCollection.Add(new KeyValuePair<string, object>("@SaveString", attributeSetInfoToInsert.SaveString));
                SQLHandler sqlH = new SQLHandler();
                return sqlH.ExecuteNonQuery("dbo.usp_Aspx_AttributeSetAddUpdate", parameterCollection, "@AttributeSetIDOut");

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Check unique Attribute set name
        /// </summary>
        /// <returns></returns>
        public int CheckAttributeSetUniqueName(int attributeSetID, string attributeSetName, int storeID, int portalID, bool updateFlag)
        {
            try
            {
                List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeSetID", attributeSetID));
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeSetName", attributeSetName));
                parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeID));
                parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalID));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsEdit", updateFlag));
                SQLHandler sqlH = new SQLHandler();
                return sqlH.ExecuteNonQuery("dbo.usp_Aspx_AttributeSetUniquenessCheck", parameterCollection, "@AttributeSetCount");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// To Bind Attribute set grid
        /// </summary>
        /// <returns></returns>
        public List<AttributeSetBaseInfo> GetAttributeSetGrid(int offset, int limit, string attributeSetName, System.Nullable<bool> isActive, System.Nullable<bool> usedInSystem, int storeId, int portalId, string cultureName, string userName)
        {
            List<AttributeSetBaseInfo> ml;
            SQLHandler sqlH = new SQLHandler();
            List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
            parameterCollection.Add(new KeyValuePair<string, object>("@offset", offset));
            parameterCollection.Add(new KeyValuePair<string, object>("@limit", limit));
            parameterCollection.Add(new KeyValuePair<string, object>("@AttributeSetName", attributeSetName));
            parameterCollection.Add(new KeyValuePair<string, object>("@IsActive", isActive));
            parameterCollection.Add(new KeyValuePair<string, object>("@UsedInSystem", usedInSystem));
            parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeId));
            parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalId));
            parameterCollection.Add(new KeyValuePair<string, object>("@CultureName", cultureName));
            //parameterCollection.Add(new KeyValuePair<string, object>("@UserName", userName));            
            ml = sqlH.ExecuteAsList<AttributeSetBaseInfo>("dbo.usp_Aspx_AttributeSetGridGetAll", parameterCollection);
            return ml;
        }

        /// <summary>
        /// To Bind Attribute set from fill using Attribute set ID
        /// </summary>
        /// <returns></returns>
        public List<AttributeSetGetByAttributeSetIdInfo> GetAttributeSetInfoByAttributeSetID(int attributeSetId, int storeId, int portalId, string userName, string cultureName)
        {
            List<AttributeSetGetByAttributeSetIdInfo> ml;
            SQLHandler sqlH = new SQLHandler();
            List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
            parameterCollection.Add(new KeyValuePair<string, object>("@AttributeSetID", attributeSetId));
            parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeId));
            parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalId));
            parameterCollection.Add(new KeyValuePair<string, object>("@UserName", userName));
            parameterCollection.Add(new KeyValuePair<string, object>("@CultureName", cultureName));
            ml = sqlH.ExecuteAsList<AttributeSetGetByAttributeSetIdInfo>("dbo.usp_Aspx_AttributeSetGetByAttributeSetID", parameterCollection);
            return ml;
        }

        /// <summary>
        /// To update, delete  Attribute Set only if it is NOT SystemUsed Type
        /// </summary>
        /// <returns></returns>
        public void DeleteAttributeSet(int attributeSetId, int storeId, int portalId, string userName)
        {
            try
            {
                List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeSetID", attributeSetId));
                parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeId));
                parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalId));
                parameterCollection.Add(new KeyValuePair<string, object>("@DeletedBy", userName));
                SQLHandler sqlH = new SQLHandler();
                sqlH.ExecuteNonQuery("dbo.usp_Aspx_DeleteAttributeSetByAttributeSetID", parameterCollection);

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// To update, delete  Attribute Set only if it is NOT SystemUsed Type
        /// </summary>
        /// <returns></returns>
        public void UpdateAttributeSetIsActive(int attributeSetId, int storeId, int portalId, string userName, bool isActive)
        {
            try
            {
                List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeSetID", attributeSetId));
                parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeId));
                parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalId));
                parameterCollection.Add(new KeyValuePair<string, object>("@UserName", userName));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsActive", isActive));
                SQLHandler sqlH = new SQLHandler();
                sqlH.ExecuteNonQuery("dbo.usp_Aspx_UpdateAttributeSetIsActiveByAttributeSetID", parameterCollection);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// To update, add  Attribute Group
        /// </summary>
        /// <returns></returns>
        public void UpdateAttributeGroup(int attributeSetId, string groupName, int groupID, string cultureName, string aliasName, int storeId, int portalId, string userName, bool isActive, bool isModified, bool flag)
        {
            try
            {
                List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeSetID", attributeSetId));
                parameterCollection.Add(new KeyValuePair<string, object>("@GroupName", groupName));
                parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeId));
                parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalId));
                parameterCollection.Add(new KeyValuePair<string, object>("@UserName", userName));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsActive", isActive));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsModified", isModified));
                parameterCollection.Add(new KeyValuePair<string, object>("@GroupID", groupID));
                parameterCollection.Add(new KeyValuePair<string, object>("@CultureName", cultureName));
                parameterCollection.Add(new KeyValuePair<string, object>("@AliasName", aliasName));
                parameterCollection.Add(new KeyValuePair<string, object>("@UpdateFlag", flag));

                SQLHandler sqlH = new SQLHandler();
                sqlH.ExecuteNonQuery("dbo.usp_Aspx_AttributeGroupAddUpdate", parameterCollection);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteAttributeSetGroup(int attributeSetId, int groupId, int storeId, int portalId, string userName, string cultureName)
        {
            try
            {
                List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeSetID", attributeSetId));
                parameterCollection.Add(new KeyValuePair<string, object>("@GroupID", groupId));
                parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeId));
                parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalId));
                parameterCollection.Add(new KeyValuePair<string, object>("@DeletedBy", userName));
                parameterCollection.Add(new KeyValuePair<string, object>("@CultureName", cultureName));
                SQLHandler sqlH = new SQLHandler();
                sqlH.ExecuteNonQuery("dbo.usp_Aspx_DeleteAttributeSetGroupByAttributeSetID", parameterCollection);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<AttributeSetGroupAliasInfo> RenameAttributeSetGroupAlias(AttributeSetGroupAliasInfo attributeSetInfoToUpdate)
        {
            try
            {
                List<AttributeSetGroupAliasInfo> ml;
                List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
                parameterCollection.Add(new KeyValuePair<string, object>("@GroupID", attributeSetInfoToUpdate.GroupID));
                parameterCollection.Add(new KeyValuePair<string, object>("@CultureName", attributeSetInfoToUpdate.CultureName));
                parameterCollection.Add(new KeyValuePair<string, object>("@AliasName", attributeSetInfoToUpdate.AliasName));
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeSetID", attributeSetInfoToUpdate.AttributeSetID));
                parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", attributeSetInfoToUpdate.StoreID));
                parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", attributeSetInfoToUpdate.PortalID));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsActive", attributeSetInfoToUpdate.IsActive));
                parameterCollection.Add(new KeyValuePair<string, object>("@IsModified", attributeSetInfoToUpdate.IsModified));
                parameterCollection.Add(new KeyValuePair<string, object>("@UserName", attributeSetInfoToUpdate.UpdatedBy));
                SQLHandler sqlH = new SQLHandler();
                ml = sqlH.ExecuteAsList<AttributeSetGroupAliasInfo>("dbo.usp_Aspx_AttributeGroupAliasRename", parameterCollection);
                return ml;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteAttribute(int attributeSetId, int groupId, int attributeId, int storeId, int portalId, string userName)
        {
            try
            {
                List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeSetID", attributeSetId));
                parameterCollection.Add(new KeyValuePair<string, object>("@GroupID", groupId));
                parameterCollection.Add(new KeyValuePair<string, object>("@AttributeID", attributeId));
                parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeId));
                parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalId));
                parameterCollection.Add(new KeyValuePair<string, object>("@DeletedBy", userName));

                SQLHandler sqlH = new SQLHandler();
                sqlH.ExecuteNonQuery("dbo.usp_Aspx_DeleteAttributeByAttributeSetID", parameterCollection);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        ///// <summary>
        ///// To Bind Items grid
        ///// </summary>
        ///// <returns></returns>
        //public void List<ItemsInfo> GetItems(int offset, int limit, int storeId, int portalId, string userName, string cultureName)
        //{
        //    List<ItemsInfo> ml = new List<ItemsInfo>();
        //    SQLHandler Sq = new SQLHandler();
        //    List<KeyValuePair<string, object>> parameterCollection = new List<KeyValuePair<string, object>>();
        //    parameterCollection.Add(new KeyValuePair<string, object>("@offset", offset));
        //    parameterCollection.Add(new KeyValuePair<string, object>("@limit", limit));
        //    parameterCollection.Add(new KeyValuePair<string, object>("@StoreID", storeId));
        //    parameterCollection.Add(new KeyValuePair<string, object>("@PortalID", portalId));
        //    parameterCollection.Add(new KeyValuePair<string, object>("@UserName", userName)); 
        //    parameterCollection.Add(new KeyValuePair<string, object>("@CultureName", cultureName));           
        //    ml = Sq.ExecuteAsList<ItemsInfo>("dbo.usp_Aspx_ItemsGetAll", parameterCollection);
        //    return ml;
        //}       
    }   
}
