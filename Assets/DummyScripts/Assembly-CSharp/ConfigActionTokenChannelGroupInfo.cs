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
public class ConfigActionTokenChannelGroupInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16323
{
	// Fields
	private SimpleSafeFloat lowLevelDistRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup> _lowLevelDistToken; // 0x18
	private Dictionary<ActionTokenSourceType, Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup>> _actionSourceToken; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigActionTokenChannel> _cfg; // 0x28

	// Properties
	public float lowLevelDist { /* [XID] */ /* 0x00000001896CC6B0-0x00000001896CC6D0 */ get => default; /* [XID] */ /* 0x00000001896D3940-0x00000001896D3960 */ private set {} } // 0x000000018276B9A0-0x000000018276BA80 0x000000018276CD30-0x000000018276CE10
	public Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup> lowLevelDistToken { /* [XID] */ /* 0x00000001896DB420-0x00000001896DB440 */ get => default; /* [XID] */ /* 0x00000001896E2B00-0x00000001896E2B20 */ private set {} } // 0x000000018276C390-0x000000018276C430 0x000000018276D510-0x000000018276D5C0
	public Dictionary<ActionTokenSourceType, Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup>> actionSourceToken { /* [XID] */ /* 0x00000001896EA0C0-0x00000001896EA0E0 */ get => default; /* [XID] */ /* 0x00000001896F1140-0x00000001896F1160 */ private set {} } // 0x000000018276CE10-0x000000018276CEB0 0x000000018276C850-0x000000018276C900
	public Dictionary<SimpleSafeInt32, ConfigActionTokenChannel> cfg { /* [XID] */ /* 0x00000001896F8A00-0x00000001896F8A20 */ get => default; /* [XID] */ /* 0x0000000189700240-0x0000000189700260 */ private set {} } // 0x000000018276C430-0x000000018276C4D0 0x000000018276BF00-0x000000018276BFB0

	// Constructors
	public ConfigActionTokenChannelGroupInfo() {} // 0x000000018276D660-0x000000018276D6F0

	// Methods
	// [XID] // 0x0000000189707AB0-0x0000000189707AD0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018276D290-0x000000018276D3D0
	// [XID] // 0x000000018970F4E0-0x000000018970F500
	public void InitEmpty() {} // 0x000000018276C900-0x000000018276CA30
	[BlackList] // 0x0000000189716860-0x00000001897168A0
	// [XID] // 0x0000000189716860-0x00000001897168A0
	public bool FromJson(JSONNode node) => default; // 0x000000018276C4D0-0x000000018276C850
	// [XID] // 0x0000000189721210-0x0000000189721230
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018276B4F0-0x000000018276B9A0
	// [XID] // 0x0000000189728830-0x0000000189728850
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF37E8 */, bool useObjectPool = false /* Metadata: 0x00AF37EC */) => default; // 0x000000018276CA30-0x000000018276CD30
	// [XID] // 0x000000018972FFE0-0x0000000189730000
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF37ED */, bool useObjectPool = false /* Metadata: 0x00AF37F1 */) => default; // 0x000000018276BFB0-0x000000018276C390
	[BlackList] // 0x00000001897378C0-0x0000000189737900
	// [XID] // 0x00000001897378C0-0x0000000189737900
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018276BA80-0x000000018276BD50
	// [XID] // 0x0000000189741EA0-0x0000000189741EC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018276CEB0-0x000000018276D290
	[BlackList] // 0x00000001897498A0-0x00000001897498E0
	// [XID] // 0x00000001897498A0-0x00000001897498E0
	public virtual void AutoAllocTypeFields() {} // 0x000000018276BD50-0x000000018276BDF0
	[BlackList] // 0x0000000189753CE0-0x0000000189753D20
	// [XID] // 0x0000000189753CE0-0x0000000189753D20
	public virtual void AutoRecycleTypeFields() {} // 0x000000018276BDF0-0x000000018276BF00
	[BlackList] // 0x000000018975E390-0x000000018975E3D0
	// [XID] // 0x000000018975E390-0x000000018975E3D0
	public virtual void ReturnToObjectPool() {} // 0x000000018276D5C0-0x000000018276D660
	[BlackList] // 0x0000000189768A20-0x0000000189768A60
	// [XID] // 0x0000000189768A20-0x0000000189768A60
	public virtual void OnPoolAllocated() {} // 0x000000018276D470-0x000000018276D510
	[BlackList] // 0x0000000189773120-0x0000000189773160
	// [XID] // 0x0000000189773120-0x0000000189773160
	public virtual void OnBeforePoolRecycled() {} // 0x000000018276D3D0-0x000000018276D470
}

