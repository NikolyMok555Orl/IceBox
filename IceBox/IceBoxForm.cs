using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceBox
{
    public partial class IceBoxForm : Form
    {
        private IceBoxAddFreezer iceBox = new IceBoxAddFreezer();
        Bitmap[] bitmaps = new Bitmap[2];
        public IceBoxForm()
        {
            InitializeComponent();
        }

        private void LoadImage(string pathImage, int i)
        {
            try
            {
                if (i > 1) throw new Exception("Ошибка");
                bitmaps[i] = new Bitmap(pathImage);
                //вместо pictureBox1 укажите pictureBox, в который нужно загрузить изображение 
                //image = pictureBoxIceBox.Size.Width; 
               /* if (!icebox) { 
                pictureBoxIceBox.Image = image;
                pictureBoxIceBox.Invalidate();*/
            }
            catch
            {
                DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectImage(int i, bool iceBox)
        {
            if (i > 1) throw new Exception("Ошибка");
            if (iceBox)
            {
                pictureBoxIceBox.Image = bitmaps[i];
            }
            else
            {
                pictureBoxFreezer.Image = bitmaps[i];
            }
            
        }

        private void IceBoxForm_Load(object sender, EventArgs e)
        {
            LoadImage("closeIceBox.jpg", 0);
            LoadImage("openIceBox.jpg", 1);
            iceBox.ChangeWork += Update;
            (iceBox as IceBoxAddFreezer).AddReaction(UpM);

            timer1.Start();
            SelectImage(0, true);
            SelectImage(0, false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // labelSostIceBox.Text ="Холодильник "+ (iceBox.Work ? "Работает":"Наелся и спит") ;
            labLampIceBox.Text = "Лампа горит " + (iceBox.LampBurn? "Да":"Нет");
            labelModeIceBox.Text = "Режим " + iceBox.Mode;
           // labelSostFreezer.Text = "Морозильник " + (iceBox.WorkFreezer ? "Работает" : "Наелся и спит");
            labLampFreezer.Text = "Лампа горит " + (iceBox.LampBurnFreezer ? "Да" : "Нет");
            labelModeFreezer.Text = "Режим " + iceBox.ModeFreezer;
        }

        private void Update(object o)
        {
            IceBox h = o as IceBox;
            //  if (h.Work)  label6.Text ="Робыть"; else label6.Text = "Не робыть";
            string text =  "Холодильник " + (h.Work ? "Работает" : "Наелся и спит");
            labelSostIceBox.Invoke(new Action<string>((s) => labelSostIceBox.Text = s), text);
        }

        private void UpM(object o)
        {
            IceBox h = o as IceBox;
            string text = "Морозильник " + (h.Work ? "Работает" : "Наелся и спит");
            labelSostFreezer.Invoke(new Action<string>((s) => labelSostFreezer.Text = s), text);
        }

        private void btnOpenDoor_Click(object sender, EventArgs e)
        {
            iceBox.OpenDoorIceBox();
            SelectImage(1, true);

        }

        private void btnCloseDoor_Click(object sender, EventArgs e)
        {
            iceBox.CloseDoorIceBox();
            SelectImage(0, true);
        }

        private void btnUpMode_Click(object sender, EventArgs e)
        {
            iceBox.UpMode();
        }

        private void btnDownMode_Click(object sender, EventArgs e)
        {
            iceBox.DownMode();
        }

        private void btnFreezerOpen_Click(object sender, EventArgs e)
        {
            iceBox.OpenDoorFreezer();
            SelectImage(1, false);
        }

        private void btnFreezerClose_Click(object sender, EventArgs e)
        {
            iceBox.CloseDoorFreezer();
            SelectImage(0, false);
        }

        private void btnFreezerModeUp_Click(object sender, EventArgs e)
        {
            iceBox.UpModeFreezer();
        }

        private void btnFreezerDown_Click(object sender, EventArgs e)
        {
            iceBox.DownModeFreezer();
        }

        private void IsWokrIceBox(object iceBoxThis)
        {
            labelSostIceBox.Text = "Холодильник " + (iceBox.Work ? "Работает" : "Наелся и спит");
        }
    }
}
