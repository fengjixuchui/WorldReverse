/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CommandThreadUiFunctionalities : CommandThreadFunctionalities // TypeDefIndex: 11445
{
	// Fields
	private readonly HashSet<IAudioUiTickable> _tickableMonos; // 0x18
	private readonly List<IAudioUiTickable> _tickableMonosToAdd; // 0x20
	private readonly List<IAudioUiTickable> _tickableMonosToRemove; // 0x28
	private readonly SyncId _sync2d; // 0x30
	private GameViewState _gameViewState; // 0x48
	private bool _wasLevelEntityActive; // 0x4C
	private uint _lastDialogId; // 0x50
	private uint _lastNarratorDialogId; // 0x54
	private int _menuCounter; // 0x58
	private float _resetFreeplayCountDown; // 0x5C

	// Properties
	public SyncId sync2d { /* [XID] */ /* 0x0000000189ADE740-0x0000000189ADE760 */ get => default; } // 0x00000001837347E0-0x00000001837348D0 

	// Constructors
	public CommandThreadUiFunctionalities() {} // Dummy constructor
	public CommandThreadUiFunctionalities(CommandThreadContext context) {} // 0x0000000183735910-0x0000000183735A80

	// Methods
	// [XID] // 0x0000000189935BC0-0x0000000189935BE0
	public override void Init() {} // 0x0000000183733030-0x0000000183733170
	// [XID] // 0x000000018993D860-0x000000018993D880
	public override void Tick(float deltaTime) {} // 0x0000000183733170-0x0000000183733240
	// [XID] // 0x0000000189944CB0-0x0000000189944CD0
	public override void EnterHomeWorld(bool firstTime) {} // 0x0000000183733BE0-0x0000000183733C90
	// [XID] // 0x000000018994C2E0-0x000000018994C300
	public override void ExitHomeWorld() {} // 0x0000000183734670-0x0000000183734710
	// [XID] // 0x0000000189B2EA70-0x0000000189B2EA90
	public override void ExitGameWorld() {} // 0x00000001837340F0-0x0000000183734190
	// [XID] // 0x00000001899E1180-0x00000001899E11A0
	public override void CreateLevel() {} // 0x0000000183731DB0-0x0000000183731E50
	// [XID] // 0x00000001899F0440-0x00000001899F0460
	public override void EnterLevel() {} // 0x0000000183733A80-0x0000000183733B30
	// [XID] // 0x000000018996A170-0x000000018996A190
	public override void ExitLevel() {} // 0x0000000183732DA0-0x0000000183732E40
	// [XID] // 0x0000000189971EF0-0x0000000189971F10
	public override void DumpCriticalInfo(StringBuilder builder) {} // 0x0000000183735540-0x0000000183735730
	// [XID] // 0x0000000189A3A350-0x0000000189A3A370
	public override void Destroy() {} // 0x0000000183732140-0x0000000183732230
	// [XID] // 0x0000000189980920-0x0000000189980940
	public void SetSwitch2D(uint nameId, uint valueId) {} // 0x0000000183735730-0x0000000183735850
	// [XID] // 0x00000001899882B0-0x00000001899882D0
	public void PostEvent2D(uint eventId) {} // 0x0000000183731AB0-0x0000000183731BC0
	// [XID] // 0x000000018998FD20-0x000000018998FD40
	public void RegisterTickable(IAudioUiTickable tickable) {} // 0x0000000183734E00-0x0000000183734ED0
	// [XID] // 0x00000001896A8490-0x00000001896A84B0
	public void UnregisterTickable(IAudioUiTickable tickable) {} // 0x0000000183734190-0x0000000183734260
	// [XID] // 0x000000018976ADB0-0x000000018976ADD0
	private bool GameViewStateEnter(GameViewState singleState) => default; // 0x0000000183731E50-0x0000000183731F20
	// [XID] // 0x00000001899A6BF0-0x00000001899A6C10
	private bool GameViewStateLeave(GameViewState state) => default; // 0x0000000183734710-0x00000001837347E0
	// [XID] // 0x00000001897458B0-0x00000001897458D0
	public void RespondToAvatarEnterFocus() {} // 0x0000000183733630-0x00000001837336E0
	// [XID] // 0x00000001899B5B00-0x00000001899B5B20
	public void RespondToAvatarExitFocus() {} // 0x0000000183733B30-0x0000000183733BE0
	// [XID] // 0x00000001899BD2E0-0x00000001899BD300
	public void RespondToAvatarChange() {} // 0x0000000183733870-0x0000000183733920
	// [XID] // 0x00000001899C4CD0-0x00000001899C4CF0
	public void RespondToMenuOpen(string name) {} // 0x0000000183735300-0x0000000183735400
	// [XID] // 0x0000000189A0DF20-0x0000000189A0DF40
	public void RespondToMenuClose(string name) {} // 0x0000000183734260-0x0000000183734370
	// [XID] // 0x0000000189A7B050-0x0000000189A7B070
	public void RespondToSneakInStart() {} // 0x0000000183732F80-0x0000000183733030
	// [XID] // 0x0000000189A82720-0x0000000189A82740
	public void RespondToSneakInStop() {} // 0x0000000183731BC0-0x0000000183731C70
	// [XID] // 0x0000000189A89F00-0x0000000189A89F20
	public void RespondToDialogStart() {} // 0x0000000183733920-0x00000001837339D0
	// [XID] // 0x0000000189A917A0-0x0000000189A917C0
	public void RespondToDialogFinish() {} // 0x0000000183731F20-0x0000000183731FE0
	// [XID] // 0x00000001899F1570-0x00000001899F1590
	public void RespondToCoopStart() {} // 0x0000000183733240-0x00000001837332F0
	// [XID] // 0x0000000189AD57D0-0x0000000189AD57F0
	public void RespondToCoopFinish() {} // 0x0000000183732090-0x0000000183732140
	// [XID] // 0x0000000189A00410-0x0000000189A00430
	public void RespondToVideoStart() {} // 0x0000000183733F50-0x0000000183734000
	// [XID] // 0x0000000189A07B00-0x0000000189A07B20
	public void RespondToVideoStop() {} // 0x00000001837336E0-0x0000000183733790
	// [XID] // 0x0000000189AEBF90-0x0000000189AEBFB0
	public void RespondToElementView(bool enabled) {} // 0x0000000183732CE0-0x0000000183732DA0
	// [XID] // 0x0000000189A16800-0x0000000189A16820
	public void ResponseToMusicGameOtherFreePlay() {} // 0x0000000183734000-0x00000001837340F0
	// [XID] // 0x0000000189A1DC80-0x0000000189A1DCA0
	public void ResponseToMusicGameBegin() {} // 0x0000000183733EA0-0x0000000183733F50
	// [XID] // 0x0000000189B11820-0x0000000189B11840
	public void ResponseToMusicGameEnd() {} // 0x0000000183731FE0-0x0000000183732090
	// [XID] // 0x0000000189A2C940-0x0000000189A2C960
	public void ResetGameViewState() {} // 0x0000000183735150-0x0000000183735210
	// [XID] // 0x0000000189A33FE0-0x0000000189A34000
	public void SetGameViewState(GameViewState state) {} // 0x0000000183732A90-0x0000000183732CE0
	// [XID] // 0x0000000189A3B710-0x0000000189A3B730
	public bool IsInSneakInMode() => default; // 0x0000000183733790-0x0000000183733870
	// [XID] // 0x0000000189B18A50-0x0000000189B18A70
	public void ReactToDialog(uint dialogId, bool start) {} // 0x0000000183732830-0x0000000183732900
	// [XID] // 0x0000000189A4A770-0x0000000189A4A790
	public void ReactToNarratorBegin(uint dialogId) {} // 0x0000000183732370-0x0000000183732430
	// [XID] // 0x0000000189A51F20-0x0000000189A51F40
	public void ReactToNarratorEnd() {} // 0x00000001837339D0-0x0000000183733A80
	// [XID] // 0x0000000189B3D7F0-0x0000000189B3D810
	public void SetCharacterElementTypeState(ElementType element) {} // 0x0000000183732680-0x0000000183732830
	// [XID] // 0x0000000189A61090-0x0000000189A610B0
	public void PostCharacterAppearEvent() {} // 0x0000000183734CE0-0x0000000183734E00
	// [XID] // 0x0000000189B85A60-0x0000000189B85A80
	public void PostMapPinEvent(bool add) {} // 0x0000000183734ED0-0x0000000183735040
	// [XID] // 0x000000018964E3C0-0x000000018964E3E0
	public void PostDungeonResultStageEvent(bool victory) {} // 0x0000000183731900-0x0000000183731AB0
	// [XID] // 0x0000000189A779E0-0x0000000189A77A00
	public void PostOpenPageEvent(string pageName) {} // 0x0000000183732430-0x0000000183732570
	// [XID] // 0x00000001897203C0-0x00000001897203E0
	public void PostClosePageEvent(string pageName) {} // 0x00000001837334F0-0x0000000183733630
	// [XID] // 0x0000000189A86AC0-0x0000000189A86AE0
	public void PostUIEvent(UIAudioEventType uiEvent) {} // 0x0000000183735210-0x0000000183735300
	// [XID] // 0x0000000189A8E650-0x0000000189A8E670
	private void TickMenuPauseLevel() {} // 0x0000000183735850-0x0000000183735910
	// [XID] // 0x0000000189A95A90-0x0000000189A95AB0
	private void TickMusicGameFreePlay(float deltaTime) {} // 0x00000001837333D0-0x00000001837334F0
	// [XID] // 0x00000001899BBCC0-0x00000001899BBCE0
	private void TickRegisteredMonos() {} // 0x0000000183734370-0x0000000183734530
	// [XID] // 0x00000001899C38A0-0x00000001899C38C0
	private void AddTickableMonos() {} // 0x0000000183731C70-0x0000000183731DB0
	// [XID] // 0x0000000189AAC0B0-0x0000000189AAC0D0
	private void RemoveTickableMonos() {} // 0x0000000183734530-0x0000000183734670
	// [XID] // 0x0000000189B055D0-0x0000000189B055F0
	private bool IsLevelEntityActive() => default; // 0x0000000183732E40-0x0000000183732F80
	// [XID] // 0x00000001897549B0-0x00000001897549D0
	private ConfigWwiseString GetUIShortIdStringByEventType(UIAudioEventType uiEvent) => default; // 0x00000001837348D0-0x0000000183734B30
	// [XID] // 0x0000000189AC2DF0-0x0000000189AC2E10
	private void PerformDialogReactions(uint dialogId, bool start) {} // 0x0000000183732900-0x0000000183732A90
	// [XID] // 0x0000000189ACA4A0-0x0000000189ACA4C0
	private void StimulateMusic(uint dialog, bool start) {} // 0x0000000183735040-0x0000000183735150
	// [XID] // 0x0000000189AA7B40-0x0000000189AA7B60
	private void PostEventByDialog(ConfigWwiseString eventName) {} // 0x00000001837332F0-0x00000001837333D0
	// [XID] // 0x0000000189AB6D40-0x0000000189AB6D60
	private void SetStatesByDialog(AudioStateOp[] stateOps) {} // 0x0000000183734B30-0x0000000183734CE0
	// [XID] // 0x0000000189AE15D0-0x0000000189AE15F0
	public void PostVideoStartEvent(string videoName) {} // 0x0000000183732230-0x0000000183732370
	// [XID] // 0x000000018991B530-0x000000018991B550
	public void PostVideoEndEvent(string videoName) {} // 0x0000000183735400-0x0000000183735540
	// [XID] // 0x0000000189940730-0x0000000189940750
	public void PostGlobalMidiEvent(int instrument, int note) {} // 0x0000000183732570-0x0000000183732680
	// [XID] // 0x0000000189AF7EB0-0x0000000189AF7ED0
	public void PostMidiEvent(SyncId syncId, int instrument, int note, bool changeGameViewState = true /* Metadata: 0x00AE9866 */) {} // 0x0000000183733C90-0x0000000183733EA0
}

