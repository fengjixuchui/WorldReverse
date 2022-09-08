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

public class AudioSyncTicker // TypeDefIndex: 11507
{
	// Fields
	private const float ACTIVE_DISTANCE = 30f; // Metadata: 0x00AE992F
	private const float CONCERN_DISTANCE = 120f; // Metadata: 0x00AE9933
	private const float MIN_NEAR_MOVE_THRESHOLD = 0.1f; // Metadata: 0x00AE9937
	private const float MIN_REAR_MOVE_THRESHOLD = 3f; // Metadata: 0x00AE993B
	private const float SQR_ACTIVE_DISTANCE = 900f; // Metadata: 0x00AE993F
	private const float SQR_CONCERN_DISTANCE = 14400f; // Metadata: 0x00AE9943
	private const float SQR_MIN_NEAR_MOVE_THRESHOLD = 0.010000001f; // Metadata: 0x00AE9947
	private const float SQR_MIN_REAR_MOVE_THRESHOLD = 9f; // Metadata: 0x00AE994B
	private const int MAX_PROC_NEAR_PER_FRAME = 10; // Metadata: 0x00AE994F
	private const int MAX_PROC_REAR_PER_FRAME = 10; // Metadata: 0x00AE9953
	private const int CROWD_WARNING_THRESHOLD = 60; // Metadata: 0x00AE9957
	private const int CROWD_WARNING_INTERVAL = 90; // Metadata: 0x00AE995B
	private readonly CommandThreadContext _context; // 0x10
	private readonly RecycledLinkedList<AudioSync> _nearSyncs; // 0x18
	private readonly RecycledLinkedList<AudioSync> _rearSyncs; // 0x20
	private readonly List<RecycledLinkedList<AudioSync>> _engradeSyncs; // 0x28
	private readonly List<RecycledLinkedList<AudioSync>> _degradeSyncs; // 0x30
	private readonly Dictionary<int, RecycledLinkedList<AudioSync>> _nodeMap; // 0x38
	private readonly Dictionary<int, AudioSync> _staticMap; // 0x40
	private RecycledLinkedList<AudioSync> _lastUpdatedNearNode; // 0x48
	private RecycledLinkedList<AudioSync> _lastUpdatedRearNode; // 0x50
	private Vector3 _listenerPosition; // 0x58
	private int _crowdWarningIntervalTicker; // 0x64

	// Constructors
	public AudioSyncTicker() {} // Dummy constructor
	public AudioSyncTicker(CommandThreadContext context) {} // 0x0000000185067120-0x0000000185067290

