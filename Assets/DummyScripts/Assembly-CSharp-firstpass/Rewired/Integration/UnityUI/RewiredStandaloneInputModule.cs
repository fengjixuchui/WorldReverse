/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using Rewired;
using Rewired.Components;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired.Integration.UnityUI
{
	// [AddComponentMenu] // 0x00000001897575A0-0x00000001897575D0
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule // TypeDefIndex: 9811
	{
		// Fields
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal"; // Metadata: 0x00AE6312
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical"; // Metadata: 0x00AE6322
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit"; // Metadata: 0x00AE6330
		private const string DEFAULT_ACTION_CANCEL = "UICancel"; // Metadata: 0x00AE633C
		[SerializeField] // 0x0000000189760570-0x00000001897605C0
		// [Tooltip] // 0x0000000189760570-0x00000001897605C0
		private InputManager_Base rewiredInputManager; // 0x70
		[SerializeField] // 0x000000018976C400-0x000000018976C450
		// [Tooltip] // 0x000000018976C400-0x000000018976C450
		private bool useAllRewiredGamePlayers; // 0x78
		[SerializeField] // 0x0000000189778130-0x0000000189778180
		// [Tooltip] // 0x0000000189778130-0x0000000189778180
		private bool useRewiredSystemPlayer; // 0x79
		[SerializeField] // 0x0000000189784240-0x0000000189784290
		// [Tooltip] // 0x0000000189784240-0x0000000189784290
		private int[] rewiredPlayerIds; // 0x80
		[SerializeField] // 0x000000018978FFF0-0x0000000189790030
		// [Tooltip] // 0x000000018978FFF0-0x0000000189790030
		private bool usePlayingPlayersOnly; // 0x88
		[SerializeField] // 0x000000018979C690-0x000000018979C6E0
		// [Tooltip] // 0x000000018979C690-0x000000018979C6E0
		private List<Rewired.Components.PlayerMouse> playerMice; // 0x90
		[SerializeField] // 0x00000001897A8290-0x00000001897A82D0
		// [Tooltip] // 0x00000001897A8290-0x00000001897A82D0
		private bool moveOneElementPerAxisPress; // 0x98
		[SerializeField] // 0x00000001897B4A20-0x00000001897B4A70
		// [Tooltip] // 0x00000001897B4A20-0x00000001897B4A70
		private bool setActionsById; // 0x99
		[SerializeField] // 0x00000001897C0FB0-0x00000001897C0FF0
		// [Tooltip] // 0x00000001897C0FB0-0x00000001897C0FF0
		private int horizontalActionId; // 0x9C
		[SerializeField] // 0x00000001897CD010-0x00000001897CD060
		// [Tooltip] // 0x00000001897CD010-0x00000001897CD060
		private int verticalActionId; // 0xA0
		[SerializeField] // 0x00000001897D9350-0x00000001897D93A0
		// [Tooltip] // 0x00000001897D9350-0x00000001897D93A0
		private int submitActionId; // 0xA4
		[SerializeField] // 0x00000001897E4EB0-0x00000001897E4EF0
		// [Tooltip] // 0x00000001897E4EB0-0x00000001897E4EF0
		private int cancelActionId; // 0xA8
		[SerializeField] // 0x00000001897F1400-0x00000001897F1440
		// [Tooltip] // 0x00000001897F1400-0x00000001897F1440
		private string m_HorizontalAxis; // 0xB0
		[SerializeField] // 0x00000001897FD190-0x00000001897FD1E0
		// [Tooltip] // 0x00000001897FD190-0x00000001897FD1E0
		private string m_VerticalAxis; // 0xB8
		[SerializeField] // 0x0000000189808F30-0x0000000189808F70
		// [Tooltip] // 0x0000000189808F30-0x0000000189808F70
		private string m_SubmitButton; // 0xC0
		[SerializeField] // 0x0000000189814C50-0x0000000189814C90
		// [Tooltip] // 0x0000000189814C50-0x0000000189814C90
		private string m_CancelButton; // 0xC8
		[SerializeField] // 0x0000000189821300-0x0000000189821350
		// [Tooltip] // 0x0000000189821300-0x0000000189821350
		private float m_InputActionsPerSecond; // 0xD0
		[SerializeField] // 0x000000018982CD10-0x000000018982CD50
		// [Tooltip] // 0x000000018982CD10-0x000000018982CD50
		private float m_RepeatDelay; // 0xD4
		[SerializeField] // 0x0000000189838AC0-0x0000000189838B00
		// [Tooltip] // 0x0000000189838AC0-0x0000000189838B00
		private bool m_allowMouseInput; // 0xD8
		[SerializeField] // 0x0000000189844A40-0x0000000189844A90
		// [Tooltip] // 0x0000000189844A40-0x0000000189844A90
		private bool m_allowMouseInputIfTouchSupported; // 0xD9
		[SerializeField] // 0x00000001898503C0-0x0000000189850400
		// [Tooltip] // 0x00000001898503C0-0x0000000189850400
		private bool m_allowTouchInput; // 0xDA
		// [FormerlySerializedAs] // 0x000000018985BFF0-0x000000018985C060
		[SerializeField] // 0x000000018985BFF0-0x000000018985C060
		// [Tooltip] // 0x000000018985BFF0-0x000000018985C060
		private bool m_ForceModuleActive; // 0xDB
		[NonSerialized]
		private int[] playerIds; // 0xE0
		private bool recompiling; // 0xE8
		[NonSerialized]
		private bool isTouchSupported; // 0xE9
		[NonSerialized]
		private float m_PrevActionTime; // 0xEC
		[NonSerialized]
		private Vector2 m_LastMoveVector; // 0xF0
		[NonSerialized]
		private int m_ConsecutiveMoveCount; // 0xF8
		[NonSerialized]
		private bool m_HasFocus; // 0xFC
	
		// Properties
		public InputManager_Base RewiredInputManager { /* [XID] */ /* 0x0000000189737220-0x0000000189737240 */ get => default; /* [XID] */ /* 0x0000000189871F10-0x0000000189871F30 */ set {} } // 0x00000001873522C0-0x0000000187352360 0x0000000187353680-0x0000000187353730
		public bool UseAllRewiredGamePlayers { /* [XID] */ /* 0x00000001898797C0-0x00000001898797E0 */ get => default; /* [XID] */ /* 0x0000000189880D90-0x0000000189880DB0 */ set {} } // 0x00000001873525B0-0x0000000187352650 0x0000000187353AD0-0x0000000187353B90
		public bool UseRewiredSystemPlayer { /* [XID] */ /* 0x0000000189995150-0x0000000189995170 */ get => default; /* [XID] */ /* 0x000000018988F6E0-0x000000018988F700 */ set {} } // 0x0000000187352700-0x00000001873527A0 0x0000000187353C40-0x0000000187353D00
		public int[] RewiredPlayerIds { /* [XID] */ /* 0x00000001896FFFA0-0x00000001896FFFC0 */ get => default; /* [XID] */ /* 0x0000000189B17900-0x0000000189B17920 */ set {} } // 0x0000000187352360-0x0000000187352460 0x0000000187353730-0x0000000187353850
		public bool UsePlayingPlayersOnly { /* [XID] */ /* 0x0000000189B44710-0x0000000189B44730 */ get => default; /* [XID] */ /* 0x00000001898AD000-0x00000001898AD020 */ set {} } // 0x0000000187352650-0x0000000187352700 0x0000000187353B90-0x0000000187353C40
		public List<Rewired.Components.PlayerMouse> PlayerMice { /* [XID] */ /* 0x00000001898B4540-0x00000001898B4560 */ get => default; /* [XID] */ /* 0x000000018963E420-0x000000018963E440 */ set {} } // 0x00000001873521F0-0x00000001873522C0 0x0000000187353580-0x0000000187353680
		public bool MoveOneElementPerAxisPress { /* [XID] */ /* 0x0000000189707670-0x0000000189707690 */ get => default; /* [XID] */ /* 0x0000000189BA9560-0x0000000189BA9580 */ set {} } // 0x0000000187352140-0x00000001873521F0 0x00000001873534D0-0x0000000187353580
		public bool allowMouseInput { /* [XID] */ /* 0x00000001898D27B0-0x00000001898D27D0 */ get => default; /* [XID] */ /* 0x00000001898DA070-0x00000001898DA090 */ set {} } // 0x00000001873529A0-0x0000000187352A50 0x0000000187354020-0x00000001873540D0
		public bool allowMouseInputIfTouchSupported { /* [XID] */ /* 0x0000000189A8A720-0x0000000189A8A740 */ get => default; /* [XID] */ /* 0x0000000189A91F60-0x0000000189A91F80 */ set {} } // 0x00000001873528F0-0x00000001873529A0 0x0000000187353F70-0x0000000187354020
		public bool allowTouchInput { /* [XID] */ /* 0x00000001899817C0-0x00000001899817E0 */ get => default; /* [XID] */ /* 0x00000001898F88A0-0x00000001898F88C0 */ set {} } // 0x0000000187352A50-0x0000000187352B00 0x00000001873540D0-0x0000000187354180
		public bool SetActionsById { /* [XID] */ /* 0x0000000189A4FB60-0x0000000189A4FB80 */ get => default; /* [XID] */ /* 0x00000001898FC050-0x00000001898FC070 */ set {} } // 0x0000000187352460-0x0000000187352510 0x0000000187353850-0x0000000187353910
		public int HorizontalActionId { /* [XID] */ /* 0x000000018990F140-0x000000018990F160 */ get => default; /* [XID] */ /* 0x0000000189916A00-0x0000000189916A20 */ set {} } // 0x00000001873520A0-0x0000000187352140 0x0000000187353310-0x00000001873534D0
		public int VerticalActionId { /* [XID] */ /* 0x0000000189AA9960-0x0000000189AA9980 */ get => default; /* [XID] */ /* 0x0000000189A7CEF0-0x0000000189A7CF10 */ set {} } // 0x00000001873527A0-0x0000000187352840 0x0000000187353D00-0x0000000187353EC0
		public int SubmitActionId { /* [XID] */ /* 0x000000018992CF80-0x000000018992CFA0 */ get => default; /* [XID] */ /* 0x0000000189934650-0x0000000189934670 */ set {} } // 0x0000000187352510-0x00000001873525B0 0x0000000187353910-0x0000000187353AD0
		public int CancelActionId { /* [XID] */ /* 0x00000001899E3730-0x00000001899E3750 */ get => default; /* [XID] */ /* 0x00000001899EAAE0-0x00000001899EAB00 */ set {} } // 0x0000000187352000-0x00000001873520A0 0x0000000187353150-0x0000000187353310
		protected override bool isMouseSupported { /* [XID] */ /* 0x000000018994ACB0-0x000000018994ACD0 */ get => default; } // 0x0000000187352DC0-0x0000000187352E90 
		private bool isTouchAllowed { /* [XID] */ /* 0x0000000189952680-0x00000001899526A0 */ get => default; } // 0x0000000187352E90-0x0000000187352F40 
		[Obsolete] // 0x0000000189AD83B0-0x0000000189AD83E0
		public bool allowActivationOnMobileDevice { /* [XID] */ /* 0x0000000189959AD0-0x0000000189959AF0 */ get => default; /* [XID] */ /* 0x0000000189961450-0x0000000189961470 */ set {} } // 0x0000000187352840-0x00000001873528F0 0x0000000187353EC0-0x0000000187353F70
		public bool forceModuleActive { /* [XID] */ /* 0x0000000189968AF0-0x0000000189968B10 */ get => default; /* [XID] */ /* 0x0000000189970140-0x0000000189970160 */ set {} } // 0x0000000187352BB0-0x0000000187352C60 0x00000001873542F0-0x00000001873543A0
		public float inputActionsPerSecond { /* [XID] */ /* 0x0000000189977F90-0x0000000189977FB0 */ get => default; /* [XID] */ /* 0x000000018997F0B0-0x000000018997F0D0 */ set {} } // 0x0000000187352D10-0x0000000187352DC0 0x0000000187354510-0x00000001873545C0
		public float repeatDelay { /* [XID] */ /* 0x0000000189986AF0-0x0000000189986B10 */ get => default; /* [XID] */ /* 0x000000018998E610-0x000000018998E630 */ set {} } // 0x0000000187352F40-0x0000000187352FF0 0x00000001873545C0-0x0000000187354670
		public string horizontalAxis { /* [XID] */ /* 0x0000000189996180-0x00000001899961A0 */ get => default; /* [XID] */ /* 0x0000000189AF3450-0x0000000189AF3470 */ set {} } // 0x0000000187352C60-0x0000000187352D10 0x00000001873543A0-0x0000000187354510
		public string verticalAxis { /* [XID] */ /* 0x00000001899A5400-0x00000001899A5420 */ get => default; /* [XID] */ /* 0x0000000189B2CE10-0x0000000189B2CE30 */ set {} } // 0x00000001873530A0-0x0000000187353150 0x00000001873547E0-0x0000000187354950
		public string submitButton { /* [XID] */ /* 0x00000001899B46B0-0x00000001899B46D0 */ get => default; /* [XID] */ /* 0x00000001899BBBE0-0x00000001899BBC00 */ set {} } // 0x0000000187352FF0-0x00000001873530A0 0x0000000187354670-0x00000001873547E0
		public string cancelButton { /* [XID] */ /* 0x00000001899C37C0-0x00000001899C37E0 */ get => default; /* [XID] */ /* 0x0000000189608A30-0x0000000189608A50 */ set {} } // 0x0000000187352B00-0x0000000187352BB0 0x0000000187354180-0x00000001873542F0
	
		// Nested types
		[Serializable]
		public class PlayerSetting // TypeDefIndex: 9812
		{
			// Fields
			public int playerId; // 0x10
			public List<Rewired.Components.PlayerMouse> playerMice; // 0x18
	
			// Constructors
			public PlayerSetting() {} // 0x0000000187346A00-0x0000000187346A90
			private PlayerSetting(PlayerSetting other) {} // 0x0000000187346A90-0x0000000187346C80
	
			// Methods
			// [XID] // 0x0000000189ABDA30-0x0000000189ABDA50
			public PlayerSetting Clone() => default; // 0x0000000187346930-0x0000000187346A00
		}
	
		// Constructors
		private RewiredStandaloneInputModule() {} // 0x0000000187351EC0-0x0000000187352000
	
		// Methods
		// [XID] // 0x00000001899D2340-0x00000001899D2360
		protected override void Awake() {} // 0x000000018734CC50-0x000000018734CE00
		// [XID] // 0x00000001899DBD10-0x00000001899DBD30
		public override void UpdateModule() {} // 0x0000000187351DD0-0x0000000187351EC0
		// [XID] // 0x00000001899E0FE0-0x00000001899E1000
		public override bool IsModuleSupported() => default; // 0x000000018734E200-0x000000018734E2A0
		// [XID] // 0x00000001899E8B20-0x00000001899E8B40
		public override bool ShouldActivateModule() => default; // 0x00000001873514D0-0x0000000187351990
		// [XID] // 0x00000001899F02A0-0x00000001899F02C0
		public override void ActivateModule() {} // 0x000000018734CAC0-0x000000018734CC50
		// [XID] // 0x00000001899F78A0-0x00000001899F78C0
		public override void DeactivateModule() {} // 0x000000018734D200-0x000000018734D2B0
		// [XID] // 0x00000001899FEF70-0x00000001899FEF90
		public override void Process() {} // 0x0000000187350020-0x00000001873501D0
		// [XID] // 0x0000000189601040-0x0000000189601060
		private bool ProcessTouchEvents() => default; // 0x000000018734F480-0x000000018734F7B0
		// [XID] // 0x0000000189A0DDC0-0x0000000189A0DDE0
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) {} // 0x000000018734F7B0-0x0000000187350020
		// [XID] // 0x0000000189A15440-0x0000000189A15460
		private bool SendSubmitEventToSelectedObject() => default; // 0x0000000187350600-0x0000000187350900
		// [XID] // 0x0000000189A1C640-0x0000000189A1C660
		private Vector2 GetRawMoveVector() => default; // 0x000000018734D950-0x000000018734DDA0
		// [XID] // 0x0000000189A23F30-0x0000000189A23F50
		private bool SendMoveEventToSelectedObject() => default; // 0x00000001873501D0-0x0000000187350600
		// [XID] // 0x0000000189A2B2B0-0x0000000189A2B2D0
		private void CheckButtonOrKeyMovement(float time, out bool downHorizontal, out bool downVertical) {
			downHorizontal = default;
			downVertical = default;
		} // 0x000000018734CE00-0x000000018734D050
		// [XID] // 0x0000000189A328D0-0x0000000189A328F0
		private void ProcessMouseEvents() {} // 0x000000018734EB00-0x000000018734ED00
		// [XID] // 0x0000000189A3A290-0x0000000189A3A2B0
		private void ProcessMouseEvent(int playerId, int pointerIndex) {} // 0x000000018734E650-0x000000018734EB00
		// [XID] // 0x0000000189A41AF0-0x0000000189A41B10
		private bool SendUpdateEventToSelectedObject() => default; // 0x0000000187350900-0x0000000187350AB0
		// [XID] // 0x0000000189A49150-0x0000000189A49170
		private void ProcessMousePress(MouseButtonEventData data) {} // 0x000000018734ED00-0x000000018734F480
		// [XID] // 0x0000000189A50AA0-0x0000000189A50AC0
		private void OnApplicationFocus(bool hasFocus) {} // 0x000000018734E2A0-0x000000018734E350
		// [XID] // 0x0000000189A57F60-0x0000000189A57F80
		private bool ShouldIgnoreEventsOnNoFocus() => default; // 0x0000000187351990-0x0000000187351AA0
		// [XID] // 0x0000000189AF1430-0x0000000189AF1450
		protected override void OnDestroy() {} // 0x000000018734E350-0x000000018734E460
		// [XID] // 0x0000000189A67540-0x0000000189A67560
		protected override bool IsDefaultPlayer(int playerId) => default; // 0x000000018734DFB0-0x000000018734E200
		// [XID] // 0x0000000189A6EB80-0x0000000189A6EBA0
		private void InitializeRewired() {} // 0x000000018734DDA0-0x000000018734DFB0
		// [XID] // 0x0000000189A763B0-0x0000000189A763D0
		private void SetupRewiredVars() {} // 0x0000000187351090-0x00000001873514D0
		// [XID] // 0x00000001896D7BB0-0x00000001896D7BD0
		private void SetUpRewiredPlayerMice() {} // 0x0000000187350EF0-0x0000000187351090
		// [XID] // 0x00000001896CA6B0-0x00000001896CA6D0
		private void SetUpRewiredActions() {} // 0x0000000187350AB0-0x0000000187350EF0
		// [XID] // 0x0000000189A8CF60-0x0000000189A8CF80
		private bool GetButtonDown(Player player, int actionId) => default; // 0x000000018734D5B0-0x000000018734D690
		// [XID] // 0x0000000189A94350-0x0000000189A94370
		private bool GetNegativeButtonDown(Player player, int actionId) => default; // 0x000000018734D870-0x000000018734D950
		// [XID] // 0x0000000189A9BCD0-0x0000000189A9BCF0
		private float GetAxis(Player player, int actionId) => default; // 0x000000018734D4C0-0x000000018734D5B0
		// [XID] // 0x0000000189AA32A0-0x0000000189AA32C0
		private void CheckEditorRecompile() {} // 0x000000018734D050-0x000000018734D130
		// [XID] // 0x0000000189AAA700-0x0000000189AAA720
		private void OnEditorRecompile() {} // 0x000000018734E460-0x000000018734E510
		// [XID] // 0x000000018978AD60-0x000000018978AD80
		private void ClearRewiredVars() {} // 0x000000018734D130-0x000000018734D200
		// [XID] // 0x0000000189AB99C0-0x0000000189AB99E0
		private bool DidAnyMouseMove() => default; // 0x000000018734D2B0-0x000000018734D4C0
		// [XID] // 0x0000000189AC15F0-0x0000000189AC1610
		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex) => default; // 0x000000018734D690-0x000000018734D870
		// [XID] // 0x0000000189AC8E40-0x0000000189AC8E60
		private void OnRewiredInitialized() {} // 0x000000018734E510-0x000000018734E5B0
		// [XID] // 0x0000000189AD0580-0x0000000189AD05A0
		private void OnRewiredShutDown() {} // 0x000000018734E5B0-0x000000018734E650
	}
}
