using elijahHotel.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elijahHotel
{
    internal class imagesRoom
    {
        public void room1(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.RoomImage1;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void room2(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.RoomImage2;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void room3(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.RoomImage3;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void room4(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.RoomImage4;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void room5(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.RoomImage5;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void room6(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.RoomImage6;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }


    }
}
