﻿// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.﻿

using UnityEditor;
using XRTK.Inspectors.Utilities;
using XRTK.Definitions.Controllers;

namespace XRTK.Inspectors.Profiles.InputSystem
{
    [CustomEditor(typeof(MixedRealityControllerDataProvidersProfile))]
    public class MixedRealityControllerDataProvidersProfileInspector : MixedRealityServiceProfileInspector
    {
        public override void OnInspectorGUI()
        {
            RenderHeader();

            EditorGUILayout.LabelField("Controller Data Providers", EditorStyles.boldLabel);
            EditorGUILayout.HelpBox("Use this profile to define all the input sources your application can get input data from.", MessageType.Info);

            ThisProfile.CheckProfileLock();

            base.OnInspectorGUI();
        }
    }
}