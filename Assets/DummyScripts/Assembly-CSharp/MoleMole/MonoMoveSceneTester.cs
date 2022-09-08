/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.UAuto;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMoveSceneTester : MonoBehaviour // TypeDefIndex: 27805
	{
		// Fields
		internal static Action Raise; // 0x00
		private MoveTestCase _currentTestCase; // 0x18
		public const string MANIFEST_FILE_PATH = "QA/TestScene/MoveSceneTestCases/Manifest"; // Metadata: 0x00B0CE4B
		public const string MOVE_CASES_DIR = "Assets/MoleRes/Long/SRes/QA/TestScene/MoveSceneTestCases"; // Metadata: 0x00B0CE77
		private const int LADDER_COUNT = 10; // Metadata: 0x00B0CEB3
		private bool _skippedFirstFrame; // 0x20
		public MoveCaseManifest moveCaseManifest; // 0x28
		private bool _caseStatusSwitch; // 0x30
		private bool _replayStatus; // 0x31
		private bool _showMoveState; // 0x32
		private bool _avatarEasy2Die; // 0x33
		private Dictionary<int, List<MoveCaseInfo>> _allCases; // 0x38
		private Dictionary<int, List<MoveCaseInfo>> _selectedCases; // 0x40
		private List<MoveCaseInfo> _curTypeCases; // 0x48
		private MoveCaseInfo _curCaseInfo; // 0x50
		private AvatarEntity _localAvatar; // 0x70
		private GameObject _localAvatarGo; // 0x78
		public GameObject lineRenderGo; // 0x80
		private List<Transform> _avatarBones; // 0x88
		private List<Transform> _dynamicBones; // 0x90
		private float _trailTime; // 0x98
		private int _teleportFrameCounts; // 0x9C
		private List<GameObject> _lineRenderGos; // 0xA0
		private List<GameObject> _lineRenderGosDynamic; // 0xA8
		private List<GameObject> _mutedMeshRenderObjs; // 0xB0
		private GameObject _water; // 0xB8
		private Dictionary<string, List<string>> _spawnPointMaps; // 0xC0
		private float _timer; // 0xC8
		private TimerStatus timerSta; // 0xCC
		public static bool bEnableTick; // 0x08
		public static bool flood; // 0x09
		public static float floodDepth; // 0x0C
		public Toggle showToolBar; // 0xD0
		public Dropdown playModeChos; // 0xD8
		public Button replay; // 0xE0
		public Dropdown caseKindsChos; // 0xE8
		public Toggle mannual; // 0xF0
		public Dropdown caseNoChos; // 0xF8
		public Slider timeScaleSlider; // 0x100
		public InputField timeScaleInput; // 0x108
		public UnityEngine.UI.Text TimerTxt; // 0x110
		public Button TimerCount; // 0x118
		public Button TimerReset; // 0x120
		public Toggle highLightAvatarBones; // 0x128
		public Toggle highLightDynamicBones; // 0x130
		public Slider trailTimeSlider; // 0x138
		public UnityEngine.UI.Text trailTimeTxt; // 0x140
		public UnityEngine.UI.Text StateTxt; // 0x148
		private List<string> caseTypesDescs; // 0x150
		private Queue<float> heighs; // 0x158
		private PlayMode _playMode; // 0x160
		private AutoTestReporter _reporter; // 0x168
		private TestSuite _currentSmokeSuite; // 0x170
		private TestCase _currentSmokeCase; // 0x178
	
		// Properties
		public GameObject localAvatarGo { /* [XID] */ /* 0x0000000189AD5C20-0x0000000189AD5C40 */ get => default; } // 0x0000000182F21430-0x0000000182F214D0 
	
		// Constructors
		public MonoMoveSceneTester() {} // 0x0000000182F211A0-0x0000000182F21430
		static MonoMoveSceneTester() {} // 0x0000000182F21100-0x0000000182F211A0
	
		// Methods
		// [XID] // 0x0000000189ADD620-0x0000000189ADD640
		public void Awake() {} // 0x0000000182F1B020-0x0000000182F1B340
		// [XID] // 0x0000000189AE4D50-0x0000000189AE4D70
		private void Start() {} // 0x0000000182F1FAD0-0x0000000182F21100
		// [XID] // 0x0000000189AEC470-0x0000000189AEC490
		private void GetSpawnPoints() {} // 0x0000000182F1C1A0-0x0000000182F1C300
		// [XID] // 0x0000000189AF3E90-0x0000000189AF3EB0
		private void GetSpawnPointTrans(Transform tran) {} // 0x0000000182F1F620-0x0000000182F1F920
		// [XID] // 0x0000000189AFB4E0-0x0000000189AFB500
		private void BonesThanMeshs(bool bonesFirst) {} // 0x0000000182F1D710-0x0000000182F1DBC0
		// [XID] // 0x0000000189B02CA0-0x0000000189B02CC0
		private void DrawBones() {} // 0x0000000182F1B650-0x0000000182F1BEC0
		// [XID] // 0x0000000189B0A430-0x0000000189B0A450
		private void ShowToolBar(bool showBar) {} // 0x0000000182F1F260-0x0000000182F1F430
		// [XID] // 0x0000000189B11C10-0x0000000189B11C30
		private void HighlightBodyBones(bool show) {} // 0x0000000182F1CB30-0x0000000182F1CD70
		// [XID] // 0x0000000189B18EC0-0x0000000189B18EE0
		private void HighlightDynamicBones(bool show) {} // 0x0000000182F1BF60-0x0000000182F1C1A0
		// [XID] // 0x0000000189B20550-0x0000000189B20570
		private void OnChangePlayMode(int modeIdx) {} // 0x0000000182F1F430-0x0000000182F1F620
		// [XID] // 0x0000000189B27C20-0x0000000189B27C40
		private void OnChangeCaseKind(int idx) {} // 0x0000000182F1C4E0-0x0000000182F1C9C0
		// [XID] // 0x0000000189B2EF30-0x0000000189B2EF50
		private void OnChangeCaseNo(int caseIdx) {} // 0x0000000182F1CD70-0x0000000182F1CE50
		// [XID] // 0x0000000189B36870-0x0000000189B36890
		private void OnTimeScaleSliderSlid(float value) {} // 0x0000000182F1F180-0x0000000182F1F260
		// [XID] // 0x0000000189B3E050-0x0000000189B3E070
		private void OnTimeScaleInput(string scaleTxt) {} // 0x0000000182F1D3B0-0x0000000182F1D580
		// [XID] // 0x0000000189B45DD0-0x0000000189B45DF0
		private void OnReplay() {} // 0x0000000182F1BEC0-0x0000000182F1BF60
		// [XID] // 0x0000000189B4D1F0-0x0000000189B4D210
		private void OnTimerCount() {} // 0x0000000182F1FA20-0x0000000182F1FAD0
		// [XID] // 0x0000000189B54A60-0x0000000189B54A80
		private void OnTimerReset() {} // 0x0000000182F1C300-0x0000000182F1C3A0
		// [XID] // 0x0000000189B5C510-0x0000000189B5C530
		private void OnTrailTimeChanged(float trailTime) {} // 0x0000000182F1C3A0-0x0000000182F1C4E0
		// [XID] // 0x0000000189B63B60-0x0000000189B63B80
		private void HandleSceneGo() {} // 0x0000000182F1CF30-0x0000000182F1D060
		// [XID] // 0x0000000189B6B2E0-0x0000000189B6B300
		private void TeleportToPosition(Vector3 pos, float yaw = 0f /* Metadata: 0x00B0CE47 */) {} // 0x0000000182F1B340-0x0000000182F1B650
		// [XID] // 0x0000000189B72940-0x0000000189B72960
		private void RaiseAvatar() {} // 0x0000000182F1D060-0x0000000182F1D190
		// [XID] // 0x0000000189B79E50-0x0000000189B79E70
		public void LateUpdate() {} // 0x0000000182F1DE20-0x0000000182F1EE80
		// [XID] // 0x0000000189B81580-0x0000000189B815A0
		private void FixedUpdate() {} // 0x0000000182F1C9C0-0x0000000182F1CB30
		// [XID] // 0x0000000189B88CF0-0x0000000189B88D10
		private void SwitchNextCase() {} // 0x0000000182F1DBC0-0x0000000182F1DE20
		// [XID] // 0x0000000189B90200-0x0000000189B90220
		private string ListToString(List<int> list) => default; // 0x0000000182F1D190-0x0000000182F1D3B0
		// [XID] // 0x0000000189B97640-0x0000000189B97660
		public void MoveCaseLogRecord(string condition, string stackTrace, LogType type) {} // 0x0000000182F1EE80-0x0000000182F1F180
		// [XID] // 0x0000000189B9EB00-0x0000000189B9EB20
		public static bool IsDescendant(Transform child, Transform parent) => default; // 0x0000000182F1D580-0x0000000182F1D710
		// [XID] // 0x0000000189BA63B0-0x0000000189BA63D0
		private void OnDestroy() {} // 0x0000000182F1F920-0x0000000182F1FA20
	}
}
