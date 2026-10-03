namespace SASSAQueueManagementSystem
{
    public partial class frmQueueManagementSystem : Form
    {
        private StaffMember? currentStaff;
        public frmQueueManagementSystem()
        {
            InitializeComponent();
        }
        public frmQueueManagementSystem(StaffMember staffMember) : this()
        {
            currentStaff = staffMember
                ?? throw new ArgumentNullException(nameof(staffMember));
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {

        }
    }
}
