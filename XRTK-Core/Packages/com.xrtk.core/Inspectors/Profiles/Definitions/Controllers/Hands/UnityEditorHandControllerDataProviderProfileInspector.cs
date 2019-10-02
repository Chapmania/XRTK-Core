﻿// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEditor;
using XRTK.Definitions.InputSystem.Simulation;

namespace XRTK.Definitions.Controllers.Hands.Inspectors.Profiles
{
    [CustomEditor(typeof(UnityEditorHandControllerDataProviderProfile))]
    public class UnityEditorHandControllerDataProviderProfileInspector : HandControllerDataProviderProfileInspector
    {
        private SerializedProperty simulateHandTracking;

        private SerializedProperty toggleLeftHandKey;
        private SerializedProperty toggleRightHandKey;
        private SerializedProperty handHideTimeout;
        private SerializedProperty leftHandManipulationKey;
        private SerializedProperty rightHandManipulationKey;

        private SerializedProperty poseDefinitions;
        private SerializedProperty handGestureAnimationSpeed;

        private SerializedProperty defaultHandDistance;
        private SerializedProperty handDepthMultiplier;
        private SerializedProperty handJitterAmount;

        private SerializedProperty yawHandCWKey;
        private SerializedProperty yawHandCCWKey;
        private SerializedProperty pitchHandCWKey;
        private SerializedProperty pitchHandCCWKey;
        private SerializedProperty rollHandCWKey;
        private SerializedProperty rollHandCCWKey;
        private SerializedProperty handRotationSpeed;

        private SerializedProperty holdStartDuration;
        private SerializedProperty manipulationStartThreshold;

        protected override void OnEnable()
        {
            base.OnEnable();

            simulateHandTracking = serializedObject.FindProperty("simulateHandTracking");

            toggleLeftHandKey = serializedObject.FindProperty("toggleLeftHandKey");
            toggleRightHandKey = serializedObject.FindProperty("toggleRightHandKey");
            handHideTimeout = serializedObject.FindProperty("handHideTimeout");
            leftHandManipulationKey = serializedObject.FindProperty("leftHandManipulationKey");
            rightHandManipulationKey = serializedObject.FindProperty("rightHandManipulationKey");

            poseDefinitions = serializedObject.FindProperty("poseDefinitions");
            handGestureAnimationSpeed = serializedObject.FindProperty("handGestureAnimationSpeed");

            holdStartDuration = serializedObject.FindProperty("holdStartDuration");
            manipulationStartThreshold = serializedObject.FindProperty("manipulationStartThreshold");

            defaultHandDistance = serializedObject.FindProperty("defaultHandDistance");
            handDepthMultiplier = serializedObject.FindProperty("handDepthMultiplier");
            handJitterAmount = serializedObject.FindProperty("handJitterAmount");

            yawHandCWKey = serializedObject.FindProperty("yawHandCWKey");
            yawHandCCWKey = serializedObject.FindProperty("yawHandCCWKey");
            pitchHandCWKey = serializedObject.FindProperty("pitchHandCWKey");
            pitchHandCCWKey = serializedObject.FindProperty("pitchHandCCWKey");
            rollHandCWKey = serializedObject.FindProperty("rollHandCWKey");
            rollHandCCWKey = serializedObject.FindProperty("rollHandCCWKey");
            handRotationSpeed = serializedObject.FindProperty("handRotationSpeed");
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            serializedObject.Update();

            EditorGUILayout.PropertyField(simulateHandTracking);
            EditorGUILayout.Space();

            EditorGUILayout.BeginVertical("Label");

            EditorGUILayout.PropertyField(toggleLeftHandKey);
            EditorGUILayout.PropertyField(toggleRightHandKey);
            EditorGUILayout.PropertyField(handHideTimeout);
            EditorGUILayout.PropertyField(leftHandManipulationKey);
            EditorGUILayout.PropertyField(rightHandManipulationKey);
            EditorGUILayout.Space();

            EditorGUILayout.PropertyField(poseDefinitions, true);
            EditorGUILayout.PropertyField(handGestureAnimationSpeed);
            EditorGUILayout.Space();

            EditorGUILayout.PropertyField(holdStartDuration);
            EditorGUILayout.PropertyField(manipulationStartThreshold);
            EditorGUILayout.Space();

            EditorGUILayout.PropertyField(defaultHandDistance);
            EditorGUILayout.PropertyField(handDepthMultiplier);
            EditorGUILayout.PropertyField(handJitterAmount);
            EditorGUILayout.Space();

            EditorGUILayout.PropertyField(yawHandCWKey);
            EditorGUILayout.PropertyField(yawHandCCWKey);
            EditorGUILayout.PropertyField(pitchHandCWKey);
            EditorGUILayout.PropertyField(pitchHandCCWKey);
            EditorGUILayout.PropertyField(rollHandCWKey);
            EditorGUILayout.PropertyField(rollHandCCWKey);
            EditorGUILayout.PropertyField(handRotationSpeed);
            EditorGUILayout.Space();

            EditorGUILayout.EndVertical();

            serializedObject.ApplyModifiedProperties();
        }
    }
}