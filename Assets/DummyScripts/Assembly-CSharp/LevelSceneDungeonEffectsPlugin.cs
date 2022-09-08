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

public sealed class LevelSceneDungeonEffectsPlugin : BaseComponentPlugin // TypeDefIndex: 12080
{
	// Fields
	private MonoEffectProxy _dungeonFogCameraEffect; // 0x58
	private MonoEffectProxy _dungeonFogPlayerEffect; // 0x60
	private Vector3 _localOffSet; // 0x68

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189AB5000-0x0000000189AB5020 */ get => default; } // 0x000000018472F970-0x000000018472FA10 

	// Constructors
	public LevelSceneDungeonEffectsPlugin() {} // 0x000000018472F8D0-0x000000018472F970

	// Methods
	// [XID] // 0x0000000189ABCC80-0x0000000189ABCCA0
	public override void Destroy() {} // 0x000000018472EEA0-0x000000018472EF50
	// [XID] // 0x0000000189AC4610-0x0000000189AC4630
	public void TickAfterCamera(float deltaTime) {} // 0x000000018472F520-0x000000018472F860
	// [XID] // 0x0000000189ACBC50-0x0000000189ACBC70
	public void CreateDungeonFogEffects(string cameraEffectName, string playerEffectName, Vector3 localOffSet) {} // 0x000000018472F020-0x000000018472F4C0
	// [XID] // 0x0000000189AD3650-0x0000000189AD3670
	public void DestroyDungeonFogEffects() {} // 0x000000018472EF50-0x000000018472F020
}

