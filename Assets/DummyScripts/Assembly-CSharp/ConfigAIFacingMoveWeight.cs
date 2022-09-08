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
public class ConfigAIFacingMoveWeight : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17444
{
	// Fields
	private SimpleSafeFloat stopRawNum; // 0x10
	private SimpleSafeFloat forwardRawNum; // 0x14
	private SimpleSafeFloat backRawNum; // 0x18
	private SimpleSafeFloat leftRawNum; // 0x1C
	private SimpleSafeFloat rightRawNum; // 0x20

	// Properties
	public float stop { /* [XID] */ /* 0x0000000189BD3750-0x0000000189BD3770 */ get => default; /* [XID] */ /* 0x0000000189BDB0A0-0x0000000189BDB0C0 */ private set {} } // 0x000000018569BB10-0x000000018569BBF0 0x000000018569B750-0x000000018569B830
	public float forward { /* [XID] */ /* 0x00000001895E79F0-0x00000001895E7A10 */ get => default; /* [XID] */ /* 0x00000001895EF320-0x00000001895EF340 */ private set {} } // 0x000000018569B210-0x000000018569B2F0 0x000000018569BFD0-0x000000018569C0B0
	public float back { /* [XID] */ /* 0x00000001895F6D40-0x00000001895F6D60 */ get => default; /* [XID] */ /* 0x00000001895FE100-0x00000001895FE120 */ private set {} } // 0x000000018569BEF0-0x000000018569BFD0 0x000000018569B2F0-0x000000018569B3D0
	public float left { /* [XID] */ /* 0x0000000189605930-0x0000000189605950 */ get => default; /* [XID] */ /* 0x000000018960D260-0x000000018960D280 */ private set {} } // 0x000000018569BA30-0x000000018569BB10 0x000000018569C490-0x000000018569C570
	public float right { /* [XID] */ /* 0x0000000189614980-0x00000001896149A0 */ get => default; /* [XID] */ /* 0x000000018961C2E0-0x000000018961C300 */ private set {} } // 0x000000018569B130-0x000000018569B210 0x000000018569B830-0x000000018569B910

	// Constructors
	public ConfigAIFacingMoveWeight() {} // 0x000000018569C8B0-0x000000018569C990

	// Methods
	// [XID] // 0x00000001896236E0-0x0000000189623700
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018569C570-0x000000018569C6D0
	// [XID] // 0x000000018962B040-0x000000018962B060
	public void InitEmpty() {} // 0x000000018569B910-0x000000018569BA30
	[BlackList] // 0x0000000189632740-0x0000000189632780
	// [XID] // 0x0000000189632740-0x0000000189632780
	public bool FromJson(JSONNode node) => default; // 0x000000018569B3D0-0x000000018569B750
	// [XID] // 0x000000018963D370-0x000000018963D390
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018569A2C0-0x000000018569A8D0
	// [XID] // 0x00000001896448B0-0x00000001896448D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6ED5 */, bool useObjectPool = false /* Metadata: 0x00AF6ED9 */) => default; // 0x000000018569BBF0-0x000000018569BEF0
	// [XID] // 0x000000018964C110-0x000000018964C130
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EDA */, bool useObjectPool = false /* Metadata: 0x00AF6EDE */) => default; // 0x000000018569AD60-0x000000018569B130
	[BlackList] // 0x00000001896537E0-0x0000000189653820
	// [XID] // 0x00000001896537E0-0x0000000189653820
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018569A8D0-0x000000018569ABA0
	// [XID] // 0x000000018965DE30-0x000000018965DE50
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018569C0B0-0x000000018569C490
	[BlackList] // 0x00000001896655D0-0x0000000189665610
	// [XID] // 0x00000001896655D0-0x0000000189665610
	public virtual void AutoAllocTypeFields() {} // 0x000000018569ABA0-0x000000018569AC40
	[BlackList] // 0x0000000189670390-0x00000001896703D0
	// [XID] // 0x0000000189670390-0x00000001896703D0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018569AC40-0x000000018569AD60
	[BlackList] // 0x000000018967A9E0-0x000000018967AA20
	// [XID] // 0x000000018967A9E0-0x000000018967AA20
	public virtual void ReturnToObjectPool() {} // 0x000000018569C810-0x000000018569C8B0
	[BlackList] // 0x0000000189685260-0x00000001896852A0
	// [XID] // 0x0000000189685260-0x00000001896852A0
	public virtual void OnPoolAllocated() {} // 0x000000018569C770-0x000000018569C810
	[BlackList] // 0x00000001896900A0-0x00000001896900E0
	// [XID] // 0x00000001896900A0-0x00000001896900E0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018569C6D0-0x000000018569C770
}

