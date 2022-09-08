/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class AIPoseSelector : IAutoAllocRecycle // TypeDefIndex: 19966
{
	// Fields
	private List<int> _poses; // 0x10

	// Constructors
	public AIPoseSelector() {} // 0x0000000183C18690-0x0000000183C186F0

	// Methods
	[BlackList] // 0x0000000189B29740-0x0000000189B29780
	// [XID] // 0x0000000189B29740-0x0000000189B29780
	public virtual void AutoAllocTypeFields() {} // 0x0000000183C18060-0x0000000183C18100
	[BlackList] // 0x0000000189B33C40-0x0000000189B33C80
	// [XID] // 0x0000000189B33C40-0x0000000189B33C80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183C18100-0x0000000183C181A0
	[BlackList] // 0x0000000189B3E390-0x0000000189B3E3D0
	// [XID] // 0x0000000189B3E390-0x0000000189B3E3D0
	public virtual void ReturnToObjectPool() {} // 0x0000000183C185F0-0x0000000183C18690
	[BlackList] // 0x0000000189B48FA0-0x0000000189B48FE0
	// [XID] // 0x0000000189B48FA0-0x0000000189B48FE0
	public virtual void OnPoolAllocated() {} // 0x0000000183C18550-0x0000000183C185F0
	[BlackList] // 0x0000000189B53520-0x0000000189B53560
	// [XID] // 0x0000000189B53520-0x0000000189B53560
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183C184B0-0x0000000183C18550
	// [XID] // 0x0000000189B5DF00-0x0000000189B5DF20
	public void InitPoseSelector(List<int> poseList) {} // 0x0000000183C181A0-0x0000000183C18250
	// [IDTag] // 0x0000000189B65460-0x0000000189B654A0
	// [XID] // 0x0000000189B65460-0x0000000189B654A0
	public bool CheckValidPose(int pose) => default; // 0x0000000183C18250-0x0000000183C18380
	// [IDTag] // 0x0000000189B6FAC0-0x0000000189B6FB00
	// [XID] // 0x0000000189B6FAC0-0x0000000189B6FB00
	public static bool CheckValidPose(SimpleSafeInt32[] poses, int poseID) => default; // 0x0000000183C18380-0x0000000183C184B0
}

