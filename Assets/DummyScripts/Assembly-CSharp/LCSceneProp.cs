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

public sealed class LCSceneProp : LCBase // TypeDefIndex: 11763
{
	// Fields
	private float _lastCheckTime; // 0x130
	private CreateGadget _config; // 0x138
	private Collider _followCollider; // 0x140

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898226B0-0x00000001898226D0 */ get => default; } // 0x0000000182C06FF0-0x0000000182C07090 

	// Constructors
	public LCSceneProp() {} // Dummy constructor
	public LCSceneProp(CreateGadget config, Collider followCollider) {} // 0x0000000182C06F60-0x0000000182C06FF0

	// Methods
	// [XID] // 0x000000018971A310-0x000000018971A330
	public override void Destroy() {} // 0x0000000182C06A80-0x0000000182C06B30
	// [XID] // 0x00000001898705D0-0x00000001898705F0
	public static bool Raycast(Vector3 pos, CreateEntity config, out RaycastHit hit) {
		hit = default;
		return default;
	} // 0x0000000182C067E0-0x0000000182C06A80
	// [XID] // 0x00000001896240A0-0x00000001896240C0
	protected override void Tick(float inDeltaTime) {} // 0x0000000182C06D70-0x0000000182C06F60
	// [XID] // 0x0000000189730670-0x0000000189730690
	public void DoDestroy(BaseEntity floorEntity) {} // 0x0000000182C06C80-0x0000000182C06D70
}

