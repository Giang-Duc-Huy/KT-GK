using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        private List<Nhanvien> danhSachNhanVien = new List<Nhanvien>();
        private const string FilePath = "nhanvien.dat";
        public Form1()
        {
            InitializeComponent();
            DocDuLieuTuFile();
            HienThiDanhSachLenListView();
        }
        private void DocDuLieuTuFile()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    using (FileStream fs = new FileStream(FilePath, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        danhSachNhanVien = (List<Nhanvien>)formatter.Deserialize(fs);
                    }
                }
                else
                {
                    LuuDuLieuVaoFile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file");
            }
        }
        private void LuuDuLieuVaoFile()
        {
            using (FileStream fs = new FileStream(FilePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, danhSachNhanVien);  
            }
        }
        private void HienThiDanhSachLenListView()
        {
            listView1.Items.Clear();
            foreach (Nhanvien nv in danhSachNhanVien)
            {
                ListViewItem item = new ListViewItem(nv.maSo);
                item.SubItems.Add(nv.hoTen);
                item.SubItems.Add(nv.ngaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(nv.eMail);
                listView1.Items.Add(item);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void themButton_Click(object sender, EventArgs e)
        {
            if (themButton.Text == "Thêm")
            {
                themButton.Text = "Hủy";
                saveButton.Enabled = true;

            }    
            else
            {
                themButton.Text = "Thêm";
                saveButton.Enabled = false;
            }
        }

        private void xLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                maSoTextBox.Text = selectedItem.SubItems[0].Text;
                hoTenTextBox.Text = selectedItem.SubItems[1].Text;
                ngaysinhTextBox.Text = selectedItem.SubItems[2].Text;
                eMailTextBox.Text = selectedItem.SubItems[3].Text;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string maSo = maSoTextBox.Text;
                string hoTen = hoTenTextBox.Text;
                DateTime ngaySinh = DateTime.Parse(ngaysinhTextBox.Text);
                string eMail = eMailTextBox.Text;
                Nhanvien nv = new Nhanvien(maSo, hoTen, ngaySinh, eMail);
                danhSachNhanVien.Add(nv);
                LuuDuLieuVaoFile();
                HienThiDanhSachLenListView();
                themButton.Enabled = true;
                saveButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
