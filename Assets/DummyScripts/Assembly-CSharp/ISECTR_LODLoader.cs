/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface ISECTR_LODLoader : ISECTR_BaseLoader // TypeDefIndex: 31934
{
	// Methods
	void SelectLOD(Vector3 pos, SECTR_ThreadContext context, bool bFromUnityThread);
	void ForceActiveLOD(int lod, SECTR_ThreadContext context, bool bFromUnityThread);
	void RefreshLODPattern();
	uint GetGroupId();
	Vector3 GetObjectPos();
}

