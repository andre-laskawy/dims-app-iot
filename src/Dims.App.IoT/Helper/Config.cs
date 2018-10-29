///-----------------------------------------------------------------
///   File:         ConfigHelper.cs
///   Author:   	Andre Laskawy           
///   Date:         02.10.2018 16:47:28
///-----------------------------------------------------------------

namespace Dims.Services.Speechrecognition.IoT.Helper
{
    /// <summary>
    /// Defines the <see cref="Config" />
    /// </summary>
    public class Config
    {
        /// <summary>
        /// Gets or sets the secret.
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// Gets or sets the SrcDeviceId
        /// Gets the source device identifier.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the broker user.
        /// </summary>
        public string SpeechRecognitionServiceUser { get; set; }

        /// <summary>
        /// Gets or sets the broker user.
        /// </summary>
        public string SmartHomeServiceUser { get; set; }

        /// <summary>
        /// Gets or sets the broker pass.
        /// </summary>
        public string Pass { get; set; }

        /// <summary>
        /// Gets or sets the LocalCloudAddress
        /// Gets the local cloud address.
        /// </summary>
        public string BrokerAddress { get; set; }

        /// <summary>
        /// Gets or sets the smart home user.
        /// </summary>
        public string SmartHomeUser { get; set; }

        /// <summary>
        /// Gets or sets the smart home pass.
        /// </summary>
        public string SmartHomePass { get; set; }

        /// <summary>
        /// Gets or sets the living room identifier.
        /// </summary>
        public string LivingRoomId { get; set; }
    }
}
