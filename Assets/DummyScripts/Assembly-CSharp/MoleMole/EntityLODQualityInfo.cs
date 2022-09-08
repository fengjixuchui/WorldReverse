/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class EntityLODQualityInfo // TypeDefIndex: 31437
	{
		// Fields
		public string qualityName; // 0x10
		public float lod0Threshold; // 0x18
		public float lod1Threshold; // 0x1C
		public float lod2Threshold; // 0x20
		public float lod3Threshold; // 0x24
		public float lod4Threshold; // 0x28
		public float fallOffBegin; // 0x2C
		public float fallOffEnd; // 0x30
		public int disableAnimatorLod; // 0x34
		private float[] _lodArray; // 0x38
	
		// Constructors
		public EntityLODQualityInfo() {} // 0x00000001814A5BF0-0x00000001814A5C60
	
		// Methods
		// [XID] // 0x0000000189B30490-0x0000000189B304B0
		public void Init() {} // 0x00000001814A59D0-0x00000001814A5B50
		// [XID] // 0x0000000189B37DB0-0x0000000189B37DD0
		public float[] GetLodArray() => default; // 0x00000001814A5B50-0x00000001814A5BF0
	}
}
