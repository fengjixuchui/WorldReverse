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
public class ConfigGuideSetOpenStateAction : ConfigGuideAction, IAutoAllocRecycle // TypeDefIndex: 18315
{
	// Fields
	private GuideOpenStateType _openState; // 0x18
	private bool _value; // 0x1C

	// Properties
	public GuideOpenStateType openState { /* [XID] */ /* 0x00000001898CD320-0x00000001898CD340 */ get => default; /* [XID] */ /* 0x00000001898D4BF0-0x00000001898D4C10 */ private set {} } // 0x0000000184855930-0x00000001848559D0 0x0000000184857150-0x0000000184857200
	public bool value { /* [XID] */ /* 0x00000001898DC610-0x00000001898DC630 */ get => default; /* [XID] */ /* 0x00000001898E4080-0x00000001898E40A0 */ private set {} } // 0x0000000184856020-0x00000001848560C0 0x0000000184855EF0-0x0000000184855FA0

	// Constructors
	public ConfigGuideSetOpenStateAction() {} // 0x00000001848576C0-0x0000000184857720

	// Methods
	// [XID] // 0x00000001898EBBF0-0x00000001898EBC10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184857510-0x0000000184857620
	// [XID] // 0x00000001898F3340-0x00000001898F3360
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001848570A0-0x0000000184857150
	// [XID] // 0x00000001898FA940-0x00000001898FA960
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF93EB */) => default; // 0x0000000184856CB0-0x0000000184856D90
	// [XID] // 0x0000000189902540-0x0000000189902560
	public override int GetHashNum() => default; // 0x0000000184855860-0x0000000184855930
	// [XID] // 0x0000000189909B00-0x0000000189909B20
	public override void InitEmpty() {} // 0x00000001848566D0-0x0000000184856770
	[BlackList] // 0x00000001899112A0-0x00000001899112E0
	// [XID] // 0x00000001899112A0-0x00000001899112E0
	public override bool FromJson(JSONNode node) => default; // 0x00000001848560C0-0x0000000184856440
	// [XID] // 0x000000018991C020-0x000000018991C040
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184855040-0x0000000184855320
	[BlackList] // 0x00000001899236E0-0x0000000189923720
	// [XID] // 0x00000001899236E0-0x0000000189923720
	public static new ConfigGuideSetOpenStateAction ParseFromJson(JSONNode node) => default; // 0x0000000184856DF0-0x0000000184857040
	// [XID] // 0x000000018992DD90-0x000000018992DDB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF93EC */, bool useObjectPool = false /* Metadata: 0x00AF93F0 */) => default; // 0x00000001848569B0-0x0000000184856CB0
	// [XID] // 0x0000000189935190-0x00000001899351B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF93F1 */, bool useObjectPool = false /* Metadata: 0x00AF93F5 */) => default; // 0x0000000184855BD0-0x0000000184855E70
	// [XID] // 0x000000018993CD10-0x000000018993CD30
	public static new ConfigGuideSetOpenStateAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF93F6 */, bool useObjectPool = false /* Metadata: 0x00AF93FA */) => default; // 0x0000000184856440-0x0000000184856660
	[BlackList] // 0x00000001899443A0-0x00000001899443E0
	// [XID] // 0x00000001899443A0-0x00000001899443E0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184855320-0x00000001848555F0
	// [XID] // 0x000000018994E940-0x000000018994E960
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184857280-0x0000000184857510
	[BlackList] // 0x0000000189955F80-0x0000000189955FC0
	// [XID] // 0x0000000189955F80-0x0000000189955FC0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001848568C0-0x00000001848569B0
	// [XID] // 0x0000000189960880-0x00000001899608A0
	protected override bool Start(ConfigGuideTask taskBelonged) => default; // 0x0000000184855AB0-0x0000000184855BD0
	// [XID] // 0x00000001899680A0-0x00000001899680C0
	protected override bool Stop() => default; // 0x0000000184854FA0-0x0000000184855040
	[BlackList] // 0x000000018996F4A0-0x000000018996F4E0
	// [XID] // 0x000000018996F4A0-0x000000018996F4E0
	public override void AutoAllocTypeFields() {} // 0x00000001848555F0-0x0000000184855690
	[BlackList] // 0x000000018997A290-0x000000018997A2D0
	// [XID] // 0x000000018997A290-0x000000018997A2D0
	public override void AutoRecycleTypeFields() {} // 0x0000000184855690-0x0000000184855740
	[BlackList] // 0x00000001899847D0-0x0000000189984810
	// [XID] // 0x00000001899847D0-0x0000000189984810
	public override void ReturnToObjectPool() {} // 0x0000000184857620-0x00000001848576C0
}

