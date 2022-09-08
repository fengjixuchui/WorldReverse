/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib
{
	public sealed class NetThread // TypeDefIndex: 6962
	{
		// Fields
		private Thread _thread; // 0x10
		private readonly Action _callback; // 0x18
		public int SleepTime; // 0x20
		private bool _running; // 0x24
		private readonly string _name; // 0x28
	
		// Properties
		public bool IsRunning { /* [XID] */ /* 0x0000000189A255D0-0x0000000189A255F0 */ get => default; } // 0x00000001863CF6F0-0x00000001863CF790 
	
		// Constructors
		public NetThread() {} // Dummy constructor
		public NetThread(string name, int sleepTime, Action callback) {} // 0x00000001863CF660-0x00000001863CF6F0
	
		// Methods
		// [XID] // 0x0000000189A2CB40-0x0000000189A2CB60
		public void Start() {} // 0x00000001863CF370-0x00000001863CF4B0
		// [XID] // 0x0000000189A342B0-0x0000000189A342D0
		public void Stop() {} // 0x00000001863CF4B0-0x00000001863CF570
		// [XID] // 0x0000000189A3B9A0-0x0000000189A3B9C0
		private void ThreadLogic() {} // 0x00000001863CF570-0x00000001863CF660
	}
}
