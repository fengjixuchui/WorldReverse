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

public sealed class VideoManager : GlobalManager // TypeDefIndex: 21378
{
	// Fields
	private bool _enableVideoManager; // 0x10
	private Action _videoStartAction; // 0x18
	private Action _videoFinishAction; // 0x20
	private Action _videoErrorAction; // 0x28
	private Action<int, string[]> _videoEventCallBack; // 0x30
	private Queue<VideoPlayTask> _videoTaskQueue; // 0x38
	private VideoPlayTask _currTask; // 0x40
	private bool _isPlaying; // 0x48
	private bool _realPlaying; // 0x49
	private bool _isDestroy; // 0x4A
	private VideoSkipPageContext _videoSkipPage; // 0x50
	private bool _disableSkip; // 0x58
	private GameObject _videoCanvas; // 0x60
	private const string VIDEO_CANVAS_PATH = "ART/UI/EmbededUI/VideoCanvasWithSubtitles"; // Metadata: 0x00AFF730

	// Properties
	public bool realPlaying { /* [XID] */ /* 0x0000000189A189F0-0x0000000189A18A10 */ get => default; } // 0x0000000184FB5710-0x0000000184FB57B0 
	public bool isPlaying { /* [XID] */ /* 0x0000000189A20070-0x0000000189A20090 */ get => default; } // 0x0000000184FB4770-0x0000000184FB4810 
	public bool disableSkip { /* [XID] */ /* 0x0000000189A27400-0x0000000189A27420 */ set {} } // 0x0000000184FB6720-0x0000000184FB67D0

	// Constructors
	public VideoManager() {} // 0x0000000184FB7160-0x0000000184FB71F0

