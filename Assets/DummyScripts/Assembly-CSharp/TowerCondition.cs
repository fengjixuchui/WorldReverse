/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class TowerCondition : IAutoAllocRecycle // TypeDefIndex: 16196
{
	// Fields
	protected TowerCondType _towerCondType; // 0x10
	protected SimpleSafeUInt32[] _argumentList; // 0x18

	// Properties
	public TowerCondType towerCondType { /* [XID] */ /* 0x0000000189B1DE90-0x0000000189B1DEB0 */ get => default; /* [XID] */ /* 0x0000000189B25780-0x0000000189B257A0 */ protected set {} } // 0x0000000183EAC880-0x0000000183EAC920 0x0000000183EACC90-0x0000000183EACD40
	public SimpleSafeUInt32[] argumentList { /* [XID] */ /* 0x0000000189B2CC10-0x0000000189B2CC30 */ get => default; /* [XID] */ /* 0x0000000189B34100-0x0000000189B34120 */ protected set {} } // 0x0000000183EACE80-0x0000000183EACF20 0x0000000183EAC3D0-0x0000000183EAC480

	// Constructors
	public TowerCondition() {} // 0x0000000183EACFC0-0x0000000183EAD020

	// Methods
	// [XID] // 0x0000000189B3BA30-0x0000000189B3BA50
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183EAC480-0x0000000183EAC880
	// [XID] // 0x0000000189B43470-0x0000000189B43490
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF33E3 */, bool useObjectPool = false /* Metadata: 0x00AF33E7 */) => default; // 0x0000000183EAC920-0x0000000183EACC90
	[BlackList] // 0x0000000189B4AC10-0x0000000189B4AC50
	// [XID] // 0x0000000189B4AC10-0x0000000189B4AC50
	public virtual void AutoAllocTypeFields() {} // 0x0000000183EAC290-0x0000000183EAC330
	[BlackList] // 0x0000000189B55390-0x0000000189B553D0
	// [XID] // 0x0000000189B55390-0x0000000189B553D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183EAC330-0x0000000183EAC3D0
	[BlackList] // 0x0000000189B5FF20-0x0000000189B5FF60
	// [XID] // 0x0000000189B5FF20-0x0000000189B5FF60
	public virtual void ReturnToObjectPool() {} // 0x0000000183EACF20-0x0000000183EACFC0
	[BlackList] // 0x0000000189B6A410-0x0000000189B6A450
	// [XID] // 0x0000000189B6A410-0x0000000189B6A450
	public virtual void OnPoolAllocated() {} // 0x0000000183EACDE0-0x0000000183EACE80
	[BlackList] // 0x0000000189B747B0-0x0000000189B747F0
	// [XID] // 0x0000000189B747B0-0x0000000189B747F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183EACD40-0x0000000183EACDE0
}

