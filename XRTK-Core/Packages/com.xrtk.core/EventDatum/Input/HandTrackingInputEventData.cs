﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;
using UnityEngine.EventSystems;
using XRTK.Definitions.Utilities;
using XRTK.Interfaces.InputSystem;
using XRTK.Interfaces.Providers.Controllers;

namespace XRTK.EventDatum.Input
{
    public class HandTrackingInputEventData : InputEventData<Vector3>
    {
        /// <summary>
        /// Constructor creates a default EventData object.
        /// Requires initialization.
        /// </summary>
        /// <param name="eventSystem"></param>
        public HandTrackingInputEventData(EventSystem eventSystem) : base(eventSystem) { }

        public IMixedRealityController Controller { get; set; }

        /// <summary>
        /// This function is called to fill the HandTrackingIntputEventData object with information
        /// </summary>
        /// <param name="inputSource">Reference to the HandTrackingInputSource that created the EventData</param>
        /// <param name="controller">Reference to the IMixedRealityController that created the EventData</param>
        /// <param name="sourceHandedness">Handedness of the HandTrackingInputSource that created the EventData</param>
        /// <param name="touchPoint">Global position of the HandTrackingInputSource that created the EventData</param>
        public void Initialize(IMixedRealityInputSource inputSource, IMixedRealityController controller, Handedness sourceHandedness, Vector3 touchPoint)
        {
            Initialize(inputSource, sourceHandedness, MixedRealityInputAction.None, touchPoint);
            Controller = controller;
        }
    }
}