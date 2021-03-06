﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TempSensor
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Arduino")]
	public partial class DBArduinoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSensorTemperatura(SensorTemperatura instance);
    partial void UpdateSensorTemperatura(SensorTemperatura instance);
    partial void DeleteSensorTemperatura(SensorTemperatura instance);
    #endregion
		
		public DBArduinoDataContext() : 
				base(global::TempSensor.Properties.Settings.Default.ArduinoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBArduinoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBArduinoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBArduinoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBArduinoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SensorTemperatura> SensorTemperaturas
		{
			get
			{
				return this.GetTable<SensorTemperatura>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SensorTemperatura")]
	public partial class SensorTemperatura : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<System.DateTime> _FechaHora;
		
		private System.Nullable<decimal> _Celsius;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFechaHoraChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaHoraChanged();
    partial void OnCelsiusChanging(System.Nullable<decimal> value);
    partial void OnCelsiusChanged();
    #endregion
		
		public SensorTemperatura()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaHora", DbType="DateTime")]
		public System.Nullable<System.DateTime> FechaHora
		{
			get
			{
				return this._FechaHora;
			}
			set
			{
				if ((this._FechaHora != value))
				{
					this.OnFechaHoraChanging(value);
					this.SendPropertyChanging();
					this._FechaHora = value;
					this.SendPropertyChanged("FechaHora");
					this.OnFechaHoraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Celsius", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Celsius
		{
			get
			{
				return this._Celsius;
			}
			set
			{
				if ((this._Celsius != value))
				{
					this.OnCelsiusChanging(value);
					this.SendPropertyChanging();
					this._Celsius = value;
					this.SendPropertyChanged("Celsius");
					this.OnCelsiusChanged();
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
