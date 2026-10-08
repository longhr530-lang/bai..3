namespace nguyenhailongb3
{
    public partial class Form1 : Form
    {
        private List<VatTu> items = new List<VatTu>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text.Trim();
            string ten = txtTen.Text.Trim();
            string donvi = comboDonVi.SelectedItem as string ?? string.Empty;
            string donGiaText = txtDonGia.Text.Trim();

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng nhập Mã vật tư.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (items.Any(x => x.Ma == ma))
            {
                MessageBox.Show("Mã vật tư đã tồn tại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(donGiaText, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var vt = new VatTu { Ma = ma, Ten = ten, DonVi = donvi, DonGia = donGia };
            items.Add(vt);
            AddListViewItem(vt);
            ClearInput();
        }

        private void AddListViewItem(VatTu vt)
        {
            var lvi = new ListViewItem(vt.Ma);
            lvi.SubItems.Add(vt.Ten);
            lvi.SubItems.Add(vt.DonVi);
            lvi.SubItems.Add(vt.DonGia.ToString("N0"));
            lvi.Tag = vt;
            listViewItems.Items.Add(lvi);
        }

        private void ClearInput()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            comboDonVi.SelectedIndex = -1;
            txtDonGia.Text = "";
        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                return;
            }

            var lvi = listViewItems.SelectedItems[0];
            if (lvi.Tag is VatTu vt)
            {
                txtMa.Text = vt.Ma;
                txtTen.Text = vt.Ten;
                comboDonVi.SelectedItem = vt.DonVi;
                txtDonGia.Text = vt.DonGia.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var lvi = listViewItems.SelectedItems[0];
            if (!(lvi.Tag is VatTu vt)) return;

            string newMa = txtMa.Text.Trim();
            string newTen = txtTen.Text.Trim();
            string newDonVi = comboDonVi.SelectedItem as string ?? string.Empty;
            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal newDonGia) || newDonGia < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If Ma changed, ensure no duplicate
            if (newMa != vt.Ma && items.Any(x => x.Ma == newMa))
            {
                MessageBox.Show("Mã vật tư mới đã tồn tại. Vui lòng nhập Mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update object
            vt.Ma = newMa;
            vt.Ten = newTen;
            vt.DonVi = newDonVi;
            vt.DonGia = newDonGia;

            // Update ListView
            lvi.Text = vt.Ma;
            lvi.SubItems[1].Text = vt.Ten;
            lvi.SubItems[2].Text = vt.DonVi;
            lvi.SubItems[3].Text = vt.DonGia.ToString("N0");
            lvi.Tag = vt;
            ClearInput();
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var res = MessageBox.Show("Bạn có chắc muốn xóa dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes) return;

            var lvi = listViewItems.SelectedItems[0];
            if (lvi.Tag is VatTu vt)
            {
                items.Remove(vt);
            }
            listViewItems.Items.Remove(lvi);
            ClearInput();
        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes) return;

            items.Clear();
            listViewItems.Items.Clear();
            ClearInput();
        }
    }

    public class VatTu
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string DonVi { get; set; }
        public decimal DonGia { get; set; }
    }
}
