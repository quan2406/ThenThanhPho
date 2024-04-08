namespace TenThanhPho_TH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EmptyOption();
            addData();

        }
        List<Country_City> list = new List<Country_City>();
        string country, city;

        public void addData()
        {
            
            list.Add(new Country_City("Viet Nam", "Ha Noi"));
            list.Add(new Country_City("My", "Washington"));
            list.Add(new Country_City("Nhat Ban", "ToKyo"));
            list.Add(new Country_City("Trung Quoc", "Bac Kinh"));
            list.Add(new Country_City("Phap", "Paris"));

        }

        public void EmptyOption()
        {
            rbHN.Checked = false;
            rbBK.Checked = false;
            rbWashington.Checked = false;
            rbParis.Checked = false;
            rbToKyo.Checked = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdVN_CheckedChanged(object sender, EventArgs e)
        {
            EmptyOption();
            country=rdVN.Text;
            
            lb.Text = "Hãy chọn thủ đô của"+rdVN.Text;
        }

        private void rbNB_CheckedChanged(object sender, EventArgs e)
        {
            country=rbNB.Text;
            EmptyOption();
            lb.Text = "Hãy chọn thủ đô của" + rbNB.Text;
        }

        private void rbTQ_CheckedChanged(object sender, EventArgs e)
        {
            country= rbTQ.Text;
            EmptyOption();
            lb.Text = "Hãy chọn thủ đô của" + rbTQ.Text;
        }

        private void rbPhap_CheckedChanged(object sender, EventArgs e)
        {
            country=rbPhap.Text;
            EmptyOption();
            lb.Text = "Hãy chọn thủ đô của" + rbPhap.Text;
        }

        private void rbMy_CheckedChanged(object sender, EventArgs e)
        {
            country = rbMy.Text;
            EmptyOption();
            lb.Text = "Hãy chọn thủ đô của" + rbMy.Text;
        }

        private void rbHN_CheckedChanged(object sender, EventArgs e)
        {
            city=rbHN.Text;
            if (check(country, city))
            {
                lb.Text = "Bạn đã chọn đúng";
            }
            else
            {
                lb.Text = "Bạn đã chọn sai";
            }
        }

        private void rbToKyo_CheckedChanged(object sender, EventArgs e)
        {
            city = rbToKyo.Text;
            if (check(country, city))
            {
                lb.Text = "Bạn đã chọn đúng";
            }
            else
            {
                lb.Text = "Bạn đã chọn sai";
            }
        }

        private void rbBK_CheckedChanged(object sender, EventArgs e)
        {
            city = rbBK.Text;
            if (check(country, city))
            {
                lb.Text = "Bạn đã chọn đúng";
            }
            else
            {
                lb.Text = "Bạn đã chọn sai";
            }
        }

        private void rbParis_CheckedChanged(object sender, EventArgs e)
        {
            city = rbParis.Text;
            if (check(country, city))
            {
                lb.Text = "Bạn đã chọn đúng";
            }
            else
            {
                lb.Text = "Bạn đã chọn sai";
            }
        }

        private void rbWashington_CheckedChanged(object sender, EventArgs e)
        {
            city = rbWashington.Text;
            if (check(country, city))
            {
                lb.Text = "Bạn đã chọn đúng";
            }
            else
            {
                lb.Text = "Bạn đã chọn sai";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát?","Xác nhận thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
                this.Close();
        }

        bool check(string country,string city)
        {
            foreach(Country_City i in list)
            {
                if (i.Country.Equals(country)&& i.City.Equals(city))
                {
                    return true;
                }
            }
            return false;
        }


    }
}