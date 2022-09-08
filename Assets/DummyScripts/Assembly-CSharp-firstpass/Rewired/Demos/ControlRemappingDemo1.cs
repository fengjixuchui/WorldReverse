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
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired.Demos
{
	// [AddComponentMenu] // 0x0000000189B0FD10-0x0000000189B0FD40
	public class ControlRemappingDemo1 : MonoBehaviour // TypeDefIndex: 9757
	{
		// Fields
		private const float defaultModalWidth = 250f; // Metadata: 0x00AE622E
		private const float defaultModalHeight = 200f; // Metadata: 0x00AE6232
		private const float assignmentTimeout = 5f; // Metadata: 0x00AE6236
		private DialogHelper dialog; // 0x18
		private InputMapper inputMapper; // 0x20
		private InputMapper.ConflictFoundEventData conflictFoundEventData; // 0x28
		private bool guiState; // 0x30
		private bool busy; // 0x31
		private bool pageGUIState; // 0x32
		private Player selectedPlayer; // 0x38
		private int selectedMapCategoryId; // 0x40
		private ControllerSelection selectedController; // 0x48
		private ControllerMap selectedMap; // 0x50
		private bool showMenu; // 0x58
		private bool startListening; // 0x59
		private Vector2 actionScrollPos; // 0x5C
		private Vector2 calibrateScrollPos; // 0x64
		private Queue<QueueEntry> actionQueue; // 0x70
		private bool setupFinished; // 0x78
		[NonSerialized]
		private bool initialized; // 0x79
		private bool isCompiling; // 0x7A
		private GUIStyle style_wordWrap; // 0x80
		private GUIStyle style_centeredBox; // 0x88
	
		// Nested types
		private class ControllerSelection // TypeDefIndex: 9758
		{
			// Fields
			private int _id; // 0x10
			private int _idPrev; // 0x14
			private ControllerType _type; // 0x18
			private ControllerType _typePrev; // 0x1C
	
			// Properties
			public int id { /* [XID] */ /* 0x0000000189621170-0x0000000189621190 */ get => default; /* [XID] */ /* 0x00000001896289C0-0x00000001896289E0 */ set {} } // 0x0000000186546550-0x00000001865465F0 0x0000000186546730-0x00000001865467E0
			public ControllerType type { /* [XID] */ /* 0x0000000189630270-0x0000000189630290 */ get => default; /* [XID] */ /* 0x0000000189637F90-0x0000000189637FB0 */ set {} } // 0x0000000186546690-0x0000000186546730 0x00000001865467E0-0x0000000186546890
			public int idPrev { /* [XID] */ /* 0x000000018963F110-0x000000018963F130 */ get => default; } // 0x00000001865464B0-0x0000000186546550 
			public ControllerType typePrev { /* [XID] */ /* 0x000000018993A350-0x000000018993A370 */ get => default; } // 0x00000001865465F0-0x0000000186546690 
			public bool hasSelection { /* [XID] */ /* 0x000000018991B200-0x000000018991B220 */ get => default; } // 0x0000000186546400-0x00000001865464B0 
	
			// Constructors
			public ControllerSelection() {} // 0x0000000186546390-0x0000000186546400
	
			// Methods
			// [XID] // 0x0000000189655B00-0x0000000189655B20
			public void Set(int id, ControllerType type) {} // 0x00000001865462B0-0x0000000186546390
			// [XID] // 0x000000018965D2E0-0x000000018965D300
			public void Clear() {} // 0x0000000186546200-0x00000001865462B0
		}
	
		private class DialogHelper // TypeDefIndex: 9759
		{
			// Fields
			private const float openBusyDelay = 0.25f; // Metadata: 0x00AE623A
			private const float closeBusyDelay = 0.1f; // Metadata: 0x00AE623E
			private DialogType _type; // 0x10
			private bool _enabled; // 0x14
			private float _busyTime; // 0x18
			private bool _busyTimerRunning; // 0x1C
			private Action<int> drawWindowDelegate; // 0x20
			private GUI.WindowFunction drawWindowFunction; // 0x28
			private WindowProperties windowProperties; // 0x30
			private int currentActionId; // 0x60
			private Action<int, UserResponse> resultCallback; // 0x68
	
			// Properties
			private float busyTimer { /* [XID] */ /* 0x00000001898674F0-0x0000000189867510 */ get => default; } // 0x000000018654AC60-0x000000018654AD20 
			public bool enabled { /* [XID] */ /* 0x000000018966BF20-0x000000018966BF40 */ get => default; /* [XID] */ /* 0x0000000189673C90-0x0000000189673CB0 */ set {} } // 0x000000018654ADC0-0x000000018654AE60 0x000000018654AF10-0x000000018654B000
			public DialogType type { /* [XID] */ /* 0x000000018981D8B0-0x000000018981D8D0 */ get => default; /* [XID] */ /* 0x0000000189682C70-0x0000000189682C90 */ set {} } // 0x000000018654AE60-0x000000018654AF10 0x000000018654B000-0x000000018654B0D0
			public bool busy { /* [XID] */ /* 0x00000001899A23B0-0x00000001899A23D0 */ get => default; } // 0x000000018654AD20-0x000000018654ADC0 
	
			// Nested types
			public enum DialogType // TypeDefIndex: 9760
			{
				None = 0,
				JoystickConflict = 1,
				ElementConflict = 2,
				KeyConflict = 3,
				DeleteAssignmentConfirmation = 10,
				AssignElement = 11
			}
	
			// Constructors
			public DialogHelper() {} // 0x000000018654AB90-0x000000018654AC60
	
			// Methods
			// [IDTag] // 0x0000000189692580-0x00000001896925C0
			// [XID] // 0x0000000189692580-0x00000001896925C0
			public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback) {} // 0x000000018654A820-0x000000018654A980
			// [IDTag] // 0x000000018969C850-0x000000018969C890
			// [XID] // 0x000000018969C850-0x000000018969C890
			public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback, float openBusyDelay) {} // 0x000000018654A6C0-0x000000018654A820
			// [XID] // 0x0000000189A613A0-0x0000000189A613C0
			public void Update() {} // 0x000000018654AAE0-0x000000018654AB90
			// [XID] // 0x0000000189A59C00-0x0000000189A59C20
			public void Draw() {} // 0x000000018654A250-0x000000018654A400
			// [IDTag] // 0x00000001896B57C0-0x00000001896B5800
			// [XID] // 0x00000001896B57C0-0x00000001896B5800
			public void DrawConfirmButton() {} // 0x000000018654A0D0-0x000000018654A180
			// [IDTag] // 0x00000001896BF7D0-0x00000001896BF810
			// [XID] // 0x00000001896BF7D0-0x00000001896BF810
			public void DrawConfirmButton(string title) {} // 0x0000000186549D40-0x0000000186549F00
			// [IDTag] // 0x00000001896C9D10-0x00000001896C9D50
			// [XID] // 0x00000001896C9D10-0x00000001896C9D50
			public void DrawConfirmButton(UserResponse response) {} // 0x0000000186549C80-0x0000000186549D40
			// [IDTag] // 0x00000001896D4310-0x00000001896D4350
			// [XID] // 0x00000001896D4310-0x00000001896D4350
			public void DrawConfirmButton(UserResponse response, string title) {} // 0x0000000186549F00-0x000000018654A0D0
			// [IDTag] // 0x00000001896DED50-0x00000001896DED90
			// [XID] // 0x00000001896DED50-0x00000001896DED90
			public void DrawCancelButton() {} // 0x0000000186549A20-0x0000000186549AD0
			// [IDTag] // 0x00000001896E9220-0x00000001896E9260
			// [XID] // 0x00000001896E9220-0x00000001896E9260
			public void DrawCancelButton(string title) {} // 0x0000000186549AD0-0x0000000186549C80
			// [IDTag] // 0x00000001896F3680-0x00000001896F36C0
			// [XID] // 0x00000001896F3680-0x00000001896F36C0
			public void Confirm() {} // 0x00000001865498B0-0x0000000186549950
			// [IDTag] // 0x00000001896FDF40-0x00000001896FDF80
			// [XID] // 0x00000001896FDF40-0x00000001896FDF80
			public void Confirm(UserResponse response) {} // 0x0000000186549950-0x0000000186549A20
			// [XID] // 0x0000000189708310-0x0000000189708330
			public void Cancel() {} // 0x0000000186549720-0x00000001865497F0
			// [XID] // 0x000000018970FD90-0x000000018970FDB0
			private void DrawWindow(int windowId) {} // 0x000000018654A180-0x000000018654A250
			// [XID] // 0x0000000189716F50-0x0000000189716F70
			private void UpdateTimers() {} // 0x000000018654AA30-0x000000018654AAE0
			// [XID] // 0x000000018998B560-0x000000018998B580
			private void StartBusyTimer(float time) {} // 0x000000018654A600-0x000000018654A6C0
			// [XID] // 0x00000001897260E0-0x0000000189726100
			private void Close() {} // 0x00000001865497F0-0x00000001865498B0
			// [XID] // 0x000000018980EE40-0x000000018980EE60
			private void StateChanged(float delay) {} // 0x000000018654A980-0x000000018654AA30
			// [XID] // 0x00000001898DEDB0-0x00000001898DEDD0
			private void Reset() {} // 0x000000018654A550-0x000000018654A600
			// [XID] // 0x000000018973C900-0x000000018973C920
			private void ResetTimers() {} // 0x000000018654A4B0-0x000000018654A550
			// [XID] // 0x0000000189743D80-0x0000000189743DA0
			public void FullReset() {} // 0x000000018654A400-0x000000018654A4B0
		}
	
		private abstract class QueueEntry // TypeDefIndex: 9761
		{
			// Fields
			private static int uidCounter; // 0x00
	
			// Properties
			public int id { /* [XID] */ /* 0x0000000189774FB0-0x0000000189774FF0 */ get; protected set; } // 0x000000018655E2F0-0x000000018655E350 0x000000018655E520-0x000000018655E580
			public QueueActionType queueActionType { /* [XID] */ /* 0x0000000189787090-0x00000001897870D0 */ get; protected set; } // 0x000000018655E400-0x000000018655E460 0x000000018655E580-0x000000018655E5E0
			public State state { /* [XID] */ /* 0x0000000189798D50-0x0000000189798D90 */ get; /* [XID] */ /* 0x00000001897A3BF0-0x00000001897A3C30 */ protected set; } // 0x000000018655E4C0-0x000000018655E520 0x000000018655E640-0x000000018655E6A0
			public UserResponse response { /* [XID] */ /* 0x00000001897AE330-0x00000001897AE370 */ get; /* [XID] */ /* 0x00000001897B8E60-0x00000001897B8EA0 */ protected set; } // 0x000000018655E460-0x000000018655E4C0 0x000000018655E5E0-0x000000018655E640
			protected static int nextId { /* [XID] */ /* 0x000000018994EF40-0x000000018994EF60 */ get; } // 0x000000018655E350-0x000000018655E400 
	
			// Nested types
			public enum State // TypeDefIndex: 9762
			{
				Waiting = 0,
				Confirmed = 1,
				Canceled = 2
			}
	
			// Constructors
			protected QueueEntry() {} // Dummy constructor
			public QueueEntry(QueueActionType queueActionType) {} // 0x000000018655E1F0-0x000000018655E2F0
	
			// Methods
			// [XID] // 0x00000001897CB680-0x00000001897CB6A0
			public void Confirm(UserResponse response) {} // 0x000000018655E0D0-0x000000018655E1F0
			// [XID] // 0x000000018997C000-0x000000018997C020
			public void Cancel() {} // 0x000000018655DFF0-0x000000018655E0D0
		}
	
		private class JoystickAssignmentChange : QueueEntry // TypeDefIndex: 9763
		{
			// Properties
			public int playerId { /* [XID] */ /* 0x0000000189763320-0x0000000189763360 */ get; private set; } // 0x0000000186558620-0x0000000186558680 0x0000000186558740-0x00000001865587A0
			public int joystickId { /* [XID] */ /* 0x000000018980BD20-0x000000018980BD60 */ get; private set; } // 0x00000001865585C0-0x0000000186558620 0x00000001865586E0-0x0000000186558740
			public bool assign { /* [XID] */ /* 0x000000018981E010-0x000000018981E050 */ get; private set; } // 0x0000000186558560-0x00000001865585C0 0x0000000186558680-0x00000001865586E0
	
			// Constructors
			public JoystickAssignmentChange() {} // Dummy constructor
			public JoystickAssignmentChange(int newPlayerId, int joystickId, bool assign) {} // 0x0000000186558420-0x0000000186558560
		}
	
		private class ElementAssignmentChange : QueueEntry // TypeDefIndex: 9764
		{
			// Properties
			public ElementAssignmentChangeType changeType { /* [XID] */ /* 0x0000000189844A90-0x0000000189844AD0 */ get; /* [XID] */ /* 0x000000018984EE40-0x000000018984EE80 */ set; } // 0x000000018654D680-0x000000018654D6E0 0x000000018654D740-0x000000018654D7A0
			public InputMapper.Context context { /* [XID] */ /* 0x0000000189859320-0x0000000189859360 */ get; private set; } // 0x000000018654D6E0-0x000000018654D740 0x000000018654D7A0-0x000000018654D800
	
			// Constructors
			public ElementAssignmentChange() {} // Dummy constructor
			public ElementAssignmentChange(ElementAssignmentChangeType changeType, InputMapper.Context context) {} // 0x000000018654D460-0x000000018654D560
			public ElementAssignmentChange(ElementAssignmentChange other) {} // 0x000000018654D560-0x000000018654D680
		}
	
		private class FallbackJoystickIdentification : QueueEntry // TypeDefIndex: 9765
		{
			// Properties
			public int joystickId { /* [XID] */ /* 0x000000018987F590-0x000000018987F5D0 */ get; private set; } // 0x000000018654E4B0-0x000000018654E510 0x000000018654E570-0x000000018654E5D0
			public string joystickName { /* [XID] */ /* 0x0000000189890DC0-0x0000000189890E00 */ get; private set; } // 0x000000018654E510-0x000000018654E570 0x000000018654E5D0-0x000000018654E630
	
			// Constructors
			public FallbackJoystickIdentification() {} // Dummy constructor
			public FallbackJoystickIdentification(int joystickId, string joystickName) {} // 0x000000018654E3B0-0x000000018654E4B0
		}
	
		private class Calibration : QueueEntry // TypeDefIndex: 9766
		{
			// Fields
			public int selectedElementIdentifierId; // 0x40
			public bool recording; // 0x44
	
			// Properties
			public Player player { get; private set; } // 0x0000000186546020-0x0000000186546080 0x00000001865461A0-0x0000000186546200
			public ControllerType controllerType { get; private set; } // 0x0000000186545F60-0x0000000186545FC0 0x00000001865460E0-0x0000000186546140
			public Joystick joystick { /* [XID] */ /* 0x00000001898EAEE0-0x00000001898EAF20 */ get; private set; } // 0x0000000186545FC0-0x0000000186546020 0x0000000186546140-0x00000001865461A0
			public CalibrationMap calibrationMap { /* [XID] */ /* 0x00000001898FCE90-0x00000001898FCED0 */ get; private set; } // 0x0000000186545F00-0x0000000186545F60 0x0000000186546080-0x00000001865460E0
	
			// Constructors
			public Calibration() {} // Dummy constructor
			public Calibration(Player player, Joystick joystick, CalibrationMap calibrationMap) {} // 0x0000000186545DC0-0x0000000186545F00
		}
	
		private struct WindowProperties // TypeDefIndex: 9767
		{
			// Fields
			public int windowId; // 0x00
			public Rect rect; // 0x04
			public Action<string, string> windowDrawDelegate; // 0x18
			public string title; // 0x20
			public string message; // 0x28
		}
	
		private enum QueueActionType // TypeDefIndex: 9768
		{
			None = 0,
			JoystickAssignment = 1,
			ElementAssignment = 2,
			FallbackJoystickIdentification = 3,
			Calibrate = 4
		}
	
		private enum ElementAssignmentChangeType // TypeDefIndex: 9769
		{
			Add = 0,
			Replace = 1,
			Remove = 2,
			ReassignOrRemove = 3,
			ConflictCheck = 4
		}
	
		public enum UserResponse // TypeDefIndex: 9770
		{
			Confirm = 0,
			Cancel = 1,
			Custom1 = 2,
			Custom2 = 3
		}
	
		// Constructors
		public ControlRemappingDemo1() {} // 0x00000001862C8820-0x00000001862C88B0
	
		// Methods
		// [XID] // 0x0000000189786EE0-0x0000000189786F00
		private void Awake() {} // 0x00000001862BEC00-0x00000001862BED40
		// [XID] // 0x0000000189A627E0-0x0000000189A62800
		private void OnEnable() {} // 0x00000001862C6310-0x00000001862C63B0
		// [XID] // 0x000000018981DE90-0x000000018981DEB0
		private void OnDisable() {} // 0x00000001862C6270-0x00000001862C6310
		// [XID] // 0x000000018978E580-0x000000018978E5A0
		private void Initialize() {} // 0x00000001862C5700-0x00000001862C5920
		// [XID] // 0x000000018997EF90-0x000000018997EFB0
		private void Setup() {} // 0x00000001862C83D0-0x00000001862C8570
		// [XID] // 0x0000000189A80C80-0x0000000189A80CA0
		private void Subscribe() {} // 0x00000001862C8620-0x00000001862C8770
		// [XID] // 0x00000001898000E0-0x0000000189800100
		private void Unsubscribe() {} // 0x00000001862C8770-0x00000001862C8820
		// [XID] // 0x0000000189A8FF10-0x0000000189A8FF30
		public void OnGUI() {} // 0x00000001862C63B0-0x00000001862C64A0
		// [XID] // 0x0000000189947BB0-0x0000000189947BD0
		private void HandleMenuControl() {} // 0x00000001862C52D0-0x00000001862C5480
		// [XID] // 0x0000000189965BC0-0x0000000189965BE0
		private void Close() {} // 0x00000001862BF080-0x00000001862BF130
		// [XID] // 0x000000018994F290-0x000000018994F2B0
		private void Open() {} // 0x00000001862C6550-0x00000001862C65F0
		// [XID] // 0x0000000189AADA00-0x0000000189AADA20
		private void DrawInitialScreen() {} // 0x00000001862C2F20-0x00000001862C3220
		// [XID] // 0x0000000189AB51F0-0x0000000189AB5210
		private void DrawPage() {} // 0x00000001862C47E0-0x00000001862C4A70
		// [XID] // 0x0000000189ABCE50-0x0000000189ABCE70
		private void DrawPlayerSelector() {} // 0x00000001862C4A70-0x00000001862C4EA0
		// [XID] // 0x0000000189AC4770-0x0000000189AC4790
		private void DrawMouseAssignment() {} // 0x00000001862C4360-0x00000001862C47E0
		// [XID] // 0x0000000189ACBE80-0x0000000189ACBEA0
		private void DrawJoystickSelector() {} // 0x00000001862C3400-0x00000001862C39B0
		// [XID] // 0x00000001898C2700-0x00000001898C2720
		private void DrawControllerSelector() {} // 0x00000001862C1C80-0x00000001862C23D0
		// [XID] // 0x0000000189ADB370-0x0000000189ADB390
		private void DrawCalibrateButton() {} // 0x00000001862BF8A0-0x00000001862BFCE0
		// [XID] // 0x0000000189AE2B60-0x0000000189AE2B80
		private void DrawMapCategories() {} // 0x00000001862C39B0-0x00000001862C4020
		// [XID] // 0x0000000189759300-0x0000000189759320
		private void DrawCategoryActions() {} // 0x00000001862C0D50-0x00000001862C1C80
		// [XID] // 0x0000000189858C40-0x0000000189858C60
		private void DrawActionAssignmentButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap) {} // 0x00000001862BF380-0x00000001862BF660
		// [XID] // 0x000000018965FA40-0x000000018965FA60
		private void DrawInvertButton(int playerId, InputAction action, Pole actionAxisContribution, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap) {} // 0x00000001862C3220-0x00000001862C3400
		// [XID] // 0x00000001897C2EB0-0x00000001897C2ED0
		private void DrawAddActionMapButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap) {} // 0x00000001862BF660-0x00000001862BF8A0
		// [XID] // 0x0000000189686410-0x0000000189686430
		private void ShowDialog() {} // 0x00000001862C8570-0x00000001862C8620
		// [XID] // 0x00000001899DD480-0x00000001899DD4A0
		private void DrawModalWindow(string title, string message) {} // 0x00000001862C41B0-0x00000001862C4360
		// [XID] // 0x0000000189B16E60-0x0000000189B16E80
		private void DrawModalWindow_OkayOnly(string title, string message) {} // 0x00000001862C4020-0x00000001862C41B0
		// [XID] // 0x0000000189B1E660-0x0000000189B1E680
		private void DrawElementAssignmentWindow(string title, string message) {} // 0x00000001862C2860-0x00000001862C2BF0
		// [XID] // 0x0000000189B26070-0x0000000189B26090
		private void DrawElementAssignmentProtectedConflictWindow(string title, string message) {} // 0x00000001862C2630-0x00000001862C2860
		// [XID] // 0x0000000189B2D300-0x0000000189B2D320
		private void DrawElementAssignmentNormalConflictWindow(string title, string message) {} // 0x00000001862C23D0-0x00000001862C2630
		// [XID] // 0x0000000189B34850-0x0000000189B34870
		private void DrawReassignOrRemoveElementAssignmentWindow(string title, string message) {} // 0x00000001862C4EA0-0x00000001862C5060
		// [XID] // 0x00000001899A1FF0-0x00000001899A2010
		private void DrawFallbackJoystickIdentificationWindow(string title, string message) {} // 0x00000001862C2BF0-0x00000001862C2F20
		// [XID] // 0x0000000189B43CB0-0x0000000189B43CD0
		private void DrawCalibrationWindow(string title, string message) {} // 0x00000001862BFCE0-0x00000001862C0D50
		// [XID] // 0x0000000189798120-0x0000000189798140
		private void DialogResultCallback(int queueActionId, UserResponse response) {} // 0x00000001862BF1D0-0x00000001862BF380
		// [XID] // 0x00000001898FCD60-0x00000001898FCD80
		private Rect GetScreenCenteredRect(float width, float height) => default; // 0x00000001862C5160-0x00000001862C52D0
		// [XID] // 0x0000000189B5A4C0-0x0000000189B5A4E0
		private void EnqueueAction(QueueEntry entry) {} // 0x00000001862C5060-0x00000001862C5160
		// [XID] // 0x0000000189B618E0-0x0000000189B61900
		private void ProcessQueue() {} // 0x00000001862C7870-0x00000001862C7A90
		// [XID] // 0x0000000189B694D0-0x0000000189B694F0
		private bool ProcessJoystickAssignmentChange(JoystickAssignmentChange entry) => default; // 0x00000001862C74B0-0x00000001862C7870
		// [XID] // 0x0000000189675F00-0x0000000189675F20
		private bool ProcessElementAssignmentChange(ElementAssignmentChange entry) => default; // 0x00000001862C6CB0-0x00000001862C6E00
		// [XID] // 0x00000001896943F0-0x0000000189694410
		private bool ProcessRemoveOrReassignElementAssignment(ElementAssignmentChange entry) => default; // 0x00000001862C7D40-0x00000001862C8010
		// [XID] // 0x00000001899EC090-0x00000001899EC0B0
		private bool ProcessRemoveElementAssignment(ElementAssignmentChange entry) => default; // 0x00000001862C7A90-0x00000001862C7D40
		// [XID] // 0x0000000189B870F0-0x0000000189B87110
		private bool ProcessAddOrReplaceElementAssignment(ElementAssignmentChange entry) => default; // 0x00000001862C6690-0x00000001862C6A30
		// [XID] // 0x0000000189A93C70-0x0000000189A93C90
		private bool ProcessElementAssignmentConflictCheck(ElementAssignmentChange entry) => default; // 0x00000001862C6E00-0x00000001862C7290
		// [XID] // 0x0000000189B957C0-0x0000000189B957E0
		private bool ProcessFallbackJoystickIdentification(FallbackJoystickIdentification entry) => default; // 0x00000001862C7290-0x00000001862C74B0
		// [XID] // 0x0000000189B9CC90-0x0000000189B9CCB0
		private bool ProcessCalibration(Calibration entry) => default; // 0x00000001862C6A30-0x00000001862C6CB0
		// [XID] // 0x000000018961C760-0x000000018961C780
		private void PlayerSelectionChanged() {} // 0x00000001862C65F0-0x00000001862C6690
		// [XID] // 0x0000000189894A10-0x0000000189894A30
		private void ControllerSelectionChanged() {} // 0x00000001862BF130-0x00000001862BF1D0
		// [XID] // 0x0000000189BB2F20-0x0000000189BB2F40
		private void ClearControllerSelection() {} // 0x00000001862BEDE0-0x00000001862BEEA0
		// [XID] // 0x0000000189BBA4A0-0x0000000189BBA4C0
		private void ClearMapSelection() {} // 0x00000001862BEEA0-0x00000001862BEF50
		// [XID] // 0x00000001897C3C10-0x00000001897C3C30
		private void ResetAll() {} // 0x00000001862C80C0-0x00000001862C8170
		// [XID] // 0x0000000189BC9A50-0x0000000189BC9A70
		private void ClearWorkingVars() {} // 0x00000001862BEF50-0x00000001862BF080
		// [XID] // 0x00000001897D2C80-0x00000001897D2CA0
		private void SetGUIStateStart() {} // 0x00000001862C8270-0x00000001862C83D0
		// [XID] // 0x0000000189BD8870-0x0000000189BD8890
		private void SetGUIStateEnd() {} // 0x00000001862C8170-0x00000001862C8270
		// [XID] // 0x0000000189795C40-0x0000000189795C60
		private void JoystickConnected(ControllerStatusChangedEventArgs args) {} // 0x00000001862C5920-0x00000001862C5CD0
		// [XID] // 0x00000001899138A0-0x00000001899138C0
		private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args) {} // 0x00000001862C5DC0-0x00000001862C61C0
		// [XID] // 0x00000001895F4500-0x00000001895F4520
		private void JoystickDisconnected(ControllerStatusChangedEventArgs args) {} // 0x00000001862C5CD0-0x00000001862C5DC0
		// [XID] // 0x00000001895FBC40-0x00000001895FBC60
		private void OnConflictFound(InputMapper.ConflictFoundEventData data) {} // 0x00000001862C61C0-0x00000001862C6270
		// [XID] // 0x0000000189931650-0x0000000189931670
		private void OnStopped(InputMapper.StoppedEventData data) {} // 0x00000001862C64A0-0x00000001862C6550
		// [XID] // 0x000000018960AF70-0x000000018960AF90
		public void IdentifyAllJoysticks() {} // 0x00000001862C5480-0x00000001862C5700
		// [XID] // 0x0000000189612350-0x0000000189612370
		protected void CheckRecompile() {} // 0x00000001862BED40-0x00000001862BEDE0
		// [XID] // 0x0000000189619CD0-0x0000000189619CF0
		private void RecompileWindow(int windowId) {} // 0x00000001862C8010-0x00000001862C80C0
	}
}
