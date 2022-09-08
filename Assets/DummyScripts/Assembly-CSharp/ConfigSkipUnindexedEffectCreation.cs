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
public class ConfigSkipUnindexedEffectCreation : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17928
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigSkipUnindexedEffectCreationByDistance _skipUnindexedEffectCreationByDistance; // 0x10

	// Properties
	public ConfigSkipUnindexedEffectCreationByDistance skipUnindexedEffectCreationByDistance { /* [XID] */ /* 0x0000000189659FB0-0x0000000189659FD0 */ get => default; /* [XID] */ /* 0x00000001898B53D0-0x00000001898B53F0 */ private set {} } // 0x00000001837651F0-0x0000000183765290 0x00000001837662A0-0x0000000183766350

	// Constructors
	public ConfigSkipUnindexedEffectCreation() {} // 0x0000000183766610-0x0000000183766670

	// Methods
	// [XID] // 0x00000001898BCE00-0x00000001898BCE20
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183766350-0x0000000183766430
	// [XID] // 0x00000001898C45C0-0x00000001898C45E0
	public void InitEmpty() {} // 0x0000000183765CF0-0x0000000183765DC0
	[BlackList] // 0x00000001898CBBD0-0x00000001898CBC10
	// [XID] // 0x00000001898CBBD0-0x00000001898CBC10
	public bool FromJson(JSONNode node) => default; // 0x0000000183765970-0x0000000183765CF0
	// [XID] // 0x00000001898D65E0-0x00000001898D6600
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183764FF0-0x00000001837651F0
	// [XID] // 0x0000000189A82660-0x0000000189A82680
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8259 */, bool useObjectPool = false /* Metadata: 0x00AF825D */) => default; // 0x0000000183765DC0-0x00000001837660C0
	// [XID] // 0x00000001898E5A20-0x00000001898E5A40
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF825E */, bool useObjectPool = false /* Metadata: 0x00AF8262 */) => default; // 0x0000000183765720-0x0000000183765970
	[BlackList] // 0x00000001898ED420-0x00000001898ED460
	// [XID] // 0x00000001898ED420-0x00000001898ED460
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183765290-0x0000000183765560
	// [XID] // 0x00000001898F7DB0-0x00000001898F7DD0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837660C0-0x00000001837662A0
	[BlackList] // 0x00000001898FF430-0x00000001898FF470
	// [XID] // 0x00000001898FF430-0x00000001898FF470
	public virtual void AutoAllocTypeFields() {} // 0x0000000183765560-0x0000000183765600
	[BlackList] // 0x0000000189909BA0-0x0000000189909BE0
	// [XID] // 0x0000000189909BA0-0x0000000189909BE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183765600-0x0000000183765720
	[BlackList] // 0x00000001899145A0-0x00000001899145E0
	// [XID] // 0x00000001899145A0-0x00000001899145E0
	public virtual void ReturnToObjectPool() {} // 0x0000000183766570-0x0000000183766610
	[BlackList] // 0x000000018991EE40-0x000000018991EE80
	// [XID] // 0x000000018991EE40-0x000000018991EE80
	public virtual void OnPoolAllocated() {} // 0x00000001837664D0-0x0000000183766570
	[BlackList] // 0x00000001899298C0-0x0000000189929900
	// [XID] // 0x00000001899298C0-0x0000000189929900
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183766430-0x00000001837664D0
}

