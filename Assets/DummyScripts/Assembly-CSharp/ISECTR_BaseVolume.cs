/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface ISECTR_BaseVolume // TypeDefIndex: 31869
{
	// Methods
	bool InvalidInLoading();
	bool IsPosInVolume(Vector3 pos);
	bool FilterLod(ISECTR_LODLoader lod, SECTR_BaseVolume.LODType type);
	bool FilterLayer(SECTR_BaseLayerProxy proxy);
	bool RemoveLayer(SECTR_BaseLayerProxy proxy);
	bool ShouldFilterStreamPos();
	void ActiveVolume();
	void DeactiveVolume();
	bool ValidToUpdate(Vector3 pos);
	void Load();
	void Unload();
	Vector3 FilterStreamPos(Vector3 pos);
}

