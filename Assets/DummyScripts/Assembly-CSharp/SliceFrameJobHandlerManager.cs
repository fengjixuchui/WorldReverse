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

public class SliceFrameJobHandlerManager // TypeDefIndex: 21663
{
	// Fields
	private PriorityQueue[] _priorityQueue; // 0x10
	private int _sharedWatcher; // 0x18
	public bool OnNeedForceSyncHandleAllPacket; // 0x1C

	// Properties
	public virtual bool shouldSyncHandle { /* [XID] */ /* 0x00000001897C9140-0x00000001897C9160 */ get => default; } // 0x000000018204D030-0x000000018204D110 

	// Nested types
	private class PriorityQueue // TypeDefIndex: 21664
	{
		// Fields
		private Queue<ISliceFrameJobHandler> packetHandlers; // 0x10
		protected Dictionary<System.Type, Func<object, ISliceFrameJobHandler>> _handlerCreator; // 0x18
		private int totalHandleCount; // 0x20
		private Dictionary<uint, DoublyList<ISliceFrameJobHandler>> packetHandlersDict; // 0x28
		private List<uint> entityPacketQueue; // 0x30

		// Constructors
		public PriorityQueue() {} // 0x0000000182038F50-0x0000000182039050

		// Methods
		// [XID] // 0x00000001897E6D70-0x00000001897E6D90
		public ISliceFrameJobHandler CreateHandleByType(object inPacket) => default; // 0x0000000182037E00-0x0000000182037F20
		// [XID] // 0x00000001897EEA40-0x00000001897EEA60
		public void RegisterCreateor(System.Type inType, Func<object, ISliceFrameJobHandler> inCreator) {} // 0x0000000182037D20-0x0000000182037E00
		// [XID] // 0x00000001897F61C0-0x00000001897F61E0
		public bool IsEmpty() => default; // 0x00000001820386A0-0x0000000182038780
		// [XID] // 0x00000001897FD800-0x00000001897FD820
		public int Count() => default; // 0x00000001820381C0-0x0000000182038260
		// [XID] // 0x0000000189805010-0x0000000189805030
		public void ClearAllJobs() {} // 0x0000000182038D50-0x0000000182038F50
		// [XID] // 0x000000018980C530-0x000000018980C550
		public void InternalHandlFirstPacket() {} // 0x0000000182038260-0x0000000182038350
		// [XID] // 0x0000000189813CC0-0x0000000189813CE0
		private void OriginalInternalHandlFirstPacket() {} // 0x0000000182037B20-0x0000000182037D20
		// [XID] // 0x000000018981B840-0x000000018981B860
		private void InternalHandlFirstEntityPacket() {} // 0x0000000182038780-0x0000000182038A40
		// [XID] // 0x0000000189822DD0-0x0000000189822DF0
		private void OldInternalHandlFirstEntityPacket() {} // 0x0000000182038A40-0x0000000182038D50
		// [IDTag] // 0x000000018982A730-0x000000018982A770
		// [XID] // 0x000000018982A730-0x000000018982A770
		public bool RegisterPacket(object inPacket) => default; // 0x0000000182038530-0x00000001820386A0
		// [IDTag] // 0x0000000189834BB0-0x0000000189834BF0
		// [XID] // 0x0000000189834BB0-0x0000000189834BF0
		public bool RegisterPacket(uint entityId, MessageBase notify, Action<MessageBase> notifyHandler, bool isEntityAppear) => default; // 0x0000000182038350-0x0000000182038530
		public bool RegisterPacket<T>(uint entityId, MessageBase notify, T param, Action<MessageBase, T> notifyHandler, bool isEntityAppear) => default;
		// [XID] // 0x000000018983F210-0x000000018983F230
		public void ClearAllEntityJobs() {} // 0x0000000182037F20-0x00000001820381C0
	}

	// Constructors
	public SliceFrameJobHandlerManager() {} // Dummy constructor
	public SliceFrameJobHandlerManager(int priorityCount) {} // 0x000000018204D220-0x000000018204D340

	// Methods
	// [XID] // 0x000000018977E880-0x000000018977E8A0
	public bool IsEmpty() => default; // 0x000000018204CC70-0x000000018204CD90
	// [XID] // 0x0000000189786040-0x0000000189786060
	public int Count() => default; // 0x000000018204C6A0-0x000000018204C7C0
	// [XID] // 0x000000018978D6F0-0x000000018978D710
	public int SetInternalThreshold(float inMSThreshold, string name) => default; // 0x000000018204C050-0x000000018204C190
	// [XID] // 0x0000000189794B40-0x0000000189794B60
	public void Destroy() {} // 0x000000018204BF80-0x000000018204C050
	// [XID] // 0x000000018979D0B0-0x000000018979D0D0
	public void RegisterCreator(int priority, System.Type inType, Func<object, ISliceFrameJobHandler> inCreator) {} // 0x000000018204CF20-0x000000018204D030
	// [IDTag] // 0x00000001897A4390-0x00000001897A43D0
	// [XID] // 0x00000001897A4390-0x00000001897A43D0
	public void RegisterPacket(object inPacket) {} // 0x000000018204CA90-0x000000018204CC70
	// [XID] // 0x00000001897AEE90-0x00000001897AEEB0
	private uint GetPriorityByEntityID(uint entityId) => default; // 0x000000018204C190-0x000000018204C3A0
	// [IDTag] // 0x00000001897B6BC0-0x00000001897B6C00
	// [XID] // 0x00000001897B6BC0-0x00000001897B6C00
	public void RegisterPacket(uint entityId, MessageBase notify, Action<MessageBase> notifyHandler, bool isEntityAppear) {} // 0x000000018204C920-0x000000018204CA90
	public void RegisterPacket<T>(uint entityId, MessageBase notify, T param, Action<MessageBase, T> notifyHandler, bool isEntityAppear) {}
	// [XID] // 0x00000001897C16C0-0x00000001897C16E0
	public virtual void ClearAllJobs() {} // 0x000000018204D110-0x000000018204D220
	// [XID] // 0x00000001897D0730-0x00000001897D0750
	private void InternalHandlFirstPacket() {} // 0x000000018204C7C0-0x000000018204C920
	// [XID] // 0x00000001897D8460-0x00000001897D8480
	private void InternalHandlePacket(SliceFrameWatch sfWatch) {} // 0x000000018204CD90-0x000000018204CF20
	// [XID] // 0x00000001897DF510-0x00000001897DF530
	public virtual void AmortizedHandlePacket() {} // 0x000000018204C3A0-0x000000018204C6A0
}

