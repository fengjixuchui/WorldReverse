/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelConfigStreamingPlugin : BaseComponentPlugin // TypeDefIndex: 12069
{
	// Fields
	private static readonly float LOAD_AXIS_DISTANCE; // 0x00
	private static readonly float UNLOAD_AXIS_DISTANCE; // 0x04
	public static bool needStopStreaming; // 0x08
	private static Vector3 _localAvatarPosition; // 0x0C
	private static int _checkIndex; // 0x18
	private static int _frameCount; // 0x1C

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898518F0-0x0000000189851910 */ get => default; } // 0x0000000185B35520-0x0000000185B35660 

	// Constructors
	public LevelConfigStreamingPlugin() {} // 0x0000000185B354C0-0x0000000185B35520
	static LevelConfigStreamingPlugin() {} // 0x0000000185B35450-0x0000000185B354C0

	// Methods
	// [XID] // 0x0000000189858F90-0x0000000189858FB0
	public override void Init() {} // 0x0000000185B343C0-0x0000000185B34570
	// [XID] // 0x0000000189860190-0x00000001898601B0
	public override void Destroy() {} // 0x0000000185B33FA0-0x0000000185B340A0
	// [XID] // 0x0000000189867850-0x0000000189867870
	public override void LateTick(float deltaTime) {} // 0x0000000185B347D0-0x0000000185B34E90
	// [XID] // 0x000000018986EF80-0x000000018986EFA0
	public static void ReloadLevelConfig(Vector3 center, bool async) {} // 0x0000000185B34E90-0x0000000185B353E0
	// [XID] // 0x0000000189876470-0x0000000189876490
	private static void LoadInternal(ConfigLevelBlockMeta blockInfo, bool async) {} // 0x0000000185B340A0-0x0000000185B343C0
	// [XID] // 0x000000018987E050-0x000000018987E070
	private static void UnloadInternal(ConfigLevelBlockMeta blockInfo) {} // 0x0000000185B345D0-0x0000000185B347D0
}

