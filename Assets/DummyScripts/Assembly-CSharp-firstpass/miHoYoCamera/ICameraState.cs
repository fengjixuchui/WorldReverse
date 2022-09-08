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
	public interface ICameraState : IPriorityStackItem, IDisposable // TypeDefIndex: 8948
	{
		// Properties
		int Id { get; }
		int Type { get; }
		string Name { get; }
		string Description { get; }
		CameraStateData Data { get; }
		CameraStateBlenderConfig BlendCfg { get; }
		bool IsSpawned { get; }
		bool IsBackground { get; }
		ICameraStateRunner Runner { get; }
	
		// Methods
		void UpdateData(CameraStateData data);
		void Spawn();
		void UnSpawn();
		void SwitchBackground(bool value);
		void UpdateByState(ICameraState state);
		void UpdateByBlendSrc(ICameraState state);
		void RegisterRunner(ICameraStateRunner runner);
		void Collect();
		void OnBlendToStart();
		void OnBlendFromStart();
		void OnBlendToFinished();
		void OnBlendFromFinished();
	}
}
