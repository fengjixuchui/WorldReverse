/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using MoleMole;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class RuntimeAnimAssetDataManager // TypeDefIndex: 8554
{
	// Fields
	private static Dictionary<ulong, RuntimeAnimAssetData> _assetMap; // 0x00

	// Constructors
	public RuntimeAnimAssetDataManager() {} // 0x00000001868E1670-0x00000001868E16D0
	static RuntimeAnimAssetDataManager() {} // 0x00000001868E1610-0x00000001868E1670

	// Methods
	public static void Init() {} // 0x00000001868E1130-0x00000001868E11E0
	public static void Destroy() {} // 0x00000001868E0EB0-0x00000001868E1130
	public static int NameStringSuffixToInt(string inStr) => default; // 0x00000001868E14A0-0x00000001868E1560
	public static AsyncJob LoadAssetDataAsync(string animAssetPath, Action<bool, RuntimeAnimAssetData> onLoadFinished) => default; // 0x00000001868E11E0-0x00000001868E14A0
	internal static void RemoveAsset(ulong assetHash) {} // 0x00000001868E1560-0x00000001868E1610
}

