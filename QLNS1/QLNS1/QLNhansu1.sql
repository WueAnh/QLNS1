
CREATE TABLE Account (
    UserName NVARCHAR2(100) PRIMARY KEY,
    DisplayName NVARCHAR2(100) DEFAULT 'Si' NOT NULL,
    Password NVARCHAR2(1000) DEFAULT '1962026656160185351301320480154111117132155' NOT NULL,
    Type NUMBER(1) DEFAULT 0 NOT NULL
);
CREATE TABLE BoPhan (
    MaBP VARCHAR2(20) PRIMARY KEY,
    TenBP NVARCHAR2(150) NOT NULL,
    NgayTL DATE,
    GhiChu NVARCHAR2(500)
);
CREATE TABLE PhongBan (
    MaPhong VARCHAR2(20) PRIMARY KEY,
    MaBP VARCHAR2(20) REFERENCES BoPhan(MaBP) NOT NULL,
    tenBP NVARCHAR2(150) NOT NULL,
    TenPhong NVARCHAR2(50) NOT NULL,
    DiaChi NVARCHAR2(150)
);

CREATE TABLE NhanVien (
    MaNV VARCHAR2(20) PRIMARY KEY,
    TenNV NVARCHAR2(50) NOT NULL,
    GioiTinh NVARCHAR2(20) NOT NULL,
    NgaySinh VARCHAR2(20) NOT NULL,
    QueQuan NVARCHAR2(200) NOT NULL,
    SDT NUMBER(10),
    DiaChi NVARCHAR2(200),
    Cmnd NUMBER(10),
    Email VARCHAR2(50),
    TenTDHV NVARCHAR2(100),
    CNganh NVARCHAR2(100),
    ChucVu NVARCHAR2(200),
    TinhTrang NVARCHAR2(200),
    NgayVaoLam VARCHAR2(20),
    UserName NVARCHAR2(100) REFERENCES Account(UserName) NOT NULL,
    MaPhong VARCHAR2(20) REFERENCES PhongBan(MaPhong) NOT NULL,
    MaBP VARCHAR2(20) REFERENCES BoPhan(MaBP) NOT NULL
);
CREATE TABLE ChamCong (
    MaCC NUMBER PRIMARY KEY,
    UserName NVARCHAR2(100) REFERENCES Account(UserName) NOT NULL,
    MaNV VARCHAR2(20) REFERENCES NhanVien(MaNV) ON DELETE CASCADE NOT NULL,
    TenNV NVARCHAR2(50) NOT NULL,
    NgayCham VARCHAR2(250),
    GioVao VARCHAR2(250),
    StatusIn VARCHAR2(20),
    GioRa VARCHAR2(250),
    StatusOut VARCHAR2(20),
    DiTre NVARCHAR2(20)
);

CREATE TABLE Luong (
    MaLuong number PRIMARY KEY,
    TenNV NVARCHAR2(50) NOT NULL,
    LuongCB FLOAT,
    ChucVu NVARCHAR2(200),
    MaNV VARCHAR2(20) REFERENCES NhanVien(MaNV) ON DELETE CASCADE NOT NULL
);


CREATE TABLE DSBaoHiem (
    MaBH number PRIMARY KEY,
    MaNV VARCHAR2(20) REFERENCES NhanVien(MaNV) ON DELETE CASCADE NOT NULL,
    TenNV NVARCHAR2(50) NOT NULL,
    LoaiBH NVARCHAR2(50),
    MaTheBH VARCHAR2(20),
    NgayCap VARCHAR2(20),
    NgayHetHan VARCHAR2(20),
    NoiCap NVARCHAR2(100),
    PhiBaoHiem FLOAT
);


