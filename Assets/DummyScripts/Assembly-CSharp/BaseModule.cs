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

public abstract class BaseModule : IPacketInterface, INotifyInterface // TypeDefIndex: 21400
{
	// Fields
	public static List<BaseModule> _globalModules; // 0x00
	protected static ModulePacketSliceFrameHandlerManager _sliceFramePacketHandlerMgr; // 0x08
	protected static int _entityCreationSFTimer; // 0x10

	// Properties
	public ModulePacketSliceFrameHandlerManager sliceFramePacketHandlerMgr { /* [XID] */ /* 0x0000000189B16030-0x0000000189B16050 */ get; } // 0x0000000181F6A8A0-0x0000000181F6A970 
	public int entityCreationSFTimer { /* [XID] */ /* 0x0000000189B49D50-0x0000000189B49D70 */ get; } // 0x0000000181F6A730-0x0000000181F6A800 

	// Nested types
	public abstract class ModulePacketSliceFrameHandlerManager : SliceFrameJobHandlerManager // TypeDefIndex: 21401
	{
		// Constructors
		protected ModulePacketSliceFrameHandlerManager() {} // Dummy constructor
		public ModulePacketSliceFrameHandlerManager(int priorityCount) {} // 0x00000001825269E0-0x0000000182526A50
	}

	public class HandleActionContext // TypeDefIndex: 21402
	{
		// Fields
		private Action<MessageBase> notifyHandler; // 0x10
		protected MessageBase actionNotify; // 0x18

		// Constructors
		public HandleActionContext() {} // 0x0000000182525CA0-0x0000000182525D00

		// Methods
		// [XID] // 0x0000000189B42BB0-0x0000000189B42BD0
		public void Init(MessageBase notify, Action<MessageBase> handler) {} // 0x0000000182525900-0x0000000182525A10
		// [IDTag] // 0x0000000189B4A610-0x0000000189B4A650
		// [XID] // 0x0000000189B4A610-0x0000000189B4A650
		public virtual void DoAction(BaseEntity e) {} // 0x0000000182525BE0-0x0000000182525CA0
		// [IDTag] // 0x0000000189B54C10-0x0000000189B54C50
		// [XID] // 0x0000000189B54C10-0x0000000189B54C50
		public virtual void DoAction() {} // 0x0000000182525B10-0x0000000182525BE0
		// [XID] // 0x0000000189B5F640-0x0000000189B5F660
		protected virtual void Deallocate() {} // 0x0000000182525840-0x0000000182525900
		// [XID] // 0x0000000189B66D60-0x0000000189B66D80
		public string NotifyType() => default; // 0x0000000182525A10-0x0000000182525B10
	}

	public class HandleActionContextWithParam<T> : HandleActionContext // TypeDefIndex: 21403
	{
		// Fields
		private Action<MessageBase, T> notifyHandler;
		protected T notifyParam;

		// Constructors
		public HandleActionContextWithParam() {}

		// Methods
		public void Init(MessageBase notify, T param, Action<MessageBase, T> handler) {}
		public override void DoAction() {}
		protected override void Deallocate() {}
	}

	public class EntityPacketNotifyHandler : SliceFrameJobHandlerOfTBase<MessageBase> // TypeDefIndex: 21404
	{
		// Fields
		private Action<MessageBase> _notifyHandler; // 0x20
		protected MessageBase _entityNotify; // 0x28
		protected uint _entityId; // 0x30
		protected bool _isEntityAppear; // 0x34

		// Constructors
		public EntityPacketNotifyHandler() {} // 0x00000001825266A0-0x0000000182526710

		// Methods
		// [XID] // 0x0000000189B6E0C0-0x0000000189B6E0E0
		public static EntityPacketNotifyHandler Alloc(uint entityId, MessageBase notify, Action<MessageBase> handler, bool isEntityAppear) => default; // 0x0000000182526230-0x0000000182526350
		// [XID] // 0x0000000189B75870-0x0000000189B75890
		public void Init(uint id, MessageBase notify, Action<MessageBase> handler, bool isEntityAppear) {} // 0x0000000182525FA0-0x00000001825260E0
		// [XID] // 0x0000000189B7CD10-0x0000000189B7CD30
		public override void Dispose() {} // 0x0000000182525EE0-0x0000000182525FA0
		// [XID] // 0x0000000189B84BB0-0x0000000189B84BD0
		public override void Handle(int i) {} // 0x00000001825260E0-0x00000001825261D0
		// [XID] // 0x0000000189B8B960-0x0000000189B8B980
		protected override void Dealloc() {} // 0x0000000182525E40-0x0000000182525EE0
		// [XID] // 0x0000000189B93150-0x0000000189B93170
		protected bool HandleActionAfterEntityReady(uint entityID, HandleActionContext context, bool isEntityAppear = false /* Metadata: 0x00AFF7B3 */) => default; // 0x0000000182526350-0x00000001825266A0
	}

	public class EntityPacketNotifyHandlerWithParam<T> : EntityPacketNotifyHandler // TypeDefIndex: 21405
	{
		// Fields
		private Action<MessageBase, T> _notifyHandler;
		protected T _notifyParam;

