﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProCModel
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ProjectCooperation")]
	public partial class LQ2DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertTDepartment(TDepartment instance);
    partial void UpdateTDepartment(TDepartment instance);
    partial void DeleteTDepartment(TDepartment instance);
    partial void InsertTUser(TUser instance);
    partial void UpdateTUser(TUser instance);
    partial void DeleteTUser(TUser instance);
    #endregion
		
		public LQ2DBDataContext() : 
				base(global::ProCModel.Properties.Settings.Default.ProjectCooperationConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public LQ2DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LQ2DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LQ2DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LQ2DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TDepartment> TDepartment
		{
			get
			{
				return this.GetTable<TDepartment>();
			}
		}
		
		public System.Data.Linq.Table<TUser> TUser
		{
			get
			{
				return this.GetTable<TUser>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.t_bas_department")]
	public partial class TDepartment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _deptid;
		
		private string _deptname;
		
		private string _description;
		
		private string _manager;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OndeptidChanging(int value);
    partial void OndeptidChanged();
    partial void OndeptnameChanging(string value);
    partial void OndeptnameChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnmanagerChanging(string value);
    partial void OnmanagerChanged();
    #endregion
		
		public TDepartment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deptid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int deptid
		{
			get
			{
				return this._deptid;
			}
			set
			{
				if ((this._deptid != value))
				{
					this.OndeptidChanging(value);
					this.SendPropertyChanging();
					this._deptid = value;
					this.SendPropertyChanged("deptid");
					this.OndeptidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deptname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string deptname
		{
			get
			{
				return this._deptname;
			}
			set
			{
				if ((this._deptname != value))
				{
					this.OndeptnameChanging(value);
					this.SendPropertyChanging();
					this._deptname = value;
					this.SendPropertyChanged("deptname");
					this.OndeptnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(200)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_manager", DbType="NChar(10)")]
		public string manager
		{
			get
			{
				return this._manager;
			}
			set
			{
				if ((this._manager != value))
				{
					this.OnmanagerChanging(value);
					this.SendPropertyChanging();
					this._manager = value;
					this.SendPropertyChanged("manager");
					this.OnmanagerChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.t_bas_user")]
	public partial class TUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _userid;
		
		private string _logname;
		
		private string _password;
		
		private string _name;
		
		private string _phone;
		
		private string _email;
		
		private string _deptid;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuseridChanging(int value);
    partial void OnuseridChanged();
    partial void OnlognameChanging(string value);
    partial void OnlognameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OndeptidChanging(string value);
    partial void OndeptidChanged();
    #endregion
		
		public TUser()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userid", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int userid
		{
			get
			{
				return this._userid;
			}
			set
			{
				if ((this._userid != value))
				{
					this.OnuseridChanging(value);
					this.SendPropertyChanging();
					this._userid = value;
					this.SendPropertyChanged("userid");
					this.OnuseridChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_logname", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string logname
		{
			get
			{
				return this._logname;
			}
			set
			{
				if ((this._logname != value))
				{
					this.OnlognameChanging(value);
					this.SendPropertyChanging();
					this._logname = value;
					this.SendPropertyChanged("logname");
					this.OnlognameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deptid", DbType="NChar(10)")]
		public string deptid
		{
			get
			{
				return this._deptid;
			}
			set
			{
				if ((this._deptid != value))
				{
					this.OndeptidChanging(value);
					this.SendPropertyChanging();
					this._deptid = value;
					this.SendPropertyChanged("deptid");
					this.OndeptidChanged();
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
