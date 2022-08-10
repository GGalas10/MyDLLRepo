﻿using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;

namespace MessBox
{
    internal partial class YesNoCancel : Form
    {

        internal MessageBoxResult resul;
        public YesNoCancel(string caption,string text,Icons icon)
        {            
            InitializeComponent();
            MessBox.SetImg(IconPic, icon);
            TextLbl.Text = text;
            TitleLbl.Text = caption;
            MessBox.FormBackColo(this);
            MessBox.ButtonYes(YesBtn);
            MessBox.ButtonNo(NoBtn);
            MessBox.ButtonCancel(CancelBtn);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void label2_Click(object sender, System.EventArgs e)
        {
            this.Close();
            resul = MessageBoxResult.None;
        }
        private void NoBtn_Click(object sender, System.EventArgs e)
        {
            resul = MessageBoxResult.Yes;
            this.Close();
        }
        private void TitleLbl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void NoBtn_Click_1(object sender, System.EventArgs e)
        {
            resul = MessageBoxResult.No;
            this.Close();          
        }

        private void CancelBtn_Click(object sender, System.EventArgs e)
        {
            resul = MessageBoxResult.Cancel;
            this.Close();
        }
    }
}
