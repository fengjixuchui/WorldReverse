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

public sealed class ShakeManager : InLevelManager // TypeDefIndex: 21006
{
	// Fields
	private int _curHandle; // 0x10
	private List<ShakeSource> _shakeSources; // 0x18
	private SimpleFixedBitStack _ignoreShake; // 0x20

	// Constructors
	public ShakeManager() {} // 0x00000001825DD6C0-0x00000001825DD790

	// Methods
	// [XID] // 0x0000000189BD31D0-0x0000000189BD31F0
	public override void Init() {} // 0x00000001825DD120-0x00000001825DD1C0
	// [XID] // 0x0000000189BDAAB0-0x0000000189BDAAD0
	public override void Tick() {} // 0x00000001825DD4E0-0x00000001825DD6C0
	// [XID] // 0x00000001895E7490-0x00000001895E74B0
	public void TickByTask(float deltaTime) {} // 0x00000001825DD1C0-0x00000001825DD310
	// [XID] // 0x00000001895EED40-0x00000001895EED60
	public override void Destroy() {} // 0x00000001825DC630-0x00000001825DC700
	// [IDTag] // 0x00000001895F6700-0x00000001895F6740
	// [XID] // 0x00000001895F6700-0x00000001895F6740
	public int AddShake(CameraShakeType shakeType, Vector3 center, Vector3 dir, float value, float actTime, float effRange, float baseCycle = 0.12f /* Metadata: 0x00AFEC60 */, bool infinite = false /* Metadata: 0x00AFEC64 */, float cycleDamping = 0.12f /* Metadata: 0x00AFEC65 */, float rangeAttenuation = 0.5f /* Metadata: 0x00AFEC69 */, bool baseOnCamera = false /* Metadata: 0x00AFEC6D */, bool afterShake = true /* Metadata: 0x00AFEC6E */) => default; // 0x00000001825DCA20-0x00000001825DCC80
	// [IDTag] // 0x0000000189600DE0-0x0000000189600E20
	// [XID] // 0x0000000189600DE0-0x0000000189600E20
	public int AddShake(CameraShakeType shakeType, Vector3 center, Vector3 dir, float value, float actTime, float effRange, ConfigCameraShakeExt extension) => default; // 0x00000001825DC700-0x00000001825DCA20
	// [XID] // 0x000000018960B7D0-0x000000018960B7F0
	public int AddCurveShake(AnimationClip curve, CameraShakeType shakeType, Vector3 center, Vector3 dir, float effRange, bool baseOnCamera) => default; // 0x00000001825DC3A0-0x00000001825DC580
	// [XID] // 0x0000000189612C60-0x0000000189612C80
	public ShakeSource GetShake(int handle) => default; // 0x00000001825DD310-0x00000001825DD4E0
	// [XID] // 0x000000018961A500-0x000000018961A520
	public int GetNextHadle() => default; // 0x00000001825DC580-0x00000001825DC630
	// [XID] // 0x0000000189621AA0-0x0000000189621AC0
	public void StopShake(int handle) {} // 0x00000001825DCE80-0x00000001825DD040
	// [XID] // 0x00000001896293D0-0x00000001896293F0
	public void IgnoreShake(bool isIgnore, int reason) {} // 0x00000001825DD040-0x00000001825DD120
	// [XID] // 0x0000000189630D00-0x0000000189630D20
	public void RefreshShakeData(ref float? shakeEnergy, ref Vector3 shakeOffset, Vector3 cameraPosition, Vector3 cameraForward, Vector3 cameraUp) {} // 0x00000001825DBAE0-0x00000001825DC3A0
	// [XID] // 0x0000000189638760-0x0000000189638780
	private float? GetMaxFloatValue(float? f1, float? f2) => default; // 0x00000001825DCC80-0x00000001825DCE20
}

