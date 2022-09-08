/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class TutorialDialogContext : BaseDialogContext // TypeDefIndex: 30315
{
	// Fields
	public static uint TUTORIAL_QUEST_LEVEL_ID; // 0x00
	private MonoTutorialDialog _dialogMono; // 0x178
	private int _counter; // 0x180
	private SimpleSafeUInt32[] _tutorialDetailList; // 0x188
	private bool _pauseLevel; // 0x190
	private float _curTime; // 0x194
	private bool _canClick; // 0x198

	// Constructors
	public TutorialDialogContext() {} // Dummy constructor
	public TutorialDialogContext(uint tuterialId, Action closeCallback = null) {} // 0x000000018108CE40-0x000000018108CF80
	static TutorialDialogContext() {} // 0x000000018108CDE0-0x000000018108CE40

	// Methods
	// [XID] // 0x0000000189740150-0x0000000189740170
	public override void SetupView() {} // 0x000000018108CA20-0x000000018108CBF0
	// [XID] // 0x0000000189747500-0x0000000189747520
	public override void ClearView() {} // 0x000000018108BC50-0x000000018108BD00
	// [XID] // 0x000000018974EC50-0x000000018974EC70
	public override void UpdateView() {} // 0x000000018108CBF0-0x000000018108CDE0
	// [XID] // 0x0000000189756360-0x0000000189756380
	protected override void BindViewCallbacks() {} // 0x000000018108BB50-0x000000018108BC50
	// [XID] // 0x000000018975D740-0x000000018975D760
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018108BEC0-0x000000018108BFD0
	// [XID] // 0x0000000189764D90-0x0000000189764DB0
	private void SetTutorialDialogView(uint detailId) {} // 0x000000018108C160-0x000000018108C700
	// [XID] // 0x000000018976C7F0-0x000000018976C810
	private void OnNextBtnClick() {} // 0x000000018108B970-0x000000018108BB50
	// [XID] // 0x0000000189773C90-0x0000000189773CB0
	private void SetTutorialTypeStyle(TutorialDetailType type) {} // 0x000000018108C700-0x000000018108C900
	// [XID] // 0x000000018977B340-0x000000018977B360
	private void StopLevelTime() {} // 0x000000018108BD90-0x000000018108BE60
	// [XID] // 0x0000000189782E80-0x0000000189782EA0
	private void ResumeLevelTime() {} // 0x000000018108C030-0x000000018108C100
}

