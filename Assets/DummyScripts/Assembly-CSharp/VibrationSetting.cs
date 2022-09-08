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
public class VibrationSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17626
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _rtpc; // 0x10
	private SimpleSafeFloat openValueRawNum; // 0x18
	private SimpleSafeFloat closeValueRawNum; // 0x1C

	// Properties
	public ConfigWwiseString rtpc { /* [XID] */ /* 0x00000001898F3500-0x00000001898F3520 */ get => default; /* [XID] */ /* 0x00000001898FAAC0-0x00000001898FAAE0 */ private set {} } // 0x000000018486E990-0x000000018486EA30 0x000000018486DD30-0x000000018486DDE0
	public float openValue { /* [XID] */ /* 0x0000000189902680-0x00000001899026A0 */ get => default; /* [XID] */ /* 0x0000000189909C60-0x0000000189909C80 */ private set {} } // 0x000000018486DA40-0x000000018486DB20 0x000000018486EB10-0x000000018486EBF0
	public float closeValue { /* [XID] */ /* 0x0000000189ABB8D0-0x0000000189ABB8F0 */ get => default; /* [XID] */ /* 0x0000000189919080-0x00000001899190A0 */ private set {} } // 0x000000018486EA30-0x000000018486EB10 0x000000018486E8B0-0x000000018486E990

	// Constructors
	public VibrationSetting() {} // 0x000000018486F200-0x000000018486F2B0

	// Methods
	// [XID] // 0x0000000189920610-0x0000000189920630
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018486EEE0-0x000000018486F020
	// [XID] // 0x0000000189927F70-0x0000000189927F90
	public void InitEmpty() {} // 0x000000018486E490-0x000000018486E5B0
	[BlackList] // 0x000000018992F5E0-0x000000018992F620
	// [XID] // 0x000000018992F5E0-0x000000018992F620
	public bool FromJson(JSONNode node) => default; // 0x000000018486E110-0x000000018486E490
	// [XID] // 0x0000000189939F90-0x0000000189939FB0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018486D360-0x000000018486D770
	// [XID] // 0x0000000189941160-0x0000000189941180
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF753B */, bool useObjectPool = false /* Metadata: 0x00AF753F */) => default; // 0x000000018486E5B0-0x000000018486E8B0
	// [XID] // 0x0000000189948C40-0x0000000189948C60
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7540 */, bool useObjectPool = false /* Metadata: 0x00AF7544 */) => default; // 0x000000018486DDE0-0x000000018486E110
	[BlackList] // 0x00000001899503F0-0x0000000189950430
	// [XID] // 0x00000001899503F0-0x0000000189950430
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018486D770-0x000000018486DA40
	// [XID] // 0x000000018995A9D0-0x000000018995A9F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018486EBF0-0x000000018486EEE0
	[BlackList] // 0x0000000189962510-0x0000000189962550
	// [XID] // 0x0000000189962510-0x0000000189962550
	public virtual void AutoAllocTypeFields() {} // 0x000000018486DB20-0x000000018486DBC0
	[BlackList] // 0x000000018996C890-0x000000018996C8D0
	// [XID] // 0x000000018996C890-0x000000018996C8D0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018486DBC0-0x000000018486DD30
	[BlackList] // 0x0000000189977220-0x0000000189977260
	// [XID] // 0x0000000189977220-0x0000000189977260
	public virtual void ReturnToObjectPool() {} // 0x000000018486F160-0x000000018486F200
	[BlackList] // 0x0000000189981BA0-0x0000000189981BE0
	// [XID] // 0x0000000189981BA0-0x0000000189981BE0
	public virtual void OnPoolAllocated() {} // 0x000000018486F0C0-0x000000018486F160
	[BlackList] // 0x000000018998C290-0x000000018998C2D0
	// [XID] // 0x000000018998C290-0x000000018998C2D0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018486F020-0x000000018486F0C0
}

