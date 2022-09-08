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

public sealed class LCIndicatorPlugin : BaseComponentPlugin // TypeDefIndex: 12058
{
	// Fields
	public List<System.Type> _timeCheckConditionKeys; // 0x58
	public Dictionary<System.Type, List<DominatorCondition>> allConditions; // 0x60
	private LCGadgetMisc _owner; // 0x68
	private LevelGadget _levelGadget; // 0x70
	private GadgetDataItem _dataItem; // 0x78
	private ConfigTemplateData _tempLateData; // 0x80
	private ConfigUIIndicator _configIndicator; // 0x88
	public List<IndicatorDominator> indicatorDominators; // 0x90
	private bool _isIndicatorShow; // 0x98
	private EntityTimerReceiver _checkTimer; // 0xA0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001895FD0D0-0x00000001895FD0F0 */ get => default; } // 0x00000001815A67B0-0x00000001815A6850 
	public GadgetDataItem dataItem { /* [XID] */ /* 0x0000000189604AB0-0x0000000189604AD0 */ get => default; /* [XID] */ /* 0x000000018960C340-0x000000018960C360 */ set {} } // 0x00000001815A3ED0-0x00000001815A3F70 0x00000001815A5EC0-0x00000001815A5F70
	public ConfigTemplateData tempLateData { /* [XID] */ /* 0x0000000189613980-0x00000001896139A0 */ get => default; /* [XID] */ /* 0x000000018961B250-0x000000018961B270 */ set {} } // 0x00000001815A5F70-0x00000001815A6020 0x00000001815A3F70-0x00000001815A4020

	// Nested types
	public struct DominatorCondition // TypeDefIndex: 12059
	{
		// Fields
		public int state; // 0x00
		public int index; // 0x04
		public IndicatorCondition condition; // 0x08
	}

	public class IndicatorDominator // TypeDefIndex: 12060
	{
		// Fields
		public uint conditionMax; // 0x10
		public uint conditionStates; // 0x14

		// Constructors
		public IndicatorDominator() {} // 0x00000001815ADB40-0x00000001815ADBA0

		// Methods
		// [XID] // 0x000000018969C6F0-0x000000018969C710
		public bool IsValid(IndicatorOperator opt) => default; // 0x00000001815AD9A0-0x00000001815ADA60
		// [XID] // 0x00000001896A3C90-0x00000001896A3CB0
		public void UpdateState(int index, bool flag) {} // 0x00000001815ADA60-0x00000001815ADB40
	}

	// Constructors
	public LCIndicatorPlugin() {} // 0x00000001815A6740-0x00000001815A67B0

	// Methods
	// [XID] // 0x0000000189622740-0x0000000189622760
	public override void Init() {} // 0x00000001815A4D60-0x00000001815A58F0
	// [XID] // 0x000000018962A0C0-0x000000018962A0E0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001815A4C90-0x00000001815A4D60
	// [XID] // 0x0000000189631860-0x0000000189631880
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001815A6340-0x00000001815A6680
	// [XID] // 0x00000001896392A0-0x00000001896392C0
	private void OnGadgetEvent(List<DominatorCondition> conditions, BaseEvent evt) {} // 0x00000001815A4AB0-0x00000001815A4C90
	// [XID] // 0x0000000189640700-0x0000000189640720
	public override void Tick(float inDeltaTime) {} // 0x00000001815A6680-0x00000001815A6740
	// [XID] // 0x0000000189648000-0x0000000189648020
	private void CheckDominator() {} // 0x00000001815A47D0-0x00000001815A49D0
	// [XID] // 0x000000018964F6B0-0x000000018964F6D0
	private bool DoCheck() => default; // 0x00000001815A5950-0x00000001815A5AF0
	// [XID] // 0x00000001896570A0-0x00000001896570C0
	public override void OnEnable() {} // 0x00000001815A6270-0x00000001815A6340
	// [XID] // 0x000000018965E790-0x000000018965E7B0
	public override void OnDisable() {} // 0x00000001815A61A0-0x00000001815A6270
	// [XID] // 0x0000000189665DA0-0x0000000189665DC0
	public override void Destroy() {} // 0x00000001815A44D0-0x00000001815A47D0
	// [IDTag] // 0x000000018966D510-0x000000018966D550
	// [XID] // 0x000000018966D510-0x000000018966D550
	public float Evaluate(TemplateParamFloat param) => default; // 0x00000001815A4020-0x00000001815A41A0
	// [IDTag] // 0x0000000189678370-0x00000001896783B0
	// [XID] // 0x0000000189678370-0x00000001896783B0
	public int Evaluate(TemplateParamInt32 param) => default; // 0x00000001815A41A0-0x00000001815A4310
	// [IDTag] // 0x0000000189682A60-0x0000000189682AA0
	// [XID] // 0x0000000189682A60-0x0000000189682AA0
	public string Evaluate(TemplateParamString param) => default; // 0x00000001815A4310-0x00000001815A4470
	// [XID] // 0x000000018968D390-0x000000018968D3B0
	private void ShowIcon() {} // 0x00000001815A5AF0-0x00000001815A5DD0
	// [XID] // 0x0000000189694F60-0x0000000189694F80
	private void HideIcon() {} // 0x00000001815A6020-0x00000001815A61A0
}

