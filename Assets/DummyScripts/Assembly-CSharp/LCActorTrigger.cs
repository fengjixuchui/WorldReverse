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

public sealed class LCActorTrigger : LCActorBase // TypeDefIndex: 11685
{
	// Fields
	private EntityTimer _timer; // 0x148
	public float checkCD; // 0x168
	private float _nextCheckTime; // 0x16C
	private float _distance; // 0x170
	private DistType _distType; // 0x174
	private Vector3 _avatarOffset; // 0x178
	private bool _isTriggering; // 0x184

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B70A80-0x0000000189B70AA0 */ get => default; } // 0x0000000184EA8EA0-0x0000000184EA8F40 
	public EntityTimer Timer { /* [XID] */ /* 0x0000000189B77FD0-0x0000000189B77FF0 */ get => default; /* [XID] */ /* 0x0000000189837290-0x00000001898372B0 */ set {} } // 0x0000000184EA8520-0x0000000184EA85D0 0x0000000184EA7740-0x0000000184EA77F0

	// Events
	private event Action<ILuaActor> _onTriggerIn;
	private event Action<ILuaActor> _onTriggerOut;
	private event Action<ILuaActor> _onTriggerTick;

	// Constructors
	public LCActorTrigger() {} // 0x0000000184EA8DC0-0x0000000184EA8EA0

	// Methods
	// [XID] // 0x0000000189B95840-0x0000000189B95860
	public void CallOnTriggerIn() {} // 0x0000000184EA8870-0x0000000184EA8930
	// [XID] // 0x0000000189863540-0x0000000189863560
	public void CallOnTriggerOut() {} // 0x0000000184EA7D70-0x0000000184EA7E30
	// [XID] // 0x0000000189879660-0x0000000189879680
	public void CallOnTriggerTick() {} // 0x0000000184EA8340-0x0000000184EA8400
	// [XID] // 0x0000000189880D10-0x0000000189880D30
	public void InitTrigger(float distance, DistType distType, Vector3 avatarOffset, Action<ILuaActor> funcTriggerIn, Action<ILuaActor> funcTriggerOut, Action<ILuaActor> funcTriggerTick) {} // 0x0000000184EA7180-0x0000000184EA7300
	// [XID] // 0x0000000189BD1230-0x0000000189BD1250
	public void AddTriggerIn(Action<ILuaActor> funcTriggerIn) {} // 0x0000000184EA85D0-0x0000000184EA8690
	// [XID] // 0x0000000189BD8930-0x0000000189BD8950
	public void AddTriggerOut(Action<ILuaActor> funcTriggerOut) {} // 0x0000000184EA7480-0x0000000184EA7540
	// [XID] // 0x0000000189896B60-0x0000000189896B80
	public void AddTriggerTick(Action<ILuaActor> funcTriggerTick) {} // 0x0000000184EA8220-0x0000000184EA82E0
	// [XID] // 0x000000018989DF70-0x000000018989DF90
	public override void Init() {} // 0x0000000184EA8060-0x0000000184EA8220
	// [XID] // 0x00000001898A5950-0x00000001898A5970
	public override void Destroy() {} // 0x0000000184EA7660-0x0000000184EA7740
	// [XID] // 0x0000000189655BA0-0x0000000189655BC0
	protected override void Tick(float inDeltaTime) {} // 0x0000000184EA8BE0-0x0000000184EA8DC0
	// [XID] // 0x00000001898B43F0-0x00000001898B4410
	private void UpdateCheck() {} // 0x0000000184EA77F0-0x0000000184EA78B0
	// [XID] // 0x000000018968A860-0x000000018968A880
	private void CheckTriggerIn() {} // 0x0000000184EA7BE0-0x0000000184EA7CF0
	// [XID] // 0x00000001898C3590-0x00000001898C35B0
	private void CheckTriggerOut() {} // 0x0000000184EA78B0-0x0000000184EA79C0
	// [XID] // 0x00000001896926A0-0x00000001896926C0
	private bool IsInDist(BaseEntity a, BaseEntity b) => default; // 0x0000000184EA79C0-0x0000000184EA7AC0
	// [XID] // 0x00000001898D2610-0x00000001898D2630
	private bool IsInDistance(BaseEntity a, BaseEntity b) => default; // 0x0000000184EA8690-0x0000000184EA8870
	// [XID] // 0x00000001898D9F50-0x00000001898D9F70
	private bool IsInXZDistance(BaseEntity a, BaseEntity b) => default; // 0x0000000184EA7E30-0x0000000184EA8060
}

