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
public class ConfigActionPanelMode : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18800
{
	// Fields
	private Dictionary<ActionPanelState, string> _stateMap; // 0x10

	// Properties
	public Dictionary<ActionPanelState, string> stateMap { /* [XID] */ /* 0x0000000189B16270-0x0000000189B16290 */ get => default; /* [XID] */ /* 0x0000000189B1D9D0-0x0000000189B1D9F0 */ private set {} } // 0x00000001835AAC70-0x00000001835AAD10 0x00000001835AA7F0-0x00000001835AA8A0

	// Constructors
	public ConfigActionPanelMode() {} // 0x00000001835AB1C0-0x00000001835AB220

	// Methods
	// [XID] // 0x0000000189B252E0-0x0000000189B25300
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001835AAF00-0x00000001835AAFE0
	// [XID] // 0x0000000189B2C790-0x0000000189B2C7B0
	public void InitEmpty() {} // 0x00000001835AA8A0-0x00000001835AA970
	[BlackList] // 0x0000000189B33CA0-0x0000000189B33CE0
	// [XID] // 0x0000000189B33CA0-0x0000000189B33CE0
	public bool FromJson(JSONNode node) => default; // 0x00000001835AA470-0x00000001835AA7F0
	// [XID] // 0x0000000189B3E580-0x0000000189B3E5A0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001835A9C70-0x00000001835A9E50
	// [XID] // 0x0000000189B46100-0x0000000189B46120
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD1D */, bool useObjectPool = false /* Metadata: 0x00AFAD21 */) => default; // 0x00000001835AA970-0x00000001835AAC70
	// [XID] // 0x0000000189B4D6B0-0x0000000189B4D6D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD22 */, bool useObjectPool = false /* Metadata: 0x00AFAD26 */) => default; // 0x00000001835AA260-0x00000001835AA470
	[BlackList] // 0x0000000189B54E70-0x0000000189B54EB0
	// [XID] // 0x0000000189B54E70-0x0000000189B54EB0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001835A9E50-0x00000001835AA120
	// [XID] // 0x0000000189B5FA40-0x0000000189B5FA60
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001835AAD10-0x00000001835AAF00
	[BlackList] // 0x0000000189B67180-0x0000000189B671C0
	// [XID] // 0x0000000189B67180-0x0000000189B671C0
	public virtual void AutoAllocTypeFields() {} // 0x00000001835AA120-0x00000001835AA1C0
	[BlackList] // 0x0000000189B71670-0x0000000189B716B0
	// [XID] // 0x0000000189B71670-0x0000000189B716B0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001835AA1C0-0x00000001835AA260
	[BlackList] // 0x0000000189B7B930-0x0000000189B7B970
	// [XID] // 0x0000000189B7B930-0x0000000189B7B970
	public virtual void ReturnToObjectPool() {} // 0x00000001835AB120-0x00000001835AB1C0
	[BlackList] // 0x0000000189B86440-0x0000000189B86480
	// [XID] // 0x0000000189B86440-0x0000000189B86480
	public virtual void OnPoolAllocated() {} // 0x00000001835AB080-0x00000001835AB120
	[BlackList] // 0x0000000189B90630-0x0000000189B90670
	// [XID] // 0x0000000189B90630-0x0000000189B90670
	public virtual void OnBeforePoolRecycled() {} // 0x00000001835AAFE0-0x00000001835AB080
}

