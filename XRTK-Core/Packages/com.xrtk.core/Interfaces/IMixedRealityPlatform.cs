﻿// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace XRTK.Interfaces
{
    /// <summary>
    /// Defines the platform to be registered
    /// </summary>
    public interface IMixedRealityPlatform
    {
        /// <summary>
        /// Is this platform currently available?
        /// </summary>
        bool IsAvailable { get; }
    }
}