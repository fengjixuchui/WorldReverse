/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomExAcb : CriDisposable // TypeDefIndex: 7047
{
	// Fields
	private IntPtr handle; // 0x20
	private GCHandle dataHandle; // 0x28

	// Properties
	public IntPtr nativeHandle { get => default; } // 0x00000001877697F0-0x0000000187769850 
	public bool isAvailable { get => default; } // 0x0000000187769780-0x00000001877697F0 

	// Constructors
	public CriAtomExAcb() {} // Dummy constructor
	internal CriAtomExAcb(IntPtr handle, GCHandle? dataHandle) {} // 0x0000000187767C70-0x0000000187767D50

	// Methods
	public static CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbPath, string awbPath) => default; // 0x0000000187767A50-0x0000000187767B70
	public static CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder awbBinder, string awbPath) => default; // 0x00000001877678E0-0x0000000187767A50
	public override void Dispose() {} // 0x0000000187766550-0x00000001877665C0
	private void Dispose(bool disposing) {} // 0x0000000187766420-0x0000000187766550
	public bool Exists(string cueName) => default; // 0x0000000187766640-0x00000001877666C0
	public bool Exists(int cueId) => default; // 0x00000001877665C0-0x0000000187766640
	public bool GetCueInfo(string cueName, out CriAtomEx.CueInfo info) {
		info = default;
		return default;
	} // 0x0000000187766AE0-0x0000000187766C50
	public bool GetCueInfo(int cueId, out CriAtomEx.CueInfo info) {
		info = default;
		return default;
	} // 0x0000000187766C50-0x0000000187766DC0
	public bool GetCueInfoByIndex(int index, out CriAtomEx.CueInfo info) {
		info = default;
		return default;
	} // 0x0000000187766890-0x0000000187766A00
	public CriAtomEx.CueInfo[] GetCueInfoList() => default; // 0x0000000187766A00-0x0000000187766AE0
	public bool GetWaveFormInfo(string cueName, out CriAtomEx.WaveformInfo info) {
		info = default;
		return default;
	} // 0x00000001877676A0-0x0000000187767810
	public bool GetWaveFormInfo(int cueId, out CriAtomEx.WaveformInfo info) {
		info = default;
		return default;
	} // 0x0000000187767530-0x00000001877676A0
	public int GetNumCuePlaying(string name) => default; // 0x0000000187766EA0-0x0000000187766F20
	public int GetNumCuePlaying(int id) => default; // 0x0000000187766E20-0x0000000187766EA0
	public int GetBlockIndex(string cueName, string blockName) => default; // 0x0000000187766800-0x0000000187766890
	public int GetBlockIndex(int cueId, string blockName) => default; // 0x0000000187766770-0x0000000187766800
	public int GetNumUsableAisacControls(string cueName) => default; // 0x0000000187766F20-0x0000000187766FA0
	public int GetNumUsableAisacControls(int cueId) => default; // 0x0000000187766FA0-0x0000000187767020
	public bool GetUsableAisacControl(string cueName, int index, out CriAtomEx.AisacControlInfo info) {
		info = default;
		return default;
	} // 0x00000001877673B0-0x0000000187767530
	public bool GetUsableAisacControl(int cueId, int index, out CriAtomEx.AisacControlInfo info) {
		info = default;
		return default;
	} // 0x0000000187767230-0x00000001877673B0
	public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(string cueName) => default; // 0x0000000187767130-0x0000000187767230
	public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(int cueId) => default; // 0x0000000187767020-0x0000000187767130
	public void ResetCueTypeState(string cueName) {} // 0x0000000187767B70-0x0000000187767BF0
	public void ResetCueTypeState(int cueId) {} // 0x0000000187767BF0-0x0000000187767C70
	public void AttachAwbFile(CriFsBinder awb_binder, string awb_path, string awb_name) {} // 0x0000000187766120-0x0000000187766230
	public void DetachAwbFile(string awb_name) {} // 0x0000000187766340-0x0000000187766420
	public bool IsReadyToRelease() => default; // 0x0000000187767810-0x00000001877678E0
	public float GetLoadProgress() => default; // 0x0000000187766DC0-0x0000000187766E20
	public void Decrypt(ulong key, ulong nonce) {} // 0x0000000187766230-0x0000000187766340
	~CriAtomExAcb() {} // 0x00000001877666C0-0x0000000187766770
	private static extern IntPtr criAtomExAcb_LoadAcbFile(IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path, IntPtr work, int work_size); // 0x0000000187769330-0x0000000187769490
	private static extern IntPtr criAtomExAcb_LoadAcbData(IntPtr acb_data, int acb_data_size, IntPtr awb_binder, string awb_path, IntPtr work, int work_size); // 0x00000001877691E0-0x0000000187769330
	private static extern void criAtomExAcb_Release(IntPtr acb_hn); // 0x0000000187769490-0x0000000187769580
	private static extern int criAtomExAcb_GetNumCues(IntPtr acb_hn); // 0x0000000187768980-0x0000000187768A70
	private static extern bool criAtomExAcb_ExistsId(IntPtr acb_hn, int id); // 0x0000000187767FC0-0x00000001877680C0
	private static extern bool criAtomExAcb_ExistsName(IntPtr acb_hn, string name); // 0x00000001877680C0-0x00000001877681E0
	private static extern int criAtomExAcb_GetNumUsableAisacControlsById(IntPtr acb_hn, int id); // 0x0000000187768A70-0x0000000187768B70
	private static extern int criAtomExAcb_GetNumUsableAisacControlsByName(IntPtr acb_hn, string name); // 0x0000000187768B70-0x0000000187768C80
	private static extern bool criAtomExAcb_GetUsableAisacControlById(IntPtr acb_hn, int id, ushort index, IntPtr info); // 0x0000000187768C80-0x0000000187768D90
	private static extern bool criAtomExAcb_GetUsableAisacControlByName(IntPtr acb_hn, string name, ushort index, IntPtr info); // 0x0000000187768D90-0x0000000187768EC0
	private static extern bool criAtomExAcb_GetWaveformInfoById(IntPtr acb_hn, int id, IntPtr waveform_info); // 0x0000000187768EC0-0x0000000187768FD0
	private static extern bool criAtomExAcb_GetWaveformInfoByName(IntPtr acb_hn, string name, IntPtr waveform_info); // 0x0000000187768FD0-0x00000001877690F0
	private static extern bool criAtomExAcb_GetCueInfoByName(IntPtr acb_hn, string name, IntPtr info); // 0x0000000187768650-0x0000000187768770
	private static extern bool criAtomExAcb_GetCueInfoById(IntPtr acb_hn, int id, IntPtr info); // 0x0000000187768430-0x0000000187768540
	private static extern bool criAtomExAcb_GetCueInfoByIndex(IntPtr acb_hn, int index, IntPtr info); // 0x0000000187768540-0x0000000187768650
	private static extern int criAtomExAcb_GetNumCuePlayingCountByName(IntPtr acb_hn, string name); // 0x0000000187768870-0x0000000187768980
	private static extern int criAtomExAcb_GetNumCuePlayingCountById(IntPtr acb_hn, int id); // 0x0000000187768770-0x0000000187768870
	private static extern int criAtomExAcb_GetBlockIndexById(IntPtr acb_hn, int id, string block_name); // 0x00000001877681E0-0x0000000187768300
	private static extern int criAtomExAcb_GetBlockIndexByName(IntPtr acb_hn, string name, string block_name); // 0x0000000187768300-0x0000000187768430
	private static extern void criAtomExAcb_ResetCueTypeStateByName(IntPtr acb_hn, string name); // 0x0000000187769670-0x0000000187769780
	private static extern void criAtomExAcb_ResetCueTypeStateById(IntPtr acb_hn, int id); // 0x0000000187769580-0x0000000187769670
	private static extern void criAtomExAcb_AttachAwbFile(IntPtr acb_hn, IntPtr awb_binder, string awb_path, string awb_name, IntPtr work, int work_size); // 0x0000000187767D50-0x0000000187767EB0
	private static extern void criAtomExAcb_DetachAwbFile(IntPtr acb_hn, string awb_name); // 0x0000000187767EB0-0x0000000187767FC0
	private static extern bool criAtomExAcb_IsReadyToRelease(IntPtr acb_hn); // 0x00000001877690F0-0x00000001877691E0
}

