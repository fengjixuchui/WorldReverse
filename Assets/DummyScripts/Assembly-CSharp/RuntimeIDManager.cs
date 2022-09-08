/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RuntimeIDManager : InLevelManager // TypeDefIndex: 20994
{
	// Fields
	public const int PEER_BITS = 3; // Metadata: 0x00AFEB7E
	public const int CATEGORY_BITS = 5; // Metadata: 0x00AFEB82
	public const int IS_SYNCED_BITS = 1; // Metadata: 0x00AFEB86
	public const int SEQUENCE_BITS = 23; // Metadata: 0x00AFEB8A
	public const int PEER_SHIFT = 29; // Metadata: 0x00AFEB8E
	public const int CATEGORY_SHIFT = 24; // Metadata: 0x00AFEB92
	public const int IS_SYNCED_SHIFT = 23; // Metadata: 0x00AFEB96
	public const int SEQUENCE_SHIFT = 0; // Metadata: 0x00AFEB9A
	private const uint PEER_MASK = 3758096384; // Metadata: 0x00AFEB9E
	private const uint CATEGORY_MASK = 520093696; // Metadata: 0x00AFEBA2
	private const uint IS_SYNCED_MASK = 8388608; // Metadata: 0x00AFEBA6
	private const uint SEQUENCE_MASK = 8388607; // Metadata: 0x00AFEBAA
	public const uint INVALID_RUNTIMEID = 0; // Metadata: 0x00AFEBAE
	public const ushort AVATAR_CATE = 1; // Metadata: 0x00AFEBB2
	public const ushort MONSTER_CATE = 2; // Metadata: 0x00AFEBB4
	public const ushort NPC_CATE = 3; // Metadata: 0x00AFEBB6
	public const ushort GADGET_CATE = 4; // Metadata: 0x00AFEBB8
	public const ushort MASSIVE_CATE = 10; // Metadata: 0x00AFEBBA
	public const ushort MAX_SERVER_CATE = 15; // Metadata: 0x00AFEBBC
	public const ushort EFFECT_CATE = 16; // Metadata: 0x00AFEBBE
	public const ushort ATTACKUNIT_CATE = 17; // Metadata: 0x00AFEBC0
	public const ushort CAMERA_CATE = 18; // Metadata: 0x00AFEBC2
	public const ushort MANAGER_CATE = 19; // Metadata: 0x00AFEBC4
	public const ushort LOCALGADGET_CATE = 20; // Metadata: 0x00AFEBC6
	public const ushort LOCALMASSIVE_CATE = 21; // Metadata: 0x00AFEBC8
	public const ushort NPCCROWD_CATE = 22; // Metadata: 0x00AFEBCA
	public const ushort LOCALNPC_CATE = 23; // Metadata: 0x00AFEBCC
	public const ushort HOMEWORLD_CATE = 24; // Metadata: 0x00AFEBCE
	public const uint LEVEL_RUNTIMEID = 327155713; // Metadata: 0x00AFEBD0
	private uint _networkedNextSeqID; // 0x10
	public const uint MAX_NETWORKED_SEQ_ID = 8388607; // Metadata: 0x00AFEBD4
	private uint _localNextSeqID; // 0x14
	public const uint MAX_LOCAL_SEQ_ID = 8388607; // Metadata: 0x00AFEBD8
	private uint _peerID; // 0x18

	// Constructors
	public RuntimeIDManager() {} // 0x0000000181BDE430-0x0000000181BDE4A0

	// Methods
	// [XID] // 0x000000018979FF50-0x000000018979FF70
	public override void Init() {} // 0x0000000181BDDF20-0x0000000181BDDFF0
	// [XID] // 0x00000001897A74A0-0x00000001897A74C0
	public override void Destroy() {} // 0x0000000181BDDC30-0x0000000181BDDCD0
	// [XID] // 0x00000001897AEF30-0x00000001897AEF50
	public uint GetNextRuntimeID(ushort category) => default; // 0x0000000181BDDB50-0x0000000181BDDC30
	// [XID] // 0x00000001897B6C40-0x00000001897B6C60
	public uint GetNextNonSyncedRuntimeID(ushort category) => default; // 0x0000000181BDD9B0-0x0000000181BDDA80
	// [XID] // 0x00000001897BEC90-0x00000001897BECB0
	public bool IsLocalEntity(uint Id) => default; // 0x0000000181BDDA80-0x0000000181BDDB50
	// [XID] // 0x00000001897C6130-0x00000001897C6150
	public ushort ParseCategory(uint runtimeID) => default; // 0x0000000181BDDE70-0x0000000181BDDF20
	// [XID] // 0x0000000189B58F40-0x0000000189B58F60
	public static ushort ParseCategoryStatic(uint runtimeID) => default; // 0x0000000181BDD840-0x0000000181BDD8F0
	// [XID] // 0x00000001897D4F10-0x00000001897D4F30
	public string ParseCategoryName(uint runtimeID) => default; // 0x0000000181BDDCD0-0x0000000181BDDE70
	// [XID] // 0x00000001897DC6B0-0x00000001897DC6D0
	public void SetupPeerID(uint peerID) {} // 0x0000000181BDDFF0-0x0000000181BDE0A0
	// [XID] // 0x00000001897E40D0-0x00000001897E40F0
	public uint ParseSequenceID(uint runtimeID) => default; // 0x0000000181BDE150-0x0000000181BDE200
	// [XID] // 0x00000001897EBC00-0x00000001897EBC20
	public uint ParsePeerID(uint runtimeID) => default; // 0x0000000181BDE0A0-0x0000000181BDE150
	// [XID] // 0x00000001897F3510-0x00000001897F3530
	public bool IsSyncedRuntimeID(uint runtimeID) => default; // 0x0000000181BDE200-0x0000000181BDE2B0
	// [XID] // 0x00000001897FAF10-0x00000001897FAF30
	public bool IsServerEntity(uint runtimeID) => default; // 0x0000000181BDE380-0x0000000181BDE430
	// [XID] // 0x00000001898023D0-0x00000001898023F0
	public static bool IsServerEntityStatic(uint runtimeID) => default; // 0x0000000181BDD8F0-0x0000000181BDD9B0
	// [XID] // 0x0000000189AF4F80-0x0000000189AF4FA0
	public bool IsClientEntity(uint runtimeID) => default; // 0x0000000181BDE2B0-0x0000000181BDE380
}

