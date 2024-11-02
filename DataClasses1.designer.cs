﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp4
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Countries")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertCapitals(Capitals instance);
    partial void UpdateCapitals(Capitals instance);
    partial void DeleteCapitals(Capitals instance);
    partial void InsertCities(Cities instance);
    partial void UpdateCities(Cities instance);
    partial void DeleteCities(Cities instance);
    partial void InsertCountries(Countries instance);
    partial void UpdateCountries(Countries instance);
    partial void DeleteCountries(Countries instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WindowsFormsApp4.Properties.Settings.Default.CountriesConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Capitals> Capitals
		{
			get
			{
				return this.GetTable<Capitals>();
			}
		}
		
		public System.Data.Linq.Table<Cities> Cities
		{
			get
			{
				return this.GetTable<Cities>();
			}
		}
		
		public System.Data.Linq.Table<Countries> Countries
		{
			get
			{
				return this.GetTable<Countries>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Capitals")]
	public partial class Capitals : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _CountryId;
		
		private string _CapitalName;
		
		private System.Nullable<int> _CapitalPopulation;
		
		private EntityRef<Countries> _Countries;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCountryIdChanging(int value);
    partial void OnCountryIdChanged();
    partial void OnCapitalNameChanging(string value);
    partial void OnCapitalNameChanged();
    partial void OnCapitalPopulationChanging(System.Nullable<int> value);
    partial void OnCapitalPopulationChanged();
    #endregion
		
		public Capitals()
		{
			this._Countries = default(EntityRef<Countries>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryId", DbType="Int NOT NULL")]
		public int CountryId
		{
			get
			{
				return this._CountryId;
			}
			set
			{
				if ((this._CountryId != value))
				{
					if (this._Countries.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCountryIdChanging(value);
					this.SendPropertyChanging();
					this._CountryId = value;
					this.SendPropertyChanged("CountryId");
					this.OnCountryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CapitalName", DbType="NVarChar(100)")]
		public string CapitalName
		{
			get
			{
				return this._CapitalName;
			}
			set
			{
				if ((this._CapitalName != value))
				{
					this.OnCapitalNameChanging(value);
					this.SendPropertyChanging();
					this._CapitalName = value;
					this.SendPropertyChanged("CapitalName");
					this.OnCapitalNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CapitalPopulation", DbType="Int")]
		public System.Nullable<int> CapitalPopulation
		{
			get
			{
				return this._CapitalPopulation;
			}
			set
			{
				if ((this._CapitalPopulation != value))
				{
					this.OnCapitalPopulationChanging(value);
					this.SendPropertyChanging();
					this._CapitalPopulation = value;
					this.SendPropertyChanged("CapitalPopulation");
					this.OnCapitalPopulationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Countries_Capitals", Storage="_Countries", ThisKey="CountryId", OtherKey="Id", IsForeignKey=true)]
		public Countries Countries
		{
			get
			{
				return this._Countries.Entity;
			}
			set
			{
				Countries previousValue = this._Countries.Entity;
				if (((previousValue != value) 
							|| (this._Countries.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Countries.Entity = null;
						previousValue.Capitals.Remove(this);
					}
					this._Countries.Entity = value;
					if ((value != null))
					{
						value.Capitals.Add(this);
						this._CountryId = value.Id;
					}
					else
					{
						this._CountryId = default(int);
					}
					this.SendPropertyChanged("Countries");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cities")]
	public partial class Cities : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _CountryId;
		
		private string _CityName;
		
		private System.Nullable<int> _CityPopulation;
		
		private EntityRef<Countries> _Countries;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCountryIdChanging(int value);
    partial void OnCountryIdChanged();
    partial void OnCityNameChanging(string value);
    partial void OnCityNameChanged();
    partial void OnCityPopulationChanging(System.Nullable<int> value);
    partial void OnCityPopulationChanged();
    #endregion
		
		public Cities()
		{
			this._Countries = default(EntityRef<Countries>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryId", DbType="Int NOT NULL")]
		public int CountryId
		{
			get
			{
				return this._CountryId;
			}
			set
			{
				if ((this._CountryId != value))
				{
					if (this._Countries.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCountryIdChanging(value);
					this.SendPropertyChanging();
					this._CountryId = value;
					this.SendPropertyChanged("CountryId");
					this.OnCountryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityName", DbType="NVarChar(100)")]
		public string CityName
		{
			get
			{
				return this._CityName;
			}
			set
			{
				if ((this._CityName != value))
				{
					this.OnCityNameChanging(value);
					this.SendPropertyChanging();
					this._CityName = value;
					this.SendPropertyChanged("CityName");
					this.OnCityNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityPopulation", DbType="Int")]
		public System.Nullable<int> CityPopulation
		{
			get
			{
				return this._CityPopulation;
			}
			set
			{
				if ((this._CityPopulation != value))
				{
					this.OnCityPopulationChanging(value);
					this.SendPropertyChanging();
					this._CityPopulation = value;
					this.SendPropertyChanged("CityPopulation");
					this.OnCityPopulationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Countries_Cities", Storage="_Countries", ThisKey="CountryId", OtherKey="Id", IsForeignKey=true)]
		public Countries Countries
		{
			get
			{
				return this._Countries.Entity;
			}
			set
			{
				Countries previousValue = this._Countries.Entity;
				if (((previousValue != value) 
							|| (this._Countries.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Countries.Entity = null;
						previousValue.Cities.Remove(this);
					}
					this._Countries.Entity = value;
					if ((value != null))
					{
						value.Cities.Add(this);
						this._CountryId = value.Id;
					}
					else
					{
						this._CountryId = default(int);
					}
					this.SendPropertyChanged("Countries");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Countries")]
	public partial class Countries : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _CountryName;
		
		private int _Population;
		
		private System.Nullable<decimal> _Area;
		
		private string _Continent;
		
		private EntitySet<Capitals> _Capitals;
		
		private EntitySet<Cities> _Cities;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCountryNameChanging(string value);
    partial void OnCountryNameChanged();
    partial void OnPopulationChanging(int value);
    partial void OnPopulationChanged();
    partial void OnAreaChanging(System.Nullable<decimal> value);
    partial void OnAreaChanged();
    partial void OnContinentChanging(string value);
    partial void OnContinentChanged();
    #endregion
		
		public Countries()
		{
			this._Capitals = new EntitySet<Capitals>(new Action<Capitals>(this.attach_Capitals), new Action<Capitals>(this.detach_Capitals));
			this._Cities = new EntitySet<Cities>(new Action<Cities>(this.attach_Cities), new Action<Cities>(this.detach_Cities));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string CountryName
		{
			get
			{
				return this._CountryName;
			}
			set
			{
				if ((this._CountryName != value))
				{
					this.OnCountryNameChanging(value);
					this.SendPropertyChanging();
					this._CountryName = value;
					this.SendPropertyChanged("CountryName");
					this.OnCountryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Population", DbType="Int NOT NULL")]
		public int Population
		{
			get
			{
				return this._Population;
			}
			set
			{
				if ((this._Population != value))
				{
					this.OnPopulationChanging(value);
					this.SendPropertyChanging();
					this._Population = value;
					this.SendPropertyChanged("Population");
					this.OnPopulationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Area", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> Area
		{
			get
			{
				return this._Area;
			}
			set
			{
				if ((this._Area != value))
				{
					this.OnAreaChanging(value);
					this.SendPropertyChanging();
					this._Area = value;
					this.SendPropertyChanged("Area");
					this.OnAreaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Continent", DbType="NVarChar(50)")]
		public string Continent
		{
			get
			{
				return this._Continent;
			}
			set
			{
				if ((this._Continent != value))
				{
					this.OnContinentChanging(value);
					this.SendPropertyChanging();
					this._Continent = value;
					this.SendPropertyChanged("Continent");
					this.OnContinentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Countries_Capitals", Storage="_Capitals", ThisKey="Id", OtherKey="CountryId")]
		public EntitySet<Capitals> Capitals
		{
			get
			{
				return this._Capitals;
			}
			set
			{
				this._Capitals.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Countries_Cities", Storage="_Cities", ThisKey="Id", OtherKey="CountryId")]
		public EntitySet<Cities> Cities
		{
			get
			{
				return this._Cities;
			}
			set
			{
				this._Cities.Assign(value);
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
		
		private void attach_Capitals(Capitals entity)
		{
			this.SendPropertyChanging();
			entity.Countries = this;
		}
		
		private void detach_Capitals(Capitals entity)
		{
			this.SendPropertyChanging();
			entity.Countries = null;
		}
		
		private void attach_Cities(Cities entity)
		{
			this.SendPropertyChanging();
			entity.Countries = this;
		}
		
		private void detach_Cities(Cities entity)
		{
			this.SendPropertyChanging();
			entity.Countries = null;
		}
	}
}
#pragma warning restore 1591