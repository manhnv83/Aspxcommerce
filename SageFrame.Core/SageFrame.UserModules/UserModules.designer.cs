﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SageFrame.UserModules
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="sageframe_20101125")]
	public partial class UserModulesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public UserModulesDataContext() :
        base(global::SageFrame.Core.Properties.Settings.Default.TempforSpConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public UserModulesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UserModulesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UserModulesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UserModulesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[Function(Name="dbo.sp_UserModuleSettingsGetByUserModuleAndSettingName")]
		public ISingleResult<sp_UserModuleSettingsGetByUserModuleAndSettingNameResult> sp_UserModuleSettingsGetByUserModuleAndSettingName([Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="UserModuleID", DbType="Int")] System.Nullable<int> userModuleID, [Parameter(Name="SettingName", DbType="NVarChar(50)")] string settingName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), portalID, userModuleID, settingName);
			return ((ISingleResult<sp_UserModuleSettingsGetByUserModuleAndSettingNameResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_UserModuleSettingsUpdate")]
		public int sp_UserModuleSettingsUpdate([Parameter(Name="UserModuleID", DbType="Int")] System.Nullable<int> userModuleID, [Parameter(Name="SettingName", DbType="NVarChar(50)")] string settingName, [Parameter(Name="SettingValue", DbType="NVarChar(2000)")] string settingValue, [Parameter(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive, [Parameter(Name="IsModified", DbType="Bit")] System.Nullable<bool> isModified, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="UpdatedBy", DbType="NVarChar(256)")] string updatedBy)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userModuleID, settingName, settingValue, isActive, isModified, portalID, updatedBy);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_UserModuleSettingsGetByUserModule")]
		public ISingleResult<sp_UserModuleSettingsGetByUserModuleResult> sp_UserModuleSettingsGetByUserModule([Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="UserModuleID", DbType="Int")] System.Nullable<int> userModuleID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), portalID, userModuleID);
			return ((ISingleResult<sp_UserModuleSettingsGetByUserModuleResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_UserModuleSettingsAdd")]
		public ISingleResult<sp_UserModuleSettingsAddResult> sp_UserModuleSettingsAdd([Parameter(Name="UserModuleID", DbType="Int")] System.Nullable<int> userModuleID, [Parameter(Name="SettingName", DbType="NVarChar(50)")] string settingName, [Parameter(Name="SettingValue", DbType="NVarChar(2000)")] string settingValue, [Parameter(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="AddedBy", DbType="NVarChar(256)")] string addedBy)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userModuleID, settingName, settingValue, isActive, portalID, addedBy);
			return ((ISingleResult<sp_UserModuleSettingsAddResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_UserModulesAndPageModulesIsActiveChanges")]
		public int sp_UserModulesAndPageModulesIsActiveChanges([Parameter(Name="UserModuleID", DbType="Int")] System.Nullable<int> userModuleID, [Parameter(Name="PageID", DbType="Int")] System.Nullable<int> pageID, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="UpdatedBy", DbType="NVarChar(256)")] string updatedBy, [Parameter(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive, [Parameter(Name="AllPages", DbType="Bit")] System.Nullable<bool> allPages)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userModuleID, pageID, portalID, updatedBy, isActive, allPages);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_GetUserModulePermissionsByUserModuleID")]
		public ISingleResult<sp_GetUserModulePermissionsByUserModuleIDResult> sp_GetUserModulePermissionsByUserModuleID([Parameter(Name="UserModuleID", DbType="Int")] System.Nullable<int> userModuleID, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="Username", DbType="NVarChar(256)")] string username)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userModuleID, portalID, username);
			return ((ISingleResult<sp_GetUserModulePermissionsByUserModuleIDResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_UserModulePermissionSave")]
		public int sp_UserModulePermissionSave([Parameter(Name="UserModuleID", DbType="Int")] System.Nullable<int> userModuleID, [Parameter(Name="ViewPermissionRoles", DbType="VarChar(4000)")] string viewPermissionRoles, [Parameter(Name="EditPermissionRoles", DbType="VarChar(4000)")] string editPermissionRoles, [Parameter(Name="ViewUsers", DbType="VarChar(4000)")] string viewUsers, [Parameter(Name="EditUsers", DbType="VarChar(4000)")] string editUsers, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="Username", DbType="NVarChar(256)")] string username)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userModuleID, viewPermissionRoles, editPermissionRoles, viewUsers, editUsers, portalID, username);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class sp_UserModuleSettingsGetByUserModuleAndSettingNameResult
	{
		
		private int _UserModuleID;
		
		private string _SettingName;
		
		private string _SettingValue;
		
		private System.Nullable<bool> _IsActive;
		
		private System.Nullable<bool> _IsDeleted;
		
		private System.Nullable<bool> _IsModified;
		
		private System.Nullable<System.DateTime> _AddedOn;
		
		private System.Nullable<System.DateTime> _UpdatedOn;
		
		private System.Nullable<System.DateTime> _DeletedOn;
		
		private System.Nullable<int> _PortalID;
		
		private string _AddedBy;
		
		private string _UpdatedBy;
		
		private string _DeletedBy;
		
		public sp_UserModuleSettingsGetByUserModuleAndSettingNameResult()
		{
		}
		
		[Column(Storage="_UserModuleID", DbType="Int NOT NULL")]
		public int UserModuleID
		{
			get
			{
				return this._UserModuleID;
			}
			set
			{
				if ((this._UserModuleID != value))
				{
					this._UserModuleID = value;
				}
			}
		}
		
		[Column(Storage="_SettingName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SettingName
		{
			get
			{
				return this._SettingName;
			}
			set
			{
				if ((this._SettingName != value))
				{
					this._SettingName = value;
				}
			}
		}
		
		[Column(Storage="_SettingValue", DbType="NVarChar(2000)")]
		public string SettingValue
		{
			get
			{
				return this._SettingValue;
			}
			set
			{
				if ((this._SettingValue != value))
				{
					this._SettingValue = value;
				}
			}
		}
		
		[Column(Storage="_IsActive", DbType="Bit")]
		public System.Nullable<bool> IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this._IsActive = value;
				}
			}
		}
		
		[Column(Storage="_IsDeleted", DbType="Bit")]
		public System.Nullable<bool> IsDeleted
		{
			get
			{
				return this._IsDeleted;
			}
			set
			{
				if ((this._IsDeleted != value))
				{
					this._IsDeleted = value;
				}
			}
		}
		
		[Column(Storage="_IsModified", DbType="Bit")]
		public System.Nullable<bool> IsModified
		{
			get
			{
				return this._IsModified;
			}
			set
			{
				if ((this._IsModified != value))
				{
					this._IsModified = value;
				}
			}
		}
		
		[Column(Storage="_AddedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> AddedOn
		{
			get
			{
				return this._AddedOn;
			}
			set
			{
				if ((this._AddedOn != value))
				{
					this._AddedOn = value;
				}
			}
		}
		
		[Column(Storage="_UpdatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdatedOn
		{
			get
			{
				return this._UpdatedOn;
			}
			set
			{
				if ((this._UpdatedOn != value))
				{
					this._UpdatedOn = value;
				}
			}
		}
		
		[Column(Storage="_DeletedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> DeletedOn
		{
			get
			{
				return this._DeletedOn;
			}
			set
			{
				if ((this._DeletedOn != value))
				{
					this._DeletedOn = value;
				}
			}
		}
		
		[Column(Storage="_PortalID", DbType="Int")]
		public System.Nullable<int> PortalID
		{
			get
			{
				return this._PortalID;
			}
			set
			{
				if ((this._PortalID != value))
				{
					this._PortalID = value;
				}
			}
		}
		
		[Column(Storage="_AddedBy", DbType="NVarChar(256)")]
		public string AddedBy
		{
			get
			{
				return this._AddedBy;
			}
			set
			{
				if ((this._AddedBy != value))
				{
					this._AddedBy = value;
				}
			}
		}
		
		[Column(Storage="_UpdatedBy", DbType="NVarChar(256)")]
		public string UpdatedBy
		{
			get
			{
				return this._UpdatedBy;
			}
			set
			{
				if ((this._UpdatedBy != value))
				{
					this._UpdatedBy = value;
				}
			}
		}
		
		[Column(Storage="_DeletedBy", DbType="NVarChar(256)")]
		public string DeletedBy
		{
			get
			{
				return this._DeletedBy;
			}
			set
			{
				if ((this._DeletedBy != value))
				{
					this._DeletedBy = value;
				}
			}
		}
	}
	
	public partial class sp_UserModuleSettingsGetByUserModuleResult
	{
		
		private int _UserModuleID;
		
		private string _SettingName;
		
		private string _SettingValue;
		
		private System.Nullable<bool> _IsActive;
		
		private System.Nullable<bool> _IsDeleted;
		
		private System.Nullable<bool> _IsModified;
		
		private System.Nullable<System.DateTime> _AddedOn;
		
		private System.Nullable<System.DateTime> _UpdatedOn;
		
		private System.Nullable<System.DateTime> _DeletedOn;
		
		private System.Nullable<int> _PortalID;
		
		private string _AddedBy;
		
		private string _UpdatedBy;
		
		private string _DeletedBy;
		
		public sp_UserModuleSettingsGetByUserModuleResult()
		{
		}
		
		[Column(Storage="_UserModuleID", DbType="Int NOT NULL")]
		public int UserModuleID
		{
			get
			{
				return this._UserModuleID;
			}
			set
			{
				if ((this._UserModuleID != value))
				{
					this._UserModuleID = value;
				}
			}
		}
		
		[Column(Storage="_SettingName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SettingName
		{
			get
			{
				return this._SettingName;
			}
			set
			{
				if ((this._SettingName != value))
				{
					this._SettingName = value;
				}
			}
		}
		
		[Column(Storage="_SettingValue", DbType="NVarChar(2000)")]
		public string SettingValue
		{
			get
			{
				return this._SettingValue;
			}
			set
			{
				if ((this._SettingValue != value))
				{
					this._SettingValue = value;
				}
			}
		}
		
		[Column(Storage="_IsActive", DbType="Bit")]
		public System.Nullable<bool> IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this._IsActive = value;
				}
			}
		}
		
		[Column(Storage="_IsDeleted", DbType="Bit")]
		public System.Nullable<bool> IsDeleted
		{
			get
			{
				return this._IsDeleted;
			}
			set
			{
				if ((this._IsDeleted != value))
				{
					this._IsDeleted = value;
				}
			}
		}
		
		[Column(Storage="_IsModified", DbType="Bit")]
		public System.Nullable<bool> IsModified
		{
			get
			{
				return this._IsModified;
			}
			set
			{
				if ((this._IsModified != value))
				{
					this._IsModified = value;
				}
			}
		}
		
		[Column(Storage="_AddedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> AddedOn
		{
			get
			{
				return this._AddedOn;
			}
			set
			{
				if ((this._AddedOn != value))
				{
					this._AddedOn = value;
				}
			}
		}
		
		[Column(Storage="_UpdatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdatedOn
		{
			get
			{
				return this._UpdatedOn;
			}
			set
			{
				if ((this._UpdatedOn != value))
				{
					this._UpdatedOn = value;
				}
			}
		}
		
		[Column(Storage="_DeletedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> DeletedOn
		{
			get
			{
				return this._DeletedOn;
			}
			set
			{
				if ((this._DeletedOn != value))
				{
					this._DeletedOn = value;
				}
			}
		}
		
		[Column(Storage="_PortalID", DbType="Int")]
		public System.Nullable<int> PortalID
		{
			get
			{
				return this._PortalID;
			}
			set
			{
				if ((this._PortalID != value))
				{
					this._PortalID = value;
				}
			}
		}
		
		[Column(Storage="_AddedBy", DbType="NVarChar(256)")]
		public string AddedBy
		{
			get
			{
				return this._AddedBy;
			}
			set
			{
				if ((this._AddedBy != value))
				{
					this._AddedBy = value;
				}
			}
		}
		
		[Column(Storage="_UpdatedBy", DbType="NVarChar(256)")]
		public string UpdatedBy
		{
			get
			{
				return this._UpdatedBy;
			}
			set
			{
				if ((this._UpdatedBy != value))
				{
					this._UpdatedBy = value;
				}
			}
		}
		
		[Column(Storage="_DeletedBy", DbType="NVarChar(256)")]
		public string DeletedBy
		{
			get
			{
				return this._DeletedBy;
			}
			set
			{
				if ((this._DeletedBy != value))
				{
					this._DeletedBy = value;
				}
			}
		}
	}
	
	public partial class sp_UserModuleSettingsAddResult
	{
		
		private System.Nullable<decimal> _Column1;
		
		public sp_UserModuleSettingsAddResult()
		{
		}
		
		[Column(Storage="_Column1", DbType="Decimal(0,0)")]
		public System.Nullable<decimal> Column1
		{
			get
			{
				return this._Column1;
			}
			set
			{
				if ((this._Column1 != value))
				{
					this._Column1 = value;
				}
			}
		}
	}
	
	public partial class sp_GetUserModulePermissionsByUserModuleIDResult
	{
		
		private string _RoleIDs;
		
		private string _UserNames;
		
		public sp_GetUserModulePermissionsByUserModuleIDResult()
		{
		}
		
		[Column(Storage="_RoleIDs", DbType="NVarChar(4000)")]
		public string RoleIDs
		{
			get
			{
				return this._RoleIDs;
			}
			set
			{
				if ((this._RoleIDs != value))
				{
					this._RoleIDs = value;
				}
			}
		}
		
		[Column(Storage="_UserNames", DbType="NVarChar(4000)")]
		public string UserNames
		{
			get
			{
				return this._UserNames;
			}
			set
			{
				if ((this._UserNames != value))
				{
					this._UserNames = value;
				}
			}
		}
	}
}
#pragma warning restore 1591