/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public abstract class BalanceTickObjectProxyWithDelayDowngradeTickLOD : BalanceTickObjectProxy // TypeDefIndex: 10471
	{
		// Fields
		public const float ValidLODSwtichElapsedTime = 2f; // Metadata: 0x00AE7643
		public const float InstantLODSwitchTime = 3f; // Metadata: 0x00AE7647
	
		// Properties
		public int requestLOD { /* [XID] */ /* 0x0000000189613AC0-0x0000000189613B00 */ get; /* [XID] */ /* 0x000000018961E2E0-0x000000018961E320 */ private set; } // 0x00000001868EFDD0-0x00000001868EFE30 0x00000001868EFEA0-0x00000001868EFF00
		public float requestElapsedTime { /* [XID] */ /* 0x00000001896288A0-0x00000001896288E0 */ get; /* [XID] */ /* 0x0000000189633150-0x0000000189633190 */ protected set; } // 0x00000001868EFD60-0x00000001868EFDD0 0x00000001868EFE30-0x00000001868EFEA0
	
		// Constructors
		protected BalanceTickObjectProxyWithDelayDowngradeTickLOD() {} // 0x00000001868EFCC0-0x00000001868EFD60
	
		// Methods
		// [XID] // 0x000000018963DBB0-0x000000018963DBD0
		protected override void Init() {} // 0x00000001868EF4C0-0x00000001868EF5E0
		// [XID] // 0x0000000189A26090-0x0000000189A260B0
		protected void AssertTickLODStateInvalid(int newRequestLOD, int stage) {} // 0x00000001868EF130-0x00000001868EF4C0
		// [XID] // 0x000000018964CC60-0x000000018964CC80
		protected virtual bool ShouldInstantActivateTickLOD(int newRequestLOD) => default; // 0x00000001868EF7F0-0x00000001868EF940
		// [XID] // 0x0000000189B19D80-0x0000000189B19DA0
		protected void InstantActivateTickLOD() {} // 0x00000001868EF5E0-0x00000001868EF6C0
		// [XID] // 0x0000000189B5D2D0-0x0000000189B5D2F0
		public override void OnRemovedFromTickGroup() {} // 0x00000001868EF6C0-0x00000001868EF7F0
		// [XID] // 0x0000000189662D30-0x0000000189662D50
		protected void UpdateTickLODTransition(int newRequestLOD, float deltaTime) {} // 0x00000001868EFA00-0x00000001868EFCC0
	}
}
