/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

internal interface syapwIJQHBZeZRnKBfKyragYBFx // TypeDefIndex: 4142
{
	// Properties
	ControllerMap this[int index] { get => default; }
	int GjxMqHiPMFWHbEAoireiwUjswOT { get; }
	IList<ControllerMap> JsNTVypLjvOjvMfpPeSSjGqIDiYx { get; }

	// Methods
	IList<T> GetMaps<T>()
		where T : ControllerMap;
	void Add(ControllerMap param_00008a4a, BoolOption param_00008a4b);
	void RemoveById(int param_00008a4c);
	void Clear(bool param_00008a4d);
	int SetEnabledByCategory(bool param_00008a4e, int param_00008a4f);
	bool ContainsMapInCategory(int param_00008a50);
	ControllerMap GetMap(int param_00008a51);
	ControllerMap GetMap(int param_00008a52, int param_00008a53);
	ControllerMap GetMapByCategory(int param_00008a54);
	int GetMaps(List<ControllerMap> param_00008a55, bool param_00008a56);
}

