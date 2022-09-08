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
public class ConfigTimeSlow : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16851
{
	// Fields
	private SimpleSafeFloat durationRawNum; // 0x10
	private SimpleSafeFloat slowRatioRawNum; // 0x14

	// Properties
	public float duration { /* [XID] */ /* 0x0000000189B09330-0x0000000189B09350 */ get => default; /* [XID] */ /* 0x0000000189B10DF0-0x0000000189B10E10 */ private set {} } // 0x000000018297BF20-0x000000018297C000 0x000000018297C290-0x000000018297C370
	public float slowRatio { /* [XID] */ /* 0x0000000189B180A0-0x0000000189B180C0 */ get => default; /* [XID] */ /* 0x0000000189B1F760-0x0000000189B1F780 */ private set {} } // 0x000000018297C370-0x000000018297C450 0x000000018297CBB0-0x000000018297CC90

	// Constructors
	public ConfigTimeSlow() {} // 0x000000018297D1C0-0x000000018297D260

	// Methods
	// [XID] // 0x0000000189B26FE0-0x0000000189B27000
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018297CED0-0x000000018297CFE0
	// [XID] // 0x0000000189B2E1B0-0x0000000189B2E1D0
	public void InitEmpty() {} // 0x000000018297C7D0-0x000000018297C8B0
	[BlackList] // 0x0000000189B35620-0x0000000189B35660
	// [XID] // 0x0000000189B35620-0x0000000189B35660
	public bool FromJson(JSONNode node) => default; // 0x000000018297C450-0x000000018297C7D0
	// [XID] // 0x0000000189B40200-0x0000000189B40220
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018297B7A0-0x000000018297BAD0
	// [XID] // 0x0000000189B47B00-0x0000000189B47B20
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4898 */, bool useObjectPool = false /* Metadata: 0x00AF489C */) => default; // 0x000000018297C8B0-0x000000018297CBB0
	// [XID] // 0x0000000189B4F350-0x0000000189B4F370
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF489D */, bool useObjectPool = false /* Metadata: 0x00AF48A1 */) => default; // 0x000000018297C000-0x000000018297C290
	[BlackList] // 0x0000000189B56C50-0x0000000189B56C90
	// [XID] // 0x0000000189B56C50-0x0000000189B56C90
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018297BAD0-0x000000018297BDA0
	// [XID] // 0x0000000189B61290-0x0000000189B612B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018297CC90-0x000000018297CED0
	[BlackList] // 0x0000000189B68B60-0x0000000189B68BA0
	// [XID] // 0x0000000189B68B60-0x0000000189B68BA0
	public virtual void AutoAllocTypeFields() {} // 0x000000018297BDA0-0x000000018297BE40
	[BlackList] // 0x0000000189B72FD0-0x0000000189B73010
	// [XID] // 0x0000000189B72FD0-0x0000000189B73010
	public virtual void AutoRecycleTypeFields() {} // 0x000000018297BE40-0x000000018297BF20
	[BlackList] // 0x0000000189B7D440-0x0000000189B7D480
	// [XID] // 0x0000000189B7D440-0x0000000189B7D480
	public virtual void ReturnToObjectPool() {} // 0x000000018297D120-0x000000018297D1C0
	[BlackList] // 0x0000000189B87DC0-0x0000000189B87E00
	// [XID] // 0x0000000189B87DC0-0x0000000189B87E00
	public virtual void OnPoolAllocated() {} // 0x000000018297D080-0x000000018297D120
	[BlackList] // 0x0000000189B92060-0x0000000189B920A0
	// [XID] // 0x0000000189B92060-0x0000000189B920A0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018297CFE0-0x000000018297D080
}

