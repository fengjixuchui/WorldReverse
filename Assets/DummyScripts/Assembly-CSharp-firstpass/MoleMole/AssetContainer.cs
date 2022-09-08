/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public interface AssetContainer // TypeDefIndex: 7549
	{
		// Methods
		bool HasAssetLoaded(int hash);
		void AddAssset(int hash, LoadedAsset asset);
		LoadedAsset GetAsset(int hash);
		void SetPrefabHash(ulong prefabHash);
		void Recycle();
		void Dump(StringBuilder builder);
		Dictionary<int, UnityEngine.Object> allLoadedAssets();
	}
}
