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

public static class TalkExcelConfigLoader // TypeDefIndex: 14891
{
	// Fields
	private static Dictionary<uint, Dictionary<uint, List<TalkExcelConfig>>> _npcID2TalkList; // 0x00
	private static Dictionary<uint, TalkExcelConfig> _firstTalkDic; // 0x08
	private static TickDictionary<uint, NpcTalkProxy> _npcTalkProxyDic; // 0x10
	private static List<TalkExcelConfig> _tempValidTalkList; // 0x18
	private static Dictionary<uint, TalkExcelConfig> _dataDict; // 0x20
	public static Action<List<DataHotfixMeta>, List<TalkExcelConfig>> customApplyHotfixAction; // 0x28
	public static Action<TalkExcelConfig, TalkExcelConfig> onUpdateConfig; // 0x30
	public static Action onApplyHotfixFinish; // 0x38
	public static Func<List<DataHotfixMeta>, List<TalkExcelConfig>, Dictionary<uint, TalkExcelConfig>, string, bool> customValidateFunc; // 0x40

	// Properties
	public static Dictionary<uint, TalkExcelConfig> dataDict { /* [XID] */ /* 0x0000000189893950-0x0000000189893970 */ get; } // 0x00000001815F9C40-0x00000001815F9D10 
	private static string FILE_LOCATION { /* [XID] */ /* 0x00000001898A23E0-0x00000001898A2400 */ get; } // 0x00000001815F7980-0x00000001815F7A20 

	// Nested types
	public class NpcTalkProxy : ITickableObject<uint> // TypeDefIndex: 14892
	{
		// Fields
		private uint _npcConfigId; // 0x10
		private bool _isDirty; // 0x14
		private List<TalkExcelConfig> _validTalkList; // 0x18

		// Properties
		public uint key { /* [XID] */ /* 0x0000000189904410-0x0000000189904430 */ get => default; } // 0x0000000181615AC0-0x0000000181615B60 
		public bool isDirty { /* [XID] */ /* 0x000000018990BA50-0x000000018990BA70 */ get => default; } // 0x0000000181615ED0-0x0000000181615F70 
		public uint validTalkId { /* [XID] */ /* 0x0000000189913580-0x00000001899135A0 */ get => default; } // 0x0000000181615B60-0x0000000181615CB0 
		public int index { get; set; } // 0x0000000181615E10-0x0000000181615E70 0x0000000181615E70-0x0000000181615ED0

		// Constructors
		public NpcTalkProxy() {} // 0x0000000181616010-0x0000000181616080

		// Methods
		// [XID] // 0x0000000189929C80-0x0000000189929CA0
		public void Tick(float deltaTime) {} // 0x0000000181615D60-0x0000000181615E10
		// [XID] // 0x00000001899313E0-0x0000000189931400
		public void ResetObject() {} // 0x0000000181615F70-0x0000000181616010
		// [XID] // 0x00000001899388F0-0x0000000189938910
		public void Init(uint configId) {} // 0x0000000181615CB0-0x0000000181615D60
		// [XID] // 0x0000000189940140-0x0000000189940160
		public void Refresh(bool dirty, List<TalkExcelConfig> talkList) {} // 0x0000000181615950-0x0000000181615AC0
	}

	// Constructors
	static TalkExcelConfigLoader() {} // 0x00000001815FA490-0x00000001815FA5B0

	// Methods
	// [XID] // 0x0000000189858CC0-0x0000000189858CE0
	private static List<TalkExcelConfig> GetTalkListByNpcID(uint npcConfigID, uint questID, out bool hasFallback) {
		hasFallback = default;
		return default;
	} // 0x00000001815F9330-0x00000001815F9520
	// [XID] // 0x000000018985FEF0-0x000000018985FF10
	private static void AddTalkListByNpcID(uint npcConfigID, TalkExcelConfig talkConfig) {} // 0x00000001815F8A10-0x00000001815F8D40
	// [XID] // 0x0000000189867530-0x0000000189867550
	private static void BuildFirstTalk() {} // 0x00000001815F7560-0x00000001815F77E0
	// [XID] // 0x000000018986ED10-0x000000018986ED30
	public static uint GetValidTalkByNpcID(uint npcConfigID, uint mainQuestId) => default; // 0x00000001815F8170-0x00000001815F8770
	// [XID] // 0x00000001898761C0-0x00000001898761E0
	public static void SetNpcTalkDirty() {} // 0x00000001815F88A0-0x00000001815F8A10
	// [XID] // 0x000000018987DD60-0x000000018987DD80
	public static void ClearNpcTalkProxy() {} // 0x00000001815F9520-0x00000001815F9600
	// [XID] // 0x0000000189884D10-0x0000000189884D30
	public static void BuildIndex() {} // 0x00000001815F9D10-0x00000001815FA080
	// [XID] // 0x000000018988C380-0x000000018988C3A0
	public static void Register() {} // 0x00000001815FA3D0-0x00000001815FA490
	// [XID] // 0x000000018989B090-0x000000018989B0B0
	public static TalkExcelConfig GetData(uint id) => default; // 0x00000001815F77E0-0x00000001815F7980
	// [XID] // 0x00000001898A99D0-0x00000001898A99F0
	public static void LoadData() {} // 0x00000001815F8770-0x00000001815F88A0
	// [XID] // 0x00000001898B1360-0x00000001898B1380
	private static void RegisterHotfixGenerated() {} // 0x00000001815F7F00-0x00000001815F8170
	// [XID] // 0x00000001898B8D00-0x00000001898B8D20
	public static void ApplyHotfix(JSONNode node) {} // 0x00000001815F7A20-0x00000001815F7F00
	// [IDTag] // 0x00000001898C02E0-0x00000001898C0320
	// [XID] // 0x00000001898C02E0-0x00000001898C0320
	public static bool ValidateHotfix(JSONNode node) => default; // 0x00000001815F8E80-0x00000001815F8FE0
	// [XID] // 0x00000001898CAC40-0x00000001898CAC60
	private static bool ParseHotfix(JSONNode node, out List<DataHotfixMeta> metaList, out List<TalkExcelConfig> configList) {
		metaList = default;
		configList = default;
		return default;
	} // 0x00000001815FA080-0x00000001815FA3D0
	// [XID] // 0x00000001898D2310-0x00000001898D2330
	private static bool ParseConfigFromLine(string line, out TalkExcelConfig data) {
		data = default;
		return default;
	} // 0x00000001815F8D40-0x00000001815F8E80
	// [IDTag] // 0x00000001898D9B70-0x00000001898D9BB0
	// [XID] // 0x00000001898D9B70-0x00000001898D9BB0
	private static bool ValidateHotfix(List<DataHotfixMeta> metaList, List<TalkExcelConfig> configList) => default; // 0x00000001815F8FE0-0x00000001815F9330
	// [IDTag] // 0x00000001898E46E0-0x00000001898E4720
	// [XID] // 0x00000001898E46E0-0x00000001898E4720
	public static bool FromBinary(int threadFlag = 0 /* Metadata: 0x00AEF923 */, bool useObjectPool = false /* Metadata: 0x00AEF927 */) => default; // 0x00000001815F9990-0x00000001815F9C40
	// [IDTag] // 0x00000001898EF260-0x00000001898EF2A0
	// [XID] // 0x00000001898EF260-0x00000001898EF2A0
	public static bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF928 */, bool useObjectPool = false /* Metadata: 0x00AEF92C */) => default; // 0x00000001815F9600-0x00000001815F9990
}

