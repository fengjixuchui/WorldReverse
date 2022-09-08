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
public class ConfigItanoCircusBulletMove : ConfigBulletMove, IAutoAllocRecycle // TypeDefIndex: 18624
{
	// Fields
	private SimpleSafeFloat itanoCircusStartAnglerRawNum; // 0x58
	private bool _destroyWhenTargetDie; // 0x5C
	private SimpleSafeFloat guidanceDelayRawNum; // 0x60
	private bool _guidanceSpeedChange; // 0x64
	private SimpleSafeFloat guidanceMinAnglerVelocityRawNum; // 0x68
	private SimpleSafeFloat guidanceDurationRawNum; // 0x6C

	// Properties
	public float itanoCircusStartAngler { /* [XID] */ /* 0x0000000189BD3490-0x0000000189BD34B0 */ get => default; /* [XID] */ /* 0x0000000189BDAD80-0x0000000189BDADA0 */ private set {} } // 0x00000001849C1810-0x00000001849C18F0 0x00000001849C1070-0x00000001849C1150
	public bool destroyWhenTargetDie { /* [XID] */ /* 0x0000000189808E50-0x0000000189808E70 */ get => default; /* [XID] */ /* 0x00000001895EF0A0-0x00000001895EF0C0 */ private set {} } // 0x00000001849C0700-0x00000001849C07A0 0x00000001849C0900-0x00000001849C09B0
	public float guidanceDelay { /* [XID] */ /* 0x000000018981F730-0x000000018981F750 */ get => default; /* [XID] */ /* 0x00000001895FDE80-0x00000001895FDEA0 */ private set {} } // 0x00000001849C04C0-0x00000001849C05A0 0x00000001849C05A0-0x00000001849C0680
	public bool guidanceSpeedChange { /* [XID] */ /* 0x0000000189817E60-0x0000000189817E80 */ get => default; /* [XID] */ /* 0x000000018960D060-0x000000018960D080 */ private set {} } // 0x00000001849C1E70-0x00000001849C1F10 0x00000001849C0D30-0x00000001849C0DE0
	public float guidanceMinAnglerVelocity { /* [XID] */ /* 0x0000000189826D50-0x0000000189826D70 */ get => default; /* [XID] */ /* 0x000000018961BF90-0x000000018961BFB0 */ private set {} } // 0x00000001849C07A0-0x00000001849C0880 0x00000001849C1950-0x00000001849C1A30
	public float guidanceDuration { /* [XID] */ /* 0x000000018982E400-0x000000018982E420 */ get => default; /* [XID] */ /* 0x000000018962ADA0-0x000000018962ADC0 */ private set {} } // 0x00000001849C1C80-0x00000001849C1D60 0x00000001849BF790-0x00000001849BF870

	// Constructors
	public ConfigItanoCircusBulletMove() {} // 0x00000001849C25E0-0x00000001849C2690

	// Methods
	// [XID] // 0x00000001896324C0-0x00000001896324E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001849C23C0-0x00000001849C2540
	// [XID] // 0x0000000189639F70-0x0000000189639F90
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001849C1DC0-0x00000001849C1E70
	// [XID] // 0x00000001896414E0-0x0000000189641500
	public override ConfigMove Clone(bool useObjectPool = false /* Metadata: 0x00AFA625 */) => default; // 0x00000001849C1730-0x00000001849C1810
	// [XID] // 0x0000000189648E80-0x0000000189648EA0
	public override int GetHashNum() => default; // 0x00000001849BFE20-0x00000001849BFEF0
	// [XID] // 0x00000001896504B0-0x00000001896504D0
	public override void InitEmpty() {} // 0x00000001849C1150-0x00000001849C1260
	[BlackList] // 0x0000000189657DD0-0x0000000189657E10
	// [XID] // 0x0000000189657DD0-0x0000000189657E10
	public override bool FromJson(JSONNode node) => default; // 0x00000001849C09B0-0x00000001849C0D30
	// [XID] // 0x0000000189662320-0x0000000189662340
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001849BF080-0x00000001849BF790
	[BlackList] // 0x0000000189669F00-0x0000000189669F40
	// [XID] // 0x0000000189669F00-0x0000000189669F40
	public static new ConfigItanoCircusBulletMove ParseFromJson(JSONNode node) => default; // 0x00000001849C1A30-0x00000001849C1C80
	// [XID] // 0x00000001896748F0-0x0000000189674910
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA626 */, bool useObjectPool = false /* Metadata: 0x00AFA62A */) => default; // 0x00000001849C1430-0x00000001849C1730
	// [XID] // 0x000000018967C280-0x000000018967C2A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA62B */, bool useObjectPool = false /* Metadata: 0x00AFA62F */) => default; // 0x00000001849BFFD0-0x00000001849C04C0
	// [XID] // 0x0000000189683890-0x00000001896838B0
	public static new ConfigItanoCircusBulletMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA630 */, bool useObjectPool = false /* Metadata: 0x00AFA634 */) => default; // 0x00000001849C0DE0-0x00000001849C1000
	[BlackList] // 0x000000018968B550-0x000000018968B590
	// [XID] // 0x000000018968B550-0x000000018968B590
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001849BF870-0x00000001849BFB40
	// [XID] // 0x00000001896960F0-0x0000000189696110
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001849C1F10-0x00000001849C23C0
	[BlackList] // 0x000000018969D7D0-0x000000018969D810
	// [XID] // 0x000000018969D7D0-0x000000018969D810
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001849C1340-0x00000001849C1430
	[BlackList] // 0x00000001896A7820-0x00000001896A7860
	// [XID] // 0x00000001896A7820-0x00000001896A7860
	public override void AutoAllocTypeFields() {} // 0x00000001849BFB40-0x00000001849BFBE0
	[BlackList] // 0x00000001896B16B0-0x00000001896B16F0
	// [XID] // 0x00000001896B16B0-0x00000001896B16F0
	public override void AutoRecycleTypeFields() {} // 0x00000001849BFBE0-0x00000001849BFD00
	[BlackList] // 0x00000001896BBEC0-0x00000001896BBF00
	// [XID] // 0x00000001896BBEC0-0x00000001896BBF00
	public override void ReturnToObjectPool() {} // 0x00000001849C2540-0x00000001849C25E0
}

