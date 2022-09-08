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
public class TriggerToStates : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18066
{
	// Fields
	private string _trigger; // 0x10
	private SimpleSafeFloat playTimeRawNum; // 0x18
	private string[] _states; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private BowDrawTime[] _bowDrawTimes; // 0x28
	private string _floatID; // 0x30
	private SimpleSafeFloat floatValueRawNum; // 0x38

	// Properties
	public string trigger { /* [XID] */ /* 0x0000000189657F50-0x0000000189657F70 */ get => default; /* [XID] */ /* 0x000000018965F540-0x000000018965F560 */ private set {} } // 0x00000001848BD9D0-0x00000001848BDA70 0x00000001848BE040-0x00000001848BE0F0
	public float playTime { /* [XID] */ /* 0x0000000189666E30-0x0000000189666E50 */ get => default; /* [XID] */ /* 0x000000018966E5C0-0x000000018966E5E0 */ private set {} } // 0x00000001848BE0F0-0x00000001848BE1D0 0x00000001848BDA70-0x00000001848BDB50
	public string[] states { /* [XID] */ /* 0x0000000189676200-0x0000000189676220 */ get => default; /* [XID] */ /* 0x000000018967DAA0-0x000000018967DAC0 */ private set {} } // 0x00000001848BEAD0-0x00000001848BEB70 0x00000001848BDC90-0x00000001848BDD40
	public BowDrawTime[] bowDrawTimes { /* [XID] */ /* 0x00000001896850E0-0x0000000189685100 */ get => default; /* [XID] */ /* 0x000000018968CBE0-0x000000018968CC00 */ private set {} } // 0x00000001848BD500-0x00000001848BD5A0 0x00000001848BD450-0x00000001848BD500
	public string floatID { /* [XID] */ /* 0x0000000189694740-0x0000000189694760 */ get => default; /* [XID] */ /* 0x000000018969BD60-0x000000018969BD80 */ private set {} } // 0x00000001848BE6A0-0x00000001848BE740 0x00000001848BD5A0-0x00000001848BD650
	public float floatValue { /* [XID] */ /* 0x00000001896A3300-0x00000001896A3320 */ get => default; /* [XID] */ /* 0x00000001896AA770-0x00000001896AA790 */ private set {} } // 0x00000001848BD370-0x00000001848BD450 0x00000001848BE740-0x00000001848BE820

	// Constructors
	public TriggerToStates() {} // 0x00000001848BEC10-0x00000001848BECB0

	// Methods
	// [XID] // 0x00000001896B1850-0x00000001896B1870
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001848BE820-0x00000001848BE990
	// [XID] // 0x00000001896B91D0-0x00000001896B91F0
	public void InitEmpty() {} // 0x00000001848BDB50-0x00000001848BDC90
	[BlackList] // 0x00000001896C0600-0x00000001896C0640
	// [XID] // 0x00000001896C0600-0x00000001896C0640
	public bool FromJson(JSONNode node) => default; // 0x00000001848BD650-0x00000001848BD9D0
	// [XID] // 0x00000001896CA9B0-0x00000001896CA9D0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001848BC3A0-0x00000001848BCA20
	// [XID] // 0x00000001896D20E0-0x00000001896D2100
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF89C7 */, bool useObjectPool = false /* Metadata: 0x00AF89CB */) => default; // 0x00000001848BDD40-0x00000001848BE040
	// [XID] // 0x00000001896D99F0-0x00000001896D9A10
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF89CC */, bool useObjectPool = false /* Metadata: 0x00AF89D0 */) => default; // 0x00000001848BCE80-0x00000001848BD370
	[BlackList] // 0x00000001896E10D0-0x00000001896E1110
	// [XID] // 0x00000001896E10D0-0x00000001896E1110
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001848BCA20-0x00000001848BCCF0
	// [XID] // 0x00000001896EB4C0-0x00000001896EB4E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001848BE1D0-0x00000001848BE6A0
	[BlackList] // 0x00000001896F27D0-0x00000001896F2810
	// [XID] // 0x00000001896F27D0-0x00000001896F2810
	public virtual void AutoAllocTypeFields() {} // 0x00000001848BCCF0-0x00000001848BCD90
	[BlackList] // 0x00000001896FD2F0-0x00000001896FD330
	// [XID] // 0x00000001896FD2F0-0x00000001896FD330
	public virtual void AutoRecycleTypeFields() {} // 0x00000001848BCD90-0x00000001848BCE80
	[BlackList] // 0x0000000189707750-0x0000000189707790
	// [XID] // 0x0000000189707750-0x0000000189707790
	public virtual void ReturnToObjectPool() {} // 0x00000001848BEB70-0x00000001848BEC10
	[BlackList] // 0x0000000189712230-0x0000000189712270
	// [XID] // 0x0000000189712230-0x0000000189712270
	public virtual void OnPoolAllocated() {} // 0x00000001848BEA30-0x00000001848BEAD0
	[BlackList] // 0x000000018971C680-0x000000018971C6C0
	// [XID] // 0x000000018971C680-0x000000018971C6C0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001848BE990-0x00000001848BEA30
}

