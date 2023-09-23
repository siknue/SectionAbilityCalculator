using System.Text.RegularExpressions;

namespace calcSectionAbility
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.in_height = new System.Windows.Forms.TextBox();
            this.in_width = new System.Windows.Forms.TextBox();
            this.in_th = new System.Windows.Forms.TextBox();
            this.in_tw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.in_lb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.in_e = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.in_g = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.in_f = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.out_j = new System.Windows.Forms.TextBox();
            this.out_ix = new System.Windows.Forms.TextBox();
            this.out_iy = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.out_zy = new System.Windows.Forms.TextBox();
            this.out_zx = new System.Windows.Forms.TextBox();
            this.out_lb = new System.Windows.Forms.TextBox();
            this.out_ls = new System.Windows.Forms.TextBox();
            this.out_lc = new System.Windows.Forms.TextBox();
            this.out_lt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.out_area = new System.Windows.Forms.TextBox();
            this.out_sb = new System.Windows.Forms.TextBox();
            this.out_ss = new System.Windows.Forms.TextBox();
            this.out_sc = new System.Windows.Forms.TextBox();
            this.out_st = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // in_height
            // 
            this.in_height.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.in_height.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.in_height.Location = new System.Drawing.Point(175, 10);
            this.in_height.Name = "in_height";
            this.in_height.Size = new System.Drawing.Size(166, 43);
            this.in_height.TabIndex = 0;
            this.in_height.Text = "0";
            this.in_height.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // in_width
            // 
            this.in_width.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.in_width.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.in_width.Location = new System.Drawing.Point(175, 74);
            this.in_width.Name = "in_width";
            this.in_width.Size = new System.Drawing.Size(166, 43);
            this.in_width.TabIndex = 1;
            this.in_width.Text = " 0";
            // 
            // in_th
            // 
            this.in_th.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.in_th.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.in_th.Location = new System.Drawing.Point(175, 138);
            this.in_th.Name = "in_th";
            this.in_th.Size = new System.Drawing.Size(166, 43);
            this.in_th.TabIndex = 2;
            this.in_th.Text = " 0";
            // 
            // in_tw
            // 
            this.in_tw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.in_tw.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.in_tw.Location = new System.Drawing.Point(175, 202);
            this.in_tw.Name = "in_tw";
            this.in_tw.Size = new System.Drawing.Size(166, 43);
            this.in_tw.TabIndex = 3;
            this.in_tw.Text = " 0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "height";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "width";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(60, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "tw";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(63, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "th";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(60, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lb";
            // 
            // in_lb
            // 
            this.in_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.in_lb.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.in_lb.Location = new System.Drawing.Point(175, 267);
            this.in_lb.Name = "in_lb";
            this.in_lb.Size = new System.Drawing.Size(166, 43);
            this.in_lb.TabIndex = 8;
            this.in_lb.Text = " 0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(412, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "E";
            // 
            // in_e
            // 
            this.in_e.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.in_e.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.in_e.Location = new System.Drawing.Point(519, 74);
            this.in_e.Name = "in_e";
            this.in_e.Size = new System.Drawing.Size(168, 43);
            this.in_e.TabIndex = 10;
            this.in_e.Text = " 205000";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(410, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "G";
            // 
            // in_g
            // 
            this.in_g.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.in_g.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.in_g.Location = new System.Drawing.Point(519, 138);
            this.in_g.Name = "in_g";
            this.in_g.Size = new System.Drawing.Size(168, 43);
            this.in_g.TabIndex = 12;
            this.in_g.Text = " 79000";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(412, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 36);
            this.label8.TabIndex = 15;
            this.label8.Text = "F";
            // 
            // in_f
            // 
            this.in_f.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.in_f.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.in_f.Location = new System.Drawing.Point(519, 10);
            this.in_f.Name = "in_f";
            this.in_f.Size = new System.Drawing.Size(168, 43);
            this.in_f.TabIndex = 14;
            this.in_f.Text = " 235";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(14, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(690, 55);
            this.button1.TabIndex = 22;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // out_j
            // 
            this.out_j.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out_j.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.out_j.Location = new System.Drawing.Point(450, 92);
            this.out_j.Name = "out_j";
            this.out_j.Size = new System.Drawing.Size(280, 43);
            this.out_j.TabIndex = 24;
            // 
            // out_ix
            // 
            this.out_ix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out_ix.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.out_ix.Location = new System.Drawing.Point(450, 168);
            this.out_ix.Name = "out_ix";
            this.out_ix.Size = new System.Drawing.Size(280, 43);
            this.out_ix.TabIndex = 25;
            // 
            // out_iy
            // 
            this.out_iy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out_iy.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.out_iy.Location = new System.Drawing.Point(450, 244);
            this.out_iy.Name = "out_iy";
            this.out_iy.Size = new System.Drawing.Size(280, 43);
            this.out_iy.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(107, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 36);
            this.label12.TabIndex = 27;
            this.label12.Text = "面積(mm2)";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(133, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 36);
            this.label13.TabIndex = 28;
            this.label13.Text = "J(mm4)";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(122, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 36);
            this.label14.TabIndex = 29;
            this.label14.Text = "Ix(mm^4)";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(122, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 36);
            this.label15.TabIndex = 30;
            this.label15.Text = "Iy(mm^4)";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(117, 400);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(159, 36);
            this.label16.TabIndex = 34;
            this.label16.Text = "Zy(mm^4)";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(117, 324);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 36);
            this.label17.TabIndex = 33;
            this.label17.Text = "Zx(mm^4)";
            // 
            // out_zy
            // 
            this.out_zy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out_zy.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.out_zy.Location = new System.Drawing.Point(450, 397);
            this.out_zy.Name = "out_zy";
            this.out_zy.Size = new System.Drawing.Size(280, 43);
            this.out_zy.TabIndex = 32;
            // 
            // out_zx
            // 
            this.out_zx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out_zx.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.out_zx.Location = new System.Drawing.Point(450, 320);
            this.out_zx.Name = "out_zx";
            this.out_zx.Size = new System.Drawing.Size(280, 43);
            this.out_zx.TabIndex = 31;
            // 
            // out_lb
            // 
            this.out_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out_lb.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.out_lb.Location = new System.Drawing.Point(258, 321);
            this.out_lb.Name = "out_lb";
            this.out_lb.Size = new System.Drawing.Size(170, 43);
            this.out_lb.TabIndex = 38;
            // 
            // out_ls
            // 
            this.out_ls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out_ls.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.out_ls.Location = new System.Drawing.Point(258, 244);
            this.out_ls.Name = "out_ls";
            this.out_ls.Size = new System.Drawing.Size(170, 43);
            this.out_ls.TabIndex = 37;
            // 
            // out_lc
            // 
            this.out_lc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out_lc.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.out_lc.Location = new System.Drawing.Point(258, 168);
            this.out_lc.Name = "out_lc";
            this.out_lc.Size = new System.Drawing.Size(170, 43);
            this.out_lc.TabIndex = 36;
            // 
            // out_lt
            // 
            this.out_lt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out_lt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.out_lt.Location = new System.Drawing.Point(258, 92);
            this.out_lt.Name = "out_lt";
            this.out_lt.Size = new System.Drawing.Size(170, 43);
            this.out_lt.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(239, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(208, 28);
            this.label18.TabIndex = 39;
            this.label18.Text = "長期許容応力度";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label19.Location = new System.Drawing.Point(59, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 36);
            this.label19.TabIndex = 40;
            this.label19.Text = "引張り";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label20.Location = new System.Drawing.Point(71, 172);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 36);
            this.label20.TabIndex = 41;
            this.label20.Text = "圧縮";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label21.Location = new System.Drawing.Point(59, 248);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 36);
            this.label21.TabIndex = 42;
            this.label21.Text = "せん断";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label22.Location = new System.Drawing.Point(74, 324);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 36);
            this.label22.TabIndex = 43;
            this.label22.Text = "曲げ";
            // 
            // out_area
            // 
            this.out_area.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out_area.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.out_area.Location = new System.Drawing.Point(450, 16);
            this.out_area.Name = "out_area";
            this.out_area.Size = new System.Drawing.Size(280, 43);
            this.out_area.TabIndex = 23;
            // 
            // out_sb
            // 
            this.out_sb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out_sb.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.out_sb.Location = new System.Drawing.Point(487, 321);
            this.out_sb.Name = "out_sb";
            this.out_sb.Size = new System.Drawing.Size(170, 43);
            this.out_sb.TabIndex = 47;
            // 
            // out_ss
            // 
            this.out_ss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out_ss.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.out_ss.Location = new System.Drawing.Point(487, 244);
            this.out_ss.Name = "out_ss";
            this.out_ss.Size = new System.Drawing.Size(170, 43);
            this.out_ss.TabIndex = 46;
            // 
            // out_sc
            // 
            this.out_sc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out_sc.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.out_sc.Location = new System.Drawing.Point(487, 168);
            this.out_sc.Name = "out_sc";
            this.out_sc.Size = new System.Drawing.Size(170, 43);
            this.out_sc.TabIndex = 45;
            // 
            // out_st
            // 
            this.out_st.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out_st.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.out_st.Location = new System.Drawing.Point(487, 92);
            this.out_st.Name = "out_st";
            this.out_st.Size = new System.Drawing.Size(170, 43);
            this.out_st.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(468, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 28);
            this.label9.TabIndex = 48;
            this.label9.Text = "短期許容応力度";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.in_height, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.in_width, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.in_th, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.in_tw, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.in_lb, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.in_f, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.in_e, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.in_g, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 322);
            this.tableLayoutPanel1.TabIndex = 49;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.out_area, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.out_j, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.out_ix, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.out_iy, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.out_zx, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.out_zy, 1, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(729, 484);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(787, 457);
            this.tableLayoutPanel2.TabIndex = 50;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.label18, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.out_sb, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.out_ss, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.label21, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.out_sc, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label22, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.out_st, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.out_lt, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.out_lb, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.out_lc, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.out_ls, 1, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(14, 560);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(687, 381);
            this.tableLayoutPanel3.TabIndex = 51;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1530, 1051);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 52;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bindingNavigator1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1522, 1019);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "角パイプ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1516, 33);
            this.bindingNavigator1.TabIndex = 52;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 28);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1522, 1019);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "長方形";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 1063);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CalcSectionAbility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }
        private void number_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // 0-9 のみの文字列
            // 正しく入力してなくても次に行くパターン
            Regex regex = new System.Text.RegularExpressions.Regex(@"^[0-9]+$");
            if (!regex.IsMatch(((System.Windows.Forms.TextBox)sender).Text))
            {
                this.errorProvider2.SetError((System.Windows.Forms.TextBox)sender, "0-9 のみの文字列");
                e.Cancel = true;
            }
        }
        #endregion

        private System.Windows.Forms.TextBox in_height;
        private System.Windows.Forms.TextBox in_width;
        private System.Windows.Forms.TextBox in_th;
        private System.Windows.Forms.TextBox in_tw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox in_lb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox in_e;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox in_g;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox in_f;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox out_j;
        private System.Windows.Forms.TextBox out_ix;
        private System.Windows.Forms.TextBox out_iy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox out_zy;
        private System.Windows.Forms.TextBox out_zx;
        private System.Windows.Forms.TextBox out_lb;
        private System.Windows.Forms.TextBox out_ls;
        private System.Windows.Forms.TextBox out_lc;
        private System.Windows.Forms.TextBox out_lt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox out_area;
        private System.Windows.Forms.TextBox out_sb;
        private System.Windows.Forms.TextBox out_ss;
        private System.Windows.Forms.TextBox out_sc;
        private System.Windows.Forms.TextBox out_st;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

