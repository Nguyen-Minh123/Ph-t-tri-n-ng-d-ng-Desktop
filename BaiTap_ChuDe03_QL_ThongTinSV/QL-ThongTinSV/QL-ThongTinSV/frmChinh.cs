using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;  // Thêm dòng này


namespace QL_ThongTinSV
{
    public partial class frmChinh : Form
    {

        public frmChinh()
        {
            InitializeComponent();


        }

        #region Phương thức bổ trợ
        QLSinhVien dssv;

        private SinhVien LayTTSV_Controls()
        {
            SinhVien sv = new SinhVien();
            bool gt = false;
            List<string> mon = new List<string>();

            sv.MSSV = this.mtxtMSSV.Text;
            sv.HoTenLot = this.txtHoTenLot.Text;
            sv.Ten = this.txtTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.Lop = this.cboLop.Text;
            sv.SoCMND = this.mtxtCMND.Text;
            sv.SDT = this.mtxtSDT.Text;
            sv.DiaChi = this.txtDiaChi.Text;
            if (rdNam.Checked)
                gt = true;
            sv.GioiTinh = gt;

            for (int i = 0; i < this.clbMonDK.Items.Count; i++)
                if (clbMonDK.GetItemChecked(i))
                    mon.Add(clbMonDK.Items[i].ToString());
            sv.MonHocDK = mon;

            return sv;
        }

        private SinhVien LayTTSV_LV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            List<string> mon = new List<string>();

            sv.MSSV = lvitem.SubItems[0].Text;
            sv.HoTenLot = lvitem.SubItems[1].Text;
            sv.Ten = lvitem.SubItems[2].Text;
            sv.NgaySinh = DateTime.ParseExact(lvitem.SubItems[3].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            sv.Lop = lvitem.SubItems[4].Text;
            sv.SoCMND = lvitem.SubItems[5].Text;
            sv.SDT = lvitem.SubItems[6].Text;
            sv.DiaChi = lvitem.SubItems[7].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[8].Text == "Nam")
                sv.GioiTinh = true;

            string[] mondk = lvitem.SubItems[9].Text.Split(',');
            foreach (string m in mondk)
            {
                mon.Add(m);
            }
            sv.MonHocDK = mon;

            return sv;
        }

        private void ThietLapTT_Control(SinhVien sv)
        {
            this.mtxtMSSV.Text = sv.MSSV;
            this.txtHoTenLot.Text = sv.HoTenLot;
            this.txtTen.Text = sv.Ten;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.cboLop.Text = sv.Lop;
            this.mtxtCMND.Text = sv.SoCMND;
            this.mtxtSDT.Text = sv.SDT;
            this.txtDiaChi.Text = sv.DiaChi;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            for (int i = 0; i < clbMonDK.Items.Count; i++)
                this.clbMonDK.SetItemChecked(i, false);
            foreach (string mon in sv.MonHocDK)
            {
                for (int i = 0; i <= this.clbMonDK.Items.Count - 1; i++)
                    if (mon.CompareTo(this.clbMonDK.Items[i]) == 0)
                        this.clbMonDK.SetItemChecked(i, true);
            }
        }

        private void ThemSV_LV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            string gt = "Nữ", mdk = "";

