using Dims.Services.Speechrecognition.IoT;
using Dims.Services.Speechrecognition.IoT.Helper;
using Dims.Smarthome.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace Dims.App.IoT
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Init();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public async void Init()
        {
            Configuration.Load();

            await SmartHomeService.Run(Configuration.Current.BrokerAddress, Configuration.Current.SmartHomeServiceUser,
              Configuration.Current.Pass, Configuration.Current.Secret, Configuration.Current.SmartHomeUser,
              Configuration.Current.SmartHomePass, Configuration.Current.LivingRoomId);

            SpeechRecognitionService.Run(Configuration.Current.BrokerAddress, Configuration.Current.SpeechRecognitionServiceUser,
                Configuration.Current.Pass, Configuration.Current.Secret, "James");
        }
    }
}
