# AutoAction
Tool xây dựng kịch bản cho PC tự làm việc
----
Hướng dẫn
B1. Tải bản released mới nhất
B2. Cài Python 2.x hoặc 3.x
B3. Chạy file install.bat (Máy phải có công cụ pip của python)
B4. Sử dụng AutoAction.exe
----
<p>
  Công cụ script được thiết kế mở rộng từ ngôn ngữ Python
 </p>
----
<p>Hướng dẫn các hàm Auto Call</p>
<p>void CallLeftClick(int x, int y, int delay) : Nhấp chuột trái tại điểm (x,y) trên màn hình với thời gian nhấp là delay</p>
<p>void CallRightClick(int x, int y, int delay) : Nhấp chuột phải tại điểm (x,y) trên màn hình với thời gian nhấp là delay</p>
<p>void CallMiddleClick(int x, int y, int delay) : Nhấp chuột giữa tại điểm (x,y) trên màn hình với thời gian nhấp là delay</p>
<p>void CallKeyboardClick(str data) : Gõ các phím trong chuỗi data</p>
<p>Các phím đặc biệt: Ctrl: "^", Shift: "+", Alt: "%", Enter: "{ENTER}", Delete: "{DEL}", F1->12: "{F1}"->"{F12}",...</p>
<p>https://msdn.microsoft.com/en-us/library/system.windows.forms.sendkeys.send(v=vs.110).aspx</p>
<p>void CallProcess(str command, str args) : Gọi các lệnh command với đối số args</p>
<p>void CallProcessWait(str command, str args) : Gọi các lệnh command với đối số args, script sẽ đợi đến khi process đó chạy xong</p>
<p>void CallWait(int millisecond) : Dừng script trong millisecond mili giây</p>
<p>Tất cả các cấu trúc và câu lệnh của python đều được chấp nhận</p>
