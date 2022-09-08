/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public sealed class TerrainGrassViewDistanceConfig : ScriptableObjectUseFiEdit // TypeDefIndex: 26560
	{
		// Fields
		public List<GrassViewDistanceConfig> grassQualitySetting; // 0x18
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Dictionary<GrassQualityLevel, GrassViewDistanceConfig> grassQualitySettingMap; // 0x20
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int[] viewRangeArr; // 0x28
	
		// Constructors
		public TerrainGrassViewDistanceConfig() {} // 0x0000000182B1CD30-0x0000000182B1CDC0
	
		// Methods
		// [XID] // 0x0000000189B815E0-0x0000000189B81600
		public void Init() {} // 0x0000000182B1CAB0-0x0000000182B1CD30
	}
}
