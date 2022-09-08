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
public class SECTR_LODQualityInfo : IEquatable<SECTR_LODQualityInfo> // TypeDefIndex: 31950
{
	// Fields
	public string qualityName; // 0x10
	public List<LODType> lodMask; // 0x18
	public int beginGroupLOD; // 0x20
	public bool enableFadeIn; // 0x24
	public float platformViewScale; // 0x28
	public float platformHeightScale; // 0x2C
	private List<bool> _lodHashSet; // 0x30

	// Constructors
	public SECTR_LODQualityInfo() {} // 0x0000000181B59190-0x0000000181B59260

	// Methods
	public void Init() {} // 0x0000000181B59090-0x0000000181B59190
	public bool HasLod(int lod) => default; // 0x0000000181B59000-0x0000000181B59090
	public bool Equals(SECTR_LODQualityInfo platform) => default; // 0x0000000181B58DC0-0x0000000181B59000
}

