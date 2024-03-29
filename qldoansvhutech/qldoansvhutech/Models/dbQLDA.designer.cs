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

namespace qldoansvhutech.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyDoAn")]
	public partial class dbQLDADataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertDoan(Doan instance);
    partial void UpdateDoan(Doan instance);
    partial void DeleteDoan(Doan instance);
    partial void InsertGvhd(Gvhd instance);
    partial void UpdateGvhd(Gvhd instance);
    partial void DeleteGvhd(Gvhd instance);
    partial void InsertLoaiDA(LoaiDA instance);
    partial void UpdateLoaiDA(LoaiDA instance);
    partial void DeleteLoaiDA(LoaiDA instance);
    partial void InsertNhom(Nhom instance);
    partial void UpdateNhom(Nhom instance);
    partial void DeleteNhom(Nhom instance);
    partial void InsertRole(Role instance);
    partial void UpdateRole(Role instance);
    partial void DeleteRole(Role instance);
    partial void InsertPtda(Ptda instance);
    partial void UpdatePtda(Ptda instance);
    partial void DeletePtda(Ptda instance);
    partial void InsertSinhvien(Sinhvien instance);
    partial void UpdateSinhvien(Sinhvien instance);
    partial void DeleteSinhvien(Sinhvien instance);
    #endregion
		
		public dbQLDADataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QuanLyDoAnConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbQLDADataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQLDADataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQLDADataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQLDADataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Doan> Doans
		{
			get
			{
				return this.GetTable<Doan>();
			}
		}
		
		public System.Data.Linq.Table<Gvhd> Gvhds
		{
			get
			{
				return this.GetTable<Gvhd>();
			}
		}
		
		public System.Data.Linq.Table<LoaiDA> LoaiDAs
		{
			get
			{
				return this.GetTable<LoaiDA>();
			}
		}
		
		public System.Data.Linq.Table<Nhom> Nhoms
		{
			get
			{
				return this.GetTable<Nhom>();
			}
		}
		
		public System.Data.Linq.Table<Role> Roles
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		public System.Data.Linq.Table<Ptda> Ptdas
		{
			get
			{
				return this.GetTable<Ptda>();
			}
		}
		
		public System.Data.Linq.Table<Sinhvien> Sinhviens
		{
			get
			{
				return this.GetTable<Sinhvien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Taikhoan;
		
		private string _Matkhau;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTaikhoanChanging(string value);
    partial void OnTaikhoanChanged();
    partial void OnMatkhauChanging(string value);
    partial void OnMatkhauChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Taikhoan", DbType="NChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Taikhoan
		{
			get
			{
				return this._Taikhoan;
			}
			set
			{
				if ((this._Taikhoan != value))
				{
					this.OnTaikhoanChanging(value);
					this.SendPropertyChanging();
					this._Taikhoan = value;
					this.SendPropertyChanged("Taikhoan");
					this.OnTaikhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matkhau", DbType="NChar(16)")]
		public string Matkhau
		{
			get
			{
				return this._Matkhau;
			}
			set
			{
				if ((this._Matkhau != value))
				{
					this.OnMatkhauChanging(value);
					this.SendPropertyChanging();
					this._Matkhau = value;
					this.SendPropertyChanged("Matkhau");
					this.OnMatkhauChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Doan")]
	public partial class Doan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Mada;
		
		private string _Tenda;
		
		private string _Mota;
		
		private System.Nullable<int> _Id;
		
		private string _Magv;
		
		private string _Maloai;
		
		private EntityRef<Sinhvien> _Sinhvien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMadaChanging(int value);
    partial void OnMadaChanged();
    partial void OnTendaChanging(string value);
    partial void OnTendaChanged();
    partial void OnMotaChanging(string value);
    partial void OnMotaChanged();
    partial void OnIdChanging(System.Nullable<int> value);
    partial void OnIdChanged();
    partial void OnMagvChanging(string value);
    partial void OnMagvChanged();
    partial void OnMaloaiChanging(string value);
    partial void OnMaloaiChanged();
    #endregion
		
		public Doan()
		{
			this._Sinhvien = default(EntityRef<Sinhvien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mada", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Mada
		{
			get
			{
				return this._Mada;
			}
			set
			{
				if ((this._Mada != value))
				{
					this.OnMadaChanging(value);
					this.SendPropertyChanging();
					this._Mada = value;
					this.SendPropertyChanged("Mada");
					this.OnMadaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tenda", DbType="NVarChar(50)")]
		public string Tenda
		{
			get
			{
				return this._Tenda;
			}
			set
			{
				if ((this._Tenda != value))
				{
					this.OnTendaChanging(value);
					this.SendPropertyChanging();
					this._Tenda = value;
					this.SendPropertyChanged("Tenda");
					this.OnTendaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mota", DbType="NVarChar(MAX)")]
		public string Mota
		{
			get
			{
				return this._Mota;
			}
			set
			{
				if ((this._Mota != value))
				{
					this.OnMotaChanging(value);
					this.SendPropertyChanging();
					this._Mota = value;
					this.SendPropertyChanged("Mota");
					this.OnMotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int")]
		public System.Nullable<int> Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					if (this._Sinhvien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Magv", DbType="VarChar(5)")]
		public string Magv
		{
			get
			{
				return this._Magv;
			}
			set
			{
				if ((this._Magv != value))
				{
					this.OnMagvChanging(value);
					this.SendPropertyChanging();
					this._Magv = value;
					this.SendPropertyChanged("Magv");
					this.OnMagvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Maloai", DbType="VarChar(5)")]
		public string Maloai
		{
			get
			{
				return this._Maloai;
			}
			set
			{
				if ((this._Maloai != value))
				{
					this.OnMaloaiChanging(value);
					this.SendPropertyChanging();
					this._Maloai = value;
					this.SendPropertyChanged("Maloai");
					this.OnMaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sinhvien_Doan", Storage="_Sinhvien", ThisKey="Id", OtherKey="Id", IsForeignKey=true)]
		public Sinhvien Sinhvien
		{
			get
			{
				return this._Sinhvien.Entity;
			}
			set
			{
				Sinhvien previousValue = this._Sinhvien.Entity;
				if (((previousValue != value) 
							|| (this._Sinhvien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sinhvien.Entity = null;
						previousValue.Doans.Remove(this);
					}
					this._Sinhvien.Entity = value;
					if ((value != null))
					{
						value.Doans.Add(this);
						this._Id = value.Id;
					}
					else
					{
						this._Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Sinhvien");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Gvhd")]
	public partial class Gvhd : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Magv;
		
		private string _Matkhau;
		
		private string _Hotengv;
		
		private string _Email;
		
		private System.Nullable<int> _Role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnMagvChanging(string value);
    partial void OnMagvChanged();
    partial void OnMatkhauChanging(string value);
    partial void OnMatkhauChanged();
    partial void OnHotengvChanging(string value);
    partial void OnHotengvChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnRoleChanging(System.Nullable<int> value);
    partial void OnRoleChanged();
    #endregion
		
		public Gvhd()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Magv", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string Magv
		{
			get
			{
				return this._Magv;
			}
			set
			{
				if ((this._Magv != value))
				{
					this.OnMagvChanging(value);
					this.SendPropertyChanging();
					this._Magv = value;
					this.SendPropertyChanged("Magv");
					this.OnMagvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matkhau", DbType="VarChar(10)")]
		public string Matkhau
		{
			get
			{
				return this._Matkhau;
			}
			set
			{
				if ((this._Matkhau != value))
				{
					this.OnMatkhauChanging(value);
					this.SendPropertyChanging();
					this._Matkhau = value;
					this.SendPropertyChanged("Matkhau");
					this.OnMatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hotengv", DbType="NVarChar(150)")]
		public string Hotengv
		{
			get
			{
				return this._Hotengv;
			}
			set
			{
				if ((this._Hotengv != value))
				{
					this.OnHotengvChanging(value);
					this.SendPropertyChanging();
					this._Hotengv = value;
					this.SendPropertyChanged("Hotengv");
					this.OnHotengvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(150)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role", DbType="Int")]
		public System.Nullable<int> Role
		{
			get
			{
				return this._Role;
			}
			set
			{
				if ((this._Role != value))
				{
					this.OnRoleChanging(value);
					this.SendPropertyChanging();
					this._Role = value;
					this.SendPropertyChanged("Role");
					this.OnRoleChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiDA")]
	public partial class LoaiDA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_lda;
		
		private string _Maloai;
		
		private string _Tenloai;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_ldaChanging(int value);
    partial void OnId_ldaChanged();
    partial void OnMaloaiChanging(string value);
    partial void OnMaloaiChanged();
    partial void OnTenloaiChanging(string value);
    partial void OnTenloaiChanged();
    #endregion
		
		public LoaiDA()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_lda", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_lda
		{
			get
			{
				return this._Id_lda;
			}
			set
			{
				if ((this._Id_lda != value))
				{
					this.OnId_ldaChanging(value);
					this.SendPropertyChanging();
					this._Id_lda = value;
					this.SendPropertyChanged("Id_lda");
					this.OnId_ldaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Maloai", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string Maloai
		{
			get
			{
				return this._Maloai;
			}
			set
			{
				if ((this._Maloai != value))
				{
					this.OnMaloaiChanging(value);
					this.SendPropertyChanging();
					this._Maloai = value;
					this.SendPropertyChanged("Maloai");
					this.OnMaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tenloai", DbType="NVarChar(50)")]
		public string Tenloai
		{
			get
			{
				return this._Tenloai;
			}
			set
			{
				if ((this._Tenloai != value))
				{
					this.OnTenloaiChanging(value);
					this.SendPropertyChanging();
					this._Tenloai = value;
					this.SendPropertyChanged("Tenloai");
					this.OnTenloaiChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Nhom")]
	public partial class Nhom : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Manhom;
		
		private string _Tennhom;
		
		private System.Nullable<int> _Id;
		
		private EntityRef<Sinhvien> _Sinhvien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnManhomChanging(int value);
    partial void OnManhomChanged();
    partial void OnTennhomChanging(string value);
    partial void OnTennhomChanged();
    partial void OnIdChanging(System.Nullable<int> value);
    partial void OnIdChanged();
    #endregion
		
		public Nhom()
		{
			this._Sinhvien = default(EntityRef<Sinhvien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Manhom", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Manhom
		{
			get
			{
				return this._Manhom;
			}
			set
			{
				if ((this._Manhom != value))
				{
					this.OnManhomChanging(value);
					this.SendPropertyChanging();
					this._Manhom = value;
					this.SendPropertyChanged("Manhom");
					this.OnManhomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tennhom", DbType="NVarChar(50)")]
		public string Tennhom
		{
			get
			{
				return this._Tennhom;
			}
			set
			{
				if ((this._Tennhom != value))
				{
					this.OnTennhomChanging(value);
					this.SendPropertyChanging();
					this._Tennhom = value;
					this.SendPropertyChanged("Tennhom");
					this.OnTennhomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int")]
		public System.Nullable<int> Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					if (this._Sinhvien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sinhvien_Nhom", Storage="_Sinhvien", ThisKey="Id", OtherKey="Id", IsForeignKey=true)]
		public Sinhvien Sinhvien
		{
			get
			{
				return this._Sinhvien.Entity;
			}
			set
			{
				Sinhvien previousValue = this._Sinhvien.Entity;
				if (((previousValue != value) 
							|| (this._Sinhvien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sinhvien.Entity = null;
						previousValue.Nhoms.Remove(this);
					}
					this._Sinhvien.Entity = value;
					if ((value != null))
					{
						value.Nhoms.Add(this);
						this._Id = value.Id;
					}
					else
					{
						this._Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Sinhvien");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Role")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaRole;
		
		private string _TenRole;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaRoleChanging(int value);
    partial void OnMaRoleChanged();
    partial void OnTenRoleChanging(string value);
    partial void OnTenRoleChanged();
    #endregion
		
		public Role()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaRole", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaRole
		{
			get
			{
				return this._MaRole;
			}
			set
			{
				if ((this._MaRole != value))
				{
					this.OnMaRoleChanging(value);
					this.SendPropertyChanging();
					this._MaRole = value;
					this.SendPropertyChanged("MaRole");
					this.OnMaRoleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenRole", DbType="NVarChar(50)")]
		public string TenRole
		{
			get
			{
				return this._TenRole;
			}
			set
			{
				if ((this._TenRole != value))
				{
					this.OnTenRoleChanging(value);
					this.SendPropertyChanging();
					this._TenRole = value;
					this.SendPropertyChanged("TenRole");
					this.OnTenRoleChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ptda")]
	public partial class Ptda : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<int> _Magv;
		
		private int _Mada;
		
		private int _Mssv;
		
		private System.Nullable<int> _Diem;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMagvChanging(System.Nullable<int> value);
    partial void OnMagvChanged();
    partial void OnMadaChanging(int value);
    partial void OnMadaChanged();
    partial void OnMssvChanging(int value);
    partial void OnMssvChanged();
    partial void OnDiemChanging(System.Nullable<int> value);
    partial void OnDiemChanged();
    #endregion
		
		public Ptda()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Magv", DbType="Int")]
		public System.Nullable<int> Magv
		{
			get
			{
				return this._Magv;
			}
			set
			{
				if ((this._Magv != value))
				{
					this.OnMagvChanging(value);
					this.SendPropertyChanging();
					this._Magv = value;
					this.SendPropertyChanged("Magv");
					this.OnMagvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mada", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Mada
		{
			get
			{
				return this._Mada;
			}
			set
			{
				if ((this._Mada != value))
				{
					this.OnMadaChanging(value);
					this.SendPropertyChanging();
					this._Mada = value;
					this.SendPropertyChanged("Mada");
					this.OnMadaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mssv", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Mssv
		{
			get
			{
				return this._Mssv;
			}
			set
			{
				if ((this._Mssv != value))
				{
					this.OnMssvChanging(value);
					this.SendPropertyChanging();
					this._Mssv = value;
					this.SendPropertyChanged("Mssv");
					this.OnMssvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diem", DbType="Int")]
		public System.Nullable<int> Diem
		{
			get
			{
				return this._Diem;
			}
			set
			{
				if ((this._Diem != value))
				{
					this.OnDiemChanging(value);
					this.SendPropertyChanging();
					this._Diem = value;
					this.SendPropertyChanged("Diem");
					this.OnDiemChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sinhvien")]
	public partial class Sinhvien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Hoten;
		
		private string _Matkhau;
		
		private string _Email;
		
		private System.Nullable<bool> _Gioitinh;
		
		private string _Mssv;
		
		private string _Sdt;
		
		private string _Hinh;
		
		private System.Nullable<int> _Role;
		
		private string _Magv;
		
		private System.Data.Linq.Binary _Maloai;
		
		private EntitySet<Doan> _Doans;
		
		private EntitySet<Nhom> _Nhoms;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnHotenChanging(string value);
    partial void OnHotenChanged();
    partial void OnMatkhauChanging(string value);
    partial void OnMatkhauChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnGioitinhChanging(System.Nullable<bool> value);
    partial void OnGioitinhChanged();
    partial void OnMssvChanging(string value);
    partial void OnMssvChanged();
    partial void OnSdtChanging(string value);
    partial void OnSdtChanged();
    partial void OnHinhChanging(string value);
    partial void OnHinhChanged();
    partial void OnRoleChanging(System.Nullable<int> value);
    partial void OnRoleChanged();
    partial void OnMagvChanging(string value);
    partial void OnMagvChanged();
    partial void OnMaloaiChanging(System.Data.Linq.Binary value);
    partial void OnMaloaiChanged();
    #endregion
		
		public Sinhvien()
		{
			this._Doans = new EntitySet<Doan>(new Action<Doan>(this.attach_Doans), new Action<Doan>(this.detach_Doans));
			this._Nhoms = new EntitySet<Nhom>(new Action<Nhom>(this.attach_Nhoms), new Action<Nhom>(this.detach_Nhoms));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hoten", DbType="NVarChar(50)")]
		public string Hoten
		{
			get
			{
				return this._Hoten;
			}
			set
			{
				if ((this._Hoten != value))
				{
					this.OnHotenChanging(value);
					this.SendPropertyChanging();
					this._Hoten = value;
					this.SendPropertyChanged("Hoten");
					this.OnHotenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matkhau", DbType="NVarChar(50)")]
		public string Matkhau
		{
			get
			{
				return this._Matkhau;
			}
			set
			{
				if ((this._Matkhau != value))
				{
					this.OnMatkhauChanging(value);
					this.SendPropertyChanging();
					this._Matkhau = value;
					this.SendPropertyChanged("Matkhau");
					this.OnMatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gioitinh", DbType="Bit")]
		public System.Nullable<bool> Gioitinh
		{
			get
			{
				return this._Gioitinh;
			}
			set
			{
				if ((this._Gioitinh != value))
				{
					this.OnGioitinhChanging(value);
					this.SendPropertyChanging();
					this._Gioitinh = value;
					this.SendPropertyChanged("Gioitinh");
					this.OnGioitinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mssv", DbType="NChar(50)")]
		public string Mssv
		{
			get
			{
				return this._Mssv;
			}
			set
			{
				if ((this._Mssv != value))
				{
					this.OnMssvChanging(value);
					this.SendPropertyChanging();
					this._Mssv = value;
					this.SendPropertyChanged("Mssv");
					this.OnMssvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sdt", DbType="VarChar(20)")]
		public string Sdt
		{
			get
			{
				return this._Sdt;
			}
			set
			{
				if ((this._Sdt != value))
				{
					this.OnSdtChanging(value);
					this.SendPropertyChanging();
					this._Sdt = value;
					this.SendPropertyChanged("Sdt");
					this.OnSdtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hinh", DbType="NVarChar(50)")]
		public string Hinh
		{
			get
			{
				return this._Hinh;
			}
			set
			{
				if ((this._Hinh != value))
				{
					this.OnHinhChanging(value);
					this.SendPropertyChanging();
					this._Hinh = value;
					this.SendPropertyChanged("Hinh");
					this.OnHinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role", DbType="Int")]
		public System.Nullable<int> Role
		{
			get
			{
				return this._Role;
			}
			set
			{
				if ((this._Role != value))
				{
					this.OnRoleChanging(value);
					this.SendPropertyChanging();
					this._Role = value;
					this.SendPropertyChanged("Role");
					this.OnRoleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Magv", DbType="VarChar(5)")]
		public string Magv
		{
			get
			{
				return this._Magv;
			}
			set
			{
				if ((this._Magv != value))
				{
					this.OnMagvChanging(value);
					this.SendPropertyChanging();
					this._Magv = value;
					this.SendPropertyChanged("Magv");
					this.OnMagvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Maloai", DbType="VarBinary(5)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Maloai
		{
			get
			{
				return this._Maloai;
			}
			set
			{
				if ((this._Maloai != value))
				{
					this.OnMaloaiChanging(value);
					this.SendPropertyChanging();
					this._Maloai = value;
					this.SendPropertyChanged("Maloai");
					this.OnMaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sinhvien_Doan", Storage="_Doans", ThisKey="Id", OtherKey="Id")]
		public EntitySet<Doan> Doans
		{
			get
			{
				return this._Doans;
			}
			set
			{
				this._Doans.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sinhvien_Nhom", Storage="_Nhoms", ThisKey="Id", OtherKey="Id")]
		public EntitySet<Nhom> Nhoms
		{
			get
			{
				return this._Nhoms;
			}
			set
			{
				this._Nhoms.Assign(value);
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
		
		private void attach_Doans(Doan entity)
		{
			this.SendPropertyChanging();
			entity.Sinhvien = this;
		}
		
		private void detach_Doans(Doan entity)
		{
			this.SendPropertyChanging();
			entity.Sinhvien = null;
		}
		
		private void attach_Nhoms(Nhom entity)
		{
			this.SendPropertyChanging();
			entity.Sinhvien = this;
		}
		
		private void detach_Nhoms(Nhom entity)
		{
			this.SendPropertyChanging();
			entity.Sinhvien = null;
		}
	}
}
#pragma warning restore 1591
