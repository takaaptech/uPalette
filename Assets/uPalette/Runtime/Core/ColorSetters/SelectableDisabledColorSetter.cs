﻿using UnityEngine;
using UnityEngine.UI;

namespace uPalette.Runtime.Core.ColorSetters
{
    [AddComponentMenu("")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Selectable))]
    [ColorSetter(typeof(Selectable), "Transition Disabled Color")]
    public class SelectableDisabledColorSetter : ColorSetter<Selectable>
    {
        protected override void Apply(Color color)
        {
            var colors = _component.colors;
            colors.disabledColor = color;
            _component.colors = colors;
        }
    }
}