/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EntitySafeCmd // TypeDefIndex: 19860
{
	// Fields
	private static bool _preCached; // 0x00
	private const int MAX_INIT_QUEUE_CAPCITY = 20; // Metadata: 0x00AFCF8F
	private static Dictionary<int, Queue<EntitySafeCmd>> _poolDic; // 0x08
	protected EntitySafeCmdType _type; // 0x10
	protected uint _runtimeId; // 0x14

	// Properties
	public EntitySafeCmdType type { /* [XID] */ /* 0x000000018994C520-0x000000018994C540 */ get => default; } // 0x00000001830F7F90-0x00000001830F8030 
	public uint runtimeId { /* [XID] */ /* 0x00000001899BE0D0-0x00000001899BE0F0 */ get => default; } // 0x00000001830F7EF0-0x00000001830F7F90 

	// Constructors
	public EntitySafeCmd() {} // 0x00000001830F80D0-0x00000001830F8140
	static EntitySafeCmd() {} // 0x00000001830F8030-0x00000001830F80D0

	// Methods
	// [XID] // 0x00000001899A78E0-0x00000001899A7900
	public static void PreCache() {} // 0x00000001830F7A20-0x00000001830F7BB0
	public static CmdType Get<CmdType>(EntitySafeCmdType type, uint runtimeId)
		where CmdType : EntitySafeCmd, new() => default;
	// [XID] // 0x0000000189925B10-0x0000000189925B30
	public static void Free(EntitySafeCmd cmd) {} // 0x00000001830F7DB0-0x00000001830F7EF0
	// [XID] // 0x00000001899C58B0-0x00000001899C58D0
	public virtual void Init(EntitySafeCmdType pType, uint pRuntimeId) {} // 0x00000001830F7BB0-0x00000001830F7C70
	// [XID] // 0x0000000189813600-0x0000000189813620
	public virtual void HandleCmd() {} // 0x00000001830F7D10-0x00000001830F7DB0
	// [XID] // 0x00000001899D4420-0x00000001899D4440
	public virtual void Clear() {} // 0x00000001830F7C70-0x00000001830F7D10
}

