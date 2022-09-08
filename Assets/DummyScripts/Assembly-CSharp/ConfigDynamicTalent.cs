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
public class ConfigDynamicTalent : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17917
{
	// Fields
	private string _talentName; // 0x10

	// Properties
	public string talentName { /* [XID] */ /* 0x00000001897C7F10-0x00000001897C7F30 */ get => default; /* [XID] */ /* 0x00000001897CF2B0-0x00000001897CF2D0 */ private set {} } // 0x00000001815C3330-0x00000001815C33D0 0x00000001815C3280-0x00000001815C3330

	// Constructors
	public ConfigDynamicTalent() {} // 0x00000001815C3840-0x00000001815C38A0

	// Methods
	// [XID] // 0x00000001897D6B40-0x00000001897D6B60
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001815C3580-0x00000001815C3660
	// [XID] // 0x00000001897DE250-0x00000001897DE270
	public void InitEmpty() {} // 0x00000001815C2EB0-0x00000001815C2F80
	[BlackList] // 0x00000001897E5CF0-0x00000001897E5D30
	// [XID] // 0x00000001897E5CF0-0x00000001897E5D30
	public bool FromJson(JSONNode node) => default; // 0x00000001815C2B30-0x00000001815C2EB0
	// [XID] // 0x00000001897F0880-0x00000001897F08A0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001815C2330-0x00000001815C2510
	// [XID] // 0x00000001897F8000-0x00000001897F8020
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF81EB */, bool useObjectPool = false /* Metadata: 0x00AF81EF */) => default; // 0x00000001815C2F80-0x00000001815C3280
	// [XID] // 0x00000001897FF750-0x00000001897FF770
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF81F0 */, bool useObjectPool = false /* Metadata: 0x00AF81F4 */) => default; // 0x00000001815C2920-0x00000001815C2B30
	[BlackList] // 0x0000000189806EB0-0x0000000189806EF0
	// [XID] // 0x0000000189806EB0-0x0000000189806EF0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001815C2510-0x00000001815C27E0
	// [XID] // 0x00000001898113E0-0x0000000189811400
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001815C33D0-0x00000001815C3580
	[BlackList] // 0x0000000189818EB0-0x0000000189818EF0
	// [XID] // 0x0000000189818EB0-0x0000000189818EF0
	public virtual void AutoAllocTypeFields() {} // 0x00000001815C27E0-0x00000001815C2880
	[BlackList] // 0x00000001898231D0-0x0000000189823210
	// [XID] // 0x00000001898231D0-0x0000000189823210
	public virtual void AutoRecycleTypeFields() {} // 0x00000001815C2880-0x00000001815C2920
	[BlackList] // 0x000000018982D880-0x000000018982D8C0
	// [XID] // 0x000000018982D880-0x000000018982D8C0
	public virtual void ReturnToObjectPool() {} // 0x00000001815C37A0-0x00000001815C3840
	[BlackList] // 0x0000000189837E60-0x0000000189837EA0
	// [XID] // 0x0000000189837E60-0x0000000189837EA0
	public virtual void OnPoolAllocated() {} // 0x00000001815C3700-0x00000001815C37A0
	[BlackList] // 0x0000000189842640-0x0000000189842680
	// [XID] // 0x0000000189842640-0x0000000189842680
	public virtual void OnBeforePoolRecycled() {} // 0x00000001815C3660-0x00000001815C3700
}

