/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class CutsceneTaskFactory // TypeDefIndex: 20696
{
	// Constructors
	public CutsceneTaskFactory() {} // 0x0000000181A06A50-0x0000000181A06AB0

	// Methods
	// [XID] // 0x0000000189B2AD20-0x0000000189B2AD40
	public static CutsceneTask CreateForPreContext(BaseInterAction interAction, ILuaActor ownerActor, Action<ILuaActor> finishCallback = null, Action<ILuaActor> startCallback = null, Action<ILuaActor> destroyCallback = null) => default; // 0x0000000181A061F0-0x0000000181A06340
	// [XID] // 0x0000000189B32240-0x0000000189B32260
	public static CutsceneTask CreateByInterAction(BaseInterAction interAction) => default; // 0x0000000181A067D0-0x0000000181A06970
	// [XID] // 0x0000000189B39BF0-0x0000000189B39C10
	public static CutsceneTask CreateByConfig(ConfigBaseCutscene cfg, ILuaActor ownerActor, Action<ILuaActor> finishCallback = null, Action<ILuaActor> startCallback = null, Action<ILuaActor> destroyCallback = null) => default; // 0x0000000181A06690-0x0000000181A067D0
	// [XID] // 0x0000000189B414B0-0x0000000189B414D0
	public static CutscenePreTask CreatePreTaskByConfig(ConfigCutscenePreTask cfg) => default; // 0x0000000181A06970-0x0000000181A06A50
	// [IDTag] // 0x0000000189B48E60-0x0000000189B48EA0
	// [XID] // 0x0000000189B48E60-0x0000000189B48EA0
	public static CutsceneFadeTask CreateFadeTask(ConfigTimeline cfg, CutsceneFadeTask.FadeType fadeType, Action<ILuaActor> finishHandler = null) => default; // 0x0000000181A06340-0x0000000181A06450
	// [IDTag] // 0x0000000189B53440-0x0000000189B53480
	// [XID] // 0x0000000189B53440-0x0000000189B53480
	public static CutsceneFadeTask CreateFadeTask(float duration, CutsceneFadeTask.FadeType fadeType, Action<ILuaActor> finishHandler = null) => default; // 0x0000000181A06450-0x0000000181A06560
	// [XID] // 0x0000000189B5DE40-0x0000000189B5DE60
	public static CutsceneFreeTask CreateFreeTaskByConfig(ConfigBaseCutscene cfg, ILuaActor ownerActor, Action<ILuaActor> finishCallback = null, Action<ILuaActor> startCallback = null) => default; // 0x0000000181A06560-0x0000000181A06690
}

