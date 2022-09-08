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
public class ConfigAIScriptedMoveToData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17475
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private bool _is3D; // 0x14
	private bool _stopByObstacle; // 0x15

	// Properties
	public int speedLevel { /* [XID] */ /* 0x0000000189BBF970-0x0000000189BBF990 */ get => default; /* [XID] */ /* 0x0000000189BC75C0-0x0000000189BC75E0 */ set {} } // 0x0000000182C5B250-0x0000000182C5B320 0x0000000182C5B3C0-0x0000000182C5B4A0
	public bool is3D { /* [XID] */ /* 0x0000000189BCF2D0-0x0000000189BCF2F0 */ get => default; /* [XID] */ /* 0x0000000189BD6560-0x0000000189BD6580 */ private set {} } // 0x0000000182C5C540-0x0000000182C5C5E0 0x0000000182C5BF70-0x0000000182C5C020
	public bool stopByObstacle { /* [XID] */ /* 0x0000000189BDE1E0-0x0000000189BDE200 */ get => default; /* [XID] */ /* 0x0000000189A70310-0x0000000189A70330 */ set {} } // 0x0000000182C5B320-0x0000000182C5B3C0 0x0000000182C5BEC0-0x0000000182C5BF70

	// Constructors
	public ConfigAIScriptedMoveToData() {} // 0x0000000182C5C680-0x0000000182C5C720

	// Methods
	// [XID] // 0x00000001895F21B0-0x00000001895F21D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C5C310-0x0000000182C5C400
	// [XID] // 0x00000001895F9B00-0x00000001895F9B20
	public void InitEmpty() {} // 0x0000000182C5BAF0-0x0000000182C5BBC0
	[BlackList] // 0x0000000189601220-0x0000000189601260
	// [XID] // 0x0000000189601220-0x0000000189601260
	public bool FromJson(JSONNode node) => default; // 0x0000000182C5B770-0x0000000182C5BAF0
	// [XID] // 0x000000018960BB00-0x000000018960BB20
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182C5AAB0-0x0000000182C5AE10
	// [XID] // 0x0000000189613100-0x0000000189613120
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FE3 */, bool useObjectPool = false /* Metadata: 0x00AF6FE7 */) => default; // 0x0000000182C5BBC0-0x0000000182C5BEC0
	// [XID] // 0x000000018961A920-0x000000018961A940
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FE8 */, bool useObjectPool = false /* Metadata: 0x00AF6FEC */) => default; // 0x0000000182C5B4A0-0x0000000182C5B770
	[BlackList] // 0x0000000189621F60-0x0000000189621FA0
	// [XID] // 0x0000000189621F60-0x0000000189621FA0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C5AE10-0x0000000182C5B0E0
	// [XID] // 0x000000018962C590-0x000000018962C5B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C5C020-0x0000000182C5C310
	[BlackList] // 0x00000001896341D0-0x0000000189634210
	// [XID] // 0x00000001896341D0-0x0000000189634210
	public virtual void AutoAllocTypeFields() {} // 0x0000000182C5B0E0-0x0000000182C5B180
	[BlackList] // 0x000000018963E8A0-0x000000018963E8E0
	// [XID] // 0x000000018963E8A0-0x000000018963E8E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182C5B180-0x0000000182C5B250
	[BlackList] // 0x0000000189649180-0x00000001896491C0
	// [XID] // 0x0000000189649180-0x00000001896491C0
	public virtual void ReturnToObjectPool() {} // 0x0000000182C5C5E0-0x0000000182C5C680
	[BlackList] // 0x00000001896537A0-0x00000001896537E0
	// [XID] // 0x00000001896537A0-0x00000001896537E0
	public virtual void OnPoolAllocated() {} // 0x0000000182C5C4A0-0x0000000182C5C540
	[BlackList] // 0x000000018965DDF0-0x000000018965DE30
	// [XID] // 0x000000018965DDF0-0x000000018965DE30
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182C5C400-0x0000000182C5C4A0
}

