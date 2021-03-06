﻿// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace XRTK.Definitions.Platforms
{
    /// <summary>
    ///  Used by the XRTK to signal that the feature is available on the iOS platform.
    /// </summary>
    public class IOSPlatform : BasePlatform
    {
        /// <inheritdoc />
        public override bool IsAvailable
        {
            get
            {
#if PLATFORM_IOS
                return true;
#else
                return false;
#endif
            }
        }
    }
}