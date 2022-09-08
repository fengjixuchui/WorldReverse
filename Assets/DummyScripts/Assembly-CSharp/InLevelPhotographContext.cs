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
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelPhotographContext : BasePageContext // TypeDefIndex: 29919
{
	// Fields
	private MonoInLevelPhotographPage _pageMono; // 0x190
	private VCStackCamera _vcStackCamera; // 0x198
	private ConfigUIPhotograph _config; // 0x1A0
	private bool _hideInfo; // 0x1A8
	private bool _hideUIOpen; // 0x1A9
	private const int INPUT_STATE_SETUP = 1; // Metadata: 0x00B1021A
	private const int INPUT_STATE_POSE = 2; // Metadata: 0x00B1021E
	private int _currPanel; // 0x1AC
	private float _currShiftLeftRight; // 0x1B0
	private float _currShiftUpDown; // 0x1B4
	private float leftrightStep; // 0x1B8
	private float updownStep; // 0x1BC
	public static readonly float moveCameraSteps; // 0x00
	private bool _emotionPlaying; // 0x1C0
	private float _currEmotionTime; // 0x1C4
	private float _targetEmotionTime; // 0x1C8
	private bool _isPerforming; // 0x1CC
	private List<Button> _listButton; // 0x1D0
	private List<PhotographPosenameExcelConfig> _allConfigList; // 0x1D8
	private PhotographPosenameExcelConfig _currConfig; // 0x1E0
	private List<PhotographPosenameExcelConfig> _currList; // 0x1E8
	private List<string> _currLockTitle; // 0x1F0
	private List<Button> _listEmotionButton; // 0x1F8
	private List<PhotographExpressionExcelConfig> _emotionConfigList; // 0x200
	private List<PhotographExpressionExcelConfig> _currEmotionList; // 0x208
	private PhotographExpressionExcelConfig _currEmotionConfig; // 0x210
	private PhotographExpressionExcelConfig _waitEmotionConfig; // 0x218
	private List<PhotographPosenameExcelConfig> poseExcelUnlocked; // 0x220
	private List<PhotographExpressionExcelConfig> emotionExcelUnlocked; // 0x228
	private Transform _currBtnSelect; // 0x230
	private PhotographPosenameExcelConfig _animToPlay; // 0x238
	private Coroutine playCoroutine; // 0x240
	private bool _faceYou; // 0x248
	private MotionBlur _motionBlur; // 0x250
	private MHYDepthOfField _depthOfField; // 0x258
	private bool _isInPhotographQuest; // 0x260
	private PhotographTask _currTask; // 0x268
	private static bool TestPhotographTask; // 0x04

	// Constructors
	public InLevelPhotographContext() {} // Dummy constructor
	public InLevelPhotographContext(bool hideUI = false /* Metadata: 0x00B10214 */) {} // 0x0000000181C6B8B0-0x0000000181C6BAE0
	static InLevelPhotographContext() {} // 0x0000000181C6B840-0x0000000181C6B8B0

	// Methods
	// [XID] // 0x0000000189ADEAB0-0x0000000189ADEAD0
	public static bool CheckCanEnterPhotograph() => default; // 0x0000000181C65380-0x0000000181C65610
	// [XID] // 0x0000000189AE64A0-0x0000000189AE64C0
	private void SwitchCurrTab(bool add) {} // 0x0000000181C69CF0-0x0000000181C69E00
	// [XID] // 0x0000000189AEDC30-0x0000000189AEDC50
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181C660D0-0x0000000181C668B0
	// [XID] // 0x0000000189AF5500-0x0000000189AF5520
	public bool HandleInputActionEventSetup(InputActionEvent actionEvent) => default; // 0x0000000181C68F60-0x0000000181C690B0
	// [XID] // 0x0000000189AFC9F0-0x0000000189AFCA10
	public bool HandleInputActionEventPose(InputActionEvent actionEvent) => default; // 0x0000000181C656A0-0x0000000181C657D0
	// [XID] // 0x0000000189B04170-0x0000000189B04190
	public override void SetupView() {} // 0x0000000181C6AEB0-0x0000000181C6B4B0
	// [XID] // 0x0000000189B0BA10-0x0000000189B0BA30
	private void RefreshHint(bool firstEnter = false /* Metadata: 0x00B10215 */) {} // 0x0000000181C668B0-0x0000000181C66A30
	// [XID] // 0x0000000189B12EE0-0x0000000189B12F00
	protected override void BindViewCallbacks() {} // 0x0000000181C637D0-0x0000000181C644B0
	// [XID] // 0x0000000189B1A5F0-0x0000000189B1A610
	private void OnUp() {} // 0x0000000181C62410-0x0000000181C62530
	// [XID] // 0x0000000189B21B80-0x0000000189B21BA0
	private void OnDown() {} // 0x0000000181C65CD0-0x0000000181C65E00
	// [XID] // 0x0000000189B29240-0x0000000189B29260
	private void OnLeft() {} // 0x0000000181C6A2B0-0x0000000181C6A3E0
	// [XID] // 0x0000000189B30650-0x0000000189B30670
	private void OnRight() {} // 0x0000000181C65260-0x0000000181C65380
	// [XID] // 0x0000000189B37F30-0x0000000189B37F50
	private void OnRefreshCameraData() {} // 0x0000000181C69AF0-0x0000000181C69BB0
	// [XID] // 0x0000000189B3F940-0x0000000189B3F960
	private void ResetDefaultSlider() {} // 0x0000000181C65FE0-0x0000000181C660D0
	// [XID] // 0x0000000189B471A0-0x0000000189B471C0
	public override void UpdateView() {} // 0x0000000181C6B4B0-0x0000000181C6B840
	// [XID] // 0x0000000189B4E960-0x0000000189B4E980
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181C6A890-0x0000000181C6A9D0
	// [XID] // 0x0000000189B561A0-0x0000000189B561C0
	private void InitEmotionPanel() {} // 0x0000000181C62640-0x0000000181C63240
	// [XID] // 0x0000000189B5DA20-0x0000000189B5DA40
	private void InitEmotionItem(Transform trans, int index) {} // 0x0000000181C698A0-0x0000000181C69AF0
	// [XID] // 0x0000000189B64F80-0x0000000189B64FA0
	private void PlayEmotionConfig(PhotographExpressionExcelConfig config) {} // 0x0000000181C67900-0x0000000181C67A20
	// [XID] // 0x0000000189B6C560-0x0000000189B6C580
	private void TryClickPlayEmotion() {} // 0x0000000181C63730-0x0000000181C637D0
	// [XID] // 0x0000000189B73C90-0x0000000189B73CB0
	private void RefreshEmotionByConfig() {} // 0x0000000181C63240-0x0000000181C63420
	// [XID] // 0x0000000189B7B340-0x0000000189B7B360
	private void TrySetEmotion() {} // 0x0000000181C64A10-0x0000000181C64AC0
	// [XID] // 0x0000000189B82C60-0x0000000189B82C80
	private void DoSetEmotion() {} // 0x0000000181C689C0-0x0000000181C68EA0
	// [XID] // 0x0000000189B8A260-0x0000000189B8A280
	private void InitPosePanel() {} // 0x0000000181C67BA0-0x0000000181C68790
	// [XID] // 0x0000000189B918C0-0x0000000189B918E0
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B10216 */) {} // 0x0000000181C6A3E0-0x0000000181C6A890
	// [XID] // 0x0000000189B98C80-0x0000000189B98CA0
	private void InitPoseItem(Transform trans, int index) {} // 0x0000000181C65A80-0x0000000181C65CD0
	// [XID] // 0x0000000189BA00A0-0x0000000189BA00C0
	private void PlayAnimConfig(PhotographPosenameExcelConfig config) {} // 0x0000000181C62280-0x0000000181C623A0
	// [XID] // 0x0000000189BA78E0-0x0000000189BA7900
	private void RefreshAnimByConfig() {} // 0x0000000181C69290-0x0000000181C695B0
	[DebuggerHidden] // 0x0000000189BAEBF0-0x0000000189BAEC30
	// [XID] // 0x0000000189BAEBF0-0x0000000189BAEC30
	private IEnumerator StandAndDoPlay() => default; // 0x0000000181C62530-0x0000000181C62640
	// [XID] // 0x0000000189BB90F0-0x0000000189BB9110
	private void DoPlay() {} // 0x0000000181C67A20-0x0000000181C67BA0
	// [XID] // 0x0000000189BC0EA0-0x0000000189BC0EC0
	private void ResetPlayerEmotion() {} // 0x0000000181C66A30-0x0000000181C66BE0
	// [XID] // 0x0000000189BC85B0-0x0000000189BC85D0
	private void ResetPlayerAnim() {} // 0x0000000181C64550-0x0000000181C64680
	// [XID] // 0x0000000189BCFE50-0x0000000189BCFE70
	private void OnFaceyouToggle(bool on) {} // 0x0000000181C6A0F0-0x0000000181C6A220
	// [XID] // 0x0000000189BD7450-0x0000000189BD7470
	private void SetHideme(bool on) {} // 0x0000000181C690B0-0x0000000181C691D0
	// [XID] // 0x0000000189BDEF70-0x0000000189BDEF90
	private void OnHidemeToggle(bool on) {} // 0x0000000181C659B0-0x0000000181C65A80
	// [XID] // 0x00000001895EBC20-0x00000001895EBC40
	private void ResetDof() {} // 0x0000000181C69F40-0x0000000181C6A0F0
	// [XID] // 0x00000001895F2FC0-0x00000001895F2FE0
	private void ForceDofGoActive(bool active) {} // 0x0000000181C66C40-0x0000000181C66DC0
	// [XID] // 0x00000001895FA800-0x00000001895FA820
	private void ClearDof() {} // 0x0000000181C676E0-0x0000000181C67900
	// [XID] // 0x00000001896021B0-0x00000001896021D0
	private void OnDofToggle(bool toggle) {} // 0x0000000181C66E20-0x0000000181C67420
	// [XID] // 0x00000001896099F0-0x0000000189609A10
	private void RefreshDofBtnAnim() {} // 0x0000000181C64C30-0x0000000181C64E80
	// [XID] // 0x0000000189611160-0x0000000189611180
	private void OnDofDistanceChange(float value) {} // 0x0000000181C6AB20-0x0000000181C6ACC0
	// [XID] // 0x0000000189618B30-0x0000000189618B50
	private void OnDofAmountChange(float value) {} // 0x0000000181C67420-0x0000000181C675E0
	// [XID] // 0x00000001896200C0-0x00000001896200E0
	private void OnFovSliderChange(float value) {} // 0x0000000181C64950-0x0000000181C64A10
	// [XID] // 0x0000000189627510-0x0000000189627530
	private void OnSetUp() {} // 0x0000000181C69E00-0x0000000181C69F40
	// [XID] // 0x000000018962F030-0x000000018962F050
	private void OnPose() {} // 0x0000000181C68EA0-0x0000000181C68F60
	// [XID] // 0x00000001896369F0-0x0000000189636A10
	private void OnEmotion() {} // 0x0000000181C691D0-0x0000000181C69290
	// [XID] // 0x000000018963DF00-0x000000018963DF20
	private void OnBackToMain() {} // 0x0000000181C65E00-0x0000000181C65EC0
	// [XID] // 0x0000000189645890-0x00000001896458B0
	private void SetBtnText(string variantName, string text) {} // 0x0000000181C6ACC0-0x0000000181C6AEB0
	// [XID] // 0x000000018964D0C0-0x000000018964D0E0
	private void OnToggleHide(bool toggleOn) {} // 0x0000000181C64AC0-0x0000000181C64C30
	// [XID] // 0x00000001896547E0-0x0000000189654800
	private void OnResetCamera() {} // 0x0000000181C675E0-0x0000000181C676E0
	// [XID] // 0x000000018965BEF0-0x000000018965BF10
	private void TryClose() {} // 0x0000000181C65EC0-0x0000000181C65F80
	// [XID] // 0x0000000189663540-0x0000000189663560
	public static bool NeedHide() => default; // 0x0000000181C644B0-0x0000000181C64550
	// [XID] // 0x000000018966AF10-0x000000018966AF30
	private void OnTakePhotograph() {} // 0x0000000181C65840-0x0000000181C659B0
	// [XID] // 0x0000000189672B10-0x0000000189672B30
	public override void ClearView() {} // 0x0000000181C64680-0x0000000181C64950
	// [XID] // 0x000000018967A250-0x000000018967A270
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x0000000181C69620-0x0000000181C69770
	// [XID] // 0x0000000189681A80-0x0000000189681AA0
	private bool SetupPhotographQuest() => default; // 0x0000000181C65000-0x0000000181C65260
	// [XID] // 0x00000001896894F0-0x0000000189689510
	private bool IsPlaceRight() => default; // 0x0000000181C63420-0x0000000181C63730
	// [XID] // 0x0000000189691150-0x0000000189691170
	private bool IsTimeRight() => default; // 0x0000000181C6A9D0-0x0000000181C6AB20
	// [XID] // 0x0000000189698900-0x0000000189698920
	private bool CheckQuestRequirement() => default; // 0x0000000181C68790-0x0000000181C689C0
	// [XID] // 0x000000018969FD70-0x000000018969FD90
	private void FinishQuest() {} // 0x0000000181C69770-0x0000000181C698A0
}

