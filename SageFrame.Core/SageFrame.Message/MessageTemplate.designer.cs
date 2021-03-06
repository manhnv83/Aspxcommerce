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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="SageFrameCorporate")]
	public partial class MessageTemplateDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public MessageTemplateDataContext() : 
				base(global::SageFrame.Core.Properties.Settings.Default.SageFrameCorporateConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MessageTemplateDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MessageTemplateDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MessageTemplateDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MessageTemplateDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[Function(Name="dbo.sp_MessageTemplateDelete")]
		public int sp_MessageTemplateDelete([Parameter(Name="MessageTemplateID", DbType="Int")] System.Nullable<int> messageTemplateID, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="DeletedOn", DbType="DateTime")] System.Nullable<System.DateTime> deletedOn, [Parameter(Name="DeletedBy", DbType="NVarChar(256)")] string deletedBy)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), messageTemplateID, portalID, deletedOn, deletedBy);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_GetMessageTemplate")]
		public ISingleResult<sp_GetMessageTemplateResult> sp_GetMessageTemplate([Parameter(Name="MessageTemplateID", DbType="Int")] System.Nullable<int> messageTemplateID, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), messageTemplateID, portalID);
			return ((ISingleResult<sp_GetMessageTemplateResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_MessageTemplateByMessageTemplateTypeID")]
		public ISingleResult<sp_MessageTemplateByMessageTemplateTypeIDResult> sp_MessageTemplateByMessageTemplateTypeID([Parameter(Name="MessageTemplateTypeID", DbType="Int")] System.Nullable<int> messageTemplateTypeID, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), messageTemplateTypeID, portalID);
			return ((ISingleResult<sp_MessageTemplateByMessageTemplateTypeIDResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_MessageTemplateAdd")]
        public int sp_MessageTemplateAdd([Parameter(Name = "MessageTemplateID", DbType = "Int")] ref System.Nullable<int> messageTemplateID, [Parameter(Name = "MessageTemplateTypeID", DbType = "Int")] System.Nullable<int> messageTemplateTypeID, [Parameter(Name = "Subject", DbType = "NVarChar(200)")] string subject, [Parameter(Name = "Body", DbType = "NText")] string body, [Parameter(Name = "MailFrom", DbType = "NVarChar(100)")] string mailFrom, [Parameter(Name = "IsActive", DbType = "Bit")] System.Nullable<bool> isActive, [Parameter(Name = "AddedOn", DbType = "DateTime")] System.Nullable<System.DateTime> addedOn, [Parameter(Name = "PortalID", DbType = "Int")] System.Nullable<int> portalID, [Parameter(Name = "AddedBy", DbType = "NVarChar(256)")] string addedBy, [Parameter(Name = "CurrentCulture", DbType = "NVarChar(256)")] string currentCulture)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), messageTemplateID, messageTemplateTypeID, subject, body, mailFrom, isActive, addedOn, portalID, addedBy, currentCulture);
			messageTemplateID = ((System.Nullable<int>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_GetMessageTemplateList")]
		public ISingleResult<sp_GetMessageTemplateListResult> sp_GetMessageTemplateList([Parameter(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive, [Parameter(Name="IsDeleted", DbType="Bit")] System.Nullable<bool> isDeleted, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="Username", DbType="NVarChar(256)")] string username, [Parameter(Name="CurrentCulture", DbType="NVarChar(256)")] string currentCulture)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), isActive, isDeleted, portalID, username, currentCulture);
			return ((ISingleResult<sp_GetMessageTemplateListResult>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.sp_MessageTemplateUpdate")]
		public int sp_MessageTemplateUpdate([Parameter(Name="MessageTemplateID", DbType="Int")] System.Nullable<int> messageTemplateID, [Parameter(Name="MessageTemplateTypeID", DbType="Int")] System.Nullable<int> messageTemplateTypeID, [Parameter(Name="Subject", DbType="NVarChar(200)")] string subject, [Parameter(Name="Body", DbType="NText")] string body, [Parameter(Name="MailFrom", DbType="NVarChar(100)")] string mailFrom, [Parameter(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive, [Parameter(Name="UpdatedOn", DbType="DateTime")] System.Nullable<System.DateTime> updatedOn, [Parameter(Name="PortalID", DbType="Int")] System.Nullable<int> portalID, [Parameter(Name="UpdatedBy", DbType="NVarChar(256)")] string updatedBy, [Parameter(Name="CurrentCulture", DbType="NVarChar(256)")] string currentCulture)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), messageTemplateID, messageTemplateTypeID, subject, body, mailFrom, isActive, updatedOn, portalID, updatedBy, currentCulture);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class sp_GetMessageTemplateResult
	{
		
		private int _MessageTemplateID;
		
		private int _MessageTemplateTypeID;
		
		private string _Subject;
		
		private string _Body;
		
		private string _MailFrom;
		
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
		
		public sp_GetMessageTemplateResult()
		{
		}
		
		[Column(Storage="_MessageTemplateID", DbType="Int NOT NULL")]
		public int MessageTemplateID
		{
			get
			{
				return this._MessageTemplateID;
			}
			set
			{
				if ((this._MessageTemplateID != value))
				{
					this._MessageTemplateID = value;
				}
			}
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
		
		[Column(Storage="_Subject", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Subject
		{
			get
			{
				return this._Subject;
			}
			set
			{
				if ((this._Subject != value))
				{
					this._Subject = value;
				}
			}
		}
		
		[Column(Storage="_Body", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this._Body = value;
				}
			}
		}
		
		[Column(Storage="_MailFrom", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string MailFrom
		{
			get
			{
				return this._MailFrom;
			}
			set
			{
				if ((this._MailFrom != value))
				{
					this._MailFrom = value;
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
	
	public partial class sp_MessageTemplateByMessageTemplateTypeIDResult
	{
		
		private int _MessageTemplateID;
		
		private int _MessageTemplateTypeID;
		
		private string _Subject;
		
		private string _Body;
		
		private string _MailFrom;
		
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
		
		public sp_MessageTemplateByMessageTemplateTypeIDResult()
		{
		}
		
		[Column(Storage="_MessageTemplateID", DbType="Int NOT NULL")]
		public int MessageTemplateID
		{
			get
			{
				return this._MessageTemplateID;
			}
			set
			{
				if ((this._MessageTemplateID != value))
				{
					this._MessageTemplateID = value;
				}
			}
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
		
		[Column(Storage="_Subject", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Subject
		{
			get
			{
				return this._Subject;
			}
			set
			{
				if ((this._Subject != value))
				{
					this._Subject = value;
				}
			}
		}
		
		[Column(Storage="_Body", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this._Body = value;
				}
			}
		}
		
		[Column(Storage="_MailFrom", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string MailFrom
		{
			get
			{
				return this._MailFrom;
			}
			set
			{
				if ((this._MailFrom != value))
				{
					this._MailFrom = value;
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
	
	public partial class sp_GetMessageTemplateListResult
	{
		
		private int _MessageTemplateID;
		
		private int _MessageTemplateTypeID;
		
		private string _Subject;
		
		private string _Body;
		
		private string _MailFrom;
		
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
		
		public sp_GetMessageTemplateListResult()
		{
		}
		
		[Column(Storage="_MessageTemplateID", DbType="Int NOT NULL")]
		public int MessageTemplateID
		{
			get
			{
				return this._MessageTemplateID;
			}
			set
			{
				if ((this._MessageTemplateID != value))
				{
					this._MessageTemplateID = value;
				}
			}
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
		
		[Column(Storage="_Subject", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Subject
		{
			get
			{
				return this._Subject;
			}
			set
			{
				if ((this._Subject != value))
				{
					this._Subject = value;
				}
			}
		}
		
		[Column(Storage="_Body", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this._Body = value;
				}
			}
		}
		
		[Column(Storage="_MailFrom", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string MailFrom
		{
			get
			{
				return this._MailFrom;
			}
			set
			{
				if ((this._MailFrom != value))
				{
					this._MailFrom = value;
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
}
#pragma warning restore 1591
