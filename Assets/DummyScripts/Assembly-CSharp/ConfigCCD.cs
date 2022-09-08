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
public class ConfigCCD : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18088
{
	// Fields
	private CCDType _type; // 0x10
	private SimpleSafeFloat detectCDRawNum; // 0x14

	// Properties
	public CCDType type { /* [XID] */ /* 0x000000018963D1F0-0x000000018963D210 */ get => default; /* [XID] */ /* 0x0000000189644710-0x0000000189644730 */ private set {} } // 0x0000000182D70580-0x0000000182D70620 0x0000000182D70040-0x0000000182D700F0
	public float detectCD { /* [XID] */ /* 0x000000018964C030-0x000000018964C050 */ get => default; /* [XID] */ /* 0x0000000189653620-0x0000000189653640 */ private set {} } // 0x0000000182D6F0A0-0x0000000182D6F180 0x0000000182D6FB90-0x0000000182D6FC70

	// Constructors
	public ConfigCCD() {} // 0x0000000182D706C0-0x0000000182D70760

	// Methods
	// [XID] // 0x000000018965AF10-0x000000018965AF30
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D70330-0x0000000182D70440
	// [XID] // 0x0000000189662400-0x0000000189662420
	public void InitEmpty() {} // 0x0000000182D6FC70-0x0000000182D6FD40
	[BlackList] // 0x0000000189669FC0-0x000000018966A000
	// [XID] // 0x0000000189669FC0-0x000000018966A000
	public bool FromJson(JSONNode node) => default; // 0x0000000182D6F810-0x0000000182D6FB90
	// [XID] // 0x00000001896749B0-0x00000001896749D0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182D6EDA0-0x0000000182D6F0A0
	// [XID] // 0x000000018967C2C0-0x000000018967C2E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A89 */, bool useObjectPool = false /* Metadata: 0x00AF8A8D */) => default; // 0x0000000182D6FD40-0x0000000182D70040
	// [XID] // 0x0000000189683930-0x0000000189683950
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A8E */, bool useObjectPool = false /* Metadata: 0x00AF8A92 */) => default; // 0x0000000182D6F5C0-0x0000000182D6F810
	[BlackList] // 0x000000018968B650-0x000000018968B690
	// [XID] // 0x000000018968B650-0x000000018968B690
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D6F180-0x0000000182D6F450
	// [XID] // 0x0000000189696210-0x0000000189696230
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D700F0-0x0000000182D70330
	[BlackList] // 0x000000018969D890-0x000000018969D8D0
	// [XID] // 0x000000018969D890-0x000000018969D8D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182D6F450-0x0000000182D6F4F0
	[BlackList] // 0x00000001896A79A0-0x00000001896A79E0
	// [XID] // 0x00000001896A79A0-0x00000001896A79E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182D6F4F0-0x0000000182D6F5C0
	[BlackList] // 0x00000001896B1810-0x00000001896B1850
	// [XID] // 0x00000001896B1810-0x00000001896B1850
	public virtual void ReturnToObjectPool() {} // 0x0000000182D70620-0x0000000182D706C0
	[BlackList] // 0x00000001896BBF80-0x00000001896BBFC0
	// [XID] // 0x00000001896BBF80-0x00000001896BBFC0
	public virtual void OnPoolAllocated() {} // 0x0000000182D704E0-0x0000000182D70580
	[BlackList] // 0x00000001896C65D0-0x00000001896C6610
	// [XID] // 0x00000001896C65D0-0x00000001896C6610
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182D70440-0x0000000182D704E0
}

