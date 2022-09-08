/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data
{
	[CustomClassObfuscation] // 0x0000000189AC7A00-0x0000000189AC7A70
	// [RequireComponent] // 0x0000000189AC7A00-0x0000000189AC7A70
	public abstract class UserDataStore : MonoBehaviour, IUserDataStore, IControllerMapStore // TypeDefIndex: 3964
	{
		// Constructors
		protected UserDataStore() {} // 0x0000000185106C80-0x0000000185106CE0
	
		// Methods
		private void OnDestroy() {} // 0x0000000185106A90-0x0000000185106C30
		internal void Initialize() {} // 0x00000001851067A0-0x0000000185106970
		public abstract void Load();
		public abstract void LoadControllerData(int playerId, ControllerType controllerType, int controllerId);
		public abstract void LoadControllerData(ControllerType controllerType, int controllerId);
		public abstract void LoadPlayerData(int playerId);
		public abstract void LoadInputBehavior(int playerId, int behaviorId);
		public abstract void Save();
		public abstract void SaveControllerData(int playerId, ControllerType controllerType, int controllerId);
		public abstract void SaveControllerData(ControllerType controllerType, int controllerId);
		public abstract void SavePlayerData(int playerId);
		public abstract void SaveInputBehavior(int playerId, int behaviorId);
		public virtual void SaveControllerMap(int playerId, ControllerMap controllerMap) {} // 0x0000000185106C30-0x0000000185106C80
		public virtual ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) => default; // 0x0000000185106970-0x00000001851069C0
		protected abstract void OnInitialize();
		protected abstract void OnControllerConnected(ControllerStatusChangedEventArgs args);
		protected abstract void OnControllerDisconnected(ControllerStatusChangedEventArgs args);
		[Obsolete] // 0x0000000189AD6E10-0x0000000189AD6E40
		protected virtual void OnControllerPreDiscconnect(ControllerStatusChangedEventArgs args) {} // 0x00000001851069C0-0x0000000185106A10
		protected virtual void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args) {} // 0x0000000185106A10-0x0000000185106A90
	}
}
