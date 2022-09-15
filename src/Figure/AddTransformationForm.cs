namespace Figure
{
    public partial class AddTransformationForm : Form
    {
        public ITransformation Transformation { get; private set; }

        public AddTransformationForm()
        {
            InitializeComponent();
            TypeDropdown.Items.Add(new SimpleReplaceTransformation());
            TypeDropdown.Items.Add(new RegexTransformation());
            TypeDropdown.Items.Add(new LeadingCapitalTransformation());
            TypeDropdown.DisplayMember = "TypeName";
        }

        private void TypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeDropdown.SelectedItem != null)
            {
                var SelectedItem = TypeDropdown.SelectedItem as ITransformation;
                Replacement.Enabled = SelectedItem.UseReplacementProperty;
                OK.Enabled = true;
                HelpText.Text = SelectedItem.HelpText;
            }
            else
            {
                OK.Enabled = false;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (TypeDropdown.SelectedItem != null)
            {
                dynamic ReturnObj = TypeDropdown.SelectedItem;
                ReturnObj.Pattern = Pattern.Text;
                if (ReturnObj.UseReplacementProperty) { ReturnObj.Replacement = Replacement.Text; }

                Transformation = ReturnObj;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
