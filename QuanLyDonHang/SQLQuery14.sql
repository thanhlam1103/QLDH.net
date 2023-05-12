use [QuanLyDonHang]
go
Create proc [dbo].[SP_Update_Pass]
@User nvarchar(50),
@OldPass nvarchar(50),
@NewPass nvarchar(50)
as
begin
    if exists (select * from NhanVien where TaiKhoan = @User and MatKhau = @OldPass)
    begin
        update NhanVien set MatKhau = @NewPass where TaiKhoan = @User
        select 1 as code, N'Thay doi mat khau thanh cong !!' as MSG
    end
    else
        select 0 as code, N'Tai khoan hoac mat khau sai !!' as MSG
end
