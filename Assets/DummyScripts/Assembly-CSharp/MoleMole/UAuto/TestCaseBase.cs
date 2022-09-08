/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using HedgehogTeam.EasyTouch;
using MoleMole;
using MoleMole.Config;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	public class TestCaseBase : IObserver // TypeDefIndex: 28038
	{
		// Fields
		public const float findTimeout = 120f; // Metadata: 0x00B0D48F
		public const float maxTimeout = 300f; // Metadata: 0x00B0D493
		public float timePassed; // 0x10
		public GameObject loadingPage; // 0x18
		public Slider loading; // 0x20
		public WaitForEndOfFrame delay; // 0x28
		public AutoTestDriver driver; // 0x30
		public GameObject InLevelMainPage; // 0x38
		public GameObject InLevelMapPage; // 0x40
		public EntityManager entityManager; // 0x48
		public BaseEntity avatar; // 0x50
		public CameraEntity camera; // 0x58
		public MonoJoyStick_H4 monoJoyStick_H4; // 0x60
		public EventSystem eventSystem; // 0x68
		public Vector2 _fixedAnchorPos; // 0x70
		public GameManager gameManager; // 0x78
		public string lastSnapShot; // 0x80
		public string realtimeRecordUrl; // 0x88
		public static CharacterAIBehaviour _characterAI; // 0x00
		private const int DEFAULT_CMD_ID = -1; // Metadata: 0x00B0D497
		private MiNetClient luaClient; // 0x90
		public bool luaClientInited; // 0x98
		public int waitNetCmd; // 0x9C
		private GameObject lastClickObject; // 0xA0
		private Vector2 avatarVector; // 0xA8
		private Vector2 towardsVector; // 0xB0
		private Vector2 cameraVector; // 0xB8
		private Vector2 avatarToTowards; // 0xC0
		private Vector2 cameraToAvatar; // 0xC8
		private static bool isDialogDataLoaded; // 0x08
		private HashSet<uint> _shieldDialogs; // 0xD0
		private Dictionary<uint, List<HomeWorldFurnitureExcelConfig>> _furnitureConfigMap; // 0xD8
		private List<HomeWorldFurnitureExcelConfig> _animalList; // 0xE0
		private List<HomeWorldFurnitureExcelConfig> _itemList; // 0xE8
		private Dictionary<uint, HomeWorldFurnitureTypeExcelConfig> _typeConfigs; // 0xF0
		private MonoHomeworldEnvironmentSetting _environmentSetting; // 0xF8
		protected GadgetEntity _parentGadget; // 0x100
		private Vector3 _initSpawnPos; // 0x108
		private uint _seed; // 0x114
		private int _minCount; // 0x118
		private int _maxCount; // 0x11C
		private HashSet<uint> filterFurniture; // 0x120
		private HashSet<uint> filterFurnitureType; // 0x128
		private Vector3 initCamera; // 0x130
		private Vector3 initAvatar; // 0x13C
		private GameObject connect; // 0x148
		private GameObject serverSelect; // 0x150
		private Button connectBt; // 0x158
		private bool AIMoving; // 0x160
		private bool moveStopped; // 0x161
		private Coroutine moveCoroutine; // 0x168
		protected MiNetClient client; // 0x170
		public bool clientInited; // 0x178
		private string expectedName; // 0x180
		private MessageBase expectedRecv; // 0x188
		private List<MessageBase> waitingRecvs; // 0x190
	
		// Nested types
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		public delegate void ActionGameObject(GameObject entity); // TypeDefIndex: 28039; 0x00000001827CFE40-0x00000001827D00A0
	
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		public delegate void ActionGameObjects(List<GameObject> entity); // TypeDefIndex: 28040; 0x00000001827D0230-0x00000001827D0490
	
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		public delegate void ActionEntity(BaseEntity entity); // TypeDefIndex: 28041; 0x00000001827CFA50-0x00000001827CFCB0
	
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		public delegate void ActionEntities(List<BaseEntity> entity); // TypeDefIndex: 28042; 0x00000001827CF660-0x00000001827CF8C0
	
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		public delegate void ActionTrans(Transform trans); // TypeDefIndex: 28043; 0x00000001827D0A20-0x00000001827D0C80
	
		public delegate IEnumerator ActionIEtTrans(Transform trans); // TypeDefIndex: 28044; 0x00000001827D0630-0x00000001827D0890
	
		public class OffLinePlayerGenderDeductor : PlayerGenderDeductor // TypeDefIndex: 28045
		{
			// Fields
			public AutoTestDriver driver; // 0x10
	
			// Constructors
			public OffLinePlayerGenderDeductor() {} // 0x00000001827D0E60-0x00000001827D0EC0
	
			// Methods
			public override Gender GetPlayerGender() => default; // 0x00000001827D0D00-0x00000001827D0E60
		}
	
		public struct CameraData // TypeDefIndex: 28046
		{
			// Fields
			public Vector3 cameraPosition; // 0x00
			public Vector3 cameraSpherical; // 0x0C
			public Vector3 cameraForward; // 0x18
			public Vector3 cameraUp; // 0x24
			public Vector3 cameraRotation; // 0x30
			public Vector3 refAnchorPosition; // 0x3C
		}
	
		// Constructors
		public TestCaseBase() {} // 0x0000000181072920-0x0000000181072D60
		static TestCaseBase() {} // 0x00000001810728B0-0x0000000181072920
	
		// Methods
		public void InitLuaNetClient() {} // 0x000000018106A4F0-0x000000018106A6D0
		public void OnDisconnected() {} // 0x000000018106C150-0x000000018106C1B0
		public bool OnLuaPacketCallback(Packet packet) => default; // 0x000000018106C1B0-0x000000018106C220
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitForANetCmd(int frame = 10 /* Metadata: 0x00B0D2D6 */) => default; // 0x0000000181071670-0x0000000181071710
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator StartCoroutine(IEnumerator coroutine) => default; // 0x000000018106FDA0-0x000000018106FE40
		public void StopCorutine(Coroutine coroutine) {} // 0x00000001810701F0-0x0000000181070270
		public void BaseTest() {} // 0x0000000181062E80-0x0000000181062F10
		[SetUp] // 0x00000001898B1F70-0x00000001898B1F80
		public virtual void SetUp() {} // 0x000000018106EAC0-0x000000018106EB10
		[TearDown] // 0x000000018987E7E0-0x000000018987E7F0
		public virtual void TearDown() {} // 0x0000000181070580-0x00000001810705D0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public virtual IEnumerator OnNotify(GameObject sender) => default; // 0x000000018106C220-0x000000018106C2C0
		public bool FindObjectInGame(string name, ActionGameObject result, float timeout = 120f /* Metadata: 0x00B0D2DA */, bool skipIfNotExist = false /* Metadata: 0x00B0D2DE */) => default; // 0x00000001810672A0-0x00000001810674B0
		public bool FindChildObjectInUsed(string name, ActionGameObject result, float timeout = 120f /* Metadata: 0x00B0D2DF */, bool skipIfNotExist = false /* Metadata: 0x00B0D2E3 */) => default; // 0x0000000181067000-0x00000001810672A0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitLevelLoaded(string name, float timeout = 480f /* Metadata: 0x00B0D2E4 */, bool levelWaitLoadUI = false /* Metadata: 0x00B0D2E8 */) => default; // 0x0000000181072370-0x0000000181072440
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CollectPoint() => default; // 0x0000000181065460-0x00000001810654D0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator MouseClick(string path, bool skipUp = false /* Metadata: 0x00B0D2E9 */, bool skipDown = false /* Metadata: 0x00B0D2EA */, bool skipIfTimeout = false /* Metadata: 0x00B0D2EB */) => default; // 0x000000018106B760-0x000000018106B820
		public void MouseClickNotWait(string path) {} // 0x000000018106B520-0x000000018106B760
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator MouseClickForNetCmd(string path) => default; // 0x000000018106B480-0x000000018106B520
		public bool CheckGameObjectActive(string path) => default; // 0x0000000181063FA0-0x0000000181064060
		public void MouseUp() {} // 0x000000018106B820-0x000000018106B980
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitFoundGameObject(string name, ActionGameObject result, bool closeMap = false /* Metadata: 0x00B0D2EC */, float timeout = 60f /* Metadata: 0x00B0D2ED */, bool closeAll = false /* Metadata: 0x00B0D2F1 */, bool skipIfNotFound = false /* Metadata: 0x00B0D2F2 */) => default; // 0x0000000181071CB0-0x0000000181071D80
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitFoundAndClickButton(string fatherUrl, string childUrl, float timeout = 60f /* Metadata: 0x00B0D2F3 */) => default; // 0x0000000181071A80-0x0000000181071B30
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitFoundGameObjectChild(string name, ActionGameObject result, bool closeMap = false /* Metadata: 0x00B0D2F7 */, float timeout = 60f /* Metadata: 0x00B0D2F8 */, bool closeAll = false /* Metadata: 0x00B0D2FC */, bool skipIfNotFound = false /* Metadata: 0x00B0D2FD */) => default; // 0x0000000181071BE0-0x0000000181071CB0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitClickWeaponIcon(string name, uint itemId, Action<WeaponItem> successAction = null, float timeout = 30f /* Metadata: 0x00B0D2FE */) => default; // 0x00000001810712F0-0x00000001810713B0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitClickChildByOrderId(string name, int orderId, float timeout = 30f /* Metadata: 0x00B0D302 */) => default; // 0x0000000181071230-0x00000001810712F0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitFoundGameObjectsInChildren(GameObject go, string name, ActionGameObjects result, float timeout = 30f /* Metadata: 0x00B0D306 */) => default; // 0x0000000181071D80-0x0000000181071E50
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitTrue(bool obj, float timeout = 120f /* Metadata: 0x00B0D30A */, string message = "" /* Metadata: 0x00B0D30E */) => default; // 0x00000001810726F0-0x00000001810727B0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitNotNull(GameObject obj, float timeout = 120f /* Metadata: 0x00B0D312 */) => default; // 0x00000001810725B0-0x0000000181072660
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitNotNull(Component component, float timeout = 120f /* Metadata: 0x00B0D316 */) => default; // 0x0000000181072500-0x00000001810725B0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitFrames(int count) => default; // 0x0000000181072240-0x00000001810722D0
		public void CloseNotExitEnityReport() {} // 0x0000000181065360-0x0000000181065460
		private bool CheckSceneLoaded(string name) => default; // 0x0000000181064340-0x00000001810646C0
		private bool CheckProgressDialog() => default; // 0x00000001810641A0-0x0000000181064340
		private bool IsInLevelMainPageActive() => default; // 0x000000018106A6D0-0x000000018106A7A0
		private Vector2 ComputeMoveVector2(Vector2 _fixedAnchorPos, Vector3 target, bool isDirection = false /* Metadata: 0x00B0D31A */, bool isWalk = false /* Metadata: 0x00B0D31B */) => default; // 0x00000001810654D0-0x0000000181065940
		private void SetScriptedMoveEnded(ScriptedMoveToInfo.ReachPointState state, int waypointIndex) {} // 0x000000018106E720-0x000000018106E7E0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator MoveCoroutine(CameraData camera, string key) => default; // 0x000000018106BB50-0x000000018106BC30
		public void ChangeLang(string language) {} // 0x00000001810636E0-0x0000000181063AE0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator EmulateDialogByMainQuestId(uint mainQuestCfgId) => default; // 0x0000000181066730-0x00000001810667D0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator EmulateDialog(uint talkCfgId, string title) => default; // 0x0000000181066880-0x0000000181066930
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator EmulateDialog(LuaTable table, string title) => default; // 0x00000001810667D0-0x0000000181066880
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator DoEmulateDialog(List<DialogExcelConfig> list) => default; // 0x00000001810665F0-0x0000000181066690
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator PlayVoiceDialog(uint dialogId) => default; // 0x000000018106C9A0-0x000000018106CA30
		private string GetPreExcelText(List<DialogExcelConfig> list, uint id) => default; // 0x00000001810695D0-0x00000001810699D0
		public void CloseDiaLog() {} // 0x00000001810652E0-0x0000000181065360
		public void InitDiaLogConfig() {} // 0x000000018106A150-0x000000018106A320
		public void ShieldErrorDiaLog(uint dialogId) {} // 0x000000018106F3A0-0x000000018106F430
		private List<DialogExcelConfig> CalDialogSequence(uint startDialog) => default; // 0x00000001810630F0-0x0000000181063480
		public void AddFurnitureFilter(uint id) {} // 0x00000001810626F0-0x0000000181062780
		public void AddFurnitureFilterType(uint id) {} // 0x0000000181062660-0x00000001810626F0
		private float rand() => default; // 0x0000000181072EE0-0x0000000181072F70
		public void SetupAvaliableFurnitureConfigs(uint seed, int minCount = 5 /* Metadata: 0x00B0D31C */, int maxCount = 10 /* Metadata: 0x00B0D320 */) {} // 0x000000018106EB10-0x000000018106F3A0
		public void InitHomeWorld(uint seed) {} // 0x000000018106A470-0x000000018106A4F0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator RandSetFuture() => default; // 0x000000018106CAE0-0x000000018106CB70
		public void SpawnGadgetForDeploy(HomeWorldFurnitureExcelConfig excelData, float x, float z, float y = 0f /* Metadata: 0x00B0D324 */) {} // 0x000000018106F780-0x000000018106FB40
		public void InitAvatarRotate(Vector3 forward) {} // 0x000000018106A070-0x000000018106A150
		public string GetPlatformString() => default; // 0x0000000181069420-0x0000000181069480
		public void ClearWaterGrassEntityList() {} // 0x0000000181064930-0x0000000181064A40
		public List<BaseEntity> GetWaterEntity() => default; // 0x0000000181069FA0-0x000000018106A070
		public List<BaseEntity> GetGrassEntity() => default; // 0x0000000181068AD0-0x0000000181068BA0
		public void AddMessageInFailure(string message) {} // 0x0000000181062780-0x0000000181062910
		public void clearall() {} // 0x0000000181072D60-0x0000000181072EE0
		private void SetServerName(string serverName) {} // 0x000000018106E7E0-0x000000018106E900
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator EnterWorldInGM(bool isBoy = true /* Metadata: 0x00B0D328 */) => default; // 0x0000000181066C10-0x0000000181066CB0
		public virtual string RunStatGM(string cmd) => default; // 0x000000018106D3C0-0x000000018106D450
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public virtual IEnumerator RunGM(string cmd, bool addAvatarAfterClear = true /* Metadata: 0x00B0D329 */, bool local = true /* Metadata: 0x00B0D32A */, bool skipWait = false /* Metadata: 0x00B0D32B */, bool isBoy = true /* Metadata: 0x00B0D32C */, bool skipSDK = false /* Metadata: 0x00B0D32D */) => default; // 0x000000018106D2F0-0x000000018106D3C0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator Reconnect() => default; // 0x000000018106CC00-0x000000018106CC90
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator FinishAllNoobs() => default; // 0x00000001810674B0-0x0000000181067540
		public float GetCurrentY(float x, float z) => default; // 0x0000000181067CF0-0x0000000181067E20
		public bool IsInLimitRegion(Vector3 pos) => default; // 0x000000018106A7A0-0x000000018106A860
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator AddToTeam(ulong guid) => default; // 0x0000000181062910-0x00000001810629B0
		public uint GetPlayerId() => default; // 0x0000000181069480-0x00000001810695D0
		public ulong GetGuidByAvatarConfigID(uint avatarConfigId) => default; // 0x0000000181068BA0-0x0000000181068E10
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator ChangeToAvatarInTeam(uint avatarConfigID) => default; // 0x0000000181063AE0-0x0000000181063B80
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator ChangeToAvatarMutiplayer(uint avatarConfigID, bool isDungeon) => default; // 0x0000000181063B80-0x0000000181063C30
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator DeleteAllAvatar() => default; // 0x0000000181066460-0x00000001810664F0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator RefreshTeam(uint avatarConfigID, bool isLeader = false /* Metadata: 0x00B0D32E */) => default; // 0x000000018106CC90-0x000000018106CD40
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator ClearTeam() => default; // 0x00000001810648A0-0x0000000181064930
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator AddAvatars() => default; // 0x0000000181062530-0x00000001810625C0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SetUpVariables() => default; // 0x000000018106EA30-0x000000018106EAC0
		public uint GetOtherAvatarConfigId() => default; // 0x0000000181069240-0x0000000181069420
		public void SetUpUserId() {} // 0x000000018106E900-0x000000018106EA30
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator GetServerAddress(string worldName) => default; // 0x0000000181069DA0-0x0000000181069E40
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitGameObjectDisable(string name, int timeout = 30 /* Metadata: 0x00B0D32F */) => default; // 0x00000001810722D0-0x0000000181072370
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator EnterStreaming(string worldName = "BigWorld01(Streaming)" /* Metadata: 0x00B0D333 */) => default; // 0x0000000181066B70-0x0000000181066C10
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CreateNameInStartPage() => default; // 0x0000000181066330-0x00000001810663C0
		public void OpenLog() {} // 0x000000018106C560-0x000000018106C760
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator EnterBigWorldBySDK(string worldName = "" /* Metadata: 0x00B0D34C */, bool isBoy = true /* Metadata: 0x00B0D350 */) => default; // 0x0000000181066930-0x00000001810669E0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator LoginBySDK(string serverName = "" /* Metadata: 0x00B0D351 */, string account = "" /* Metadata: 0x00B0D355 */, string passwd = "" /* Metadata: 0x00B0D359 */, bool isBoy = true /* Metadata: 0x00B0D35D */) => default; // 0x000000018106ACE0-0x000000018106ADA0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SwitchToDebugPanel(string worldName = "" /* Metadata: 0x00B0D35E */, bool skipWait = false /* Metadata: 0x00B0D362 */) => default; // 0x0000000181070420-0x00000001810704D0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator ChooseCharacter(int timeout = 60 /* Metadata: 0x00B0D363 */, bool isBoy = true /* Metadata: 0x00B0D367 */, bool skipError = false /* Metadata: 0x00B0D368 */) => default; // 0x00000001810646C0-0x0000000181064770
		private bool AlreadyInWorld(string worldName) => default; // 0x00000001810629B0-0x0000000181062B50
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator ConnectClick() => default; // 0x0000000181065940-0x00000001810659D0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitDownloadFullPackage(bool isBoy) => default; // 0x0000000181071480-0x0000000181071510
		public void SetAvatarCollect() {} // 0x000000018106DC10-0x000000018106DD20
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator EnterBigWorldFromGame(string worldName, bool clearAll = false /* Metadata: 0x00B0D369 */, bool skipAvatarSelect = false /* Metadata: 0x00B0D36A */, bool addAvatarAfterClear = true /* Metadata: 0x00B0D36B */, bool isBoy = true /* Metadata: 0x00B0D36C */, bool skipInitStep = false /* Metadata: 0x00B0D36D */, bool skipSDK = false /* Metadata: 0x00B0D36E */) => default; // 0x00000001810669E0-0x0000000181066AC0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CloseAllUtilMainPage(bool closeMap = true /* Metadata: 0x00B0D36F */, int timeout = 120 /* Metadata: 0x00B0D370 */) => default; // 0x00000001810651A0-0x0000000181065250
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitCutScene(int timeout = 120 /* Metadata: 0x00B0D374 */, int afterTime = 5 /* Metadata: 0x00B0D378 */, bool skipError = false /* Metadata: 0x00B0D37C */, LuaTable selectWords = null, string breakGameObjectName = "" /* Metadata: 0x00B0D37D */) => default; // 0x00000001810713B0-0x0000000181071480
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator TelePort(Vector3 position) => default; // 0x0000000181070B60-0x0000000181070C10
		public void TelePortOnly(Vector3 position) {} // 0x0000000181070760-0x0000000181070A70
		public void TelePortWithoutLoading(Vector3 position) {} // 0x0000000181070A70-0x0000000181070B60
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator TelePortLocal(Vector3 position) => default; // 0x00000001810706B0-0x0000000181070760
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator StartMove(Vector3 direction) => default; // 0x0000000181070010-0x00000001810700C0
		public void SetFov(float value) {} // 0x000000018106E180-0x000000018106E260
		public float GetFov() => default; // 0x0000000181068630-0x0000000181068710
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator StopMove(Vector3 direction) => default; // 0x0000000181070390-0x0000000181070420
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator MoveByAngle(float angle, bool stop = false /* Metadata: 0x00B0D381 */, Vector3 endPos = default, CameraData cameraData = default) => default; // 0x000000018106BA50-0x000000018106BB50
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WalkByAngle(float angle, bool stop = false /* Metadata: 0x00B0D382 */, Vector3 endPos = default, CameraData cameraData = default) => default; // 0x00000001810727B0-0x00000001810728B0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator MoveByAI(Vector3 position, float timeout = 60f /* Metadata: 0x00B0D383 */, float precise = 1f /* Metadata: 0x00B0D387 */) => default; // 0x000000018106B980-0x000000018106BA50
		public void StartMove(CameraData camera, string key) {} // 0x000000018106FEF0-0x0000000181070010
		public void StopMove() {} // 0x0000000181070270-0x0000000181070390
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator MoveToPositionUntilStateChange(Vector3 target, float timeout = 60f /* Metadata: 0x00B0D38B */, float precise = 1f /* Metadata: 0x00B0D38F */) => default; // 0x000000018106BF80-0x000000018106C050
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator GMGoto(Vector3 targetPos, bool isForceSetPosition) => default; // 0x0000000181067760-0x0000000181067820
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator TelAndLookAround(Vector3 target, float deltaDegree, float deltaInterval, float seconds) => default; // 0x00000001810705D0-0x00000001810706B0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator MoveToPositionAndLookAtNextPos(Vector3 targetPos, Vector3 lookAtPos, bool isForceSetPosition) => default; // 0x000000018106BD00-0x000000018106BDD0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitSeconds(float lastingSeconds) => default; // 0x0000000181072660-0x00000001810726F0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitAndResetCamera(float lastSeconds) => default; // 0x0000000181071130-0x00000001810711C0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator MoveToPosition(Vector3 target, float timeout = 60f /* Metadata: 0x00B0D393 */, float precise = 1f /* Metadata: 0x00B0D397 */, float runDistance = 2f /* Metadata: 0x00B0D39B */, bool skipIfTimeout = false /* Metadata: 0x00B0D39F */, bool clickScreen = false /* Metadata: 0x00B0D3A0 */, bool isSprint = false /* Metadata: 0x00B0D3A1 */) => default; // 0x000000018106C050-0x000000018106C150
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator MoveToPositionUntilCutScene(Vector3 target, float timeout = 60f /* Metadata: 0x00B0D3A2 */, float precise = 1f /* Metadata: 0x00B0D3A6 */, float runDistance = 4f /* Metadata: 0x00B0D3AA */, bool needShift = false /* Metadata: 0x00B0D3AE */) => default; // 0x000000018106BE90-0x000000018106BF80
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator MoveToPositionUntilCutSceneDisAppear(Vector3 target, float timeout = 120f /* Metadata: 0x00B0D3AF */) => default; // 0x000000018106BDD0-0x000000018106BE90
		public void SetPlayerToEnity(BaseEntity towards) {} // 0x000000018106E5C0-0x000000018106E720
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator MoveToEntity(BaseEntity towards, float timeout = 120f /* Metadata: 0x00B0D3B3 */, float range = 1f /* Metadata: 0x00B0D3B7 */) => default; // 0x000000018106BC30-0x000000018106BD00
		public void StartFollowEntity(BaseEntity towards, float duration) {} // 0x000000018106FE40-0x000000018106FEF0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator FollowEntity(BaseEntity towards, float duration) => default; // 0x00000001810675E0-0x0000000181067690
		public bool CheckEntityExistsByName(string name, float circle = 50f /* Metadata: 0x00B0D3BB */) => default; // 0x0000000181063C30-0x0000000181063FA0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitFoundEntitiesGW(ActionEntities result, float circle = 10f /* Metadata: 0x00B0D3BF */) => default; // 0x0000000181071B30-0x0000000181071BE0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitFoundNearByEntityById(uint Id, ActionEntity result, float timeout = 120f /* Metadata: 0x00B0D3C3 */, float circle = 50f /* Metadata: 0x00B0D3C7 */) => default; // 0x0000000181071EE0-0x0000000181071FB0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitFoundNearByEntitysById(uint Id, ActionEntities result, float timeout = 120f /* Metadata: 0x00B0D3CB */, float circle = 50f /* Metadata: 0x00B0D3CF */) => default; // 0x0000000181072090-0x0000000181072160
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitFoundNearByTransByName(string name, ActionTrans result, float timeout = 120f /* Metadata: 0x00B0D3D3 */, float circle = 50f /* Metadata: 0x00B0D3D7 */, bool ignoreFailure = false /* Metadata: 0x00B0D3DB */) => default; // 0x0000000181072160-0x0000000181072240
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator FoundNearByTransListByName(string name, ActionIEtTrans result, float circle = 50f /* Metadata: 0x00B0D3DC */, float interval_time = 3f /* Metadata: 0x00B0D3E0 */) => default; // 0x0000000181067690-0x0000000181067760
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitForGadgetDisappear(string entityName, float timeOut = 30f /* Metadata: 0x00B0D3E4 */) => default; // 0x0000000181071710-0x00000001810717B0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitForModifyDisappear(string modifyName, float timeOut = 30f /* Metadata: 0x00B0D3E8 */) => default; // 0x00000001810717B0-0x0000000181071850
		public int GetGadgetEntityCount(string entityName) => default; // 0x0000000181068710-0x00000001810689A0
		public int GetTransformChildCount(string path) => default; // 0x0000000181069E40-0x0000000181069F10
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitFoundNearByDropByName(string name) => default; // 0x0000000181071E50-0x0000000181071EE0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitFoundNearByEntityByName(string name, ActionEntity result, float timeout = 120f /* Metadata: 0x00B0D3EC */, float circle = 50f /* Metadata: 0x00B0D3F0 */, bool ignoreFailure = false /* Metadata: 0x00B0D3F4 */) => default; // 0x0000000181071FB0-0x0000000181072090
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitFoundAllNearbyEntities(ActionEntities result, float circle = 10f /* Metadata: 0x00B0D3F5 */, bool onlyGW = false /* Metadata: 0x00B0D3F9 */) => default; // 0x00000001810719D0-0x0000000181071A80
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitFoundAllEntityByName(string name, ActionEntities result, float timeout = 120f /* Metadata: 0x00B0D3FA */) => default; // 0x0000000181071910-0x00000001810719D0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitFoundAllEntityById(uint id, ActionEntities result, float timeout = 120f /* Metadata: 0x00B0D3FE */) => default; // 0x0000000181071850-0x0000000181071910
		public int GetEntityCount(string name) => default; // 0x00000001810680B0-0x00000001810681F0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SelectDialog(string content) => default; // 0x000000018106D450-0x000000018106D4F0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SelectDialog(int index, bool breakOnCutScene = false /* Metadata: 0x00B0D402 */) => default; // 0x000000018106D4F0-0x000000018106D5A0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator GetDialogCount(Action<int> retAction) => default; // 0x0000000181067E20-0x0000000181067EC0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator BuildTower(BaseEntity inteeEntity, int count) => default; // 0x0000000181062F10-0x0000000181062FC0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator EnterLeiTaiBattle(string entityName, uint levelId, uint diffId = 3 /* Metadata: 0x00B0D403 */) => default; // 0x0000000181066AC0-0x0000000181066B70
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator KillMonsterAroundTowerEnd(float circle = 7f /* Metadata: 0x00B0D407 */, float timeout = 3600f /* Metadata: 0x00B0D40B */) => default; // 0x000000018106AA10-0x000000018106AAD0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SelectTower() => default; // 0x000000018106D720-0x000000018106D7B0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator Pick(string content) => default; // 0x000000018106C800-0x000000018106C8A0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator Pick(int index) => default; // 0x000000018106C760-0x000000018106C800
		public void ChangeGameTime(float value) {} // 0x0000000181063480-0x00000001810636E0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CreateName(string name) => default; // 0x00000001810663C0-0x0000000181066460
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SkipCutScene() => default; // 0x000000018106F6F0-0x000000018106F780
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator ClickTalkDialog(int timeout = 60 /* Metadata: 0x00B0D40F */) => default; // 0x0000000181065100-0x00000001810651A0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator ClearBag() => default; // 0x0000000181064810-0x00000001810648A0
		public T GetPrivateProperty<T>(object instance, string propertyname) => default;
		public T GetPrivateField<T>(object instance, string fieldname) => default;
		public T CallPrivateMethod<T>(object instance, string name, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] param) => default;
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator ClickScreen(float x = 0.7f /* Metadata: 0x00B0D413 */, float y = 0.2f /* Metadata: 0x00B0D417 */) => default; // 0x0000000181064C20-0x0000000181064CC0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator ClickScreenAllTheTime() => default; // 0x0000000181064B90-0x0000000181064C20
		public void ClickScreen(Vector2 pos) {} // 0x0000000181064CC0-0x0000000181065100
		public void SelectDrop(string url, int index) {} // 0x000000018106D5A0-0x000000018106D720
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator ClickOnPointerObject(GameObject go) => default; // 0x0000000181064AF0-0x0000000181064B90
		public void ButtonClickObject(string url) {} // 0x0000000181062FC0-0x00000001810630F0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator DownAndUpOnPointerObject(GameObject go) => default; // 0x0000000181066690-0x0000000181066730
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SkillNormal(int index, bool up = true /* Metadata: 0x00B0D41B */) => default; // 0x000000018106F430-0x000000018106F4E0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator Skill(int index, bool up = true /* Metadata: 0x00B0D41C */) => default; // 0x000000018106F640-0x000000018106F6F0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SkillNotStop(int index, bool up = true /* Metadata: 0x00B0D41D */, int deltaFrames = 30 /* Metadata: 0x00B0D41E */) => default; // 0x000000018106F4E0-0x000000018106F5A0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SkillUp(int index) => default; // 0x000000018106F5A0-0x000000018106F640
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator Jump(bool up = true /* Metadata: 0x00B0D422 */, bool skipWait = false /* Metadata: 0x00B0D423 */) => default; // 0x000000018106A970-0x000000018106AA10
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator Fly(bool up = true /* Metadata: 0x00B0D424 */, bool skipWait = false /* Metadata: 0x00B0D425 */) => default; // 0x0000000181067540-0x00000001810675E0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator ChooseGeneralDialog(bool OK = true /* Metadata: 0x00B0D426 */, bool closeMap = true /* Metadata: 0x00B0D427 */, bool skipIfNotFound = false /* Metadata: 0x00B0D428 */) => default; // 0x0000000181064770-0x0000000181064810
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator ClickOnMap(GameObject mark, bool OK = true /* Metadata: 0x00B0D429 */, float timeout = 120f /* Metadata: 0x00B0D42A */) => default; // 0x0000000181064A40-0x0000000181064AF0
		public void AvatarAI(bool isOpen) {} // 0x0000000181062D20-0x0000000181062DE0
		public void MonsterAI(bool isOpen) {} // 0x000000018106ADA0-0x000000018106AE30
		public void CreateMonster(uint cID, uint level = 1 /* Metadata: 0x00B0D42E */, bool isElite = false /* Metadata: 0x00B0D432 */, List<uint> affixList = null) {} // 0x0000000181066040-0x0000000181066330
		public void CreateMonsterByAngle(uint cID, float angle, uint level = 1 /* Metadata: 0x00B0D433 */, bool isElite = false /* Metadata: 0x00B0D437 */, List<uint> affixList = null) {} // 0x0000000181065D50-0x0000000181066040
		public void CreateMonsterByAngle2(uint cID, float angle, uint level = 1 /* Metadata: 0x00B0D438 */, uint distance = 1 /* Metadata: 0x00B0D43C */) {} // 0x0000000181065A60-0x0000000181065D50
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator Create7Slimu() => default; // 0x00000001810659D0-0x0000000181065A60
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator TickMonsterDoSkill(MonsterEntity monster, float deltaTime, Vector3 pos) => default; // 0x0000000181070C10-0x0000000181070CE0
		public List<ConfigKeyInput> GetConfigKeyInputs(BaseEntity monster) => default; // 0x0000000181067B90-0x0000000181067CF0
		public uint GetMonsterSkillId(BaseEntity monster) => default; // 0x0000000181069170-0x0000000181069240
		public int GetMonsterPosId(BaseEntity monster) => default; // 0x00000001810690E0-0x0000000181069170
		public bool CheckMonsterInUnnormalState(BaseEntity monster, out AbilityState state) {
			state = default;
			return default;
		} // 0x0000000181064060-0x00000001810641A0
		public float GetDistance(BaseEntity monster, BaseEntity avatar) => default; // 0x0000000181067EC0-0x00000001810680B0
		public bool IsMonsterHpFull(BaseEntity monster) => default; // 0x000000018106A860-0x000000018106A970
		public void MonsterDoSkill(BaseEntity monster, int skillID) {} // 0x000000018106AEE0-0x000000018106B180
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator MonsterDoSkillByID(BaseEntity monster, ConfigKeyInput skill, bool needResetMonsterPos) => default; // 0x000000018106AE30-0x000000018106AEE0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator MonsterMove(BaseEntity monster, Vector3 target = default) => default; // 0x000000018106B2D0-0x000000018106B390
		public void MonsterSetTarget(BaseEntity monster, BaseEntity target) {} // 0x000000018106B390-0x000000018106B480
		public void MonsterGod(bool MonsterDebugInv = true /* Metadata: 0x00B0D440 */) {} // 0x000000018106B180-0x000000018106B2D0
		public virtual void InitENetClient() {} // 0x000000018106A320-0x000000018106A470
		public virtual void DestoryENetClient() {} // 0x00000001810664F0-0x00000001810665F0
		public virtual bool OnPacketCallback(Packet udpPacket) => default; // 0x000000018106C2C0-0x000000018106C560
		public virtual void SendMessage(MessageBase req) {} // 0x000000018106D930-0x000000018106DC10
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitMessage(string expectedProtoName, Action<MessageBase> RecvCallback, float timeout = 10f /* Metadata: 0x00B0D441 */) => default; // 0x0000000181072440-0x0000000181072500
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public virtual IEnumerator SendMessageAndWaitRecv(MessageBase req, string expectedProtoName, Action<MessageBase> RecvCallback, float timeout = 10f /* Metadata: 0x00B0D445 */) => default; // 0x000000018106D7B0-0x000000018106D870
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public virtual IEnumerator SendMessageAndWaitRecvs(MessageBase req, string expectedProtoName, Action<List<MessageBase>> recvs, float timeout = 10f /* Metadata: 0x00B0D449 */) => default; // 0x000000018106D870-0x000000018106D930
		public Vector3 GetAvatarLocation() => default; // 0x0000000181067820-0x0000000181067950
		public void StartCharacterAI(string behaviourName, float findMonsterRange = 50f /* Metadata: 0x00B0D44D */, float attackRange = 3f /* Metadata: 0x00B0D451 */, bool needRecovery = false /* Metadata: 0x00B0D455 */, int maxNoFoundCount = 8 /* Metadata: 0x00B0D456 */, int skillMask = 0 /* Metadata: 0x00B0D45A */, int loopTime = 2 /* Metadata: 0x00B0D45E */) {} // 0x000000018106FB40-0x000000018106FDA0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitForAIStop(float timeout = -1f /* Metadata: 0x00B0D462 */, bool closePage = true /* Metadata: 0x00B0D466 */) => default; // 0x00000001810715C0-0x0000000181071670
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitForAIStopMonsterReturn(BaseEntity monsterEntity, float timeout = -1f /* Metadata: 0x00B0D467 */) => default; // 0x0000000181071510-0x00000001810715C0
		public static void StopAI() {} // 0x00000001810700C0-0x00000001810701F0
		public void FaceToForward(Vector3 target) {} // 0x0000000181066D10-0x0000000181067000
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator UpdateQuestGuide() => default; // 0x0000000181070CE0-0x0000000181070D70
		private void SetMainCameraSpherical(Vector3 spherical) {} // 0x000000018106E350-0x000000018106E5C0
		public Vector3 GetMainCameraSpherical() => default; // 0x0000000181068EB0-0x00000001810690E0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator RotateFocusCamera(Vector3 delta) => default; // 0x000000018106D240-0x000000018106D2F0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator RotateByCameraData(CameraData data) => default; // 0x000000018106CEA0-0x000000018106CF70
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SetCameraRotateByGesture(Vector3 targetspherical) => default; // 0x000000018106DFB0-0x000000018106E060
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator RotateCameraBySpherical(Vector3 spherical, bool rotateZ = true /* Metadata: 0x00B0D46B */) => default; // 0x000000018106D0D0-0x000000018106D190
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator RotateCameraByDir(int dir) => default; // 0x000000018106CF70-0x000000018106D010
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator RotateCameraBySphericalContinue(Vector3 spherical, bool rotateZ = true /* Metadata: 0x00B0D46C */) => default; // 0x000000018106D010-0x000000018106D0D0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator RotateCamera(Vector3 towards) => default; // 0x000000018106D190-0x000000018106D240
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator AutoAim(GameObject gameobject, float timeout = 3f /* Metadata: 0x00B0D46D */, float followSpeed = 0.1f /* Metadata: 0x00B0D471 */, Vector2 offset = default) => default; // 0x0000000181062B50-0x0000000181062C30
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator AutoShoot(GameObject gameobject, float timeout = -1f /* Metadata: 0x00B0D475 */, int deltaFrames = 10 /* Metadata: 0x00B0D479 */, float followSpeed = 0.1f /* Metadata: 0x00B0D47D */, Vector2 offset = default) => default; // 0x0000000181062C30-0x0000000181062D20
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SetCameraForward(Vector3 toward) => default; // 0x000000018106DD20-0x000000018106DDD0
		public static void ResetCameraQASet() {} // 0x000000018106CDD0-0x000000018106CEA0
		public void LockCameraQAPosForward() {} // 0x000000018106AAD0-0x000000018106ACE0
		public static void SetCameraQAPosForward(Vector3 Position, Vector3 Forward) {} // 0x000000018106DE80-0x000000018106DFB0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator SetCameraPosition(Vector3 Position) => default; // 0x000000018106DDD0-0x000000018106DE80
		public Vector3 GetCameraForward() => default; // 0x0000000181067950-0x0000000181067A70
		public Vector3 GetCameraPosition() => default; // 0x0000000181067A70-0x0000000181067B90
		public void AddErrorIgnore(string ignoerString) {} // 0x00000001810625C0-0x0000000181062660
		public void Exit() {} // 0x0000000181066CB0-0x0000000181066D10
		public void BackMyWorld() {} // 0x0000000181062DE0-0x0000000181062E80
		public void SetCanEnter() {} // 0x000000018106E060-0x000000018106E180
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator RequestSceneGetAreaExplorePointReq() => default; // 0x000000018106CD40-0x000000018106CDD0
		public Dictionary<uint, uint> GetExplorePointDict() => default; // 0x0000000181068390-0x0000000181068630
		public uint GetExplorePointById(uint id) => default; // 0x0000000181068280-0x0000000181068390
		public void PlayCutsceneIndex(uint cutsceneIndex, Action<ILuaActor> finishCallback, Action<ILuaActor> startCallback, Action<ILuaActor> destroyCallback, bool syncLoad, uint mainQuestId) {} // 0x000000018106C8A0-0x000000018106C9A0
		public uint GetGameTime(float hour, float minute) => default; // 0x00000001810689A0-0x0000000181068AD0
		public string GetUserPara(string key) => default; // 0x0000000181069F10-0x0000000181069FA0
		public EntityManager GetEntityManager() => default; // 0x00000001810681F0-0x0000000181068280
		public AvatarEntity GetLocalEntity() => default; // 0x0000000181068E10-0x0000000181068EB0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitAvatarActive() => default; // 0x00000001810711C0-0x0000000181071230
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator TakeSnapShot(Action<string> savedFileName, string fileNamePrefix = "SnapShot" /* Metadata: 0x00B0D481 */) => default; // 0x00000001810704D0-0x0000000181070580
		public void UploadVideo() {} // 0x0000000181070D70-0x0000000181071130
		public void SetInputString(string input) {} // 0x000000018106E260-0x000000018106E350
		public void CloseDebugConsole() {} // 0x0000000181065250-0x00000001810652E0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator RandomTransport() => default; // 0x000000018106CB70-0x000000018106CC00
		private List<Vector2> GetSectorPosByIndex(string name, bool isCity = false /* Metadata: 0x00B0D48D */) => default; // 0x00000001810699D0-0x0000000181069DA0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator QuestAccept(uint subId, bool needFinish = false /* Metadata: 0x00B0D48E */) => default; // 0x000000018106CA30-0x000000018106CAE0
	}
}
