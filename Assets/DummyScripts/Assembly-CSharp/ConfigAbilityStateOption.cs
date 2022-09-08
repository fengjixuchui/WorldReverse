/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigAbilityStateOption : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16847
{
	// Constructors
	public ConfigAbilityStateOption() {} // 0x0000000182CA5D10-0x0000000182CA5D70

	// Methods
	// [XID] // 0x0000000189882F90-0x0000000189882FB0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182CA5960-0x0000000182CA5A10
	// [XID] // 0x000000018988A7B0-0x000000018988A7D0
	public void InitEmpty() {} // 0x0000000182CA5510-0x0000000182CA55B0
	[BlackList] // 0x0000000189891C20-0x0000000189891C60
	// [XID] // 0x0000000189891C20-0x0000000189891C60
	public bool FromJson(JSONNode node) => default; // 0x0000000182CA5190-0x0000000182CA5510
	// [XID] // 0x0000000189A4C1E0-0x0000000189A4C200
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182CA4AA0-0x0000000182CA4B50
	// [XID] // 0x00000001898A38A0-0x00000001898A38C0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4870 */, bool useObjectPool = false /* Metadata: 0x00AF4874 */) => default; // 0x0000000182CA55B0-0x0000000182CA58B0
	// [XID] // 0x00000001898AACC0-0x00000001898AACE0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4875 */, bool useObjectPool = false /* Metadata: 0x00AF4879 */) => default; // 0x0000000182CA4F60-0x0000000182CA5040
	[BlackList] // 0x00000001898B2590-0x00000001898B25D0
	// [XID] // 0x00000001898B2590-0x00000001898B25D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182CA4B50-0x0000000182CA4E20
	// [XID] // 0x00000001898BD0A0-0x00000001898BD0C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182CA58B0-0x0000000182CA5960
	// [XID] // 0x00000001898C4860-0x00000001898C4880
	public virtual AbilityState GetMatchingAbilityState() => default; // 0x0000000182CA50F0-0x0000000182CA5190
	// [XID] // 0x00000001898CBDF0-0x00000001898CBE10
	public virtual void ChangeModifierConfig(ConfigAbilityModifier modifier) {} // 0x0000000182CA5040-0x0000000182CA50F0
	// [XID] // 0x00000001898D3670-0x00000001898D3690
	protected static void DirtyCheckModifierProperties(ConfigAbilityModifier modifier) {} // 0x0000000182CA5B50-0x0000000182CA5C70
	[BlackList] // 0x00000001898DAE20-0x00000001898DAE60
	// [XID] // 0x00000001898DAE20-0x00000001898DAE60
	public virtual void AutoAllocTypeFields() {} // 0x0000000182CA4E20-0x0000000182CA4EC0
	[BlackList] // 0x00000001898E5D20-0x00000001898E5D60
	// [XID] // 0x00000001898E5D20-0x00000001898E5D60
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182CA4EC0-0x0000000182CA4F60
	[BlackList] // 0x00000001898F0640-0x00000001898F0680
	// [XID] // 0x00000001898F0640-0x00000001898F0680
	public virtual void ReturnToObjectPool() {} // 0x0000000182CA5C70-0x0000000182CA5D10
	[BlackList] // 0x00000001898FAC60-0x00000001898FACA0
	// [XID] // 0x00000001898FAC60-0x00000001898FACA0
	public virtual void OnPoolAllocated() {} // 0x0000000182CA5AB0-0x0000000182CA5B50
	[BlackList] // 0x0000000189905740-0x0000000189905780
	// [XID] // 0x0000000189905740-0x0000000189905780
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182CA5A10-0x0000000182CA5AB0
}

