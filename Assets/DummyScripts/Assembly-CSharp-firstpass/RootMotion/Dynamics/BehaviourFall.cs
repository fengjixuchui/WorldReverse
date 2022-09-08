/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using RootMotion;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RootMotion.Dynamics
{
	// [AddComponentMenu] // 0x00000001899077A0-0x0000000189907800
	// [HelpURL] // 0x00000001899077A0-0x0000000189907800
	public class BehaviourFall : BehaviourBase // TypeDefIndex: 9870
	{
		// Fields
		// [LargeHeader] // 0x0000000189914FF0-0x0000000189915050
		// [Tooltip] // 0x0000000189914FF0-0x0000000189915050
		public string stateName; // 0xF8
		// [Tooltip] // 0x00000001899228D0-0x0000000189922900
		public float transitionDuration; // 0x100
		// [Tooltip] // 0x000000018992B9C0-0x000000018992B9F0
		public int layer; // 0x104
		// [Tooltip] // 0x00000001899345C0-0x00000001899345F0
		public float fixedTime; // 0x108
		// [LargeHeader] // 0x000000018993D8E0-0x000000018993D940
		// [Tooltip] // 0x000000018993D8E0-0x000000018993D940
		public LayerMask raycastLayers; // 0x10C
		// [Tooltip] // 0x000000018994AC60-0x000000018994AC90
		public string blendParameter; // 0x110
		// [Tooltip] // 0x0000000189953A30-0x0000000189953A60
		public float writheHeight; // 0x118
		// [Tooltip] // 0x000000018995CB00-0x000000018995CB30
		public float writheYVelocity; // 0x11C
		// [Tooltip] // 0x0000000189965C80-0x0000000189965CB0
		public float blendSpeed; // 0x120
		// [Tooltip] // 0x000000018996E800-0x000000018996E830
		public float blendMappingSpeed; // 0x124
		// [LargeHeader] // 0x0000000189977F30-0x0000000189977F90
		// [Tooltip] // 0x0000000189977F30-0x0000000189977F90
		public bool canEnd; // 0x128
		// [Tooltip] // 0x0000000189985260-0x0000000189985290
		public float minTime; // 0x12C
		// [Tooltip] // 0x000000018998E5E0-0x000000018998E610
		public float maxEndVelocity; // 0x130
		// [Tooltip] // 0x0000000189997730-0x0000000189997760
		public PuppetEvent onEnd; // 0x138
		private float timer; // 0x150
		private bool endTriggered; // 0x154
	
		// Constructors
		public BehaviourFall() {} // 0x00000001876C6060-0x00000001876C6170
	
		// Methods
		// [ContextMenu] // 0x00000001899A0C80-0x00000001899A0CD0
		// [XID] // 0x00000001899A0C80-0x00000001899A0CD0
		private void OpenUserManual() {} // 0x00000001876C5BC0-0x00000001876C5C70
		// [ContextMenu] // 0x00000001899AB710-0x00000001899AB760
		// [XID] // 0x00000001899AB710-0x00000001899AB760
		private void OpenScriptReference() {} // 0x00000001876C5B10-0x00000001876C5BC0
		// [XID] // 0x00000001897250E0-0x0000000189725100
		protected override void OnActivate() {} // 0x00000001876C5240-0x00000001876C5340
		// [XID] // 0x00000001899BD420-0x00000001899BD440
		protected override void OnDeactivate() {} // 0x00000001876C5340-0x00000001876C5420
		// [XID] // 0x00000001899C4E70-0x00000001899C4E90
		public override void OnReactivate() {} // 0x00000001876C5A60-0x00000001876C5B10
		[DebuggerHidden] // 0x00000001899CC410-0x00000001899CC450
		// [XID] // 0x00000001899CC410-0x00000001899CC450
		private IEnumerator SmoothActivate() => default; // 0x00000001876C5D70-0x00000001876C5E80
		// [XID] // 0x000000018989D260-0x000000018989D280
		protected override void OnFixedUpdate() {} // 0x00000001876C5420-0x00000001876C5760
		// [XID] // 0x00000001899DE030-0x00000001899DE050
		protected override void OnLateUpdate() {} // 0x00000001876C5760-0x00000001876C5A60
		// [XID] // 0x0000000189964250-0x0000000189964270
		public override void Resurrect() {} // 0x00000001876C5C70-0x00000001876C5D70
		// [XID] // 0x00000001895F05A0-0x00000001895F05C0
		private float GetBlendTarget(float groundHeight) => default; // 0x00000001876C4CB0-0x00000001876C4FA0
		// [XID] // 0x00000001899F4C80-0x00000001899F4CA0
		private float GetGroundHeight() => default; // 0x00000001876C4FA0-0x00000001876C5240
	}
}
