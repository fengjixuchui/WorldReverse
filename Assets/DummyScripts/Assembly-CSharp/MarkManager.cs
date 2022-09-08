/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using UniRx;
using UnityEngine;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MarkManager : InLevelManager, INotifyInterface // TypeDefIndex: 20965
{
	// Fields
	private Dictionary<uint, List<LCBaseMarkable>> _lcMarkableDic; // 0x10
	private ConfigMapGlobal _configMapGlobal; // 0x18
	private List<uint> _sceneScriptDataHandles; // 0x20
	private Dictionary<uint, SceneScriptData> _levelDataDic; // 0x28
	private SceneScriptData _levelData; // 0x30
	private MapScriptData _mapData; // 0x38
	private ConfigLevelLayout _levelLayoutConfig; // 0x40
	private ConfigLevelArea _currLevelArea; // 0x48
	private ConfigWorldAreaLayout _worldAreaLayoutConfig; // 0x50
	private ConfigWorldAreaLayout _fogAreaLayoutConfig; // 0x58
	private Rect _levelRect; // 0x60
	private Dictionary<Tuple<MarkType, uint>, LCBaseMarkable> _currTracingEntity; // 0x70
	private List<GeneralMarkID> _dirtyMarks; // 0x78
	private List<GeneralMarkID> _movedMarkIDs; // 0x80
	private uint _customMarkID; // 0x88
	public const int MAX_CUSTOME_MARK_COUNT = 99; // Metadata: 0x00AFE7BB
	private uint _sceneID; // 0x8C
	private List<uint> _extraSceneIDs; // 0x90
	private Dictionary<uint, SceneMarks> _sceneID2sceneMarks; // 0x98
	private HashSet<uint> keysToDelete; // 0xB0
	private Dictionary<uint, SimpleFixedBitStack> _curBanCompanionMarks; // 0xB8
	private List<uint> _tempDeleteKeyList; // 0xC0
	private Dictionary<uint, SimpleFixedBitStack> _curCompanionMarkShowEffect; // 0xC8
	private Dictionary<uint, MarkIconType> _curCompanionMarkIconType; // 0xD0
	private List<uint> _markIDBuffer; // 0xD8
	private Dictionary<uint, LCRadarHint> _radarHintMarkEntity; // 0xE0
	private Dictionary<uint, LCNearestRadarHint> _loadBalanceHintMarks; // 0xE8
	private Dictionary<uint, GatherAreaType> _hintGatherZoneMap; // 0xF0
	private Dictionary<RadarHintType, NearestRadarHintItrData> _radarHintItrData; // 0xF8
	private Dictionary<RadarHintType, bool> _radarHintEnableMap; // 0x100
	private Dictionary<GatherAreaType, bool> _areaTypeEnableMap; // 0x108
	private int _lastHintMarkItrIndex; // 0x110
	private const int HINT_ITR_PER_FRAME = 5; // Metadata: 0x00AFE7BF
	private Dictionary<GatherAreaType, string> _areaTypeStringMapCache; // 0x118
	private Dictionary<NpcTrackingKey, MHYSortedList<NpcBaseTrackingData, bool>> _curNpcTrakingListDic; // 0x120
	private Dictionary<uint, NpcQuestTrackingData> _curNpcQuestTrackingDic; // 0x128
	private Dictionary<Tuple<uint, uint>, NpcTalkTrackingData> _curNpcTalkTrackingDic; // 0x130
	private uint _curTalkMarkId; // 0x138
	private Stack<VCMarkBillboardPlugin> _cachedMarkBillboards; // 0x140
	private Dictionary<Tuple<MarkType, uint>, VCMarkBillboardPlugin> _currMarkBillboards; // 0x148
	private Dictionary<Tuple<MarkType, uint>, VCMarkBillboardPlugin> _visibleBillboardsDicTemp; // 0x150
	private List<uint> _trackingDailyTaskIDList; // 0x158
	private NavigationType _curNavigationType; // 0x160
	private uint _curNavigationID; // 0x164
	private Dictionary<uint, GuidePointData> _guidePoints; // 0x168
	private Dictionary<uint, GuidePointData> _taskGuidePoint; // 0x170
	private MarkType _navigatedMarkType; // 0x178
	private uint _navigatedPathedMarkID; // 0x17C
	private List<uint> _navigatedMarkIDList; // 0x180
	private List<TrackingGroup> _navigatedMarkGroupList; // 0x188
	private Vector3 _navigatedPathedPosition; // 0x190
	private LevelSceneGuidePathPlugin _guidePathPlugin; // 0x1A0
	private BaseEntity _teamEntity; // 0x1A8
	private const float CHECK_GAP = 2f; // Metadata: 0x00AFE7C3
	private float _nextAreaCheckTime; // 0x1B0
	private float CHANGE_CD; // 0x1B4
	private int _currAreaIndex; // 0x1B8
	private int _currSubAreaIndex; // 0x1BC
	private float _resendCheckPoint; // 0x1C8
	private const float RESEND_CHECK_GAP = 3f; // Metadata: 0x00AFE7C7
	private bool _needResendCheck; // 0x1CC
	private uint _lastAreaLevel; // 0x1D0
	private Dictionary<uint, uint> _currAreaLevel; // 0x1D8

	// Properties
	private static string CONFIG_MAP_GLOBAL_PATH { /* [XID] */ /* 0x0000000189B7E500-0x0000000189B7E520 */ get => default; } // 0x0000000181422A20-0x0000000181422AC0 
	public ConfigMapGlobal configMapGlobal { /* [XID] */ /* 0x0000000189B860F0-0x0000000189B86110 */ get => default; } // 0x0000000181427B80-0x0000000181427D80 
	public float miniMapUIRadius { /* [XID] */ /* 0x0000000189B8D190-0x0000000189B8D1B0 */ get => default; } // 0x0000000181422130-0x00000001814221F0 
	public float miniMapSightRadius { /* [XID] */ /* 0x0000000189B94950-0x0000000189B94970 */ get => default; } // 0x0000000181420680-0x0000000181420740 
	private float levelMapCustomMarkCancelRadius { /* [XID] */ /* 0x0000000189B9BFE0-0x0000000189B9C000 */ get => default; } // 0x000000018142FF80-0x0000000181430040 
	public ConfigWorldAreaLayout worldAreaLayoutConfig { /* [XID] */ /* 0x0000000189BA3750-0x0000000189BA3770 */ get => default; } // 0x0000000181420740-0x0000000181420800 
	public ConfigWorldAreaLayout fogAreaLayoutConfig { /* [XID] */ /* 0x0000000189BAAB20-0x0000000189BAAB40 */ get => default; } // 0x000000018142FEC0-0x000000018142FF80 
	public SceneScriptData levelData { /* [XID] */ /* 0x0000000189BB2090-0x0000000189BB20B0 */ get => default; } // 0x0000000181417AC0-0x0000000181417B60 
	public Rect levelRect { /* [XID] */ /* 0x0000000189BB9480-0x0000000189BB94A0 */ get => default; } // 0x000000018141C220-0x000000018141C2F0 
	private static string WORLD_AREA_CFG_PATH { /* [XID] */ /* 0x0000000189BC12C0-0x0000000189BC12E0 */ get => default; } // 0x0000000181419A80-0x0000000181419B20 
	private static string FOG_AREA_CFG_PATH { /* [XID] */ /* 0x0000000189BC8B00-0x0000000189BC8B20 */ get => default; } // 0x000000018141BA60-0x000000018141BB00 
	public uint curTracingBossID { /* [XID] */ /* 0x0000000189BD0290-0x0000000189BD02D0 */ get; /* [XID] */ /* 0x0000000189BDAAF0-0x0000000189BDAB30 */ set; } // 0x0000000181428990-0x00000001814289F0 0x0000000181431BF0-0x0000000181431C60
	public uint curTracingCustomMarkID { /* [XID] */ /* 0x00000001895EA860-0x00000001895EA8A0 */ get; /* [XID] */ /* 0x00000001895F4DE0-0x00000001895F4E20 */ set; } // 0x0000000181429AE0-0x0000000181429B40 0x000000018142A850-0x000000018142A8C0
	public MarkType curTracingCustomMarkType { /* [XID] */ /* 0x00000001895FF430-0x00000001895FF470 */ get; /* [XID] */ /* 0x0000000189609E90-0x0000000189609ED0 */ set; } // 0x0000000181428C40-0x0000000181428CA0 0x000000018141EBB0-0x000000018141EC20
	public uint sceneID { /* [XID] */ /* 0x00000001896943B0-0x00000001896943D0 */ get => default; /* [XID] */ /* 0x000000018968C880-0x000000018968C8A0 */ private set {} } // 0x00000001814224A0-0x0000000181422540 0x000000018141B4D0-0x000000018141BA60
	public List<uint> trackingDailyTaskIDList { /* [XID] */ /* 0x0000000189A145A0-0x0000000189A145C0 */ get => default; } // 0x0000000181428B90-0x0000000181428C40 
	public uint curNavigationID { /* [XID] */ /* 0x0000000189AA3C80-0x0000000189AA3CA0 */ get => default; } // 0x000000018142E590-0x000000018142E630 
	public NavigationType curNavigationType { /* [XID] */ /* 0x0000000189AAB210-0x0000000189AAB230 */ get => default; } // 0x000000018142D870-0x000000018142D910 
	public Dictionary<uint, GuidePointData> guidePoints { /* [XID] */ /* 0x0000000189B220D0-0x0000000189B220F0 */ get => default; } // 0x000000018142D7C0-0x000000018142D870 
	public List<uint> curNavigatedMarkIDList { /* [XID] */ /* 0x0000000189B4ECF0-0x0000000189B4ED10 */ get => default; } // 0x000000018141D8E0-0x000000018141D990 
	public List<TrackingGroup> curNavigatedMarkGroupList { /* [XID] */ /* 0x0000000189B56620-0x0000000189B56640 */ get => default; } // 0x0000000181423C40-0x0000000181423CF0 
	public LevelSceneGuidePathPlugin guidePathPlugin { /* [XID] */ /* 0x0000000189B5DE20-0x0000000189B5DE40 */ get => default; } // 0x0000000181430040-0x0000000181430170 
	private Vector3? localAvatarPosition { /* [XID] */ /* 0x0000000189BAF000-0x0000000189BAF020 */ get => default; } // 0x0000000181419470-0x0000000181419600 
	public int currSubAreaIndex { /* [XID] */ /* 0x0000000189AB51D0-0x0000000189AB51F0 */ get => default; } // 0x0000000181417B60-0x0000000181417C00 
	public WorldAreaConfig currSubArea { /* [XID] */ /* 0x0000000189BBDD40-0x0000000189BBDD80 */ get; /* [XID] */ /* 0x0000000189BC8AC0-0x0000000189BC8B00 */ private set; } // 0x0000000181417480-0x00000001814174E0 0x0000000181419FB0-0x000000018141A020
	public uint currAreaLevel { /* [XID] */ /* 0x000000018960CD60-0x000000018960CD80 */ get => default; } // 0x000000018141BEE0-0x000000018141C090 
	public uint currLevelAreaID { /* [XID] */ /* 0x000000018962AA60-0x000000018962AA80 */ get => default; } // 0x000000018141E420-0x000000018141E4D0 

	// Nested types
	public struct GeneralMarkID : IEquatable<GeneralMarkID> // TypeDefIndex: 20966
	{
		// Fields
		public uint sceneID; // 0x00
		public MarkType markType; // 0x04
		public uint markID; // 0x08
		public readonly uint innerID; // 0x0C
		private static uint _nextInnerID; // 0x00

		// Constructors
		public GeneralMarkID(uint sceneID, MarkType markType, uint markID) {
			this.sceneID = default;
			this.markType = default;
			this.markID = default;
			innerID = default;
		} // 0x0000000183291C50-0x0000000183291C60
		static GeneralMarkID() {
			_nextInnerID = default;
		} // 0x0000000183291B20-0x0000000183291C50

		// Methods
		// [XID] // 0x00000001896321A0-0x00000001896321C0
		public override int GetHashCode() => default; // 0x0000000183291A50-0x0000000183291A60
		// [XID] // 0x0000000189639C50-0x0000000189639C70
		public bool Equals(GeneralMarkID other) => default; // 0x0000000183291980-0x0000000183291A50
		// [XID] // 0x0000000189641180-0x00000001896411A0
		public static void ResetInnerID() {} // 0x0000000183291A60-0x0000000183291B20
	}

	public class NearestRadarHintItrData // TypeDefIndex: 20967
	{
		// Fields
		public RadarHintType hintType; // 0x10
		public LCNearestRadarHint nearestHintMark; // 0x18
		public LCNearestRadarHint itrHintMark; // 0x20
		public float nearestDistSqrt; // 0x28

		// Constructors
		public NearestRadarHintItrData() {} // Dummy constructor
		public NearestRadarHintItrData(RadarHintType hintType) {} // 0x0000000183291780-0x00000001832918A0

		// Methods
		// [XID] // 0x0000000189648AC0-0x0000000189648AE0
		public void NewHintMarkIteration() {} // 0x00000001832916D0-0x0000000183291780
	}

	private class NpcTrackingKey // TypeDefIndex: 20968
	{
		// Fields
		public TrackingGroup group; // 0x10
		public BaseEntity tarEntity; // 0x20
		public Vector3 curPos; // 0x28

		// Properties
		public uint configID { /* [XID] */ /* 0x0000000189650160-0x0000000189650180 */ get => default; } // 0x000000018326D780-0x000000018326D820 
		public uint questMainID { /* [XID] */ /* 0x0000000189657A50-0x0000000189657A70 */ get => default; } // 0x000000018326D9C0-0x000000018326DA60 

		// Constructors
		public NpcTrackingKey() {} // 0x000000018326DCD0-0x000000018326DD30

		// Methods
		// [XID] // 0x000000018965F180-0x000000018965F1A0
		public void Init(uint configID, uint questMainID) {} // 0x000000018326DA60-0x000000018326DBA0
		// [XID] // 0x0000000189666930-0x0000000189666950
		public override bool Equals(object obj) => default; // 0x000000018326D890-0x000000018326D9C0
		// [XID] // 0x000000018966E030-0x000000018966E050
		public override int GetHashCode() => default; // 0x000000018326DBA0-0x000000018326DC50
	}

	private class NpcTrackingDataComparer : IComparer<NpcBaseTrackingData> // TypeDefIndex: 20969
	{
		// Fields
		private static NpcTrackingDataComparer _instance; // 0x00

		// Properties
		public static NpcTrackingDataComparer instance { /* [XID] */ /* 0x000000018967D740-0x000000018967D760 */ get => default; } // 0x0000000183270780-0x00000001832708C0 

		// Constructors
		public NpcTrackingDataComparer() {} // 0x0000000183270920-0x0000000183270980
		static NpcTrackingDataComparer() {} // 0x00000001832708C0-0x0000000183270920

		// Methods
		// [XID] // 0x0000000189675EA0-0x0000000189675EC0
		public int Compare(NpcBaseTrackingData x, NpcBaseTrackingData y) => default; // 0x0000000183270650-0x0000000183270780
	}

	public enum NpcTrackingState // TypeDefIndex: 20970
	{
		None = 0,
		HaveEntity = 1,
		NoEntity = 2
	}

	public enum MarkTrackingState // TypeDefIndex: 20971
	{
		None = 0,
		TrackingHide = 1,
		TrackingShow = 2
	}

	private abstract class NpcBaseTrackingData // TypeDefIndex: 20972
	{
		// Fields
		protected static uint _curUniqID; // 0x00
		public bool markLCAdded; // 0x1C
		public NpcTrackingState curNpcTrackingState; // 0x20
		public MarkTrackingState curMarkTrackingState; // 0x24
		public int priority; // 0x28

		// Properties
		public virtual bool careNpcHide { /* [XID] */ /* 0x000000018969A170-0x000000018969A190 */ get; } // 0x000000018326E950-0x000000018326E9F0 
		public NpcTrackingKey key { /* [XID] */ /* 0x00000001896A19C0-0x00000001896A1A00 */ get; protected set; } // 0x000000018326E8F0-0x000000018326E950 0x000000018326EB90-0x000000018326EBF0
		public uint uniqID { /* [XID] */ /* 0x00000001896B2DB0-0x00000001896B2DF0 */ get; protected set; } // 0x000000018326EB30-0x000000018326EB90 0x000000018326E890-0x000000018326E8F0

		// Constructors
		protected NpcBaseTrackingData() {} // Dummy constructor
		public NpcBaseTrackingData(uint configID, uint questMainID) {} // 0x000000018326EC50-0x000000018326EE10
		static NpcBaseTrackingData() {} // 0x000000018326EBF0-0x000000018326EC50

		// Methods
		// [XID] // 0x00000001896C4980-0x00000001896C49A0
		protected uint GetNextUniqID() => default; // 0x000000018326E9F0-0x000000018326EB30
		public abstract void AddMarkLC(MarkManager mgr, BaseEntity tarEntity);
		public abstract void RemoveMarkLC(MarkManager mgr);
		public abstract void AddTracking(MarkManager mgr, BaseEntity tarEntity, Vector3 pos, TrackingGroup groupId);
		public abstract void RemoveTracking(MarkManager mgr);
		public abstract void UpdateMark(MarkManager mgr, BaseEntity tarEntity, Vector3 pos, bool needShow, TrackingGroup groupId);
		public abstract void UpdateMarkPosition(MarkManager mgr, Vector3 pos);
	}

	private class NpcQuestTrackingData : NpcBaseTrackingData // TypeDefIndex: 20973
	{
		// Fields
		public uint questSubID; // 0x30
		public MarkIconType iconType; // 0x34
		public ShowQuestGuideType showGuide; // 0x38
		public QuestExcelConfigProxy questConfig; // 0x40

		// Constructors
		public NpcQuestTrackingData() {} // Dummy constructor
		public NpcQuestTrackingData(uint configID, uint questSubID, uint questMainID, ShowQuestGuideType showGuide, MarkIconType iconType, QuestExcelConfigProxy questConfig) {} // 0x000000018326E7C0-0x000000018326E890

		// Methods
		// [XID] // 0x00000001896CBEF0-0x00000001896CBF10
		public override void AddMarkLC(MarkManager mgr, BaseEntity tarEntity) {} // 0x000000018326E6D0-0x000000018326E7C0
		// [XID] // 0x00000001896D3240-0x00000001896D3260
		public override void RemoveMarkLC(MarkManager mgr) {} // 0x000000018326E2E0-0x000000018326E3B0
		// [XID] // 0x00000001896DADC0-0x00000001896DADE0
		public override void AddTracking(MarkManager mgr, BaseEntity tarEntity, Vector3 pos, TrackingGroup groupId) {} // 0x000000018326E3B0-0x000000018326E6D0
		// [XID] // 0x00000001896E2560-0x00000001896E2580
		public override void RemoveTracking(MarkManager mgr) {} // 0x000000018326E130-0x000000018326E2E0
		// [XID] // 0x00000001896E9A40-0x00000001896E9A60
		public override void UpdateMark(MarkManager mgr, BaseEntity tracingEntity, Vector3 pos, bool needShow, TrackingGroup groupId) {} // 0x000000018326DEB0-0x000000018326E130
		// [XID] // 0x00000001896F0C00-0x00000001896F0C20
		public override void UpdateMarkPosition(MarkManager mgr, Vector3 pos) {} // 0x000000018326DD90-0x000000018326DEB0
	}

	private class NpcTalkTrackingData : NpcBaseTrackingData // TypeDefIndex: 20974
	{
		// Fields
		public MarkIconType iconType; // 0x30
		public uint markId; // 0x34

		// Properties
		public override bool careNpcHide { /* [XID] */ /* 0x00000001896F8460-0x00000001896F8480 */ get => default; } // 0x0000000183290FD0-0x0000000183291070 

		// Constructors
		public NpcTalkTrackingData() {} // Dummy constructor
		public NpcTalkTrackingData(uint configID, uint questMainID, MarkIconType iconType, uint markId) {} // 0x0000000183291510-0x00000001832915D0

		// Methods
		// [XID] // 0x00000001896FFDC0-0x00000001896FFDE0
		public override void AddMarkLC(MarkManager mgr, BaseEntity tarEntity) {} // 0x0000000183291420-0x0000000183291510
		// [XID] // 0x0000000189707500-0x0000000189707520
		public override void RemoveMarkLC(MarkManager mgr) {} // 0x0000000183291150-0x0000000183291220
		// [XID] // 0x000000018970EDC0-0x000000018970EDE0
		public override void AddTracking(MarkManager mgr, BaseEntity tarEntity, Vector3 pos, TrackingGroup groupId) {} // 0x0000000183291290-0x0000000183291420
		// [XID] // 0x0000000189716200-0x0000000189716220
		public override void RemoveTracking(MarkManager mgr) {} // 0x0000000183291070-0x0000000183291150
		// [XID] // 0x000000018971DC40-0x000000018971DC60
		public override void UpdateMark(MarkManager mgr, BaseEntity tracingEntity, Vector3 pos, bool needShow, TrackingGroup groupId) {} // 0x0000000183290DB0-0x0000000183290FD0
		// [XID] // 0x0000000189725120-0x0000000189725140
		public override void UpdateMarkPosition(MarkManager mgr, Vector3 pos) {} // 0x0000000183290C90-0x0000000183290DB0
	}

	public enum NavigationType // TypeDefIndex: 20975
	{
		NONE = 0,
		TASK = 1,
		QUEST = 2
	}

	// Constructors
	public MarkManager() {} // 0x0000000181432640-0x0000000181432C70

	// Methods
	// [XID] // 0x00000001896142B0-0x00000001896142D0
	public override void Init() {} // 0x0000000181427460-0x00000001814277C0
	// [XID] // 0x000000018961BD10-0x000000018961BD30
	private void InitActivityMarks() {} // 0x0000000181426CF0-0x0000000181426E00
	// [XID] // 0x0000000189623240-0x0000000189623260
	private ConfigWorldAreaLayout LoadWorldAreaLayoutConfig(string cfgPath) => default; // 0x000000018141F900-0x000000018141FD00
	// [XID] // 0x000000018962AA80-0x000000018962AAA0
	private void InitWorldAreaLayoutConfig(string cfgPath) {} // 0x0000000181426AE0-0x0000000181426BA0
	// [XID] // 0x00000001896321C0-0x00000001896321E0
	private void DestroyWorldAreaLayoutConfig() {} // 0x00000001814232A0-0x0000000181423340
	// [XID] // 0x0000000189639C70-0x0000000189639C90
	public void RequestAllCustomMark() {} // 0x000000018142D420-0x000000018142D550
	// [XID] // 0x00000001896411A0-0x00000001896411C0
	public void FetchAllPacketAnchor() {} // 0x0000000181425050-0x00000001814250F0
	// [XID] // 0x0000000189648AE0-0x0000000189648B00
	public void RequestAddCustomMark(uint sceneID, string name, Vector pos, MapMarkPointType type, MapMarkFromType reasonType, uint configID) {} // 0x0000000181426E00-0x0000000181427040
	// [XID] // 0x0000000189650180-0x00000001896501A0
	public void RequestRemoveCustomMark(uint sceneID, uint identifier) {} // 0x000000018142A640-0x000000018142A850
	// [XID] // 0x0000000189657A70-0x0000000189657A90
	public void RequestModCustomMark(uint sceneID, uint oldIdentifier, string name, Vector pos, MapMarkPointType type) {} // 0x00000001814221F0-0x00000001814224A0
	// [XID] // 0x000000018965F1A0-0x000000018965F1C0
	public void RefreshCustomMarksFromNetwork(RepeatedMessageField<MapMarkPoint> markList) {} // 0x000000018142D2C0-0x000000018142D370
	// [XID] // 0x0000000189666950-0x0000000189666970
	public void RefreshPacketAnchor() {} // 0x000000018141CF40-0x000000018141D8E0
	// [XID] // 0x000000018966E050-0x000000018966E070
	private bool CompareMarkPoint(MapMarkPoint point1, MapMarkPoint point2) => default; // 0x00000001814236F0-0x0000000181423980
	// [XID] // 0x0000000189675EC0-0x0000000189675EE0
	private void RefreshCustomMark(RepeatedMessageField<MapMarkPoint> markList) {} // 0x000000018141EF20-0x000000018141F900
	// [XID] // 0x000000018967D760-0x000000018967D780
	public override void Destroy() {} // 0x000000018141D990-0x000000018141DD90
	// [XID] // 0x0000000189684D60-0x0000000189684D80
	public override void Tick() {} // 0x0000000181432310-0x0000000181432640
	// [XID] // 0x000000018969B950-0x000000018969B970
	public void RegisterSceneID(uint sceneID) {} // 0x000000018141E320-0x000000018141E420
	// [XID] // 0x00000001896A3040-0x00000001896A3060
	private void LoadLevelData(uint sceneID) {} // 0x000000018141C620-0x000000018141C7D0
	// [XID] // 0x00000001896AA490-0x00000001896AA4B0
	public SceneScriptData GetLevelData(uint sceneID) => default; // 0x000000018141B3E0-0x000000018141B4D0
	// [XID] // 0x00000001896B1370-0x00000001896B1390
	public bool HasLCMarkable(LCBaseMarkable lcMarkable) => default; // 0x000000018142C4C0-0x000000018142C660
	// [XID] // 0x00000001896B8E30-0x00000001896B8E50
	public void UnRegisterLCMarkable(LCBaseMarkable lcMarkable) {} // 0x0000000181431A10-0x0000000181431BF0
	// [IDTag] // 0x00000001896C0150-0x00000001896C0190
	// [XID] // 0x00000001896C0150-0x00000001896C0190
	public void AddMark(uint sceneID, MarkType markType, uint markID, Vector3 position, MarkIconType iconType, bool deleteTrack = false /* Metadata: 0x00AFE792 */) {} // 0x0000000181420E00-0x0000000181421070
	// [IDTag] // 0x00000001896CA5F0-0x00000001896CA630
	// [XID] // 0x00000001896CA5F0-0x00000001896CA630
	public void AddMark(uint sceneID, MarkType markType, uint markID, Vector3 position, float radius, MarkIconType iconType) {} // 0x0000000181420B80-0x0000000181420E00
	// [XID] // 0x00000001896D4DA0-0x00000001896D4DC0
	public void AddAreaMark(uint sceneID, MarkType markType, uint markID, Vector3 position, MarkIconType iconType, bool showWhenAreaLocked) {} // 0x0000000181417E70-0x0000000181418190
	// [XID] // 0x00000001896DC3A0-0x00000001896DC3C0
	public void RefreshMarkOnAreaUnlocked(uint sceneID, uint areaID) {} // 0x000000018141C9A0-0x000000018141CD70
	// [IDTag] // 0x00000001896E3C10-0x00000001896E3C50
	// [XID] // 0x00000001896E3C10-0x00000001896E3C50
	public void AddCurrSceneMark(MarkType markType, uint markID, Vector3 position, MarkIconType iconType) {} // 0x00000001814250F0-0x0000000181425230
	// [IDTag] // 0x00000001896EDEF0-0x00000001896EDF30
	// [XID] // 0x00000001896EDEF0-0x00000001896EDF30
	public void AddCurrSceneMark(MarkIconType iconType, uint markID, Vector3 position) {} // 0x0000000181425230-0x0000000181425400
	// [XID] // 0x00000001896F8480-0x00000001896F84A0
	public void RemoveCurrSceneMark(MarkIconType iconType, uint markID) {} // 0x000000018141AE80-0x000000018141B010
	// [IDTag] // 0x00000001896FFDE0-0x00000001896FFE20
	// [XID] // 0x00000001896FFDE0-0x00000001896FFE20
	public void RemoveMark(uint sceneID, MarkType markType) {} // 0x0000000181425940-0x0000000181425BE0
	// [IDTag] // 0x000000018970A480-0x000000018970A4C0
	// [XID] // 0x000000018970A480-0x000000018970A4C0
	public void RemoveMark(uint sceneID, MarkType markType, uint markID) {} // 0x0000000181425790-0x0000000181425940
	// [XID] // 0x0000000189714970-0x0000000189714990
	public bool TryRemoveMark(uint sceneID, MarkType markType, uint markID) => default; // 0x0000000181421B60-0x0000000181421CE0
	// [IDTag] // 0x000000018971C3E0-0x000000018971C420
	// [XID] // 0x000000018971C3E0-0x000000018971C420
	public void RemoveMark(MarkType markType, uint markID) {} // 0x0000000181425400-0x0000000181425790
	// [IDTag] // 0x0000000189726A40-0x0000000189726A80
	// [XID] // 0x0000000189726A40-0x0000000189726A80
	public void RemoveMarkLC(MarkType markType, uint markID) {} // 0x00000001814293D0-0x0000000181429520
	// [IDTag] // 0x0000000189730F60-0x0000000189730FA0
	// [XID] // 0x0000000189730F60-0x0000000189730FA0
	private void RemoveMarkLC(LCBaseMarkable component, MarkType markType, uint markID) {} // 0x00000001814292E0-0x00000001814293D0
	// [XID] // 0x000000018973B6D0-0x000000018973B6F0
	private SceneMarks GetSceneMarks(uint sceneID) => default; // 0x0000000181426BA0-0x0000000181426CF0
	// [XID] // 0x0000000189743160-0x0000000189743180
	private SceneMarks TryGetSceneMarks(uint sceneID) => default; // 0x0000000181422920-0x0000000181422A20
	// [XID] // 0x000000018974ACE0-0x000000018974AD00
	public GeneralMarkData GetNavigatingMark(uint scene) => default; // 0x0000000181431E60-0x0000000181432310
	// [XID] // 0x00000001898078C0-0x00000001898078E0
	public Dictionary<uint, GeneralMarkData> GetMarkDic(uint sceneID, MarkType markType) => default; // 0x000000018141CD70-0x000000018141CE60
	// [XID] // 0x00000001899AE4D0-0x00000001899AE4F0
	public Dictionary<uint, GeneralMarkData> TryGetMarkDataDic(uint sceneID, MarkType markType) => default; // 0x000000018141B2F0-0x000000018141B3E0
	// [IDTag] // 0x0000000189761010-0x0000000189761050
	// [XID] // 0x0000000189761010-0x0000000189761050
	public bool TryGetMarkData(GeneralMarkID markID, out GeneralMarkData markData) {
		markData = default;
		return default;
	} // 0x000000018142F190-0x000000018142F280
	// [IDTag] // 0x000000018976B400-0x000000018976B440
	// [XID] // 0x000000018976B400-0x000000018976B440
	public bool TryGetMarkData(MarkType markType, uint markID, out GeneralMarkData markData) {
		markData = default;
		return default;
	} // 0x000000018142F090-0x000000018142F190
	// [IDTag] // 0x00000001897759A0-0x00000001897759E0
	// [XID] // 0x00000001897759A0-0x00000001897759E0
	public bool TryGetMarkData(uint sceneID, MarkType markType, uint markID, out GeneralMarkData markData) {
		markData = default;
		return default;
	} // 0x000000018142EF60-0x000000018142F090
	// [XID] // 0x0000000189780100-0x0000000189780120
	public void TrackMark(uint sceneID, MarkType markType, uint markID) {} // 0x0000000181417310-0x0000000181417480
	// [XID] // 0x00000001897879A0-0x00000001897879C0
	public void UpdateMark(uint sceneID, MarkType markType, uint markID) {} // 0x0000000181419350-0x0000000181419470
	// [XID] // 0x000000018978F040-0x000000018978F060
	public bool CancelTrackMark(uint sceneID, MarkType markType, uint markID) => default; // 0x0000000181427E60-0x00000001814280C0
	// [XID] // 0x0000000189796870-0x0000000189796890
	public bool IsTrackingMark(uint sceneID, MarkType markType, uint markID) => default; // 0x0000000181422AC0-0x0000000181422C10
	// [XID] // 0x000000018979E910-0x000000018979E930
	public bool AddCustomMark(uint sceneID, Vector3 levelMapPos, MapMarkPoint mapMarkPoint) => default; // 0x000000018142C780-0x000000018142CA40
	// [XID] // 0x00000001897A6040-0x00000001897A6060
	private MarkIconType GetMarkCustomIconType(MapMarkPointType type) => default; // 0x000000018142B0F0-0x000000018142B260
	// [XID] // 0x00000001897AD530-0x00000001897AD550
	public uint GetNextCustomMarkID(uint sceneID) => default; // 0x000000018141BB00-0x000000018141BC30
	// [XID] // 0x00000001897B5610-0x00000001897B5630
	public void ChangeCustomMarkIcon(uint sceneID, uint markID, MarkIconType iconType) {} // 0x000000018141A910-0x000000018141AAB0
	// [XID] // 0x00000001897BD250-0x00000001897BD270
	public int GetTotalCustomMarkCount(uint sceneID) => default; // 0x000000018142CDC0-0x000000018142CE90
	// [XID] // 0x00000001897C45C0-0x00000001897C45E0
	public void AddCompanionMark(uint sceneID, uint uid, int index) {} // 0x00000001814277C0-0x0000000181427B80
	// [IDTag] // 0x00000001897CBDB0-0x00000001897CBDF0
	// [XID] // 0x00000001897CBDB0-0x00000001897CBDF0
	public void BanCompanionMark(uint uid, bool isBan, int reason) {} // 0x000000018142E3D0-0x000000018142E590
	// [IDTag] // 0x00000001897D66A0-0x00000001897D66E0
	// [XID] // 0x00000001897D66A0-0x00000001897D66E0
	private bool BanCompanionMark(uint uid, int reason, SimpleFixedBitStack banValue, bool isBan) => default; // 0x000000018142E1A0-0x000000018142E3D0
	// [XID] // 0x00000001897E1020-0x00000001897E1040
	public void ClearBanCompanionMark(int reason) {} // 0x0000000181420800-0x0000000181420B80
	// [IDTag] // 0x00000001897E8750-0x00000001897E8790
	// [XID] // 0x00000001897E8750-0x00000001897E8790
	public void SetCompanionMarkEffectShow(uint uid, bool isShow, int reason) {} // 0x000000018141AAB0-0x000000018141AC70
	// [IDTag] // 0x00000001897F3530-0x00000001897F3570
	// [XID] // 0x00000001897F3530-0x00000001897F3570
	private bool SetCompanionMarkEffectShow(uint uid, int reason, SimpleFixedBitStack showValue, bool isShow) => default; // 0x000000018141AC70-0x000000018141AE80
	// [XID] // 0x00000001897FD8A0-0x00000001897FD8C0
	public void ClearCompanionMarkEffectShow(int reason) {} // 0x0000000181422540-0x00000001814228C0
	// [XID] // 0x00000001898050F0-0x0000000189805110
	public bool IsCompanionMarkShowEffect(uint uid) => default; // 0x000000018142D550-0x000000018142D650
	// [XID] // 0x000000018980C630-0x000000018980C650
	public void SetCompanionMarkIconType(uint uid, MarkIconType iconType) {} // 0x000000018141BD00-0x000000018141BEE0
	// [IDTag] // 0x0000000189813DA0-0x0000000189813DE0
	// [XID] // 0x0000000189813DA0-0x0000000189813DE0
	public void ClearCompanionMarkIconType(uint uid) {} // 0x000000018142B830-0x000000018142BA80
	// [IDTag] // 0x000000018981E910-0x000000018981E950
	// [XID] // 0x000000018981E910-0x000000018981E950
	public void ClearCompanionMarkIconType() {} // 0x000000018142B550-0x000000018142B830
	// [XID] // 0x0000000189828FC0-0x0000000189828FE0
	public void AddMonsterMark(uint entityID) {} // 0x0000000181419B20-0x0000000181419DB0
	// [XID] // 0x00000001898304F0-0x0000000189830510
	public void UpdateMonsterMarkPosition(uint entityID, Vector3 position) {} // 0x000000018142AEB0-0x000000018142B0F0
	// [XID] // 0x0000000189837B70-0x0000000189837B90
	public bool TryGetMarkLevelMapPosition(GeneralMarkID mark, out Vector2 levelMapPos, out float height) {
		levelMapPos = default;
		height = default;
		return default;
	} // 0x0000000181429000-0x00000001814291D0
	// [XID] // 0x000000018983F2F0-0x000000018983F310
	public Vector2 WorldPosToNormalizedLevelMapPos(Vector3 worldPos) => default; // 0x0000000181431550-0x0000000181431700
	// [XID] // 0x0000000189846970-0x0000000189846990
	public Vector2 NormalizeLevelMapPos(Vector2 position) => default; // 0x0000000181418FB0-0x0000000181419100
	// [XID] // 0x000000018984DEC0-0x000000018984DEE0
	public Vector2 DenormalizeLevelMapPos(Vector2 normalizedPosition) => default; // 0x0000000181424290-0x00000001814243C0
	// [IDTag] // 0x0000000189854F70-0x0000000189854FB0
	// [XID] // 0x0000000189854F70-0x0000000189854FB0
	public bool UpdateMarkPosition(MarkType markType, uint markID, Vector3 worldPosition) => default; // 0x0000000181418650-0x0000000181418770
	// [IDTag] // 0x000000018985F230-0x000000018985F270
	// [XID] // 0x000000018985F230-0x000000018985F270
	public bool UpdateMarkPosition(uint sceneId, MarkType markType, uint markID, Vector3 worldPosition) => default; // 0x0000000181418190-0x0000000181418650
	// [XID] // 0x0000000189869B40-0x0000000189869B60
	public bool UpdateMarkPositionAndRadius(uint sceneId, MarkType markType, uint markID, Vector3 worldPosition, float radius) => default; // 0x00000001814174E0-0x00000001814178C0
	// [XID] // 0x0000000189870EC0-0x0000000189870EE0
	public bool UpdateMarkRadius(MarkType markType, uint markID, float radius) => default; // 0x0000000181429B40-0x0000000181429EF0
	// [XID] // 0x0000000189878870-0x0000000189878890
	private void CheckCompanionMarks() {} // 0x0000000181420070-0x0000000181420680
	// [XID] // 0x000000018987FE20-0x000000018987FE40
	public void GotoCompanion(uint companionMarkID) {} // 0x00000001814261C0-0x00000001814266B0
	// [XID] // 0x0000000189887420-0x0000000189887440
	public uint AddPinMark(uint sceneID, MarkIconType iconType, Vector2 levelMapPos) => default; // 0x000000018142BA80-0x000000018142BD10
	// [XID] // 0x000000018988E5A0-0x000000018988E5C0
	public bool CanAddPinMark(uint sceneID, MarkIconType iconType) => default; // 0x000000018142BD10-0x000000018142BF60
	// [XID] // 0x00000001898166B0-0x00000001898166D0
	public void AddRadarHintMark(LCRadarHint lcMarkable) {} // 0x000000018142C2D0-0x000000018142C4C0
	// [XID] // 0x0000000189A793D0-0x0000000189A793F0
	public void RemoveRadarHintMark(uint markID) {} // 0x000000018142D9D0-0x000000018142DAE0
	// [XID] // 0x00000001898A4BA0-0x00000001898A4BC0
	public RadarHintExcelConfig GetRadarHintMarkConfig(uint radarHintMarkID) => default; // 0x0000000181428DD0-0x0000000181428EF0
	// [XID] // 0x00000001898AC060-0x00000001898AC080
	private void InitNearestRadarHint() {} // 0x000000018141E4D0-0x000000018141EAD0
	// [XID] // 0x00000001898B3780-0x00000001898B37A0
	private void InitWidgetMark() {} // 0x00000001814199A0-0x0000000181419A80
	// [XID] // 0x00000001898BB550-0x00000001898BB570
	private void InitRoutineMark() {} // 0x000000018141CE60-0x000000018141CF40
	// [XID] // 0x00000001898C2800-0x00000001898C2820
	private void InitHomeworldMark() {} // 0x00000001814311C0-0x00000001814312A0
	// [XID] // 0x00000001898CA240-0x00000001898CA260
	private void ClearNearestRadarHint() {} // 0x0000000181419600-0x0000000181419710
	// [XID] // 0x00000001898D1970-0x00000001898D1990
	public bool OnNotify(Notify ntf) => default; // 0x0000000181431020-0x00000001814311C0
	// [XID] // 0x00000001898D9170-0x00000001898D9190
	private void CheckRadarEnableType() {} // 0x0000000181423980-0x0000000181423C40
	// [XID] // 0x00000001898E0E10-0x00000001898E0E30
	public GatherAreaType GetGadgetGatherArea(uint gadgetID) => default; // 0x0000000181423CF0-0x0000000181423DE0
	// [XID] // 0x00000001898E8900-0x00000001898E8920
	private void SetRadarHintEnable(RadarHintType type, bool enabled) {} // 0x00000001814266B0-0x0000000181426900
	// [XID] // 0x00000001898F0020-0x00000001898F0040
	public void SetGatherAreaEnable(GatherAreaType type, bool enable, bool updateRadar = true /* Metadata: 0x00AFE793 */) {} // 0x0000000181426900-0x0000000181426A30
	// [XID] // 0x00000001898F78F0-0x00000001898F7910
	private void UpdateRadarByArea() {} // 0x0000000181423340-0x00000001814234B0
	// [XID] // 0x00000001898FEF90-0x00000001898FEFB0
	private void NewHintMarkIteration() {} // 0x0000000181418770-0x0000000181418930
	// [XID] // 0x0000000189BBD3F0-0x0000000189BBD410
	public void AddNearestRadarHintMark(RadarHintType hintType, LCNearestRadarHint lcMarkable) {} // 0x0000000181429520-0x0000000181429610
	// [XID] // 0x000000018990E250-0x000000018990E270
	public void RemoveNearestRadarHintMark(RadarHintType hintType, uint markID) {} // 0x000000018141B010-0x000000018141B1B0
	// [XID] // 0x00000001899159C0-0x00000001899159E0
	public void UpdateUnqiueRadarHintMark() {} // 0x0000000181424550-0x0000000181424FD0
	// [XID] // 0x000000018991D350-0x000000018991D370
	public bool IsCurTracingEntity(uint entityId) => default; // 0x0000000181421070-0x0000000181421270
	// [XID] // 0x0000000189924CE0-0x0000000189924D00
	private void AddNpcTrackingImpl(NpcBaseTrackingData curData) {} // 0x0000000181427040-0x00000001814272A0
	// [XID] // 0x000000018992C1E0-0x000000018992C200
	private void RemoveNpcTrackingImpl(NpcBaseTrackingData curData) {} // 0x000000018142DC90-0x000000018142DEA0
	// [XID] // 0x0000000189933660-0x0000000189933680
	private TrackingGroup GetQuestTrackingGroup(uint subQuestId) => default; // 0x0000000181417970-0x0000000181417AC0
	// [XID] // 0x000000018993B310-0x000000018993B330
	private void UpdateAllNpcTracking() {} // 0x000000018141C7D0-0x000000018141C9A0
	// [XID] // 0x0000000189942400-0x0000000189942420
	private void UpdateNpcTracking(NpcTrackingKey key, MHYSortedList<NpcBaseTrackingData, bool> list) {} // 0x0000000181418930-0x0000000181418FB0
	// [XID] // 0x0000000189949D20-0x0000000189949D40
	public void AddMarkLC(BaseEntity tracingEntity, MarkType type, uint markId) {} // 0x0000000181431C60-0x0000000181431E60
	// [XID] // 0x0000000189951900-0x0000000189951920
	public void RefreshAllQuestTracingMarks() {} // 0x0000000181421590-0x0000000181421B60
	// [XID] // 0x0000000189958E30-0x0000000189958E50
	public void AddQuestGuide(uint sceneId, uint subQuestID, Vector3 location, ref QuestExcelConfigProxy cfg, MarkIconType iconType = MarkIconType.MarkQuest /* Metadata: 0x00AFE794 */, Vector3? locationOffset = default, bool useDefaultIcon = false /* Metadata: 0x00AFE798 */, bool ignoreShowGuideType = false /* Metadata: 0x00AFE799 */, TrackingGroup markGroup = default) {} // 0x00000001814312A0-0x0000000181431550
	// [XID] // 0x0000000189960500-0x0000000189960520
	private void AddQuestBillboard(uint subQuestID, Vector3 location, ref QuestExcelConfigProxy cfg, Vector3? locationOffset = default, bool useDefaultIcon = false /* Metadata: 0x00AFE79A */, bool ignoreShowGuideType = false /* Metadata: 0x00AFE79B */, TrackingGroup markGroup = default) {} // 0x000000018142A2E0-0x000000018142A640
	// [XID] // 0x0000000189967EC0-0x0000000189967EE0
	public void AddQuestArea(uint sceneId, uint subQuestID, Vector3 location, float radius, MarkIconType iconType) {} // 0x000000018142EB60-0x000000018142EDA0
	// [XID] // 0x000000018996F120-0x000000018996F140
	private int GetNpcQuestTrackPriority(ref MainQuestExcelConfigProxy mainConfig, ref QuestExcelConfigProxy subConfig) => default; // 0x0000000181417C00-0x0000000181417DA0
	// [XID] // 0x0000000189976C70-0x0000000189976C90
	public void AddQuestNpcTracking(uint subQuestID, uint npcConfigID, uint questMainID, ref MainQuestExcelConfigProxy mainConfig, ref QuestExcelConfigProxy subConfig, MarkIconType iconType = MarkIconType.MarkQuest /* Metadata: 0x00AFE79C */) {} // 0x0000000181421CE0-0x0000000181421EF0
	// [XID] // 0x000000018997E0C0-0x000000018997E0E0
	public void RemoveQuestNpcTracking(uint subQuestID) {} // 0x0000000181428EF0-0x0000000181429000
	// [XID] // 0x0000000189985BD0-0x0000000189985BF0
	private MarkIconType ChangeIconTypeFromAreaToPoint(MarkIconType tarType) => default; // 0x000000018141FD00-0x000000018141FDD0
	// [XID] // 0x000000018998D840-0x000000018998D860
	private void UpdateQuestTracingMark(uint sceneID, uint subQuestID, Vector3 worldPosition, MarkIconType iconType, BaseEntity entity = null, bool hideOnMove = false /* Metadata: 0x00AFE7A0 */, Vector3? positionOffset = default, bool hideIcon = false /* Metadata: 0x00AFE7A1 */, float radius = 0f /* Metadata: 0x00AFE7A2 */, TrackingGroup groupId = default) {} // 0x0000000181430170-0x00000001814308E0
	// [XID] // 0x00000001899952D0-0x00000001899952F0
	private int GetNpcTalkTrackPriority(NpcTalkTrackingData data) => default; // 0x000000018142C040-0x000000018142C120
	// [XID] // 0x000000018999CD90-0x000000018999CDB0
	private uint GetNpcTalkTrackMarkId() => default; // 0x0000000181426A30-0x0000000181426AE0
	// [XID] // 0x00000001899A4630-0x00000001899A4650
	public void AddNpcTalkTracking(uint npcConfigID, uint questMainID) {} // 0x000000018142C120-0x000000018142C2D0
	// [XID] // 0x00000001899AC010-0x00000001899AC030
	public void RemoveNpcTalkTracking(uint npcConfigID, uint questMainID) {} // 0x000000018142D650-0x000000018142D7C0
	// [XID] // 0x00000001899B3880-0x00000001899B38A0
	private void UpdateTalkTracingMark(uint sceneID, uint talkId, Vector3 worldPosition, MarkIconType iconType, BaseEntity entity = null, bool hideOnMove = false /* Metadata: 0x00AFE7A6 */, Vector3? positionOffset = default, bool hideIcon = false /* Metadata: 0x00AFE7A7 */, float radius = 0f /* Metadata: 0x00AFE7A8 */, TrackingGroup groupId = default) {} // 0x0000000181416FF0-0x0000000181417310
	// [XID] // 0x00000001899BACA0-0x00000001899BACC0
	private void AddNpcQuestMarkBillboard(uint questId, BaseEntity entity, string prefabName, ShowQuestGuideType showGuide = ShowQuestGuideType.QUEST_GUIDE_ITEM_ENABLE /* Metadata: 0x00AFE7AC */, TrackingGroup markGroup = default) {} // 0x00000001814280C0-0x0000000181428260
	// [XID] // 0x00000001899C26F0-0x00000001899C2710
	private void AddNpcTalkMarkBillboard(uint talkId, BaseEntity entity, string prefabName, TrackingGroup markGroup) {} // 0x0000000181423110-0x00000001814232A0
	// [XID] // 0x00000001899C9D00-0x00000001899C9D20
	private void AddNpcMarkBillboardImpl(MarkType markType, uint markId, VCMarkBillboardPlugin markBillboard) {} // 0x0000000181428CA0-0x0000000181428DD0
	// [XID] // 0x00000001899D15A0-0x00000001899D15C0
	private VCMarkBillboardPlugin GetNpcMarkBillboard(BaseEntity entity) => default; // 0x000000018141C090-0x000000018141C220
	// [XID] // 0x00000001899D8B10-0x00000001899D8B30
	private void AddLocationMarkBillboard(Vector3 position, MarkType markType, uint markID, QuestExcelConfigProxy questExcelCfg, bool useDefaultIcon, Vector3 originPosition, TrackingGroup markGroup = default) {} // 0x000000018141A3D0-0x000000018141A860
	// [XID] // 0x00000001899E01A0-0x00000001899E01C0
	public void RemoveNpcMarkBillboard(MarkType markType, uint markID, bool force = false /* Metadata: 0x00AFE7B0 */) {} // 0x000000018141C440-0x000000018141C620
	// [XID] // 0x00000001899E7CC0-0x00000001899E7CE0
	private VCMarkBillboardPlugin GetDummyEntity() => default; // 0x00000001814243C0-0x0000000181424550
	// [XID] // 0x00000001899EF0C0-0x00000001899EF0E0
	private void RefreshAllMarkBillboards() {} // 0x0000000181429EF0-0x000000018142A2E0
	// [XID] // 0x00000001899F6A90-0x00000001899F6AB0
	private static bool IsBillboardOverlap(Vector3 l, Vector3 r) => default; // 0x000000018142D140-0x000000018142D2C0
	// [XID] // 0x00000001899FE070-0x00000001899FE090
	private static int GetMarkTypeBillboardPriority(MarkType tarType) => default; // 0x0000000181429A30-0x0000000181429AE0
	// [XID] // 0x0000000189A05990-0x0000000189A059B0
	private static bool CompareToBillboard(Tuple<MarkType, uint> lMarkKey, Tuple<MarkType, uint> rMarkKey) => default; // 0x000000018141A020-0x000000018141A300
	// [XID] // 0x0000000189A0CC60-0x0000000189A0CC80
	private void TryAddVisibleBillboard(Tuple<MarkType, uint> markKey, VCMarkBillboardPlugin billboard, Dictionary<Tuple<MarkType, uint>, VCMarkBillboardPlugin> cacheDic) {} // 0x000000018142CA40-0x000000018142CDC0
	// [XID] // 0x0000000189A1B850-0x0000000189A1B870
	public void TrackOrStopDailyTask(uint dailyTaskID) {} // 0x000000018142BF60-0x000000018142C040
	// [XID] // 0x0000000189A23220-0x0000000189A23240
	public void TrackDailyTask(uint dailyTaskID) {} // 0x000000018142F560-0x000000018142FCD0
	// [XID] // 0x0000000189A2A440-0x0000000189A2A460
	public void StopTrackDailyTask(uint dailyTaskID) {} // 0x000000018142E630-0x000000018142EB60
	// [XID] // 0x0000000189A318B0-0x0000000189A318D0
	public bool IsDailyTaskInTracing(uint dailyTaskID) => default; // 0x0000000181417DA0-0x0000000181417E70
	// [XID] // 0x0000000189A393F0-0x0000000189A39410
	private void SeDailyTaskInTracingLocalData() {} // 0x000000018142C660-0x000000018142C780
	// [XID] // 0x0000000189A40BB0-0x0000000189A40BD0
	public void InitDailyTaskLocalData() {} // 0x000000018142F470-0x000000018142F560
	// [XID] // 0x0000000189A48210-0x0000000189A48230
	public void SetNavigation(uint id, NavigationType type, bool isInit = false /* Metadata: 0x00AFE7B1 */) {} // 0x000000018141C2F0-0x000000018141C440
	// [XID] // 0x0000000189A4FAC0-0x0000000189A4FAE0
	private void SetNavigationImpl(uint id, NavigationType type, bool isInit = false /* Metadata: 0x00AFE7B2 */) {} // 0x0000000181425BE0-0x00000001814261C0
	// [IDTag] // 0x0000000189A57050-0x0000000189A57090
	// [XID] // 0x0000000189A57050-0x0000000189A57090
	public void PaimonNavigation(bool isInit = false /* Metadata: 0x00AFE7B3 */, bool isRefresh = false /* Metadata: 0x00AFE7B4 */) {} // 0x0000000181423DE0-0x0000000181423F10
	// [XID] // 0x0000000189A61A30-0x0000000189A61A50
	private void SetPaimonNavigation() {} // 0x000000018142D370-0x000000018142D420
	// [XID] // 0x0000000189A69990-0x0000000189A699B0
	private void InitPaimonNavigation() {} // 0x00000001814198F0-0x00000001814199A0
	// [IDTag] // 0x0000000189A70C20-0x0000000189A70C60
	// [XID] // 0x0000000189A70C20-0x0000000189A70C60
	private void PaimonNavigation(uint id, NavigationType type, bool isInit, bool isRefresh) {} // 0x0000000181423F10-0x0000000181424290
	// [IDTag] // 0x0000000189A7B640-0x0000000189A7B680
	// [XID] // 0x0000000189A7B640-0x0000000189A7B680
	public bool IsInNavigation(uint id, NavigationType type) => default; // 0x0000000181422CD0-0x0000000181422DB0
	// [XID] // 0x0000000189A85E30-0x0000000189A85E50
	public void CancelCurrentQuestNavigation() {} // 0x0000000181429800-0x0000000181429A30
	// [XID] // 0x0000000189A8D710-0x0000000189A8D730
	public void CancelCurrentNavigation() {} // 0x0000000181419710-0x00000001814198F0
	// [XID] // 0x0000000189A94CD0-0x0000000189A94CF0
	public void TryToCancelCurrentOfflineNavigation() {} // 0x00000001814272A0-0x0000000181427460
	// [XID] // 0x0000000189A9C510-0x0000000189A9C530
	public void SetNavigationByMainId(uint mainId, bool isQuest) {} // 0x0000000181429610-0x0000000181429800
	// [IDTag] // 0x0000000189AB2C20-0x0000000189AB2C60
	// [XID] // 0x0000000189AB2C20-0x0000000189AB2C60
	public bool IsInNavigation() => default; // 0x0000000181422C10-0x0000000181422CD0
	// [XID] // 0x0000000189ABD770-0x0000000189ABD790
	public void ResetNavigationLocalData(uint taskID) {} // 0x0000000181421370-0x0000000181421590
	// [XID] // 0x0000000189AC51D0-0x0000000189AC51F0
	private void SetNavigationLocalData(uint mainQuestID, NavigationType type) {} // 0x0000000181423580-0x00000001814236F0
	// [XID] // 0x0000000189ACC720-0x0000000189ACC740
	private bool CanMultiPlayerModeNavigation(uint id, NavigationType type) => default; // 0x000000018142EDA0-0x000000018142EF60
	// [XID] // 0x0000000189AD4410-0x0000000189AD4430
	public void InitNavigation() {} // 0x0000000181416B60-0x0000000181416FF0
	// [XID] // 0x0000000189ADBE00-0x0000000189ADBE20
	public void TrackOrStopDungeonEntry(uint pointID) {} // 0x0000000181427D80-0x0000000181427E60
	// [XID] // 0x0000000189AE3730-0x0000000189AE3750
	public CityConfig GetAvatarCityConfig() => default; // 0x000000018141B1B0-0x000000018141B2F0
	// [XID] // 0x0000000189AEB090-0x0000000189AEB0B0
	public CityConfig GetCityConfig(Vector3 worldPos) => default; // 0x00000001814308E0-0x0000000181430A40
	// [XID] // 0x0000000189AF2960-0x0000000189AF2980
	public WorldAreaConfig GetAreaConfig(Vector3 worldPos) => default; // 0x0000000181421EF0-0x0000000181422070
	// [XID] // 0x0000000189AFA260-0x0000000189AFA280
	public WorldAreaConfig GetSubAreaConfig(Vector3 worldPos) => default; // 0x00000001814289F0-0x0000000181428B90
	[Preserve] // 0x0000000189B017E0-0x0000000189B01820
	// [XID] // 0x0000000189B017E0-0x0000000189B01820
	public override string Dump(string tag) => default; // 0x000000018141DD90-0x000000018141E320
	// [XID] // 0x0000000189B0BD30-0x0000000189B0BD50
	public void StopCurrentCustomTrack() {} // 0x000000018142CE90-0x000000018142D140
	// [XID] // 0x0000000189B13320-0x0000000189B13340
	public bool IsInCustomTracing(uint id, MarkType type) => default; // 0x0000000181431700-0x0000000181431860
	// [XID] // 0x0000000189B1AAE0-0x0000000189B1AB00
	public void SetCurrentCustomTrack(uint id, MarkType type) {} // 0x000000018142DAE0-0x000000018142DC90
	// [XID] // 0x0000000189B296A0-0x0000000189B296C0
	public void AddGuidePoint(BaseEntity entity, TargetIndicatorType type) {} // 0x0000000181419DB0-0x0000000181419FB0
	// [XID] // 0x0000000189B30C50-0x0000000189B30C70
	public void AddTaskGuidePoint(BaseEntity entity, TargetIndicatorType type, uint taskID, float yOffset = 0f /* Metadata: 0x00AFE7B5 */) {} // 0x000000018141EC20-0x000000018141EF20
	// [XID] // 0x0000000189B38270-0x0000000189B38290
	public void RemoveGuidePoint(uint entityRuntimeID) {} // 0x0000000181428260-0x0000000181428420
	// [XID] // 0x0000000189B3FCC0-0x0000000189B3FCE0
	public void AddGuidePointForTask(uint taskID) {} // 0x000000018142DEA0-0x000000018142E1A0
	// [XID] // 0x0000000189B474B0-0x0000000189B474D0
	public void RemoveGuidePointForTask(uint taskID) {} // 0x000000018142B260-0x000000018142B550
	// [XID] // 0x0000000189B65340-0x0000000189B65360
	public bool IsCurNavigateGroup(TrackingGroup groupId) => default; // 0x0000000181421270-0x0000000181421370
	// [XID] // 0x0000000189B6C9A0-0x0000000189B6C9C0
	public void StopPathNavigation() {} // 0x000000018141EAD0-0x000000018141EBB0
	// [XID] // 0x0000000189B740C0-0x0000000189B740E0
	public void TryStartPathNavigation() {} // 0x00000001814291D0-0x00000001814292E0
	// [XID] // 0x0000000189B7B670-0x0000000189B7B690
	public void ClearNavigation() {} // 0x0000000181419100-0x0000000181419350
	// [XID] // 0x0000000189B83060-0x0000000189B83080
	public void RemoveNavigation(uint questMarkID) {} // 0x0000000181428420-0x00000001814287F0
	// [XID] // 0x0000000189B8A5B0-0x0000000189B8A5D0
	public bool StartNavigation(List<uint> questMarkIDList) => default; // 0x0000000181422DB0-0x0000000181423110
	// [XID] // 0x0000000189B91BA0-0x0000000189B91BC0
	public bool StartDailyTaskNavigation(uint taskID, bool isInit, bool isRefresh) => default; // 0x000000018142A8C0-0x000000018142AEB0
	// [XID] // 0x0000000189B99060-0x0000000189B99080
	public void StopDailyTaskNavigation(uint dailyTaskID) {} // 0x00000001814178C0-0x0000000181417970
	// [XID] // 0x0000000189BA0370-0x0000000189BA0390
	public bool TryStopDailyTaskNavigation(uint taskID) => default; // 0x000000018141A300-0x000000018141A3D0
	// [XID] // 0x0000000189BA7BD0-0x0000000189BA7BF0
	private void TickNavigation() {} // 0x000000018142FCD0-0x000000018142FEC0
	// [XID] // 0x0000000189BD31F0-0x0000000189BD3210
	public void InitAvataArea() {} // 0x000000018141A860-0x000000018141A910
	// [XID] // 0x0000000189BDAAD0-0x0000000189BDAAF0
	private bool TryGetWorldPositionAreaID(Vector3 worldPosition, out uint areaID) {
		areaID = default;
		return default;
	} // 0x0000000181431860-0x0000000181431A10
	// [XID] // 0x00000001895E74B0-0x00000001895E74D0
	private void CheckAvatarArea(bool skipTimeCheck = false /* Metadata: 0x00AFE7B9 */, bool updateCheckTime = true /* Metadata: 0x00AFE7BA */) {} // 0x0000000181430A40-0x0000000181431020
	// [XID] // 0x00000001895EED60-0x00000001895EED80
	private void SendAreaChangeAudio(WorldAreaConfig cfg) {} // 0x00000001814287F0-0x0000000181428990
	// [XID] // 0x00000001895F6740-0x00000001895F6760
	public void UpdateResendCheck(bool value) {} // 0x0000000181422070-0x0000000181422130
	// [XID] // 0x00000001895FDAC0-0x00000001895FDAE0
	private void CheckEnterAreaResend() {} // 0x00000001814234B0-0x0000000181423580
	// [XID] // 0x0000000189605310-0x0000000189605330
	private void CheckLevelArea() {} // 0x000000018142F280-0x000000018142F470
	// [XID] // 0x0000000189614290-0x00000001896142B0
	public uint GetCurrentAreaLevelWithWorldLevel(uint worldLevel) => default; // 0x000000018141BC30-0x000000018141BD00
	// [XID] // 0x000000018961BCF0-0x000000018961BD10
	public void UpdateAreaLevels() {} // 0x000000018142D910-0x000000018142D9D0
	// [XID] // 0x0000000189795E90-0x0000000189795EB0
	public static uint GetAdjustedLevel(uint worldLevel, uint baseLevel) => default; // 0x000000018141FDD0-0x0000000181420070
}

