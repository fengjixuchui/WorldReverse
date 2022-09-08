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
using MoleMole;
using MoleMole.Config;
using UniRx;
using UnityEngine;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestModule : BaseModule // TypeDefIndex: 21598
{
	// Fields
	private Queue<QuestConfigCheckRequest> _configCheckRequestQueue; // 0x10
	private bool _configCheckRequestProcessing; // 0x18
	private Dictionary<uint, uint> _rqRuntimeId2ConfigIdDic; // 0x20
	private Queue<QuestProtoRequest> _protoRequestQueue; // 0x28
	private Dictionary<ulong, LuaPreloadState> _cachedPreloadLua; // 0x30
	private Dictionary<uint, List<LuaPreloadState>> _mainQuestCachedLua; // 0x38
	private SimpleObjectPool<LuaPreloadState> _luaPreloadStatePool; // 0x40
	private Dictionary<uint, AnimePreLoadState> _mainQuestCachedAnime; // 0x48
	private const int MAX_DATA_TASK = 200; // Metadata: 0x00AFFA1D
	private Queue<QuestUpdateRequest> _updateRequestQueue; // 0x50
	private Queue<QuestUpdateRequest> _wait2UpdateQueue; // 0x58
	private bool _questUpdateRequestProcessing; // 0x60
	private bool _questUpdateWaiting; // 0x61
	private List<uint> _mainIDList; // 0x68
	private List<uint> _mainIDFinishedList; // 0x70
	private Dictionary<uint, bool> _questRewindDic; // 0x78
	private static int _proficientQuestId; // 0x00
	private const int QUEST_VARS_SIZE = 5; // Metadata: 0x00AFFA21
	private Dictionary<uint, QuestVarLocal> _mainQuestVarDic; // 0x80
	private HashSet<uint> _mainQuestFinishedSet; // 0x88
	private Dictionary<uint, List<QuestProxy>> _mainQuestID2SubListDic; // 0x90
	private Dictionary<uint, List<uint>> _mainQuestID2FactorListDic; // 0x98
	private Dictionary<uint, bool> _mainQuestID2Preload; // 0xA0
	private Dictionary<uint, QuestProxy> _questID2Dic; // 0xA8
	private List<QuestNotifyCache> _questCacheList; // 0xB0
	private List<QuestProtoRequest> _questPostCacheList; // 0xB8
	private bool _isPostInited; // 0xC0
	private static Dictionary<uint, bool> _rewindMainIDs; // 0x08
	private Dictionary<uint, QuestState> _mainQuestID2StateDic; // 0xC8
	private bool _delayQuestHint; // 0xD0
	private Queue<Tuple<QuestExcelConfigProxy, QuestHintType>> _questHintCache; // 0xD8
	private StringBuilder stringBuilder; // 0xE0
	private const string preSharePath = "Quest/Share/Q"; // Metadata: 0x00AFFA25
	private const string postSharePath = "ShareConfig"; // Metadata: 0x00AFFA36
	private const string preClientPath = "Quest/Client/Q"; // Metadata: 0x00AFFA45
	private const string postClientPath = "ClientConfig"; // Metadata: 0x00AFFA57
	private Dictionary<uint, float> _questGuideAreaRadius; // 0xE8
	private Dictionary<uint, EntityInfoCacheData> _spawnCacheDic; // 0xF0
	private Queue<string> _unSpawnAliasQueue; // 0xF8
	private List<AliasBindCache> _bindCacheList; // 0x100
	private HashSet<uint> _npcPreQuestTalkIdSet; // 0x108
	private Dictionary<uint, int> _questGlobalVarDic; // 0x110
	private List<uint> _onGoingPersonalLineList; // 0x118
	private List<uint> _canBeUnlockPersonalLineList; // 0x120
	private List<uint> _lockedPersonalLineList; // 0x128
	private Dictionary<uint, LockedPersonallineData> _lockedLineDic; // 0x130
	private QuestTrackingMainData _trackingMainData; // 0x138
	private bool _canSaveQuestData; // 0x140
	private Coroutine curCoroutine; // 0x148
	private List<uint> _suggestTrackMainQuestList; // 0x158
	private bool _suggestTrackOutOfOrder; // 0x160
	private List<uint> _newMainQuest; // 0x168
	private NavigationState _navigationState; // 0x170
	private uint _navigatedMainQuestID; // 0x174
	private List<uint> _navigatedSubQuestIDList; // 0x178

	// Properties
	public List<uint> mainQuestIDList { /* [XID] */ /* 0x0000000189BC2D90-0x0000000189BC2DB0 */ get => default; } // 0x0000000181B28530-0x0000000181B285D0 
	public List<uint> finishedMainQuestIDList { /* [XID] */ /* 0x0000000189BCA4F0-0x0000000189BCA510 */ get => default; } // 0x0000000181B3AD00-0x0000000181B3ADA0 
	private static int proficientQuestId { /* [XID] */ /* 0x0000000189BD1B60-0x0000000189BD1B80 */ get => default; } // 0x0000000181B2F750-0x0000000181B2F920 
	public Dictionary<uint, List<QuestProxy>> mainQuestID2SubListDic { /* [XID] */ /* 0x00000001895FC450-0x00000001895FC470 */ get => default; } // 0x0000000181B29690-0x0000000181B29740 
	public Dictionary<uint, QuestProxy> questID2Dic { /* [XID] */ /* 0x0000000189612BC0-0x0000000189612BE0 */ get => default; } // 0x0000000181B364A0-0x0000000181B36550 
	public bool delayQuestHint { /* [XID] */ /* 0x000000018960AF70-0x000000018960AF90 */ set {} } // 0x0000000181B2A750-0x0000000181B2AA00
	public uint curFinishedDailyTaskCount { /* [XID] */ /* 0x0000000189949B80-0x0000000189949BA0 */ get => default; } // 0x0000000181B37280-0x0000000181B37380 
	public uint legendaryKeyCount { /* [XID] */ /* 0x0000000189951760-0x0000000189951780 */ get => default; } // 0x0000000181B2F9F0-0x0000000181B2FAA0 
	public List<uint> onGoingPersonalLineList { /* [XID] */ /* 0x0000000189958D30-0x0000000189958D50 */ get => default; } // 0x0000000181B3CD50-0x0000000181B3CE00 
	public List<uint> canBeUnlockPersonalLineList { /* [XID] */ /* 0x00000001899603E0-0x0000000189960400 */ get => default; } // 0x0000000181B2BE40-0x0000000181B2BEF0 
	public List<uint> lockedPersonalLineList { /* [XID] */ /* 0x0000000189967DE0-0x0000000189967E00 */ get => default; } // 0x0000000181B29990-0x0000000181B29A40 
	public Dictionary<uint, LockedPersonallineData> lockedLineDic { /* [XID] */ /* 0x000000018996F060-0x000000018996F080 */ get => default; } // 0x0000000181B241D0-0x0000000181B24280 
	public QuestTrackingMainData trackingMainData { /* [XID] */ /* 0x00000001899CCDA0-0x00000001899CCDC0 */ get => default; } // 0x0000000181B2A460-0x0000000181B2A510 
	private bool lateTrackSome { /* [XID] */ /* 0x0000000189A5A180-0x0000000189A5A1C0 */ get; /* [XID] */ /* 0x0000000189A64B60-0x0000000189A64BA0 */ set; } // 0x0000000181B293F0-0x0000000181B29450 0x0000000181B23A00-0x0000000181B23A70
	public bool paimonNavigationEnabled { /* [XID] */ /* 0x0000000189AC9640-0x0000000189AC9660 */ get => default; } // 0x0000000181B25730-0x0000000181B257E0 
	public bool paimonNavigationAvailable { /* [XID] */ /* 0x0000000189AD0FD0-0x0000000189AD0FF0 */ get => default; } // 0x0000000181B312A0-0x0000000181B31390 

	// Nested types
	public class QuestProtoRequest : ISimplePoolObject // TypeDefIndex: 21599
	{
		// Fields
		private static SimpleObjectPool<QuestProtoRequest> _pool; // 0x00
		private ushort _dataType; // 0x10
		private MessageBase _msg; // 0x18

		// Properties
		public ushort dataType { /* [XID] */ /* 0x0000000189B63C90-0x0000000189B63CB0 */ get => default; } // 0x000000018481A8A0-0x000000018481A940 
		public MessageBase msg { /* [XID] */ /* 0x0000000189B6B420-0x0000000189B6B440 */ get => default; } // 0x000000018481AA30-0x000000018481AAD0 

		// Constructors
		public QuestProtoRequest() {} // 0x000000018481AC30-0x000000018481AC90
		static QuestProtoRequest() {} // 0x000000018481ABC0-0x000000018481AC30

		// Methods
		// [XID] // 0x0000000189B54BB0-0x0000000189B54BD0
		public static QuestProtoRequest Get(ushort dataType, MessageBase msg) => default; // 0x000000018481A780-0x000000018481A8A0
		// [XID] // 0x0000000189B5C5F0-0x0000000189B5C610
		public static void Release(QuestProtoRequest request) {} // 0x000000018481A940-0x000000018481AA30
		// [XID] // 0x0000000189B72A30-0x0000000189B72A50
		public void Init(ushort dataType, MessageBase msg) {} // 0x000000018481A6B0-0x000000018481A780
		// [XID] // 0x0000000189B79FB0-0x0000000189B79FD0
		public void ResetObject() {} // 0x000000018481AAD0-0x000000018481ABC0
	}

	public class QuestConfigCheckRequest : ISimplePoolObject // TypeDefIndex: 21600
	{
		// Fields
		private static SimpleObjectPool<QuestConfigCheckRequest> _pool; // 0x00
		private bool _isInit; // 0x10
		private Quest _quest; // 0x18
		private QuestProxy _questProxy; // 0x20

		// Properties
		public bool isInit { /* [XID] */ /* 0x0000000189B90300-0x0000000189B90320 */ get => default; } // 0x000000018481A0D0-0x000000018481A170 
		public Quest quest { /* [XID] */ /* 0x0000000189B97750-0x0000000189B97770 */ get => default; } // 0x000000018481A250-0x000000018481A2F0 
		public QuestProxy questProxy { /* [XID] */ /* 0x0000000189B9EC10-0x0000000189B9EC30 */ get => default; } // 0x000000018481A030-0x000000018481A0D0 

		// Constructors
		public QuestConfigCheckRequest() {} // 0x000000018481A640-0x000000018481A6B0
		static QuestConfigCheckRequest() {} // 0x000000018481A5D0-0x000000018481A640

		// Methods
		// [XID] // 0x0000000189B81710-0x0000000189B81730
		public static QuestConfigCheckRequest Get(QuestProxy questProxy, Quest quest, bool isInit) => default; // 0x000000018481A2F0-0x000000018481A430
		// [XID] // 0x0000000189B88D90-0x0000000189B88DB0
		public static void Release(QuestConfigCheckRequest request) {} // 0x000000018481A430-0x000000018481A520
		// [XID] // 0x0000000189BA6500-0x0000000189BA6520
		public void Init(QuestProxy questProxy, Quest quest, bool isInit) {} // 0x000000018481A170-0x000000018481A250
		// [XID] // 0x0000000189BAD840-0x0000000189BAD860
		public void ResetObject() {} // 0x000000018481A520-0x000000018481A5D0
	}

	private class LuaPreloadState : ISimplePoolObject // TypeDefIndex: 21601
	{
		// Fields
		public ulong pathHash; // 0x10
		public HashSet<uint> questMainIdSet; // 0x18
		public AsyncJob loadJob; // 0x20
		public bool isLoaded; // 0x30
		public bool isEternal; // 0x31

		// Constructors
		public LuaPreloadState() {} // 0x000000018481DB60-0x000000018481DC10

		// Methods
		// [XID] // 0x0000000189BB4F80-0x0000000189BB4FA0
		public void ResetObject() {} // 0x000000018481DA80-0x000000018481DB60
	}

	private class AnimePreLoadState // TypeDefIndex: 21602
	{
		// Fields
		public int curLoadFreeStyleCount; // 0x10
		public Dictionary<uint, int[]> curLoadFreeStyleDic; // 0x18

		// Constructors
		public AnimePreLoadState() {} // 0x000000018483A6C0-0x000000018483A720

		// Methods
		// [XID] // 0x0000000189BBC5A0-0x0000000189BBC5C0
		public void Release() {} // 0x000000018483A610-0x000000018483A6C0
		// [XID] // 0x0000000189BC4240-0x0000000189BC4260
		public static AnimePreLoadState Get() => default; // 0x000000018483A570-0x000000018483A610
	}

	public class QuestUpdateRequest : ISimplePoolObject // TypeDefIndex: 21603
	{
		// Fields
		private static SimpleObjectPool<QuestUpdateRequest> _pool; // 0x00
		private bool _isInit; // 0x10
		private Quest _quest; // 0x18
		private QuestProxy _questProxy; // 0x20

		// Properties
		public bool isInit { /* [XID] */ /* 0x0000000189BDA990-0x0000000189BDA9B0 */ get => default; } // 0x0000000184819890-0x0000000184819930 
		public Quest quest { /* [XID] */ /* 0x00000001895E7390-0x00000001895E73B0 */ get => default; } // 0x0000000184819A10-0x0000000184819AB0 
		public QuestProxy questProxy { /* [XID] */ /* 0x00000001895EECA0-0x00000001895EECC0 */ get => default; } // 0x00000001848197F0-0x0000000184819890 

		// Constructors
		public QuestUpdateRequest() {} // 0x0000000184819E00-0x0000000184819E70
		static QuestUpdateRequest() {} // 0x0000000184819D90-0x0000000184819E00

		// Methods
		// [XID] // 0x0000000189BCBBE0-0x0000000189BCBC00
		public static QuestUpdateRequest Get(QuestProxy questProxy, Quest quest, bool isInit) => default; // 0x0000000184819AB0-0x0000000184819BF0
		// [XID] // 0x0000000189BD3130-0x0000000189BD3150
		public static void Release(QuestUpdateRequest request) {} // 0x0000000184819BF0-0x0000000184819CE0
		// [XID] // 0x00000001895F6660-0x00000001895F6680
		public void Init(QuestProxy questProxy, Quest quest, bool isInit) {} // 0x0000000184819930-0x0000000184819A10
		// [XID] // 0x00000001895FDA40-0x00000001895FDA60
		public void ResetObject() {} // 0x0000000184819CE0-0x0000000184819D90
	}

	public class QuestVarLocal : ISimplePoolObject // TypeDefIndex: 21604
	{
		// Fields
		private static SimpleObjectPool<QuestVarLocal> _pool; // 0x00
		private int[] QuestVars; // 0x10
		public uint questVarSeq; // 0x18

		// Constructors
		public QuestVarLocal() {} // 0x000000018481B360-0x000000018481B400
		static QuestVarLocal() {} // 0x000000018481B2F0-0x000000018481B360

		// Methods
		// [XID] // 0x0000000189605270-0x0000000189605290
		public static QuestVarLocal Get() => default; // 0x000000018481AE50-0x000000018481AF30
		// [XID] // 0x000000018960CCA0-0x000000018960CCC0
		public static void Release(QuestVarLocal questVarLocal) {} // 0x000000018481AF30-0x000000018481B020
		// [XID] // 0x00000001896141F0-0x0000000189614210
		public void ResetObject() {} // 0x000000018481B250-0x000000018481B2F0
		// [XID] // 0x000000018961BC10-0x000000018961BC30
		public void UpdateValue(uint index, int value) {} // 0x000000018481B020-0x000000018481B140
		// [XID] // 0x0000000189623180-0x00000001896231A0
		public int GetValue(uint index) => default; // 0x000000018481B140-0x000000018481B250
		// [XID] // 0x000000018962A980-0x000000018962A9A0
		public void Clear() {} // 0x000000018481AD70-0x000000018481AE50
	}

	private struct QuestNotifyCache // TypeDefIndex: 21605
	{
		// Fields
		public QuestListUpdateNotify listUpdateNotify; // 0x00
		public QuestDelNotify delNotify; // 0x08
		public QuestProgressUpdateNotify progressNotify; // 0x10
		public QuestUpdateQuestVarNotify questVarNotify; // 0x18
	}

	private struct AliasBindCache // TypeDefIndex: 21606
	{
		// Fields
		public string alias; // 0x00
		public uint runtimeID; // 0x08

		// Methods
		// [XID] // 0x0000000189632100-0x0000000189632120
		public static AliasBindCache CreateAliasBindCache(string alias, uint runtimeID) => default; // 0x000000018481B400-0x000000018481B530
	}

	public class QuestTrackingMetaData // TypeDefIndex: 21607
	{
		// Fields
		public readonly QuestType questType; // 0x10
		public readonly uint mainQuestID; // 0x14
		private List<uint> _subQuestIDList; // 0x18

		// Properties
		public bool hasSubTracking { /* [XID] */ /* 0x0000000189639BB0-0x0000000189639BD0 */ get => default; } // 0x00000001848399F0-0x0000000184839AB0 
		public uint firstSubQuestID { /* [XID] */ /* 0x0000000189641060-0x0000000189641080 */ get => default; } // 0x0000000184839C20-0x0000000184839D00 
		public uint lastSubQuestID { /* [XID] */ /* 0x00000001896489E0-0x0000000189648A00 */ get => default; } // 0x0000000184839DD0-0x0000000184839ED0 
		public List<uint> subQuestIDList { /* [XID] */ /* 0x00000001896579B0-0x00000001896579D0 */ get => default; } // 0x0000000184839AB0-0x0000000184839B50 

		// Constructors
		public QuestTrackingMetaData() {} // Dummy constructor
		public QuestTrackingMetaData(uint mainQuestID, QuestType questType) {} // 0x0000000184839FC0-0x000000018483A070

		// Methods
		// [XID] // 0x00000001896500C0-0x00000001896500E0
		public bool IsInSubTracking(uint subQuestID) => default; // 0x0000000184839D00-0x0000000184839DD0
		// [XID] // 0x000000018965F080-0x000000018965F0A0
		public void AddSubQuestID(uint subQuestID) {} // 0x0000000184839ED0-0x0000000184839FC0
		// [XID] // 0x0000000189666850-0x0000000189666870
		public bool RemoveSubQuestID(uint subQuestID) => default; // 0x0000000184839B50-0x0000000184839C20
		// [XID] // 0x000000018966DF90-0x000000018966DFB0
		public void ClearSubQuestID() {} // 0x0000000184839940-0x00000001848399F0
	}

	public class QuestTrackingMainData // TypeDefIndex: 21608
	{
		// Fields
		private readonly Dictionary<QuestType, List<QuestTrackingMetaData>> _trackingTypeDataDic; // 0x10
		private static int trackMaxCount; // 0x00

		// Constructors
		public QuestTrackingMainData() {} // 0x000000018481D9A0-0x000000018481DA80
		static QuestTrackingMainData() {} // 0x000000018481D940-0x000000018481D9A0

		// Methods
		// [XID] // 0x000000018967D640-0x000000018967D660
		private static int GetTrackingCountLimit(QuestType questType) => default; // 0x000000018481D870-0x000000018481D940
		// [IDTag] // 0x0000000189684CC0-0x0000000189684D00
		// [XID] // 0x0000000189684CC0-0x0000000189684D00
		private List<QuestTrackingMetaData> GetTrackingList(QuestType questType) => default; // 0x000000018481C690-0x000000018481C780
		// [IDTag] // 0x000000018968FB20-0x000000018968FB60
		// [XID] // 0x000000018968FB20-0x000000018968FB60
		private List<QuestTrackingMetaData> GetTrackingList(uint mainQuestID) => default; // 0x000000018481C5A0-0x000000018481C690
		// [XID] // 0x000000018969A070-0x000000018969A090
		private QuestTrackingMetaData GetTrackingMetaData(uint mainQuestID) => default; // 0x000000018481BA20-0x000000018481BD00
		// [XID] // 0x00000001896A1860-0x00000001896A1880
		private QuestTrackingMetaData GetRelatedTrackingMetaData(uint subQuestID) => default; // 0x000000018481B850-0x000000018481B960
		// [XID] // 0x00000001896A8D20-0x00000001896A8D40
		public void AddMainQuest(uint mainQuestID) {} // 0x000000018481CEF0-0x000000018481D140
		// [XID] // 0x00000001896AFD50-0x00000001896AFD70
		public void RemoveMainQuest(uint mainQuestID, bool needSave = true /* Metadata: 0x00AFFA67 */) {} // 0x000000018481D140-0x000000018481D440
		// [XID] // 0x00000001896B7780-0x00000001896B77A0
		public void ClearMainQuest() {} // 0x000000018481C920-0x000000018481CAE0
		// [XID] // 0x00000001896BE8B0-0x00000001896BE8D0
		public List<uint> GetAllMainQuestIDList() => default; // 0x000000018481CBA0-0x000000018481CE80
		// [XID] // 0x00000001896C61B0-0x00000001896C61D0
		public uint GetMainQuestID2BoringRemind() => default; // 0x000000018481C260-0x000000018481C5A0
		// [XID] // 0x00000001896CD7D0-0x00000001896CD7F0
		public uint GetMainQuestID2Remove(uint mainQuestID2Add) => default; // 0x000000018481BD00-0x000000018481BE90
		// [XID] // 0x00000001896D4C00-0x00000001896D4C20
		public bool IsInMainTracking(uint mainQuestID) => default; // 0x000000018481D7B0-0x000000018481D870
		// [XID] // 0x00000001896DC280-0x00000001896DC2A0
		public bool IsMainTrackingEmpty() => default; // 0x000000018481B530-0x000000018481B730
		// [XID] // 0x00000001896E3A50-0x00000001896E3A70
		public void AddSubQuest(uint subQuestID) {} // 0x000000018481B960-0x000000018481BA20
		// [XID] // 0x00000001896EAE40-0x00000001896EAE60
		public bool RemoveSubQuest(uint subQuestID) => default; // 0x000000018481C780-0x000000018481C850
		// [XID] // 0x00000001896F2210-0x00000001896F2230
		public void ClearSubQuest(uint mainQuestID) {} // 0x000000018481CAE0-0x000000018481CBA0
		// [XID] // 0x00000001896F9BB0-0x00000001896F9BD0
		public void ClearAllSubQuest() {} // 0x000000018481D520-0x000000018481D7B0
		// [XID] // 0x0000000189701400-0x0000000189701420
		public List<uint> GetSubQuestIDList(uint mainQuestID) => default; // 0x000000018481B730-0x000000018481B850
		// [XID] // 0x0000000189708BC0-0x0000000189708BE0
		public List<uint> GetSubQuestIDListRef(uint mainQuestID) => default; // 0x000000018481D440-0x000000018481D520
		// [XID] // 0x00000001897104A0-0x00000001897104C0
		public List<uint> GetAllSubQuestIDList() => default; // 0x000000018481BE90-0x000000018481C190
		// [XID] // 0x0000000189717820-0x0000000189717840
		public uint GetFirstSubQuestID(uint mainQuestID) => default; // 0x000000018481C850-0x000000018481C920
		// [XID] // 0x000000018971F350-0x000000018971F370
		public uint GetLastSubQuestID(uint mainQuestID) => default; // 0x000000018481C190-0x000000018481C260
	}

	public enum NavigationState // TypeDefIndex: 21611
	{
		Disabled = 0,
		AutoEnabled = 1,
		ManualEnabled = 2
	}

	// Constructors
	public QuestModule() {} // 0x0000000181B3DD00-0x0000000181B3E300
	static QuestModule() {} // 0x0000000181B3DC60-0x0000000181B3DD00

	// Methods
	// [XID] // 0x0000000189AACC60-0x0000000189AACC80
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000181B26A40-0x0000000181B26D10
	// [XID] // 0x0000000189AB44F0-0x0000000189AB4510
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000181B3B890-0x0000000181B3B980
	// [XID] // 0x0000000189ABC1C0-0x0000000189ABC1E0
	private void SetRqRuntimeIdMaping(uint mainQuestId, uint mainQuestConfigId) {} // 0x0000000181B28E10-0x0000000181B28F30
	// [XID] // 0x0000000189AC3AA0-0x0000000189AC3AC0
	private uint GetRqConfigIdByRuntimeId(uint mainQuestId) => default; // 0x0000000181B300D0-0x0000000181B301B0
	// [XID] // 0x0000000189ACAF40-0x0000000189ACAF60
	private void UpdateQuestStreaming(Quest quest, bool isInit = false /* Metadata: 0x00AFF9E3 */) {} // 0x0000000181B2C9D0-0x0000000181B2CCA0
	// [XID] // 0x0000000189AD2A60-0x0000000189AD2A80
	private void UpdateQuestConfigCheckOnRequest(QuestProxy questProxy, Quest quest, bool isInit) {} // 0x0000000181B383D0-0x0000000181B38670
	// [XID] // 0x0000000189ADA420-0x0000000189ADA440
	public void CheckQuestUpdateConfig(bool force = false /* Metadata: 0x00AFF9E4 */) {} // 0x0000000181B2F410-0x0000000181B2F630
	// [XID] // 0x0000000189AE1D30-0x0000000189AE1D50
	private void OnQuestConfigUpdateInternal(QuestConfigCheckRequest request) {} // 0x0000000181B37F20-0x0000000181B38070
	// [XID] // 0x0000000189AE95D0-0x0000000189AE95F0
	public void OnQuestConfigSerialized(ConfigMainQuestScheme config, bool isAsync) {} // 0x0000000181B392A0-0x0000000181B39370
	// [XID] // 0x0000000189AF1370-0x0000000189AF1390
	private void OnQuestConfigLoadHandler() {} // 0x0000000181B23B40-0x0000000181B23BE0
	// [IDTag] // 0x0000000189AF8930-0x0000000189AF8970
	// [XID] // 0x0000000189AF8930-0x0000000189AF8970
	private void UpdateQuestPreBan(QuestProxy questProxy, Quest quest) {} // 0x0000000181B265C0-0x0000000181B26730
	// [XID] // 0x0000000189B02ED0-0x0000000189B02EF0
	private void CheckQuestBanWhenClear(QuestProxy questProxy) {} // 0x0000000181B29450-0x0000000181B295A0
	// [XID] // 0x0000000189B0A5C0-0x0000000189B0A5E0
	private bool OnQuestPacketEnqueue(ushort dataType, Packet packet) => default; // 0x0000000181B291B0-0x0000000181B293F0
	// [XID] // 0x0000000189B11D60-0x0000000189B11D80
	public bool IsLoadingProcessing() => default; // 0x0000000181B36D60-0x0000000181B36E20
	// [XID] // 0x0000000189B18F90-0x0000000189B18FB0
	private void CheckQuestMsg() {} // 0x0000000181B24280-0x0000000181B24380
	// [XID] // 0x0000000189B20690-0x0000000189B206B0
	private void OnQuestProtoRequest(QuestProtoRequest request) {} // 0x0000000181B3A990-0x0000000181B3AB00
	// [XID] // 0x0000000189B27D90-0x0000000189B27DB0
	private void OnQuestProtoRequestInternal(ushort dataType, IMessage msg) {} // 0x0000000181B288B0-0x0000000181B28BB0
	// [XID] // 0x0000000189B2F0B0-0x0000000189B2F0D0
	private bool IsPostCacheRequest(ushort dataType) => default; // 0x0000000181B3B450-0x0000000181B3B540
	// [XID] // 0x0000000189B369D0-0x0000000189B369F0
	private void ClearQuestCache() {} // 0x0000000181B3C180-0x0000000181B3C280
	private void ReleaseCahceQueue<T>(Queue<T> cache)
		where T : ISimplePoolObject {}
	private void ReleaseCahceQueue<T>(List<T> cache)
		where T : ISimplePoolObject {}
	// [XID] // 0x0000000189B3E190-0x0000000189B3E1B0
	private void ClearAllQuestPreload() {} // 0x0000000181B3ADA0-0x0000000181B3AE50
	// [XID] // 0x0000000189B45EE0-0x0000000189B45F00
	private void RemoveQuestPreload(uint mainQuestId) {} // 0x0000000181B36F60-0x0000000181B37020
	// [XID] // 0x0000000189B4D310-0x0000000189B4D330
	private void AddQuestPreload(ConfigMainQuestScheme config, bool isAsync) {} // 0x0000000181B34CB0-0x0000000181B34DA0
	// [XID] // 0x0000000189B54BD0-0x0000000189B54BF0
	private bool IsQuestPreloadFinish(uint mainQuestId) => default; // 0x0000000181B33BF0-0x0000000181B33CC0
	// [XID] // 0x0000000189B5C610-0x0000000189B5C630
	private void ClearAllQuestPreloadLua() {} // 0x0000000181B2B8F0-0x0000000181B2BBE0
	// [XID] // 0x0000000189B63CB0-0x0000000189B63CD0
	private void RemoveQuestPreloadLua(uint questMainId) {} // 0x0000000181B2C450-0x0000000181B2C700
	// [XID] // 0x0000000189B6B440-0x0000000189B6B460
	private void AddQuestPreloadLua(ConfigMainQuestScheme config, bool isAsync) {} // 0x0000000181B24D00-0x0000000181B25190
	// [XID] // 0x0000000189B72A50-0x0000000189B72A70
	private LuaPreloadState PreloadQuestLuaImpl(uint questMainId, ulong pathHash, bool isEternal, bool isAsync) => default; // 0x0000000181B2BEF0-0x0000000181B2C450
	// [XID] // 0x0000000189B79FD0-0x0000000189B79FF0
	private static void OnPreloadLuaFinish(int index, ulong pathHash, bool loadSucceeded, byte[] bytes) {} // 0x0000000181B2CE40-0x0000000181B2D050
	// [XID] // 0x0000000189B81730-0x0000000189B81750
	private bool IsPreloadLuaFinish(uint mainQuestId) => default; // 0x0000000181B23BE0-0x0000000181B23D40
	// [IDTag] // 0x0000000189B88DB0-0x0000000189B88DF0
	// [XID] // 0x0000000189B88DB0-0x0000000189B88DF0
	private bool IsQuestPreloadLua(uint mainQuestId, string path) => default; // 0x0000000181B38E30-0x0000000181B38F30
	// [IDTag] // 0x0000000189B930B0-0x0000000189B930F0
	// [XID] // 0x0000000189B930B0-0x0000000189B930F0
	private bool IsQuestPreloadLua(uint mainQuestId, ulong pathHash) => default; // 0x0000000181B38D00-0x0000000181B38E30
	// [XID] // 0x0000000189B9D420-0x0000000189B9D440
	private void ClearAllQuestPreloadFreeStyle() {} // 0x0000000181B25940-0x0000000181B25D40
	// [XID] // 0x0000000189BA4E30-0x0000000189BA4E50
	private void RemoveQuestPreloadFreeStyle(uint mainQuestId) {} // 0x0000000181B285D0-0x0000000181B288B0
	// [XID] // 0x0000000189BAC010-0x0000000189BAC030
	private void AddQuestPreloadFreeStyle(ConfigMainQuestScheme config, bool isAsync) {} // 0x0000000181B25190-0x0000000181B25730
	// [XID] // 0x0000000189BB3810-0x0000000189BB3830
	private void OnPreloadFreeStyleFinish(uint mainQuestId) {} // 0x0000000181B37A80-0x0000000181B37B90
	// [XID] // 0x0000000189BBADA0-0x0000000189BBADC0
	private bool IsPreloadFreeStyleFinish(uint mainQuestId) => default; // 0x0000000181B24380-0x0000000181B24480
	// [XID] // 0x0000000189BD9130-0x0000000189BD9150
	public void BuildMainIDList() {} // 0x0000000181B271B0-0x0000000181B274C0
	// [XID] // 0x00000001895E5D10-0x00000001895E5D30
	public bool HasSubQuestValiable(uint mainQuestId) => default; // 0x0000000181B28BB0-0x0000000181B28D40
	// [XID] // 0x00000001895ED6D0-0x00000001895ED6F0
	public bool HasSubQuestShow(List<QuestProxy> subQuestList) => default; // 0x0000000181B29C70-0x0000000181B29DE0
	// [XID] // 0x00000001895F4CA0-0x00000001895F4CC0
	public QuestProxy GetFirstUnfinishedSubQuest(uint subQuestID) => default; // 0x0000000181B26340-0x0000000181B264A0
	// [XID] // 0x0000000189603E50-0x0000000189603E70
	public void SetMainQuestPreload(uint mainQuestID, bool preloaded) {} // 0x0000000181B330F0-0x0000000181B33220
	// [XID] // 0x000000018960B730-0x000000018960B750
	public bool IsMainQuestPreloaded(uint mainQuestID) => default; // 0x0000000181B36C60-0x0000000181B36D60
	// [XID] // 0x000000018961A480-0x000000018961A4A0
	private QuestNotifyCache CreateQuestNotifyCache() => default; // 0x0000000181B295A0-0x0000000181B29690
	// [XID] // 0x0000000189621A00-0x0000000189621A20
	public void InitLuaQuest() {} // 0x0000000181B3C380-0x0000000181B3C540
	// [XID] // 0x0000000189629310-0x0000000189629330
	public void PostInitLuaQuest() {} // 0x0000000181B30B30-0x0000000181B31140
	// [XID] // 0x0000000189630C60-0x0000000189630C80
	public void PostSoftInitLuaQuest() {} // 0x0000000181B3AF50-0x0000000181B3B270
	// [XID] // 0x000000018991E270-0x000000018991E290
	public List<QuestProxy> GetSubQuestListByMainID(uint mainQuestID) => default; // 0x0000000181B30430-0x0000000181B30520
	// [XID] // 0x000000018963FB50-0x000000018963FB70
	public List<QuestProxy> GetTracingSubQuestByMainID(uint mainQuestID) => default; // 0x0000000181B3D4E0-0x0000000181B3D700
	// [XID] // 0x0000000189647330-0x0000000189647350
	public bool IsMainQuestFinished(uint mainQuestID) => default; // 0x0000000181B30360-0x0000000181B30430
	// [XID] // 0x000000018964EA20-0x000000018964EA40
	public bool IsSubQuestFinished(uint questID) => default; // 0x0000000181B3AE50-0x0000000181B3AF50
	// [XID] // 0x00000001896562F0-0x0000000189656310
	public void ClearMainQuestFinished(uint mainQuestID) {} // 0x0000000181B35BB0-0x0000000181B35C80
	// [XID] // 0x000000018965DA10-0x000000018965DA30
	public void ClearMainQuestFinishedAll() {} // 0x0000000181B2C830-0x0000000181B2C8F0
	// [XID] // 0x000000018966C7C0-0x000000018966C7E0
	private void UpdateMainQuest(QuestProxy quest, bool isInit = false /* Metadata: 0x00AFF9E5 */) {} // 0x0000000181B353C0-0x0000000181B35A20
	// [XID] // 0x00000001896745D0-0x00000001896745F0
	private void TryRemoveFromQuestRedPointList(uint mainId) {} // 0x0000000181B2E190-0x0000000181B2E3F0
	// [XID] // 0x000000018967BF00-0x000000018967BF20
	private void TryAddToQuestRedPointList(QuestExcelConfigProxy quest, bool checkRedPoint = false /* Metadata: 0x00AFF9E6 */) {} // 0x0000000181B29DE0-0x0000000181B2A1F0
	// [XID] // 0x00000001896834F0-0x0000000189683510
	private void CheckNewQuestRedPoint(IList<Quest> questInfoList) {} // 0x0000000181B29740-0x0000000181B29990
	// [XID] // 0x000000018968B0B0-0x000000018968B0D0
	private void UpdateMainQuestState(uint mainQuestID, ref QuestExcelConfigProxy subQuest, QuestState newState, bool isInit) {} // 0x0000000181B27E10-0x0000000181B28160
	// [XID] // 0x0000000189692DB0-0x0000000189692DD0
	private void NotifyQuestHint(ref QuestExcelConfigProxy config, QuestHintType hintType) {} // 0x0000000181B37020-0x0000000181B37220
	// [XID] // 0x0000000189934690-0x00000001899346B0
	public QuestProxy GetQuest(uint questID) => default; // 0x0000000181B2D6D0-0x0000000181B2D7C0
	// [XID] // 0x00000001896A1880-0x00000001896A18A0
	public uint GetQuestMainID(uint questID) => default; // 0x0000000181B3B540-0x0000000181B3B630
	// [XID] // 0x00000001896A8D40-0x00000001896A8D60
	private bool IsNeedRewind(uint questID) => default; // 0x0000000181B28D40-0x0000000181B28E10
	// [XID] // 0x00000001896AFD70-0x00000001896AFD90
	private void AddToRewindDic(uint questID) {} // 0x0000000181B2C8F0-0x0000000181B2C9D0
	// [XID] // 0x00000001896B77A0-0x00000001896B77C0
	private void ClearFromFailedDic(uint questID) {} // 0x0000000181B270E0-0x0000000181B271B0
	// [XID] // 0x00000001896BE8D0-0x00000001896BE8F0
	private void UpdateQuest(Quest quest, bool isInit = false /* Metadata: 0x00AFF9E7 */) {} // 0x0000000181B36550-0x0000000181B36860
	// [XID] // 0x00000001896C61D0-0x00000001896C61F0
	private string GetShareConfigPath(uint mainQuestId) => default; // 0x0000000181B261F0-0x0000000181B26340
	// [XID] // 0x00000001896CD7F0-0x00000001896CD810
	private string GetClientConfigPath(uint mainQuestId) => default; // 0x0000000181B27AD0-0x0000000181B27C20
	// [XID] // 0x00000001896D4C20-0x00000001896D4C40
	private void UpdateQuestOnRequest(QuestProxy questProxy, Quest quest, bool isInit) {} // 0x0000000181B38F30-0x0000000181B39060
	// [XID] // 0x00000001896DC2A0-0x00000001896DC2C0
	private void CheckUpdateQuestRequests() {} // 0x0000000181B36090-0x0000000181B363C0
	// [XID] // 0x00000001896E3A70-0x00000001896E3A90
	private void OnPrepareQuestData(QuestUpdateRequest request) {} // 0x0000000181B3A890-0x0000000181B3A990
	// [XID] // 0x00000001896EAE60-0x00000001896EAE80
	private void CheckUpdateQuestRequestInternal(QuestUpdateRequest request, bool forceCheckMsg) {} // 0x0000000181B3D3F0-0x0000000181B3D4E0
	// [XID] // 0x00000001896F2230-0x00000001896F2250
	public void TryUpdateWaitingQuest(bool forceCheckMsg) {} // 0x0000000181B342C0-0x0000000181B34490
	// [XID] // 0x00000001896F9BD0-0x00000001896F9BF0
	private void UpdateMainQuestPre(QuestProxy quest, bool isInit) {} // 0x0000000181B23D40-0x0000000181B241D0
	// [XID] // 0x0000000189701420-0x0000000189701440
	private void UpdateQuestOnRequestInternal(QuestUpdateRequest request) {} // 0x0000000181B34550-0x0000000181B34CB0
	// [IDTag] // 0x0000000189708BE0-0x0000000189708C20
	// [XID] // 0x0000000189708BE0-0x0000000189708C20
	private void UpdateQuestPreBan(Quest quest) {} // 0x0000000181B26730-0x0000000181B268A0
	// [XID] // 0x00000001897133A0-0x00000001897133C0
	private void UpdateQuestPostBan(Quest quest) {} // 0x0000000181B2FCB0-0x0000000181B2FE20
	// [XID] // 0x000000018971AC20-0x000000018971AC40
	private void CallSafeRewind(QuestProxy quest) {} // 0x0000000181B238B0-0x0000000181B23A00
	// [XID] // 0x0000000189721F20-0x0000000189721F40
	private void RemoveQuest(QuestProxy quest) {} // 0x0000000181B36860-0x0000000181B36A70
	// [XID] // 0x0000000189729670-0x0000000189729690
	private void ClearQuest(QuestProxy quest, bool force) {} // 0x0000000181B30260-0x0000000181B30360
	// [XID] // 0x0000000189730E80-0x0000000189730EA0
	private void ClearAllQuest() {} // 0x0000000181B28160-0x0000000181B28330
	// [XID] // 0x0000000189738710-0x0000000189738730
	public void RequestQuestTalkHistory(uint mainQuestID) {} // 0x0000000181B30520-0x0000000181B30630
	// [XID] // 0x0000000189740490-0x00000001897404B0
	public override bool OnPacket(Packet packet) => default; // 0x0000000181B25D40-0x0000000181B261F0
	// [XID] // 0x0000000189747830-0x0000000189747850
	private bool OnQuestPacket(ushort dataType, Packet packet) => default; // 0x0000000181B3D310-0x0000000181B3D3F0
	// [XID] // 0x000000018974EFB0-0x000000018974EFD0
	private bool OnQuestPacketInternal(ushort dataType, Packet packet) => default; // 0x0000000181B275E0-0x0000000181B278E0
	// [XID] // 0x00000001897566A0-0x00000001897566C0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181B3CB90-0x0000000181B3CD50
	// [XID] // 0x000000018975DB10-0x000000018975DB30
	private void CheckProficientPlayer(Quest quest) {} // 0x0000000181B3A5C0-0x0000000181B3A730
	// [XID] // 0x00000001898F7050-0x00000001898F7070
	public void TryCloseCutScenePage() {} // 0x0000000181B2DCB0-0x0000000181B2DE50
	// [XID] // 0x000000018976CBC0-0x000000018976CBE0
	public bool TryGetQuestGuideAreaRadius(uint subQuestID, out float radius) {
		radius = default;
		return default;
	} // 0x0000000181B248E0-0x0000000181B249D0
	// [XID] // 0x0000000189774000-0x0000000189774020
	private void OnNpcTalkRsp(NpcTalkRsp rsp) {} // 0x0000000181B23A70-0x0000000181B23B40
	// [XID] // 0x000000018977B740-0x000000018977B760
	private void PerformNpcTalk(uint talkID) {} // 0x0000000181B376C0-0x0000000181B377B0
	// [XID] // 0x00000001897831D0-0x00000001897831F0
	public void RequestNpcTalk(uint entityRuntimeID, uint talkID) {} // 0x0000000181B2CD20-0x0000000181B2CE40
	// [XID] // 0x000000018978A7E0-0x000000018978A800
	private void OnQuestListNotify(QuestListNotify notify) {} // 0x0000000181B3C800-0x0000000181B3C8D0
	// [XID] // 0x0000000189791E40-0x0000000189791E60
	private void OnQuestListUpdateNotify(QuestListUpdateNotify notify) {} // 0x0000000181B2A1F0-0x0000000181B2A350
	// [XID] // 0x0000000189799510-0x0000000189799530
	private void OnQuestListUpdate(IList<Quest> questInfoList, bool isInit) {} // 0x0000000181B3C960-0x0000000181B3CB90
	// [XID] // 0x00000001897A1400-0x00000001897A1420
	private void OnQuestDelNotify(QuestDelNotify notify) {} // 0x0000000181B3BC00-0x0000000181B3C040
	// [IDTag] // 0x00000001897A8B20-0x00000001897A8B60
	// [XID] // 0x00000001897A8B20-0x00000001897A8B60
	public void FinishSubQuest(bool isFailed = false /* Metadata: 0x00AFF9E8 */, QuestProxy quest = null) {} // 0x0000000181B34F30-0x0000000181B35010
	// [IDTag] // 0x00000001897B3880-0x00000001897B38C0
	// [XID] // 0x00000001897B3880-0x00000001897B38C0
	public void FinishSubQuest(bool isFailed = false /* Metadata: 0x00AFF9E9 */, uint questID = 0 /* Metadata: 0x00AFF9EA */) {} // 0x0000000181B35010-0x0000000181B35230
	// [XID] // 0x00000001897BEC30-0x00000001897BEC50
	public void RequestAddQuestContentProgress(uint startQuestId) {} // 0x0000000181B2F630-0x0000000181B2F750
	// [XID] // 0x00000001897C60D0-0x00000001897C60F0
	private void OnQuestContentProgressRsp(AddQuestContentProgressRsp rsp) {} // 0x0000000181B29B10-0x0000000181B29C70
	// [XID] // 0x00000001897CD940-0x00000001897CD960
	public void CreateEntityReq(CreateReason reason, CreateEntityInfo.EntityOneofCase entityCase, uint configID, uint level, Vector3 initPos, Vector3 initRot, uint dropID = 0 /* Metadata: 0x00AFF9EE */, float scale = 1f /* Metadata: 0x00AFF9F2 */, uint sceneID = 3 /* Metadata: 0x00AFF9F6 */, string alias = "" /* Metadata: 0x00AFF9FA */, uint roomID = 0 /* Metadata: 0x00AFF9FE */, string metaPath = "" /* Metadata: 0x00AFFA02 */, uint chestDropId = 0 /* Metadata: 0x00AFFA06 */, bool isShowCutscene = false /* Metadata: 0x00AFFA0A */, GadgetBornType bornType = GadgetBornType.GadgetBornInAir /* Metadata: 0x00AFFA0B */, uint questId = 0 /* Metadata: 0x00AFFA0F */, uint questMainId = 0 /* Metadata: 0x00AFFA13 */) {} // 0x0000000181B2E3F0-0x0000000181B2EF80
	// [XID] // 0x00000001897D4EB0-0x00000001897D4ED0
	private void OnSceneCreateEntityRsp(SceneCreateEntityRsp rsp) {} // 0x0000000181B309D0-0x0000000181B30B30
	// [XID] // 0x00000001897DC610-0x00000001897DC630
	private void OnQuestCreateEntityRsp(QuestCreateEntityRsp rsp) {} // 0x0000000181B2AA00-0x0000000181B2B080
	// [XID] // 0x00000001897E4010-0x00000001897E4030
	private void OnEntityForceSyncRsp(EntityForceSyncRsp rsp) {} // 0x0000000181B301B0-0x0000000181B30260
	// [XID] // 0x00000001897EBB80-0x00000001897EBBA0
	private void OnGetQuestTalkHistoryRsp(GetQuestTalkHistoryRsp rsp) {} // 0x0000000181B388E0-0x0000000181B38AD0
	// [XID] // 0x00000001897F3450-0x00000001897F3470
	private void CacheAliasBind(string alias, uint entityId) {} // 0x0000000181B2A350-0x0000000181B2A460
	// [XID] // 0x00000001897FAE50-0x00000001897FAE70
	public void FlushAliasBind() {} // 0x0000000181B37B90-0x0000000181B37D90
	// [XID] // 0x0000000189802350-0x0000000189802370
	public void DestroyEntityReq(uint runtimeID, string alias, uint sceneId) {} // 0x0000000181B23470-0x0000000181B23740
	// [XID] // 0x0000000189809760-0x0000000189809780
	private void OnDestroyEntityRsp(QuestDestroyEntityRsp rsp) {} // 0x0000000181B2B2C0-0x0000000181B2B5A0
	// [XID] // 0x0000000189A8FEF0-0x0000000189A8FF10
	public void DestroyNpcEntityReq(uint configId, uint mainQuestId) {} // 0x0000000181B32910-0x0000000181B32B50
	// [XID] // 0x0000000189818A50-0x0000000189818A70
	public void RemoveNpcData(uint configId, uint mainQuestId, bool needCheckNpc) {} // 0x0000000181B37D90-0x0000000181B37F20
	// [XID] // 0x0000000189820290-0x00000001898202B0
	private void OnDestroyNpcEntityRsp(QuestDestroyNpcRsp rsp) {} // 0x0000000181B24A50-0x0000000181B24B10
	// [XID] // 0x00000001898278F0-0x0000000189827910
	public override void ClearOnLevelDestroy() {} // 0x0000000181B268A0-0x0000000181B26940
	// [XID] // 0x000000018982EB10-0x000000018982EB30
	public override void ClearOnDisconnect() {} // 0x0000000181B3B980-0x0000000181B3BC00
	// [XID] // 0x00000001898364B0-0x00000001898364D0
	public override void ClearOnBackHome() {} // 0x0000000181B2C700-0x0000000181B2C830
	// [XID] // 0x000000018983D8C0-0x000000018983D8E0
	private void OnFinishedParentQuestNotify(FinishedParentQuestNotify ntf) {} // 0x0000000181B24B10-0x0000000181B24D00
	// [XID] // 0x0000000189845190-0x00000001898451B0
	private void OnFinishedParentQuestUpdateNotify(FinishedParentQuestUpdateNotify ntf) {} // 0x0000000181B27C20-0x0000000181B27E10
	// [XID] // 0x000000018984C600-0x000000018984C620
	private void OnCancelFinishParentQuestNotify(CancelFinishParentQuestNotify ntf) {} // 0x0000000181B38670-0x0000000181B38740
	// [XID] // 0x0000000189853680-0x00000001898536A0
	private void FinishParentQuest(ParentQuest parentQuest, bool isInit) {} // 0x0000000181B31450-0x0000000181B31D40
	// [XID] // 0x000000018985B170-0x000000018985B190
	private void OnMainQuestStateChange(uint mainQuestID, bool isInit) {} // 0x0000000181B34130-0x0000000181B342C0
	// [XID] // 0x0000000189862670-0x0000000189862690
	private void CancelFinishedParentQuest(uint mainQuestID) {} // 0x0000000181B33A00-0x0000000181B33BF0
	// [XID] // 0x0000000189869A60-0x0000000189869A80
	public void LoadQuestVar(ParentQuest parentQuest) {} // 0x0000000181B2B660-0x0000000181B2B8F0
	// [XID] // 0x0000000189870D60-0x0000000189870D80
	public void SetQuestVar(uint questId, uint index, int value) {} // 0x0000000181B24480-0x0000000181B246E0
	// [XID] // 0x0000000189878790-0x00000001898787B0
	public void SetQuestVarByMainId(uint mainQuestId, uint index, int value) {} // 0x0000000181B2B080-0x0000000181B2B2C0
	// [XID] // 0x000000018987FD40-0x000000018987FD60
	public int GetQuestVar(uint questId, uint index) => default; // 0x0000000181B35A80-0x0000000181B35BB0
	// [XID] // 0x0000000189ACBE60-0x0000000189ACBE80
	public int GetQuestVarByMainId(uint mainQuestId, uint index) => default; // 0x0000000181B274C0-0x0000000181B275E0
	// [XID] // 0x000000018988E4C0-0x000000018988E4E0
	public void ClearQuestVar(uint mainQuestId) {} // 0x0000000181B2FF60-0x0000000181B300D0
	// [XID] // 0x0000000189895AE0-0x0000000189895B00
	public uint GetMainQuestIdBySubQuestId(uint subQuestId) => default; // 0x0000000181B34490-0x0000000181B34550
	// [XID] // 0x000000018989D180-0x000000018989D1A0
	public QuestState GetMainQuestStateById(uint id) => default; // 0x0000000181B3AB00-0x0000000181B3ABE0
	// [XID] // 0x00000001898A4AA0-0x00000001898A4AC0
	public QuestState GetMainQuestStateNew(uint mainQuestID) => default; // 0x0000000181B32620-0x0000000181B32910
	// [XID] // 0x0000000189619CD0-0x0000000189619CF0
	public string GetRandomFactorValue(uint questMainId, string type) => default; // 0x0000000181B377B0-0x0000000181B37A80
	// [XID] // 0x00000001898B3640-0x00000001898B3660
	public uint GetLackNPCSubQuestIdByMainID(uint mainId) => default; // 0x0000000181B34DA0-0x0000000181B34F30
	// [XID] // 0x00000001898BB470-0x00000001898BB490
	public uint GetLackSceneSubQuestIdByMainId(uint mainId) => default; // 0x0000000181B35230-0x0000000181B353C0
	// [XID] // 0x00000001898C2720-0x00000001898C2740
	private void OnChapterStateNotify(ChapterStateNotify ntf) {} // 0x0000000181B2DE50-0x0000000181B2E190
	// [XID] // 0x00000001898CA180-0x00000001898CA1A0
	private void OnQuestProgressUpdateNotify(QuestProgressUpdateNotify ntf) {} // 0x0000000181B31F10-0x0000000181B32050
	// [XID] // 0x00000001898D18D0-0x00000001898D18F0
	private void OnQuestProgressUpdate(QuestProgressUpdateNotify ntf) {} // 0x0000000181B2D930-0x0000000181B2DCB0
	// [XID] // 0x00000001898D9030-0x00000001898D9050
	private void OnQuestUpdateQuestVarNotify(QuestUpdateQuestVarNotify ntf) {} // 0x0000000181B3C040-0x0000000181B3C180
	// [XID] // 0x00000001898E0CF0-0x00000001898E0D10
	private void OnQuestVarUpdate(QuestUpdateQuestVarNotify ntf) {} // 0x0000000181B31D40-0x0000000181B31F10
	// [XID] // 0x00000001898E8860-0x00000001898E8880
	private void FireQuestProgressHintNotify(RepeatedMessageField<Quest> questList) {} // 0x0000000181B3D910-0x0000000181B3DC60
	// [XID] // 0x00000001898EFF80-0x00000001898EFFA0
	private void OnBargainStartNotify(BargainStartNotify startNotify) {} // 0x0000000181B257E0-0x0000000181B25940
	// [XID] // 0x00000001898F7810-0x00000001898F7830
	private void OnBargainPriceRsp(BargainOfferPriceRsp priceRsp) {} // 0x0000000181B31140-0x0000000181B312A0
	// [XID] // 0x00000001898FEEB0-0x00000001898FEED0
	private void OnBargainDataRsp(GetBargainDataRsp dataRsp) {} // 0x0000000181B3A730-0x0000000181B3A890
	// [XID] // 0x00000001899066D0-0x00000001899066F0
	private void OnAllActivatedBargainDataRsp(GetAllActivatedBargainDataRsp dataRsp) {} // 0x0000000181B38AD0-0x0000000181B38C30
	// [XID] // 0x000000018990E150-0x000000018990E170
	private void OnBargainEndNotify(BargainTerminateNotify endNoitfy) {} // 0x0000000181B2D570-0x0000000181B2D6D0
	// [XID] // 0x00000001899158A0-0x00000001899158C0
	public void BargainOfferPriceReq(uint bargainID, uint price) {} // 0x0000000181B3ABE0-0x0000000181B3AD00
	// [XID] // 0x000000018991D290-0x000000018991D2B0
	public void GetBargainDataReq(uint bargainID) {} // 0x0000000181B3C280-0x0000000181B3C380
	// [XID] // 0x0000000189924B40-0x0000000189924B60
	public void GetAllActivatedBargainDataReq() {} // 0x0000000181B33D40-0x0000000181B33E20
	// [XID] // 0x000000018992C080-0x000000018992C0A0
	private void OnServerCondMeetQuestListUpdateNotify(ServerCondMeetQuestListUpdateNotify data) {} // 0x0000000181B37480-0x0000000181B376C0
	// [XID] // 0x0000000189B16E40-0x0000000189B16E60
	public bool IsServerCondValid(uint questId) => default; // 0x0000000181B28330-0x0000000181B28400
	// [XID] // 0x000000018993B170-0x000000018993B190
	private void OnQuestGlobalVarUpdateNotify(QuestGlobalVarNotify data) {} // 0x0000000181B2BBE0-0x0000000181B2BE40
	// [XID] // 0x00000001899422C0-0x00000001899422E0
	public int GetQuestGlobalVar(uint id) => default; // 0x0000000181B3A4B0-0x0000000181B3A5C0
	// [XID] // 0x0000000189976B90-0x0000000189976BB0
	public override void InitOnLevelInit() {} // 0x0000000181B38740-0x0000000181B387E0
	// [XID] // 0x000000018997DFC0-0x000000018997DFE0
	private void OnPersonalLineAllDataRsp(PersonalLineAllDataRsp rsp) {} // 0x0000000181B2D050-0x0000000181B2D570
	// [XID] // 0x0000000189985B50-0x0000000189985B70
	public void SendPersonalLineAllDataReq() {} // 0x0000000181B3A170-0x0000000181B3A2A0
	// [XID] // 0x000000018998D760-0x000000018998D780
	private void OnRedeemLegendaryKeyRsp(RedeemLegendaryKeyRsp rsp) {} // 0x0000000181B278E0-0x0000000181B27AD0
	// [XID] // 0x0000000189995170-0x0000000189995190
	public void SendRedeemLegendaryKeyReq() {} // 0x0000000181B3A090-0x0000000181B3A170
	// [XID] // 0x000000018999CCB0-0x000000018999CCD0
	private void OnUnlockPersonalLineRsp(UnlockPersonalLineRsp rsp) {} // 0x0000000181B3A2A0-0x0000000181B3A4B0
	// [XID] // 0x00000001899A4530-0x00000001899A4550
	public void SendUnlockPersonalLineReq(uint id) {} // 0x0000000181B2A510-0x0000000181B2A610
	// [XID] // 0x00000001899ABF30-0x00000001899ABF50
	public bool IsPersonalLineFinished(uint chapterId) => default; // 0x0000000181B36A70-0x0000000181B36BA0
	// [XID] // 0x00000001899B37A0-0x00000001899B37C0
	public bool IsCanFetchPersonalLineKey() => default; // 0x0000000181B39F00-0x0000000181B3A090
	// [XID] // 0x00000001899BABA0-0x00000001899BABC0
	public List<uint> GetOnGoingMainQuestList() => default; // 0x0000000181B33550-0x0000000181B337F0
	[Preserve] // 0x00000001899C2590-0x00000001899C25D0
	// [XID] // 0x00000001899C2590-0x00000001899C25D0
	public string Dump(string tag) => default; // 0x0000000181B32050-0x0000000181B32620
	// [XID] // 0x00000001899D42E0-0x00000001899D4300
	public bool TryAddMainTracking(uint mainQuestID) => default; // 0x0000000181B36E20-0x0000000181B36F60
	// [XID] // 0x00000001899DB990-0x00000001899DB9B0
	private void AddMainTracking(uint mainQuestID) {} // 0x0000000181B28400-0x0000000181B28530
	// [XID] // 0x00000001899E31F0-0x00000001899E3210
	private void TryRemoveOldMainTrackingIfNeed(uint mainQuestID2Add) {} // 0x0000000181B363C0-0x0000000181B364A0
	// [XID] // 0x00000001899EA780-0x00000001899EA7A0
	public void RemoveMainTracking(uint mainQuestID, bool lateTrackSome = false /* Metadata: 0x00AFFA17 */, bool clearNavigation = true /* Metadata: 0x00AFFA18 */) {} // 0x0000000181B3B270-0x0000000181B3B450
	// [XID] // 0x00000001899F2290-0x00000001899F22B0
	public void ClearMainTracking() {} // 0x0000000181B337F0-0x0000000181B33A00
	// [XID] // 0x00000001899F98B0-0x00000001899F98D0
	public void RefreshMainTracking() {} // 0x0000000181B3C660-0x0000000181B3C800
	// [XID] // 0x0000000189A00C90-0x0000000189A00CB0
	private void DeepRefreshMainTracking() {} // 0x0000000181B2EF80-0x0000000181B2F410
	// [XID] // 0x0000000189A08570-0x0000000189A08590
	public void DeepRefreshTracking() {} // 0x0000000181B2A610-0x0000000181B2A750
	// [XID] // 0x0000000189A0FB70-0x0000000189A0FB90
	private void ClearLevelCoroutine() {} // 0x0000000181B37380-0x0000000181B37480
	// [XID] // 0x0000000189A16FF0-0x0000000189A17010
	public bool IsInMainTracking(uint mainQuestID) => default; // 0x0000000181B38C30-0x0000000181B38D00
	// [XID] // 0x0000000189A1E6E0-0x0000000189A1E700
	public bool IsMainTrackingEmpty() => default; // 0x0000000181B23740-0x0000000181B23800
	// [XID] // 0x0000000189A25E10-0x0000000189A25E30
	public void AddSubQuest(uint subQuestID) {} // 0x0000000181B28F30-0x0000000181B28FF0
	// [XID] // 0x0000000189A2D250-0x0000000189A2D270
	public bool IsOtherBigWorldGuide(QuestProxy quest, out uint bigWorldSceneId) {
		bigWorldSceneId = default;
		return default;
	} // 0x0000000181B33220-0x0000000181B33550
	// [XID] // 0x0000000189A34CB0-0x0000000189A34CD0
	private void AddSubTracking(QuestProxy quest) {} // 0x0000000181B39370-0x0000000181B39F00
	// [XID] // 0x0000000189A3C020-0x0000000189A3C040
	private void RemoveSubTracking(uint subQuestID) {} // 0x0000000181B33E20-0x0000000181B34130
	// [XID] // 0x0000000189A43CB0-0x0000000189A43CD0
	private void ClearSubTracking(uint mainQuestID) {} // 0x0000000181B2FAA0-0x0000000181B2FCB0
	// [XID] // 0x0000000189A4B120-0x0000000189A4B140
	private void ClearAllSubTracking() {} // 0x0000000181B3B630-0x0000000181B3B890
	// [XID] // 0x0000000189A52800-0x0000000189A52820
	public uint GetFirstSubQuestID(uint mainQuestID) => default; // 0x0000000181B2F920-0x0000000181B2F9F0
	// [XID] // 0x0000000189A6F2A0-0x0000000189A6F2C0
	private void TryTrackSome(bool lateTrackSome) {} // 0x0000000181B30840-0x0000000181B309D0
	// [XID] // 0x0000000189A76B00-0x0000000189A76B20
	private void TrackSome() {} // 0x0000000181B26D10-0x0000000181B270E0
	// [XID] // 0x0000000189A7E420-0x0000000189A7E440
	private bool TryTrackSuggest() => default; // 0x0000000181B246E0-0x0000000181B248E0
	// [XID] // 0x0000000189A85D90-0x0000000189A85DB0
	private bool AddSuggestTrack(uint[] suggestTrackMainQuestList, bool suggestTrackOutOfOrder) => default; // 0x0000000181B3C540-0x0000000181B3C660
	// [XID] // 0x0000000189A8D650-0x0000000189A8D670
	private void NavigationSuggest(uint mainQuestID, uint[] suggestTrackMainQuestList, bool isInit) {} // 0x0000000181B38070-0x0000000181B383D0
	// [XID] // 0x0000000189A94C10-0x0000000189A94C30
	private void TryNavigationSuggest(uint mainQuestID = 0 /* Metadata: 0x00AFFA19 */) {} // 0x0000000181B35DD0-0x0000000181B36090
	// [XID] // 0x0000000189A9C490-0x0000000189A9C4B0
	private bool IsInMainNavigation(uint mainQuestID) => default; // 0x0000000181B26940-0x0000000181B26A40
	// [XID] // 0x0000000189AA3BE0-0x0000000189AA3C00
	public void ClearSuggestNavigation() {} // 0x0000000181B36BA0-0x0000000181B36C60
	// [XID] // 0x0000000189AAB1B0-0x0000000189AAB1D0
	private void SnapshootTrackingLocalData() {} // 0x0000000181B2B5A0-0x0000000181B2B660
	// [XID] // 0x0000000189AB2B60-0x0000000189AB2B80
	public void ResetTrackingLocalData(List<uint> initParams = null) {} // 0x0000000181B3CF10-0x0000000181B3D0F0
	// [XID] // 0x0000000189ABA6E0-0x0000000189ABA700
	private void AddTrackingLocalData(uint mainQuestID) {} // 0x0000000181B3D0F0-0x0000000181B3D2B0
	// [XID] // 0x0000000189AC1FF0-0x0000000189AC2010
	private void RemoveTrackingLocalData(uint mainQuestID) {} // 0x0000000181B2FE20-0x0000000181B2FF60
	// [XID] // 0x0000000189AD8DB0-0x0000000189AD8DD0
	public bool TryEnablePaimonNavigation(uint mainQuestID, bool isInit) => default; // 0x0000000181B32B50-0x0000000181B330F0
	// [XID] // 0x0000000189AE0840-0x0000000189AE0860
	public static bool IsSameSubQuestIdList(List<uint> list1, List<uint> list2) => default; // 0x0000000181B2D7C0-0x0000000181B2D930
	// [XID] // 0x0000000189AE7D70-0x0000000189AE7D90
	public void DisablePaimenNavigation() {} // 0x0000000181B387E0-0x0000000181B388E0
	// [XID] // 0x0000000189AEFAA0-0x0000000189AEFAC0
	private bool IsPaimenNavigationAlreadyInArea(uint subQuestId) => default; // 0x0000000181B30630-0x0000000181B30840
	// [XID] // 0x0000000189AF6F80-0x0000000189AF6FA0
	private bool StartPaimenNavigation(List<uint> subQuestIDs) => default; // 0x0000000181B3D700-0x0000000181B3D910
	// [XID] // 0x0000000189AFE590-0x0000000189AFE5B0
	private void ResetPaimonNavigation() {} // 0x0000000181B29A40-0x0000000181B29B10
	// [IDTag] // 0x0000000189B05DE0-0x0000000189B05E20
	// [XID] // 0x0000000189B05DE0-0x0000000189B05E20
	private void ClearPaimonNavigation(uint mainQuestID) {} // 0x0000000181B290F0-0x0000000181B291B0
	// [IDTag] // 0x0000000189B106B0-0x0000000189B106F0
	// [XID] // 0x0000000189B106B0-0x0000000189B106F0
	private void ClearPaimonNavigation() {} // 0x0000000181B28FF0-0x0000000181B290F0
	// [XID] // 0x0000000189B1A9C0-0x0000000189B1A9E0
	private void ClearSubQuestPaimonNavigation() {} // 0x0000000181B35C80-0x0000000181B35DD0
	// [XID] // 0x0000000189B21FB0-0x0000000189B21FD0
	private void RemoveSubQuestPaimonNavigation(uint subQuestID) {} // 0x0000000181B39060-0x0000000181B392A0
	// [XID] // 0x0000000189B295A0-0x0000000189B295C0
	private void ClearTrackingOnLevelDestroy() {} // 0x0000000181B264A0-0x0000000181B265C0
	// [XID] // 0x0000000189B30AF0-0x0000000189B30B10
	private void ClearTrackingOnDisconnect() {} // 0x0000000181B3CE00-0x0000000181B3CF10
	// [XID] // 0x0000000189B381D0-0x0000000189B381F0
	private void ClearTrackingOnBackHome() {} // 0x0000000181B31390-0x0000000181B31450
}

