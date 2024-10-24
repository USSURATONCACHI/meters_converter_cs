namespace meters_converter_csharp2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!Char.IsDigit(e.KeyChar) &&
            e.KeyChar != ',' &&
            e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
    }


    private void button1_Click(object sender, EventArgs e)
    {
        if (textBox1.TextLength == 0)
        {
            MessageBox.Show("Введите число", "Ошибка.", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        if (comboBox1.SelectedIndex == -1)
        {
            MessageBox.Show("Выберите единицу измерения из выпадающего списка", "Ошибка.", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        RadioButton[] buttons = {
            radioButtonMeters,
            radioButtonKm,
            radioButtonFeet,
            radioButtonInches,
        };
        if (!buttons.Where(b => b.Checked).Any())
        {
            MessageBox.Show("Выберите единицу измерения, в которую необходимо конвертировать", "Ошибка.", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        RadioButton selected_button = buttons.Where(b => b.Checked).First();


        double val = Convert.ToDouble(textBox1.Text);
        Unit from_unit;
        switch (comboBox1.SelectedIndex) { 
            case 0: from_unit = Unit.Kilometers; break;
            case 1: from_unit = Unit.Inches; break;
            case 2: from_unit = Unit.Feet; break;
            case 3: from_unit = Unit.Meters; break;
            default: throw new Exception("Unknown Unit selected");
        }

        Unit to_unit = UnitMethods.FromTag(selected_button.Tag?.ToString() ?? "");

        double from_meters = val * UnitMethods.ToMeters(from_unit);
        double result = from_meters / UnitMethods.ToMeters(to_unit);

        label1.Text = $"{textBox1.Text} {UnitMethods.ShortName(from_unit)} = {result} {UnitMethods.ShortName(to_unit)}";
    }
}
