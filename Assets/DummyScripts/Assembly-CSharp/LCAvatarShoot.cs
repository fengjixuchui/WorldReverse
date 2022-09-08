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

public sealed class LCAvatarShoot : LCBase // TypeDefIndex: 11704
{
	// Fields
	private VCAvatarFocus _vcFocus; // 0x130
	private ConfigShoot _normalShootConfig; // 0x138
	private ConfigShoot _aimingShootConfig; // 0x150
	public ShootCollisionData shootData; // 0x168
	private float AIM_ANGLE_THRESHOLD_FAR; // 0x198
	private float AIM_ANGLE_THRESHOLD_NEAR; // 0x19C
	private float AIM_ANGLE_THRESHOLD_THRESHOLD_SQR; // 0x1A0
	private RaycastHit[] _testHitRaycastHits; // 0x1A8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001897DBB90-0x00000001897DBBB0 */ get => default; } // 0x0000000182208100-0x0000000182208390 
	public ConfigShoot CurShootConfig { /* [XID] */ /* 0x00000001897E3600-0x00000001897E3620 */ get => default; } // 0x0000000182206580-0x00000001822066B0 

	// Nested types
	public struct ConfigShoot // TypeDefIndex: 11705
	{
		// Fields
		public Transform bulletBornTran; // 0x00
		public float detectRangeFromViewport; // 0x08
		public float detectRadiusFromViewport; // 0x0C
		public float autoFocusMinRange; // 0x10
		public float autoFocusMaxRange; // 0x14
	}

	public struct ShootCollisionData // TypeDefIndex: 11706
	{
		// Fields
		public Vector3 shootPos; // 0x00
		public Vector3 shootTarPos; // 0x0C
		public BaseEntity shootTarEntity; // 0x18
		public Vector3 shootForward; // 0x20
	}

	// Constructors
	public LCAvatarShoot() {} // 0x0000000182208080-0x0000000182208100

	// Methods
	// [XID] // 0x00000001897EADE0-0x00000001897EAE00
	public override void Init() {} // 0x0000000182206370-0x0000000182206580
	// [XID] // 0x00000001897F2B50-0x00000001897F2B70
	public override void Destroy() {} // 0x0000000182205510-0x00000001822055F0
	// [XID] // 0x00000001897FA390-0x00000001897FA3B0
	private ConfigShoot LoadShootConfig(ConfigShoot config) => default; // 0x0000000182205330-0x0000000182205510
	// [XID] // 0x00000001898018F0-0x0000000189801910
	protected override void Tick(float inDeltaTime) {} // 0x0000000182207D30-0x0000000182208080
	// [XID] // 0x0000000189808D90-0x0000000189808DB0
	private void UpdateNormalShoot() {} // 0x00000001822055F0-0x0000000182205740
	// [XID] // 0x0000000189810680-0x00000001898106A0
	public void UpdateNormalWhenDoShoot() {} // 0x0000000182206710-0x0000000182206AA0
	// [XID] // 0x0000000189817DC0-0x0000000189817DE0
	private void UpdateFocusShoot() {} // 0x0000000182204E50-0x00000001822052D0
	// [XID] // 0x000000018981F6F0-0x000000018981F710
	public void UpdateFocusShootWhenDoShoot() {} // 0x00000001822073B0-0x0000000182207D30
	// [XID] // 0x0000000189826C70-0x0000000189826C90
	private ShootCollisionData GetCollisionOnRaycast(Vector3 point, Vector3 direction, float range) => default; // 0x0000000182206B10-0x00000001822073B0
	// [XID] // 0x000000018982E300-0x000000018982E320
	private ShootCollisionData GetCollisionOnSphereCast(Vector3 point, float radius, Vector3 direction, float range) => default; // 0x00000001822057C0-0x0000000182206070
	// [XID] // 0x0000000189835A70-0x0000000189835A90
	private bool IsValidTarget(GameObject hitGameObject, BaseEntity hitEntity) => default; // 0x0000000182206070-0x0000000182206370
}

