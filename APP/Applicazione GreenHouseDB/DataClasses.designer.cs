﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Applicazione_GreenHouseDB
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Prova")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definizioni metodo Extensibility
    partial void OnCreated();
    partial void InsertRICERCATORI(RICERCATORI instance);
    partial void UpdateRICERCATORI(RICERCATORI instance);
    partial void DeleteRICERCATORI(RICERCATORI instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::Applicazione_GreenHouseDB.Properties.Settings.Default.ProvaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<RICERCATORI> RICERCATORI
		{
			get
			{
				return this.GetTable<RICERCATORI>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RICERCATORI")]
	public partial class RICERCATORI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _IDRicercatore;
		
		private string _CF;
		
		private string _Nome;
		
		private string _Cognome;
		
		private string _Provincia;
		
		private string _CAP;
		
		private string _Via;
		
		private string _NumeroCivico;
		
		private string _Telefono;
		
		private string _Mail;
		
		private string _Competenza;
		
		private string _Dipartimento;
		
		private string _NomeUniversità;
		
    #region Definizioni metodo Extensibility
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDRicercatoreChanging(decimal value);
    partial void OnIDRicercatoreChanged();
    partial void OnCFChanging(string value);
    partial void OnCFChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnCognomeChanging(string value);
    partial void OnCognomeChanged();
    partial void OnProvinciaChanging(string value);
    partial void OnProvinciaChanged();
    partial void OnCAPChanging(string value);
    partial void OnCAPChanged();
    partial void OnViaChanging(string value);
    partial void OnViaChanged();
    partial void OnNumeroCivicoChanging(string value);
    partial void OnNumeroCivicoChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    partial void OnMailChanging(string value);
    partial void OnMailChanged();
    partial void OnCompetenzaChanging(string value);
    partial void OnCompetenzaChanged();
    partial void OnDipartimentoChanging(string value);
    partial void OnDipartimentoChanged();
    partial void OnNomeUniversitàChanging(string value);
    partial void OnNomeUniversitàChanged();
    #endregion
		
		public RICERCATORI()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDRicercatore", DbType="Decimal(1,0) NOT NULL", IsPrimaryKey=true)]
		public decimal IDRicercatore
		{
			get
			{
				return this._IDRicercatore;
			}
			set
			{
				if ((this._IDRicercatore != value))
				{
					this.OnIDRicercatoreChanging(value);
					this.SendPropertyChanging();
					this._IDRicercatore = value;
					this.SendPropertyChanged("IDRicercatore");
					this.OnIDRicercatoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CF", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string CF
		{
			get
			{
				return this._CF;
			}
			set
			{
				if ((this._CF != value))
				{
					this.OnCFChanging(value);
					this.SendPropertyChanging();
					this._CF = value;
					this.SendPropertyChanged("CF");
					this.OnCFChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cognome", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Cognome
		{
			get
			{
				return this._Cognome;
			}
			set
			{
				if ((this._Cognome != value))
				{
					this.OnCognomeChanging(value);
					this.SendPropertyChanging();
					this._Cognome = value;
					this.SendPropertyChanged("Cognome");
					this.OnCognomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Provincia", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Provincia
		{
			get
			{
				return this._Provincia;
			}
			set
			{
				if ((this._Provincia != value))
				{
					this.OnProvinciaChanging(value);
					this.SendPropertyChanging();
					this._Provincia = value;
					this.SendPropertyChanged("Provincia");
					this.OnProvinciaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CAP", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CAP
		{
			get
			{
				return this._CAP;
			}
			set
			{
				if ((this._CAP != value))
				{
					this.OnCAPChanging(value);
					this.SendPropertyChanging();
					this._CAP = value;
					this.SendPropertyChanged("CAP");
					this.OnCAPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Via", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Via
		{
			get
			{
				return this._Via;
			}
			set
			{
				if ((this._Via != value))
				{
					this.OnViaChanging(value);
					this.SendPropertyChanging();
					this._Via = value;
					this.SendPropertyChanged("Via");
					this.OnViaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumeroCivico", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string NumeroCivico
		{
			get
			{
				return this._NumeroCivico;
			}
			set
			{
				if ((this._NumeroCivico != value))
				{
					this.OnNumeroCivicoChanging(value);
					this.SendPropertyChanging();
					this._NumeroCivico = value;
					this.SendPropertyChanged("NumeroCivico");
					this.OnNumeroCivicoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mail", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Mail
		{
			get
			{
				return this._Mail;
			}
			set
			{
				if ((this._Mail != value))
				{
					this.OnMailChanging(value);
					this.SendPropertyChanging();
					this._Mail = value;
					this.SendPropertyChanged("Mail");
					this.OnMailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Competenza", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Competenza
		{
			get
			{
				return this._Competenza;
			}
			set
			{
				if ((this._Competenza != value))
				{
					this.OnCompetenzaChanging(value);
					this.SendPropertyChanging();
					this._Competenza = value;
					this.SendPropertyChanged("Competenza");
					this.OnCompetenzaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dipartimento", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Dipartimento
		{
			get
			{
				return this._Dipartimento;
			}
			set
			{
				if ((this._Dipartimento != value))
				{
					this.OnDipartimentoChanging(value);
					this.SendPropertyChanging();
					this._Dipartimento = value;
					this.SendPropertyChanged("Dipartimento");
					this.OnDipartimentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NomeUniversità", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NomeUniversità
		{
			get
			{
				return this._NomeUniversità;
			}
			set
			{
				if ((this._NomeUniversità != value))
				{
					this.OnNomeUniversitàChanging(value);
					this.SendPropertyChanging();
					this._NomeUniversità = value;
					this.SendPropertyChanged("NomeUniversità");
					this.OnNomeUniversitàChanged();
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
