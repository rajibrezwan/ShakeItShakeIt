using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ShakeItShakeIt.Resources;
using ShakeGestures;

namespace ShakeItShakeIt
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
            ShakeGesturesHelper.Instance.ShakeGesture += new EventHandler<ShakeGestureEventArgs>(Perform_Shakeevent);


            //set the no of shake parameter after which you want shake event handler to fire
            ShakeGesturesHelper.Instance.MinimumRequiredMovesForShake = 3;

            //Activate the shake gesture helper
            ShakeGesturesHelper.Instance.Active = true;
        }
        private void Perform_Shakeevent(object sender, ShakeGestureEventArgs e)
        {
            //Enclose the task you need to perform in the following dispatcher code
            Dispatcher.BeginInvoke(() =>
            {
               // displayblock.Text = DateTime.Now.ToLongTimeString();
                Media.Play();
            });
        }
        
        
    }
}