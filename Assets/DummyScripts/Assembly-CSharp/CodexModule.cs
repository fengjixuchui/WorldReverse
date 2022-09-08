/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CodexModule : BaseModule // TypeDefIndex: 21422
{
	// Fields
	private Dictionary<ulong, ConfigLoadRequest> _codexQuestRequestDict; // 0x10
	private Dictionary<uint, ConfigCodexQuest> _codexQuestDict; // 0x18
	private Dictionary<ulong, uint> _codexPath2IdDict; // 0x20
	private Action<uint, ConfigCodexQuest> _actionOnLoadConfigCodexQuest; // 0x28
	public const float JoypadDelayForQuickNavi = 0.3f; // Metadata: 0x00AFF7D5
	private Dictionary<CodexType, List<CodexItemState>> _allCodexDict; // 0x30
	private Dictionary<uint, List<CodexItemState>> _pushTipsGroupDict; // 0x38
	private ulong _lastRequestMonsterBeKilledNumTime; // 0x40
	private Dictionary<uint, uint> _codexMonsterBeKilledDic; // 0x48

	// Properties
	private static string CODEX_QUEST_CONFIG_PRE_PATH { /* [XID] */ /* 0x0000000189B948F0-0x0000000189B94910 */ get => default; } // 0x0000000182916730-0x00000001829167D0 

	// Nested types
	public class CodexBookData // TypeDefIndex: 21423
	{
		// Fields
		public DocumentExcelConfig dConfig; // 0x10
		public CodexItemState state; // 0x18
		public uint descHash; // 0x20

		// Properties
		public bool isGot { /* [XID] */ /* 0x0000000189695BD0-0x0000000189695BF0 */ get => default; } // 0x00000001829276B0-0x0000000182927760 

		// Constructors
		public CodexBookData() {} // 0x0000000182927760-0x00000001829277C0
	}

	public class CodexBooksSet // TypeDefIndex: 21424
	{
		// Fields
		public uint setId; // 0x10
		public string setText; // 0x18
		public List<CodexBookData> books; // 0x20
		public MaterialExcelConfig mConfig; // 0x28

		// Constructors
		public CodexBooksSet() {} // 0x00000001829288A0-0x0000000182928900

		// Methods
		// [XID] // 0x000000018969D300-0x000000018969D320
		public int GetGollectedCount() => default; // 0x00000001829286F0-0x00000001829288A0
	}

	public class CodexViewData // TypeDefIndex: 21425
	{
		// Fields
		public CodexItemState state; // 0x10
		public ViewCodexExcelConfig viewConfig; // 0x18

		// Properties
		public bool isUnlocked { /* [XID] */ /* 0x00000001896A4400-0x00000001896A4420 */ get => default; } // 0x0000000182926B30-0x0000000182926BE0 

		// Constructors
		public CodexViewData() {} // 0x0000000182926BE0-0x0000000182926C40
	}

	public class CodexWeaponData // TypeDefIndex: 21426
	{
		// Fields
		public CodexItemState state; // 0x10
		public WeaponCodexExcelConfig codexConfig; // 0x18

		// Properties
		public bool isUnlocked { /* [XID] */ /* 0x00000001896ABBF0-0x00000001896ABC10 */ get => default; } // 0x00000001829268F0-0x00000001829269A0 

		// Constructors
		public CodexWeaponData() {} // 0x00000001829269A0-0x0000000182926A00
	}

	public class CodexReliquaryData // TypeDefIndex: 21427
	{
		// Fields
		public CodexItemState state; // 0x10
		public ReliquaryCodexExcelConfig codexConfig; // 0x18

		// Properties
		public bool isUnlocked { /* [XID] */ /* 0x00000001896B2D30-0x00000001896B2D50 */ get => default; } // 0x0000000182926F70-0x0000000182927020 

		// Constructors
		public CodexReliquaryData() {} // 0x0000000182927020-0x0000000182927080
	}

	public class CodexCreatureData // TypeDefIndex: 21428
	{
		// Fields
		public CodexItemState state; // 0x10
		public AnimalCodexExcelConfig codexConfig; // 0x18

		// Properties
		public bool isUnlocked { /* [XID] */ /* 0x00000001896BA450-0x00000001896BA470 */ get => default; } // 0x0000000182926D30-0x0000000182926DE0 

		// Constructors
		public CodexCreatureData() {} // 0x0000000182926DE0-0x0000000182926E40
	}

	public class CodexMaterialData // TypeDefIndex: 21429
	{
		// Fields
		public CodexItemState state; // 0x10
		public MaterialCodexExcelConfig codexConfig; // 0x18

		// Properties
		public bool isUnlocked { /* [XID] */ /* 0x00000001896C16A0-0x00000001896C16C0 */ get => default; } // 0x0000000182927D40-0x0000000182927DF0 

		// Constructors
		public CodexMaterialData() {} // 0x0000000182927DF0-0x0000000182927E50
	}

	// Constructors
	public CodexModule() {} // 0x000000018291DF60-0x000000018291E0D0

	// Methods
	// [XID] // 0x0000000189AA09E0-0x0000000189AA0A00
	public bool LoadQuestConfig(uint mainQuestConfigId, Action<uint, ConfigCodexQuest> actionOnLoadConfigCodexQuest, bool asyncLoad = true /* Metadata: 0x00AFF7CC */) => default; // 0x0000000182918A00-0x0000000182918D90
	// [XID] // 0x0000000189AA7FA0-0x0000000189AA7FC0
	private ConfigLoadRequest.LoadState GetMainQuestSchemeLoadState(uint mainQuestConfigId) => default; // 0x000000018291D600-0x000000018291D700
	// [XID] // 0x0000000189AAFC50-0x0000000189AAFC70
	private ConfigLoadAndSerializePattern GetQuestConfig(Action onLoadFinish) => default; // 0x000000018291AB20-0x000000018291ACB0
	// [XID] // 0x0000000189AB7390-0x0000000189AB73B0
	private object QuestConfigSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFF7CD */) => default; // 0x000000018291B5A0-0x000000018291B6B0
	// [XID] // 0x0000000189ABEDF0-0x0000000189ABEE10
	private object QuestConfigSerializeJson(JSONNode node) => default; // 0x00000001829177A0-0x00000001829178A0
	// [XID] // 0x0000000189AC68D0-0x0000000189AC68F0
	private void OnQuestConfigAsyncSerialized(object obj, ulong path) {} // 0x000000018291A190-0x000000018291A270
	// [XID] // 0x0000000189ACE0F0-0x0000000189ACE110
	private void OnQuestConfigSerialized(object obj, ulong path, bool isAsync) {} // 0x000000018291BBF0-0x000000018291BED0
	// [XID] // 0x0000000189AD5DA0-0x0000000189AD5DC0
	public List<CodexItemState> GetCodexList(CodexType type) => default; // 0x0000000182917540-0x0000000182917650
	private void RemoveDisuseDataCodex<T>(Dictionary<uint, T> dataDict) {}
	// [XID] // 0x0000000189ADD790-0x0000000189ADD7B0
	private bool IsDataDisuse(object data) => default; // 0x000000018291CB70-0x000000018291CF30
	// [XID] // 0x0000000189AE4F60-0x0000000189AE4F80
	private static int CompareBySortOrder(CodexItemState x, CodexItemState y) => default; // 0x0000000182918820-0x0000000182918900
	// [XID] // 0x0000000189AEC5A0-0x0000000189AEC5C0
	private static int CompareByViewedAndSortOrder(CodexItemState x, CodexItemState y) => default; // 0x000000018291D850-0x000000018291D940
	// [XID] // 0x0000000189AF4090-0x0000000189AF40B0
	public bool IsAnyCodexNotViewed(CodexType type) => default; // 0x000000018291A270-0x000000018291A440
	// [IDTag] // 0x0000000189AFB800-0x0000000189AFB840
	// [XID] // 0x0000000189AFB800-0x0000000189AFB840
	public void SetCodexViewed(CodexType type, uint id) {} // 0x000000018291C9A0-0x000000018291CB70
	// [IDTag] // 0x0000000189B05E60-0x0000000189B05EA0
	// [XID] // 0x0000000189B05E60-0x0000000189B05EA0
	public void SetCodexViewed(CodexType type, IEnumerable<uint> ids) {} // 0x000000018291C750-0x000000018291C9A0
	// [XID] // 0x0000000189B10730-0x0000000189B10750
	private void OnViewCodexRsp(ViewCodexRsp rsp) {} // 0x00000001829194F0-0x0000000182919800
	// [XID] // 0x0000000189B17860-0x0000000189B17880
	public override bool OnPacket(Packet packet) => default; // 0x00000001829178A0-0x0000000182917A40
	// [XID] // 0x0000000189B1F120-0x0000000189B1F140
	private void OnCodexDataFullNotify(CodexDataFullNotify notify) {} // 0x0000000182916EE0-0x0000000182917540
	// [XID] // 0x0000000189B269F0-0x0000000189B26A10
	private void OnCodexDataUpdateNotify(CodexDataUpdateNotify notify) {} // 0x0000000182918E90-0x0000000182919460
	// [XID] // 0x0000000189B2DBC0-0x0000000189B2DBE0
	public override void ClearOnDisconnect() {} // 0x000000018291D4B0-0x000000018291D550
	// [XID] // 0x0000000189B34FF0-0x0000000189B35010
	public override void ClearOnLevelDestroy() {} // 0x0000000182917B40-0x0000000182917BE0
	// [XID] // 0x0000000189B3C8C0-0x0000000189B3C8E0
	public override void ClearOnBackHome() {} // 0x0000000182919800-0x00000001829198C0
	// [XID] // 0x0000000189B44670-0x0000000189B44690
	public List<CodexItemState> GetPushTipsGroup(uint groupId) => default; // 0x0000000182917650-0x0000000182917720
	// [XID] // 0x0000000189B4BE00-0x0000000189B4BE20
	private void CheckLoadDataCodexPushTips() {} // 0x000000018291D770-0x000000018291D850
	// [XID] // 0x0000000189B532B0-0x0000000189B532D0
	public List<CodexItemState> GetCodexPushTipsConfigs(PushTipsCodexType type, string filter = null) => default; // 0x000000018291BFB0-0x000000018291C600
	// [XID] // 0x0000000189B5AC50-0x0000000189B5AC70
	public void SetPushTipsViewed(CodexItemState state) {} // 0x0000000182916C70-0x0000000182916EE0
	// [XID] // 0x0000000189B62050-0x0000000189B62070
	private void CheckLoadDataCodexQuest() {} // 0x0000000182918D90-0x0000000182918E90
	// [IDTag] // 0x0000000189B69C90-0x0000000189B69CD0
	// [XID] // 0x0000000189B69C90-0x0000000189B69CD0
	public List<CodexItemState> GetCodexQuests(QuestType type) => default; // 0x000000018291B130-0x000000018291B540
	// [XID] // 0x0000000189B73FE0-0x0000000189B74000
	public List<ChapterExcelConfig> GetCodexQuestChapters(QuestType type) => default; // 0x0000000182919B50-0x0000000182919E90
	// [XID] // 0x0000000189B7B610-0x0000000189B7B630
	public bool IsCodexQuestChapterViewed(QuestType type, uint chapterId) => default; // 0x0000000182919E90-0x000000018291A0B0
	// [IDTag] // 0x0000000189B82FE0-0x0000000189B83020
	// [XID] // 0x0000000189B82FE0-0x0000000189B83020
	public List<uint> GetCodexQuests(QuestType type, uint chapterId) => default; // 0x000000018291AF10-0x000000018291B130
	// [XID] // 0x0000000189B8D130-0x0000000189B8D150
	public Dictionary<uint, CodexItemState> GetCodexQuestState(QuestType type) => default; // 0x00000001829198C0-0x0000000182919AD0
	// [XID] // 0x0000000189B9BFA0-0x0000000189B9BFC0
	public static ConfigCodexQuest GetConfigCodexQuest(uint mainQuestId) => default; // 0x000000018291BA10-0x000000018291BBF0
	// [XID] // 0x0000000189BA36D0-0x0000000189BA36F0
	private static ConfigCodexQuest CodexQuestConfigSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFF7D1 */) => default; // 0x000000018291AD90-0x000000018291AE90
	// [XID] // 0x0000000189BAAAA0-0x0000000189BAAAC0
	private static ConfigCodexQuest CodexQuestConfigSerializeJson(JSONNode node) => default; // 0x0000000182918900-0x0000000182918A00
	// [XID] // 0x0000000189BB2010-0x0000000189BB2030
	private void CheckLoadDataCodexBooks() {} // 0x000000018291C600-0x000000018291C750
	// [XID] // 0x0000000189BB9400-0x0000000189BB9420
	public List<CodexBooksSet> GetCodexBooks() => default; // 0x000000018291A440-0x000000018291A980
	// [XID] // 0x0000000189BC11E0-0x0000000189BC1200
	private void CheckLoadDataCodexView() {} // 0x000000018291B6B0-0x000000018291B7F0
	// [XID] // 0x0000000189BC8A40-0x0000000189BC8A60
	public Dictionary<uint, List<CodexViewData>> GetCodexView() => default; // 0x00000001829167D0-0x0000000182916C70
	// [XID] // 0x0000000189BD01B0-0x0000000189BD01D0
	private void CheckLoadDataCodexWeapon() {} // 0x000000018291ACB0-0x000000018291AD90
	// [XID] // 0x0000000189BD7830-0x0000000189BD7850
	public List<CodexWeaponData> GetCodexWeaponConfigs() => default; // 0x000000018291CF30-0x000000018291D330
	// [XID] // 0x0000000189BDF3A0-0x0000000189BDF3C0
	private void CheckLoadDataCodexReliquary() {} // 0x000000018291BED0-0x000000018291BFB0
	// [XID] // 0x00000001895EBF70-0x00000001895EBF90
	public Dictionary<uint, List<CodexReliquaryData>> GetCodexReliquaryConfigs() => default; // 0x00000001829182B0-0x0000000182918750
	// [XID] // 0x00000001895F3350-0x00000001895F3370
	private void CheckLoadDataCodexCreature() {} // 0x0000000182917A40-0x0000000182917B40
	// [XID] // 0x00000001895FAC70-0x00000001895FAC90
	public Dictionary<uint, List<CodexCreatureData>> GetCodexCreatureConfigs(AnimalCodexType type) => default; // 0x0000000182917E30-0x00000001829182B0
	// [XID] // 0x0000000189602580-0x00000001896025A0
	public void RequestMonsterBeKilledNum(List<uint> list) {} // 0x000000018291A980-0x000000018291AB20
	// [XID] // 0x0000000189609DF0-0x0000000189609E10
	public bool TryGetMonsterBeKilledNum(uint uid, out uint num) {
		num = default;
		return default;
	} // 0x000000018291A0B0-0x000000018291A190
	// [XID] // 0x0000000189611620-0x0000000189611640
	private void OnQueryCodexMonsterBeKilledNumRsp(QueryCodexMonsterBeKilledNumRsp rsp) {} // 0x000000018291D940-0x000000018291DB80
	// [XID] // 0x0000000189618F20-0x0000000189618F40
	private void CheckLoadDataCodexMaterial() {} // 0x000000018291B840-0x000000018291B960
	// [XID] // 0x0000000189620460-0x0000000189620480
	public List<CodexMaterialData> GetCodexMaterialConfigs(MaterialCodexType type) => default; // 0x000000018291DB80-0x000000018291DF60
	// [XID] // 0x0000000189627910-0x0000000189627930
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000182917BE0-0x0000000182917CD0
	// [XID] // 0x000000018962F310-0x000000018962F330
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x000000018291D400-0x000000018291D4B0
}

