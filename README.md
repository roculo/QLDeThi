# QLDeThi
 De Thi Trach Nhiem Co So Du Lieu Phan Tan Co Nhung
Chú ý EF dùng trong distrubuted database
Cẩn thuận publication sẽ sinh ra row mới cho các table mang tên rowguid
Cần set rowguid=Guild.NewGuid() để cho nó tự tạo , EF ko thể tự tạo cái này.
