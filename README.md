# Database-Management-System QUẢN LÝ BÁN VÉ MÁY BAY
## 1.Chức năng
Để sử dụng phần mềm, người dùng cần đăng nhập vào hệ thống. Người dùng gồm có hai loại: dành cho nhân viên và quản lý.

Đối với Nhân viên:
Bán vé máy bay:
-	Mua vé: Nhân viên có thể thực hiện giao dịch mua vé cho khách hàng. Họ nhập thông tin khách hàng và chọn chuyến bay, hạng vé cùng với số lượng vé cần mua.
-	Hủy vé: Nếu cần, nhân viên có thể hủy vé cho khách hàng. Họ cần xác định vé cần hủy dựa trên thông tin giao dịch ban đầu.
-	Tìm kiếm: Nhân viên có khả năng tìm kiếm thông tin về chuyến bay, giá vé và tình trạng vé cho việc tư vấn và bán vé.
Tra cứu chuyến bay:
-	Tìm kiếm: Nhân viên có thể tra cứu thông tin về chuyến bay, bao gồm lịch trình, sân bay đi và đến, số ghế trống và các chi tiết liên quan để cung cấp cho khách hàng.

Đối với Quản lý:

Bán vé máy bay:
-	Mua vé: Quản lý có thể thực hiện các giao dịch mua vé giống như nhân viên để hỗ trợ khách hàng hoặc xem lịch sử giao dịch.
-	Hủy vé: Quản lý có thể thực hiện việc hủy vé cho khách hàng và xem thông tin chi tiết về các giao dịch hủy vé.
-	Tìm kiếm: Tương tự như nhân viên, quản lý có khả năng tìm kiếm thông tin về chuyến bay và vé.
Tra cứu chuyến bay:
-	Tìm kiếm: Quản lý có thể tìm kiếm thông tin về chuyến bay để cung cấp cho khách hàng hoặc theo dõi lịch trình chuyến bay.
Báo cáo:
-	Xem báo cáo: Quản lý có quyền truy cập vào các báo cáo về doanh số bán hàng, lịch sử đặt vé, tỷ lệ sử dụng ghế trống và các thống kê khác để đánh giá hiệu suất kinh doanh.
Quản lý chuyến bay:
-	Thêm, xóa, sửa: Quản lý có thể thêm mới, xóa hoặc chỉnh sửa thông tin về các chuyến bay, bao gồm lịch trình, sân bay đi và đến, số lượng ghế trống và các chi tiết khác.
-	Tìm kiếm: Quản lý có khả năng tìm kiếm thông tin về chuyến bay để quản lý và điều chỉnh các thông tin cụ thể.
Quản lý đơn giá:
-	Thêm, xóa, sửa: Quản lý có quyền thêm mới, xóa hoặc chỉnh sửa các thông tin về đơn giá vé theo từng tuyến bay và hạng vé.
-	Tìm kiếm: Quản lý có khả năng tìm kiếm thông tin về đơn giá vé để điều chỉnh và cập nhật.
Quản lý hạng vé:
-	Thêm, xóa, sửa: Quản lý có thể quản lý thông tin về các hạng vé, bao gồm tên, mô tả và các điều kiện của hạng vé.
-	Tìm kiếm: Quản lý có khả năng tìm kiếm thông tin về hạng vé để cập nhật và quản lý.
Quản lý tuyến bay:
-	Thêm, xóa, sửa: Quản lý có thể quản lý thông tin về các tuyến bay, bao gồm điểm đi và điểm đến, thời gian bay và các chi tiết khác.
-	Tìm kiếm: Quản lý có khả năng tìm kiếm thông tin về tuyến bay để điều chỉnh và cập nhật.
Quản lý sân bay:
-	Thêm, xóa, sửa: Quản lý có quyền quản lý thông tin về các sân bay, bao gồm tên, địa chỉ và các thông tin liên quan khác.
-	Tìm kiếm: Quản lý có khả năng tìm kiếm thông tin về sân bay để quản lý và cập nhật.
Quản lý máy bay:
-	Thêm, xóa, sửa: Quản lý có thể quản lý thông tin về các máy bay, bao gồm tên, loại máy bay và các chi tiết liên quan khác.
-	Tìm kiếm: Quản lý có khả năng tìm kiếm thông tin về máy bay để điều chỉnh và cập nhật.
Quản lý nhân viên:
-	Thêm, xóa, sửa: Quản lý có thể thực hiện quản lý thông tin về nhân viên, bao gồm tên, ngày sinh, giới tính, địa chỉ, số điện thoại, mã công việc, lương, ngày tuyển dụng và các thông tin khác.
-	Tìm kiếm: Quản lý có khả năng tìm kiếm thông tin về nhân viên để quản lý và cập nhật. 
  ## 2.	Diagram
  ![image](https://github.com/thanhtin99/Database-Management-System/assets/95009162/6a2bab65-d88e-4723-8d4c-7aa5d00b1b9f)
  ## 3. Thiết kế các chức năng
  1.View
  
  2.Stored Procedure 
  
  3.Function
  
  4.Transaction
  
  5.Tạo user và phân quyền
  ## 4. Giao diện
1.	Đăng nhập
 ![image](https://github.com/thanhtin99/Database-Management-System/assets/95009162/dc152104-7aeb-4179-9051-06a54ba0fdf4)

2.	Hệ thống
 ![image](https://github.com/thanhtin99/Database-Management-System/assets/95009162/f113af2c-1de9-47ae-867e-e47b278def5c)

3.	Bán vé
![image](https://github.com/thanhtin99/Database-Management-System/assets/95009162/5946617e-6f3f-47a7-ae91-75b646c5b4b5)

4.	Tra cứu chuyến bay
 ![image](https://github.com/thanhtin99/Database-Management-System/assets/95009162/5e11bc04-007a-4cea-ba37-3063c863a69e)

5.	Báo cáo doanh thu
 ![image](https://github.com/thanhtin99/Database-Management-System/assets/95009162/44e8e19f-1328-4335-b071-20a6683e49e7)

6.	Quản lý chuyến bay
 ![image](https://github.com/thanhtin99/Database-Management-System/assets/95009162/3111e316-5213-414a-b0e4-c473f5bb76e9)

7.	Quản lý đơn giá
 ![image](https://github.com/thanhtin99/Database-Management-System/assets/95009162/7a6c1b3d-45a3-4008-aff0-59aa3207b83e)

8.	Quản lý hạng vé
 ![image](https://github.com/thanhtin99/Database-Management-System/assets/95009162/103422cf-df64-4bf1-a6f3-6206b2b38683)

9.	Quản lý tuyến bay
 ![image](https://github.com/thanhtin99/Database-Management-System/assets/95009162/81f8ae72-2f4c-4478-961d-f2aba7f782b4)

10.	 Quản lý sân bay
 ![image](https://github.com/thanhtin99/Database-Management-System/assets/95009162/792cb873-2140-4a37-8a0c-ddafdb33da5c)

11.	 Quản lý máy bay
 ![image](https://github.com/thanhtin99/Database-Management-System/assets/95009162/bfa607be-b4a7-4652-a9c2-0d24b5d355c6)

12.	 Quản lý nhân viên
 ![image](https://github.com/thanhtin99/Database-Management-System/assets/95009162/b9d25e77-abbe-4426-a329-1759d69fe72b)

13.	 Quản lý khách hàng
 ![image](https://github.com/thanhtin99/Database-Management-System/assets/95009162/f64a102b-8999-4ad6-bfbf-56e66023ed6d)




