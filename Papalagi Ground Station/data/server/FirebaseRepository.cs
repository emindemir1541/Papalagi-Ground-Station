using FireSharp.Response;
using GMap.NET.WindowsForms;
using Papalagi_Ground_Station.map;
using Papalagi_Ground_Station.util;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Papalagi_Ground_Station.helper;

namespace Papalagi_Ground_Station.data
{
    class FirebaseRepository : FirebaseBase
    {
        private const String basePath = "DataStore/";
        private const String dronePath = "Drone/";
        private const String usersPath = basePath + "Users/";
        private const String selectedUserPath = basePath + dronePath + "selectedUser/";
        private const String droneInfoPath = basePath + dronePath + "droneInfo/";



        public async Task<User> getUserAsync(String deviceId)
        {

            await Task.Delay(1000);

            FirebaseResponse response = await client.GetTaskAsync(usersPath + deviceId);
            User user = response.ResultAs<User>();

            return user;

        }

        public async Task<List<User>> getUserListAsync()
        {
            await Task.Delay(1000);

            FirebaseResponse response = await client.GetTaskAsync(usersPath);

            return JsonHelper.AsObjectList<User>(response.Body);
        }

        public async void setSelectedUser(User user)
        {
            SetResponse response = await client.SetTaskAsync(selectedUserPath, user);
            User finalUser = response.ResultAs<User>();
            //return finalUser;
        }

        public async void setUser(User user)
        {
            SetResponse response = await client.SetTaskAsync(usersPath+user.deviceId, user);
            User finalUser = response.ResultAs<User>();
            //return finalUser;
        }

        public async void setDrone(Drone drone)
        {
            SetResponse response = await client.SetTaskAsync(droneInfoPath, drone);
        }


        public async Task updateUser(User user)
        {
            FirebaseResponse response = await client.UpdateTaskAsync(usersPath + user.deviceId, user);
            User finalUser = response.ResultAs<User>();

            MessageBox.Show(finalUser.name);
            // return user;
        }
    }
}
