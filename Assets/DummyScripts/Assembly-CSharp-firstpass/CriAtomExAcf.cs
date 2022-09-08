/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomExAcf // TypeDefIndex: 7051
{
	// Nested types
	public struct AcfDspSettingInfo // TypeDefIndex: 7052
	{
		// Fields
		public string name; // 0x00
		public ushort[] busIndexes; // 0x08
		public ushort[] extendBusIndexes; // 0x10
		public ushort snapshotStartIndex; // 0x18
		public byte numBuses; // 0x1A
		public byte numExtendBuses; // 0x1B
		public ushort numSnapshots; // 0x1C
		public ushort snapshotWorkSize; // 0x1E

		// Constructors
		public AcfDspSettingInfo(byte[] data, int startIndex) {
			name = default;
			busIndexes = default;
			extendBusIndexes = default;
			snapshotStartIndex = default;
			numBuses = default;
			numExtendBuses = default;
			numSnapshots = default;
			snapshotWorkSize = default;
		} // 0x000000018775D330-0x000000018775DCA0
	}

	public struct AcfDspSettingSnapshotInfo // TypeDefIndex: 7053
	{
		// Fields
		public string name; // 0x00
		public byte numBuses; // 0x08
		public byte numExtendBuses; // 0x09
		public byte[] reserved; // 0x10
		public ushort[] busIndexes; // 0x18
		public ushort[] extendBusIndexes; // 0x20

		// Constructors
		public AcfDspSettingSnapshotInfo(byte[] data, int startIndex) {
			name = default;
			numBuses = default;
			numExtendBuses = default;
			reserved = default;
			busIndexes = default;
			extendBusIndexes = default;
		} // 0x000000018775DCA0-0x000000018775E0B0
	}

	public struct AcfDspBusInfo // TypeDefIndex: 7054
	{
		// Fields
		public string name; // 0x00
		public float volume; // 0x08
		public float pan3dVolume; // 0x0C
		public float pan3dAngle; // 0x10
		public float pan3dDistance; // 0x14
		public ushort[] fxIndexes; // 0x18
		public ushort[] busLinkIndexes; // 0x20
		public ushort busNo; // 0x28
		public byte numFxes; // 0x2A
		public byte numBusLinks; // 0x2B

		// Constructors
		public AcfDspBusInfo(byte[] data, int startIndex) {
			name = default;
			volume = default;
			pan3dVolume = default;
			pan3dAngle = default;
			pan3dDistance = default;
			fxIndexes = default;
			busLinkIndexes = default;
			busNo = default;
			numFxes = default;
			numBusLinks = default;
		} // 0x000000018775CA50-0x000000018775CDB0
	}

	public enum AcfDspBusLinkType : uint // TypeDefIndex: 7055
	{
		preVolume = 0,
		postVolume = 1,
		postPan = 2
	}

	public struct AcfDspBusLinkInfo // TypeDefIndex: 7056
	{
		// Fields
		public AcfDspBusLinkType type; // 0x00
		public float sendLevel; // 0x04
		public ushort busNo; // 0x08
		public ushort busId; // 0x0A

		// Constructors
		public AcfDspBusLinkInfo(byte[] data, int startIndex) {
			type = default;
			sendLevel = default;
			busNo = default;
			busId = default;
		} // 0x000000018775CDB0-0x000000018775D330
	}

	public struct CategoryInfo // TypeDefIndex: 7057
	{
		// Fields
		public uint groupNo; // 0x00
		public uint id; // 0x04
		public string name; // 0x08
		public uint numCueLimits; // 0x10
		public float volume; // 0x14

		// Constructors
		public CategoryInfo(byte[] data, int startIndex) {
			groupNo = default;
			id = default;
			name = default;
			numCueLimits = default;
			volume = default;
		} // 0x000000018775F560-0x000000018775F5F0
	}

	public enum AcfAisacType : uint // TypeDefIndex: 7058
	{
		normal = 0,
		autoModulation = 1
	}

	public struct GlobalAisacInfo // TypeDefIndex: 7059
	{
		// Fields
		public string name; // 0x00
		public ushort index; // 0x08
		public ushort numGraphs; // 0x0A
		public AcfAisacType type; // 0x0C
		public float randomRange; // 0x10
		public ushort controlId; // 0x14
		public ushort dummy; // 0x16

		// Constructors
		public GlobalAisacInfo(byte[] data, int startIndex) {
			name = default;
			index = default;
			numGraphs = default;
			type = default;
			randomRange = default;
			controlId = default;
			dummy = default;
		} // 0x00000001877790D0-0x0000000187779240
	}

	public enum AisacGraphType // TypeDefIndex: 7060
	{
		none = 0,
		volume = 1,
		pitch = 2,
		bandpassHigh = 3,
		bandpassLow = 4,
		biquadFreq = 5,
		biquadQ = 6,
		busSend0 = 7,
		busSend1 = 8,
		busSend2 = 9,
		busSend3 = 10,
		busSend4 = 11,
		busSend5 = 12,
		busSend6 = 13,
		busSend7 = 14,
		pan3dAngel = 15,
		pan3dVolume = 16,
		pan3dInteriorDistance = 17,
		pan3dCenter = 18,
		pan3dLfe = 19,
		aisac0 = 20,
		aisac1 = 21,
		aisac2 = 22,
		aisac3 = 23,
		aisac4 = 24,
		aisac5 = 25,
		aisac6 = 26,
		aisac7 = 27,
		aisac8 = 28,
		aisac9 = 29,
		aisac10 = 30,
		aisac11 = 31,
		aisac12 = 32,
		aisac13 = 33,
		aisac14 = 34,
		aisac15 = 35,
		priority = 36,
		preDelayTime = 37,
		biquadGain = 38,
		pan3dMixdownCenter = 39,
		pan3dMixdownLfe = 40,
		egAttack = 41,
		egRelease = 42,
		playbackRatio = 43,
		drySendL = 44,
		drySendR = 45,
		drySendCenter = 46,
		drySendLfe = 47,
		drySendSl = 48,
		drySendSr = 49,
		drySendEx1 = 50,
		drySendEx2 = 51,
		panSpread = 52
	}

	public struct AisacGraphInfo // TypeDefIndex: 7061
	{
		// Fields
		public AisacGraphType type; // 0x00

		// Constructors
		public AisacGraphInfo(byte[] data, int startIndex) {
			type = default;
		} // 0x000000018775EEF0-0x000000018775F160
	}

	public enum CharacterEncoding : uint // TypeDefIndex: 7062
	{
		utf8 = 0,
		sjis = 1
	}

	public struct AcfInfo // TypeDefIndex: 7063
	{
		// Fields
		public string name; // 0x00
		public uint size; // 0x08
		public uint version; // 0x0C
		public CharacterEncoding characterEncoding; // 0x10
		public int numDspSettings; // 0x14
		public int numCategories; // 0x18
		public int numCategoriesPerPlayback; // 0x1C
		public int numReacts; // 0x20
		public int numAisacControls; // 0x24
		public int numGlobalAisacs; // 0x28
		public int numGameVariables; // 0x2C
		public int maxBusesOfDspBusSettings; // 0x30
		public int numBuses; // 0x34
		public int numVoiceLimitGroups; // 0x38

		// Constructors
		public AcfInfo(byte[] data, int startIndex) {
			name = default;
			size = default;
			version = default;
			characterEncoding = default;
			numDspSettings = default;
			numCategories = default;
			numCategoriesPerPlayback = default;
			numReacts = default;
			numAisacControls = default;
			numGlobalAisacs = default;
			numGameVariables = default;
			maxBusesOfDspBusSettings = default;
			numBuses = default;
			numVoiceLimitGroups = default;
		} // 0x000000018775E680-0x000000018775E790
	}

	public struct SelectorInfo // TypeDefIndex: 7064
	{
		// Fields
		public string name; // 0x00
		public ushort index; // 0x08
		public ushort numLabels; // 0x0A
		public ushort globalLabelIndex; // 0x0C

		// Constructors
		public SelectorInfo(byte[] data, int startIndex) {
			name = default;
			index = default;
			numLabels = default;
			globalLabelIndex = default;
		} // 0x0000000187779900-0x0000000187779A20
	}

	public struct SelectorLabelInfo // TypeDefIndex: 7065
	{
		// Fields
		public string selectorName; // 0x00
		public string labelName; // 0x08

		// Constructors
		public SelectorLabelInfo(byte[] data, int startIndex) {
			selectorName = default;
			labelName = default;
		} // 0x0000000187779C00-0x0000000187779C10
	}

	// Constructors
	public CriAtomExAcf() {} // 0x000000018776D1E0-0x000000018776D240

	// Methods
	public static int GetNumAisacControls() => default; // 0x000000018776CA60-0x000000018776CAC0
	public static bool GetAisacControlInfo(ushort index, out CriAtomEx.AisacControlInfo info) {
		info = default;
		return default;
	} // 0x000000018776B920-0x000000018776BA70
	public static int GetNumDspSettings() => default; // 0x000000018776CBE0-0x000000018776CC40
	public static bool GetDspSettingInformation(string name, out AcfDspSettingInfo info) {
		info = default;
		return default;
	} // 0x000000018776C100-0x000000018776C250
	public static bool GetDspSettingSnapshotInformation(ushort index, out AcfDspSettingSnapshotInfo info) {
		info = default;
		return default;
	} // 0x000000018776C250-0x000000018776C3A0
	public static bool GetDspBusInformation(ushort index, out AcfDspBusInfo info) {
		info = default;
		return default;
	} // 0x000000018776BE60-0x000000018776BFB0
	public static bool GetDspBusLinkInformation(ushort index, out AcfDspBusLinkInfo info) {
		info = default;
		return default;
	} // 0x000000018776BFB0-0x000000018776C100
	public static int GetNumCategories() => default; // 0x000000018776CB80-0x000000018776CBE0
	public static int GetNumCategoriesPerPlayback() => default; // 0x000000018776CB20-0x000000018776CB80
	public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo info) {
		info = default;
		return default;
	} // 0x000000018776BBC0-0x000000018776BD10
	public static bool GetCategoryInfoByName(string name, out CategoryInfo info) {
		info = default;
		return default;
	} // 0x000000018776BD10-0x000000018776BE60
	public static bool GetCategoryInfoById(uint id, out CategoryInfo info) {
		info = default;
		return default;
	} // 0x000000018776BA70-0x000000018776BBC0
	public static int GetNumGlobalAisacs() => default; // 0x000000018776CC40-0x000000018776CCA0
	public static bool GetGlobalAisacInfoByIndex(ushort index, out GlobalAisacInfo info) {
		info = default;
		return default;
	} // 0x000000018776C5F0-0x000000018776C740
	public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info) {
		info = default;
		return default;
	} // 0x000000018776C740-0x000000018776C890
	public static bool GetGlobalAisacGraphInfo(GlobalAisacInfo aisacInfo, ushort graphIndex, out AisacGraphInfo graphInfo) {
		graphInfo = default;
		return default;
	} // 0x000000018776C3A0-0x000000018776C5F0
	public static bool GetGlobalAisacValue(GlobalAisacInfo aisacInfo, float control, AisacGraphType type, out float value) {
		value = default;
		return default;
	} // 0x000000018776C890-0x000000018776CA00
	public static bool GetAcfInfo(out AcfInfo acfInfo) {
		acfInfo = default;
		return default;
	} // 0x000000018776B7D0-0x000000018776B920
	public static int GetNumSelectors() => default; // 0x000000018776CCA0-0x000000018776CD00
	public static bool GetSelectorInfoByIndex(ushort index, out SelectorInfo info) {
		info = default;
		return default;
	} // 0x000000018776CD00-0x000000018776CE50
	public static bool GetSelectorInfoByName(string name, out SelectorInfo info) {
		info = default;
		return default;
	} // 0x000000018776CE50-0x000000018776CFA0
	public static bool GetSelectorLabelInfo(SelectorInfo selectorInfo, ushort labelIndex, out SelectorLabelInfo info) {
		info = default;
		return default;
	} // 0x000000018776CFA0-0x000000018776D1E0
	public static int GetNumBuses() => default; // 0x000000018776CAC0-0x000000018776CB20
	public static int GetMaxBusesOfDspBusSettings() => default; // 0x000000018776CA00-0x000000018776CA60
	public static string FindBusName(string busName) => default; // 0x000000018776B760-0x000000018776B7D0
	private static extern int criAtomExAcf_GetNumAisacControls(); // 0x000000018776EB20-0x000000018776EC00
	private static extern bool criAtomExAcf_GetAisacControlInfo(ushort index, IntPtr info); // 0x000000018776D680-0x000000018776D780
	private static extern uint criAtomExAcf_GetAisacControlIdByName(string name); // 0x000000018776D570-0x000000018776D680
	private static extern string criAtomExAcf_GetAisacControlNameById(uint id); // 0x000000018776D780-0x000000018776D890
	private static extern int criAtomExAcf_GetNumDspSettings(); // 0x000000018776F2A0-0x000000018776F380
	private static extern int criAtomExAcf_GetNumDspSettingsFromAcfData(IntPtr acf_data, int acf_data_size); // 0x000000018776F1A0-0x000000018776F2A0
	private static extern string criAtomExAcf_GetDspSettingNameByIndex(ushort index); // 0x000000018776E2E0-0x000000018776E3F0
	private static extern string criAtomExAcf_GetDspSettingNameByIndexFromAcfData(IntPtr acf_data, int acf_data_size, ushort index); // 0x000000018776E1C0-0x000000018776E2E0
	private static extern bool criAtomExAcf_GetDspSettingInformation(string name, IntPtr info); // 0x000000018776E0B0-0x000000018776E1C0
	private static extern bool criAtomExAcf_GetDspSettingSnapshotInformation(ushort index, IntPtr info); // 0x000000018776E3F0-0x000000018776E4F0
	private static extern bool criAtomExAcf_GetDspBusInformation(ushort index, IntPtr info); // 0x000000018776DBA0-0x000000018776DCA0
	private static extern int criAtomExAcf_GetDspFxType(ushort index); // 0x000000018776DFC0-0x000000018776E0B0
	private static extern string criAtomExAcf_GetDspFxName(ushort index); // 0x000000018776DDA0-0x000000018776DEB0
	private static extern bool criAtomExAcf_GetDspFxParameters(ushort index, IntPtr parameters, int size); // 0x000000018776DEB0-0x000000018776DFC0
	private static extern bool criAtomExAcf_GetDspBusLinkInformation(ushort index, IntPtr info); // 0x000000018776DCA0-0x000000018776DDA0
	private static extern int criAtomExAcf_GetNumCategoriesFromAcfData(IntPtr acf_data, int acf_data_size); // 0x000000018776EDE0-0x000000018776EEE0
	private static extern int criAtomExAcf_GetNumCategories(); // 0x000000018776F0C0-0x000000018776F1A0
	private static extern int criAtomExAcf_GetNumCategoriesPerPlaybackFromAcfData(IntPtr acf_data, int acf_data_size); // 0x000000018776EEE0-0x000000018776EFE0
	private static extern int criAtomExAcf_GetNumCategoriesPerPlayback(); // 0x000000018776EFE0-0x000000018776F0C0
	private static extern bool criAtomExAcf_GetCategoryInfo(ushort index, IntPtr info); // 0x000000018776DAA0-0x000000018776DBA0
	private static extern bool criAtomExAcf_GetCategoryInfoByName(string name, IntPtr info); // 0x000000018776D990-0x000000018776DAA0
	private static extern bool criAtomExAcf_GetCategoryInfoById(uint id, IntPtr info); // 0x000000018776D890-0x000000018776D990
	private static extern int criAtomExAcf_GetNumGlobalAisacs(); // 0x000000018776F380-0x000000018776F460
	private static extern bool criAtomExAcf_GetGlobalAisacInfo(ushort index, IntPtr info); // 0x000000018776E710-0x000000018776E810
	private static extern bool criAtomExAcf_GetGlobalAisacInfoByName(string name, IntPtr info); // 0x000000018776E600-0x000000018776E710
	private static extern bool criAtomExAcf_GetGlobalAisacGraphInfo(IntPtr aisac_info, ushort graph_index, IntPtr graph_info); // 0x000000018776E4F0-0x000000018776E600
	private static extern bool criAtomExAcf_GetGlobalAisacValue(IntPtr aisac_info, float control, AisacGraphType type, out float value); // 0x000000018776E810-0x000000018776E940
	private static extern bool criAtomExAcf_GetAcfInfo(IntPtr acf_info); // 0x000000018776D480-0x000000018776D570
	private static extern bool criAtomExAcf_GetAcfInfoFromAcfData(IntPtr acf_data, int acf_data_size, IntPtr acf_info); // 0x000000018776D370-0x000000018776D480
	private static extern int criAtomExAcf_GetNumSelectors(); // 0x000000018776F460-0x000000018776F540
	private static extern bool criAtomExAcf_GetSelectorInfoByIndex(ushort index, IntPtr info); // 0x000000018776F540-0x000000018776F640
	private static extern bool criAtomExAcf_GetSelectorInfoByName(string name, IntPtr info); // 0x000000018776F640-0x000000018776F750
	private static extern bool criAtomExAcf_GetSelectorLabelInfo(IntPtr selector_info, ushort label_index, IntPtr info); // 0x000000018776F750-0x000000018776F860
	private static extern int criAtomExAcf_GetNumBusesFromAcfData(IntPtr acf_data, int acf_data_size); // 0x000000018776EC00-0x000000018776ED00
	private static extern int criAtomExAcf_GetNumBuses(); // 0x000000018776ED00-0x000000018776EDE0
	private static extern int criAtomExAcf_GetMaxBusesOfDspBusSettingsFromAcfData(IntPtr acf_data, int acf_data_size); // 0x000000018776E940-0x000000018776EA40
	private static extern int criAtomExAcf_GetMaxBusesOfDspBusSettings(); // 0x000000018776EA40-0x000000018776EB20
	private static extern string criAtomExAcf_FindBusName(string bus_name); // 0x000000018776D240-0x000000018776D370
}

