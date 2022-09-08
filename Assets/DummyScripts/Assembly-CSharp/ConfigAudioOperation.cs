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
public class ConfigAudioOperation : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17605
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _operation; // 0x10

	// Properties
	public ConfigWwiseString operation { /* [XID] */ /* 0x00000001899949C0-0x00000001899949E0 */ get => default; /* [XID] */ /* 0x0000000189A8F510-0x0000000189A8F530 */ private set {} } // 0x0000000184099890-0x0000000184099930 0x0000000184099330-0x00000001840993E0

	// Constructors
	public ConfigAudioOperation() {} // 0x0000000184099BF0-0x0000000184099C50

	// Methods
	// [XID] // 0x0000000189A96A60-0x0000000189A96A80
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184099930-0x0000000184099A10
	// [XID] // 0x0000000189A9DE90-0x0000000189A9DEB0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001840995E0-0x00000001840996B0
	// [XID] // 0x0000000189AA5920-0x0000000189AA5940
	public virtual ConfigAudioOperation Clone(bool useObjectPool = false /* Metadata: 0x00AF7479 */) => default; // 0x0000000184099250-0x0000000184099330
	// [XID] // 0x0000000189AACF60-0x0000000189AACF80
	public virtual int GetHashNum() => default; // 0x0000000184098520-0x00000001840985F0
	// [XID] // 0x0000000189AB48F0-0x0000000189AB4910
	public virtual void InitEmpty() {} // 0x0000000184098D90-0x0000000184098E60
	[BlackList] // 0x0000000189ABC620-0x0000000189ABC660
	// [XID] // 0x0000000189ABC620-0x0000000189ABC660
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000184098840-0x0000000184098BC0
	// [XID] // 0x0000000189AC6CE0-0x0000000189AC6D00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184097E90-0x0000000184098090
	[BlackList] // 0x0000000189ACE4D0-0x0000000189ACE510
	// [XID] // 0x0000000189ACE4D0-0x0000000189ACE510
	public static ConfigAudioOperation ParseFromJson(JSONNode node) => default; // 0x00000001840993E0-0x00000001840995E0
	// [XID] // 0x0000000189AD9270-0x0000000189AD9290
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF747A */, bool useObjectPool = false /* Metadata: 0x00AF747E */) => default; // 0x0000000184098F50-0x0000000184099250
	// [XID] // 0x0000000189AE0D60-0x0000000189AE0D80
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF747F */, bool useObjectPool = false /* Metadata: 0x00AF7483 */) => default; // 0x00000001840985F0-0x0000000184098840
	// [XID] // 0x0000000189AE8210-0x0000000189AE8230
	public static ConfigAudioOperation ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7484 */, bool useObjectPool = false /* Metadata: 0x00AF7488 */) => default; // 0x0000000184098BC0-0x0000000184098D90
	[BlackList] // 0x0000000189AF0090-0x0000000189AF00D0
	// [XID] // 0x0000000189AF0090-0x0000000189AF00D0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000184098090-0x0000000184098360
	// [XID] // 0x0000000189AFA6C0-0x0000000189AFA6E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001840996B0-0x0000000184099890
	[BlackList] // 0x0000000189B01C50-0x0000000189B01C90
	// [XID] // 0x0000000189B01C50-0x0000000189B01C90
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184098E60-0x0000000184098F50
	[BlackList] // 0x0000000189B0C250-0x0000000189B0C290
	// [XID] // 0x0000000189B0C250-0x0000000189B0C290
	public virtual void AutoAllocTypeFields() {} // 0x0000000184098360-0x0000000184098400
	[BlackList] // 0x0000000189B16490-0x0000000189B164D0
	// [XID] // 0x0000000189B16490-0x0000000189B164D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184098400-0x0000000184098520
	[BlackList] // 0x0000000189B20B70-0x0000000189B20BB0
	// [XID] // 0x0000000189B20B70-0x0000000189B20BB0
	public virtual void ReturnToObjectPool() {} // 0x0000000184099B50-0x0000000184099BF0
	[BlackList] // 0x0000000189B2B140-0x0000000189B2B180
	// [XID] // 0x0000000189B2B140-0x0000000189B2B180
	public virtual void OnPoolAllocated() {} // 0x0000000184099AB0-0x0000000184099B50
	[BlackList] // 0x0000000189B35460-0x0000000189B354A0
	// [XID] // 0x0000000189B35460-0x0000000189B354A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184099A10-0x0000000184099AB0
}

