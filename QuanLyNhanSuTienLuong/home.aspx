<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="QuanLyNhanSuTienLuong.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
        width: 1358px;
        height: 327px;
            margin-right: 0px;
        }
        .auto-style3 {
            width: 1362px;
            height: 17px;
        }
        .auto-style4 {
            float: left;
            width: 91%;
        }
        .auto-style5 {
            width: 1364px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="w3-main" style="margin-left:300px;margin-top:43px;">

  <!-- Header -->
  <header class="w3-container" style="padding-top:22px">
    <h2><b>CHÀO MỪNG BẠN ĐẾN VỚI KLAND</b></h2>
  </header>
    <div class="w3-row-padding w3-margin-bottom">
    
  </div>

     <div class="w3-panel">
    <div class="w3-row-padding" style="margin:0 -16px">

      <div class="w3-twothird">
          <a href="#"><img src="images/banner1.png" alt="" title="" border="0" class="auto-style2" /></a>


      </div>
        <br />
        <br /><br /><br />
        <div class="auto-style4">
        <h5 class="auto-style5"><b>KLAND “GỬI TRỌN NIỀM TIN”</b></h5>
        <h6 class="auto-style3" Width="100%"><b>Công ty CP Kland – hướng tới tương lai trở thành “KGroup” luôn luôn hướng tới những sản phẩm – dịch vụ theo tiêu chuẩn quốc tế để giúp cho khách hàng tạo ra một cuộc sống hoàn toàn mới với phong cách hiện đại, thông minh. Ở mọi lĩnh vực Kland đều hướng tới khách hàng và phát triển thương hiệu bền vững, luôn đón đầu xu hướng tiêu dùng. Kland đã tạo những dấu ấn riêng tại mỗi lĩnh vực kinh doanh, nhanh chóng trở thành tập đoàn kinh tế lớn mạnh sánh vai cùng các tập đoàn kinh tế chủ chốt của nền kinh tế Việt Nam.</b></h6>
      </div></div>
    </div>
  </div>
  <hr>

  <hr>


<div class="w3-panel" class="auto-style1">
    <div class="w3-row-padding" style="margin:0 -16px">

    </div>
  </div>
  <hr>

  <hr> 
  <br>s
  <%--<div class="w3-row-padding w3-margin-bottom">
        <div class="w3-quarter">
          <div class="w3-container w3-red w3-padding-16" >
            <div class="w3-left"><i class="fa fa-comment w3-xxxlarge"></i></div>
            <div class="w3-right">
                <h3>
                     <b><asp:Label ID="lbl_HoSosv" runat="server"></asp:Label></b>
                </h3>
            </div>            
            <div class="w3-clear"></div>
            <h4>Hồ sơ sinh viên</h4>
         </div>

        </div>
        <div class="w3-quarter">
          <div class="w3-container w3-blue w3-padding-16">
            <div class="w3-left"><i class="fa fa-eye w3-xxxlarge"></i></div>
            <div class="w3-right">
              <h3><b>
                  <asp:Label ID="lbl_HoSogv" runat="server"></asp:Label>
              </b></h3>
            </div>
            <div class="w3-clear"></div>
            <h4>Hồ sơ giáo viên</h4>
          </div>
        </div>

        <div class="w3-quarter">
          <div class="w3-container w3-teal w3-padding-16">
            <div class="w3-left"><i class="fa fa-share-alt w3-xxxlarge"></i></div>
            <div class="w3-right">
              <h3><b>
                  <asp:Label ID="lbl_Doantn" runat="server"></asp:Label>
              </b></h3>
            </div>
            <div class="w3-clear"></div>
            <h4>Đồ án tốt nghiệp</h4>
          </div>
        </div>

        <div class="w3-quarter">
          <div class="w3-container w3-orange w3-text-white w3-padding-16">
            <div class="w3-left"><i class="fa fa-users w3-xxxlarge"></i></div>
            <div class="w3-right">
              <h3><b>
                  <asp:Label ID="lbl_socn" runat="server" Text="Label"></asp:Label></b></h3>
            </div>
            <div class="w3-clear"></div>
            <h4>Số chuyên ngành</h4>
          </div>
        </div>
  </div>

  <br>--%>

  <!-- End page content -->
</div>
    <script>
// Get the Sidebar
var mySidebar = document.getElementById("mySidebar");

// Get the DIV with overlay effect
var overlayBg = document.getElementById("myOverlay");

// Toggle between showing and hiding the sidebar, and add overlay effect
function w3_open() {
    if (mySidebar.style.display === 'block') {
        mySidebar.style.display = 'none';
        overlayBg.style.display = "none";
    } else {
        mySidebar.style.display = 'block';
        overlayBg.style.display = "block";
    }
}

// Close the sidebar with the close button
function w3_close() {
    mySidebar.style.display = "none";
    overlayBg.style.display = "none";
}
</script>
         </a>
</asp:Content>
