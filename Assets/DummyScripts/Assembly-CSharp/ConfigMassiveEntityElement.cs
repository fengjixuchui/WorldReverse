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
public class ConfigMassiveEntityElement : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17377
{
	// Fields
	private EntityType _entityType; // 0x10
	private ElementType _elementType; // 0x14
	private SimpleSafeFloat elementDurabilityRawNum; // 0x18
	private bool _isElementDurabilityMutable; // 0x1C

	// Properties
	public EntityType entityType { /* [XID] */ /* 0x0000000189B90990-0x0000000189B909B0 */ get => default; /* [XID] */ /* 0x0000000189B97DA0-0x0000000189B97DC0 */ private set {} } // 0x00000001814CD220-0x00000001814CD2C0 0x00000001814CCCA0-0x00000001814CCD50
	public ElementType elementType { /* [XID] */ /* 0x0000000189B9F190-0x0000000189B9F1B0 */ get => default; /* [XID] */ /* 0x0000000189BA6A00-0x0000000189BA6A20 */ private set {} } // 0x00000001814CD180-0x00000001814CD220 0x00000001814CDBD0-0x00000001814CDC80
	public float elementDurability { /* [XID] */ /* 0x0000000189BADC40-0x0000000189BADC60 */ get => default; /* [XID] */ /* 0x0000000189BB53F0-0x0000000189BB5410 */ private set {} } // 0x00000001814CDAF0-0x00000001814CDBD0 0x00000001814CD640-0x00000001814CD720
	public bool isElementDurabilityMutable { /* [XID] */ /* 0x0000000189BBCB60-0x0000000189BBCB80 */ get => default; /* [XID] */ /* 0x0000000189BC47C0-0x0000000189BC47E0 */ private set {} } // 0x00000001814CDC80-0x00000001814CDD20 0x00000001814CD0D0-0x00000001814CD180

	// Constructors
	public ConfigMassiveEntityElement() {} // 0x00000001814CE390-0x00000001814CE400

	// Methods
	// [XID] // 0x0000000189BCC140-0x0000000189BCC160
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001814CE070-0x00000001814CE1B0
	// [XID] // 0x0000000189BD3770-0x0000000189BD3790
	public void InitEmpty() {} // 0x00000001814CD720-0x00000001814CD7F0
	[BlackList] // 0x0000000189BDB0C0-0x0000000189BDB100
	// [XID] // 0x0000000189BDB0C0-0x0000000189BDB100
	public bool FromJson(JSONNode node) => default; // 0x00000001814CD2C0-0x00000001814CD640
	// [XID] // 0x00000001895EAD30-0x00000001895EAD50
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001814CC3B0-0x00000001814CC850
	// [XID] // 0x00000001895F21D0-0x00000001895F21F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C2F */, bool useObjectPool = false /* Metadata: 0x00AF6C33 */) => default; // 0x00000001814CD7F0-0x00000001814CDAF0
	// [XID] // 0x00000001895F9B40-0x00000001895F9B60
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C34 */, bool useObjectPool = false /* Metadata: 0x00AF6C38 */) => default; // 0x00000001814CCD50-0x00000001814CD0D0
	[BlackList] // 0x00000001896012A0-0x00000001896012E0
	// [XID] // 0x00000001896012A0-0x00000001896012E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001814CC850-0x00000001814CCB20
	// [XID] // 0x000000018960BBA0-0x000000018960BBC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001814CDD20-0x00000001814CE070
	[BlackList] // 0x0000000189613160-0x00000001896131A0
	// [XID] // 0x0000000189613160-0x00000001896131A0
	public virtual void AutoAllocTypeFields() {} // 0x00000001814CCB20-0x00000001814CCBC0
	[BlackList] // 0x000000018961D990-0x000000018961D9D0
	// [XID] // 0x000000018961D990-0x000000018961D9D0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001814CCBC0-0x00000001814CCCA0
	[BlackList] // 0x0000000189627F10-0x0000000189627F50
	// [XID] // 0x0000000189627F10-0x0000000189627F50
	public virtual void ReturnToObjectPool() {} // 0x00000001814CE2F0-0x00000001814CE390
	[BlackList] // 0x00000001896327A0-0x00000001896327E0
	// [XID] // 0x00000001896327A0-0x00000001896327E0
	public virtual void OnPoolAllocated() {} // 0x00000001814CE250-0x00000001814CE2F0
	[BlackList] // 0x000000018963D3D0-0x000000018963D410
	// [XID] // 0x000000018963D3D0-0x000000018963D410
	public virtual void OnBeforePoolRecycled() {} // 0x00000001814CE1B0-0x00000001814CE250
}

