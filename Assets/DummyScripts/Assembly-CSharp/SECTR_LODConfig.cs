/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[Serializable]
public sealed class SECTR_LODConfig : ScriptableObjectUseFiEdit // TypeDefIndex: 31965
{
	// Fields
	public List<SECTR_LODPattern> lodPatterns; // 0x18
	[NonSerialized]
	private Dictionary<int, SECTR_LODPattern> _type2LodPattern; // 0x20

	// Constructors
	public SECTR_LODConfig() {} // 0x0000000181B58770-0x0000000181B58820

	// Methods
	public void Init() {} // 0x0000000181B58510-0x0000000181B58670
	public void Clear() {} // 0x0000000181B58340-0x0000000181B583B0
	public SECTR_LODPattern GetPattern(int nameHash) => default; // 0x0000000181B58460-0x0000000181B58510
	public SECTR_LODPattern GetDefaultPattern() => default; // 0x0000000181B583B0-0x0000000181B58460
	public bool RefreshLODPattern(SECTR_LODPattern info) => default; // 0x0000000181B58670-0x0000000181B58770
}

