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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClimateMeterManager : InLevelManager, INotifyInterface // TypeDefIndex: 20755
{
	// Fields
	private Dictionary<JsonClimateType, ClimateConfigData> _climateDataMap; // 0x10
	private static JsonClimateType _currClimateType; // 0x00
	private static JsonClimateType _currClimateAreaType; // 0x04
	private static float _currClimateMeterValue; // 0x08
	private static uint _currAreaID; // 0x0C
	private ConfigClimate _configClimate; // 0x18
	private float _maxLength; // 0x20
	private float _threshRatio; // 0x24
	private float _weakLenIntensity; // 0x28
	private float _lenLerpSpeed; // 0x2C
	private bool _coldLenEnable; // 0x30
	private float _lenLerpTimer; // 0x34
	private float _fullLerpTime; // 0x38
	private float _targetLenIntensity; // 0x3C
	private float _startLenIntensity; // 0x40
	private float _currentIntensity; // 0x44
	private EffClimateLenState _currentLenState; // 0x48

	// Properties
	private static string CONFIG_CLIMATE { /* [XID] */ /* 0x000000018980B070-0x000000018980B090 */ get => default; } // 0x000000018519BDE0-0x000000018519BE80 
	public JsonClimateType currClimateType { /* [XID] */ /* 0x0000000189830510-0x0000000189830530 */ get => default; } // 0x000000018519BC00-0x000000018519BCD0 

	// Nested types
	public class ClimateConfigData // TypeDefIndex: 20756
	{
		// Fields
		public uint lowDebuffID; // 0x10
		public uint highDebuffID; // 0x14
		public string climateDialogTitle; // 0x18
		public string climateDialteDesc; // 0x20

		// Constructors
		public ClimateConfigData() {} // 0x00000001851BC200-0x00000001851BC260
	}

	public enum EffClimateLenState // TypeDefIndex: 20757
	{
		None = 0,
		Weak = 1,
		Strong = 2
	}

	// Constructors
	public ClimateMeterManager() {} // 0x000000018519D3B0-0x000000018519D460
	static ClimateMeterManager() {} // 0x000000018519D330-0x000000018519D3B0

	// Methods
	// [XID] // 0x00000001898126C0-0x00000001898126E0
	public static void SetStaticClimateMeterType(uint newType) {} // 0x000000018519BE80-0x000000018519BF50
	// [XID] // 0x000000018981A360-0x000000018981A380
	public static void SetStaticClimateAreaType(uint newType) {} // 0x000000018519CAF0-0x000000018519CBC0
	// [XID] // 0x0000000189821A10-0x0000000189821A30
	public static void SetStaticClimateMeterValue(float value) {} // 0x000000018519CCA0-0x000000018519CD70
	// [XID] // 0x0000000189828FE0-0x0000000189829000
	public static void SetStaticClimateAreaID(uint areaID) {} // 0x000000018519B710-0x000000018519B7E0
	// [XID] // 0x0000000189837B90-0x0000000189837BB0
	public override void Init() {} // 0x000000018519BF50-0x000000018519C590
	// [XID] // 0x000000018983F310-0x000000018983F330
	public override void Destroy() {} // 0x000000018519B520-0x000000018519B710
	// [XID] // 0x0000000189846990-0x00000001898469B0
	public bool OnNotify(Notify notify) => default; // 0x000000018519CFE0-0x000000018519D1B0
	// [XID] // 0x000000018984DF40-0x000000018984DF60
	public override void Tick() {} // 0x000000018519D280-0x000000018519D330
	// [XID] // 0x0000000189854FD0-0x0000000189854FF0
	public void RefreshClimate() {} // 0x000000018519B210-0x000000018519B330
	// [XID] // 0x000000018985C730-0x000000018985C750
	public void SetClimateType(JsonClimateType type) {} // 0x000000018519B330-0x000000018519B520
	// [XID] // 0x0000000189864090-0x00000001898640B0
	public void SetClimateArea(JsonClimateType type) {} // 0x000000018519BA00-0x000000018519BBA0
	// [XID] // 0x000000018986B480-0x000000018986B4A0
	public void ClearClimateDebuff(JsonClimateType type) {} // 0x000000018519CF30-0x000000018519CFE0
	// [XID] // 0x00000001898727F0-0x0000000189872810
	public void SetClimateValue(float value) {} // 0x000000018519C800-0x000000018519CAF0
	// [XID] // 0x000000018987A480-0x000000018987A4A0
	public JsonClimateType GetCurrentClimateAreaType() => default; // 0x000000018519B140-0x000000018519B210
	// [XID] // 0x0000000189881580-0x00000001898815A0
	public uint GetCurrentClimateAreaID() => default; // 0x000000018519D1B0-0x000000018519D280
	// [XID] // 0x0000000189B0E610-0x0000000189B0E630
	public void GetCurrentClimateMeterState(out float meterValue, out int warningState, out float meterRatio) {
		meterValue = default;
		warningState = default;
		meterRatio = default;
	} // 0x000000018519AFF0-0x000000018519B140
	// [XID] // 0x000000018988FEC0-0x000000018988FEE0
	public ClimateConfigData GetClimateConfigDataByType(JsonClimateType climateType) => default; // 0x000000018519B910-0x000000018519BA00
	// [XID] // 0x0000000189897420-0x0000000189897440
	private void InitColdLen() {} // 0x000000018519BCD0-0x000000018519BDE0
	// [XID] // 0x000000018989E940-0x000000018989E960
	private void DestroyLen() {} // 0x000000018519C760-0x000000018519C800
	// [XID] // 0x0000000189ACA750-0x0000000189ACA770
	public void UpdateClimateEffLen(bool showLen, bool immdiate = false /* Metadata: 0x00AFE28A */) {} // 0x000000018519B7E0-0x000000018519B910
	// [XID] // 0x00000001898ADAB0-0x00000001898ADAD0
	private float GetTargetClimateLenIntensity(EffClimateLenState state) => default; // 0x000000018519CBC0-0x000000018519CCA0
	// [XID] // 0x00000001898B4F80-0x00000001898B4FA0
	private void SetColdLenState(EffClimateLenState state, bool immediate = false /* Metadata: 0x00AFE28B */) {} // 0x000000018519C590-0x000000018519C760
	// [XID] // 0x00000001898BCA70-0x00000001898BCA90
	private void UpdateClimateLen() {} // 0x000000018519CD70-0x000000018519CF30
}

