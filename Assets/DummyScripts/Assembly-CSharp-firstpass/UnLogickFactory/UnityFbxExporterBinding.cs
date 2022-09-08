/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnLogickFactory
{
	public static class UnityFbxExporterBinding // TypeDefIndex: 10137
	{
		// Fields
		private static Vector3 rotAdjust; // 0x00
		public static Vector3 posAdjust; // 0x0C
		private static Vector3 scaleAdjust; // 0x18
		public static Vector3 posOffset; // 0x24
		private const string dllFilenameBase = "UnityFbxExporter"; // Metadata: 0x00AE7022
		private const string dllVersion = "14"; // Metadata: 0x00AE7036
		private const string dllExtension = "dll"; // Metadata: 0x00AE703C
		private static IntPtr exportSceneDll; // 0x30
		public static VoidVoid Create; // 0x38
		public static VoidVoid Destroy; // 0x40
		public static BoolStringInt Save; // 0x48
		public static IntPtrStringIntPtr MeshCreate; // 0x50
		public static VoidLogCallback LogFbxFormats; // 0x58
		public static IntVoid FormatsCount; // 0x60
		public static VoidIntLogCallback GetFormat; // 0x68
		public static BoolInt IsFormatFbx; // 0x70
		public static IntPtrIntPtr MeshGetNode; // 0x78
		public static IntPtrIntPtrDoubleArrayInt MeshSetVertices; // 0x80
		public static VoidIntPtrDoubleArrayInt MeshSetNormals; // 0x88
		public static VoidIntPtrDoubleArrayInt MeshSetColors; // 0x90
		public static VoidIntPtrIntIntArrayInt MeshAddTriangles; // 0x98
		public static IntPtrStringStringETextureUseEAlphaSource CreateTexture; // 0xA0
		public static IntPtrStringDouble3 CreatePhongMaterial; // 0xA8
		public static VoidIntPtrIntPtrTextureChannels MaterialSetTexture; // 0xB0
		public static VoidIntPtrIntPtr MeshAddMaterial; // 0xB8
		public static VoidIntPtrDoubleArrayIntString MeshSetUV; // 0xC0
		public static IntPtrIntPtrString CreateNode; // 0xC8
		public static VoidIntPtr MakeNodeSkeleton; // 0xD0
		public static IntPtrString SkeletonCreateRoot; // 0xD8
		public static IntPtrIntPtrString SkeletonCreateLimb; // 0xE0
		public static VoidIntPtrDouble3x3 NodeSetLocal; // 0xE8
		public static IntPtrIntPtr MeshCreateSkin; // 0xF0
		public static IntPtrIntPtr ClusterCreate; // 0xF8
		public static IntPtrIntPtr3Double3x3 SkinAddCluster; // 0x100
		public static VoidIntPtrIntDouble ClusterAddWeight; // 0x108
		public static VoidIntPtr MeshStoreBindPose; // 0x110
		public static VoidStringIntPtrArrayDoubleArrayInt MeshSetBindPose; // 0x118
		public static VoidIntPtrDoubleArray ClusterSetLinkMatrix; // 0x120
		public static VoidIntPtrDouble3 NodeSetPreRotation; // 0x128
		public static VoidIntPtr UpdateTransformation; // 0x130
		public static IntPtrVoid CreateBindPose; // 0x138
		public static VoidIntPtrIntPtrDouble16 AddBoneToPose; // 0x140
		public static BoolIntPtr6DoubleIntPtr IsValidBindPoseVerbose; // 0x148
		public static IntPtrVoid FbxStatusCreate; // 0x150
		public static IntPtrVoid NodeListCreate; // 0x158
		public static IntIntPtr NodeListSize; // 0x160
		public static IntPtrIntPtrInt NodeListGetAt; // 0x168
		public static StringIntPtr NodeGetName; // 0x170
		public static StringIntPtr PoseGetClassId; // 0x178
		public static StringIntPtr NodeGetClassId; // 0x180
		public static VoidIntPtrStringDouble4 SetColorProperty; // 0x188
		public static VoidIntPtrStringDouble4 SetDouble4Property; // 0x190
		public static VoidIntPtrStringDouble3 SetDouble3Property; // 0x198
		public static VoidIntPtrStringDouble2 SetDouble2Property; // 0x1A0
		public static VoidIntPtrStringMatrix SetMatrixProperty; // 0x1A8
		public static VoidIntPtrStringDouble SetDoubleProperty; // 0x1B0
		public static VoidIntPtrStringBool SetBoolProperty; // 0x1B8
		public static VoidIntPtrStringLong SetLongProperty; // 0x1C0
		public static VoidIntPtrStringString SetStringProperty; // 0x1C8
		public static IntPtrStringIntPtrDoubleDoubleDouble CameraCreate; // 0x1D0
		public static IntPtrStringIntPtrETypeDoubleDoubleDoubleDoubleBoolBool LightCreate; // 0x1D8
		public static IntPtrIntPtr AddBlendShape; // 0x1E0
		public static IntPtrStringIntPtr AddBlendChannel; // 0x1E8
		public static IntPtrStringIntPtrDouble AddBlendFrame; // 0x1F0
		public static SkinnedMeshRenderer blendSmr; // 0x1F8
		public static Mesh blendMesh; // 0x200
	
		// Nested types
		private static class NativeMethods // TypeDefIndex: 10138
		{
			// Methods
			public static extern IntPtr LoadLibrary(string dllToLoad); // 0x0000000186EA6550-0x0000000186EA6660
			public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName); // 0x0000000186EA6440-0x0000000186EA6550
			public static extern bool FreeLibrary(IntPtr hModule); // 0x0000000186EA6350-0x0000000186EA6440
		}
	
		public delegate void LogCallback(string msg); // TypeDefIndex: 10139; 0x0000000186EA52F0-0x0000000186EA5550
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate int IntVoid(); // TypeDefIndex: 10140; 0x0000000186EA4560-0x0000000186EA46D0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate string StringInt(int value); // TypeDefIndex: 10141; 0x0000000186EA77F0-0x0000000186EA7980
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate bool BoolInt(int value); // TypeDefIndex: 10142; 0x00000001862A0320-0x00000001862A04B0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidLogCallback(LogCallback msg); // TypeDefIndex: 10143; 0x0000000186EB0780-0x0000000186EB09E0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntLogCallback(int index, LogCallback msg); // TypeDefIndex: 10144; 0x0000000186EAADB0-0x0000000186EAAF70
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidVoid(); // TypeDefIndex: 10145; 0x0000000186EB1060-0x0000000186EB11C0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate bool BoolString(string value); // TypeDefIndex: 10146; 0x00000001862A0AD0-0x00000001862A0D30
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate bool BoolStringInt(string arg0, int arg1); // TypeDefIndex: 10147; 0x00000001862A0670-0x00000001862A0920
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate IntPtr IntPtrString(string value); // TypeDefIndex: 10148; 0x0000000186EA3D50-0x0000000186EA3FB0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate IntPtr IntPtrStringDouble3(string value, double r, double g, double b); // TypeDefIndex: 10149; 0x0000000186EA1C20-0x0000000186EA1F90
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate IntPtr IntPtrStringIntPtrDoubleDoubleDouble(string value, IntPtr node, double nearPlane, double farPlane, double fieldOfView); // TypeDefIndex: 10150; 0x0000000186EA21B0-0x0000000186EA2560
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate IntPtr IntPtrStringIntPtrETypeDoubleDoubleDoubleDoubleBoolBool(string value, IntPtr node, EType lightType, double r, double g, double b, double intensity, bool enabled, bool shadows); // TypeDefIndex: 10151; 0x0000000186EA2C90-0x0000000186EA3200
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate IntPtr IntPtrStringIntPtr(string arg0, IntPtr arg1); // TypeDefIndex: 10152; 0x0000000186EA33C0-0x0000000186EA3670
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate IntPtr IntPtrStringIntPtrDouble(string arg0, IntPtr arg1, double arg2); // TypeDefIndex: 10153; 0x0000000186EA2740-0x0000000186EA2A40
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate IntPtr IntPtrVoid(LogCallback logCallback); // TypeDefIndex: 10154; 0x0000000186EA4160-0x0000000186EA43C0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate IntPtr IntPtrIntPtr(IntPtr value); // TypeDefIndex: 10155; 0x0000000186EA1890-0x0000000186EA1A20
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate IntPtr IntPtrIntPtrDoubleArrayInt(IntPtr arg0, double[] arg1, int arg2); // TypeDefIndex: 10156; 0x0000000186EA0DE0-0x0000000186EA0FC0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrDoubleArrayInt(IntPtr arg0, double[] arg1, int arg2); // TypeDefIndex: 10157; 0x0000000186EABF90-0x0000000186EAC160
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrIntIntArrayInt(IntPtr arg0, int arg1, int[] arg2, int arg3); // TypeDefIndex: 10158; 0x0000000186EACA70-0x0000000186EACCB0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate IntPtr IntPtrStringStringETextureUseEAlphaSource(string arg0, string arg1, ETextureUse arg2, EAlphaSource arg3); // TypeDefIndex: 10159; 0x0000000186EA3850-0x0000000186EA3BA0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrIntPtrTextureChannels(IntPtr arg0, IntPtr arg1, TextureChannels arg2); // TypeDefIndex: 10160; 0x0000000186EAD850-0x0000000186EADA20
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrIntPtr(IntPtr arg0, IntPtr arg1); // TypeDefIndex: 10161; 0x0000000186EADBD0-0x0000000186EADD90
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrDoubleArrayIntString(IntPtr arg0, double[] arg1, int arg2, string arg3); // TypeDefIndex: 10162; 0x0000000186EABB90-0x0000000186EABDD0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate IntPtr IntPtrIntPtrString(IntPtr arg0, string arg1); // TypeDefIndex: 10163; 0x0000000186EA1520-0x0000000186EA16E0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrDouble3x3(IntPtr node, double rot_x, double rot_y, double rot_z, double pos_x, double pos_y, double pos_z, double scale_x, double scale_y, double scale_z); // TypeDefIndex: 10164; 0x0000000186EAB600-0x0000000186EAB9C0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate IntPtr IntPtrIntPtr3(IntPtr arg0, IntPtr arg1, IntPtr arg2); // TypeDefIndex: 10165; 0x0000000186EA0A20-0x0000000186EA0C00
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate IntPtr IntPtrIntPtr3Double3x3(IntPtr arg0, IntPtr arg1, IntPtr arg2, double rot_x, double rot_y, double rot_z, double pos_x, double pos_y, double pos_z, double scale_x, double scale_y, double scale_z); // TypeDefIndex: 10166; 0x0000000186EA03F0-0x0000000186EA0830
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrIntDouble(IntPtr arg0, int arg1, double arg2); // TypeDefIndex: 10167; 0x0000000186EAC6A0-0x0000000186EAC890
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtr(IntPtr arg0); // TypeDefIndex: 10168; 0x0000000186EB0460-0x0000000186EB05F0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidStringIntPtrArrayDoubleArrayInt(string arg0, IntPtr[] arg1, double[] arg2, int arg3); // TypeDefIndex: 10169; 0x0000000186EB0B90-0x0000000186EB0EE0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrDoubleArray(IntPtr cluster, double[] matrix); // TypeDefIndex: 10170; 0x0000000186EAC310-0x0000000186EAC4D0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrDouble3(IntPtr arg0, double arg1, double arg2, double arg3); // TypeDefIndex: 10171; 0x0000000186EAB160-0x0000000186EAB3B0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrIntPtrDouble16(IntPtr arg0, IntPtr arg1, double p00, double p10, double p20, double p30, double p01, double p11, double p21, double p31, double p02, double p12, double p22, double p32, double p03, double p13, double p23, double p33); // TypeDefIndex: 10172; 0x0000000186EACFC0-0x0000000186EAD680
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate bool BoolIntPtr6DoubleIntPtr(IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, double arg6, IntPtr arg7, LogCallback logCallback); // TypeDefIndex: 10173; 0x000000018629FDB0-0x00000001862A0170
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate int IntIntPtr(IntPtr arg0); // TypeDefIndex: 10174; 0x0000000186E9FFC0-0x0000000186EA0150
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate IntPtr IntPtrIntPtrInt(IntPtr arg0, int arg1); // TypeDefIndex: 10175; 0x0000000186EA1190-0x0000000186EA1350
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate string StringIntPtr(IntPtr arg0); // TypeDefIndex: 10176; 0x0000000186EA74C0-0x0000000186EA7650
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrStringDouble4(IntPtr arg0, string arg1, double arg2, double arg3, double arg4, double arg5); // TypeDefIndex: 10177; 0x0000000186EAEB90-0x0000000186EAEE30
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrStringDouble3(IntPtr arg0, string arg1, double arg2, double arg3, double arg4); // TypeDefIndex: 10178; 0x0000000186EAE730-0x0000000186EAE9A0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrStringDouble2(IntPtr arg0, string arg1, double arg2, double arg3); // TypeDefIndex: 10179; 0x0000000186EAE310-0x0000000186EAE530
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrStringDouble(IntPtr arg0, string arg1, double arg2); // TypeDefIndex: 10180; 0x0000000186EAEFF0-0x0000000186EAF1E0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrStringBool(IntPtr arg0, string arg1, bool arg2); // TypeDefIndex: 10181; 0x0000000186EADF50-0x0000000186EAE130
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrStringLong(IntPtr arg0, string arg1, long arg2); // TypeDefIndex: 10182; 0x0000000186EAF3A0-0x0000000186EAF580
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrStringMatrix(IntPtr arg0, string arg1, double p00, double p10, double p20, double p30, double p01, double p11, double p21, double p31, double p02, double p12, double p22, double p32, double p03, double p13, double p23, double p33); // TypeDefIndex: 10183; 0x0000000186EAF880-0x0000000186EAFF40
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void VoidIntPtrStringString(IntPtr arg0, string arg1, string arg2); // TypeDefIndex: 10184; 0x0000000186EB00F0-0x0000000186EB02D0
	
		public enum EType // TypeDefIndex: 10185
		{
			ePoint = 0,
			eDirectional = 1,
			eSpot = 2,
			eArea = 3,
			eVolume = 4
		}
	
		public enum ETextureUse // TypeDefIndex: 10186
		{
			eStandard = 0,
			eShadowMap = 1,
			eLightMap = 2,
			eSphericalReflectionMap = 3,
			eSphereReflectionMap = 4,
			eBumpNormalMap = 5
		}
	
		public enum EAlphaSource // TypeDefIndex: 10187
		{
			eNone = 0,
			eRGBIntensity = 1,
			eBlack = 2
		}
	
		public enum TextureChannels // TypeDefIndex: 10188
		{
			Diffuse = 0,
			Emissive = 1,
			Ambient = 2,
			NormalMap = 3,
			BumpMap = 4,
			TransparentColor = 5,
			Shininess = 6,
			Specular = 7,
			Reflection = 8
		}
	
		// Constructors
		static UnityFbxExporterBinding() {} // 0x00000001862BA650-0x00000001862BA770
	
		// Methods
		// [XID] // 0x0000000189791630-0x0000000189791650
		public static string GetDLLPath(int logLevel = 0 /* Metadata: 0x00AE701A */) => default; // 0x00000001862B59F0-0x00000001862B5DF0
		// [XID] // 0x0000000189798D10-0x0000000189798D30
		public static bool Init(int logLevel = 0 /* Metadata: 0x00AE701E */) => default; // 0x00000001862B5DF0-0x00000001862B6B30
		// [XID] // 0x00000001897A0B70-0x00000001897A0B90
		private static IntPtr LoadLibrary(string path) => default; // 0x00000001862B6B30-0x00000001862B6BF0
		private static void SetupMethod<T>(string methodName, ref T methodDelegate)
			where T : class {}
		// [XID] // 0x00000001897A8250-0x00000001897A8270
		public static void Close() {} // 0x00000001862B5330-0x00000001862B53C0
		// [IDTag] // 0x00000001897AFD30-0x00000001897AFD70
		// [XID] // 0x00000001897AFD30-0x00000001897AFD70
		public static IntPtr ProcessMesh(Mesh sourceMesh, UnityEngine.Material[] materials, IntPtr node) => default; // 0x00000001862B7520-0x00000001862B7660
		// [IDTag] // 0x00000001897BA840-0x00000001897BA880
		// [XID] // 0x00000001897BA840-0x00000001897BA880
		public static IntPtr ProcessMesh(Mesh sourceMesh, UnityEngine.Material[] materials) => default; // 0x00000001862B7660-0x00000001862B7790
		// [IDTag] // 0x00000001897C58D0-0x00000001897C5910
		// [XID] // 0x00000001897C58D0-0x00000001897C5910
		public static IntPtr ProcessMesh(Mesh sourceMesh, int logLevel, UnityEngine.Material[] materials, Vector3[] overrideVertices, Vector3[] overrideNormals, IntPtr node, Dictionary<UnityEngine.Material, IntPtr> KnownMaterials) => default; // 0x00000001862B8E00-0x00000001862B8F90
		// [IDTag] // 0x00000001897CFED0-0x00000001897CFF10
		// [XID] // 0x00000001897CFED0-0x00000001897CFF10
		public static IntPtr ProcessMesh(Mesh sourceMesh, int logLevel, UnityEngine.Material[] materials, Vector3[] overrideVertices, Vector3[] overrideNormals, IntPtr node, Dictionary<UnityEngine.Material, IntPtr> KnownMaterials, out IntPtr[] fbxMaterials, out IntPtr[][] fbxTextures) {
			fbxMaterials = default;
			fbxTextures = default;
			return default;
		} // 0x00000001862B7790-0x00000001862B8E00
		// [XID] // 0x00000001897DAAF0-0x00000001897DAB10
		public static IntPtr ProcessTerrain(Terrain terrain, TerrainData terrainData, int terrainQuality, IntPtr node, out IntPtr material, out IntPtr[] textures) {
			material = default;
			textures = default;
			return default;
		} // 0x00000001862B8F90-0x00000001862B9BB0
		// [XID] // 0x000000018994AAA0-0x000000018994AAC0
		private static void FlipTriangles(int[] triangles) {} // 0x00000001862B58B0-0x00000001862B59F0
		// [XID] // 0x0000000189B4FB10-0x0000000189B4FB30
		private static IntPtr AddTextureToMaterial(IntPtr material, UnityEngine.Material mat, string shaderName, TextureChannels channel, ETextureUse textureUse, int logLevel) => default; // 0x00000001862B4980-0x00000001862B4D00
		// [IDTag] // 0x00000001897F13C0-0x00000001897F1400
		// [XID] // 0x00000001897F13C0-0x00000001897F1400
		private static void CopyVectorsToDoubles(double[] dest, Vector3[] source) {} // 0x00000001862B5640-0x00000001862B5780
		// [XID] // 0x0000000189B1B850-0x0000000189B1B870
		private static void CopyPointsToDoubles(double[] dest, Vector3[] source) {} // 0x00000001862B5500-0x00000001862B5640
		// [XID] // 0x0000000189B2A440-0x0000000189B2A460
		private static void CopyColorsToDoubles(double[] dest, Color[] source) {} // 0x00000001862B53C0-0x00000001862B5500
		// [IDTag] // 0x000000018980A700-0x000000018980A740
		// [XID] // 0x000000018980A700-0x000000018980A740
		private static void CopyVectorsToDoubles(double[] dest, Vector2[] source) {} // 0x00000001862B5780-0x00000001862B58B0
		// [XID] // 0x0000000189619B70-0x0000000189619B90
		private static void AddVector3ToArray(double[] doubleData, ref Vector3 vector, ref int index) {} // 0x00000001862B4E20-0x00000001862B4F70
		// [XID] // 0x000000018981C740-0x000000018981C760
		private static void AddPoint3ToArray(double[] doubleData, ref Vector3 vector, ref int index) {} // 0x00000001862B4820-0x00000001862B4980
		// [XID] // 0x0000000189B31960-0x0000000189B31980
		private static void AddColorToArray(double[] doubleData, ref Color color, ref int index) {} // 0x00000001862B46A0-0x00000001862B4820
		// [XID] // 0x0000000189B409B0-0x0000000189B409D0
		private static void AddVector2ToArray(double[] doubleData, ref Vector2 vector, ref int index) {} // 0x00000001862B4D00-0x00000001862B4E20
		// [XID] // 0x0000000189832AA0-0x0000000189832AC0
		public static FbxExportCollection ScanHierarchy(Transform rootBone, bool createRoot, FbxExportSettings settings) => default; // 0x00000001862BA2C0-0x00000001862BA650
		// [XID] // 0x0000000189A5ADA0-0x0000000189A5ADC0
		private static void RecursiveAddTransforms(Transform bone, IntPtr fbxBone, FbxExportCollection result, bool rootLevel, FbxExportSettings settings, bool belowLODGroup) {} // 0x00000001862B9BB0-0x00000001862BA2C0
		// [XID] // 0x0000000189724590-0x00000001897245B0
		private static void AddBoneWeight(ref BoneWeight boneWeight, IntPtr[] fbxClusters, int boneWeightIndex) {} // 0x00000001862B41E0-0x00000001862B4570
		// [XID] // 0x000000018971D1B0-0x000000018971D1D0
		public static void AddBoneWeights(BoneWeight[] boneWeights, IntPtr[] fbxClusters) {} // 0x00000001862B4570-0x00000001862B46A0
		// [XID] // 0x0000000189850320-0x0000000189850340
		public static void NodeSetTransform(IntPtr node, Transform transform, bool rootLevel) {} // 0x00000001862B7070-0x00000001862B7520
		// [XID] // 0x0000000189BB9520-0x0000000189BB9540
		public static void NodeSetTerrainTransform(IntPtr node, Transform transform) {} // 0x00000001862B6BF0-0x00000001862B7070
		// [XID] // 0x000000018985E7D0-0x000000018985E7F0
		public static void CameraSetTransform(IntPtr node, Transform transform, bool rootLevel) {} // 0x00000001862B4F70-0x00000001862B5330
	}
}
