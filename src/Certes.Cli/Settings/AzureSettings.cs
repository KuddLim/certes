﻿using System;

namespace Certes.Cli.Settings
{
    internal class AzureSettings
    {
        public string SubscriptionId { get; set; }
        public string TenantId { get; set; }
        public string ClientSecret { get; set; }
        public string ClientId { get; set; }
    }
}
