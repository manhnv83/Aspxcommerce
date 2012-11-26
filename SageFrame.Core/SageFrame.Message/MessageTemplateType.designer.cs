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

namespace SageFrame.Message
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="SageFrame")]
	public partial class MessageTemplateTypeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public MessageTemplateTypeDataContext() :
        base(global::SageFrame.Core.Properties.Settings.Default.TempforSpConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MessageTemplateTypeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MessageTemplateTypeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MessageTemplateTypeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MessageTemplateTypeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[Function(Name="dbo.sp_MessageTemplateTypeAdd")]
		public int sp_MessageTemplateTypeAdd([Parameter(Name="MessageTemplateTypeID", DbType="Int")] ref System.Nullable<int> messageTemplateTypeID, [Parameter(Name="Name", DbType="NVarChar(200)")] string name, [Parameter(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive, [Parameter(Name="AddedOn", DbType="DateTime")] System.Nullable<System.DateTime> addedOn, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="AddedBy", DbType="NVarChar(256)")] string addedBy)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), messageTemplateTypeID, name, isActive, addedOn, portalID, addedBy);
			messageTemplateTypeID = ((System.Nullable<int>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_MessageTemplateTypeDelete")]
		public int sp_MessageTemplateTypeDelete([Parameter(Name="MessageTemplateTypeID", DbType="Int")] System.Nullable<int> messageTemplateTypeID, [Parameter(Name="DeletedOn", DbType="DateTime")] System.Nullable<System.DateTime> deletedOn, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="DeletedBy", DbType="NVarChar(256)")] string deletedBy)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), messageTemplateTypeID, deletedOn, portalID, deletedBy);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_MessageTemplateTypeUpdate")]
		public int sp_MessageTemplateTypeUpdate([Parameter(Name="MessageTemplateTypeID", DbType="Int")] System.Nullable<int> messageTemplateTypeID, [Parameter(Name="Name", DbType="NVarChar(200)")] string name, [Parameter(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive, [Parameter(Name="UpdatedOn", DbType="DateTime")] System.Nullable<System.DateTime> updatedOn, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="UpdatedBy", DbType="NVarChar(256)")] string updatedBy)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), messageTemplateTypeID, name, isActive, updatedOn, portalID, updatedBy);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_GetMessageTemplateType")]
		public ISingleResult<sp_GetMessageTemplateTypeResult> sp_GetMessageTemplateType([Parameter(Name="MessageTemplateTypeID", DbType="Int")] System.Nullable<int> messageTemplateTypeID, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), messageTemplateTypeID, portalID);
			return ((ISingleResult<sp_GetMessageTemplateTypeResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_GetMessageTemplateTypeList")]
		public ISingleResult<sp_GetMessageTemplateTypeListResult> sp_GetMessageTemplateTypeList([Parameter(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive, [Parameter(Name="IsDeleted", DbType="Bit")] System.Nullable<bool> isDeleted, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="Username", DbType="NVarChar(256)")] string username, [Parameter(Name="CurrentCulture", DbType="NVarChar(256)")] string currentCulture)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), isActive, isDeleted, portalID, username, currentCulture);
			return ((ISingleResult<sp_GetMessageTemplateTypeListResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_LangaugeMessageTemplateTypeInsertUpdate")]
		public int sp_LangaugeMessageTemplateTypeInsertUpdate([Parameter(Name="MessageTemplateTypeIDs", DbType="VarChar(4000)")] string messageTemplateTypeIDs, [Parameter(Name="Names", DbType="NVarChar(4000)")] string names, [Parameter(Name="Culture", DbType="NVarChar(256)")] string culture, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="Username", DbType="NVarChar(256)")] string username)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), messageTemplateTypeIDs, names, culture, portalID, username);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class sp_GetMessageTemplateTypeResult
	{
		
		private int _MessageTemplateTypeID;
		
		private string _Name;
		
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
		
		public sp_GetMessageTemplateTypeResult()
		{
		}
		
		[Column(Storage="_MessageTemplateTypeID", DbType="Int NOT NULL")]
		public int MessageTemplateTypeID
		{
			get
			{
				return this._MessageTemplateTypeID;
			}
			set
			{
				if ((this._MessageTemplateTypeID != value))
				{
					this._MessageTemplateTypeID = value;
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
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
	
	public partial class sp_GetMessageTemplateTypeListResult
	{
		
		private int _MessageTemplateTypeID;
		
		private string _Name;
		
		private string _CultureName;
		
		public sp_GetMessageTemplateTypeListResult()
		{
		}
		
		[Column(Storage="_MessageTemplateTypeID", DbType="Int NOT NULL")]
		public int MessageTemplateTypeID
		{
			get
			{
				return this._MessageTemplateTypeID;
			}
			set
			{
				if ((this._MessageTemplateTypeID != value))
				{
					this._MessageTemplateTypeID = value;
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[Column(Storage="_CultureName", DbType="NVarChar(200)")]
		public string CultureName
		{
			get
			{
				return this._CultureName;
			}
			set
			{
				if ((this._CultureName != value))
				{
					this._CultureName = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
