/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public interface ILuaActorInfoData // TypeDefIndex: 21061
	{
		// Properties
		uint runtimeID { get; }
		string alias { get; }
		string metaPath { get; }
		uint configID { get; }
		uint dataIndex { get; }
		Vector3 bornPos { get; }
		Vector3 bornEuler { get; }
		bool isNetwork { get; }
		bool isAutoStart { get; }
		int sceneID { get; }
		uint roomID { get; }
		uint questID { get; }
		bool noPerform { get; }
		bool checkHide { get; }
		bool dontDestroyOnClear { get; }
		bool clearCmd { get; }
	}
}
