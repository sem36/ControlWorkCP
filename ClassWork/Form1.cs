using System.Security.Policy;

namespace ClassWork
{
    public partial class Form1 : Form
    {
        List<ClassRegister> classes = new List<ClassRegister>();
        public Form1()
        {
            InitializeComponent();
        }
        public void clear()
        {
            namebox.Text = "";
            groupBox.Text = "";
            AvarageBox.Text = "";
            BookBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            ClassRegister std =  new ClassRegister(namebox.Text,groupBox.Text,BookBox.Text,AvarageBox.Text);
            classes.Add(std);
            listBox1.Items.Add(std.GetName());
        }
        public void Cheak (List<ClassRegister> classRegister, string name)
        {
            if (name == null)
                return;
            for (int a = 0; classRegister.Count > a; a++)
            {
                if (classRegister[a].GetName() == name)
                {
                    namebox.Text = classRegister[a].GetName();
                    groupBox.Text = classRegister[a].GetNumberGroup();
                    AvarageBox.Text = classRegister[a].GetAvarageScore();
                    BookBox.Text = classRegister[a].GetNumberCB();
                }
            }
        }
        public int ReturnIndex(List<ClassRegister> classRegisters,string name)
        {
            for (int a = 0; classRegisters.Count > a; a++)
            {
                if (classRegisters[a].GetName() == name)
                {
                    return a;
                }
            }
            return 0;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            try
            {
                if (listBox1.SelectedItem != null)
                    Cheak(classes, listBox1.SelectedItem.ToString());
            }
            catch (Exception)
            {
                label5.Text = "ERROR";
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            int index = listBox1.SelectedIndex;
            try
            {
                listBox1.Items.RemoveAt(index);
                classes.RemoveAt(index);
            }
            catch (Exception)
            {
                label5.Text = "ERROR";
            }
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            ClassRegister std = new ClassRegister(namebox.Text, groupBox.Text, BookBox.Text, AvarageBox.Text);
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                listBox1.Items[index] = std.GetName();
                classes[index] = std;
            }
        }
    }
}