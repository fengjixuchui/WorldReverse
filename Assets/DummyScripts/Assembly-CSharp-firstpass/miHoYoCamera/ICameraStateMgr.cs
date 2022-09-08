/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoCamera
{
	public interface ICameraStateMgr // TypeDefIndex: 8952
	{
		// Methods
		void BindCamera(Camera camera);
		void RegisterState(ICameraState state);
		void UnregisterState(ICameraState state);
		void SpawnState(int stateId);
		void UnSpawnState(int stateId);
		void SpawnStateByType(int stateType);
		void UnSpawnStateByType(int stateType);
		void Collect(float deltaTime);
		void Tick(float deltaTime);
		void Flush(float deltaTime);
	}
}
