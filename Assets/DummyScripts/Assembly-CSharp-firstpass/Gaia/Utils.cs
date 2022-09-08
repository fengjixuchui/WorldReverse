/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	public class Utils : MonoBehaviour // TypeDefIndex: 9343
	{
		// Constructors
		public Utils() {} // 0x0000000185A497D0-0x0000000185A49830
	
		// Methods
		// [IDTag] // 0x0000000189B40BF0-0x0000000189B40C30
		// [XID] // 0x0000000189B40BF0-0x0000000189B40C30
		public static string GetGaiaAssetDirectory() => default; // 0x0000000185A45F30-0x0000000185A46060
		// [IDTag] // 0x0000000189B4B2E0-0x0000000189B4B320
		// [XID] // 0x0000000189B4B2E0-0x0000000189B4B320
		public static string GetGaiaAssetDirectory(GaiaConstants.FeatureType featureType) => default; // 0x0000000185A46060-0x0000000185A46200
		// [XID] // 0x0000000189B55A20-0x0000000189B55A40
		public static List<string> GetGaiaStampsList(GaiaConstants.FeatureType featureType) => default; // 0x0000000185A46730-0x0000000185A46820
		// [XID] // 0x0000000189715610-0x0000000189715630
		public static string GetGaiaAssetPath(GaiaConstants.FeatureType featureType, string assetName) => default; // 0x0000000185A46200-0x0000000185A46310
		// [XID] // 0x0000000189B64C50-0x0000000189B64C70
		public static string GetGaiaStampAssetPath(GaiaConstants.FeatureType featureType, string assetName) => default; // 0x0000000185A46440-0x0000000185A46560
		// [XID] // 0x0000000189B6C030-0x0000000189B6C050
		public static string GetGaiaStampPath(Texture2D source) => default; // 0x0000000185A46560-0x0000000185A46730
		// [XID] // 0x0000000189B12280-0x0000000189B122A0
		public static bool CheckValidGaiaStampPath(Texture2D source) => default; // 0x0000000185A43A10-0x0000000185A43C60
		// [XID] // 0x0000000189AA8120-0x0000000189AA8140
		public static void CreateGaiaAssetDirectories() {} // 0x0000000185A444B0-0x0000000185A44540
		public static T[] GetAtPath<T>(string path) => default;
		// [XID] // 0x0000000189B82780-0x0000000189B827A0
		public static void MakeTextureNormal(Texture2D texture) {} // 0x0000000185A473C0-0x0000000185A47490
		// [XID] // 0x0000000189646740-0x0000000189646760
		public static void MakeTextureReadable(Texture2D texture) {} // 0x0000000185A47490-0x0000000185A47560
		// [XID] // 0x000000018972E3F0-0x000000018972E410
		public static void CompressToSingleChannelFileImage(float[,] input, string imageName, TextureFormat imageStorageFormat = TextureFormat.RGBA32 /* Metadata: 0x00AE5768 */, bool exportPNG = true /* Metadata: 0x00AE576C */, bool exportJPG = true /* Metadata: 0x00AE576D */) {} // 0x0000000185A440A0-0x0000000185A442F0
		// [XID] // 0x0000000189B987C0-0x0000000189B987E0
		public static void CompressToMultiChannelFileImage(float[,,] input, string imageName, TextureFormat imageStorageFormat = TextureFormat.RGBA32 /* Metadata: 0x00AE576E */, bool exportPNG = true /* Metadata: 0x00AE5772 */, bool exportJPG = true /* Metadata: 0x00AE5773 */) {} // 0x0000000185A43C60-0x0000000185A440A0
		// [XID] // 0x0000000189B9FCC0-0x0000000189B9FCE0
		public static float[,] ConvertTextureToArray(Texture2D texture) => default; // 0x0000000185A442F0-0x0000000185A444B0
		// [XID] // 0x0000000189BA7510-0x0000000189BA7530
		public static float[,] DecompressFromSingleChannelFileImage(string fileName, int width, int height, TextureFormat imageStorageFormat = TextureFormat.RGBA32 /* Metadata: 0x00AE5774 */, bool channelR = true /* Metadata: 0x00AE5778 */, bool channelG = false /* Metadata: 0x00AE5779 */, bool channelB = false /* Metadata: 0x00AE577A */, bool channelA = false /* Metadata: 0x00AE577B */) => default; // 0x0000000185A44D20-0x0000000185A44FD0
		// [XID] // 0x00000001898A4BC0-0x00000001898A4BE0
		public static float[,] DecompressFromSingleChannelTexture(Texture2D importTexture, bool channelR = true /* Metadata: 0x00AE577C */, bool channelG = false /* Metadata: 0x00AE577D */, bool channelB = false /* Metadata: 0x00AE577E */, bool channelA = false /* Metadata: 0x00AE577F */) => default; // 0x0000000185A44FD0-0x0000000185A45440
		// [XID] // 0x000000018973D710-0x000000018973D730
		public static void ExportJPG(string fileName, Texture2D texture) {} // 0x0000000185A45440-0x0000000185A45540
		// [XID] // 0x0000000189BBD4B0-0x0000000189BBD4D0
		public static void ExportPNG(string fileName, Texture2D texture) {} // 0x0000000185A45540-0x0000000185A45640
		// [XID] // 0x00000001897423E0-0x0000000189742400
		public static float[,] LoadRawFile(string fileName) => default; // 0x0000000185A47050-0x0000000185A473C0
		// [XID] // 0x0000000189BCCC00-0x0000000189BCCC20
		public static Mesh CreateMesh(float[,] heightmap, Vector3 targetSize) => default; // 0x0000000185A44540-0x0000000185A44D20
		// [XID] // 0x0000000189BD4290-0x0000000189BD42B0
		public static Bounds GetBounds(GameObject go) => default; // 0x0000000185A45C60-0x0000000185A45F30
		// [XID] // 0x0000000189BDBBE0-0x0000000189BDBC00
		private Vector3 Rotate90LeftXAxis(Vector3 input) => default; // 0x0000000185A48800-0x0000000185A48940
		// [XID] // 0x00000001895E8590-0x00000001895E85B0
		private Vector3 Rotate90RightXAxis(Vector3 input) => default; // 0x0000000185A48BC0-0x0000000185A48D00
		// [XID] // 0x00000001895EFD40-0x00000001895EFD60
		private Vector3 Rotate90LeftYAxis(Vector3 input) => default; // 0x0000000185A48940-0x0000000185A48A80
		// [XID] // 0x00000001895F76D0-0x00000001895F76F0
		private Vector3 Rotate90RightYAxis(Vector3 input) => default; // 0x0000000185A48D00-0x0000000185A48E40
		// [XID] // 0x000000018997C7D0-0x000000018997C7F0
		private Vector3 Rotate90LeftZAxis(Vector3 input) => default; // 0x0000000185A48A80-0x0000000185A48BC0
		// [XID] // 0x0000000189606490-0x00000001896064B0
		private Vector3 Rotate90RightZAxis(Vector3 input) => default; // 0x0000000185A48E40-0x0000000185A48F80
		// [IDTag] // 0x000000018960DD80-0x000000018960DDC0
		// [XID] // 0x000000018960DD80-0x000000018960DDC0
		public static bool Math_ApproximatelyEqual(float a, float b, float threshold) => default; // 0x0000000185A47560-0x0000000185A47680
		// [IDTag] // 0x00000001896181B0-0x00000001896181F0
		// [XID] // 0x00000001896181B0-0x00000001896181F0
		public static bool Math_ApproximatelyEqual(float a, float b) => default; // 0x0000000185A47680-0x0000000185A47750
		// [IDTag] // 0x0000000189622990-0x00000001896229D0
		// [XID] // 0x0000000189622990-0x00000001896229D0
		public static bool Math_ApproximatelyEqual(Vector3 a, Vector3 b, float threshold) => default; // 0x0000000185A47870-0x0000000185A479D0
		// [IDTag] // 0x000000018962D180-0x000000018962D1C0
		// [XID] // 0x000000018962D180-0x000000018962D1C0
		public static bool Math_ApproximatelyEqual(Vector3 a, Vector3 b) => default; // 0x0000000185A47750-0x0000000185A47870
		// [XID] // 0x0000000189A13C50-0x0000000189A13C70
		public static bool Math_IsPowerOf2(int value) => default; // 0x0000000185A48070-0x0000000185A48110
		// [XID] // 0x00000001897212B0-0x00000001897212D0
		public static float Math_Clamp(float min, float max, float value) => default; // 0x0000000185A479D0-0x0000000185A47AC0
		// [IDTag] // 0x00000001896469E0-0x0000000189646A20
		// [XID] // 0x00000001896469E0-0x0000000189646A20
		public static float Math_Modulo(float value, float mod) => default; // 0x0000000185A48200-0x0000000185A482D0
		// [IDTag] // 0x0000000189651120-0x0000000189651160
		// [XID] // 0x0000000189651120-0x0000000189651160
		public static int Math_Modulo(int value, int mod) => default; // 0x0000000185A48110-0x0000000185A48200
		// [XID] // 0x0000000189751350-0x0000000189751370
		public static float Math_InterpolateLinear(float value1, float value2, float fraction) => default; // 0x0000000185A47D30-0x0000000185A47E30
		// [XID] // 0x0000000189662EC0-0x0000000189662EE0
		public static float Math_InterpolateSmooth(float value1, float value2, float fraction) => default; // 0x0000000185A47F40-0x0000000185A48070
		// [XID] // 0x0000000189AD5FC0-0x0000000189AD5FE0
		public static float Math_Distance(float x1, float y1, float x2, float y2) => default; // 0x0000000185A47AC0-0x0000000185A47BE0
		// [XID] // 0x0000000189767760-0x0000000189767780
		public static float Math_InterpolateSmooth2(float v1, float v2, float fraction) => default; // 0x0000000185A47E30-0x0000000185A47F40
		// [XID] // 0x0000000189679FC0-0x0000000189679FE0
		public static float Math_InterpolateCubic(float v0, float v1, float v2, float v3, float fraction) => default; // 0x0000000185A47BE0-0x0000000185A47D30
		// [XID] // 0x00000001896816A0-0x00000001896816C0
		public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angle) => default; // 0x0000000185A48F80-0x0000000185A49200
		// [XID] // 0x0000000189842200-0x0000000189842220
		public static string FixFileName(string sourceFileName) => default; // 0x0000000185A45640-0x0000000185A457B0
		// [XID] // 0x00000001897333D0-0x00000001897333F0
		public static FileStream OpenRead(string path) => default; // 0x0000000185A482D0-0x0000000185A483B0
		// [XID] // 0x0000000189698550-0x0000000189698570
		public static string ReadAllText(string path) => default; // 0x0000000185A485D0-0x0000000185A48800
		// [XID] // 0x000000018969F8A0-0x000000018969F8C0
		public static void WriteAllText(string path, string contents) {} // 0x0000000185A49560-0x0000000185A497D0
		// [XID] // 0x00000001896A6B10-0x00000001896A6B30
		public static byte[] ReadAllBytes(string path) => default; // 0x0000000185A483B0-0x0000000185A485D0
		// [XID] // 0x000000018960CDC0-0x000000018960CDE0
		public static void WriteAllBytes(string path, byte[] bytes) {} // 0x0000000185A49410-0x0000000185A49560
		public static void CreateAsset<T>()
			where T : ScriptableObject {}
		// [IDTag] // 0x00000001896B5840-0x00000001896B5880
		// [XID] // 0x00000001896B5840-0x00000001896B5880
		public static string GetAssetPath(UnityEngine.Object uo) => default; // 0x0000000185A45870-0x0000000185A45920
		// [XID] // 0x00000001896BF810-0x00000001896BF830
		public static string WrapScriptableObject(ScriptableObject so) => default; // 0x0000000185A49360-0x0000000185A49410
		// [XID] // 0x00000001896C7230-0x00000001896C7250
		public static void UnwrapScriptableObject(string path, string newpath) {} // 0x0000000185A49200-0x0000000185A492B0
		// [XID] // 0x00000001896CE880-0x00000001896CE8A0
		public static string WrapGameObjectAsPrefab(GameObject go) => default; // 0x0000000185A492B0-0x0000000185A49360
		// [XID] // 0x00000001896D5C10-0x00000001896D5C30
		public static bool IsInLayerMask(GameObject obj, LayerMask mask) => default; // 0x0000000185A46B30-0x0000000185A46C20
		// [XID] // 0x00000001896DD140-0x00000001896DD160
		public static bool IsSameTexture(Texture2D tex1, Texture2D tex2, bool checkID = false /* Metadata: 0x00AE5780 */) => default; // 0x0000000185A46E00-0x0000000185A47050
		// [XID] // 0x0000000189B9C500-0x0000000189B9C520
		public static bool IsSameGameObject(GameObject go1, GameObject go2, bool checkID = false /* Metadata: 0x00AE5781 */) => default; // 0x0000000185A46C20-0x0000000185A46E00
		// [IDTag] // 0x00000001896EBFF0-0x00000001896EC030
		// [XID] // 0x00000001896EBFF0-0x00000001896EC030
		public static string GetAssetPath(string fileName) => default; // 0x0000000185A45920-0x0000000185A459D0
		// [IDTag] // 0x00000001896F6830-0x00000001896F6870
		// [XID] // 0x00000001896F6830-0x00000001896F6870
		public static string GetAssetPath(string name, string type) => default; // 0x0000000185A457B0-0x0000000185A45870
		// [XID] // 0x00000001899B7CD0-0x00000001899B7CF0
		public static GaiaSettings GetGaiaSettings() => default; // 0x0000000185A46310-0x0000000185A46440
		// [XID] // 0x0000000189A4FA80-0x0000000189A4FAA0
		public static UnityEngine.Object GetAsset(string fileNameOrPath, System.Type assetType) => default; // 0x0000000185A45BB0-0x0000000185A45C60
		// [XID] // 0x000000018970FE10-0x000000018970FE30
		public static GameObject GetAssetPrefab(string name) => default; // 0x0000000185A459D0-0x0000000185A45A70
		// [XID] // 0x0000000189716FC0-0x0000000189716FE0
		public static ScriptableObject GetAssetScriptableObject(string name) => default; // 0x0000000185A45A70-0x0000000185A45B10
		// [XID] // 0x000000018971E980-0x000000018971E9A0
		public static Texture2D GetAssetTexture2D(string name) => default; // 0x0000000185A45B10-0x0000000185A45BB0
		// [XID] // 0x0000000189726120-0x0000000189726140
		public static System.Type GetType(string TypeName) => default; // 0x0000000185A46820-0x0000000185A46B30
	}
}
