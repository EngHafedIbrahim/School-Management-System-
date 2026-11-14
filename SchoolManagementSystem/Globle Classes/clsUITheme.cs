using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SchoolManagementSystem.Globle_Classes
{
    public static class clsUITheme
    {
        // ── Color Palette (Indigo + Teal) ──
        public static readonly Color PrimaryColor = Color.FromArgb(55, 71, 133);
        public static readonly Color PrimaryHoverColor = Color.FromArgb(72, 92, 165);
        public static readonly Color AccentColor = Color.FromArgb(0, 150, 136);
        public static readonly Color DarkColor = Color.FromArgb(38, 42, 51);
        public static readonly Color LightBackground = Color.FromArgb(243, 244, 246);
        public static readonly Color CardBackground = Color.White;
        public static readonly Color BorderColor = Color.FromArgb(209, 213, 219);
        public static readonly Color TextDark = Color.FromArgb(31, 41, 55);
        public static readonly Color TextMuted = Color.FromArgb(107, 114, 128);
        public static readonly Color SuccessColor = Color.FromArgb(16, 122, 87);
        public static readonly Color DangerColor = Color.FromArgb(185, 28, 28);
        public static readonly Color WarningColor = Color.FromArgb(180, 130, 10);

        // ── Fonts ──
        public static readonly Font TitleFont = new Font("Segoe UI", 16, FontStyle.Bold);
        public static readonly Font SubtitleFont = new Font("Segoe UI", 10, FontStyle.Regular);
        public static readonly Font SectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
        public static readonly Font RegularFont = new Font("Segoe UI", 9.5f, FontStyle.Regular);
        public static readonly Font BoldFont = new Font("Segoe UI", 9.5f, FontStyle.Bold);

        public static readonly Font ArabicTitleFont = new Font("Segoe UI", 14f, FontStyle.Bold);
        public static readonly Font ArabicSubtitleFont = new Font("Segoe UI", 9.5f, FontStyle.Regular);
        public static readonly Font ArabicRegularFont = new Font("Segoe UI", 9.5f, FontStyle.Regular);
        public static readonly Font ArabicBoldFont = new Font("Segoe UI", 9.5f, FontStyle.Bold);

        // ── RTL ──
        public static void ApplyRTL(Form form)
        {
            form.RightToLeft = RightToLeft.Yes;
            form.RightToLeftLayout = true;
            form.Font = ArabicRegularFont;
        }

        // ── Messages ──
        public static DialogResult ShowArabicMessage(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            return MessageBox.Show(text, caption, buttons, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        public static DialogResult ShowArabicMessage(string text, string caption, MessageBoxIcon icon)
        {
            return ShowArabicMessage(text, caption, MessageBoxButtons.OK, icon);
        }

        // ── DataGridView ──
        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(229, 231, 235);
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = true;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 42;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 251);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(107, 114, 128);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv.ScrollBars = ScrollBars.Both;

            dgv.RowTemplate.Height = 40;
            dgv.DefaultCellStyle.Font = RegularFont;
            dgv.DefaultCellStyle.ForeColor = TextDark;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(238, 242, 255);
            dgv.DefaultCellStyle.SelectionForeColor = PrimaryColor;
            dgv.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 251);

            AddRowHoverEffect(dgv);
        }

        private static void AddRowHoverEffect(DataGridView dgv)
        {
            int lastRow = -1;

            dgv.CellMouseEnter += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv.Rows.Count && !dgv.Rows[e.RowIndex].Selected)
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(243, 244, 246);
                    lastRow = e.RowIndex;
                }
            };

            dgv.CellMouseLeave += (s, e) =>
            {
                if (lastRow >= 0 && lastRow < dgv.Rows.Count && !dgv.Rows[lastRow].Selected)
                {
                    dgv.Rows[lastRow].DefaultCellStyle.BackColor =
                        (lastRow % 2 == 1) ? Color.FromArgb(249, 250, 251) : Color.White;
                }
            };
        }

        // ── Buttons ──
        public static void StylePrimaryButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = PrimaryColor;
            btn.ForeColor = Color.White;
            btn.Font = BoldFont;
            btn.Cursor = Cursors.Hand;
            btn.Height = 36;
            AddHoverEffect(btn);
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
            AddHoverEffect(btn);
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
            AddHoverEffect(btn);
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
            AddHoverEffectOutline(btn);
        }

        public static void AddHoverEffect(Button btn)
        {
            Color normalBg = btn.BackColor;
            Color hoverBg = ControlPaint.Light(normalBg, 0.12f);
            Color pressBg = ControlPaint.Dark(normalBg, 0.08f);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (s, e) => btn.BackColor = hoverBg;
            btn.MouseLeave += (s, e) => btn.BackColor = normalBg;
            btn.MouseDown += (s, e) => btn.BackColor = pressBg;
            btn.MouseUp += (s, e) => btn.BackColor = hoverBg;
        }

        public static void AddHoverEffectOutline(Button btn)
        {
            Color normalBg = btn.BackColor;
            Color hoverBg = Color.FromArgb(243, 244, 246);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = BorderColor;
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (s, e) => btn.BackColor = hoverBg;
            btn.MouseLeave += (s, e) => btn.BackColor = normalBg;
        }

        // ── TextBox / ComboBox ──
        public static void StyleTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = new Font("Segoe UI", 10f);
            txt.BackColor = Color.White;
            txt.ForeColor = TextDark;
            txt.TextAlign = HorizontalAlignment.Right;

            txt.Enter += (s, e) => { txt.BackColor = Color.FromArgb(248, 250, 255); };
            txt.Leave += (s, e) => { txt.BackColor = Color.White; };
        }

        public static void StyleComboBox(ComboBox cb)
        {
            cb.FlatStyle = FlatStyle.Flat;
            cb.Font = new Font("Segoe UI", 10f);
            cb.BackColor = Color.White;
            cb.ForeColor = TextDark;
        }

        // ── Header Panel ──
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

        public static void AddHeaderBottomLine(Panel pnlHeader)
        {
            pnlHeader.Paint += (s, e) =>
            {
                using (var pen = new Pen(BorderColor, 1))
                    e.Graphics.DrawLine(pen, 0, pnlHeader.Height - 1, pnlHeader.Width, pnlHeader.Height - 1);
            };
        }

        // ── Stat Cards ──
        public static Panel CreateStatCard(string title, string value, Color accentColor)
        {
            Panel card = new Panel()
            {
                Size = new Size(195, 80),
                BackColor = Color.White,
                Padding = new Padding(14, 10, 14, 10),
                Margin = new Padding(6),
            };

            card.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var pen = new Pen(Color.FromArgb(20, 0, 0, 0), 1))
                    e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
                using (var brush = new SolidBrush(accentColor))
                    e.Graphics.FillRectangle(brush, 0, 0, card.Width, 3);
            };

            // Value أولاً حتى يكون Controls[0]
            Label lblValue = new Label()
            {
                Text = value,
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = TextDark,
                Location = new Point(14, 34),
                AutoSize = true,
                BackColor = Color.Transparent
            };

            Label lblTitle = new Label()
            {
                Text = title,
                Font = new Font("Segoe UI", 8.5f, FontStyle.Regular),
                ForeColor = TextMuted,
                Location = new Point(14, 12),
                AutoSize = true,
                BackColor = Color.Transparent
            };

            card.Controls.Add(lblValue);
            card.Controls.Add(lblTitle);
            return card;
        }

        // ── Empty State ──
        private static Dictionary<DataGridView, Label> _emptyStateLabels = new Dictionary<DataGridView, Label>();

        public static void ShowEmptyState(DataGridView dgv, string message = "لا توجد بيانات لعرضها")
        {
            if (dgv.Parent == null) return;

            if (!_emptyStateLabels.ContainsKey(dgv))
            {
                Label lbl = new Label()
                {
                    Text = message,
                    Font = new Font("Segoe UI", 12, FontStyle.Regular),
                    ForeColor = TextMuted,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    BackColor = Color.White,
                    Visible = false
                };
                dgv.Parent.Controls.Add(lbl);
                lbl.BringToFront();
                _emptyStateLabels[dgv] = lbl;
            }

            bool isEmpty = dgv.Rows.Count == 0;
            _emptyStateLabels[dgv].Text = message;
            _emptyStateLabels[dgv].Visible = isEmpty;
            dgv.Visible = !isEmpty;
        }

        // ── Section Divider ──
        public static Panel CreateSectionDivider(string title, int width)
        {
            Panel pnl = new Panel()
            {
                Size = new Size(width, 32),
                BackColor = Color.Transparent,
            };

            Label lbl = new Label()
            {
                Text = title,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = PrimaryColor,
                AutoSize = true,
                Location = new Point(0, 4),
                BackColor = Color.Transparent
            };

            Panel line = new Panel()
            {
                Height = 1,
                BackColor = BorderColor,
                Dock = DockStyle.Bottom
            };

            pnl.Controls.Add(lbl);
            pnl.Controls.Add(line);
            return pnl;
        }

        // ── Style All Controls in Form ──
        public static void StyleFormControls(Form form)
        {
            foreach (Control ctrl in GetAllControls(form))
            {
                if (ctrl is TextBox txt && txt.Tag?.ToString() != "skip")
                    StyleTextBox(txt);
                else if (ctrl is ComboBox cb)
                    StyleComboBox(cb);
            }
        }

        private static IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                yield return ctrl;
                foreach (var child in GetAllControls(ctrl))
                    yield return child;
            }
        }
    }
}
