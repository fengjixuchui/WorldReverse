/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[CreateAssetMenu] // 0x0000000189672990-0x00000001896729D0
public sealed class SECTR_SceneSplitterConfig : ScriptableObjectUseFiEdit // TypeDefIndex: 31903
{
	// Fields
	public string folderName; // 0x18
	public string finalSectorName; // 0x20
	public SplitType type; // 0x28
	public List<SECTR_LayerConfig> layerConfigs; // 0x30
	public SECTR_LayerConfig colliderLayerConfig; // 0x38
	public List<SECTR_LayerLodThreshold> thresholdConfigs; // 0x40
	public float defaultHlodDis; // 0x48
	public List<string> objBlackList; // 0x50

	// Nested types
	public enum SplitType // TypeDefIndex: 31904
	{
		BigWorld = 0,
		Dungeon = 1,
		Home = 2
	}

	// Constructors
	public SECTR_SceneSplitterConfig() {} // 0x0000000181B5A010-0x0000000181B5A100

	// Methods
	public List<string> GetCityNameFromIndex(int x, int y) => default; // 0x0000000181B59C30-0x0000000181B59D70
	public List<SECTR_LayerConfig> SortConfigs() => default; // 0x0000000181B59E90-0x0000000181B59F80
	public void AddNewLayer() {} // 0x0000000181B59A20-0x0000000181B59B30
	public void RemoveLayer(SECTR_LayerConfig layer) {} // 0x0000000181B59D70-0x0000000181B59E00
	public void AddNewThreshold() {} // 0x0000000181B59B30-0x0000000181B59C30
	public void RemoveThreshold(SECTR_LayerLodThreshold config) {} // 0x0000000181B59E00-0x0000000181B59E90
}

