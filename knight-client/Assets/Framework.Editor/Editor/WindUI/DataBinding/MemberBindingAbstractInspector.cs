﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using NaughtyAttributes.Editor;

namespace UnityEditor.UI
{
    [CustomEditor(typeof(MemberBindingAbstract), true)]
    public class MemberBindingAbstractInspector : InspectorEditor
    {
        private MemberBindingAbstract     mTargetAbstract;

        protected override void OnEnable()
        {
            base.OnEnable();
            mTargetAbstract = this.target as MemberBindingAbstract;
        }

        public override void OnInspectorGUI()
        {
            this.mTargetAbstract.GetPaths();
            base.OnInspectorGUI();
        }
    }
}
