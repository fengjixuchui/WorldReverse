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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigPlatformUIData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18636
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigPlatformUIAction _baseCanvansAction; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigPlatformUIAction _basePageAction; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigPlatformUIAction> _contextActions; // 0x20

	// Properties
	public ConfigPlatformUIAction baseCanvansAction { /* [XID] */ /* 0x0000000189670070-0x0000000189670090 */ get => default; /* [XID] */ /* 0x00000001896779D0-0x00000001896779F0 */ private set {} } // 0x0000000184767790-0x0000000184767830 0x0000000184767830-0x00000001847678E0
	public ConfigPlatformUIAction basePageAction { /* [XID] */ /* 0x000000018967EEE0-0x000000018967EF00 */ get => default; /* [XID] */ /* 0x0000000189686850-0x0000000189686870 */ private set {} } // 0x0000000184766EC0-0x0000000184766F60 0x0000000184766A50-0x0000000184766B00
	public Dictionary<string, ConfigPlatformUIAction> contextActions { /* [XID] */ /* 0x000000018968E650-0x000000018968E670 */ get => default; /* [XID] */ /* 0x00000001896960D0-0x00000001896960F0 */ private set {} } // 0x0000000184766480-0x0000000184766520 0x00000001847673E0-0x0000000184767490

	// Constructors
	public ConfigPlatformUIData() {} // 0x0000000184767F40-0x0000000184767FA0

	// Methods
	// [XID] // 0x000000018969D7B0-0x000000018969D7D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184767C20-0x0000000184767D60
	// [XID] // 0x00000001896A4800-0x00000001896A4820
	public void InitEmpty() {} // 0x00000001847672E0-0x00000001847673E0
	[BlackList] // 0x00000001896ABF70-0x00000001896ABFB0
	// [XID] // 0x00000001896ABF70-0x00000001896ABFB0
	public bool FromJson(JSONNode node) => default; // 0x0000000184766F60-0x00000001847672E0
	// [XID] // 0x00000001896B6400-0x00000001896B6420
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001847660B0-0x0000000184766480
	// [XID] // 0x0000000189A37520-0x0000000189A37540
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA693 */, bool useObjectPool = false /* Metadata: 0x00AFA697 */) => default; // 0x0000000184767490-0x0000000184767790
	// [XID] // 0x0000000189A3EC70-0x0000000189A3EC90
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA698 */, bool useObjectPool = false /* Metadata: 0x00AFA69C */) => default; // 0x0000000184766B00-0x0000000184766EC0
	[BlackList] // 0x00000001896CC130-0x00000001896CC170
	// [XID] // 0x00000001896CC130-0x00000001896CC170
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184766520-0x00000001847667F0
	// [XID] // 0x00000001896D67A0-0x00000001896D67C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001847678E0-0x0000000184767C20
	[BlackList] // 0x00000001896DDE00-0x00000001896DDE40
	// [XID] // 0x00000001896DDE00-0x00000001896DDE40
	public virtual void AutoAllocTypeFields() {} // 0x00000001847667F0-0x0000000184766890
	[BlackList] // 0x00000001896E8240-0x00000001896E8280
	// [XID] // 0x00000001896E8240-0x00000001896E8280
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184766890-0x0000000184766A50
	[BlackList] // 0x00000001896F2690-0x00000001896F26D0
	// [XID] // 0x00000001896F2690-0x00000001896F26D0
	public virtual void ReturnToObjectPool() {} // 0x0000000184767EA0-0x0000000184767F40
	[BlackList] // 0x00000001896FD1F0-0x00000001896FD230
	// [XID] // 0x00000001896FD1F0-0x00000001896FD230
	public virtual void OnPoolAllocated() {} // 0x0000000184767E00-0x0000000184767EA0
	[BlackList] // 0x00000001897076F0-0x0000000189707730
	// [XID] // 0x00000001897076F0-0x0000000189707730
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184767D60-0x0000000184767E00
}

