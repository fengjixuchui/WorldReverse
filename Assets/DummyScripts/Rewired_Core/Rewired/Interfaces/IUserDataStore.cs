/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Interfaces
{
	public interface IUserDataStore // TypeDefIndex: 3962
	{
		// Methods
		void Save();
		void SaveControllerData(int playerId, ControllerType controllerType, int controllerId);
		void SaveControllerData(ControllerType controllerType, int controllerId);
		void Load();
		void LoadControllerData(int playerId, ControllerType controllerType, int controllerId);
		void LoadControllerData(ControllerType controllerType, int controllerId);
	}
}
