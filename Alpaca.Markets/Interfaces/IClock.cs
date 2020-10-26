﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace Alpaca.Markets
{
    /// <summary>
    /// Encapsulates current trading date information from Alpaca REST API.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMemberInSuper.Global")]
    public interface IClock
    {
        /// <summary>
        /// Gets current timestamp (in UTC time zone).
        /// </summary>
        [Obsolete("This property will be removed in the next major release. Use the TimestampUtc property instead.", true)]
        DateTime Timestamp { get; }

        /// <summary>
        /// Gets current timestamp in UTC time zone.
        /// </summary>
        DateTime TimestampUtc { get; }

        /// <summary>
        /// Returns <c>true</c> if trading day is open now.
        /// </summary>
        Boolean IsOpen { get; }

        /// <summary>
        /// Gets nearest trading day open time (in UTC time zone).
        /// </summary>
        [Obsolete("This property will be removed in the next major release. Use the NextOpenUtc property instead.", true)]
        DateTime NextOpen { get; }

        /// <summary>
        /// Gets nearest trading day open time in UTC time zone.
        /// </summary>
        DateTime NextOpenUtc { get; }

        /// <summary>
        /// Gets nearest trading day close time (in UTC time zone).
        /// </summary>
        [Obsolete("This property will be removed in the next major release. Use the NextCloseUtc property instead.", true)]
        DateTime NextClose { get;  }

        /// <summary>
        /// Gets nearest trading day close time in UTC time zone.
        /// </summary>
        DateTime NextCloseUtc { get;  }
    }
}
