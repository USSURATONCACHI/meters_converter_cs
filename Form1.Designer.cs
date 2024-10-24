namespace meters_converter_csharp2;

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
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
        textBox1 = new TextBox();
        button1 = new Button();
        comboBox1 = new ComboBox();
        label1 = new Label();
        groupBox1 = new GroupBox();
        radioButtonInches = new RadioButton();
        radioButtonFeet = new RadioButton();
        radioButtonKm = new RadioButton();
        radioButtonMeters = new RadioButton();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new Point(14, 12);
        textBox1.Margin = new Padding(4, 3, 4, 3);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(117, 23);
        textBox1.TabIndex = 0;
        textBox1.KeyPress += textBox1_KeyPress;
        // 
        // button1
        // 
        button1.Location = new Point(14, 44);
        button1.Margin = new Padding(4, 3, 4, 3);
        button1.Name = "button1";
        button1.Size = new Size(266, 27);
        button1.TabIndex = 1;
        button1.Text = "Ок";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // comboBox1
        // 
        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Километры", "Дюймы", "Футы", "Метры" });
        comboBox1.Location = new Point(139, 12);
        comboBox1.Margin = new Padding(4, 3, 4, 3);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(140, 23);
        comboBox1.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(15, 78);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(87, 15);
        label1.TabIndex = 3;
        label1.Text = "Введите число";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(radioButtonInches);
        groupBox1.Controls.Add(radioButtonFeet);
        groupBox1.Controls.Add(radioButtonKm);
        groupBox1.Controls.Add(radioButtonMeters);
        groupBox1.Location = new Point(287, 12);
        groupBox1.Margin = new Padding(4, 3, 4, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4, 3, 4, 3);
        groupBox1.Size = new Size(226, 82);
        groupBox1.TabIndex = 4;
        groupBox1.TabStop = false;
        groupBox1.Text = "Конвертировать в";
        // 
        // radioButtonInches
        // 
        radioButtonInches.AutoSize = true;
        radioButtonInches.Location = new Point(115, 51);
        radioButtonInches.Margin = new Padding(4, 3, 4, 3);
        radioButtonInches.Name = "radioButtonInches";
        radioButtonInches.Size = new Size(68, 19);
        radioButtonInches.TabIndex = 3;
        radioButtonInches.TabStop = true;
        radioButtonInches.Tag = "in";
        radioButtonInches.Text = "Дюймы";
        radioButtonInches.UseVisualStyleBackColor = true;
        // 
        // radioButtonFeet
        // 
        radioButtonFeet.AutoSize = true;
        radioButtonFeet.Location = new Point(115, 23);
        radioButtonFeet.Margin = new Padding(4, 3, 4, 3);
        radioButtonFeet.Name = "radioButtonFeet";
        radioButtonFeet.Size = new Size(54, 19);
        radioButtonFeet.TabIndex = 2;
        radioButtonFeet.TabStop = true;
        radioButtonFeet.Tag = "ft";
        radioButtonFeet.Text = "Футы";
        radioButtonFeet.UseVisualStyleBackColor = true;
        // 
        // radioButtonKm
        // 
        radioButtonKm.AutoSize = true;
        radioButtonKm.Location = new Point(8, 51);
        radioButtonKm.Margin = new Padding(4, 3, 4, 3);
        radioButtonKm.Name = "radioButtonKm";
        radioButtonKm.Size = new Size(89, 19);
        radioButtonKm.TabIndex = 1;
        radioButtonKm.TabStop = true;
        radioButtonKm.Tag = "km";
        radioButtonKm.Text = "Километры";
        radioButtonKm.UseVisualStyleBackColor = true;
        // 
        // radioButtonMeters
        // 
        radioButtonMeters.AutoSize = true;
        radioButtonMeters.Location = new Point(8, 23);
        radioButtonMeters.Margin = new Padding(4, 3, 4, 3);
        radioButtonMeters.Name = "radioButtonMeters";
        radioButtonMeters.Size = new Size(63, 19);
        radioButtonMeters.TabIndex = 0;
        radioButtonMeters.TabStop = true;
        radioButtonMeters.Tag = "m";
        radioButtonMeters.Text = "Метры";
        radioButtonMeters.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(534, 119);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        Controls.Add(comboBox1);
        Controls.Add(button1);
        Controls.Add(textBox1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Конвертер ";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radioButtonInches;
    private System.Windows.Forms.RadioButton radioButtonFeet;
    private System.Windows.Forms.RadioButton radioButtonKm;
    private System.Windows.Forms.RadioButton radioButtonMeters;
}
