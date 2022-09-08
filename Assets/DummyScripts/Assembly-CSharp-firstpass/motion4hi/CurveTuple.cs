/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace motion4hi
{
	[Serializable]
	public class CurveTuple // TypeDefIndex: 9378
	{
		// Fields
		public AnimationCurve xCurve; // 0x10
		public AnimationCurve yCurve; // 0x18
		public AnimationCurve zCurve; // 0x20
		public AnimationCurve wCurve; // 0x28
	
		// Constructors
		public CurveTuple() {} // 0x00000001853CD090-0x00000001853CD110
	
		// Methods
		// [XID] // 0x00000001896FF690-0x00000001896FF6B0
		public float Evaluate(float t) => default; // 0x00000001853CCFC0-0x00000001853CD090
		// [XID] // 0x0000000189BD0190-0x0000000189BD01B0
		public Vector3 EvaluateVec(float t) => default; // 0x00000001853CCE30-0x00000001853CCFC0
		// [XID] // 0x000000018970E3D0-0x000000018970E3F0
		public Quaternion EvaluateQuat(float t) => default; // 0x00000001853CCC80-0x00000001853CCE30
	}
}
