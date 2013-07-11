using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QR_Test_CSharp_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Bitmap myBitMap = new Bitmap("C:\\Users\\Salman\\Downloads\\Yusno.png");
            ZXing.LuminanceSource source = new ZXing.BitmapLuminanceSource(myBitMap);
            ZXing.BinaryBitmap bitmap = new ZXing.BinaryBitmap(new ZXing.Common.HybridBinarizer(source));
            ZXing.QrCode.QRCodeReader R = new ZXing.QrCode.QRCodeReader();
            ZXing.Result Rs = R.decode(bitmap);

        }




    }
}
