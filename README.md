# AutoAction
Tool xây dựng kịch bản cho PC tự làm việc
----
Hướng dẫn
B1. Tải bản released mới nhất
B2. Cài Python 2.x hoặc 3.x
B3. Chạy file install.bat (Máy phải có công cụ pip của python)
B4. Sử dụng AutoActionLauncher.exe
----
<p>
  Công cụ script được thiết kế mở rộng từ ngôn ngữ Python
 </p>
----
<p>Hướng dẫn các hàm Auto Call</p>
<p><b>Lưu ý: các tham số có dấu bằng cho phép không cần truyền đối số nếu không cần sử dụng</b></p>
<p><b>void CallLeftClick(int x, int y, int delay = 0, int time = 1, float interval = 0)</b> : Nhấp chuột trái tại điểm (x,y) trên màn hình với thời gian nhấp là delay, số lần nhấp là time và khoảng thời gian giữa các lần nhấp là interval giây</p>
<p><b>void CallRightClick(int x, int y, int delay =0, int time = 1, float interval = 0)</b></p>
<p><b>void CallMiddleClick(int x, int y, int delay =0, int time = 1, float interval = 0)</b></p>
<p><b>void CallClick(int x, int y, str button = "left", int delay = 0, int time = 1, float interval = 0)</b>: Nhấp chuột button tại điểm x, y với thời gian nhấp là delay, số lần nhấp là time, khoảng thời gian chờ giữa các lần nhấp là interval giây</p>
<p><b>void CallKeyboardClick(str data, int delay = 0) </b>: Gõ các phím trong chuỗi data với thời gian chờ giữa các phím là delay giây</p>
<p><b>void CallHotkey(str firstKey, str secondKey="")</b>: Gõ các phím nóng ctrl, shift, alt, f1, f2,... và các tổ hợp phím</p>
<p><b>void CallProcess(str command, str args) </b>: Gọi các lệnh command với đối số args</p>
<p><b>void CallProcessWait(str command, str args)</b> : Gọi các lệnh command với đối số args, script sẽ đợi đến khi process đó chạy xong</p>
<p><b>void CallWait(int second) </b>: Dừng script trong second giây</p>
<p><b>str MakeMessage(str text, bool alert = True, str title ="")</b>: Hiển thị thông báo text tựa đề title. Nếu alert = False thì hàm trả về str nhập vào từ user</>
<p><b>int,int GetPos()</b>:  Trả về vị trí hiện tại của con trỏ chuột</p>
<p><b>int,int GetSize()</b>: Trả về kích thước màn hình</p>
<p><b>void CallMoveMouse(int x, int y, bool rel = False)</b>: Di chuyển chuột đến x, y tính từ góc trên cùng bên trái màn hình. Nếu rel = True thì x, y được cộng thêm vào vị trí hiện tại</p>
<p><b>void CallScrollV(int x, int y, int amount)</b>: cuộn chuột amount lần lên xuống (vertical) tại điểm x, y</p>
<p><b>void CallScrollH(int x, int y, int amount)</b>: cuộn chuột amount lần trái phải (horizontal) tại điểm x, y</p>
<p>Tất cả các cấu trúc và câu lệnh của python đều được chấp nhận</p>