CREATE TABLE DSKhenThuong (
    MaThuong NUMBER PRIMARY KEY,
    MaNV VARCHAR2(20) REFERENCES NhanVien(MaNV) ON DELETE CASCADE NOT NULL,
    TenNV NVARCHAR2(50) NOT NULL,
    NgayThuong VARCHAR2(20),
    LyDo NVARCHAR2(300),
    HinhThuc NVARCHAR2(300),
    TienThuong FLOAT
);
CREATE TABLE DSKyLuat (
    MaKyLuat NUMBER PRIMARY KEY,
    MaNV VARCHAR2(20) REFERENCES NhanVien(MaNV) ON DELETE CASCADE NOT NULL,
    TenNV NVARCHAR2(50) NOT NULL,
    NgayKyLuat VARCHAR2(20),
    LyDo NVARCHAR2(300),
    HinhThuc NVARCHAR2(300),
    TienPhat FLOAT
);
CREATE TABLE DSThaiSan (
    MaThaiSan NUMBER PRIMARY KEY,
    MaNV VARCHAR2(20) REFERENCES NhanVien(MaNV) ON DELETE CASCADE NOT NULL,
    TenNV NVARCHAR2(50) NOT NULL,
    NgayBatDau VARCHAR2(20),
    NgayKetThuc VARCHAR2(20),
    TrangThai NVARCHAR2(300)
);

CREATE TABLE HopDong (
    MaHD VARCHAR2(20) PRIMARY KEY NOT NULL,
    MaNV VARCHAR2(20) REFERENCES NhanVien(MaNV) ON DELETE CASCADE NOT NULL,
    TenNV NVARCHAR2(50) NOT NULL,
    MaBP VARCHAR2(20) NOT NULL,
    tenBP NVARCHAR2(150) NOT NULL,
    MaPhong VARCHAR2(20) NOT NULL,
    TenPhong NVARCHAR2(50) NOT NULL,
    LoaiHD NVARCHAR2(150) NOT NULL,
    NgayBD VARCHAR2(20) NOT NULL,
    NgayKT VARCHAR2(20) NOT NULL
);

CREATE TABLE TongLuong (
    MaTongLuong NUMBER PRIMARY KEY NOT NULL,
    MaNV VARCHAR2(20) REFERENCES NhanVien(MaNV) ON DELETE CASCADE NOT NULL,
    TenNV NVARCHAR2(50) NOT NULL,
    TuNgay VARCHAR2(20),
    DenNgay VARCHAR2(20),
    SoNgayCong NUMBER,
    LuongCB FLOAT,
    TongPhiBH FLOAT,
    TongTienThuong FLOAT,
    TongTienPhat FLOAT,
    TongLuong FLOAT
);

------------------Insert DATA--------------------------------
insert into Account values ('admin', 'Manager', '1962026656160185351301320480154111117132155', 0);
insert into Account values ('staff', 'Employee', '1962026656160185351301320480154111117132155', 3);
insert into BoPhan values ('BP001', 'Technique',  TO_DATE('3/3/2021', 'MM/DD/YYYY'), '');
insert into BoPhan values ('BP002', 'Technology', TO_DATE('3/2/2020', 'MM/DD/YYYY'), '');
insert into BoPhan values ('BP003', 'Audit', TO_DATE('3/2/2020', 'MM/DD/YYYY'), '');
insert into BoPhan values ('BP004', 'Administration', TO_DATE('3/2/2020', 'MM/DD/YYYY'), '');
insert into BoPhan values ('BP005', 'Human resources', TO_DATE('3/2/2020', 'MM/DD/YYYY'), '');
insert into BoPhan values ('BP006', 'Customer Service', TO_DATE('3/2/2020', 'MM/DD/YYYY'), '');
insert into PhongBan values ('PB01', 'BP001', 'Technique', 'Software', 'Ton Duc Thang');
insert into PhongBan values ('PB02', 'BP002', 'Technology', 'Biology', 'Nguyen Tat Thanh');
insert into PhongBan values ('PB03', 'BP003', 'Audit', 'Audit', 'Nguyen Tat Thanh');
insert into PhongBan values ('PB04', 'BP004', 'Administration', 'Administration', 'Ton Duc Thang');
insert into PhongBan values ('PB05', 'BP005', 'Human resources','Human resources', 'Ton Duc Thang');
insert into PhongBan values ('PB06', 'BP006', 'Customer Service','Customer Service', 'Ton Duc Thang');


