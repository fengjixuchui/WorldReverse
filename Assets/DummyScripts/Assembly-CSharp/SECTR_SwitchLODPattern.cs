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
public class SECTR_SwitchLODPattern // TypeDefIndex: 31955
{
	// Fields
	public string patternName; // 0x10
	public List<SECTR_LODPattern> multiPatterns; // 0x18
	private Dictionary<int, SECTR_LODPattern> _name2Pattern; // 0x20

	// Constructors
	public SECTR_SwitchLODPattern() {} // 0x0000000181B5AE00-0x0000000181B5AEB0

	// Methods
	public void InitSwitchPattern() {} // 0x0000000181B5ACB0-0x0000000181B5AE00
	public SECTR_LODPattern GetLODPattern(int nameHash) => default; // 0x0000000181B5AC00-0x0000000181B5ACB0
}

