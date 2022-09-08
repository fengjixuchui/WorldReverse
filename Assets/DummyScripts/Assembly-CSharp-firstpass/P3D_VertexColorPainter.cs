/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class P3D_VertexColorPainter : ScriptableObject // TypeDefIndex: 9446
{
	// Fields
	public List<Color> colors; // 0x18
	public Mesh mesh; // 0x20
	private bool isTemporaryDisabled; // 0x28

	// Properties
	private static bool isSubtractColor { get => default; } // 0x0000000186015450-0x00000001860154D0 

	// Constructors
	public P3D_VertexColorPainter() {} // 0x00000001860153F0-0x0000000186015450

	// Methods
	public void SetMesh(Mesh newMesh) {} // 0x0000000186014400-0x0000000186014640
	private bool NeedResetMesh(Mesh newMesh) => default; // 0x0000000186013380-0x00000001860134E0
	public void SetMeshVertexColorEnabled(bool isEnabled) {} // 0x0000000186014340-0x0000000186014400
	public void UpdateMeshFromColors() {} // 0x0000000186015330-0x00000001860153F0
	public void ResetColor(Color color) {} // 0x0000000186013F60-0x00000001860140A0
	public void Paint(P3D_VertexColorBrush brush, List<P3D_Result> results, P3D_VertexColorPaintMode mode) {} // 0x00000001860134E0-0x0000000186013760
	public void Paint(P3D_VertexColorBrush brush, HashSet<P3D_Vertex> vertices, P3D_VertexColorPaintMode mode) {} // 0x0000000186013760-0x00000001860139C0
	private bool IsChannelOperation(P3D_VertexColorPaintMode mode, out int channel) {
		channel = default;
		return default;
	} // 0x00000001860132E0-0x0000000186013380
	private Dictionary<int, float> GetInfluencedVertexDistances(List<P3D_Result> results) => default; // 0x0000000186012E40-0x0000000186013090
	private static void SafeAdd(Dictionary<int, float> dict, int key, float value) {} // 0x00000001860140A0-0x0000000186014340
	private HashSet<int> GetInfluencedVertices(List<P3D_Result> results) => default; // 0x0000000186013090-0x00000001860132E0
	private void ReplaceColor(P3D_VertexColorBrush brush, Dictionary<int, float> vertexDistances) {} // 0x0000000186013CB0-0x0000000186013F60
	private void ReplaceColor(P3D_VertexColorBrush brush, Dictionary<int, float> vertexDistances, int channel) {} // 0x00000001860139C0-0x0000000186013CB0
	private void AddColor(P3D_VertexColorBrush brush, Dictionary<int, float> vertexDistances) {} // 0x00000001860122E0-0x0000000186012610
	private void AddColor(P3D_VertexColorBrush brush, Dictionary<int, float> vertexDistances, int channel) {} // 0x0000000186012610-0x0000000186012930
	private void SubtractColor(P3D_VertexColorBrush brush, Dictionary<int, float> vertexDistances) {} // 0x0000000186015080-0x0000000186015330
	private void SubtractColor(P3D_VertexColorBrush brush, Dictionary<int, float> vertexDistances, int channel) {} // 0x0000000186014D00-0x0000000186015080
	private void SmoothColor(P3D_VertexColorBrush brush, ICollection<int> vertices) {} // 0x00000001860149E0-0x0000000186014D00
	private void SmoothColor(P3D_VertexColorBrush brush, ICollection<int> vertices, int channel) {} // 0x0000000186014640-0x00000001860149E0
	private ICollection<Color> GetColors(ICollection<int> vertices) => default; // 0x0000000186012930-0x0000000186012BA0
	private ICollection<float> GetColors(ICollection<int> vertices, int channel) => default; // 0x0000000186012BA0-0x0000000186012E40
}

