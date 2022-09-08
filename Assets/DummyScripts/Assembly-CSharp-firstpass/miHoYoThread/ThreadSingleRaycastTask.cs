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

namespace miHoYoThread
{
	public class ThreadSingleRaycastTask : ThreadTask<miHoYoThread.TaskSingleRaycastData> // TypeDefIndex: 9076
	{
		// Fields
		private RaycastHit _hitInfo; // 0x60
		private Vector3 _startPos; // 0xA0
		private string _taskName; // 0xB0
		private Transform _raycastTrans; // 0xB8
	
		// Properties
		public override string taskName { /* [XID] */ /* 0x0000000189B7ADC0-0x0000000189B7ADE0 */ get => default; } // 0x0000000185407800-0x00000001854078B0 
	
		// Constructors
		public ThreadSingleRaycastTask() {} // 0x00000001854076D0-0x0000000185407800
	
		// Methods
		// [XID] // 0x0000000189B73890-0x0000000189B738B0
		public override void BindTarget(object target) {} // 0x00000001854070B0-0x00000001854071C0
		// [XID] // 0x0000000189B827C0-0x0000000189B827E0
		public override void Collect() {} // 0x00000001854071C0-0x0000000185407290
		// [XID] // 0x0000000189B89E30-0x0000000189B89E50
		public override void Execute() {} // 0x0000000185407290-0x0000000185407420
		// [XID] // 0x0000000189B91550-0x0000000189B91570
		public override void Flush() {} // 0x0000000185407420-0x00000001854074C0
	}
}
