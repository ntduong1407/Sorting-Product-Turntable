namespace CSharp_PLC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LedBao = new SymbolFactoryDotNet.StandardControl();
            this.TrangThai = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.NhapSo = new System.Windows.Forms.TextBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.high_sensor = new SymbolFactoryDotNet.StandardControl();
            this.medium_sensor = new SymbolFactoryDotNet.StandardControl();
            this.small_sensor = new SymbolFactoryDotNet.StandardControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.high_number_product = new System.Windows.Forms.Label();
            this.medium_number_product = new System.Windows.Forms.Label();
            this.small_number_product = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LedBao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.high_sensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medium_sensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.small_sensor)).BeginInit();
            this.SuspendLayout();
            // 
            // LedBao
            // 
            this.LedBao.AnalogIntValue1 = ((short)(0));
            this.LedBao.AnalogValue1 = 0D;
            this.LedBao.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.LedBao.BackColor = System.Drawing.Color.Transparent;
            this.LedBao.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.LedBao.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Lime, "Band1"));
            this.LedBao.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Red, "Band2"));
            this.LedBao.BlinkColor = System.Drawing.Color.Red;
            this.LedBao.Category = "1Btn.cat2";
            this.LedBao.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("LedBao.DebugData"));
            this.LedBao.FillColor = System.Drawing.Color.White;
            this.LedBao.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.LedBao.Location = new System.Drawing.Point(99, 14);
            this.LedBao.Name = "LedBao";
            this.LedBao.Size = new System.Drawing.Size(43, 42);
            this.LedBao.SymbolHandle = ((long)(842488176));
            this.LedBao.TabIndex = 5;
            // 
            // TrangThai
            // 
            this.TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangThai.Location = new System.Drawing.Point(37, 62);
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Size = new System.Drawing.Size(161, 22);
            this.TrangThai.TabIndex = 4;
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_connect.Location = new System.Drawing.Point(543, 54);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(85, 30);
            this.btn_connect.TabIndex = 7;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // NhapSo
            // 
            this.NhapSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapSo.Location = new System.Drawing.Point(431, 58);
            this.NhapSo.Name = "NhapSo";
            this.NhapSo.Size = new System.Drawing.Size(106, 22);
            this.NhapSo.TabIndex = 6;
            this.NhapSo.Text = "192.168.56.1";
            this.NhapSo.TextChanged += new System.EventHandler(this.NhapSo_TextChanged);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(81, 377);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(103, 31);
            this.btn_stop.TabIndex = 9;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(81, 316);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(103, 31);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(81, 451);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(103, 31);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // high_sensor
            // 
            this.high_sensor.AnalogIntValue1 = ((short)(0));
            this.high_sensor.AnalogValue1 = 0D;
            this.high_sensor.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.high_sensor.BackColor = System.Drawing.Color.Transparent;
            this.high_sensor.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.high_sensor.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), "Band1"));
            this.high_sensor.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135))))), "Band2"));
            this.high_sensor.BlinkColor = System.Drawing.Color.Red;
            this.high_sensor.Category = "1Btn.cat2";
            this.high_sensor.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("high_sensor.DebugData"));
            this.high_sensor.FillColor = System.Drawing.Color.White;
            this.high_sensor.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.high_sensor.Location = new System.Drawing.Point(239, 221);
            this.high_sensor.Name = "high_sensor";
            this.high_sensor.Size = new System.Drawing.Size(19, 17);
            this.high_sensor.SymbolHandle = ((long)(842488176));
            this.high_sensor.TabIndex = 14;
            // 
            // medium_sensor
            // 
            this.medium_sensor.AnalogIntValue1 = ((short)(0));
            this.medium_sensor.AnalogValue1 = 0D;
            this.medium_sensor.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.medium_sensor.BackColor = System.Drawing.Color.Transparent;
            this.medium_sensor.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.medium_sensor.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), "Band1"));
            this.medium_sensor.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135))))), "Band2"));
            this.medium_sensor.BlinkColor = System.Drawing.Color.Red;
            this.medium_sensor.Category = "1Btn.cat2";
            this.medium_sensor.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("medium_sensor.DebugData"));
            this.medium_sensor.FillColor = System.Drawing.Color.White;
            this.medium_sensor.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.medium_sensor.Location = new System.Drawing.Point(239, 239);
            this.medium_sensor.Name = "medium_sensor";
            this.medium_sensor.Size = new System.Drawing.Size(19, 17);
            this.medium_sensor.SymbolHandle = ((long)(842488176));
            this.medium_sensor.TabIndex = 15;
            // 
            // small_sensor
            // 
            this.small_sensor.AnalogIntValue1 = ((short)(0));
            this.small_sensor.AnalogValue1 = 0D;
            this.small_sensor.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.small_sensor.BackColor = System.Drawing.Color.Transparent;
            this.small_sensor.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.small_sensor.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), "Band1"));
            this.small_sensor.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135))))), "Band2"));
            this.small_sensor.BlinkColor = System.Drawing.Color.Red;
            this.small_sensor.Category = "1Btn.cat2";
            this.small_sensor.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("small_sensor.DebugData"));
            this.small_sensor.FillColor = System.Drawing.Color.White;
            this.small_sensor.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.small_sensor.Location = new System.Drawing.Point(239, 256);
            this.small_sensor.Name = "small_sensor";
            this.small_sensor.Size = new System.Drawing.Size(19, 17);
            this.small_sensor.SymbolHandle = ((long)(842488176));
            this.small_sensor.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // high_number_product
            // 
            this.high_number_product.AutoSize = true;
            this.high_number_product.BackColor = System.Drawing.Color.Cyan;
            this.high_number_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high_number_product.Location = new System.Drawing.Point(547, 141);
            this.high_number_product.Name = "high_number_product";
            this.high_number_product.Size = new System.Drawing.Size(70, 25);
            this.high_number_product.TabIndex = 17;
            this.high_number_product.Text = "label1";
            // 
            // medium_number_product
            // 
            this.medium_number_product.AutoSize = true;
            this.medium_number_product.BackColor = System.Drawing.Color.Cyan;
            this.medium_number_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medium_number_product.Location = new System.Drawing.Point(12, 149);
            this.medium_number_product.Name = "medium_number_product";
            this.medium_number_product.Size = new System.Drawing.Size(70, 25);
            this.medium_number_product.TabIndex = 18;
            this.medium_number_product.Text = "label2";
            // 
            // small_number_product
            // 
            this.small_number_product.AutoSize = true;
            this.small_number_product.BackColor = System.Drawing.Color.Cyan;
            this.small_number_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.small_number_product.Location = new System.Drawing.Point(288, 40);
            this.small_number_product.Name = "small_number_product";
            this.small_number_product.Size = new System.Drawing.Size(70, 25);
            this.small_number_product.TabIndex = 19;
            this.small_number_product.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::CSharp_PLC.Properties.Resources.Screenshot_2023_03_31_232822;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(640, 630);
            this.Controls.Add(this.small_number_product);
            this.Controls.Add(this.medium_number_product);
            this.Controls.Add(this.high_number_product);
            this.Controls.Add(this.small_sensor);
            this.Controls.Add(this.medium_sensor);
            this.Controls.Add(this.high_sensor);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.NhapSo);
            this.Controls.Add(this.LedBao);
            this.Controls.Add(this.TrangThai);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LedBao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.high_sensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medium_sensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.small_sensor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SymbolFactoryDotNet.StandardControl LedBao;
        private System.Windows.Forms.TextBox TrangThai;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox NhapSo;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_reset;
        private SymbolFactoryDotNet.StandardControl high_sensor;
        private SymbolFactoryDotNet.StandardControl medium_sensor;
        private SymbolFactoryDotNet.StandardControl small_sensor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label high_number_product;
        private System.Windows.Forms.Label medium_number_product;
        private System.Windows.Forms.Label small_number_product;
    }
}

