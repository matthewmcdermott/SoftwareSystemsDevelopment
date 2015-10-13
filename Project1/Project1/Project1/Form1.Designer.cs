namespace Project1
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
            this.labelStockTicker = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.radioButtonDownloadData = new System.Windows.Forms.RadioButton();
            this.radioButtonDisplayData = new System.Windows.Forms.RadioButton();
            this.buttonGo = new System.Windows.Forms.Button();
            this.radioButtonDaily = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekly = new System.Windows.Forms.RadioButton();
            this.radioButtonMonthly = new System.Windows.Forms.RadioButton();
            this.groupBoxResolution = new System.Windows.Forms.GroupBox();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStockTicker = new System.Windows.Forms.ComboBox();
            this.groupBoxResolution.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStockTicker
            // 
            this.labelStockTicker.AutoSize = true;
            this.labelStockTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockTicker.Location = new System.Drawing.Point(6, 26);
            this.labelStockTicker.Name = "labelStockTicker";
            this.labelStockTicker.Size = new System.Drawing.Size(88, 13);
            this.labelStockTicker.TabIndex = 1;
            this.labelStockTicker.Text = "Stock Ticker :";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.Location = new System.Drawing.Point(6, 52);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(73, 13);
            this.labelStartDate.TabIndex = 4;
            this.labelStartDate.Text = "Start Date :";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.Location = new System.Drawing.Point(6, 79);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(68, 13);
            this.labelEndDate.TabIndex = 5;
            this.labelEndDate.Text = "End Date :";
            // 
            // radioButtonDownloadData
            // 
            this.radioButtonDownloadData.AutoSize = true;
            this.radioButtonDownloadData.Location = new System.Drawing.Point(23, 52);
            this.radioButtonDownloadData.Name = "radioButtonDownloadData";
            this.radioButtonDownloadData.Size = new System.Drawing.Size(112, 17);
            this.radioButtonDownloadData.TabIndex = 7;
            this.radioButtonDownloadData.TabStop = true;
            this.radioButtonDownloadData.Text = "Download Data";
            this.radioButtonDownloadData.UseVisualStyleBackColor = true;
            // 
            // radioButtonDisplayData
            // 
            this.radioButtonDisplayData.AutoSize = true;
            this.radioButtonDisplayData.Location = new System.Drawing.Point(23, 29);
            this.radioButtonDisplayData.Name = "radioButtonDisplayData";
            this.radioButtonDisplayData.Size = new System.Drawing.Size(97, 17);
            this.radioButtonDisplayData.TabIndex = 8;
            this.radioButtonDisplayData.TabStop = true;
            this.radioButtonDisplayData.Text = "Display Data";
            this.radioButtonDisplayData.UseVisualStyleBackColor = true;
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(311, 224);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(128, 69);
            this.buttonGo.TabIndex = 10;
            this.buttonGo.Text = "Go!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // radioButtonDaily
            // 
            this.radioButtonDaily.AutoSize = true;
            this.radioButtonDaily.Location = new System.Drawing.Point(22, 29);
            this.radioButtonDaily.Name = "radioButtonDaily";
            this.radioButtonDaily.Size = new System.Drawing.Size(53, 17);
            this.radioButtonDaily.TabIndex = 12;
            this.radioButtonDaily.TabStop = true;
            this.radioButtonDaily.Text = "Daily";
            this.radioButtonDaily.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeekly
            // 
            this.radioButtonWeekly.AutoSize = true;
            this.radioButtonWeekly.Location = new System.Drawing.Point(22, 52);
            this.radioButtonWeekly.Name = "radioButtonWeekly";
            this.radioButtonWeekly.Size = new System.Drawing.Size(67, 17);
            this.radioButtonWeekly.TabIndex = 13;
            this.radioButtonWeekly.TabStop = true;
            this.radioButtonWeekly.Text = "Weekly";
            this.radioButtonWeekly.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonthly
            // 
            this.radioButtonMonthly.AutoSize = true;
            this.radioButtonMonthly.Location = new System.Drawing.Point(22, 75);
            this.radioButtonMonthly.Name = "radioButtonMonthly";
            this.radioButtonMonthly.Size = new System.Drawing.Size(69, 17);
            this.radioButtonMonthly.TabIndex = 14;
            this.radioButtonMonthly.TabStop = true;
            this.radioButtonMonthly.Text = "Monthly";
            this.radioButtonMonthly.UseVisualStyleBackColor = true;
            // 
            // groupBoxResolution
            // 
            this.groupBoxResolution.Controls.Add(this.radioButtonDaily);
            this.groupBoxResolution.Controls.Add(this.radioButtonMonthly);
            this.groupBoxResolution.Controls.Add(this.radioButtonWeekly);
            this.groupBoxResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxResolution.Location = new System.Drawing.Point(304, 118);
            this.groupBoxResolution.Name = "groupBoxResolution";
            this.groupBoxResolution.Size = new System.Drawing.Size(137, 100);
            this.groupBoxResolution.TabIndex = 15;
            this.groupBoxResolution.TabStop = false;
            this.groupBoxResolution.Text = "Resolution :";
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.dateTimePicker1);
            this.groupBoxAction.Controls.Add(this.radioButtonDisplayData);
            this.groupBoxAction.Controls.Add(this.radioButtonDownloadData);
            this.groupBoxAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAction.Location = new System.Drawing.Point(304, 12);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(142, 100);
            this.groupBoxAction.TabIndex = 16;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Action :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(-110, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(98, 50);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 17;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(98, 79);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 18;
            // 
            // comboBoxStockTicker
            // 
            this.comboBoxStockTicker.FormattingEnabled = true;
            this.comboBoxStockTicker.Items.AddRange(new object[] {
            "",
            "A",
            "AA",
            "AAPL",
            "ABC",
            "ABT",
            "ACE",
            "ACN",
            "ADBE",
            "ADI",
            "ADM",
            "ADP",
            "ADSK",
            "AEE",
            "AEP",
            "AES",
            "AET",
            "AFL",
            "AGN",
            "AIG",
            "AIV",
            "AIZ",
            "AKAM",
            "ALL",
            "ALTR",
            "ALXN",
            "AMAT",
            "AMD",
            "AMGN",
            "AMP",
            "AMT",
            "AMZN",
            "AN",
            "ANF",
            "ANR",
            "AON",
            "APA",
            "APC",
            "APD",
            "APH",
            "APOL",
            "ARG",
            "ATI",
            "AVB",
            "AVP",
            "AVY",
            "AXP",
            "AZO",
            "BA",
            "BAC",
            "BAX",
            "BBBY",
            "BBT",
            "BBY",
            "BCR",
            "BDX",
            "BEAM",
            "BEN",
            "BFB",
            "BHI",
            "BIG",
            "BIIB",
            "BK",
            "BLK",
            "BLL",
            "BMC",
            "BMS",
            "BMY",
            "BRCM",
            "BRK",
            "BSX",
            "BTU",
            "BWA",
            "BXP",
            "C",
            "CA",
            "CAG",
            "CAH",
            "CAM",
            "CAT",
            "CB",
            "CBE",
            "CBG",
            "CBS",
            "CCE",
            "CCI",
            "CCL",
            "CELG",
            "CERN",
            "CF",
            "CFN",
            "CHK",
            "CHRW",
            "CI",
            "CINF",
            "CL",
            "CLF",
            "CLX",
            "CMA",
            "CMCSA",
            "CME",
            "CMG",
            "CMI",
            "CMS",
            "CNP",
            "CNX",
            "COF",
            "COG",
            "COH",
            "COL",
            "COP",
            "COST",
            "COV",
            "CPB",
            "CRM",
            "CSC",
            "CSCO",
            "CSX",
            "CTAS",
            "CTL",
            "CTSH",
            "CTXS",
            "CVC",
            "CVH",
            "CVS",
            "CVX",
            "D",
            "DD",
            "DE",
            "DELL",
            "DF",
            "DFS",
            "DGX",
            "DHI",
            "DHR",
            "DIS",
            "DISCA",
            "DLTR",
            "DNB",
            "DNR",
            "DO",
            "DOV",
            "DOW",
            "DPS",
            "DRI",
            "DTE",
            "DTV",
            "DUK",
            "DV",
            "DVA",
            "DVN",
            "EA",
            "EBAY",
            "ECL",
            "ED",
            "EFX",
            "EIX",
            "EL",
            "EMC",
            "EMN",
            "EMR",
            "EOG",
            "EQR",
            "EQT",
            "ESRX",
            "ETFC",
            "ETN",
            "ETR",
            "EW",
            "EXC",
            "EXPD",
            "EXPE",
            "F",
            "FAST",
            "FCX",
            "FDO",
            "FDX",
            "FE",
            "FFIV",
            "FHN",
            "FII",
            "FIS",
            "FISV",
            "FITB",
            "FLIR",
            "FLR",
            "FLS",
            "FMC",
            "FOSL",
            "FRX",
            "FSLR",
            "FTI",
            "FTR",
            "GAS",
            "GCI",
            "GD",
            "GE",
            "GILD",
            "GIS",
            "GLW",
            "GME",
            "GNW",
            "GOOG",
            "GPC",
            "GPS",
            "GR",
            "GS",
            "GT",
            "GWW",
            "HAL",
            "HAR",
            "HAS",
            "HBAN",
            "HCBK",
            "HCN",
            "HCP",
            "HD",
            "HES",
            "HIG",
            "HNZ",
            "HOG",
            "HON",
            "HOT",
            "HP",
            "HPQ",
            "HRB",
            "HRL",
            "HRS",
            "HSP",
            "HST",
            "HSY",
            "HUM",
            "IBM",
            "ICE",
            "IFF",
            "IGT",
            "INTC",
            "INTU",
            "IP",
            "IPG",
            "IR",
            "IRM",
            "ISRG",
            "ITW",
            "IVZ",
            "JBL",
            "JCI",
            "JCP",
            "JDSU",
            "JEC",
            "JNJ",
            "JNPR",
            "JOY",
            "JPM",
            "JWN",
            "K",
            "KEY",
            "KFT",
            "KIM",
            "KLAC",
            "KMB",
            "KMI",
            "KMX",
            "KO",
            "KR",
            "KSS",
            "L",
            "LEG",
            "LEN",
            "LH",
            "LIFE",
            "LLL",
            "LLTC",
            "LLY",
            "LM",
            "LMT",
            "LNC",
            "LO",
            "LOW",
            "LRCX",
            "LSI",
            "LTD",
            "LUK",
            "LUV",
            "LXK",
            "M",
            "MA",
            "MAR",
            "MAS",
            "MAT",
            "MCD",
            "MCHP",
            "MCK",
            "MCO",
            "MDT",
            "MET",
            "MHP",
            "MJN",
            "MKC",
            "MMC",
            "MMM",
            "MNST",
            "MO",
            "MOLX",
            "MON",
            "MOS",
            "MPC",
            "MRK",
            "MRO",
            "MS",
            "MSFT",
            "MSI",
            "MTB",
            "MU",
            "MUR",
            "MWV",
            "MYL",
            "NBL",
            "NBR",
            "NDAQ",
            "NE",
            "NEE",
            "NEM",
            "NFLX",
            "NFX",
            "NI",
            "NKE",
            "NOC",
            "NOV",
            "NRG",
            "NSC",
            "NTAP",
            "NTRS",
            "NU",
            "NUE",
            "NVDA",
            "NWL",
            "NWSA",
            "NYX",
            "OI",
            "OKE",
            "OMC",
            "ORCL",
            "ORLY",
            "OXY",
            "PAYX",
            "PBCT",
            "PBI",
            "PCAR",
            "PCG",
            "PCL",
            "PCLN",
            "PCP",
            "PCS",
            "PDCO",
            "PEG",
            "PEP",
            "PFE",
            "PFG",
            "PG",
            "PGR",
            "PH",
            "PHM",
            "PKI",
            "PLD",
            "PLL",
            "PM",
            "PNC",
            "PNW",
            "POM",
            "PPG",
            "PPL",
            "PRGO",
            "PRU",
            "PSA",
            "PSX",
            "PWR",
            "PX",
            "PXD",
            "QCOM",
            "QEP",
            "R",
            "RAI",
            "RDC",
            "RF",
            "RHI",
            "RHT",
            "RL",
            "ROK",
            "ROP",
            "ROST",
            "RRC",
            "RRD",
            "RSG",
            "RTN",
            "S",
            "SAI",
            "SBUX",
            "SCG",
            "SCHW",
            "SE",
            "SEE",
            "SHLD",
            "SHW",
            "SIAL",
            "SJM",
            "SLB",
            "SLM",
            "SNA",
            "SNDK",
            "SNI",
            "SO",
            "SPG",
            "SPLS",
            "SRCL",
            "SRE",
            "STI",
            "STJ",
            "STT",
            "STX",
            "STZ",
            "SUN",
            "SWK",
            "SWN",
            "SWY",
            "SYK",
            "SYMC",
            "SYY",
            "T",
            "TAP",
            "TDC",
            "TE",
            "TEG",
            "TEL",
            "TER",
            "TGT",
            "THC",
            "TIE",
            "TIF",
            "TJX",
            "TMK",
            "TMO",
            "TRIP",
            "TROW",
            "TRV",
            "TSN",
            "TSO",
            "TSS",
            "TWC",
            "TWX",
            "TXN",
            "TXT",
            "TYC",
            "UNH",
            "UNM",
            "UNP",
            "UPS",
            "URBN",
            "USB",
            "UTX",
            "V",
            "VAR",
            "VFC",
            "VIAB",
            "VLO",
            "VMC",
            "VNO",
            "VRSN",
            "VTR",
            "VZ",
            "WAG",
            "WAT",
            "WDC",
            "WEC",
            "WFC",
            "WFM",
            "WHR",
            "WIN",
            "WLP",
            "WM",
            "WMB",
            "WMT",
            "WPI",
            "WPO",
            "WPX",
            "WU",
            "WY",
            "WYN",
            "WYNN",
            "X",
            "XEL",
            "XL",
            "XLNX",
            "XOM",
            "XRAY",
            "XRX",
            "XYL",
            "YHOO",
            "YUM",
            "ZION",
            "ZMH"});
            this.comboBoxStockTicker.Location = new System.Drawing.Point(98, 23);
            this.comboBoxStockTicker.Name = "comboBoxStockTicker";
            this.comboBoxStockTicker.Size = new System.Drawing.Size(200, 21);
            this.comboBoxStockTicker.Sorted = true;
            this.comboBoxStockTicker.TabIndex = 19;
            this.comboBoxStockTicker.SelectedIndexChanged += new System.EventHandler(this.comboBoxStockTicker_SelectedIndexChanged);
            this.comboBoxStockTicker.Click += new System.EventHandler(this.comboBoxStockTicker_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 320);
            this.Controls.Add(this.comboBoxStockTicker);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.groupBoxResolution);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelStockTicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxResolution.ResumeLayout(false);
            this.groupBoxResolution.PerformLayout();
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStockTicker;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.RadioButton radioButtonDownloadData;
        private System.Windows.Forms.RadioButton radioButtonDisplayData;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.RadioButton radioButtonDaily;
        private System.Windows.Forms.RadioButton radioButtonWeekly;
        private System.Windows.Forms.RadioButton radioButtonMonthly;
        private System.Windows.Forms.GroupBox groupBoxResolution;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ComboBox comboBoxStockTicker;
    }
}

