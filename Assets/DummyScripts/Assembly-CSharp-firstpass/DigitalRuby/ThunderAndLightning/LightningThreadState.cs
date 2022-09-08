/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningThreadState // TypeDefIndex: 9648
	{
		// Fields
		private Thread lightningThread; // 0x10
		private AutoResetEvent lightningThreadEvent; // 0x18
		private readonly Queue<Action> actionsForBackgroundThread; // 0x20
		private readonly Queue<KeyValuePair<Action, ManualResetEvent>> actionsForMainThread; // 0x28
		public bool Running; // 0x30
		private bool isTerminating; // 0x31
	
		// Constructors
		public LightningThreadState() {} // 0x00000001860499A0-0x0000000186049B00
	
		// Methods
		// [XID] // 0x0000000189B582E0-0x0000000189B58300
		private bool UpdateMainThreadActionsOnce() => default; // 0x00000001860496D0-0x00000001860498E0
		// [XID] // 0x0000000189A1CC20-0x0000000189A1CC40
		private void BackgroundThreadMethod() {} // 0x0000000186049290-0x0000000186049550
		// [XID] // 0x00000001896CE860-0x00000001896CE880
		public void TerminateAndWaitForEnd() {} // 0x0000000186049550-0x00000001860496D0
		// [XID] // 0x00000001896D5BD0-0x00000001896D5BF0
		public void UpdateMainThreadActions() {} // 0x00000001860498E0-0x00000001860499A0
		// [XID] // 0x0000000189B8CBF0-0x0000000189B8CC10
		public bool AddActionForMainThread(Action action, bool waitForAction = false /* Metadata: 0x00AE5CEF */) => default; // 0x00000001860490A0-0x0000000186049290
		// [XID] // 0x0000000189985FD0-0x0000000189985FF0
		public bool AddActionForBackgroundThread(Action action) => default; // 0x0000000186048F30-0x00000001860490A0
	}
}
