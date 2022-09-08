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
public class ConfigExternalVoiceLookupItem : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18076
{
	// Fields
	private SimpleSafeUInt32 fileIDRawNum; // 0x10
	private AudioVoiceTrigger __gameTrigger; // 0x14
	private SimpleSafeUInt32 _gameTriggerArgsRawNum; // 0x18

	// Properties
	public uint fileID { /* [XID] */ /* 0x000000018976FDD0-0x000000018976FDF0 */ get => default; /* [XID] */ /* 0x0000000189777570-0x0000000189777590 */ private set {} } // 0x0000000183E4A8B0-0x0000000183E4A980 0x0000000183E4B0E0-0x0000000183E4B1C0
	public AudioVoiceTrigger _gameTrigger { /* [XID] */ /* 0x000000018977ECA0-0x000000018977ECC0 */ get => default; /* [XID] */ /* 0x00000001897865E0-0x0000000189786600 */ private set {} } // 0x0000000183E4B5A0-0x0000000183E4B640 0x0000000183E4ACB0-0x0000000183E4AD60
	public uint _gameTriggerArgs { /* [XID] */ /* 0x000000018978DC70-0x000000018978DC90 */ get => default; /* [XID] */ /* 0x0000000189795260-0x0000000189795280 */ private set {} } // 0x0000000183E4A7E0-0x0000000183E4A8B0 0x0000000183E4B640-0x0000000183E4B720

	// Constructors
	public ConfigExternalVoiceLookupItem() {} // 0x0000000183E4BD40-0x0000000183E4BE00

	// Methods
	// [XID] // 0x000000018979D630-0x000000018979D650
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183E4BA40-0x0000000183E4BB60
	// [XID] // 0x00000001897A4930-0x00000001897A4950
	public void InitEmpty() {} // 0x0000000183E4B1C0-0x0000000183E4B2A0
	[BlackList] // 0x00000001897ABF00-0x00000001897ABF40
	// [XID] // 0x00000001897ABF00-0x00000001897ABF40
	public bool FromJson(JSONNode node) => default; // 0x0000000183E4AD60-0x0000000183E4B0E0
	// [XID] // 0x00000001897B7050-0x00000001897B7070
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183E49F60-0x0000000183E4A380
	// [XID] // 0x00000001897BEEF0-0x00000001897BEF10
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A37 */, bool useObjectPool = false /* Metadata: 0x00AF8A3B */) => default; // 0x0000000183E4B2A0-0x0000000183E4B5A0
	// [XID] // 0x00000001897C6540-0x00000001897C6560
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A3C */, bool useObjectPool = false /* Metadata: 0x00AF8A40 */) => default; // 0x0000000183E4A980-0x0000000183E4ACB0
	[BlackList] // 0x00000001897CDD00-0x00000001897CDD40
	// [XID] // 0x00000001897CDD00-0x00000001897CDD40
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183E4A380-0x0000000183E4A650
	// [XID] // 0x00000001897D8950-0x00000001897D8970
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183E4B720-0x0000000183E4BA40
	[BlackList] // 0x00000001897DFAD0-0x00000001897DFB10
	// [XID] // 0x00000001897DFAD0-0x00000001897DFB10
	public virtual void AutoAllocTypeFields() {} // 0x0000000183E4A650-0x0000000183E4A6F0
	[BlackList] // 0x00000001897EA460-0x00000001897EA4A0
	// [XID] // 0x00000001897EA460-0x00000001897EA4A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183E4A6F0-0x0000000183E4A7E0
	[BlackList] // 0x00000001897F4E50-0x00000001897F4E90
	// [XID] // 0x00000001897F4E50-0x00000001897F4E90
	public virtual void ReturnToObjectPool() {} // 0x0000000183E4BCA0-0x0000000183E4BD40
	[BlackList] // 0x00000001897FF650-0x00000001897FF690
	// [XID] // 0x00000001897FF650-0x00000001897FF690
	public virtual void OnPoolAllocated() {} // 0x0000000183E4BC00-0x0000000183E4BCA0
	[BlackList] // 0x0000000189809BD0-0x0000000189809C10
	// [XID] // 0x0000000189809BD0-0x0000000189809C10
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183E4BB60-0x0000000183E4BC00
}

