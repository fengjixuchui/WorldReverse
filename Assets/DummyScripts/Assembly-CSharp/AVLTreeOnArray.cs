/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class AVLTreeOnArray // TypeDefIndex: 11038
{
	// Fields
	protected const int INVALID_INDEX = 0; // Metadata: 0x00AE8B38
	private int _rootIndex; // 0x10
	private int _nextAvailableIndex; // 0x14

	// Properties
	public virtual int count { /* [XID] */ /* 0x0000000189A04CA0-0x0000000189A04CC0 */ get; } // 0x000000018247ED60-0x000000018247EE00 
	protected virtual int rootIndex { /* [XID] */ /* 0x0000000189A0C310-0x0000000189A0C330 */ get; /* [XID] */ /* 0x0000000189A13CB0-0x0000000189A13CD0 */ set; } // 0x000000018247CB60-0x000000018247CC00 0x000000018247CC00-0x000000018247CCB0

	// Constructors
	protected AVLTreeOnArray() {} // 0x000000018247F160-0x000000018247F1D0

	// Methods
	// [XID] // 0x00000001898E66A0-0x00000001898E66C0
	public virtual void Clear() {} // 0x000000018247D940-0x000000018247DA20
	protected abstract void Clear(int index);
	protected abstract int GetNodeArrayLength();
	protected abstract int ReadParent(int index);
	protected abstract int ReadDepth(int index);
	protected abstract int ReadLeftChild(int index);
	protected abstract int ReadRightChild(int index);
	protected abstract void WriteParent(int index, int parent);
	protected abstract void WriteDepth(int index, int depth);
	protected abstract void WriteLeftChild(int index, int leftChild);
	protected abstract void WriteRightChild(int index, int rightChild);
	protected abstract void Expand(int targetCapacity);
	protected abstract void SwapValues(int a, int b);
	protected abstract void Move(int from, int to);
	// [XID] // 0x0000000189A22840-0x0000000189A22860
	protected virtual bool RemoveIndex(int index) => default; // 0x000000018247DD20-0x000000018247E290
	// [XID] // 0x0000000189904980-0x00000001899049A0
	protected virtual void Rebalance(int index) {} // 0x000000018247EF40-0x000000018247F160
	// [XID] // 0x0000000189A30F80-0x0000000189A30FA0
	protected virtual void RotateLeft(int index) {} // 0x000000018247D180-0x000000018247D3B0
	// [XID] // 0x0000000189A38C10-0x0000000189A38C30
	protected virtual void RotateRight(int index) {} // 0x000000018247D710-0x000000018247D940
	// [XID] // 0x0000000189A40200-0x0000000189A40220
	protected virtual void RotateRightThenLeft(int index) {} // 0x000000018247E4F0-0x000000018247E7D0
	// [XID] // 0x0000000189A47820-0x0000000189A47840
	protected virtual void RotateLeftThenRight(int index) {} // 0x000000018247C880-0x000000018247CB60
	// [XID] // 0x000000018983EAD0-0x000000018983EAF0
	protected virtual void RelocateRoot() {} // 0x000000018247E950-0x000000018247EA90
	// [XID] // 0x0000000189811F10-0x0000000189811F30
	protected int FindMinimum(int index) => default; // 0x000000018247D3B0-0x000000018247D4C0
	// [XID] // 0x0000000189A5E270-0x0000000189A5E290
	protected int FindMaximum(int index) => default; // 0x000000018247CDF0-0x000000018247CF00
	// [XID] // 0x0000000189A65AA0-0x0000000189A65AC0
	protected virtual int Allocate() => default; // 0x000000018247DB40-0x000000018247DC50
	// [XID] // 0x0000000189A6D130-0x0000000189A6D150
	protected virtual void Deallocate(int index) {} // 0x000000018247CF00-0x000000018247D180
	// [XID] // 0x0000000189A748A0-0x0000000189A748C0
	protected virtual void SwapForLast(ref int index, int with) {} // 0x000000018247DC50-0x000000018247DD20
	// [XID] // 0x0000000189A7C360-0x0000000189A7C380
	protected virtual bool IsValidIndex(int index) => default; // 0x000000018247D4C0-0x000000018247D590
	// [XID] // 0x00000001897DABD0-0x00000001897DABF0
	protected virtual bool IsLeftChild(int index) => default; // 0x000000018247E3C0-0x000000018247E4F0
	// [XID] // 0x0000000189821440-0x0000000189821460
	protected virtual bool IsRightChild(int index) => default; // 0x000000018247E290-0x000000018247E3C0
	// [XID] // 0x0000000189A92D20-0x0000000189A92D40
	protected virtual void UpdateDepth(int index) {} // 0x000000018247EBB0-0x000000018247ED60
	// [XID] // 0x0000000189A9A7A0-0x0000000189A9A7C0
	protected virtual void SetLeftChild(int index, int child) {} // 0x000000018247DA20-0x000000018247DB40
	// [XID] // 0x00000001897D5F30-0x00000001897D5F50
	protected virtual void SetRigthChild(int index, int child) {} // 0x000000018247EA90-0x000000018247EBB0
	// [XID] // 0x0000000189AA8E90-0x0000000189AA8EB0
	protected virtual void ReleaseLeftChild(int index) {} // 0x000000018247EE00-0x000000018247EF40
	// [XID] // 0x00000001897B7BB0-0x00000001897B7BD0
	protected virtual void ReleaseRightChild(int index) {} // 0x000000018247CCB0-0x000000018247CDF0
	// [XID] // 0x0000000189AB80C0-0x0000000189AB80E0
	protected virtual void DetachFromParent(int index) {} // 0x000000018247D590-0x000000018247D710
	// [XID] // 0x00000001898FD000-0x00000001898FD020
	protected virtual int CalcBalanceFactor(int index) => default; // 0x000000018247E7D0-0x000000018247E950
}

