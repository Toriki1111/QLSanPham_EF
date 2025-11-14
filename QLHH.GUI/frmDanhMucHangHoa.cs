using BUS;
using DTO;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QLHH.GUI
{
    public partial class frmDanhMucHangHoa : Form
    {
        BUS_Hang busHang = new BUS_Hang();
        BUS_ChatLieu busChatLieu = new BUS_ChatLieu();
        string thuMucLuuAnh = @"D:\Projects\QLBanHang\Images";
        private enum TrangThai
        {
            MacDinh,
            Them,
            Sua
        }
        private TrangThai trangThaiHienTai = TrangThai.MacDinh;
        public frmDanhMucHangHoa()
        {
            InitializeComponent();

            if (!Directory.Exists(thuMucLuuAnh))
            {
                Directory.CreateDirectory(thuMucLuuAnh);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBoxChatLieu();
            LoadDataGridView();
            CapNhatTrangThaiControls(TrangThai.MacDinh);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        private void LoadComboBoxChatLieu()
        {
            cboMaChatLieu.DataSource = busChatLieu.LayDanhSachChatLieu();
            cboMaChatLieu.DisplayMember = "TenChatLieu";
            cboMaChatLieu.ValueMember = "MaChatLieu";
            cboMaChatLieu.SelectedIndex = -1;
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (trangThaiHienTai != TrangThai.MacDinh)
            {
                MessageBox.Show("Bạn đang trong quá trình nhập liệu. Vui lòng Lưu hoặc Bỏ qua.", "Thông báo");
                return;
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHangHoa.Rows[e.RowIndex];

                txtMaHang.Text = row.Cells["MaHang"].Value?.ToString();
                txtTenHang.Text = row.Cells["TenHang"].Value?.ToString();
                cboMaChatLieu.SelectedValue = row.Cells["MaChatLieu"].Value;
                txtSoLuong.Text = row.Cells["SoLuong"].Value?.ToString();
                group.Text = row.Cells["DonGiaNhap"].Value?.ToString();
                txtDonGiaBan.Text = row.Cells["DonGiaBan"].Value?.ToString();
                dgvHangHoa.Text = row.Cells["GhiChu"].Value?.ToString();

                txtAnh.Text = row.Cells["Hinh"].Value?.ToString();
                picAnh.Image = (!string.IsNullOrEmpty(txtAnh.Text) && File.Exists(txtAnh.Text))
                    ? Image.FromFile(txtAnh.Text)
                    : null;

                // Enable nút Bỏ qua khi có dữ liệu được load
                BoQua_Button.Enabled = true;
            }
        }

        private void LoadDataGridView()
        {
            // Lấy danh sách, sắp xếp theo tên hàng tăng dần
            var ds = busHang.LayDanhSachHang()
    .OrderBy(h => h.TenHang, StringComparer.Create(
        System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), false))
    .ToList();

            dgvHangHoa.DataSource = null;  // reset DataSource trước
            dgvHangHoa.DataSource = ds;

            dgvHangHoa.Columns["MaHang"].HeaderText = "Mã hàng";
            dgvHangHoa.Columns["TenHang"].HeaderText = "Tên hàng";
            dgvHangHoa.Columns["TenChatLieu"].HeaderText = "Chất liệu";
            dgvHangHoa.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvHangHoa.Columns["DonGiaNhap"].HeaderText = "Đơn giá nhập";
            dgvHangHoa.Columns["DonGiaBan"].HeaderText = "Đơn giá bán";

            dgvHangHoa.Columns["MaChatLieu"].Visible = false;
            dgvHangHoa.Columns["Hinh"].Visible = false;
            dgvHangHoa.Columns["GhiChu"].Visible = false;

            dgvHangHoa.Columns["TenHang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ClearControls()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            cboMaChatLieu.SelectedIndex = -1; 
            txtSoLuong.Text = "0";
            group.Text = "0";
            txtDonGiaBan.Text = "0";
            txtAnh.Text = "";
            dgvHangHoa.Text = "";
            picAnh.Image = null;
        }
        private void CapNhatTrangThaiControls(TrangThai trangThai)
        {
            trangThaiHienTai = trangThai;
            bool dangNhapLieu = (trangThai == TrangThai.Them || trangThai == TrangThai.Sua);

            // Cho phép luôn chỉnh sửa Tên Hàng, Số lượng, Đơn giá bán
            txtTenHang.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtDonGiaBan.ReadOnly = false;
            txtDonGiaNhap.ReadOnly = false; // nếu 'group' là textbox chứa Đơn giá nhập

            // Các control khác vẫn theo trạng thái
            txtMaHang.ReadOnly = (trangThai != TrangThai.Them);
            btnMo.Enabled = dangNhapLieu;
            btnLuu_Click.Enabled = dangNhapLieu;
            BoQua_Button.Enabled = dangNhapLieu || !string.IsNullOrEmpty(txtMaHang.Text);
            btnThem_Click.Enabled = !dangNhapLieu;
            btnSua_Click.Enabled = !dangNhapLieu;
            btnXoa_Click.Enabled = !dangNhapLieu;
            btnTimKiem_Click.Enabled = !dangNhapLieu;
            btnThoat_Click.Enabled = !dangNhapLieu;
            dgvHangHoa.Enabled = !dangNhapLieu;
        }

        private void btnThem_Click_Click(object sender, EventArgs e)
        {
            CapNhatTrangThaiControls(TrangThai.Them);
            ClearControls();
            txtMaHang.Focus();
        }

        private void btnSua_Click_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHang.Text))
            {
                MessageBox.Show("Bạn phải chọn một mặt hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CapNhatTrangThaiControls(TrangThai.Sua);
            txtTenHang.Focus();
        }

        private void btnXoa_Click_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text;

            if (string.IsNullOrEmpty(maHang))
            {
                MessageBox.Show("Bạn chưa chọn mặt hàng để xóa.", "Thông báo");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa mặt hàng '{txtTenHang.Text}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (busHang.XoaHang(maHang))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadDataGridView();
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại (có thể do lỗi khóa ngoại).");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaHang.Text))
                {
                    MessageBox.Show("Mã hàng không được để trống!");
                    txtMaHang.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtTenHang.Text))
                {
                    MessageBox.Show("Tên hàng không được để trống!");
                    txtTenHang.Focus();
                    return;
                }
                if (cboMaChatLieu.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn chất liệu!");
                    dgvHangHoa.Focus();
                    return;
                }

                Hang_DTO hang = new Hang_DTO
                {
                    MaHang = txtMaHang.Text,
                    TenHang = txtTenHang.Text,
                    MaChatLieu = cboMaChatLieu.SelectedValue.ToString(),
                    SoLuong = float.Parse(txtSoLuong.Text),
                    DonGiaNhap = double.Parse(group.Text),
                    DonGiaBan = double.Parse(txtDonGiaBan.Text),
                    Hinh = txtAnh.Text,
                    GhiChu = dgvHangHoa.Text
                };

                if (trangThaiHienTai == TrangThai.Them)
                {
                    if (busHang.ThemHang(hang))
                    {
                        MessageBox.Show("Thêm mới thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại. Mã hàng có thể đã tồn tại.");
                        return;
                    }
                }
                else 
                {
                    if (busHang.SuaHang(hang))
                    {
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại.");
                        return;
                    }
                }

                LoadDataGridView();
                CapNhatTrangThaiControls(TrangThai.MacDinh);
                ClearControls();
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng, Đơn giá nhập, Đơn giá bán phải là số.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void btnTimKiem_Click_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadDataGridView(); // hiển thị tất cả dữ liệu
                return;
            }
            dgvHangHoa.DataSource = busHang.TimKiemHang(tuKhoa);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string tenFile = Path.GetFileName(dlg.FileName);
                    string duongDanMoi = Path.Combine(thuMucLuuAnh, tenFile);
                    File.Copy(dlg.FileName, duongDanMoi, true);
                    txtAnh.Text = duongDanMoi;
                    picAnh.Image = Image.FromFile(duongDanMoi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sao chép ảnh: " + ex.Message);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnh_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picAnh_Click(object sender, EventArgs e)
        {

        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void GhiChu_richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoQua_Button_Click(object sender, EventArgs e)
        {
            CapNhatTrangThaiControls(TrangThai.MacDinh); // trở về trạng thái mặc định
            ClearControls(); // xóa form
            LoadDataGridView(); // load lại dữ liệu hiện có
        }

    }
}
