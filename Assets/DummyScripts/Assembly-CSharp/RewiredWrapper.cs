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
using Rewired;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class RewiredWrapper : InputPluginWrapper // TypeDefIndex: 29990
{
	// Fields
	private bool _hasMergedMap; // 0x18
	private KeyboardType _keyboardType; // 0x1C
	private HashSet<int> _allKeyboardTypes; // 0x20
	private List<ControllerMap> _controllerMapCache; // 0x28
	private Dictionary<string, bool> _mapEnableStateCache; // 0x30
	private List<ActionElementMap> _elementMapCache; // 0x38
	private Dictionary<string, string> _defaultMapsInXmlStr; // 0x40
	private Array _allControllerTypes; // 0x48
	private bool _hasLastActiveControllerChanged; // 0x50
	private bool _hasReinitBindingForPS; // 0x51
	private RuntimePlatform _platformCache; // 0x54
	private Dictionary<ControllerType, List<AssignConflictInfo>> _conflictInfos; // 0x58
	private const int MAP_CONTROLLER_KEY_SEPARATOR = 1000; // Metadata: 0x00B10651
	private const string OVERRIDE_MAP_PREFS_PATTERN = "OverrideControllerMap__{0}__{1}"; // Metadata: 0x00B10655
	private static ConfigKeyCode[] _unchangeableKeyCodeList; // 0x00
	private static HashSet<InputActionType> _needPlayerResolveConflictActions; // 0x08
	private const string REWIRED_INPUT_MANAGER_PREFAB = "EmbededRes/Build/Others/RewiredInputManager"; // Metadata: 0x00B10678
	private uint _handle; // 0x60
	public static Guid XBOX_360_CONTROLLER_TYPE_GUID; // 0x10
	public static Guid DUAL_SHOCK_4_CONTROLLER_TYPE_GUID; // 0x20
	public static Guid UNKNOWN_CONTROLLER_TYPE_GUID; // 0x30
	private Rewired.InputManager _rewiredInputManager; // 0x68
	private Action _onControllerConnected; // 0x70
	private Action _onControllerDisconnected; // 0x78
	private bool _controllerDisconnected; // 0x80
	private SpriteLoadProxy _iconProxy; // 0x88
	private bool _onControllerConnectedFlag; // 0x90
	private bool _onControllerDisConnectedFlag; // 0x91
	private ControllerType _controllerTypeFlag; // 0x94
	private Controller _activeController; // 0xA0
	protected StringBuilder joypadLogBuidler; // 0xA8
	private bool _menuButtonRightConfirm; // 0xB0
	private List<KeyCode> _tempKeyCodeList; // 0xB8
	private List<ControllerMap> _tempControllerMapList; // 0xC0
	private List<int> _tempElementIDList; // 0xC8
	private static Dictionary<int, KeyCode> _elementToKeycodeIOSDualShock4; // 0x40
	private static Dictionary<int, KeyCode> _elementToKeycodeIOSXBox; // 0x48
	private static Dictionary<Guid, Dictionary<int, KeyCode>> _elementToKeycodeIOS; // 0x50
	private static Dictionary<RuntimePlatform, Dictionary<Guid, Dictionary<int, KeyCode>>> _elementToKeycode; // 0x58

	// Properties
	public KeyboardType currentKeyboardType { /* [XID] */ /* 0x00000001896541B0-0x00000001896541D0 */ get => default; } // 0x0000000185025E50-0x0000000185025EF0 
	public Action onControllerConnected { /* [XID] */ /* 0x00000001899109C0-0x00000001899109E0 */ get => default; /* [XID] */ /* 0x0000000189918600-0x0000000189918620 */ set {} } // 0x000000018501C3B0-0x000000018501C450 0x0000000185023DE0-0x0000000185023E90
	public Action onControllerDisconnected { /* [XID] */ /* 0x000000018991FE00-0x000000018991FE20 */ get => default; /* [XID] */ /* 0x00000001899276A0-0x00000001899276C0 */ set {} } // 0x0000000185026C90-0x0000000185026D30 0x00000001850270D0-0x0000000185027180
	public override bool isReady { /* [XID] */ /* 0x0000000189936230-0x0000000189936250 */ get => default; } // 0x000000018501F980-0x000000018501FA50 
	private Player player { /* [XID] */ /* 0x000000018993DC30-0x000000018993DC70 */ get; /* [XID] */ /* 0x0000000189948230-0x0000000189948270 */ set; } // 0x000000018501C6B0-0x000000018501C710 0x000000018501B1C0-0x000000018501B230
	public Controller activeController { /* [XID] */ /* 0x0000000189B85A40-0x0000000189B85A60 */ get => default; /* [XID] */ /* 0x000000018995A0D0-0x000000018995A0F0 */ private set {} } // 0x0000000185024490-0x0000000185024540 0x000000018501A1A0-0x000000018501A490

	// Nested types
	public enum KeyboardLayoutID // TypeDefIndex: 29991
	{
		Default = 0,
		Develop = 1,
		FR = 2,
		DE = 3
	}

	public class AssignConflictInfo // TypeDefIndex: 29992
	{
		// Fields
		private ElementAssignment _elementAssignment; // 0x10
		private string _overrideMapPrefsKey; // 0x38
		private ControllerType _controllerType; // 0x40

		// Properties
		public InputActionType conflictActionID { /* [XID] */ /* 0x0000000189A85A20-0x0000000189A85A40 */ get => default; } // 0x0000000185014CE0-0x0000000185014D80 
		public string overrideMapPrefsKey { /* [XID] */ /* 0x0000000189A8D320-0x0000000189A8D340 */ get => default; } // 0x0000000185014D80-0x0000000185014E20 
		public ControllerType controllerType { /* [XID] */ /* 0x0000000189A94840-0x0000000189A94860 */ get => default; } // 0x0000000185014930-0x00000001850149D0 
		public Pole axisContribution { /* [XID] */ /* 0x0000000189A9C140-0x0000000189A9C160 */ get => default; } // 0x0000000185014B40-0x0000000185014BE0 

		// Constructors
		public AssignConflictInfo() {} // 0x0000000185014E20-0x0000000185014E80

		// Methods
		// [XID] // 0x0000000189A767F0-0x0000000189A76810
		public void Init(ElementAssignment assignment, ControllerMap defaultMap) {} // 0x00000001850149D0-0x0000000185014B40
		// [XID] // 0x0000000189A7E0C0-0x0000000189A7E0E0
		public void Clear() {} // 0x0000000185014BE0-0x0000000185014CE0
	}

	private class XMLMapProxy // TypeDefIndex: 29993
	{
		// Fields
		private ControllerMap _mapCreated; // 0x10
		private ControllerType _controllerType; // 0x18
		private RewiredWrapper _context; // 0x20

		// Properties
		public IList<ActionElementMap> AllMaps { /* [XID] */ /* 0x0000000189AA3850-0x0000000189AA3870 */ get => default; } // 0x0000000185033E80-0x0000000185033F30 
		public Guid hardwareGuid { /* [XID] */ /* 0x0000000189AAAEB0-0x0000000189AAAED0 */ get => default; } // 0x0000000185033C90-0x0000000185033DA0 
		public int categoryId { /* [XID] */ /* 0x0000000189AB2880-0x0000000189AB28A0 */ get => default; } // 0x0000000185033A90-0x0000000185033B40 
		public int layoutId { /* [XID] */ /* 0x0000000189ABA3B0-0x0000000189ABA3D0 */ get => default; } // 0x0000000185033BE0-0x0000000185033C90 
		public ControllerType controllerType { /* [XID] */ /* 0x0000000189AC1CE0-0x0000000189AC1D00 */ get => default; } // 0x0000000185033B40-0x0000000185033BE0 

		// Constructors
		public XMLMapProxy() {} // Dummy constructor
		public XMLMapProxy(RewiredWrapper context, ControllerType controllerType, string xml) {} // 0x0000000185034050-0x0000000185034100

		// Methods
		// [XID] // 0x0000000189AC9270-0x0000000189AC9290
		public void ReplaceMap(ControllerMap mapToBeReplaced) {} // 0x00000001850339D0-0x0000000185033A90
		// [XID] // 0x0000000189AD0D40-0x0000000189AD0D60
		public void CreateElementMap(ControllerType controllerType, ElementAssignment assignment) {} // 0x0000000185033F30-0x0000000185034050
		// [XID] // 0x0000000189AD8940-0x0000000189AD8960
		public string ToXmlString() => default; // 0x0000000185033DA0-0x0000000185033E80
	}

	// Constructors
	public RewiredWrapper() {} // 0x0000000185029760-0x00000001850299A0
	static RewiredWrapper() {} // 0x0000000185029380-0x0000000185029760

	// Methods
	// [XID] // 0x0000000189BDEF30-0x0000000189BDEF50
	private void InitMapManagement() {} // 0x0000000185019250-0x0000000185019300
	// [XID] // 0x00000001895EBBE0-0x00000001895EBC00
	public override void InitBinding(InputDeviceType deviceType) {} // 0x0000000185028290-0x0000000185028370
	// [XID] // 0x00000001895F2F80-0x00000001895F2FA0
	private void RefreshJoystickMapEnableState() {} // 0x00000001850197D0-0x0000000185019870
	// [XID] // 0x00000001895FA7C0-0x00000001895FA7E0
	private void RefreshUnknownMapEnableState() {} // 0x000000018501FC90-0x000000018501FF80
	// [XID] // 0x0000000189602190-0x00000001896021B0
	private bool IsUnknownMapLayoutIDShouldBeEnabled(int layoutID) => default; // 0x0000000185020B50-0x0000000185020C20
	// [XID] // 0x00000001896099B0-0x00000001896099D0
	private void DestroyMapManagement() {} // 0x000000018501DEC0-0x000000018501DF60
	// [XID] // 0x0000000189611120-0x0000000189611140
	private void TickMapManagement() {} // 0x0000000185023180-0x0000000185023260
	// [XID] // 0x0000000189618B10-0x0000000189618B30
	private void OnLastActiveControllerChangedMapManagement(Player player, Controller controller) {} // 0x000000018501DBD0-0x000000018501DCA0
	// [XID] // 0x0000000189620080-0x00000001896200A0
	public bool HasOverrideMap(ControllerType controllerType) => default; // 0x000000018501B770-0x000000018501BA50
	// [XID] // 0x00000001896274D0-0x00000001896274F0
	public void ResetMapToDefault(ControllerType controllerType) {} // 0x0000000185022AA0-0x0000000185022C10
	// [XID] // 0x000000018962F010-0x000000018962F030
	public bool IsKeyCodeBindAction(ControllerType controllerType, KeyCode keycode, InputActionGroupType groupType = InputActionGroupType.All /* Metadata: 0x00B10625 */) => default; // 0x000000018501BE70-0x000000018501BFF0
	// [XID] // 0x00000001896369B0-0x00000001896369D0
	public void ReplaceRelatedActionsOfTargetKeyCode(ControllerType controllerType, KeyCode source, KeyCode target, bool exchange = true /* Metadata: 0x00B10629 */, InputActionGroupType groupType = InputActionGroupType.All /* Metadata: 0x00B1062A */) {} // 0x000000018501CDD0-0x000000018501D100
	// [IDTag] // 0x000000018963DEA0-0x000000018963DEE0
	// [XID] // 0x000000018963DEA0-0x000000018963DEE0
	public void GetActionsByKeycode(ControllerType controllerType, KeyCode keycode, List<InputActionType> result, InputActionGroupType groupType = InputActionGroupType.All /* Metadata: 0x00B1062E */) {} // 0x000000018501E370-0x000000018501E600
	// [IDTag] // 0x00000001896486F0-0x0000000189648730
	// [XID] // 0x00000001896486F0-0x0000000189648730
	public void GetActionsByKeycode(ControllerType controllerType, KeyCode keycode, List<ActionElementMap> result, InputActionGroupType groupType = InputActionGroupType.All /* Metadata: 0x00B10632 */) {} // 0x000000018501E600-0x000000018501E9A0
	// [XID] // 0x0000000189652F80-0x0000000189652FA0
	public void GetKeyCodeByAction(ControllerType controllerType, InputActionType inputAction, List<KeyCode> result) {} // 0x0000000185026150-0x00000001850263A0
	// [XID] // 0x000000018965A660-0x000000018965A680
	public bool CanChangeKeyCodeRelatedAction(ConfigKeyCode keycode) => default; // 0x000000018501D6B0-0x000000018501D7E0
	// [XID] // 0x0000000189618350-0x0000000189618370
	public ActionElementMap GetKeyboardActionMap(InputActionType inputAction) => default; // 0x0000000185027530-0x0000000185027640
	// [XID] // 0x0000000189669870-0x0000000189669890
	public override List<KeyCode> GetKeyboardMouseMap(InputActionType inputAction) => default; // 0x0000000185024540-0x0000000185024900
	// [XID] // 0x0000000189671360-0x0000000189671380
	public List<KeyboardIconKeySprite> GetKeyboardMouseMapKeySprite(InputActionType inputAction) => default; // 0x000000018501E9A0-0x000000018501EE00
	// [XID] // 0x0000000189678C40-0x0000000189678C60
	public bool IsElementIDBindAction(ControllerType controllerType, int elementID, InputActionGroupType groupType = InputActionGroupType.All /* Metadata: 0x00B10636 */) => default; // 0x0000000185023C60-0x0000000185023DE0
	// [IDTag] // 0x0000000189680330-0x0000000189680370
	// [XID] // 0x0000000189680330-0x0000000189680370
	public void GetActionsByElementID(ControllerType controllerType, int elementID, List<InputActionType> result, InputActionGroupType groupType = InputActionGroupType.All /* Metadata: 0x00B1063A */) {} // 0x0000000185027F10-0x00000001850281A0
	// [IDTag] // 0x000000018968AD20-0x000000018968AD60
	// [XID] // 0x000000018968AD20-0x000000018968AD60
	public void GetActionsByElementID(ControllerType controllerType, int elementID, List<ActionElementMap> result, InputActionGroupType groupType = InputActionGroupType.All /* Metadata: 0x00B1063E */) {} // 0x0000000185027B70-0x0000000185027F10
	// [XID] // 0x00000001896957A0-0x00000001896957C0
	public void ReplaceRelatedActionsOfTargetElementID(ControllerType controllerType, int source, int target, bool exchange = true /* Metadata: 0x00B10642 */, InputActionGroupType groupType = InputActionGroupType.All /* Metadata: 0x00B10643 */) {} // 0x000000018501F650-0x000000018501F980
	// [XID] // 0x000000018969CE50-0x000000018969CE70
	public void GetElementIDByAction(ControllerType controllerType, InputActionType inputAction, List<int> result) {} // 0x0000000185022880-0x0000000185022AA0
	// [IDTag] // 0x00000001896A4120-0x00000001896A4160
	// [XID] // 0x00000001896A4120-0x00000001896A4160
	public Sprite GetCurrControllerElementIcon(InputActionType inputAction) => default; // 0x0000000185024DC0-0x0000000185024EC0
	// [IDTag] // 0x00000001896AE590-0x00000001896AE5D0
	// [XID] // 0x00000001896AE590-0x00000001896AE5D0
	public Sprite GetCurrControllerElementIcon(int elementID) => default; // 0x0000000185024CC0-0x0000000185024DC0
	// [XID] // 0x00000001896B8B10-0x00000001896B8B30
	public bool IsConfirmBackInvert() => default; // 0x0000000185023A90-0x0000000185023C60
	// [XID] // 0x00000001896BFD50-0x00000001896BFD70
	public void GetUnAssignedActions(ControllerType controllerType, Action<AssignConflictInfo> visitCallback, bool onlyGetFromEnabledMap) {} // 0x0000000185021F10-0x0000000185022180
	// [XID] // 0x00000001896C7630-0x00000001896C7650
	public int GetUnAssignedActionCount(ControllerType controllerType, bool onlyGetFromEnabledMap) => default; // 0x0000000185024100-0x0000000185024360
	// [XID] // 0x00000001896CED90-0x00000001896CEDB0
	public void AssignActionToKeyCodeByConflictInfo(AssignConflictInfo conflictInfo, KeyCode keycodeToAssign) {} // 0x00000001850268B0-0x0000000185026BA0
	// [XID] // 0x00000001896D61B0-0x00000001896D61D0
	private void InitMap(InputDeviceType deviceType) {} // 0x0000000185021B60-0x0000000185021C50
	// [XID] // 0x00000001896DD7D0-0x00000001896DD7F0
	public void ReInitBindingForPS() {} // 0x0000000185026EA0-0x0000000185026F60
	// [XID] // 0x00000001896E4E60-0x00000001896E4E80
	private void InitKeyboardTypes() {} // 0x00000001850238D0-0x0000000185023A90
	// [XID] // 0x00000001896EC360-0x00000001896EC380
	private void InitMapEnableStates(InputDeviceType deviceType) {} // 0x0000000185022C10-0x0000000185022DE0
	// [XID] // 0x00000001896F3AF0-0x00000001896F3B10
	private void ClearAllMaps() {} // 0x000000018501C710-0x000000018501C8C0
	// [XID] // 0x00000001896FB240-0x00000001896FB260
	private void LoadDefaultMaps() {} // 0x0000000185026700-0x00000001850268B0
	// [XID] // 0x00000001897029F0-0x0000000189702A10
	private void StoreDefaultMaps() {} // 0x000000018501FA50-0x000000018501FC90
	// [IDTag] // 0x000000018970A110-0x000000018970A150
	// [XID] // 0x000000018970A110-0x000000018970A150
	private void ApplyOverrideMap() {} // 0x0000000185023300-0x0000000185023450
	// [IDTag] // 0x00000001897146A0-0x00000001897146E0
	// [XID] // 0x00000001897146A0-0x00000001897146E0
	private void CacheMapEnableState() {} // 0x0000000185028830-0x0000000185028990
	// [IDTag] // 0x000000018971EFF0-0x000000018971F030
	// [XID] // 0x000000018971EFF0-0x000000018971F030
	private void RecoverMapEnableState() {} // 0x0000000185023020-0x0000000185023180
	// [IDTag] // 0x0000000189729340-0x0000000189729380
	// [XID] // 0x0000000189729340-0x0000000189729380
	private void CacheMapEnableState(ControllerType controllerType) {} // 0x0000000185028990-0x0000000185028BC0
	// [IDTag] // 0x0000000189733A40-0x0000000189733A80
	// [XID] // 0x0000000189733A40-0x0000000189733A80
	private void RecoverMapEnableState(ControllerType controllerType) {} // 0x0000000185022DE0-0x0000000185023020
	// [IDTag] // 0x000000018973E8C0-0x000000018973E900
	// [XID] // 0x000000018973E8C0-0x000000018973E900
	private void ApplyOverrideMap(ControllerType controllerType) {} // 0x00000001850236B0-0x0000000185023870
	// [IDTag] // 0x0000000189748F20-0x0000000189748F60
	// [XID] // 0x0000000189748F20-0x0000000189748F60
	private void ApplyOverrideMap(ControllerType controllerType, ControllerMap map) {} // 0x0000000185023450-0x00000001850236B0
	// [XID] // 0x0000000189753270-0x0000000189753290
	private void CheckAndMergeMap() {} // 0x0000000185019F10-0x000000018501A060
	// [XID] // 0x000000018975A670-0x000000018975A690
	private void ClearConflictInfoBeforeMerge() {} // 0x0000000185021870-0x0000000185021B60
	// [XID] // 0x0000000189762320-0x0000000189762340
	private void AddMapFromXml(ControllerMap map, string xmlString) {} // 0x0000000185020690-0x00000001850207B0
	// [XID] // 0x0000000189769920-0x0000000189769940
	private void ReplaceMap(ControllerMap map, ControllerMap mapToReplace) {} // 0x000000018501B230-0x000000018501B4D0
	// [IDTag] // 0x0000000189770ED0-0x0000000189770F10
	// [XID] // 0x0000000189770ED0-0x0000000189770F10
	private void MergeAdditionalActionsToOverrideMap(ControllerType controllerType) {} // 0x000000018501A720-0x000000018501A8E0
	// [IDTag] // 0x000000018977B400-0x000000018977B440
	// [XID] // 0x000000018977B400-0x000000018977B440
	private void MergeAdditionalActionsToOverrideMap(ControllerType controllerType, ControllerMap defaultMap) {} // 0x000000018501A490-0x000000018501A720
	// [IDTag] // 0x0000000189785C70-0x0000000189785CB0
	// [XID] // 0x0000000189785C70-0x0000000189785CB0
	private void MergeAdditionalActionsToOverrideMap(ControllerMap defaultMap, XMLMapProxy overrideMap) {} // 0x000000018501A8E0-0x000000018501B1C0
	// [XID] // 0x0000000189790460-0x0000000189790480
	private bool ActionEqualityCheck(int actionID, Pole axisContribution, ActionElementMap elementMap) => default; // 0x0000000185024FB0-0x00000001850250C0
	// [XID] // 0x0000000189797DD0-0x0000000189797DF0
	private void RecordConflictInfo(AssignConflictInfo info) {} // 0x0000000185018AD0-0x0000000185018C60
	// [XID] // 0x000000018979FAB0-0x000000018979FAD0
	private List<AssignConflictInfo> GetConflictInfo(ControllerType controllerType) => default; // 0x0000000185026BA0-0x0000000185026C90
	// [XID] // 0x00000001897A70B0-0x00000001897A70D0
	private bool IsBindSameActionsExceptTargetAction(ControllerMap defaultMap, XMLMapProxy overrideMap, int elementID, int actionId, Pole axisContribution) => default; // 0x0000000185020CF0-0x00000001850211C0
	// [XID] // 0x00000001897AEA20-0x00000001897AEA40
	private void CreateElementMap(ControllerType controllerType, ControllerMap map, ElementAssignment assignment) {} // 0x0000000185027640-0x0000000185027890
	// [XID] // 0x00000001897B68B0-0x00000001897B68D0
	private void SetRuleSetToMapEnabler(int ruleSetID) {} // 0x000000018501B4D0-0x000000018501B770
	// [XID] // 0x00000001897BE710-0x00000001897BE730
	private void ReplaceRelatedActionsOfTargetKeyCodeImp(ControllerMap map, KeyCode source, KeyCode target, bool exchange = true /* Metadata: 0x00B10647 */, InputActionGroupType groupType = InputActionGroupType.All /* Metadata: 0x00B10648 */) {} // 0x00000001850252F0-0x0000000185025850
	// [IDTag] // 0x00000001897C5DA0-0x00000001897C5DE0
	// [XID] // 0x00000001897C5DA0-0x00000001897C5DE0
	private void OnOverrideMapModified(ControllerMap map) {} // 0x0000000185024AE0-0x0000000185024CC0
	// [IDTag] // 0x00000001897D0480-0x00000001897D04C0
	// [XID] // 0x00000001897D0480-0x00000001897D04C0
	private void OnOverrideMapModified(XMLMapProxy map) {} // 0x0000000185024900-0x0000000185024AE0
	// [XID] // 0x00000001897DAE30-0x00000001897DAE50
	private void RefreshConflictListByOverrideMap(IList<ActionElementMap> allMaps, ControllerType controllerType, string prefsKey) {} // 0x000000018501BA50-0x000000018501BD60
	// [XID] // 0x00000001897E2540-0x00000001897E2560
	private void ReplaceRelatedActionsOfTargetElementIDImp(ControllerMap map, int source, int target, bool exchange = true /* Metadata: 0x00B1064C */, InputActionGroupType groupType = InputActionGroupType.All /* Metadata: 0x00B1064D */) {} // 0x000000018501F0F0-0x000000018501F650
	// [XID] // 0x00000001897E9CB0-0x00000001897E9CD0
	private void GetActiveElementMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) {} // 0x0000000185018260-0x0000000185018640
	// [XID] // 0x0000000189B6F120-0x0000000189B6F140
	private void GetActiveAndEnabledMaps(ControllerType controllerType, List<ControllerMap> result) {} // 0x0000000185022530-0x00000001850227C0
	// [XID] // 0x00000001897F90C0-0x00000001897F90E0
	private void GetActiveAndEnabledMapPrefsKey(ControllerType controllerType, List<string> result) {} // 0x000000018501DD10-0x000000018501DEC0
	// [XID] // 0x00000001898006D0-0x00000001898006F0
	private void GetEnabledMaps(ControllerType controllerType, List<ControllerMap> result) {} // 0x0000000185020940-0x0000000185020B50
	// [IDTag] // 0x0000000189807D50-0x0000000189807D90
	// [XID] // 0x0000000189807D50-0x0000000189807D90
	private void GetAllMaps(List<ControllerMap> result) {} // 0x0000000185018820-0x0000000185018AD0
	// [IDTag] // 0x0000000189812270-0x00000001898122B0
	// [XID] // 0x0000000189812270-0x00000001898122B0
	private void GetAllMaps(ControllerType controllerType, List<ControllerMap> result) {} // 0x0000000185018640-0x0000000185018820
	// [XID] // 0x0000000189A09600-0x0000000189A09620
	private ControllerMap GetFirstEnabledMap(ControllerType controllerType) => default; // 0x00000001850190F0-0x0000000185019250
	private static extern IntPtr GetForegroundWindow(); // 0x0000000185025C00-0x0000000185025CE0
	private static extern uint GetWindowThreadProcessId(IntPtr hwnd, IntPtr proccess); // 0x0000000185022430-0x0000000185022530
	private static extern IntPtr GetKeyboardLayout(uint thread); // 0x0000000185025200-0x00000001850252F0
	// [XID] // 0x0000000189824150-0x0000000189824170
	private KeyboardType GetCurrentKeyboardLayout() => default; // 0x000000018501D4C0-0x000000018501D6B0
	// [XID] // 0x000000018982BBA0-0x000000018982BBC0
	private void CheckKeyboardLayoutChange() {} // 0x0000000185025D90-0x0000000185025E50
	// [XID] // 0x0000000189833110-0x0000000189833130
	private void OnKeyboardTypeChange() {} // 0x000000018501D100-0x000000018501D1A0
	// [XID] // 0x0000000189763630-0x0000000189763650
	public void UpdateKeyboardMapEnableState() {} // 0x00000001850263A0-0x0000000185026700
	// [XID] // 0x0000000189AA6520-0x0000000189AA6540
	private KeyboardLayoutID GetLayoutIDByKeyboardType(KeyboardType keyboardType) => default; // 0x000000018501C2B0-0x000000018501C3B0
	// [XID] // 0x0000000189AC48E0-0x0000000189AC4900
	private KeyboardLayoutID GetLayoutIDByInputDeviceType() => default; // 0x0000000185024EC0-0x0000000185024FB0
	// [XID] // 0x0000000189850870-0x0000000189850890
	private static KeyCode ToKeyCode(ActionElementMap elementMap) => default; // 0x00000001850211C0-0x0000000185021350
	// [XID] // 0x0000000189857C40-0x0000000189857C60
	private static string ToKeySprite(ActionElementMap elementMap) => default; // 0x0000000185022180-0x00000001850223C0
	// [XID] // 0x000000018985ED10-0x000000018985ED30
	private int GetDualShock4MapElementID(int actionID) => default; // 0x000000018501C580-0x000000018501C6B0
	// [IDTag] // 0x00000001898664B0-0x00000001898664F0
	// [XID] // 0x00000001898664B0-0x00000001898664F0
	private Sprite GetXboxControllerElementIcon(InputActionType inputAction) => default; // 0x0000000185028580-0x0000000185028710
	// [IDTag] // 0x00000001898709B0-0x00000001898709F0
	// [XID] // 0x00000001898709B0-0x00000001898709F0
	private Sprite GetXboxControllerElementIcon(int elementID) => default; // 0x0000000185028470-0x0000000185028580
	// [IDTag] // 0x000000018987B4B0-0x000000018987B4F0
	// [XID] // 0x000000018987B4B0-0x000000018987B4F0
	private Sprite GetUnknownControllerElementIcon(InputActionType inputAction) => default; // 0x0000000185025960-0x0000000185025AF0
	// [IDTag] // 0x00000001898859F0-0x0000000189885A30
	// [XID] // 0x00000001898859F0-0x0000000189885A30
	private Sprite GetUnknownControllerElementIcon(int elementID) => default; // 0x0000000185025AF0-0x0000000185025C00
	// [IDTag] // 0x000000018988FB40-0x000000018988FB80
	// [XID] // 0x000000018988FB40-0x000000018988FB80
	private Sprite GetDualShock4ControllerElementIcon(InputActionType inputAction) => default; // 0x0000000185024030-0x0000000185024100
	// [IDTag] // 0x000000018989A1F0-0x000000018989A230
	// [XID] // 0x000000018989A1F0-0x000000018989A230
	private Sprite GetDualShock4ControllerElementIcon(int elementID) => default; // 0x0000000185023E90-0x0000000185024030
	// [XID] // 0x00000001898A46E0-0x00000001898A4700
	private void GetCategoryAndLayoutByKey(int key, out ControllerType controllerType, out int category, out int layout) {
		controllerType = default;
		category = default;
		layout = default;
	} // 0x0000000185024360-0x0000000185024490
	// [IDTag] // 0x00000001898ABBA0-0x00000001898ABBE0
	// [XID] // 0x00000001898ABBA0-0x00000001898ABBE0
	private static string GetOverrideMapPrefsKey(ControllerMap map) => default; // 0x0000000185019300-0x00000001850194E0
	// [IDTag] // 0x00000001898B6370-0x00000001898B63B0
	// [XID] // 0x00000001898B6370-0x00000001898B63B0
	private static string GetOverrideMapPrefsKey(XMLMapProxy map) => default; // 0x00000001850194E0-0x00000001850196C0
	// [XID] // 0x00000001898C0DB0-0x00000001898C0DD0
	private static int GetControllerMapKey(ControllerType controllerType, int category, int layout) => default; // 0x0000000185020C20-0x0000000185020CF0
	// [XID] // 0x00000001898C86B0-0x00000001898C86D0
	private void ResetMapToDefaultImp(ControllerType controllerType) {} // 0x0000000185018C60-0x0000000185019090
	// [IDTag] // 0x00000001898D0080-0x00000001898D00C0
	// [XID] // 0x00000001898D0080-0x00000001898D00C0
	private bool BelongsToActionGroup(InputActionGroupType groupType, InputActionType inputAction) => default; // 0x0000000185020530-0x0000000185020690
	// [IDTag] // 0x00000001898DA5A0-0x00000001898DA5E0
	// [XID] // 0x00000001898DA5A0-0x00000001898DA5E0
	private bool BelongsToActionGroup(InputActionGroupType groupType, int inputAction) => default; // 0x0000000185020460-0x0000000185020530
	// [IDTag] // 0x00000001898E51F0-0x00000001898E5230
	// [XID] // 0x00000001898E51F0-0x00000001898E5230
	private Controller GetLastActiveController(ControllerType controllerType) => default; // 0x0000000185019C20-0x0000000185019DA0
	// [IDTag] // 0x00000001898EFC50-0x00000001898EFC90
	// [XID] // 0x00000001898EFC50-0x00000001898EFC90
	private Controller GetLastActiveController() => default; // 0x0000000185019DA0-0x0000000185019F10
	// [XID] // 0x00000001898FA390-0x00000001898FA3B0
	private void AssignActionToKeyCodeByConflictInfoImp(ControllerMap map, AssignConflictInfo conflictInfo, KeyCode keycodeToAssign) {} // 0x0000000185021570-0x0000000185021760
	// [XID] // 0x0000000189901D20-0x0000000189901D40
	private XMLMapProxy CreateFromXml(ControllerType controllerType, string xml) => default; // 0x0000000185028370-0x0000000185028470
	// [XID] // 0x000000018992EE00-0x000000018992EE20
	public override void Init() {} // 0x000000018501FF80-0x0000000185020200
	// [XID] // 0x0000000189961AE0-0x0000000189961B00
	public bool HasConnectedJoypad() => default; // 0x000000018501C8C0-0x000000018501CDD0
	// [XID] // 0x00000001899691B0-0x00000001899691D0
	public bool HasConnectedJoypadNoGC() => default; // 0x0000000185028D00-0x0000000185028F60
	// [XID] // 0x0000000189970C70-0x0000000189970C90
	public Player.ControllerHelper GetCurrentPlayerControllers() => default; // 0x00000001850281A0-0x0000000185028290
	// [XID] // 0x00000001899785D0-0x00000001899785F0
	public IEnumerable<Controller> GetControllers() => default; // 0x0000000185021420-0x0000000185021570
	// [XID] // 0x000000018997F6D0-0x000000018997F6F0
	public Controller GetLastActiveOrFirstJoypadController() => default; // 0x0000000185027180-0x00000001850274B0
	// [XID] // 0x0000000189987000-0x0000000189987020
	public InputJoypadType GetFirstJoypadType() => default; // 0x0000000185021C50-0x0000000185021F10
	// [XID] // 0x000000018998EB10-0x000000018998EB30
	public void AssignFirstJoypadController() {} // 0x00000001850227C0-0x0000000185022880
	// [XID] // 0x00000001899966F0-0x0000000189996710
	public override void Setup() {} // 0x000000018501D950-0x000000018501DBD0
	// [XID] // 0x000000018999E1B0-0x000000018999E1D0
	public override void Destroy() {} // 0x000000018501BFF0-0x000000018501C2B0
	// [XID] // 0x00000001899A5B70-0x00000001899A5B90
	public void Tick() {} // 0x0000000185020200-0x00000001850202E0
	// [XID] // 0x00000001899AD270-0x00000001899AD290
	private void OnControllerConnectedFlagInternalCallback() {} // 0x00000001850279B0-0x0000000185027B70
	// [XID] // 0x00000001899B4A50-0x00000001899B4A70
	private void OnControllerDisConnectedFlagInternalCallback() {} // 0x0000000185023260-0x0000000185023300
	// [XID] // 0x00000001899BC170-0x00000001899BC190
	private void OnControllerConnected(ControllerStatusChangedEventArgs args) {} // 0x0000000185028F60-0x0000000185029380
	// [XID] // 0x00000001899C3BF0-0x00000001899C3C10
	private void OnControllerDisconnected(ControllerStatusChangedEventArgs args) {} // 0x0000000185019870-0x0000000185019C20
	// [XID] // 0x00000001899CB2B0-0x00000001899CB2D0
	private void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args) {} // 0x000000018501DF60-0x000000018501E2F0
	// [XID] // 0x00000001899D27A0-0x00000001899D27C0
	private void OnLastActiveControllerChanged(Player player, Controller controller) {} // 0x000000018501D1A0-0x000000018501D4C0
	// [XID] // 0x00000001899D9EF0-0x00000001899D9F10
	public bool GetButtonDown(InputActionType actionType) => default; // 0x000000018501A060-0x000000018501A1A0
	// [XID] // 0x00000001899E1810-0x00000001899E1830
	public override bool GetButton(InputActionType actionType) => default; // 0x0000000185028BC0-0x0000000185028D00
	// [XID] // 0x00000001899E8DC0-0x00000001899E8DE0
	public bool GetButtonUp(InputActionType actionType) => default; // 0x00000001850250C0-0x0000000185025200
	// [XID] // 0x00000001899F0740-0x00000001899F0760
	public bool GetButtonLongPressDown(InputActionType actionType) => default; // 0x0000000185021760-0x0000000185021870
	// [XID] // 0x00000001899F7D80-0x00000001899F7DA0
	public bool GetButtonLongPress(InputActionType actionType) => default; // 0x000000018501EEF0-0x000000018501F000
	// [XID] // 0x00000001899FF3F0-0x00000001899FF410
	public bool GetButtonLongPressUp(InputActionType actionType) => default; // 0x000000018501BD60-0x000000018501BE70
	// [XID] // 0x0000000189A06BF0-0x0000000189A06C10
	public bool GetButtonShortPressUp(InputActionType actionType) => default; // 0x0000000185025850-0x0000000185025960
	// [XID] // 0x0000000189A0E300-0x0000000189A0E320
	public float GetAxis(InputActionType actionType) => default; // 0x0000000185020340-0x0000000185020460
	// [XID] // 0x0000000189A158E0-0x0000000189A15900
	public float GetAxisRaw(InputActionType actionType) => default; // 0x0000000185027890-0x00000001850279B0
	// [XID] // 0x0000000189A1CDA0-0x0000000189A1CDC0
	public bool GetAxisActive(InputActionType actionType) => default; // 0x0000000185028710-0x0000000185028830
	// [XID] // 0x0000000189A242E0-0x0000000189A24300
	public bool GetNegativeButtonRepeating(InputActionType actionType) => default; // 0x00000001850196C0-0x00000001850197D0
	// [XID] // 0x0000000189A2B7C0-0x0000000189A2B7E0
	public bool GetButtonRepeating(InputActionType inputAction) => default; // 0x000000018501C450-0x000000018501C580
	// [XID] // 0x0000000189A32E20-0x0000000189A32E40
	public void SetMenuButtonRightConfirm(bool val) {} // 0x0000000185025CE0-0x0000000185025D90
	// [XID] // 0x0000000189A3A670-0x0000000189A3A690
	private InputActionType InputActionMapping(InputActionType actionType) => default; // 0x0000000185021350-0x0000000185021420
	// [XID] // 0x0000000189A41FC0-0x0000000189A41FE0
	private void InitUnityInput() {} // 0x000000018501F000-0x000000018501F0F0
	// [XID] // 0x0000000189A49570-0x0000000189A49590
	private void DestroyUnityInput() {} // 0x000000018501EE00-0x000000018501EEF0
	// [XID] // 0x0000000189A50EC0-0x0000000189A50EE0
	private bool GetButtonFromUnity(InputActionType inputAction) => default; // 0x0000000185026F60-0x00000001850270D0
	// [XID] // 0x0000000189A58480-0x0000000189A584A0
	private bool GetButtonUpFromUnity(InputActionType inputAction) => default; // 0x000000018501D7E0-0x000000018501D950
	// [XID] // 0x0000000189A5FF00-0x0000000189A5FF20
	private bool GetButtonDownFromUnity(InputActionType inputAction) => default; // 0x0000000185026D30-0x0000000185026EA0
	// [XID] // 0x0000000189A67BA0-0x0000000189A67BC0
	private void GetQueryKeycodeFromAction(InputActionType inputAction, List<KeyCode> result) {} // 0x0000000185025EF0-0x0000000185026150
	// [XID] // 0x0000000189A6EFD0-0x0000000189A6EFF0
	private KeyCode GetQueryKeycodeFromElementID(int elementID, Guid hardwareTypeGuid) => default; // 0x00000001850207B0-0x0000000185020940
}

