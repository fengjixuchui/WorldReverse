/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BagItemSlot : IReusable // TypeDefIndex: 20671
{
	// Fields
	public int typeIndex; // 0x10
	private BagItem _item; // 0x18

	// Properties
	public BagItem item { /* [XID] */ /* 0x0000000189ABC2E0-0x0000000189ABC300 */ get => default; } // 0x0000000183563A20-0x0000000183563AC0 

	// Constructors
	public BagItemSlot() {} // 0x0000000183563DA0-0x0000000183563E10

	// Methods
	// [IDTag] // 0x0000000189AA6D20-0x0000000189AA6D60
	// [XID] // 0x0000000189AA6D20-0x0000000189AA6D60
	public static BagItemSlot Create(int idx, ItemParam itemParam) => default; // 0x0000000183563BA0-0x0000000183563CF0
	// [IDTag] // 0x0000000189AB1700-0x0000000189AB1740
	// [XID] // 0x0000000189AB1700-0x0000000189AB1740
	public static BagItemSlot Create(int typeIndex, Item item) => default; // 0x0000000183563AC0-0x0000000183563BA0
	// [IDTag] // 0x0000000189AC3B80-0x0000000189AC3BC0
	// [XID] // 0x0000000189AC3B80-0x0000000189AC3BC0
	public void Refresh(ItemParam itemParam) {} // 0x0000000183563790-0x00000001835638C0
	// [IDTag] // 0x0000000189ACE1B0-0x0000000189ACE1F0
	// [XID] // 0x0000000189ACE1B0-0x0000000189ACE1F0
	public void Refresh(Item item) {} // 0x00000001835636D0-0x0000000183563790
	// [XID] // 0x0000000189AD8ED0-0x0000000189AD8EF0
	public void Destroy() {} // 0x0000000183563970-0x0000000183563A20
	// [XID] // 0x0000000189AE09A0-0x0000000189AE09C0
	public void BeforeRecycle() {} // 0x00000001835638C0-0x0000000183563970
	// [XID] // 0x00000001899B71D0-0x00000001899B71F0
	private void ClearItem() {} // 0x0000000183563CF0-0x0000000183563DA0
}

