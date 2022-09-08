/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RootMotion.Dynamics
{
	// [AddComponentMenu] // 0x00000001897D5E30-0x00000001897D5E60
	public class BehaviourTemplate : BehaviourBase // TypeDefIndex: 9880
	{
		// Fields
		public SubBehaviourCOM centerOfMass; // 0xF8
		public LayerMask groundLayers; // 0x100
		public PuppetEvent onLoseBalance; // 0x108
		public float loseBalanceAngle; // 0x120
	
		// Constructors
		public BehaviourTemplate() {} // 0x00000001876CE130-0x00000001876CE1E0
	
		// Methods
		// [XID] // 0x00000001897DECE0-0x00000001897DED00
		protected override void OnInitiate() {} // 0x00000001876CDA90-0x00000001876CDB50
		// [XID] // 0x00000001898B37A0-0x00000001898B37C0
		protected override void OnActivate() {} // 0x00000001876CD880-0x00000001876CD920
		// [XID] // 0x00000001897EE180-0x00000001897EE1A0
		public override void OnReactivate() {} // 0x00000001876CDD90-0x00000001876CDE30
		// [XID] // 0x00000001897F5930-0x00000001897F5950
		protected override void OnDeactivate() {} // 0x00000001876CD920-0x00000001876CD9C0
		// [XID] // 0x00000001897DF7B0-0x00000001897DF7D0
		protected override void OnFixedUpdate() {} // 0x00000001876CD9C0-0x00000001876CDA90
		// [XID] // 0x00000001897EEB40-0x00000001897EEB60
		protected override void OnLateUpdate() {} // 0x00000001876CDB50-0x00000001876CDBF0
		// [XID] // 0x0000000189B84C10-0x0000000189B84C30
		protected override void OnMuscleHitBehaviour(MuscleHit hit) {} // 0x00000001876CDCC0-0x00000001876CDD90
		// [XID] // 0x0000000189813500-0x0000000189813520
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m) {} // 0x00000001876CDBF0-0x00000001876CDCC0
	}
}
