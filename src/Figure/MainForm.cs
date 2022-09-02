using System.ComponentModel;

namespace Figure;

public partial class MainForm : Form
{
    private BindingList<ITransformation> Transformations { get; set; }
    private bool ListChanged;
    private bool TextChanged;

    public MainForm()
    {
        InitializeComponent();
        Transformations = new BindingList<ITransformation>();
        TransformationTable.DataSource = Transformations;
        ListChanged = false;
        TextChanged = false;
    }

    private void AddTransformation_Click(object sender, EventArgs e)
    {
        using (var dlg = new AddTransformationForm())
        {
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Transformations.Add(dlg.Transformation);
            }
        }
    }

    private void RemoveTransformation_Click(object sender, EventArgs e)
    {
        foreach (DataGridViewCell cell in TransformationTable.SelectedCells)
        {
            TransformationTable.Rows.RemoveAt(cell.RowIndex);
        }
    }

    private void Start_Click(object sender, EventArgs e)
    {
        foreach (ITransformation transformation in Transformations)
        {
            textEditBox.Text = transformation.Transform(textEditBox.Text);
        }
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!TextChanged || MessageBox.Show("Text has been edited.\rAre you certain you wish to continue without saving?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK && File.Exists(dlg.FileName))
                {
                    textEditBox.Text = File.ReadAllText(dlg.FileName);
                    TextChanged = false;
                }
            }
        }
    }

    private void textEditBox_TextChanged(object sender, EventArgs e)
    {
        TextChanged = true;
    }
}
