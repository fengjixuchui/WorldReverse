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
public class ConfigAvatarHitBucketSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18101
{
	// Fields
	private SimpleSafeInt32 meleeBucketCountRawNum; // 0x10
	private SimpleSafeFloat meleeBucketCDRawNum; // 0x14
	private SimpleSafeInt32 rangedBucketCountRawNum; // 0x18
	private SimpleSafeFloat rangedBucketCDRawNum; // 0x1C

	// Properties
	public int meleeBucketCount { /* [XID] */ /* 0x000000018990A670-0x000000018990A690 */ get => default; /* [XID] */ /* 0x00000001899CBBA0-0x00000001899CBBC0 */ private set {} } // 0x000000018461C2B0-0x000000018461C380 0x000000018461BCC0-0x000000018461BDA0
	public float meleeBucketCD { /* [XID] */ /* 0x00000001899D2FD0-0x00000001899D2FF0 */ get => default; /* [XID] */ /* 0x00000001899DA5C0-0x00000001899DA5E0 */ private set {} } // 0x000000018461BBE0-0x000000018461BCC0 0x000000018461B780-0x000000018461B860
	public int rangedBucketCount { /* [XID] */ /* 0x00000001899E2060-0x00000001899E2080 */ get => default; /* [XID] */ /* 0x00000001899E9520-0x00000001899E9540 */ private set {} } // 0x000000018461C380-0x000000018461C450 0x000000018461C1D0-0x000000018461C2B0
	public float rangedBucketCD { /* [XID] */ /* 0x0000000189912010-0x0000000189912030 */ get => default; /* [XID] */ /* 0x00000001899F8450-0x00000001899F8470 */ private set {} } // 0x000000018461C800-0x000000018461C8E0 0x000000018461B350-0x000000018461B430

	// Constructors
	public ConfigAvatarHitBucketSetting() {} // 0x000000018461CC00-0x000000018461CCF0

	// Methods
	// [XID] // 0x00000001899FFA60-0x00000001899FFA80
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018461C8E0-0x000000018461CA20
	// [XID] // 0x0000000189A072B0-0x0000000189A072D0
	public void InitEmpty() {} // 0x000000018461BDA0-0x000000018461BED0
	[BlackList] // 0x0000000189A0E810-0x0000000189A0E850
	// [XID] // 0x0000000189A0E810-0x0000000189A0E850
	public bool FromJson(JSONNode node) => default; // 0x000000018461B860-0x000000018461BBE0
	// [XID] // 0x0000000189A18D70-0x0000000189A18D90
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018461A9C0-0x000000018461AEB0
	// [XID] // 0x0000000189A20450-0x0000000189A20470
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B09 */, bool useObjectPool = false /* Metadata: 0x00AF8B0D */) => default; // 0x000000018461BED0-0x000000018461C1D0
	// [XID] // 0x0000000189A27840-0x0000000189A27860
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B0E */, bool useObjectPool = false /* Metadata: 0x00AF8B12 */) => default; // 0x000000018461B430-0x000000018461B780
	[BlackList] // 0x0000000189A2EF70-0x0000000189A2EFB0
	// [XID] // 0x0000000189A2EF70-0x0000000189A2EFB0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018461AEB0-0x000000018461B180
	// [XID] // 0x0000000189A39810-0x0000000189A39830
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018461C450-0x000000018461C800
	[BlackList] // 0x0000000189A41050-0x0000000189A41090
	// [XID] // 0x0000000189A41050-0x0000000189A41090
	public virtual void AutoAllocTypeFields() {} // 0x000000018461B180-0x000000018461B220
	[BlackList] // 0x0000000189A4B540-0x0000000189A4B580
	// [XID] // 0x0000000189A4B540-0x0000000189A4B580
	public virtual void AutoRecycleTypeFields() {} // 0x000000018461B220-0x000000018461B350
	[BlackList] // 0x0000000189A55DE0-0x0000000189A55E20
	// [XID] // 0x0000000189A55DE0-0x0000000189A55E20
	public virtual void ReturnToObjectPool() {} // 0x000000018461CB60-0x000000018461CC00
	[BlackList] // 0x0000000189A60660-0x0000000189A606A0
	// [XID] // 0x0000000189A60660-0x0000000189A606A0
	public virtual void OnPoolAllocated() {} // 0x000000018461CAC0-0x000000018461CB60
	[BlackList] // 0x0000000189A6B130-0x0000000189A6B170
	// [XID] // 0x0000000189A6B130-0x0000000189A6B170
	public virtual void OnBeforePoolRecycled() {} // 0x000000018461CA20-0x000000018461CAC0
}

