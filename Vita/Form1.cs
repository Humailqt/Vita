using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Vita
{
    public class transport
    {
        public String name;
        public String firma;
        public String dateOUT;
    }
    public class auto : transport
    {

        
    }
    public class low_auto : transport
    {

        
    }
    public class track: transport
    {

        
    }

    public partial class Form1 : Form
    {
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        String name_tmp;
        String lastName_tmp;
        DataBase dataBase = new DataBase();

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            name_tmp = BoxName.Text;
            lastName_tmp= boxLastName.Text;

            Corrent_user.Text = name_tmp +"||"+lastName_tmp;
            


        }

        private void show_Person()
        {

        }

        private void ButtomFind_Click(object sender, EventArgs e)
        {
            string findLastName = boxFind.Text;
            Person correntPerson = dataBase.GetPerson(findLastName);
            infoOut.Text = correntPerson.name + "||" + correntPerson.lastName;

        }
    }

    class DataBase
    {

        Person[] data;


        public Person GetPerson(string lastName) {

            foreach (Person item in data)
            {
                if (item.lastName == lastName)
                {
                    return item;
                }
            }
            Person p = new Person();
            return p; 
        }

    }

}
