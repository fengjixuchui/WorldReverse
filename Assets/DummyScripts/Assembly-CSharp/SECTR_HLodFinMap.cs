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
public sealed class SECTR_HLodFinMap : ScriptableObjectUseFiEdit // TypeDefIndex: 31964
{
	// Fields
	public List<SECTR_HLODFinInfo> lodFinInfos; // 0x18
	[NonSerialized]
	private Dictionary<int, SECTR_HLODFinInfo> _name2LodFinInfo; // 0x20

	// Constructors
	public SECTR_HLodFinMap() {} // 0x0000000181B58230-0x0000000181B582E0

	// Methods
	public void Init() {} // 0x0000000181B57F90-0x0000000181B580B0
	public void Clear() {} // 0x0000000181B57E70-0x0000000181B57EE0
	public SECTR_HLODFinInfo GetObjInfoByName(int nameHash) => default; // 0x0000000181B57EE0-0x0000000181B57F90
	public bool RefreshFinInfo(SECTR_HLODFinInfo info) => default; // 0x0000000181B580B0-0x0000000181B58230
}

