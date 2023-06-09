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

namespace QuanLyDonHang
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Quanlybanhang")]
	public partial class LinqToSqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblHang(tblHang instance);
    partial void UpdatetblHang(tblHang instance);
    partial void DeletetblHang(tblHang instance);
    #endregion
		
		public LinqToSqlDataContext() : 
				base(global::QuanLyDonHang.Properties.Settings.Default.QLDonHangConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblHang> tblHangs
		{
			get
			{
				return this.GetTable<tblHang>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblHang")]
	public partial class tblHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHang;
		
		private string _TenHang;
		
		private string _MaChatLieu;
		
		private double _SoLuong;
		
		private double _DonGiaNhap;
		
		private double _DonGiaBan;
		
		private string _GhiChu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHangChanging(string value);
    partial void OnMaHangChanged();
    partial void OnTenHangChanging(string value);
    partial void OnTenHangChanged();
    partial void OnMaChatLieuChanging(string value);
    partial void OnMaChatLieuChanged();
    partial void OnSoLuongChanging(double value);
    partial void OnSoLuongChanged();
    partial void OnDonGiaNhapChanging(double value);
    partial void OnDonGiaNhapChanged();
    partial void OnDonGiaBanChanging(double value);
    partial void OnDonGiaBanChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    #endregion
		
		public tblHang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHang", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHang
		{
			get
			{
				return this._MaHang;
			}
			set
			{
				if ((this._MaHang != value))
				{
					this.OnMaHangChanging(value);
					this.SendPropertyChanging();
					this._MaHang = value;
					this.SendPropertyChanged("MaHang");
					this.OnMaHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHang", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenHang
		{
			get
			{
				return this._TenHang;
			}
			set
			{
				if ((this._TenHang != value))
				{
					this.OnTenHangChanging(value);
					this.SendPropertyChanging();
					this._TenHang = value;
					this.SendPropertyChanged("TenHang");
					this.OnTenHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaChatLieu", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaChatLieu
		{
			get
			{
				return this._MaChatLieu;
			}
			set
			{
				if ((this._MaChatLieu != value))
				{
					this.OnMaChatLieuChanging(value);
					this.SendPropertyChanging();
					this._MaChatLieu = value;
					this.SendPropertyChanged("MaChatLieu");
					this.OnMaChatLieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Float NOT NULL")]
		public double SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGiaNhap", DbType="Float NOT NULL")]
		public double DonGiaNhap
		{
			get
			{
				return this._DonGiaNhap;
			}
			set
			{
				if ((this._DonGiaNhap != value))
				{
					this.OnDonGiaNhapChanging(value);
					this.SendPropertyChanging();
					this._DonGiaNhap = value;
					this.SendPropertyChanged("DonGiaNhap");
					this.OnDonGiaNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGiaBan", DbType="Float NOT NULL")]
		public double DonGiaBan
		{
			get
			{
				return this._DonGiaBan;
			}
			set
			{
				if ((this._DonGiaBan != value))
				{
					this.OnDonGiaBanChanging(value);
					this.SendPropertyChanging();
					this._DonGiaBan = value;
					this.SendPropertyChanged("DonGiaBan");
					this.OnDonGiaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(200)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
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
