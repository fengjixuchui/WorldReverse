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

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltTransformTrackerScript : MonoBehaviour // TypeDefIndex: 9660
	{
		// Fields
		// [Tooltip] // 0x00000001895F8F60-0x00000001895F8F90
		public LightningBoltPrefabScript LightningScript; // 0x18
		// [Tooltip] // 0x0000000189601D20-0x0000000189601D50
		public Transform StartTarget; // 0x20
		// [Tooltip] // 0x000000018960AF90-0x000000018960AFC0
		public Transform EndTarget; // 0x28
		// [SingleLine] // 0x0000000189613B80-0x0000000189613BB0
		public RangeOfFloats ScaleLimit; // 0x30
		private readonly Dictionary<Transform, LightningCustomTransformStateInfo> transformStartPositions; // 0x38
	
		// Constructors
		public LightningBoltTransformTrackerScript() {} // 0x0000000186042270-0x0000000186042320
	
		// Methods
		// [XID] // 0x000000018961CC40-0x000000018961CC60
		private void Start() {} // 0x0000000186041620-0x0000000186041790
		// [XID] // 0x00000001896F9000-0x00000001896F9020
		private static float AngleBetweenVector2(Vector2 vec1, Vector2 vec2) => default; // 0x00000001860412A0-0x0000000186041430
		// [XID] // 0x000000018962B950-0x000000018962B970
		private static void UpdateTransform(LightningCustomTransformStateInfo state, LightningBoltPrefabScript script, RangeOfFloats scaleLimit) {} // 0x0000000186041790-0x0000000186042270
		// [XID] // 0x0000000189708080-0x00000001897080A0
		public void CustomTransformHandler(LightningCustomTransformStateInfo state) {} // 0x0000000186041430-0x0000000186041620
	}
}
