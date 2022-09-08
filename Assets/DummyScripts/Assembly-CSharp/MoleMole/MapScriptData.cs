/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x0000000189626330-0x0000000189626380
	public sealed class MapScriptData : ScriptableObjectUseFiEdit // TypeDefIndex: 19593
	{
		// Fields
		public Rect LevelRect; // 0x18
		public string MapImagePath; // 0x28
		public string PointCfgPath; // 0x30
		public string levelAreaCfgPath; // 0x38
		public string worldAreaCfgPath; // 0x40
		public string MiniMapImagePath; // 0x48
		public string GlobalMapImagePath; // 0x50
		public MapSubAreaCell[] MapSubAreaInfos; // 0x58
		[NonSerialized]
		private Dictionary<uint, Texture2D> _mapSubAreaInfoDic; // 0x60
	
		// Nested types
		[Serializable]
		public class MapSubAreaCell // TypeDefIndex: 19594
		{
			// Fields
			public uint AreaID; // 0x10
			public Texture2D MapSubAreaInfo; // 0x18
	
			// Constructors
			public MapSubAreaCell() {} // 0x0000000184F1B1A0-0x0000000184F1B210
		}
	
		// Constructors
		public MapScriptData() {} // 0x0000000184F1B0F0-0x0000000184F1B1A0
	
		// Methods
		// [XID] // 0x000000018962F4E0-0x000000018962F500
		private void CreateSubMapDic() {} // 0x0000000184F1AF70-0x0000000184F1B0F0
		// [XID] // 0x0000000189636FA0-0x0000000189636FC0
		public Texture2D GetSubAreaInfoMap(uint areaID_1) => default; // 0x0000000184F1AE80-0x0000000184F1AF70
	}
}
