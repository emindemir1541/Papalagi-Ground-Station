using FireSharp.Response;
using GMap.NET.MapProviders;
using Papalagi_Ground_Station.data;
using Papalagi_Ground_Station.data.local;
using Papalagi_Ground_Station.helper;
using Papalagi_Ground_Station.map;
using Papalagi_Ground_Station.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papalagi_Ground_Station.forms
{
    public partial class Tracking : Form
    {

        MapSetter mapSetter;
        FirebaseRepository userRepository = new FirebaseRepository();
        User currentUser = new User();
        Drone drone = new Drone();
        string selectedUserId = null;
        bool trackSituation = false;

        public Tracking()
        {
            InitializeComponent();
        }

        private void Tracking_Load(object sender, EventArgs e)
        {
            mapSetter = new MapSetter(map);
            mapSetter.settings();
            panelPersonList.Show();
            enableManuelLocation(false);

             mapSetter.setDroneLocation("27,0293947", " 38,5115684");
            //  mapSetter.setPhoneLocation(map, 27.039, 38.5115684);


            setUsersDataGridView();
            getUsersToDataGridView();
            getSelectedUser();
            setDrone();

            

        }



        private void labelOpenPersonList_Click(object sender, EventArgs e)
        {
            panelPersonList.Show();
            setUsersDataGridView();
        }
        private void labelExitPersonList_Click(object sender, EventArgs e)
        {
            panelPersonList.Hide();
        }
        private void dataGridViewPersonList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedUserId = dataGridViewPersonList.CurrentRow.Cells[2].Value.ToString();
        }
        private void buttonSendLocation_Click(object sender, EventArgs e)
        {
            mapSetter.setDroneLocation(textBoxDroneLongitude.Text, textBoxDroneLatitude.Text);
        }
        private void checkBoxManuelLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxManuelLocation.Checked)
            {
                enableManuelLocation(true);
            }
            else
            {
                enableManuelLocation(false);
            }
        }
        private void radioButtonPerson_CheckedChanged(object sender, EventArgs e)
        {
            enableManuelLocation(false);
        }
        private void buttonPersonTrack_Click(object sender, EventArgs e)
        {
            if (selectedUserId != null)
            {
                panelPersonList.Hide();
                tracking(true);
            }

        }
        private void buttonTracking_Click(object sender, EventArgs e)
        {
            tracking();
        }
        private void buttonSafe_Click(object sender, EventArgs e)
        {
            currentUser.situation = Situation.SAFE;
            tracking();
            userRepository.setSelectedUser(currentUser);
            userRepository.setUser(currentUser);
        }

        private void setUsersDataGridView()
        {
            dataGridViewPersonList.Columns.Add("name", "Name");
            dataGridViewPersonList.Columns.Add("situation", "Situation");
            dataGridViewPersonList.Columns.Add("deviceId", "Device ID");
        }
        private async void getUsersToDataGridView()
        {
            var userListTask = userRepository.getUserListAsync();

            await Task.WhenAll(userListTask);

            var userList = userListTask.Result;

            foreach (User user in userList)
            {
                dataGridViewPersonList.Rows.Add(user.name, user.situation, user.deviceId);
                mapSetter.setPhoneLocation(user);
            }

            dataGridViewPersonList.ClearSelection();

        }
        private async void setCurrentUserToTextBoxes(User selectedUser)
        {
            labelPersonName.Text = selectedUser.name + " " + selectedUser.surname;
            labelPersonAge.Text = selectedUser.age.ToString();
            labelPersonPhone.Text = selectedUser.phoneNo.ToString();
            labelPhoneId.Text = selectedUser.deviceId;
            labelPersonSituation.Text = selectedUser.situation;
            labelLocationTime.Text = selectedUser.locationTime.ToString(); //TODO: değiştir
            labelPhoneLongitude.Text = selectedUser.longitude.ToString();
            labelPhoneLatitude.Text = selectedUser.latitude.ToString();
        }


        private async void getSelectedUser()
        {
            while (true)
            {
                if (selectedUserId != null)
                {
                    var user = await userRepository.getUserAsync(selectedUserId);
                    setCurrentUserToTextBoxes(user);
                    mapSetter.setPhoneLocation(user);
                    currentUser = user;
                    mapSetter.selectMarker(user.deviceId);
                    if (trackSituation)
                    {
                        userRepository.setSelectedUser(user);
                    }
                }
                await Task.Delay(2000);
            }
        }
        private void enableManuelLocation(bool enable)
        {
            textBoxDroneLongitude.Enabled = enable;
            textBoxDroneLatitude.Enabled = enable;
            buttonSendLocation.Enabled = enable;
            checkBoxManuelLocation.Checked = enable;
        }


        private void setDrone()
        {
            drone.droneId = "Hexacopter";
            drone.tracking = false;
            userRepository.setDrone(drone);

        }
        private void sendDroneInfo(bool tracking)
        {
            drone.tracking = tracking;
            userRepository.setDrone(drone);
        }

        private void tracking()
        {
            trackSituation = !trackSituation;
            trackingBody(trackSituation);

        }
        private void tracking(bool open)
        {
            trackSituation = open;
            trackingBody(open);

        }
        private void trackingBody(bool open)
        {
            if (open)
            {
                buttonTracking.Text = "Stop Tracking";
                buttonSafe.Text = "Stop Tracking And Mark As Safe";
            }
            else
            {
                buttonTracking.Text = "Start Tracking";
                buttonSafe.Text = "Mark As Safe";
            }
            sendDroneInfo(open);
        }


    }
}
