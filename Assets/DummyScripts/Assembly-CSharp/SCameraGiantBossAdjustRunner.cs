/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoCamera;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SCameraGiantBossAdjustRunner : SCameraStateBaseRunner<SCameraGiantBossAdjustState> // TypeDefIndex: 32083
{
	// Fields
	private List<SCameraGiantBossAdjustData> _stack; // 0x658
	private SCameraGiantBossAdjustData _currData; // 0x660
	private SCameraModuleInitialize _initialModule; // 0x670
	public bool enterLocking; // 0x678

	// Constructors
	public SCameraGiantBossAdjustRunner() {} // 0x0000000181F11810-0x0000000181F118D0

	// Methods
	// [XID] // 0x000000018977CBB0-0x000000018977CBD0
	protected override void InitModules() {} // 0x0000000181F10C60-0x0000000181F10DB0
	// [XID] // 0x0000000189784630-0x0000000189784650
	public void EnterLocking() {} // 0x0000000181F11080-0x0000000181F11120
	// [XID] // 0x000000018978BC20-0x000000018978BC40
	public SCameraGiantBossAdjustData GetBossData() => default; // 0x0000000181F11180-0x0000000181F113C0
	// [XID] // 0x00000001897930D0-0x00000001897930F0
	public void UpdateByBlendSrc(ICameraState state) {} // 0x0000000181F101A0-0x0000000181F10AA0
	// [XID] // 0x000000018979B340-0x000000018979B360
	public override void OnSpawn() {} // 0x0000000181F0FE00-0x0000000181F0FEF0
	// [XID] // 0x00000001897A2820-0x00000001897A2840
	public void RefreshCombatSetting(double deltaTime) {} // 0x0000000181F114A0-0x0000000181F11550
	// [XID] // 0x00000001897A9D20-0x00000001897A9D40
	protected override void CollectPreInternal() {} // 0x0000000181F0FEF0-0x0000000181F0FFA0
	// [XID] // 0x00000001897B16F0-0x00000001897B1710
	protected override void HandleRotateCmd(ref SCameraCmd cmd) {} // 0x0000000181F10DB0-0x0000000181F11080
	// [XID] // 0x00000001897B9110-0x00000001897B9130
	protected override void HandleZoomCmd(ref SCameraCmd cmd) {} // 0x0000000181F0FD00-0x0000000181F0FE00
	// [XID] // 0x00000001897C1220-0x00000001897C1240
	public override void OnUnSpawn() {} // 0x0000000181F11550-0x0000000181F11700
	// [XID] // 0x0000000189728CC0-0x0000000189728CE0
	public void EnterGiantBossAdjust(SCameraGiantBossAdjustData bossData) {} // 0x0000000181F0FBB0-0x0000000181F0FD00
	// [XID] // 0x00000001897D02A0-0x00000001897D02C0
	public void ExitGiantBossAdjust(SCameraGiantBossAdjustData bossData) {} // 0x0000000181F0FFA0-0x0000000181F101A0
	// [XID] // 0x00000001897D7F20-0x00000001897D7F40
	protected override void TickInternal(float deltaTime) {} // 0x0000000181F11700-0x0000000181F11810
}

