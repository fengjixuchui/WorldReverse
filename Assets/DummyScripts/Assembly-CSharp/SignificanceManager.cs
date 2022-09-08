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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SignificanceManager : InLevelManager // TypeDefIndex: 21288
{
	// Fields
	public const int PRIORITY_CRITICAL = 0; // Metadata: 0x00AFF3FE
	public const int PRIORITY_HIGH = 1; // Metadata: 0x00AFF402
	public const int PRIORITY_MED = 2; // Metadata: 0x00AFF406
	public const int PRIORITY_LOW = 3; // Metadata: 0x00AFF40A
	public const int PRIORITY_HIDDEN = 4; // Metadata: 0x00AFF40E
	public const int PRIORITY_TOTAL = 5; // Metadata: 0x00AFF412
	private int[] _significanceLevelScore; // 0x10
	private LinkedList<ManagedObjectInfo> managedObjects; // 0x18
	private Camera _playerCamera; // 0x20
	private TickModuleHistoryCollector tmhc; // 0x30
	public static bool bJobType; // 0x00
	private ThreadTask_SignificanceManager _threadTask; // 0x48
	private SignificanceTask _significanceTask; // 0x50
	private SignificanceTickLODTask _significanceTaskLOD; // 0x58

	// Properties
	public Camera playerCamera { /* [XID] */ /* 0x0000000189BC2E30-0x0000000189BC2E50 */ set {} } // 0x0000000182F785E0-0x0000000182F78690
	public TickObjectProxyLODManagerEntity balanceTickGroupComputeThread { /* [XID] */ /* 0x0000000189BCA570-0x0000000189BCA5B0 */ get; /* [XID] */ /* 0x0000000189BD4970-0x0000000189BD49B0 */ private set; } // 0x0000000182F78580-0x0000000182F785E0 0x0000000182F793E0-0x0000000182F79440

	// Nested types
	public interface ISignificanceManagedObject // TypeDefIndex: 21289
	{
		// Methods
		void CacheFrameDataUnityThread();
		int GetSignificanceScore(Vector3 mainCamerPos);
		void OnSignificanceLevelChanged(int newLevel);
	}

	private class ManagedObjectInfo // TypeDefIndex: 21290
	{
		// Fields
		public ISignificanceManagedObject obj; // 0x10
		public int significanceLevel; // 0x18

		// Constructors
		public ManagedObjectInfo() {} // Dummy constructor
		public ManagedObjectInfo(ISignificanceManagedObject inObj) {} // 0x0000000182F68D30-0x0000000182F68DB0
	}

	// Constructors
	public SignificanceManager() {} // 0x0000000182F79DD0-0x0000000182F79E90
	static SignificanceManager() {} // 0x0000000182F79D70-0x0000000182F79DD0

	// Methods
	// [XID] // 0x0000000189BDF3C0-0x0000000189BDF3E0
	public override void Init() {} // 0x0000000182F78C80-0x0000000182F78E70
	// [XID] // 0x00000001895EBF90-0x00000001895EBFB0
	private int GetSignificanceLevelByScore(int inScore) => default; // 0x0000000182F79560-0x0000000182F79670
	// [XID] // 0x00000001895F3390-0x00000001895F33B0
	public void RegisterManagedObject(ISignificanceManagedObject inMO) {} // 0x0000000182F78F40-0x0000000182F79100
	// [XID] // 0x00000001895FACB0-0x00000001895FACD0
	public void UnRegisterManagedObject(ISignificanceManagedObject inMO) {} // 0x0000000182F78990-0x0000000182F78B30
	// [XID] // 0x00000001896025C0-0x00000001896025E0
	public static int DefaultGetSMOSignificanceScore(Vector3 cameraPos, Vector3 smoPos) => default; // 0x0000000182F79100-0x0000000182F792C0
	// [XID] // 0x0000000189609E30-0x0000000189609E50
	public override void Tick() {} // 0x0000000182F79940-0x0000000182F79D70
	// [XID] // 0x0000000189611660-0x0000000189611680
	private void Flush() {} // 0x0000000182F78E70-0x0000000182F78F40
	// [XID] // 0x0000000189618F60-0x0000000189618F80
	public override void Destroy() {} // 0x0000000182F78690-0x0000000182F78730
	// [XID] // 0x00000001896204A0-0x00000001896204C0
	public void StartDumpTMMMALog() {} // 0x0000000182F79440-0x0000000182F79560
	// [XID] // 0x0000000189627950-0x0000000189627970
	private void OnProfilerFrameTick(List<CycleStatLogNode> inCycleStatLog) {} // 0x0000000182F792C0-0x0000000182F793E0
	// [XID] // 0x000000018962F350-0x000000018962F370
	private void CreateComputeThreadTask() {} // 0x0000000182F78790-0x0000000182F78990
	// [XID] // 0x0000000189636E20-0x0000000189636E40
	private void DestroyComputeThreadTask() {} // 0x0000000182F78B30-0x0000000182F78C80
	// [XID] // 0x000000018963E300-0x000000018963E320
	public void SimulateBuildTickListWhenJobThreadIsNotReady() {} // 0x0000000182F79670-0x0000000182F79940
}

