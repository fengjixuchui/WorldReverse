/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorkerThreadSpatialFunctionalities : WorkerThreadFunctionalities<SharedSpatialFunctionalities> // TypeDefIndex: 11422
{
	// Fields
	private const float NEAR_DISTANCE = 30f; // Metadata: 0x00AE9846
	private const float CONCERN_DISTANCE = 120f; // Metadata: 0x00AE984A
	private const float MIN_NEAR_MOVE_THRESHOLD = 0.1f; // Metadata: 0x00AE984E
	private const float MIN_REAR_MOVE_THRESHOLD = 3f; // Metadata: 0x00AE9852
	private const float SQR_NEAR_DISTANCE = 900f; // Metadata: 0x00AE9856
	private const float SQR_CONCERN_DISTANCE = 14400f; // Metadata: 0x00AE985A
	private const float SQR_MIN_NEAR_MOVE_THRESHOLD = 0.010000001f; // Metadata: 0x00AE985E
	private const float SQRT_MIN_REAR_MOVE_THRESHOLD = 9f; // Metadata: 0x00AE9862
	private readonly HashSet<ulong> _registeredEmitterSyncs; // 0x28
	private readonly Dictionary<ulong, RecycledLinkedList<SpatialEmitterSync>> _emitterSyncMap; // 0x30
	private readonly RecycledLinkedList<SpatialEmitterSync> _emitterList; // 0x38
	private readonly Dictionary<uint, ulong> _roomNameToSyncIdMap; // 0x40
	private readonly Dictionary<ulong, Room> _roomMap; // 0x48
	private readonly Dictionary<ulong, RoomTrigger> _roomTriggerMap; // 0x50
	private readonly RecycledLinkedList<Room> _roomList; // 0x58
	private readonly Dictionary<ulong, RecycledLinkedList<Room>> _roomListNodeMap; // 0x60
	private readonly List<Room> _waitRemoveRoomList; // 0x68
	private readonly Dictionary<ulong, RoomPortal> _portalMap; // 0x70
	private readonly Dictionary<uint, ulong> _portalNameToSyncIdMap; // 0x78
	private readonly RecycledLinkedList<RoomPortal> _portalList; // 0x80
	private readonly Dictionary<ulong, RecycledLinkedList<RoomPortal>> _portalListNodeMap; // 0x88
	private SyncId _listenerSyncId; // 0x90
	private Vector3 _listenerPosition; // 0xA8
	private ulong _listenerRoomId; // 0xB8
	private ulong _globalRoomId; // 0xC0
	private Room _globalRoom; // 0xC8
	private bool _isRoomAddedCurFrame; // 0xD0
	private bool _isRoomRemovedCurFrame; // 0xD1
	private bool _isGlobalRoomAddedCurFrame; // 0xD2
	private bool _isGlobalRoomRemovedCurFrame; // 0xD3
	private readonly Queue<SpatialEmitterSync> _waitUpdateEmittersQueue; // 0xD8
	private Room tempRoom; // 0xE0
	private SpatialEmitterSync tempEmitter; // 0xE8
	private RoomTrigger tempRoomTrigger; // 0xF0

	// Properties
	public bool enabled { /* [XID] */ /* 0x00000001899168E0-0x0000000189916920 */ get; /* [XID] */ /* 0x0000000189920F30-0x0000000189920F70 */ private set; } // 0x0000000182D8D340-0x0000000182D8D3A0 0x0000000182D8D8B0-0x0000000182D8D910

	// Constructors
	public WorkerThreadSpatialFunctionalities() {} // Dummy constructor
	public WorkerThreadSpatialFunctionalities(WorkerThreadContext context, SharedSpatialFunctionalities shared) {} // 0x0000000182D8E430-0x0000000182D8E760

	// Methods
	// [XID] // 0x0000000189612480-0x00000001896124A0
	public override void Init() {} // 0x0000000182D8B620-0x0000000182D8B6C0
	// [XID] // 0x0000000189619DF0-0x0000000189619E10
	public override void Tick(TimeSpan deltaTime) {} // 0x0000000182D8B6C0-0x0000000182D8B860
	// [XID] // 0x0000000189621270-0x0000000189621290
	private void TickPreProcessWaitRemoveRoom() {} // 0x0000000182D8A710-0x0000000182D8AB10
	// [XID] // 0x00000001899419D0-0x00000001899419F0
	private void TickMustUpdateEmitters() {} // 0x0000000182D8C7E0-0x0000000182D8CA90
	// [XID] // 0x00000001899494F0-0x0000000189949510
	private void MarkNeedUpdate(SpatialEmitterSync emitter) {} // 0x0000000182D8A300-0x0000000182D8A3E0
	// [XID] // 0x0000000189950D50-0x0000000189950D70
	private void TickListener() {} // 0x0000000182D8BE40-0x0000000182D8C1C0
	// [XID] // 0x0000000189958550-0x0000000189958570
	private void TickEmitters() {} // 0x0000000182D8D910-0x0000000182D8DB90
	// [XID] // 0x000000018995FBB0-0x000000018995FBD0
	private void TickPortals() {} // 0x0000000182D8CEA0-0x0000000182D8D080
	// [XID] // 0x00000001899674F0-0x0000000189967510
	private void ReCalculateEmitterBelongRoom(SpatialEmitterSync emitter) {} // 0x0000000182D8AD30-0x0000000182D8B0B0
	// [XID] // 0x00000001896A6C10-0x00000001896A6C30
	private void TickProcessWaitUpdateEmitters() {} // 0x0000000182D8CA90-0x0000000182D8CBB0
	// [XID] // 0x00000001896E7870-0x00000001896E7890
	private void TickProcessWaitRemoveRoom() {} // 0x0000000182D8B0B0-0x0000000182D8B340
	// [XID] // 0x000000018997D540-0x000000018997D560
	public override void Destroy() {} // 0x0000000182D8AB10-0x0000000182D8ABB0
	// [XID] // 0x0000000189985100-0x0000000189985120
	private SpatialEmitterSync AllocateEmitter(SyncId syncId) => default; // 0x0000000182D8A3E0-0x0000000182D8A4E0
	// [XID] // 0x000000018998CC60-0x000000018998CC80
	public void RegisterEmitter(SyncId syncId) {} // 0x0000000182D8B340-0x0000000182D8B620
	// [XID] // 0x0000000189994920-0x0000000189994940
	public void UnregisterEmitter(SyncId syncId) {} // 0x0000000182D89EE0-0x0000000182D8A0D0
	// [XID] // 0x000000018999C1D0-0x000000018999C1F0
	public void UpdateEmitterPosition(SyncId syncId, Vector3 pos) {} // 0x0000000182D8C4D0-0x0000000182D8C680
	// [XID] // 0x0000000189A00600-0x0000000189A00620
	public void RegisterListener(SyncId syncId) {} // 0x0000000182D8DE00-0x0000000182D8DF50
	// [XID] // 0x00000001899AB5F0-0x00000001899AB610
	public void UnregisterListener(SyncId syncId) {} // 0x0000000182D8ABB0-0x0000000182D8AD30
	// [XID] // 0x00000001899B2FB0-0x00000001899B2FD0
	public bool QueryIfSyncIsSpatialEmitter(SyncId syncId) => default; // 0x0000000182D89DF0-0x0000000182D89EE0
	// [XID] // 0x00000001896891E0-0x0000000189689200
	public void AddRoom(uint roomNameId, RoomParams roomParams) {} // 0x0000000182D8D3A0-0x0000000182D8D7D0
	// [XID] // 0x00000001899C1D00-0x00000001899C1D20
	public void RemoveRoom(uint roomNameId) {} // 0x0000000182D8C680-0x0000000182D8C7E0
	// [XID] // 0x00000001899C9100-0x00000001899C9120
	public void AddRoomBoxTrigger(uint roomNameId, Vector3 position, Quaternion rotation, Vector3 size) {} // 0x0000000182D8E080-0x0000000182D8E330
	// [XID] // 0x0000000189A89FA0-0x0000000189A89FC0
	public void AddRoomSphereTrigger(uint roomNameId, Vector3 position, float radius) {} // 0x0000000182D8A0D0-0x0000000182D8A300
	// [XID] // 0x00000001899D8030-0x00000001899D8050
	public void ClearAll() {} // 0x0000000182D8A4E0-0x0000000182D8A710
	// [XID] // 0x00000001899DF660-0x00000001899DF680
	private void SetGameObjectInRoom(ulong syncId, ulong roomId) {} // 0x0000000182D8E330-0x0000000182D8E430
	// [IDTag] // 0x00000001899E7150-0x00000001899E7190
	// [XID] // 0x00000001899E7150-0x00000001899E7190
	public void SetGlobalRoom(uint roomNameId, RoomParams roomParams) {} // 0x0000000182D8B9B0-0x0000000182D8BCF0
	// [IDTag] // 0x00000001899F1590-0x00000001899F15D0
	// [XID] // 0x00000001899F1590-0x00000001899F15D0
	public void SetGlobalRoom(uint busAuxName) {} // 0x0000000182D8BCF0-0x0000000182D8BE40
	// [XID] // 0x00000001896F7DD0-0x00000001896F7DF0
	private void SaveRoomParams(Room room) {} // 0x0000000182D8DF50-0x0000000182D8E080
	// [XID] // 0x0000000189A03570-0x0000000189A03590
	public void ClearGlobalRoom() {} // 0x0000000182D8CDB0-0x0000000182D8CEA0
	// [XID] // 0x0000000189A0ABB0-0x0000000189A0ABD0
	public void SetPortal(uint portalNameId, RoomPortalParams @params) {} // 0x0000000182D8C1C0-0x0000000182D8C4D0
	// [XID] // 0x0000000189A123C0-0x0000000189A123E0
	private bool ResetPortalLinkedRoom(RoomPortal portal) => default; // 0x0000000182D8CBB0-0x0000000182D8CDB0
	// [XID] // 0x0000000189A19810-0x0000000189A19830
	private void SavePortalParams(RoomPortal portal) {} // 0x0000000182D8D080-0x0000000182D8D1B0
	// [XID] // 0x0000000189A20E70-0x0000000189A20E90
	public void RemovePortal(uint portalNameId) {} // 0x0000000182D8DB90-0x0000000182D8DE00
	// [XID] // 0x0000000189848C20-0x0000000189848C40
	private void NotifySpatialEmitterRoomChange(SpatialEmitterSync emitter) {} // 0x0000000182D8D1B0-0x0000000182D8D340
	// [XID] // 0x0000000189A2F950-0x0000000189A2F970
	private void InitGlobalRoom() {} // 0x0000000182D8D7D0-0x0000000182D8D8B0
	// [XID] // 0x0000000189A37320-0x0000000189A37340
	public void SetEnabled(bool enable) {} // 0x0000000182D8B860-0x0000000182D8B9B0
}

