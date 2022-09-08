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
using UnityEngine.Scripting;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LoadingManager : GlobalManager // TypeDefIndex: 21029
{
	// Fields
	private Dictionary<uint, LoadingTask> _loadingTasks; // 0x10
	private LoadingTask _curLoadingTask; // 0x18
	private LoadingTask _lastLoadingTask; // 0x20
	private BornTask _bornTask; // 0x28
	private Coroutine _bornCoroutine; // 0x30
	private Action<ILuaActor> _transPreCallback; // 0x38
	private Action<ILuaActor> _transFinishCallback; // 0x40
	private ILuaActor _curActor; // 0x48
	private Vector3 _cacheJumpPos; // 0x50
	private EnterType _cacheEnterType; // 0x5C
	private uint _cacheToken; // 0x60
	private bool _cacheIsSkipUI; // 0x64
	private bool _isPlayerTransStart; // 0x65
	private Coroutine _delayTransmitInCSCoroutine; // 0x68

	// Properties
	public bool isPlayerTransStarted { /* [XID] */ /* 0x0000000189B1AAC0-0x0000000189B1AAE0 */ get => default; } // 0x0000000181D9B950-0x0000000181D9B9F0 

	// Constructors
	public LoadingManager() {} // 0x0000000181D9DA20-0x0000000181D9DAD0

	// Methods
	// [XID] // 0x00000001896AB2B0-0x00000001896AB2D0
	public bool IsLoaded() => default; // 0x0000000181D9BEF0-0x0000000181D9BFB0
	// [XID] // 0x00000001899FB430-0x00000001899FB450
	public LoadingTask GetCurLoadingTask() => default; // 0x0000000181D9B810-0x0000000181D9B950
	// [XID] // 0x0000000189A02690-0x0000000189A026B0
	public LoadingTask GetLastLoadingTask() => default; // 0x0000000181D966F0-0x0000000181D96790
	// [XID] // 0x0000000189A09E60-0x0000000189A09E80
	public BornTask GetBornTask() => default; // 0x0000000181D99980-0x0000000181D99A20
	// [XID] // 0x0000000189A116C0-0x0000000189A116E0
	public LoadingTask GetLoadingTask(uint token, bool forceCreate = false /* Metadata: 0x00AFED2A */) => default; // 0x0000000181D995B0-0x0000000181D99980
	// [XID] // 0x0000000189A18A30-0x0000000189A18A50
	public override void ClearOnLevelDestroy() {} // 0x0000000181D96D70-0x0000000181D96E10
	// [XID] // 0x0000000189A200F0-0x0000000189A20110
	public override void Destroy() {} // 0x0000000181D97980-0x0000000181D97A20
	// [XID] // 0x0000000189A27460-0x0000000189A27480
	public override void Init() {} // 0x0000000181D9A6E0-0x0000000181D9A780
	// [XID] // 0x0000000189A2ECA0-0x0000000189A2ECC0
	public override void ReloadRes() {} // 0x0000000181D9D980-0x0000000181D9DA20
	// [XID] // 0x0000000189A36590-0x0000000189A365B0
	public override void ClearOnDisconnect() {} // 0x0000000181D96CC0-0x0000000181D96D70
	// [XID] // 0x0000000189A3DB90-0x0000000189A3DBB0
	public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFED2B */) {} // 0x0000000181D96A60-0x0000000181D96CC0
	// [XID] // 0x0000000189A45310-0x0000000189A45330
	public void OnDoSetPlayerBornData() {} // 0x0000000181D974A0-0x0000000181D97740
	// [XID] // 0x0000000189A4C9E0-0x0000000189A4CA00
	private void PlayFirstEnterVideo() {} // 0x0000000181D97CC0-0x0000000181D98170
	// [XID] // 0x0000000189A54210-0x0000000189A54230
	private void CloseInLevelNamePageAndMusic(InLevelNamePageContext context) {} // 0x0000000181D9CF20-0x0000000181D9D090
	// [XID] // 0x0000000189A5BC20-0x0000000189A5BC40
	public void OnPlayerEnterSceneNotify(PlayerEnterSceneNotify notify) {} // 0x0000000181D98B70-0x0000000181D99270
	// [XID] // 0x0000000189A63390-0x0000000189A633B0
	private void UpdateSceneTags(IList<uint> lst) {} // 0x0000000181D9B2D0-0x0000000181D9B5E0
	// [XID] // 0x0000000189A6AED0-0x0000000189A6AEF0
	private bool NeedLoadNewScene(PlayerEnterSceneNotify notify) => default; // 0x0000000181D958A0-0x0000000181D95F20
	// [XID] // 0x0000000189A72580-0x0000000189A725A0
	private void RealEnterScene(PlayerEnterSceneNotify notify) {} // 0x0000000181D98170-0x0000000181D98640
	// [XID] // 0x0000000189A7A1D0-0x0000000189A7A1F0
	private void SceneGoto(PlayerEnterSceneNotify notify) {} // 0x0000000181D99D50-0x0000000181D9A210
	// [XID] // 0x0000000189A81690-0x0000000189A816B0
	private void SetCurLevelBeforeLoadScene(bool isPrepare, bool asyncLoad, bool isTransmit) {} // 0x0000000181D9D840-0x0000000181D9D980
	// [XID] // 0x0000000189A89090-0x0000000189A890B0
	private void LoadNewScene(PlayerEnterSceneNotify notify) {} // 0x0000000181D99270-0x0000000181D995B0
	// [XID] // 0x0000000189A90870-0x0000000189A90890
	private void ReloadCurScene(PlayerEnterSceneNotify notify) {} // 0x0000000181D9D090-0x0000000181D9D220
	// [XID] // 0x0000000189A980B0-0x0000000189A980D0
	private void CheckNeedToLoadScene(PlayerEnterSceneNotify notify) {} // 0x0000000181D96860-0x0000000181D96950
	// [XID] // 0x0000000189A9F490-0x0000000189A9F4B0
	public void OnBeginLoadScene(EnterScenePeerNotify notify) {} // 0x0000000181D9A8D0-0x0000000181D9B2D0
	// [XID] // 0x0000000189AA6CA0-0x0000000189AA6CC0
	public void AfterInitFinish(PlayerEnterSceneInfoNotify notify) {} // 0x0000000181D9C5E0-0x0000000181D9CC60
	// [XID] // 0x0000000189AAE410-0x0000000189AAE430
	public void AfterEnterSceneDone(EnterSceneDoneRsp rsp) {} // 0x0000000181D9CD20-0x0000000181D9CF20
	// [XID] // 0x0000000189AB5C80-0x0000000189AB5CA0
	public void OnChooseName(bool isBornEnterScene, bool isMale) {} // 0x0000000181D9A5C0-0x0000000181D9A6E0
	// [XID] // 0x0000000189ABD6F0-0x0000000189ABD710
	public void OnTokenRspFail() {} // 0x0000000181D9C1B0-0x0000000181D9C260
	// [XID] // 0x0000000189AC5190-0x0000000189AC51B0
	public void OnLoginRspSucc(bool isRelogin) {} // 0x0000000181D9CC60-0x0000000181D9CD20
	// [XID] // 0x0000000189A9E970-0x0000000189A9E990
	public void OnLoginRspQueuing() {} // 0x0000000181D9BE40-0x0000000181D9BEF0
	// [XID] // 0x0000000189886B00-0x0000000189886B20
	public void OnLoginRspFail() {} // 0x0000000181D9A780-0x0000000181D9A830
	// [XID] // 0x0000000189ADBDC0-0x0000000189ADBDE0
	public void SetReloadScene() {} // 0x0000000181D96950-0x0000000181D96A00
	// [XID] // 0x0000000189AE36F0-0x0000000189AE3710
	public void EnterSceneInitFinish(uint token) {} // 0x0000000181D96790-0x0000000181D96860
	// [XID] // 0x0000000189AEB050-0x0000000189AEB070
	public void EnterSceneDoneFinish(uint token) {} // 0x0000000181D9A2C0-0x0000000181D9A390
	// [XID] // 0x0000000189AF2920-0x0000000189AF2940
	public void EnterInitScene(uint token) {} // 0x0000000181D98640-0x0000000181D98710
	// [XID] // 0x0000000189AFA220-0x0000000189AFA240
	public void EnterLoadStage(uint token, bool isNewScene) {} // 0x0000000181D99A20-0x0000000181D99C00
	// [XID] // 0x0000000189B017A0-0x0000000189B017C0
	public void EnterScenePostFinish(uint token, bool isNewScene) {} // 0x0000000181D96100-0x0000000181D96300
	// [XID] // 0x0000000189B08CF0-0x0000000189B08D10
	public void StopLoading() {} // 0x0000000181D9BD10-0x0000000181D9BE40
	[DebuggerHidden] // 0x0000000189B107F0-0x0000000189B10830
	// [XID] // 0x0000000189B107F0-0x0000000189B10830
	public IEnumerator PlayerTeleport(Vector3 pos, Action<SECTR_Manager.ProgressType, float> progressFunc) => default; // 0x0000000181D99C00-0x0000000181D99D50
	// [XID] // 0x0000000189B220B0-0x0000000189B220D0
	public void PlayerJumpPos(Vector3 jumpPos, EnterType enterType, uint token, bool isSkipUI) {} // 0x0000000181D9BA90-0x0000000181D9BD10
	// [XID] // 0x0000000189B29640-0x0000000189B29660
	private bool CheckTransmitInCutscene() => default; // 0x0000000181D988D0-0x0000000181D98B70
	// [XID] // 0x0000000189B30BF0-0x0000000189B30C10
	public void OnCutSceneFinish() {} // 0x0000000181D9A210-0x0000000181D9A2C0
	// [XID] // 0x0000000189B38250-0x0000000189B38270
	private void PerformDirectlyPlayerTransmit() {} // 0x0000000181D9D310-0x0000000181D9D3F0
	// [XID] // 0x0000000189B3FCA0-0x0000000189B3FCC0
	private void StopDelayTransmitCoroutine() {} // 0x0000000181D9A410-0x0000000181D9A500
	// [XID] // 0x0000000189B47490-0x0000000189B474B0
	private void PerformSafePlayerTransmit() {} // 0x0000000181D9B5E0-0x0000000181D9B6C0
	// [XID] // 0x0000000189B4ECD0-0x0000000189B4ECF0
	public void RequestSceneTransToPoint(uint sceneId, uint pointId, Action finishCallBackInForceDrag = null) {} // 0x0000000181D96E10-0x0000000181D974A0
	// [XID] // 0x0000000189B56600-0x0000000189B56620
	public void RequestTransToPacketAnchor(uint anchorID) {} // 0x0000000181D9C260-0x0000000181D9C4D0
	// [XID] // 0x0000000189B5DDC0-0x0000000189B5DDE0
	public void RequestClientTransmit(uint sceneId, Vector3 targetPos, Vector3 targetEuler, TransmitReason reason, ILuaActor actor, Action<ILuaActor> transFinishCallback, Action<ILuaActor> transPreCallback, uint questId = 0 /* Metadata: 0x00AFED2C */, uint pointId = 0 /* Metadata: 0x00AFED30 */) {} // 0x0000000181D9D500-0x0000000181D9D7E0
	// [XID] // 0x0000000189B65320-0x0000000189B65340
	public void CheckTransPreCB() {} // 0x0000000181D9A500-0x0000000181D9A5C0
	// [XID] // 0x0000000189B6C980-0x0000000189B6C9A0
	public void TransFinishCB() {} // 0x0000000181D9B740-0x0000000181D9B810
	// [XID] // 0x0000000189B740A0-0x0000000189B740C0
	public void TransmitPlayerFail() {} // 0x0000000181D9C4D0-0x0000000181D9C5E0
	// [XID] // 0x0000000189B7B650-0x0000000189B7B670
	public void TryToTransmitPlayer() {} // 0x0000000181D96300-0x0000000181D96410
	// [XID] // 0x0000000189B83040-0x0000000189B83060
	public void PlayerTransmitStart() {} // 0x0000000181D9B9F0-0x0000000181D9BA90
	// [XID] // 0x0000000189B8A590-0x0000000189B8A5B0
	public void ClearTransNotify() {} // 0x0000000181D9A830-0x0000000181D9A8D0
	// [XID] // 0x0000000189B91B80-0x0000000189B91BA0
	private void PerformPlayerTransmit(Vector3 targetPos, EnterType enterType, uint token, EvtTransmitAvatar.TransmitType transType = EvtTransmitAvatar.TransmitType.Default /* Metadata: 0x00AFED34 */) {} // 0x0000000181D95F20-0x0000000181D96100
	[Preserve] // 0x0000000189B99020-0x0000000189B99060
	// [XID] // 0x0000000189B99020-0x0000000189B99060
	public override string Dump(string tag) => default; // 0x0000000181D97A20-0x0000000181D97CC0
	// [XID] // 0x0000000189BA3710-0x0000000189BA3730
	public void ReportTasks() {} // 0x0000000181D9D3F0-0x0000000181D9D500
	// [XID] // 0x0000000189BAAAE0-0x0000000189BAAB00
	public void GoToLevelWithSceneId(uint sceneID, GlobalVars.WorldType worldType, string selectedDataName = null, Action createNewWorldCallback = null) {} // 0x0000000181D9BFB0-0x0000000181D9C0D0
	// [XID] // 0x0000000189BB2050-0x0000000189BB2070
	public void GoToLevel(GlobalVars.WorldType worldType, string selectedDataName = null, Action createNewWorldCallback = null) {} // 0x0000000181D95690-0x0000000181D95790
	// [XID] // 0x0000000189BB9440-0x0000000189BB9460
	private void GoToLevelImp(GlobalVars.WorldType worldType, string selectedDataName = null, Action createNewWorldCallback = null) {} // 0x0000000181D96410-0x0000000181D966F0
	[DebuggerHidden] // 0x0000000189BC1260-0x0000000189BC12A0
	// [XID] // 0x0000000189BC1260-0x0000000189BC12A0
	public IEnumerator WaitLevelLoaded(uint sceneID) => default; // 0x0000000181D95790-0x0000000181D958A0
	// [XID] // 0x0000000189BCBC60-0x0000000189BCBC80
	public void DebugLocalGoToLevelWithDungeonId(uint dungeonID) {} // 0x0000000181D9C0D0-0x0000000181D9C1B0
	// [XID] // 0x0000000189BD31B0-0x0000000189BD31D0
	public void DebugLocalGoToLevelWithSceneId(uint sceneID) {} // 0x0000000181D98710-0x0000000181D988D0
	// [XID] // 0x0000000189BDAA90-0x0000000189BDAAB0
	public void DebugLocalTransport(Vector3 gotoPos) {} // 0x0000000181D97740-0x0000000181D97980
}

