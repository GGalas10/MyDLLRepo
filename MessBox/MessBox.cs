using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
namespace MessBox
{
    public static class MessBox
    {
        public static MessageBoxResult Show(string caption,string text,TypeOfBox BoxType,Icons icon)
        {
            MessageBoxResult result;
            switch (BoxType)
            {
                case TypeOfBox.YesNo:
                    YesNo yesNo = new YesNo(caption, text,icon);
                    yesNo.ShowDialog();
                    result = yesNo.resul;
                    break;
                case TypeOfBox.Yes:
                    Yes yes = new Yes(caption, text, icon);
                    yes.ShowDialog();
                    result = yes.resul;
                    break;
                case TypeOfBox.No:
                    No no = new No(caption,text, icon);
                    no.ShowDialog();
                    result = no.resul;
                    break;
                case TypeOfBox.YesCancelNo:
                    YesNoCancel yesnocancel = new YesNoCancel(caption, text, icon);
                    yesnocancel.ShowDialog();
                    result = yesnocancel.resul;
                    break;
                case TypeOfBox.YesCancel:
                    YesCancel yescancel = new YesCancel(caption, text, icon);
                    yescancel.ShowDialog();
                    result = yescancel.resul;
                    break;
                case TypeOfBox.Ok:
                    Ok ok = new Ok(caption, text, icon);
                    ok.ShowDialog();
                    result = ok.resul;
                    break;
                default:
                    result = MessageBoxResult.None;
                    break;
            }
            return result;
        }        
        internal static void FormBackColo(Form form)
        {
            Label ExitBtn = new Label();
            ExitBtn.BackColor = System.Drawing.Color.Transparent;
            ExitBtn.Image = global::MessBox.Properties.Resources.Exit;
            ExitBtn.Location = new System.Drawing.Point(348, 0);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new System.Drawing.Size(24, 24);
            ExitBtn.Click += ExitBtnClick;
            form.Controls.Add(ExitBtn);
            form.BackColor = Color.FromArgb(66, 125, 176);
        }
        internal static void ButtonYes(Button btn)
        {
            BtnSettings(btn);
            btn.BackColor = Color.FromArgb(69,196,23);
            btn.Text = "&Tak";
        }
        internal static void ButtonNo(Button btn)
        {
            BtnSettings(btn);
            btn.BackColor = Color.FromArgb(137, 26, 26);
            btn.Text = "&Nie";
        }
        internal static void ButtonCancel(Button btn)
        {
            BtnSettings(btn);
            btn.BackColor = Color.FromArgb(233, 111, 30);
            btn.Text = "&Anuluj";
        }
        internal static void ButtonOk(Button btn)
        {
            BtnSettings(btn);
            btn.BackColor = Color.FromArgb(233, 111, 30);
            btn.Text = "&OK";
        }
        private static void BtnSettings(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));         
        }
        private static void ExitBtnClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        public static void SetImg(Label lbl,Icons ico)
        {
            switch (ico)
            {
                case Icons.Error:
                    lbl.Image = global::MessBox.Properties.Resources.Exit;
                    break;
                case Icons.Info:
                    lbl.Image = global::MessBox.Properties.Resources.Info;
                    break;
                case Icons.Warning:
                    lbl.Image = global::MessBox.Properties.Resources.no;
                    break;
                case Icons.Ok:
                    lbl.Image = global::MessBox.Properties.Resources.Yes;
                    break;
                default:
                    lbl.Image = global::MessBox.Properties.Resources.Info;
                    break;
            }
        }
    }
} 
