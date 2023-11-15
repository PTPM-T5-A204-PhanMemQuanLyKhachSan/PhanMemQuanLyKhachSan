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

namespace BLL_DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLKhachSan")]
	public partial class QLKhachSanDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertQL_NguoiDung(QL_NguoiDung instance);
    partial void UpdateQL_NguoiDung(QL_NguoiDung instance);
    partial void DeleteQL_NguoiDung(QL_NguoiDung instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    partial void InsertPhong(Phong instance);
    partial void UpdatePhong(Phong instance);
    partial void DeletePhong(Phong instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertChiTietDatPhong(ChiTietDatPhong instance);
    partial void UpdateChiTietDatPhong(ChiTietDatPhong instance);
    partial void DeleteChiTietDatPhong(ChiTietDatPhong instance);
    partial void InsertDatPhong(DatPhong instance);
    partial void UpdateDatPhong(DatPhong instance);
    partial void DeleteDatPhong(DatPhong instance);
    #endregion
		
		public QLKhachSanDataContext() : 
				base(global::BLL_DAL.Properties.Settings.Default.QLKhachSanConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLKhachSanDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLKhachSanDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLKhachSanDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLKhachSanDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<QL_NguoiDung> QL_NguoiDungs
		{
			get
			{
				return this.GetTable<QL_NguoiDung>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
		
		public System.Data.Linq.Table<Phong> Phongs
		{
			get
			{
				return this.GetTable<Phong>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<ChiTietDatPhong> ChiTietDatPhongs
		{
			get
			{
				return this.GetTable<ChiTietDatPhong>();
			}
		}
		
		public System.Data.Linq.Table<DatPhong> DatPhongs
		{
			get
			{
				return this.GetTable<DatPhong>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QL_NguoiDung")]
	public partial class QL_NguoiDung : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TenDangNhap;
		
		private string _MatKhau;
		
		private System.Nullable<bool> _HoatDong;
		
		private System.Nullable<int> _MaNV;
		
		private EntityRef<NhanVien> _NhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTenDangNhapChanging(string value);
    partial void OnTenDangNhapChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnHoatDongChanging(System.Nullable<bool> value);
    partial void OnHoatDongChanged();
    partial void OnMaNVChanging(System.Nullable<int> value);
    partial void OnMaNVChanged();
    #endregion
		
		public QL_NguoiDung()
		{
			this._NhanVien = default(EntityRef<NhanVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDangNhap", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TenDangNhap
		{
			get
			{
				return this._TenDangNhap;
			}
			set
			{
				if ((this._TenDangNhap != value))
				{
					this.OnTenDangNhapChanging(value);
					this.SendPropertyChanging();
					this._TenDangNhap = value;
					this.SendPropertyChanged("TenDangNhap");
					this.OnTenDangNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(100)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoatDong", DbType="Bit")]
		public System.Nullable<bool> HoatDong
		{
			get
			{
				return this._HoatDong;
			}
			set
			{
				if ((this._HoatDong != value))
				{
					this.OnHoatDongChanging(value);
					this.SendPropertyChanging();
					this._HoatDong = value;
					this.SendPropertyChanged("HoatDong");
					this.OnHoatDongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="Int")]
		public System.Nullable<int> MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_QL_NguoiDung", Storage="_NhanVien", ThisKey="MaNV", OtherKey="MaNV", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.QL_NguoiDungs.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.QL_NguoiDungs.Add(this);
						this._MaNV = value.MaNV;
					}
					else
					{
						this._MaNV = default(Nullable<int>);
					}
					this.SendPropertyChanged("NhanVien");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNV;
		
		private string _HoTenNV;
		
		private string _ChucVu;
		
		private System.Nullable<int> _Luong;
		
		private string _Phai;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private string _QueQuan;
		
		private string _CCCD;
		
		private string _Hinh;
		
		private string _DienThoai;
		
		private string _TinhTrang;
		
		private System.Nullable<System.DateTime> _NgayVaoLam;
		
		private EntitySet<QL_NguoiDung> _QL_NguoiDungs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNVChanging(int value);
    partial void OnMaNVChanged();
    partial void OnHoTenNVChanging(string value);
    partial void OnHoTenNVChanged();
    partial void OnChucVuChanging(string value);
    partial void OnChucVuChanged();
    partial void OnLuongChanging(System.Nullable<int> value);
    partial void OnLuongChanged();
    partial void OnPhaiChanging(string value);
    partial void OnPhaiChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnQueQuanChanging(string value);
    partial void OnQueQuanChanged();
    partial void OnCCCDChanging(string value);
    partial void OnCCCDChanged();
    partial void OnHinhChanging(string value);
    partial void OnHinhChanged();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    partial void OnTinhTrangChanging(string value);
    partial void OnTinhTrangChanged();
    partial void OnNgayVaoLamChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayVaoLamChanged();
    #endregion
		
		public NhanVien()
		{
			this._QL_NguoiDungs = new EntitySet<QL_NguoiDung>(new Action<QL_NguoiDung>(this.attach_QL_NguoiDungs), new Action<QL_NguoiDung>(this.detach_QL_NguoiDungs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTenNV", DbType="NVarChar(50)")]
		public string HoTenNV
		{
			get
			{
				return this._HoTenNV;
			}
			set
			{
				if ((this._HoTenNV != value))
				{
					this.OnHoTenNVChanging(value);
					this.SendPropertyChanging();
					this._HoTenNV = value;
					this.SendPropertyChanged("HoTenNV");
					this.OnHoTenNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChucVu", DbType="NVarChar(30)")]
		public string ChucVu
		{
			get
			{
				return this._ChucVu;
			}
			set
			{
				if ((this._ChucVu != value))
				{
					this.OnChucVuChanging(value);
					this.SendPropertyChanging();
					this._ChucVu = value;
					this.SendPropertyChanged("ChucVu");
					this.OnChucVuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Luong", DbType="Int")]
		public System.Nullable<int> Luong
		{
			get
			{
				return this._Luong;
			}
			set
			{
				if ((this._Luong != value))
				{
					this.OnLuongChanging(value);
					this.SendPropertyChanging();
					this._Luong = value;
					this.SendPropertyChanged("Luong");
					this.OnLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phai", DbType="NVarChar(50)")]
		public string Phai
		{
			get
			{
				return this._Phai;
			}
			set
			{
				if ((this._Phai != value))
				{
					this.OnPhaiChanging(value);
					this.SendPropertyChanging();
					this._Phai = value;
					this.SendPropertyChanged("Phai");
					this.OnPhaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QueQuan", DbType="NVarChar(50)")]
		public string QueQuan
		{
			get
			{
				return this._QueQuan;
			}
			set
			{
				if ((this._QueQuan != value))
				{
					this.OnQueQuanChanging(value);
					this.SendPropertyChanging();
					this._QueQuan = value;
					this.SendPropertyChanged("QueQuan");
					this.OnQueQuanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CCCD", DbType="VarChar(13)")]
		public string CCCD
		{
			get
			{
				return this._CCCD;
			}
			set
			{
				if ((this._CCCD != value))
				{
					this.OnCCCDChanging(value);
					this.SendPropertyChanging();
					this._CCCD = value;
					this.SendPropertyChanged("CCCD");
					this.OnCCCDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hinh", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="VarChar(11)")]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="NVarChar(20)")]
		public string TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayVaoLam", DbType="Date")]
		public System.Nullable<System.DateTime> NgayVaoLam
		{
			get
			{
				return this._NgayVaoLam;
			}
			set
			{
				if ((this._NgayVaoLam != value))
				{
					this.OnNgayVaoLamChanging(value);
					this.SendPropertyChanging();
					this._NgayVaoLam = value;
					this.SendPropertyChanged("NgayVaoLam");
					this.OnNgayVaoLamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_QL_NguoiDung", Storage="_QL_NguoiDungs", ThisKey="MaNV", OtherKey="MaNV")]
		public EntitySet<QL_NguoiDung> QL_NguoiDungs
		{
			get
			{
				return this._QL_NguoiDungs;
			}
			set
			{
				this._QL_NguoiDungs.Assign(value);
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
		
		private void attach_QL_NguoiDungs(QL_NguoiDung entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_QL_NguoiDungs(QL_NguoiDung entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Phong")]
	public partial class Phong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaPhong;
		
		private string _TenPhong;
		
		private string _LoaiPhong;
		
		private System.Nullable<int> _GiaPhong;
		
		private string _TrangThai;
		
		private EntitySet<ChiTietDatPhong> _ChiTietDatPhongs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaPhongChanging(int value);
    partial void OnMaPhongChanged();
    partial void OnTenPhongChanging(string value);
    partial void OnTenPhongChanged();
    partial void OnLoaiPhongChanging(string value);
    partial void OnLoaiPhongChanged();
    partial void OnGiaPhongChanging(System.Nullable<int> value);
    partial void OnGiaPhongChanged();
    partial void OnTrangThaiChanging(string value);
    partial void OnTrangThaiChanged();
    #endregion
		
		public Phong()
		{
			this._ChiTietDatPhongs = new EntitySet<ChiTietDatPhong>(new Action<ChiTietDatPhong>(this.attach_ChiTietDatPhongs), new Action<ChiTietDatPhong>(this.detach_ChiTietDatPhongs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhong", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaPhong
		{
			get
			{
				return this._MaPhong;
			}
			set
			{
				if ((this._MaPhong != value))
				{
					this.OnMaPhongChanging(value);
					this.SendPropertyChanging();
					this._MaPhong = value;
					this.SendPropertyChanged("MaPhong");
					this.OnMaPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenPhong", DbType="NVarChar(20)")]
		public string TenPhong
		{
			get
			{
				return this._TenPhong;
			}
			set
			{
				if ((this._TenPhong != value))
				{
					this.OnTenPhongChanging(value);
					this.SendPropertyChanging();
					this._TenPhong = value;
					this.SendPropertyChanged("TenPhong");
					this.OnTenPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiPhong", DbType="NVarChar(20)")]
		public string LoaiPhong
		{
			get
			{
				return this._LoaiPhong;
			}
			set
			{
				if ((this._LoaiPhong != value))
				{
					this.OnLoaiPhongChanging(value);
					this.SendPropertyChanging();
					this._LoaiPhong = value;
					this.SendPropertyChanged("LoaiPhong");
					this.OnLoaiPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaPhong", DbType="Int")]
		public System.Nullable<int> GiaPhong
		{
			get
			{
				return this._GiaPhong;
			}
			set
			{
				if ((this._GiaPhong != value))
				{
					this.OnGiaPhongChanging(value);
					this.SendPropertyChanging();
					this._GiaPhong = value;
					this.SendPropertyChanged("GiaPhong");
					this.OnGiaPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrangThai", DbType="NVarChar(15)")]
		public string TrangThai
		{
			get
			{
				return this._TrangThai;
			}
			set
			{
				if ((this._TrangThai != value))
				{
					this.OnTrangThaiChanging(value);
					this.SendPropertyChanging();
					this._TrangThai = value;
					this.SendPropertyChanged("TrangThai");
					this.OnTrangThaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_ChiTietDatPhong", Storage="_ChiTietDatPhongs", ThisKey="MaPhong", OtherKey="MaPhong")]
		public EntitySet<ChiTietDatPhong> ChiTietDatPhongs
		{
			get
			{
				return this._ChiTietDatPhongs;
			}
			set
			{
				this._ChiTietDatPhongs.Assign(value);
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
		
		private void attach_ChiTietDatPhongs(ChiTietDatPhong entity)
		{
			this.SendPropertyChanging();
			entity.Phong = this;
		}
		
		private void detach_ChiTietDatPhongs(ChiTietDatPhong entity)
		{
			this.SendPropertyChanging();
			entity.Phong = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _HoTenKH;
		
		private string _CCCD;
		
		private string _Email;
		
		private string _Phone;
		
		private EntitySet<DatPhong> _DatPhongs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnHoTenKHChanging(string value);
    partial void OnHoTenKHChanged();
    partial void OnCCCDChanging(string value);
    partial void OnCCCDChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    #endregion
		
		public KhachHang()
		{
			this._DatPhongs = new EntitySet<DatPhong>(new Action<DatPhong>(this.attach_DatPhongs), new Action<DatPhong>(this.detach_DatPhongs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTenKH", DbType="NVarChar(50)")]
		public string HoTenKH
		{
			get
			{
				return this._HoTenKH;
			}
			set
			{
				if ((this._HoTenKH != value))
				{
					this.OnHoTenKHChanging(value);
					this.SendPropertyChanging();
					this._HoTenKH = value;
					this.SendPropertyChanged("HoTenKH");
					this.OnHoTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CCCD", DbType="VarChar(12)")]
		public string CCCD
		{
			get
			{
				return this._CCCD;
			}
			set
			{
				if ((this._CCCD != value))
				{
					this.OnCCCDChanging(value);
					this.SendPropertyChanging();
					this._CCCD = value;
					this.SendPropertyChanged("CCCD");
					this.OnCCCDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(30)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(10)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_DatPhong", Storage="_DatPhongs", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<DatPhong> DatPhongs
		{
			get
			{
				return this._DatPhongs;
			}
			set
			{
				this._DatPhongs.Assign(value);
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
		
		private void attach_DatPhongs(DatPhong entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = this;
		}
		
		private void detach_DatPhongs(DatPhong entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietDatPhong")]
	public partial class ChiTietDatPhong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDP;
		
		private int _MaPhong;
		
		private EntityRef<Phong> _Phong;
		
		private EntityRef<DatPhong> _DatPhong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDPChanging(int value);
    partial void OnMaDPChanged();
    partial void OnMaPhongChanging(int value);
    partial void OnMaPhongChanged();
    #endregion
		
		public ChiTietDatPhong()
		{
			this._Phong = default(EntityRef<Phong>);
			this._DatPhong = default(EntityRef<DatPhong>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDP", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDP
		{
			get
			{
				return this._MaDP;
			}
			set
			{
				if ((this._MaDP != value))
				{
					if (this._DatPhong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDPChanging(value);
					this.SendPropertyChanging();
					this._MaDP = value;
					this.SendPropertyChanged("MaDP");
					this.OnMaDPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhong", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaPhong
		{
			get
			{
				return this._MaPhong;
			}
			set
			{
				if ((this._MaPhong != value))
				{
					if (this._Phong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaPhongChanging(value);
					this.SendPropertyChanging();
					this._MaPhong = value;
					this.SendPropertyChanged("MaPhong");
					this.OnMaPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_ChiTietDatPhong", Storage="_Phong", ThisKey="MaPhong", OtherKey="MaPhong", IsForeignKey=true)]
		public Phong Phong
		{
			get
			{
				return this._Phong.Entity;
			}
			set
			{
				Phong previousValue = this._Phong.Entity;
				if (((previousValue != value) 
							|| (this._Phong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Phong.Entity = null;
						previousValue.ChiTietDatPhongs.Remove(this);
					}
					this._Phong.Entity = value;
					if ((value != null))
					{
						value.ChiTietDatPhongs.Add(this);
						this._MaPhong = value.MaPhong;
					}
					else
					{
						this._MaPhong = default(int);
					}
					this.SendPropertyChanged("Phong");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DatPhong_ChiTietDatPhong", Storage="_DatPhong", ThisKey="MaDP", OtherKey="MaDP", IsForeignKey=true)]
		public DatPhong DatPhong
		{
			get
			{
				return this._DatPhong.Entity;
			}
			set
			{
				DatPhong previousValue = this._DatPhong.Entity;
				if (((previousValue != value) 
							|| (this._DatPhong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DatPhong.Entity = null;
						previousValue.ChiTietDatPhongs.Remove(this);
					}
					this._DatPhong.Entity = value;
					if ((value != null))
					{
						value.ChiTietDatPhongs.Add(this);
						this._MaDP = value.MaDP;
					}
					else
					{
						this._MaDP = default(int);
					}
					this.SendPropertyChanged("DatPhong");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DatPhong")]
	public partial class DatPhong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDP;
		
		private System.Nullable<int> _MaKH;
		
		private System.Nullable<System.DateTime> _CheckIn;
		
		private System.Nullable<System.DateTime> _CheckOut;
		
		private string _TrangThai;
		
		private EntitySet<ChiTietDatPhong> _ChiTietDatPhongs;
		
		private EntityRef<KhachHang> _KhachHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDPChanging(int value);
    partial void OnMaDPChanged();
    partial void OnMaKHChanging(System.Nullable<int> value);
    partial void OnMaKHChanged();
    partial void OnCheckInChanging(System.Nullable<System.DateTime> value);
    partial void OnCheckInChanged();
    partial void OnCheckOutChanging(System.Nullable<System.DateTime> value);
    partial void OnCheckOutChanged();
    partial void OnTrangThaiChanging(string value);
    partial void OnTrangThaiChanged();
    #endregion
		
		public DatPhong()
		{
			this._ChiTietDatPhongs = new EntitySet<ChiTietDatPhong>(new Action<ChiTietDatPhong>(this.attach_ChiTietDatPhongs), new Action<ChiTietDatPhong>(this.detach_ChiTietDatPhongs));
			this._KhachHang = default(EntityRef<KhachHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDP
		{
			get
			{
				return this._MaDP;
			}
			set
			{
				if ((this._MaDP != value))
				{
					this.OnMaDPChanging(value);
					this.SendPropertyChanging();
					this._MaDP = value;
					this.SendPropertyChanged("MaDP");
					this.OnMaDPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int")]
		public System.Nullable<int> MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CheckIn", DbType="Date")]
		public System.Nullable<System.DateTime> CheckIn
		{
			get
			{
				return this._CheckIn;
			}
			set
			{
				if ((this._CheckIn != value))
				{
					this.OnCheckInChanging(value);
					this.SendPropertyChanging();
					this._CheckIn = value;
					this.SendPropertyChanged("CheckIn");
					this.OnCheckInChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CheckOut", DbType="Date")]
		public System.Nullable<System.DateTime> CheckOut
		{
			get
			{
				return this._CheckOut;
			}
			set
			{
				if ((this._CheckOut != value))
				{
					this.OnCheckOutChanging(value);
					this.SendPropertyChanging();
					this._CheckOut = value;
					this.SendPropertyChanged("CheckOut");
					this.OnCheckOutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrangThai", DbType="NVarChar(15)")]
		public string TrangThai
		{
			get
			{
				return this._TrangThai;
			}
			set
			{
				if ((this._TrangThai != value))
				{
					this.OnTrangThaiChanging(value);
					this.SendPropertyChanging();
					this._TrangThai = value;
					this.SendPropertyChanged("TrangThai");
					this.OnTrangThaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DatPhong_ChiTietDatPhong", Storage="_ChiTietDatPhongs", ThisKey="MaDP", OtherKey="MaDP")]
		public EntitySet<ChiTietDatPhong> ChiTietDatPhongs
		{
			get
			{
				return this._ChiTietDatPhongs;
			}
			set
			{
				this._ChiTietDatPhongs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_DatPhong", Storage="_KhachHang", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public KhachHang KhachHang
		{
			get
			{
				return this._KhachHang.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang.Entity = null;
						previousValue.DatPhongs.Remove(this);
					}
					this._KhachHang.Entity = value;
					if ((value != null))
					{
						value.DatPhongs.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(Nullable<int>);
					}
					this.SendPropertyChanged("KhachHang");
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
		
		private void attach_ChiTietDatPhongs(ChiTietDatPhong entity)
		{
			this.SendPropertyChanging();
			entity.DatPhong = this;
		}
		
		private void detach_ChiTietDatPhongs(ChiTietDatPhong entity)
		{
			this.SendPropertyChanging();
			entity.DatPhong = null;
		}
	}
}
#pragma warning restore 1591
