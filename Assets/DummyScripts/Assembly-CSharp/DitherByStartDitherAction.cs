/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DitherByStartDitherAction : BaseDither // TypeDefIndex: 32044
{
	// Fields
	private EntityTimer _ditherTimer; // 0x10
	private bool isReserve; // 0x18

	// Constructors
	public DitherByStartDitherAction() {} // Dummy constructor
	public DitherByStartDitherAction(BaseEntity entity) {} // 0x0000000181D501A0-0x0000000181D50270

	// Methods
	// [XID] // 0x0000000189B70DE0-0x0000000189B70E00
	public override void Destroy() {} // 0x0000000181D4FE90-0x0000000181D4FF60
	// [XID] // 0x0000000189B78390-0x0000000189B783B0
	public override float UpdateDither(float inDeltaTime) => default; // 0x0000000181D4FF60-0x0000000181D500C0
	// [XID] // 0x0000000189B7F7F0-0x0000000189B7F810
	public void StartDither(float duration, bool reserve) {} // 0x0000000181D500C0-0x0000000181D501A0
}

