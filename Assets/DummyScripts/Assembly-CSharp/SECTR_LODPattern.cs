/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[Serializable]
public class SECTR_LODPattern // TypeDefIndex: 31951
{
	// Fields
	public string patternName; // 0x10
	public List<SECTR_LODQualityInfo> multiplatform; // 0x18
	public List<SECTR_LODThreshold> lodThresholds; // 0x20
	private Dictionary<int, SECTR_LODThreshold> _lod2Threshold; // 0x28
	private Dictionary<int, SECTR_LODQualityInfo> _name2Quality; // 0x30

	// Constructors
	public SECTR_LODPattern() {} // 0x0000000181B58CC0-0x0000000181B58DC0

	// Methods
	public void InitPattern() {} // 0x0000000181B58AC0-0x0000000181B58CC0
	public SECTR_LODThreshold GetLODThreshold(int index) => default; // 0x0000000181B58920-0x0000000181B589F0
	public SECTR_LODQualityInfo GetQuality(int index) => default; // 0x0000000181B589F0-0x0000000181B58AC0
}

