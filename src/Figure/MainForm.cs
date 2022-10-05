using Newtonsoft.Json;
using System.ComponentModel;

namespace Figure;

public partial class MainForm : Form
{
    private BindingList<ITransformation> Transformations { get; set; }
    private bool UnsavedListChanges;
    private bool UnsavedTextChanges;
    private string TextFilePath;
    private string ListFilePath;

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
                UnsavedListChanges = true;
            }
        }
    }

    private void RemoveTransformation_Click(object sender, EventArgs e)
    {
        foreach (DataGridViewCell cell in TransformationTable.SelectedCells)
        {
            TransformationTable.Rows.RemoveAt(cell.RowIndex);
            UnsavedListChanges = true;
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
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(dlg.FileName))
                    {
                        textEditBox.Text = File.ReadAllText(dlg.FileName);
                        UnsavedTextChanges = false;
                        TextFilePath = dlg.FileName;
                    }
                    else
                    {
                        MessageBox.Show("Selected file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(TextFilePath, textEditBox.Text);
                TextFilePath = dlg.FileName;
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

    private void saveTransformationListAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (var dlg = new SaveFileDialog())
        {
            dlg.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            dlg.InitialDirectory = Path.GetDirectoryName(ListFilePath);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SaveListFile(dlg.FileName);
                    ListFilePath = dlg.FileName;
                    UnsavedListChanges = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to save transformation list:\r{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }


    private void saveTransformationListToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(ListFilePath))
        {
            saveTransformationListAsToolStripMenuItem_Click(sender, e);
        }
        else
        {
            try
            {
                SaveListFile(ListFilePath);
                UnsavedListChanges = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to save transformation list:\r{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    private void SaveListFile(string path)
    {
        JsonSerializer serializer = new JsonSerializer();
        serializer.TypeNameHandling = TypeNameHandling.All;
        using (StreamWriter sw = new StreamWriter(path))
        {
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, Transformations.ToArray());
            }
        }
    }

    private void openTransformationListToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!UnsavedListChanges || MessageBox.Show("You have unsaved changes. Continue?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(dlg.FileName))
                    {
                        string Serialized = File.ReadAllText(dlg.FileName);
                        JsonSerializerSettings settings = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto };
                        var Deserialized = JsonConvert.DeserializeObject(Serialized, settings);
                        if (Deserialized != null)
                        {
                            Transformations.Clear();
                            foreach (ITransformation transformation in (IEnumerable<ITransformation>)Deserialized)
                            {
                                Transformations.Add(transformation);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if ((UnsavedListChanges | UnsavedTextChanges) == false || MessageBox.Show("You have unsaved changes. Continue?", "Unsaved changes", MessageBoxButtons.OKCancel) == DialogResult.OK)
        {
            textEditBox.Clear();
            Transformations.Clear();
            TextFilePath = "";
            ListFilePath = "";
            UnsavedListChanges = false;
            UnsavedTextChanges = false;
        }
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new AboutBox1().ShowDialog();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if ((UnsavedTextChanges | UnsavedListChanges ) 
            && MessageBox.Show("You have unsaved text changes. Continue?", "Unsaved changes", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
        {
            return;
        }
        Environment.Exit(0);
    }
}