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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelSceneReminderPlugin : BaseComponentPlugin, IDialogVoiceEventResponder // TypeDefIndex: 12111
{
	// Fields
	private Dictionary<ReminderStyleType, LevelSceneReminderImp> _allReminders; // 0x58

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018979DED0-0x000000018979DEF0 */ get => default; } // 0x00000001833071E0-0x0000000183307280 

	// Nested types
	private class LevelSceneReminderImp // TypeDefIndex: 12112
	{
		// Fields
		private EntityTimer _timer; // 0x10
		private ReminderExcelConfig _config; // 0x18
		private object[] _configParam; // 0x20
		private LevelSceneReminderPlugin _manager; // 0x28
		private bool _postSpeechEvent; // 0x30

		// Properties
		public bool isVoiceOn { /* [XID] */ /* 0x00000001897F8980-0x00000001897F89A0 */ get => default; } // 0x00000001833135D0-0x0000000183313680 

		// Constructors
		public LevelSceneReminderImp() {} // 0x00000001833146E0-0x0000000183314750

		// Methods
		// [XID] // 0x0000000189800040-0x0000000189800060
		public void Init(BaseEntity entity, LevelSceneReminderPlugin manager) {} // 0x0000000183313B20-0x0000000183313C40
		// [XID] // 0x0000000189807740-0x0000000189807760
		public void Tick(float inDeltaTime) {} // 0x0000000183313EC0-0x0000000183313F90
		// [XID] // 0x000000018980EDA0-0x000000018980EDC0
		public void Destroy() {} // 0x0000000183313360-0x0000000183313450
		// [XID] // 0x0000000189816430-0x0000000189816450
		public void AddReminder(uint id, float exDelay, object[] strParams) {} // 0x0000000183313450-0x00000001833135D0
		// [XID] // 0x000000018981DDF0-0x000000018981DE10
		public bool InterruptCurReminder() => default; // 0x00000001833132B0-0x0000000183313360
		// [XID] // 0x00000001898251A0-0x00000001898251C0
		private void OnReminderEnd() {} // 0x0000000183313F90-0x0000000183314030
		// [XID] // 0x000000018982CB90-0x000000018982CBB0
		private bool CloseReminder(bool interrupt) => default; // 0x0000000183313C40-0x0000000183313EC0
		// [XID] // 0x00000001898342E0-0x0000000189834300
		private void ShowReminder() {} // 0x0000000183314200-0x00000001833146E0
		[DebuggerHidden] // 0x000000018983B650-0x000000018983B690
		// [XID] // 0x000000018983B650-0x000000018983B690
		private IEnumerator CheckAndShowBannerReminder(InLevelMainPageContext pageContext) => default; // 0x0000000183313A00-0x0000000183313B20
		// [XID] // 0x0000000189845DB0-0x0000000189845DD0
		private void ShowBannerReminder() {} // 0x0000000183314030-0x0000000183314200
		// [XID] // 0x000000018984D340-0x000000018984D360
		private void PostReminderSpeechEvent() {} // 0x0000000183313680-0x00000001833137C0
		// [XID] // 0x0000000189854430-0x0000000189854450
		private void PostReminderStopSpeechEvent() {} // 0x00000001833137C0-0x00000001833138F0
		// [XID] // 0x000000018985BDA0-0x000000018985BDC0
		public void RespondToDialogVoiceEvent(uint reminderId, bool startPlaying) {} // 0x00000001833138F0-0x0000000183313A00
	}

	// Constructors
	public LevelSceneReminderPlugin() {} // 0x0000000183307150-0x00000001833071E0

	// Methods
	// [XID] // 0x00000001897A5380-0x00000001897A53A0
	public override void Init() {} // 0x00000001833069C0-0x0000000183306A70
	// [XID] // 0x00000001897ACA20-0x00000001897ACA40
	public override void Tick(float inDeltaTime) {} // 0x0000000183306F80-0x0000000183307150
	// [XID] // 0x00000001897B4780-0x00000001897B47A0
	public override void Destroy() {} // 0x0000000183306160-0x0000000183306350
	// [XID] // 0x00000001897BC710-0x00000001897BC730
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000183306680-0x0000000183306780
	// [XID] // 0x00000001897C3B90-0x00000001897C3BB0
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000183306C90-0x0000000183306DB0
	// [XID] // 0x00000001897CB4C0-0x00000001897CB4E0
	private void AddReminder(uint id, object[] strParams = null) {} // 0x0000000183305FC0-0x0000000183306160
	// [XID] // 0x00000001897D2BA0-0x00000001897D2BC0
	public bool IsCurReminderVoiceOn(ReminderStyleType type) => default; // 0x0000000183306BC0-0x0000000183306C90
	// [XID] // 0x00000001897DA900-0x00000001897DA920
	private bool InterruptAllReminder(ReminderStyleType? type) => default; // 0x0000000183306350-0x0000000183306600
	// [XID] // 0x00000001897E1D20-0x00000001897E1D40
	private LevelSceneReminderImp GetReminder(ReminderStyleType style) => default; // 0x0000000183306860-0x00000001833069C0
	// [XID] // 0x00000001897E94F0-0x00000001897E9510
	private LevelSceneReminderImp TryGetReminder(ReminderStyleType style) => default; // 0x0000000183306780-0x0000000183306860
	// [XID] // 0x00000001897F10C0-0x00000001897F10E0
	public void RespondToDialogVoiceEvent(uint reminderId, bool startPlaying) {} // 0x0000000183306DB0-0x0000000183306F80
}

