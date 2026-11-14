using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SchoolManagementSystem.Globle_Classes;
using SchoolManagementSystem.Students;
using SchoolManagementSystem.Parents;
using SchoolManagementSystem.Enrollment;
using SchoolManagementSystem.Classes;
using SchoolManagementSystem.Courses;
using SchoolManagementSystem.Academic;
using SchoolManagementSystem.Teachers;
using SchoolManagementSystem.Attendance;
using SchoolManagementSystem.Finance;
using SchoolManagementSystem.Users;
using SchoolManagementSystem.Reports;
using SchoolManagementSystemBusinessLayer;
using SchoolManagementSystem.Login;

namespace SchoolManagementSystem
{
    public partial class frmMainScreen : Form
    {
        #region ── Fields ──────────────────────────────────────────────────────────

        // ── Layout Panels ──
        private Panel pnlHeader;
        private Panel pnlSidebar;
        private Panel pnlSidebarScroll;
        private Panel pnlStatusBar;
        private Panel pnlCenter;

        // ── Header Controls ──
        private Label lblAppTitle;
        private Label lblCurrentUser;
        private Label lblAcademicYear;
        private Button btnLogout;

        // ── Status Bar Controls ──
        private Label lblStatusUser;
        private Label lblStatusClock;
        private Label lblStatusVersion;

        // ── Dashboard Stat Labels (in welcome panel) ──
        private Label lblStatStudents;
        private Label lblStatTeachers;
        private Label lblStatClasses;
        private Label lblStatParents;

        // ── Timer ──
        private System.Windows.Forms.Timer tmrClock;

        // ── Sidebar State ──
        private Button _activeNavButton;
        private bool _isLoggingOut;
        private readonly List<NavGroup> _navGroups = new List<NavGroup>();

        // ── Dimensions ──
        private const int SIDEBAR_WIDTH = 270;
        private const int HEADER_HEIGHT = 65;
        private const int STATUSBAR_HEIGHT = 32;
        private const int GROUP_HEADER_HEIGHT = 44;
        private const int NAV_ITEM_HEIGHT = 40;
        private const int SIDEBAR_PADDING = 8;

        #endregion

        #region ── Inner Types ─────────────────────────────────────────────────────

        private class NavGroup
        {
            public string Name;
            public string RoleTag;   // "all", "admin", "teacher"
            public Panel HeaderPanel;
            public Panel ContentPanel;
            public Label ArrowLabel;
            public bool IsExpanded = true;
            public List<Button> NavButtons = new List<Button>();
        }

        private struct NavItemDef
        {
            public string Text;
            public Action ClickAction;
            public NavItemDef(string text, Action action) { Text = text; ClickAction = action; }
        }

        #endregion

        #region ── Constructor & Load ──────────────────────────────────────────────

        public frmMainScreen()
        {

            InitializeComponent();
        }
        frmLogin _Login;
        public frmMainScreen(frmLogin Login)
        {

            InitializeComponent();

            this._Login = Login;
        }

        private void FrmMainScreen_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = false;

            BuildHeader();
            BuildStatusBar();
            BuildSidebar();
            BuildWelcomePanel();
            SetupClock();

            this.ResumeLayout(true);

            UpdateUserInfo();
            ApplyRoleBasedVisibility();
            RefreshDashboardStats();
        }

        #endregion

        #region ── Header Bar ──────────────────────────────────────────────────────

        private void BuildHeader()
        {
            pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = HEADER_HEIGHT,
                BackColor = clsUITheme.DarkColor,
                Padding = new Padding(20, 0, 15, 0)
            };

