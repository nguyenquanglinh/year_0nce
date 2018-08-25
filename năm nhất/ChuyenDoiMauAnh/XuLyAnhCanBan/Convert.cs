using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyAnhCanBan
{
    public partial class Convert : Form
    {
        string path;
        LockBitImage lockbit;
        List<IXuLyAnh> ThuatToan;
        public Convert()
        {

            InitializeComponent();
            this.Text = "ConvertImage";
            cbbCachXuLy.SelectedIndex = 0;
            ThuatToan = new List<IXuLyAnh>();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                KhoiTaoImg(open);
            
            }
        }

        #region


        //tạo thuật toán xử lý
        private void TaoThuatToanXuLy()
        {
            //chuyển sang ảnh xám
            if (cbbCachXuLy.SelectedIndex == 1)
                AddThuatToan(new ConvertImageColorToImageGray());
            //đảo màu ảnh
            else if (cbbCachXuLy.SelectedIndex == 2)
                AddThuatToan(new ColorReversal());
            //Chọn ngưỡng T
            else if (cbbCachXuLy.SelectedIndex == 3)
            {
                var f2 = new ThresholdT();
                f2.ShowDialog();

                AddThuatToan(new HandleThreshold(f2.T));
            }
            //chọn khoảng [a,b]
            else if (cbbCachXuLy.SelectedIndex == 4)
            {
                var f2 = new Threshold_a_b_();
                f2.ShowDialog();
                AddThuatToan(new ThresholdAB(f2.a, f2.b));
            }
            //nhân chập
            else if (cbbCachXuLy.SelectedIndex == 5)
            {
                var f2 = new Multiply();
                f2.ShowDialog();
                AddThuatToan(new ConvertImageToNegative(f2.Arr));
            }
        }

        //lưu ảnh
        private void SaveImage(string name)
        {
            this.pictureBox2.Image.Save("F:/C#/BaiTap1/ChuyenDoiMauAnh/DataImg/" + name + ".jpg", System.Drawing.Imaging.ImageFormat.Png);
            MessageBox.Show("ok");
        }

        //thêm 1 thuật toán mới vào để xử lý
        private void AddThuatToan(IXuLyAnh im)
        {
            ThuatToan.Add(im);
            listBox1.Items.Add(cbbCachXuLy.SelectedItem);
        }

        //thực hiện khi bấm open
        private void KhoiTaoImg(OpenFileDialog open)
        {
            pictureBox1.Image = Image.FromFile(open.FileName);
            path = open.FileName;
            lockbit = new LockBitImage(new Bitmap(path));
            lockbit.Arr = lockbit.GetByteBit();
        }


        //thực hiện khi bấn xử lý
        private void ThucHienThuatToan()
        {
            foreach (var item in ThuatToan)
            {
                item.ConvertImage(lockbit.Arr);
            }
            ThuatToan = new List<IXuLyAnh>();
            lockbit.SetByteToBitMap(lockbit.Arr);
            listBox1.Items.Clear();
            pictureBox2.Image = lockbit.Bitmap;
            lockbit = new LockBitImage(new Bitmap(path));
            lockbit.Arr = lockbit.GetByteBit();
        }
        #endregion

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            if (ThuatToan.Count != 0)
            {
                ThucHienThuatToan();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var f2 = new SaveImg();
            f2.ShowDialog();
            SaveImage(f2.FileName);
        }



        private void cbbCachXuLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaoThuatToanXuLy();
        }


        private List<Bitmap> LayBitMapChu()
        {
            var duyetAnh = new DuyetDiemAnhChu(lockbit.Arr, lockbit.Bitmap);
            return duyetAnh.DuyetDiemChu();

        }

        private void btnDemDiemAnh_Click(object sender, EventArgs e)
        {
            var tapAnh = LayBitMapChu();
            if (tapAnh.Count == 0)
                MessageBox.Show("chỉ so sánh được ảnh đen trắng");
            for (int i = 0; i < tapAnh.Count; i++)
            {
                pictureBox2.Image = tapAnh[i];
                SaveImage(i.ToString());
            }
        }

        private void btnSoSanh_Click(object sender, EventArgs e)
        {
            var tapAnh = LayBitMapChu();
            string path = "F:/C#/BaiTap1/ChuyenDoiMauAnh/DataImg";
            var datapath = Directory.GetFiles(path);

            foreach (var item in tapAnh)
            {
                var lb = new LockBitImage(item);

                var sosanh = new CopareImg(lb.GetByteBit());
                lb.UnLockBit();
               
                foreach (string fileName in datapath)
                {
                    var locbit = new LockBitImage(new Bitmap(fileName));
                    if (sosanh.Compare(locbit.GetByteBit()))
                    {
                        txtText.Text += Path.GetFileName(fileName).Trim().Split('.')[0].Split('-')[0];

                        locbit.UnLockBit();
                     
                        MessageBox.Show("ok");
                        break;
                    }
                    else locbit.UnLockBit(); 
                }

            }
        }
         
        
    }
    class Stt
    {
        public Stt(int dDau, int DCuoi)
        {
            this.DiemDau = dDau;
            this.DiemCuoi = DCuoi;

            this.DoDai = DCuoi - dDau;
        }
        int dai;

        public int DiemDau { get; set; }

        public int DiemCuoi { get; set; }

        public int DoDai
        {
            get
            {
                return dai;
            }
            set
            {
                dai = value;

                if (value == 0)
                    dai = 1;
            }
        }
    }
}
