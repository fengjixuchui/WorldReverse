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
public sealed class SECTR_VoFinMap : ScriptableObjectUseFiEdit // TypeDefIndex: 31967
{
	// Fields
	public List<SECTR_VOFinInfo> voFinInfos; // 0x18
	[NonSerialized]
	private Dictionary<int, SECTR_VOFinInfo> _name2VoFinInfo; // 0x20

	// Constructors
	public SECTR_VoFinMap() {} // 0x0000000181B5BAB0-0x0000000181B5BB60

	// Methods
	public void Init() {} // 0x0000000181B5B990-0x0000000181B5BAB0
	public void Clear() {} // 0x0000000181B5B870-0x0000000181B5B8E0
	public SECTR_VOFinInfo GetObjInfoByName(int nameHash) => default; // 0x0000000181B5B8E0-0x0000000181B5B990
}

