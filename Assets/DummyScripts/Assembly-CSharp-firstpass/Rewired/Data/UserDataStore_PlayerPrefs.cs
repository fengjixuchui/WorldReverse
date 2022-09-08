/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using Rewired;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired.Data
{
	public class UserDataStore_PlayerPrefs : UserDataStore // TypeDefIndex: 9826
	{
		// Fields
		private const string thisScriptName = "UserDataStore_PlayerPrefs"; // Metadata: 0x00AE6988
		private const string logPrefix = "Rewired: "; // Metadata: 0x00AE69A5
		private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component."; // Metadata: 0x00AE69B2
		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments"; // Metadata: 0x00AE6B7F
		[SerializeField] // 0x0000000189664890-0x00000001896648D0
		// [Tooltip] // 0x0000000189664890-0x00000001896648D0
		private bool isEnabled; // 0x18
		[SerializeField] // 0x0000000189670D00-0x0000000189670D50
		// [Tooltip] // 0x0000000189670D00-0x0000000189670D50
		private bool loadDataOnStart; // 0x19
		[SerializeField] // 0x000000018967CD40-0x000000018967CD90
		// [Tooltip] // 0x000000018967CD40-0x000000018967CD90
		private bool loadJoystickAssignments; // 0x1A
		[SerializeField] // 0x0000000189689090-0x00000001896890E0
		// [Tooltip] // 0x0000000189689090-0x00000001896890E0
		private bool loadKeyboardAssignments; // 0x1B
		[SerializeField] // 0x00000001896951C0-0x0000000189695210
		// [Tooltip] // 0x00000001896951C0-0x0000000189695210
		private bool loadMouseAssignments; // 0x1C
		[SerializeField] // 0x00000001896A0E60-0x00000001896A0EB0
		// [Tooltip] // 0x00000001896A0E60-0x00000001896A0EB0
		private string playerPrefsKeyPrefix; // 0x20
		[NonSerialized]
		private bool allowImpreciseJoystickAssignmentMatching; // 0x28
		[NonSerialized]
		private bool deferredJoystickAssignmentLoadPending; // 0x29
		[NonSerialized]
		private bool wasJoystickEverDetected; // 0x2A
		[NonSerialized]
		private List<int> __allActionIds; // 0x30
		[NonSerialized]
		private string __allActionIdsString; // 0x38
	
		// Properties
		public bool IsEnabled { /* [XID] */ /* 0x00000001896ACBE0-0x00000001896ACC00 */ get => default; /* [XID] */ /* 0x00000001899AC050-0x00000001899AC070 */ set {} } // 0x00000001862DF750-0x00000001862DF7F0 0x00000001862E0080-0x00000001862E0130
		public bool LoadDataOnStart { /* [XID] */ /* 0x00000001896BB4C0-0x00000001896BB4E0 */ get => default; /* [XID] */ /* 0x0000000189951920-0x0000000189951940 */ set {} } // 0x00000001862DF7F0-0x00000001862DF890 0x00000001862E0130-0x00000001862E01E0
		public bool LoadJoystickAssignments { /* [XID] */ /* 0x00000001896C9CD0-0x00000001896C9CF0 */ get => default; /* [XID] */ /* 0x00000001896D14C0-0x00000001896D14E0 */ set {} } // 0x00000001862DF890-0x00000001862DF930 0x00000001862E01E0-0x00000001862E0290
		public bool LoadKeyboardAssignments { /* [XID] */ /* 0x00000001899559A0-0x00000001899559C0 */ get => default; /* [XID] */ /* 0x0000000189900A90-0x0000000189900AB0 */ set {} } // 0x00000001862DF930-0x00000001862DF9D0 0x00000001862E0290-0x00000001862E0340
		public bool LoadMouseAssignments { /* [XID] */ /* 0x00000001896E76C0-0x00000001896E76E0 */ get => default; /* [XID] */ /* 0x00000001896EED80-0x00000001896EEDA0 */ set {} } // 0x00000001862DF9D0-0x00000001862DFA70 0x00000001862E0340-0x00000001862E03F0
		public string PlayerPrefsKeyPrefix { /* [XID] */ /* 0x00000001896F6760-0x00000001896F6780 */ get => default; /* [XID] */ /* 0x00000001896FDF00-0x00000001896FDF20 */ set {} } // 0x00000001862DFA70-0x00000001862DFB10 0x00000001862E03F0-0x00000001862E04A0
		private string playerPrefsKey_controllerAssignments { /* [XID] */ /* 0x0000000189963500-0x0000000189963520 */ get => default; } // 0x00000001862DFFA0-0x00000001862E0080 
		private bool loadControllerAssignments { /* [XID] */ /* 0x000000018960FF30-0x000000018960FF50 */ get => default; } // 0x00000001862DFEE0-0x00000001862DFFA0 
		private List<int> allActionIds { /* [XID] */ /* 0x0000000189714190-0x00000001897141B0 */ get => default; } // 0x00000001862DFCD0-0x00000001862DFEE0 
		private string allActionIdsString { /* [XID] */ /* 0x000000018971BC30-0x000000018971BC50 */ get => default; } // 0x00000001862DFB10-0x00000001862DFCD0 
	
		// Nested types
		private class ControllerAssignmentSaveInfo // TypeDefIndex: 9827
		{
			// Fields
			public PlayerInfo[] players; // 0x10
	
			// Properties
			public int playerCount { /* [XID] */ /* 0x0000000189961430-0x0000000189961450 */ get => default; } // 0x00000001862C8C80-0x00000001862C8D30 
	
			// Nested types
			public class PlayerInfo // TypeDefIndex: 9828
			{
				// Fields
				public int id; // 0x10
				public bool hasKeyboard; // 0x14
				public bool hasMouse; // 0x15
				public JoystickInfo[] joysticks; // 0x18
	
				// Properties
				public int joystickCount { /* [XID] */ /* 0x0000000189615A00-0x0000000189615A20 */ get => default; } // 0x00000001862C92A0-0x00000001862C9350 
	
				// Constructors
				public PlayerInfo() {} // 0x00000001862C9240-0x00000001862C92A0
	
				// Methods
				// [XID] // 0x000000018997F090-0x000000018997F0B0
				public int IndexOfJoystick(int joystickId) => default; // 0x00000001862C90F0-0x00000001862C9240
				// [XID] // 0x0000000189986AD0-0x0000000189986AF0
				public bool ContainsJoystick(int joystickId) => default; // 0x00000001862C9030-0x00000001862C90F0
			}
	
			public class JoystickInfo // TypeDefIndex: 9829
			{
				// Fields
				public Guid instanceGuid; // 0x10
				public string hardwareIdentifier; // 0x20
				public int id; // 0x28
	
				// Constructors
				public JoystickInfo() {} // 0x00000001862C8DF0-0x00000001862C8E50
			}
	
			// Constructors
			public ControllerAssignmentSaveInfo() {} // 0x00000001862C8C20-0x00000001862C8C80
			public ControllerAssignmentSaveInfo(int playerCount) {} // 0x00000001862C8AC0-0x00000001862C8C20
	
			// Methods
			// [XID] // 0x0000000189968AD0-0x0000000189968AF0
			public int IndexOfPlayer(int playerId) => default; // 0x00000001862C8970-0x00000001862C8AC0
			// [XID] // 0x0000000189970120-0x0000000189970140
			public bool ContainsPlayer(int playerId) => default; // 0x00000001862C88B0-0x00000001862C8970
		}
	
		private class JoystickAssignmentHistoryInfo // TypeDefIndex: 9830
		{
			// Fields
			public readonly Joystick joystick; // 0x10
			public readonly int oldJoystickId; // 0x18
	
			// Constructors
			public JoystickAssignmentHistoryInfo() {} // Dummy constructor
			public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId) {} // 0x00000001862C8D30-0x00000001862C8DF0
		}
	
		// Constructors
		public UserDataStore_PlayerPrefs() {} // 0x00000001862DF6D0-0x00000001862DF750
	
		// Methods
		// [XID] // 0x0000000189722F40-0x0000000189722F60
		public override void Save() {} // 0x00000001862DF1A0-0x00000001862DF280
		// [IDTag] // 0x000000018972A650-0x000000018972A690
		// [XID] // 0x000000018972A650-0x000000018972A690
		public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId) {} // 0x00000001862DDC30-0x00000001862DDD50
		// [IDTag] // 0x0000000189734D90-0x0000000189734DD0
		// [XID] // 0x0000000189734D90-0x0000000189734DD0
		public override void SaveControllerData(ControllerType controllerType, int controllerId) {} // 0x00000001862DDD50-0x00000001862DDE60
		// [XID] // 0x000000018963CC00-0x000000018963CC20
		public override void SavePlayerData(int playerId) {} // 0x00000001862DF0B0-0x00000001862DF1A0
		// [XID] // 0x000000018980AFF0-0x000000018980B010
		public override void SaveInputBehavior(int playerId, int behaviorId) {} // 0x00000001862DE7D0-0x00000001862DE8E0
		// [XID] // 0x000000018974E850-0x000000018974E870
		public override void Load() {} // 0x00000001862DCC70-0x00000001862DCD50
		// [IDTag] // 0x0000000189755F70-0x0000000189755FB0
		// [XID] // 0x0000000189755F70-0x0000000189755FB0
		public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId) {} // 0x00000001862DA530-0x00000001862DA650
		// [IDTag] // 0x0000000189760530-0x0000000189760570
		// [XID] // 0x0000000189760530-0x0000000189760570
		public override void LoadControllerData(ControllerType controllerType, int controllerId) {} // 0x00000001862DA650-0x00000001862DA760
		// [XID] // 0x0000000189B5AD90-0x0000000189B5ADB0
		public override void LoadPlayerData(int playerId) {} // 0x00000001862DCB80-0x00000001862DCC70
		// [XID] // 0x0000000189772210-0x0000000189772230
		public override void LoadInputBehavior(int playerId, int behaviorId) {} // 0x00000001862DB160-0x00000001862DB270
		// [XID] // 0x0000000189779980-0x00000001897799A0
		protected override void OnInitialize() {} // 0x00000001862DD030-0x00000001862DD140
		// [XID] // 0x0000000189B71510-0x0000000189B71530
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args) {} // 0x00000001862DCD50-0x00000001862DCE80
		// [XID] // 0x0000000189788880-0x00000001897888A0
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args) {} // 0x00000001862DCF50-0x00000001862DD030
		// [XID] // 0x00000001896FCC90-0x00000001896FCCB0
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args) {} // 0x00000001862DCE80-0x00000001862DCF50
		// [IDTag] // 0x00000001897977C0-0x0000000189797800
		// [XID] // 0x00000001897977C0-0x0000000189797800
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap) {} // 0x00000001862DE010-0x00000001862DE130
		// [IDTag] // 0x00000001897A2410-0x00000001897A2450
		// [XID] // 0x00000001897A2410-0x00000001897A2450
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x00000001862DA760-0x00000001862DA940
		// [XID] // 0x00000001897ACC40-0x00000001897ACC60
		private int LoadAll() => default; // 0x00000001862D9ED0-0x00000001862DA0C0
		// [IDTag] // 0x00000001897B49E0-0x00000001897B4A20
		// [XID] // 0x00000001897B49E0-0x00000001897B4A20
		private int LoadPlayerDataNow(int playerId) => default; // 0x00000001862DCA80-0x00000001862DCB80
		// [IDTag] // 0x00000001897BFA70-0x00000001897BFAB0
		// [XID] // 0x00000001897BFA70-0x00000001897BFAB0
		private int LoadPlayerDataNow(Player player) => default; // 0x00000001862DC800-0x00000001862DCA80
		// [XID] // 0x000000018968E030-0x000000018968E050
		private int LoadAllJoystickCalibrationData() => default; // 0x00000001862D9D10-0x00000001862D9ED0
		// [IDTag] // 0x00000001897D1420-0x00000001897D1460
		// [XID] // 0x00000001897D1420-0x00000001897D1460
		private int LoadJoystickCalibrationData(Joystick joystick) => default; // 0x00000001862DC120-0x00000001862DC1F0
		// [IDTag] // 0x00000001897DBD70-0x00000001897DBDB0
		// [XID] // 0x00000001897DBD70-0x00000001897DBDB0
		private int LoadJoystickCalibrationData(int joystickId) => default; // 0x00000001862DC1F0-0x00000001862DC2F0
		// [XID] // 0x000000018985F1B0-0x000000018985F1D0
		private int LoadJoystickData(int joystickId) => default; // 0x00000001862DC2F0-0x00000001862DC530
		// [IDTag] // 0x00000001897EE1A0-0x00000001897EE1E0
		// [XID] // 0x00000001897EE1A0-0x00000001897EE1E0
		private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId) => default; // 0x00000001862DA330-0x00000001862DA450
		// [IDTag] // 0x00000001897F8AC0-0x00000001897F8B00
		// [XID] // 0x00000001897F8AC0-0x00000001897F8B00
		private int LoadControllerDataNow(ControllerType controllerType, int controllerId) => default; // 0x00000001862DA450-0x00000001862DA530
		// [XID] // 0x000000018970EE20-0x000000018970EE40
		private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId) => default; // 0x00000001862DAB20-0x00000001862DAE90
		// [IDTag] // 0x000000018980A790-0x000000018980A7D0
		// [XID] // 0x000000018980A790-0x000000018980A7D0
		private ControllerMap LoadControllerMap(Player player, Controller controller, int categoryId, int layoutId) => default; // 0x00000001862DA940-0x00000001862DAB20
		// [XID] // 0x00000001899FC4D0-0x00000001899FC4F0
		private int LoadInputBehaviors(int playerId) => default; // 0x00000001862DB270-0x00000001862DB4A0
		// [IDTag] // 0x000000018981C760-0x000000018981C7A0
		// [XID] // 0x000000018981C760-0x000000018981C7A0
		private int LoadInputBehaviorNow(int playerId, int behaviorId) => default; // 0x00000001862DAFF0-0x00000001862DB160
		// [IDTag] // 0x0000000189826E50-0x0000000189826E90
		// [XID] // 0x0000000189826E50-0x0000000189826E90
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior) => default; // 0x00000001862DAE90-0x00000001862DAFF0
		// [XID] // 0x0000000189803B30-0x0000000189803B50
		private bool LoadControllerAssignmentsNow() => default; // 0x00000001862DA230-0x00000001862DA330
		// [XID] // 0x0000000189B6E0E0-0x0000000189B6E100
		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data) => default; // 0x00000001862DC530-0x00000001862DC800
		// [XID] // 0x0000000189830450-0x0000000189830470
		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data) => default; // 0x00000001862DB5B0-0x00000001862DC120
		// [XID] // 0x00000001898476D0-0x00000001898476F0
		private ControllerAssignmentSaveInfo LoadControllerAssignmentData() => default; // 0x00000001862DA0C0-0x00000001862DA230
		[DebuggerHidden] // 0x000000018984EE00-0x000000018984EE40
		// [XID] // 0x000000018984EE00-0x000000018984EE40
		private IEnumerator LoadJoystickAssignmentsDeferred() => default; // 0x00000001862DB4A0-0x00000001862DB5B0
		// [XID] // 0x0000000189A98090-0x0000000189A980B0
		private void SaveAll() {} // 0x00000001862DD430-0x00000001862DD620
		// [IDTag] // 0x0000000189860410-0x0000000189860450
		// [XID] // 0x0000000189860410-0x0000000189860450
		private void SavePlayerDataNow(int playerId) {} // 0x00000001862DEFB0-0x00000001862DF0B0
		// [IDTag] // 0x000000018986AB50-0x000000018986AB90
		// [XID] // 0x000000018986AB50-0x000000018986AB90
		private void SavePlayerDataNow(Player player) {} // 0x00000001862DEE50-0x00000001862DEFB0
		// [XID] // 0x0000000189874C30-0x0000000189874C50
		private void SaveAllJoystickCalibrationData() {} // 0x00000001862DD270-0x00000001862DD430
		// [IDTag] // 0x000000018987C750-0x000000018987C790
		// [XID] // 0x000000018987C750-0x000000018987C790
		private void SaveJoystickCalibrationData(int joystickId) {} // 0x00000001862DEA30-0x00000001862DEB30
		// [IDTag] // 0x0000000189886BB0-0x0000000189886BF0
		// [XID] // 0x0000000189886BB0-0x0000000189886BF0
		private void SaveJoystickCalibrationData(Joystick joystick) {} // 0x00000001862DEB30-0x00000001862DEC40
		// [XID] // 0x0000000189890DA0-0x0000000189890DC0
		private void SaveJoystickData(int joystickId) {} // 0x00000001862DEC40-0x00000001862DEE50
		// [IDTag] // 0x00000001898983A0-0x00000001898983E0
		// [XID] // 0x00000001898983A0-0x00000001898983E0
		private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId) {} // 0x00000001862DDA50-0x00000001862DDB50
		// [IDTag] // 0x00000001898A2990-0x00000001898A29D0
		// [XID] // 0x00000001898A2990-0x00000001898A29D0
		private void SaveControllerDataNow(ControllerType controllerType, int controllerId) {} // 0x00000001862DDB50-0x00000001862DDC30
		// [IDTag] // 0x00000001898ACFC0-0x00000001898AD000
		// [XID] // 0x00000001898ACFC0-0x00000001898AD000
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData) {} // 0x00000001862DE130-0x00000001862DE370
		// [IDTag] // 0x00000001898B7710-0x00000001898B7750
		// [XID] // 0x00000001898B7710-0x00000001898B7750
		private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId) {} // 0x00000001862DE370-0x00000001862DE550
		// [IDTag] // 0x00000001898C1ED0-0x00000001898C1F10
		// [XID] // 0x00000001898C1ED0-0x00000001898C1F10
		private void SaveControllerMap(Player player, ControllerMap controllerMap) {} // 0x00000001862DDE60-0x00000001862DE010
		// [XID] // 0x000000018970ED40-0x000000018970ED60
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData) {} // 0x00000001862DE8E0-0x00000001862DEA30
		// [IDTag] // 0x00000001898D3E90-0x00000001898D3ED0
		// [XID] // 0x00000001898D3E90-0x00000001898D3ED0
		private void SaveInputBehaviorNow(int playerId, int behaviorId) {} // 0x00000001862DE650-0x00000001862DE7D0
		// [IDTag] // 0x00000001898DEEC0-0x00000001898DEF00
		// [XID] // 0x00000001898DEEC0-0x00000001898DEF00
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior) {} // 0x00000001862DE550-0x00000001862DE650
		// [XID] // 0x00000001898E9A70-0x00000001898E9A90
		private bool SaveControllerAssignments() => default; // 0x00000001862DD620-0x00000001862DDA50
		// [XID] // 0x00000001898F0EA0-0x00000001898F0EC0
		private bool ControllerAssignmentSaveDataExists() => default; // 0x00000001862D80F0-0x00000001862D8200
		// [XID] // 0x0000000189707480-0x00000001897074A0
		private string GetBasePlayerPrefsKey(Player player) => default; // 0x00000001862D8470-0x00000001862D8580
		// [XID] // 0x0000000189862150-0x0000000189862170
		private string GetControllerMapPlayerPrefsKey(Player player, Controller controller, int categoryId, int layoutId, bool includeDuplicateIndex) => default; // 0x00000001862D8D20-0x00000001862D91B0
		// [XID] // 0x0000000189907800-0x0000000189907820
		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, Controller controller, int categoryId, int layoutId, bool includeDuplicateIndex) => default; // 0x00000001862D8580-0x00000001862D8A10
		// [XID] // 0x000000018990F120-0x000000018990F140
		private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick) => default; // 0x00000001862D9A00-0x00000001862D9C00
		// [XID] // 0x00000001897ED3B0-0x00000001897ED3D0
		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId) => default; // 0x00000001862D9790-0x00000001862D98D0
		// [XID] // 0x0000000189716260-0x0000000189716280
		private string GetControllerMapXml(Player player, Controller controller, int categoryId, int layoutId) => default; // 0x00000001862D91B0-0x00000001862D9370
		// [XID] // 0x00000001899F4EE0-0x00000001899F4F00
		private List<int> GetControllerMapKnownActionIds(Player player, Controller controller, int categoryId, int layoutId) => default; // 0x00000001862D8A10-0x00000001862D8D20
		// [XID] // 0x0000000189AFE630-0x0000000189AFE650
		private string GetJoystickCalibrationMapXml(Joystick joystick) => default; // 0x00000001862D9C00-0x00000001862D9D10
		// [XID] // 0x000000018971DCA0-0x000000018971DCC0
		private string GetInputBehaviorXml(Player player, int id) => default; // 0x00000001862D98D0-0x00000001862D9A00
		// [XID] // 0x000000018993C1B0-0x000000018993C1D0
		private void AddDefaultMappingsForNewActions(ControllerMap controllerMap, List<int> knownActionIds) {} // 0x00000001862D7B70-0x00000001862D80F0
		// [XID] // 0x00000001899435C0-0x00000001899435E0
		private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo) => default; // 0x00000001862D8200-0x00000001862D8470
		// [XID] // 0x000000018994AC90-0x000000018994ACB0
		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches) {
			matches = default;
			return default;
		} // 0x00000001862DF280-0x00000001862DF500
		// [XID] // 0x0000000189B6F960-0x0000000189B6F980
		private static int GetDuplicateIndex(Player player, Controller controller) => default; // 0x00000001862D9370-0x00000001862D9790
		// [XID] // 0x0000000189A64710-0x0000000189A64730
		private void RefreshLayoutManager(int playerId) {} // 0x00000001862DD140-0x00000001862DD270
	}
}
