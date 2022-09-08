/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class Dispatcher : MonoBehaviour // TypeDefIndex: 8658
	{
		// Fields
		private static Dispatcher _instance; // 0x00
		private static bool _queued; // 0x08
		private static List<Action> _backlog; // 0x10
		private static List<Action> _actions; // 0x18
	
		// Constructors
		public Dispatcher() {} // 0x00000001859DABA0-0x00000001859DAC00
		static Dispatcher() {} // 0x00000001859DAAC0-0x00000001859DABA0
	
		// Methods
		// [IDTag] // 0x0000000189625A00-0x0000000189625A40
		// [XID] // 0x0000000189625A00-0x0000000189625A40
		public static void RunAsync(Action action) {} // 0x00000001859DA480-0x00000001859DA5D0
		// [IDTag] // 0x0000000189630370-0x00000001896303B0
		// [XID] // 0x0000000189630370-0x00000001896303B0
		public static void RunAsync(Action<object> action, object state) {} // 0x00000001859DA320-0x00000001859DA480
		// [XID] // 0x000000018963ACF0-0x000000018963AD10
		public static void RunOnMainThread(Action action) {} // 0x00000001859DA5D0-0x00000001859DA770
		// [XID] // 0x0000000189953930-0x0000000189953950
		private static void Initialize() {} // 0x00000001859DA160-0x00000001859DA320
		// [XID] // 0x0000000189649BE0-0x0000000189649C00
		private void Update() {} // 0x00000001859DA770-0x00000001859DAAC0
	}
}
