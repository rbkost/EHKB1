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

namespace SiteDraft1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EHKBTest")]
	public partial class DataLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEHKB(EHKB instance);
    partial void UpdateEHKB(EHKB instance);
    partial void DeleteEHKB(EHKB instance);
    #endregion
		
		public DataLinqDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["EHKBTestConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EHKB> EHKBs
		{
			get
			{
				return this.GetTable<EHKB>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EHKB")]
	public partial class EHKB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _Summary;
		
		private string _LongDescription;
		
		private string _Tags;
		
		private string _Body;
		
		private string _DataAdded;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnSummaryChanging(string value);
    partial void OnSummaryChanged();
    partial void OnLongDescriptionChanging(string value);
    partial void OnLongDescriptionChanged();
    partial void OnTagsChanging(string value);
    partial void OnTagsChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    partial void OnDataAddedChanging(string value);
    partial void OnDataAddedChanged();
    #endregion
		
		public EHKB()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Summary", DbType="NVarChar(MAX)")]
		public string Summary
		{
			get
			{
				return this._Summary;
			}
			set
			{
				if ((this._Summary != value))
				{
					this.OnSummaryChanging(value);
					this.SendPropertyChanging();
					this._Summary = value;
					this.SendPropertyChanged("Summary");
					this.OnSummaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LongDescription", DbType="NVarChar(MAX)")]
		public string LongDescription
		{
			get
			{
				return this._LongDescription;
			}
			set
			{
				if ((this._LongDescription != value))
				{
					this.OnLongDescriptionChanging(value);
					this.SendPropertyChanging();
					this._LongDescription = value;
					this.SendPropertyChanged("LongDescription");
					this.OnLongDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tags", DbType="NVarChar(MAX)")]
		public string Tags
		{
			get
			{
				return this._Tags;
			}
			set
			{
				if ((this._Tags != value))
				{
					this.OnTagsChanging(value);
					this.SendPropertyChanging();
					this._Tags = value;
					this.SendPropertyChanged("Tags");
					this.OnTagsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="NVarChar(MAX)")]
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
					this.OnBodyChanging(value);
					this.SendPropertyChanging();
					this._Body = value;
					this.SendPropertyChanged("Body");
					this.OnBodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataAdded", DbType="NVarChar(MAX)")]
		public string DataAdded
		{
			get
			{
				return this._DataAdded;
			}
			set
			{
				if ((this._DataAdded != value))
				{
					this.OnDataAddedChanging(value);
					this.SendPropertyChanging();
					this._DataAdded = value;
					this.SendPropertyChanged("DataAdded");
					this.OnDataAddedChanged();
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
