/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class DebugExtension // TypeDefIndex: 8549
{
	// Methods
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugPoint(Vector3 position, Color color, float scale = 1f /* Metadata: 0x00ADFA3C */, float duration = 0f /* Metadata: 0x00ADFA40 */, bool depthTest = true /* Metadata: 0x00ADFA44 */) {} // 0x0000000187580D80-0x00000001875811F0
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugPoint(Vector3 position, float scale = 1f /* Metadata: 0x00ADFA45 */, float duration = 0f /* Metadata: 0x00ADFA49 */, bool depthTest = true /* Metadata: 0x00ADFA4D */) {} // 0x0000000187580C90-0x0000000187580D80
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugBounds(Bounds bounds, Color color, float duration = 0f /* Metadata: 0x00ADFA4E */, bool depthTest = true /* Metadata: 0x00ADFA52 */) {} // 0x000000018757AC90-0x000000018757B520
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugBounds(Bounds bounds, float duration = 0f /* Metadata: 0x00ADFA53 */, bool depthTest = true /* Metadata: 0x00ADFA57 */) {} // 0x000000018757B520-0x000000018757B600
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugLocalCube(Transform transform, Vector3 size, Color color, Vector3 center = default, float duration = 0f /* Metadata: 0x00ADFA58 */, bool depthTest = true /* Metadata: 0x00ADFA5C */) {} // 0x0000000187580160-0x0000000187580C90
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugLocalCube(Transform transform, Vector3 size, Vector3 center = default, float duration = 0f /* Metadata: 0x00ADFA5D */, bool depthTest = true /* Metadata: 0x00ADFA61 */) {} // 0x000000018757FF10-0x0000000187580020
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugLocalCube(Matrix4x4 space, Vector3 size, Color color, Vector3 center = default, float duration = 0f /* Metadata: 0x00ADFA62 */, bool depthTest = true /* Metadata: 0x00ADFA66 */) {} // 0x000000018757F390-0x000000018757FF10
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugLocalCube(Matrix4x4 space, Vector3 size, Vector3 center = default, float duration = 0f /* Metadata: 0x00ADFA67 */, bool depthTest = true /* Metadata: 0x00ADFA6B */) {} // 0x0000000187580020-0x0000000187580160
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugCircle(Vector3 position, Vector3 up, Color color, float radius = 1f /* Metadata: 0x00ADFA6C */, float duration = 0f /* Metadata: 0x00ADFA70 */, bool depthTest = true /* Metadata: 0x00ADFA74 */) {} // 0x000000018757D0A0-0x000000018757D740
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugCircle(Vector3 position, Color color, float radius = 1f /* Metadata: 0x00ADFA75 */, float duration = 0f /* Metadata: 0x00ADFA79 */, bool depthTest = true /* Metadata: 0x00ADFA7D */) {} // 0x000000018757D740-0x000000018757D870
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugCircle(Vector3 position, Vector3 up, float radius = 1f /* Metadata: 0x00ADFA7E */, float duration = 0f /* Metadata: 0x00ADFA82 */, bool depthTest = true /* Metadata: 0x00ADFA86 */) {} // 0x000000018757D870-0x000000018757D980
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugCircle(Vector3 position, float radius = 1f /* Metadata: 0x00ADFA87 */, float duration = 0f /* Metadata: 0x00ADFA8B */, bool depthTest = true /* Metadata: 0x00ADFA8F */) {} // 0x000000018757D980-0x000000018757DAC0
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugWireSphere(Vector3 position, Color color, float radius = 1f /* Metadata: 0x00ADFA90 */, float duration = 0f /* Metadata: 0x00ADFA94 */, bool depthTest = true /* Metadata: 0x00ADFA98 */) {} // 0x00000001875812E0-0x0000000187581700
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugWireSphere(Vector3 position, float radius = 1f /* Metadata: 0x00ADFA99 */, float duration = 0f /* Metadata: 0x00ADFA9D */, bool depthTest = true /* Metadata: 0x00ADFAA1 */) {} // 0x00000001875811F0-0x00000001875812E0
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugCylinder(Vector3 start, Vector3 end, Color color, float radius = 1f /* Metadata: 0x00ADFAA2 */, float duration = 0f /* Metadata: 0x00ADFAA6 */, bool depthTest = true /* Metadata: 0x00ADFAAA */) {} // 0x000000018757E880-0x000000018757F280
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugCylinder(Vector3 start, Vector3 end, float radius = 1f /* Metadata: 0x00ADFAAB */, float duration = 0f /* Metadata: 0x00ADFAAF */, bool depthTest = true /* Metadata: 0x00ADFAB3 */) {} // 0x000000018757F280-0x000000018757F390
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugCone(Vector3 position, Vector3 direction, Color color, float angle = 45f /* Metadata: 0x00ADFAB4 */, float duration = 0f /* Metadata: 0x00ADFAB8 */, bool depthTest = true /* Metadata: 0x00ADFABC */) {} // 0x000000018757DBD0-0x000000018757E610
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugCone(Vector3 position, Vector3 direction, float angle = 45f /* Metadata: 0x00ADFABD */, float duration = 0f /* Metadata: 0x00ADFAC1 */, bool depthTest = true /* Metadata: 0x00ADFAC5 */) {} // 0x000000018757DAC0-0x000000018757DBD0
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugCone(Vector3 position, Color color, float angle = 45f /* Metadata: 0x00ADFAC6 */, float duration = 0f /* Metadata: 0x00ADFACA */, bool depthTest = true /* Metadata: 0x00ADFACE */) {} // 0x000000018757E750-0x000000018757E880
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugCone(Vector3 position, float angle = 45f /* Metadata: 0x00ADFACF */, float duration = 0f /* Metadata: 0x00ADFAD3 */, bool depthTest = true /* Metadata: 0x00ADFAD7 */) {} // 0x000000018757E610-0x000000018757E750
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugArrow(Vector3 position, Vector3 direction, Color color, float duration = 0f /* Metadata: 0x00ADFAD8 */, bool depthTest = true /* Metadata: 0x00ADFADC */) {} // 0x000000018757AA50-0x000000018757AC90
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugArrow(Vector3 position, Vector3 direction, float duration = 0f /* Metadata: 0x00ADFADD */, bool depthTest = true /* Metadata: 0x00ADFAE1 */) {} // 0x000000018757A950-0x000000018757AA50
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugCapsule(Vector3 start, Vector3 end, Color color, float radius = 1f /* Metadata: 0x00ADFAE2 */, float duration = 0f /* Metadata: 0x00ADFAE6 */, bool depthTest = true /* Metadata: 0x00ADFAEA */) {} // 0x000000018757B600-0x000000018757CF90
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DebugCapsule(Vector3 start, Vector3 end, float radius = 1f /* Metadata: 0x00ADFAEB */, float duration = 0f /* Metadata: 0x00ADFAEF */, bool depthTest = true /* Metadata: 0x00ADFAF3 */) {} // 0x000000018757CF90-0x000000018757D0A0
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawPoint(Vector3 position, Color color, float scale = 1f /* Metadata: 0x00ADFAF4 */) {} // 0x00000001875870C0-0x00000001875874A0
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawPoint(Vector3 position, float scale = 1f /* Metadata: 0x00ADFAF8 */) {} // 0x00000001875874A0-0x0000000187587560
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawBounds(Bounds bounds, Color color) {} // 0x00000001875819F0-0x0000000187582140
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawBounds(Bounds bounds) {} // 0x0000000187582140-0x00000001875821F0
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawLocalCube(Transform transform, Vector3 size, Color color, Vector3 center = default) {} // 0x0000000187585D30-0x0000000187586700
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawLocalCube(Transform transform, Vector3 size, Vector3 center = default) {} // 0x0000000187585B30-0x0000000187585C10
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawLocalCube(Matrix4x4 space, Vector3 size, Color color, Vector3 center = default) {} // 0x0000000187586700-0x00000001875870C0
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawLocalCube(Matrix4x4 space, Vector3 size, Vector3 center = default) {} // 0x0000000187585C10-0x0000000187585D30
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawCircle(Vector3 position, Vector3 up, Color color, float radius = 1f /* Metadata: 0x00ADFAFC */) {} // 0x0000000187583B40-0x0000000187584220
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawCircle(Vector3 position, Color color, float radius = 1f /* Metadata: 0x00ADFB00 */) {} // 0x0000000187584220-0x0000000187584330
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawCircle(Vector3 position, Vector3 up, float radius = 1f /* Metadata: 0x00ADFB04 */) {} // 0x0000000187584330-0x0000000187584420
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawCircle(Vector3 position, float radius = 1f /* Metadata: 0x00ADFB08 */) {} // 0x0000000187583A20-0x0000000187583B40
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawCylinder(Vector3 start, Vector3 end, Color color, float radius = 1f /* Metadata: 0x00ADFB0C */) {} // 0x0000000187585220-0x0000000187585B30
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawCylinder(Vector3 start, Vector3 end, float radius = 1f /* Metadata: 0x00ADFB10 */) {} // 0x0000000187585120-0x0000000187585220
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawCone(Vector3 position, Vector3 direction, Color color, float angle = 45f /* Metadata: 0x00ADFB14 */) {} // 0x0000000187584520-0x0000000187584EF0
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawCone(Vector3 position, Vector3 direction, float angle = 45f /* Metadata: 0x00ADFB18 */) {} // 0x0000000187584420-0x0000000187584520
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawCone(Vector3 position, Color color, float angle = 45f /* Metadata: 0x00ADFB1C */) {} // 0x0000000187585010-0x0000000187585120
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawCone(Vector3 position, float angle = 45f /* Metadata: 0x00ADFB20 */) {} // 0x0000000187584EF0-0x0000000187585010
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawArrow(Vector3 position, Vector3 direction, Color color) {} // 0x00000001875817F0-0x00000001875819F0
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawArrow(Vector3 position, Vector3 direction) {} // 0x0000000187581700-0x00000001875817F0
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawCapsule(Vector3 start, Vector3 end, Color color, float radius = 1f /* Metadata: 0x00ADFB24 */) {} // 0x00000001875822F0-0x0000000187583A20
	// [Conditional] // 0x00000001899D6B40-0x00000001899D6B70
	public static void DrawCapsule(Vector3 start, Vector3 end, float radius = 1f /* Metadata: 0x00ADFB28 */) {} // 0x00000001875821F0-0x00000001875822F0
	public static string MethodsOfObject(object obj, bool includeInfo = false /* Metadata: 0x00ADFB2C */) => default; // 0x0000000187587560-0x0000000187587720
	public static string MethodsOfType(System.Type type, bool includeInfo = false /* Metadata: 0x00ADFB2D */) => default; // 0x0000000187587720-0x00000001875878D0
}

