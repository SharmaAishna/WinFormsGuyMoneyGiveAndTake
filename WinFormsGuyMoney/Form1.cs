using WinFormsGuyMoney.Model;

namespace WinFormsGuyMoney
{
    public partial class Form1 : Form
    {
        Guy Joe ;
        Guy Bob;
        int Bank = 100;
        public Form1()
        {
            InitializeComponent();

            Joe= new Guy() { Cash=100,Name="Joe"};
           
            Bob=new Guy() {Cash=500, Name="Bob" };
           
            UpdateForm();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void UpdateForm()
        {
            JoesCash.Text = Joe.Name + " has $" + Joe.Cash;
            BobsCash.Text = Bob.Name + " has $" + Bob.Cash;
            BanksCash.Text="The bank has $" +Bank;
        }

        private void Give_Click(object sender, EventArgs e)
        {
            if(Bank >= 10)
            {
                Bank -= Joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money");
            }
        }

        private void Receive_Click(object sender, EventArgs e)
        {
            Bank += Bob.GiveCash(5);
            UpdateForm();
        }
    }
}