		// Constructors
		public EntityPacketNotifyHandlerWithParam() {}

		// Methods
		public static EntityPacketNotifyHandler Alloc(uint entityID, MessageBase notify, T param, Action<MessageBase, T> handler, bool isEntityAppear) => default;
		public void Init(uint entityID, MessageBase notify, T param, Action<MessageBase, T> handler, bool isEntityAppear) {}
		public override void Handle(int i) {}
		protected override void Dealloc() {}
	}

	// Constructors
	public BaseModule() {} // 0x0000000181F6B620-0x0000000181F6B760
	static BaseModule() {} // 0x0000000181F6B570-0x0000000181F6B620

	// Methods
	// [XID] // 0x0000000189AA6C40-0x0000000189AA6C60
	public static void InitModuleOnLevelInit() {} // 0x0000000181F69C30-0x0000000181F69DA0
	// [XID] // 0x0000000189AAE390-0x0000000189AAE3B0
	public static void ClearModuleOnLevelDestroy() {} // 0x0000000181F6AA80-0x0000000181F6AC20
	// [XID] // 0x0000000189AB5BE0-0x0000000189AB5C00
	public static void ClearModuleOnDisconnect() {} // 0x0000000181F6B010-0x0000000181F6B180
	// [XID] // 0x0000000189ABD670-0x0000000189ABD690
	public static void ClearModuleOnBackHome() {} // 0x0000000181F69DA0-0x0000000181F69F10
	// [XID] // 0x0000000189AC5110-0x0000000189AC5130
	public static void ClearModules() {} // 0x0000000181F69F10-0x0000000181F6A140
	// [XID] // 0x0000000189ACC640-0x0000000189ACC660
	protected virtual void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000181F6A1F0-0x0000000181F6A2A0
	// [XID] // 0x0000000189AD4370-0x0000000189AD4390
	protected virtual void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000181F6B180-0x0000000181F6B230
	// [XID] // 0x0000000189ADBCC0-0x0000000189ADBCE0
	public virtual bool OnPacket(Packet packet) => default; // 0x0000000181F6A140-0x0000000181F6A1F0
	// [XID] // 0x0000000189AE3690-0x0000000189AE36B0
	public virtual bool OnNotify(Notify ntf) => default; // 0x0000000181F6B230-0x0000000181F6B300
	protected void UpdateField<T>(bool isSpecified, ref T field, T newValue, Action<T, T> callback = null) {}
	protected void UpdateField<T>(ref T field, T newValue, Action<T, T> callback = null) {}
	// [IDTag] // 0x0000000189AEAF70-0x0000000189AEAFB0
	// [XID] // 0x0000000189AEAF70-0x0000000189AEAFB0
	protected List<int> ConvertList(List<uint> fromList) => default; // 0x0000000181F69A60-0x0000000181F69C30
	// [IDTag] // 0x0000000189AF5830-0x0000000189AF5870
	// [XID] // 0x0000000189AF5830-0x0000000189AF5870
	protected List<string> ConvertList(List<string> fromList) => default; // 0x0000000181F69890-0x0000000181F69A60
	// [XID] // 0x0000000189AFFF10-0x0000000189AFFF30
	protected virtual void OnRetCodeHandler(int retcode, string rspName, Action<string> handler = null) {} // 0x0000000181F6A2A0-0x0000000181F6A730
	// [XID] // 0x0000000189B074B0-0x0000000189B074D0
	public virtual void InitOnLevelInit() {} // 0x0000000181F6AF70-0x0000000181F6B010
	public abstract void ClearOnLevelDestroy();
	public abstract void ClearOnDisconnect();
	// [XID] // 0x0000000189B0EC70-0x0000000189B0EC90
	public virtual void ClearOnBackHome() {} // 0x0000000181F6A800-0x0000000181F6A8A0
	// [XID] // 0x0000000189B250A0-0x0000000189B250C0
	public static void InitModulePacketSliceFrameHandlerManager() {} // 0x0000000181F6B300-0x0000000181F6B570
	// [XID] // 0x0000000189B2C550-0x0000000189B2C570
	protected static void ClearModulePacketSliceFrameHandlerManager() {} // 0x0000000181F6A970-0x0000000181F6AA80
	protected void TryToHandleActionAfterEntityReady<T>(uint entityId, MessageBase notify, T param, Action<MessageBase, T> notifyHandler) {}
	// [XID] // 0x0000000189B33AA0-0x0000000189B33AC0
	protected void TryToHandleActionAfterEntityReady(uint entityId, MessageBase notify, Action<MessageBase> notifyHandler) {} // 0x0000000181F696F0-0x0000000181F69890
	// [XID] // 0x0000000189B3B370-0x0000000189B3B390
	protected bool HandleActionAfterEntityReady(uint entityID, HandleActionContext context, bool isEntityAppear = false /* Metadata: 0x00AFF7B2 */) => default; // 0x0000000181F6AC20-0x0000000181F6AF70
}

