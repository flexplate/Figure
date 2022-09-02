using System.Collections.ObjectModel;
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
        dataGridView1.DataSource = Transformations;
        ListChanged = false;
        TextChanged = false;
    }

    private void Transformations_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
    {
        
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
        
    }
}