	// Methods
	// [XID] // 0x0000000189B05350-0x0000000189B05370
	public void Add(SyncId syncId, Transform t, bool @static, bool enableOcc) {} // 0x0000000185065E00-0x0000000185066130
	// [XID] // 0x0000000189B00E60-0x0000000189B00E80
	public void Remove(SyncId syncId) {} // 0x0000000185065200-0x0000000185065340
	// [XID] // 0x0000000189B14040-0x0000000189B14060
	public int GetCount() => default; // 0x0000000185067040-0x0000000185067120
	// [XID] // 0x0000000189B1B8D0-0x0000000189B1B8F0
	public void ImpelTick(SyncId syncId) {} // 0x0000000185064540-0x0000000185064650
	// [XID] // 0x00000001897EFB40-0x00000001897EFB60
	public bool QueryIfOccEnabled(int instanceId, out Transform transform) {
		transform = default;
		return default;
	} // 0x00000001850643D0-0x0000000185064540
	// [XID] // 0x0000000189B2A4C0-0x0000000189B2A4E0
	public void Tick(float deltaTime) {} // 0x0000000185064850-0x0000000185064A10
	// [XID] // 0x0000000189B31A00-0x0000000189B31A20
	public void DestroyAll() {} // 0x0000000185066210-0x00000001850662F0
	// [XID] // 0x0000000189AC1720-0x0000000189AC1740
	private AudioSync AllocateSync(SyncId syncId, Transform t, bool @static, bool enableOcc) => default; // 0x0000000185066F00-0x0000000185067040
	// [XID] // 0x0000000189B1E7F0-0x0000000189B1E810
	private void DeallocateSync(AudioSync sync) {} // 0x0000000185065910-0x00000001850659E0
	// [XID] // 0x0000000189B482F0-0x0000000189B48310
	private void UpdateSyncProperties(AudioSync sync, bool @static, bool enableOcc) {} // 0x00000001850659E0-0x0000000185065AE0
	// [XID] // 0x0000000189AAA880-0x0000000189AAA8A0
	private void AddSyncToStaticMap(AudioSync sync, int instanceId) {} // 0x0000000185066130-0x0000000185066210
	// [XID] // 0x0000000189AB9B80-0x0000000189AB9BA0
	private void AddSyncToMobileList(AudioSync sync, int instanceId, Vector3 position) {} // 0x0000000185063F80-0x0000000185064180
	// [XID] // 0x0000000189B5EC80-0x0000000189B5ECA0
	private bool RemoveSyncFromStaticMap(SyncId syncId, out AudioSync sync) {
		sync = default;
		return default;
	} // 0x0000000185064180-0x00000001850642D0
	// [XID] // 0x0000000189648460-0x0000000189648480
	private bool RemoveSyncFromMobileList(SyncId syncId, out AudioSync sync) {
		sync = default;
		return default;
	} // 0x0000000185066B20-0x0000000185066DB0
	// [XID] // 0x0000000189AC8EC0-0x0000000189AC8EE0
	private void MoveStaticSyncToMobileList(AudioSync sync) {} // 0x0000000185065340-0x0000000185065490
	// [XID] // 0x0000000189B74E50-0x0000000189B74E70
	private void MoveMobileSyncToStaticMap(AudioSync sync) {} // 0x0000000185065490-0x00000001850655B0
	// [XID] // 0x0000000189B82900-0x0000000189B82920
	private bool ImpelTickStaticSync(SyncId syncId) => default; // 0x00000001850655B0-0x00000001850657E0
	// [XID] // 0x0000000189B89FE0-0x0000000189B8A000
	private bool ImpelTickMobileSync(SyncId syncId) => default; // 0x0000000185065AE0-0x0000000185065E00
	// [XID] // 0x0000000189B8AF40-0x0000000189B8AF60
	private void Terminate(AudioSync t) {} // 0x0000000185066A30-0x0000000185066B20
	// [XID] // 0x0000000189B926A0-0x0000000189B926C0
	private void TickUpdateNearSyncs(float listenerX, float listenerY, float listenerZ) {} // 0x0000000185064B80-0x0000000185065060
	// [XID] // 0x0000000189B99BC0-0x0000000189B99BE0
	private void TickUpdateRearSyncs(float listenerX, float listenerY, float listenerZ) {} // 0x00000001850662F0-0x00000001850667D0
	// [XID] // 0x0000000189BA12E0-0x0000000189BA1300
	private void TerminateAllSyncNodesInLink(RecycledLinkedList<AudioSync> syncLink) {} // 0x0000000185066DB0-0x0000000185066F00
	// [XID] // 0x0000000189BA88E0-0x0000000189BA8900
	private void TransgradeSyncNodes(List<RecycledLinkedList<AudioSync>> nodeList, RecycledLinkedList<AudioSync> srcLink, RecycledLinkedList<AudioSync> dstLink, ref RecycledLinkedList<AudioSync> srcLastNode) {} // 0x00000001850667D0-0x0000000185066930
	// [XID] // 0x0000000189BAFC00-0x0000000189BAFC20
	private void MoveSyncNodeBetweenLinks(RecycledLinkedList<AudioSync> node, RecycledLinkedList<AudioSync> srcLink, RecycledLinkedList<AudioSync> dstLink, ref RecycledLinkedList<AudioSync> srcLastNode) {} // 0x0000000185064650-0x0000000185064850
	// [XID] // 0x0000000189AD0620-0x0000000189AD0640
	private void RegisterSync(SyncId syncId) {} // 0x0000000185066930-0x0000000185066A30
	// [XID] // 0x0000000189BBE990-0x0000000189BBE9B0
	private void UnregisterSync(SyncId syncId) {} // 0x00000001850642D0-0x00000001850643D0
	// [XID] // 0x0000000189BC6650-0x0000000189BC6670
	private void UpdateSyncTransform(SyncId syncId, Vector3 position, Quaternion rotation) {} // 0x0000000185064A10-0x0000000185064B80
	// [Conditional] // 0x0000000189BCE2C0-0x0000000189BCE310
	// [XID] // 0x0000000189BCE2C0-0x0000000189BCE310
	private void PrintDuplicatedRegistrationWarning(SyncId syncId) {} // 0x00000001850657E0-0x0000000185065910
	// [Conditional] // 0x0000000189BD86A0-0x0000000189BD86F0
	// [XID] // 0x0000000189BD86A0-0x0000000189BD86F0
	private void PrintTooManyNearSyncWarningIfNecessary() {} // 0x0000000185065060-0x0000000185065200
}

