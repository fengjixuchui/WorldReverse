/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoHomeworldSetting : MonoBehaviour // TypeDefIndex: 20397
	{
		// Fields
		public MonoHomeworldEnvironmentSetting[] blocks; // 0x18
		public GameObject[] doors; // 0x20
		public GameObject[] stairs; // 0x28
		public FurnitureDataInternal[] doorData; // 0x30
		public FurnitureDataInternal[] stairData; // 0x38
		public WeekendDjinnConfig[] weekendDjinnSpawnPoints; // 0x40
		public HomeworldModuleInteriorEnvConfig[] envConfigs; // 0x48
		protected bool _initliazed; // 0x50
		protected HomeworldManager _homeManager; // 0x58
	
		// Constructors
		public MonoHomeworldSetting() {} // 0x00000001846FA6C0-0x00000001846FA730
	
		// Methods
		// [XID] // 0x00000001899C0EF0-0x00000001899C0F10
		private void OnEnable() {} // 0x00000001846F9C20-0x00000001846F9E40
		// [XID] // 0x00000001899C84B0-0x00000001899C84D0
		public void SetAllGlobalDoorActive(bool active) {} // 0x00000001846F9E40-0x00000001846FA000
		// [XID] // 0x00000001899CFF10-0x00000001899CFF30
		public void SetAllGlobalStairActive(bool active) {} // 0x00000001846FA000-0x00000001846FA1C0
		// [XID] // 0x00000001899D7430-0x00000001899D7450
		public void SetGlobalDoorActive(bool active, int index) {} // 0x00000001846FA1C0-0x00000001846FA380
		// [XID] // 0x00000001899DE7D0-0x00000001899DE7F0
		public void SetGlobalStairActive(bool active, int index) {} // 0x00000001846FA500-0x00000001846FA6C0
		// [XID] // 0x00000001899E64D0-0x00000001899E64F0
		public void SetGlobalEntity(FurnitureDeploySurfaceType type, int slot, FurnitureDataInternal furnitureData, out FurnitureDataInternal replaceFurnitureData) {
			replaceFurnitureData = default;
		} // 0x00000001846FA380-0x00000001846FA500
		// [XID] // 0x00000001899EDA20-0x00000001899EDA40
		public Transform GetGlobalFurnitureTransform(FurnitureDeploySurfaceType type, int index) => default; // 0x00000001846F99B0-0x00000001846F9AD0
		// [XID] // 0x00000001899F5430-0x00000001899F5450
		public FurnitureDataInternal GetGlobalFurnitureDataInternal(FurnitureDeploySurfaceType type) => default; // 0x00000001846F98C0-0x00000001846F99B0
		// [XID] // 0x00000001899FCA90-0x00000001899FCAB0
		public int GetStairIndexByGameObject(GameObject stairObj) => default; // 0x00000001846F9AD0-0x00000001846F9C20
		// [XID] // 0x0000000189A03F80-0x0000000189A03FA0
		public int GetDoorIndexByGameObject(GameObject doorObj) => default; // 0x00000001846F9770-0x00000001846F98C0
	}
}
