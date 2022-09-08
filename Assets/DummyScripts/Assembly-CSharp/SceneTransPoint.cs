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
public class SceneTransPoint : ConfigScenePoint, IAutoAllocRecycle // TypeDefIndex: 14975
{
	// Fields
	private SimpleSafeUInt32 maxSpringVolumeRawNum; // 0x60
	private SimpleSafeUInt32[] _cutsceneList; // 0x68
	private SimpleSafeUInt32 npcIdRawNum; // 0x70

	// Properties
	public override RealScenePointType pointType { /* [XID] */ /* 0x0000000189B40500-0x0000000189B40520 */ get => default; } // 0x0000000181BAE1A0-0x0000000181BAE270 
	public uint maxSpringVolume { /* [XID] */ /* 0x0000000189B47E60-0x0000000189B47E80 */ get => default; /* [XID] */ /* 0x0000000189B4F5D0-0x0000000189B4F5F0 */ private set {} } // 0x0000000181BAE7B0-0x0000000181BAE880 0x0000000181BAE520-0x0000000181BAE600
	public SimpleSafeUInt32[] cutsceneList { /* [XID] */ /* 0x0000000189B56EF0-0x0000000189B56F10 */ get => default; /* [XID] */ /* 0x0000000189B5E860-0x0000000189B5E880 */ private set {} } // 0x0000000181BAC8B0-0x0000000181BAC950 0x0000000181BAD940-0x0000000181BAD9F0
	public uint npcId { /* [XID] */ /* 0x0000000189B65DE0-0x0000000189B65E00 */ get => default; /* [XID] */ /* 0x0000000189B6D340-0x0000000189B6D360 */ private set {} } // 0x0000000181BAD1E0-0x0000000181BAD2B0 0x0000000181BADFE0-0x0000000181BAE0C0

	// Constructors
	public SceneTransPoint() {} // 0x0000000181BAEDF0-0x0000000181BAEE50

	// Methods
	// [XID] // 0x0000000189B74AB0-0x0000000189B74AD0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181BAEC20-0x0000000181BAED50
	// [XID] // 0x0000000189B7C0F0-0x0000000189B7C110
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181BAE660-0x0000000181BAE740
	// [XID] // 0x0000000189B83AC0-0x0000000189B83AE0
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AEFD18 */) => default; // 0x0000000181BAE0C0-0x0000000181BAE1A0
	// [XID] // 0x0000000189B8AC50-0x0000000189B8AC70
	public override int GetHashNum() => default; // 0x0000000181BACC00-0x0000000181BACCD0
	// [XID] // 0x0000000189B922E0-0x0000000189B92300
	public override void InitEmpty() {} // 0x0000000181BAD9F0-0x0000000181BADB10
	[BlackList] // 0x0000000189B99860-0x0000000189B998A0
	// [XID] // 0x0000000189B99860-0x0000000189B998A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181BAD330-0x0000000181BAD6B0
	// [XID] // 0x0000000189BA3EF0-0x0000000189BA3F10
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181BAC180-0x0000000181BAC5E0
	[BlackList] // 0x0000000189BAB480-0x0000000189BAB4C0
	// [XID] // 0x0000000189BAB480-0x0000000189BAB4C0
	public static new SceneTransPoint ParseFromJson(JSONNode node) => default; // 0x0000000181BAE2D0-0x0000000181BAE520
	// [XID] // 0x0000000189BB58D0-0x0000000189BB58F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD19 */, bool useObjectPool = false /* Metadata: 0x00AEFD1D */) => default; // 0x0000000181BADCE0-0x0000000181BADFE0
	// [XID] // 0x0000000189BBD060-0x0000000189BBD080
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD1E */, bool useObjectPool = false /* Metadata: 0x00AEFD22 */) => default; // 0x0000000181BACDB0-0x0000000181BAD160
	// [XID] // 0x0000000189BC4C40-0x0000000189BC4C60
	public static new SceneTransPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD23 */, bool useObjectPool = false /* Metadata: 0x00AEFD27 */) => default; // 0x0000000181BAD6B0-0x0000000181BAD8D0
	[BlackList] // 0x0000000189BCC720-0x0000000189BCC760
	// [XID] // 0x0000000189BCC720-0x0000000189BCC760
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181BAC5E0-0x0000000181BAC8B0
	// [XID] // 0x0000000189BD68C0-0x0000000189BD68E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181BAE880-0x0000000181BAEC20
	[BlackList] // 0x0000000189BDE660-0x0000000189BDE6A0
	// [XID] // 0x0000000189BDE660-0x0000000189BDE6A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181BADBF0-0x0000000181BADCE0
	[BlackList] // 0x00000001895EE050-0x00000001895EE090
	// [XID] // 0x00000001895EE050-0x00000001895EE090
	public override void AutoAllocTypeFields() {} // 0x0000000181BAC950-0x0000000181BAC9F0
	[BlackList] // 0x00000001895F89D0-0x00000001895F8A10
	// [XID] // 0x00000001895F89D0-0x00000001895F8A10
	public override void AutoRecycleTypeFields() {} // 0x0000000181BAC9F0-0x0000000181BACAE0
	[BlackList] // 0x0000000189602EB0-0x0000000189602EF0
	// [XID] // 0x0000000189602EB0-0x0000000189602EF0
	public override void ReturnToObjectPool() {} // 0x0000000181BAED50-0x0000000181BAEDF0
}

