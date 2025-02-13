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

namespace final_oosee.Business
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Job_Management")]
	public partial class JobManagemetDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEMPLOYER(EMPLOYER instance);
    partial void UpdateEMPLOYER(EMPLOYER instance);
    partial void DeleteEMPLOYER(EMPLOYER instance);
    partial void InsertJOB(JOB instance);
    partial void UpdateJOB(JOB instance);
    partial void DeleteJOB(JOB instance);
    partial void InsertSTUDENT(STUDENT instance);
    partial void UpdateSTUDENT(STUDENT instance);
    partial void DeleteSTUDENT(STUDENT instance);
    partial void InsertstudentApplied(studentApplied instance);
    partial void UpdatestudentApplied(studentApplied instance);
    partial void DeletestudentApplied(studentApplied instance);
    partial void InsertUSERS(USERS instance);
    partial void UpdateUSERS(USERS instance);
    partial void DeleteUSERS(USERS instance);
    #endregion
		
		public JobManagemetDataContext() : 
				base(global::final_oosee.Properties.Settings.Default.Job_ManagementConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public JobManagemetDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JobManagemetDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JobManagemetDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JobManagemetDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EMPLOYER> EMPLOYERs
		{
			get
			{
				return this.GetTable<EMPLOYER>();
			}
		}
		
		public System.Data.Linq.Table<JOB> JOBs
		{
			get
			{
				return this.GetTable<JOB>();
			}
		}
		
		public System.Data.Linq.Table<STUDENT> STUDENTs
		{
			get
			{
				return this.GetTable<STUDENT>();
			}
		}
		
		public System.Data.Linq.Table<studentApplied> studentApplieds
		{
			get
			{
				return this.GetTable<studentApplied>();
			}
		}
		
		public System.Data.Linq.Table<USERS> USERS
		{
			get
			{
				return this.GetTable<USERS>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EMPLOYER")]
	public partial class EMPLOYER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _employerName;
		
		private string _address;
		
		private string _phoneNumber;
		
		private System.Nullable<int> _userID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnemployerNameChanging(string value);
    partial void OnemployerNameChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnphoneNumberChanging(string value);
    partial void OnphoneNumberChanged();
    partial void OnuserIDChanging(System.Nullable<int> value);
    partial void OnuserIDChanged();
    #endregion
		
		public EMPLOYER()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employerName", DbType="NVarChar(50)")]
		public string employerName
		{
			get
			{
				return this._employerName;
			}
			set
			{
				if ((this._employerName != value))
				{
					this.OnemployerNameChanging(value);
					this.SendPropertyChanging();
					this._employerName = value;
					this.SendPropertyChanged("employerName");
					this.OnemployerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NVarChar(50)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phoneNumber", DbType="VarChar(15)")]
		public string phoneNumber
		{
			get
			{
				return this._phoneNumber;
			}
			set
			{
				if ((this._phoneNumber != value))
				{
					this.OnphoneNumberChanging(value);
					this.SendPropertyChanging();
					this._phoneNumber = value;
					this.SendPropertyChanged("phoneNumber");
					this.OnphoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="Int")]
		public System.Nullable<int> userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.JOB")]
	public partial class JOB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _employerID;
		
		private string _jobName;
		
		private string _jobDescription;
		
		private string _address;
		
		private System.Nullable<int> _wagePerHour;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnemployerIDChanging(System.Nullable<int> value);
    partial void OnemployerIDChanged();
    partial void OnjobNameChanging(string value);
    partial void OnjobNameChanged();
    partial void OnjobDescriptionChanging(string value);
    partial void OnjobDescriptionChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnwagePerHourChanging(System.Nullable<int> value);
    partial void OnwagePerHourChanged();
    #endregion
		
		public JOB()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employerID", DbType="Int")]
		public System.Nullable<int> employerID
		{
			get
			{
				return this._employerID;
			}
			set
			{
				if ((this._employerID != value))
				{
					this.OnemployerIDChanging(value);
					this.SendPropertyChanging();
					this._employerID = value;
					this.SendPropertyChanged("employerID");
					this.OnemployerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jobName", DbType="NVarChar(20)")]
		public string jobName
		{
			get
			{
				return this._jobName;
			}
			set
			{
				if ((this._jobName != value))
				{
					this.OnjobNameChanging(value);
					this.SendPropertyChanging();
					this._jobName = value;
					this.SendPropertyChanged("jobName");
					this.OnjobNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jobDescription", DbType="NVarChar(300)")]
		public string jobDescription
		{
			get
			{
				return this._jobDescription;
			}
			set
			{
				if ((this._jobDescription != value))
				{
					this.OnjobDescriptionChanging(value);
					this.SendPropertyChanging();
					this._jobDescription = value;
					this.SendPropertyChanged("jobDescription");
					this.OnjobDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NVarChar(50)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wagePerHour", DbType="Int")]
		public System.Nullable<int> wagePerHour
		{
			get
			{
				return this._wagePerHour;
			}
			set
			{
				if ((this._wagePerHour != value))
				{
					this.OnwagePerHourChanging(value);
					this.SendPropertyChanging();
					this._wagePerHour = value;
					this.SendPropertyChanged("wagePerHour");
					this.OnwagePerHourChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.STUDENT")]
	public partial class STUDENT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _fullName;
		
		private string _dateOfBirth;
		
		private string _address;
		
		private string _gender;
		
		private string _phoneNumber;
		
		private string _healthCondition;
		
		private string _additionalCondition;
		
		private System.Nullable<int> _userID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnfullNameChanging(string value);
    partial void OnfullNameChanged();
    partial void OndateOfBirthChanging(string value);
    partial void OndateOfBirthChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OnphoneNumberChanging(string value);
    partial void OnphoneNumberChanged();
    partial void OnhealthConditionChanging(string value);
    partial void OnhealthConditionChanged();
    partial void OnadditionalConditionChanging(string value);
    partial void OnadditionalConditionChanged();
    partial void OnuserIDChanging(System.Nullable<int> value);
    partial void OnuserIDChanged();
    #endregion
		
		public STUDENT()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fullName", DbType="NVarChar(50)")]
		public string fullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				if ((this._fullName != value))
				{
					this.OnfullNameChanging(value);
					this.SendPropertyChanging();
					this._fullName = value;
					this.SendPropertyChanged("fullName");
					this.OnfullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateOfBirth", DbType="VarChar(20)")]
		public string dateOfBirth
		{
			get
			{
				return this._dateOfBirth;
			}
			set
			{
				if ((this._dateOfBirth != value))
				{
					this.OndateOfBirthChanging(value);
					this.SendPropertyChanging();
					this._dateOfBirth = value;
					this.SendPropertyChanged("dateOfBirth");
					this.OndateOfBirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NVarChar(50)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="NVarChar(20)")]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phoneNumber", DbType="VarChar(15)")]
		public string phoneNumber
		{
			get
			{
				return this._phoneNumber;
			}
			set
			{
				if ((this._phoneNumber != value))
				{
					this.OnphoneNumberChanging(value);
					this.SendPropertyChanging();
					this._phoneNumber = value;
					this.SendPropertyChanged("phoneNumber");
					this.OnphoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_healthCondition", DbType="NVarChar(50)")]
		public string healthCondition
		{
			get
			{
				return this._healthCondition;
			}
			set
			{
				if ((this._healthCondition != value))
				{
					this.OnhealthConditionChanging(value);
					this.SendPropertyChanging();
					this._healthCondition = value;
					this.SendPropertyChanged("healthCondition");
					this.OnhealthConditionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_additionalCondition", DbType="NVarChar(50)")]
		public string additionalCondition
		{
			get
			{
				return this._additionalCondition;
			}
			set
			{
				if ((this._additionalCondition != value))
				{
					this.OnadditionalConditionChanging(value);
					this.SendPropertyChanging();
					this._additionalCondition = value;
					this.SendPropertyChanged("additionalCondition");
					this.OnadditionalConditionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="Int")]
		public System.Nullable<int> userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.studentApplied")]
	public partial class studentApplied : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _studentID;
		
		private System.Nullable<int> _jobID;
		
		private string _jobName;
		
		private string _status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnstudentIDChanging(System.Nullable<int> value);
    partial void OnstudentIDChanged();
    partial void OnjobIDChanging(System.Nullable<int> value);
    partial void OnjobIDChanged();
    partial void OnjobNameChanging(string value);
    partial void OnjobNameChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    #endregion
		
		public studentApplied()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentID", DbType="Int")]
		public System.Nullable<int> studentID
		{
			get
			{
				return this._studentID;
			}
			set
			{
				if ((this._studentID != value))
				{
					this.OnstudentIDChanging(value);
					this.SendPropertyChanging();
					this._studentID = value;
					this.SendPropertyChanged("studentID");
					this.OnstudentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jobID", DbType="Int")]
		public System.Nullable<int> jobID
		{
			get
			{
				return this._jobID;
			}
			set
			{
				if ((this._jobID != value))
				{
					this.OnjobIDChanging(value);
					this.SendPropertyChanging();
					this._jobID = value;
					this.SendPropertyChanged("jobID");
					this.OnjobIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jobName", DbType="NVarChar(50)")]
		public string jobName
		{
			get
			{
				return this._jobName;
			}
			set
			{
				if ((this._jobName != value))
				{
					this.OnjobNameChanging(value);
					this.SendPropertyChanging();
					this._jobName = value;
					this.SendPropertyChanged("jobName");
					this.OnjobNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NVarChar(10)")]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.USERS")]
	public partial class USERS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _username;
		
		private string _password;
		
		private string _role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnroleChanging(string value);
    partial void OnroleChanged();
    #endregion
		
		public USERS()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(20)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_role", DbType="VarChar(20)")]
		public string role
		{
			get
			{
				return this._role;
			}
			set
			{
				if ((this._role != value))
				{
					this.OnroleChanging(value);
					this.SendPropertyChanging();
					this._role = value;
					this.SendPropertyChanged("role");
					this.OnroleChanged();
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
