/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class LoadingTask : IAutoAllocRecycle // TypeDefIndex: 20210
{
	// Fields
	private LoadState _loadState; // 0x10
	public LoadType loadType; // 0x14
	public uint token; // 0x18
	public uint sceneID; // 0x1C
	public uint dungeonId; // 0x20
	public Vector3 initPos; // 0x24
	public bool isLoadNewScene; // 0x30
	public bool isFirstEnterScene; // 0x31
	public bool isReLogin; // 0x32
	public uint tryToEnterSceneID; // 0x34
	public ulong loginTimeStamp; // 0x38
	private Coroutine _timeOutCoroutine; // 0x40
	public static float loginTaskCheckRatio; // 0x00
	private static Dictionary<int, int> stateCheckTimer; // 0x08

	// Properties
	public LoadState loadState { /* [XID] */ /* 0x00000001896B2470-0x00000001896B2490 */ get => default; /* [XID] */ /* 0x000000018988DC50-0x000000018988DC70 */ set {} } // 0x00000001831BD810-0x00000001831BD8B0 0x00000001831BDBC0-0x00000001831BDC80

	// Nested types
	public enum LoadType // TypeDefIndex: 20211
	{
		Invalid = 0,
		Scene = 1,
		Dungeon = 2,
		Goto = 3
	}

	public enum LoadState // TypeDefIndex: 20212
	{
		Invalid = 0,
		Queuing = 1,
		EnterScene = 2,
		ShowLoadingPage = 3,
		WaitingPeerID = 4,
		SceneReady = 5,
		InitScene = 6,
		LoadStage = 7,
		SceneInitFinish = 8,
		SceneDone = 9,
		LoginFinish = 10
	}

	// Constructors
	public LoadingTask() {} // 0x00000001831BEFD0-0x00000001831BF030
	static LoadingTask() {} // 0x00000001831BEE80-0x00000001831BEFD0

	// Methods
	[BlackList] // 0x0000000189620600-0x0000000189620640
	// [XID] // 0x0000000189620600-0x0000000189620640
	public virtual void AutoAllocTypeFields() {} // 0x00000001831BD560-0x00000001831BD600
	[BlackList] // 0x000000018962ABC0-0x000000018962AC00
	// [XID] // 0x000000018962ABC0-0x000000018962AC00
	public virtual void AutoRecycleTypeFields() {} // 0x00000001831BD600-0x00000001831BD6D0
	[BlackList] // 0x00000001896358D0-0x0000000189635910
	// [XID] // 0x00000001896358D0-0x0000000189635910
	public virtual void ReturnToObjectPool() {} // 0x00000001831BEDE0-0x00000001831BEE80
	// [XID] // 0x000000018964EBC0-0x000000018964EBE0
	public void OnPoolAllocated() {} // 0x00000001831BE730-0x00000001831BE7F0
	// [XID] // 0x0000000189656430-0x0000000189656450
	public void OnBeforePoolRecycled() {} // 0x00000001831BE640-0x00000001831BE730
	// [XID] // 0x0000000189895320-0x0000000189895340
	public void RunTimeOutChecker() {} // 0x00000001831BD950-0x00000001831BDBC0
	// [XID] // 0x00000001898A4280-0x00000001898A42A0
	private void ForceGoBackInLogin() {} // 0x00000001831BDC80-0x00000001831BE0B0
	// [XID] // 0x0000000189A448F0-0x0000000189A44910
	private void ReportCurLevel() {} // 0x00000001831BE0B0-0x00000001831BE550
	// [XID] // 0x0000000189674770-0x0000000189674790
	private void ReportLoginTask() {} // 0x00000001831BD6D0-0x00000001831BD810
	// [XID] // 0x000000018967C0A0-0x000000018967C0C0
	public string ReportLog() => default; // 0x00000001831BE7F0-0x00000001831BEDE0
	// [XID] // 0x0000000189683650-0x0000000189683670
	public void ClearCoroutine() {} // 0x00000001831BE550-0x00000001831BE640
}

