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

public class BtnTransmitSubTask : IBtnTransmitData, IComparable<BtnTransmitSubTask> // TypeDefIndex: 21142
{
	// Fields
	private int _id; // 0x10
	private uint _sceneId; // 0x14
	private Vector3 _dummyPos; // 0x18
	private Vector3 _dummyEuler; // 0x24
	private uint _questId; // 0x30
	private uint _pointId; // 0x34
	private int _priority; // 0x38
	private float _range; // 0x3C
	private float _innerTickRange; // 0x40
	private float _outterTickRange; // 0x44
	private PlayerModule _playerModule; // 0x48
	private EntityManager _entityMgr; // 0x50
	private NotifyManager _notifyMgr; // 0x58
	private Notify _appearNotify; // 0x60
	private Notify _disappearNotify; // 0x78
	private float _checkPoint; // 0x90
	private float _checkGap; // 0x94

	// Properties
	public int id { /* [XID] */ /* 0x0000000189885DE0-0x0000000189885E00 */ get => default; } // 0x0000000184D3F0F0-0x0000000184D3F190 
	public int btnTransId { /* [XID] */ /* 0x000000018988D120-0x000000018988D140 */ get => default; } // 0x0000000184D3F3D0-0x0000000184D3F470 
	public uint sceneId { /* [XID] */ /* 0x0000000189894730-0x0000000189894750 */ get => default; } // 0x0000000184D3EB30-0x0000000184D3EBD0 
	public uint btnTransSceneId { /* [XID] */ /* 0x000000018989BD60-0x000000018989BD80 */ get => default; } // 0x0000000184D3F700-0x0000000184D3F7A0 
	public Vector3 dummyPos { /* [XID] */ /* 0x00000001898A3240-0x00000001898A3260 */ get => default; } // 0x0000000184D3F010-0x0000000184D3F0F0 
	public Vector3 btnTransDummyPos { /* [XID] */ /* 0x00000001898AA640-0x00000001898AA660 */ get => default; } // 0x0000000184D3F2F0-0x0000000184D3F3D0 
	public Vector3 dummyEuler { /* [XID] */ /* 0x00000001898B20F0-0x00000001898B2110 */ get => default; } // 0x0000000184D3E970-0x0000000184D3EA50 
	public Vector3 btnTransDummyEuler { /* [XID] */ /* 0x00000001898B9E20-0x00000001898B9E40 */ get => default; } // 0x0000000184D3F210-0x0000000184D3F2F0 
	public uint btnTransQuestId { /* [XID] */ /* 0x00000001898C1180-0x00000001898C11A0 */ get => default; } // 0x0000000184D3F5B0-0x0000000184D3F650 
	public uint btnTransPointId { /* [XID] */ /* 0x00000001898C8A60-0x00000001898C8A80 */ get => default; } // 0x0000000184D3F470-0x0000000184D3F510 
	public int priority { /* [XID] */ /* 0x00000001898D0460-0x00000001898D0480 */ get => default; } // 0x0000000184D3EBD0-0x0000000184D3EC70 
	public int btnTransPriority { /* [XID] */ /* 0x00000001898D7A60-0x00000001898D7A80 */ get => default; } // 0x0000000184D3F510-0x0000000184D3F5B0 
	public float btnTransRange { /* [XID] */ /* 0x00000001898DF6F0-0x00000001898DF710 */ get => default; } // 0x0000000184D3F650-0x0000000184D3F700 

	// Constructors
	public BtnTransmitSubTask() {} // 0x0000000184D3F190-0x0000000184D3F210

	// Methods
	// [XID] // 0x00000001898E7190-0x00000001898E71B0
	public int CompareTo(BtnTransmitSubTask task) => default; // 0x0000000184D3E640-0x0000000184D3E730
	// [XID] // 0x00000001898EE960-0x00000001898EE980
	public void InitWithData(IBtnTransmitData data) {} // 0x0000000184D3EC70-0x0000000184D3F010
	// [XID] // 0x00000001898F6160-0x00000001898F6180
	public void Tick() {} // 0x0000000184D3E730-0x0000000184D3E970
	// [XID] // 0x00000001898FD9A0-0x00000001898FD9C0
	public void ForceDisappear() {} // 0x0000000184D3EA50-0x0000000184D3EB30
	// [XID] // 0x0000000189905200-0x0000000189905220
	public void Destroy() {} // 0x0000000184D3E590-0x0000000184D3E640
}

