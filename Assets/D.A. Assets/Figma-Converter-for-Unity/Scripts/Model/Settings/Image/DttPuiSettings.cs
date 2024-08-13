﻿using System;
using UnityEngine;

namespace DA_Assets.FCU.Model
{
    [Serializable]
    public class DttPuiSettings : BaseImageSettings
    {
        [SerializeField] float falloffDistance = 1f;
        public float FalloffDistance { get => falloffDistance; set => SetValue(ref falloffDistance, value); }
    }
}