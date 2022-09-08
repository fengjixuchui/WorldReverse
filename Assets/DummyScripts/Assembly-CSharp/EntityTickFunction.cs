/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class EntityTickFunction : IReusable, IDisposable // TypeDefIndex: 19864
{
	// Fields
	public static bool statDisableEntityTick; // 0x00
	protected int _generation; // 0x18
	protected EntityTickContext _context; // 0x20
	private static int importantErrorCount; // 0x04

	// Properties
	public BaseEntity _entity { /* [XID] */ /* 0x0000000189A4FC60-0x0000000189A4FCA0 */ get; /* [XID] */ /* 0x0000000189A5A320-0x0000000189A5A360 */ protected set; } // 0x0000000185689C40-0x0000000185689CA0 0x0000000185689990-0x00000001856899F0
	public bool isValid { /* [XID] */ /* 0x0000000189A64DA0-0x0000000189A64DC0 */ get; } // 0x00000001856899F0-0x0000000185689C40 

	// Constructors
	protected EntityTickFunction() {} // 0x000000018568A650-0x000000018568A6B0
	static EntityTickFunction() {} // 0x000000018568A5E0-0x000000018568A650

	// Methods
	// [XID] // 0x0000000189A48350-0x0000000189A48370
	public override string ToString() => default; // 0x000000018568A400-0x000000018568A5E0
	// [XID] // 0x0000000189A6C520-0x0000000189A6C540
	protected virtual bool IsLevelValid() => default; // 0x0000000185689750-0x0000000185689800
	// [XID] // 0x0000000189A73CD0-0x0000000189A73CF0
	public void CheckIsTickable() {} // 0x00000001856892F0-0x0000000185689660
	public static T CreateTickFunction<T>(BaseEntity inEntity, EntityTickContext inTickContext, bool fromJobThread)
		where T : EntityTickFunction, new() => default;
	// [XID] // 0x0000000189A7B7E0-0x0000000189A7B800
	public static void BeforeExecuteEntityTick(BaseEntity inEntity) {} // 0x0000000185689240-0x00000001856892F0
	public static T AddTailTickList<T>(TickArray list, BaseEntity inEntity, EntityTickContext inTickContext, bool fromJobThread)
		where T : EntityTickFunction, new() => default;
	// [XID] // 0x0000000189610D60-0x0000000189610D80
	public static void AddSyncTickableFunctionToTickList(TickArray inEntityTickList, BaseEntity inEntity, EntityTickContext inContext, bool fromJobThread) {} // 0x0000000185689CA0-0x0000000185689E90
	// [XID] // 0x0000000189A8A860-0x0000000189A8A880
	public static void TickBeforeComponents(BaseEntity inEntity) {} // 0x0000000185689FA0-0x000000018568A050
	// [XID] // 0x0000000189A92140-0x0000000189A92160
	public static void TickComponents(BaseEntity inEntity, float inGameDeltaTime) {} // 0x0000000185689E90-0x0000000185689FA0
	// [XID] // 0x0000000189A99B20-0x0000000189A99B40
	public static void ConditionalAddToSafeReadyEntitiesList(BaseEntity inEntity, List<BaseEntity> onSafeReadyEntitiesList) {} // 0x0000000185689800-0x0000000185689990
	public abstract void Execute();
	// [XID] // 0x0000000189AA0AE0-0x0000000189AA0B00
	public void BeforeRecycle() {} // 0x0000000185689660-0x0000000185689750
	public abstract void Dispose();
	// [XID] // 0x0000000189AA81C0-0x0000000189AA81E0
	public static void InitObjectPool() {} // 0x000000018568A050-0x000000018568A400
}

