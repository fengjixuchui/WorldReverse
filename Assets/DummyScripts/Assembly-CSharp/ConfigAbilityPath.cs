/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigAbilityPath : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17173
{
	// Fields
	private Dictionary<string, string[]> _abilityPaths; // 0x10

	// Properties
	public Dictionary<string, string[]> abilityPaths { /* [XID] */ /* 0x0000000189BA24D0-0x0000000189BA24F0 */ get => default; /* [XID] */ /* 0x0000000189BA99E0-0x0000000189BA9A00 */ private set {} } // 0x0000000184771D50-0x0000000184771DF0 0x0000000184772200-0x00000001847722B0

	// Constructors
	public ConfigAbilityPath() {} // 0x0000000184772350-0x00000001847723B0

	// Methods
	// [XID] // 0x0000000189BB11D0-0x0000000189BB11F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184771FE0-0x00000001847720C0
	// [XID] // 0x0000000189BB8320-0x0000000189BB8340
	public void InitEmpty() {} // 0x0000000184771980-0x0000000184771A50
	[BlackList] // 0x0000000189BBFB10-0x0000000189BBFB50
	// [XID] // 0x0000000189BBFB10-0x0000000189BBFB50
	public bool FromJson(JSONNode node) => default; // 0x0000000184771600-0x0000000184771980
	// [XID] // 0x0000000189BCAAF0-0x0000000189BCAB10
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184770E00-0x0000000184770FE0
	// [XID] // 0x0000000189BD2180-0x0000000189BD21A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF658D */, bool useObjectPool = false /* Metadata: 0x00AF6591 */) => default; // 0x0000000184771A50-0x0000000184771D50
	// [XID] // 0x0000000189BD97A0-0x0000000189BD97C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6592 */, bool useObjectPool = false /* Metadata: 0x00AF6596 */) => default; // 0x00000001847713F0-0x0000000184771600
	[BlackList] // 0x00000001895E61D0-0x00000001895E6210
	// [XID] // 0x00000001895E61D0-0x00000001895E6210
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184770FE0-0x00000001847712B0
	// [XID] // 0x00000001895F0AA0-0x00000001895F0AC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184771DF0-0x0000000184771FE0
	[BlackList] // 0x00000001895F8450-0x00000001895F8490
	// [XID] // 0x00000001895F8450-0x00000001895F8490
	public virtual void AutoAllocTypeFields() {} // 0x00000001847712B0-0x0000000184771350
	[BlackList] // 0x0000000189602AB0-0x0000000189602AF0
	// [XID] // 0x0000000189602AB0-0x0000000189602AF0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184771350-0x00000001847713F0
	[BlackList] // 0x000000018960D2E0-0x000000018960D320
	// [XID] // 0x000000018960D2E0-0x000000018960D320
	public virtual void ReturnToObjectPool() {} // 0x00000001847722B0-0x0000000184772350
	[BlackList] // 0x0000000189617770-0x00000001896177B0
	// [XID] // 0x0000000189617770-0x00000001896177B0
	public virtual void OnPoolAllocated() {} // 0x0000000184772160-0x0000000184772200
	[BlackList] // 0x0000000189622020-0x0000000189622060
	// [XID] // 0x0000000189622020-0x0000000189622060
	public virtual void OnBeforePoolRecycled() {} // 0x00000001847720C0-0x0000000184772160
}

