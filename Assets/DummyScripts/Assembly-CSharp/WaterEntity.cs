/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WaterEntity : ScenePropEntity, IAutoAllocRecycle // TypeDefIndex: 19886
{
	// Fields
	private long _waterId; // 0x588
	private MassiveEntityProxy _massiveEntityProxy; // 0x590

	// Properties
	public override bool isAuthority { /* [XID] */ /* 0x0000000189873EA0-0x0000000189873EC0 */ get => default; /* [XID] */ /* 0x000000018987B960-0x000000018987B980 */ set {} } // 0x0000000182CA7C90-0x0000000182CA7D70 0x0000000182CA8370-0x0000000182CA8430
	public override float balanceTickDeltaTime { /* [XID] */ /* 0x0000000189882AF0-0x0000000189882B10 */ get => default; } // 0x0000000182CA92A0-0x0000000182CA93A0 
	public long waterId { /* [XID] */ /* 0x000000018978CF00-0x000000018978CF20 */ get => default; } // 0x0000000182CA8250-0x0000000182CA8300 
	public override MassiveEntityProxy massiveEntityProxy { /* [XID] */ /* 0x00000001898ED100-0x00000001898ED120 */ get => default; } // 0x0000000182CA8B80-0x0000000182CA8C30 

	// Constructors
	public WaterEntity() {} // 0x0000000182CA9210-0x0000000182CA92A0

	// Methods
	// [XID] // 0x000000018988A230-0x000000018988A250
	private void InitLightweight(uint inRuntimeID, uint inConfigID = 0 /* Metadata: 0x00AFD008 */) {} // 0x0000000182CA8670-0x0000000182CA8870
	// [XID] // 0x00000001898916E0-0x0000000189891700
	public override void Init(uint runtimeID, uint configID = 0 /* Metadata: 0x00AFD00C */) {} // 0x0000000182CA8140-0x0000000182CA8250
	// [XID] // 0x0000000189899050-0x0000000189899070
	private void RemoveLightWeight() {} // 0x0000000182CA88D0-0x0000000182CA89C0
	// [XID] // 0x00000001898A01D0-0x00000001898A01F0
	public override void RealSetToBeRemoved() {} // 0x0000000182CA8CD0-0x0000000182CA8DB0
	// [XID] // 0x00000001898A79B0-0x00000001898A79D0
	protected override void AllocatedAbilityProxy() {} // 0x0000000182CA8DB0-0x0000000182CA8EB0
	// [XID] // 0x00000001898AF4B0-0x00000001898AF4D0
	protected override void DeallocatedAbilityProxy() {} // 0x0000000182CA8C30-0x0000000182CA8CD0
	// [XID] // 0x0000000189AA7A70-0x0000000189AA7A90
	public void SetWaterId(long scenePropId) {} // 0x0000000182CA85A0-0x0000000182CA8670
	// [XID] // 0x00000001898C5970-0x00000001898C5990
	public override long GetScenePropID() => default; // 0x0000000182CA84F0-0x0000000182CA85A0
	[BlackList] // 0x00000001898CD100-0x00000001898CD140
	// [XID] // 0x00000001898CD100-0x00000001898CD140
	public override void AutoAllocTypeFields() {} // 0x0000000182CA7E60-0x0000000182CA7F00
	[BlackList] // 0x00000001898D7B80-0x00000001898D7BC0
	// [XID] // 0x00000001898D7B80-0x00000001898D7BC0
	public override void AutoRecycleTypeFields() {} // 0x0000000182CA7F00-0x0000000182CA7FB0
	[BlackList] // 0x00000001898E2860-0x00000001898E28A0
	// [XID] // 0x00000001898E2860-0x00000001898E28A0
	public override void ReturnToObjectPool() {} // 0x0000000182CA9170-0x0000000182CA9210
	// [XID] // 0x00000001898F4900-0x00000001898F4920
	protected override void InitMassiveProxy() {} // 0x0000000182CA9050-0x0000000182CA9110
	// [XID] // 0x00000001898FC1B0-0x00000001898FC1D0
	protected override void DestroyMassiveProxy() {} // 0x0000000182CA8F30-0x0000000182CA8FE0
	// [XID] // 0x0000000189903C30-0x0000000189903C50
	protected override void SwitchScenePropId(long scenePropId) {} // 0x0000000182CA8A40-0x0000000182CA8B20
}

