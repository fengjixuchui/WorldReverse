/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Data.Mapping;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data
{
	[Serializable]
	public sealed class UserData // TypeDefIndex: 3955
	{
		// Fields
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private ConfigVars configVars; // 0x10
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private List<Player_Editor> players; // 0x18
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private List<InputAction> actions; // 0x20
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private List<InputCategory> actionCategories; // 0x28
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private ActionCategoryMap actionCategoryMap; // 0x30
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private List<InputBehavior> inputBehaviors; // 0x38
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private List<InputMapCategory> mapCategories; // 0x40
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private List<InputLayout> joystickLayouts; // 0x48
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private List<InputLayout> keyboardLayouts; // 0x50
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private List<InputLayout> mouseLayouts; // 0x58
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private List<InputLayout> customControllerLayouts; // 0x60
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private List<ControllerMap_Editor> joystickMaps; // 0x68
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private List<ControllerMap_Editor> keyboardMaps; // 0x70
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private List<ControllerMap_Editor> mouseMaps; // 0x78
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private List<ControllerMap_Editor> customControllerMaps; // 0x80
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private List<CustomController_Editor> customControllers; // 0x88
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private List<ControllerMapLayoutManager_RuleSet_Editor> controllerMapLayoutManagerRuleSets; // 0x90
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private List<ControllerMapEnabler_RuleSet_Editor> controllerMapEnablerRuleSets; // 0x98
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private int playerIdCounter; // 0xA0
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private int actionIdCounter; // 0xA4
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private int actionCategoryIdCounter; // 0xA8
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private int inputBehaviorIdCounter; // 0xAC
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private int mapCategoryIdCounter; // 0xB0
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private int joystickLayoutIdCounter; // 0xB4
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private int keyboardLayoutIdCounter; // 0xB8
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private int mouseLayoutIdCounter; // 0xBC
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private int customControllerLayoutIdCounter; // 0xC0
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private int joystickMapIdCounter; // 0xC4
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private int keyboardMapIdCounter; // 0xC8
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private int mouseMapIdCounter; // 0xCC
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private int customControllerMapIdCounter; // 0xD0
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private int customControllerIdCounter; // 0xD4
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private int controllerMapLayoutManagerSetIdCounter; // 0xD8
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private int controllerMapEnablerSetIdCounter; // 0xDC
		private Func<int, bool> containsActionDelegate; // 0xE0
	
		// Properties
		internal IList<Player_Editor> Players_readOnly { get; private set; } // 0x000000018510D7E0-0x000000018510D840 0x000000018510ECE0-0x000000018510ED50
		private IList<InputAction> Actions_readOnly { get; set; } // 0x000000018510E730-0x000000018510E7A0
		internal IList<InputCategory> ActionCategories_readOnly { get; private set; } // 0x000000018510D540-0x000000018510D5A0 0x000000018510E6C0-0x000000018510E730
		private IList<InputBehavior> InputBehaviors_readOnly { get; set; } // 0x000000018510E960-0x000000018510E9D0
		internal IList<InputMapCategory> MapCategories_readOnly { get; private set; } // 0x000000018510D720-0x000000018510D780 0x000000018510EB90-0x000000018510EC00
		internal IList<InputLayout> JoystickLayouts_readOnly { get; private set; } // 0x000000018510D660-0x000000018510D6C0 0x000000018510E9D0-0x000000018510EA40
		internal IList<InputLayout> KeyboardLayouts_readOnly { get; private set; } // 0x000000018510D6C0-0x000000018510D720 0x000000018510EAB0-0x000000018510EB20
		internal IList<InputLayout> MouseLayouts_readOnly { get; private set; } // 0x000000018510D780-0x000000018510D7E0 0x000000018510EC00-0x000000018510EC70
		internal IList<InputLayout> CustomControllerLayouts_readOnly { get; private set; } // 0x000000018510D600-0x000000018510D660 0x000000018510E880-0x000000018510E8F0
		private IList<ControllerMap_Editor> JoystickMaps_readOnly { get; set; } // 0x000000018510EA40-0x000000018510EAB0
		private IList<ControllerMap_Editor> KeyboardMaps_readOnly { get; set; } // 0x000000018510EB20-0x000000018510EB90
		private IList<ControllerMap_Editor> MouseMaps_readOnly { get; set; } // 0x000000018510EC70-0x000000018510ECE0
		private IList<ControllerMap_Editor> CustomControllerMaps_readOnly { get; set; } // 0x000000018510E8F0-0x000000018510E960
		private IList<ControllerMapLayoutManager_RuleSet_Editor> ControllerMapLayoutManagerRuleSets_readOnly { get; set; } // 0x000000018510E810-0x000000018510E880
		private IList<ControllerMapEnabler_RuleSet_Editor> ControllerMapEnablerRuleSets_readOnly { get; set; } // 0x000000018510E7A0-0x000000018510E810
		public ConfigVars ConfigVars { get => default; } // 0x000000018510D5A0-0x000000018510D600 
		internal IEnumerable<InputMapCategory> UserAssignableMapCategories { get => default; } // 0x000000018510D840-0x000000018510D8E0 
		public int playerCount { get => default; } // 0x000000018510D8E0-0x000000018510D960 
	
		// Constructors
		public UserData() {} // 0x000000018510CD80-0x000000018510CDF0
		private UserData(bool init) {} // 0x000000018510C540-0x000000018510CD80
	
		// Methods
		internal IEnumerable<InputAction> bUkCqqbTCbZDZsDEABezjonPmLX(int param_000084e6, bool param_000084e7) => default; // 0x000000018510CF40-0x000000018510D000
		internal IEnumerable<InputAction> bUkCqqbTCbZDZsDEABezjonPmLX(string param_000084e8, bool param_000084e9) => default; // 0x000000018510D000-0x000000018510D0E0
		public List<InputAction> GetActions_Copy() => default; // 0x0000000185107F00-0x0000000185108020
		public List<InputBehavior> GetInputBehaviors_Copy() => default; // 0x0000000185108BE0-0x0000000185108D50
		public string[] GetPlayerNames() => default; // 0x000000018510A290-0x000000018510A420
		public InputAction GetAction(string name) => default; // 0x0000000185107E50-0x0000000185107F00
		public InputAction GetActionById(int id) => default; // 0x0000000185107930-0x0000000185107A60
		public int GetActionId(string name) => default; // 0x0000000185107D90-0x0000000185107E50
		public IEnumerable<int> SortedActionIdsInCategory(int id) => default; // 0x000000018510BB90-0x000000018510BC30
		public bool ContainsAction(int id) => default; // 0x0000000185106EF0-0x0000000185106F70
		public int IndexOfAction(int id) => default; // 0x000000018510A700-0x000000018510A830
		public int IndexOfAction(string name) => default; // 0x000000018510A830-0x000000018510A9A0
		public string[] GetActionCategoryNames() => default; // 0x0000000185107A60-0x0000000185107BF0
		public InputCategory GetActionCategory(int index) => default; // 0x0000000185107BF0-0x0000000185107CE0
		public InputCategory GetActionCategory(string name) => default; // 0x0000000185107CE0-0x0000000185107D90
		public int IndexOfActionCategory(string name) => default; // 0x000000018510A590-0x000000018510A700
		public string[] GetInputBehaviorNames() => default; // 0x0000000185108A40-0x0000000185108BE0
		public InputBehavior GetInputBehaviorById(int id) => default; // 0x00000001851088F0-0x0000000185108A40
		public string[] GetMapCategoryNames() => default; // 0x0000000185109A40-0x0000000185109C00
		public InputMapCategory GetMapCategoryById(int id) => default; // 0x0000000185109850-0x0000000185109970
		public int GetMapCategoryId(string name) => default; // 0x0000000185109970-0x0000000185109A40
		public int IndexOfMapCategory(string name) => default; // 0x000000018510B500-0x000000018510B670
		public string[] GetJoystickLayoutNames() => default; // 0x0000000185108ED0-0x0000000185109090
		public InputLayout GetJoystickLayoutById(int id) => default; // 0x0000000185108D50-0x0000000185108DF0
		public int GetJoystickLayoutId(string name) => default; // 0x0000000185108DF0-0x0000000185108ED0
		public int IndexOfJoystickLayout(int id) => default; // 0x000000018510B0F0-0x000000018510B200
		public int IndexOfJoystickLayout(string name) => default; // 0x000000018510AF70-0x000000018510B0F0
		public string[] GetKeyboardLayoutNames() => default; // 0x00000001851096A0-0x0000000185109850
		public InputLayout GetKeyboardLayoutById(int id) => default; // 0x0000000185109530-0x00000001851095D0
		public int GetKeyboardLayoutId(string name) => default; // 0x00000001851095D0-0x00000001851096A0
		public int IndexOfKeyboardLayout(int id) => default; // 0x000000018510B200-0x000000018510B340
		public int IndexOfKeyboardLayout(string name) => default; // 0x000000018510B340-0x000000018510B500
		public string[] GetMouseLayoutNames() => default; // 0x0000000185109D60-0x0000000185109EF0
		public InputLayout GetMouseLayoutById(int id) => default; // 0x0000000185109C00-0x0000000185109CA0
		public int GetMouseLayoutId(string name) => default; // 0x0000000185109CA0-0x0000000185109D60
		public int IndexOfMouseLayout(int id) => default; // 0x000000018510B7E0-0x000000018510B8E0
		public int IndexOfMouseLayout(string name) => default; // 0x000000018510B670-0x000000018510B7E0
		public string[] GetCustomControllerLayoutNames() => default; // 0x0000000185108390-0x0000000185108540
		public InputLayout GetCustomControllerLayoutById(int id) => default; // 0x0000000185108230-0x00000001851082D0
		public int GetCustomControllerLayoutId(string name) => default; // 0x00000001851082D0-0x0000000185108390
		public int IndexOfCustomControllerLayout(int id) => default; // 0x000000018510ABC0-0x000000018510ACD0
		public int IndexOfCustomControllerLayout(string name) => default; // 0x000000018510ACD0-0x000000018510AE60
		internal ControllerMap EejRxaQkJjVzdXNnYOzIknaBWSF(Controller param_00008509, int param_0000850a, int param_0000850b) => default; // 0x0000000185106F70-0x0000000185107130
		public ControllerMap_Editor GetJoystickMap(int categoryId, Guid hardwareGuid, int layoutId) => default; // 0x0000000185109090-0x00000001851092F0
		public List<ControllerMap_Editor> GetJoystickMaps(Guid hardwareGuid) => default; // 0x00000001851092F0-0x0000000185109530
		internal JoystickMap xSmZEdTrKmvKQhUCylMqvdplEmLK(Joystick param_00008510, int param_00008511, int param_00008512) => default; // 0x000000018510F070-0x000000018510F150
		private JoystickMap xSmZEdTrKmvKQhUCylMqvdplEmLK(HardwareControllerMapIdentifier param_00008513, int param_00008514, int param_00008515) => default; // 0x000000018510F150-0x000000018510FC40
		private ControllerMap_Editor dqKPHkffJNGGsHuAoxrmsoxwQvSP(int param_00008516, Guid param_00008517, int param_00008518, bool param_00008519) => default; // 0x000000018510D0E0-0x000000018510D1E0
		private ControllerMap_Editor edqGOyPIbqxPjWduCebehfVtzRM(int param_0000851a, Guid param_0000851b, int param_0000851c) => default; // 0x000000018510D350-0x000000018510D540
		private JoystickMap nBQvQxqpITmHJPVLHnwMLlIeBUp(HardwareControllerMapIdentifier param_0000851d, ControllerMap_Editor param_0000851e, HardwareJoystickTemplateMap param_0000851f, HardwareJoystickMap param_00008520, int param_00008521, int param_00008522) => default; // 0x000000018510DE90-0x000000018510E410
		public KeyboardMap FindKeyboardMap_Game(int categoryId, int layoutId) => default; // 0x0000000185107210-0x0000000185107360
		public MouseMap FindMouseMap_Game(int categoryId, int layoutId) => default; // 0x0000000185107360-0x00000001851074C0
		public ControllerMap_Editor GetCustomControllerMap(int categoryId, int controllerUid, int layoutId) => default; // 0x0000000185108540-0x0000000185108720
		public List<ControllerMap_Editor> GetCustomControllerMaps(int controllerUid) => default; // 0x0000000185108720-0x00000001851088F0
		internal CustomControllerMap MehHSdzwFfroqrFNXLiGTsJRIwK(int param_0000852b, int param_0000852c, int param_0000852d) => default; // 0x000000018510B8E0-0x000000018510B990
		private CustomControllerMap MehHSdzwFfroqrFNXLiGTsJRIwK(CustomController_Editor param_0000852e, int param_0000852f, int param_00008530) => default; // 0x000000018510B990-0x000000018510BB90
		private ControllerMap_Editor mesUcMBsplifnocsrcbehcdnWJj(int param_00008531, int param_00008532, int param_00008533, bool param_00008534) => default; // 0x000000018510DD90-0x000000018510DE90
		private ControllerMap_Editor CNJluiqbUWuLNmQGsyDvnBjIrTM(int param_00008535, int param_00008536, int param_00008537) => default; // 0x0000000185106CE0-0x0000000185106EF0
		public CustomController_Editor GetCustomControllerById(int id) => default; // 0x0000000185108180-0x0000000185108230
		public int IndexOfCustomController(int id) => default; // 0x000000018510AE60-0x000000018510AF70
		public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSetById(int id) => default; // 0x00000001851080D0-0x0000000185108180
		public int IndexOfControllerMapLayoutManagerRuleSet(int id) => default; // 0x000000018510AAB0-0x000000018510ABC0
		public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSetById(int id) => default; // 0x0000000185108020-0x00000001851080D0
		public int IndexOfControllerMapEnablerRuleSet(int id) => default; // 0x000000018510A9A0-0x000000018510AAB0
		public int GetNewPlayerId() => default; // 0x000000018510A220-0x000000018510A290
		public int GetNewActionCategoryId() => default; // 0x0000000185109EF0-0x0000000185109F60
		public int GetNewInputBehaviorId() => default; // 0x0000000185109FF0-0x000000018510A060
		public int GetNewMapCategoryId() => default; // 0x000000018510A140-0x000000018510A1B0
		public int GetNewJoystickLayoutId() => default; // 0x000000018510A060-0x000000018510A0D0
		public int GetNewKeyboardLayoutId() => default; // 0x000000018510A0D0-0x000000018510A140
		public int GetNewMouseLayoutId() => default; // 0x000000018510A1B0-0x000000018510A220
		public int GetNewCustomControllerLayoutId() => default; // 0x0000000185109F60-0x0000000185109FF0
		private Player_Editor GSZeaxXpRdMLDgOmmHuwrCgsXjs() => default; // 0x00000001851074C0-0x0000000185107930
		private InputCategory TRJwjOZSSTAKChaAiCgKPWJxOmQ() => default; // 0x000000018510BC30-0x000000018510BD90
		private InputBehavior sQjLOUlHnCqbfWBVphJhsTFnFdc() => default; // 0x000000018510E410-0x000000018510E6C0
		private InputMapCategory ecUyQZFJdpXDXsgxHLbjdNRNGMI() => default; // 0x000000018510D1E0-0x000000018510D350
		private InputLayout jrcBygfzmVMHQPmYGgpgzbYkitSc() => default; // 0x000000018510D960-0x000000018510DAF0
		private InputLayout ITVOzABurSvFsagyZmuGYtbzJir() => default; // 0x000000018510A420-0x000000018510A590
		private InputLayout asWTBfYbeGKFQPgxKcIlfswQTbMv() => default; // 0x000000018510CDF0-0x000000018510CF40
		private InputLayout tSURnYCtXucFOhJJItwlMfXhOTs() => default; // 0x000000018510EF50-0x000000018510F070
		private ControllerMap_Editor kvbIyBmFYvChuBCEzASnETXFXUAB(List<ControllerMap_Editor> param_0000853e, int param_0000853f, int param_00008540) => default; // 0x000000018510DC30-0x000000018510DD90
		private ControllerMap_Editor EthSUjOfCEJjDeZuqNYxywxsaTS(List<ControllerMap_Editor> param_00008541, List<InputLayout> param_00008542, int param_00008543, int param_00008544, bool param_00008545) => default; // 0x0000000185107130-0x0000000185107210
		private ControllerMap_Editor tGGvfeXWZunqaBgsWMyoDarqzfV(List<ControllerMap_Editor> param_00008546, List<InputLayout> param_00008547, int param_00008548, int param_00008549) => default; // 0x000000018510ED50-0x000000018510EF50
		private void kNCefiYXbcQmvFFPCzwqqkLJPnA(List<ControllerMap_Editor> param_0000854a, List<InputLayout> param_0000854b) {} // 0x000000018510DAF0-0x000000018510DC30
		internal void YJaAHaimrHWIfKrgfWxeihnqrcza() {} // 0x000000018510BD90-0x000000018510C540
	}
}
