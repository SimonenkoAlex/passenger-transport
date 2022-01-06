namespace WFAPassengerTransport
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnBus = new System.Windows.Forms.Button();
            this.btnTaxi = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBus
            // 
            this.btnBus.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBus.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBus.Location = new System.Drawing.Point(175, 100);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(250, 50);
            this.btnBus.TabIndex = 0;
            this.btnBus.Text = "Автобус";
            this.btnBus.UseVisualStyleBackColor = true;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click);
            // 
            // btnTaxi
            // 
            this.btnTaxi.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTaxi.Location = new System.Drawing.Point(175, 200);
            this.btnTaxi.Name = "btnTaxi";
            this.btnTaxi.Size = new System.Drawing.Size(250, 50);
            this.btnTaxi.TabIndex = 0;
            this.btnTaxi.Text = "Такси";
            this.btnTaxi.UseVisualStyleBackColor = true;
            this.btnTaxi.Click += new System.EventHandler(this.btnTaxi_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrain.Location = new System.Drawing.Point(175, 300);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(250, 50);
            this.btnTrain.TabIndex = 0;
            this.btnTrain.Text = "Электричка";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnTaxi);
            this.Controls.Add(this.btnBus);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пассажирский транспорт";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.Button btnTaxi;
        private System.Windows.Forms.Button btnTrain;
    }
}