	// Methods
	// [XID] // 0x0000000189A2EC60-0x0000000189A2EC80
	public override void Init() {} // 0x0000000184FB57B0-0x0000000184FB5880
	// [XID] // 0x0000000189A36530-0x0000000189A36550
	public override void Destroy() {} // 0x0000000184FB46C0-0x0000000184FB4770
	// [XID] // 0x0000000189A3DB50-0x0000000189A3DB70
	public override void ClearOnLevelDestroy() {} // 0x0000000184FB45A0-0x0000000184FB4650
	// [XID] // 0x0000000189A452D0-0x0000000189A452F0
	public override void ReloadRes() {} // 0x0000000184FB6CF0-0x0000000184FB6D90
	// [XID] // 0x0000000189A4C9A0-0x0000000189A4C9C0
	public override void ClearOnDisconnect() {} // 0x0000000184FB44F0-0x0000000184FB45A0
	// [XID] // 0x0000000189A541D0-0x0000000189A541F0
	public override void Tick() {} // 0x0000000184FB6D90-0x0000000184FB7160
	// [XID] // 0x0000000189A5BBE0-0x0000000189A5BC00
	private void TryPlayVideo(string videoPath, string subtitlePath, Color bgColor, bool useSkipBtn = true /* Metadata: 0x00AFF6F7 */) {} // 0x0000000184FB48C0-0x0000000184FB4E90
	// [XID] // 0x0000000189A63350-0x0000000189A63370
	private void TryStopVideo() {} // 0x0000000184FB5660-0x0000000184FB5710
	// [XID] // 0x0000000189A6AE90-0x0000000189A6AEB0
	private void TrySkipVideo() {} // 0x0000000184FB4810-0x0000000184FB48C0
	// [XID] // 0x0000000189A72540-0x0000000189A72560
	private void OnVideoStart(string videoPath) {} // 0x0000000184FB64A0-0x0000000184FB65E0
	// [XID] // 0x0000000189A7A170-0x0000000189A7A190
	private void OnVideoFinish(string videoPath) {} // 0x0000000184FB5B50-0x0000000184FB5EA0
	// [IDTag] // 0x0000000189A815F0-0x0000000189A81630
	// [XID] // 0x0000000189A815F0-0x0000000189A81630
	private void OnVideoError(string videoPath) {} // 0x0000000184FB5460-0x0000000184FB5510
	// [IDTag] // 0x0000000189A8BFC0-0x0000000189A8C000
	// [XID] // 0x0000000189A8BFC0-0x0000000189A8C000
	private void OnVideoError() {} // 0x0000000184FB5250-0x0000000184FB5460
	// [XID] // 0x0000000189A965C0-0x0000000189A965E0
	private void OnVideoEvent(int type, string[] paramArr) {} // 0x0000000184FB5930-0x0000000184FB5A10
	// [XID] // 0x0000000189A9DB10-0x0000000189A9DB30
	private void ClearAllVideoTask(bool isDestroy = true /* Metadata: 0x00AFF6F8 */, bool isQuit = false /* Metadata: 0x00AFF6F9 */) {} // 0x0000000184FB4050-0x0000000184FB4180
	// [XID] // 0x0000000189AA5420-0x0000000189AA5440
	private void ShowSkipPage(bool useSkipBtn) {} // 0x0000000184FB65E0-0x0000000184FB6720
	// [XID] // 0x0000000189AACCA0-0x0000000189AACCC0
	private void CloseSkipPage() {} // 0x0000000184FB5510-0x0000000184FB55C0
	// [XID] // 0x0000000189AB4530-0x0000000189AB4550
	private void CheckSkipPage(bool useSkipBtn) {} // 0x0000000184FB4EF0-0x0000000184FB5010
	// [XID] // 0x0000000189ABC220-0x0000000189ABC240
	private void CheckVideoCanvasObject() {} // 0x0000000184FB5010-0x0000000184FB5250
	// [XID] // 0x0000000189AC3B00-0x0000000189AC3B20
	private void DestroyVideoCanvasObject() {} // 0x0000000184FB67D0-0x0000000184FB6920
	// [IDTag] // 0x0000000189ACAFC0-0x0000000189ACB000
	// [XID] // 0x0000000189ACAFC0-0x0000000189ACB000
	public void TryPlayVideoByPath(string videoPath, uint subtitleId = 0 /* Metadata: 0x00AFF6FA */, bool canSkip = true /* Metadata: 0x00AFF6FE */, Action startAction = null, Action finishAction = null, Action errorAction = null, Color? bgColor = default, bool forceSkip = false /* Metadata: 0x00AFF6FF */, float fadeIn = 0f /* Metadata: 0x00AFF700 */, float fadeOut = 0f /* Metadata: 0x00AFF704 */, Action<int, string[]> eventAction = null, bool dontPauseLogic = false /* Metadata: 0x00AFF708 */) {} // 0x0000000184FB5EA0-0x0000000184FB6140
	// [IDTag] // 0x0000000189AD5DC0-0x0000000189AD5E00
	// [XID] // 0x0000000189AD5DC0-0x0000000189AD5E00
	public void TryPlayVideoByPath(string videoPath, string subtitlePath = null, bool canSkip = true /* Metadata: 0x00AFF709 */, Action startAction = null, Action finishAction = null, Action errorAction = null, Color? bgColor = default, bool forceSkip = false /* Metadata: 0x00AFF70A */, float fadeIn = 0f /* Metadata: 0x00AFF70B */, float fadeOut = 0f /* Metadata: 0x00AFF70F */, Action<int, string[]> eventAction = null, bool dontPauseLogic = false /* Metadata: 0x00AFF713 */) {} // 0x0000000184FB6140-0x0000000184FB63C0
	// [XID] // 0x0000000189AE0920-0x0000000189AE0940
	public void TryPlayVideoForLua(string videoPath, uint subtitleId = 0 /* Metadata: 0x00AFF714 */, bool canSkip = true /* Metadata: 0x00AFF718 */, Action<ILuaActor> finishAction = null, ILuaActor actor = null, Color? bgColor = default, float fadeIn = 0f /* Metadata: 0x00AFF719 */, float fadeOut = 0f /* Metadata: 0x00AFF71D */, Action<int, string[]> eventAction = null, bool dontPauseLogic = false /* Metadata: 0x00AFF721 */) {} // 0x0000000184FB6980-0x0000000184FB6CF0
	// [XID] // 0x0000000189AE7DD0-0x0000000189AE7DF0
	public void TryPlayVideoForCutscene(string videoPath, uint subtitleId = 0 /* Metadata: 0x00AFF722 */, bool canSkip = true /* Metadata: 0x00AFF726 */, Action<ILuaActor> finishAction = null, ILuaActor actor = null, Color? bgColor = default, float fadeIn = 0f /* Metadata: 0x00AFF727 */, float fadeOut = 0f /* Metadata: 0x00AFF72B */, Action<int, string[]> eventAction = null, bool dontPauseLogic = false /* Metadata: 0x00AFF72F */) {} // 0x0000000184FB4180-0x0000000184FB44F0
	// [XID] // 0x0000000189AEFB00-0x0000000189AEFB20
	public void TrySkipCurrVideo() {} // 0x0000000184FB5880-0x0000000184FB5930
	// [XID] // 0x0000000189AF6FE0-0x0000000189AF7000
	public void StatPlayVideo(string videoPath) {} // 0x0000000184FB63C0-0x0000000184FB64A0
	// [XID] // 0x0000000189AFE5F0-0x0000000189AFE610
	public void StatStopVideo() {} // 0x0000000184FB55C0-0x0000000184FB5660
}