------------------login Account---------------------
CREATE OR REPLACE FUNCTION sp_LogintAccount(
  p_username IN VARCHAR2,
  p_password IN VARCHAR2
) RETURN SYS_REFCURSOR IS
  v_cursor SYS_REFCURSOR;
BEGIN
  OPEN v_cursor FOR
    SELECT *
    FROM Account
    WHERE UserName = p_username AND Password = p_password;

  RETURN v_cursor;
END sp_LogintAccount;

------------------ChangePassword---------------------

CREATE OR REPLACE PROCEDURE sp_ChangeAccount(
  p_username IN VARCHAR2,
  p_displayname IN VARCHAR2,
  p_password IN VARCHAR2,
  p_newpassword IN VARCHAR2
) IS
  v_isRightPass NUMBER := 0;
BEGIN
  -- Check if the username and password match
  SELECT COUNT(*)
  INTO v_isRightPass
  FROM Account
  WHERE UserName = p_username AND Password = p_password;

  -- If a match is found, update the account
  IF v_isRightPass > 0 THEN
    -- If new password is empty, update display name only
    IF p_newpassword IS NULL OR p_newpassword = '' THEN
      UPDATE Account
      SET DisplayName = p_displayname
      WHERE UserName = p_username;
    ELSE
      -- Update both display name and password
      UPDATE Account
      SET DisplayName = p_displayname, Password = p_newpassword
      WHERE UserName = p_username;
    END IF;
  END IF;
END sp_ChangeAccount;
/


------------------Checkbaohiem---------------------
CREATE OR REPLACE PROCEDURE sp_CheckBaoHiemIsExists (
  p_manv IN VARCHAR2,
  p_loaibh IN VARCHAR2,
  p_tungay IN VARCHAR2,
  p_denngay IN VARCHAR2,
  p_result OUT SYS_REFCURSOR
) IS
BEGIN
  OPEN p_result FOR
    SELECT *
    FROM DSBaoHiem
    WHERE MaNV = p_manv
      AND LoaiBH = p_loaibh
      AND (
        NgayHetHan BETWEEN TO_DATE(p_tungay || ' 00:00:00', 'DD/MM/YYYY HH24:MI:SS')
        AND TO_DATE(p_denngay || ' 23:59:59', 'DD/MM/YYYY HH24:MI:SS')
        OR TO_DATE(p_denngay, 'DD/MM/YYYY') < NgayHetHan
      );
END sp_CheckBaoHiemIsExists;
/

------------------------------Th? t?c ki?m tra ch?m công theo ngày----------------------------
CREATE OR REPLACE PROCEDURE sp_CheckChamCongExists (
  p_manv IN VARCHAR2,
  p_ngaycham IN VARCHAR2,
  p_result OUT SYS_REFCURSOR
) IS
BEGIN
  OPEN p_result FOR
    SELECT *
    FROM ChamCong
    WHERE MaNV = p_manv AND NgayCham = TO_DATE(p_ngaycham, 'DD/MM/YYYY');
END sp_CheckChamCongExists;
------------------------------Th? t?c l?c ch?m công theo MaBP theo ngày----------------------------
CREATE OR REPLACE PROCEDURE RP_ChamCongByMaBP (
  p_mabp IN VARCHAR2,
  p_tungay IN VARCHAR2,
  p_denngay IN VARCHAR2,
  p_result OUT SYS_REFCURSOR
) IS
BEGIN
  OPEN p_result FOR
    SELECT cc.*
    FROM ChamCong cc, NhanVien nv, BoPhan bp
    WHERE cc.MaNV = nv.MaNV
      AND nv.MaBP = bp.MaBP
      AND bp.MaBP = p_mabp
      AND NgayCham BETWEEN TO_DATE(p_tungay || ' 00:00:00', 'DD/MM/YYYY HH24:MI:SS')
      AND TO_DATE(p_denngay || ' 23:59:59', 'DD/MM/YYYY HH24:MI:SS');
