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
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class ExternalVoiceData // TypeDefIndex: 19366
{
	// Fields
	private static readonly Dictionary<uint, ExternalVoiceItem> _items; // 0x00
	private static readonly Dictionary<ExternalVoiceIdentity, uint> _identityLut; // 0x08
	private static readonly Dictionary<string, string> _emosyncLut; // 0x10
	private static readonly Dictionary<uint, uint> _itemFileLut; // 0x18
	private static readonly ConfigMetaConfig.PathHash _voiceLutPathHash; // 0x20
	private static readonly ConfigMetaConfig.PathHash _emoMapPathHash; // 0x30
	private static readonly ConfigMetaConfig.PathHash _innerPathHash; // 0x40
	private static readonly ConfigMetaConfig.PathHash _allVoicesPathHash; // 0x50
	private const string dataFolder = "Data"; // Metadata: 0x00AFC77E
	private const string txtPath = "/_JsonOutput"; // Metadata: 0x00AFC786
	private const string binPath = "/_BinOutput"; // Metadata: 0x00AFC796
	private const string voiceFolder = "/Voice/"; // Metadata: 0x00AFC7A5
	private const string leafFolder = "Items/"; // Metadata: 0x00AFC7B0
	private static readonly string voiceDataFolderTxtPath; // 0x60
	private static readonly string voiceDataFolderBinPath; // 0x68

	// Nested types
	private static class TriggerNameInterpreter // TypeDefIndex: 19367
	{
		// Fields
		private static readonly Dictionary<string, AudioVoiceTrigger> _lut; // 0x00

		// Constructors
		static TriggerNameInterpreter() {} // 0x00000001837F64F0-0x00000001837F6860

		// Methods
		// [XID] // 0x00000001896ED6D0-0x00000001896ED6F0
		public static AudioVoiceTrigger Interprete(string name) => default; // 0x00000001837F63B0-0x00000001837F64F0
	}

	private class ConfigAbstraction : ConfigObjectDictionaryAbstraction<string, ConfigExternalVoiceItem> // TypeDefIndex: 19368
	{
		// Constructors
		public ConfigAbstraction() {} // 0x00000001837F7020-0x00000001837F7090

		// Methods
		// [XID] // 0x0000000189A2D3D0-0x0000000189A2D3F0
		protected override void DictionaryFromBinary(ByteArray bytes, out Dictionary<string, ConfigExternalVoiceItem> dictionary) {
			dictionary = default;
		} // 0x00000001837F6F20-0x00000001837F7020
		// [XID] // 0x0000000189A34E90-0x0000000189A34EB0
		protected override void DictionaryFromJson(JSONNode json, out Dictionary<string, ConfigExternalVoiceItem> dictionary) {
			dictionary = default;
		} // 0x00000001837F6E30-0x00000001837F6F20
	}

	private class ConfigIndexDictionaryAbstraction : ConfigObjectDictionaryAbstraction<uint, ConfigExternalVoiceLookupItem> // TypeDefIndex: 19369
	{
		// Constructors
		public ConfigIndexDictionaryAbstraction() {} // 0x00000001837F6210-0x00000001837F6280

		// Methods
		// [XID] // 0x0000000189A3C2B0-0x0000000189A3C2D0
		protected override void DictionaryFromBinary(ByteArray bytes, out Dictionary<uint, ConfigExternalVoiceLookupItem> dictionary) {
			dictionary = default;
		} // 0x00000001837F6110-0x00000001837F6210
		// [XID] // 0x0000000189A43E90-0x0000000189A43EB0
		protected override void DictionaryFromJson(JSONNode json, out Dictionary<uint, ConfigExternalVoiceLookupItem> dictionary) {
			dictionary = default;
		} // 0x00000001837F6020-0x00000001837F6110
	}

	private class ConfigEmoDictionaryAbstraction : ConfigObjectDictionaryAbstraction<string, string> // TypeDefIndex: 19370
	{
		// Constructors
		public ConfigEmoDictionaryAbstraction() {} // 0x00000001837F5FB0-0x00000001837F6020

		// Methods
		// [XID] // 0x0000000189A4B380-0x0000000189A4B3A0
		protected override void DictionaryFromBinary(ByteArray bytes, out Dictionary<string, string> dictionary) {
			dictionary = default;
		} // 0x00000001837F5EB0-0x00000001837F5FB0
		// [XID] // 0x0000000189A52A00-0x0000000189A52A20
		protected override void DictionaryFromJson(JSONNode json, out Dictionary<string, string> dictionary) {
			dictionary = default;
		} // 0x00000001837F5DC0-0x00000001837F5EB0
	}

	// Constructors
	static ExternalVoiceData() {} // 0x00000001837D8660-0x00000001837D8960

	// Methods
	// [XID] // 0x0000000189972990-0x00000001899729B0
	private static ConfigLoadAndSerializePattern GetLoadPattern(Action onLoadFinish) => default; // 0x00000001837D7460-0x00000001837D7750
	// [XID] // 0x000000018997A150-0x000000018997A170
	private static object ExternalVoiceDataSerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFC776 */) => default; // 0x00000001837D7750-0x00000001837D7880
	// [XID] // 0x00000001897C5930-0x00000001897C5950
	private static object ExternalVoiceDataSerializeJson(JSONNode node) => default; // 0x00000001837D5CF0-0x00000001837D5E10
	// [XID] // 0x0000000189838AA0-0x0000000189838AC0
	private static void OnExternalVoiceDataSerialized(object obj, ulong path) {} // 0x00000001837D62F0-0x00000001837D6610
	// [XID] // 0x00000001899909D0-0x00000001899909F0
	public static void PrepareVoiceDataByIdentity(AudioVoiceTrigger trigger, uint param, Action onFinishHandler) {} // 0x00000001837D54A0-0x00000001837D5970
	// [XID] // 0x0000000189998490-0x00000001899984B0
	public static void ReloadFromFile() {} // 0x00000001837D70C0-0x00000001837D7180
	// [XID] // 0x000000018999FC90-0x000000018999FCB0
	private static void ReloadAll() {} // 0x00000001837D84F0-0x00000001837D8660
	// [XID] // 0x00000001899A7940-0x00000001899A7960
	private static void Reload() {} // 0x00000001837D6610-0x00000001837D6E10
	[DebuggerHidden] // 0x00000001899AF1B0-0x00000001899AF1F0
	// [XID] // 0x00000001899AF1B0-0x00000001899AF1F0
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC77A */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x00000001837D7BB0-0x00000001837D7CF0
	// [XID] // 0x0000000189ACBF80-0x0000000189ACBFA0
	public static ExternalVoiceItem GetItemById(uint id) => default; // 0x00000001837D5340-0x00000001837D54A0
	// [IDTag] // 0x00000001899C0FD0-0x00000001899C1010
	// [XID] // 0x00000001899C0FD0-0x00000001899C1010
	public static ExternalVoiceItem GetItemByIdentity(AudioVoiceTrigger trigger, uint param) => default; // 0x00000001837D8140-0x00000001837D8250
	// [XID] // 0x00000001899CB8C0-0x00000001899CB8E0
	public static string GetEmosyncPathByVoiceFilename(string filename) => default; // 0x00000001837D7F10-0x00000001837D8010
	// [XID] // 0x00000001899D2DB0-0x00000001899D2DD0
	private static void Clear() {} // 0x00000001837D6E10-0x00000001837D70C0
	// [IDTag] // 0x00000001899DA360-0x00000001899DA3A0
	// [XID] // 0x00000001899DA360-0x00000001899DA3A0
	private static ExternalVoiceItem GetItemByIdentity(ExternalVoiceIdentity identity) => default; // 0x00000001837D8010-0x00000001837D8140
	// [XID] // 0x0000000189B7DDA0-0x0000000189B7DDC0
	private static void LoadConfigByItemId(uint id) {} // 0x00000001837D8250-0x00000001837D84F0
	// [XID] // 0x00000001899EC2D0-0x00000001899EC2F0
	private static void LoadConfig(ConfigMetaConfig.PathHash configFileHash, ConfigAbstraction abstraction, List<ExternalVoiceSound> reusedSoundList) {} // 0x00000001837D7880-0x00000001837D7BB0
	// [XID] // 0x0000000189B9FD60-0x0000000189B9FD80
	private static void InterpreteItem(ConfigExternalVoiceItem config, List<ExternalVoiceSound> reusedSoundList) {} // 0x00000001837D5970-0x00000001837D5CF0
	// [XID] // 0x0000000189750000-0x0000000189750020
	private static uint[] GetInferiors(ConfigExternalVoiceInferiorItem[] inferiors) => default; // 0x00000001837D7CF0-0x00000001837D7F10
	// [XID] // 0x0000000189784330-0x0000000189784350
	private static void AddSounds(ExternalVoiceItem item, ConfigExternalVoiceSound[] sounds, List<ExternalVoiceSound> reusedSoundList) {} // 0x00000001837D5E10-0x00000001837D6000
	// [XID] // 0x0000000189A0A000-0x0000000189A0A020
	private static bool InterpreteSound(ConfigExternalVoiceSound config, out ExternalVoiceSound sound) {
		sound = default;
		return default;
	} // 0x00000001837D6000-0x00000001837D62F0
	// [IDTag] // 0x0000000189A11900-0x0000000189A11940
	// [XID] // 0x0000000189A11900-0x0000000189A11940
	private static void ReunionFamilies(Dictionary<uint, uint> parentPointers) {} // 0x00000001837D7280-0x00000001837D7460
	// [IDTag] // 0x0000000189A1BAB0-0x0000000189A1BAF0
	// [XID] // 0x0000000189A1BAB0-0x0000000189A1BAF0
	private static void ReunionFamilies(uint childId, uint parentId) {} // 0x00000001837D7180-0x00000001837D7280
}

