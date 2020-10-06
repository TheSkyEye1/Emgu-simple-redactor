namespace lab3_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.IMG1 = new Emgu.CV.UI.ImageBox();
            this.IMG2 = new Emgu.CV.UI.ImageBox();
            this.channelb = new System.Windows.Forms.Button();
            this.loadbutton = new System.Windows.Forms.Button();
            this.chnltrack = new System.Windows.Forms.TrackBar();
            this.lb1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cnn = new System.Windows.Forms.Label();
            this.brt = new System.Windows.Forms.TrackBar();
            this.brtl = new System.Windows.Forms.Label();
            this.bright = new System.Windows.Forms.Button();
            this.cont = new System.Windows.Forms.TrackBar();
            this.conl = new System.Windows.Forms.Label();
            this.contra = new System.Windows.Forms.Button();
            this.sepiah = new System.Windows.Forms.Button();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.opb = new System.Windows.Forms.Button();
            this.img1c = new System.Windows.Forms.TrackBar();
            this.img2c = new System.Windows.Forms.TrackBar();
            this.img1l = new System.Windows.Forms.Label();
            this.img2l = new System.Windows.Forms.Label();
            this.loadsecond = new System.Windows.Forms.Button();
            this.medblur = new System.Windows.Forms.Button();
            this.sharp = new System.Windows.Forms.Button();
            this.embosb = new System.Windows.Forms.Button();
            this.edgeb = new System.Windows.Forms.Button();
            this.aquabut = new System.Windows.Forms.Button();
            this.mask1 = new System.Windows.Forms.Button();
            this.edg = new System.Windows.Forms.Button();
            this.cartfb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IMG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chnltrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2c)).BeginInit();
            this.SuspendLayout();
            // 
            // IMG1
            // 
            this.IMG1.Location = new System.Drawing.Point(12, 12);
            this.IMG1.Name = "IMG1";
            this.IMG1.Size = new System.Drawing.Size(640, 480);
            this.IMG1.TabIndex = 2;
            this.IMG1.TabStop = false;
            // 
            // IMG2
            // 
            this.IMG2.Location = new System.Drawing.Point(832, 12);
            this.IMG2.Name = "IMG2";
            this.IMG2.Size = new System.Drawing.Size(640, 480);
            this.IMG2.TabIndex = 3;
            this.IMG2.TabStop = false;
            // 
            // channelb
            // 
            this.channelb.Location = new System.Drawing.Point(658, 43);
            this.channelb.Name = "channelb";
            this.channelb.Size = new System.Drawing.Size(168, 23);
            this.channelb.TabIndex = 4;
            this.channelb.Text = "Channel info";
            this.channelb.UseVisualStyleBackColor = true;
            this.channelb.Click += new System.EventHandler(this.channelb_Click);
            // 
            // loadbutton
            // 
            this.loadbutton.Location = new System.Drawing.Point(658, 12);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(168, 23);
            this.loadbutton.TabIndex = 5;
            this.loadbutton.Text = "Load image";
            this.loadbutton.UseVisualStyleBackColor = true;
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // chnltrack
            // 
            this.chnltrack.LargeChange = 1;
            this.chnltrack.Location = new System.Drawing.Point(658, 72);
            this.chnltrack.Maximum = 2;
            this.chnltrack.Name = "chnltrack";
            this.chnltrack.Size = new System.Drawing.Size(168, 45);
            this.chnltrack.TabIndex = 6;
            this.chnltrack.ValueChanged += new System.EventHandler(this.chnltrack_ValueChanged);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(791, 104);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 13);
            this.lb1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gray filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cnn
            // 
            this.cnn.AutoSize = true;
            this.cnn.Location = new System.Drawing.Point(667, 104);
            this.cnn.Name = "cnn";
            this.cnn.Size = new System.Drawing.Size(72, 13);
            this.cnn.TabIndex = 9;
            this.cnn.Text = "Channel: blue";
            // 
            // brt
            // 
            this.brt.Location = new System.Drawing.Point(658, 164);
            this.brt.Maximum = 510;
            this.brt.Name = "brt";
            this.brt.Size = new System.Drawing.Size(168, 45);
            this.brt.TabIndex = 10;
            this.brt.Value = 256;
            this.brt.Scroll += new System.EventHandler(this.brt_Scroll);
            // 
            // brtl
            // 
            this.brtl.AutoSize = true;
            this.brtl.Location = new System.Drawing.Point(804, 196);
            this.brtl.Name = "brtl";
            this.brtl.Size = new System.Drawing.Size(13, 13);
            this.brtl.TabIndex = 11;
            this.brtl.Text = "0";
            // 
            // bright
            // 
            this.bright.Location = new System.Drawing.Point(658, 212);
            this.bright.Name = "bright";
            this.bright.Size = new System.Drawing.Size(168, 23);
            this.bright.TabIndex = 12;
            this.bright.Text = "Brightness";
            this.bright.UseVisualStyleBackColor = true;
            this.bright.Click += new System.EventHandler(this.bright_Click);
            // 
            // cont
            // 
            this.cont.Location = new System.Drawing.Point(658, 241);
            this.cont.Maximum = 50;
            this.cont.Minimum = 1;
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(168, 45);
            this.cont.TabIndex = 50;
            this.cont.Value = 10;
            this.cont.Scroll += new System.EventHandler(this.cnt_Scroll);
            // 
            // conl
            // 
            this.conl.AutoSize = true;
            this.conl.Location = new System.Drawing.Point(798, 273);
            this.conl.Name = "conl";
            this.conl.Size = new System.Drawing.Size(13, 13);
            this.conl.TabIndex = 51;
            this.conl.Text = "1";
            // 
            // contra
            // 
            this.contra.Location = new System.Drawing.Point(658, 292);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(168, 23);
            this.contra.TabIndex = 52;
            this.contra.Text = "Contrast";
            this.contra.UseVisualStyleBackColor = true;
            this.contra.Click += new System.EventHandler(this.contra_Click);
            // 
            // sepiah
            // 
            this.sepiah.Location = new System.Drawing.Point(12, 506);
            this.sepiah.Name = "sepiah";
            this.sepiah.Size = new System.Drawing.Size(300, 23);
            this.sepiah.TabIndex = 53;
            this.sepiah.Text = "Sepiah";
            this.sepiah.UseVisualStyleBackColor = true;
            this.sepiah.Click += new System.EventHandler(this.sepiah_Click);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(658, 321);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(62, 17);
            this.rb1.TabIndex = 54;
            this.rb1.TabStop = true;
            this.rb1.Text = "addition";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.Click += new System.EventHandler(this.rb1_Click);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(658, 344);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(71, 17);
            this.rb2.TabIndex = 55;
            this.rb2.Text = "exception";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.Click += new System.EventHandler(this.rb2_Click);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(658, 367);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(79, 17);
            this.rb3.TabIndex = 56;
            this.rb3.Text = "intersection";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.Click += new System.EventHandler(this.rb3_Click);
            // 
            // opb
            // 
            this.opb.Location = new System.Drawing.Point(757, 358);
            this.opb.Name = "opb";
            this.opb.Size = new System.Drawing.Size(69, 26);
            this.opb.TabIndex = 57;
            this.opb.Text = "Operate";
            this.opb.UseVisualStyleBackColor = true;
            this.opb.Click += new System.EventHandler(this.opb_Click);
            // 
            // img1c
            // 
            this.img1c.Location = new System.Drawing.Point(658, 390);
            this.img1c.Name = "img1c";
            this.img1c.Size = new System.Drawing.Size(168, 45);
            this.img1c.TabIndex = 10;
            this.img1c.Value = 5;
            this.img1c.Scroll += new System.EventHandler(this.img1c_Scroll);
            // 
            // img2c
            // 
            this.img2c.Location = new System.Drawing.Point(658, 441);
            this.img2c.Name = "img2c";
            this.img2c.Size = new System.Drawing.Size(168, 45);
            this.img2c.TabIndex = 59;
            this.img2c.Value = 5;
            this.img2c.Scroll += new System.EventHandler(this.img2c_Scroll);
            // 
            // img1l
            // 
            this.img1l.AutoSize = true;
            this.img1l.Location = new System.Drawing.Point(804, 422);
            this.img1l.Name = "img1l";
            this.img1l.Size = new System.Drawing.Size(22, 13);
            this.img1l.TabIndex = 60;
            this.img1l.Text = "0.5";
            // 
            // img2l
            // 
            this.img2l.AutoSize = true;
            this.img2l.Location = new System.Drawing.Point(804, 473);
            this.img2l.Name = "img2l";
            this.img2l.Size = new System.Drawing.Size(22, 13);
            this.img2l.TabIndex = 61;
            this.img2l.Text = "0.5";
            // 
            // loadsecond
            // 
            this.loadsecond.Location = new System.Drawing.Point(757, 326);
            this.loadsecond.Name = "loadsecond";
            this.loadsecond.Size = new System.Drawing.Size(69, 26);
            this.loadsecond.TabIndex = 62;
            this.loadsecond.Text = "Load";
            this.loadsecond.UseVisualStyleBackColor = true;
            this.loadsecond.Click += new System.EventHandler(this.loadsecond_Click);
            // 
            // medblur
            // 
            this.medblur.Location = new System.Drawing.Point(12, 535);
            this.medblur.Name = "medblur";
            this.medblur.Size = new System.Drawing.Size(300, 23);
            this.medblur.TabIndex = 63;
            this.medblur.Text = "Blur filter";
            this.medblur.UseVisualStyleBackColor = true;
            this.medblur.Click += new System.EventHandler(this.medblur_Click);
            // 
            // sharp
            // 
            this.sharp.Location = new System.Drawing.Point(318, 535);
            this.sharp.Name = "sharp";
            this.sharp.Size = new System.Drawing.Size(300, 23);
            this.sharp.TabIndex = 64;
            this.sharp.Text = "Add sharpness";
            this.sharp.UseVisualStyleBackColor = true;
            this.sharp.Click += new System.EventHandler(this.sharp_Click);
            // 
            // embosb
            // 
            this.embosb.Location = new System.Drawing.Point(170, 564);
            this.embosb.Name = "embosb";
            this.embosb.Size = new System.Drawing.Size(300, 23);
            this.embosb.TabIndex = 65;
            this.embosb.Text = "Emboss filter";
            this.embosb.UseVisualStyleBackColor = true;
            this.embosb.Click += new System.EventHandler(this.embosb_Click);
            // 
            // edgeb
            // 
            this.edgeb.Location = new System.Drawing.Point(318, 506);
            this.edgeb.Name = "edgeb";
            this.edgeb.Size = new System.Drawing.Size(300, 23);
            this.edgeb.TabIndex = 66;
            this.edgeb.Text = "Edge filter";
            this.edgeb.UseVisualStyleBackColor = true;
            this.edgeb.Click += new System.EventHandler(this.edgeb_Click);
            // 
            // aquabut
            // 
            this.aquabut.Location = new System.Drawing.Point(852, 504);
            this.aquabut.Name = "aquabut";
            this.aquabut.Size = new System.Drawing.Size(88, 53);
            this.aquabut.TabIndex = 67;
            this.aquabut.Text = "Watercolor Filter";
            this.aquabut.UseVisualStyleBackColor = true;
            this.aquabut.Click += new System.EventHandler(this.aquabut_Click);
            // 
            // mask1
            // 
            this.mask1.Location = new System.Drawing.Point(852, 563);
            this.mask1.Name = "mask1";
            this.mask1.Size = new System.Drawing.Size(88, 23);
            this.mask1.TabIndex = 68;
            this.mask1.Text = "Load mask";
            this.mask1.UseVisualStyleBackColor = true;
            this.mask1.Click += new System.EventHandler(this.mask1_Click);
            // 
            // edg
            // 
            this.edg.Location = new System.Drawing.Point(658, 492);
            this.edg.Name = "edg";
            this.edg.Size = new System.Drawing.Size(168, 23);
            this.edg.TabIndex = 71;
            this.edg.Text = "Edgy";
            this.edg.UseVisualStyleBackColor = true;
            this.edg.Click += new System.EventHandler(this.edg_Click);
            // 
            // cartfb
            // 
            this.cartfb.Location = new System.Drawing.Point(946, 504);
            this.cartfb.Name = "cartfb";
            this.cartfb.Size = new System.Drawing.Size(88, 82);
            this.cartfb.TabIndex = 72;
            this.cartfb.Text = "Cartoony Filter";
            this.cartfb.UseVisualStyleBackColor = true;
            this.cartfb.Click += new System.EventHandler(this.cartfb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 590);
            this.Controls.Add(this.cartfb);
            this.Controls.Add(this.edg);
            this.Controls.Add(this.mask1);
            this.Controls.Add(this.aquabut);
            this.Controls.Add(this.edgeb);
            this.Controls.Add(this.embosb);
            this.Controls.Add(this.sharp);
            this.Controls.Add(this.medblur);
            this.Controls.Add(this.loadsecond);
            this.Controls.Add(this.img2l);
            this.Controls.Add(this.img1l);
            this.Controls.Add(this.img2c);
            this.Controls.Add(this.img1c);
            this.Controls.Add(this.opb);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.sepiah);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.conl);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.bright);
            this.Controls.Add(this.brtl);
            this.Controls.Add(this.brt);
            this.Controls.Add(this.cnn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.chnltrack);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.channelb);
            this.Controls.Add(this.IMG2);
            this.Controls.Add(this.IMG1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.IMG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chnltrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2c)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox IMG1;
        private Emgu.CV.UI.ImageBox IMG2;
        private System.Windows.Forms.Button channelb;
        private System.Windows.Forms.Button loadbutton;
        private System.Windows.Forms.TrackBar chnltrack;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cnn;
        private System.Windows.Forms.TrackBar brt;
        private System.Windows.Forms.Label brtl;
        private System.Windows.Forms.Button bright;
        private System.Windows.Forms.TrackBar cont;
        private System.Windows.Forms.Label conl;
        private System.Windows.Forms.Button contra;
        private System.Windows.Forms.Button sepiah;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.Button opb;
        private System.Windows.Forms.TrackBar img1c;
        private System.Windows.Forms.TrackBar img2c;
        private System.Windows.Forms.Label img1l;
        private System.Windows.Forms.Label img2l;
        private System.Windows.Forms.Button loadsecond;
        private System.Windows.Forms.Button medblur;
        private System.Windows.Forms.Button sharp;
        private System.Windows.Forms.Button embosb;
        private System.Windows.Forms.Button edgeb;
        private System.Windows.Forms.Button aquabut;
        private System.Windows.Forms.Button mask1;
        private System.Windows.Forms.Button edg;
        private System.Windows.Forms.Button cartfb;
    }
}

