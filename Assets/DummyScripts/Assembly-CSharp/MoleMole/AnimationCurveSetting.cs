/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x0000000189660AF0-0x0000000189660B30
	public class AnimationCurveSetting : ScriptableObject // TypeDefIndex: 19596
	{
		// Fields
		public CurveStyle[] styles; // 0x18
	
		// Nested types
		[Serializable]
		public class CurveStyle // TypeDefIndex: 19597
		{
			// Fields
			public string curveName; // 0x10
			public AnimationCurve curve; // 0x18
			public float duration; // 0x20
	
			// Constructors
			public CurveStyle() {} // 0x0000000184E82B10-0x0000000184E82B70
		}
	
		// Constructors
		public AnimationCurveSetting() {} // 0x0000000184E790D0-0x0000000184E79130
	}
}
