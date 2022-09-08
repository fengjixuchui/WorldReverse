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
public class ConfigPlatformActionTokenChannel : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16324
{
	// Fields
	private EntityType[] _highEntityTypes; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup> _entityTypeToken; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigActionTokenChannelGroupInfo _defaultCfg; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigActionTokenChannelGroupInfo> _platformCfg; // 0x28

	// Properties
	public EntityType[] highEntityTypes { /* [XID] */ /* 0x000000018979BF70-0x000000018979BF90 */ get => default; /* [XID] */ /* 0x00000001897A3400-0x00000001897A3420 */ private set {} } // 0x0000000181872F40-0x0000000181872FE0 0x0000000181872E90-0x0000000181872F40
	public Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup> entityTypeToken { /* [XID] */ /* 0x00000001897AA980-0x00000001897AA9A0 */ get => default; /* [XID] */ /* 0x00000001897B2510-0x00000001897B2530 */ private set {} } // 0x0000000181872D40-0x0000000181872DE0 0x0000000181872DE0-0x0000000181872E90
	public ConfigActionTokenChannelGroupInfo defaultCfg { /* [XID] */ /* 0x00000001897B9E30-0x00000001897B9E50 */ get => default; /* [XID] */ /* 0x00000001897C1F10-0x00000001897C1F30 */ private set {} } // 0x0000000181871D90-0x0000000181871E30 0x00000001818733E0-0x0000000181873490
	public Dictionary<string, ConfigActionTokenChannelGroupInfo> platformCfg { /* [XID] */ /* 0x00000001897C97E0-0x00000001897C9800 */ get => default; /* [XID] */ /* 0x00000001897D0DF0-0x00000001897D0E10 */ private set {} } // 0x00000001818729A0-0x0000000181872A40 0x0000000181872030-0x00000001818720E0

	// Constructors
	public ConfigPlatformActionTokenChannel() {} // 0x00000001818737C0-0x0000000181873820

	// Methods
	// [XID] // 0x00000001897D8CD0-0x00000001897D8CF0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181873490-0x00000001818735E0
	// [XID] // 0x00000001897DFED0-0x00000001897DFEF0
	public void InitEmpty() {} // 0x0000000181872890-0x00000001818729A0
	[BlackList] // 0x00000001897E75D0-0x00000001897E7610
	// [XID] // 0x00000001897E75D0-0x00000001897E7610
	public bool FromJson(JSONNode node) => default; // 0x0000000181872510-0x0000000181872890
	// [XID] // 0x00000001897F2570-0x00000001897F2590
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181871620-0x0000000181871AC0
	// [XID] // 0x00000001897F9C80-0x00000001897F9CA0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF37F2 */, bool useObjectPool = false /* Metadata: 0x00AF37F6 */) => default; // 0x0000000181872A40-0x0000000181872D40
	// [XID] // 0x0000000189801200-0x0000000189801220
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF37F7 */, bool useObjectPool = false /* Metadata: 0x00AF37FB */) => default; // 0x00000001818720E0-0x0000000181872510
	[BlackList] // 0x00000001898085E0-0x0000000189808620
	// [XID] // 0x00000001898085E0-0x0000000189808620
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181871AC0-0x0000000181871D90
	// [XID] // 0x0000000189812D00-0x0000000189812D20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181872FE0-0x00000001818733E0
	[BlackList] // 0x000000018981A920-0x000000018981A960
	// [XID] // 0x000000018981A920-0x000000018981A960
	public virtual void AutoAllocTypeFields() {} // 0x0000000181871E30-0x0000000181871ED0
	[BlackList] // 0x0000000189824D40-0x0000000189824D80
	// [XID] // 0x0000000189824D40-0x0000000189824D80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181871ED0-0x0000000181872030
	[BlackList] // 0x000000018982F2A0-0x000000018982F2E0
	// [XID] // 0x000000018982F2A0-0x000000018982F2E0
	public virtual void ReturnToObjectPool() {} // 0x0000000181873720-0x00000001818737C0
	[BlackList] // 0x0000000189839980-0x00000001898399C0
	// [XID] // 0x0000000189839980-0x00000001898399C0
	public virtual void OnPoolAllocated() {} // 0x0000000181873680-0x0000000181873720
	[BlackList] // 0x00000001898441A0-0x00000001898441E0
	// [XID] // 0x00000001898441A0-0x00000001898441E0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001818735E0-0x0000000181873680
}

