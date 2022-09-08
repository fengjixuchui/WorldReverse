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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class FacePartControl : IAutoAllocRecycle // TypeDefIndex: 19827
{
	// Fields
	private IFaceMatInfoProvider _faceMatInfoProvider; // 0x10
	private Renderer _facePartRenderer; // 0x18
	private FaceMatInfo _originFaceMatInfo; // 0x20
	private string[] _frameNames; // 0x38

	// Constructors
	public FacePartControl() {} // 0x0000000181BAFA70-0x0000000181BAFAD0

	// Methods
	// [XID] // 0x0000000189A69A30-0x0000000189A69A50
	public void OnBeforePoolRecycled() {} // 0x0000000181BAF690-0x0000000181BAF760
	// [XID] // 0x0000000189A70D40-0x0000000189A70D60
	public void OnPoolAllocated() {} // 0x0000000181BAF760-0x0000000181BAF800
	// [XID] // 0x0000000189B5A3C0-0x0000000189B5A3E0
	public void Init(IFaceMatInfoProvider provider, Renderer part) {} // 0x0000000181BAF140-0x0000000181BAF450
	// [XID] // 0x0000000189A7FBB0-0x0000000189A7FBD0
	public bool HasRenderer() => default; // 0x0000000181BAF450-0x0000000181BAF530
	// [XID] // 0x0000000189A87980-0x0000000189A879A0
	public void SetFacePartIndex(int index) {} // 0x0000000181BAF800-0x0000000181BAF9D0
	// [XID] // 0x0000000189A8F190-0x0000000189A8F1B0
	public int GetMaxIndex() => default; // 0x0000000181BAF530-0x0000000181BAF5F0
	// [XID] // 0x0000000189A96680-0x0000000189A966A0
	public void Reset() {} // 0x0000000181BAEFC0-0x0000000181BAF140
	// [XID] // 0x0000000189A9DC30-0x0000000189A9DC50
	public string[] GetFrameNames() => default; // 0x0000000181BAF5F0-0x0000000181BAF690
	[BlackList] // 0x0000000189AA5620-0x0000000189AA5660
	// [XID] // 0x0000000189AA5620-0x0000000189AA5660
	public virtual void AutoAllocTypeFields() {} // 0x0000000181BAEE50-0x0000000181BAEEF0
	[BlackList] // 0x0000000189AAFE50-0x0000000189AAFE90
	// [XID] // 0x0000000189AAFE50-0x0000000189AAFE90
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181BAEEF0-0x0000000181BAEFC0
	[BlackList] // 0x0000000189ABA9A0-0x0000000189ABA9E0
	// [XID] // 0x0000000189ABA9A0-0x0000000189ABA9E0
	public virtual void ReturnToObjectPool() {} // 0x0000000181BAF9D0-0x0000000181BAFA70
}

