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
public class ConfigWidgetAction_TakePhoto : ConfigWidgetAction, IAutoAllocRecycle // TypeDefIndex: 19175
{
	// Fields
	private bool _hasCameraEffect; // 0x10
	private string _cameraScreenEffect; // 0x18
	private string _mainCameraEffect; // 0x20

	// Properties
	public bool hasCameraEffect { /* [XID] */ /* 0x0000000189BAAD40-0x0000000189BAAD60 */ get => default; /* [XID] */ /* 0x0000000189BB2310-0x0000000189BB2330 */ private set {} } // 0x00000001840C49F0-0x00000001840C4A90 0x00000001840C4060-0x00000001840C4110
	public string cameraScreenEffect { /* [XID] */ /* 0x0000000189BB97A0-0x0000000189BB97C0 */ get => default; /* [XID] */ /* 0x0000000189BC1640-0x0000000189BC1660 */ private set {} } // 0x00000001840C5690-0x00000001840C5730 0x00000001840C5730-0x00000001840C57E0
	public string mainCameraEffect { /* [XID] */ /* 0x0000000189BC8D00-0x0000000189BC8D20 */ get => default; /* [XID] */ /* 0x0000000189BD0510-0x0000000189BD0530 */ private set {} } // 0x00000001840C4D20-0x00000001840C4DC0 0x00000001840C4FC0-0x00000001840C5070

	// Constructors
	public ConfigWidgetAction_TakePhoto() {} // 0x00000001840C60D0-0x00000001840C6130

	// Methods
	// [XID] // 0x0000000189BD7A50-0x0000000189BD7A70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001840C5F00-0x00000001840C6030
	// [XID] // 0x0000000189BDF680-0x0000000189BDF6A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001840C5AF0-0x00000001840C5BF0
	// [XID] // 0x00000001895EC130-0x00000001895EC150
	public override ConfigWidgetAction Clone(bool useObjectPool = false /* Metadata: 0x00AFC447 */) => default; // 0x00000001840C55B0-0x00000001840C5690
	// [XID] // 0x00000001895F35F0-0x00000001895F3610
	public override int GetHashNum() => default; // 0x00000001840C3F90-0x00000001840C4060
	// [XID] // 0x00000001895FAEF0-0x00000001895FAF10
	public override void InitEmpty() {} // 0x00000001840C4E50-0x00000001840C4F40
	[BlackList] // 0x0000000189602730-0x0000000189602770
	// [XID] // 0x0000000189602730-0x0000000189602770
	public override bool FromJson(JSONNode node) => default; // 0x00000001840C4670-0x00000001840C49F0
	// [XID] // 0x000000018960CEE0-0x000000018960CF00
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001840C3690-0x00000001840C3A50
	[BlackList] // 0x0000000189614540-0x0000000189614580
	// [XID] // 0x0000000189614540-0x0000000189614580
	public static new ConfigWidgetAction_TakePhoto ParseFromJson(JSONNode node) => default; // 0x00000001840C5840-0x00000001840C5A90
	// [XID] // 0x000000018961EFC0-0x000000018961EFE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC448 */, bool useObjectPool = false /* Metadata: 0x00AFC44C */) => default; // 0x00000001840C51C0-0x00000001840C54C0
	// [XID] // 0x00000001896263C0-0x00000001896263E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC44D */, bool useObjectPool = false /* Metadata: 0x00AFC451 */) => default; // 0x00000001840C41F0-0x00000001840C4570
	// [XID] // 0x000000018962DD50-0x000000018962DD70
	public static new ConfigWidgetAction_TakePhoto ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC452 */, bool useObjectPool = false /* Metadata: 0x00AFC456 */) => default; // 0x00000001840C4A90-0x00000001840C4CB0
	[BlackList] // 0x0000000189635970-0x00000001896359B0
	// [XID] // 0x0000000189635970-0x00000001896359B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001840C3A50-0x00000001840C3D20
	// [XID] // 0x000000018963FD50-0x000000018963FD70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001840C5BF0-0x00000001840C5F00
	[BlackList] // 0x0000000189647610-0x0000000189647650
	// [XID] // 0x0000000189647610-0x0000000189647650
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001840C50D0-0x00000001840C51C0
	[BlackList] // 0x0000000189651CE0-0x0000000189651D20
	// [XID] // 0x0000000189651CE0-0x0000000189651D20
	public override void AutoAllocTypeFields() {} // 0x00000001840C3D20-0x00000001840C3DC0
	[BlackList] // 0x000000018965C520-0x000000018965C560
	// [XID] // 0x000000018965C520-0x000000018965C560
	public override void AutoRecycleTypeFields() {} // 0x00000001840C3DC0-0x00000001840C3E70
	[BlackList] // 0x0000000189666C10-0x0000000189666C50
	// [XID] // 0x0000000189666C10-0x0000000189666C50
	public override void ReturnToObjectPool() {} // 0x00000001840C6030-0x00000001840C60D0
	// [XID] // 0x0000000189671AC0-0x0000000189671AE0
	public override void DoAction(LCWidget lcWidget, QuickWidgetGeneral widget) {} // 0x00000001840C54C0-0x00000001840C55B0
}

