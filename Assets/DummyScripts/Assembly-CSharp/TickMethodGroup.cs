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

public class TickMethodGroup // TypeDefIndex: 20726
{
	// Fields
	private int _frameInterval; // 0x10
	private HashList<TickMethod> _tickMethods; // 0x18
	private Dictionary<BaseComponent, TickMethod> _componentTickMethodDict; // 0x20
	private int _nextTickRoundStartFrame; // 0x28
	private int _leftTickNodeCount; // 0x2C
	private DoublyList<TickMethod> _nextTickNode; // 0x30

	// Constructors
	public TickMethodGroup() {} // 0x0000000182CBDA30-0x0000000182CBDA90

	// Methods
	// [XID] // 0x0000000189AA3CA0-0x0000000189AA3CC0
	public void Init(int frameInterval) {} // 0x0000000182CBCB80-0x0000000182CBCC70
	// [XID] // 0x0000000189AAB230-0x0000000189AAB250
	public void Tick() {} // 0x0000000182CBCC70-0x0000000182CBCEB0
	// [XID] // 0x0000000189B5ED70-0x0000000189B5ED90
	private void RegisterNewlyAddedTickMethod(BaseComponent component, TickMethod tickMethod) {} // 0x0000000182CBC7F0-0x0000000182CBC930
	// [XID] // 0x0000000189ABA7E0-0x0000000189ABA800
	private void UnregisterNewlyRemovedTickMethod(BaseComponent component) {} // 0x0000000182CBCEB0-0x0000000182CBCFD0
	// [XID] // 0x0000000189AC20B0-0x0000000189AC20D0
	public void Destroy() {} // 0x0000000182CBC9E0-0x0000000182CBCB80
	// [XID] // 0x0000000189AC96E0-0x0000000189AC9700
	public void AddMethod(BaseComponent component, Action<float> method) {} // 0x0000000182CBCFD0-0x0000000182CBD140
	// [XID] // 0x0000000189616A70-0x0000000189616A90
	public void RemoveMethod(BaseComponent component, Action<float> method) {} // 0x0000000182CBD140-0x0000000182CBD330
	// [XID] // 0x0000000189AD8E50-0x0000000189AD8E70
	public void AddTickMethod(BaseComponent component, TickMethod method) {} // 0x0000000182CBD540-0x0000000182CBD670
	// [XID] // 0x0000000189AE0960-0x0000000189AE0980
	public void GetAndClearTickMethods(BaseEntity entity, ref Dictionary<BaseComponent, TickMethod> componentTickMethodDict) {} // 0x0000000182CBD670-0x0000000182CBD8E0
	// [XID] // 0x0000000189AE7E30-0x0000000189AE7E50
	private static TickMethod AllocateTickMethod() => default; // 0x0000000182CBD990-0x0000000182CBDA30
	// [XID] // 0x000000018963ACF0-0x000000018963AD10
	private static void DeallocateTickMethod(ref TickMethod tickMethod) {} // 0x0000000182CBD8E0-0x0000000182CBD990
	// [XID] // 0x0000000189AF7060-0x0000000189AF7080
	private static Dictionary<BaseComponent, TickMethod> AllocateComponentTickMethodDict() => default; // 0x0000000182CBD330-0x0000000182CBD3D0
	// [XID] // 0x0000000189AFE6D0-0x0000000189AFE6F0
	private static void DeallocateComponentTickMethodDict(ref Dictionary<BaseComponent, TickMethod> componentTickMethodDict) {} // 0x0000000182CBC930-0x0000000182CBC9E0
	// [XID] // 0x0000000189B05F20-0x0000000189B05F40
	private static HashList<TickMethod> AllocateTickMethodHashList() => default; // 0x0000000182CBD4A0-0x0000000182CBD540
	// [XID] // 0x0000000189B0D630-0x0000000189B0D650
	private static void DeallocateTickMethodHashList(ref HashList<TickMethod> tickMethodHashList) {} // 0x0000000182CBD3D0-0x0000000182CBD4A0
}

