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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class MechanicusCardExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16221
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected SimpleSafeUInt32 costPointsRawNum; // 0x14
	protected MechanicusCardType _cardType; // 0x18
	protected SimpleSafeUInt32 effectIDRawNum; // 0x1C
	protected SimpleSafeUInt32 lastRoundRawNum; // 0x20
	protected uint _descTextMapHash; // 0x24
	protected string[] _descParamList; // 0x28
	protected SimpleSafeUInt32 gear_idRawNum; // 0x30

	// Properties
	public uint ID { /* [XID] */ /* 0x0000000189638D90-0x0000000189638DB0 */ get => default; /* [XID] */ /* 0x00000001896401F0-0x0000000189640210 */ protected set {} } // 0x00000001847256B0-0x0000000184725780 0x0000000184724320-0x0000000184724400
	public uint costPoints { /* [XID] */ /* 0x0000000189647A30-0x0000000189647A50 */ get => default; /* [XID] */ /* 0x000000018964F0C0-0x000000018964F0E0 */ protected set {} } // 0x0000000184724250-0x0000000184724320 0x00000001847247F0-0x00000001847248D0
	public MechanicusCardType cardType { /* [XID] */ /* 0x0000000189656A70-0x0000000189656A90 */ get => default; /* [XID] */ /* 0x000000018965E0D0-0x000000018965E0F0 */ protected set {} } // 0x0000000184726630-0x00000001847266D0 0x00000001847259E0-0x0000000184725A90
	public uint effectID { /* [XID] */ /* 0x00000001896657B0-0x00000001896657D0 */ get => default; /* [XID] */ /* 0x000000018966CF20-0x000000018966CF40 */ protected set {} } // 0x0000000184726480-0x0000000184726550 0x0000000184725520-0x0000000184725600
	public uint lastRound { /* [XID] */ /* 0x0000000189674D90-0x0000000189674DB0 */ get => default; /* [XID] */ /* 0x000000018967C5E0-0x000000018967C600 */ protected set {} } // 0x0000000184724670-0x0000000184724740 0x0000000184725780-0x0000000184725860
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189683C90-0x0000000189683CB0 */ get => default; /* [XID] */ /* 0x000000018968B910-0x000000018968B930 */ protected set {} } // 0x00000001847261D0-0x0000000184726270 0x0000000184724740-0x00000001847247F0
	public string desc { /* [XID] */ /* 0x00000001896934A0-0x00000001896934C0 */ get => default; } // 0x0000000184725860-0x00000001847259E0 
	public string[] descParamList { /* [XID] */ /* 0x000000018969A7D0-0x000000018969A7F0 */ get => default; /* [XID] */ /* 0x00000001896A21E0-0x00000001896A2200 */ protected set {} } // 0x0000000184724400-0x00000001847244A0 0x0000000184725600-0x00000001847256B0
	public uint gear_id { /* [XID] */ /* 0x00000001896A9420-0x00000001896A9440 */ get => default; /* [XID] */ /* 0x00000001896B0550-0x00000001896B0570 */ protected set {} } // 0x0000000184726270-0x0000000184726340 0x0000000184726550-0x0000000184726630

	// Constructors
	public MechanicusCardExcelConfig() {} // 0x0000000184726770-0x00000001847267D0

	// Methods
	// [IDTag] // 0x00000001896B7F70-0x00000001896B7FB0
	// [XID] // 0x00000001896B7F70-0x00000001896B7FB0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184724EE0-0x0000000184725520
	// [IDTag] // 0x00000001896C1F80-0x00000001896C1FC0
	// [XID] // 0x00000001896C1F80-0x00000001896C1FC0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001847248D0-0x0000000184724EE0
	// [XID] // 0x00000001896CC6D0-0x00000001896CC6F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF34B4 */, bool useObjectPool = false /* Metadata: 0x00AF34B8 */) => default; // 0x0000000184725A90-0x00000001847261D0
	[BlackList] // 0x00000001896D3960-0x00000001896D39A0
	// [XID] // 0x00000001896D3960-0x00000001896D39A0
	public virtual void AutoAllocTypeFields() {} // 0x00000001847244A0-0x0000000184724540
	[BlackList] // 0x00000001896DE2E0-0x00000001896DE320
	// [XID] // 0x00000001896DE2E0-0x00000001896DE320
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184724540-0x0000000184724670
	[BlackList] // 0x00000001896E86C0-0x00000001896E8700
	// [XID] // 0x00000001896E86C0-0x00000001896E8700
	public virtual void ReturnToObjectPool() {} // 0x00000001847266D0-0x0000000184726770
	[BlackList] // 0x00000001896F2C10-0x00000001896F2C50
	// [XID] // 0x00000001896F2C10-0x00000001896F2C50
	public virtual void OnPoolAllocated() {} // 0x00000001847263E0-0x0000000184726480
	[BlackList] // 0x00000001896FD6F0-0x00000001896FD730
	// [XID] // 0x00000001896FD6F0-0x00000001896FD730
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184726340-0x00000001847263E0
}

