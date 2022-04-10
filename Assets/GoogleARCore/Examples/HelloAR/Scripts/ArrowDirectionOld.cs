//-----------------------------------------------------------------------
// <copyright file="HelloARController.cs" company="Google LLC">
//
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

using UnityEngine;

namespace GoogleARCore.Examples.HelloAR
{
    internal class ArrowDirectionOld
    {
        public Quaternion targetRot;        // The rotation of the device camera from  Frame.Pose.rotation
        public GameObject arrow;            // The direction indicator on the person indicator

        void LateUpdate()
        {
            float rotationSmoothingSpeed = 0.5f;  // TODO Krasi
            Vector3 targetEulerAngles = targetRot.eulerAngles;
            float rotationToApplyAroundY = targetEulerAngles.y;
            float newCamRotAngleY = Mathf.LerpAngle(arrow.transform.eulerAngles.y,
               rotationToApplyAroundY, rotationSmoothingSpeed * Time.deltaTime);
            Quaternion newCamRotYQuat = Quaternion.Euler(0, newCamRotAngleY, 0);
            arrow.transform.rotation = newCamRotYQuat;
            Debug.Log("=== newCamRotYQuat:" + newCamRotYQuat);
            Debug.Log("=== arrow:" + arrow);
            Debug.Log("targetRot:" + targetRot);
        }

    }
}