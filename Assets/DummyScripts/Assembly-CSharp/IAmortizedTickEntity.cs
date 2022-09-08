/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IAmortizedTickEntity // TypeDefIndex: 20810
{
	// Properties
	float lastTickTime { get; set; }

	// Methods
	void AmortizedTick(float inDeltaTime, List<BaseEntity> onSafeReadyEntitiesList, int sharedInitComponentWatch);
	bool Destroy(SliceFrameWatch watch);
	string ToString();
}

