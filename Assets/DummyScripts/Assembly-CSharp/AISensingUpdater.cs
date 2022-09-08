/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AISensingUpdater : BrainModuleBase // TypeDefIndex: 20429
{
	// Fields
	private Dictionary<uint, AISensingKnowledge.SensibleInfo> _enemySensibles; // 0x30
	private Dictionary<uint, AISensingKnowledge.SensibleInfo> _enemySensiblesPreparation; // 0x38
	private LCAIManager _aiManager; // 0x40

	// Constructors
	public AISensingUpdater() {} // Dummy constructor
	public AISensingUpdater(AIKnowledge knowledge) {} // 0x000000018129A810-0x000000018129A960

	// Methods
	// [XID] // 0x00000001898246E0-0x0000000189824700
	protected override void UpdateMainThreadInternal(float deltaTime) {} // 0x000000018129A080-0x000000018129A150
	// [XID] // 0x000000018982C190-0x000000018982C1B0
	protected override void UpdateComputeThreadInternal(float deltaTime) {} // 0x0000000181298F00-0x0000000181298FD0
	// [XID] // 0x0000000189833680-0x00000001898336A0
	private void CollectEnemies() {} // 0x0000000181299050-0x0000000181299640
	// [XID] // 0x000000018983AB40-0x000000018983AB60
	private void ProcessEnemies() {} // 0x0000000181299640-0x000000018129A000
	// [XID] // 0x0000000189842200-0x0000000189842220
	public static bool CanSignalBeNoticed(AIKnowledge knowledge, Vector3 checkPos) => default; // 0x0000000181298C80-0x0000000181298F00
	// [XID] // 0x00000001898495E0-0x0000000189849600
	public void OnDrawVisionInfo() {} // 0x000000018129A150-0x000000018129A810
}

