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

public sealed class LevelSceneAirflowFieldPlugin : BaseComponentPlugin // TypeDefIndex: 12075
{
	// Fields
	private Airflow _airflow; // 0x58
	private List<BaseEntity> _entitiesNotInAirflow; // 0x60
	private List<BaseEntity> _entitiesInAirflow; // 0x68
	private const float TICK_INTERVAL = 0.1f; // Metadata: 0x00AEB474
	private float _tickInterval; // 0x70

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018995E210-0x000000018995E230 */ get => default; } // 0x0000000182757B10-0x0000000182757BB0 

	// Constructors
	public LevelSceneAirflowFieldPlugin() {} // 0x0000000182757A60-0x0000000182757B10

	// Methods
	// [XID] // 0x0000000189965B80-0x0000000189965BA0
	public void OnEntityInAirStateChanged(BaseEntity entity, bool isInAir) {} // 0x0000000182756F90-0x0000000182757080
	// [XID] // 0x000000018996D1D0-0x000000018996D1F0
	private void TryAddRelatedEntity(BaseEntity entity) {} // 0x0000000182756E80-0x0000000182756F90
	// [XID] // 0x0000000189B766C0-0x0000000189B766E0
	private void TryRemoveRelatedEntity(BaseEntity entity) {} // 0x0000000182757430-0x0000000182757590
	// [XID] // 0x000000018997BFA0-0x000000018997BFC0
	private bool TickIntervalReady() => default; // 0x00000001827571F0-0x0000000182757300
	// [XID] // 0x0000000189983BF0-0x0000000189983C10
	public override void Init() {} // 0x0000000182757300-0x00000001827573D0
	// [XID] // 0x000000018998B4C0-0x000000018998B4E0
	public override void LateTick(float deltaTime) {} // 0x0000000182757590-0x00000001827579F0
	// [XID] // 0x0000000189993040-0x0000000189993060
	public override void Destroy() {} // 0x0000000182757100-0x00000001827571F0
}

