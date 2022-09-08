/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[fiInspectorOnly] // 0x0000000189ABD060-0x0000000189ABD070
public abstract class BaseCombatScenePropObject : BaseScenePropObject, IAutoAllocRecycle, ICombatSceneProp // TypeDefIndex: 20023
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public Bounds realBounds; // 0x30
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public uint entityId; // 0x48
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private Vector3[] _anims; // 0x50
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public Vector3 originalPos; // 0x58
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _playTime; // 0x64
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private bool _isFinish; // 0x68
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected bool _die; // 0x69

	// Constructors
	protected BaseCombatScenePropObject() {} // 0x0000000181682380-0x0000000181682410

	// Methods
	[BlackList] // 0x00000001897B6D30-0x00000001897B6D70
	// [XID] // 0x00000001897B6D30-0x00000001897B6D70
	public override void AutoAllocTypeFields() {} // 0x0000000181680810-0x00000001816808B0
	[BlackList] // 0x00000001897C18D0-0x00000001897C1910
	// [XID] // 0x00000001897C18D0-0x00000001897C1910
	public override void AutoRecycleTypeFields() {} // 0x00000001816808B0-0x00000001816809A0
	[BlackList] // 0x00000001897CBE50-0x00000001897CBE90
	// [XID] // 0x00000001897CBE50-0x00000001897CBE90
	public override void ReturnToObjectPool() {} // 0x00000001816822E0-0x0000000181682380
	// [XID] // 0x00000001897D6760-0x00000001897D6780
	protected override void AddScenePropToManager() {} // 0x0000000181681210-0x00000001816812B0
	// [XID] // 0x00000001897DDF50-0x00000001897DDF70
	protected override void RemoveScenePropFromManager() {} // 0x00000001816813F0-0x0000000181681490
	// [XID] // 0x00000001897E59C0-0x00000001897E59E0
	public override void LodLevelUpdate(int lodLevel) {} // 0x0000000181681620-0x0000000181681790
	protected abstract ScenePropCombatBaseConfig GetConfig();
	// [XID] // 0x00000001897ED4F0-0x00000001897ED510
	public Vector3 GetRootOffset() => default; // 0x0000000181681010-0x0000000181681120
	// [XID] // 0x00000001897F4C70-0x00000001897F4C90
	public override void ReleaseSceneProp() {} // 0x0000000181681E00-0x0000000181681EB0
	// [XID] // 0x00000001897FC740-0x00000001897FC760
	public void SetAnimations(Vector3[] anim) {} // 0x0000000181681890-0x0000000181681940
	// [XID] // 0x0000000189803CB0-0x0000000189803CD0
	public virtual void BeingHit(EvtBeingHit beingHitEvent) {} // 0x0000000181681AD0-0x0000000181681CB0
	// [XID] // 0x000000018980B150-0x000000018980B170
	public void TickShake() {} // 0x00000001816809A0-0x0000000181680E50
	// [XID] // 0x00000001898127A0-0x00000001898127C0
	public bool IsFinish() => default; // 0x0000000181681350-0x00000001816813F0
	// [XID] // 0x000000018981A460-0x000000018981A480
	protected void Clear() {} // 0x0000000181681510-0x00000001816815C0
	// [XID] // 0x0000000189821B30-0x0000000189821B50
	public override void RefreshSceneProp(GameObject obj) {} // 0x0000000181682210-0x00000001816822E0
	// [XID] // 0x0000000189829080-0x00000001898290A0
	protected void CalculateBounds() {} // 0x0000000181680670-0x0000000181680810
	// [XID] // 0x0000000189830630-0x0000000189830650
	public Bounds GetBounds() => default; // 0x0000000181681CB0-0x0000000181681DA0
	// [XID] // 0x0000000189837BF0-0x0000000189837C10
	public Vector3 GetPosition() => default; // 0x0000000181681120-0x0000000181681210
	// [XID] // 0x000000018983F3F0-0x000000018983F410
	public virtual uint GetConfigID() => default; // 0x00000001816812B0-0x0000000181681350
	// [XID] // 0x0000000189846A50-0x0000000189846A70
	public virtual int GetEffectConfigID() => default; // 0x0000000181680F10-0x0000000181680FB0
	// [XID] // 0x000000018984E080-0x000000018984E0A0
	public virtual void RefreshEffectConfig() {} // 0x0000000181681EB0-0x0000000181681F50
	// [XID] // 0x0000000189855110-0x0000000189855130
	public Transform GetTransform() => default; // 0x0000000181682110-0x0000000181682210
	// [XID] // 0x000000018985C7F0-0x000000018985C810
	public MoleMole.SceneSurfaceMaterial GetSurfaceType() => default; // 0x0000000181682000-0x00000001816820A0
	// [XID] // 0x0000000189864150-0x0000000189864170
	public void ResetAnimations(Vector3[] vec) {} // 0x0000000181681F50-0x0000000181682000
	// [XID] // 0x000000018986B540-0x000000018986B560
	public virtual void Die() {} // 0x0000000181681940-0x0000000181681A70
	// [XID] // 0x00000001898728B0-0x00000001898728D0
	private void RefreshMainObj() {} // 0x0000000181681790-0x0000000181681890
}

