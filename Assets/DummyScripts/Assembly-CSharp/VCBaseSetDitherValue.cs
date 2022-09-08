/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class VCBaseSetDitherValue : VCBase // TypeDefIndex: 11828
{
	// Fields
	private static readonly int DitherPropID; // 0x00
	private static readonly int UsingDitherPropID; // 0x04
	private static readonly int TextureBiasPropID; // 0x08
	private bool _usingDitherAlpha; // 0x108
	private float _ditherAlphaValue; // 0x10C
	private float _managerDitherAlphaValue; // 0x110
	private float _localDitherAlphaValue; // 0x114
	private VCBaseModel _modelComponent; // 0x118
	private float _showStartDitherDuration; // 0x120
	private bool _needStartDitherAction; // 0x124
	private float _detectDitherRangeBetweenCameraAndAvatar; // 0x128
	private float _detectDitherRangeNormalBetweenCamera; // 0x12C
	private float _detectDitherRangeNormalBetweenCameraInTimeLine; // 0x130
	protected List<BaseDither> _dithers; // 0x138
	protected bool _isDitherChangeStarted; // 0x140
	protected float _spd; // 0x144
	protected float _fromValue; // 0x148
	protected float _toValue; // 0x14C
	protected Action _changeFinishHandler; // 0x150
	private bool _triggerUpdateDitherShow; // 0x158
	private bool _prevUsingDitherAlpha; // 0x159
	private float _prevDitherAlphaValue; // 0x15C
	private static readonly float INITIAL_TEXTURE_BIAS; // 0x0C
	private static readonly float DITHER_TEXTURE_BIAS; // 0x10
	private float _prevTextureBias; // 0x160
	private static readonly float MOTION_VECTOR_THRESHOLD; // 0x14
	private bool _prevInMotionVectorMode; // 0x164
	private bool _isVisible; // 0x165

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189786EA0-0x0000000189786EC0 */ get => default; } // 0x0000000181356340-0x00000001813563E0 
	public bool UsingDitherAlpha { /* [XID] */ /* 0x000000018978E520-0x000000018978E540 */ get => default; /* [XID] */ /* 0x00000001896E3200-0x00000001896E3220 */ set {} } // 0x00000001813552F0-0x00000001813553A0 0x0000000181353D50-0x0000000181353E20
	public float DitherAlphaValue { /* [XID] */ /* 0x000000018979DF10-0x000000018979DF30 */ get => default; /* [XID] */ /* 0x00000001898DB710-0x00000001898DB730 */ set {} } // 0x0000000181353C40-0x0000000181353CF0 0x0000000181355740-0x0000000181355820
	public float ManagerDitherAlphaValue { /* [XID] */ /* 0x00000001897ACA80-0x00000001897ACAA0 */ get => default; /* [XID] */ /* 0x00000001897B47E0-0x00000001897B4800 */ set {} } // 0x0000000181353380-0x0000000181353430 0x00000001813540D0-0x0000000181354190
	private float LocalDitherAlphaValue { /* [XID] */ /* 0x0000000189706960-0x0000000189706980 */ get => default; /* [XID] */ /* 0x00000001897C3BF0-0x00000001897C3C10 */ set {} } // 0x0000000181353270-0x0000000181353320 0x00000001813534A0-0x0000000181353560
	public bool isDitherChangeStarted { /* [XID] */ /* 0x00000001897BC890-0x00000001897BC8B0 */ get => default; } // 0x0000000181353710-0x00000001813537C0 

	// Constructors
	public VCBaseSetDitherValue() {} // 0x0000000181356270-0x0000000181356340
	static VCBaseSetDitherValue() {} // 0x0000000181356190-0x0000000181356270

	// Methods
	// [XID] // 0x00000001897CB520-0x00000001897CB540
	private void UpdateSelfDitherValue() {} // 0x00000001813545F0-0x0000000181354710
	// [XID] // 0x00000001897D2C40-0x00000001897D2C60
	protected virtual void InitDithers() {} // 0x0000000181354D50-0x0000000181354E00
	// [XID] // 0x00000001897DA9A0-0x00000001897DA9C0
	protected virtual void UpdateDithers(float inDeltaTime) {} // 0x0000000181353A20-0x0000000181353C40
	// [XID] // 0x00000001897E1D80-0x00000001897E1DA0
	protected virtual void DestroyDithers() {} // 0x0000000181355820-0x00000001813559A0
	// [XID] // 0x00000001897E9550-0x00000001897E9570
	protected void TryAddDitherByStartDitherAction() {} // 0x0000000181355B80-0x0000000181355CC0
	// [XID] // 0x00000001897F1160-0x00000001897F1180
	protected void TryAddDitherBetweenCameraAndAvatar() {} // 0x0000000181354190-0x00000001813542A0
	// [XID] // 0x00000001897F8A00-0x00000001897F8A20
	protected void TryAddDitherByNormalBetweenCamera(bool useHitBox) {} // 0x0000000181354E00-0x0000000181354F30
	// [XID] // 0x00000001897708F0-0x0000000189770910
	protected void TryAddDitherByNormalBetweenCameraInTimeline(bool useHitBox) {} // 0x00000001813559A0-0x0000000181355AD0
	// [XID] // 0x0000000189807780-0x00000001898077A0
	public void StartDither(float duration, bool reserve) {} // 0x00000001813555D0-0x0000000181355740
	// [XID] // 0x000000018980EE00-0x000000018980EE20
	public uint StartAbilityDither(float tarDitherValue, float cutInTime = 0f /* Metadata: 0x00AEACAC */) => default; // 0x0000000181355410-0x00000001813555D0
	// [XID] // 0x00000001897A55B0-0x00000001897A55D0
	public void StopAbilityDither(uint uniqId, float cutOutTime = 0f /* Metadata: 0x00AEACB0 */) {} // 0x0000000181354F30-0x00000001813550A0
	// [XID] // 0x00000001897C3CF0-0x00000001897C3D10
	protected void CallChangeFinishHandler() {} // 0x0000000181354870-0x0000000181354930
	// [XID] // 0x0000000189795DA0-0x0000000189795DC0
	protected void SetDitherVisible(bool visible, bool force = false /* Metadata: 0x00AEACB4 */) {} // 0x0000000181353EA0-0x0000000181353F90
	// [XID] // 0x00000001897CB5C0-0x00000001897CB5E0
	public override void PreInit() {} // 0x0000000181355CC0-0x0000000181355FF0
	// [XID] // 0x000000018983B6F0-0x000000018983B710
	public override void Init() {} // 0x0000000181354520-0x00000001813545F0
	// [XID] // 0x00000001898430B0-0x00000001898430D0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000181355FF0-0x00000001813560C0
	// [XID] // 0x000000018984A310-0x000000018984A330
	public void StartChangeTask(float duration, float fromValue, float toValue, bool isFromCurrentValue, Action changeFinishHandler = null, bool clearHandler = false /* Metadata: 0x00AEACB5 */) {} // 0x00000001813542A0-0x0000000181354470
	// [XID] // 0x00000001897E9690-0x00000001897E96B0
	public void StopChangeTask(float toValue) {} // 0x0000000181353560-0x0000000181353640
	// [XID] // 0x0000000189858FF0-0x0000000189859010
	public void ClearHandler(Action callBack) {} // 0x0000000181355190-0x0000000181355280
	// [XID] // 0x00000001897F8A60-0x00000001897F8A80
	protected void TickChange(float inDeltaTime) {} // 0x00000001813537C0-0x00000001813538E0
	// [XID] // 0x00000001898678B0-0x00000001898678D0
	protected override void Tick(float inDeltaTime) {} // 0x00000001813560C0-0x0000000181356190
	// [XID] // 0x000000018986EFC0-0x000000018986EFE0
	protected override void LateTick(float inDeltaTime) {} // 0x00000001813550A0-0x0000000181355190
	// [XID] // 0x00000001898E3380-0x00000001898E33A0
	public void ImmdiatelyUpdateDitherShow() {} // 0x0000000181354710-0x00000001813547B0
	// [XID] // 0x000000018987E0B0-0x000000018987E0D0
	public void ForceUpdateDitherShow(float deltaTime) {} // 0x0000000181354000-0x00000001813540D0
	// [XID] // 0x0000000189885100-0x0000000189885120
	protected void UpdateDitherShow() {} // 0x0000000181354470-0x0000000181354520
	// [XID] // 0x00000001898F2700-0x00000001898F2720
	protected void UpdateDitherShowInternal() {} // 0x0000000181354930-0x0000000181354D50
	// [XID] // 0x0000000189893C30-0x0000000189893C50
	public override void OnDisable() {} // 0x0000000181355AD0-0x0000000181355B80
	// [XID] // 0x0000000189823C20-0x0000000189823C40
	public override void Destroy() {} // 0x0000000181353960-0x0000000181353A20
	// [XID] // 0x00000001898821C0-0x00000001898821E0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181353640-0x0000000181353710
}

