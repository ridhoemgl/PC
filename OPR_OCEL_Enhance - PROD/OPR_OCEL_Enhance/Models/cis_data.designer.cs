﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OPR_OCEL_Enhance.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DB_ONLINE_EXAM_OCEL")]
	public partial class cis_dataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTBL_M_CATEGORY_HANDBOOK_CI(TBL_M_CATEGORY_HANDBOOK_CI instance);
    partial void UpdateTBL_M_CATEGORY_HANDBOOK_CI(TBL_M_CATEGORY_HANDBOOK_CI instance);
    partial void DeleteTBL_M_CATEGORY_HANDBOOK_CI(TBL_M_CATEGORY_HANDBOOK_CI instance);
    partial void InsertTBL_R_HANDBOOK_CI(TBL_R_HANDBOOK_CI instance);
    partial void UpdateTBL_R_HANDBOOK_CI(TBL_R_HANDBOOK_CI instance);
    partial void DeleteTBL_R_HANDBOOK_CI(TBL_R_HANDBOOK_CI instance);
    #endregion
		
		public cis_dataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DB_ONLINE_EXAM_OCELConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public cis_dataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public cis_dataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public cis_dataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public cis_dataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TBL_M_CATEGORY_HANDBOOK_CI> TBL_M_CATEGORY_HANDBOOK_CIs
		{
			get
			{
				return this.GetTable<TBL_M_CATEGORY_HANDBOOK_CI>();
			}
		}
		
		public System.Data.Linq.Table<VW_LIST_HANDBOOK_CI> VW_LIST_HANDBOOK_CIs
		{
			get
			{
				return this.GetTable<VW_LIST_HANDBOOK_CI>();
			}
		}
		
		public System.Data.Linq.Table<TBL_R_HANDBOOK_CI> TBL_R_HANDBOOK_CIs
		{
			get
			{
				return this.GetTable<TBL_R_HANDBOOK_CI>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="cis.TBL_M_CATEGORY_HANDBOOK_CIS")]
	public partial class TBL_M_CATEGORY_HANDBOOK_CI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _PID_CATEGORY;
		
		private string _NAMA_CATEGORY;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPID_CATEGORYChanging(string value);
    partial void OnPID_CATEGORYChanged();
    partial void OnNAMA_CATEGORYChanging(string value);
    partial void OnNAMA_CATEGORYChanged();
    #endregion
		
		public TBL_M_CATEGORY_HANDBOOK_CI()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PID_CATEGORY", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string PID_CATEGORY
		{
			get
			{
				return this._PID_CATEGORY;
			}
			set
			{
				if ((this._PID_CATEGORY != value))
				{
					this.OnPID_CATEGORYChanging(value);
					this.SendPropertyChanging();
					this._PID_CATEGORY = value;
					this.SendPropertyChanged("PID_CATEGORY");
					this.OnPID_CATEGORYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAMA_CATEGORY", DbType="VarChar(50)")]
		public string NAMA_CATEGORY
		{
			get
			{
				return this._NAMA_CATEGORY;
			}
			set
			{
				if ((this._NAMA_CATEGORY != value))
				{
					this.OnNAMA_CATEGORYChanging(value);
					this.SendPropertyChanging();
					this._NAMA_CATEGORY = value;
					this.SendPropertyChanged("NAMA_CATEGORY");
					this.OnNAMA_CATEGORYChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="cis.VW_LIST_HANDBOOK_CIS")]
	public partial class VW_LIST_HANDBOOK_CI
	{
		
		private string _HANDBOOK_PID;
		
		private string _PID_CATEGORY;
		
		private string _NAMA_CATEGORY;
		
		private string _FILE_PATH;
		
		private string _FILE_NAME;
		
		private bool _IsActive;
		
		private System.Nullable<System.DateTime> _CREATED_DATE;
		
		public VW_LIST_HANDBOOK_CI()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HANDBOOK_PID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string HANDBOOK_PID
		{
			get
			{
				return this._HANDBOOK_PID;
			}
			set
			{
				if ((this._HANDBOOK_PID != value))
				{
					this._HANDBOOK_PID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PID_CATEGORY", DbType="VarChar(50)")]
		public string PID_CATEGORY
		{
			get
			{
				return this._PID_CATEGORY;
			}
			set
			{
				if ((this._PID_CATEGORY != value))
				{
					this._PID_CATEGORY = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAMA_CATEGORY", DbType="VarChar(50)")]
		public string NAMA_CATEGORY
		{
			get
			{
				return this._NAMA_CATEGORY;
			}
			set
			{
				if ((this._NAMA_CATEGORY != value))
				{
					this._NAMA_CATEGORY = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FILE_PATH", DbType="VarChar(200)")]
		public string FILE_PATH
		{
			get
			{
				return this._FILE_PATH;
			}
			set
			{
				if ((this._FILE_PATH != value))
				{
					this._FILE_PATH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FILE_NAME", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string FILE_NAME
		{
			get
			{
				return this._FILE_NAME;
			}
			set
			{
				if ((this._FILE_NAME != value))
				{
					this._FILE_NAME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit NOT NULL")]
		public bool IsActive
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATED_DATE", DbType="DateTime")]
		public System.Nullable<System.DateTime> CREATED_DATE
		{
			get
			{
				return this._CREATED_DATE;
			}
			set
			{
				if ((this._CREATED_DATE != value))
				{
					this._CREATED_DATE = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="cis.TBL_R_HANDBOOK_CIS")]
	public partial class TBL_R_HANDBOOK_CI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _HANDBOOK_PID;
		
		private string _PID_CATEGORY;
		
		private string _FILE_PATH;
		
		private string _FILE_NAME;
		
		private bool _IsActive;
		
		private System.Nullable<System.DateTime> _CREATED_DATE;
		
		private string _CREATED_BY;
		
		private System.Nullable<System.DateTime> _MODIF_DATE;
		
		private string _MODIF_BY;
		
		private string _GROUP_FLG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHANDBOOK_PIDChanging(string value);
    partial void OnHANDBOOK_PIDChanged();
    partial void OnPID_CATEGORYChanging(string value);
    partial void OnPID_CATEGORYChanged();
    partial void OnFILE_PATHChanging(string value);
    partial void OnFILE_PATHChanged();
    partial void OnFILE_NAMEChanging(string value);
    partial void OnFILE_NAMEChanged();
    partial void OnIsActiveChanging(bool value);
    partial void OnIsActiveChanged();
    partial void OnCREATED_DATEChanging(System.Nullable<System.DateTime> value);
    partial void OnCREATED_DATEChanged();
    partial void OnCREATED_BYChanging(string value);
    partial void OnCREATED_BYChanged();
    partial void OnMODIF_DATEChanging(System.Nullable<System.DateTime> value);
    partial void OnMODIF_DATEChanged();
    partial void OnMODIF_BYChanging(string value);
    partial void OnMODIF_BYChanged();
    partial void OnGROUP_FLGChanging(string value);
    partial void OnGROUP_FLGChanged();
    #endregion
		
		public TBL_R_HANDBOOK_CI()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HANDBOOK_PID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string HANDBOOK_PID
		{
			get
			{
				return this._HANDBOOK_PID;
			}
			set
			{
				if ((this._HANDBOOK_PID != value))
				{
					this.OnHANDBOOK_PIDChanging(value);
					this.SendPropertyChanging();
					this._HANDBOOK_PID = value;
					this.SendPropertyChanged("HANDBOOK_PID");
					this.OnHANDBOOK_PIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PID_CATEGORY", DbType="VarChar(50)")]
		public string PID_CATEGORY
		{
			get
			{
				return this._PID_CATEGORY;
			}
			set
			{
				if ((this._PID_CATEGORY != value))
				{
					this.OnPID_CATEGORYChanging(value);
					this.SendPropertyChanging();
					this._PID_CATEGORY = value;
					this.SendPropertyChanged("PID_CATEGORY");
					this.OnPID_CATEGORYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FILE_PATH", DbType="VarChar(200)")]
		public string FILE_PATH
		{
			get
			{
				return this._FILE_PATH;
			}
			set
			{
				if ((this._FILE_PATH != value))
				{
					this.OnFILE_PATHChanging(value);
					this.SendPropertyChanging();
					this._FILE_PATH = value;
					this.SendPropertyChanged("FILE_PATH");
					this.OnFILE_PATHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FILE_NAME", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string FILE_NAME
		{
			get
			{
				return this._FILE_NAME;
			}
			set
			{
				if ((this._FILE_NAME != value))
				{
					this.OnFILE_NAMEChanging(value);
					this.SendPropertyChanging();
					this._FILE_NAME = value;
					this.SendPropertyChanged("FILE_NAME");
					this.OnFILE_NAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit NOT NULL")]
		public bool IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATED_DATE", DbType="DateTime")]
		public System.Nullable<System.DateTime> CREATED_DATE
		{
			get
			{
				return this._CREATED_DATE;
			}
			set
			{
				if ((this._CREATED_DATE != value))
				{
					this.OnCREATED_DATEChanging(value);
					this.SendPropertyChanging();
					this._CREATED_DATE = value;
					this.SendPropertyChanged("CREATED_DATE");
					this.OnCREATED_DATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATED_BY", DbType="VarChar(50)")]
		public string CREATED_BY
		{
			get
			{
				return this._CREATED_BY;
			}
			set
			{
				if ((this._CREATED_BY != value))
				{
					this.OnCREATED_BYChanging(value);
					this.SendPropertyChanging();
					this._CREATED_BY = value;
					this.SendPropertyChanged("CREATED_BY");
					this.OnCREATED_BYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MODIF_DATE", DbType="DateTime")]
		public System.Nullable<System.DateTime> MODIF_DATE
		{
			get
			{
				return this._MODIF_DATE;
			}
			set
			{
				if ((this._MODIF_DATE != value))
				{
					this.OnMODIF_DATEChanging(value);
					this.SendPropertyChanging();
					this._MODIF_DATE = value;
					this.SendPropertyChanged("MODIF_DATE");
					this.OnMODIF_DATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MODIF_BY", DbType="VarChar(10)")]
		public string MODIF_BY
		{
			get
			{
				return this._MODIF_BY;
			}
			set
			{
				if ((this._MODIF_BY != value))
				{
					this.OnMODIF_BYChanging(value);
					this.SendPropertyChanging();
					this._MODIF_BY = value;
					this.SendPropertyChanged("MODIF_BY");
					this.OnMODIF_BYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GROUP_FLG", DbType="VarChar(50)")]
		public string GROUP_FLG
		{
			get
			{
				return this._GROUP_FLG;
			}
			set
			{
				if ((this._GROUP_FLG != value))
				{
					this.OnGROUP_FLGChanging(value);
					this.SendPropertyChanging();
					this._GROUP_FLG = value;
					this.SendPropertyChanged("GROUP_FLG");
					this.OnGROUP_FLGChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591