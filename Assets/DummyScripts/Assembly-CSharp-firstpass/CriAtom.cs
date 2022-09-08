/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using AOT;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

// [AddComponentMenu] // 0x0000000189B7F640-0x0000000189B7F670
public class CriAtom : CriMonoBehaviour // TypeDefIndex: 6973
{
	// Fields
	public string acfFile; // 0x28
	private bool acfIsLoading; // 0x30
	public CriAtomCueSheet[] cueSheets; // 0x38
	public string dspBusSetting; // 0x40
	public bool dontDestroyOnLoad; // 0x48
	private static CriAtomExSequencer.EventCbFunc eventUserCbFunc; // 0x00
	private static CriAtomExBeatSync.CbFunc beatsyncUserCbFunc; // 0x08
	public bool dontRemoveExistsCueSheet; // 0x49

	// Properties
	private static CriAtom instance { get; set; } // 0x0000000187777170-0x0000000187777200 0x0000000187777200-0x0000000187777290
	public static bool CueSheetsAreLoading { get => default; } // 0x0000000187776FE0-0x0000000187777170 

	// Constructors
	public CriAtom() {} // 0x0000000187776F30-0x0000000187776FE0
	static CriAtom() {} // 0x0000000187776EC0-0x0000000187776F30

	// Methods
	public static void AttachDspBusSetting(string settingName) {} // 0x0000000187774730-0x0000000187774890
	public static void DetachDspBusSetting() {} // 0x0000000187774D50-0x0000000187774E30
	public static CriAtomCueSheet GetCueSheet(string name) => default; // 0x0000000187775330-0x00000001877753D0
	public static CriAtomCueSheet AddCueSheet(string name, string acbFile, string awbFile, CriFsBinder binder = null) => default; // 0x00000001877745F0-0x0000000187774730
	public static CriAtomCueSheet AddCueSheetAsync(string name, string acbFile, string awbFile, CriFsBinder binder = null, bool loadAwbOnMemory = false /* Metadata: 0x00ADE095 */) => default; // 0x0000000187774190-0x00000001877742D0
	public static CriAtomCueSheet AddCueSheet(string name, byte[] acbData, string awbFile, CriFsBinder awbBinder = null) => default; // 0x00000001877744B0-0x00000001877745F0
	public static CriAtomCueSheet AddCueSheetAsync(string name, byte[] acbData, string awbFile, CriFsBinder awbBinder = null, bool loadAwbOnMemory = false /* Metadata: 0x00ADE096 */) => default; // 0x0000000187774040-0x0000000187774190
	public static void RemoveCueSheet(string name) {} // 0x0000000187776180-0x0000000187776280
	public static CriAtomExAcb GetAcb(string cueSheetName) => default; // 0x0000000187774E30-0x0000000187774FE0
	public static void SetCategoryVolume(string name, float volume) {} // 0x00000001877765D0-0x0000000187776650
	public static void SetCategoryVolume(int id, float volume) {} // 0x0000000187776650-0x00000001877766D0
	public static float GetCategoryVolume(string name) => default; // 0x0000000187775120-0x00000001877751A0
	public static float GetCategoryVolume(int id) => default; // 0x00000001877751A0-0x0000000187775210
	public static void SetBusAnalyzer(string busName, bool sw) {} // 0x0000000187776470-0x0000000187776550
	public static void SetBusAnalyzer(bool sw) {} // 0x0000000187776550-0x00000001877765D0
	public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(string busName) => default; // 0x0000000187774FE0-0x0000000187775080
	[Obsolete] // 0x0000000189BA1490-0x0000000189BA14C0
	public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(int busId) => default; // 0x0000000187775080-0x0000000187775120
	public void Setup() {} // 0x0000000187776800-0x0000000187776C70
	public void Shutdown() {} // 0x0000000187776C70-0x0000000187776EC0
	private void Awake() {} // 0x0000000187774890-0x0000000187774BB0
	protected override void OnEnable() {} // 0x0000000187775E90-0x0000000187775F60
	private void OnDestroy() {} // 0x0000000187775DC0-0x0000000187775E90
	public override void CriInternalUpdate() {} // 0x0000000187774CD0-0x0000000187774D50
	public override void CriInternalLateUpdate() {} // 0x0000000187774C80-0x0000000187774CD0
	public CriAtomCueSheet GetCueSheetInternal(string name) => default; // 0x0000000187775210-0x0000000187775330
	public CriAtomCueSheet AddCueSheetInternal(string name, string acbFile, string awbFile, CriFsBinder binder) => default; // 0x00000001877742D0-0x00000001877744B0
	public void RemoveCueSheetInternal(string name) {} // 0x0000000187775F60-0x0000000187776180
	private void MargeCueSheet(CriAtomCueSheet[] newCueSheets, bool newDontRemoveExistsCueSheet) {} // 0x0000000187775B40-0x0000000187775DC0
	private CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbFile, string awbFile) => default; // 0x0000000187775910-0x0000000187775B40
	private CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder binder, string awbFile) => default; // 0x00000001877755A0-0x0000000187775710
	private void LoadAcbFileAsync(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbFile, string awbFile, bool loadAwbOnMemory) {} // 0x0000000187775710-0x0000000187775800
	[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
	private IEnumerator LoadAcbFileCoroutine(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory) => default; // 0x0000000187775800-0x0000000187775910
	private void LoadAcbDataAsync(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbFile, bool loadAwbOnMemory) {} // 0x00000001877753D0-0x0000000187775490
	[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
	private IEnumerator LoadAcbDataCoroutine(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory) => default; // 0x0000000187775490-0x00000001877755A0
	// [MonoPInvokeCallback] // 0x0000000189BB8C60-0x0000000189BB8CB0
	public static void SequenceEventCallbackFromNative(string eventString) {} // 0x0000000187776280-0x0000000187776350
	// [MonoPInvokeCallback] // 0x0000000189BC5360-0x0000000189BC53B0
	public static void BeatSyncCallbackFromNative(ref CriAtomExBeatSync.Info info) {} // 0x0000000187774BB0-0x0000000187774C80
	public static void SetEventCallback(CriAtomExSequencer.EventCbFunc func, string separator) {} // 0x00000001877766D0-0x0000000187776800
	public static void SetBeatSyncCallback(CriAtomExBeatSync.CbFunc func) {} // 0x0000000187776350-0x0000000187776470
}

