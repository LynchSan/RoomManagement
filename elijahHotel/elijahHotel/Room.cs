using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elijahHotel
{
    public partial class Room : Form
    {
        private imagesRoom imagesRoom;
        roomRandom randomizer = new roomRandom();

        int roomNumber = 0; // room number
        string rooms = ""; //for room text

        string roomRandomNumber = ""; //for room text
        int addedRooms = 0;

        Dictionary<string, int> roomValuePair = new Dictionary<string, int>
        {
            { "Room1", 1499 },
            { "Room2", 2199 },
            { "Room3", 1199 },
            { "Room4", 2499 },
            { "Room5", 3999 },
            { "Room6", 1899 },
        };

        Dictionary<string, int> roomAdded = new Dictionary<string, int>
        {

        };


        public Room()
        {
            InitializeComponent();
            imagesRoom = new imagesRoom();
        }

        // Adds a Gradient Color
        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                ColorTranslator.FromHtml("#694929"),  
                ColorTranslator.FromHtml("#33271a"),

                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            base.OnPaint(e);
        }

        //calculates the total of the Room values
        private int CalculateTotal()
        {
            int total = 0;
            foreach (var value in roomAdded.Values)
            {
                total += value;
            }
            return total;
        }

        //RandomNumber for room

        private void UpdateRandomNumbers()
        {
            // Clear previous random numbers
            roomRandomNumber = "";

            if (addedRooms <= 0)
            {
                // No rooms added, so no random numbers
                labelRoomSelected.Text = "Room Selected: " + rooms;
                labelRoomNum.Text = "Room Numbers: "; // Clear room numbers display
                return;
            }

            // Generate unique random numbers equal to the number of added rooms
            List<int> randomNumbers = randomizer.GenerateMultipleUniqueNumbers(addedRooms);

            // Build the string of random numbers
            foreach (int num in randomNumbers)
            {
                roomRandomNumber += num.ToString() + ", ";
            }

            // Remove the trailing comma and space if present
            if (roomRandomNumber.EndsWith(", "))
            {
                roomRandomNumber = roomRandomNumber.Substring(0, roomRandomNumber.Length - 2);
            }

            // Update both labels - one for selected rooms, one for room numbers
            labelRoomSelected.Text = "Room Selected: " + rooms;
            labelRoomNum.Text = "Room Numbers: " + roomRandomNumber;
        }

        private void Room_Load(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //For repeating the room numbers
            roomNumber = (roomNumber % 6) + 1;

            switch (roomNumber)
            {
                case 1:
                    imagesRoom.room1(pictureBoxStock);
                    labelRoomName.Text = "Room 1";
                    labelStatus.Text = "Available";
                    labelColor.BackColor = Color.Lime;
                    labelPrice.Text = "Price: ₱1,499";

                    labelDescription.Text = "Room 1 is a spacious room with a king-sized bed, perfect for couples " +
                        "or solo travelers. It features a private bathroom, air conditioning, and a flat-screen TV.";
                    break;
                case 2:
                    imagesRoom.room2(pictureBoxStock);
                    labelRoomName.Text = "Room 2";
                    labelStatus.Text = "Available";
                    labelColor.BackColor = Color.Lime;
                    labelPrice.Text = "Price: ₱2,199";

                    labelDescription.Text = "Room 2 is a cozy room with two twin beds, ideal for friends or family." +
                        " It includes a private bathroom, " +
                        "air conditioning, and a mini-fridge.";
                    break;
                case 3:
                    imagesRoom.room3(pictureBoxStock);
                    labelRoomName.Text = "Room 3";
                    labelStatus.Text = "Occupied";
                    labelColor.BackColor = Color.Orange;
                    labelPrice.Text = "Price: ₱1,199";

                    labelDescription.Text = "Room 3 is a budget-friendly option with a double bed." +
                        " It features a shared bathroom, air conditioning, and basic amenities.";
                    break;
                case 4:
                    imagesRoom.room4(pictureBoxStock);
                    labelRoomName.Text = "Room 4";
                    labelStatus.Text = "Maintenance";
                    labelColor.BackColor = Color.Red;
                    labelPrice.Text = "Price: ₱2,499";

                    labelDescription.Text = "Room 4 is a luxurious suite with a king-sized bed, a separate living area, " +
                        "and a private balcony. It includes a large bathroom with a jacuzzi, air conditioning, and a mini-bar.";
                    break;
                case 5:
                    imagesRoom.room5(pictureBoxStock);
                    labelRoomName.Text = "Room 5";
                    labelStatus.Text = "Available";
                    labelColor.BackColor = Color.Lime;
                    labelPrice.Text = "Price: ₱3,999";

                    labelDescription.Text = "Room 5 is a spacious family room with two queen-sized beds." +
                        " It features a private bathroom, air conditioning, and a flat-screen TV.";
                    break;
                case 6:
                    imagesRoom.room6(pictureBoxStock);
                    labelRoomName.Text = "Room 6";
                    labelStatus.Text = "Available";
                    labelColor.BackColor = Color.Lime;
                    labelPrice.Text = "Price: ₱1,899";

                    labelDescription.Text = "Room 6 is a modern room with a queen-sized bed and a private bathroom." +
                        " It includes air conditioning, a flat-screen TV, and a mini-fridge.";
                    break;

            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            //For repeating the room numbers in reverse order
            roomNumber = (roomNumber - 2 + 6) % 6 + 1;

            switch (roomNumber)
            {
                case 1:
                    imagesRoom.room1(pictureBoxStock);
                    labelRoomName.Text = "Room 1";
                    labelStatus.Text = "Available";
                    labelColor.BackColor = Color.Lime;
                    labelPrice.Text = "Price: ₱1,499";

                    labelDescription.Text = "Room 1 is a spacious room with a king-sized bed, perfect for couples " +
                        "or solo travelers. It features a private bathroom, air conditioning, and a flat-screen TV.";
                    break;
                case 2:
                    imagesRoom.room2(pictureBoxStock);
                    labelRoomName.Text = "Room 2";
                    labelStatus.Text = "Available";
                    labelColor.BackColor = Color.Lime;
                    labelPrice.Text = "Price: ₱2,199";

                    labelDescription.Text = "Room 2 is a cozy room with two twin beds, ideal for friends or family." +
                        " It includes a private bathroom, " +
                        "air conditioning, and a mini-fridge.";
                    break;
                case 3:
                    imagesRoom.room3(pictureBoxStock);
                    labelRoomName.Text = "Room 3";
                    labelStatus.Text = "Occupied";
                    labelColor.BackColor = Color.Orange;
                    labelPrice.Text = "Price: ₱1,199";

                    labelDescription.Text = "Room 3 is a budget-friendly option with a double bed." +
                        " It features a shared bathroom, air conditioning, and basic amenities.";
                    break;
                case 4:
                    imagesRoom.room4(pictureBoxStock);
                    labelRoomName.Text = "Room 4";
                    labelStatus.Text = "Maintenance";
                    labelColor.BackColor = Color.Red;
                    labelPrice.Text = "Price: ₱2,499";

                    labelDescription.Text = "Room 4 is a luxurious suite with a king-sized bed, a separate living area, " +
                        "and a private balcony. It includes a large bathroom with a jacuzzi, air conditioning, and a mini-bar.";
                    break;
                case 5:
                    imagesRoom.room5(pictureBoxStock);
                    labelRoomName.Text = "Room 5";
                    labelStatus.Text = "Available";
                    labelColor.BackColor = Color.Lime;
                    labelPrice.Text = "Price: ₱3,999";

                    labelDescription.Text = "Room 5 is a spacious family room with two queen-sized beds." +
                        " It features a private bathroom, air conditioning, and a flat-screen TV.";
                    break;
                case 6:
                    imagesRoom.room6(pictureBoxStock);
                    labelRoomName.Text = "Room 6";
                    labelStatus.Text = "Available";
                    labelColor.BackColor = Color.Lime;
                    labelPrice.Text = "Price: ₱1,899";

                    labelDescription.Text = "Room 6 is a modern room with a queen-sized bed and a private bathroom." +
                        " It includes air conditioning, a flat-screen TV, and a mini-fridge.";
                    break;
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            switch (roomNumber)
            {
                case 1:
                    if (roomAdded.ContainsKey("Room1"))
                    {
                        MessageBox.Show("Room 1 has already been added to your cart.");
                    }
                    else
                    {
                        MessageBox.Show("Room 1 has been added to your cart.");
                        roomAdded["Room1"] = roomValuePair["Room1"];

                        string roomN1 = "Room 1, ";
                        rooms += roomN1;

                        addedRooms++;
                    }
                    break;
                case 2:
                    if (roomAdded.ContainsKey("Room2"))
                    {
                        MessageBox.Show("Room 2 has already been added to your cart.");
                    }
                    else
                    {
                        MessageBox.Show("Room 2 has been added to your cart.");
                        roomAdded["Room2"] = roomValuePair["Room2"];

                        string roomN2 = "Room 2, ";
                        rooms += roomN2;

                        addedRooms++;
                    }
                    break;
                case 3:
                    MessageBox.Show("Sorry this room is currently Occupied ");
                    break;
                    /*
                    if (roomAdded.ContainsKey("Room3"))
                    {
                        MessageBox.Show("Room 3 has already been added to your cart.");
                    }
                    
                    else
                    {
                        MessageBox.Show("Room 3 has been added to your cart.");
                        roomAdded["Room3"] = roomValuePair["Room3"];

                        string roomN3 = "Room 3, ";
                        rooms += roomN3;

                        addedRooms++;
                    }
                    break;
                    */
                case 4:

                    MessageBox.Show("Sorry this room is currently on Maintenance ");
                    break;

                    /*
                    if (roomAdded.ContainsKey("Room4"))
                    {
                        MessageBox.Show("Room 4 has already been added to your cart.");
                    }
                    else
                    {
                        MessageBox.Show("Room 4 has been added to your cart.");
                        roomAdded["Room4"] = roomValuePair["Room4"];

                        string roomN4 = "Room 4, ";
                        rooms += roomN4;

                        addedRooms++;
                    }
                    break;
                    */
                case 5:
                    if (roomAdded.ContainsKey("Room5"))
                    {
                        MessageBox.Show("Room 5 has already been added to your cart.");
                    }
                    else
                    {
                        MessageBox.Show("Room 5 has been added to your cart.");
                        roomAdded["Room5"] = roomValuePair["Room5"];

                        string roomN5 = "Room 5, ";
                        rooms += roomN5;

                        addedRooms++;
                    }
                    break;
                case 6:
                    if (roomAdded.ContainsKey("Room6"))
                    {
                        MessageBox.Show("Room 6 has already been added to your cart.");
                    }
                    else
                    {
                        MessageBox.Show("Room 6 has been added to your cart.");
                        roomAdded["Room6"] = roomValuePair["Room6"];

                        string roomN6 = "Room 6, ";
                        rooms += roomN6;

                        addedRooms++;
                    }
                    break;

            }

            // Update the label showing selected rooms
            labelRoomSelected.Text = "Room Selected: " + rooms;
            int total = CalculateTotal();

            // Update the total label with the calculated total
            labelTotal.Text = "Total: ₱" + total.ToString("N0");// N0 format adds commas as thousand separators
            UpdateRandomNumbers();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            switch (roomNumber)
            {
                case 1:
                    if (!roomAdded.ContainsKey("Room1"))
                    {
                        MessageBox.Show("Room 1 is not in your cart.");
                    }
                    else
                    {
                        MessageBox.Show("Room 1 has been removed from your cart.");
                        roomAdded.Remove("Room1");

                        rooms = rooms.Replace("Room 1, ", "");
                        addedRooms--;
                    }
                    break;
                case 2:
                    if (!roomAdded.ContainsKey("Room2"))
                    {
                        MessageBox.Show("Room 2 is not in your cart.");
                    }
                    else
                    {
                        MessageBox.Show("Room 2 has been removed from your cart.");
                        roomAdded.Remove("Room2");

                        rooms = rooms.Replace("Room 2, ", "");
                        addedRooms--;
                    }
                    break;
                case 3:
                    if (!roomAdded.ContainsKey("Room3"))
                    {
                        MessageBox.Show("Room 3 is not in your cart.");
                    }
                    else
                    {
                        MessageBox.Show("Room 3 has been removed from your cart.");
                        roomAdded.Remove("Room3");

                        rooms = rooms.Replace("Room 3, ", "");
                        addedRooms--;
                    }
                    break;
                case 4:
                    if (!roomAdded.ContainsKey("Room4"))
                    {
                        MessageBox.Show("Room 4 is not in your cart.");
                    }
                    else
                    {
                        MessageBox.Show("Room 4 has been removed from your cart.");
                        roomAdded.Remove("Room4");

                        rooms = rooms.Replace("Room 4, ", "");
                        addedRooms--;
                    }
                    break;
                case 5:
                    if (!roomAdded.ContainsKey("Room5"))
                    {
                        MessageBox.Show("Room 5 is not in your cart.");
                    }
                    else
                    {
                        MessageBox.Show("Room 5 has been removed from your cart.");
                        roomAdded.Remove("Room5");

                        rooms = rooms.Replace("Room 5, ", "");
                        addedRooms--;
                    }
                    break;
                case 6:
                    if (!roomAdded.ContainsKey("Room6"))
                    {
                        MessageBox.Show("Room 6 is not in your cart.");
                    }
                    else
                    {
                        MessageBox.Show("Room 6 has been removed from your cart.");
                        roomAdded.Remove("Room6");

                        rooms = rooms.Replace("Room 6, ", "");
                        addedRooms--;
                    }
                    break;
            }

            // Update the label showing selected rooms
            labelRoomSelected.Text = "Room Selected: " + rooms;

            // Update the total
            int total = CalculateTotal();
            labelTotal.Text = "Total: ₱" + total.ToString("N0");
            UpdateRandomNumbers();
        }

    }
}
