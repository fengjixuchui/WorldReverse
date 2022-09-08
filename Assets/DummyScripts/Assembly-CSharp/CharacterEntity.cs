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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class CharacterEntity : BaseEntity, IAutoAllocRecycle // TypeDefIndex: 19874
{
	// Fields
	public const string ROOT_NODE = "RootNode"; // Metadata: 0x00AFCFB5
	protected Vector3 _originLocalPosRoot; // 0x4B8
	protected Vector3 _originLocalEulerRoot; // 0x4C4
	protected Vector3 _originLocalScaleRoot; // 0x4D0
	protected Transform _bipTrans; // 0x4E0

	// Properties
	public Transform bipTrans { /* [XID] */ /* 0x000000018977D300-0x000000018977D320 */ get; } // 0x000000018465E2D0-0x000000018465E380 

	// Constructors
	protected CharacterEntity() {} // 0x000000018465ED40-0x000000018465EDD0

	// Methods
	// [XID] // 0x0000000189784D40-0x0000000189784D60
	public bool isBipChanged() => default; // 0x000000018465E9B0-0x000000018465EB70
	// [XID] // 0x000000018978C1F0-0x000000018978C210
	public override void OnEntityReady() {} // 0x000000018465E860-0x000000018465E910
	// [XID] // 0x00000001897937E0-0x0000000189793800
	protected void InitBipNode() {} // 0x000000018465E3E0-0x000000018465E5E0
	// [XID] // 0x000000018979B9F0-0x000000018979BA10
	public void ResetBipNode() {} // 0x000000018465E0A0-0x000000018465E230
	// [XID] // 0x00000001897A2DE0-0x00000001897A2E00
	public void ResetEmotion() {} // 0x000000018465E230-0x000000018465E2D0
	// [XID] // 0x00000001897AA460-0x00000001897AA480
	protected override bool ShouldFireEntityReady() => default; // 0x000000018465E650-0x000000018465E6F0
	// [XID] // 0x00000001897B1ED0-0x00000001897B1EF0
	protected override bool ShouldFireEntityActive() => default; // 0x000000018465E760-0x000000018465E800
	// [XID] // 0x00000001897B9930-0x00000001897B9950
	protected override bool ShouldFireEntityRemoved() => default; // 0x000000018465E910-0x000000018465E9B0
	[BlackList] // 0x00000001897C1930-0x00000001897C1970
	// [XID] // 0x00000001897C1930-0x00000001897C1970
	public override void AutoAllocTypeFields() {} // 0x000000018465DF00-0x000000018465DFA0
	[BlackList] // 0x00000001897CBE90-0x00000001897CBED0
	// [XID] // 0x00000001897CBE90-0x00000001897CBED0
	public override void AutoRecycleTypeFields() {} // 0x000000018465DFA0-0x000000018465E0A0
	[BlackList] // 0x00000001897D67A0-0x00000001897D67E0
	// [XID] // 0x00000001897D67A0-0x00000001897D67E0
	public override void ReturnToObjectPool() {} // 0x000000018465ECA0-0x000000018465ED40
}

