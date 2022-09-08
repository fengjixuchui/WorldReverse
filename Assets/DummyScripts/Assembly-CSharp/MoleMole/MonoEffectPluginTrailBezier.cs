/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoEffectPluginTrailBezier : MonoEffectPluginTrail // TypeDefIndex: 19741
	{
		// Fields
		public int InterpolationSteps; // 0x48
		public float SmoothValue; // 0x4C
		private const int CURVE_DEGREE = 4; // Metadata: 0x00AFCCED
		private Vector3[] _points; // 0x50
		private int _pointReady; // 0x58
	
		// Constructors
		public MonoEffectPluginTrailBezier() {} // 0x0000000183C95100-0x0000000183C95180
	
		// Methods
		// [XID] // 0x0000000189B49020-0x0000000189B49040
		public override void Awaked() {} // 0x0000000183C949B0-0x0000000183C94A80
		// [XID] // 0x0000000189B50620-0x0000000189B50640
		public override void Tick(float inDeltaTime) {} // 0x0000000183C94EA0-0x0000000183C95100
		// [XID] // 0x0000000189B57F60-0x0000000189B57F80
		private void DrawBezierCurve() {} // 0x0000000183C94B60-0x0000000183C94EA0
	}
}
