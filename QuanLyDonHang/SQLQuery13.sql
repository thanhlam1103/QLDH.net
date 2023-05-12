use [QuanLyDonHang]
go
create proc SP_ShowKhachHang
as
begin
	select * from tblKhach
end
go

create proc SP_ShowHang
as
begin
	select * from tblHang
end
go