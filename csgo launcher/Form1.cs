using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace csgo_launcher
{
    public partial class Form1 : Form
    {
        DataTable reso = new DataTable();
        public class ID
        {
            public string username { get; set; }
            public string password { get; set; }
        }
        string filePath = @"id.txt";
        string filePath_config = @"config.txt";
        List<ID> ids = new List<ID>();
        List<string> lines1;

        public Form1()
        {
            InitializeComponent();

            if (!File.Exists(filePath))
            {
                File.CreateText(filePath);
            }
            if (!File.Exists(filePath_config))
            {
                File.CreateText(filePath_config);
            }
            else
            if(new FileInfo(filePath_config).Length != 0)
            {
                lines1 = File.ReadAllLines(filePath_config).ToList();
                string[] fill = lines1[0].Split(',');
                SteamDirectory.Text = fill[0];
                LaunchOption.Text = fill[1];
            }
            else
                lines1 = File.ReadAllLines(filePath_config).ToList();


            List<string> lines = File.ReadAllLines(filePath).ToList(); 
            
            foreach (var line in lines)
            {
                string[] entries = line.Split(' ');

                ID newID = new ID();

                newID.username = entries[0];
                newID.password = entries[1];

                ids.Add(newID);
            }
            foreach (var id in ids)
            {
                idBox.Items.Add(id.username);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            fillreso();

            resoComboBox.DataSource = reso;
            resoComboBox.DisplayMember = "resolution";
        }
        private void fillreso()
        {
            reso.Columns.Add("resolution");
            reso.Columns.Add("w");
            reso.Columns.Add("h");

            reso.Rows.Add("","","");
            reso.Rows.Add("640*480", "-w 640", "-h 480");
            reso.Rows.Add("800*600", "-w 800", "-h 600");
            reso.Rows.Add("1024*768", "-w 1024", "-h 768");
            reso.Rows.Add("1280*720", "-w 1280", "-h 720");
            reso.Rows.Add("1280*800", "-w 1280", "-h 800");
            reso.Rows.Add("1280*960", "-w 1280", "-h 960");
            reso.Rows.Add("1280*1024", "-w 1280", "-h 1024");
            reso.Rows.Add("1360*768", "-w 1360", "-h 768");
            reso.Rows.Add("1366*768", "-w 1366", "-h 768");
            reso.Rows.Add("1440*900", "-w 1440", "-h 900");
            reso.Rows.Add("1600*900", "-w 1600", "-h 900");
            reso.Rows.Add("1920*1080", "-w 1920", "-h 1080");
        }
        public string sel, user, pass;
        public string w, h , win, launchcsgo;
        private void button1_Click(object sender, EventArgs e) 
        {
            string steamDirectory = SteamDirectory.Text;
            string launchOption = LaunchOption.Text;
            //string sel,user,pass;
            sel = idBox.GetItemText(idBox.SelectedItem);

            foreach (var id in ids)
            {
                if ((id.username == sel))
                {
                    user = id.username;
                    pass = id.password;
                }
            }
           
            string edit = ($"{steamDirectory}, {launchOption}");
            File.WriteAllText(filePath_config, edit);

            if (windowed.Checked == true)
                win = "-windowed";
            else
                win = "-fullscreen";

            if (launchCSGO.Checked == true)
                launchcsgo = "-applaunch 730";
            else
                launchcsgo = "";
            Process[] pname = Process.GetProcessesByName("Steam");
            if (pname.Length > 0)
            {
                Process.Start($"{steamDirectory}", "/C -shutdown");
            }
            Process.Start($"{steamDirectory}", $"-login {user} {pass} {launchcsgo} {LaunchOption} {win} {w} {h}");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void idBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddID_Click(object sender, EventArgs e)
        {  
            ids.Add(new ID { username = Username.Text, password= Password.Text });
            idBox.Items.Add(Username.Text);
            List<string> output = new List<string>();

            foreach(var id in ids)
            {
                output.Add($"{id.username} {id.password}");
            }
            File.WriteAllLines(filePath, output);
            
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }
        public string del { get; private set; }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteID_Click(object sender, EventArgs e)
        {
                 
            del = idBox.GetItemText(idBox.SelectedItem); 
            List<string> output = new List<string>();

            foreach (var id in ids)
            {
                if(!(id.username == del))
                {
                    output.Add($"{id.username} {id.password} ");
                }             
            }
            
            File.WriteAllLines(filePath, output);
            idBox.Items.Remove(idBox.SelectedItem);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void resoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            h = reso.Rows[resoComboBox.SelectedIndex]["h"].ToString();
            w = reso.Rows[resoComboBox.SelectedIndex]["w"].ToString();
        }
    }
}
