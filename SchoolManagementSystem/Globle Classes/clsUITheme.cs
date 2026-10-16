using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem.Globle_Classes
{
    public static class clsUITheme
    {
        public static readonly Color PrimaryColor = Color.FromArgb(41, 128, 185);
        public static readonly Color PrimaryHoverColor = Color.FromArgb(52, 152, 219);
        public static readonly Color DarkColor = Color.FromArgb(44, 62, 80);
        public static readonly Color LightBackground = Color.FromArgb(245, 247, 250);
        public static readonly Color CardBackground = Color.White;
        public static readonly Color BorderColor = Color.FromArgb(220, 224, 230);
        public static readonly Color TextDark = Color.FromArgb(33, 37, 41);
        public static readonly Color TextMuted = Color.FromArgb(120, 130, 140);
        public static readonly Color SuccessColor = Color.FromArgb(39, 174, 96);
        public static readonly Color DangerColor = Color.FromArgb(192, 57, 43);
        public static readonly Color WarningColor = Color.FromArgb(243, 156, 18);

        public static readonly Font TitleFont = new Font("Segoe UI", 16, FontStyle.Bold);
        public static readonly Font SubtitleFont = new Font("Segoe UI", 10, FontStyle.Regular);
        public static readonly Font SectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
        public static readonly Font RegularFont = new Font("Segoe UI", 9.5f, FontStyle.Regular);
        public static readonly Font BoldFont = new Font("Segoe UI", 9.5f, FontStyle.Bold);

        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(235, 238, 242);
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = true;
            dgv.ReadOnly = true;
            
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 40;
            //dgv.AutoScrollOffset
            dgv.ColumnHeadersDefaultCellStyle.BackColor = DarkColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = BoldFont;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            // Make grid keep its height and scroll vertically when rows are more
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // we control widths manually
            dgv.ScrollBars = ScrollBars.Both;  // or ScrollBars.Vertical if you only want vertical

            
            dgv.RowTemplate.Height = 35;
            dgv.DefaultCellStyle.Font = RegularFont;
            dgv.DefaultCellStyle.ForeColor = PrimaryHoverColor;// TextDark;
            dgv.DefaultCellStyle.SelectionBackColor = PrimaryColor;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Padding = new Padding(6, 0, 6, 0);
            
            //dgv.RightToLeft = RightToLeft.Yes;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
        }

        public static void StylePrimaryButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = PrimaryColor;
            btn.ForeColor = Color.White;
            btn.Font = BoldFont;
            btn.Cursor = Cursors.Hand;
            btn.Height = 36;
        }

        public static void StyleSuccessButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = SuccessColor;
            btn.ForeColor = Color.White;
            btn.Font = BoldFont;
            btn.Cursor = Cursors.Hand;
            btn.Height = 36;
        }

        public static void StyleDangerButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = DangerColor;
            btn.ForeColor = Color.White;
            btn.Font = BoldFont;
            btn.Cursor = Cursors.Hand;
            btn.Height = 36;
        }

        public static void StyleSecondaryButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = BorderColor;
            btn.BackColor = Color.White;
            btn.ForeColor = TextDark;
            btn.Font = RegularFont;
            btn.Cursor = Cursors.Hand;
            btn.Height = 36;
        }

        public static Panel CreateHeaderPanel(string title, string subtitle)
        {
            Panel pnl = new Panel()
            {
                Dock = DockStyle.Top,
                Height = 70,
                BackColor = Color.White,
                Padding = new Padding(20, 10, 20, 10)
            };

            Label lblTitle = new Label()
            {
                Text = title,
                Font = TitleFont,
                ForeColor = DarkColor,
                Location = new Point(20, 10),
                AutoSize = true
            };

            Label lblSub = new Label()
            {
                Text = subtitle,
                Font = SubtitleFont,
                ForeColor = TextMuted,
                Location = new Point(22, 40),
                AutoSize = true
            };

            Panel pnlLine = new Panel()
            {
                Dock = DockStyle.Bottom,
                Height = 1,
                BackColor = BorderColor
            };

            pnl.Controls.Add(lblTitle);
            pnl.Controls.Add(lblSub);
            pnl.Controls.Add(pnlLine);

            return pnl;
        }


    }
}
