using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using System.Drawing;
using Papalagi_Ground_Station.util;

namespace Papalagi_Ground_Station.map
{
    public class MapSetter
    {
        GMapControl map;
        GMapOverlay droneMarkers = new GMapOverlay("droneMarkers");
        GMapOverlay phoneMarkers = new GMapOverlay("phoneMarkers");

        public MapSetter(GMapControl map)
        {
            this.map = map;
        }

        public void setDroneLocation(string _longitude, string _latitude)
        {
            PointLatLng droneLocation = new PointLatLng(float.Parse(_latitude), float.Parse(_longitude));
            GMapMarker marker = new GMarkerGoogle(droneLocation, coustumMarker());
            droneMarkers.Markers.Add(marker);
            map.Position = droneLocation;
        }

        public void setPhoneLocation(User user)
        {
            removeLocation(user.deviceId);
            PointLatLng phoneLocation = new PointLatLng(user.latitude, user.longitude);
            GMapMarker marker = new GMarkerGoogle(phoneLocation, GMarkerGoogleType.blue_small);
            marker.Tag = user.deviceId;
            marker.ToolTipText = MarkerColor.BLUE;
            phoneMarkers.Markers.Add(marker);
        }

        public void removeLocation(string userId)
        {
            foreach (var marker in phoneMarkers.Markers.ToList())
            {
                if (marker.Tag.ToString() == userId)
                {
                    marker.Overlay.Markers.Remove(marker);
                }
            }
        }


        public void selectMarker(string userId)
        {
            GMapMarker selectedMarker = null;
            var markers = phoneMarkers.Markers.ToList();
            foreach (GMapMarker marker in markers)
            {
                if (marker.Tag.ToString() == userId)
                {
                    marker.Overlay.Markers.Remove(marker);
                    GMapMarker newMarker = new GMarkerGoogle(marker.Position, GMarkerGoogleType.red_dot);
                    newMarker.Tag = marker.Tag;
                    newMarker.ToolTipText = MarkerColor.RED;
                    marker.Overlay.Markers.Add(newMarker);
                    selectedMarker = newMarker;
                }
                else
                {
                    if (marker.ToolTipText == MarkerColor.RED)
                    {
                        marker.Overlay.Markers.Remove(marker);
                        GMapMarker newMarker = new GMarkerGoogle(marker.Position, GMarkerGoogleType.blue_dot);
                        newMarker.Tag = marker.Tag;
                        newMarker.ToolTipText = MarkerColor.BLUE;
                    }
                }
            }
            if (selectedMarker != null)
            {
                map.Position = selectedMarker.Position;
            }

        }


        public string route()
        {
            /*    var route = GoogleMapProvider.Instance.GetRoute(lastPoint(droneMarkers), lastPoint(phoneMarkers), false, false, 14);
                var r = new GMapRoute(route.Points, "Tracking Route");
                var routes = new GMapOverlay("routes");
                routes.Routes.Add(r);
                map.Overlays.Add(routes);*/

            return "";
        }



        private Bitmap coustumMarker()
        {
            //  Bitmap markerType = (Bitmap)Image.FromFile("img/droneFlag.png");
            return (Bitmap)Image.FromFile("img/droneFlag.png");

        }

        private PointLatLng lastPoint(GMapOverlay markerList)
        {
            return markerList.Markers.Last<GMapMarker>().Position;
        }

        private void removeDroneMarkers()
        {
            if (map.Overlays.Count > 0 && droneMarkers.Markers.Count > 0)
            {
                map.Overlays.Remove(droneMarkers);
                droneMarkers.Markers.Clear();
                map.Refresh();
            }
        }

        private void removePhoneMarkers()
        {
            if (map.Overlays.Count > 0 && phoneMarkers.Markers.Count > 0)
            {
                map.Overlays.Remove(phoneMarkers);
                phoneMarkers.Markers.Clear();
                map.Refresh();
            }
        }

        public MapSetter settings()
        {
            map.Overlays.Add(phoneMarkers);
            map.Overlays.Add(droneMarkers);
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.MaxZoom = 25;
            map.MinZoom = 5;
            map.Zoom = 13;
            map.ShowCenter = false;
            map.SetAutoScrollMargin(840, 745);
            return this;
        }

    }
}
