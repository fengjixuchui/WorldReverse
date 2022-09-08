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

public sealed class EntityTickManager : InLevelManager // TypeDefIndex: 20727
{
	// Fields
	private Dictionary<int, TickMethodGroup> _tickIntervalToTickMethodGroupDict; // 0x10
	private Dictionary<int, TickMethodGroup> _lateTickIntervalToTickMethodGroupDict; // 0x18
	private Dictionary<BaseEntity, int> _entityActionCountDict; // 0x20
	private Action<BaseEntity, int, int> _onTickIntervalChanged; // 0x28
	public float TickTime; // 0x30

	// Constructors
	public EntityTickManager() {} // 0x00000001823FECA0-0x00000001823FED00

	// Methods
	// [XID] // 0x0000000189B14B50-0x0000000189B14B70
	public override void Init() {} // 0x00000001823FDB70-0x00000001823FDC80
	// [XID] // 0x0000000189B1C490-0x0000000189B1C4B0
	public override void Destroy() {} // 0x00000001823FD3E0-0x00000001823FD4C0
	// [XID] // 0x0000000189B239E0-0x0000000189B23A00
	public override void Tick() {} // 0x00000001823FE9D0-0x00000001823FECA0
	// [XID] // 0x0000000189B2AD00-0x0000000189B2AD20
	public override void LateTick() {} // 0x00000001823FE520-0x00000001823FE680
	// [XID] // 0x0000000189B0CC60-0x0000000189B0CC80
	public void AddTickMethod(BaseComponent component, Action<float> method) {} // 0x00000001823FE720-0x00000001823FE800
	// [XID] // 0x0000000189B39BD0-0x0000000189B39BF0
	public void RemoveTickMethod(BaseComponent component, Action<float> method) {} // 0x00000001823FD680-0x00000001823FD760
	// [XID] // 0x0000000189BC67A0-0x0000000189BC67C0
	public void AddLateTickMethod(BaseComponent component, Action<float> method) {} // 0x00000001823FD7C0-0x00000001823FD8A0
	// [XID] // 0x0000000189B48E40-0x0000000189B48E60
	public void RemoveLateTickMethod(BaseComponent component, Action<float> method) {} // 0x00000001823FE800-0x00000001823FE8E0
	// [XID] // 0x0000000189B504A0-0x0000000189B504C0
	public void OnTickIntervalChanged(BaseEntity entity, int oldLOD, int newLOD) {} // 0x00000001823FE8E0-0x00000001823FE9D0
	// [XID] // 0x0000000189B57D30-0x0000000189B57D50
	private void InitTickMethodGroup(ref Dictionary<int, TickMethodGroup> tickMethodGroup) {} // 0x00000001823FDAB0-0x00000001823FDB70
	// [XID] // 0x0000000189B5F700-0x0000000189B5F720
	private void TickTickMethodGroup(Dictionary<int, TickMethodGroup> tickMethodGroup) {} // 0x00000001823FD4C0-0x00000001823FD680
	// [XID] // 0x0000000189B66DE0-0x0000000189B66E00
	private void DestroyTickMethodGroup(ref Dictionary<int, TickMethodGroup> tickMethodGroup) {} // 0x00000001823FD8A0-0x00000001823FDAB0
	// [XID] // 0x0000000189B141F0-0x0000000189B14210
	private void AddToTickMethodGroup(ref Dictionary<int, TickMethodGroup> tickMethodGroup, BaseComponent component, Action<float> method) {} // 0x00000001823FE0D0-0x00000001823FE370
	// [XID] // 0x0000000189B75930-0x0000000189B75950
	private void RemoveFromTickMethodGroup(ref Dictionary<int, TickMethodGroup> tickMethodGroup, BaseComponent component, Action<float> method) {} // 0x00000001823FD160-0x00000001823FD380
	// [XID] // 0x0000000189B7CE10-0x0000000189B7CE30
	private void IntervalChangedToTickMethodGroup(ref Dictionary<int, TickMethodGroup> tickMethodGroup, BaseEntity entity) {} // 0x00000001823FDC80-0x00000001823FE0D0
	// [XID] // 0x0000000189B84C70-0x0000000189B84C90
	private bool IsLevelReady() => default; // 0x00000001823FE420-0x00000001823FE520
	// [XID] // 0x0000000189B8BA20-0x0000000189B8BA40
	private static TickMethodGroup AllocateTickMethodGroup() => default; // 0x00000001823FE680-0x00000001823FE720
	// [XID] // 0x0000000189B93210-0x0000000189B93230
	private static void DeallocateTickMethodGroup(ref TickMethodGroup tickMethod) {} // 0x00000001823FE370-0x00000001823FE420
}

