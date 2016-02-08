using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;
using Microsoft.Kinect.Toolkit.Controls;

namespace TestKinectDeLaMort
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private KinectSensor myKinect;
        private Skeleton[] skeletonData;


        //Variable pour juste caméra
        // private KinectSensor sensor;
        private ColorImageFormat lastImageFormat = ColorImageFormat.Undefined;
        private Byte[] pixelData;
        private WriteableBitmap outputImage;
        private static readonly int Bgr32BytesPerPixel = (PixelFormats.Bgr32.BitsPerPixel + 7) / 8;

        //Pour caméra
        /*private void Window_Loaded(Object Sender, RoutedEventArgs e)
        {
            sensor = KinectSensor.KinectSensors[0];

            if (sensor.Status == KinectStatus.Connected)
            {
                sensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
                sensor.ColorFrameReady += new EventHandler<ColorImageFrameReadyEventArgs>(sensor_ColorFrameReady);
                sensor.Start();
            }
        }*/

        private void Window_Loaded(Object Sender, RoutedEventArgs e)
        {
            myKinect = KinectSensor.KinectSensors[0];

            if (myKinect.Status == KinectStatus.Connected)
            {
                myKinect.SkeletonStream.Enable();
                myKinect.SkeletonFrameReady += new EventHandler<SkeletonFrameReadyEventArgs>(myKinect_AllFramesReady);
                myKinect.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
                myKinect.ColorFrameReady += new EventHandler<ColorImageFrameReadyEventArgs>(sensor_ColorFrameReady);
                myKinect.Start();
            }
        }

        private void myKinect_AllFramesReady(Object sender,SkeletonFrameReadyEventArgs e)
        {
            using (SkeletonFrame skeletonFrame = e.OpenSkeletonFrame())
            {
                if (skeletonFrame != null)
                {
                    if (this.skeletonData == null || (this.skeletonData.Length != skeletonFrame.SkeletonArrayLength))
                    {
                        this.skeletonData = new Skeleton[skeletonFrame.SkeletonArrayLength];
                    }

                    skeletonFrame.CopySkeletonDataTo(skeletonData);

                    foreach(Skeleton skeleton in skeletonData)
                    {
                        if(skeleton.TrackingState == SkeletonTrackingState.Tracked)
                        {
                            double x = 0, y = 0, z = 0;
                            Joint joint = skeleton.Joints[JointType.HandRight];
                            x = joint.Position.X;
                            y = joint.Position.Y;
                            z = joint.Position.Z;
                            tRightHand.Content = "X: " + x + " \nY: " + y + " \nZ: " + z;
                            if (x > 0.5)
                            {
                                tRightHand.Foreground = Brushes.Red;
                            } else
                            {
                                tRightHand.Foreground = Brushes.Black;
                            }
                        }
                    }
                }
            }
        }




        // pour caméra
        private void sensor_ColorFrameReady(Object sender, ColorImageFrameReadyEventArgs e)
        {
            using (ColorImageFrame imageFrame = e.OpenColorImageFrame())
            {
                if (imageFrame != null)
                {
                    bool newFormat = this.lastImageFormat != imageFrame.Format;

                    if (newFormat)
                    {
                        this.pixelData = new Byte[imageFrame.PixelDataLength];
                    }

                    imageFrame.CopyPixelDataTo(pixelData);

                    if (newFormat)
                    {
                        this.video.Visibility = Visibility.Visible;
                        this.outputImage = new WriteableBitmap(
                            imageFrame.Width,
                            imageFrame.Height,
                            96,
                            96,
                            PixelFormats.Bgr32,
                            null);

                        this.video.Source = this.outputImage;
                    }

                    this.outputImage.WritePixels(
                        new Int32Rect(0, 0, imageFrame.Width, imageFrame.Height),
                        this.pixelData,
                        imageFrame.Width * Bgr32BytesPerPixel,
                        0);

                    this.lastImageFormat = imageFrame.Format;
                }
            }
        }


        public MainWindow()
        {
            InitializeComponent();


        }
    }
}
