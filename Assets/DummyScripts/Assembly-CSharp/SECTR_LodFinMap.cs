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
public sealed class SECTR_LodFinMap : ScriptableObjectUseFiEdit // TypeDefIndex: 31966
{
	// Fields
	public List<SECTR_LODFinInfo> lodFinInfos; // 0x18
	[NonSerialized]
	private Dictionary<int, SECTR_LODFinInfo> _name2LodFinInfo; // 0x20

	// Constructors
	public SECTR_LodFinMap() {} // 0x0000000181B597B0-0x0000000181B59860

	// Methods
	public void Init() {} // 0x0000000181B59510-0x0000000181B59630
	public void Clear() {} // 0x0000000181B593F0-0x0000000181B59460
	public SECTR_LODFinInfo GetObjInfoByName(int nameHash) => default; // 0x0000000181B59460-0x0000000181B59510
	public bool RefreshFinInfo(SECTR_LODFinInfo info) => default; // 0x0000000181B59630-0x0000000181B597B0
}

