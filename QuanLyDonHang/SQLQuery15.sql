
USE [QuanLyDonHang]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 8/13/2021 5:44:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
    [MaNV] [int] IDENTITY(1,1) NOT NULL,
    [TaiKhoan] [nvarchar](50) NOT NULL,
    [MatKhau] [nvarchar](50) NOT NULL,
    [IDPer] [int] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
    [MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
 
GO
create proc [dbo].[SP_AuthoLogin]
@Username nvarchar(20),
@Password nvarchar(20)
as
begin
    if exists (select * from NhanVien where TaiKhoan = @Username and MatKhau = @Password and IDPer = 1)
        select 1 as code
    else if exists (select * from NhanVien where TaiKhoan = @Username and MatKhau = @Password and IDPer = 0)
        select 0 as code
    else if exists(select * from NhanVien where TaiKhoan = @Username and MatKhau != @Password) 
        select 2 as code
    else select 3 as code
end