/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoTimeIndicator : MonoBehaviour // TypeDefIndex: 31332
	{
		// Fields
		private const int USAGEINDEX_TIME = 0; // Metadata: 0x00B1219A
		private const int USAGEINDEX_SERVER_TIME = 1; // Metadata: 0x00B1219E
		private const int USAGEINDEX_RTT = 2; // Metadata: 0x00B121A2
		private const int USAGEINDEX_EntityCount = 3; // Metadata: 0x00B121A6
		private const int USAGEINDEX_POS = 4; // Metadata: 0x00B121AA
		private const int USAGEINDEX_BUDGET = 5; // Metadata: 0x00B121AE
		private const int USAGEINDEX_PACKET_LOSS = 6; // Metadata: 0x00B121B2
		private const int USAGEINDEX_APP_RTT = 7; // Metadata: 0x00B121B6
		private const int USAGEINDEX_VERSION = 8; // Metadata: 0x00B121BA
		private const int USAGEINDEX_STREAM = 9; // Metadata: 0x00B121BE
		private const int USAGEINDEX_UNITY_TIME = 10; // Metadata: 0x00B121C2
		private const int USAGEINDEX_LEVEL_TIME_SCALE = 11; // Metadata: 0x00B121C6
		private const int USAGEINDEX_SectorCount_ConstInfo = 12; // Metadata: 0x00B121CA
		private const int USAGEINDEX_RUNITY = 12; // Metadata: 0x00B121CE
		private const int USAGEINDEX_RMONO = 13; // Metadata: 0x00B121D2
		private const int USAGEINDEX_RGFX = 14; // Metadata: 0x00B121D6
		private const int USAGEINDEX_RPROFILER = 15; // Metadata: 0x00B121DA
		private const int USAGEINDEX_RTEX = 16; // Metadata: 0x00B121DE
		private const int USAGEINDEX_RMESH = 17; // Metadata: 0x00B121E2
		private const int USAGEINDEX_RCLIP = 18; // Metadata: 0x00B121E6
		private const int USAGEINDEX_DC = 19; // Metadata: 0x00B121EA
		private const int USAGEINDEX_DP = 20; // Metadata: 0x00B121EE
		private const int USAGEINDEX_DEVICEMEMORY = 21; // Metadata: 0x00B121F2
		private const int USAGEINDEX_DYNAMICOBJECT = 22; // Metadata: 0x00B121F6
		private const int USAGEINDEX_RTOTAL = 23; // Metadata: 0x00B121FA
		private const int USAGEINDEX_IL2CPPMem = 24; // Metadata: 0x00B121FE
		private const int USAGEINDEX_RTLOADSTOREBW = 25; // Metadata: 0x00B12202
		private const int USAGEINDEX_LOAD = 26; // Metadata: 0x00B12206
		private const int USAGEINDEX_ENTITYDEBUG = 27; // Metadata: 0x00B1220A
		private const int USAGEINDEX_ENTITYABILITY = 28; // Metadata: 0x00B1220E
		private const int USAGEINDEX_StatTimeMainThread = 29; // Metadata: 0x00B12212
		private const int USAGEINDEX_StatTimeGPU = 30; // Metadata: 0x00B12216
		private const int USAGEINDEX_SectionCount_MemoryCPU = 31; // Metadata: 0x00B1221A
		private const int USAGEINDEX_GPUTotal = 31; // Metadata: 0x00B1221E
		private const int USAGEINDEX_FrameBegin = 32; // Metadata: 0x00B12222
		private const int USAGEINDEX_GPUSkinning = 33; // Metadata: 0x00B12226
		private const int USAGEINDEX_GeometryPass = 34; // Metadata: 0x00B1222A
		private const int USAGEINDEX_HybridDeferredPass = 35; // Metadata: 0x00B1222E
		private const int USAGEINDEX_MainLightShadowMapPass = 36; // Metadata: 0x00B12232
		private const int USAGEINDEX_LocalLightShadowMapPass = 37; // Metadata: 0x00B12236
		private const int USAGEINDEX_ShadowMaskPass = 38; // Metadata: 0x00B1223A
		private const int USAGEINDEX_WaterSSRPass = 39; // Metadata: 0x00B1223E
		private const int USAGEINDEX_HalfParticlePass = 40; // Metadata: 0x00B12242
		private const int USAGEINDEX_FinalPass = 41; // Metadata: 0x00B12246
		private const int USAGEINDEX_DecalFinalPass = 42; // Metadata: 0x00B1224A
		private const int USAGEINDEX_OpaquePass = 43; // Metadata: 0x00B1224E
		private const int USAGEINDEX_HeightFogPass = 44; // Metadata: 0x00B12252
		private const int USAGEINDEX_TransparentPass = 45; // Metadata: 0x00B12256
		private const int USAGEINDEX_BeforImageEffectsPass = 46; // Metadata: 0x00B1225A
		private const int USAGEINDEX_AfterPostProcessPass = 47; // Metadata: 0x00B1225E
		private const int USAGEINDEX_FrameEnd = 48; // Metadata: 0x00B12262
		private const int USAGEINDEX_SectionCount_GPU = 49; // Metadata: 0x00B12266
		private const int USAGEINDEX_Last = 49; // Metadata: 0x00B1226A
		private const int USAGEINDEX_TOTAL_COUNT = 50; // Metadata: 0x00B1226E
		private UnityEngine.UI.Text[] _textPool; // 0x18
		private SimpleText[] _simpletextPool; // 0x20
		private LinkedListNode<MutableString>[] _msForTexts; // 0x28
		private Func<string>[] _onTextContent; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _toggleDetailBtn; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _streamText; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _versionText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _posText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeText; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _serverTimeText; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unityTimeText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _packetLossText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _appRTTText; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rttText; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _entityText; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _budgetText; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _reservedTotalMemoryText; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _reservedUnityMemoryText; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _reservedMonoMemoryText; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _reservedGfxMemoryText; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _reservedProfilerMemoryText; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textureMemoryText; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _meshMemoryText; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _clipMemoryText; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _drawCallText; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _drawPrimText; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _deviceMemory; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _dynamicObject; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _loadText; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _entityDebugText; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _il2cppMemTex; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rtLoadStoreText; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _entityAbilityText; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _statTimeMainThreadText; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _statTimeGPUText; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelTimeScale; // 0x130
		private static float statTextBaseY; // 0x00
		private static float statTextHight; // 0x04
		public static Color defaultStatFontColor; // 0x08
		private MMAField _statMMAPrefabLoadJobCount; // 0x138
		private MMAField _statMMAAssetLoadJobCount; // 0x160
		private MMAField _statMMABundleLoadJobCount; // 0x188
		private MMAField _statMMAEntityReadyCount; // 0x1B0
		private MMAField _statMMAEntityAppearDisappearCount; // 0x1D8
		private MMAField _statMMAAppliedModifierCount; // 0x200
		private MMAField _statMMATimerCount; // 0x228
		private MMAField _statMMAFrameTime; // 0x250
		private MMAField _statMMAGameTime; // 0x278
		private MMAField _statMMARenderTime; // 0x2A0
		private MMAField _statMMAWaitForPresentTime; // 0x2C8
		private MMAField _statMMAPresentTime; // 0x2F0
		private MMAField _statMMATotalGPUTime; // 0x318
		private MMAField[] _statMMAGPUPassTimes; // 0x340
		private int _maxPrefabLoadJobCount; // 0x348
		private int _maxAssetLoadJobCount; // 0x34C
		private int _maxBundleLoadJobCount; // 0x350
		private static int RefreshCount; // 0x18
		private string _versionStr; // 0x358
		private string _streamStr; // 0x360
		private StatFrameData _cachedFrameData; // 0x368
		private int _targetUpdateCount; // 0x460
		private int runtimeStatView; // 0x464
		private bool bObservingAppMemory; // 0x468
		private TimerReceiver _updateTimer; // 0x470
	
		// Constructors
		public MonoTimeIndicator() {} // 0x0000000183B7C200-0x0000000183B7C850
		static MonoTimeIndicator() {} // 0x0000000183B7C130-0x0000000183B7C200
	
		// Methods
		// [IDTag] // 0x0000000189B057F0-0x0000000189B05830
		// [XID] // 0x0000000189B057F0-0x0000000189B05830
		private void BindStatText(int idx, UnityEngine.UI.Text inText, Func<string> inStatFunc) {} // 0x0000000183B77890-0x0000000183B77A80
		// [IDTag] // 0x0000000189B0FFC0-0x0000000189B10000
		// [XID] // 0x0000000189B0FFC0-0x0000000189B10000
		private void BindStatText(int idx, SimpleText inText, Func<string> inStatFunc) {} // 0x0000000183B76BB0-0x0000000183B76DA0
		// [IDTag] // 0x0000000189B1A410-0x0000000189B1A450
		// [XID] // 0x0000000189B1A410-0x0000000189B1A450
		private void BindStatText(int idx, ref UnityEngine.UI.Text inText, Func<string> inStatFunc, ref int displayIdx, string labelGOName = null, Color? fontColor = default) {} // 0x0000000183B76DA0-0x0000000183B77390
		// [XID] // 0x0000000189B24AF0-0x0000000189B24B10
		private void BindStatTextWithRightAlignment(int idx, Func<string> inStatFunc, ref int displayIdx, string labelGOName = null, Color? fontColor = default) {} // 0x0000000183B747B0-0x0000000183B74A80
		// [IDTag] // 0x0000000189B2BFA0-0x0000000189B2BFE0
		// [XID] // 0x0000000189B2BFA0-0x0000000189B2BFE0
		private void BindStatText(int idx, ref SimpleText inText, Func<string> inStatFunc, ref int displayIdx, string labelGOName = null, Color? fontColor = default) {} // 0x0000000183B77390-0x0000000183B77890
		// [XID] // 0x0000000189B36490-0x0000000189B364B0
		private void CreateGPUPassStatMMAs() {} // 0x0000000183B79FE0-0x0000000183B7A140
		// [XID] // 0x0000000189B3DC70-0x0000000189B3DC90
		private void AccumulateGPUPassStatMMAs() {} // 0x0000000183B742A0-0x0000000183B74400
		// [XID] // 0x0000000189B459F0-0x0000000189B45A10
		private void BindRightAlignmentText() {} // 0x0000000183B7A810-0x0000000183B7B010
		// [XID] // 0x0000000189B4CE70-0x0000000189B4CE90
		private void HookTextButtons() {} // 0x0000000183B78770-0x0000000183B79730
		// [XID] // 0x0000000189B54590-0x0000000189B545B0
		private void OnDestroy() {} // 0x0000000183B7B620-0x0000000183B7B760
		// [XID] // 0x0000000189B5C160-0x0000000189B5C180
		public void Awake() {} // 0x0000000183B72BD0-0x0000000183B73020
		// [XID] // 0x0000000189B63760-0x0000000189B63780
		private void Update() {} // 0x0000000183B7BCC0-0x0000000183B7C130
		// [XID] // 0x0000000189B6AF40-0x0000000189B6AF60
		private string UpdateLoadText() => default; // 0x0000000183B761E0-0x0000000183B766A0
		// [XID] // 0x0000000189B72580-0x0000000189B725A0
		private string UpdateIl2CPPMemText() => default; // 0x0000000183B78010-0x0000000183B781E0
		// [XID] // 0x0000000189B79AB0-0x0000000189B79AD0
		private string UpdateEntityDebugText() => default; // 0x0000000183B73E90-0x0000000183B742A0
		// [XID] // 0x0000000189B81220-0x0000000189B81240
		private string UpdateAbilityDebugText() => default; // 0x0000000183B728E0-0x0000000183B72BD0
		// [XID] // 0x0000000189B889D0-0x0000000189B889F0
		public static void FillStatAveMaxIntStringAndClear(MutableString ms, string name, ref MMAField mf, bool bNeedClearAll, float valueDisplaceScale = 1f /* Metadata: 0x00B12196 */) {} // 0x0000000183B74C50-0x0000000183B74DF0
		// [XID] // 0x0000000189B8FE80-0x0000000189B8FEA0
		private string UpdateModuleStatTimeMainThreadDebugText() => default; // 0x0000000183B73C40-0x0000000183B73E90
		// [XID] // 0x0000000189B972C0-0x0000000189B972E0
		private string UpdateModuleStatTimePresentText() => default; // 0x0000000183B77A80-0x0000000183B77CA0
		// [XID] // 0x0000000189B9E740-0x0000000189B9E760
		private string UpdateModuleStatTimeGPUTotal(MutableString.ELengthLevel lengthLevel, int usageIndex) => default; // 0x0000000183B797C0-0x0000000183B79980
		// [XID] // 0x0000000189BA60F0-0x0000000189BA6110
		private string UpdateModuleStatTimeGPUPass(string title, int passIndex, MutableString.ELengthLevel lengthLevel, int usageIndex) => default; // 0x0000000183B79D40-0x0000000183B79FE0
		// [XID] // 0x0000000189BAD380-0x0000000189BAD3A0
		private void HookEntityCountBtn() {} // 0x0000000183B7A1D0-0x0000000183B7A500
		// [XID] // 0x0000000189BB4B70-0x0000000189BB4B90
		private string UpdateEntityCountText() => default; // 0x0000000183B78300-0x0000000183B78570
		// [XID] // 0x0000000189BBC0E0-0x0000000189BBC100
		private string UpdateBudgetText() => default; // 0x0000000183B766A0-0x0000000183B76BB0
		// [XID] // 0x0000000189BC3E40-0x0000000189BC3E60
		private string GetLevelTimeStr() => default; // 0x0000000183B74520-0x0000000183B74750
		// [XID] // 0x0000000189BCB740-0x0000000189BCB760
		private string GetServerTimeStr() => default; // 0x0000000183B74FC0-0x0000000183B752B0
		// [XID] // 0x0000000189BD2D40-0x0000000189BD2D60
		private string GetLevelTimeScaleStr() => default; // 0x0000000183B79A10-0x0000000183B79CB0
		// [XID] // 0x0000000189BDA420-0x0000000189BDA440
		private string GetUnityTimeStr() => default; // 0x0000000183B73420-0x0000000183B73610
		// [XID] // 0x00000001895E6EB0-0x00000001895E6ED0
		public string GetAppRTTStr() => default; // 0x0000000183B752B0-0x0000000183B75580
		// [XID] // 0x00000001895EE840-0x00000001895EE860
		public string GetPacketLossStr() => default; // 0x0000000183B758F0-0x0000000183B75B30
		// [XID] // 0x00000001895F61E0-0x00000001895F6200
		public string GetRTTTimeStr() => default; // 0x0000000183B75EB0-0x0000000183B761E0
		// [XID] // 0x00000001895FD4E0-0x00000001895FD500
		public string GetPositionStr() => default; // 0x0000000183B75B30-0x0000000183B75EB0
		// [XID] // 0x0000000189604E60-0x0000000189604E80
		private void InitVersionStr() {} // 0x0000000183B72810-0x0000000183B728E0
		// [XID] // 0x000000018960C870-0x000000018960C890
		private string GetVersionStr() => default; // 0x0000000183B7A6D0-0x0000000183B7A780
		// [XID] // 0x0000000189613DD0-0x0000000189613DF0
		private void InitStreamStr() {} // 0x0000000183B73380-0x0000000183B73420
		// [XID] // 0x000000018961B7A0-0x000000018961B7C0
		private string GetStreamStr() => default; // 0x0000000183B74F10-0x0000000183B74FC0
		// [XID] // 0x0000000189622D20-0x0000000189622D40
		private string GetReservedTotalMemory() => default; // 0x0000000183B73020-0x0000000183B731F0
		// [XID] // 0x000000018962A510-0x000000018962A530
		private string GetReservedUnityMemory() => default; // 0x0000000183B7A500-0x0000000183B7A6D0
		// [XID] // 0x0000000189631CB0-0x0000000189631CD0
		private string GetReservedMonoMemory() => default; // 0x0000000183B73A40-0x0000000183B73C40
		// [XID] // 0x00000001896397E0-0x0000000189639800
		private string GetReservedGfxMemory() => default; // 0x0000000183B7B010-0x0000000183B7B1E0
		// [XID] // 0x0000000189640CA0-0x0000000189640CC0
		private string GetReservedProfilerMemory() => default; // 0x0000000183B7B450-0x0000000183B7B620
		// [XID] // 0x00000001896485F0-0x0000000189648610
		private string GetTextureMemory() => default; // 0x0000000183B74A80-0x0000000183B74C50
		// [XID] // 0x000000018964FD00-0x000000018964FD20
		private string GetMeshMemory() => default; // 0x0000000183B73870-0x0000000183B73A40
		// [XID] // 0x0000000189657540-0x0000000189657560
		private string GetClipMemory() => default; // 0x0000000183B736A0-0x0000000183B73870
		// [XID] // 0x000000018965EC00-0x000000018965EC20
		private string GetDrawCallCount() => default; // 0x0000000183B731F0-0x0000000183B73380
		// [XID] // 0x0000000189666280-0x00000001896662A0
		private string GetDrawPrimitiveCount() => default; // 0x0000000183B78570-0x0000000183B78700
		// [XID] // 0x000000018966DA40-0x000000018966DA60
		public string GetDeviceMemory() => default; // 0x0000000183B75580-0x0000000183B75760
		// [XID] // 0x0000000189675860-0x0000000189675880
		public string GetDynamicObject() => default; // 0x0000000183B75760-0x0000000183B758F0
		// [XID] // 0x000000018967D170-0x000000018967D190
		private string GetRTLoadStoreBandWidth() => default; // 0x0000000183B7B950-0x0000000183B7BAF0
		// [XID] // 0x0000000189684820-0x0000000189684840
		private void EnableDeviceMemoryObserver(bool bEnable) {} // 0x0000000183B7B270-0x0000000183B7B3C0
		// [XID] // 0x000000018968C390-0x000000018968C3B0
		private void OnEnable() {} // 0x0000000183B7B820-0x0000000183B7B950
		// [XID] // 0x0000000189693E60-0x0000000189693E80
		private void OnDisable() {} // 0x0000000183B7B760-0x0000000183B7B820
		// [XID] // 0x000000018969B430-0x000000018969B450
		public void ToggleViewMode() {} // 0x0000000183B7BAF0-0x0000000183B7BCC0
		// [XID] // 0x00000001896A2B50-0x00000001896A2B70
		private void RefreshTexts(int from, int count) {} // 0x0000000183B72520-0x0000000183B72810
		// [XID] // 0x00000001896A9FD0-0x00000001896A9FF0
		private bool InternalUpdate() => default; // 0x0000000183B77DC0-0x0000000183B77F80
	}
}