            // Bottom accent line
            var pnlAccent = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 3,
                BackColor = clsUITheme.PrimaryColor
            };

            // Application Title (Right in RTL)
            lblAppTitle = new Label
            {
                Text = "🏫  نظام إدارة المدرسة المتكامل",
                Font = new Font("Segoe UI", 14.5f, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Dock = DockStyle.Right,
                Width = 350,
                TextAlign = ContentAlignment.MiddleRight
            };

            // Academic Year (Right, after title)
            lblAcademicYear = new Label
            {
                Text = "",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Regular),
                ForeColor = Color.FromArgb(160, 185, 210),
                AutoSize = false,
                Dock = DockStyle.Right,
                Width = 200,
                TextAlign = ContentAlignment.MiddleRight
            };

            // Logout Button (Left in RTL)
            btnLogout = new Button
            {
                Text = "تسجيل الخروج 🚪",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = clsUITheme.DangerColor,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(130, 36),
                Cursor = Cursors.Hand,
                Dock = DockStyle.Left,
                Margin = new Padding(5, 14, 0, 14)
            };
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 50, 35);
            btnLogout.Click += BtnLogout_Click;

            // User Info (Left, after logout)
            lblCurrentUser = new Label
            {
                Text = "",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Regular),
                ForeColor = Color.FromArgb(200, 215, 230),
                AutoSize = false,
                Dock = DockStyle.Left,
                Width = 280,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(12, 0, 0, 0)
            };

            pnlHeader.Controls.Add(lblAcademicYear);
            pnlHeader.Controls.Add(lblAppTitle);
            pnlHeader.Controls.Add(lblCurrentUser);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(pnlAccent);

            this.Controls.Add(pnlHeader);
            pnlHeader.BringToFront();
        }

        #endregion

        #region ── Status Bar ──────────────────────────────────────────────────────

        private void BuildStatusBar()
        {
            pnlStatusBar = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = STATUSBAR_HEIGHT,
                BackColor = Color.FromArgb(248, 249, 252),
                Padding = new Padding(15, 0, 15, 0)
            };

            pnlStatusBar.Paint += (s, e) =>
            {
                using (var pen = new Pen(clsUITheme.BorderColor))
                    e.Graphics.DrawLine(pen, 0, 0, pnlStatusBar.Width, 0);
            };

            // User info (Right in RTL)
            lblStatusUser = new Label
            {
                Text = "👤 المستخدم: —",
                Font = clsUITheme.ArabicRegularFont,
                ForeColor = clsUITheme.TextMuted,
                AutoSize = false,
                Dock = DockStyle.Right,
                Width = 320,
                TextAlign = ContentAlignment.MiddleRight
            };

            // Version (Left in RTL)
            lblStatusVersion = new Label
            {
                Text = "الإصدار 1.0.0",
                Font = clsUITheme.ArabicRegularFont,
                ForeColor = clsUITheme.TextMuted,
                AutoSize = false,
                Dock = DockStyle.Left,
                Width = 120,
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Clock (Center)
            lblStatusClock = new Label
            {
                Text = DateTime.Now.ToString("yyyy/MM/dd  hh:mm:ss tt"),
                Font = clsUITheme.ArabicRegularFont,
                ForeColor = clsUITheme.TextMuted,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            pnlStatusBar.Controls.Add(lblStatusClock);
            pnlStatusBar.Controls.Add(lblStatusVersion);
            pnlStatusBar.Controls.Add(lblStatusUser);

            this.Controls.Add(pnlStatusBar);
            pnlStatusBar.BringToFront();
        }

        #endregion

        #region ── Sidebar Navigation (Right in RTL) ──────────────────────────────

        private void BuildSidebar()
        {
            pnlSidebar = new Panel
            {
                Dock = DockStyle.Right,
                Width = SIDEBAR_WIDTH,
                BackColor = Color.White
            };

            // Left border (in RTL, separator is on the left edge of the sidebar)
            pnlSidebar.Paint += (s, e) =>
            {
                using (var pen = new Pen(clsUITheme.BorderColor))
                    e.Graphics.DrawLine(pen, 0, 0, 0, pnlSidebar.Height);
            };

            pnlSidebarScroll = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.White
            };

            // 1. Student Management
            AddNavGroup("👨‍🎓  إدارة الطلاب", "all", new NavItemDef[]
            {
                new NavItemDef("📋  قائمة الطلاب", () => OpenChildForm<frmStudentList>()),
                new NavItemDef("👨‍👩‍👧  أولياء الأمور", () => OpenChildForm<frmParentList>()),
                new NavItemDef("📝  التسجيل والقبول", () => OpenChildForm<frmStudentEnrollmentList>()),
            });

            // 2. Academic Management
            AddNavGroup("🏫  الشؤون الأكاديمية", "all", new NavItemDef[]
            {
                new NavItemDef("📚  الفصول الدراسية", () => OpenChildForm<frmClassList>()),
                new NavItemDef("📖  المقررات الدراسية", () => OpenChildForm<frmCourseList>()),
                new NavItemDef("📊  المراحل الدراسية", () => OpenChildForm<frmGradeLevels>()),
                new NavItemDef("📅  السنوات الأكاديمية", () => OpenChildForm<frmAcademicYears>()),
                new NavItemDef("⏰  الجدول المدرسي", () => OpenChildForm<frmTimetableManagement>()),
            });

            // 3. Teachers
            AddNavGroup("👨‍🏫  المعلمون", "all", new NavItemDef[]
            {
                new NavItemDef("📋  قائمة المعلمين", () => OpenChildForm<frmTeacherList>()),
            });

            // 4. Assessment & Attendance
            AddNavGroup("📊  التقييم والحضور", "all", new NavItemDef[]
            {
                new NavItemDef("✅  إدارة الحضور والغياب", () => OpenChildForm<frmAttendanceManagement>()),
                new NavItemDef("📝  إدارة الدرجات (قريباً)", () => ShowComingSoonMessage("إدارة الدرجات")),
            });

            // 5. Finance
            AddNavGroup("💰  الشؤون المالية", "admin", new NavItemDef[]
            {
                new NavItemDef("💳  هياكل الرسوم الدراسية", () => OpenChildForm<frmFeeStructures>()),
                new NavItemDef("🧾  سجل الفواتير", () => OpenChildForm<frmInvoicesList>()),
                new NavItemDef("💵  سندات القبض والمدفوعات", () => OpenChildForm<frmPaymentsList>()),
                new NavItemDef("📑  أنواع وطرق الدفع", () => OpenChildForm<frmPaymentTypes>()),
            });

            // 6. User Management
            AddNavGroup("👥  إدارة المستخدمين", "admin", new NavItemDef[]
            {
                new NavItemDef("👤  سجل المستخدمين والصلاحيات", () => OpenChildForm<frmUserList>()),
            });

            // 7. Reports
            AddNavGroup("📋  التقارير", "all", new NavItemDef[]
            {
                new NavItemDef("📊  تقرير أداء وتحصيل الطلاب", () => OpenChildFormInstance(new frmStudentPerformance())),
            });

            RelayoutSidebar();

            pnlSidebar.Controls.Add(pnlSidebarScroll);
            this.Controls.Add(pnlSidebar);
            pnlSidebar.BringToFront();
        }

        private void AddNavGroup(string title, string roleTag, NavItemDef[] items)
        {
            var group = new NavGroup
            {
                Name = title,
                RoleTag = roleTag,
                IsExpanded = true
            };

            int contentWidth = SIDEBAR_WIDTH - 20;

            // ── Group Header ──
            group.HeaderPanel = new Panel
            {
                Size = new Size(contentWidth, GROUP_HEADER_HEIGHT),
                BackColor = Color.FromArgb(245, 247, 252),
                Cursor = Cursors.Hand
            };

            group.HeaderPanel.Paint += (s, e) =>
            {
                using (var pen = new Pen(Color.FromArgb(230, 234, 240)))
                    e.Graphics.DrawLine(pen, 10, group.HeaderPanel.Height - 1,
                                        group.HeaderPanel.Width - 10, group.HeaderPanel.Height - 1);
            };

            // Arrow on the left in RTL
            group.ArrowLabel = new Label
            {
                Text = "▼",
                Font = new Font("Segoe UI", 8.5f),
                ForeColor = clsUITheme.TextMuted,
                Size = new Size(24, GROUP_HEADER_HEIGHT),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(10, 0),
                Cursor = Cursors.Hand
            };

            var lblGroupTitle = new Label
            {
                Text = title,
                Font = clsUITheme.ArabicBoldFont,
                ForeColor = clsUITheme.TextDark,
                AutoSize = false,
                Location = new Point(35, 0),
                Size = new Size(contentWidth - 45, GROUP_HEADER_HEIGHT),
                TextAlign = ContentAlignment.MiddleRight,
                Cursor = Cursors.Hand
            };

            EventHandler toggleHandler = (s, e) =>
            {
                group.IsExpanded = !group.IsExpanded;
                group.ArrowLabel.Text = group.IsExpanded ? "▼" : "◀";
                RelayoutSidebar();
            };

            group.HeaderPanel.Click += toggleHandler;
            lblGroupTitle.Click += toggleHandler;
            group.ArrowLabel.Click += toggleHandler;

            Color normalBg = Color.FromArgb(245, 247, 252);
            Color hoverBg = Color.FromArgb(228, 235, 248);

            Action<Control> wireHover = (c) =>
            {
                c.MouseEnter += (s, e) => group.HeaderPanel.BackColor = hoverBg;
                c.MouseLeave += (s, e) => group.HeaderPanel.BackColor = normalBg;
            };
            wireHover(group.HeaderPanel);
            wireHover(lblGroupTitle);
            wireHover(group.ArrowLabel);

            group.HeaderPanel.Controls.Add(group.ArrowLabel);
            group.HeaderPanel.Controls.Add(lblGroupTitle);
            pnlSidebarScroll.Controls.Add(group.HeaderPanel);

            // ── Group Content (nav items) ──
            group.ContentPanel = new Panel
            {
                Size = new Size(contentWidth, items.Length * NAV_ITEM_HEIGHT),
                BackColor = Color.White
            };

            for (int i = 0; i < items.Length; i++)
            {
                var itemDef = items[i];

                var btn = new Button
                {
                    Text = itemDef.Text,
                    Font = clsUITheme.ArabicRegularFont,
                    ForeColor = clsUITheme.TextDark,
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(contentWidth, NAV_ITEM_HEIGHT),
                    Location = new Point(0, i * NAV_ITEM_HEIGHT),
                    TextAlign = ContentAlignment.MiddleRight,
                    Cursor = Cursors.Hand,
                    Padding = new Padding(0, 0, 15, 0)
                };

                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 240, 255);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 225, 250);

                Action action = itemDef.ClickAction;
                Button capturedBtn = btn;

                btn.Click += (s, e) =>
                {
                    SetActiveNavButton(capturedBtn);
                    action?.Invoke();
                };

                group.ContentPanel.Controls.Add(btn);
                group.NavButtons.Add(btn);
            }

            pnlSidebarScroll.Controls.Add(group.ContentPanel);
            _navGroups.Add(group);
        }

        private void RelayoutSidebar()
        {
            int y = SIDEBAR_PADDING;

            foreach (var group in _navGroups)
            {
                if (!group.HeaderPanel.Visible)
                {
                    group.ContentPanel.Visible = false;
                    continue;
                }

                group.HeaderPanel.Location = new Point(8, y);
                y += group.HeaderPanel.Height + 1;

                if (group.IsExpanded && group.ContentPanel.Controls.Count > 0)
                {
                    group.ContentPanel.Location = new Point(8, y);
                    group.ContentPanel.Visible = true;
                    y += group.ContentPanel.Height;
                }
                else
                {
                    group.ContentPanel.Visible = false;
                }

                y += 8;
            }
        }

        private void SetActiveNavButton(Button btn)
        {
            if (_activeNavButton != null)
            {
                _activeNavButton.BackColor = Color.White;
                _activeNavButton.ForeColor = clsUITheme.TextDark;
                _activeNavButton.Font = clsUITheme.ArabicRegularFont;
                _activeNavButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 240, 255);
            }

            _activeNavButton = btn;
            if (btn != null)
            {
                btn.BackColor = clsUITheme.PrimaryColor;
                btn.ForeColor = Color.White;
                btn.Font = clsUITheme.ArabicBoldFont;
                btn.FlatAppearance.MouseOverBackColor = clsUITheme.PrimaryHoverColor;
            }
        }

        #endregion

        #region ── Welcome & Dashboard Panel ───────────────────────────────────────

        private void BuildWelcomePanel()
        {
            pnlCenter = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = clsUITheme.LightBackground
            };

            var pnlContainer = new Panel
            {
                Size = new Size(620, 400),
                BackColor = Color.Transparent
            };

            // ── Welcome Card ──
            var pnlCard = new Panel
            {
                Size = new Size(540, 190),
                Location = new Point(40, 0),
                BackColor = Color.White
            };
            pnlCard.Paint += (s, e) =>
            {
                using (var pen = new Pen(clsUITheme.BorderColor))
                    e.Graphics.DrawRectangle(pen, 0, 0, pnlCard.Width - 1, pnlCard.Height - 1);
            };

            var lblIcon = new Label
            {
                Text = "🏫",
                Font = new Font("Segoe UI", 36f),
                Location = new Point(0, 15),
                Size = new Size(540, 55),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.White
            };

            var lblTitle = new Label
            {
                Text = "نظام إدارة المدرسة المتكامل",
                Font = new Font("Segoe UI", 16f, FontStyle.Bold),
                ForeColor = clsUITheme.TextDark,
                Location = new Point(0, 75),
                Size = new Size(540, 35),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.White
            };

            var lblSub = new Label
            {
                Text = "اختر القسم المطلوب من القائمة الجانبية للبدء",
                Font = clsUITheme.ArabicRegularFont,
                ForeColor = clsUITheme.TextMuted,
                Location = new Point(0, 115),
                Size = new Size(540, 28),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.White
            };

            var lblVer = new Label
            {
                Text = "الإصدار 1.0.0",
                Font = new Font("Segoe UI", 8.5f),
                ForeColor = Color.FromArgb(190, 195, 200),
                Location = new Point(0, 150),
                Size = new Size(540, 22),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.White
            };

            pnlCard.Controls.AddRange(new Control[] { lblIcon, lblTitle, lblSub, lblVer });
            pnlContainer.Controls.Add(pnlCard);

            // ── Stats Cards Row ──
            int cardWidth = 135;
            int cardHeight = 90;
            int cardGap = 15;
            int totalCardsWidth = (cardWidth * 4) + (cardGap * 3);
            int cardsStartX = (620 - totalCardsWidth) / 2;
            int cardsY = 210;

            var statsData = new (string label, string emoji, Color accent)[]
            {
                ("الطلاب", "👨‍🎓", Color.FromArgb(41, 128, 185)),
                ("المعلمون", "👨‍🏫", Color.FromArgb(142, 68, 173)),
                ("الفصول", "🏫", Color.FromArgb(230, 126, 34)),
                ("أولياء الأمور", "👨‍👩‍👧", Color.FromArgb(39, 174, 96)),
            };

            Label[] statValueLabels = new Label[4];

            for (int i = 0; i < 4; i++)
            {
                int x = cardsStartX + (3 - i) * (cardWidth + cardGap);
                var data = statsData[i];

                var card = new Panel
                {
                    Size = new Size(cardWidth, cardHeight),
                    Location = new Point(x, cardsY),
                    BackColor = Color.White
                };

                Color accentColor = data.accent;
                card.Paint += (s, e) =>
                {
                    using (var pen = new Pen(clsUITheme.BorderColor))
                        e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
                    using (var brush = new SolidBrush(accentColor))
                        e.Graphics.FillRectangle(brush, 0, 0, card.Width, 3);
                };

                var lblEmoji = new Label
                {
                    Text = data.emoji,
                    Font = new Font("Segoe UI", 18f),
                    Location = new Point(0, 10),
                    Size = new Size(cardWidth, 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.White
                };

                var lblValue = new Label
                {
                    Text = "—",
                    Font = new Font("Segoe UI", 14f, FontStyle.Bold),
                    ForeColor = data.accent,
                    Location = new Point(0, 38),
                    Size = new Size(cardWidth, 24),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.White
                };
                statValueLabels[i] = lblValue;

                var lblLabel = new Label
                {
                    Text = data.label,
                    Font = clsUITheme.ArabicBoldFont,
                    ForeColor = clsUITheme.TextMuted,
                    Location = new Point(0, 62),
                    Size = new Size(cardWidth, 22),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.White
                };

                card.Controls.AddRange(new Control[] { lblEmoji, lblValue, lblLabel });
                pnlContainer.Controls.Add(card);
            }

            lblStatStudents = statValueLabels[0];
            lblStatTeachers = statValueLabels[1];
            lblStatClasses = statValueLabels[2];
            lblStatParents = statValueLabels[3];

            pnlCenter.Controls.Add(pnlContainer);

            EventHandler centerHandler = (s, e) =>
            {
                if (pnlCenter.Width > 0 && pnlCenter.Height > 0)
                {
                    pnlContainer.Location = new Point(
                        Math.Max(0, (pnlCenter.Width - pnlContainer.Width) / 2),
                        Math.Max(0, (pnlCenter.Height - pnlContainer.Height) / 2 - 25)
                    );
                }
            };
            pnlCenter.Resize += centerHandler;
            pnlCenter.HandleCreated += centerHandler;

            this.Controls.Add(pnlCenter);
            pnlCenter.SendToBack();
        }

        private void RefreshDashboardStats()
        {
            try
            {
                var stats = clsDashboard.GetDashboardStats();
                lblStatStudents.Text = stats.TotalStudents.ToString();
                lblStatTeachers.Text = stats.TotalTeachers.ToString();
                lblStatClasses.Text = stats.TotalClasses.ToString();
                lblStatParents.Text = stats.TotalParents.ToString();

                if (!string.IsNullOrEmpty(stats.CurrentAcademicYear) &&
                    stats.CurrentAcademicYear != "None")
                {
                    lblAcademicYear.Text = $"📅 السنة الأكاديمية: {stats.CurrentAcademicYear}";
                }
            }
            catch { }
        }

        #endregion

        #region ── Child Form Management (ShowDialog) ──────────────────────────────

        private void OpenChildForm<T>() where T : Form, new()
        {
            using (T form = new T())
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
            }

            SetActiveNavButton(null);
            RefreshDashboardStats();
        }

        private void OpenChildFormInstance(Form form)
        {
            using (form)
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
            }

            SetActiveNavButton(null);
            RefreshDashboardStats();
        }

        #endregion

        #region ── Clock ───────────────────────────────────────────────────────────

        private void SetupClock()
        {
            tmrClock = new System.Windows.Forms.Timer { Interval = 1000 };
            tmrClock.Tick += (s, e) =>
            {
                lblStatusClock.Text = DateTime.Now.ToString("yyyy/MM/dd  hh:mm:ss tt");
            };
            tmrClock.Start();
        }

        #endregion

        #region ── User Info & Role-Based Access ───────────────────────────────────

        private void UpdateUserInfo()
        {
            string userName = "مدير النظام";
            string userType = "مدير";

            try
            {
                if (clsGloble.CurrentUser != null)
                {
                    userName = !string.IsNullOrEmpty(clsGloble.CurrentUser.Username)
                                ? clsGloble.CurrentUser.Username : "غير معروف";
                    
                    switch (clsGloble.CurrentUser.UserType?.ToLower())
                    {
                        case "admin": userType = "مدير النظام"; break;
                        case "teacher": userType = "معلم"; break;
                        case "parent": userType = "ولي أمر"; break;
                        case "student": userType = "طالب"; break;
                        default: userType = clsGloble.CurrentUser.UserType ?? "مستخدم"; break;
                    }
                }
            }
            catch { }

            lblCurrentUser.Text = $"👤 {userName}  |  {userType}";
            lblStatusUser.Text = $"👤 تم تسجيل الدخول: {userName} ({userType})";
        }

        private void ApplyRoleBasedVisibility()
        {
            string userType = "admin";

            try
            {
                if (clsGloble.CurrentUser != null &&
                    !string.IsNullOrEmpty(clsGloble.CurrentUser.UserType))
                {
                    userType = clsGloble.CurrentUser.UserType.ToLower();
                }
            }
            catch { }

            foreach (var group in _navGroups)
            {
                bool visible;

                if (group.RoleTag == "all")
                {
                    visible = true;
                }
                else
                {
                    switch (userType)
                    {
                        case "admin":
                            visible = true;
                            break;
                        case "teacher":
                            visible = (group.RoleTag == "teacher");
                            break;
                        default:
                            visible = false;
                            break;
                    }
                }

                group.HeaderPanel.Visible = visible;
                if (!visible)
                    group.ContentPanel.Visible = false;
            }

            RelayoutSidebar();
        }

        #endregion

        #region ── Event Handlers ──────────────────────────────────────────────────

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = clsUITheme.ShowArabicMessage(
                "هل أنت متأكد من رغبتك في تسجيل الخروج؟",
                "تأكيد تسجيل الخروج",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _isLoggingOut = true;
                clsGloble.CurrentUser = null;

                _Login.Show();

                this.Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_isLoggingOut)
            {
                tmrClock?.Stop();
                tmrClock?.Dispose();
                base.OnFormClosing(e);
                //this._Login.Dispose();
                return;
            }

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = clsUITheme.ShowArabicMessage(
                    "هل أنت متأكد من رغبتك في إغلاق وإنهاء النظام؟",
                    "تأكيد الخروج",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }

            tmrClock?.Stop();
            tmrClock?.Dispose();
            base.OnFormClosing(e);
        }

        #endregion

        #region ── Helpers ─────────────────────────────────────────────────────────

        private void ShowComingSoonMessage(string moduleName)
        {
            clsUITheme.ShowArabicMessage(
                $"وحدة ({moduleName}) سيتم إطلاقها وتفعيلها في المرحلة القادمة.",
                "قريباً",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        #endregion
    }
}
