/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtWeatherChange : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20180
{
	// Fields
	public string name; // 0x30
	public ConfigWeatherType toWeather; // 0x38

	// Constructors
	public EvtWeatherChange() {} // 0x000000018465DEA0-0x000000018465DF00

	// Methods
	[BlackList] // 0x0000000189B65420-0x0000000189B65460
	// [XID] // 0x0000000189B65420-0x0000000189B65460
	public override void AutoAllocTypeFields() {} // 0x000000018465D940-0x000000018465D9E0
	[BlackList] // 0x0000000189B6FA80-0x0000000189B6FAC0
	// [XID] // 0x0000000189B6FA80-0x0000000189B6FAC0
	public override void AutoRecycleTypeFields() {} // 0x000000018465D9E0-0x000000018465DA90
	[BlackList] // 0x0000000189B7A110-0x0000000189B7A150
	// [XID] // 0x0000000189B7A110-0x0000000189B7A150
	public override void ReturnToObjectPool() {} // 0x000000018465DD00-0x000000018465DDA0
	// [XID] // 0x0000000189B84D90-0x0000000189B84DB0
	public void Init(string name, ConfigWeatherType toWeather) {} // 0x000000018465DB60-0x000000018465DC40
	// [XID] // 0x0000000189B8BB40-0x0000000189B8BB60
	public override string ToString() => default; // 0x000000018465DDA0-0x000000018465DEA0
}

