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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelSceneColliderChangePlugin : BaseComponentPlugin // TypeDefIndex: 12077
{
	// Fields
	private const float NEED_REFRESH_GROUND_INFO_DISTANCE = 3f; // Metadata: 0x00AEB47C
	private LevelSceneSurfacePlugin _surfacePlugin; // 0x58
	private List<Bounds> _updateBounds; // 0x60
	private HashSet<uint> _monsterInBounds; // 0x68

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A01940-0x0000000189A01960 */ get => default; } // 0x0000000183085B30-0x0000000183085BD0 

	// Constructors
	public LevelSceneColliderChangePlugin() {} // 0x0000000183085A80-0x0000000183085B30

	// Methods
	// [XID] // 0x0000000189A093F0-0x0000000189A09410
	public override void OnEntityReady() {} // 0x00000001830854D0-0x00000001830855F0
	// [XID] // 0x0000000189A10880-0x0000000189A108A0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001830848A0-0x0000000183084980
	// [XID] // 0x0000000189A17F30-0x0000000189A17F50
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001830855F0-0x0000000183085A80
	// [XID] // 0x0000000189A1F550-0x0000000189A1F570
	public override void LateTick(float deltaTime) {} // 0x0000000183084EA0-0x0000000183085380
	// [XID] // 0x0000000189A26A70-0x0000000189A26A90
	private void HandleMonster(float deltaTime, BaseEntity entity, List<Bounds> bounds, bool refreshImmediately, bool forceUp, uint rockGadgetId) {} // 0x0000000183084980-0x0000000183084EA0
}

