create database QuanLyKhachSan
on
( name=qlyks_data,
  filename='C:\gitexample\QuanLyKhachSan\qly_ks.mdf',
  size=5,
  maxsize=10,
  filegrowth=2
)
log on
( name=qlyks_log,
  filename='C:\gitexample\QuanLyKhachSan\qly_ks.ldf',
  size=5mb,
  filegrowth=2mb
)

create table tblPhong
( Maphong nvarchar(10) primary key not null,
  Tenphong nvarchar(50),
  Dongia float
)

insert into tblPhong(Maphong, Tenphong, Dongia) 
values ('P01', 'Phòng 1', 1000000)
insert into tblPhong(Maphong, Tenphong, Dongia) 
values ('P02', 'Phòng 2', 500000)

select * from tblPhong



