/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class P3D_Helper // TypeDefIndex: 9430
{
	// Fields
	public const string ComponentMenuPrefix = "Paint in 3D/P3D "; // Metadata: 0x00AE58A4
	private static UnityEngine.Material clearMaterial; // 0x00

	// Properties
	public static UnityEngine.Material ClearMaterial { get; } // 0x0000000187235AE0-0x0000000187235CF0 

	// Methods
	public static TextureFormat GetTextureFormat(P3D_Format format) => default; // 0x00000001872347D0-0x0000000187234850
	public static bool IndexInMask(int index, LayerMask mask) => default; // 0x00000001872349B0-0x0000000187234A50
	public static Texture2D CreateTexture(int width, int height, TextureFormat format, bool mipMaps) => default; // 0x0000000187233A00-0x0000000187233AC0
	public static void ClearTexture(Texture2D texture2D, Color color, bool apply = true /* Metadata: 0x00AE588E */) {} // 0x0000000187231C40-0x0000000187231D90
	public static Mesh GetMesh(GameObject gameObject, ref Mesh bakedMesh) => default; // 0x0000000187234580-0x00000001872347D0
	private static void DestroyMesh(ref Mesh mesh) {} // 0x0000000187233E40-0x0000000187233EF0
	public static UnityEngine.Material GetMaterial(GameObject gameObject, int materialIndex = 0 /* Metadata: 0x00AE588F */) => default; // 0x0000000187234440-0x0000000187234580
	public static UnityEngine.Material CloneMaterial(GameObject gameObject, int materialIndex = 0 /* Metadata: 0x00AE5893 */) => default; // 0x0000000187231D90-0x0000000187231F40
	public static UnityEngine.Material AddMaterial(Renderer renderer, Shader shader, int materialIndex = -1 /* Metadata: 0x00AE5897 */) => default; // 0x0000000187231760-0x00000001872318D0
	public static Rect SplitHorizontal(ref Rect rect, int separation) => default; // 0x00000001872357F0-0x0000000187235930
	public static Rect SplitVertical(ref Rect rect, int separation) => default; // 0x0000000187235930-0x0000000187235A70
	public static bool Zero(float v) => default; // 0x0000000187235A70-0x0000000187235AE0
	public static float Divide(float a, float b) => default; // 0x00000001872340D0-0x00000001872341A0
	public static float Reciprocal(float a) => default; // 0x0000000187235720-0x00000001872357F0
	public static float GetUniformScale(Transform transform) => default; // 0x0000000187234900-0x00000001872349B0
	public static Vector2 GetUV(RaycastHit hit, P3D_CoordType coord) => default; // 0x0000000187234850-0x0000000187234900
	public static float DampenFactor(float dampening, float elapsed) => default; // 0x0000000187233C60-0x0000000187233D20
	public static Vector2 CalculatePixelFromCoord(Vector2 uv, Vector2 tiling, Vector2 offset, int width, int height) => default; // 0x0000000187231AA0-0x0000000187231C40
	public static P3D_Matrix CreateMatrix(Vector2 position, Vector2 size, float angle) => default; // 0x00000001872336D0-0x0000000187233A00
	public static float Dampen(float current, float target, float dampening, float elapsed, float minStep = 0f /* Metadata: 0x00AE589B */) => default; // 0x0000000187233D20-0x0000000187233E40
	public static Vector3 Dampen3(Vector3 current, Vector3 target, float dampening, float elapsed, float minStep = 0f /* Metadata: 0x00AE589F */) => default; // 0x0000000187233AC0-0x0000000187233C60
	public static T Destroy<T>(T o)
		where T : UnityEngine.Object => default;
	public static bool IntersectBarycentric(Vector3 start, Vector3 end, P3D_Triangle triangle, out Vector3 weights, out float distance01) {
		weights = default;
		distance01 = default;
		return default;
	} // 0x0000000187234A50-0x0000000187234EB0
	public static float ClosestBarycentric(Vector3 point, P3D_Triangle triangle, out Vector3 weights) {
		weights = default;
		return default;
	} // 0x0000000187232A50-0x00000001872336D0
	public static bool ClosestBarycentric(Vector3 point, P3D_Triangle triangle, ref Vector3 weights, ref float distanceSqr) => default; // 0x00000001872320D0-0x0000000187232A50
	public static bool IntersectSphere(Vector3 point, float radius, P3D_Triangle triangle, out Vector3 distancesToCenter01) {
		distancesToCenter01 = default;
		return default;
	} // 0x0000000187234EB0-0x0000000187235140
	public static float ClosestBarycentric(Vector2 point, Vector2 start, Vector2 end) => default; // 0x0000000187231F40-0x00000001872320D0
	public static bool PointLeftOfLine(Vector2 a, Vector2 b, Vector2 p) => default; // 0x00000001872351C0-0x0000000187235270
	public static bool PointRightOfLine(Vector2 a, Vector2 b, Vector2 p) => default; // 0x0000000187235270-0x0000000187235320
	public static bool FrontIntersect(Ray ray, P3D_Triangle triangle, out Vector3 intersection) {
		intersection = default;
		return default;
	} // 0x00000001872341A0-0x0000000187234440
	public static Vector3 BarycentricWeight(Vector3 point, P3D_Triangle triangle) => default; // 0x00000001872318D0-0x0000000187231AA0
	public static float Distance(Vector3 linePoint, Vector3 lineDirection, Vector3 point) => default; // 0x0000000187233EF0-0x00000001872340D0
	public static bool ProbablyIntersect(Bounds bounds, Ray ray, float radius) => default; // 0x0000000187235490-0x0000000187235720
	public static bool ProbablyIntersect(Bounds bounds, Vector3 point, float radius) => default; // 0x0000000187235320-0x0000000187235490
	public static T Clone<T>(T o, bool keepName = true /* Metadata: 0x00AE58A3 */)
		where T : UnityEngine.Object => default;
	public static bool IsWritableFormat(TextureFormat format) => default; // 0x0000000187235140-0x00000001872351C0
}

