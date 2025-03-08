namespace gk___projekt_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            Canvas = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            BetaTextBox = new TextBox();
            BetaAngleSlider = new TrackBar();
            AlphaTextBox = new TextBox();
            textBox1 = new TextBox();
            ResolutionTextBox = new TextBox();
            AlphaAngleSlider = new TrackBar();
            ResolutionSlider = new TrackBar();
            groupBox2 = new GroupBox();
            textBox10 = new TextBox();
            MTextBox = new TextBox();
            textBox9 = new TextBox();
            textBox7 = new TextBox();
            MSlider = new TrackBar();
            KsTextBox = new TextBox();
            KdTextBox = new TextBox();
            KdSlider = new TrackBar();
            KsSlider = new TrackBar();
            groupBox3 = new GroupBox();
            ControlPointsCheckBox = new CheckBox();
            PolygonMeshCheckBox = new CheckBox();
            groupBox4 = new GroupBox();
            NormalMapCheckBox = new CheckBox();
            TextureCheckBox = new CheckBox();
            SelectTextureButton = new Button();
            textBox3 = new TextBox();
            SelectNormalMapButton = new Button();
            SurfaceColorButton = new Button();
            groupBox5 = new GroupBox();
            MLigthSlider = new TrackBar();
            ReflectorCheckBox = new CheckBox();
            AnimationCheckBox = new CheckBox();
            LightDistanceTextBox = new TextBox();
            LightDistanceSlider = new TrackBar();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            LightColorButton = new Button();
            SurfaceWaveCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BetaAngleSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlphaAngleSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResolutionSlider).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KdSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KsSlider).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MLigthSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LightDistanceSlider).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(Canvas);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(2138, 1159);
            splitContainer1.SplitterDistance = 1611;
            splitContainer1.TabIndex = 0;
            // 
            // Canvas
            // 
            Canvas.Dock = DockStyle.Fill;
            Canvas.Location = new Point(0, 0);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(1611, 1159);
            Canvas.TabIndex = 0;
            Canvas.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox4, 0, 3);
            tableLayoutPanel1.Controls.Add(groupBox5, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 280F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 280F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.Size = new Size(523, 1159);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(BetaTextBox);
            groupBox1.Controls.Add(BetaAngleSlider);
            groupBox1.Controls.Add(AlphaTextBox);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(ResolutionTextBox);
            groupBox1.Controls.Add(AlphaAngleSlider);
            groupBox1.Controls.Add(ResolutionSlider);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ImeMode = ImeMode.Off;
            groupBox1.Location = new Point(3, 0);
            groupBox1.Margin = new Padding(3, 0, 3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 0, 3, 3);
            groupBox1.Size = new Size(517, 277);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Triangulation";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(3, 200);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(81, 24);
            textBox4.TabIndex = 6;
            textBox4.Text = "Beta";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(3, 120);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(82, 24);
            textBox2.TabIndex = 5;
            textBox2.Text = "Alpha";
            // 
            // BetaTextBox
            // 
            BetaTextBox.BorderStyle = BorderStyle.None;
            BetaTextBox.Location = new Point(436, 200);
            BetaTextBox.Margin = new Padding(3, 0, 3, 0);
            BetaTextBox.Name = "BetaTextBox";
            BetaTextBox.ReadOnly = true;
            BetaTextBox.Size = new Size(75, 24);
            BetaTextBox.TabIndex = 1;
            BetaTextBox.Text = "0";
            // 
            // BetaAngleSlider
            // 
            BetaAngleSlider.Location = new Point(96, 200);
            BetaAngleSlider.Maximum = 180;
            BetaAngleSlider.Minimum = -180;
            BetaAngleSlider.Name = "BetaAngleSlider";
            BetaAngleSlider.Size = new Size(334, 69);
            BetaAngleSlider.TabIndex = 2;
            BetaAngleSlider.TickStyle = TickStyle.None;
            BetaAngleSlider.Scroll += BetaAngleSlider_Scroll;
            // 
            // AlphaTextBox
            // 
            AlphaTextBox.BorderStyle = BorderStyle.None;
            AlphaTextBox.Location = new Point(436, 120);
            AlphaTextBox.Name = "AlphaTextBox";
            AlphaTextBox.ReadOnly = true;
            AlphaTextBox.Size = new Size(75, 24);
            AlphaTextBox.TabIndex = 4;
            AlphaTextBox.Text = "0";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(3, 40);
            textBox1.Margin = new Padding(3, 3, 0, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 24);
            textBox1.TabIndex = 2;
            textBox1.Text = "Resolution";
            // 
            // ResolutionTextBox
            // 
            ResolutionTextBox.BorderStyle = BorderStyle.None;
            ResolutionTextBox.Location = new Point(436, 40);
            ResolutionTextBox.Name = "ResolutionTextBox";
            ResolutionTextBox.ReadOnly = true;
            ResolutionTextBox.Size = new Size(75, 24);
            ResolutionTextBox.TabIndex = 1;
            ResolutionTextBox.Text = "32";
            // 
            // AlphaAngleSlider
            // 
            AlphaAngleSlider.Location = new Point(96, 120);
            AlphaAngleSlider.Maximum = 180;
            AlphaAngleSlider.Minimum = -180;
            AlphaAngleSlider.Name = "AlphaAngleSlider";
            AlphaAngleSlider.Size = new Size(334, 69);
            AlphaAngleSlider.TabIndex = 2;
            AlphaAngleSlider.TickStyle = TickStyle.None;
            AlphaAngleSlider.Scroll += AlphaAngleSlider_Scroll;
            // 
            // ResolutionSlider
            // 
            ResolutionSlider.Location = new Point(96, 40);
            ResolutionSlider.Maximum = 64;
            ResolutionSlider.Minimum = 2;
            ResolutionSlider.Name = "ResolutionSlider";
            ResolutionSlider.Size = new Size(334, 69);
            ResolutionSlider.TabIndex = 0;
            ResolutionSlider.TickStyle = TickStyle.None;
            ResolutionSlider.Value = 32;
            ResolutionSlider.Scroll += ResolutionSlider_Scroll;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(MTextBox);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(MSlider);
            groupBox2.Controls.Add(KsTextBox);
            groupBox2.Controls.Add(KdTextBox);
            groupBox2.Controls.Add(KdSlider);
            groupBox2.Controls.Add(KsSlider);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 280);
            groupBox2.Margin = new Padding(3, 0, 3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 0, 3, 3);
            groupBox2.Size = new Size(517, 277);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Reflection";
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Location = new Point(9, 200);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(88, 24);
            textBox10.TabIndex = 5;
            textBox10.Text = "M";
            // 
            // MTextBox
            // 
            MTextBox.BorderStyle = BorderStyle.None;
            MTextBox.Location = new Point(436, 200);
            MTextBox.Name = "MTextBox";
            MTextBox.ReadOnly = true;
            MTextBox.Size = new Size(75, 24);
            MTextBox.TabIndex = 2;
            MTextBox.Text = "50";
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Location = new Point(6, 120);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(93, 24);
            textBox9.TabIndex = 4;
            textBox9.Text = "Ks";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(6, 40);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(91, 24);
            textBox7.TabIndex = 3;
            textBox7.Text = "Kd";
            // 
            // MSlider
            // 
            MSlider.Location = new Point(99, 200);
            MSlider.Maximum = 100;
            MSlider.Name = "MSlider";
            MSlider.Size = new Size(331, 69);
            MSlider.TabIndex = 0;
            MSlider.TickStyle = TickStyle.None;
            MSlider.Value = 50;
            MSlider.Scroll += MSlider_Scroll;
            // 
            // KsTextBox
            // 
            KsTextBox.BorderStyle = BorderStyle.None;
            KsTextBox.Location = new Point(436, 120);
            KsTextBox.Name = "KsTextBox";
            KsTextBox.ReadOnly = true;
            KsTextBox.Size = new Size(75, 24);
            KsTextBox.TabIndex = 2;
            KsTextBox.Text = "0,5";
            // 
            // KdTextBox
            // 
            KdTextBox.BorderStyle = BorderStyle.None;
            KdTextBox.Location = new Point(436, 40);
            KdTextBox.Name = "KdTextBox";
            KdTextBox.ReadOnly = true;
            KdTextBox.Size = new Size(75, 24);
            KdTextBox.TabIndex = 2;
            KdTextBox.Text = "0,5";
            // 
            // KdSlider
            // 
            KdSlider.Location = new Point(99, 40);
            KdSlider.Maximum = 100;
            KdSlider.Name = "KdSlider";
            KdSlider.Size = new Size(334, 69);
            KdSlider.TabIndex = 0;
            KdSlider.TickStyle = TickStyle.None;
            KdSlider.Value = 50;
            KdSlider.Scroll += KdSlider_Scroll;
            // 
            // KsSlider
            // 
            KsSlider.Location = new Point(96, 120);
            KsSlider.Maximum = 100;
            KsSlider.Name = "KsSlider";
            KsSlider.Size = new Size(334, 69);
            KsSlider.TabIndex = 0;
            KsSlider.TickStyle = TickStyle.None;
            KsSlider.Value = 50;
            KsSlider.Scroll += KsSlider_Scroll;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ControlPointsCheckBox);
            groupBox3.Controls.Add(PolygonMeshCheckBox);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 563);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(517, 94);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rendering settings";
            // 
            // ControlPointsCheckBox
            // 
            ControlPointsCheckBox.AutoSize = true;
            ControlPointsCheckBox.Location = new Point(280, 40);
            ControlPointsCheckBox.Name = "ControlPointsCheckBox";
            ControlPointsCheckBox.Size = new Size(198, 29);
            ControlPointsCheckBox.TabIndex = 1;
            ControlPointsCheckBox.Text = "Show control points";
            ControlPointsCheckBox.UseVisualStyleBackColor = true;
            ControlPointsCheckBox.CheckedChanged += ControlPointsCheckBox_CheckedChanged;
            // 
            // PolygonMeshCheckBox
            // 
            PolygonMeshCheckBox.AutoSize = true;
            PolygonMeshCheckBox.Location = new Point(9, 40);
            PolygonMeshCheckBox.Name = "PolygonMeshCheckBox";
            PolygonMeshCheckBox.Size = new Size(202, 29);
            PolygonMeshCheckBox.TabIndex = 0;
            PolygonMeshCheckBox.Text = "Show polygon mesh";
            PolygonMeshCheckBox.UseVisualStyleBackColor = true;
            PolygonMeshCheckBox.CheckedChanged += PolygonMeshCheckBox_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(SurfaceWaveCheckBox);
            groupBox4.Controls.Add(NormalMapCheckBox);
            groupBox4.Controls.Add(TextureCheckBox);
            groupBox4.Controls.Add(SelectTextureButton);
            groupBox4.Controls.Add(textBox3);
            groupBox4.Controls.Add(SelectNormalMapButton);
            groupBox4.Controls.Add(SurfaceColorButton);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 663);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(517, 234);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Texture Settings";
            // 
            // NormalMapCheckBox
            // 
            NormalMapCheckBox.AutoSize = true;
            NormalMapCheckBox.Location = new Point(280, 100);
            NormalMapCheckBox.Name = "NormalMapCheckBox";
            NormalMapCheckBox.Size = new Size(192, 29);
            NormalMapCheckBox.TabIndex = 10;
            NormalMapCheckBox.Text = "Enable normal map";
            NormalMapCheckBox.UseVisualStyleBackColor = true;
            NormalMapCheckBox.CheckedChanged += NormalMapCheckBox_CheckedChanged;
            // 
            // TextureCheckBox
            // 
            TextureCheckBox.AutoSize = true;
            TextureCheckBox.Location = new Point(9, 100);
            TextureCheckBox.Name = "TextureCheckBox";
            TextureCheckBox.Size = new Size(149, 29);
            TextureCheckBox.TabIndex = 9;
            TextureCheckBox.Text = "Enable texture";
            TextureCheckBox.UseVisualStyleBackColor = true;
            TextureCheckBox.CheckedChanged += TextureCheckBox_CheckedChanged;
            // 
            // SelectTextureButton
            // 
            SelectTextureButton.Enabled = false;
            SelectTextureButton.Location = new Point(9, 160);
            SelectTextureButton.Name = "SelectTextureButton";
            SelectTextureButton.Size = new Size(195, 34);
            SelectTextureButton.TabIndex = 8;
            SelectTextureButton.Text = "Select texture";
            SelectTextureButton.UseVisualStyleBackColor = true;
            SelectTextureButton.Click += SelectTextureButton_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(9, 40);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(122, 24);
            textBox3.TabIndex = 2;
            textBox3.Text = "Surface color";
            // 
            // SelectNormalMapButton
            // 
            SelectNormalMapButton.Enabled = false;
            SelectNormalMapButton.Location = new Point(280, 160);
            SelectNormalMapButton.Name = "SelectNormalMapButton";
            SelectNormalMapButton.Size = new Size(195, 34);
            SelectNormalMapButton.TabIndex = 7;
            SelectNormalMapButton.Text = "Select normal map";
            SelectNormalMapButton.UseVisualStyleBackColor = true;
            SelectNormalMapButton.Click += SelectNormalMapButton_Click;
            // 
            // SurfaceColorButton
            // 
            SurfaceColorButton.BackColor = Color.Green;
            SurfaceColorButton.Location = new Point(170, 40);
            SurfaceColorButton.Name = "SurfaceColorButton";
            SurfaceColorButton.Size = new Size(34, 34);
            SurfaceColorButton.TabIndex = 3;
            SurfaceColorButton.UseVisualStyleBackColor = false;
            SurfaceColorButton.Click += SurfaceColorButton_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(MLigthSlider);
            groupBox5.Controls.Add(ReflectorCheckBox);
            groupBox5.Controls.Add(AnimationCheckBox);
            groupBox5.Controls.Add(LightDistanceTextBox);
            groupBox5.Controls.Add(LightDistanceSlider);
            groupBox5.Controls.Add(textBox6);
            groupBox5.Controls.Add(textBox5);
            groupBox5.Controls.Add(LightColorButton);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(3, 903);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(517, 253);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Light";
            // 
            // MLigthSlider
            // 
            MLigthSlider.Location = new Point(123, 175);
            MLigthSlider.Maximum = 100;
            MLigthSlider.Minimum = 1;
            MLigthSlider.Name = "MLigthSlider";
            MLigthSlider.Size = new Size(310, 69);
            MLigthSlider.TabIndex = 10;
            MLigthSlider.Value = 1;
            MLigthSlider.Scroll += MLigthSlider_Scroll;
            // 
            // ReflectorCheckBox
            // 
            ReflectorCheckBox.AutoSize = true;
            ReflectorCheckBox.Location = new Point(10, 180);
            ReflectorCheckBox.Name = "ReflectorCheckBox";
            ReflectorCheckBox.Size = new Size(107, 29);
            ReflectorCheckBox.TabIndex = 9;
            ReflectorCheckBox.Text = "Reflector";
            ReflectorCheckBox.UseVisualStyleBackColor = true;
            ReflectorCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // AnimationCheckBox
            // 
            AnimationCheckBox.AutoSize = true;
            AnimationCheckBox.Location = new Point(280, 40);
            AnimationCheckBox.Name = "AnimationCheckBox";
            AnimationCheckBox.Size = new Size(120, 29);
            AnimationCheckBox.TabIndex = 6;
            AnimationCheckBox.Text = "Animation";
            AnimationCheckBox.UseVisualStyleBackColor = true;
            AnimationCheckBox.CheckedChanged += AnimationCheckBox_CheckedChanged;
            // 
            // LightDistanceTextBox
            // 
            LightDistanceTextBox.BorderStyle = BorderStyle.None;
            LightDistanceTextBox.Location = new Point(436, 120);
            LightDistanceTextBox.Name = "LightDistanceTextBox";
            LightDistanceTextBox.ReadOnly = true;
            LightDistanceTextBox.Size = new Size(62, 24);
            LightDistanceTextBox.TabIndex = 8;
            LightDistanceTextBox.Text = "500";
            // 
            // LightDistanceSlider
            // 
            LightDistanceSlider.Location = new Point(96, 120);
            LightDistanceSlider.Maximum = 1000;
            LightDistanceSlider.Minimum = 100;
            LightDistanceSlider.Name = "LightDistanceSlider";
            LightDistanceSlider.Size = new Size(334, 69);
            LightDistanceSlider.TabIndex = 7;
            LightDistanceSlider.TickStyle = TickStyle.None;
            LightDistanceSlider.Value = 500;
            LightDistanceSlider.Scroll += LightDistanceSlider_Scroll;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(9, 120);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(88, 24);
            textBox6.TabIndex = 6;
            textBox6.Text = "Distance";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(9, 40);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(118, 24);
            textBox5.TabIndex = 4;
            textBox5.Text = "Light color";
            // 
            // LightColorButton
            // 
            LightColorButton.Location = new Point(170, 40);
            LightColorButton.Name = "LightColorButton";
            LightColorButton.Size = new Size(34, 34);
            LightColorButton.TabIndex = 5;
            LightColorButton.UseVisualStyleBackColor = true;
            LightColorButton.Click += LightColorButton_Click;
            // 
            // SurfaceWaveCheckBox
            // 
            SurfaceWaveCheckBox.AutoSize = true;
            SurfaceWaveCheckBox.Location = new Point(279, 40);
            SurfaceWaveCheckBox.Name = "SurfaceWaveCheckBox";
            SurfaceWaveCheckBox.Size = new Size(144, 29);
            SurfaceWaveCheckBox.TabIndex = 11;
            SurfaceWaveCheckBox.Text = "Surface Wave";
            SurfaceWaveCheckBox.UseVisualStyleBackColor = true;
            SurfaceWaveCheckBox.CheckedChanged += SurfaceWaveCheckBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2138, 1159);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Bezier Surface Renderer Mikołaj Karbowski";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BetaAngleSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlphaAngleSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)ResolutionSlider).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)KdSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)KsSlider).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MLigthSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)LightDistanceSlider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox Canvas;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TextBox ResolutionTextBox;
        private TrackBar ResolutionSlider;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox AlphaTextBox;
        private TrackBar AlphaAngleSlider;
        private TrackBar BetaAngleSlider;
        private TextBox BetaTextBox;
        private TextBox KsTextBox;
        private TrackBar KsSlider;
        private TextBox KdTextBox;
        private TrackBar KdSlider;
        private TextBox MTextBox;
        private TrackBar MSlider;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox7;
        private GroupBox groupBox3;
        private CheckBox ControlPointsCheckBox;
        private CheckBox PolygonMeshCheckBox;
        private TextBox textBox5;
        private Button SurfaceColorButton;
        private TextBox textBox3;
        private Button LightColorButton;
        private Button SelectNormalMapButton;
        private CheckBox AnimationCheckBox;
        private Button SelectTextureButton;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TrackBar LightDistanceSlider;
        private TextBox textBox6;
        private TextBox LightDistanceTextBox;
        private CheckBox NormalMapCheckBox;
        private CheckBox TextureCheckBox;
        private CheckBox ReflectorCheckBox;
        private TrackBar MLigthSlider;
        private CheckBox SurfaceWaveCheckBox;
    }
}
