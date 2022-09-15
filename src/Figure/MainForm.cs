using System.ComponentModel;

namespace Figure;

public partial class MainForm : Form
{
    private BindingList<ITransformation> Transformations { get; set; }
    private bool UnsavedListChanges;
    private bool UnsavedTextChanges;
    private string TextFilePath;

    public MainForm()
    {
        InitializeComponent();
        TransformationTable.AutoGenerateColumns = false;
        Transformations = new BindingList<ITransformation>();
        TransformationTable.DataSource = Transformations;
        TextFilePath = "";
        UnsavedListChanges = false;
        UnsavedTextChanges = false;
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
            transformation.Applied = true;
        }
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!UnsavedTextChanges || MessageBox.Show("Text has been edited.\rAre you certain you wish to continue without saving?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK && File.Exists(dlg.FileName))
                {
                    textEditBox.Text = File.ReadAllText(dlg.FileName);
                    UnsavedTextChanges = false;
                    TextFilePath = dlg.FileName;
                }
            }
        }
    }

    private void textEditBox_TextChanged(object sender, EventArgs e)
    {
        UnsavedTextChanges = true;
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(TextFilePath))
        {
            saveAsToolStripMenuItem_Click(sender, e);
            return;
        }
        File.WriteAllText(TextFilePath, textEditBox.Text);
        UnsavedTextChanges = false;
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (var dlg = new SaveFileDialog())
        {
            dlg.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            dlg.InitialDirectory = Path.GetDirectoryName(TextFilePath);
            if (dlg.ShowDialog() == DialogResult.OK 
                && (!File.Exists(dlg.FileName) || MessageBox.Show($"Are you sure you wish to overwrite the file {dlg.FileName}?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                TextFilePath = dlg.FileName;
                File.WriteAllText(TextFilePath, textEditBox.Text);
                UnsavedTextChanges = false;
            }
        }
    }

    private void Step_Click(object sender, EventArgs e)
    {
        ITransformation Transformation = Transformations.First(t => t.Applied != true);
        Transformation.Transform(textEditBox.Text);
        Transformation.Applied = true;
    }
}
