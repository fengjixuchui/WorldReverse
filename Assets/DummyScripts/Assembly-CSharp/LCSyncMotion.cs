/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using FullInspector;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCSyncMotion : LCBase // TypeDefIndex: 11770
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private MoveSyncTask[] _moveSyncTasks; // 0x130
	private CombatSyncTask[] _combatSyncTasks; // 0x138
	private int _taskNumInMoveQueue; // 0x144
	private int _taskNumInCombatQueue; // 0x148
	private const int SYNC_MOTION_TASK_CAPACITY = 50; // Metadata: 0x00AEA7E0
	private const float SYNC_FORCE_RESET_TIME_DELAY = 1.5f; // Metadata: 0x00AEA7E4
	private VCSyncAnimator _vcSyncAnimator; // 0x150
	private VCBaseMove _moveCom; // 0x158
	private bool _lastIsGroundMoveSyncTask; // 0x160
	private bool _hasFakeMoveSyncTask; // 0x161
	private bool _syncAnimatorTriggerSet; // 0x162
	private bool _needSetPosRotAfterStateChange; // 0x163
	private MoveSyncTask _lastMoveSyncTask; // 0x164
	private bool _forceSetPositionIceId; // 0x220
	private ulong _refuseSyncMotionTimeStamp; // 0x228
	private StringBuilder _queueLog; // 0x230
	private string MoveTaskLogFormat; // 0x238
	private string CombatTaskLogFormat; // 0x240

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898952C0-0x00000001898952E0 */ get => default; } // 0x0000000182606140-0x00000001826061E0 
	public int taskNumInQueue { /* [XID] */ /* 0x00000001898C9760-0x00000001898C97A0 */ get; /* [XID] */ /* 0x00000001898D3CD0-0x00000001898D3D10 */ private set; } // 0x0000000182604F50-0x0000000182604FB0 0x0000000182600AE0-0x0000000182600B50
	public uint latestMoveTaskTime { /* [XID] */ /* 0x00000001898DED50-0x00000001898DED90 */ get; /* [XID] */ /* 0x00000001898E9870-0x00000001898E98B0 */ private set; } // 0x0000000182600BC0-0x0000000182600C20 0x0000000182602410-0x0000000182602480

	// Constructors
	public LCSyncMotion() {} // 0x0000000182606040-0x0000000182606140

	// Methods
	// [XID] // 0x0000000189A5FB30-0x0000000189A5FB50
	public override void PreInit() {} // 0x0000000182605DA0-0x0000000182605E50
	// [XID] // 0x00000001898A4200-0x00000001898A4220
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000182605E50-0x0000000182606040
	// [XID] // 0x0000000189A49130-0x0000000189A49150
	public override void Init() {} // 0x0000000182602680-0x0000000182602740
	// [XID] // 0x0000000189A57EC0-0x0000000189A57EE0
	public void HandleSyncTasksInQueueAfterAnimatorEvent(float inDeltaTime) {} // 0x00000001826010D0-0x0000000182601370
	// [XID] // 0x00000001898BAB80-0x00000001898BABA0
	public void ChangeAuthority() {} // 0x0000000182604290-0x00000001826043F0
	// [XID] // 0x00000001898C1D90-0x00000001898C1DB0
	public void FlushAndRefreshRefuseSyncTimer() {} // 0x00000001826014C0-0x00000001826015C0
	// [XID] // 0x00000001898F3D40-0x00000001898F3D60
	public void ResetSyncTaskWithReliableSeq(uint reliableSeq, DualClientSequenceId clientSequenceId) {} // 0x0000000182600C20-0x0000000182600D90
	// [IDTag] // 0x00000001898FB270-0x00000001898FB2B0
	// [XID] // 0x00000001898FB270-0x00000001898FB2B0
	public void AddSyncTask(MoveSyncTask syncTask) {} // 0x0000000182604FB0-0x0000000182605590
	// [IDTag] // 0x0000000189905DC0-0x0000000189905E00
	// [XID] // 0x0000000189905DC0-0x0000000189905E00
	public void AddSyncTask(CombatSyncTask syncTask) {} // 0x0000000182605590-0x0000000182605B20
	// [IDTag] // 0x00000001899103F0-0x0000000189910430
	// [XID] // 0x00000001899103F0-0x0000000189910430
	private void DoAddSyncTask(MoveSyncTask syncTask) {} // 0x0000000182601970-0x00000001826020A0
	// [IDTag] // 0x000000018991B180-0x000000018991B1C0
	// [XID] // 0x000000018991B180-0x000000018991B1C0
	private void DoAddSyncTask(CombatSyncTask syncTask) {} // 0x00000001826020A0-0x0000000182602410
	// [XID] // 0x0000000189925980-0x00000001899259A0
	private void HandleSyncTasksInQueue(float inDeltaTime) {} // 0x0000000182605B20-0x0000000182605DA0
	// [XID] // 0x000000018992CE50-0x000000018992CE70
	public void FlushAllSyncTasks(DualClientSequenceId beforeClientSequenceId) {} // 0x0000000182604450-0x0000000182604770
	// [XID] // 0x0000000189934300-0x0000000189934320
	private int GetEarliestSyncTaskIndex(out bool isMove) {
		isMove = default;
		return default;
	} // 0x00000001826015C0-0x0000000182601970
	// [XID] // 0x0000000189B43C70-0x0000000189B43C90
	private bool TryHandleMoveSyncTask(ref MoveSyncTask syncTask) => default; // 0x0000000182602740-0x0000000182602A10
	// [XID] // 0x0000000189943410-0x0000000189943430
	public bool GetNextMoveSyncOrder(ref MoveSyncTask moveTask) => default; // 0x0000000182602CA0-0x0000000182603390
	// [XID] // 0x000000018994AB20-0x000000018994AB40
	public int PeekNextMoveSyncOrder(ref MoveSyncTask moveTask) => default; // 0x0000000182600160-0x0000000182600440
	// [XID] // 0x0000000189952530-0x0000000189952550
	private bool CanHandleMoveMessage() => default; // 0x0000000182604770-0x0000000182604920
	// [XID] // 0x00000001899599B0-0x00000001899599D0
	private bool CheckMoveSyncTaskStacking(ref MoveSyncTask syncTask, float deltaTimeThreshold) => default; // 0x0000000182604B40-0x0000000182604F50
	// [XID] // 0x00000001899612F0-0x0000000189961310
	private int GetEarliestMoveSyncTaskIndex() => default; // 0x0000000182602A10-0x0000000182602CA0
	// [XID] // 0x00000001899689B0-0x00000001899689D0
	private bool DoHandleCombatSyncTask(ref CombatSyncTask combatSyncTask, bool forceHandleImmediately = false /* Metadata: 0x00AEA7DB */, float inDeltaTime = 0f /* Metadata: 0x00AEA7DC */) => default; // 0x0000000182603390-0x0000000182604290
	// [XID] // 0x000000018996FFA0-0x000000018996FFC0
	private bool CheckCombatForceSetPosInfoColliderReady(EvtCombatForceSetPosInfo message) => default; // 0x0000000182602480-0x0000000182602680
	// [XID] // 0x0000000189977E00-0x0000000189977E20
	private void FlushAndHandleSyncTasksInQueue(DualClientSequenceId clientSequenceId) {} // 0x0000000182600D90-0x00000001826010D0
	// [XID] // 0x000000018997EFB0-0x000000018997EFD0
	private bool CanHandleBeingHitMessage() => default; // 0x0000000182601370-0x00000001826014C0
	// [XID] // 0x000000018982CCF0-0x000000018982CD10
	private bool CanHandleFaceTurnMessage() => default; // 0x0000000182604920-0x0000000182604AD0
	// [XID] // 0x000000018998E490-0x000000018998E4B0
	private void LogQueue(string info) {} // 0x0000000182600440-0x0000000182600AE0
}

