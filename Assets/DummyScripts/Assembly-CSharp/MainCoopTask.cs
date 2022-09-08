/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MainCoopTask // TypeDefIndex: 20791
{
	// Fields
	private uint _mainCoopId; // 0x10
	private uint _confidenceValue; // 0x14
	private Dictionary<CoopTemperamentType, uint> _temperamentValueDic; // 0x18
	private Dictionary<CoopTemperamentType, float> _temperamentRatioDic; // 0x20
	private Dictionary<uint, uint> _tempValueDic; // 0x28
	private List<uint> _savePointList; // 0x30
	private ConfigMainCoopGroup _mainCoopCfg; // 0x38

	// Properties
	public bool useConfidence { /* [XID] */ /* 0x00000001895EC010-0x00000001895EC030 */ get => default; } // 0x00000001837EB090-0x00000001837EB150 
	public bool useTemperament { /* [XID] */ /* 0x00000001895F3410-0x00000001895F3430 */ get => default; } // 0x00000001837EBFE0-0x00000001837EC0A0 
	public uint maxConfidenceValue { /* [XID] */ /* 0x00000001895FAD30-0x00000001895FAD50 */ get => default; } // 0x00000001837EC180-0x00000001837EC230 
	public uint mainCoopId { /* [XID] */ /* 0x0000000189602640-0x0000000189602660 */ get => default; } // 0x00000001837EC670-0x00000001837EC710 
	public Dictionary<CoopTemperamentType, uint> temperamentValueDic { /* [XID] */ /* 0x0000000189609EF0-0x0000000189609F10 */ get => default; } // 0x00000001837EBC70-0x00000001837EBD10 
	public Dictionary<uint, uint> tempValueDic { /* [XID] */ /* 0x0000000189611720-0x0000000189611740 */ get => default; } // 0x00000001837EAE20-0x00000001837EAEC0 

	// Constructors
	public MainCoopTask() {} // 0x00000001837EC710-0x00000001837EC790

	// Methods
	// [XID] // 0x0000000189619020-0x0000000189619040
	public void Init(uint mainCoopId, ConfigMainCoopGroup grp) {} // 0x00000001837EB740-0x00000001837EBBC0
	// [XID] // 0x0000000189620500-0x0000000189620520
	public void RefreshBySaveData(MainCoop coopSaveData) {} // 0x00000001837EB150-0x00000001837EB620
	// [XID] // 0x0000000189627990-0x00000001896279B0
	public CoopSubStartPoint GetSubStartPoint(uint subStartPointId) => default; // 0x00000001837EBE30-0x00000001837EBF40
	// [XID] // 0x00000001896C9CD0-0x00000001896C9CF0
	public ConfigCoopInteractionGroup GetCoopInteractionGroupById(uint coopInteractionId) => default; // 0x00000001837EC330-0x00000001837EC440
	// [XID] // 0x0000000189636EA0-0x0000000189636EC0
	public CoopSavePoint GetSavePoint(uint savePointId) => default; // 0x00000001837EC560-0x00000001837EC670
	// [XID] // 0x000000018963E400-0x000000018963E420
	public bool GetSavePointFinishState(uint savePointId) => default; // 0x00000001837EC440-0x00000001837EC560
	// [XID] // 0x0000000189645C00-0x0000000189645C20
	public void SetConfidenceValue(uint value) {} // 0x00000001837EBBC0-0x00000001837EBC70
	// [XID] // 0x000000018964D480-0x000000018964D4A0
	public uint GetConfidenceValue() => default; // 0x00000001837EBF40-0x00000001837EBFE0
	// [XID] // 0x0000000189654D20-0x0000000189654D40
	public float GetConfidenceValueNormalized() => default; // 0x00000001837EC230-0x00000001837EC330
	// [XID] // 0x000000018965C270-0x000000018965C290
	public uint GetTemperamentValue(CoopTemperamentType type) => default; // 0x00000001837EC0A0-0x00000001837EC180
	// [XID] // 0x0000000189663A40-0x0000000189663A60
	public void SetTemperamentValue(CoopTemperamentType type, uint value) {} // 0x00000001837EB620-0x00000001837EB740
	// [XID] // 0x000000018966B2C0-0x000000018966B2E0
	public float GetTemperamentRatio(CoopTemperamentType type) => default; // 0x00000001837EAFA0-0x00000001837EB090
	// [XID] // 0x0000000189672FA0-0x0000000189672FC0
	public uint GetTempValue(uint tempValueId) => default; // 0x00000001837EAEC0-0x00000001837EAFA0
	// [XID] // 0x000000018967A590-0x000000018967A5B0
	public void SetTempValue(uint tempValueId, uint value) {} // 0x00000001837EBD10-0x00000001837EBE30
}

