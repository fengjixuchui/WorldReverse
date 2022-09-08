/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using FullSerializer;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[fsObject] // 0x0000000189A8C180-0x0000000189A8C1D0
public class ConfigOverrideGroup // TypeDefIndex: 19467
{
	// Fields
	public object Default; // 0x10
	[InspectorNullable] // 0x0000000189A98270-0x0000000189A98280
	public Dictionary<string, object> Overrides; // 0x18
	[NonSerialized]
	public int Hash; // 0x20

	// Constructors
	public ConfigOverrideGroup() {} // 0x00000001823EB860-0x00000001823EB8D0

	// Methods
	public T GetConfig<T>(string name) => default;
	// [IDTag] // 0x0000000189A9F5B0-0x0000000189A9F5F0
	// [XID] // 0x0000000189A9F5B0-0x0000000189A9F5F0
	public void CalcHash() {} // 0x00000001823EB5D0-0x00000001823EB670
	// [IDTag] // 0x0000000189AA9A60-0x0000000189AA9AA0
	// [XID] // 0x0000000189AA9A60-0x0000000189AA9AA0
	public void CalcHash(ref int hash) {} // 0x00000001823EB670-0x00000001823EB720
	// [XID] // 0x0000000189AB4670-0x0000000189AB4690
	public bool ValidateHash() => default; // 0x00000001823EB720-0x00000001823EB860
}

