/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	public interface IGaiaWorkItem // TypeDefIndex: 9167
	{
		// Properties
		ulong JobID { get; set; }
		GaiaConstants.JobStatus Status { get; set; }
		int ActiveJobs { get; set; }
		bool IsCancelled { get; set; }
		bool IsErrored { get; set; }
		string ErrorStr { get; set; }
		bool NeedsBackground { get; }
	
		// Methods
		void ResetToIdle();
		void ExecuteSetupInForeground();
		void ExecuteWorkInBackground();
		void ExecutePostProcessInForeground();
		float PercentComplete();
	}
}
