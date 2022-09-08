/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct AudioPlatformMoveSettings : IEmptyInitable, IHashable // TypeDefIndex: 17558
{
	// Fields
	private SimpleSafeUInt32 idRawNum; // 0x00
	private AudioPlatformMoveType _moveType; // 0x04
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _moveStartEvent; // 0x08
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _moveStopEvent; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _rotateStartEvent; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _rotateStopEvent; // 0x20
	private SimpleSafeFloat linearVelocityThresholdRawNum; // 0x28
	private SimpleSafeFloat angularVelocityThresholdRawNum; // 0x2C
	private static readonly AudioPlatformMoveSettings _empty; // 0x00

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A291A0-0x0000000189A291C0 */ get => default; /* [XID] */ /* 0x0000000189A30790-0x0000000189A307B0 */ private set {} } // 0x0000000183849430-0x00000001838494E0 0x00000001838481F0-0x0000000183848500
	public AudioPlatformMoveType moveType { /* [XID] */ /* 0x0000000189A38150-0x0000000189A38170 */ get => default; /* [XID] */ /* 0x0000000189A3F880-0x0000000189A3F8A0 */ private set {} } // 0x0000000183847C50-0x0000000183847D00 0x0000000183847BA0-0x0000000183847C50
	public ConfigWwiseString moveStartEvent { /* [XID] */ /* 0x0000000189A46F50-0x0000000189A46F70 */ get => default; /* [XID] */ /* 0x0000000189A4E870-0x0000000189A4E890 */ private set {} } // 0x0000000183847EB0-0x0000000183847F80 0x0000000183846AB0-0x0000000183846AC0
	public ConfigWwiseString moveStopEvent { /* [XID] */ /* 0x0000000189A55F80-0x0000000189A55FA0 */ get => default; /* [XID] */ /* 0x0000000189A5DA40-0x0000000189A5DA60 */ private set {} } // 0x00000001838494E0-0x00000001838494F0 0x0000000183846E60-0x0000000183847570
	public ConfigWwiseString rotateStartEvent { /* [XID] */ /* 0x0000000189A65140-0x0000000189A65160 */ get => default; /* [XID] */ /* 0x0000000189A6C900-0x0000000189A6C920 */ private set {} } // 0x0000000183847D00-0x0000000183847E00 0x00000001838486B0-0x0000000183848770
	public ConfigWwiseString rotateStopEvent { /* [XID] */ /* 0x0000000189A740F0-0x0000000189A74110 */ get => default; /* [XID] */ /* 0x0000000189A7BA80-0x0000000189A7BAA0 */ private set {} } // 0x0000000183847750-0x0000000183847AE0 0x0000000183848770-0x0000000183848860
	public float linearVelocityThreshold { /* [XID] */ /* 0x0000000189A83380-0x0000000189A833A0 */ get => default; /* [XID] */ /* 0x0000000189A8ACC0-0x0000000189A8ACE0 */ private set {} } // 0x00000001838485F0-0x00000001838486B0 0x0000000183848860-0x0000000183848AE0
	public float angularVelocityThreshold { /* [XID] */ /* 0x0000000189A923F0-0x0000000189A92410 */ get => default; /* [XID] */ /* 0x0000000189A99E20-0x0000000189A99E40 */ private set {} } // 0x00000001838469F0-0x0000000183846AB0 0x0000000183846CF0-0x0000000183846DA0
	public static AudioPlatformMoveSettings empty { /* [XID] */ /* 0x0000000189B00310-0x0000000189B00330 */ get => default; } // 0x0000000183846AC0-0x0000000183846CF0 

	// Constructors
	static AudioPlatformMoveSettings() {
		_empty = default;
	} // 0x00000001838494F0-0x0000000183849840

	// Methods
	// [IDTag] // 0x0000000189AA0DA0-0x0000000189AA0DE0
	// [XID] // 0x0000000189AA0DA0-0x0000000189AA0DE0
	public bool Equals(AudioPlatformMoveSettings otherVal) => default; // 0x0000000183848AE0-0x0000000183849140
	// [IDTag] // 0x0000000189AAB770-0x0000000189AAB7B0
	// [XID] // 0x0000000189AAB770-0x0000000189AAB7B0
	public override bool Equals(object other) => default; // 0x00000001838476A0-0x0000000183847750
	// [XID] // 0x0000000189AB6120-0x0000000189AB6140
	public override int GetHashCode() => default; // 0x0000000183847E00-0x0000000183847EB0
	// [XID] // 0x0000000189ABDAF0-0x0000000189ABDB10
	public void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183849350-0x0000000183849430
	// [XID] // 0x0000000189AC56D0-0x0000000189AC56F0
	public void InitEmpty() {} // 0x0000000183848110-0x00000001838481F0
	[BlackList] // 0x0000000189ACCB80-0x0000000189ACCBC0
	// [XID] // 0x0000000189ACCB80-0x0000000189ACCBC0
	public bool FromJson(JSONNode node) => default; // 0x0000000183847AE0-0x0000000183847BA0
	// [XID] // 0x0000000189AD79E0-0x0000000189AD7A00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183846620-0x0000000183846900
	// [XID] // 0x0000000189ADF450-0x0000000189ADF470
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF72DF */, bool useObjectPool = false /* Metadata: 0x00AF72E3 */) => default; // 0x0000000183848500-0x00000001838485F0
	// [XID] // 0x0000000189AE6C10-0x0000000189AE6C30
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF72E4 */, bool useObjectPool = false /* Metadata: 0x00AF72E8 */) => default; // 0x0000000183847570-0x00000001838476A0
	[BlackList] // 0x0000000189AEE740-0x0000000189AEE780
	// [XID] // 0x0000000189AEE740-0x0000000189AEE780
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183846900-0x00000001838469F0
	// [XID] // 0x0000000189AF8E50-0x0000000189AF8E70
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183849140-0x0000000183849350
}