END RP_ChamCongByMaBP;
-------------------------------Th? t?c l?c nhân viên theo B? Ph?n----------------------------------
CREATE OR REPLACE PROCEDURE RP_NhanVienbyMaBP (
  p_mabp IN VARCHAR2,
  p_result OUT SYS_REFCURSOR
) IS
BEGIN
  OPEN p_result FOR
    SELECT nv.*
    FROM NhanVien nv, BoPhan bp
    WHERE nv.MaBP = bp.MaBP
      AND bp.MaBP = p_mabp;
END RP_NhanVienbyMaBP;
-------------------------------Th? t?c l?c nhân viên ch?m công ?i tr? gi?----------------------------------
CREATE OR REPLACE PROCEDURE RP_NhanVienDiTre (
  p_manv VARCHAR2,
  p_ngaybatdau VARCHAR2,
  p_ngayketthuc VARCHAR2,
  p_result OUT SYS_REFCURSOR
) IS
BEGIN
  OPEN p_result FOR
    SELECT MaNV, TenNV, NgayCham, GioVao, DiTre
    FROM ChamCong
    WHERE MaNV = p_manv AND DiTre = 'Tr? gi? làm' AND NgayCham BETWEEN TO_DATE(p_ngaybatdau, 'DD/MM/YYYY') AND TO_DATE(p_ngayketthuc, 'DD/MM/YYYY');
END RP_NhanVienDiTre;
-------------------------------Th? t?c l?c nhân viên ch?m công làm thêm gi?----------------------------------
CREATE OR REPLACE PROCEDURE RP_ThemGio (
  p_ngaybatdau VARCHAR2,
  p_ngayketthuc VARCHAR2,
  p_result OUT SYS_REFCURSOR
) IS
BEGIN
  OPEN p_result FOR
    SELECT cc.*, (TO_DATE(cc.GioRa, 'HH24:MI') - TO_DATE('17:00', 'HH24:MI')) * 24 * 60 AS GioLamThem
    FROM ChamCong cc
    WHERE cc.GioRa > '17:30' AND cc.GioRa < '24:00' AND NgayCham BETWEEN TO_DATE(p_ngaybatdau, 'DD/MM/YYYY') AND TO_DATE(p_ngayketthuc, 'DD/MM/YYYY');
END RP_ThemGio;
------------------------------Th? t?c l?c thâm niên-------------------------------------------
CREATE OR REPLACE PROCEDURE RP_ThamNien (
  p_ngaybatdau VARCHAR2,
  p_ngayketthuc VARCHAR2,
  p_result OUT SYS_REFCURSOR
) IS
BEGIN
  OPEN p_result FOR
    SELECT nv.*, MONTHS_BETWEEN(SYSDATE, TO_DATE(nv.NgayVaoLam, 'DD/MM/YYYY')) / 12 AS ThamNien
    FROM NhanVien nv;
END RP_ThamNien;
-------------------------------Th? t?c l?c theo h?p ??ng s?p h?t h?n ----------------------------------

CREATE OR REPLACE PROCEDURE RP_HopDong (
  p_ngaybatdau VARCHAR2,
  p_ngayketthuc VARCHAR2,
  p_result OUT SYS_REFCURSOR
) IS
BEGIN
  OPEN p_result FOR
    SELECT hd.*
    FROM HopDong hd
    WHERE hd.NgayKT BETWEEN TO_DATE(p_ngaybatdau, 'DD/MM/YYYY') AND TO_DATE(p_ngayketthuc, 'DD/MM/YYYY');
END RP_HopDong;



