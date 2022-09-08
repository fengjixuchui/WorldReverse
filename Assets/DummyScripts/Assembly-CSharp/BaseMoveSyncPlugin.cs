/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BaseMoveSyncPlugin : BaseComponentPlugin // TypeDefIndex: 12037
{
	// Fields
	protected MotionInfo[] _motion; // 0x58
	protected MoveSyncTask _syncTask; // 0x60
	private MotionState _prevMotionState; // 0x11C
	private VCBaseMove _ownerMove; // 0x120
	private static BitArray _forceReliabeMotionStates; // 0x00
	private static Dictionary<int, float> _intervalConfigLod0; // 0x08
	private static Dictionary<int, float> _intervalConfigLod1; // 0x10
	private static Dictionary<int, float> _intervalConfigLod2; // 0x18
	private static float _intervalConfigLod0Default; // 0x20
	private static float _intervalConfigLod1Default; // 0x24
	private static float _intervalConfigLod2Default; // 0x28
	private uint _lod; // 0x128
	private float _lastSendSyncTaskTime; // 0x12C
	private MoveSyncTask _lastSendMoveSyncTask; // 0x130
	private float _intervalTime; // 0x1EC
	private bool _canIgnoreTickSync; // 0x1F0
	private bool _reliableSendWhenSameComparablePart; // 0x1F1
	private float _reliableSendWhenSameComparablePartTime; // 0x1F4
	private const float FORCE_SEND_PAC_INTERVAL = 5f; // Metadata: 0x00AEB382
	private const int DEFAULT_SYNC_SEQ_INTERVAL = 100; // Metadata: 0x00AEB386
	protected uint _lastSendReliabledPacketSeq; // 0x1F8
	private LCSyncMotion _lcSyncMotion; // 0x200
	private bool _hasInitializedSyncMove; // 0x208
	private ulong _lastHandledTaskTimeStamp; // 0x210
	private uint _lastHandledReliableTaskSeq; // 0x218
	private MoveSyncTask tempPeekGetMoveSyncTask; // 0x21C
	private BaseEntity _syncTestEntity; // 0x2D8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899FC040-0x00000001899FC060 */ get => default; } // 0x0000000182B94F20-0x0000000182B94FC0 
	private bool needSync { /* [XID] */ /* 0x00000001896AB120-0x00000001896AB140 */ get => default; } // 0x0000000182B94690-0x0000000182B947D0 
	public bool hasInitializedSyncMove { /* [XID] */ /* 0x0000000189AA78D0-0x0000000189AA78F0 */ get => default; } // 0x0000000182B8FCB0-0x0000000182B8FD60 
	public int taskNumInQueue { /* [XID] */ /* 0x0000000189AE4540-0x0000000189AE4560 */ get => default; } // 0x0000000182B945E0-0x0000000182B94690 
	public uint latestMoveTaskTime { /* [XID] */ /* 0x0000000189AEBCB0-0x0000000189AEBCD0 */ get => default; } // 0x0000000182B8FE60-0x0000000182B8FF10 
	private uint _syncTestEntityID { /* [XID] */ /* 0x0000000189AFAF40-0x0000000189AFAF60 */ get => default; } // 0x0000000182B8FD60-0x0000000182B8FE60 

	// Constructors
	public BaseMoveSyncPlugin() {} // 0x0000000182B949B0-0x0000000182B94F20

	// Methods
	// [XID] // 0x0000000189A03450-0x0000000189A03470
	public override void Destroy() {} // 0x0000000182B90C70-0x0000000182B90D40
	// [XID] // 0x0000000189A0AAF0-0x0000000189A0AB10
	public override void Init() {} // 0x0000000182B92A70-0x0000000182B92C10
	// [XID] // 0x0000000189A12260-0x0000000189A12280
	public override void OnEnable() {} // 0x0000000182B94870-0x0000000182B94910
	// [XID] // 0x0000000189A19710-0x0000000189A19730
	public override void OnDisable() {} // 0x0000000182B947D0-0x0000000182B94870
	// [XID] // 0x0000000189A20D90-0x0000000189A20DB0
	public override void LateTick(float inDeltaTime) {} // 0x0000000182B937E0-0x0000000182B93890
	// [XID] // 0x0000000189A280C0-0x0000000189A280E0
	public void SetLodLevel(uint lod) {} // 0x0000000182B929B0-0x0000000182B92A70
	// [XID] // 0x00000001897C7290-0x00000001897C72B0
	private void RefreshSyncInterval() {} // 0x0000000182B91E40-0x0000000182B92010
	// [XID] // 0x0000000189A3E8F0-0x0000000189A3E910
	private void InitSyncInterval() {} // 0x0000000182B902C0-0x0000000182B90C70
	// [XID] // 0x0000000189A45FE0-0x0000000189A46000
	private void RefreshMonsterSync() {} // 0x0000000182B91CE0-0x0000000182B91E40
	// [XID] // 0x0000000189A4D6F0-0x0000000189A4D710
	protected void UpdateAuthorityMode() {} // 0x0000000182B90DA0-0x0000000182B90FB0
	// [XID] // 0x0000000189A54F90-0x0000000189A54FB0
	private void ResetAuthorityMode() {} // 0x0000000182B94910-0x0000000182B949B0
	// [XID] // 0x0000000189A5C8A0-0x0000000189A5C8C0
	private static void AddReliableMotionState(MotionState motionState) {} // 0x0000000182B93890-0x0000000182B93950
	// [XID] // 0x0000000189A64170-0x0000000189A64190
	private static bool ForceReliableWhenChangeState(MotionState motionState) => default; // 0x0000000182B92650-0x0000000182B92840
	// [XID] // 0x0000000189A6BB20-0x0000000189A6BB40
	public void CreateSyncTask(MotionState motionState, bool reliable, Vector3? param0 = default, Vector3? param1 = default, Vector3? param2 = default, Vector3? param3 = default, bool useCurrentPlatformTime = false /* Metadata: 0x00AEB380 */, bool useLateTickStartPosition = false /* Metadata: 0x00AEB381 */, Vector3? overridePosition = default) {} // 0x0000000182B91610-0x0000000182B91CE0
	// [XID] // 0x0000000189A732E0-0x0000000189A73300
	protected virtual void SetSyncTaskRefferenceSystem(VCBaseMove ownerMove, bool useCurrentPlatformTime) {} // 0x0000000182B93720-0x0000000182B937E0
	// [XID] // 0x0000000189A7ADD0-0x0000000189A7ADF0
	protected virtual void ConvertSyncTaskRefferenceSystemToMotionInfo(int paramNum) {} // 0x0000000182B94530-0x0000000182B945E0
	// [XID] // 0x0000000189A82360-0x0000000189A82380
	protected virtual void ConvertMotionInfoToSyncTaskRefferenceSystem(MotionInfo motion) {} // 0x0000000182B91180-0x0000000182B91230
	// [XID] // 0x0000000189A89C80-0x0000000189A89CA0
	private void ConvertSyncTaskToMotionInfo() {} // 0x0000000182B920C0-0x0000000182B92650
	// [XID] // 0x0000000189702380-0x00000001897023A0
	private void SetMotionParams(int paramNum, int index, Vector3 value) {} // 0x0000000182B91230-0x0000000182B914A0
	// [XID] // 0x0000000189A98F50-0x0000000189A98F70
	private void RequestDoCharacterMove() {} // 0x0000000182B90FB0-0x0000000182B91180
	// [XID] // 0x0000000189AA00E0-0x0000000189AA0100
	private bool HasSyncMotion() => default; // 0x0000000182B94440-0x0000000182B94530
	// [XID] // 0x0000000189AAF110-0x0000000189AAF130
	public void ProcessMotion(MotionInfo motion, uint time, bool isReliable, uint reliableSeq, DualClientSequenceId clientSequenceId) {} // 0x0000000182B92CF0-0x0000000182B93440
	// [XID] // 0x0000000189AB69D0-0x0000000189AB69F0
	public void TryInitialSyncMove(ref MoveSyncTask syncTask) {} // 0x0000000182B94340-0x0000000182B94440
	// [XID] // 0x0000000189ABE4A0-0x0000000189ABE4C0
	private void ConvertMotionInfoToSyncTask(MotionInfo motion, uint time, uint reliableSeq, bool isReliable, DualClientSequenceId clientSequenceId) {} // 0x0000000182B939C0-0x0000000182B94340
	// [XID] // 0x0000000189AC6010-0x0000000189AC6030
	private MotionState TranslateFromIceMotion(MotionState motion) => default; // 0x0000000182B92C10-0x0000000182B92CF0
	// [XID] // 0x0000000189ACD580-0x0000000189ACD5A0
	public bool GetNextSyncOrder(ref MoveSyncTask task) => default; // 0x0000000182B8FF10-0x0000000182B901E0
	// [XID] // 0x0000000189AD5360-0x0000000189AD5380
	public void SetLastReliableSeq(uint reliableSeq) {} // 0x0000000182B92010-0x0000000182B920C0
	// [XID] // 0x00000001899A8600-0x00000001899A8620
	public void SetLastTime(uint time) {} // 0x0000000182B8FBA0-0x0000000182B8FC50
	// [XID] // 0x0000000189764940-0x0000000189764960
	public bool PeekNextSyncOrder(out MotionState motion, out Vector3 position) {
		motion = default;
		position = default;
		return default;
	} // 0x0000000182B92840-0x0000000182B929B0
	// [XID] // 0x0000000189B02520-0x0000000189B02540
	private bool HasLocalSyncTest() => default; // 0x0000000182B914A0-0x0000000182B91610
	// [XID] // 0x0000000189B09B00-0x0000000189B09B20
	private void TrySendLocalSyncTask() {} // 0x0000000182B934A0-0x0000000182B93720
}

