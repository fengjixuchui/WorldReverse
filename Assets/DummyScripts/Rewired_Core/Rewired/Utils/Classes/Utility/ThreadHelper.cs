/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal class ThreadHelper : IDisposable // TypeDefIndex: 4392
	{
		// Fields
		private readonly Stopwatch XJdPlaQAlkHyVCjLHboQazhehtx; // 0x10
		private Thread xgExdbVyAKUPeHviEQuSfAnlZIs; // 0x18
		private ManualResetEvent RdbgzudXqzaPglIEYiEwHSgKyFnV; // 0x20
		private ManualResetEvent WpXKIbwHutDQsRyRDwAPwSmucHE; // 0x28
		private AutoResetEvent BeUUHzWeAJoQXnEnLZdWlEUHzGS; // 0x30
		private bool rjzKZHIYfbsrgwuefusBpWFwpME; // 0x38
		private bool emuVrtBFJJrHewGGlSYtRURcNOX; // 0x39
		private int GFmCVUMSGyQVJAEABARimKqachS; // 0x3C
		private bool suFzAhVRhGVAvqBiLHYtRjZYwBk; // 0x40
		private int fgMCFMxuwBHTvxVgNDThjtkLouV; // 0x44
		private long GPywStwPFQXSekADmmywejqwtka; // 0x48
		private bool wWHCWPfDPBSYTXENEikTjuUdimc; // 0x50
		private int diocntymSdkTWlYKtPuKPFoNyen; // 0x54
		private long asIRBPNPLWftiKCIFqvMDWzhRIYB; // 0x58
		private uint ENFmMZfgKIIjuiYpzvnnaCVGlVMc; // 0x60
		private readonly object TROHSyLKjYyohQeAvXLSWRaDciH; // 0x68
		private Queue<Action> BJAuWFHlxkAlPJwUnonmABSaRJL; // 0x70
		private Queue<Action> yACFjqTBQxQMisBjOfbWrOOEfIx; // 0x78
		private bool UAoMXUDNqugTEKCAweMzhFsNZLmd; // 0x80
		private Action xIAGJSJwEccVacnuZPENgorgACOL; // 0x88
		private Action ASyvWOTeiyeMLfoYdwTmbElcyYI; // 0x90
		private Action MtHqbQcnPyjbaCCRAQsSzYFZnXWg; // 0x98
		private bool vsurYtRlepcrpAzAENwjqjJEZPT; // 0xA0
	
		// Properties
		public bool isRunning { get => default; } // 0x00000001862F9C80-0x00000001862F9CE0 
		public int fixedTimeStepFPS { set {} } // 0x00000001862FA690-0x00000001862FA720
	
		// Events
		public event Action ThreadUpdateEvent;
		private event Action _ThreadStartedEvent;
		public event Action ThreadStartedEvent;
		private event Action _ThreadPreStopEvent;
		public event Action ThreadPreStopEvent;
	
		// Constructors
		public ThreadHelper() {} // Dummy constructor
		private ThreadHelper(int timeoutMS) {} // 0x00000001862F9970-0x00000001862F99F0
		private ThreadHelper(int fixedTimeStepFPS, bool useHighPrecisionTimer, int timeoutMS) {} // 0x00000001862F9720-0x00000001862F9970
	
		// Methods
		public static ThreadHelper Create(bool fixedTimeStep = false /* Metadata: 0x00AC5143 */, int fixedTimeStepFPS = 100 /* Metadata: 0x00AC5144 */, bool useHighPrecisionTimer = false /* Metadata: 0x00AC5148 */, int timeoutMS = 0 /* Metadata: 0x00AC5149 */) => default; // 0x00000001862F8A70-0x00000001862F8B70
		public static ThreadHelper CreateFixedTimeStep(int timeStepFPS, int timeoutMS = 0 /* Metadata: 0x00AC514D */) => default; // 0x00000001862F8940-0x00000001862F89C0
		public static ThreadHelper CreateFixedTimeStep(int timeStepFPS, bool useHighPrecisionTimer = false /* Metadata: 0x00AC5151 */, int timeoutMS = 0 /* Metadata: 0x00AC5152 */) => default; // 0x00000001862F89C0-0x00000001862F8A70
		public bool Start(bool wait) => default; // 0x00000001862F91B0-0x00000001862F9350
		public void Stop(bool wait) {} // 0x00000001862F9350-0x00000001862F94A0
		public void WaitForActionQueueToFinish() {} // 0x00000001862F94A0-0x00000001862F9630
		public void ResetTimeout() {} // 0x00000001862F9120-0x00000001862F91B0
		private void qHRzioZdXpmfuyXRLDxgSFOkGivH() {} // 0x00000001862F9E90-0x00000001862FA4E0
		private void KUAvkxaPJaCotZAhSDylCRTHIrCL() {} // 0x00000001862F8E60-0x00000001862F9040
		private void pbaKgPRbqyhzTxjmuopEpgjGcJjI() {} // 0x00000001862F9DC0-0x00000001862F9E90
		private void wWHIeZOvAcJogZJomCBAHnsZeBwE() {} // 0x00000001862FA720-0x00000001862FA800
		public void Dispose() {} // 0x00000001862F8C30-0x00000001862F8D30
		~ThreadHelper() {} // 0x00000001862F8D30-0x00000001862F8E60
		protected void Dispose(bool disposing) {} // 0x00000001862F8B70-0x00000001862F8C30
	}
}
