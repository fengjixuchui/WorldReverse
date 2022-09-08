/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DitherByAbility : BaseDither // TypeDefIndex: 32048
{
	// Fields
	private uint _curUniqId; // 0x10
	private Dictionary<uint, AbilityDitherInfo> _curAbilityDitherInfos; // 0x18
	private List<uint> _tempDestoryDitherUniqId; // 0x20

	// Properties
	public override bool CanBeDestroy { /* [XID] */ /* 0x0000000189BD1520-0x0000000189BD1540 */ get => default; } // 0x0000000185958400-0x00000001859584C0 

	// Nested types
	private class AbilityDitherInfo // TypeDefIndex: 32049
	{
		// Fields
		private float _fromDither; // 0x10
		private float _toDither; // 0x14
		private float _leftTime; // 0x18
		private float _duration; // 0x1C
		private bool _isStoping; // 0x20
		private float _curDither; // 0x24

		// Constructors
		public AbilityDitherInfo() {} // 0x0000000185959E30-0x0000000185959E90

		// Methods
		// [XID] // 0x00000001896038E0-0x0000000189603900
		public bool IsStoped() => default; // 0x00000001859599D0-0x0000000185959A80
		// [XID] // 0x000000018960B220-0x000000018960B240
		public void Start(float tarDitherValue, float time) {} // 0x0000000185959A80-0x0000000185959B60
		// [XID] // 0x00000001897B4960-0x00000001897B4980
		public void Stop(float time) {} // 0x0000000185959900-0x00000001859599D0
		// [XID] // 0x0000000189619F40-0x0000000189619F60
		public float UpdateDither(float deltaTime) => default; // 0x0000000185959CA0-0x0000000185959E30
		// [XID] // 0x0000000189621470-0x0000000189621490
		public void Release() {} // 0x0000000185959C00-0x0000000185959CA0
		// [XID] // 0x000000018978E680-0x000000018978E6A0
		public static AbilityDitherInfo Get() => default; // 0x0000000185959B60-0x0000000185959C00
	}

	// Constructors
	public DitherByAbility() {} // 0x0000000185958E40-0x0000000185958F00

	// Methods
	// [XID] // 0x0000000189787020-0x0000000189787040
	private uint GenNextUniqId() => default; // 0x0000000185958D80-0x0000000185958E40
	// [XID] // 0x0000000189BD8B40-0x0000000189BD8B60
	public override void Destroy() {} // 0x00000001859584C0-0x00000001859586D0
	// [XID] // 0x00000001895E5700-0x00000001895E5720
	public static DitherByAbility Get() => default; // 0x0000000185958880-0x0000000185958920
	// [XID] // 0x000000018977F660-0x000000018977F680
	public uint Start(float tarDitherValue, float time) => default; // 0x00000001859586D0-0x0000000185958880
	// [XID] // 0x00000001897ACBA0-0x00000001897ACBC0
	public void Stop(uint uniqId, float time) {} // 0x00000001859582F0-0x0000000185958400
	// [XID] // 0x00000001895FBEA0-0x00000001895FBEC0
	public override float UpdateDither(float inDeltaTime) => default; // 0x0000000185958990-0x0000000185958D80
}

