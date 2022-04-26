using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTL2
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // tạo các tài khoản admin
            Application["Users"] = new List<Nguoidung>();
            List<Nguoidung> Users =( List < Nguoidung >) Application["Users"];
            Users.Add(new Nguoidung("TruongDong", "dong@gmail.com", "123456789", "2352002"));
            Users.Add(new Nguoidung("Nguyenkien", "kien@gmail.com", "123456789", "2010A021"));
            Users.Add(new Nguoidung("Haidoan", "doan@gmail.com", "123456789", "2010A022"));


            //tạo danh sách các sản phẩm
            Application["ProductList"] = new List<Product>();
            List<Product> ProductList = new List<Product>();

            //Sản Phẩm Bán Chạy 
            ProductList.Add(new Product() { Id = "1", Images = "Anh/Anh8.jpg", Name = "THÚC ĐẨY GIAO TIẾP", Gia = "67000", tieude = "Nâng cao tầm hiểu biết cho bản thân ,cải thiện kỹ năng nói chuyện với người đối diện." });
            ProductList.Add(new Product() { Id = "2", Images = "Anh/Anh2.jpg", Name = "36 THÓI QUEN CẦN TRÁNH ĐỂ TRẺ THỰC SỰ TRƯỞNG THÀNH", Gia = "83000", tieude = "Giúp Hoàn Thiện Bản Thân trở nên có bản lĩnh trong cuộc sống" });
            ProductList.Add(new Product() { Id = "3", Images = "Anh/Anh11.jpg", Name = "XÔN XAO ĐẦU ĐỜI - GIA ĐÌNH BẠN, GIA ĐÌNH TỚ", Gia = "55000", tieude = "Gia Đình Tớ - Bố, mẹ, anh chị em là gia đình của bé. Ông bà nội, ông bà ngoại,..." });
            ProductList.Add(new Product() { Id = "4", Images = "Anh/Anh1.jpg", Name = "21 NGÀY KHÁM PHÁ MINDMAP", Gia = "99000", tieude = "Cuốn sách giúp bạn từ người mới học trở thành người vận dụng thành thạo sơ đồ tư duy." });
            ProductList.Add(new Product() { Id = "5", Images = "Anh/Anh3.jpg", Name = "CUỐN SÁCH NHỎ - Ý NGHĨA LỚN", Gia = "70000", tieude = "Bộ sách bao gồm các bài chia sẻ sách hay, các sáng tác giàu giá trị nhân văn, các tác phẩm thuyết minh về sách..." });
            ProductList.Add(new Product() { Id = "6", Images = "Anh/Anh4.jpg", Name = "ĐIÊU KHẮC CUỘC ĐỜI", Gia = "60200", tieude = "Điêu Khắc Cuộc Đời - Cuốn sách giúp bạn không còn hoang mang mơ hồ, không còn lực bất tòng tâm nữa, bạn sẽ trở thành một người đơn giản" });
            ProductList.Add(new Product() { Id = "7", Images = "Anh/Anh7.jpg",Name="Phương Pháp đọc Tiếng Anh lưu loát",Gia="100000", tieude = "Chỉ cần bạn kiên trì cố gắng và dành ra 30 phút mỗi ngày thì việc giao tiếp tự tin như người bản xứ sẽ không còn là ước mơ xa vời.PHƯƠNG PHÁP LUYỆN NÓI TIẾNG ANH LƯU LOÁT" });
            ProductList.Add(new Product() { Id = "8", Images = "Anh/Anh9.jpg", Name = "TIKTOK TẤT TẦN TẬT", Gia = "126000", tieude = "Cuốn sách này dành cho các nhà marketing, sinh viên và ngành marketing và tất cả mọi người, những ai muốn chinh phục nền tảng đang làm mưa làm gió khắp thế giới." });
            ProductList.Add(new Product() { Id = "9", Images = "Anh/Anh5.jpg", Name = "ĐIỀU KỲ DIỆU CỦA VẬN ĐỘNG", Gia = "99000", tieude = "uốn sách này sẽ giúp bạn biết phòng bệnh, biết chăm sóc sức khỏe cho chính bạn và những người trong gia đình. Mỗi câu chuyện thường bắt nguồn từ mỗi gia đình người Việt Nam chúng ta" });
            ProductList.Add(new Product() { Id = "10", Images = "Anh/Anh10.jpg", Name = "VIỆT NAM DANH TÁC - TIÊU SƠN TRÁNG SĨ", Gia = "70000", tieude = "Một truyện lịch sử, quân sự và cũng là câu chuyện mang hơi hướng tiểu thuyết kiếm hiệp trong bối cảnh thời Lê mạt Nguyễn sơ" });
            // Sản phẩm phổ Biến
            ProductList.Add(new Product() { Id = "11", Images = "Anh/phobien/99baitoan.jpg", Name = "99 Ngày Em Giỏi Toán ", Gia = "76000", tieude = "99 Ngày Em Giỏi Toán Lớp 4 là một cuốn sách tuyệt vời giúp các em vượt qua một năm lớp 4 nhiều kiến thức hơn so với ba năm đầu tiên của cấp Tiểu học. Việc học toán sẽ nhẹ nhàng, dễ dàng và hiệu quả hơn nhiều." });
            ProductList.Add(new Product() { Id = "12", Images = "Anh/phobien/250baivanhay.jpg", Name = "250 Bài Văn Hay", Gia = "32000", tieude = "250 Đề Và Bài Văn Hay Lớp 2 (Biên Soạn Theo Chương Trình GDPT Mới) - Làm văn là một phần quan trọng của môn học Tiếng Việt ở Tiểu học. Làm văn có tính chất quyết định trong việc đánh giá kết quả học tập bộ môn Tiếng Việt." });
            ProductList.Add(new Product() { Id = "13", Images = "Anh/phobien/boiduonghsg.jpg ", Name = "Bồi Dưỡng Học Sinh Giỏi Sinh", Gia = "70000", tieude = "Combo Sách Hay Của Phan Khắc Nghệ: Bồi Dưỡng Học Sinh Giỏi Sinh Học 11 Câu Hỏi Và Bài Tập Trắc Nghiệm Sinh Học 11 (Bộ 3 Cuốn) giúp các em nắm vững lý thuyết và kĩ năng giải bài tập sinh học" });
            ProductList.Add(new Product() { Id = "14", Images = "Anh/phobien/dethi10.jpg", Name = " Bộ Đề Thi Tuyển Sinh Vào 10 Môn Tiếng Anh", Gia = "57000", tieude = "Nội dung cuốn sách Bộ Đề Thi Tuyển Sinh Vào Lớp 10 Môn Tiếng Anh được biên soạn bám sát theo cấu trúc đề thi tuyển sinh vào lớp 10 THPT do SGD và Đào tạo TPHCM công bố, và chương trình Tiếng Anh bậc THCS, chủ yếu ở lớp 9." });
            ProductList.Add(new Product() { Id = "15", Images= "Anh/phobien/cuuxunhudanong.jpg", Name="Cư Xử Như Đàn Ông",Gia="51000",tieude= "Combo Cư Xử Như Người Thành Công, Suy Nghĩ Như Người Thành Đạt + Cư Xử Như Đàn Bà, Suy Nghĩ Như Đàn Ông (Bộ 2 Cuốn) - Bộ sách đem tới cho độc giả sự thấu suốt, niềm hứng khởi và một trải nghiệm đọc đáng giá." });
            ProductList.Add(new Product() { Id = "16", Images = "Anh/phobien/hinhkk.jpg", Name = "Hình Học Không Gian Lớp 11", Gia = "98000", tieude = "Mỗi cuốn trong bộ sách TOP 1 MÔN TOÁN tương ứng một chương trong chương trình sách giáo khoa Toán 12. Chúng tôi khẳng định đây là bộ sách đầy đủ nhất, chuyên sâu nhất để học Toán 12 và luyện thi Tốt Nghiệp THPT." });
            ProductList.Add(new Product() { Id = "17", Images = "Anh/phobien/lamchutuduy.jpg", Name = "Làm Chủ Tư Duy", Gia = "98000", tieude = "Combo Xoay Tư Duy Chuyển Cuộc Đời + Làm Chủ Tư Duy, Thay Đổi Vận Mệnh (Bộ 2 Cuốn) - Bộ sách chia sẻ với bạn những phương pháp hiệu quả và thực tiễn mà bạn có thể áp dụng và thành công." });
            ProductList.Add(new Product() { Id = "18", Images = "Anh/phobien/nhansucotcan.jpg", Name = "Nhân Sự Cốt Cán", Gia = "127000", tieude = "Nhân Sự Cốt Cán là mạch máu của mọi tổ chức: họ phát minh, lãnh đạo (bất kể chức danh nào), kết nối mọi người, làm cho mọi thứ xảy ra và tạo ra trật tự thoát khỏi sự hỗn loạn." });
            ProductList.Add(new Product() { Id = "19", Images = "Anh/phobien/25thoiquentot.jpg", Name = "25 Thói Quen Tốt Để Thành Công", Gia = "54000", tieude = "Trang Bị Cho mọi người kiến thức về con người giúp hoàn thiện nhân cách của bản thân" });
            //  Sản phẩm  kỹ năng sống
            ProductList.Add(new Product() { Id = "20", Images = "Anh/Kynangsong/danongsaohoa.jpg", Name = "Đàn Ông Sao Hỏa", Gia = "150000", tieude = "Đàn Ông Sao Hỏa - Đàn Bà Sao Kim (Classic Edition) thực sự đã giúp đỡ cho hàng triệu độc giả, trong đó có tôi và chắc chắn cũng sẽ có bạn." });
            ProductList.Add(new Product() { Id = "21", Images = "Anh/Kynangsong/lmchucamxuc.jpg", Name = "Làm Chủ Cảm Xúc", Gia = "82000", tieude = "Đời Hạnh Phúc Khi Làm Chủ Cảm Xúc - Cuốn sách nhẹ nhàng dẫn người đọc vào thế giới của những hỷ, nộ, ái, ố để bắt đầu “cuộc chơi” của cảm xúc và lý trí." });
            ProductList.Add(new Product() { Id = "22", Images = "Anh/Kynangsong/suynghinhudanong.jpg", Name = "SUY NGHĨ NHƯ ĐÀN ÔNG", Gia = "87000", tieude = "Với cách viết dễ chịu như trò chuyện, tăng gia vị bằng sự hài hước của một ngôi sao hài kịch, Steve Harvey trong Cư xử như đàn bà, suy nghĩ như đàn ông giống một người bạn thân hơn là một chuyên gia tâm lý." });
            ProductList.Add(new Product() { Id = "23", Images = "Anh/Kynangsong/thauhieuchinhminh.jpg", Name = "Thấu Hiểu Chính Mình", Gia = "72000", tieude = "Thấu Hiểu Chính Mình - Cuốn sách sẽ giúp chúng ta nhận biết và nuôi dưỡng sức mạnh trong mình, từ đó học cách yêu thương bản thân và tạo dựng một cuộc sống tràn đầy ý nghĩa." });
            ProductList.Add(new Product() { Id = "24", Images = "Anh/Kynangsong/thietketuonglai.jpg", Name = "Thiết Kế Sự Nghiệp Tương Lai", Gia = "81000", tieude = "Thiết Kế Sự Nghiệp Tương Lai - Cuốn sách cung cấp những công cụ và phương pháp giúp bạn khai phá tiềm năng của chính mình." });
            ProductList.Add(new Product() { Id = "25", Images = "Anh/Kynangsong/tuoitredanggiabaonhieu.jpg", Name = "Tuổi Trẻ Đáng Giá Bao Nhiêu", Gia = "72000", tieude = "Tuổi Trẻ Đáng Giá Bao Nhiêu - Là cuốn sách về kỹ năng sống của tác giả Rosie Nguyễn. Cuốn sách thôi thúc bạn hãy sống thật ý nghĩa, làm những gì trái tim mách bảo." });
            ProductList.Add(new Product() { Id = "26", Images = "Anh/Kynangsong/tutuongconnguoi.jpg", Name = "Tư Tưởng Con Người", Gia = "215000", tieude = "Vượt Qua Sợ Hãi - Tư Tưởng Và Con Người Aung San Suu Kyi Qua Các Bài Viết - Những bài luận chặt chẽ, đanh thép của bà cùng những bài viết về bà sẽ giúp ta thấu hiểu suối nguồn của hệ thống qian điểm chính trị cũng như sức mạnh tinh thần phi thường nơi người phụ nữ này." });
            ProductList.Add(new Product() { Id = "27", Images = "Anh/Kynangsong/dichbenh.jpg", Name = "DỊCH BỆNH ATLANTIS", Gia = "72000", tieude = "Dịch Bệnh Atlantis - Một đại dịch đã được ấp ủ 70.000 năm." });
            ProductList.Add(new Product() { Id = "28", Images = "Anh/Kynangsong/bikipsinhton.jpg", Name = "SINH TỒN THỜI KỸ THUẬT SỐ", Gia = "102000", tieude = "Nghệ Thuật Kiêng Khem Tin Tức - Bí Kíp Sinh Tồn Thời Kỹ Thuật Số - Cuốn sách này có thể coi là một kim chỉ nam cho con người trong một thời đại đổi thay nhanh hơn bao giờ hết." });
            ProductList.Add(new Product() { Id = "29", Images = "Anh/Kynangsong/tuoitrebaolau.jpg", Name = "TUỔI TRẺ CÓ BAO LÂU MÀ HỮNG HỜ", Gia = "79200", tieude = "Tuổi Trẻ Có Bao Lâu Mà Hững Hờ - Cuốn sách không chắc sẽ giúp bạn gỡ rối tơ lòng hay vượt qua những âu lo để trưởng thành và khôn ngoan hơn, nhưng những trang viết chân thực sẽ lắng nghe bạn, an ủi trái tim bạn, và nhen nhóm niềm tin trong bạn, cùng bạn sống ý nghĩa hơn." });
            ProductList.Add(new Product() { Id = "30", Images = "Anh/Kynangsong/khampha.jpg", Name = "21 NGÀY KHÁM PHÁ MINDMAP", Gia = "87500", tieude = "21 Ngày Khám Phá Mindmap - Cuốn sách giúp bạn từ người mới học trở thành người vận dụng thành thạo sơ đồ tư duy." });
            // Sản phẩm tiếng anh
            ProductList.Add(new Product() { Id = "31", Images = "Anh/Sachtienganh/ta1.jpg", Name = "TỪ VỰNG ĐẮT ĐỂ ĐẠT ĐIỂM CAO 4 KỸ NĂNG",Gia = "108000",tieude = "Từ Vựng IELTS 8.0 - Từ Vựng Đắt Để Đạt Điểm Cao 4 Kỹ Năng - Là cuốn sách tổng hợp 15 chủ đề Từ vựng chất lượng giúp bạn đạt điểm cao cả 4 kỹ năng IELTS."});
            ProductList.Add(new Product() { Id = "32",Images = "Anh/Sachtienganh/ta2.jpg", Name = "TỰ HỌC TIẾNG PHÁP TRONG 24 GIỜ",Gia = "72000",tieude = "Tự Học Tiếng Pháp Trong 24 Giờ - Nếu bạn sẵn lòng dành 24 tiếng đồng hồ trong quỹ thời gian của bạn để học ngữ pháp, từ vựng, và các cụm từ được trình bày trong cuốn sách này, bạn sẽ thấy rằng bạn có thể hiểu và giao tiếp tiếng Pháp trong các tình huống thường ngày."});
            ProductList.Add(new Product() { Id = "33",Images = "Anh/Sachtienganh/ta3.jpg", Name = "TÔI MUỐN GIỎI TIẾNG ANH ",Gia = "168000",tieude = "Tôi Muốn Giỏi Tiếng Anh Nhưng Không Muốn Chăm Chỉ - Thay vì nghĩ mình phải học thuộc lòng từng từ một, hãy đọc sách một cách vui vẻ là được. Trong khi nhẹ nhàng lật giở từng trang sách, bạn đã tự động ghi nhớ được tới gần 1.000 từ vựng tiếng Anh rồi đó!"});
            ProductList.Add(new Product() { Id = "34",Images = "Anh/Sachtienganh/ta4.jpg", Name = "500 CÂU ĐÀM THOẠI TIẾNG HOA",Gia = "71280",tieude = "10 Ngày Tự Tin Giao Tiếp 500 Câu Đàm Thoại Tiếng Hoa - Gồm 10 chủ đề Giao tiếp cơ bản hằng ngày trong cuộc sống sinh hoạt đời thường như: Giới thiệu bản thân, chào hỏi, giới thiệu gia đình, bạn bè, diễn đạt thời gian, ăn uống, mua sắm, hỏi đường..."});
            ProductList.Add(new Product() { Id = "35",Images = "Anh/Sachtienganh/ta5.jpg", Name = "GIAO TIẾP TIẾNG ANH KHÔNG HỀ KHÓ",Gia = "319200",tieude = "Crushing English - Giao Tiếp Tiếng Anh Không Hề Khó - Cuốn sách sẽ là một giải pháp trọn bộ giúp những bạn đang còn gặp khó khăn trong việc học giao tiếp tiếng Anh sẽ đạt được điều mình mong muốn. Vậy cuốn sách này có gì?"});
            ProductList.Add(new Product() { Id = "36",Images = "Anh/Sachtienganh/ta6.jpg", Name = "TIẾNG HÀN CHO DU LỊCH",Gia = "89250",tieude = "Tiếng Hàn Cho Du Lịch - Để tránh khỏi bỡ ngỡ và lạc lõng ở xứ sở kim chi này, các bạn hãy tập trung nói những câu giao tiếp bằng tiếng Hàn thông dụng nhất khi du lịch có trong cuốn bí kíp hữu dụng này nhé."});
            ProductList.Add(new Product() { Id = "37",Images = "Anh/Sachtienganh/ta7.jpg", Name = "HỘI THOẠI GIAO TIẾP TIẾNG NHẬT",Gia = "132000",tieude = "Bộ Sách Dành Cho Người Tự Học - Hội Thoại Giao Tiếp Tiếng Nhật - Cuốn sách không chỉ giúp bạn học được thật nhiều từ mới, mẫu câu mà còn giúp bạn hiểu biết thêm về văn hóa của đất nước và con người Nhật Bản."});
            // sản phẩm trang văn học
            ProductList.Add(new Product() { Id = "40",Images = "Anh/sachvanhoc/van1.jpg", Name = "TÔ BÌNH YÊN VẼ HẠNH PHÚC",Gia = "58500",tieude = "Tô Bình Yên Vẽ Hạnh Phúc là một cuốn sách mà độc giả vừa tìm được “Hạnh phúc to to từ những điều nho nhỏ” vừa được thực hành ngay lập tức. Một sự kết hợp mới lạ đầy thú vị giữa thể loại sách tản văn và sách tô màu."});
            ProductList.Add(new Product() { Id = "41",Images = "Anh/sachvanhoc/van2.gif", Name = "HARRY POTTER VÀ ĐỨA TRẺ BỊ NGUYỀN RỦA",Gia = "120000",tieude = "Harry Potter Và Đứa Trẻ Bị Nguyền Rủa: Phần Một Và Hai đưa Phù thủy nổi tiếng thế giới quay lại dựa trên vở kịch mới của tác giả Rowling trong bối cảnh 19 năm sau khi Harry là Giám đốc Sở Thần Sáng."});
            ProductList.Add(new Product() { Id = "42",Images = "Anh/sachvanhoc/van3.jpg", Name = "THƯ TÌNH GỬI MỘT NGƯỜI",Gia = "185250",tieude = "Thư Tình Gửi Một Người gồm toàn bộ thư từ và hình ảnh liên quan mà nhạc sĩ Trịnh Công Sơn đã gửi cho Ngô Vũ Dao Ánh – người con gái đã là nhân vật trong nhiều khúc tình ca của nhạc sĩ từ năm 1964 đến năm 1989."});
            ProductList.Add(new Product() { Id = "43",Images = "Anh/sachvanhoc/van4.jpg", Name = "CÂY CAM NGỌT CỦA TÔI",Gia = "86400",tieude = "Cây Cam Ngọt Của Tôi - Cuốn sách kinh điển này bởi thế không ngừng khiến trái tim người đọc khắp thế giới thổn thức, kể từ khi ra mắt lần đầu năm 1968 tại Brazil."});
            ProductList.Add(new Product() { Id = "44",Images = "Anh/sachvanhoc/van5.jpg", Name = "HONG TAY KHÓI LẠNH",Gia = "76500",tieude = "Hong Tay Khói Lạnh - Độc lập nhưng lại kết nối với nhau bởi nơi chốn giả lập và chủ điểm về nỗi cô độc trong tinh thần, các câu chuyện. Một lần nữa, lại cho thấy tài năng, sức tưởng tượng, sự nhạy cảm và đồng cảm hiếm có của Nguyễn Ngọc Tư trước tâm trạng chung của con người giữa những biến động lớn của đời sống."});
            ProductList.Add(new Product() { Id = "45",Images = "Anh/sachvanhoc/van6.png", Name = "MẮT BIẾC (BÌA MỀM)",Gia = "93500",tieude = "Một tác phẩm được nhiều người bình chọn là hay nhất của nhà văn này. Một tác phẩm đang được dịch và giới thiệu tại Nhật Bản (theo thông tin từ các báo)…"});
            Application["ProductList"] = ProductList;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["login"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}