            lvitem.SubItems.Add(sv.HoTenLot);
            lvitem.SubItems.Add(sv.Ten);
            lvitem.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SoCMND);
            lvitem.SubItems.Add(sv.SDT);
            lvitem.SubItems.Add(sv.DiaChi);
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            foreach (string mon in sv.MonHocDK)
            {
                mdk += mon + ",";
            }
            lvitem.SubItems.Add(mdk);

            this.lvSinhVien.Items.Add(lvitem);
        }

        private void TaiListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in dssv.DSSV)
            {
                ThemSV_LV(sv);
            }
        }

        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MSSV.CompareTo(obj1);
        }

        #endregion

        #region Các sự kiện

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            dssv = new QLSinhVien();
            //dssv.DocFile_TXT("du-lieu\\DSSinhVien.txt");
            //dssv.DocFile_Json("du-lieu\\DSSinhVien.json");
            dssv.DocFile_XML("du-lieu\\DSSinhVien.xml");
            TaiListView();
            KhoiTaoMenuMonHoc(); // ⬅️ THÊM DÒNG NÀY VÀO
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(mtxtMSSV.Text) ||
                string.IsNullOrEmpty(txtHoTenLot.Text) ||
                string.IsNullOrEmpty(txtTen.Text) ||
                string.IsNullOrEmpty(cboLop.Text) ||
                dtpNgaySinh.Value == DateTime.Now ||
                string.IsNullOrEmpty(mtxtCMND.Text) ||
                string.IsNullOrEmpty(mtxtSDT.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text) ||
                clbMonDK.Items.Count == 0
              )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                SinhVien sv = LayTTSV_Controls();
                SinhVien kq = dssv.Tim1SV(sv.MSSV, SoSanhTheoMa);

                if (kq != null)
                    MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.dssv.ThemSV(sv);
                    this.TaiListView();
                    this.dssv.GhiFile_TXT("du-lieu\\DSSinhVien.txt");

                    // ✅ Nạp lại để bộ nhớ và file luôn khớp
                    dssv = new QLSinhVien();
                    dssv.DocFile_TXT("du-lieu\\DSSinhVien.txt");
                }
            }
        }


        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lviem = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = LayTTSV_LV(lviem);
                ThietLapTT_Control(sv);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (this.lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (
                string.IsNullOrEmpty(mtxtMSSV.Text) ||
                string.IsNullOrEmpty(txtHoTenLot.Text) ||
                string.IsNullOrEmpty(txtTen.Text) ||
                string.IsNullOrEmpty(cboLop.Text) ||
                dtpNgaySinh.Value == DateTime.Now ||
                string.IsNullOrEmpty(mtxtCMND.Text) ||
                string.IsNullOrEmpty(mtxtSDT.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text) ||
                clbMonDK.CheckedItems.Count == 0
              )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SinhVien sv = LayTTSV_Controls();
            SinhVien kq = dssv.Tim1SV(sv.MSSV, SoSanhTheoMa);

            if (kq == null)
            {
                MessageBox.Show("Mã sinh viên không tồn tại!", "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xóa sinh viên cũ và thêm sinh viên mới với thông tin cập nhật
            dssv.Xoa(sv.MSSV, SoSanhTheoMa);
            dssv.ThemSV(sv);
            TaiListView();
            dssv.GhiFile_TXT("du-lieu\\DSSinhVien.txt");

            MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvSinhVien.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvSinhVien.Items[i];
                if (lvitem.Checked)
                    dssv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.TaiListView();
            dssv.GhiFile_TXT("du-lieu\\DSSinhVien.txt");

        }

        private void tsmiTaiLaiDS_Click(object sender, EventArgs e)
        {
            // Đọc lại từ TXT để đồng bộ
            dssv = new QLSinhVien();
            dssv.DocFile_TXT("du-lieu\\DSSinhVien.txt");
            TaiListView();
            KhoiTaoMenuMonHoc(); // ⬅️ THÊM DÒNG NÀY VÀO
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (frmTimKiem tk = new frmTimKiem())
            {
                if (tk.ShowDialog() == DialogResult.OK)
                {
                    string mssv = tk.MSSV_TK;
                    string ten = tk.Ten_TK;
                    string lop = tk.Lop_TK;

                    var kq = dssv.DSSV.Where(sv =>
                        (string.IsNullOrEmpty(mssv) || sv.MSSV.Contains(mssv)) &&
                        (string.IsNullOrEmpty(ten) || sv.Ten.Contains(ten)) &&
                        (string.IsNullOrEmpty(lop) || sv.Lop == lop)
                    ).ToList();

                    // Hiển thị kết quả tìm kiếm lên ListView
                    this.lvSinhVien.Items.Clear();
                    foreach (SinhVien sv in kq)
                    {
                        ThemSV_LV(sv);
                    }

                    if (kq.Count == 0)
                        MessageBox.Show("Không tìm thấy sinh viên nào!", "Kết quả tìm kiếm",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        #endregion

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void btnLamTrong_Click_1(object sender, EventArgs e)
        {
            // Xóa text trong các ô nhập
            mtxtMSSV.Clear();
            txtHoTenLot.Clear();
            txtTen.Clear();
            mtxtCMND.Clear();
            mtxtSDT.Clear();
            txtDiaChi.Clear();

            // Reset ngày sinh về hôm nay (hoặc có thể set về 01/01/2000 tùy yêu cầu)
            dtpNgaySinh.Value = DateTime.Now;

            // Reset giới tính: mặc định chọn Nam
            rdNam.Checked = true;
            rdNu.Checked = false;

            // Reset lớp: bỏ chọn
            cboLop.SelectedIndex = -1;

            // Bỏ chọn tất cả môn đăng ký
            for (int i = 0; i < clbMonDK.Items.Count; i++)
            {
                clbMonDK.SetItemChecked(i, false);
            }

            // Đưa con trỏ về MSSV
            mtxtMSSV.Focus();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn file dữ liệu sinh viên";
            ofd.Filter = "Tệp dữ liệu (*.json;*.xml;*.txt)|*.json;*.xml;*.txt|Tất cả các tệp (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string duongDan = ofd.FileName;
                dssv = new QLSinhVien();

                try
                {
                    string duoiFile = Path.GetExtension(duongDan).ToLower();

                    if (duoiFile == ".json")
                        dssv.DocFile_Json(duongDan);
                    else if (duoiFile == ".xml")
                        dssv.DocFile_XML(duongDan);
                    else if (duoiFile == ".txt")
                        dssv.DocFile_TXT(duongDan);
                    else
                    {
                        MessageBox.Show("Định dạng file không được hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    TaiListView();
                    MessageBox.Show("Đọc file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnreset_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu nhập
            mtxtMSSV.Clear();
            txtHoTenLot.Clear();
            txtTen.Clear();
            mtxtCMND.Clear();
            mtxtSDT.Clear();
            txtDiaChi.Clear();
            cboLop.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;
            rdNam.Checked = true;
            rdNu.Checked = false;

            // Bỏ chọn tất cả môn học
            for (int i = 0; i < clbMonDK.Items.Count; i++)
                clbMonDK.SetItemChecked(i, false);

            // Xóa danh sách hiển thị
            lvSinhVien.Items.Clear();

            // Xóa dữ liệu trong đối tượng quản lý
            if (dssv != null)
                dssv.DSSV.Clear();

            MessageBox.Show("Đã reset toàn bộ dữ liệu trên form!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mtxtMSSV.Focus();
        }
        private void KhoiTaoMenuMonHoc()
        {
            ContextMenuStrip cms = new ContextMenuStrip();
            cms.Items.Add("Thêm môn...", null, (s, e) => ThemMonHoc());
            cms.Items.Add("Xóa môn đang chọn", null, (s, e) => XoaMonHoc());

            clbMonDK.ContextMenuStrip = cms;
        }
        private void ThemMonHoc()
        {
            string name = Interaction.InputBox("Nhập tên môn:", "Thêm môn");
            if (string.IsNullOrWhiteSpace(name)) return;

            foreach (var item in clbMonDK.Items)
            {
                if (item.ToString().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Môn này đã tồn tại!");
                    return;
                }
            }
            clbMonDK.Items.Add(name, true);  // được tick sẵn khi thêm
        }
        private void XoaMonHoc()
        {
            if (clbMonDK.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn môn cần xóa.");
                return;
            }
            clbMonDK.Items.Remove(clbMonDK.SelectedItem);
        }


    }
}
