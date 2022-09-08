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

public abstract class CharacterModule : BaseModule // TypeDefIndex: 21419
{
	// Fields
	protected Dictionary<uint, Dictionary<int, List<BaseRetargetCommand>>> _retargetCmdDic; // 0x10

	// Constructors
	protected CharacterModule() {} // 0x0000000183D40800-0x0000000183D408B0

	// Methods
	// [XID] // 0x0000000189967E60-0x0000000189967E80
	public List<BaseRetargetCommand> GetRetargetCacheCmd(uint localRuntimeID, RetargetCommandType cmdType) => default; // 0x0000000183D40540-0x0000000183D40670
	// [XID] // 0x000000018996F0C0-0x000000018996F0E0
	public void AddCacheCmd(BaseRetargetCommand cmd) {} // 0x0000000183D40100-0x0000000183D40320
	// [XID] // 0x0000000189BB2F00-0x0000000189BB2F20
	protected void HandleRetargetCache(uint localRuntimeID, uint runtimeID) {} // 0x0000000183D40320-0x0000000183D40540
	// [XID] // 0x0000000189BBA480-0x0000000189BBA4A0
	protected void HandlerRetargetCacheInternal(uint runtimeID, uint localRutimeID, RetargetCommandType cmdType) {} // 0x0000000183D3FC20-0x0000000183D3FD30
	// [XID] // 0x0000000189BAB9D0-0x0000000189BAB9F0
	protected bool Retarget(BaseEntity entity, uint runtimeID) => default; // 0x0000000183D3FE10-0x0000000183D3FF20
	// [XID] // 0x000000018998D7C0-0x000000018998D7E0
	protected void HandleReqInteraction(uint runtimeID, List<BaseRetargetCommand> cmdList) {} // 0x0000000183D3FF20-0x0000000183D40100
	// [XID] // 0x0000000189995230-0x0000000189995250
	public virtual void EntityDisappearByID(uint entityId, VisionType type) {} // 0x0000000183D3FD30-0x0000000183D3FE10
	// [XID] // 0x000000018999CD10-0x000000018999CD30
	public virtual void EntityDisappear(uint entityId, VisionType type) {} // 0x0000000183D40670-0x0000000183D40730
	// [XID] // 0x00000001899A4590-0x00000001899A45B0
	public virtual void EntityAppear(SceneEntityInfo entity, VisionType type, uint infoParam) {} // 0x0000000183D40730-0x0000000183D40800
}

