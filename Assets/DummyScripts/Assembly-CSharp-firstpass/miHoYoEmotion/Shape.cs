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

namespace miHoYoEmotion
{
	[Serializable]
	public class Shape // TypeDefIndex: 8531
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public List<int> blendShapes; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public List<string> blendableNames; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public List<float> weights; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public List<BoneShape> bones; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool verified; // 0x30
	
		// Constructors
		public Shape() {} // 0x000000018726B780-0x000000018726B920
	
		// Methods
		// [XID] // 0x000000018982B800-0x000000018982B820
		public bool HasBone(Transform bone) => default; // 0x000000018726B4A0-0x000000018726B610
		// [XID] // 0x0000000189674830-0x0000000189674850
		public int IndexOfBone(Transform bone) => default; // 0x000000018726B610-0x000000018726B780
	}
}
