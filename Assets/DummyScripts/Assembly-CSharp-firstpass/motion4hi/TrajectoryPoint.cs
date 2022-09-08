/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace motion4hi
{
	[Serializable]
	public struct TrajectoryPoint // TypeDefIndex: 9399
	{
		// Fields
		public float t; // 0x00
		[NonSerialized]
		public Quaternion q; // 0x04
		public Vector3 p; // 0x14
	
		// Methods
		// [XID] // 0x0000000189A6C500-0x0000000189A6C520
		public static TrajectoryPoint Evaluate(List<TrajectoryPoint> points, float t) => default; // 0x00000001853E8C80-0x00000001853E90E0
		// [XID] // 0x000000018973D0D0-0x000000018973D0F0
		public static List<TrajectoryPoint> SampleCurve(AnimationClip inClip, GameObject sampleGo, string inChildName, float step = 0.016f /* Metadata: 0x00AE5836 */) => default; // 0x00000001853E90E0-0x00000001853E9470
	}
}
