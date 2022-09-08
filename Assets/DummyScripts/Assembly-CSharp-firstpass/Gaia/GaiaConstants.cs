/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	public static class GaiaConstants // TypeDefIndex: 9190
	{
		// Fields
		public static string GaiaMajorVersion; // 0x00
		public static string GaiaMinorVersion; // 0x08
		public static readonly string AssetDir; // 0x10
		public static readonly string AssetDirFromAssetDB; // 0x18
		public static string[] JobStatusStr; // 0x20
		public static float VirginTerrainCheckThreshold; // 0x28
		public const TextureFormat defaultTextureFormat = TextureFormat.RGBA32; // Metadata: 0x00AE5490
		public const TextureFormat fmtHmTextureFormat = TextureFormat.RGBA32; // Metadata: 0x00AE5494
		public const TextureFormat fmtRGBA32 = TextureFormat.RGBA32; // Metadata: 0x00AE5498
		public const StorageFormat defaultImageStorageFormat = StorageFormat.PNG; // Metadata: 0x00AE549C
		public const ImageChannel defaultImageStorageChannel = ImageChannel.R; // Metadata: 0x00AE54A0
	
		// Nested types
		public enum TargetPlatform // TypeDefIndex: 9191
		{
			ModernDestop = 0,
			Desktop = 1,
			Mobile = 2,
			VirtualReality = 3
		}
	
		public enum TargetCameraStyle // TypeDefIndex: 9192
		{
			FirstPerson = 0,
			TopDown = 1,
			Flying = 2
		}
	
		public enum TargetTerrainSize // TypeDefIndex: 9193
		{
			Meters_256 = 0,
			Meters_512 = 1,
			Kilometers_1 = 2,
			Kilometers_2 = 3,
			Kilometers_3 = 4,
			Kilometers_5 = 5,
			Kilometers_10 = 6,
			Kilometers_15 = 7,
			Kilometers_20 = 8
		}
	
		public enum JobStatus // TypeDefIndex: 9194
		{
			Idle = 0,
			Queued = 1,
			Started = 2,
			CompletedCancelled = 3,
			CompletedError = 4,
			Completed = 5
		}
	
		public enum ManagerEditorMode // TypeDefIndex: 9195
		{
			Standard = 0,
			Advanced = 1,
			Utilities = 2,
			Extensions = 3
		}
	
		public enum OperationMode // TypeDefIndex: 9196
		{
			DesignTime = 0,
			RuntimeInterval = 1,
			RuntimeTriggeredInterval = 2
		}
	
		public enum NoiseType // TypeDefIndex: 9197
		{
			None = 0,
			Perlin = 1,
			Billow = 2,
			Ridged = 3
		}
	
		public enum ImageFitnessFilterMode // TypeDefIndex: 9198
		{
			None = 0,
			ImageGreyScale = 1,
			ImageRedChannel = 2,
			ImageGreenChannel = 3,
			ImageBlueChannel = 4,
			ImageAlphaChannel = 5,
			TerrainTexture0 = 6,
			TerrainTexture1 = 7,
			TerrainTexture2 = 8,
			TerrainTexture3 = 9,
			TerrainTexture4 = 10,
			TerrainTexture5 = 11,
			TerrainTexture6 = 12,
			TerrainTexture7 = 13,
			PerlinNoise = 14,
			BillowNoise = 15,
			RidgedNoise = 16
		}
	
		public enum FeatureType // TypeDefIndex: 9199
		{
			Adhoc = 0,
			Bases = 1,
			Hills = 2,
			Islands = 3,
			Lakes = 4,
			Mesas = 5,
			Mountains = 6,
			Plains = 7,
			Rivers = 8,
			Rocks = 9,
			Valleys = 10,
			Villages = 11,
			Waterfalls = 12
		}
	
		public enum GeneratorBorderStyle // TypeDefIndex: 9200
		{
			None = 0,
			Mountains = 1,
			Water = 2
		}
	
		public enum FeatureSource // TypeDefIndex: 9201
		{
			Stamp = 0,
			SimplexNoise = 1,
			BillowNoise = 2,
			RidgedNoise = 3,
			DerivedIQ = 4,
			DerivedSwiss = 5,
			DerivedJordan = 6,
			CellNoise = 7,
			MultiFractal = 8
		}
	
		public enum FeatureOperation // TypeDefIndex: 9202
		{
			RaiseHeight = 0,
			LowerHeight = 1,
			BlendHeight = 2,
			StencilHeight = 3,
			DifferenceHeight = 4
		}
	
		public enum FeatureOperationType // TypeDefIndex: 9203
		{
			PreviewStamp = 0,
			ApplyStamp = 1,
			ApplyStampPre = 2,
			ApplyStampPost = 3
		}
	
		public enum OperationType // TypeDefIndex: 9204
		{
			Add = 0,
			Subtract = 1,
			Multiply = 2,
			Divide = 3
		}
	
		public enum GaiaResolution // TypeDefIndex: 9205
		{
			Resolution_64 = 0,
			Resolution_128 = 1,
			Resolution_256 = 2,
			Resolution_512 = 3,
			Resolution_1024 = 4,
			Resolution_2048 = 5,
			Resolution_4096 = 6,
			Resolution_8192 = 7
		}
	
		public enum GaiaHeightmapResolution // TypeDefIndex: 9206
		{
			Resolution_65 = 0,
			Resolution_129 = 1,
			Resolution_257 = 2,
			Resolution_513 = 3,
			Resolution_1025 = 4,
			Resolution_2049 = 5,
			Resolution_Custom = 6
		}
	
		public enum SpawnerShape // TypeDefIndex: 9207
		{
			Box = 0,
			Sphere = 1
		}
	
		public enum SpawnerLocation // TypeDefIndex: 9208
		{
			RandomLocation = 0,
			RandomLocationClustered = 1,
			EveryLocation = 2,
			EveryLocationJittered = 3
		}
	
		public enum SpawnerLocationCheckType // TypeDefIndex: 9209
		{
			PointCheck = 0,
			BoundedAreaCheck = 1
		}
	
		public enum SpawnerRuleSelector // TypeDefIndex: 9210
		{
			All = 0,
			Fittest = 1,
			WeightedFittest = 2,
			Random = 3
		}
	
		public enum SpawnerResourceType // TypeDefIndex: 9211
		{
			TerrainTexture = 0,
			TerrainDetail = 1,
			TerrainTree = 2,
			GameObject = 3
		}
	
		public enum StorageFormat // TypeDefIndex: 9212
		{
			PNG = 0,
			JPG = 1
		}
	
		public enum ImageChannel // TypeDefIndex: 9213
		{
			R = 0,
			G = 1,
			B = 2,
			A = 3
		}
	
		public enum ImageChannelWithNone // TypeDefIndex: 9214
		{
			None = 0,
			R = 1,
			G = 2,
			B = 3,
			A = 4
		}
	
		// Constructors
		static GaiaConstants() {} // 0x000000018658ADF0-0x000000018658B0F0
	}
}
