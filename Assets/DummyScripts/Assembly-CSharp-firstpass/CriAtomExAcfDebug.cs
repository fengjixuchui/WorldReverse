/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class CriAtomExAcfDebug // TypeDefIndex: 7221
{
	// Nested types
	public struct CategoryInfo // TypeDefIndex: 7222
	{
		// Fields
		public uint groupNo; // 0x00
		public uint id; // 0x04
		public string name; // 0x08
		public uint numCueLimits; // 0x10
		public float volume; // 0x14
	}

	public struct DspBusInfo // TypeDefIndex: 7223
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
	}

	public struct AisacControlInfo // TypeDefIndex: 7224
	{
		// Fields
		public string name; // 0x00
		public uint id; // 0x08
	}

	public enum AisacType // TypeDefIndex: 7225
	{
		Normal = 0,
		AutoModulation = 1
	}

	public struct GlobalAisacInfo // TypeDefIndex: 7226
	{
		// Fields
		public string name; // 0x00
		public ushort index; // 0x08
		public ushort numGraphs; // 0x0A
		public AisacType type; // 0x0C
		public float randomRange; // 0x10
		public ushort controlId; // 0x14
	}

	public struct SelectorInfo // TypeDefIndex: 7227
	{
		// Fields
		public string name; // 0x00
		public ushort index; // 0x08
		public ushort numLabels; // 0x0A
		public ushort globalLabelIndex; // 0x0C
	}

	public struct SelectorLabelInfo // TypeDefIndex: 7228
	{
		// Fields
		public string selectorName; // 0x00
		public string labelName; // 0x08
	}

	private struct CategoryInfoForMarshaling // TypeDefIndex: 7229
	{
		// Fields
		public uint groupNo; // 0x00
		public uint id; // 0x04
		public IntPtr namePtr; // 0x08
		public uint numCueLimits; // 0x10
		public float volume; // 0x14

		// Methods
		public void Convert(out CategoryInfo x) {
			x = default;
		} // 0x000000018775F340-0x000000018775F560
	}

	private struct DspBusInfoForMarshaling // TypeDefIndex: 7230
	{
		// Fields
		public IntPtr namePtr; // 0x00
		public float volume; // 0x08
		public float pan3dVolume; // 0x0C
		public float pan3dAngle; // 0x10
		public float pan3dDistance; // 0x14
		public ushort[] fxIndexes; // 0x18
		public ushort[] busLinkIndexes; // 0x20
		public ushort busNo; // 0x28
		public byte numFxes; // 0x2A
		public byte numBusLinks; // 0x2B

		// Methods
		public void Convert(out DspBusInfo x) {
			x = default;
		} // 0x00000001877782F0-0x0000000187778A70
	}

	private struct AisacControlInfoForMarshaling // TypeDefIndex: 7231
	{
		// Fields
		public IntPtr namePtr; // 0x00
		public uint id; // 0x08

		// Methods
		public void Convert(out AisacControlInfo x) {
			x = default;
		} // 0x000000018775EBE0-0x000000018775ED70
	}

	private struct GlobalAisacInfoForMarshaling // TypeDefIndex: 7232
	{
		// Fields
		public IntPtr namePtr; // 0x00
		public ushort index; // 0x08
		public ushort numGraphs; // 0x0A
		public uint type; // 0x0C
		public float randomRange; // 0x10
		public ushort controlId; // 0x14
		public ushort dummy; // 0x16

		// Methods
		public void Convert(out GlobalAisacInfo x) {
			x = default;
		} // 0x0000000187778D20-0x00000001877790D0
	}

	private struct SelectorInfoForMarshaling // TypeDefIndex: 7233
	{
		// Fields
		public IntPtr namePtr; // 0x00
		public ushort index; // 0x08
		public ushort numLabels; // 0x0A
		public ushort globalLabelIndex; // 0x0C

		// Methods
		public void Convert(out SelectorInfo x) {
			x = default;
		} // 0x0000000187779710-0x0000000187779900
	}

	private struct SelectorLabelInfoForMarshaling // TypeDefIndex: 7234
	{
		// Fields
		public IntPtr selectorNamePtr; // 0x00
		public IntPtr labelNamePtr; // 0x08

		// Methods
		public void Convert(out SelectorLabelInfo x) {
			x = default;
		} // 0x0000000187779A20-0x0000000187779C00
	}

	// Methods
	public static int GetNumCategories() => default; // 0x000000018776A0F0-0x000000018776A150
	public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo categoryInfo) {
		categoryInfo = default;
		return default;
	} // 0x0000000187769B30-0x0000000187769C40
	public static bool GetCategoryInfoByName(string name, out CategoryInfo categoryInfo) {
		categoryInfo = default;
		return default;
	} // 0x0000000187769C40-0x0000000187769D40
	public static bool GetCategoryInfoById(uint id, out CategoryInfo categoryInfo) {
		categoryInfo = default;
		return default;
	} // 0x0000000187769A20-0x0000000187769B30
	public static int GetNumBuses() => default; // 0x000000018776A090-0x000000018776A0F0
	public static bool GetDspBusInformation(ushort index, out DspBusInfo dspBusInfo) {
		dspBusInfo = default;
		return default;
	} // 0x0000000187769D40-0x0000000187769E00
	public static int GetNumAisacControls() => default; // 0x000000018776A030-0x000000018776A090
	public static bool GetAisacControlInfo(ushort index, out AisacControlInfo info) {
		info = default;
		return default;
	} // 0x00000001877698C0-0x00000001877699A0
	public static uint GetAisacControlIdByName(string name) => default; // 0x0000000187769850-0x00000001877698C0
	public static string GetAisacControlNameById(uint id) => default; // 0x00000001877699A0-0x0000000187769A20
	public static int GetNumGlobalAisacs() => default; // 0x000000018776A150-0x000000018776A1B0
	public static bool GetGlobalAisacInfo(ushort index, out GlobalAisacInfo info) {
		info = default;
		return default;
	} // 0x0000000187769F10-0x000000018776A030
	public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info) {
		info = default;
		return default;
	} // 0x0000000187769E00-0x0000000187769F10
	public static int GetNumSelectors() => default; // 0x000000018776A1B0-0x000000018776A210
	public static bool GetSelectorInfoByIndex(ushort index, out SelectorInfo info) {
		info = default;
		return default;
	} // 0x000000018776A210-0x000000018776A310
	public static bool GetSelectorInfoByName(string name, out SelectorInfo info) {
		info = default;
		return default;
	} // 0x000000018776A310-0x000000018776A410
	public static bool GetSelectorLabelInfo(ref SelectorInfo selectorInfo, ushort index, out SelectorLabelInfo labelInfo) {
		labelInfo = default;
		return default;
	} // 0x000000018776A410-0x000000018776A540
	private static extern int criAtomExAcf_GetNumCategories(); // 0x000000018776B160-0x000000018776B240
	private static extern int criAtomExAcf_GetCategoryInfo(ushort index, out CategoryInfoForMarshaling categoryInfo); // 0x000000018776AAB0-0x000000018776ABD0
	private static extern int criAtomExAcf_GetCategoryInfoByName(string name, out CategoryInfoForMarshaling categoryInfo); // 0x000000018776A970-0x000000018776AAB0
	private static extern int criAtomExAcf_GetCategoryInfoById(uint id, out CategoryInfoForMarshaling categoryInfo); // 0x000000018776A850-0x000000018776A970
	private static extern int criAtomExAcf_GetNumBuses(); // 0x000000018776B080-0x000000018776B160
	private static extern int criAtomExAcf_GetDspBusInformation(ushort index, out DspBusInfoForMarshaling dspBusInfo); // 0x000000018776ABD0-0x000000018776AD40
	private static extern int criAtomExAcf_GetNumAisacControls(); // 0x000000018776AFA0-0x000000018776B080
	private static extern int criAtomExAcf_GetAisacControlInfo(ushort index, out AisacControlInfoForMarshaling info); // 0x000000018776A650-0x000000018776A760
	private static extern uint criAtomExAcf_GetAisacControlIdByName(string name); // 0x000000018776A540-0x000000018776A650
	private static extern IntPtr criAtomExAcf_GetAisacControlNameById(uint id); // 0x000000018776A760-0x000000018776A850
	private static extern int criAtomExAcf_GetNumGlobalAisacs(); // 0x000000018776B240-0x000000018776B320
	private static extern int criAtomExAcf_GetGlobalAisacInfo(ushort index, out GlobalAisacInfoForMarshaling info); // 0x000000018776AE80-0x000000018776AFA0
	private static extern int criAtomExAcf_GetGlobalAisacInfoByName(string name, out GlobalAisacInfoForMarshaling info); // 0x000000018776AD40-0x000000018776AE80
	private static extern int criAtomExAcf_GetNumSelectors(); // 0x000000018776B320-0x000000018776B400
	private static extern int criAtomExAcf_GetSelectorInfoByIndex(ushort index, out SelectorInfoForMarshaling info); // 0x000000018776B400-0x000000018776B510
	private static extern int criAtomExAcf_GetSelectorInfoByName(string name, out SelectorInfoForMarshaling info); // 0x000000018776B510-0x000000018776B640
	private static extern int criAtomExAcf_GetSelectorLabelInfo(ref SelectorInfoForMarshaling info, ushort labelIndex, out SelectorLabelInfoForMarshaling label_info); // 0x000000018776B640-0x000000018776B760
}

