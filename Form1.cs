using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Serialize_Lab.Classes;
using System.Runtime.Serialization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace Serialize_Lab
{
    public partial class Form1 : Form
    {
        public static Transport curTransport;
        public static List<Label> labels;
        public static List<TextBox> textboxes;
        public static List<Transport> transports;

        public Form1()
        {
            InitializeComponent();
            transports = new List<Transport>();
            SetStartInterface("");
        }

        private void SerializeObject()
        {
            Wrapper typeList = new Wrapper();
            string path = @"D:\serial.bin";
            string data = string.Empty;
            JsonSerializer serializer = new JsonSerializer();
            
            foreach ( Transport transport in transports )
            {
                MemoryStream ms = new MemoryStream();

                BsonWriter writer = new BsonWriter(ms);
                serializer.Serialize(writer, transport);
                typeList.Content.Add(transport.GetType());
                data += Convert.ToBase64String(ms.ToArray()) + " ";
            }

            MemoryStream ms1 = new MemoryStream();

            BsonWriter writer1 = new BsonWriter(ms1);

            serializer.Serialize(writer1, typeList);
            data += Convert.ToBase64String(ms1.ToArray());

            System.IO.File.WriteAllText(path, data);
        }

        private void DeserializeObject()
        {
            string path = @"D:\serial.bin";
            Wrapper typeList;
            Serializators objectDeserializer = new Serializators();

            JsonSerializer serializer = new JsonSerializer();
            MemoryStream ms = new MemoryStream();
            string data = string.Empty;

            data = System.IO.File.ReadAllText(path);
            string[] dataList = data.Split(' '); 
            byte[] bdata = Convert.FromBase64String(dataList[dataList.Length - 1]);
            MemoryStream ms1 = new MemoryStream(bdata);

            using (BsonReader reader = new BsonReader(ms1))
            {
                JsonSerializer deserializer = new JsonSerializer();
                typeList = deserializer.Deserialize<Wrapper>(reader);
            }

            for (int i = 0; i < typeList.Content.Count; i++ )
            {
                transports.Add(objectDeserializer.Serialize(typeList.Content[i], dataList[i]));
            }
        }

        private void ChangeInterface(List<string> attributes)
        {
            describeGroupBox.Controls.Clear();
            string[] parametrs;
            labels = new List<Label>();
            textboxes = new List<TextBox>();
            Label curLabel;
            TextBox curTextBox;
            Point labelPos = new Point(8, 78);
            Point textBoxPos = new Point(194, 78);
            for (int i = 0; i < attributes.Count - 1; i++)
            {
                parametrs = attributes[i].Split('/');
                curLabel = new Label();
                curTextBox = new TextBox();
                curLabel.AutoSize = true;
                curLabel.Text = parametrs[0];
                curTextBox.Text = parametrs[1];
                curLabel.Location = labelPos;
                curTextBox.Location = textBoxPos;
                describeGroupBox.Controls.Add(curLabel);
                describeGroupBox.Controls.Add(curTextBox);
                labels.Add(curLabel);
                textboxes.Add(curTextBox);
                labelPos.Y += 26;
                textBoxPos.Y += 26;
            }
            SetStartInterface(attributes[attributes.Count - 1]);
        }

        private void SetStartInterface(string className)
        {
            Label curLabel = new Label();
            TextBox curTextBox = new TextBox();
            Point labelPos = new Point(8, 20);
            Point textBoxPos = new Point(194, 20);
            curTextBox.Name = "classNameTextBox";
            curLabel.Location = labelPos;
            curTextBox.Location = textBoxPos;
            curLabel.Text = "Класс";
            curTextBox.Text = className;
            curTextBox.Enabled = false;
            describeGroupBox.Controls.Add(curLabel);
            describeGroupBox.Controls.Add(curLabel);
            describeGroupBox.Controls.Add(curTextBox);
        }

        private void SetInterface()
        {
            ChangeInterface(curTransport.Attridutes);
            nameTextBox.Text = "";
            createButton.Enabled = true;
            nameTextBox.Enabled = true;
            changeButton.Enabled = false;
        }

        private void helicopterButton_Click(object sender, EventArgs e)
        {
            curTransport = new Helicopter();
            SetInterface();
        }

        private void planeButton_Click(object sender, EventArgs e)
        {
            curTransport = new Plane();
            SetInterface();
        }

        private void railButton_Click(object sender, EventArgs e)
        {
            curTransport = new RailTransport();
            SetInterface();
        }

        private void autoButton_Click(object sender, EventArgs e)
        {
            curTransport = new AutoTransport();
            SetInterface();
        }

        private void sailingButton_Click(object sender, EventArgs e)
        {
            curTransport = new SailingTransport();
            SetInterface();
        }

        private void steamboatButton_Click(object sender, EventArgs e)
        {
            curTransport = new SteamboatTransport();
            SetInterface();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            List<string> attributes = new List<string>();

            foreach (TextBox textBox in textboxes)
            {
                attributes.Add(textBox.Text);
            }

            attributes.Add(nameTextBox.Text);

            curTransport.Attridutes = attributes;

            transports.Add(curTransport);

            itemsListBox.Items.Add(nameTextBox.Text);

            labels.Clear();
            textboxes.Clear();

            createButton.Enabled = false;
            nameTextBox.Enabled = false;
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            createButton.Enabled = false;
            changeButton.Enabled = true;
            
            ChangeInterface(transports[itemsListBox.SelectedIndex].Attridutes);
            nameTextBox.Text = (string)itemsListBox.SelectedItem;
            nameTextBox.Enabled = true;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            List<string> attributes = new List<string>();

            foreach (TextBox textBox in textboxes)
            {
                attributes.Add(textBox.Text);
            }

            attributes.Add(nameTextBox.Text);

            transports[itemsListBox.SelectedIndex].Attridutes = attributes;

            createButton.Enabled = false;
            changeButton.Enabled = false;
            nameTextBox.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DeserializeObject();
            foreach (Transport transport in transports)
            {
                itemsListBox.Items.Add(transport.GetName());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeObject();
        }
    }
}
