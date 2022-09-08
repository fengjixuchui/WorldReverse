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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public sealed class AISensingKnowledge : Switchable, IAutoAllocRecycle // TypeDefIndex: 19971
{
	// Fields
	public ConfigAISensingSetting setting; // 0x18
	public Dictionary<string, ConfigAISensingSetting> templateInUse; // 0x20
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public Dictionary<uint, SensibleInfo> enemySensibles; // 0x28
	public float nearestEnemyDistance; // 0x30
	public uint nearestEnemy; // 0x34
	public bool scared; // 0x38

	// Nested types
	public struct SensibleInfo // TypeDefIndex: 19972
	{
		// Fields
		public uint sensibleID; // 0x00
		public Vector3 position; // 0x04
		public Vector3 targetablePosition; // 0x10
		public Vector3 direction; // 0x1C
		public float distance; // 0x28
		public bool hasLineOfSight; // 0x2C
		public bool isCharacterEntity; // 0x2D
	}

	// Constructors
	public AISensingKnowledge() {} // 0x000000018301CA20-0x000000018301CA90

	// Methods
	[BlackList] // 0x000000018969D4C0-0x000000018969D500
	// [XID] // 0x000000018969D4C0-0x000000018969D500
	public override void AutoAllocTypeFields() {} // 0x000000018301BF70-0x000000018301C040
	[BlackList] // 0x00000001896A7600-0x00000001896A7640
	// [XID] // 0x00000001896A7600-0x00000001896A7640
	public override void AutoRecycleTypeFields() {} // 0x000000018301C040-0x000000018301C120
	[BlackList] // 0x00000001896B1470-0x00000001896B14B0
	// [XID] // 0x00000001896B1470-0x00000001896B14B0
	public override void ReturnToObjectPool() {} // 0x000000018301C980-0x000000018301CA20
	// [XID] // 0x00000001896BBD60-0x00000001896BBD80
	public void ReInitByConfigID(BaseEntity.ReInitReason reason, ConfigAISensing configSensing, string initialPose, string initialTemplateName) {} // 0x000000018301C720-0x000000018301C980
	// [XID] // 0x0000000189679FE0-0x000000018967A000
	public void InitSensing(ConfigAISensing configSensing, string initialPose, string initialTemplateName) {} // 0x000000018301C280-0x000000018301C500
	// [XID] // 0x00000001896CA7F0-0x00000001896CA810
	public void SwitchSetting(int toPose) {} // 0x000000018301C500-0x000000018301C660
	// [XID] // 0x00000001896D1E80-0x00000001896D1EA0
	public BaseEntity GetNearestEnemy(float maxRange = 99f /* Metadata: 0x00AFD162 */) => default; // 0x000000018301C180-0x000000018301C280
}

