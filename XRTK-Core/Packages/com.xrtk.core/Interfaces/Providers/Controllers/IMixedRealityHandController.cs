﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;
using XRTK.Definitions.Utilities;
using XRTK.Providers.Controllers.Hands;

namespace XRTK.Interfaces.Providers.Controllers
{
    /// <summary>
    /// Controller definition, used to manage a hand controller.
    /// </summary>
    public interface IMixedRealityHandController : IMixedRealityController
    {
        /// <summary>
        /// Gets the axis aligned bounds of the hand controller.
        /// </summary>
        Bounds Bounds { get; }

        /// <summary>
        /// Gets whether this hand controller is currently tracked.
        /// </summary>
        bool IsTracked { get; }

        /// <summary>
        /// Gets whether the hand is in pointing pose for raycasting.
        /// </summary>
        bool IsInPointingPose { get; }

        /// <summary>
        /// Get the current pose of a joint of the hand.
        /// </summary>
        /// <remarks>
        /// Hand bones should be oriented along the Z-axis, with the Y-axis indicating the "up" direction,
        /// i.e. joints rotate primarily around the X-axis.
        /// </remarks>
        bool TryGetJointPose(TrackedHandJoint joint, out MixedRealityPose pose);

        /// <summary>
        /// Updates the state of the hand controller using provided hand data.
        /// </summary>
        /// <param name="handData">Updated hand data for this controller.</param>
        void UpdateState(HandData handData);
    }
}