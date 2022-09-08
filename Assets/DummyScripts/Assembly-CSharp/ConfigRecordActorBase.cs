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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigRecordActorBase : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18880
{
	// Fields
	private MoleMole.Config.Vector _pos; // 0x10
	private MoleMole.Config.Vector _rot; // 0x1C
	private MoleMole.Config.Vector _scale; // 0x28
	private SimpleSafeUInt32 serialIDRawNum; // 0x34

	// Properties
	public MoleMole.Config.Vector pos { /* [XID] */ /* 0x00000001896D1FC0-0x00000001896D1FE0 */ get => default; /* [XID] */ /* 0x00000001896D9830-0x00000001896D9850 */ private set {} } // 0x0000000184D49AC0-0x0000000184D49BA0 0x0000000184D49290-0x0000000184D49360
	public MoleMole.Config.Vector rot { /* [XID] */ /* 0x00000001896E0F50-0x00000001896E0F70 */ get => default; /* [XID] */ /* 0x00000001896E81C0-0x00000001896E81E0 */ private set {} } // 0x0000000184D48610-0x0000000184D486F0 0x0000000184D491C0-0x0000000184D49290
	public MoleMole.Config.Vector scale { /* [XID] */ /* 0x00000001896EF8A0-0x00000001896EF8C0 */ get => default; /* [XID] */ /* 0x00000001896F7190-0x00000001896F71B0 */ private set {} } // 0x0000000184D49D70-0x0000000184D49E50 0x0000000184D4AF10-0x0000000184D4AFE0
	public uint serialID { /* [XID] */ /* 0x00000001896FEB50-0x00000001896FEB70 */ get => default; /* [XID] */ /* 0x0000000189705DE0-0x0000000189705E00 */ private set {} } // 0x0000000184D48BA0-0x0000000184D48C70 0x0000000184D49F80-0x0000000184D4A060

	// Constructors
	public ConfigRecordActorBase() {} // 0x0000000184D4B080-0x0000000184D4B0E0

	// Methods
	// [XID] // 0x000000018970D710-0x000000018970D730
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184D4AC40-0x0000000184D4ADD0
	// [XID] // 0x0000000189714BD0-0x0000000189714BF0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184D4A730-0x0000000184D4A7E0
	// [XID] // 0x000000018971C560-0x000000018971C580
	public virtual ConfigRecordActorBase Clone(bool useObjectPool = false /* Metadata: 0x00AFB241 */) => default; // 0x0000000184D4A450-0x0000000184D4A530
	// [XID] // 0x0000000189723A70-0x0000000189723A90
	public virtual int GetHashNum() => default; // 0x0000000184D490F0-0x0000000184D491C0
	// [XID] // 0x000000018972B1B0-0x000000018972B1D0
	public virtual void InitEmpty() {} // 0x0000000184D49E50-0x0000000184D49F80
	[BlackList] // 0x0000000189732920-0x0000000189732960
	// [XID] // 0x0000000189732920-0x0000000189732960
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000184D49740-0x0000000184D49AC0
	// [XID] // 0x000000018973D3D0-0x000000018973D3F0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184D486F0-0x0000000184D48BA0
	[BlackList] // 0x00000001897448B0-0x00000001897448F0
	// [XID] // 0x00000001897448B0-0x00000001897448F0
	public static ConfigRecordActorBase ParseFromJson(JSONNode node) => default; // 0x0000000184D4A530-0x0000000184D4A730
	// [XID] // 0x000000018974F310-0x000000018974F330
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB242 */, bool useObjectPool = false /* Metadata: 0x00AFB246 */) => default; // 0x0000000184D4A150-0x0000000184D4A450
	// [XID] // 0x00000001897569C0-0x00000001897569E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB247 */, bool useObjectPool = false /* Metadata: 0x00AFB24B */) => default; // 0x0000000184D49360-0x0000000184D49740
	// [XID] // 0x000000018975DE50-0x000000018975DE70
	public static ConfigRecordActorBase ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB24C */, bool useObjectPool = false /* Metadata: 0x00AFB250 */) => default; // 0x0000000184D49BA0-0x0000000184D49D70
	[BlackList] // 0x0000000189765450-0x0000000189765490
	// [XID] // 0x0000000189765450-0x0000000189765490
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000184D48C70-0x0000000184D48F40
	// [XID] // 0x000000018976FC70-0x000000018976FC90
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184D4A7E0-0x0000000184D4AC40
	[BlackList] // 0x0000000189777450-0x0000000189777490
	// [XID] // 0x0000000189777450-0x0000000189777490
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184D4A060-0x0000000184D4A150
	[BlackList] // 0x0000000189781F80-0x0000000189781FC0
	// [XID] // 0x0000000189781F80-0x0000000189781FC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184D48F40-0x0000000184D48FE0
	[BlackList] // 0x000000018978C2D0-0x000000018978C310
	// [XID] // 0x000000018978C2D0-0x000000018978C310
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184D48FE0-0x0000000184D490F0
	[BlackList] // 0x0000000189796970-0x00000001897969B0
	// [XID] // 0x0000000189796970-0x00000001897969B0
	public virtual void ReturnToObjectPool() {} // 0x0000000184D4AFE0-0x0000000184D4B080
	[BlackList] // 0x00000001897A15E0-0x00000001897A1620
	// [XID] // 0x00000001897A15E0-0x00000001897A1620
	public virtual void OnPoolAllocated() {} // 0x0000000184D4AE70-0x0000000184D4AF10
	[BlackList] // 0x00000001897ABD40-0x00000001897ABD80
	// [XID] // 0x00000001897ABD40-0x00000001897ABD80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184D4ADD0-0x0000000184D4AE70
}

