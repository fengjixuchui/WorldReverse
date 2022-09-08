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
using XInputDotNetPure;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class XInputDeviceManager : InputDeviceManager // TypeDefIndex: 8010
	{
		// Fields
		private bool[] deviceConnected; // 0x18
		private const int maxDevices = 4; // Metadata: 0x00ADF3E5
		private RingBuffer<GamePadState>[] gamePadState; // 0x20
		private Thread thread; // 0x28
		private int timeStep; // 0x30
		private int bufferSize; // 0x34
	
		// Constructors
		public XInputDeviceManager() {} // 0x0000000186D222D0-0x0000000186D225B0
	
		// Methods
		// [XID] // 0x0000000189867B90-0x0000000189867BB0
		private void StartWorker() {} // 0x0000000186D21C70-0x0000000186D21DA0
		// [XID] // 0x000000018986F270-0x000000018986F290
		private void StopWorker() {} // 0x0000000186D21DA0-0x0000000186D21E70
		// [XID] // 0x00000001898766F0-0x0000000189876710
		private void Worker() {} // 0x0000000186D22120-0x0000000186D222D0
		// [XID] // 0x0000000189BDE120-0x0000000189BDE140
		internal GamePadState GetState(int deviceIndex) => default; // 0x0000000186D21A70-0x0000000186D21C70
		// [XID] // 0x00000001898854B0-0x00000001898854D0
		public override void Update(ulong updateTick, float deltaTime) {} // 0x0000000186D21ED0-0x0000000186D22120
		// [XID] // 0x0000000189BDD1B0-0x0000000189BDD1D0
		public override void Destroy() {} // 0x0000000186D216F0-0x0000000186D21790
		// [XID] // 0x0000000189893F40-0x0000000189893F60
		public static bool CheckPlatformSupport(ICollection<string> errors) => default; // 0x0000000186D21570-0x0000000186D216F0
		// [XID] // 0x00000001896CE6C0-0x00000001896CE6E0
		internal static void Enable() {} // 0x0000000186D21790-0x0000000186D21A70
	}
}
