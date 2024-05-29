using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Final_Project_OOP
{
     class Program
    {
        public static List<LoaiKhach> dsloaiKhach = new List<LoaiKhach>();
        public static List<Khach> dskhach = new List<Khach>();
        public static List<HoaDon> dshoaDon = new List<HoaDon>();
        public static List<DichVu> dsdichVu = new List<DichVu>();
        public static List<LoaiDichVu> dsloaiDichVu = new List<LoaiDichVu>();
        public static List<MayTinh> dsmayTinh = new List<MayTinh>();
        public static List<LoaiMayTinh> dsloaiMayTinh = new List<LoaiMayTinh>();
        public static List<Phong> dsphong = new List<Phong>();
        public static List<LoaiPhong> dsloaiPhong = new List<LoaiPhong>();
        public static List<NhanVien> dsnhanVien = new List<NhanVien>();
        public static List<Tang> dstang = new List<Tang>();
        public static List<ChiTietHoaDon> dschiTietHoaDon = new List<ChiTietHoaDon>();
        public static List<TrucPhong> dstrucPhong = new List<TrucPhong>();
        public static void taoDSLoaiKhach()
        {
            dsloaiKhach.Add(new LoaiKhach("NEWCUS000", "Khách Hàng Mới", "Khách hàng lần đầu đến quán"));
            dsloaiKhach.Add(new LoaiKhach("NORCUS001", "Khách Hàng Bình Thường", "Khách hàng thường xuyên đến quán"));
            dsloaiKhach.Add(new LoaiKhach("VIPCUS002", "Khách Hàng Vip", "Khách hàng có số giờ chơi trên 50h"));
            dsloaiKhach.Add(new LoaiKhach("SVIPCUS003", "Khách Hàng Siêu VIP", "Khách hàng thường xuyên sử dụng dịch vụ VIPP của quán "));
        }
        public static void taoDSKhachHang()
        {
            dskhach.Add(new Khach("KH001", "Phạm Lê Thiên Phú", 18, "An Phú Trung", "0832165657", dsloaiKhach[1]));
            dskhach.Add(new Khach("KH002", "Trần Hưng Phấn", 26, "Vĩnh An", "0345088366", dsloaiKhach[0]));
            dskhach.Add(new Khach("KH003", "Trần Thị Ngọc Anh", 20, "Thái Hòa", "0866151546", dsloaiKhach[1]));
            dskhach.Add(new Khach("KH004", "Triệu Minh Nhật", 18, "Anh Đông", "0369412799", dsloaiKhach[1]));
            dskhach.Add(new Khach("KH005", "Trần Thanh Sang", 22, "An Thủy", "0977479750", dsloaiKhach[2]));
            dskhach.Add(new Khach("KH006", "Triệu Quân Sự", 25, "Bình Dương", "0394033398", dsloaiKhach[3]));
            dskhach.Add(new Khach("KH007", "Lại Minh Béo", 19, "Bình Hòa", "0367312969", dsloaiKhach[0]));
            dskhach.Add(new Khach("KH008", "Rô Nan Đô", 22, "Bồ Đào Nha", "0348491345", dsloaiKhach[1]));
            dskhach.Add(new Khach("KH009", "Nây Ma", 30, "Ra Xiu", "0399200026", dsloaiKhach[2]));
            dskhach.Add(new Khach("KH010", "Nguyễn Tuấn Luyện", 20, "An Hòa", "0357585554", dsloaiKhach[3]));
            dskhach.Add(new Khach("KH011", "Trần Nhựt Quang", 21, "Tân Xuân", "0356195586", dsloaiKhach[0]));
            dskhach.Add(new Khach("KH012", "Thái Kim Huỳnh", 19, "An Thái", "0986998564", dsloaiKhach[1]));
            dskhach.Add(new Khach("KH013", "Mai Kim Ngân", 19, "Hòa Bình", "0337958468", dsloaiKhach[1]));
            dskhach.Add(new Khach("KH014", "Phạm Lê Thiện Quí", 17, "Tây Ninh", "0356927268", dsloaiKhach[2]));
            dskhach.Add(new Khach("KH015", "Lê Thị Thúy", 45, "Thạnh Phú", "0397771766", dsloaiKhach[3]));
            dskhach.Add(new Khach("KH016", "Trần Phát Huy", 23, "Tân Hưng", "0987809287", dsloaiKhach[0]));
            dskhach.Add(new Khach("KH017", "Nguyễn Tấn Đạo", 20, "Bình Dương", "0348418586", dsloaiKhach[2]));
            dskhach.Add(new Khach("KH018", "Trần Đức Nguyên", 21, "Thái Nguyên", "0384807117", dsloaiKhach[0]));
            dskhach.Add(new Khach("KH019", "Trần Thị Thành Nghiệp", 21, "Đồng Deer", "0865318339", dsloaiKhach[3])); 
            dskhach.Add(new Khach("KH020", "Yamate Kudasai", 26, "Nhật Bổn", "0379347368", dsloaiKhach[2]));
        }
        

        public static void taoDSLoaiDV()
        {
            dsloaiDichVu.Add(new LoaiDichVu("LDV001", "Loại dịch vụ máy tính cấu hình nhẹ", "Máy tính dùng cho việc nhập liệu cơ bản của dân văn phòng"));
            dsloaiDichVu.Add(new LoaiDichVu("LDV002", "Loại dịch vụ máy tính cấu hình trung bình", "Máy tính dùng cho việc xem phim, lướt web cơ bản không đòi hỏi cấu hình cao"));
            dsloaiDichVu.Add(new LoaiDichVu("LDV003", "Loại dịch vụ máy tính cấu hình mạnh", "Máy tính dùng cho việc chơi game được trang bị cấu hình mạnh"));
        }
        public static void taoDSDV()
        {
            dsdichVu.Add(new DichVu("DV001", "Dịch vụ máy tính xem phim", dsloaiDichVu[1]));
            dsdichVu.Add(new DichVu("DV002", "Dịch vụ máy tính lướt web", dsloaiDichVu[1]));
            dsdichVu.Add(new DichVu("DV003", "Dịch vụ máy tính đọc báo", dsloaiDichVu[1]));
            dsdichVu.Add(new DichVu("DV004", "Dịch vụ máy tính truy cập mạng xã hội", dsloaiDichVu[1]));
            dsdichVu.Add(new DichVu("DV005", "Dịch vụ máy tính chỉnh sửa văn bản", dsloaiDichVu[0]));
            dsdichVu.Add(new DichVu("DV005", "Dịch vụ máy tính thiết kế Slide trình chiếu", dsloaiDichVu[0]));
            dsdichVu.Add(new DichVu("DV005", "Dịch vụ máy tính chỉnh sửa chỉnh sửa hình ảnh", dsloaiDichVu[2]));
            dsdichVu.Add(new DichVu("DV006", "Dịch vụ máy tính chơi game", dsloaiDichVu[2]));
        }
        public static void taoDSLoaiMay()
        {
            dsloaiMayTinh.Add(new LoaiMayTinh("LMT001","Máy tính Dell Siêu Cấp Vjp Pro", "Máy này chơi game chiến lắm, bao mượt, combat cực phê, chơi mê tới sáng", "20k/1h"));
            dsloaiMayTinh.Add(new LoaiMayTinh("LMT002", "Máy tính ASUS Mẫu Đẹp", "Máy tính cho bạn trải nghiệm lướt web mượt mà", "15k/1h"));
            dsloaiMayTinh.Add(new LoaiMayTinh("LMT003", "Máy tính ACER Gọn Nhẹ", "Máy tính trang bị mang hình sắc nét 4k, cho bạn trải nghiệm điện ảnh chân thực", "15k/1h"));
            dsloaiMayTinh.Add(new LoaiMayTinh("LMT004", "Máy tính HP Mạnh, To, Đen, Hơi Đẹp :))", "Máy này chơi game cũng cỡ con DELL, nhưng nó là máy HP", "20k/1h"));
            dsloaiMayTinh.Add(new LoaiMayTinh("LMT005", "Máy tính SAMSUNG Mỏng, Nhẹ", "Lướt web, đọc báo, lên FB các kiểu thoải mái", "15k/1h"));
            dsloaiMayTinh.Add(new LoaiMayTinh("LMT006", "Máy tính Lenovo Trâu Bò Cày Bừa Thua Máy Này Cày Coin", "Máy này cày coin ngon lắm, thuê đi", "15k/1h"));
            dsloaiMayTinh.Add(new LoaiMayTinh("LMT007", "Máy tính MSI Phục Vụ Công Việc Văn Phòng", "Word, Exceel, PPS, ... cái gì cũng được lên hết đi", "10k/1h"));
            dsloaiMayTinh.Add(new LoaiMayTinh("LMT008", "Máy tính Razer Nghe Thôi Đã Biết Máy Tính Chơi Game", "Giờ mà Logitech nhảy vào làm máy tính chơi game thì may ra mới so với con máy này được", "20k/1h"));
            dsloaiMayTinh.Add(new LoaiMayTinh("LMT009", "Máy tính APPLE Sang Trọng Thời Thượng", "Con máy này cũng xài Office 365 ngon lành luôn", "10k/1h"));
            dsloaiMayTinh.Add(new LoaiMayTinh("LMT010", "Máy tính ALIENWARE Combat Cực Mê, Chặt Chém Cực Phê", "Máy tính chơi game đời mới, tuyên bố tụi Razer, Dell là ĐBRR hết", "20k/1h"));
        }
        public static void taoDSMayTinh()
        {
            dsmayTinh.Add(new MayTinh("MAY001", 855, "Dell001", "Dell", dsloaiMayTinh[0], dsphong[0]));
            dsmayTinh.Add(new MayTinh("MAY002", 796, "Dell002", "Dell", dsloaiMayTinh[0], dsphong[0]));
            dsmayTinh.Add(new MayTinh("MAY003", 871, "Dell003", "Dell", dsloaiMayTinh[0], dsphong[0]));
            dsmayTinh.Add(new MayTinh("MAY004", 626, "Dell004", "Dell", dsloaiMayTinh[0], dsphong[1]));
            dsmayTinh.Add(new MayTinh("MAY005", 916, "Dell005", "Dell", dsloaiMayTinh[0], dsphong[1]));
            dsmayTinh.Add(new MayTinh("MAY006", 543, "Asus001", "Asus", dsloaiMayTinh[1], dsphong[1]));
            dsmayTinh.Add(new MayTinh("MAY007", 443, "Asus002", "Asus", dsloaiMayTinh[1], dsphong[2]));
            dsmayTinh.Add(new MayTinh("MAY008", 193, "Asus003", "Asus", dsloaiMayTinh[1], dsphong[2]));
            dsmayTinh.Add(new MayTinh("MAY009", 378, "Asus004", "Asus", dsloaiMayTinh[1], dsphong[2]));
            dsmayTinh.Add(new MayTinh("MAY010", 985, "Asus005", "Asus", dsloaiMayTinh[1], dsphong[3]));
            dsmayTinh.Add(new MayTinh("MAY011", 470, "Acer001", "Acer", dsloaiMayTinh[2], dsphong[3]));
            dsmayTinh.Add(new MayTinh("MAY012", 301, "Acer002", "Acer", dsloaiMayTinh[2], dsphong[3]));
            dsmayTinh.Add(new MayTinh("MAY013", 967, "Acer003", "Acer", dsloaiMayTinh[2], dsphong[4]));
            dsmayTinh.Add(new MayTinh("MAY014", 955, "Acer004", "Acer", dsloaiMayTinh[2], dsphong[4]));
            dsmayTinh.Add(new MayTinh("MAY015", 152, "Acer005", "Acer", dsloaiMayTinh[2], dsphong[4]));
            dsmayTinh.Add(new MayTinh("MAY016", 315, "HP001", "HP", dsloaiMayTinh[3], dsphong[5]));
            dsmayTinh.Add(new MayTinh("MAY017", 962, "HP002", "HP", dsloaiMayTinh[3], dsphong[5]));
            dsmayTinh.Add(new MayTinh("MAY018", 800, "HP003", "HP", dsloaiMayTinh[3], dsphong[5]));
            dsmayTinh.Add(new MayTinh("MAY019", 762, "HP004", "HP", dsloaiMayTinh[3], dsphong[6]));
            dsmayTinh.Add(new MayTinh("MAY020", 627, "HP005", "HP", dsloaiMayTinh[3], dsphong[6]));
            dsmayTinh.Add(new MayTinh("MAY021", 591, "Samsung001", "Samsung", dsloaiMayTinh[4], dsphong[6]));
            dsmayTinh.Add(new MayTinh("MAY022", 979, "Samsung002", "Samsung", dsloaiMayTinh[4], dsphong[7]));
            dsmayTinh.Add(new MayTinh("MAY023", 909, "Samsung003", "Samsung", dsloaiMayTinh[4], dsphong[7]));
            dsmayTinh.Add(new MayTinh("MAY024", 640, "Samsung004", "Samsung", dsloaiMayTinh[4], dsphong[7]));
            dsmayTinh.Add(new MayTinh("MAY025", 879, "Samsung005", "Samsung", dsloaiMayTinh[4], dsphong[8]));
            dsmayTinh.Add(new MayTinh("MAY026", 650, "Lenovo001", "Lenovo", dsloaiMayTinh[5], dsphong[8]));
            dsmayTinh.Add(new MayTinh("MAY027", 831, "Lenovo002", "Lenovo", dsloaiMayTinh[5], dsphong[8]));
            dsmayTinh.Add(new MayTinh("MAY028", 411, "Lenovo003", "Lenovo", dsloaiMayTinh[5], dsphong[9]));
            dsmayTinh.Add(new MayTinh("MAY029", 786, "Lenovo004", "Lenovo", dsloaiMayTinh[5], dsphong[9]));
            dsmayTinh.Add(new MayTinh("MAY030", 310, "Lenovo005", "Lenovo", dsloaiMayTinh[5], dsphong[9]));
            dsmayTinh.Add(new MayTinh("MAY031", 905, "Msi001", "Msi", dsloaiMayTinh[6], dsphong[10]));
            dsmayTinh.Add(new MayTinh("MAY032", 348, "Msi002", "Msi", dsloaiMayTinh[6], dsphong[10]));
            dsmayTinh.Add(new MayTinh("MAY033", 937, "Msi003", "Msi", dsloaiMayTinh[6], dsphong[10]));
            dsmayTinh.Add(new MayTinh("MAY034", 458, "Msi004", "Msi", dsloaiMayTinh[6], dsphong[11]));
            dsmayTinh.Add(new MayTinh("MAY035", 810, "Msi005", "Msi", dsloaiMayTinh[6], dsphong[11]));
            dsmayTinh.Add(new MayTinh("MAY036", 409, "Razer001", "Razer", dsloaiMayTinh[7], dsphong[11]));
            dsmayTinh.Add(new MayTinh("MAY037", 978, "Razer002", "Razer", dsloaiMayTinh[7], dsphong[12]));
            dsmayTinh.Add(new MayTinh("MAY038", 514, "Razer003", "Razer", dsloaiMayTinh[7], dsphong[12]));
            dsmayTinh.Add(new MayTinh("MAY039", 663, "Razer004", "Razer", dsloaiMayTinh[7], dsphong[12]));
            dsmayTinh.Add(new MayTinh("MAY040", 401, "Razer005", "Razer", dsloaiMayTinh[7], dsphong[13]));
            dsmayTinh.Add(new MayTinh("MAY041", 657, "Apple001", "Apple", dsloaiMayTinh[8], dsphong[13]));
            dsmayTinh.Add(new MayTinh("MAY042", 984, "Apple002", "Apple", dsloaiMayTinh[8], dsphong[13]));
            dsmayTinh.Add(new MayTinh("MAY043", 959, "Apple003", "Apple", dsloaiMayTinh[8], dsphong[14]));
            dsmayTinh.Add(new MayTinh("MAY044", 703, "Apple004", "Apple", dsloaiMayTinh[8], dsphong[14]));
            dsmayTinh.Add(new MayTinh("MAY045", 222, "Apple005", "Apple", dsloaiMayTinh[8], dsphong[14]));
            dsmayTinh.Add(new MayTinh("MAY046", 442, "AlienWare001", "AlienWare", dsloaiMayTinh[9], dsphong[10]));
            dsmayTinh.Add(new MayTinh("MAY047", 290, "AlienWare002", "AlienWare", dsloaiMayTinh[9], dsphong[11]));
            dsmayTinh.Add(new MayTinh("MAY048", 721, "AlienWare003", "AlienWare", dsloaiMayTinh[9], dsphong[12]));
            dsmayTinh.Add(new MayTinh("MAY049", 706, "AlienWare004", "AlienWare", dsloaiMayTinh[9], dsphong[13]));
            dsmayTinh.Add(new MayTinh("MAY050", 999, "AlienWare005", "AlienWare", dsloaiMayTinh[9], dsphong[14]));
        }
        public static void taoDSLoaiPhong()
        {
            dsloaiPhong.Add(new LoaiPhong("LP1", "Phòng thường", "Phòng dùng cho các dịch vụ như nhập liệu, chỉnh sửa văn bản,..."));
            dsloaiPhong.Add(new LoaiPhong("LP2", "Phòng tầm trung", "Phòng dùng cho các dịch vụ như xem phim, lướt web, đọc báo,..."));
            dsloaiPhong.Add(new LoaiPhong("LP3", "Phòng VIP", "Phòng dùng cho các dịch vụ chơi game"));
        }
        public static void taoDSPhong()
        {
            dsphong.Add(new Phong("P01", "1.0", dstang[1-1], dsloaiPhong[0] ));
            dsphong.Add(new Phong("P02", "2.0", dstang[1-1], dsloaiPhong[1] ));
            dsphong.Add(new Phong("P03", "3.0", dstang[1-1], dsloaiPhong[2] ));
            dsphong.Add(new Phong("P04", "1.1", dstang[2-1], dsloaiPhong[0] ));
            dsphong.Add(new Phong("P05", "2.1", dstang[2 - 1], dsloaiPhong[1] ));
            dsphong.Add(new Phong("P06", "3.1", dstang[2 - 1],  dsloaiPhong[2] ));
            dsphong.Add(new Phong("P07", "1.2", dstang[3 - 1], dsloaiPhong[0] ));
            dsphong.Add(new Phong("P08", "2.2", dstang[3 - 1], dsloaiPhong[1] ));
            dsphong.Add(new Phong("P09", "3.2", dstang[3 - 1], dsloaiPhong[2] ));
            dsphong.Add(new Phong("P10", "1.3", dstang[4 - 1], dsloaiPhong[0] ));
            dsphong.Add(new Phong("P11", "2.3", dstang[4 - 1], dsloaiPhong[1]));
            dsphong.Add(new Phong("P12", "3.3", dstang[4 - 1], dsloaiPhong[2]));
            dsphong.Add(new Phong("P13", "1.4", dstang[5 - 1], dsloaiPhong[0]));
            dsphong.Add(new Phong("P14", "2.4", dstang[5 - 1], dsloaiPhong[1]));
            dsphong.Add(new Phong("P15", "3.4", dstang[5 - 1], dsloaiPhong[2]));
            //dsphong.Add(new Phong("P10", "10", dsloaiPhong[]));
        }
        public static void taDSNhanVien()
        {
            dsnhanVien.Add(new NhanVien("NV01", "Phạm Xuân Thứ", 20, "0862133381", "Nhân viên part-time"));
            dsnhanVien.Add(new NhanVien("NV02", "Nguyễn Hà Đông", 23, "0867727627", "Nhân viên part-time"));
            dsnhanVien.Add(new NhanVien("NV03", "Trần Hữu Nghĩa", 22, "0376346479", "Nhân viên part-time"));
            dsnhanVien.Add(new NhanVien("NV04", "Hồ Thị Kim Nga", 21, "0869042704", "Nhân viên part-time"));
            dsnhanVien.Add(new NhanVien("NV05", "Trần Minh Tân", 22, "0964533953", "Nhân viên part-time"));
            dsnhanVien.Add(new NhanVien("NV06", "Phan Tấn Trung", 22, "0983256742", "Nhân viên part-time"));
            dsnhanVien.Add(new NhanVien("NV07", "Nguyễn Thị Yến Nhi", 24, "0329380779", "Nhân viên full-time"));
            dsnhanVien.Add(new NhanVien("NV08", "Lê Thị Mỹ Linh", 25, "0382129288", "Nhân viên full-time"));
            dsnhanVien.Add(new NhanVien("NV09", "Nguyễn Tùng Lâm", 29, "0379588834", "Nhân viên full-time"));
            dsnhanVien.Add(new NhanVien("NV10", "Triệu Nhật Nam", 24, "0377130299", "Nhân viên full-time"));
            dsnhanVien.Add(new NhanVien("NV11", "Nguyễn Đình Văn", 31, "0386040583", "Nhân viên tạp vụ"));
            dsnhanVien.Add(new NhanVien("NV12", "Phạm Ngọc Triển", 33, "0362237998", "Nhân viên tạp vụ"));
        }
        public static void taoDSTang()
        {
            dstang.Add(new Tang("T1", "Tầng 1", "0353204199"));
            dstang.Add(new Tang("T2", "Tầng 2", "0375731969"));
            dstang.Add(new Tang("T3", "Tầng 3", "0987396400"));
            dstang.Add(new Tang("T4", "Tầng 4", "0354065786"));
            dstang.Add(new Tang("T5", "Tầng 5", "0347105339"));
        }
        public static void taoDSChiTietHoaDon()
        {
            //DV:0-5
            //hd: 23
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[0], dsdichVu[0]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[1], dsdichVu[5]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[2], dsdichVu[3]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[3], dsdichVu[1]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[4], dsdichVu[1]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[5], dsdichVu[4]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[6], dsdichVu[2]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[7], dsdichVu[1]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[8], dsdichVu[0]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[9], dsdichVu[3]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[10], dsdichVu[4]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[11], dsdichVu[2]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[12], dsdichVu[1]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[13], dsdichVu[1]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[14], dsdichVu[5]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[15], dsdichVu[3]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[16], dsdichVu[4]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[17], dsdichVu[3]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[18], dsdichVu[1]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[19], dsdichVu[3]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[20], dsdichVu[3]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[21], dsdichVu[2]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[22], dsdichVu[4]));
            dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[23], dsdichVu[3]));
           // dschiTietHoaDon.Add(new ChiTietHoaDon(dshoaDon[8], dsdichVu[3]));
        }
        public static void taoDSTrucPhong()
        {
            dstrucPhong.Add(new TrucPhong(dsnhanVien[9], dstang[3], dsphong[5], "Ngày 2021-02-06 lúc 00:26:53"));
            dstrucPhong.Add(new TrucPhong(dsnhanVien[11], dstang[2], dsphong[8], "Ngày 2021-06-04 lúc 10:31:52"));
            dstrucPhong.Add(new TrucPhong(dsnhanVien[11], dstang[0], dsphong[1], "Ngày 2020-11-08 lúc 03:53:02"));
            dstrucPhong.Add(new TrucPhong(dsnhanVien[4], dstang[3], dsphong[7], "Ngày 2021-05-12 lúc 13:13:36"));
            dstrucPhong.Add(new TrucPhong(dsnhanVien[9], dstang[1], dsphong[7], "Ngày 2020-11-18 lúc 17:42:22"));
            dstrucPhong.Add(new TrucPhong(dsnhanVien[10], dstang[2], dsphong[9], "Ngày 2021-04-03 lúc 00:54:09"));
            dstrucPhong.Add(new TrucPhong(dsnhanVien[4], dstang[1], dsphong[3], "Ngày 2020-10-02 lúc 23:25:42"));
        }
        public static void taoDSHoaDon()
        {

            dshoaDon.Add(new HoaDon("HD4777N", "Ngày 2021-04-03 lúc 07:49:19", 8, dskhach[2], dsmayTinh[15], dsdichVu[2], dsnhanVien[6]));
            dshoaDon.Add(new HoaDon("HD2552N", "Ngày 2021-05-01 lúc 20:13:14", 4, dskhach[15], dsmayTinh[24], dsdichVu[4], dsnhanVien[4]));
            dshoaDon.Add(new HoaDon("HD9694N", "Ngày 2020-12-22 lúc 03:57:22", 3, dskhach[9], dsmayTinh[40], dsdichVu[5], dsnhanVien[7]));
            dshoaDon.Add(new HoaDon("HD8015N", "Ngày 2020-12-29 lúc 14:40:42", 2, dskhach[7], dsmayTinh[35], dsdichVu[1], dsnhanVien[4]));
            dshoaDon.Add(new HoaDon("HD3814N", "Ngày 2020-12-21 lúc 12:37:27", 5, dskhach[12], dsmayTinh[12], dsdichVu[5], dsnhanVien[5]));
            dshoaDon.Add(new HoaDon("HD4596N", "Ngày 2021-05-24 lúc 21:58:46", 3, dskhach[8], dsmayTinh[25], dsdichVu[5], dsnhanVien[0]));

            dshoaDon.Add(new HoaDon("HD3435N", "Ngày 2021-06-19 lúc 02:26:18", 8, dskhach[18], dsmayTinh[29], dsdichVu[5], dsnhanVien[6]));
            dshoaDon.Add(new HoaDon("HD4798N", "Ngày 2020-11-01 lúc 22:24:28", 4, dskhach[13], dsmayTinh[35], dsdichVu[0], dsnhanVien[9]));
            dshoaDon.Add(new HoaDon("HD5437N", "Ngày 2021-01-23 lúc 05:34:11", 3, dskhach[0], dsmayTinh[34], dsdichVu[3], dsnhanVien[4]));
            dshoaDon.Add(new HoaDon("HD4322N", "Ngày 2020-11-08 lúc 22:00:07", 2, dskhach[0], dsmayTinh[45], dsdichVu[0], dsnhanVien[7]));
            dshoaDon.Add(new HoaDon("HD5459N", "Ngày 2021-03-02 lúc 18:19:07", 5, dskhach[19], dsmayTinh[28], dsdichVu[3], dsnhanVien[0]));
            dshoaDon.Add(new HoaDon("HD9954N", "Ngày 2021-05-03 lúc 11:13:45", 3, dskhach[7], dsmayTinh[26], dsdichVu[5], dsnhanVien[7]));

            dshoaDon.Add(new HoaDon("HD2927N", "Ngày 2021-04-10 lúc 18:04:00", 8, dskhach[17], dsmayTinh[6], dsdichVu[5], dsnhanVien[9]));
            dshoaDon.Add(new HoaDon("HD7133N", "Ngày 2020-10-08 lúc 05:46:21", 4, dskhach[3], dsmayTinh[7], dsdichVu[5], dsnhanVien[8]));
            dshoaDon.Add(new HoaDon("HD8811N", "Ngày 2021-05-23 lúc 21:03:48", 3, dskhach[14], dsmayTinh[9], dsdichVu[3], dsnhanVien[2]));
            dshoaDon.Add(new HoaDon("HD9950N", "Ngày 2021-06-18 lúc 11:38:26", 2, dskhach[10], dsmayTinh[46], dsdichVu[5], dsnhanVien[5]));
            dshoaDon.Add(new HoaDon("HD7579N", "Ngày 2021-05-23 lúc 08:38:35", 5, dskhach[16], dsmayTinh[40], dsdichVu[3], dsnhanVien[7]));
            dshoaDon.Add(new HoaDon("HD3559N", "Ngày 2020-12-02 lúc 11:11:01", 3, dskhach[18], dsmayTinh[30], dsdichVu[5], dsnhanVien[1]));

            dshoaDon.Add(new HoaDon("HD7950N", "Ngày 2020-12-17 lúc 05:35:27", 5, dskhach[6], dsmayTinh[33], dsdichVu[3], dsnhanVien[8]));
            dshoaDon.Add(new HoaDon("HD4401N", "Ngày 2020-12-28 lúc 03:57:06", 1, dskhach[16], dsmayTinh[39], dsdichVu[0], dsnhanVien[3]));
            dshoaDon.Add(new HoaDon("HD7527N", "Ngày 2020-11-30 lúc 23:40:12", 3, dskhach[7], dsmayTinh[13], dsdichVu[2], dsnhanVien[7]));
            dshoaDon.Add(new HoaDon("HD7514N", "Ngày 2020-12-30 lúc 19:38:03", 5, dskhach[16], dsmayTinh[24], dsdichVu[3], dsnhanVien[6]));
            dshoaDon.Add(new HoaDon("HD2223N", "Ngày 2021-05-04 lúc 15:52:08", 4, dskhach[11], dsmayTinh[28], dsdichVu[4], dsnhanVien[2]));
            dshoaDon.Add(new HoaDon("HD3497N", "Ngày 2021-06-19 lúc 02:26:18", 6, dskhach[2], dsmayTinh[24], dsdichVu[0], dsnhanVien[9]));
        }
        public static void linQ_0()
        {
            Console.WriteLine("----------------------------------LinQ_0----------------------------------");
            var list = from kh in dskhach
                       where string.Compare(kh.tenKH, "Thái Kim Huỳnh", true) == 0
                       select new
                       {
                           kh.tenKH,
                           kh.tuoi,
                       };
            if (list.Count() == 0)
            {
                Console.WriteLine("Khong tim thay khach hang ");
                return;
            }
            foreach (var i in list)
            {
                Console.WriteLine("[{0}] - {1} ", i.tenKH, i.tuoi);
            }
        }
        public static void linQ_1()
        {
            Console.WriteLine("----------------------------------LinQ_1----------------------------------");
            Console.WriteLine("                 <Liệt kê những khách hàng trên 20 tuổi>");
            var x = from p in dskhach
                    where p.tuoi > 20
                    select p;
            if(x.Count()==0)
            {
                Console.WriteLine("Khong tim thay khach hang nhu yeu cau");
            }
            else
                foreach(var dskh in x)
                {
                    Console.WriteLine("[{0}]",dskh.tenKH);
                }
        }
        public static void linQ_2()
        {
            Console.WriteLine("----------------------------------LinQ_2----------------------------------");
            Console.WriteLine("   <Hãy cho biết thông tin hóa đơn của khách hàng “Phạm Lê Thiên Phú”>");
            var list = from p in dshoaDon
                       where string.Compare(p.idmaKH.tenKH, "Phạm Lê Thiên Phú", true) == 0
                       select new
                       {
                           p.idmaHD,
                           p.thoigian,
                           p.soGioThue,
                           
                           p.idmaMayTinh.tenMayTinh,
                           p.idmaDV.tenDV,
                           p.idmaNV.tenNV,
                       };
            if (list.Count() == 0)
            {
                Console.WriteLine("Không tìm thấy thông tin hóa đơn của khách hàng như yêu cầu");
            }
            else
                foreach (var x in list)
                {
                    Console.WriteLine("Mã hóa đơn: {0}",x.idmaHD);
                    Console.WriteLine("Thời gian lập hóa đơn: {0}", x.thoigian);
                    Console.WriteLine("Số giờ thuê: {0}h", x.soGioThue);
                    //Console.WriteLine("Mã khách hàng:{0}", x.idmaKH);
                    Console.WriteLine("Tên máy tính: {0}", x.tenMayTinh);
                    Console.WriteLine("Tên dịch vụ: {0}", x.tenDV);
                    Console.WriteLine("Tên nhân viên: {0}", x.tenNV);
                }
        }
        public static void linQ_3()
        {
            Console.WriteLine("----------------------------------LinQ_3----------------------------------");
            Console.WriteLine("     <Cho biết tổng số giờ thuê của khách hàng “Trần Thị Ngọc Anh”>");
            var list = from x in dshoaDon
                       where string.Compare(x.idmaKH.tenKH, "Trần Thị Ngọc Anh", true) == 0
                       group x by x.idmaKH.tenKH into c
                       select new
                       {
                           Tong=c.Sum(g=>g.soGioThue)
                       };
            if(list.Count()==0)
            {
                Console.WriteLine("Không tìm thấy thông tin khách hàng");
            }
            foreach(var x in list) 
            {
                Console.WriteLine("Tổng số giờ thuê là: {0}", x.Tong);
            }
        }
        public static void linQ_4()
        {
            Console.WriteLine("----------------------------------LinQ_4----------------------------------");
            Console.WriteLine("<Hãy cho biết thông tin những hóa đơn mà nhân viên “Lê Thị Mỹ Linh” đã lập>");
            var list = from hd in dshoaDon
                       where string.Compare(hd.idmaNV.tenNV, "Lê Thị Mỹ Linh", true) == 0
                       select new
                       {
                           hd.idmaHD,
                           hd.thoigian,
                           hd.soGioThue,
                           hd.idmaKH.tenKH,
                           hd.idmaMayTinh.tenMayTinh,
                           //hd.idmaDV.tenDV,
                           hd.idmaNV.tenNV,
                       };
            if(list.Count()==0)
            {
                Console.WriteLine("Không tìm thấy thông tin hóa đơn mà nhân viên Lê Thị Mỹ Linh đã lập");
            }
            else
                foreach(var x in list)
                {
                    Console.WriteLine("Mã hóa đơn: {0}", x.idmaHD);
                    Console.WriteLine("Thời gian lập hóa đơn: {0}", x.thoigian);
                    Console.WriteLine("Số giờ thuê: {0}h", x.soGioThue);
                    Console.WriteLine("Tên khách hàng:{0}", x.tenKH);
                    Console.WriteLine("Tên máy tính: {0}", x.tenMayTinh);
                    //Console.WriteLine("Tên dịch vụ: {0}", x.tenDV);
                    Console.WriteLine("Tên nhân viên: {0}", x.tenNV);
                }
        }
        public static void linQ_5()
        {
            Console.WriteLine("----------------------------------LinQ_5----------------------------------");
            Console.WriteLine("         <Liệt kê những khách hàng có số giờ thuê trên 3h>");
            var x = from p
                    in dshoaDon //from v in dskhach
                    where p.soGioThue > 3
                    select new
                    {
                        p.idmaKH.tenKH,
                        p.soGioThue,
                    };
            if (x.Count() == 0)
                Console.WriteLine("Không tìm thấy hóa đơn như yêu cầu");
            foreach (var z in x)
            {
                Console.WriteLine(z.tenKH);
            }
        }
        public static void linQ_6()
        {
            Console.WriteLine("----------------------------------LinQ_6----------------------------------");
            Console.WriteLine("                 <Liệt kê những máy tính có trên tầng 2>");
            var list = from x in dsmayTinh
                       where string.Compare(x.maPhong.idmaTang.loaiTang, "Tầng 2", true) == 0
                       select new
                       {
                           x.tenMayTinh,
                       };
            if (list.Count() == 0)
                Console.WriteLine("Không có máy tính trên tầng 2");
            else
                foreach(var x in list)
                {
                    Console.WriteLine(x.tenMayTinh);
                }
        }
        public static void linQ_7()
        {
            Console.WriteLine("----------------------------------LinQ_7----------------------------------");
            Console.WriteLine("         <Cho biết lịch trực phòng của nhân viên “Triệu Nhật Nam”>");
            var list = from tp in dstrucPhong
                       where string.Compare(tp.idmaNV.tenNV, "Triệu Nhật Nam", true) == 0
                       select new
                       {
                           tp.idmaTang.loaiTang,
                           tp.idmaPhong.idmaPhong,
                           tp.thoiGian,
                       };
            if (list.Count() == 0)
            {
                Console.WriteLine("Không tìm thấy lịch trực phòng của nhân viên Triệu Nhật Nam");
            }
            else
                foreach(var x in list)
                {
                    Console.WriteLine(x.loaiTang);
                    Console.WriteLine("Phòng: {0}",x.idmaPhong);
                    Console.WriteLine(x.thoiGian);
                }
        }
        public static void linQ_8()
        {
            Console.WriteLine("----------------------------------LinQ_8----------------------------------");
            Console.WriteLine("           <Cho biết tên những khách hàng thuộc loại khách VIP>");
            var list = from lk in dskhach
                       where string.Compare(lk.idmaLoaiKH.phanloaiKH, "Khách hàng VIP", true) == 0
                       select new
                       {
                           lk.idmaKH,
                           lk.tenKH,
                           lk.tuoi,
                           lk.diaChi,
                           lk.soDT,
                          // lk.idmaLoaiKH,
                       };
            if(list.Count() == 0)
            {
                Console.WriteLine("Không tìm thấy thông tin của khách hàng VIP");
            }
            else
                foreach(var x in list)
                {
                    Console.WriteLine("Mã khách hàng: {0}",x.idmaKH);
                    Console.WriteLine("Tên khách hàng: {0}",x.tenKH);
                    Console.WriteLine("Tuổi: {0}",x.tuoi);
                    Console.WriteLine("Địa chỉ: {0}",x.diaChi);
                    Console.WriteLine("Số điện thoại: {0}",x.soDT);
                    
                }
        }
        public static void linQ_9()
        {
            Console.WriteLine("----------------------------------LinQ_9----------------------------------");
            Console.WriteLine("                   <Cho biết tổng số máy ở các tầng>");
            var list = from m in dsmayTinh
                       from v in dsphong         
                       where m.maPhong.idmaPhong==v.idmaPhong
                       group m by m.maPhong.idmaTang into c
                       select new
                       {
                           tang = c.Key,
                           Tong = c.Select(g => g.idmaMayTinh).Distinct().Count()
                       };
            foreach(var x in list)
            {
                Console.WriteLine("{0} có số máy là: {1}", x.tang.loaiTang, x.Tong);                    
            }
        }
        public static void linQ_10()
        {
            Console.WriteLine("----------------------------------LinQ_10----------------------------------");
            Console.WriteLine(" <Hãy cho biết tên và số điện thoại cả các nhân viên đã từng trực tại phòng P08>");
            var list = from x in dstrucPhong
                       where x.idmaPhong.idmaPhong == "P08"
                       select new
                       {
                           x.idmaNV.tenNV,
                           x.idmaNV.soDT,
                       };
            if(list.Count()==0)
                Console.WriteLine("Không tìm thấy thông tin nhân viên trực tại phòng P08");
            else
                foreach(var x in list)
                {
                    Console.WriteLine("Nhân viên {0}: {1}", x.tenNV, x.soDT);
                }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            taoDSLoaiKhach();
            taoDSLoaiPhong();
            taoDSLoaiDV();
            taoDSLoaiMay();
            taDSNhanVien();
            taoDSTang();
            taoDSKhachHang();       
            taoDSPhong();
            taoDSMayTinh();          
            taoDSDV();          
            taoDSHoaDon();
            taoDSChiTietHoaDon();
            taoDSTrucPhong();
            //linQ_0();
            linQ_1();
            linQ_2();
            linQ_3();
            linQ_4();
            linQ_5();
            linQ_6();
            linQ_7();
            linQ_8();
            linQ_9();
            linQ_10();
        }
    }
}