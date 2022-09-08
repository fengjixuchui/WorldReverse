/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigLuaHack : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18536
{
	// Fields
	private string _UILuaScriptPath; // 0x10
	private bool _enableLuaPatch; // 0x18
	private bool _enableAllContextLuaPatch; // 0x19
	private string[] _UILuaPatchContextStartupList; // 0x20
	private string[] _UILuaPatchContextSetupViewList; // 0x28
	private string[] _UILuaPatchContextPostSetupViewList; // 0x30
	private string[] _UILuaPatchContextSetActiveEnabledList; // 0x38
	private string[] _UILuaPatchContextSetActiveDisabledList; // 0x40
	private string[] _UILuaPatchContextDestroyList; // 0x48
	private string[] _UILuaPatchContextDestroyForceList; // 0x50
	private Dictionary<string, string[]> _UILuaPatchContextButtonMap; // 0x58
	private Dictionary<string, string[]> _UILuaPatchContextInputFieldMap; // 0x60
	private Dictionary<string, string[]> _UILuaPatchContextDrowdownMap; // 0x68
	private Dictionary<string, string[]> _UILuaPatchContextToggleMap; // 0x70
	private Dictionary<string, string[]> _UILuaPatchContextSliderMap; // 0x78
	private Dictionary<string, string[]> _UILuaPatchContextPanelMap; // 0x80

	// Properties
	public string UILuaScriptPath { /* [XID] */ /* 0x00000001896056D0-0x00000001896056F0 */ get => default; /* [XID] */ /* 0x000000018960D080-0x000000018960D0A0 */ private set {} } // 0x0000000182ADA530-0x0000000182ADA5D0 0x0000000182AD9EF0-0x0000000182AD9FA0
	public bool enableLuaPatch { /* [XID] */ /* 0x00000001896146E0-0x0000000189614700 */ get => default; /* [XID] */ /* 0x000000018961BFF0-0x000000018961C010 */ private set {} } // 0x0000000182ADA340-0x0000000182ADA3E0 0x0000000182AD95E0-0x0000000182AD9690
	public bool enableAllContextLuaPatch { /* [XID] */ /* 0x0000000189623540-0x0000000189623560 */ get => default; /* [XID] */ /* 0x000000018962AE00-0x000000018962AE20 */ private set {} } // 0x0000000182AD80E0-0x0000000182AD8180 0x0000000182AD8030-0x0000000182AD80E0
	public string[] UILuaPatchContextStartupList { /* [XID] */ /* 0x00000001896324E0-0x0000000189632500 */ get => default; /* [XID] */ /* 0x0000000189639F90-0x0000000189639FB0 */ private set {} } // 0x0000000182AD9120-0x0000000182AD91C0 0x0000000182AD9740-0x0000000182AD97F0
	public string[] UILuaPatchContextSetupViewList { /* [XID] */ /* 0x0000000189641500-0x0000000189641520 */ get => default; /* [XID] */ /* 0x0000000189648EA0-0x0000000189648EC0 */ private set {} } // 0x0000000182AD8FE0-0x0000000182AD9080 0x0000000182AD6B80-0x0000000182AD6C30
	public string[] UILuaPatchContextPostSetupViewList { /* [XID] */ /* 0x00000001896504D0-0x00000001896504F0 */ get => default; /* [XID] */ /* 0x0000000189657E10-0x0000000189657E30 */ private set {} } // 0x0000000182AD9080-0x0000000182AD9120 0x0000000182AD9930-0x0000000182AD99E0
	public string[] UILuaPatchContextSetActiveEnabledList { /* [XID] */ /* 0x000000018965F440-0x000000018965F460 */ get => default; /* [XID] */ /* 0x0000000189666D50-0x0000000189666D70 */ private set {} } // 0x0000000182ADA490-0x0000000182ADA530 0x0000000182AD8180-0x0000000182AD8230
	public string[] UILuaPatchContextSetActiveDisabledList { /* [XID] */ /* 0x000000018966E4A0-0x000000018966E4C0 */ get => default; /* [XID] */ /* 0x0000000189676160-0x0000000189676180 */ private set {} } // 0x0000000182ADA670-0x0000000182ADA710 0x0000000182AD8F30-0x0000000182AD8FE0
	public string[] UILuaPatchContextDestroyList { /* [XID] */ /* 0x00000001899BBCA0-0x00000001899BBCC0 */ get => default; /* [XID] */ /* 0x0000000189685040-0x0000000189685060 */ private set {} } // 0x0000000182AD97F0-0x0000000182AD9890 0x0000000182AD9690-0x0000000182AD9740
	public string[] UILuaPatchContextDestroyForceList { /* [XID] */ /* 0x000000018968CB00-0x000000018968CB20 */ get => default; /* [XID] */ /* 0x0000000189694640-0x0000000189694660 */ private set {} } // 0x0000000182ADA2A0-0x0000000182ADA340 0x0000000182ADA3E0-0x0000000182ADA490
	public Dictionary<string, string[]> UILuaPatchContextButtonMap { /* [XID] */ /* 0x000000018969BC80-0x000000018969BCA0 */ get => default; /* [XID] */ /* 0x00000001896A3240-0x00000001896A3260 */ private set {} } // 0x0000000182AD8230-0x0000000182AD82D0 0x0000000182AD9B40-0x0000000182AD9BF0
	public Dictionary<string, string[]> UILuaPatchContextInputFieldMap { /* [XID] */ /* 0x00000001896AA6F0-0x00000001896AA710 */ get => default; /* [XID] */ /* 0x00000001896B1730-0x00000001896B1750 */ private set {} } // 0x0000000182AD91C0-0x0000000182AD9260 0x0000000182AD9A90-0x0000000182AD9B40
	public Dictionary<string, string[]> UILuaPatchContextDrowdownMap { /* [XID] */ /* 0x00000001896B90D0-0x00000001896B90F0 */ get => default; /* [XID] */ /* 0x00000001896C04E0-0x00000001896C0500 */ private set {} } // 0x0000000182ADA5D0-0x0000000182ADA670 0x0000000182AD6C30-0x0000000182AD6CE0
	public Dictionary<string, string[]> UILuaPatchContextToggleMap { /* [XID] */ /* 0x00000001896C7C30-0x00000001896C7C50 */ get => default; /* [XID] */ /* 0x00000001896CF5F0-0x00000001896CF610 */ private set {} } // 0x0000000182AD9890-0x0000000182AD9930 0x0000000182AD82D0-0x0000000182AD8380
	public Dictionary<string, string[]> UILuaPatchContextSliderMap { /* [XID] */ /* 0x00000001896D67C0-0x00000001896D67E0 */ get => default; /* [XID] */ /* 0x00000001896DDE60-0x00000001896DDE80 */ private set {} } // 0x0000000182AD9BF0-0x0000000182AD9C90 0x0000000182AD9E40-0x0000000182AD9EF0
	public Dictionary<string, string[]> UILuaPatchContextPanelMap { /* [XID] */ /* 0x00000001896E5430-0x00000001896E5450 */ get => default; /* [XID] */ /* 0x00000001896ECAA0-0x00000001896ECAC0 */ private set {} } // 0x0000000182AD7F80-0x0000000182AD8030 0x0000000182AD99E0-0x0000000182AD9A90

	// Constructors
	public ConfigLuaHack() {} // 0x0000000182ADB7B0-0x0000000182ADB820

	// Methods
	// [XID] // 0x00000001896F42A0-0x00000001896F42C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182ADB350-0x0000000182ADB5D0
	// [XID] // 0x00000001896FBAB0-0x00000001896FBAD0
	public void InitEmpty() {} // 0x0000000182AD9C90-0x0000000182AD9E40
	[BlackList] // 0x0000000189703010-0x0000000189703050
	// [XID] // 0x0000000189703010-0x0000000189703050
	public bool FromJson(JSONNode node) => default; // 0x0000000182AD9260-0x0000000182AD95E0
	// [XID] // 0x000000018970D7B0-0x000000018970D7D0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182AD6CE0-0x0000000182AD7B30
	// [XID] // 0x0000000189714C50-0x0000000189714C70
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA0F1 */, bool useObjectPool = false /* Metadata: 0x00AFA0F5 */) => default; // 0x0000000182AD9FA0-0x0000000182ADA2A0
	// [XID] // 0x000000018971C5C0-0x000000018971C5E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA0F6 */, bool useObjectPool = false /* Metadata: 0x00AFA0FA */) => default; // 0x0000000182AD8380-0x0000000182AD8F30
	[BlackList] // 0x0000000189723AF0-0x0000000189723B30
	// [XID] // 0x0000000189723AF0-0x0000000189723B30
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182AD7B30-0x0000000182AD7E00
	// [XID] // 0x000000018972E210-0x000000018972E230
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182ADA710-0x0000000182ADB350
	[BlackList] // 0x00000001897358E0-0x0000000189735920
	// [XID] // 0x00000001897358E0-0x0000000189735920
	public virtual void AutoAllocTypeFields() {} // 0x0000000182AD7E00-0x0000000182AD7EA0
	[BlackList] // 0x0000000189740800-0x0000000189740840
	// [XID] // 0x0000000189740800-0x0000000189740840
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182AD7EA0-0x0000000182AD7F80
	[BlackList] // 0x000000018974B000-0x000000018974B040
	// [XID] // 0x000000018974B000-0x000000018974B040
	public virtual void ReturnToObjectPool() {} // 0x0000000182ADB710-0x0000000182ADB7B0
	[BlackList] // 0x0000000189755490-0x00000001897554D0
	// [XID] // 0x0000000189755490-0x00000001897554D0
	public virtual void OnPoolAllocated() {} // 0x0000000182ADB670-0x0000000182ADB710
	[BlackList] // 0x000000018975FA10-0x000000018975FA50
	// [XID] // 0x000000018975FA10-0x000000018975FA50
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182ADB5D0-0x0000000182ADB670
}

