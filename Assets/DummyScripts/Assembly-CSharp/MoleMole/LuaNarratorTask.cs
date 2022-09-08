/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public sealed class LuaNarratorTask : LuaTask, IDialogVoiceEventResponder // TypeDefIndex: 21156
	{
		// Fields
		private ILuaNarratorData _data; // 0x78
		private bool _checkRange; // 0x80
		private List<uint> _dialogList; // 0x88
		private uint _narratorId; // 0x90
		private float _narratorPauseLen; // 0x94
		private float _narratorResumeLen; // 0x98
		private int _dialogIndex; // 0x9C
		private uint _mainQuestId; // 0xA0
		private bool _needResumePerform; // 0xA4
		private bool _isWaiting; // 0xA5
		private bool _isListFromLoading; // 0xA6
		private bool _isDefaultInterval; // 0xA7
		private float _defaultIntervalCnt; // 0xA8
		private static float DEFAULT_INTERVAL; // 0x00
		private bool _isDefaultAudioInterval; // 0xAC
		private float _defaultAudioIntervalCnt; // 0xB0
		private static float DEFAULT_AUDIO_INTERVAL; // 0x04
		private EntityActor _entityActor; // 0xB8
		private bool _isPauseByUser; // 0xC0
		private bool _isImmediatePause; // 0xC1
	
		// Properties
		public int dialogIndex { /* [XID] */ /* 0x0000000189669C00-0x0000000189669C20 */ get => default; /* [XID] */ /* 0x0000000189671840-0x0000000189671860 */ set {} } // 0x0000000184F12AB0-0x0000000184F12B50 0x0000000184F12C10-0x0000000184F12CC0
		private bool isRealPaused { /* [XID] */ /* 0x000000018968B190-0x000000018968B1B0 */ get => default; } // 0x0000000184F12B50-0x0000000184F12C10 
	
		// Constructors
		public LuaNarratorTask() {} // 0x0000000184F129F0-0x0000000184F12AB0
		static LuaNarratorTask() {} // 0x0000000184F12980-0x0000000184F129F0
	
		// Methods
		[BlackList] // 0x0000000189679030-0x0000000189679070
		// [XID] // 0x0000000189679030-0x0000000189679070
		public void InitData(ILuaNarratorData data, bool checkRange, uint mainQuestId) {} // 0x0000000184F11830-0x0000000184F11AD0
		// [XID] // 0x0000000189683550-0x0000000189683570
		private void FinishNarrator(ILuaActor actor, LuaTask task) {} // 0x0000000184F11760-0x0000000184F11830
		// [XID] // 0x0000000189692E70-0x0000000189692E90
		public void RespondToDialogVoiceEvent(uint dialogId, bool startPlaying) {} // 0x0000000184F12000-0x0000000184F121D0
		// [XID] // 0x000000018969A0F0-0x000000018969A110
		public override void StartTask() {} // 0x0000000184F121D0-0x0000000184F12370
		// [XID] // 0x00000001896A1900-0x00000001896A1920
		private bool CheckPause() => default; // 0x0000000184F11520-0x0000000184F11650
		// [XID] // 0x00000001896A8E00-0x00000001896A8E20
		public override void OnPause() {} // 0x0000000184F11AD0-0x0000000184F11B80
		// [XID] // 0x00000001896AFEB0-0x00000001896AFED0
		public override void OnResume() {} // 0x0000000184F11B80-0x0000000184F11C50
		// [XID] // 0x00000001896B77E0-0x00000001896B7800
		public void TryPause(bool pauseImmediately) {} // 0x0000000184F12590-0x0000000184F12670
		// [XID] // 0x00000001896BE950-0x00000001896BE970
		public void TryResume() {} // 0x0000000184F12670-0x0000000184F12740
		// [XID] // 0x00000001896C6250-0x00000001896C6270
		private void AsyncStartTask() {} // 0x0000000184F11070-0x0000000184F11220
		// [XID] // 0x00000001896CD870-0x00000001896CD890
		private void PerformNarrator() {} // 0x0000000184F11D80-0x0000000184F11F30
		// [XID] // 0x00000001896D4CE0-0x00000001896D4D00
		private bool PerformNarratorInternal() => default; // 0x0000000184F11C50-0x0000000184F11D80
		// [XID] // 0x00000001896DC340-0x00000001896DC360
		private bool CheckDefaultAudioInterval() => default; // 0x0000000184F11220-0x0000000184F113C0
		// [XID] // 0x00000001896E3B90-0x00000001896E3BB0
		private bool CheckDefaultInterval() => default; // 0x0000000184F113C0-0x0000000184F11520
		// [XID] // 0x00000001896EAF40-0x00000001896EAF60
		protected override void TickInternal() {} // 0x0000000184F12370-0x0000000184F12590
		// [XID] // 0x00000001896F2330-0x00000001896F2350
		protected override void DestroyInternal() {} // 0x0000000184F11650-0x0000000184F11760
		// [XID] // 0x00000001896F9CB0-0x00000001896F9CD0
		protected override void ReleaseTask() {} // 0x0000000184F11F30-0x0000000184F12000
	}
}
