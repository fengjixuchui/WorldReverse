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
using MoleMole.Config;
using SimpleJSON;
using UnityEngine;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class NpcManager : GlobalManager, INotifyInterface // TypeDefIndex: 21218
{
	// Fields
	private int _lastCheckAppearPlayerBlockX; // 0x10
	private int _lastCheckAppearPlayerBlockZ; // 0x14
	private int _appearHandleCount; // 0x18
	private Dictionary<uint, NpcBornInfo> _dailyNpcBornInfoDic; // 0x20
	private Dictionary<uint, Dictionary<Vector2, BlockBornPosData>> _dailyNpcBlockPosDataSceneIdDic; // 0x28
	private Dictionary<uint, Dictionary<uint, RecycledLinkedList<BornPosData>>> _dailyNpcRoomPosDataSceneIdDic; // 0x30
	private RecycledLinkedList<NpcBornInfo> _dirtyNpcList; // 0x38
	private List<BlockBornPosData> _dirtyBlockList; // 0x40
	private RecycledLinkedList<BornPosData> _curDailyNpcPosDataItr; // 0x48
	private Dictionary<QuestNpcKey, NpcBornInfo> _questNpcBornInfoDic; // 0x50
	private Dictionary<uint, Dictionary<Vector2, RecycledLinkedList<BornPosData>>> _questNpcBlockPosDataSceneIdDic; // 0x58
	private Dictionary<uint, Dictionary<uint, RecycledLinkedList<BornPosData>>> _questNpcRoomPosDataSceneIdDic; // 0x60
	private RecycledLinkedList<BornPosData> _curQuestNpcPosDataItr; // 0x68
	private Dictionary<uint, uint> _dailyNpcDisableDic; // 0x70
	private List<uint> _newRoomList; // 0x78
	private List<uint> _activeRoomList; // 0x80
	private RecycledLinkedList<NpcBornInfo> _appearedNpcList; // 0x88
	private RecycledLinkedList<NpcBornInfo> _disappearedNpcList; // 0x90
	private RecycledLinkedList<NpcBornInfo> _curAppearedNpcItr; // 0x98
	private RecycledLinkedList<NpcBornInfo> _curAppearedNpcSyncPosItr; // 0xA0
	private RecycledLinkedList<NpcBornInfo> _curDisappearedNpcItr; // 0xA8
	private RecycledLinkedList<NpcBornInfo> _curDirtyNpcItr; // 0xB0
	private Coroutine _npcCheckAppearCoroutine; // 0xB8
	private Coroutine _npcCheckDisappearCoroutine; // 0xC0
	private NpcManagerTask _npcThreadTask; // 0xC8
	private bool _isWorking; // 0xD0
	private bool _isInited; // 0xD1
	private Dictionary<uint, List<BornPosData>> _groupSuitePosDataDic; // 0xD8
	private Dictionary<uint, uint> _cachedGroupSuiteInfoDic; // 0xE0
	private Vector3 _cachedLocalPos; // 0xE8
	private uint _curSceneId; // 0xF4
	private bool _curSceneIsRoomType; // 0xF8
	private uint _curDynBornUniqId; // 0xFC
	private Dictionary<uint, uint> _curDynBornPosQuestIdDic; // 0x100
	private const int BLOCK_SIZE = 20; // Metadata: 0x00AFF135
	private const float BLOCK_SIZE_MULTI = 0.05f; // Metadata: 0x00AFF139
	private const int FILE_BLOCK_SIZE = 1024; // Metadata: 0x00AFF13D
	private const float FILE_BLOCK_SIZE_MULTI = 0.0009765625f; // Metadata: 0x00AFF141
	private const int LOAD_BLOCK_SIZE = 40; // Metadata: 0x00AFF145
	private const float LOAD_BLOCK_SIZE_MULTI = 0.025f; // Metadata: 0x00AFF149
	private const float LOAD_TO_FILE_BLOCK_MULTI = 0.0390625f; // Metadata: 0x00AFF14D
	private const float DEFAULT_APPEAR_DIST = 80f; // Metadata: 0x00AFF151
	private const float DEFAULT_DISAPPEAR_DIST = 80f; // Metadata: 0x00AFF155
	private static int _perTickHandleAppearCount; // 0x00
	private static int _perTickHandleDisappearCount; // 0x04
	private static int _perTickHandlePosSyncCount; // 0x08
	private static float _appearDist; // 0x0C
	private static float _disappearDist; // 0x10
	private static float _loadDist; // 0x14
	private static Vector3 _loadDistAppend; // 0x18
	private static int _appearBlockCount; // 0x24
	private static int _disappearBlockCount; // 0x28
	private static string[] SCENE_BORN_POS_CONFIG_FOLDER_PATH; // 0x30
	private Dictionary<uint, Dictionary<Vector2, SceneBlockLoadState>> _levelNpcBornPosDic; // 0x108
	private Dictionary<ulong, SceneBlockLoadState> _filePath2StateDic; // 0x110
	private static bool _useThreadWork; // 0x38
	private static bool _useGroupData; // 0x39
	private static bool _loadDataByStream; // 0x3A
	private int _lastCheckFileBlockMinX; // 0x118
	private int _lastCheckFileBlockMinZ; // 0x11C
	private int _lastCheckFileBlockMaxX; // 0x120
	private int _lastCheckFileBlockMaxZ; // 0x124
	private bool _isThreadRunning; // 0x128
	private Queue<ICacheCommand> _mainThreadCommandQueue; // 0x130
	private Queue<ICacheCommand> _workThreadCommandQueue; // 0x138
	private List<ICacheCommandPool> _usedMainThreadCommandPools; // 0x140
	private List<ICacheCommandPool> _usedWorkThreadCommandPools; // 0x148
	private IEnumerator _threadCheckAppear; // 0x150
	private IEnumerator _threadCheckDisappear; // 0x158

	// Properties
	private bool _needCacheCommand { /* [XID] */ /* 0x000000018984DEA0-0x000000018984DEC0 */ get => default; } // 0x0000000184C09640-0x0000000184C09720 
	public float curAppearDist { /* [XID] */ /* 0x0000000189854F50-0x0000000189854F70 */ get => default; } // 0x0000000184C06010-0x0000000184C060F0 
	public float curDisappearDist { /* [XID] */ /* 0x000000018985C6F0-0x000000018985C710 */ get => default; } // 0x0000000184C0DEB0-0x0000000184C0DF90 
	public int curAppearBlock { /* [XID] */ /* 0x0000000189864070-0x0000000189864090 */ get => default; } // 0x0000000184C0F520-0x0000000184C0F5F0 
	public int curDisappearBlock { /* [XID] */ /* 0x000000018986B440-0x000000018986B460 */ get => default; } // 0x0000000184C09F60-0x0000000184C0A030 
	private static string SCENE_BORN_POS_CONFIG_FOLDER_PATH_0 { /* [XID] */ /* 0x0000000189A89050-0x0000000189A89070 */ get => default; } // 0x0000000184C056F0-0x0000000184C05790 
	private static string SCENE_BORN_POS_CONFIG_FOLDER_PATH_1 { /* [XID] */ /* 0x0000000189A90830-0x0000000189A90850 */ get => default; } // 0x0000000184C11130-0x0000000184C111D0 
	private static string ROOM_SCENE_BORN_POS_STREAMING_CONFIG_PATH { /* [XID] */ /* 0x0000000189A98070-0x0000000189A98090 */ get => default; } // 0x0000000184C05790-0x0000000184C05830 
	private static string NORMAL_SCENE_BORN_POS_STREAMING_CONFIG_PATH { /* [XID] */ /* 0x0000000189A9F450-0x0000000189A9F470 */ get => default; } // 0x0000000184C06650-0x0000000184C066F0 
	private static bool _realLoadDataByStream { /* [XID] */ /* 0x0000000189AA6C60-0x0000000189AA6C80 */ get => default; } // 0x0000000184C0B720-0x0000000184C0B820 

	// Nested types
	private struct QuestNpcKey // TypeDefIndex: 21219
	{
		// Fields
		public uint configId; // 0x00
		public uint questMainId; // 0x04

		// Constructors
		public QuestNpcKey(uint configId, uint questMainId) {
			this.configId = default;
			this.questMainId = default;
		} // 0x0000000184C1C4A0-0x0000000184C1C510

		// Methods
		// [XID] // 0x0000000189B35030-0x0000000189B35050
		public override int GetHashCode() => default; // 0x0000000184C1C300-0x0000000184C1C3B0
		// [IDTag] // 0x0000000189B3C900-0x0000000189B3C940
		// [XID] // 0x0000000189B3C900-0x0000000189B3C940
		public override bool Equals(object obj) => default; // 0x0000000184C1C220-0x0000000184C1C300
		// [IDTag] // 0x0000000189B47430-0x0000000189B47470
		// [XID] // 0x0000000189B47430-0x0000000189B47470
		public bool Equals(QuestNpcKey other) => default; // 0x0000000184C1C480-0x0000000184C1C4A0
		// [XID] // 0x0000000189B51DE0-0x0000000189B51E00
		private static int CombineHashCodes(int h1, int h2) => default; // 0x0000000184C1BFD0-0x0000000184C1C110
	}

	private class BlockBornPosData // TypeDefIndex: 21220
	{
		// Fields
		public bool isDirty; // 0x10
		public int x; // 0x14
		public int z; // 0x18
		public RecycledLinkedList<BornPosData> bornPosList; // 0x20

		// Constructors
		public BlockBornPosData() {} // 0x0000000184C15130-0x0000000184C151C0
	}

	private enum ConfigLoadPhase // TypeDefIndex: 21221
	{
		NotLoad = 0,
		Loading = 1,
		Loaded = 2
	}

	private interface IDataAdapter<TDataSource> // TypeDefIndex: 21222
	{
		// Properties
		uint configId { get; }
		uint roomId { get; }
		Vector3 pos { get; }
		Vector3 rot { get; }
		uint groupId { get; }
		uint suiteId { get; }
		uint[] suiteIdList { get; }
		uint dynUniqId { get; }

		// Methods
		void Set(TDataSource dataSource);
		void Clear();
	}

	private class GroupDataAdapter : IDataAdapter<ILuaMapInfoCfgEx> // TypeDefIndex: 21223
	{
		// Fields
		private ILuaMapInfoCfgEx _curCfg; // 0x10
		private static GroupDataAdapter _instance; // 0x00

		// Properties
		public uint configId { /* [XID] */ /* 0x0000000189B59600-0x0000000189B59620 */ get => default; } // 0x0000000184C17F40-0x0000000184C18000 
		public uint roomId { /* [XID] */ /* 0x0000000189B60E50-0x0000000189B60E70 */ get => default; } // 0x0000000184C180A0-0x0000000184C18160 
		public Vector3 pos { /* [XID] */ /* 0x0000000189B685B0-0x0000000189B685D0 */ get => default; } // 0x0000000184C17D30-0x0000000184C17EA0 
		public Vector3 rot { /* [XID] */ /* 0x0000000189B6F940-0x0000000189B6F960 */ get => default; } // 0x0000000184C17980-0x0000000184C17AF0 
		public uint groupId { /* [XID] */ /* 0x0000000189B76F10-0x0000000189B76F30 */ get => default; } // 0x0000000184C18210-0x0000000184C182D0 
		public uint suiteId { /* [XID] */ /* 0x0000000189B7E460-0x0000000189B7E480 */ get => default; } // 0x0000000184C17AF0-0x0000000184C17BB0 
		public uint[] suiteIdList { /* [XID] */ /* 0x0000000189B86070-0x0000000189B86090 */ get => default; } // 0x0000000184C18000-0x0000000184C180A0 
		public uint dynUniqId { /* [XID] */ /* 0x0000000189B8D150-0x0000000189B8D170 */ get => default; } // 0x0000000184C17EA0-0x0000000184C17F40 
		public static GroupDataAdapter instance { /* [XID] */ /* 0x0000000189BA36F0-0x0000000189BA3710 */ get => default; } // 0x0000000184C17BB0-0x0000000184C17C90 

		// Constructors
		public GroupDataAdapter() {} // 0x0000000184C182D0-0x0000000184C18330

		// Methods
		// [XID] // 0x0000000189B94910-0x0000000189B94930
		public void Set(ILuaMapInfoCfgEx dataSource) {} // 0x0000000184C18160-0x0000000184C18210
		// [XID] // 0x0000000189B9BFC0-0x0000000189B9BFE0
		public void Clear() {} // 0x0000000184C17C90-0x0000000184C17D30
	}

	private class BornConfigDataAdapter : IDataAdapter<ConfigNpcBornPos> // TypeDefIndex: 21224
	{
		// Fields
		private ConfigNpcBornPos _curCfg; // 0x10
		private static BornConfigDataAdapter _instance; // 0x00

		// Properties
		public uint configId { /* [XID] */ /* 0x0000000189BAAAC0-0x0000000189BAAAE0 */ get => default; } // 0x0000000184C1A470-0x0000000184C1A520 
		public uint roomId { /* [XID] */ /* 0x0000000189BB2030-0x0000000189BB2050 */ get => default; } // 0x0000000184C1A5D0-0x0000000184C1A680 
		public Vector3 pos { /* [XID] */ /* 0x0000000189BB9420-0x0000000189BB9440 */ get => default; } // 0x0000000184C1A2B0-0x0000000184C1A3D0 
		public Vector3 rot { /* [XID] */ /* 0x0000000189BC1200-0x0000000189BC1220 */ get => default; } // 0x0000000184C19F60-0x0000000184C1A080 
		public uint groupId { /* [XID] */ /* 0x0000000189BC8A60-0x0000000189BC8A80 */ get => default; } // 0x0000000184C1A730-0x0000000184C1A7E0 
		public uint suiteId { /* [XID] */ /* 0x0000000189BD01D0-0x0000000189BD01F0 */ get => default; } // 0x0000000184C1A080-0x0000000184C1A130 
		public uint[] suiteIdList { /* [XID] */ /* 0x0000000189BD7890-0x0000000189BD78B0 */ get => default; } // 0x0000000184C1A520-0x0000000184C1A5D0 
		public uint dynUniqId { /* [XID] */ /* 0x0000000189BDF3E0-0x0000000189BDF400 */ get => default; } // 0x0000000184C1A3D0-0x0000000184C1A470 
		public static BornConfigDataAdapter instance { /* [XID] */ /* 0x00000001895FACD0-0x00000001895FACF0 */ get => default; } // 0x0000000184C1A130-0x0000000184C1A210 

		// Constructors
		public BornConfigDataAdapter() {} // 0x0000000184C1A7E0-0x0000000184C1A840

		// Methods
		// [XID] // 0x00000001895EBFB0-0x00000001895EBFD0
		public void Set(ConfigNpcBornPos dataSource) {} // 0x0000000184C1A680-0x0000000184C1A730
		// [XID] // 0x00000001895F33B0-0x00000001895F33D0
		public void Clear() {} // 0x0000000184C1A210-0x0000000184C1A2B0
	}

	private class DyncBornDataAdapter : IDataAdapter<DyncBornDataAdapter> // TypeDefIndex: 21225
	{
		// Fields
		private static List<DyncBornDataAdapter> _listInstance; // 0x00

		// Properties
		public uint configId { get; /* [XID] */ /* 0x000000018965DAB0-0x000000018965DAF0 */ private set; } // 0x0000000184C15BF0-0x0000000184C15C50 0x0000000184C15DC0-0x0000000184C15E20
		public uint roomId { get; /* [XID] */ /* 0x000000018966FE10-0x000000018966FE50 */ private set; } // 0x0000000184C15CB0-0x0000000184C15D10 0x0000000184C155C0-0x0000000184C15620
		public Vector3 pos { get; /* [XID] */ /* 0x0000000189681DD0-0x0000000189681E10 */ private set; } // 0x0000000184C15B20-0x0000000184C15B90 0x0000000184C15620-0x0000000184C15690
		public Vector3 rot { get; /* [XID] */ /* 0x0000000189694310-0x0000000189694350 */ private set; } // 0x0000000184C154E0-0x0000000184C15550 0x0000000184C15550-0x0000000184C155C0
		public uint groupId { get; private set; } // 0x0000000184C15EE0-0x0000000184C15F40 0x0000000184C15F40-0x0000000184C15FA0
		public uint suiteId { get; private set; } // 0x0000000184C15690-0x0000000184C156F0 0x0000000184C15E20-0x0000000184C15E80
		public uint[] suiteIdList { get; private set; } // 0x0000000184C15C50-0x0000000184C15CB0 0x0000000184C15E80-0x0000000184C15EE0
		public uint dynUniqId { get; /* [XID] */ /* 0x00000001896D1C80-0x00000001896D1CC0 */ private set; } // 0x0000000184C15B90-0x0000000184C15BF0 0x0000000184C157B0-0x0000000184C15810
		public static DyncBornDataAdapter instance { /* [XID] */ /* 0x00000001896F22F0-0x00000001896F2310 */ get => default; } // 0x0000000184C156F0-0x0000000184C157B0 
		public static List<DyncBornDataAdapter> listInstance { /* [XID] */ /* 0x00000001896F9C50-0x00000001896F9C70 */ get => default; } // 0x0000000184C15FA0-0x0000000184C160E0 

		// Constructors
		public DyncBornDataAdapter() {} // 0x0000000184C160E0-0x0000000184C16140

		// Methods
		// [XID] // 0x00000001896DC320-0x00000001896DC340
		public void Init(uint configId, uint roomId, Vector3 pos, Vector3 rot, uint dynUniqId) {} // 0x0000000184C15810-0x0000000184C15A80
		// [XID] // 0x00000001896E3B70-0x00000001896E3B90
		public void Set(DyncBornDataAdapter dataSource) {} // 0x0000000184C15D10-0x0000000184C15DC0
		// [XID] // 0x00000001896EAEE0-0x00000001896EAF00
		public void Clear() {} // 0x0000000184C15A80-0x0000000184C15B20
	}

	private class SceneBlockLoadState // TypeDefIndex: 21226
	{
		// Fields
		public uint sceneId; // 0x10
		public bool isRoomType; // 0x14
		public ConfigLoadAndSerializePattern pattern; // 0x18
		public ConfigLoadPhase phase; // 0x20

		// Constructors
		public SceneBlockLoadState() {} // 0x0000000184C16140-0x0000000184C161A0
	}

	private interface ICacheCommand : ISimplePoolObject // TypeDefIndex: 21227
	{
		// Properties
		int weight { get; }
		bool isMainThread { get; }

		// Methods
		void Execute(NpcManager mgr);
		void Release();
	}

	private interface ICacheCommandPool : ISimplePool // TypeDefIndex: 21228
	{
		// Methods
		void DestroyPool();
	}

	private abstract class BaseCacheCommand<TSelf> : ICacheCommand // TypeDefIndex: 21229
		where TSelf : BaseCacheCommand<TSelf>, new()
	{
		// Properties
		public virtual int weight { get; }
		public virtual bool isMainThread { get; }
		public abstract TSelf thisRef { get; }

		// Constructors
		protected BaseCacheCommand() {}

		// Methods
		public void Release() {}
		public virtual void Execute(NpcManager mgr) {}
		public virtual void ResetObject() {}
	}

	private class OnNpcPosChangeReq : BaseCacheCommand<OnNpcPosChangeReq> // TypeDefIndex: 21230
	{
		// Fields
		private uint _configId; // 0x10
		private uint _mainQuestId; // 0x14
		private Vector3 _pos; // 0x18
		private Vector3 _rot; // 0x24

		// Properties
		public override OnNpcPosChangeReq thisRef { /* [XID] */ /* 0x0000000189701480-0x00000001897014A0 */ get => default; } // 0x0000000184C1D5B0-0x0000000184C1D650 

		// Constructors
		public OnNpcPosChangeReq() {} // 0x0000000184C1D650-0x0000000184C1D6C0

		// Methods
		// [XID] // 0x0000000189708C80-0x0000000189708CA0
		public override void Execute(NpcManager mgr) {} // 0x0000000184C1D2E0-0x0000000184C1D3F0
		// [XID] // 0x0000000189710520-0x0000000189710540
		public void Init(uint configId, uint mainQuestId, Vector3 pos, Vector3 rot) {} // 0x0000000184C1D470-0x0000000184C1D5B0
	}

	private class AddRoomReq : BaseCacheCommand<AddRoomReq> // TypeDefIndex: 21231
	{
		// Fields
		private uint _roomId; // 0x10

		// Properties
		public override AddRoomReq thisRef { /* [XID] */ /* 0x0000000189717900-0x0000000189717920 */ get => default; } // 0x0000000184C1C700-0x0000000184C1C7A0 

		// Constructors
		public AddRoomReq() {} // 0x0000000184C1C7A0-0x0000000184C1C810

		// Methods
		// [XID] // 0x000000018971F3D0-0x000000018971F3F0
		public override void Execute(NpcManager mgr) {} // 0x0000000184C1C510-0x0000000184C1C5D0
		// [XID] // 0x00000001897269C0-0x00000001897269E0
		public void Init(uint roomId) {} // 0x0000000184C1C650-0x0000000184C1C700
	}

	private class RemoveRoomReq : BaseCacheCommand<RemoveRoomReq> // TypeDefIndex: 21232
	{
		// Fields
		private uint _roomId; // 0x10

		// Properties
		public override RemoveRoomReq thisRef { /* [XID] */ /* 0x000000018972DF30-0x000000018972DF50 */ get => default; } // 0x0000000184C00260-0x0000000184C00300 

		// Constructors
		public RemoveRoomReq() {} // 0x0000000184C00300-0x0000000184C00370

		// Methods
		// [XID] // 0x00000001897355B0-0x00000001897355D0
		public override void Execute(NpcManager mgr) {} // 0x0000000184C00070-0x0000000184C00130
		// [XID] // 0x000000018973D130-0x000000018973D150
		public void Init(uint roomId) {} // 0x0000000184C001B0-0x0000000184C00260
	}

	private class UpdateNpcDataReq : BaseCacheCommand<UpdateNpcDataReq> // TypeDefIndex: 21233
	{
		// Fields
		private uint _configId; // 0x10
		private uint _questMainId; // 0x14
		private Vector3 _pos; // 0x18
		private Vector3 _rot; // 0x24
		private uint _sceneId; // 0x30
		private uint _roomId; // 0x34
		private uint _runtimeId; // 0x38

		// Properties
		public override UpdateNpcDataReq thisRef { /* [XID] */ /* 0x0000000189744650-0x0000000189744670 */ get => default; } // 0x0000000184C20780-0x0000000184C20820 

		// Constructors
		public UpdateNpcDataReq() {} // 0x0000000184C20820-0x0000000184C20890

		// Methods
		// [XID] // 0x000000018974C350-0x000000018974C370
		public override void Execute(NpcManager mgr) {} // 0x0000000184C20440-0x0000000184C20570
		// [XID] // 0x00000001897535C0-0x00000001897535E0
		public void Init(uint configId, uint questMainId, Vector3 pos, Vector3 rot, uint sceneId, uint roomId, uint runtimeId) {} // 0x0000000184C205F0-0x0000000184C20780
	}

	private class RemoveNpcDataReq : BaseCacheCommand<RemoveNpcDataReq> // TypeDefIndex: 21234
	{
		// Fields
		private uint _configId; // 0x10
		private uint _questMainId; // 0x14

		// Properties
		public override RemoveNpcDataReq thisRef { /* [XID] */ /* 0x000000018975AB00-0x000000018975AB20 */ get => default; } // 0x0000000184C153D0-0x0000000184C15470 

		// Constructors
		public RemoveNpcDataReq() {} // 0x0000000184C15470-0x0000000184C154E0

		// Methods
		// [XID] // 0x0000000189762610-0x0000000189762630
		public override void Execute(NpcManager mgr) {} // 0x0000000184C151C0-0x0000000184C15290
		// [XID] // 0x0000000189769CB0-0x0000000189769CD0
		public void Init(uint configId, uint questMainId) {} // 0x0000000184C15310-0x0000000184C153D0
	}

	private class AddDynNpcBornDataReq : BaseCacheCommand<AddDynNpcBornDataReq> // TypeDefIndex: 21235
	{
		// Fields
		private uint _configId; // 0x10
		private Vector3 _pos; // 0x14
		private Vector3 _rot; // 0x20
		private uint _sceneId; // 0x2C
		private uint _roomId; // 0x30
		private uint _uniqId; // 0x34

		// Properties
		public override AddDynNpcBornDataReq thisRef { /* [XID] */ /* 0x00000001897712A0-0x00000001897712C0 */ get => default; } // 0x0000000184C19E50-0x0000000184C19EF0 

		// Constructors
		public AddDynNpcBornDataReq() {} // 0x0000000184C19EF0-0x0000000184C19F60

		// Methods
		// [XID] // 0x0000000189778B20-0x0000000189778B40
		public override void Execute(NpcManager mgr) {} // 0x0000000184C19B40-0x0000000184C19C60
		// [XID] // 0x00000001897800E0-0x0000000189780100
		public void Init(uint configId, Vector3 pos, Vector3 rot, uint sceneId, uint roomId, uint uniqId) {} // 0x0000000184C19CE0-0x0000000184C19E50
	}

	private class RemoveDynNpcBornDataReq : BaseCacheCommand<RemoveDynNpcBornDataReq> // TypeDefIndex: 21236
	{
		// Fields
		private uint _uniqId; // 0x10

		// Properties
		public override RemoveDynNpcBornDataReq thisRef { /* [XID] */ /* 0x0000000189787980-0x00000001897879A0 */ get => default; } // 0x0000000184BFE0E0-0x0000000184BFE180 

		// Constructors
		public RemoveDynNpcBornDataReq() {} // 0x0000000184BFE180-0x0000000184BFE1F0

		// Methods
		// [XID] // 0x000000018978EFA0-0x000000018978EFC0
		public override void Execute(NpcManager mgr) {} // 0x0000000184BFDEF0-0x0000000184BFDFB0
		// [XID] // 0x0000000189796810-0x0000000189796830
		public void Init(uint uniqId) {} // 0x0000000184BFE030-0x0000000184BFE0E0
	}

	private class OnGroupSuiteChangeReq : BaseCacheCommand<OnGroupSuiteChangeReq> // TypeDefIndex: 21237
	{
		// Fields
		private uint _groupId; // 0x10
		private uint _suiteId; // 0x14

		// Properties
		public override OnGroupSuiteChangeReq thisRef { /* [XID] */ /* 0x000000018979E8F0-0x000000018979E910 */ get => default; } // 0x0000000184C00B50-0x0000000184C00BF0 

		// Constructors
		public OnGroupSuiteChangeReq() {} // 0x0000000184C00BF0-0x0000000184C00C60

		// Methods
		// [XID] // 0x00000001897A6020-0x00000001897A6040
		public override void Execute(NpcManager mgr) {} // 0x0000000184C00940-0x0000000184C00A10
		// [XID] // 0x00000001897AD4D0-0x00000001897AD4F0
		public void Init(uint groupId, uint suiteId) {} // 0x0000000184C00A90-0x0000000184C00B50
	}

	private class OnGroupUnloadReq : BaseCacheCommand<OnGroupUnloadReq> // TypeDefIndex: 21238
	{
		// Fields
		private uint _groupId; // 0x10

		// Properties
		public override OnGroupUnloadReq thisRef { /* [XID] */ /* 0x00000001897B55F0-0x00000001897B5610 */ get => default; } // 0x0000000184C1EDD0-0x0000000184C1EE70 

		// Constructors
		public OnGroupUnloadReq() {} // 0x0000000184C1EE70-0x0000000184C1EEE0

		// Methods
		// [XID] // 0x00000001897BD1F0-0x00000001897BD210
		public override void Execute(NpcManager mgr) {} // 0x0000000184C1EBE0-0x0000000184C1ECA0
		// [XID] // 0x00000001897C45A0-0x00000001897C45C0
		public void Init(uint groupId) {} // 0x0000000184C1ED20-0x0000000184C1EDD0
	}

	private class OnDestroyReq : BaseCacheCommand<OnDestroyReq> // TypeDefIndex: 21239
	{
		// Fields
		private uint _configId; // 0x10
		private uint _questMainId; // 0x14

		// Properties
		public override OnDestroyReq thisRef { /* [XID] */ /* 0x00000001897CBD90-0x00000001897CBDB0 */ get => default; } // 0x0000000184C1AA50-0x0000000184C1AAF0 

		// Constructors
		public OnDestroyReq() {} // 0x0000000184C1AAF0-0x0000000184C1AB60

		// Methods
		// [XID] // 0x00000001897D37C0-0x00000001897D37E0
		public override void Execute(NpcManager mgr) {} // 0x0000000184C1A840-0x0000000184C1A910
		// [XID] // 0x00000001897DB250-0x00000001897DB270
		public void Init(uint configId, uint questMainId) {} // 0x0000000184C1A990-0x0000000184C1AA50
	}

	private class GenerateLevelBornPosDataReq : BaseCacheCommand<GenerateLevelBornPosDataReq> // TypeDefIndex: 21240
	{
		// Fields
		private uint _sceneId; // 0x10
		private bool _isRoomType; // 0x14
		private IEnumerable<ConfigNpcBornPos> _dataSourceList; // 0x18

		// Properties
		public override GenerateLevelBornPosDataReq thisRef { /* [XID] */ /* 0x00000001897E28E0-0x00000001897E2900 */ get => default; } // 0x0000000184C1AD90-0x0000000184C1AE30 

		// Constructors
		public GenerateLevelBornPosDataReq() {} // 0x0000000184C1AE30-0x0000000184C1AEA0

		// Methods
		// [XID] // 0x00000001897EA000-0x00000001897EA020
		public override void Execute(NpcManager mgr) {} // 0x0000000184C1AB60-0x0000000184C1AC30
		// [XID] // 0x00000001897F1CF0-0x00000001897F1D10
		public void Init(uint sceneId, bool isRoomType, IEnumerable<ConfigNpcBornPos> dataSourceList) {} // 0x0000000184C1ACB0-0x0000000184C1AD90
	}

	private class ClearLevelBornPosDataReq : BaseCacheCommand<ClearLevelBornPosDataReq> // TypeDefIndex: 21241
	{
		// Fields
		private uint _sceneId; // 0x10
		private bool _isRoomType; // 0x14

		// Properties
		public override ClearLevelBornPosDataReq thisRef { /* [XID] */ /* 0x00000001897F9590-0x00000001897F95B0 */ get => default; } // 0x0000000184C1EAD0-0x0000000184C1EB70 

		// Constructors
		public ClearLevelBornPosDataReq() {} // 0x0000000184C1EB70-0x0000000184C1EBE0

		// Methods
		// [XID] // 0x0000000189800AF0-0x0000000189800B10
		public override void Execute(NpcManager mgr) {} // 0x0000000184C1E8B0-0x0000000184C1E980
		// [XID] // 0x0000000189808040-0x0000000189808060
		public void Init(uint sceneId, bool isRoomType) {} // 0x0000000184C1EA00-0x0000000184C1EAD0
	}

	private class NpcAppearReq : BaseCacheCommand<NpcAppearReq> // TypeDefIndex: 21242
	{
		// Fields
		protected uint _configId; // 0x10
		protected uint _roomId; // 0x14
		protected uint _mainQuestId; // 0x18
		protected Vector3 _pos; // 0x1C
		protected Vector3 _rot; // 0x28
		protected uint _runtimeId; // 0x34

		// Properties
		public override bool isMainThread { /* [XID] */ /* 0x000000018980FA10-0x000000018980FA30 */ get => default; } // 0x0000000184BFE860-0x0000000184BFE900 
		public override NpcAppearReq thisRef { /* [XID] */ /* 0x0000000189817020-0x0000000189817040 */ get => default; } // 0x0000000184BFEA80-0x0000000184BFEB20 

		// Constructors
		public NpcAppearReq() {} // 0x0000000184BFEBC0-0x0000000184BFEC30

		// Methods
		// [XID] // 0x000000018981E8B0-0x000000018981E8D0
		public override void Execute(NpcManager mgr) {} // 0x0000000184BFE5F0-0x0000000184BFE780
		// [XID] // 0x0000000189825DC0-0x0000000189825DE0
		public override void ResetObject() {} // 0x0000000184BFEB20-0x0000000184BFEBC0
		// [XID] // 0x000000018982D520-0x000000018982D540
		public void Init(uint configId, uint roomId, uint mainQuestId, Vector3 pos, Vector3 rot, uint runtimeID) {} // 0x0000000184BFE900-0x0000000184BFEA80
	}

	private class NpcForceAppearReq : NpcAppearReq // TypeDefIndex: 21243
	{
		// Constructors
		public NpcForceAppearReq() {} // 0x0000000184C1BE40-0x0000000184C1BEF0

		// Methods
		// [XID] // 0x0000000189834C50-0x0000000189834C70
		public override void Execute(NpcManager mgr) {} // 0x0000000184C1BC60-0x0000000184C1BDC0
	}

	private class NpcDisappearReq : BaseCacheCommand<NpcDisappearReq> // TypeDefIndex: 21244
	{
		// Fields
		private uint _configId; // 0x10
		private uint _mainQuestId; // 0x14

		// Properties
		public override bool isMainThread { /* [XID] */ /* 0x000000018983C3B0-0x000000018983C3D0 */ get => default; } // 0x0000000184C1B9F0-0x0000000184C1BA90 
		public override NpcDisappearReq thisRef { /* [XID] */ /* 0x00000001898438E0-0x0000000189843900 */ get => default; } // 0x0000000184C1BB50-0x0000000184C1BBF0 

		// Constructors
		public NpcDisappearReq() {} // 0x0000000184C1BBF0-0x0000000184C1BC60

		// Methods
		// [XID] // 0x000000018984AE30-0x000000018984AE50
		public override void Execute(NpcManager mgr) {} // 0x0000000184C1B850-0x0000000184C1B970
		// [XID] // 0x0000000189852130-0x0000000189852150
		public void Init(uint configId, uint mainQuestId) {} // 0x0000000184C1BA90-0x0000000184C1BB50
	}

	private class SyncNpcPos : BaseCacheCommand<SyncNpcPos> // TypeDefIndex: 21245
	{
		// Fields
		private uint _configId; // 0x10
		private uint _questMainId; // 0x14

		// Properties
		public override SyncNpcPos thisRef { /* [XID] */ /* 0x0000000189859B90-0x0000000189859BB0 */ get => default; } // 0x0000000184C19A30-0x0000000184C19AD0 

		// Constructors
		public SyncNpcPos() {} // 0x0000000184C19AD0-0x0000000184C19B40

		// Methods
		// [XID] // 0x0000000189860C30-0x0000000189860C50
		public override void Execute(NpcManager mgr) {} // 0x0000000184C19820-0x0000000184C198F0
		// [XID] // 0x00000001898683E0-0x0000000189868400
		public void Init(uint configId, uint questMainId) {} // 0x0000000184C19970-0x0000000184C19A30
	}

	private class SetGlobalAppearDisappearDist : BaseCacheCommand<SetGlobalAppearDisappearDist> // TypeDefIndex: 21246
	{
		// Fields
		private float _appearDist; // 0x10
		private float _disappearDist; // 0x14

		// Properties
		public override SetGlobalAppearDisappearDist thisRef { /* [XID] */ /* 0x000000018986F860-0x000000018986F880 */ get => default; } // 0x0000000184BFDC20-0x0000000184BFDCC0 

		// Constructors
		public SetGlobalAppearDisappearDist() {} // 0x0000000184BFDCC0-0x0000000184BFDD30

		// Methods
		// [XID] // 0x0000000189876E10-0x0000000189876E30
		public override void Execute(NpcManager mgr) {} // 0x0000000184BFDA00-0x0000000184BFDAD0
		// [XID] // 0x000000018987E920-0x000000018987E940
		public void Init(float appearDist, float disappearDist) {} // 0x0000000184BFDB50-0x0000000184BFDC20
	}

	private class CommandPool<TCommand> : SimpleObjectPool<TCommand>, ICacheCommandPool // TypeDefIndex: 21247
		where TCommand : class, ICacheCommand, new()
	{
		// Fields
		private static CommandPool<TCommand> _instance;

		// Constructors
		public CommandPool() {}

		// Methods
		public static bool Get(out CommandPool<TCommand> pool) {
			pool = default;
			return default;
		}
		public void DestroyPool() {}
	}

	// Constructors
	public NpcManager() {} // 0x0000000184C122B0-0x0000000184C126F0
	static NpcManager() {} // 0x0000000184C11FF0-0x0000000184C122B0

	// Methods
	[DebuggerHidden] // 0x000000018980B010-0x000000018980B050
	// [XID] // 0x000000018980B010-0x000000018980B050
	private IEnumerator CheckBlockNpcAppear(uint sceneId, int curX, int curZ, int i, int j, Dictionary<Vector2, BlockBornPosData> curSceneDailyPosDic, Dictionary<Vector2, RecycledLinkedList<BornPosData>> curSceneQuestPosDic, bool isInit, bool force = false /* Metadata: 0x00AFF121 */) => default; // 0x0000000184C0B150-0x0000000184C0B340
	[DebuggerHidden] // 0x00000001898156F0-0x0000000189815730
	// [XID] // 0x00000001898156F0-0x0000000189815730
	private IEnumerator CheckNormalSceneNpcAppear(uint sceneId, bool isInit) => default; // 0x0000000184C0E0E0-0x0000000184C0E220
	// [XID] // 0x0000000189820310-0x0000000189820330
	private bool CheckCanChangeBornPos_NormalScene(BornPosData oldPos, uint sceneId, int x, int z) => default; // 0x0000000184C08D10-0x0000000184C08EC0
	// [XID] // 0x0000000189827990-0x00000001898279B0
	private bool CheckCanChangeBornPos_Room(BornPosData oldPos, uint sceneId) => default; // 0x0000000184C083B0-0x0000000184C084C0
	[DebuggerHidden] // 0x000000018982EB90-0x000000018982EBD0
	// [XID] // 0x000000018982EB90-0x000000018982EBD0
	private IEnumerator CheckRoomSceneNpcAppear(uint sceneId, bool isInit) => default; // 0x0000000184C09720-0x0000000184C09860
	[DebuggerHidden] // 0x0000000189839200-0x0000000189839240
	// [XID] // 0x0000000189839200-0x0000000189839240
	private IEnumerator CheckNormalSceneNpcDisappear() => default; // 0x0000000184C11B50-0x0000000184C11C60
	[DebuggerHidden] // 0x0000000189843900-0x0000000189843940
	// [XID] // 0x0000000189843900-0x0000000189843940
	private IEnumerator CheckRoomSceneNpcDisappear() => default; // 0x0000000184C06D30-0x0000000184C06E40
	// [XID] // 0x0000000189872790-0x00000001898727B0
	public override void ReloadRes() {} // 0x0000000184C11EB0-0x0000000184C11F50
	// [XID] // 0x000000018987A460-0x000000018987A480
	public override void ClearOnLevelDestroy() {} // 0x0000000184C06860-0x0000000184C06920
	// [XID] // 0x0000000189881540-0x0000000189881560
	public override void PostTick() {} // 0x0000000184C11E10-0x0000000184C11EB0
	// [XID] // 0x0000000189888AA0-0x0000000189888AC0
	public override void Init() {} // 0x0000000184C0BC20-0x0000000184C0BD70
	// [XID] // 0x000000018988FE80-0x000000018988FEA0
	public override void Destroy() {} // 0x0000000184C06E40-0x0000000184C06FA0
	// [XID] // 0x00000001898973E0-0x0000000189897400
	public override void ClearOnDisconnect() {} // 0x0000000184C067A0-0x0000000184C06860
	// [XID] // 0x000000018989E900-0x000000018989E920
	public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFF122 */) {} // 0x0000000184C066F0-0x0000000184C067A0
	// [XID] // 0x00000001898A6400-0x00000001898A6420
	public override void Tick() {} // 0x0000000184C11F50-0x0000000184C11FF0
	// [XID] // 0x00000001898ADA70-0x00000001898ADA90
	public void ForceSyncNpcPos(uint configId, uint mainQuestId) {} // 0x0000000184C0D100-0x0000000184C0D4B0
	// [XID] // 0x00000001898B4F00-0x00000001898B4F20
	private void TickSyncPos() {} // 0x0000000184C0A480-0x0000000184C0A7C0
	// [XID] // 0x00000001898BCA10-0x00000001898BCA30
	public bool OnNotify(Notify ntf) => default; // 0x0000000184C117C0-0x0000000184C119B0
	// [XID] // 0x00000001898C4130-0x00000001898C4150
	public void ForceNpcNotDestroy(uint configId, uint questMainId, bool forceNotDestroy) {} // 0x0000000184C10F30-0x0000000184C11130
	// [XID] // 0x00000001898CB830-0x00000001898CB850
	public bool IsForceNpcNotDestroy(uint configId, uint questMainId) => default; // 0x0000000184C06540-0x0000000184C06650
	// [XID] // 0x00000001898D2F50-0x00000001898D2F70
	private void AddNewRoom(uint roomId) {} // 0x0000000184C0A030-0x0000000184C0A1E0
	// [XID] // 0x00000001898DA900-0x00000001898DA920
	private void RemoveRoom(uint roomId) {} // 0x0000000184C0B010-0x0000000184C0B150
	// [XID] // 0x00000001898E2720-0x00000001898E2740
	private void SetDailyNpcEnable(uint configId, bool enable) {} // 0x0000000184C09860-0x0000000184C09A70
	// [XID] // 0x00000001898BED80-0x00000001898BEDA0
	private bool IsNpcBornInfoEnable(NpcBornInfo bornInfo) => default; // 0x0000000184C0AE50-0x0000000184C0AF40
	// [XID] // 0x00000001898F1A10-0x00000001898F1A30
	private uint GenNextDynBornPosUniqId() => default; // 0x0000000184C0B820-0x0000000184C0B920
	// [XID] // 0x00000001898F9150-0x00000001898F9170
	public uint AddDynNpcBornData(uint configId, Vector3 pos, Vector3 rot, uint sceneId, uint roomId, uint dynPosUniqId = 0 /* Metadata: 0x00AFF123 */) => default; // 0x0000000184C0FE50-0x0000000184C10130
	// [XID] // 0x0000000189900AB0-0x0000000189900AD0
	public void RemoveDyncNpcBornData(uint dynBornDataUniqId) {} // 0x0000000184C0ACF0-0x0000000184C0AE50
	// [XID] // 0x0000000189908270-0x0000000189908290
	private void RemoveDynNpcBornDataImpl(uint configId, uint dynBornDataUniqId, bool clearInfo) {} // 0x0000000184C08F20-0x0000000184C091C0
	// [XID] // 0x000000018990FA70-0x000000018990FA90
	private void ClearDynNpcData() {} // 0x0000000184C0DCD0-0x0000000184C0DEB0
	// [XID] // 0x0000000189A885A0-0x0000000189A885C0
	public void UpdateNpcData(uint configId, uint questMainId, Vector3 pos, Vector3 rot, uint sceneId, uint roomId, uint tarRuntimeId = 0 /* Metadata: 0x00AFF127 */) {} // 0x0000000184C0A7C0-0x0000000184C0ACF0
	// [XID] // 0x0000000189AAD9C0-0x0000000189AAD9E0
	public void RemoveNpcData(uint configId, uint questMainId) {} // 0x0000000184C0F160-0x0000000184C0F390
	// [XID] // 0x00000001899263E0-0x0000000189926400
	public bool IsInROI(uint sceneId, uint roomId, Vector3 position) => default; // 0x0000000184C0D710-0x0000000184C0D9A0
	// [XID] // 0x0000000189AA63E0-0x0000000189AA6400
	private bool IsSceneRoomType(uint sceneId) => default; // 0x0000000184C0F740-0x0000000184C0F830
	// [XID] // 0x0000000189934F30-0x0000000189934F50
	private void RemoveQuestNpcPosFromDic(NpcBornInfo bornInfo) {} // 0x0000000184C0BD70-0x0000000184C0C540
	// [XID] // 0x000000018993CA90-0x000000018993CAB0
	private void RemoveDailyNpcPosFromDic(BornPosData posData) {} // 0x0000000184C07A10-0x0000000184C083B0
	// [XID] // 0x0000000189AB51B0-0x0000000189AB51D0
	private void AddQuestNpcPosToDic(BornPosData posData) {} // 0x0000000184C04F60-0x0000000184C05290
	// [XID] // 0x000000018994B670-0x000000018994B690
	public void OnNpcPosChange(uint configId, uint mainQuestId, Vector3 pos, Vector3 rot) {} // 0x0000000184C060F0-0x0000000184C06540
	// [XID] // 0x0000000189952F50-0x0000000189952F70
	public void SetGlobalAppearDisappearLength(float appearLength, float disappearLength) {} // 0x0000000184C0A260-0x0000000184C0A480
	// [XID] // 0x000000018995A4D0-0x000000018995A4F0
	public void ResetGobalAppearDisappearLength() {} // 0x0000000184C111D0-0x0000000184C11280
	// [XID] // 0x000000018987C790-0x000000018987C7B0
	public void OnNpcDestroy(uint configId, uint questMainId) {} // 0x0000000184C11C60-0x0000000184C11E10
	// [XID] // 0x0000000189969540-0x0000000189969560
	public void OnGroupSuiteChange(uint groupId, uint suiteId) {} // 0x0000000184C08AC0-0x0000000184C08D10
	// [XID] // 0x0000000189971120-0x0000000189971140
	public void OnGroupUnload(uint groupId) {} // 0x0000000184C10D10-0x0000000184C10F30
	// [XID] // 0x0000000189978AF0-0x0000000189978B10
	private void SetBornPosGroupSuiteEnable(BornPosData pos, bool enable) {} // 0x0000000184C05EF0-0x0000000184C06010
	// [XID] // 0x000000018997FB70-0x000000018997FB90
	private void ClearGroupSuiteInfo() {} // 0x0000000184C0B340-0x0000000184C0B600
	// [XID] // 0x00000001898B0170-0x00000001898B0190
	private void SetNpcDirty(NpcBornInfo tarInfo) {} // 0x0000000184C05410-0x0000000184C05500
	// [XID] // 0x0000000189ABCE30-0x0000000189ABCE50
	private void RemoveDirtyNpc(NpcBornInfo tarInfo) {} // 0x0000000184C05290-0x0000000184C053B0
	// [XID] // 0x0000000189996AC0-0x0000000189996AE0
	private void SetBlockDirty(BlockBornPosData tarData) {} // 0x0000000184C0DB70-0x0000000184C0DC50
	// [XID] // 0x000000018999E630-0x000000018999E650
	private void ClearDirtyBlockList() {} // 0x0000000184C05A90-0x0000000184C05C40
	// [XID] // 0x0000000189B70970-0x0000000189B70990
	private void AddAppearedNpc(NpcBornInfo tarInfo) {} // 0x0000000184C05500-0x0000000184C055D0
	// [XID] // 0x00000001899AD680-0x00000001899AD6A0
	private void RemoveAppearedNpc(NpcBornInfo tarInfo) {} // 0x0000000184C0DF90-0x0000000184C0E0E0
	// [XID] // 0x00000001899B4EA0-0x00000001899B4EC0
	private void AddDisappearedNpc(NpcBornInfo tarInfo) {} // 0x0000000184C116F0-0x0000000184C117C0
	// [XID] // 0x00000001899BC610-0x00000001899BC630
	private void RemoveDisappearedNpc(NpcBornInfo tarInfo) {} // 0x0000000184C055D0-0x0000000184C056F0
	// [XID] // 0x00000001899C3F60-0x00000001899C3F80
	private void TryGenerateCurSceneNpcBornInfo() {} // 0x0000000184C10A50-0x0000000184C10D10
	private BornPosData AddPosData<T>(uint sceneId, bool isRoomType, T dataSource, IDataAdapter<T> data) => default;
	// [XID] // 0x00000001899CB770-0x00000001899CB790
	private void StartWork(bool force) {} // 0x0000000184C11280-0x0000000184C116F0
	// [XID] // 0x00000001899D2BB0-0x00000001899D2BD0
	private void PauseWork() {} // 0x0000000184C06920-0x0000000184C06A30
	// [XID] // 0x00000001899DA200-0x00000001899DA220
	private void ResumeWork() {} // 0x0000000184C06A30-0x0000000184C06BF0
	// [XID] // 0x00000001899E1D00-0x00000001899E1D20
	private void StopWork() {} // 0x0000000184C0F390-0x0000000184C0F520
	// [XID] // 0x00000001899E90B0-0x00000001899E90D0
	private void ClearAllData() {} // 0x0000000184C0D9A0-0x0000000184C0DB70
	// [XID] // 0x00000001899F0990-0x00000001899F09B0
	private void ResetInfo() {} // 0x0000000184C0E220-0x0000000184C0E620
	// [XID] // 0x00000001899F8070-0x00000001899F8090
	private void ClearQuestNPCData() {} // 0x0000000184C08870-0x0000000184C08980
	// [IDTag] // 0x00000001899FF700-0x00000001899FF740
	// [XID] // 0x00000001899FF700-0x00000001899FF740
	private static void RealPosition2BlockPosition(Vector3 realPos, out int x, out int z) {
		x = default;
		z = default;
	} // 0x0000000184C0CE70-0x0000000184C0CFA0
	// [IDTag] // 0x0000000189A09DE0-0x0000000189A09E20
	// [XID] // 0x0000000189A09DE0-0x0000000189A09E20
	private static Vector2 RealPosition2BlockPosition(Vector3 realPos) => default; // 0x0000000184C0CFA0-0x0000000184C0D100
	// [IDTag] // 0x0000000189A144E0-0x0000000189A14520
	// [XID] // 0x0000000189A144E0-0x0000000189A14520
	private static int GetBlockDistance(Vector3 pos1, Vector3 pos2) => default; // 0x0000000184C10390-0x0000000184C10710
	// [IDTag] // 0x0000000189A1E780-0x0000000189A1E7C0
	// [XID] // 0x0000000189A1E780-0x0000000189A1E7C0
	private static int GetBlockDistance(Vector3 pos1, int x2, int z2) => default; // 0x0000000184C10130-0x0000000184C10390
	// [IDTag] // 0x0000000189A28BB0-0x0000000189A28BF0
	// [XID] // 0x0000000189A28BB0-0x0000000189A28BF0
	private static int GetBlockDistance(int x1, int z1, int x2, int z2) => default; // 0x0000000184C10710-0x0000000184C10830
	// [XID] // 0x0000000189A33130-0x0000000189A33150
	private void EntityAppearImpl(bool isInit, NpcBornInfo bornInfo, BornPosData posData = null, bool force = false /* Metadata: 0x00AFF12B */) {} // 0x0000000184C0D4B0-0x0000000184C0D710
	// [XID] // 0x0000000189B7F4C0-0x0000000189B7F4E0
	public void NpcAppear(uint configId, uint roomId, uint mainQuestId, Vector3 pos, Vector3 rot, uint runtimeID = 0 /* Metadata: 0x00AFF12C */, NpcBornInfo bornInfo = null) {} // 0x0000000184C05830-0x0000000184C05A90
	// [XID] // 0x0000000189B3C070-0x0000000189B3C090
	public void AddForceCheckNpc(uint configId, uint mainQuestId) {} // 0x0000000184C0FB50-0x0000000184C0FE50
	// [XID] // 0x0000000189A49960-0x0000000189A49980
	private void EntityDisappearImpl(NpcBornInfo tarInfo) {} // 0x0000000184C05C40-0x0000000184C05DB0
	// [XID] // 0x0000000189A512B0-0x0000000189A512D0
	public void NpcDisappear(uint configId, uint questMainId) {} // 0x0000000184C08980-0x0000000184C08AC0
	// [XID] // 0x0000000189B4B240-0x0000000189B4B260
	private bool GetLocalPosition(out Vector3 pos) {
		pos = default;
		return default;
	} // 0x0000000184C07860-0x0000000184C07A10
	// [XID] // 0x0000000189A603E0-0x0000000189A60400
	private Vector3 GetNpcPosition(NpcBornInfo tarInfo) => default; // 0x0000000184C06BF0-0x0000000184C06D30
	// [XID] // 0x0000000189A67F70-0x0000000189A67F90
	private Vector3 GetNpcRotation(NpcBornInfo tarInfo) => default; // 0x0000000184C119B0-0x0000000184C11AF0
	// [XID] // 0x0000000189A6F340-0x0000000189A6F360
	public NpcBornInfo GetNpcBornInfo(uint configId, uint questMainId) => default; // 0x0000000184C084C0-0x0000000184C08630
	// [XID] // 0x0000000189A76B80-0x0000000189A76BA0
	public bool IsManageByServer(uint npcConfigId, uint mainQuestId) => default; // 0x0000000184C0B600-0x0000000184C0B720
	[Preserve] // 0x0000000189A7E4E0-0x0000000189A7E520
	// [XID] // 0x0000000189A7E4E0-0x0000000189A7E520
	public override string Dump(string tag) => default; // 0x0000000184C06FA0-0x0000000184C07860
	// [XID] // 0x0000000189AAE3D0-0x0000000189AAE3F0
	private void GetFileBlockPosByRealPos(Vector3 pos, out int ox, out int oz) {
		ox = default;
		oz = default;
	} // 0x0000000184C0E9C0-0x0000000184C0EB00
	// [XID] // 0x0000000189AB5C40-0x0000000189AB5C60
	private ulong GetSceneBornPosStreamingConfigFilePathHash(uint sceneId, bool isRoom, Vector2 blockPos) => default; // 0x0000000184C08630-0x0000000184C08870
	// [XID] // 0x0000000189ABD690-0x0000000189ABD6B0
	private void TryLoadTarBlockPosConfig(uint sceneId, bool isRoom, Vector2 pos, bool async) {} // 0x0000000184C09A70-0x0000000184C09F60
	// [XID] // 0x0000000189AC5130-0x0000000189AC5150
	private void TryLoadTarSceneAllConfig(uint sceneId, bool isRoom) {} // 0x0000000184C0ED20-0x0000000184C0F160
	private void GenerateLevelDefaultMetaDatas<T>(uint sceneId, bool isRoomType, IEnumerable<T> dataSourceList, IDataAdapter<T> adapter) {}
	// [XID] // 0x0000000189ACC6A0-0x0000000189ACC6C0
	private void TryLoadTarPosConfig(uint sceneId, bool isRoom, Vector3 pos, bool async) {} // 0x0000000184C0F830-0x0000000184C0FB50
	// [XID] // 0x0000000189AD4390-0x0000000189AD43B0
	private static ConfigLoadAndSerializePattern GetNpcBornPosConfig(Action onLoadFinish) => default; // 0x0000000184C0C540-0x0000000184C0C820
	// [XID] // 0x0000000189ADBD60-0x0000000189ADBD80
	private static object LevelNpcBornPosConfigSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFF130 */) => default; // 0x0000000184C09460-0x0000000184C09570
	// [XID] // 0x0000000189AE36B0-0x0000000189AE36D0
	private static object LevelNpcBornPosConfigSerializeJson(JSONNode node) => default; // 0x0000000184C091C0-0x0000000184C092C0
	// [XID] // 0x0000000189AEAFD0-0x0000000189AEAFF0
	private static void OnNpcBornConfigLoadFinish(object obj, ulong path) {} // 0x0000000184C0B920-0x0000000184C0BC20
	// [XID] // 0x0000000189AF28E0-0x0000000189AF2900
	private void GenerateLevelNpcBornInfoByConfig(uint sceneId, bool isRoomType, IEnumerable<ConfigNpcBornPos> dataSourceList) {} // 0x0000000184C0F5F0-0x0000000184C0F740
	// [XID] // 0x0000000189AFA200-0x0000000189AFA220
	private void ClearLevelNpcBornInfo(uint sceneId, bool isRoomType) {} // 0x0000000184C05DB0-0x0000000184C05EF0
	private void GenerateLevelNpcBornInfo<T>(uint sceneId, bool isRoomType, IEnumerable<T> dataSourceList, IDataAdapter<T> adapter, bool isInit = true /* Metadata: 0x00AFF134 */) {}
	private TCommand AddCommand<TCommand>()
		where TCommand : class, ICacheCommand, new() => default;
	// [XID] // 0x0000000189B01780-0x0000000189B017A0
	private void ClearCommandPool() {} // 0x0000000184C0C820-0x0000000184C0CE70
	// [XID] // 0x0000000189B08CD0-0x0000000189B08CF0
	private void DestroyCommandPool() {} // 0x0000000184C0E620-0x0000000184C0E9C0
	// [XID] // 0x0000000189B107B0-0x0000000189B107D0
	public void ThreadCollectWork() {} // 0x0000000184C092C0-0x0000000184C09460
	// [XID] // 0x0000000189B178A0-0x0000000189B178C0
	public void ThreadFlushWork() {} // 0x0000000184C0AF40-0x0000000184C0B010
	// [XID] // 0x0000000189B1F1A0-0x0000000189B1F1C0
	public void ThreadTickWork() {} // 0x0000000184C09570-0x0000000184C09640
	// [XID] // 0x0000000189B26A30-0x0000000189B26A50
	private void HandleCachedWorkThreadCommands() {} // 0x0000000184C10830-0x0000000184C10A50
	// [XID] // 0x0000000189B2DC00-0x0000000189B2DC20
	private void HandleCachedMainThreadCommands() {} // 0x0000000184C0EB00-0x0000000184C0ED20
}

