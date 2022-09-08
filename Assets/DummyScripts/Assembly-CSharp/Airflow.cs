/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class Airflow // TypeDefIndex: 14735
{
	// Fields
	private BaseEntity _airflowEntity; // 0x10
	private LCAirflowField _airflow; // 0x18
	private VortexBuilder _vortexBuilder; // 0x20

	// Constructors
	public Airflow() {} // 0x0000000181FC3C00-0x0000000181FC4050

	// Methods
	// [XID] // 0x0000000189832730-0x0000000189832750
	public void Destroy() {} // 0x0000000181FC32A0-0x0000000181FC3540
	// [XID] // 0x0000000189839D90-0x0000000189839DB0
	private void OnGrassStateChanged(uint id, SceneObjState state, Bounds bounds) {} // 0x0000000181FC3860-0x0000000181FC39A0
	// [XID] // 0x0000000189841340-0x0000000189841360
	private void OnGrassRemoved(uint id) {} // 0x0000000181FC39A0-0x0000000181FC3A60
	// [XID] // 0x00000001898487E0-0x0000000189848800
	public void LateTick() {} // 0x0000000181FC3A60-0x0000000181FC3C00
	// [XID] // 0x0000000189850060-0x0000000189850080
	public bool CanTriggerInRange(Vector3 pos) => default; // 0x0000000181FC3600-0x0000000181FC36F0
	// [XID] // 0x0000000189857320-0x0000000189857340
	public bool HasAirflow() => default; // 0x0000000181FC37B0-0x0000000181FC3860
	// [XID] // 0x000000018985E4E0-0x000000018985E500
	public void AddToAirflow(BaseEntity entity) {} // 0x0000000181FC36F0-0x0000000181FC37B0
	// [XID] // 0x0000000189B7DC80-0x0000000189B7DCA0
	public void RemoveFromAirflow(BaseEntity entity) {} // 0x0000000181FC3540-0x0000000181FC3600
}

