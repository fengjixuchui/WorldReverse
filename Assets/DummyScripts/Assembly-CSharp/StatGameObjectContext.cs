/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StatGameObjectContext : BenchmarkEntity.StatObjectContext<GameObject> // TypeDefIndex: 27599
{
	// Fields
	private uint _prefabHandle; // 0x30

	// Constructors
	public StatGameObjectContext() {} // 0x0000000182C84300-0x0000000182C84370

	// Methods
	// [XID] // 0x00000001897CA5C0-0x00000001897CA5E0
	protected override GameObject InternalInstantiate(IStatInstantiationContext ic) => default; // 0x0000000182C83F30-0x0000000182C84250
	// [XID] // 0x00000001897D1BF0-0x00000001897D1C10
	public override IEnumerable<GameObject> InternalGetGameObjects() => default; // 0x0000000182C84250-0x0000000182C84300
	// [XID] // 0x00000001897D9AF0-0x00000001897D9B10
	protected override void DisposeObject(GameObject obj) {} // 0x0000000182C83D40-0x0000000182C83E10
	// [XID] // 0x00000001897E0D90-0x00000001897E0DB0
	protected override void OnDisposedAllObjects() {} // 0x0000000182C83E10-0x0000000182C83F30
}

