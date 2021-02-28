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

namespace P2._3Ziekmelding
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ZiekmeldingDB")]
	public partial class dbZiekmeldingDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertmeldingen(meldingen instance);
    partial void Updatemeldingen(meldingen instance);
    partial void Deletemeldingen(meldingen instance);
    partial void Insertpersonen(personen instance);
    partial void Updatepersonen(personen instance);
    partial void Deletepersonen(personen instance);
    #endregion
		
		public dbZiekmeldingDataContext() : 
				base(global::P2._3Ziekmelding.Properties.Settings.Default.ZiekmeldingDBDataContext, mappingSource)
		{
			OnCreated();
		}
		
		public dbZiekmeldingDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbZiekmeldingDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbZiekmeldingDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbZiekmeldingDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<meldingen> meldingens
		{
			get
			{
				return this.GetTable<meldingen>();
			}
		}
		
		public System.Data.Linq.Table<personen> personens
		{
			get
			{
				return this.GetTable<personen>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.meldingen")]
	public partial class meldingen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _pid;
		
		private System.Nullable<System.DateTime> _DatumZiek;
		
		private System.Nullable<System.DateTime> _DatumBeter;
		
		private EntityRef<personen> _personen;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnpidChanging(System.Nullable<int> value);
    partial void OnpidChanged();
    partial void OnDatumZiekChanging(System.Nullable<System.DateTime> value);
    partial void OnDatumZiekChanged();
    partial void OnDatumBeterChanging(System.Nullable<System.DateTime> value);
    partial void OnDatumBeterChanged();
    #endregion
		
		public meldingen()
		{
			this._personen = default(EntityRef<personen>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pid", DbType="Int")]
		public System.Nullable<int> pid
		{
			get
			{
				return this._pid;
			}
			set
			{
				if ((this._pid != value))
				{
					if (this._personen.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnpidChanging(value);
					this.SendPropertyChanging();
					this._pid = value;
					this.SendPropertyChanged("pid");
					this.OnpidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DatumZiek", DbType="DateTime")]
		public System.Nullable<System.DateTime> DatumZiek
		{
			get
			{
				return this._DatumZiek;
			}
			set
			{
				if ((this._DatumZiek != value))
				{
					this.OnDatumZiekChanging(value);
					this.SendPropertyChanging();
					this._DatumZiek = value;
					this.SendPropertyChanged("DatumZiek");
					this.OnDatumZiekChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DatumBeter", DbType="DateTime")]
		public System.Nullable<System.DateTime> DatumBeter
		{
			get
			{
				return this._DatumBeter;
			}
			set
			{
				if ((this._DatumBeter != value))
				{
					this.OnDatumBeterChanging(value);
					this.SendPropertyChanging();
					this._DatumBeter = value;
					this.SendPropertyChanged("DatumBeter");
					this.OnDatumBeterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="personen_meldingen", Storage="_personen", ThisKey="pid", OtherKey="pid", IsForeignKey=true)]
		public personen personen
		{
			get
			{
				return this._personen.Entity;
			}
			set
			{
				personen previousValue = this._personen.Entity;
				if (((previousValue != value) 
							|| (this._personen.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._personen.Entity = null;
						previousValue.meldingens.Remove(this);
					}
					this._personen.Entity = value;
					if ((value != null))
					{
						value.meldingens.Add(this);
						this._pid = value.pid;
					}
					else
					{
						this._pid = default(Nullable<int>);
					}
					this.SendPropertyChanged("personen");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.personen")]
	public partial class personen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pid;
		
		private string _voornaam;
		
		private string _achternaam;
		
		private string _afdeling;
		
		private EntitySet<meldingen> _meldingens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpidChanging(int value);
    partial void OnpidChanged();
    partial void OnvoornaamChanging(string value);
    partial void OnvoornaamChanged();
    partial void OnachternaamChanging(string value);
    partial void OnachternaamChanged();
    partial void OnafdelingChanging(string value);
    partial void OnafdelingChanged();
    #endregion
		
		public personen()
		{
			this._meldingens = new EntitySet<meldingen>(new Action<meldingen>(this.attach_meldingens), new Action<meldingen>(this.detach_meldingens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int pid
		{
			get
			{
				return this._pid;
			}
			set
			{
				if ((this._pid != value))
				{
					this.OnpidChanging(value);
					this.SendPropertyChanging();
					this._pid = value;
					this.SendPropertyChanged("pid");
					this.OnpidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_voornaam", DbType="VarChar(50)")]
		public string voornaam
		{
			get
			{
				return this._voornaam;
			}
			set
			{
				if ((this._voornaam != value))
				{
					this.OnvoornaamChanging(value);
					this.SendPropertyChanging();
					this._voornaam = value;
					this.SendPropertyChanged("voornaam");
					this.OnvoornaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_achternaam", DbType="VarChar(50)")]
		public string achternaam
		{
			get
			{
				return this._achternaam;
			}
			set
			{
				if ((this._achternaam != value))
				{
					this.OnachternaamChanging(value);
					this.SendPropertyChanging();
					this._achternaam = value;
					this.SendPropertyChanged("achternaam");
					this.OnachternaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_afdeling", DbType="VarChar(50)")]
		public string afdeling
		{
			get
			{
				return this._afdeling;
			}
			set
			{
				if ((this._afdeling != value))
				{
					this.OnafdelingChanging(value);
					this.SendPropertyChanging();
					this._afdeling = value;
					this.SendPropertyChanged("afdeling");
					this.OnafdelingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="personen_meldingen", Storage="_meldingens", ThisKey="pid", OtherKey="pid")]
		public EntitySet<meldingen> meldingens
		{
			get
			{
				return this._meldingens;
			}
			set
			{
				this._meldingens.Assign(value);
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
		
		private void attach_meldingens(meldingen entity)
		{
			this.SendPropertyChanging();
			entity.personen = this;
		}
		
		private void detach_meldingens(meldingen entity)
		{
			this.SendPropertyChanging();
			entity.personen = null;
		}
	}
}
#pragma warning restore 1591