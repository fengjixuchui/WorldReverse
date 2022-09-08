/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using PigeonCoopToolkit.Effects.Trails;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoEffectPluginTrailStatic : MonoEffectPluginTrail // TypeDefIndex: 19748
	{
		// Fields
		private StaticTrail _staticTrail; // 0x48
		public bool generateDefaultDuration; // 0x50
		public float appearDuration; // 0x54
		public AnimationCurve appearCurve; // 0x58
		public float vanishDuration; // 0x60
		public AnimationCurve vanishCurve; // 0x68
		private float _timer; // 0x70
		private bool _haveSetUp; // 0x74
		// [Header] // 0x0000000189704520-0x0000000189704550
		public string MaterialOverrideKey; // 0x78
		// [Header] // 0x00000001896CF460-0x00000001896CF490
		public string EffectOverlayKey; // 0x80
		public float TimeScale; // 0x88
	
		// Properties
		public StaticTrail staticTrail { /* [XID] */ /* 0x0000000189713620-0x0000000189713640 */ get => default; } // 0x0000000183C9AF70-0x0000000183C9B010 
	
		// Constructors
		public MonoEffectPluginTrailStatic() {} // 0x0000000183C9AE80-0x0000000183C9AF70
	
		// Methods
		// [XID] // 0x000000018971AE00-0x000000018971AE20
		public override void Awaked() {} // 0x0000000183C9A440-0x0000000183C9A550
		// [XID] // 0x0000000189722140-0x0000000189722160
		public override void Init() {} // 0x0000000183C9A7E0-0x0000000183C9AAA0
		// [XID] // 0x00000001897298A0-0x00000001897298C0
		public override void Enabled() {} // 0x0000000183C9A5F0-0x0000000183C9A690
		// [XID] // 0x0000000189731040-0x0000000189731060
		public override void Tick(float inDeltaTime) {} // 0x0000000183C9AD60-0x0000000183C9AE80
		// [XID] // 0x0000000189738910-0x0000000189738930
		private void SetAniAnchor() {} // 0x0000000183C9ABA0-0x0000000183C9ACA0
		// [XID] // 0x0000000189740690-0x00000001897406B0
		public override bool IsToBeDeallocated() => default; // 0x0000000183C9AAA0-0x0000000183C9ABA0
		// [XID] // 0x0000000189747A10-0x0000000189747A30
		public override void Clear() {} // 0x0000000183C9A550-0x0000000183C9A5F0
	}
}
