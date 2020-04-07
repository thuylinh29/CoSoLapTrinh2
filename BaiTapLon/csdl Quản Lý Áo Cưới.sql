create database QuanLyAnhVienAoCuoi
on
(	name=Qly_Aocuoi_data,
	filename='C:\gitexample\QuanLyAoCuoi\qly_aocuoi.mdf',
	size=5,
	maxsize=10,
	filegrowth=2
)
log on
(	name=Qly_Aocuoi_log,
	filename='C:\gitexample\QuanLyAoCuoi\qly_aocuoi.ldf',
	size=5mb,
	filegrowth=2mb
)

create table ChuyenMon
(	MaCM varchar(10) primary key not null,
	TenCM nvarchar(50)
)

create table NhaCungCap
(	MaNCC varchar(10) primary key not null,
	TenNCC nvarchar(50),
	DiaChi nvarchar(50),
	DienThoai int
)

create table Mau
(	MaMau varchar(10) primary key not null,
	TenMau nvarchar(50)
)

create table NoiSanXuat
(	MaNoiSX varchar(10) primary key not null,
	TenNoiSX nvarchar(50)
)

create table SanPham
(	MaSP varchar(10) primary key not null,
	TenSP nvarchar(50),
	AnhMinhHoa nvarchar(50),
	MaMau varchar(10) not null,
	MaNoiSX varchar(10) not null,
	SoLuong int,
	DonGiaNhap int,
	DonGiaThue int,
	MaLoaiSP varchar(10) not null
)

create table LoaiSP
(	MaLoaiSP varchar(10) primary key not null,
	TenLoaiSP nvarchar(50)
)

create table HoaDonNhap
(	MaHDN varchar(10) primary key not null,
	NgayNhap datetime,
	MaNV varchar(10) not null,
	MaNCC varchar(10) not null,
	TongTien int
)

create table ChiTietHDN
(	MaHDN varchar(10) not null,
	MaSP varchar(10) not null,
	SoLuong int,
	DonGia int,
	ThanhTien int,
	constraint PK_ChiTietHDN primary key (MaHDN, MaSP)
)

create table HopDong
(	MaHD varchar(10) primary key not null,
	MaKhach varchar(10)  not null,
	MaNV varchar(10) not null,
	NgayHD datetime,
	KhuyenMai int,
	TamUng int
)

create table ChiTietHDong
(	MaHD varchar(10) not null,
	MaSP varchar(10) not null,
	SoLuong int,
	NgayThue date,
	ChuaTra int,
	constraint PK_ChiTietHDong primary key (MaHD,MaSP)
)

create table ThanhToanHD
(	MaThanhToan varchar(10) primary key not null,
	MaHD varchar(10) not null,
	MaNV varchar(10) not null,
	NgayThanhToan date,
	TongTien int,
	SoTienThanhToan int
)
drop table ThanhToanHD

create table ChiTietThanhToan
(	MaThanhToan varchar(10) not null,
	MaSP varchar(10) not null,
	NgayTra date,
	ThanhTien int,
	constraint PK_ChiTietThanhToan primary key (MaThanhToan, MaSP)
)

create table NhanVien
(	MaNV varchar(10) primary key not null,
	TenNV nvarchar(50),
	DiaChi nvarchar(50),
	DienThoaiCD int,
	DienThoaiDD int,
	MaCM varchar(10) not null
)

create table KhachHang
(	MaKhach varchar(10) primary key not null,
	TenKhach nvarchar(50),
	SoCMTND int,
	DiaChi nvarchar(50),
	DienThoaiKhach int
)

insert into SanPham(MaSP, TenSp, AnhMinhHoa, MaMau, MaNoiSX, SoLuong,DonGiaNhap, DonGiaThue, MaLoaiSP)
values ('SP01', 'Ao cuoi', '', 'Mau01', 'NSX01', 5, 1000000,1500000,'LSP01')
insert into SanPham(MaSP, TenSp, AnhMinhHoa, MaMau, MaNoiSX, SoLuong,DonGiaNhap, DonGiaThue, MaLoaiSP)
values ('SP02', 'Vest','', 'Mau02', 'NSX01', 5, 500000, 1000000, 'LSP02')
insert into ChiTietHDong (MaHD, MaSP, SoLuong, NgayThue,ChuaTra)
values ('HD01', 'SP01', 1, '4/5/2020', '')
insert into ChiTietHDong (MaHD, MaSP, SoLuong, NgayThue, ChuaTra)
values ('HD01', 'SP02', 2, '4/5/2020', '')
insert into ChiTietThanhToan(MaThanhToan, MaSP, NgayTra, ThanhTien)
values ('TT01', 'SP01', '4/12/2020','')
insert into ChiTietThanhToan(MaThanhToan, MaSP, NgayTra, ThanhTien)
values ('TT01', 'SP02', '4/13/2020','')
insert into LoaiSP(MaLoaiSP, TenLoaiSP)
values ('LSP01', 'Loai 1')
insert into NoiSanXuat(MaNoiSX, TenNoiSX)
values ('NSX01', 'Viet Phuong')
insert into ThanhToanHD(MaThanhToan, MaHD, MaNV, NgayThanhToan, TongTien, SoTienThanhToan)
values ('TT01','HD01','NV01','4/20/2020',10500000,'')
insert into HopDong(MaHD,MaKhach,MaNV, NgayHD, KhuyenMai,TamUng)
values ('HD01', 'KH01', 'NV01', '3/31/2020', 0, 500000)
insert into HopDong(MaHD,MaKhach,MaNV, NgayHD, KhuyenMai,TamUng)
values ('HD02', 'KH01', 'NV01', '3/31/2020', 0, 0)



