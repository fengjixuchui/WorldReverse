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
using Moments.Encoder;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Moments
{
	internal sealed class Worker // TypeDefIndex: 7569
	{
		// Fields
		private static int workerId; // 0x00
		private Thread m_Thread; // 0x10
		private int m_Id; // 0x18
		internal List<GifFrame> m_Frames; // 0x20
		internal GifEncoder m_Encoder; // 0x28
		internal string m_FilePath; // 0x30
		internal Action<int, string> m_OnFileSaved; // 0x38
		internal Action<int, float> m_OnFileSaveProgress; // 0x40
	
		// Constructors
		public Worker() {} // Dummy constructor
		internal Worker(ThreadPriority priority) {} // 0x000000018609C820-0x000000018609C930
		static Worker() {} // 0x000000018609C7C0-0x000000018609C820
	
		// Methods
		// [XID] // 0x00000001898C71C0-0x00000001898C71E0
		internal void Start() {} // 0x000000018609C710-0x000000018609C7C0
		// [XID] // 0x0000000189BD10D0-0x0000000189BD10F0
		private void Run() {} // 0x000000018609C540-0x000000018609C710
	}
}
