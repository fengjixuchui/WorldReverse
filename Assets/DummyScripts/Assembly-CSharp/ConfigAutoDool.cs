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
public class ConfigAutoDool : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17993
{
	// Fields
	private SimpleSafeFloat checkIntervalRawNum; // 0x10
	private SimpleSafeFloat triggerDistanceRawNum; // 0x14

	// Properties
	public float checkInterval { /* [XID] */ /* 0x0000000189A53870-0x0000000189A53890 */ get => default; /* [XID] */ /* 0x0000000189A174D0-0x0000000189A174F0 */ private set {} } // 0x000000018447ED00-0x000000018447EDE0 0x000000018447E270-0x000000018447E350
	public float triggerDistance { /* [XID] */ /* 0x0000000189A1EC30-0x0000000189A1EC50 */ get => default; /* [XID] */ /* 0x0000000189A262E0-0x0000000189A26300 */ private set {} } // 0x000000018447F360-0x000000018447F440 0x000000018447F280-0x000000018447F360

	// Constructors
	public ConfigAutoDool() {} // 0x000000018447F4E0-0x000000018447F590

	// Methods
	// [XID] // 0x0000000189A2D5D0-0x0000000189A2D5F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018447F030-0x000000018447F140
	// [XID] // 0x0000000189A35070-0x0000000189A35090
	public void InitEmpty() {} // 0x000000018447E920-0x000000018447EA00
	[BlackList] // 0x0000000189A3C4F0-0x0000000189A3C530
	// [XID] // 0x0000000189A3C4F0-0x0000000189A3C530
	public bool FromJson(JSONNode node) => default; // 0x000000018447E5A0-0x000000018447E920
	// [XID] // 0x0000000189A46E70-0x0000000189A46E90
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018447DB10-0x000000018447DE20
	// [XID] // 0x0000000189A4E7B0-0x0000000189A4E7D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF85FD */, bool useObjectPool = false /* Metadata: 0x00AF8601 */) => default; // 0x000000018447EA00-0x000000018447ED00
	// [XID] // 0x0000000189A55EA0-0x0000000189A55EC0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8602 */, bool useObjectPool = false /* Metadata: 0x00AF8606 */) => default; // 0x000000018447E350-0x000000018447E5A0
	[BlackList] // 0x0000000189A5D820-0x0000000189A5D860
	// [XID] // 0x0000000189A5D820-0x0000000189A5D860
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018447DE20-0x000000018447E0F0
	// [XID] // 0x0000000189A683F0-0x0000000189A68410
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018447EDE0-0x000000018447F030
	[BlackList] // 0x0000000189A6F780-0x0000000189A6F7C0
	// [XID] // 0x0000000189A6F780-0x0000000189A6F7C0
	public virtual void AutoAllocTypeFields() {} // 0x000000018447E0F0-0x000000018447E190
	[BlackList] // 0x0000000189A7A4B0-0x0000000189A7A4F0
	// [XID] // 0x0000000189A7A4B0-0x0000000189A7A4F0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018447E190-0x000000018447E270
	[BlackList] // 0x0000000189A84B60-0x0000000189A84BA0
	// [XID] // 0x0000000189A84B60-0x0000000189A84BA0
	public virtual void ReturnToObjectPool() {} // 0x000000018447F440-0x000000018447F4E0
	[BlackList] // 0x0000000189A8F490-0x0000000189A8F4D0
	// [XID] // 0x0000000189A8F490-0x0000000189A8F4D0
	public virtual void OnPoolAllocated() {} // 0x000000018447F1E0-0x000000018447F280
	[BlackList] // 0x0000000189A99DA0-0x0000000189A99DE0
	// [XID] // 0x0000000189A99DA0-0x0000000189A99DE0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018447F140-0x000000018447F1E0
}

