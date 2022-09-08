/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal interface IJoypadListHandlerAdapter // TypeDefIndex: 30649
{
	// Methods
	bool SelectItem(int idx);
	void DeselectItem();
	void ClickItem(int idx);
	int GetSelectedIndex();
	Transform GetSelectedItemTrans();
	int GetItemCount();
	int GetColCount();
	int GetRowCount();
	void OnAdapterFocus(bool activateObj);
	void OnAdapterLostFocus(bool activateObj);
}

