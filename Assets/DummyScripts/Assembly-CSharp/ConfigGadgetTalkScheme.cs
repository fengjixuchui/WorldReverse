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
public class ConfigGadgetTalkScheme : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18815
{
	// Fields
	private uint _configId; // 0x10
	private uint _groupId; // 0x14
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigTalkScheme[] _talks; // 0x18

	// Properties
	public uint configId { /* [XID] */ /* 0x0000000189B9A9E0-0x0000000189B9AA00 */ get => default; /* [XID] */ /* 0x0000000189BA2190-0x0000000189BA21B0 */ private set {} } // 0x0000000181C9D810-0x0000000181C9D8B0 0x0000000181C9DC80-0x0000000181C9DD30
	public uint groupId { /* [XID] */ /* 0x0000000189BA95C0-0x0000000189BA95E0 */ get => default; /* [XID] */ /* 0x0000000189BB0DD0-0x0000000189BB0DF0 */ private set {} } // 0x0000000181C9DD30-0x0000000181C9DDD0 0x0000000181C9DDD0-0x0000000181C9DE80
	public ConfigTalkScheme[] talks { /* [XID] */ /* 0x0000000189BB7F60-0x0000000189BB7F80 */ get => default; /* [XID] */ /* 0x0000000189BBF6F0-0x0000000189BBF710 */ private set {} } // 0x0000000181C9D770-0x0000000181C9D810 0x0000000181C9E170-0x0000000181C9E220

	// Constructors
	public ConfigGadgetTalkScheme() {} // 0x0000000181C9E520-0x0000000181C9E580

	// Methods
	// [XID] // 0x0000000189BC7300-0x0000000189BC7320
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181C9E220-0x0000000181C9E340
	// [XID] // 0x0000000189BCF010-0x0000000189BCF030
	public void InitEmpty() {} // 0x0000000181C9D8B0-0x0000000181C9D980
	[BlackList] // 0x0000000189BD63C0-0x0000000189BD6400
	// [XID] // 0x0000000189BD63C0-0x0000000189BD6400
	public bool FromJson(JSONNode node) => default; // 0x0000000181C9D3F0-0x0000000181C9D770
	// [XID] // 0x00000001895E6050-0x00000001895E6070
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181C9C970-0x0000000181C9CCD0
	// [XID] // 0x00000001895ED9B0-0x00000001895ED9D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFADA7 */, bool useObjectPool = false /* Metadata: 0x00AFADAB */) => default; // 0x0000000181C9D980-0x0000000181C9DC80
	// [XID] // 0x00000001895F5130-0x00000001895F5150
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFADAC */, bool useObjectPool = false /* Metadata: 0x00AFADB0 */) => default; // 0x0000000181C9D0F0-0x0000000181C9D3F0
	[BlackList] // 0x00000001895FC730-0x00000001895FC770
	// [XID] // 0x00000001895FC730-0x00000001895FC770
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181C9CCD0-0x0000000181C9CFA0
	// [XID] // 0x0000000189606EC0-0x0000000189606EE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181C9DE80-0x0000000181C9E170
	[BlackList] // 0x000000018960E840-0x000000018960E880
	// [XID] // 0x000000018960E840-0x000000018960E880
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C9CFA0-0x0000000181C9D040
	[BlackList] // 0x00000001896191A0-0x00000001896191E0
	// [XID] // 0x00000001896191A0-0x00000001896191E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C9D040-0x0000000181C9D0F0
	[BlackList] // 0x00000001896234E0-0x0000000189623520
	// [XID] // 0x00000001896234E0-0x0000000189623520
	public virtual void ReturnToObjectPool() {} // 0x0000000181C9E480-0x0000000181C9E520
	[BlackList] // 0x000000018962DDD0-0x000000018962DE10
	// [XID] // 0x000000018962DDD0-0x000000018962DE10
	public virtual void OnPoolAllocated() {} // 0x0000000181C9E3E0-0x0000000181C9E480
	[BlackList] // 0x00000001896389B0-0x00000001896389F0
	// [XID] // 0x00000001896389B0-0x00000001896389F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C9E340-0x0000000181C9E3E0
}

