/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[fiInspectorOnly] // 0x0000000189A06FC0-0x0000000189A07000
[RecycleType] // 0x0000000189A06FC0-0x0000000189A07000
public class SECTR_LayerTree : IAutoAllocRecycle // TypeDefIndex: 20268
{
	// Fields
	public long id; // 0x10
	public Bounds bounds; // 0x18
	public Bounds loadBounds; // 0x30
	[InspectorCollapsedFoldout] // 0x0000000189A394D0-0x0000000189A39530
	[InspectorCollectionShowItemDropdown] // 0x0000000189A394D0-0x0000000189A39530
	// [PooledField] // 0x0000000189A394D0-0x0000000189A39530
	[ShowInInspector] // 0x0000000189A394D0-0x0000000189A39530
	public List<SECTR_BaseLayerProxy> values; // 0x48
	[InspectorCollapsedFoldout] // 0x0000000189A49A00-0x0000000189A49A60
	[InspectorCollectionShowItemDropdown] // 0x0000000189A49A00-0x0000000189A49A60
	// [PooledField] // 0x0000000189A49A00-0x0000000189A49A60
	[ShowInInspector] // 0x0000000189A49A00-0x0000000189A49A60
	public List<SECTR_LayerTree> children; // 0x50
	[InspectorCollapsedFoldout] // 0x0000000189B32380-0x0000000189B323C0
	[InspectorCollectionShowItemDropdown] // 0x0000000189B32380-0x0000000189B323C0
	[ShowInInspector] // 0x0000000189B32380-0x0000000189B323C0
	public SECTR_LayerTree parentNode; // 0x58

	// Constructors
	public SECTR_LayerTree() {} // 0x00000001843841B0-0x0000000184384220

	// Methods
	[BlackList] // 0x0000000189A68050-0x0000000189A68090
	// [XID] // 0x0000000189A68050-0x0000000189A68090
	public virtual void AutoAllocTypeFields() {} // 0x0000000184383A20-0x0000000184383B00
	[BlackList] // 0x0000000189A72660-0x0000000189A726A0
	// [XID] // 0x0000000189A72660-0x0000000189A726A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184383B00-0x0000000184383C10
	[BlackList] // 0x0000000189A7CF70-0x0000000189A7CFB0
	// [XID] // 0x0000000189A7CF70-0x0000000189A7CFB0
	public virtual void ReturnToObjectPool() {} // 0x0000000184384110-0x00000001843841B0
	// [XID] // 0x0000000189A878E0-0x0000000189A87900
	public virtual void OnPoolAllocated() {} // 0x0000000184384070-0x0000000184384110
	// [XID] // 0x0000000189A8F150-0x0000000189A8F170
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184383FD0-0x0000000184384070
	// [XID] // 0x0000000189A96640-0x0000000189A96660
	public void Clear() {} // 0x0000000184383CE0-0x0000000184383E40
	// [XID] // 0x0000000189A9DBB0-0x0000000189A9DBD0
	public void RemoveValue(SECTR_BaseLayerProxy layer) {} // 0x0000000184383C10-0x0000000184383CE0
	// [XID] // 0x0000000189AA5540-0x0000000189AA5560
	public void RemoveChild(SECTR_LayerTree child) {} // 0x0000000184383950-0x0000000184383A20
	// [XID] // 0x0000000189AACD60-0x0000000189AACD80
	public void CheckNode() {} // 0x0000000184383E40-0x0000000184383FD0
}

