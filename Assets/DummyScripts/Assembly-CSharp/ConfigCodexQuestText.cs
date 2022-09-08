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
public class ConfigCodexQuestText : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17661
{
	// Fields
	private SimpleSafeUInt32 textIdRawNum; // 0x10
	private CodexQuestTextType _textType; // 0x14

	// Properties
	public uint textId { /* [XID] */ /* 0x00000001899E9620-0x00000001899E9640 */ get => default; /* [XID] */ /* 0x00000001899F0C90-0x00000001899F0CB0 */ private set {} } // 0x0000000182AAB6E0-0x0000000182AAB7B0 0x0000000182AAAB70-0x0000000182AAAC50
	public CodexQuestTextType textType { /* [XID] */ /* 0x00000001899F8510-0x00000001899F8530 */ get => default; /* [XID] */ /* 0x00000001899FFB40-0x00000001899FFB60 */ private set {} } // 0x0000000182AAB7B0-0x0000000182AAB850 0x0000000182AAB330-0x0000000182AAB3E0

	// Constructors
	public ConfigCodexQuestText() {} // 0x0000000182AABDB0-0x0000000182AABE10

	// Methods
	// [XID] // 0x0000000189A07330-0x0000000189A07350
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182AABAC0-0x0000000182AABBD0
	// [XID] // 0x0000000189A0E8B0-0x0000000189A0E8D0
	public void InitEmpty() {} // 0x0000000182AAB260-0x0000000182AAB330
	[BlackList] // 0x0000000189A15FC0-0x0000000189A16000
	// [XID] // 0x0000000189A15FC0-0x0000000189A16000
	public bool FromJson(JSONNode node) => default; // 0x0000000182AAAEE0-0x0000000182AAB260
	// [XID] // 0x0000000189A204B0-0x0000000189A204D0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182AAA430-0x0000000182AAA730
	// [XID] // 0x0000000189A278E0-0x0000000189A27900
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF76B7 */, bool useObjectPool = false /* Metadata: 0x00AF76BB */) => default; // 0x0000000182AAB3E0-0x0000000182AAB6E0
	// [XID] // 0x0000000189A2F070-0x0000000189A2F090
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF76BC */, bool useObjectPool = false /* Metadata: 0x00AF76C0 */) => default; // 0x0000000182AAAC50-0x0000000182AAAEE0
	[BlackList] // 0x0000000189A36A10-0x0000000189A36A50
	// [XID] // 0x0000000189A36A10-0x0000000189A36A50
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182AAA730-0x0000000182AAAA00
	// [XID] // 0x0000000189A410D0-0x0000000189A410F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182AAB850-0x0000000182AABAC0
	[BlackList] // 0x0000000189A487B0-0x0000000189A487F0
	// [XID] // 0x0000000189A487B0-0x0000000189A487F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182AAAA00-0x0000000182AAAAA0
	[BlackList] // 0x0000000189A52D60-0x0000000189A52DA0
	// [XID] // 0x0000000189A52D60-0x0000000189A52DA0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182AAAAA0-0x0000000182AAAB70
	[BlackList] // 0x0000000189A5D9A0-0x0000000189A5D9E0
	// [XID] // 0x0000000189A5D9A0-0x0000000189A5D9E0
	public virtual void ReturnToObjectPool() {} // 0x0000000182AABD10-0x0000000182AABDB0
	[BlackList] // 0x0000000189A68530-0x0000000189A68570
	// [XID] // 0x0000000189A68530-0x0000000189A68570
	public virtual void OnPoolAllocated() {} // 0x0000000182AABC70-0x0000000182AABD10
	[BlackList] // 0x0000000189A72A20-0x0000000189A72A60
	// [XID] // 0x0000000189A72A20-0x0000000189A72A60
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182AABBD0-0x0000000182AABC70
}

