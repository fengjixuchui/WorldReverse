/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnLogickFactory
{
	public class FbxExportSettings // TypeDefIndex: 10117
	{
		// Fields
		public FbxLODScheme LODScheme; // 0x10
		public int logLevel; // 0x18
		public FbxTextureExportScheme textureScheme; // 0x20
		public int formatId; // 0x28
		public int terrainQuality; // 0x2C
		public SkinnedMeshOptions skinnedMeshOptions; // 0x30
		public ObjectExportMask objectExportMask; // 0x34
		public FbxNodeCallback OnFbxNodeCreated; // 0x38
		public FbxMeshCallback OnFbxMeshCreated; // 0x40
		public FbxSkinnedMeshCallback OnFbxSkinnedMeshCreated; // 0x48
		public FbxTerrainCallback OnFbxTerrainCreated; // 0x50
		public FbxMaterialCallback OnFbxMaterialCreated; // 0x58
	
		// Properties
		public bool ExportCloth { /* [XID] */ /* 0x0000000189B06C70-0x0000000189B06C90 */ get => default; } // 0x00000001862A2D90-0x00000001862A2E40 
		public bool ExportMeshes { /* [XID] */ /* 0x0000000189A792D0-0x0000000189A792F0 */ get => default; } // 0x00000001862A2EF0-0x00000001862A2F90 
		public bool ExportSkinnedMeshes { /* [XID] */ /* 0x0000000189B15670-0x0000000189B15690 */ get => default; } // 0x00000001862A2F90-0x00000001862A3040 
		public bool ExportTerrains { /* [XID] */ /* 0x0000000189B1D110-0x0000000189B1D130 */ get => default; } // 0x00000001862A3040-0x00000001862A30F0 
		public bool ExportLights { /* [XID] */ /* 0x0000000189B246E0-0x0000000189B24700 */ get => default; } // 0x00000001862A2E40-0x00000001862A2EF0 
		public bool ExportCameras { /* [XID] */ /* 0x0000000189A97430-0x0000000189A97450 */ get => default; } // 0x00000001862A2CE0-0x00000001862A2D90 
	
		// Constructors
		public FbxExportSettings() {} // 0x00000001862A2BF0-0x00000001862A2CE0
	}
}
