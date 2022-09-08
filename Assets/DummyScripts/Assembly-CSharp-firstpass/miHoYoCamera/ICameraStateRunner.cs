/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoCamera
{
	public interface ICameraStateRunner : IDisposable // TypeDefIndex: 8958
	{
		// Properties
		bool IsBackground { get; }
	
		// Methods
		void SwitchRunning(bool background);
		void Init(ICameraState state);
		void Start();
		void Collect(float deltaTime);
		void Tick(float deltaTime);
		void Flush(float deltaTime);
		void PostFlushTop();
	}
}
