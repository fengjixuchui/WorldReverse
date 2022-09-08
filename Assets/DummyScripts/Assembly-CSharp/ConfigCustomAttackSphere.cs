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
public class ConfigCustomAttackSphere : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17943
{
	// Fields
	private SimpleSafeFloat customAttackSphere_RadiusRawNum; // 0x10

	// Properties
	public float customAttackSphere_Radius { /* [XID] */ /* 0x00000001896C27B0-0x00000001896C27D0 */ get => default; /* [XID] */ /* 0x000000018965AF90-0x000000018965AFB0 */ private set {} } // 0x00000001817FE890-0x00000001817FE970 0x00000001817FE3E0-0x00000001817FE4C0

	// Constructors
	public ConfigCustomAttackSphere() {} // 0x00000001817FEDF0-0x00000001817FEE90

	// Methods
	// [XID] // 0x0000000189662420-0x0000000189662440
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001817FEB20-0x00000001817FEC10
	// [XID] // 0x000000018966A040-0x000000018966A060
	public void InitEmpty() {} // 0x00000001817FE4C0-0x00000001817FE590
	[BlackList] // 0x0000000189671C80-0x0000000189671CC0
	// [XID] // 0x0000000189671C80-0x0000000189671CC0
	public bool FromJson(JSONNode node) => default; // 0x00000001817FE060-0x00000001817FE3E0
	// [XID] // 0x000000018967C320-0x000000018967C340
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001817FD840-0x00000001817FDA50
	// [XID] // 0x0000000189683970-0x0000000189683990
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF843B */, bool useObjectPool = false /* Metadata: 0x00AF843F */) => default; // 0x00000001817FE590-0x00000001817FE890
	// [XID] // 0x000000018968B6D0-0x000000018968B6F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8440 */, bool useObjectPool = false /* Metadata: 0x00AF8444 */) => default; // 0x00000001817FDE90-0x00000001817FE060
	[BlackList] // 0x0000000189693280-0x00000001896932C0
	// [XID] // 0x0000000189693280-0x00000001896932C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001817FDA50-0x00000001817FDD20
	// [XID] // 0x000000018969D8F0-0x000000018969D910
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001817FE970-0x00000001817FEB20
	[BlackList] // 0x00000001896A48C0-0x00000001896A4900
	// [XID] // 0x00000001896A48C0-0x00000001896A4900
	public virtual void AutoAllocTypeFields() {} // 0x00000001817FDD20-0x00000001817FDDC0
	[BlackList] // 0x00000001896AEDD0-0x00000001896AEE10
	// [XID] // 0x00000001896AEDD0-0x00000001896AEE10
	public virtual void AutoRecycleTypeFields() {} // 0x00000001817FDDC0-0x00000001817FDE90
	[BlackList] // 0x00000001896B9230-0x00000001896B9270
	// [XID] // 0x00000001896B9230-0x00000001896B9270
	public virtual void ReturnToObjectPool() {} // 0x00000001817FED50-0x00000001817FEDF0
	[BlackList] // 0x00000001896C3480-0x00000001896C34C0
	// [XID] // 0x00000001896C3480-0x00000001896C34C0
	public virtual void OnPoolAllocated() {} // 0x00000001817FECB0-0x00000001817FED50
	[BlackList] // 0x00000001896CDB90-0x00000001896CDBD0
	// [XID] // 0x00000001896CDB90-0x00000001896CDBD0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001817FEC10-0x00000001817FECB0
}

