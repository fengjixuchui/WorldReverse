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

public class VCNormalPickable : VCBasePickable // TypeDefIndex: 11917
{
	// Fields
	private Vector3 _lastPos; // 0x190
	private float _lastCheckTime; // 0x19C
	private float _intervalTime; // 0x1A0
	private EntityTimer _objTimer; // 0x1A8
	private float _lifeTime; // 0x1B0
	private float _stopThreshold; // 0x1B4
	private float _forceStopThreshold; // 0x1B8
	private Vector3 _controlVelocity; // 0x1BC
	public Vector3 initVelocity; // 0x1C8
	public bool isMonsterDrop; // 0x1D4
	private uint _dropSound; // 0x1D8
	private float _bounceCheckThreshold; // 0x1DC
	private Vector3 _lastPredictPos; // 0x1E0
	private float _lastVelocityY; // 0x1EC
	private int _dropSoundPlayedCount; // 0x1F0
	private readonly int DROP_SOUND_LIMIT; // 0x1F4

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018989C970-0x000000018989C990 */ get => default; } // 0x00000001836DB230-0x00000001836DB2D0 

	// Constructors
	public VCNormalPickable() {} // 0x00000001836DB110-0x00000001836DB230

	// Methods
	// [XID] // 0x00000001898A41C0-0x00000001898A41E0
	public override void Init() {} // 0x00000001836DA1D0-0x00000001836DA370
	// [XID] // 0x0000000189A9D3A0-0x0000000189A9D3C0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x00000001836DAD90-0x00000001836DAEF0
	// [XID] // 0x00000001898B2CA0-0x00000001898B2CC0
	public virtual void CheckConfigCollider() {} // 0x00000001836D7C80-0x00000001836D7FF0
	// [XID] // 0x0000000189AA4B20-0x0000000189AA4B40
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x00000001836D7FF0-0x00000001836D80E0
	// [XID] // 0x0000000189AAC1D0-0x0000000189AAC1F0
	public override void Destroy() {} // 0x00000001836D80E0-0x00000001836D8250
	// [XID] // 0x0000000189AB3A90-0x0000000189AB3AB0
	protected override Vector3 GetInitVelocity() => default; // 0x00000001836D73C0-0x00000001836D7B20
	// [XID] // 0x0000000189AD1F80-0x0000000189AD1FA0
	protected override Vector3 GetInitAngularVelocity() => default; // 0x00000001836D9A20-0x00000001836DA1D0
	// [XID] // 0x00000001898D85C0-0x00000001898D85E0
	protected override void InitPickComponents() {} // 0x00000001836D8BC0-0x00000001836D8F10
	// [XID] // 0x00000001898E0440-0x00000001898E0460
	protected override void RemovePickableComponents() {} // 0x00000001836DAA20-0x00000001836DAAC0
	// [XID] // 0x0000000189AF0980-0x0000000189AF09A0
	private void CheckPlayDropEffect() {} // 0x00000001836DA430-0x00000001836DA570
	// [XID] // 0x00000001898EF640-0x00000001898EF660
	private void CheckPlayLandSound(float deltaTime) {} // 0x00000001836D82E0-0x00000001836D87D0
	// [XID] // 0x00000001898F6EF0-0x00000001898F6F10
	protected override void Tick(float inDeltaTime) {} // 0x00000001836DAEF0-0x00000001836DB110
	// [XID] // 0x00000001898FE680-0x00000001898FE6A0
	private bool HandleState() => default; // 0x00000001836D8F10-0x00000001836D9260
	// [XID] // 0x0000000189905DA0-0x0000000189905DC0
	private bool NeedSelfRotate() => default; // 0x00000001836DAAC0-0x00000001836DABB0
	// [XID] // 0x0000000189B246C0-0x0000000189B246E0
	private void CheckInitRotation() {} // 0x00000001836D9410-0x00000001836D97D0
	// [XID] // 0x0000000189B1D0D0-0x0000000189B1D0F0
	public void CheckPosition() {} // 0x00000001836D8920-0x00000001836D8BC0
	// [XID] // 0x000000018991CAD0-0x000000018991CAF0
	public override void ResetPickComponents(bool forceReset = false /* Metadata: 0x00AEAF4C */) {} // 0x00000001836DA570-0x00000001836DA6E0
	// [XID] // 0x0000000189B32FD0-0x0000000189B32FF0
	public override void OnSceneLoad() {} // 0x00000001836D9340-0x00000001836D9410
	// [XID] // 0x000000018992B820-0x000000018992B840
	protected void InitDropSound() {} // 0x00000001836DA6E0-0x00000001836DA8B0
	// [XID] // 0x0000000189932FE0-0x0000000189933000
	protected void PlayDropSound() {} // 0x00000001836D9830-0x00000001836D9A20
	// [XID] // 0x000000018993A8A0-0x000000018993A8C0
	protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001836D9260-0x00000001836D9340
	// [XID] // 0x0000000189B422B0-0x0000000189B422D0
	protected override bool OnEvent(BaseEvent e) => default; // 0x00000001836DAC20-0x00000001836DAD30
	// [XID] // 0x0000000189B49CD0-0x0000000189B49CF0
	private void AppearFromServer(EvtAppearFromServer evt) {} // 0x00000001836D87D0-0x00000001836D88A0
}

